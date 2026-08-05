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
	[Cpp2IlInjected.Address(RVA = "0x67F54B0", Offset = "0x67F3EB0", VA = "0x1867F54B0")]
	public BOFEHLDLNAG(ThreadPriority GDGIBBJCIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67F54A0", Offset = "0x67F3EA0", VA = "0x1867F54A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x680B030", Offset = "0x6809A30", VA = "0x18680B030")]
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
				[Cpp2IlInjected.Address(RVA = "0x68046B0", Offset = "0x68030B0", VA = "0x1868046B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6801C90", Offset = "0x6800690", VA = "0x186801C90")]
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
				[Cpp2IlInjected.Address(RVA = "0x6801760", Offset = "0x6800160", VA = "0x186801760")]
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
				[Cpp2IlInjected.Address(RVA = "0x6802270", Offset = "0x6800C70", VA = "0x186802270")]
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
				[Cpp2IlInjected.Address(RVA = "0x67FF9D0", Offset = "0x67FE3D0", VA = "0x1867FF9D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x67FC420", Offset = "0x67FAE20", VA = "0x1867FC420")]
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
				[Cpp2IlInjected.Address(RVA = "0x680ABE0", Offset = "0x68095E0", VA = "0x18680ABE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6801EF0", Offset = "0x68008F0", VA = "0x186801EF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x67F54F0", Offset = "0x67F3EF0", VA = "0x1867F54F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x680AE30", Offset = "0x6809830", VA = "0x18680AE30")]
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
				[Cpp2IlInjected.Address(RVA = "0x67FB510", Offset = "0x67F9F10", VA = "0x1867FB510")]
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
					[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
					public PGGOLPHGEFM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x680CDA0", Offset = "0x680B7A0", VA = "0x18680CDA0")]
					internal void PHBCFPLKFNA()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static PFEKNBHDJHH<NKJBGADCILE> APMCPFCJBFA;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6801A50", Offset = "0x6800450", VA = "0x186801A50")]
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
					[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
					public KLPCFMNNPHG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6806260", Offset = "0x6804C60", VA = "0x186806260")]
					internal void BMHAJCHNJJD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable FLPBMNOMAPF;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x67F3BF0", Offset = "0x67F25F0", VA = "0x1867F3BF0")]
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
					[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
					public BALPAGCIGDE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x67F4510", Offset = "0x67F2F10", VA = "0x1867F4510")]
					internal void BMHAJCHNJJD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x67FF130", Offset = "0x67FDB30", VA = "0x1867FF130")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
			public FPCBFNADCDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67FF010", Offset = "0x67FDA10", VA = "0x1867FF010")]
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
			[Cpp2IlInjected.Address(RVA = "0x67F5E80", Offset = "0x67F4880", VA = "0x1867F5E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67F6D30", Offset = "0x67F5730", VA = "0x1867F6D30")]
		private static void JFIFFEEILBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67F5EC0", Offset = "0x67F48C0", VA = "0x1867F5EC0")]
		private static void FBDAGDGMAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67F5C50", Offset = "0x67F4650", VA = "0x1867F5C50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67F6790", Offset = "0x67F5190", VA = "0x1867F6790")]
		private static void FBEDKNGMKEO(KNGOKFOKDCJ.POILCKPKGNE KCGLPAPOILB, PlayerLoopSystem ILNJPBLHBPP, Type LIDHKKEFFIK, Type HBIIGBPICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x67F6950", Offset = "0x67F5350", VA = "0x1867F6950")]
		private static void HKCEEGCLDFN(PlayerLoopSystem ILNJPBLHBPP, Type LIDHKKEFFIK, Type HBIIGBPICEJ, JBOJBANNMDJ MLLOBPABEOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67F9660", Offset = "0x67F8060", VA = "0x1867F9660")]
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
		[Cpp2IlInjected.Address(RVA = "0x67F2D70", Offset = "0x67F1770", VA = "0x1867F2D70")]
		public AIGJCFECELI(POILCKPKGNE HLLHGJLACLE, int BGBDPOKCFCM = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67F2AD0", Offset = "0x67F14D0", VA = "0x1867F2AD0")]
		public void CIIMPNMONBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x67F2B40", Offset = "0x67F1540", VA = "0x1867F2B40")]
		public void GGIGLMBINHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67F2B90", Offset = "0x67F1590", VA = "0x1867F2B90")]
		public void HIAHNABLCLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static POILCKPKGNE[] MOLOIFGLANE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AIGJCFECELI[] NELOJEALGJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6806540", Offset = "0x6804F40", VA = "0x186806540")]
	public static AIGJCFECELI KPOAGHFJGFE(POILCKPKGNE KCGLPAPOILB, int BGBDPOKCFCM = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6806720", Offset = "0x6805120", VA = "0x186806720")]
	public static AIGJCFECELI NDNFHBFOJDN(POILCKPKGNE KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68064A0", Offset = "0x6804EA0", VA = "0x1868064A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x680A940", Offset = "0x6809340", VA = "0x18680A940", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KCCLJGCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1779640", Offset = "0x1778040", VA = "0x181779640", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BBIBAANHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D30580", Offset = "0x1D2EF80", VA = "0x181D30580", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x680AB30", Offset = "0x6809530", VA = "0x18680AB30")]
	public NPMFMMODMKC(int FFPJHIEILCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x680A9A0", Offset = "0x68093A0", VA = "0x18680A9A0", Slot = "7")]
	public void BAMIJHPGHBK(double HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x680AAC0", Offset = "0x68094C0", VA = "0x18680AAC0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KCCLJGCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x55CF6E0", Offset = "0x55CE0E0", VA = "0x1855CF6E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BBIBAANHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x55CF6C0", Offset = "0x55CE0C0", VA = "0x1855CF6C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MBHPHHGJHII
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x55CF6B0", Offset = "0x55CE0B0", VA = "0x1855CF6B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double CDNHGFHLBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x21E75F0", Offset = "0x21E5FF0", VA = "0x1821E75F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x680BB40", Offset = "0x680A540", VA = "0x18680BB40", Slot = "7")]
	public virtual void BAMIJHPGHBK(double HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x680BC60", Offset = "0x680A660", VA = "0x18680BC60", Slot = "8")]
	public virtual void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67F5920", Offset = "0x67F4320", VA = "0x1867F5920")]
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
		[Cpp2IlInjected.Address(RVA = "0x55CF700", Offset = "0x55CE100", VA = "0x1855CF700")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x55CF750", Offset = "0x55CE150", VA = "0x1855CF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67F57B0", Offset = "0x67F41B0", VA = "0x1867F57B0", Slot = "7")]
	public override void BAMIJHPGHBK(double HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67F58E0", Offset = "0x67F42E0", VA = "0x1867F58E0", Slot = "8")]
	public override void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67F5920", Offset = "0x67F4320", VA = "0x1867F5920")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B9EF30", Offset = "0x3B9D930", VA = "0x183B9EF30")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OPJFHELDCAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3B9EF90", Offset = "0x3B9D990", VA = "0x183B9EF90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B0130", Offset = "0x7AEB30", VA = "0x1807B0130")]
		protected LMKHEAOICFN(TPromise KAOFPHMICPN, TMainThreadPromise JIIPKKGMNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3B9EFE0", Offset = "0x3B9D9E0", VA = "0x183B9EFE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3210740", Offset = "0x320F140", VA = "0x183210740")]
		public EFPIPMBMFFP(JMGBCNAMNAH<T> KAOFPHMICPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3210530", Offset = "0x320EF30", VA = "0x183210530", Slot = "6")]
		protected override void GNOKDEBNCLD(JMGBCNAMNAH<T> KAOFPHMICPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x32104D0", Offset = "0x320EED0", VA = "0x1832104D0")]
		[CompilerGenerated]
		private void EKCLFHDPIML(T MNKBHKEBOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3210500", Offset = "0x320EF00", VA = "0x183210500")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
		public LECJFNDNFIB(Action MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB9A8F0", Offset = "0xB992F0", VA = "0x180B9A8F0", Slot = "5")]
		public void LAAAOIHLIFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<KAAKGOJBBEF> HPKAGDHPLKH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x275BD00", Offset = "0x275A700", VA = "0x18275BD00")]
	public static JMGBCNAMNAH<T> KAAPPLMKNGB<T>(this JMGBCNAMNAH<T> KAOFPHMICPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6809FB0", Offset = "0x68089B0", VA = "0x186809FB0")]
	public static void KAAPPLMKNGB(Action MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x275BC40", Offset = "0x275A640", VA = "0x18275BC40")]
	private static JMGBCNAMNAH<T> ENDOGGANMAF<T>(JMGBCNAMNAH<T> KAOFPHMICPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6809DA0", Offset = "0x68087A0", VA = "0x186809DA0")]
	private static void JJDCMFIHHJC(KAAKGOJBBEF NKEDMHLLGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x680A050", Offset = "0x6808A50", VA = "0x18680A050")]
	private static void NDOKLFJOKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6809BC0", Offset = "0x68085C0", VA = "0x186809BC0")]
	private static void CCMHJIOGOEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6809CC0", Offset = "0x68086C0", VA = "0x186809CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67F4780", Offset = "0x67F3180", VA = "0x1867F4780")]
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
		[Cpp2IlInjected.Address(RVA = "0x680B230", Offset = "0x6809C30", VA = "0x18680B230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x680BAD0", Offset = "0x680A4D0", VA = "0x18680BAD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67F5120", Offset = "0x67F3B20", VA = "0x1867F5120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67F5440", Offset = "0x67F3E40", VA = "0x1867F5440", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6806D50", Offset = "0x6805750", VA = "0x186806D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6807100", Offset = "0x6805B00", VA = "0x186807100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public HIJOCALEAMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6801E90", Offset = "0x6800890", VA = "0x186801E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x68029C0", Offset = "0x68013C0", VA = "0x1868029C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6803560", Offset = "0x6801F60", VA = "0x186803560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x680A3C0", Offset = "0x6808DC0", VA = "0x18680A3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x680A8D0", Offset = "0x68092D0", VA = "0x18680A8D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6809000", Offset = "0x6807A00", VA = "0x186809000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6809B50", Offset = "0x6808550", VA = "0x186809B50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public JGLFJDJHAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6804170", Offset = "0x6802B70", VA = "0x186804170")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public DCKBBMPIPGL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x67FB480", Offset = "0x67F9E80", VA = "0x1867FB480", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x67FB0F0", Offset = "0x67F9AF0", VA = "0x1867FB0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x67FB0A0", Offset = "0x67F9AA0", VA = "0x1867FB0A0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x67FB430", Offset = "0x67F9E30", VA = "0x1867FB430", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public CMGBEGOBHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x67F5BD0", Offset = "0x67F45D0", VA = "0x1867F5BD0")]
		internal bool JBNOCOHPFOG(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x67F5950", Offset = "0x67F4350", VA = "0x1867F5950")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public LONIGOKHALP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x68088A0", Offset = "0x68072A0", VA = "0x1868088A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6808FB0", Offset = "0x68079B0", VA = "0x186808FB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x67F9AF0", Offset = "0x67F84F0", VA = "0x1867F9AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool CPMHMGMAJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67FAD20", Offset = "0x67F9720", VA = "0x1867FAD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool GIKHCMDBMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67FA890", Offset = "0x67F9290", VA = "0x1867FA890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MIJLPFKLFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67FA130", Offset = "0x67F8B30", VA = "0x1867FA130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BALGHEPEICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x67FA270", Offset = "0x67F8C70", VA = "0x1867FA270")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67F9D10", Offset = "0x67F8710", VA = "0x1867F9D10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67FA660", Offset = "0x67F9060", VA = "0x1867FA660")]
	[LHNJPKEFJFF(KMDAJMKLPFP.EnteredEditModeNextFrame, 0)]
	private static void KBIDHAMCLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67F9790", Offset = "0x67F8190", VA = "0x1867F9790")]
	[AsyncStateMachine(typeof(OLALDNAHNLO))]
	public static Task<Scene> AIGPJKDEJCN(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP = LoadSceneMode.Single, bool OAOJJHJJHNM = false, [Optional] NKOLFLIKMKN<string>.JNCJJIKLGBC JGLNEJEEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x67FA1C0", Offset = "0x67F8BC0", VA = "0x1867FA1C0")]
	[AsyncStateMachine(typeof(BOBDMMMLKNP))]
	private static Task HEDOANBIIGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67F9F30", Offset = "0x67F8930", VA = "0x1867F9F30")]
	[AsyncStateMachine(typeof(LDGBDCIIKMM))]
	private static Task EEPPFJIKHFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67F99A0", Offset = "0x67F83A0", VA = "0x1867F99A0")]
	[AsyncStateMachine(typeof(JGJHAGANFME))]
	private static Task<Scene> BHCHLJINEGH(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP, bool OAOJJHJJHNM, NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67FA500", Offset = "0x67F8F00", VA = "0x1867FA500")]
	private static void JOJDCOBNHOL(SceneInstance CONPDDCOPOE, LoadSceneMode LFGFANLKJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67F98E0", Offset = "0x67F82E0", VA = "0x1867F98E0")]
	private static void AJMFOICKMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67FAC00", Offset = "0x67F9600", VA = "0x1867FAC00")]
	[AsyncStateMachine(typeof(NKLIICJHGKM))]
	private static Task<Scene> MOEKCJAOFEE(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67FADC0", Offset = "0x67F97C0", VA = "0x1867FADC0")]
	private static bool NEGBPOAPJNF(string DNOMIJHONBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67F9E20", Offset = "0x67F8820", VA = "0x1867F9E20")]
	[AsyncStateMachine(typeof(MBEDJCCEPLE))]
	private static Task<Scene> CKOJJAEDICA(NKOLFLIKMKN<string>.JNCJJIKLGBC MOBBOFLOFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67FA380", Offset = "0x67F8D80", VA = "0x1867FA380")]
	public static JMGBCNAMNAH<Scene> JEJFNNPEINA(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67FA930", Offset = "0x67F9330", VA = "0x1867FA930")]
	public static BCACLFKFPHI MKFLNBBCFIB(string DNOMIJHONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67FA0A0", Offset = "0x67F8AA0", VA = "0x1867FA0A0")]
	[IteratorStateMachine(typeof(DCKBBMPIPGL))]
	private static IEnumerator<FLFEOAPLLLI> GJKIOLNNJMN(string DNOMIJHONBC, LCADBCNGFBM HPAGJEKMNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x67FA000", Offset = "0x67F8A00", VA = "0x1867FA000")]
	[IteratorStateMachine(typeof(LONIGOKHALP))]
	private static IEnumerator<FLFEOAPLLLI> EKOADIFLBAL(string DNOMIJHONBC, LoadSceneMode LFGFANLKJDP, FPEMLHHDDKL<Scene> HPAGJEKMNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x67FA760", Offset = "0x67F9160", VA = "0x1867FA760")]
	public static bool LHEAABCCPLJ([Out] string NFEJFAJGLMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BFJNENALNBA
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67F5010", Offset = "0x67F3A10", VA = "0x1867F5010")]
	public static IDisposable GCHDHJJCFIP(this KBFCHONAOBJ PEHINKLIDNC, float JAPHMJICBGD, Action<float> NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67F50A0", Offset = "0x67F3AA0", VA = "0x1867F50A0")]
	public static IDisposable OOPDHCBNABO(this KBFCHONAOBJ PEHINKLIDNC, Action<float> NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67F4F90", Offset = "0x67F3990", VA = "0x1867F4F90")]
	public static IDisposable COKKBJNCMBH(this KBFCHONAOBJ PEHINKLIDNC, Action<float> NCPFGEDHINI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JGKPAKDCHHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6803F80", Offset = "0x6802980", VA = "0x186803F80")]
	public static IDisposable NJMCPDKGNBN(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6803EF0", Offset = "0x68028F0", VA = "0x186803EF0")]
	public static IDisposable NJMCPDKGNBN(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6803D30", Offset = "0x6802730", VA = "0x186803D30")]
	public static IDisposable JPBFJKJIHMJ(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6803B10", Offset = "0x6802510", VA = "0x186803B10")]
	public static IDisposable GOMIOHKPIIK(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6803A90", Offset = "0x6802490", VA = "0x186803A90")]
	public static IDisposable GOMIOHKPIIK(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6803710", Offset = "0x6802110", VA = "0x186803710")]
	public static IDisposable EFDEIJJMCBD(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6803B90", Offset = "0x6802590", VA = "0x186803B90")]
	public static IDisposable GPIEBECHJEB(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6803CB0", Offset = "0x68026B0", VA = "0x186803CB0")]
	public static IDisposable JJAHLLFJLLJ(this MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68040C0", Offset = "0x6802AC0", VA = "0x1868040C0")]
	public static IDisposable OJNMPIBKGLL(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6803830", Offset = "0x6802230", VA = "0x186803830")]
	public static IDisposable GJDAOLDIJIB(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6803790", Offset = "0x6802190", VA = "0x186803790")]
	public static IDisposable FBGKBIMLMDO(this MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6803E50", Offset = "0x6802850", VA = "0x186803E50")]
	public static IDisposable NJICMAGDOEA(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68035D0", Offset = "0x6801FD0", VA = "0x1868035D0")]
	public static IDisposable BBPBHFFMGLM(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6803DB0", Offset = "0x68027B0", VA = "0x186803DB0")]
	public static IDisposable NCDNGLNGOKH(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6803950", Offset = "0x6802350", VA = "0x186803950")]
	public static IDisposable GKBHIKEHANK(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6803670", Offset = "0x6802070", VA = "0x186803670")]
	public static IDisposable BOIFPJJBLFE(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68039F0", Offset = "0x68023F0", VA = "0x1868039F0")]
	public static IDisposable GKILAEBEDCN(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6803C10", Offset = "0x6802610", VA = "0x186803C10")]
	public static IDisposable JCABOANHBHM(this MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6804010", Offset = "0x6802A10", VA = "0x186804010")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public KFFPBOLANOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68048B0", Offset = "0x68032B0", VA = "0x1868048B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6804990", Offset = "0x6803390", VA = "0x186804990", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public ANKKENNODFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67F43D0", Offset = "0x67F2DD0", VA = "0x1867F43D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x67F44C0", Offset = "0x67F2EC0", VA = "0x1867F44C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6802590", Offset = "0x6800F90", VA = "0x186802590")]
	public static DHBMNMGGJAH NJMCPDKGNBN(Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6802640", Offset = "0x6801040", VA = "0x186802640")]
	public static DHBMNMGGJAH NJMCPDKGNBN(Behaviour PEHINKLIDNC, Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6802700", Offset = "0x6801100", VA = "0x186802700")]
	public static DHBMNMGGJAH NJMCPDKGNBN(Behaviour PEHINKLIDNC, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6802500", Offset = "0x6800F00", VA = "0x186802500")]
	[IteratorStateMachine(typeof(KFFPBOLANOB))]
	private static IEnumerator<FLFEOAPLLLI> AHIDEIBCGJN(JAAKDEGMLAI INJDPFHNFNL, Action NCPFGEDHINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6802470", Offset = "0x6800E70", VA = "0x186802470")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public LDMEHFMBEFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6807160", Offset = "0x6805B60", VA = "0x186807160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68071F0", Offset = "0x6805BF0", VA = "0x1868071F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9210", Offset = "0x7A7C10", VA = "0x1807A9210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6808790", Offset = "0x6807190", VA = "0x186808790")]
	public LKBGKHBPHNK(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6808670", Offset = "0x6807070", VA = "0x186808670")]
	[IteratorStateMachine(typeof(LDMEHFMBEFC))]
	private IEnumerator<FLFEOAPLLLI> BGCCPJHEMNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x68086F0", Offset = "0x68070F0", VA = "0x1868086F0", Slot = "4")]
	public void OnCompleted(Action AOPCEFBGAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	public void HIJKCFDBHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class IBEDIEIKCGH
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6802130", Offset = "0x6800B30", VA = "0x186802130")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public EBKKBBKLDFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67FC060", Offset = "0x67FAA60", VA = "0x1867FC060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67FC0E0", Offset = "0x67FAAE0", VA = "0x1867FC0E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6804CD0", Offset = "0x68036D0", VA = "0x186804CD0")]
	public static DHBMNMGGJAH NJMCPDKGNBN(float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6804BC0", Offset = "0x68035C0", VA = "0x186804BC0")]
	public static DHBMNMGGJAH NJMCPDKGNBN(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x68049E0", Offset = "0x68033E0", VA = "0x1868049E0")]
	public static DHBMNMGGJAH AEBCLFFOPDN(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6804DD0", Offset = "0x68037D0", VA = "0x186804DD0")]
	public static DHBMNMGGJAH OOJCFOHOKIP(KBFCHONAOBJ PEHINKLIDNC, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6804B00", Offset = "0x6803500", VA = "0x186804B00")]
	private static IEnumerator<FLFEOAPLLLI> AHIDEIBCGJN(MADGOMEGEEG NNGFOJMJBAK, float JAPHMJICBGD, JAAKDEGMLAI INJDPFHNFNL, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6804F70", Offset = "0x6803970", VA = "0x186804F70")]
	private static IEnumerator<FLFEOAPLLLI> POONHOPDFPD(MADGOMEGEEG NNGFOJMJBAK, float JAPHMJICBGD, JAAKDEGMLAI INJDPFHNFNL, Action<float> NCPFGEDHINI, bool ICNDMMFENED = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6804EE0", Offset = "0x68038E0", VA = "0x186804EE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public AFNPPLNBGAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67F29C0", Offset = "0x67F13C0", VA = "0x1867F29C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67F2A80", Offset = "0x67F1480", VA = "0x1867F2A80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x680BDC0", Offset = "0x680A7C0", VA = "0x18680BDC0")]
	[IteratorStateMachine(typeof(AFNPPLNBGAP))]
	private static IEnumerator<FLFEOAPLLLI> PLNEMPFONPA(JAAKDEGMLAI EGDEBJAGPAI, Func<bool> BMPNDHLKPNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x680BCA0", Offset = "0x680A6A0", VA = "0x18680BCA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public ECNKEMGGBIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x67FC130", Offset = "0x67FAB30", VA = "0x1867FC130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67FC1A0", Offset = "0x67FABA0", VA = "0x1867FC1A0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public GFFKHECJKIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6801680", Offset = "0x6800080", VA = "0x186801680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6801710", Offset = "0x6800110", VA = "0x186801710", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x680C550", Offset = "0x680AF50", VA = "0x18680C550")]
	[IteratorStateMachine(typeof(ECNKEMGGBIA))]
	private static IEnumerator<FLFEOAPLLLI> BGCCPJHEMNN(float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x680CD00", Offset = "0x680B700", VA = "0x18680CD00")]
	[IteratorStateMachine(typeof(GFFKHECJKIG))]
	private static IEnumerator<FLFEOAPLLLI> PKGFGDNAKIK(float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x680C9E0", Offset = "0x680B3E0", VA = "0x18680C9E0")]
	public static IDisposable KNNDCGAJGJB(this MonoBehaviour HBOAILJIBKK, float EDBFKNKJGAL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x680CB00", Offset = "0x680B500", VA = "0x18680CB00")]
	public static DHBMNMGGJAH MGGAHCOAHCN(this MonoBehaviour HBOAILJIBKK, float EDBFKNKJGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x680C8B0", Offset = "0x680B2B0", VA = "0x18680C8B0")]
	public static DHBMNMGGJAH KNNDCGAJGJB(this MonoBehaviour HBOAILJIBKK, float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x680C890", Offset = "0x680B290", VA = "0x18680C890")]
	public static DHBMNMGGJAH KIHMNKIKGPO(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x680C860", Offset = "0x680B260", VA = "0x18680C860")]
	public static DHBMNMGGJAH IMEKHOAECDM(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x680CBC0", Offset = "0x680B5C0", VA = "0x18680CBC0")]
	public static DHBMNMGGJAH OCELLGDMCBD(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x680CCA0", Offset = "0x680B6A0", VA = "0x18680CCA0")]
	public static DHBMNMGGJAH ONFANNGENML(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x680CCD0", Offset = "0x680B6D0", VA = "0x18680CCD0")]
	public static DHBMNMGGJAH PEPJINMJDAA(this MonoBehaviour HBOAILJIBKK, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x680C790", Offset = "0x680B190", VA = "0x18680C790")]
	private static DHBMNMGGJAH ENMHAFBIFGG(MonoBehaviour HBOAILJIBKK, JAAKDEGMLAI EGDEBJAGPAI, Action BINBFFLGBGL, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x680C480", Offset = "0x680AE80", VA = "0x18680C480")]
	public static DHBMNMGGJAH APNADLHCCFC(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x680C5F0", Offset = "0x680AFF0", VA = "0x18680C5F0")]
	public static DHBMNMGGJAH CPHNMCJDNBO(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x680C6C0", Offset = "0x680B0C0", VA = "0x18680C6C0")]
	public static DHBMNMGGJAH EIJIEJGJCLD(this MonoBehaviour HBOAILJIBKK, float BADOEALKKEF, Action BINBFFLGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x680C3B0", Offset = "0x680ADB0", VA = "0x18680C3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FB710", Offset = "0x67FA110", VA = "0x1867FB710", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BIJFIAFCNIC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x67FBF20", Offset = "0x67FA920", VA = "0x1867FBF20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67FBE80", Offset = "0x67FA880", VA = "0x1867FBE80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x67FBFC0", Offset = "0x67FA9C0", VA = "0x1867FBFC0")]
	public DLOKFEDAFJO([Optional] Action CIMMOFGCHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x67FB850", Offset = "0x67FA250", VA = "0x1867FB850")]
	public void FLOHBAGDPJC(GNMIFLHNNDO OKNALOCEHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x67FBA00", Offset = "0x67FA400", VA = "0x1867FBA00")]
	private void IBBBFPFOBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x67FBB60", Offset = "0x67FA560", VA = "0x1867FBB60", Slot = "7")]
	public bool NHOOEDMOMNO(bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x67FBB70", Offset = "0x67FA570", VA = "0x1867FBB70", Slot = "8")]
	public bool NHOOEDMOMNO(Action MCLCEMNNOFC, bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x67FB980", Offset = "0x67FA380", VA = "0x1867FB980", Slot = "9")]
	public IEnumerator<GNMIFLHNNDO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x67FB980", Offset = "0x67FA380", VA = "0x1867FB980", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public LHDNCOLMKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6801C60", Offset = "0x6800660", VA = "0x186801C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public HEGCHEHJDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6801C60", Offset = "0x6800660", VA = "0x186801C60")]
		internal void MGALHLFNEEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float GEHIKLNKEEA;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x67F28C0", Offset = "0x67F12C0", VA = "0x1867F28C0")]
	public AFDANOMBAJD(Behaviour PEHINKLIDNC, float GEHIKLNKEEA, [Optional] Action CIMMOFGCHIL, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67F27B0", Offset = "0x67F11B0", VA = "0x1867F27B0", Slot = "9")]
	protected override bool LIGHEHLPLHN(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67F26A0", Offset = "0x67F10A0", VA = "0x1867F26A0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public PJAFJMGJAJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x680CE20", Offset = "0x680B820", VA = "0x18680CE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x680CEF0", Offset = "0x680B8F0", VA = "0x18680CEF0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xF23EC0", Offset = "0xF228C0", VA = "0x180F23EC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BIJFIAFCNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x67F4230", Offset = "0x67F2C30", VA = "0x1867F4230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x67F4190", Offset = "0x67F2B90", VA = "0x1867F4190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67F42D0", Offset = "0x67F2CD0", VA = "0x1867F42D0")]
	protected ANGAKDGHCNK(Behaviour PEHINKLIDNC, [Optional] Action CIMMOFGCHIL, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67F4130", Offset = "0x67F2B30", VA = "0x1867F4130", Slot = "7")]
	public bool NHOOEDMOMNO(bool DBCFABNBIEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x67F40D0", Offset = "0x67F2AD0", VA = "0x1867F40D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x67F3DF0", Offset = "0x67F27F0", VA = "0x1867F3DF0")]
	protected void INLKFIJHPMD(Action MCLCEMNNOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67F3E10", Offset = "0x67F2810", VA = "0x1867F3E10")]
	protected BCACLFKFPHI LEPEHGJMHAI(float DAMPBKHPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x67F4050", Offset = "0x67F2A50", VA = "0x1867F4050")]
	private void NFLEEJLHLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x67F3D60", Offset = "0x67F2760", VA = "0x1867F3D60")]
	[IteratorStateMachine(typeof(PJAFJMGJAJP))]
	private IEnumerator<FLFEOAPLLLI> FHAFBFIMLPB(float DAMPBKHPLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67F3D20", Offset = "0x67F2720", VA = "0x1867F3D20")]
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
	[Cpp2IlInjected.Address(RVA = "0x6806BB0", Offset = "0x68055B0", VA = "0x186806BB0")]
	public KPCEBCHJAOJ(Behaviour PEHINKLIDNC, float LDENLCNIOFF, int NAFFAELHMJA, [Optional] Action CIMMOFGCHIL, float JIFPBDINPNL = 0f, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "9")]
	protected override bool LIGHEHLPLHN(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6806930", Offset = "0x6805330", VA = "0x186806930", Slot = "10")]
	protected override bool LFFOEIAEMMF(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6806B30", Offset = "0x6805530", VA = "0x186806B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x67F28C0", Offset = "0x67F12C0", VA = "0x1867F28C0")]
	public IAAHAIFFJKK(Behaviour PEHINKLIDNC, float GEHIKLNKEEA, [Optional] Action CIMMOFGCHIL, [Optional] PIEDMAMFPDI KHBNDDBJHNK, [Optional] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "9")]
	protected override bool LIGHEHLPLHN(Action MCLCEMNNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x68020F0", Offset = "0x6800AF0", VA = "0x1868020F0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public OFGBBGLOKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x67F56F0", Offset = "0x67F40F0", VA = "0x1867F56F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x680ADE0", Offset = "0x68097E0", VA = "0x18680ADE0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x67FF7F0", Offset = "0x67FE1F0", VA = "0x1867FF7F0")]
	public GCJHGLLABCD(KBFCHONAOBJ PEHINKLIDNC, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x67FF470", Offset = "0x67FDE70", VA = "0x1867FF470")]
	private void FOCGGNDJFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67FF610", Offset = "0x67FE010", VA = "0x1867FF610")]
	private void MAKINGIJNED(string JKDHCOHJJFE, Action MKHDPFOONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67FF770", Offset = "0x67FE170", VA = "0x1867FF770")]
	[IteratorStateMachine(typeof(OFGBBGLOKAM))]
	private IEnumerator<FLFEOAPLLLI> PMFHLJMJFII(Action MKHDPFOONKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67FF410", Offset = "0x67FDE10", VA = "0x1867FF410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67FF260", Offset = "0x67FDC60", VA = "0x1867FF260")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD830", Offset = "0x7AC230", VA = "0x1807AD830")]
		[DebuggerHidden]
		public CJGMMNMCJKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x67F56F0", Offset = "0x67F40F0", VA = "0x1867F56F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x67F5760", Offset = "0x67F4160", VA = "0x1867F5760", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x6805BE0", Offset = "0x68045E0", VA = "0x186805BE0")]
	public KKGALODEKMA(MonoBehaviour HBOAILJIBKK, Action NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6805DD0", Offset = "0x68047D0", VA = "0x186805DD0")]
	public KKGALODEKMA(MonoBehaviour HBOAILJIBKK, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6806010", Offset = "0x6804A10", VA = "0x186806010")]
	public KKGALODEKMA(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1901540", Offset = "0x18FFF40", VA = "0x181901540")]
	private KKGALODEKMA(PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6805060", Offset = "0x6803A60", VA = "0x186805060")]
	internal static KKGALODEKMA COEMMPGLGFF(MonoBehaviour HBOAILJIBKK, float JAPHMJICBGD, Action<float> NCPFGEDHINI, JAAKDEGMLAI EGDEBJAGPAI, bool ICNDMMFENED = true, [Optional] PIEDMAMFPDI KHBNDDBJHNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6805960", Offset = "0x6804360", VA = "0x186805960")]
	private void NJMCPDKGNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6805560", Offset = "0x6803F60", VA = "0x186805560")]
	private void JIMENIFIFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x68053B0", Offset = "0x6803DB0", VA = "0x1868053B0")]
	private void FOCGGNDJFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6805190", Offset = "0x6803B90", VA = "0x186805190")]
	private void DFOJLAFAKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x68057A0", Offset = "0x68041A0", VA = "0x1868057A0")]
	private void MAKINGIJNED(string JKDHCOHJJFE, Action MKHDPFOONKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6805B60", Offset = "0x6804560", VA = "0x186805B60")]
	[IteratorStateMachine(typeof(CJGMMNMCJKB))]
	private IEnumerator<FLFEOAPLLLI> PMFHLJMJFII(Action MKHDPFOONKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6805350", Offset = "0x6803D50", VA = "0x186805350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x68058D0", Offset = "0x68042D0", VA = "0x1868058D0")]
	[CompilerGenerated]
	private void MPIHFPCLPLN(string KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6805AD0", Offset = "0x68044D0", VA = "0x186805AD0")]
	[CompilerGenerated]
	private void OEDJMGFOCPJ(string KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6804FD0", Offset = "0x68039D0", VA = "0x186804FD0")]
	[CompilerGenerated]
	private void ACMCNFHJMIH(string KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6805710", Offset = "0x6804110", VA = "0x186805710")]
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
		[Cpp2IlInjected.Address(RVA = "0x68028A0", Offset = "0x68012A0", VA = "0x1868028A0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float EKJJKNJAKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6802820", Offset = "0x6801220", VA = "0x186802820", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double OAMPGJAMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x68028B0", Offset = "0x68012B0", VA = "0x1868028B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6802830", Offset = "0x6801230", VA = "0x186802830")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void EKLFLINKKJI(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A4B80", VA = "0x1807A6180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CF0", Offset = "0x7B46F0", VA = "0x1807B5CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6804490", Offset = "0x6802E90", VA = "0x186804490")]
	public static FLFEOAPLLLI OLFILPFAIHE(IEnumerator<FLFEOAPLLLI> EECJCDGPHNK, AJNLPKEJBFG LBNBPFBOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x68045F0", Offset = "0x6802FF0", VA = "0x1868045F0")]
	public FLFEOAPLLLI OLFILPFAIHE(AJNLPKEJBFG[] DNPOMLJGMIN, IEnumerator<FLFEOAPLLLI>[] PCFOEENOGBI, FLFEOAPLLLI[] FBBFPFINPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6804320", Offset = "0x6802D20", VA = "0x186804320")]
	public void EPGBOBHHKOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x68041E0", Offset = "0x6802BE0", VA = "0x1868041E0")]
	public void BGMOLCKEKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6804350", Offset = "0x6802D50", VA = "0x186804350")]
	public void JDNGNEMENJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6804320", Offset = "0x6802D20", VA = "0x186804320")]
	public void GFHNNFNCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public BCHHDINLHHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x67F47E0", Offset = "0x67F31E0", VA = "0x1867F47E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public HDFNLKAMPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6801C20", Offset = "0x6800620", VA = "0x186801C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public JLCNIALHDBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x68041A0", Offset = "0x6802BA0", VA = "0x1868041A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public FBHDGDOJFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x67FEFD0", Offset = "0x67FD9D0", VA = "0x1867FEFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x915740", Offset = "0x914140", VA = "0x180915740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x67FD710", Offset = "0x67FC110", VA = "0x1867FD710")]
	private static int GCLMFAJMPAA(JAAKDEGMLAI EGDEBJAGPAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x67FE980", Offset = "0x67FD380", VA = "0x1867FE980")]
	public EPGMPCNGNJJ(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x67FD1C0", Offset = "0x67FBBC0", VA = "0x1867FD1C0")]
	private void ENCGCNOGILL(int NKIOOGDFCFG, int KFJGLCHFKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x67FCBB0", Offset = "0x67FB5B0", VA = "0x1867FCBB0")]
	public void BAMDELHOMAK(KBFCHONAOBJ PEHINKLIDNC, FLFEOAPLLLI IPAMDAPHCPI, IEnumerator<FLFEOAPLLLI> EECJCDGPHNK, AJNLPKEJBFG LBNBPFBOKOC, [Optional] JLPKKIGBDOF CFPNCHGIMAL, FFLPGPJCNNM HFKFBFLPKHP = FFLPGPJCNNM.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x67FE040", Offset = "0x67FCA40", VA = "0x1867FE040")]
	public void MJCHOKMCNEG(IEnumerable<JJKCOBOKOGJ> NJFIDJNHNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x67FC6E0", Offset = "0x67FB0E0", VA = "0x1867FC6E0")]
	private JJKCOBOKOGJ ANGKECELOGF(int GOGPMIGNNJO)
	{
		return default(JJKCOBOKOGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x67FD3A0", Offset = "0x67FBDA0", VA = "0x1867FD3A0")]
	private void FPECCFPHHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2563A70", Offset = "0x2562470", VA = "0x182563A70")]
	private static void NOHLFNLJEGE<T>(int GOGPMIGNNJO, T[] CEOJJFFEJEJ, int BFFGCOIILMK, [Optional] T FPEFCBHJANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2563AC0", Offset = "0x25624C0", VA = "0x182563AC0")]
	private static void NOHLFNLJEGE<T>(int GOGPMIGNNJO, NativeArray<T> CEOJJFFEJEJ, int BFFGCOIILMK, [Optional] T FPEFCBHJANN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x67FDAA0", Offset = "0x67FC4A0", VA = "0x1867FDAA0")]
	private void MBKJKNKDLCB(IEnumerable<JJKCOBOKOGJ> NJFIDJNHNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x67FC620", Offset = "0x67FB020", VA = "0x1867FC620")]
	private void AFNEGHEHOKK(JJKCOBOKOGJ DLBJCDPBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x67FCD30", Offset = "0x67FB730", VA = "0x1867FCD30")]
	private ADFLEALPBDI BCLBINLIKFP(int EBFGGENHCLB)
	{
		return default(ADFLEALPBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x67FDE40", Offset = "0x67FC840", VA = "0x1867FDE40")]
	public void MEGHJAJMPGP(float DNHAFMNPMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x67FD9A0", Offset = "0x67FC3A0", VA = "0x1867FD9A0")]
	private void GNDFHPENLLC(Action MAGGDEMNFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x67FDA20", Offset = "0x67FC420", VA = "0x1867FDA20")]
	private void JFOJLHMKIDJ(Action MAGGDEMNFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x67FE280", Offset = "0x67FCC80", VA = "0x1867FE280")]
	public void PCIKFEJODPO(float DNHAFMNPMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x67FCF90", Offset = "0x67FB990", VA = "0x1867FCF90")]
	public void CHHCLLKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x67FD740", Offset = "0x67FC140", VA = "0x1867FD740")]
	public void GFHNNFNCFKG(JLPKKIGBDOF JMMKJLDLGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x67FD090", Offset = "0x67FBA90", VA = "0x1867FD090")]
	public void CPHIPFMNBCB(JLPKKIGBDOF JMMKJLDLGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x67FD870", Offset = "0x67FC270", VA = "0x1867FD870")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public EIBLEBIKNMN(Action NJNIBIJAKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x606B8A0", Offset = "0x606A2A0", VA = "0x18606B8A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public CDEMFONCFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4862960", Offset = "0x4861360", VA = "0x184862960")]
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
		[Cpp2IlInjected.Address(RVA = "0x817570", Offset = "0x815F70", VA = "0x180817570", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6CE0", Offset = "0x3AC56E0", VA = "0x183AC6CE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6B90", Offset = "0x3AC5590", VA = "0x183AC6B90")]
	private static bool LFFDJLGACMI(T MAGGDEMNFDG, T LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7080", Offset = "0x3AC5A80", VA = "0x183AC7080")]
	public KNINKFALEBP(T MFBCPDOOPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6D60", Offset = "0x3AC5760", VA = "0x183AC6D60", Slot = "6")]
	public IDisposable PGGAJFOPGNC(UnityEngine.Object PEHINKLIDNC, Action<T> BKMLCGFGCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6500", Offset = "0x3AC4F00", VA = "0x183AC6500")]
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
	[Cpp2IlInjected.Address(RVA = "0x67FC1F0", Offset = "0x67FABF0", VA = "0x1867FC1F0")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void EKLFLINKKJI(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	[Preserve]
	internal ECOHOGFEKJN([CNGDHLLDFHE(null)] PIEDMAMFPDI KHBNDDBJHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x67FC260", Offset = "0x67FAC60", VA = "0x1867FC260", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x67F3190", Offset = "0x67F1B90", VA = "0x1867F3190")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void EKLFLINKKJI(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x67F3B30", Offset = "0x67F2530", VA = "0x1867F3B30")]
	[Preserve]
	public AMAKEDNGPIE([CNGDHLLDFHE(null)] NHFHGODLONK BENCDGNGKKH, [CNGDHLLDFHE(null)] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x67F34B0", Offset = "0x67F1EB0", VA = "0x1867F34B0", Slot = "16")]
	public override DHBMNMGGJAH HPADGCLPGEG(KBFCHONAOBJ PEHINKLIDNC, IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x67F3870", Offset = "0x67F2270", VA = "0x1867F3870", Slot = "17")]
	public override void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x67F2F00", Offset = "0x67F1900", VA = "0x1867F2F00", Slot = "19")]
	public override void DACHGFOODGD(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x67F3700", Offset = "0x67F2100", VA = "0x1867F3700", Slot = "18")]
	protected override void JPBFJKJIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x67F3B00", Offset = "0x67F2500", VA = "0x1867F3B00")]
	private EPGMPCNGNJJ NLMNJIDKAOL(JAAKDEGMLAI ADAMDPHPFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x67F3200", Offset = "0x67F1C00", VA = "0x1867F3200", Slot = "20")]
	internal override ADJEEMLDENB FJOOJOGFNFE(IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE, Behaviour PEHINKLIDNC, AJNLPKEJBFG LBNBPFBOKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x67F3430", Offset = "0x67F1E30", VA = "0x1867F3430", Slot = "21")]
	internal override GFALIBHBCAI GFBNMDIKDCE(JAAKDEGMLAI INJDPFHNFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x67F35E0", Offset = "0x67F1FE0", VA = "0x1867F35E0")]
	private void JJFHIANLILL(EPGMPCNGNJJ BMCMGEEPMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x67F3130", Offset = "0x67F1B30", VA = "0x1867F3130", Slot = "22")]
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
	[Cpp2IlInjected.Address(RVA = "0x680C320", Offset = "0x680AD20", VA = "0x18680C320")]
	public static OPLIBHGPFMI NDFPICIGPEG(int BDOGNHJHDIJ, float DNHAFMNPMOH, NativeArray<FFLPGPJCNNM> HNBGAHELEPB, NativeArray<float> DFINEACEKEB, NativeArray<int> BDJAKHOHKOF, NativeArray<int> AKKODBENNPM, NativeArray<int> IGFLHEOAHLM, NativeArray<int> LEPLCMCKCJE, NativeArray<int> MOMBJOPPGKH)
	{
		return default(OPLIBHGPFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x680C200", Offset = "0x680AC00", VA = "0x18680C200", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x680C2E0", Offset = "0x680ACE0", VA = "0x18680C2E0")]
	private bool HIMMLKGPFLG(int OJANCMLFDOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x680C380", Offset = "0x680AD80", VA = "0x18680C380")]
	private void OLNJBJAKMBG(NativeArray<int> LDHKIFPGEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x680BE50", Offset = "0x680A850", VA = "0x18680BE50")]
	private int BIJGCAALGBF(int DJGEFFODPCM, int PAMFPLOLMDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x680BEF0", Offset = "0x680A8F0", VA = "0x18680BEF0")]
	private void CDEPLCBLNGO(NativeArray<int> LDHKIFPGEBO, int BHOICFNKGLF, int FEDGKNJBNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x680BFC0", Offset = "0x680A9C0", VA = "0x18680BFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6807C30", Offset = "0x6806630", VA = "0x186807C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool FEJBNDKBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C2240", Offset = "0x7C0C40", VA = "0x1807C2240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JAAKDEGMLAI MFLABAGBJMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A4B80", VA = "0x1807A6180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JAAKDEGMLAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CF0", Offset = "0x7B46F0", VA = "0x1807B5CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MADGOMEGEEG MEPNGHMNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FLFEOAPLLLI LDCPGDFGDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6807480", Offset = "0x6805E80", VA = "0x186807480")]
	public static DHBMNMGGJAH AHIAMNLJLIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6808180", Offset = "0x6806B80", VA = "0x186808180")]
	[Preserve]
	protected LJIHGBAMIMD([CNGDHLLDFHE(null)] NHFHGODLONK BENCDGNGKKH, [CNGDHLLDFHE(null)] MADGOMEGEEG NNGFOJMJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6807F70", Offset = "0x6806970", VA = "0x186807F70", Slot = "6")]
	public DHBMNMGGJAH OLPPMELFJKG(IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6807F80", Offset = "0x6806980", VA = "0x186807F80", Slot = "7")]
	public DHBMNMGGJAH OLPPMELFJKG(Behaviour PEHINKLIDNC, IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract DHBMNMGGJAH HPADGCLPGEG(KBFCHONAOBJ PEHINKLIDNC, IEnumerator<FLFEOAPLLLI> DOIMDGEJOJE);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6807D40", Offset = "0x6806740", VA = "0x186807D40", Slot = "17")]
	public virtual void KECAPFPCLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6807240", Offset = "0x6805C40", VA = "0x186807240", Slot = "9")]
	public void AHFEEIEDIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6807D20", Offset = "0x6806720", VA = "0x186807D20", Slot = "18")]
	protected virtual void JPBFJKJIHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6807D00", Offset = "0x6806700", VA = "0x186807D00")]
	private void IEFDEEEHDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6807760", Offset = "0x6806160", VA = "0x186807760")]
	private void CCGBENBCALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6807CE0", Offset = "0x68066E0", VA = "0x186807CE0")]
	private void GOMIOHKPIIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6807C10", Offset = "0x6806610", VA = "0x186807C10")]
	private void EFDEIJJMCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x68076E0", Offset = "0x68060E0", VA = "0x1868076E0")]
	private void BDKFPKCIBBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6807BF0", Offset = "0x68065F0", VA = "0x186807BF0")]
	private void EADCJEDCIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6807810", Offset = "0x6806210", VA = "0x186807810")]
	private void DCJFFLDDHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6807780", Offset = "0x6806180", VA = "0x186807780", Slot = "19")]
	public virtual void DACHGFOODGD(JAAKDEGMLAI EGDEBJAGPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6807510", Offset = "0x6805F10", VA = "0x186807510")]
	private void AKPBAALLIFM(GFALIBHBCAI BMCMGEEPMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1C8FBF0", Offset = "0x1C8E5F0", VA = "0x181C8FBF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6807830", Offset = "0x6806230", VA = "0x186807830", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6807700", Offset = "0x6806100", VA = "0x186807700", Slot = "12")]
	public FLFEOAPLLLI BFMCNOEOKJE(JAAKDEGMLAI INJDPFHNFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6807EE0", Offset = "0x68068E0", VA = "0x186807EE0", Slot = "13")]
	public FLFEOAPLLLI MGHKGOFFNHB(float EDBFKNKJGAL, JAAKDEGMLAI INJDPFHNFNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6807C80", Offset = "0x6806680", VA = "0x186807C80", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FLFEOAPLLLI FINPMLEONLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LJAGEFOFDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x67F1EC0", Offset = "0x67F08C0", VA = "0x1867F1EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool FCKGDPHFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8156B0", Offset = "0x8140B0", VA = "0x1808156B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8156C0", Offset = "0x8140C0", VA = "0x1808156C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string BJAHCKCNPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x67F1F40", Offset = "0x67F0940", VA = "0x1867F1F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float MJCOCGGLIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1087250", Offset = "0x1085C50", VA = "0x181087250")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x55CF1E0", Offset = "0x55CDBE0", VA = "0x1855CF1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x67F24E0", Offset = "0x67F0EE0", VA = "0x1867F24E0")]
	public ADJEEMLDENB(IEnumerator<FLFEOAPLLLI> EECJCDGPHNK, EEEMNJCOABC PEHINKLIDNC, AJNLPKEJBFG LBNBPFBOKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x67F20F0", Offset = "0x67F0AF0", VA = "0x1867F20F0")]
	public FLFEOAPLLLI OLFILPFAIHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x67F1E00", Offset = "0x67F0800", VA = "0x1867F1E00")]
	public bool FCLNFPHNKHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x67F1E70", Offset = "0x67F0870", VA = "0x1867F1E70")]
	public void GFHNNFNCFKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x67F2400", Offset = "0x67F0E00", VA = "0x1867F2400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x894590", Offset = "0x892F90", VA = "0x180894590")]
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
		[Cpp2IlInjected.Address(RVA = "0xE049F0", Offset = "0xE033F0", VA = "0x180E049F0", Slot = "23")]
		get
		{
			return default(JAAKDEGMLAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public JAAKDEGMLAI KLGCHJFMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x12EAD90", Offset = "0x12E9790", VA = "0x1812EAD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float EHGOCHDMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B70", Offset = "0x7F4570", VA = "0x1807F5B70", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NFPEJAFOCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x67F2E80", Offset = "0x67F1880", VA = "0x1867F2E80", Slot = "24")]
	private bool CNGEPFHLCED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x67F2EA0", Offset = "0x67F18A0", VA = "0x1867F2EA0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x67F2EB0", Offset = "0x67F18B0", VA = "0x1867F2EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9220", Offset = "0x7A7C20", VA = "0x1807A9220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x68011E0", Offset = "0x67FFBE0", VA = "0x1868011E0")]
	public GFALIBHBCAI(JAAKDEGMLAI INJDPFHNFNL, GJCNFHEDFCN LEOIJELJIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6800FA0", Offset = "0x67FF9A0", VA = "0x186800FA0")]
	public void PJFBCOCDENH(ADJEEMLDENB EECJCDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6800410", Offset = "0x67FEE10", VA = "0x186800410")]
	public void FKJOAEPKCCO(IList<ADJEEMLDENB> PCFOEENOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6800C90", Offset = "0x67FF690", VA = "0x186800C90")]
	public void PEJFLFNFKDP(IList<ADJEEMLDENB> PCFOEENOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6800A10", Offset = "0x67FF410", VA = "0x186800A10")]
	private void LAGEJMBLADC(ADJEEMLDENB EECJCDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6800B00", Offset = "0x67FF500", VA = "0x186800B00")]
	private void NHPJNBHKKMJ(IList<ADJEEMLDENB> PCFOEENOGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6800720", Offset = "0x67FF120", VA = "0x186800720")]
	private ADFLEALPBDI HDFOJNGLKKG(ADJEEMLDENB EECJCDGPHNK)
	{
		return default(ADFLEALPBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x68008A0", Offset = "0x67FF2A0", VA = "0x1868008A0")]
	public void JPBFJKJIHMJ(float DNHAFMNPMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x67FFCC0", Offset = "0x67FE6C0", VA = "0x1867FFCC0")]
	public void AHFEEIEDIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x67FFEB0", Offset = "0x67FE8B0", VA = "0x1867FFEB0")]
	private void AIPPNJGHOMN(List<ADJEEMLDENB> PCFOEENOGBI, Stack<int> GABODENMPHM, bool BHNDELGLPII, float LOGAEAMPDON = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x68001B0", Offset = "0x67FEBB0", VA = "0x1868001B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x68002D0", Offset = "0x67FECD0", VA = "0x1868002D0")]
	private void FGHBKGDIGKB(List<ADJEEMLDENB> PCFOEENOGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class AFCJDHLOLNI : GJCNFHEDFCN
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "4")]
	public void HHBEGKMADDL(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
	public void GIMOKJPEELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x6802940", Offset = "0x6801340", VA = "0x186802940", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MANBOABLAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x68028D0", Offset = "0x68012D0", VA = "0x1868028D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PMBPGIOGIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6802920", Offset = "0x6801320", VA = "0x186802920", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
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

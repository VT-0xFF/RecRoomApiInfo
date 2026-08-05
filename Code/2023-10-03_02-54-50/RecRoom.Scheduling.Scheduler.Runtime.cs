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
public class AIKJJIACJBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KNOCMCNBIEO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6327730", Offset = "0x6325F30", VA = "0x186327730")]
	public AIKJJIACJBJ(ThreadPriority LJNLENPFLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6327720", Offset = "0x6325F20", VA = "0x186327720", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> FAKNCDMHEPD(List<PlayerLoopSystem> BKIDEJBLOMH, int BLDMEJNLNML);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct KFGIDKHEKHI
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OHMLMLIBHEI
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static CAPEMHJDAJL EIGKGGLKKDD;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x633CE40", Offset = "0x633B640", VA = "0x18633CE40")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct DOCOAGBCGGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static CAPEMHJDAJL CBHODMNPLID;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x632DB90", Offset = "0x632C390", VA = "0x18632DB90")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct ADEDALMAPBA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static CAPEMHJDAJL CEFEFEKKGFI;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6326DF0", Offset = "0x63255F0", VA = "0x186326DF0")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct BBEBCIFJOJJ
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CAPEMHJDAJL HCICPOPCGPM;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CAPEMHJDAJL NFBODLIBLKM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CAPEMHJDAJL FBIHHFIEDDA;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static CAPEMHJDAJL IIAABJPAENH;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x63284D0", Offset = "0x6326CD0", VA = "0x1863284D0")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GEKJGJHIBBF
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static CAPEMHJDAJL MLLAAMCGAGJ;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x63339A0", Offset = "0x63321A0", VA = "0x1863339A0")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct MFHNCKLGHFP
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CAPEMHJDAJL HCICPOPCGPM;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CAPEMHJDAJL NFBODLIBLKM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CAPEMHJDAJL FBIHHFIEDDA;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static CAPEMHJDAJL IIAABJPAENH;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x633AF40", Offset = "0x6339740", VA = "0x18633AF40")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct ECOGBPONEHM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static CAPEMHJDAJL DPJHKGEPHDL;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x632DD90", Offset = "0x632C590", VA = "0x18632DD90")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct KPGMDBDFDCB
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static CAPEMHJDAJL BCFCKIBBJEN;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6339AD0", Offset = "0x63382D0", VA = "0x186339AD0")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct KIBDKCNOJAN
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static CAPEMHJDAJL DHDEJLLIHME;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6339380", Offset = "0x6337B80", VA = "0x186339380")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct NILNEJEBDDB
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static CAPEMHJDAJL ONELMGLLNDE;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x633BB00", Offset = "0x633A300", VA = "0x18633BB00")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct EGAHDJEPDFA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static CAPEMHJDAJL EIOMBFNBBGO;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x632E9A0", Offset = "0x632D1A0", VA = "0x18632E9A0")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct GMHJKEPLOHK
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static CAPEMHJDAJL HPCMJMPBLAP;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6337750", Offset = "0x6335F50", VA = "0x186337750")]
				public static PlayerLoopSystem JPMGDKJJNGP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum KHGJGJMIPNM : byte
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
			public struct IGINODPKAPA
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class ENKLLCJPNHF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public KHGJGJMIPNM updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
					public ENKLLCJPNHF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x632FD10", Offset = "0x632E510", VA = "0x18632FD10")]
					internal void PDBPPLFIHFO()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static KACIPEPFJMN<KHGJGJMIPNM> ONJAOCHJKDE;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x63383E0", Offset = "0x6336BE0", VA = "0x1863383E0")]
				public static PlayerLoopSystem JPMGDKJJNGP(KHGJGJMIPNM CPICIHOCAIB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct COIKLAOMDCO
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class GGKPJHKGFMN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public EDCOKKBMGBJ.MIJNIEBNCIE key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
					public GGKPJHKGFMN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6333D40", Offset = "0x6332540", VA = "0x186333D40")]
					internal void LPJFNFJMGMG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable DPPHCCJNPFN;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6329400", Offset = "0x6327C00", VA = "0x186329400")]
				public static PlayerLoopSystem DLLEGBIDHMC(EDCOKKBMGBJ.MIJNIEBNCIE EBICOEDOGKC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct JHONDBFHPJB
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class CKEAHHEAHEC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public EDCOKKBMGBJ.MIJNIEBNCIE key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
					public CKEAHHEAHEC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x63289D0", Offset = "0x63271D0", VA = "0x1863289D0")]
					internal void LPJFNFJMGMG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6338AC0", Offset = "0x63372C0", VA = "0x186338AC0")]
				public static PlayerLoopSystem DLLEGBIDHMC(EDCOKKBMGBJ.MIJNIEBNCIE EBICOEDOGKC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class GDDEGLKEGPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public GDDEGLKEGPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6333880", Offset = "0x6332080", VA = "0x186333880")]
			internal List<PlayerLoopSystem> BOALANNAICH(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PFKKGHDHDIK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool EIPCLIIIPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6329920", Offset = "0x6328120", VA = "0x186329920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x632A740", Offset = "0x6328F40", VA = "0x18632A740")]
		private static void MBOIMMMDMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6329960", Offset = "0x6328160", VA = "0x186329960")]
		private static void DPHNJPPCMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6329530", Offset = "0x6327D30", VA = "0x186329530")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6329760", Offset = "0x6327F60", VA = "0x186329760")]
		private static void BFEIAEHEAMG(EDCOKKBMGBJ.MIJNIEBNCIE EBICOEDOGKC, PlayerLoopSystem PHKHCLPPIAD, Type IDHOOIJGIDD, Type PIBPCJBOAEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x632A230", Offset = "0x6328A30", VA = "0x18632A230")]
		private static void GCCILLHCGFB(PlayerLoopSystem PHKHCLPPIAD, Type IDHOOIJGIDD, Type PIBPCJBOAEO, FAKNCDMHEPD IGFAOENAPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x632A610", Offset = "0x6328E10", VA = "0x18632A610")]
		private static void LHMDGINDEGF(PlayerLoopSystem PHKHCLPPIAD, Type IDHOOIJGIDD, Type PIBPCJBOAEO, PlayerLoopSystem? MMKDCPOPLBM, PlayerLoopSystem? GMMKENIIIKJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EDCOKKBMGBJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum MIJNIEBNCIE
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
	public class AFNHICIACDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly MIJNIEBNCIE DOECCFPKAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly JBMGLOGHBIM CAEAPLGIAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long EOIPKLMGDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long CNJNENMDKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long HKGNDHEGLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int LEKEFLEBBNM;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6327290", Offset = "0x6325A90", VA = "0x186327290")]
		public AFNHICIACDG(MIJNIEBNCIE GDCEBFIFCCN, int NOMNBGFPANF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6327040", Offset = "0x6325840", VA = "0x186327040")]
		public void NFJICGLLJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6326FF0", Offset = "0x63257F0", VA = "0x186326FF0")]
		public void LKHMFIHIAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x63270B0", Offset = "0x63258B0", VA = "0x1863270B0")]
		public void PIGKMBPPHMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static MIJNIEBNCIE[] HMIFGJAPKGK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static AFNHICIACDG[] IBNIKBOIPHM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x632E000", Offset = "0x632C800", VA = "0x18632E000")]
	public static AFNHICIACDG DAPGEILNLCF(MIJNIEBNCIE EBICOEDOGKC, int NOMNBGFPANF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x632DF90", Offset = "0x632C790", VA = "0x18632DF90")]
	public static AFNHICIACDG BNEGAMJLCGI(MIJNIEBNCIE EBICOEDOGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x632E1E0", Offset = "0x632C9E0", VA = "0x18632E1E0")]
	public static void NFEGOGAHKBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JBMGLOGHBIM : HBDFDCCIJJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int ONIFBEAALMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> MEBPEAAMEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double OIBFHHMDNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double PFCKGDLJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double CFDDJJOPLNO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double HBCEAIINGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6338820", Offset = "0x6337020", VA = "0x186338820", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double OEADIMONIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1600D80", Offset = "0x15FF580", VA = "0x181600D80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double CMJEFNLEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C050E0", Offset = "0x1C038E0", VA = "0x181C050E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6338A10", Offset = "0x6337210", VA = "0x186338A10")]
	public JBMGLOGHBIM(int DDGNICMAFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63388F0", Offset = "0x63370F0", VA = "0x1863388F0", Slot = "7")]
	public void HDGEANFHNAI(double HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6338880", Offset = "0x6337080", VA = "0x186338880", Slot = "8")]
	public void HCOIPAFLDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KDNDAGCDNEK : HBDFDCCIJJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long JEDNJDDHFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double FOOLPPOCGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double HHLDEHOBCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double HPMLCODAODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double NJOHMMBJKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double OIBFHHMDNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double PFCKGDLJEGO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double OEADIMONIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x537B9B0", Offset = "0x537A1B0", VA = "0x18537B9B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double CMJEFNLEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x537B970", Offset = "0x537A170", VA = "0x18537B970", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GDMPHGMOLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x537B4D0", Offset = "0x5379CD0", VA = "0x18537B4D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HBCEAIINGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3A30", Offset = "0x1FB2230", VA = "0x181FB3A30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6339140", Offset = "0x6337940", VA = "0x186339140", Slot = "7")]
	public virtual void HDGEANFHNAI(double HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6339100", Offset = "0x6337900", VA = "0x186339100", Slot = "8")]
	public virtual void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6333D10", Offset = "0x6332510", VA = "0x186333D10")]
	public KDNDAGCDNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GGGONMDEHOI : KDNDAGCDNEK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double IEMDHIEJFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x537B530", Offset = "0x5379D30", VA = "0x18537B530")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x537B4E0", Offset = "0x5379CE0", VA = "0x18537B4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6333BE0", Offset = "0x63323E0", VA = "0x186333BE0", Slot = "7")]
	public override void HDGEANFHNAI(double HBAHLIBAHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6333BA0", Offset = "0x63323A0", VA = "0x186333BA0", Slot = "8")]
	public override void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6333D10", Offset = "0x6332510", VA = "0x186333D10")]
	public GGGONMDEHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HBDFDCCIJJA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double HBCEAIINGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double OEADIMONIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double CMJEFNLEOIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GKMIFEIOCHC
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface FKAIDLIEPMN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool OPPIBJODKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LEICLPMPLAP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class FBFGECOADPB<TPromise, TMainThreadPromise> : FKAIDLIEPMN where TPromise : DFJLMOHJECJ where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise OLDLJICHHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise CDPLEDOPLLL;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise JHDEFKMINMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3372390", Offset = "0x3370B90", VA = "0x183372390")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OPPIBJODKDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x33723F0", Offset = "0x3370BF0", VA = "0x1833723F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
		protected FBFGECOADPB(TPromise OLDLJICHHOB, TMainThreadPromise NCPKKMAJKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3372440", Offset = "0x3370C40", VA = "0x183372440", Slot = "5")]
		public void LEICLPMPLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OMNFLKONHNK(TPromise OLDLJICHHOB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class HPFPGFOLMMC<T> : FBFGECOADPB<FNFCBJEHDPL<T>, KEACBFFGLIO<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x35B9030", Offset = "0x35B7830", VA = "0x1835B9030")]
		public HPFPGFOLMMC(FNFCBJEHDPL<T> OLDLJICHHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x35B8E20", Offset = "0x35B7620", VA = "0x1835B8E20", Slot = "6")]
		protected override void OMNFLKONHNK(FNFCBJEHDPL<T> OLDLJICHHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x35B8DC0", Offset = "0x35B75C0", VA = "0x1835B8DC0")]
		[CompilerGenerated]
		private void DDLNJPDDODC(T PGNGICAKGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x35B8DF0", Offset = "0x35B75F0", VA = "0x1835B8DF0")]
		[CompilerGenerated]
		private void ILDHEFELJHF(string OBDAEGBLILG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class LBPKGKMJJDG : FKAIDLIEPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action POMIBLHGGHJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OPPIBJODKDG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
		public LBPKGKMJJDG(Action POMIBLHGGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC30", Offset = "0xAAE430", VA = "0x180AAFC30", Slot = "5")]
		public void LEICLPMPLAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<FKAIDLIEPMN> PGPLEGAHCLF;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2382940", Offset = "0x2381140", VA = "0x182382940")]
	public static FNFCBJEHDPL<T> GEOLGBGFMEH<T>(this FNFCBJEHDPL<T> OLDLJICHHOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6337160", Offset = "0x6335960", VA = "0x186337160")]
	public static void GEOLGBGFMEH(Action POMIBLHGGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2382880", Offset = "0x2381080", VA = "0x182382880")]
	private static FNFCBJEHDPL<T> DLLKGGCIKAK<T>(FNFCBJEHDPL<T> OLDLJICHHOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6336F50", Offset = "0x6335750", VA = "0x186336F50")]
	private static void AEEPJCFLBPK(FKAIDLIEPMN PNMJMLLMCEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6337300", Offset = "0x6335B00", VA = "0x186337300")]
	private static void GJGFLNCBHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6337200", Offset = "0x6335A00", VA = "0x186337200")]
	private static void GIBCLKLHOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x63375E0", Offset = "0x6335DE0", VA = "0x1863375E0")]
	private static void LHMOCOFEMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FDCBHPFLPIL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct MDPHCHMCGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> MIJPAPLFCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string LINGGNBNLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode DACHCAHPKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool AGFDKGFIPBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x633AEE0", Offset = "0x63396E0", VA = "0x18633AEE0")]
		public MDPHCHMCGDG(TaskCompletionSource<Scene> NNCNDINJHAB, string LINGGNBNLPP, LoadSceneMode DACHCAHPKFJ, bool AGFDKGFIPBJ, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FMDDKCNJPGA : IAsyncStateMachine
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
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private GJGBNJADGMM<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x6332F70", Offset = "0x6331770", VA = "0x186332F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6333810", Offset = "0x6332010", VA = "0x186333810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct AHJMCOFDGHF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x63273A0", Offset = "0x6325BA0", VA = "0x1863273A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x63276C0", Offset = "0x6325EC0", VA = "0x1863276C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KOPAIBAMLBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MDPHCHMCGDG <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x63396C0", Offset = "0x6337EC0", VA = "0x1863396C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6339A70", Offset = "0x6338270", VA = "0x186339A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FGIGBLALGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KEACBFFGLIO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FGIGBLALGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6332F10", Offset = "0x6331710", VA = "0x186332F10")]
		internal void FFEJCIJJKOK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct EGNGHCFEKGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

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
		private FGIGBLALGEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x632EBA0", Offset = "0x632D3A0", VA = "0x18632EBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x632F740", Offset = "0x632DF40", VA = "0x18632F740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EFGMOOAKOLO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x632E420", Offset = "0x632CC20", VA = "0x18632E420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x632E930", Offset = "0x632D130", VA = "0x18632E930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PJPELJBMPGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GJGBNJADGMM<string>.NJLLNAPFMFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GJGBNJADGMM<string>.NJLLNAPFMFK <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x633E3E0", Offset = "0x633CBE0", VA = "0x18633E3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x633EF30", Offset = "0x633D730", VA = "0x18633EF30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HMKCOHLAHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public HMKCOHLAHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x63383B0", Offset = "0x6336BB0", VA = "0x1863383B0")]
		internal bool OMCMJGLHJIH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GIENEFENBPF : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public MPIIFDIEJMJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public GIENEFENBPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6336D10", Offset = "0x6335510", VA = "0x186336D10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6336980", Offset = "0x6335180", VA = "0x186336980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6336930", Offset = "0x6335130", VA = "0x186336930")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6336CC0", Offset = "0x63354C0", VA = "0x186336CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FBPMGODMEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KEACBFFGLIO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FBPMGODMEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6331580", Offset = "0x632FD80", VA = "0x186331580")]
		internal bool HPIKAAIFFPI(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6331300", Offset = "0x632FB00", VA = "0x186331300")]
		internal void AGEMMPHJADF(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OAEMFKFFIDJ : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public KEACBFFGLIO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private FBPMGODMEJA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public OAEMFKFFIDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x633BDD0", Offset = "0x633A5D0", VA = "0x18633BDD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x633C4E0", Offset = "0x633ACE0", VA = "0x18633C4E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> JJKNJJMLIMK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static DFJLMOHJECJ MPHNDHMENPG;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation PLOPKIKMJHC;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static DFJLMOHJECJ GFLLELEDGKA;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string GCAONOHJFJG;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority IKPAHIEOJJM;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task CMAEADCCBGO;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> GNPMAIJKOPJ;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<MDPHCHMCGDG> JMNOMJOEGOK;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task MIHAONCJOHD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool NADCHBJJMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6331780", Offset = "0x632FF80", VA = "0x186331780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool DFKKDIEPOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6332C80", Offset = "0x6331480", VA = "0x186332C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BILKOELJNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6331B50", Offset = "0x6330350", VA = "0x186331B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MPHEIHPJLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6332AC0", Offset = "0x63312C0", VA = "0x186332AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FBBHJLONEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6332860", Offset = "0x6331060", VA = "0x186332860")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6332280", Offset = "0x6330A80", VA = "0x186332280")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6332390", Offset = "0x6330B90", VA = "0x186332390")]
	[EODBIJHEOFL(IPEKLHHMMFE.EnteredEditModeNextFrame, 0)]
	private static void GGBKLMFMAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6332970", Offset = "0x6331170", VA = "0x186332970")]
	[AsyncStateMachine(typeof(FMDDKCNJPGA))]
	public static Task<Scene> NOFCLMMJNOM(string LINGGNBNLPP, LoadSceneMode DACHCAHPKFJ = LoadSceneMode.Single, bool AGFDKGFIPBJ = false, [Optional] GJGBNJADGMM<string>.NJLLNAPFMFK KEJOGFIGOPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6331BF0", Offset = "0x63303F0", VA = "0x186331BF0")]
	[AsyncStateMachine(typeof(AHJMCOFDGHF))]
	private static Task EGJFLJLPANJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6332490", Offset = "0x6330C90", VA = "0x186332490")]
	[AsyncStateMachine(typeof(KOPAIBAMLBO))]
	private static Task HACKFIEMODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6332560", Offset = "0x6330D60", VA = "0x186332560")]
	[AsyncStateMachine(typeof(EGNGHCFEKGO))]
	private static Task<Scene> JMMMDMDPPFE(string LINGGNBNLPP, LoadSceneMode DACHCAHPKFJ, bool AGFDKGFIPBJ, GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6332120", Offset = "0x6330920", VA = "0x186332120")]
	private static void GECMKPILJPH(SceneInstance AOCDGMDEJCJ, LoadSceneMode DACHCAHPKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x63319A0", Offset = "0x63301A0", VA = "0x1863319A0")]
	private static void CEIGCPLAHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6332000", Offset = "0x6330800", VA = "0x186332000")]
	[AsyncStateMachine(typeof(EFGMOOAKOLO))]
	private static Task<Scene> FPPLOOOIDFJ(string LINGGNBNLPP, LoadSceneMode DACHCAHPKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6331A60", Offset = "0x6330260", VA = "0x186331A60")]
	private static bool DIDCKAALJHO(string LINGGNBNLPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63326B0", Offset = "0x6330EB0", VA = "0x1863326B0")]
	[AsyncStateMachine(typeof(PJPELJBMPGA))]
	private static Task<Scene> MGJPFOIPFEO(GJGBNJADGMM<string>.NJLLNAPFMFK AJNGGDAAJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6331600", Offset = "0x632FE00", VA = "0x186331600")]
	public static FNFCBJEHDPL<Scene> AELCJIHJDJG(string LINGGNBNLPP, LoadSceneMode DACHCAHPKFJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6331CA0", Offset = "0x63304A0", VA = "0x186331CA0")]
	public static DFJLMOHJECJ EKJFKKAFMBE(string LINGGNBNLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6331F70", Offset = "0x6330770", VA = "0x186331F70")]
	[IteratorStateMachine(typeof(GIENEFENBPF))]
	private static IEnumerator<JCNDEIPBHJP> FDHEPPJANAI(string LINGGNBNLPP, MPIIFDIEJMJ AHGMHLKMAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63327C0", Offset = "0x6330FC0", VA = "0x1863327C0")]
	[IteratorStateMachine(typeof(OAEMFKFFIDJ))]
	private static IEnumerator<JCNDEIPBHJP> NALNHJODIIF(string LINGGNBNLPP, LoadSceneMode DACHCAHPKFJ, KEACBFFGLIO<Scene> AHGMHLKMAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6332B50", Offset = "0x6331350", VA = "0x186332B50")]
	public static bool OLGAGPMHACA([Out] string HMCNKPJOPIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OFNFCHOAMBK
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x633C530", Offset = "0x633AD30", VA = "0x18633C530")]
	public static IDisposable AHOGIBLOLAP(this EFPOEJEGKBK LIODJEBJPCP, float GGEFPFACMCG, Action<float> EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x633C5C0", Offset = "0x633ADC0", VA = "0x18633C5C0")]
	public static IDisposable APAIHOHEGOM(this EFPOEJEGKBK LIODJEBJPCP, Action<float> EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x633C640", Offset = "0x633AE40", VA = "0x18633C640")]
	public static IDisposable DCKHLFABJMO(this EFPOEJEGKBK LIODJEBJPCP, Action<float> EANDJFCDJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DBGJPCNCOED
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x632D550", Offset = "0x632BD50", VA = "0x18632D550")]
	public static IDisposable EAEKIPFFPDM(this MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x632D4C0", Offset = "0x632BCC0", VA = "0x18632D4C0")]
	public static IDisposable EAEKIPFFPDM(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x632D7B0", Offset = "0x632BFB0", VA = "0x18632D7B0")]
	public static IDisposable HFBGFFHILGI(this MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x632D9F0", Offset = "0x632C1F0", VA = "0x18632D9F0")]
	public static IDisposable MDBJAHPMOGO(this MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x632DA70", Offset = "0x632C270", VA = "0x18632DA70")]
	public static IDisposable OIMFHECNOCP(this MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x632D830", Offset = "0x632C030", VA = "0x18632D830")]
	public static IDisposable HOELCNDCGMK(this MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x632D5E0", Offset = "0x632BDE0", VA = "0x18632D5E0")]
	public static IDisposable EPOHNONKJPO(this MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x632D070", Offset = "0x632B870", VA = "0x18632D070")]
	public static IDisposable ABOHLEMKIAL(this MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x632D1C0", Offset = "0x632B9C0", VA = "0x18632D1C0")]
	public static IDisposable BCDMKHNEGMG(this MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x632D380", Offset = "0x632BB80", VA = "0x18632D380")]
	public static IDisposable CAKLONCJABG(this MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x632DAF0", Offset = "0x632C2F0", VA = "0x18632DAF0")]
	public static IDisposable OKMDFFNHLFO(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x632D950", Offset = "0x632C150", VA = "0x18632D950")]
	public static IDisposable LICNMONLFKC(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x632D8B0", Offset = "0x632C0B0", VA = "0x18632D8B0")]
	public static IDisposable IKOOJJBFBMG(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x632D2E0", Offset = "0x632BAE0", VA = "0x18632D2E0")]
	public static IDisposable BPKMOIDIEBD(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x632D120", Offset = "0x632B920", VA = "0x18632D120")]
	public static IDisposable AHKFAMJMLIF(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x632D660", Offset = "0x632BE60", VA = "0x18632D660")]
	public static IDisposable GADEHNBEHKK(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x632D420", Offset = "0x632BC20", VA = "0x18632D420")]
	public static IDisposable CEONIKKJDPP(this MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x632D700", Offset = "0x632BF00", VA = "0x18632D700")]
	public static IDisposable GILMANBHDFB(this MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MDJIDAMLKDC
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class ALOPODFBIEA : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HBFJPNFNPJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private GJCHHJBKBGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public ALOPODFBIEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x63283A0", Offset = "0x6326BA0", VA = "0x1863283A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6328480", Offset = "0x6326C80", VA = "0x186328480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class EODMPKGHMHH : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HBFJPNFNPJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private GJCHHJBKBGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public EODMPKGHMHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x632FD90", Offset = "0x632E590", VA = "0x18632FD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x632FE80", Offset = "0x632E680", VA = "0x18632FE80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x633AE30", Offset = "0x6339630", VA = "0x18633AE30")]
	public static CEKHBJPKCPE EAEKIPFFPDM(Action EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x633AD70", Offset = "0x6339570", VA = "0x18633AD70")]
	public static CEKHBJPKCPE EAEKIPFFPDM(Behaviour LIODJEBJPCP, Action EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x633AC50", Offset = "0x6339450", VA = "0x18633AC50")]
	public static CEKHBJPKCPE EAEKIPFFPDM(Behaviour LIODJEBJPCP, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x633ABC0", Offset = "0x63393C0", VA = "0x18633ABC0")]
	[IteratorStateMachine(typeof(ALOPODFBIEA))]
	private static IEnumerator<JCNDEIPBHJP> CEPAFLAIONO(HBFJPNFNPJH BPOHGAPJJAB, Action EANDJFCDJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x633AB30", Offset = "0x6339330", VA = "0x18633AB30")]
	[IteratorStateMachine(typeof(EODMPKGHMHH))]
	private static IEnumerator<JCNDEIPBHJP> CEPAFLAIONO(HBFJPNFNPJH BPOHGAPJJAB, Action<float> EANDJFCDJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PFHOBOLKCHD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CGLPMOLPIOJ : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public PFHOBOLKCHD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public CGLPMOLPIOJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x63288F0", Offset = "0x63270F0", VA = "0x1863288F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6328980", Offset = "0x6327180", VA = "0x186328980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly HBFJPNFNPJH JAKCEBDKIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action NHBNAPGAFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool IKKNKBCPLAJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KOHLFPFEHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x762AD0", Offset = "0x7612D0", VA = "0x180762AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x633DCE0", Offset = "0x633C4E0", VA = "0x18633DCE0")]
	public PFHOBOLKCHD(HBFJPNFNPJH JAKCEBDKIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x633DBC0", Offset = "0x633C3C0", VA = "0x18633DBC0")]
	[IteratorStateMachine(typeof(CGLPMOLPIOJ))]
	private IEnumerator<JCNDEIPBHJP> CHFELBJECIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x633DC40", Offset = "0x633C440", VA = "0x18633DC40", Slot = "4")]
	public void OnCompleted(Action OHHFMIGBIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	public void GEIECIAPCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class IHEJBADIHAH
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x63386A0", Offset = "0x6336EA0", VA = "0x1863386A0")]
	public static PFHOBOLKCHD CKDLNEOCDIK(this HBFJPNFNPJH JAKCEBDKIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class PHMNEKCIDBA
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NKJPKMPICLM : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public EDKKKJJABHG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public NKJPKMPICLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x633BD00", Offset = "0x633A500", VA = "0x18633BD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x633BD80", Offset = "0x633A580", VA = "0x18633BD80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x633E1F0", Offset = "0x633C9F0", VA = "0x18633E1F0")]
	public static CEKHBJPKCPE EAEKIPFFPDM(float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x633E0E0", Offset = "0x633C8E0", VA = "0x18633E0E0")]
	public static CEKHBJPKCPE EAEKIPFFPDM(MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x633DDF0", Offset = "0x633C5F0", VA = "0x18633DDF0")]
	public static CEKHBJPKCPE ABINIGHMNEA(MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x633DFD0", Offset = "0x633C7D0", VA = "0x18633DFD0")]
	public static CEKHBJPKCPE CPPPJIDPLEM(EFPOEJEGKBK LIODJEBJPCP, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x633DF10", Offset = "0x633C710", VA = "0x18633DF10")]
	private static IEnumerator<JCNDEIPBHJP> CEPAFLAIONO(HJEJMNGHCOF DKJHIBJFHEL, float GGEFPFACMCG, HBFJPNFNPJH BPOHGAPJJAB, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x633E380", Offset = "0x633CB80", VA = "0x18633E380")]
	private static IEnumerator<JCNDEIPBHJP> ODKHDMHFMFI(HJEJMNGHCOF DKJHIBJFHEL, float GGEFPFACMCG, HBFJPNFNPJH BPOHGAPJJAB, Action<float> EANDJFCDJCH, bool DMMLAJOBILC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x633E2F0", Offset = "0x633CAF0", VA = "0x18633E2F0")]
	[IteratorStateMachine(typeof(NKJPKMPICLM))]
	private static IEnumerator<JCNDEIPBHJP> HAKEAPGBDHE(EDKKKJJABHG OMMAADJEEDE, float GGEFPFACMCG, HBFJPNFNPJH BPOHGAPJJAB, Action<float> EANDJFCDJCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GKDNGEFDIJG
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HJEMJJJEOFO : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HBFJPNFNPJH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public HJEMJJJEOFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x63382A0", Offset = "0x6336AA0", VA = "0x1863382A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6338360", Offset = "0x6336B60", VA = "0x186338360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6336DA0", Offset = "0x63355A0", VA = "0x186336DA0")]
	[IteratorStateMachine(typeof(HJEMJJJEOFO))]
	private static IEnumerator<JCNDEIPBHJP> FIBKPEFHMGP(HBFJPNFNPJH JAKCEBDKIMH, Func<bool> DMIHLCIKLML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6336E30", Offset = "0x6335630", VA = "0x186336E30")]
	public static CEKHBJPKCPE KPLDFKEKCED(this MonoBehaviour GNBHLGDNMIM, Func<bool> DMIHLCIKLML, HBFJPNFNPJH JAKCEBDKIMH = HBFJPNFNPJH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PBLMBMJCHDG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class LLHJLPEMCFF : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public HBFJPNFNPJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public LLHJLPEMCFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x633A2C0", Offset = "0x6338AC0", VA = "0x18633A2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x633A330", Offset = "0x6338B30", VA = "0x18633A330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class PCOFJPCIAHD : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public HBFJPNFNPJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private JCNDEIPBHJP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public PCOFJPCIAHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x633DAE0", Offset = "0x633C2E0", VA = "0x18633DAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x633DB70", Offset = "0x633C370", VA = "0x18633DB70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x633D1C0", Offset = "0x633B9C0", VA = "0x18633D1C0")]
	[IteratorStateMachine(typeof(LLHJLPEMCFF))]
	private static IEnumerator<JCNDEIPBHJP> CHFELBJECIL(float CDJDJMPLMGP, HBFJPNFNPJH BPOHGAPJJAB, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x633D690", Offset = "0x633BE90", VA = "0x18633D690")]
	[IteratorStateMachine(typeof(PCOFJPCIAHD))]
	private static IEnumerator<JCNDEIPBHJP> GMCBJGKNFOE(float CDJDJMPLMGP, HBFJPNFNPJH BPOHGAPJJAB, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x633D490", Offset = "0x633BC90", VA = "0x18633D490")]
	public static IDisposable DGFIDJNJNJB(this MonoBehaviour GNBHLGDNMIM, float CDJDJMPLMGP, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x633D830", Offset = "0x633C030", VA = "0x18633D830")]
	public static CEKHBJPKCPE MBOJHLFFAIO(this MonoBehaviour GNBHLGDNMIM, float CDJDJMPLMGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x633D360", Offset = "0x633BB60", VA = "0x18633D360")]
	public static CEKHBJPKCPE DGFIDJNJNJB(this MonoBehaviour GNBHLGDNMIM, float CDJDJMPLMGP, HBFJPNFNPJH BPOHGAPJJAB, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x633D9F0", Offset = "0x633C1F0", VA = "0x18633D9F0")]
	public static CEKHBJPKCPE NOMDBECHGOE(this MonoBehaviour GNBHLGDNMIM, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x633D330", Offset = "0x633BB30", VA = "0x18633D330")]
	public static CEKHBJPKCPE DBBPCKMIOFG(this MonoBehaviour GNBHLGDNMIM, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x633D5B0", Offset = "0x633BDB0", VA = "0x18633D5B0")]
	public static CEKHBJPKCPE FFAEJEBPMGB(this MonoBehaviour GNBHLGDNMIM, Action OBFEDEKONOA, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x633D8F0", Offset = "0x633C0F0", VA = "0x18633D8F0")]
	public static CEKHBJPKCPE MFACPILLDNC(this MonoBehaviour GNBHLGDNMIM, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x633D190", Offset = "0x633B990", VA = "0x18633D190")]
	public static CEKHBJPKCPE BMFIEHFLPHB(this MonoBehaviour GNBHLGDNMIM, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x633D800", Offset = "0x633C000", VA = "0x18633D800")]
	public static CEKHBJPKCPE KLEOAEEGHGD(this MonoBehaviour GNBHLGDNMIM, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x633D260", Offset = "0x633BA60", VA = "0x18633D260")]
	private static CEKHBJPKCPE CHHHGAHJEKP(MonoBehaviour GNBHLGDNMIM, HBFJPNFNPJH JAKCEBDKIMH, Action OBFEDEKONOA, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x633D920", Offset = "0x633C120", VA = "0x18633D920")]
	public static CEKHBJPKCPE MHGNHDHDFEI(this MonoBehaviour GNBHLGDNMIM, float EJMPOOOCONK, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x633D0C0", Offset = "0x633B8C0", VA = "0x18633D0C0")]
	public static CEKHBJPKCPE BLFMLILKMFI(this MonoBehaviour GNBHLGDNMIM, float EJMPOOOCONK, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x633D730", Offset = "0x633BF30", VA = "0x18633D730")]
	public static CEKHBJPKCPE IJGBEGPDOHG(this MonoBehaviour GNBHLGDNMIM, float EJMPOOOCONK, Action OBFEDEKONOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x633DA10", Offset = "0x633C210", VA = "0x18633DA10")]
	public static CEKHBJPKCPE NPJOAOHKBAG(this MonoBehaviour GNBHLGDNMIM, float EJMPOOOCONK, Action OBFEDEKONOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GNLIAFKDOIH : ADGOOPEGACF, IEnumerable<ADGOOPEGACF>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<ADGOOPEGACF> EHPOGOFLOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool EEBELHIPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action IAEEMJDHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ENGEMIPBFLD;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NHBIFHIEDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6337E70", Offset = "0x6336670", VA = "0x186337E70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EFKBALNEAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x63380E0", Offset = "0x63368E0", VA = "0x1863380E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6337DD0", Offset = "0x63365D0", VA = "0x186337DD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6338200", Offset = "0x6336A00", VA = "0x186338200")]
	public GNLIAFKDOIH([Optional] Action IAEEMJDHBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6337FB0", Offset = "0x63367B0", VA = "0x186337FB0")]
	public void EIGFNHEIDIC(ADGOOPEGACF EDCFNEDCPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6337950", Offset = "0x6336150", VA = "0x186337950")]
	private void BIKBODEFKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6337DC0", Offset = "0x63365C0", VA = "0x186337DC0", Slot = "7")]
	public bool BMDELBPMNKA(bool HCOFOGEFGHL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6337AB0", Offset = "0x63362B0", VA = "0x186337AB0", Slot = "8")]
	public bool BMDELBPMNKA(Action POMIBLHGGHJ, bool HCOFOGEFGHL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6338180", Offset = "0x6336980", VA = "0x186338180", Slot = "9")]
	public IEnumerator<ADGOOPEGACF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6338180", Offset = "0x6336980", VA = "0x186338180", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MPNPHHJKPPK : NFNJAGCJEFI
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GANMNPIIBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MPNPHHJKPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GANMNPIIBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6328800", Offset = "0x6327000", VA = "0x186328800")]
		internal void EJEDIHPBNEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class BOMHDEAAPPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MPNPHHJKPPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BOMHDEAAPPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6328800", Offset = "0x6327000", VA = "0x186328800")]
		internal void HCENGEBBFGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float ICPGKJDNPNJ;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x63395C0", Offset = "0x6337DC0", VA = "0x1863395C0")]
	public MPNPHHJKPPK(Behaviour LIODJEBJPCP, float ICPGKJDNPNJ, [Optional] Action IAEEMJDHBNL, [Optional] JMCNEMFGNEN PAJPLAPLMIA, [Optional] HJEJMNGHCOF DKJHIBJFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x633B230", Offset = "0x6339A30", VA = "0x18633B230", Slot = "9")]
	protected override bool HMAHMHIAIBC(Action POMIBLHGGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x633B340", Offset = "0x6339B40", VA = "0x18633B340", Slot = "10")]
	protected override bool NGNCFHBDECI(Action POMIBLHGGHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ADGOOPEGACF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NHBIFHIEDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EFKBALNEAPO;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BMDELBPMNKA(bool HCOFOGEFGHL = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BMDELBPMNKA(Action POMIBLHGGHJ, bool HCOFOGEFGHL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class NFNJAGCJEFI : ADGOOPEGACF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KEKILMNNLON : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NFNJAGCJEFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public KEKILMNNLON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6339260", Offset = "0x6337A60", VA = "0x186339260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6339330", Offset = "0x6337B30", VA = "0x186339330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour LIODJEBJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action IAEEMJDHBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private HMNIIACEBPJ BNIOLOPHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly JMCNEMFGNEN PAJPLAPLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly HJEJMNGHCOF DKJHIBJFHEL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NHBIFHIEDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xDD7940", Offset = "0xDD6140", VA = "0x180DD7940", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EFKBALNEAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x633B640", Offset = "0x6339E40", VA = "0x18633B640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x633B510", Offset = "0x6339D10", VA = "0x18633B510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x633BA00", Offset = "0x633A200", VA = "0x18633BA00")]
	protected NFNJAGCJEFI(Behaviour LIODJEBJPCP, [Optional] Action IAEEMJDHBNL, [Optional] JMCNEMFGNEN PAJPLAPLMIA, [Optional] HJEJMNGHCOF DKJHIBJFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x633B450", Offset = "0x6339C50", VA = "0x18633B450", Slot = "7")]
	public bool BMDELBPMNKA(bool HCOFOGEFGHL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x633B4B0", Offset = "0x6339CB0", VA = "0x18633B4B0", Slot = "8")]
	public bool BMDELBPMNKA(Action POMIBLHGGHJ, bool HCOFOGEFGHL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HMAHMHIAIBC(Action POMIBLHGGHJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NGNCFHBDECI(Action POMIBLHGGHJ);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x633B7A0", Offset = "0x6339FA0", VA = "0x18633B7A0")]
	protected void KNNLAKFCABA(Action POMIBLHGGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x633B7C0", Offset = "0x6339FC0", VA = "0x18633B7C0")]
	protected DFJLMOHJECJ OFAKEJFJDKA(float AIKHKAOPEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x633B6E0", Offset = "0x6339EE0", VA = "0x18633B6E0")]
	private void FCBPNGHFILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x633B5B0", Offset = "0x6339DB0", VA = "0x18633B5B0")]
	[IteratorStateMachine(typeof(KEKILMNNLON))]
	private IEnumerator<JCNDEIPBHJP> CKDGPKJJBAP(float AIKHKAOPEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x633B760", Offset = "0x6339F60", VA = "0x18633B760")]
	[CompilerGenerated]
	private void FDLEFIHNHNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JNEGBEPGOKL : NFNJAGCJEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float EMAOAAOKOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int IGKIOKMJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float AJBJNBLOODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] GMDJGEDKIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int NKJLDBDBFGP;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6338F20", Offset = "0x6337720", VA = "0x186338F20")]
	public JNEGBEPGOKL(Behaviour LIODJEBJPCP, float MMJKECIHLOH, int IGKIOKMJAEP, [Optional] Action IAEEMJDHBNL, float AJBJNBLOODI = 0f, [Optional] JMCNEMFGNEN PAJPLAPLMIA, [Optional] HJEJMNGHCOF DKJHIBJFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "9")]
	protected override bool HMAHMHIAIBC(Action POMIBLHGGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6338CA0", Offset = "0x63374A0", VA = "0x186338CA0", Slot = "10")]
	protected override bool NGNCFHBDECI(Action POMIBLHGGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6338EA0", Offset = "0x63376A0", VA = "0x186338EA0")]
	private void OHDCNMKLDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KNOGIAAFAKG : NFNJAGCJEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float ICPGKJDNPNJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x63395C0", Offset = "0x6337DC0", VA = "0x1863395C0")]
	public KNOGIAAFAKG(Behaviour LIODJEBJPCP, float ICPGKJDNPNJ, [Optional] Action IAEEMJDHBNL, [Optional] JMCNEMFGNEN PAJPLAPLMIA, [Optional] HJEJMNGHCOF DKJHIBJFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "9")]
	protected override bool HMAHMHIAIBC(Action POMIBLHGGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6339580", Offset = "0x6337D80", VA = "0x186339580", Slot = "10")]
	protected override bool NGNCFHBDECI(Action POMIBLHGGHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class COBFNBEECME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class CFOLEPPLOKC : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public CFOLEPPLOKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6328830", Offset = "0x6327030", VA = "0x186328830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x63288A0", Offset = "0x63270A0", VA = "0x1863288A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private CEKHBJPKCPE JDAEGMKHIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EFPOEJEGKBK LIODJEBJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> DFHFLGDIHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private HBFJPNFNPJH JAKCEBDKIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float OCPLMJEGDHN;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6329220", Offset = "0x6327A20", VA = "0x186329220")]
	public COBFNBEECME(EFPOEJEGKBK LIODJEBJPCP, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6328ED0", Offset = "0x63276D0", VA = "0x186328ED0")]
	private void LJBIAGGFNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6328C90", Offset = "0x6327490", VA = "0x186328C90")]
	private void CJEPGNKBDOO(string OBDAEGBLILG, Action GBIKPIPKJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6328E50", Offset = "0x6327650", VA = "0x186328E50")]
	[IteratorStateMachine(typeof(CFOLEPPLOKC))]
	private IEnumerator<JCNDEIPBHJP> EJIGFNNPHKK(Action GBIKPIPKJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6328DF0", Offset = "0x63275F0", VA = "0x186328DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6329070", Offset = "0x6327870", VA = "0x186329070")]
	[CompilerGenerated]
	private void OMKDOKMDEAG(string EIIICLNDLPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class PMPFAGMJCJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CLNPMKDPEHM : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private JCNDEIPBHJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public CLNPMKDPEHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6328830", Offset = "0x6327030", VA = "0x186328830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6328C40", Offset = "0x6327440", VA = "0x186328C40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private CEKHBJPKCPE JDAEGMKHIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour GNBHLGDNMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action EANDJFCDJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> DFHFLGDIHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private HBFJPNFNPJH JAKCEBDKIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float OCPLMJEGDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool DMMLAJOBILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly JMCNEMFGNEN PAJPLAPLMIA;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6340190", Offset = "0x633E990", VA = "0x186340190")]
	public PMPFAGMJCJG(MonoBehaviour GNBHLGDNMIM, Action EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x633FD00", Offset = "0x633E500", VA = "0x18633FD00")]
	public PMPFAGMJCJG(MonoBehaviour GNBHLGDNMIM, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x633FF40", Offset = "0x633E740", VA = "0x18633FF40")]
	public PMPFAGMJCJG(MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x17C0A10", Offset = "0x17BF210", VA = "0x1817C0A10")]
	private PMPFAGMJCJG(JMCNEMFGNEN PAJPLAPLMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x633FBD0", Offset = "0x633E3D0", VA = "0x18633FBD0")]
	internal static PMPFAGMJCJG POCPFPJFIJA(MonoBehaviour GNBHLGDNMIM, float GGEFPFACMCG, Action<float> EANDJFCDJCH, HBFJPNFNPJH JAKCEBDKIMH, bool DMMLAJOBILC = true, [Optional] JMCNEMFGNEN PAJPLAPLMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x633F4C0", Offset = "0x633DCC0", VA = "0x18633F4C0")]
	private void EAEKIPFFPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x633F2B0", Offset = "0x633DAB0", VA = "0x18633F2B0")]
	private void DINBAEGDNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x633F990", Offset = "0x633E190", VA = "0x18633F990")]
	private void LJBIAGGFNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x633F740", Offset = "0x633DF40", VA = "0x18633F740")]
	private void HHLOAODMCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x633F0F0", Offset = "0x633D8F0", VA = "0x18633F0F0")]
	private void CJEPGNKBDOO(string OBDAEGBLILG, Action GBIKPIPKJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x633F630", Offset = "0x633DE30", VA = "0x18633F630")]
	[IteratorStateMachine(typeof(CLNPMKDPEHM))]
	private IEnumerator<JCNDEIPBHJP> EJIGFNNPHKK(Action GBIKPIPKJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x633F460", Offset = "0x633DC60", VA = "0x18633F460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x633FB40", Offset = "0x633E340", VA = "0x18633FB40")]
	[CompilerGenerated]
	private void MDAOMBNPODG(string EIIICLNDLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x633F6B0", Offset = "0x633DEB0", VA = "0x18633F6B0")]
	[CompilerGenerated]
	private void ENGCPJOJHBE(string EIIICLNDLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x633F900", Offset = "0x633E100", VA = "0x18633F900")]
	[CompilerGenerated]
	private void LHPHBLFNNJK(string EIIICLNDLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x633F220", Offset = "0x633DA20", VA = "0x18633F220")]
	[CompilerGenerated]
	private void DHCHGBAFCBB(string EIIICLNDLPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum JPGMAMDMDPG : byte
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
internal sealed class JLDBCFHIEPF : HJEJMNGHCOF
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float EAOJAGIPLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6338C60", Offset = "0x6337460", VA = "0x186338C60", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float PNHHBBNCOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6338C70", Offset = "0x6337470", VA = "0x186338C70", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double NLNBOCHJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6338C80", Offset = "0x6337480", VA = "0x186338C80", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6338BF0", Offset = "0x63373F0", VA = "0x186338BF0")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.None)]
	private static void APGOIBPKMBC(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	[Preserve]
	internal JLDBCFHIEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface KHONKCIPAEN
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIIACMIGFHN(string BOBHOMKFHJB);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLJCNEGFAGM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface OFFLMOCOGIN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool MGKCHKIDAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class LCCLNJJNLAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public GGMKILGMENM DLBALJDPGKI;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x76A380", Offset = "0x768B80", VA = "0x18076A380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6339DC0", Offset = "0x63385C0", VA = "0x186339DC0")]
	public static JCNDEIPBHJP DJFFNBPNBFB(IEnumerator<JCNDEIPBHJP> IAMIIEKKNLI, OJIBJCKPNON ILKFMEEJMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6339D00", Offset = "0x6338500", VA = "0x186339D00")]
	public JCNDEIPBHJP DJFFNBPNBFB(OJIBJCKPNON[] NCBBAMHMOHK, IEnumerator<JCNDEIPBHJP>[] DIHKEPOGGDF, JCNDEIPBHJP[] BPGCMALIJBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6339CD0", Offset = "0x63384D0", VA = "0x186339CD0")]
	public void CODEHINAPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6339F20", Offset = "0x6338720", VA = "0x186339F20")]
	public void MJJAKOCPGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x633A060", Offset = "0x6338860", VA = "0x18633A060")]
	public void OGBOIEMICNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6339CD0", Offset = "0x63384D0", VA = "0x186339CD0")]
	public void FELDDOHAJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public LCCLNJJNLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class GGMKILGMENM
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FPHPIPPKPMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public LCCLNJJNLAP KDJICBKMOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public EFPOEJEGKBK NKBDMCBGPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public OJIBJCKPNON HCKMGPBJKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<JCNDEIPBHJP> HNGOEKCHKLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JCNDEIPBHJP FHCOIGFDDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public JPGMAMDMDPG HLDENIFAJLO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ODJJGMJIAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public HBFJPNFNPJH KFKLDBEEPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<FPHPIPPKPMG> OPHNLNNKALD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class MCGCIHCMGOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public OJIBJCKPNON promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GGMKILGMENM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public EFPOEJEGKBK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LCCLNJJNLAP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public JPGMAMDMDPG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JCNDEIPBHJP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<JCNDEIPBHJP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MCGCIHCMGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x633A380", Offset = "0x6338B80", VA = "0x18633A380")]
		internal void LJCNPFEGDDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class JPHPDIAKFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public LCCLNJJNLAP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public GGMKILGMENM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public JPHPDIAKFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x63390C0", Offset = "0x63378C0", VA = "0x1863390C0")]
		internal void ODLKPLDNJLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BKOLBONPGBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public LCCLNJJNLAP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GGMKILGMENM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BKOLBONPGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x63287C0", Offset = "0x6326FC0", VA = "0x1863287C0")]
		internal void JEMKIBOCLPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class IJKIKKCHJCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public LCCLNJJNLAP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public GGMKILGMENM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public IJKIKKCHJCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x63387E0", Offset = "0x6336FE0", VA = "0x1863387E0")]
		internal void APAOBGOOEDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const JPGMAMDMDPG MGCBBMLDLIA = JPGMAMDMDPG.Cancelled | JPGMAMDMDPG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly HBFJPNFNPJH JAKCEBDKIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] HAHGOAKDANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<JPGMAMDMDPG> KLLLHJNILHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> EODPCNIKMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> GGCCLBBACFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> EJPNGHHGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> CCPKDOBICHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> MBBFEKIMEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> FEFEELHIJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private LCCLNJJNLAP[] FFDCMJBENFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private OJIBJCKPNON[] NCBBAMHMOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private EFPOEJEGKBK[] KNLJPKKNBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<JCNDEIPBHJP>[] LJAEPIEECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private JCNDEIPBHJP[] BNDFLNALNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int IBJDLLGDENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int OLEHEDGFINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int OACGDGBGKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float DPEFKNPKIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private ENIDHMPNAHK GACJCDFCJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle IONKLOKAGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<LCCLNJJNLAP> GJNDDFBCJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool MEEEJOCEMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> BPAIALDCAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> ODLEMEEGIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool JPKNKJMPOFM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ODJJGMJIAJG[] PPDDAEABKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8B6780", Offset = "0x8B4F80", VA = "0x1808B6780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x63348E0", Offset = "0x63330E0", VA = "0x1863348E0")]
	private static int GBEECHJBNDJ(HBFJPNFNPJH JAKCEBDKIMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x63362E0", Offset = "0x6334AE0", VA = "0x1863362E0")]
	public GGMKILGMENM(HBFJPNFNPJH JAKCEBDKIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6335A80", Offset = "0x6334280", VA = "0x186335A80")]
	private void NLDNBMDENDC(int DPFEMKMMFBN, int DFFAHJBBEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6335C60", Offset = "0x6334460", VA = "0x186335C60")]
	public void NNAGAGKPGFK(EFPOEJEGKBK LIODJEBJPCP, JCNDEIPBHJP OOCOFOMIDLA, IEnumerator<JCNDEIPBHJP> IAMIIEKKNLI, OJIBJCKPNON ILKFMEEJMIC, [Optional] LCCLNJJNLAP LKMHCAJEGKO, JPGMAMDMDPG KIICJBMLJKN = JPGMAMDMDPG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6335FE0", Offset = "0x63347E0", VA = "0x186335FE0")]
	public void PKOOMGJPBIH(IEnumerable<FPHPIPPKPMG> FHNHFGOJPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6334990", Offset = "0x6333190", VA = "0x186334990")]
	private FPHPIPPKPMG HOCNFGAKINA(int ODBBHMFLOHM)
	{
		return default(FPHPIPPKPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6335690", Offset = "0x6333E90", VA = "0x186335690")]
	private void MLGHJJIMOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x237C360", Offset = "0x237AB60", VA = "0x18237C360")]
	private static void CGOPMEOPGDL<T>(int ODBBHMFLOHM, T[] PKHFLLJGKMM, int NBNELMONDLK, [Optional] T GFFGCEENEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x237C3B0", Offset = "0x237ABB0", VA = "0x18237C3B0")]
	private static void CGOPMEOPGDL<T>(int ODBBHMFLOHM, NativeArray<T> PKHFLLJGKMM, int NBNELMONDLK, [Optional] T GFFGCEENEOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6334310", Offset = "0x6332B10", VA = "0x186334310")]
	private void FDLFFJFJLBJ(IEnumerable<FPHPIPPKPMG> FHNHFGOJPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6336220", Offset = "0x6334A20", VA = "0x186336220")]
	private void PNBBKOCOIKG(FPHPIPPKPMG OGDABOPDJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x63340B0", Offset = "0x63328B0", VA = "0x1863340B0")]
	private FJDLPLHBAGN EOBPCMOCFEK(int FLEAKPCGMDO)
	{
		return default(FJDLPLHBAGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6335DE0", Offset = "0x63345E0", VA = "0x186335DE0")]
	public void OOKHCDDJPLM(float FKGOANJCMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6334910", Offset = "0x6333110", VA = "0x186334910")]
	private void GGCOHPKJLHN(Action FABNAGLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6335A00", Offset = "0x6334200", VA = "0x186335A00")]
	private void NELJCLMJACP(Action FABNAGLLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6334E60", Offset = "0x6333660", VA = "0x186334E60")]
	public void IANPOEIGJJN(float FKGOANJCMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x63347E0", Offset = "0x6332FE0", VA = "0x1863347E0")]
	public void FFAMFELMPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x63346B0", Offset = "0x6332EB0", VA = "0x1863346B0")]
	public void FELDDOHAJBK(LCCLNJJNLAP OMMAADJEEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6333F80", Offset = "0x6332780", VA = "0x186333F80")]
	public void BMAHKMMNBFJ(LCCLNJJNLAP OMMAADJEEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6335560", Offset = "0x6333D60", VA = "0x186335560")]
	public void LJKAGOOOHFE(LCCLNJJNLAP OMMAADJEEDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PLDFIKDEGIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly PLDFIKDEGIG FNKJEGINCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action GCCIKJFPLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool PMNGKOBCMDF;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public PLDFIKDEGIG(Action GCCIKJFPLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x633EFA0", Offset = "0x633D7A0", VA = "0x18633EFA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface MJJADBMFJEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PNDNHEGKBBA(UnityEngine.Object LIODJEBJPCP, Action<T> PNIPJAJDAED);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface CPMENAKDLHD<T> : MJJADBMFJEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GNJIMEGENHM<T> : CPMENAKDLHD<T>, MJJADBMFJEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class LPNJKBONANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public GNJIMEGENHM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public ENDNJFNGIKC<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public LPNJKBONANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x39DDB20", Offset = "0x39DC320", VA = "0x1839DDB20")]
		internal void HDDNPPDBMKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject LKHAPMIKJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<ENDNJFNGIKC<UnityEngine.Object, Action<T>>> ILONPKKJAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T CCNAAAEBLND;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DE300", Offset = "0x7DCB00", VA = "0x1807DE300", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x34C8640", Offset = "0x34C6E40", VA = "0x1834C8640", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x34C84C0", Offset = "0x34C6CC0", VA = "0x1834C84C0")]
	private static bool FGIIGDIGBLH(T FABNAGLLOKN, T FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x34C89E0", Offset = "0x34C71E0", VA = "0x1834C89E0")]
	public GNJIMEGENHM(T PEEPPMEMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x34C86C0", Offset = "0x34C6EC0", VA = "0x1834C86C0", Slot = "6")]
	public IDisposable PNDNHEGKBBA(UnityEngine.Object LIODJEBJPCP, Action<T> PNIPJAJDAED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x34C8190", Offset = "0x34C6990", VA = "0x1834C8190")]
	private void BOLJHLGLBND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class LKPDOFAFADO : AENDJLNIDBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly JMCNEMFGNEN PAJPLAPLMIA;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x633A1A0", Offset = "0x63389A0", VA = "0x18633A1A0")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.None)]
	private static void APGOIBPKMBC(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	[Preserve]
	internal LKPDOFAFADO([AKMGDNDIMPI(null)] JMCNEMFGNEN PAJPLAPLMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x633A210", Offset = "0x6338A10", VA = "0x18633A210", Slot = "4")]
	public IDisposable CAKLONCJABG(float GGEFPFACMCG, Action<float> ELLFKJCIDIE, bool DMMLAJOBILC = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class AINGGPPDAPC : FBIFDGNAGGA, JMCNEMFGNEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private GGMKILGMENM[] FDABLHPEIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private KHONKCIPAEN FJMBFBFFGMI;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6327770", Offset = "0x6325F70", VA = "0x186327770")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.None)]
	private static void APGOIBPKMBC(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x63282E0", Offset = "0x6326AE0", VA = "0x1863282E0")]
	[Preserve]
	public AINGGPPDAPC([AKMGDNDIMPI(null)] OOBMLCDGGBB POLKKJFMJBP, [AKMGDNDIMPI(null)] HJEJMNGHCOF DKJHIBJFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6327EF0", Offset = "0x63266F0", VA = "0x186327EF0", Slot = "16")]
	public override CEKHBJPKCPE IKENNHBICIK(EFPOEJEGKBK LIODJEBJPCP, IEnumerator<JCNDEIPBHJP> NBGKLNFFHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6327AF0", Offset = "0x63262F0", VA = "0x186327AF0", Slot = "17")]
	public override void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x63277E0", Offset = "0x6325FE0", VA = "0x1863277E0", Slot = "19")]
	public override void BKGOCEAPFIO(HBFJPNFNPJH JAKCEBDKIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6327D80", Offset = "0x6326580", VA = "0x186327D80", Slot = "18")]
	protected override void HFBGFFHILGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x63282B0", Offset = "0x6326AB0", VA = "0x1863282B0")]
	private GGMKILGMENM OPKPLGFBHHL(HBFJPNFNPJH BJKOKHNAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6328140", Offset = "0x6326940", VA = "0x186328140", Slot = "20")]
	internal override OGODDFDAMJO NEFBMICEEJB(IEnumerator<JCNDEIPBHJP> NBGKLNFFHPA, Behaviour LIODJEBJPCP, OJIBJCKPNON ILKFMEEJMIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6327A70", Offset = "0x6326270", VA = "0x186327A70", Slot = "21")]
	internal override ABIJFLOIICC EGKLKBLMOKD(HBFJPNFNPJH BPOHGAPJJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6328020", Offset = "0x6326820", VA = "0x186328020")]
	private void LMDFJDMDKOB(GGMKILGMENM PAEDHBJIGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6327A10", Offset = "0x6326210", VA = "0x186327A10", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct ENIDHMPNAHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float PLOIJPHDKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int JCKKICMDMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> CONFJBMENEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> NJPNMCMKPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> ILENONJMOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<JPGMAMDMDPG> FBEJAPBHMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> HHAFBGAFOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> CCPKDOBICHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> GGCCLBBACFG;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x632FA30", Offset = "0x632E230", VA = "0x18632FA30")]
	public static ENIDHMPNAHK GFPEABNIECK(int LILJHEPOJLJ, float FKGOANJCMGP, NativeArray<JPGMAMDMDPG> BBAJHHMHCHH, NativeArray<float> APCJMNBNLAA, NativeArray<int> BFOPHJALFEE, NativeArray<int> JPLFJIAGCKI, NativeArray<int> HGDPIKDKIBC, NativeArray<int> NJPNMCMKPND, NativeArray<int> ILENONJMOGE)
	{
		return default(ENIDHMPNAHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x632F920", Offset = "0x632E120", VA = "0x18632F920", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x632FA90", Offset = "0x632E290", VA = "0x18632FA90")]
	private bool GPLJPADCKGG(int ADMJKDLHPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x632FA00", Offset = "0x632E200", VA = "0x18632FA00")]
	private void FIMAMILJHBE(NativeArray<int> JDNOEIKBCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x632F7B0", Offset = "0x632DFB0", VA = "0x18632F7B0")]
	private int CNNMLLAPGDC(int PKINLHMLFCA, int OHEMMKGHFEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x632F850", Offset = "0x632E050", VA = "0x18632F850")]
	private void EGCBNFKECAN(NativeArray<int> JDNOEIKBCPC, int MPBCGHEFLJP, int LLIOFJLHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x632FAD0", Offset = "0x632E2D0", VA = "0x18632FAD0")]
	private void PPEBCODBAEH(NativeArray<int> JDNOEIKBCPC, int LGGAIICBOKB, int FMCGIGGHFBJ, int HLKEKHAAGLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class FBIFDGNAGGA : JMCNEMFGNEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly OOBMLCDGGBB POLKKJFMJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly HJEJMNGHCOF DKJHIBJFHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ABIJFLOIICC[] GCHDDKBAIBD;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static JMCNEMFGNEN LNAOMADBHGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6330A40", Offset = "0x632F240", VA = "0x186330A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool KCOGMFJCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HBFJPNFNPJH FNGMMMHDILD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HBFJPNFNPJH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76A380", Offset = "0x768B80", VA = "0x18076A380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HJEJMNGHCOF IODLOJDMIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JCNDEIPBHJP BIDPLBLOHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x762B10", Offset = "0x761310", VA = "0x180762B10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6330A90", Offset = "0x632F290", VA = "0x186330A90")]
	public static CEKHBJPKCPE KHJPHAGOLKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6330E10", Offset = "0x632F610", VA = "0x186330E10")]
	[Preserve]
	protected FBIFDGNAGGA([AKMGDNDIMPI(null)] OOBMLCDGGBB POLKKJFMJBP, [AKMGDNDIMPI(null)] HJEJMNGHCOF DKJHIBJFHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6330630", Offset = "0x632EE30", VA = "0x186330630", Slot = "6")]
	public CEKHBJPKCPE GFKLAMKNNLG(IEnumerator<JCNDEIPBHJP> NBGKLNFFHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6330430", Offset = "0x632EC30", VA = "0x186330430", Slot = "7")]
	public CEKHBJPKCPE GFKLAMKNNLG(Behaviour LIODJEBJPCP, IEnumerator<JCNDEIPBHJP> NBGKLNFFHPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract CEKHBJPKCPE IKENNHBICIK(EFPOEJEGKBK LIODJEBJPCP, IEnumerator<JCNDEIPBHJP> NBGKLNFFHPA);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6330640", Offset = "0x632EE40", VA = "0x186330640", Slot = "17")]
	public virtual void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6330800", Offset = "0x632F000", VA = "0x186330800", Slot = "9")]
	public void HJEHGPHMBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x63307E0", Offset = "0x632EFE0", VA = "0x1863307E0", Slot = "18")]
	protected virtual void HFBGFFHILGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x632FF80", Offset = "0x632E780", VA = "0x18632FF80")]
	private void CBHODMNPLID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x632FFA0", Offset = "0x632E7A0", VA = "0x18632FFA0")]
	private void CEFEFEKKGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6330BA0", Offset = "0x632F3A0", VA = "0x186330BA0")]
	private void MDBJAHPMOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6330DF0", Offset = "0x632F5F0", VA = "0x186330DF0")]
	private void OIMFHECNOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6330050", Offset = "0x632E850", VA = "0x186330050")]
	private void DPJHKGEPHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x632FED0", Offset = "0x632E6D0", VA = "0x18632FED0")]
	private void BCFCKIBBJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6330B80", Offset = "0x632F380", VA = "0x186330B80")]
	private void MALILGNLENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x632FEF0", Offset = "0x632E6F0", VA = "0x18632FEF0", Slot = "19")]
	public virtual void BKGOCEAPFIO(HBFJPNFNPJH JAKCEBDKIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6330C20", Offset = "0x632F420", VA = "0x186330C20")]
	private void ODKONBNAAGL(ABIJFLOIICC PAEDHBJIGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B64740", Offset = "0x1B62F40", VA = "0x181B64740")]
	private ABIJFLOIICC JCOODGPLGFE(HBFJPNFNPJH BJKOKHNAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract OGODDFDAMJO NEFBMICEEJB(IEnumerator<JCNDEIPBHJP> NBGKLNFFHPA, Behaviour GNBHLGDNMIM, OJIBJCKPNON BINIHNFCIDN);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract ABIJFLOIICC EGKLKBLMOKD(HBFJPNFNPJH JAKCEBDKIMH);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6330070", Offset = "0x632E870", VA = "0x186330070", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6330B20", Offset = "0x632F320", VA = "0x186330B20", Slot = "12")]
	public JCNDEIPBHJP LLPLPAJELHF(HBFJPNFNPJH BPOHGAPJJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x632FFC0", Offset = "0x632E7C0", VA = "0x18632FFC0", Slot = "13")]
	public JCNDEIPBHJP DAKPDBKPEFJ(float CDJDJMPLMGP, HBFJPNFNPJH BPOHGAPJJAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6330BC0", Offset = "0x632F3C0", VA = "0x186330BC0", Slot = "14")]
	public JCNDEIPBHJP MECHOMGNEFH(Func<bool> DMIHLCIKLML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class OGODDFDAMJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly OJIBJCKPNON ILKFMEEJMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly OFFLMOCOGIN LIODJEBJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool AOBOGJDHAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string BOBHOMKFHJB;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<JCNDEIPBHJP> HNGOEKCHKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JCNDEIPBHJP FHCOIGFDDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool NALGEHFMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x633CB60", Offset = "0x633B360", VA = "0x18633CB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool BDDLLECFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x803760", Offset = "0x801F60", VA = "0x180803760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAE4F40", Offset = "0xAE3740", VA = "0x180AE4F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x633C6C0", Offset = "0x633AEC0", VA = "0x18633C6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float DEGMGDEHOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1019AB0", Offset = "0x10182B0", VA = "0x181019AB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x10D3DD0", Offset = "0x10D25D0", VA = "0x1810D3DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x633CD30", Offset = "0x633B530", VA = "0x18633CD30")]
	public OGODDFDAMJO(IEnumerator<JCNDEIPBHJP> IAMIIEKKNLI, OFFLMOCOGIN LIODJEBJPCP, OJIBJCKPNON ILKFMEEJMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x633C870", Offset = "0x633B070", VA = "0x18633C870")]
	public JCNDEIPBHJP DJFFNBPNBFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x633CBE0", Offset = "0x633B3E0", VA = "0x18633CBE0")]
	public bool PPAEBKAJKII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x633CB10", Offset = "0x633B310", VA = "0x18633CB10")]
	public void FELDDOHAJBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x633CC50", Offset = "0x633B450", VA = "0x18633CC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8195D0", Offset = "0x817DD0", VA = "0x1808195D0")]
	[CompilerGenerated]
	private void ENKNNCKMBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class OJIBJCKPNON : FJLNMGIMEGK, CEKHBJPKCPE, HMNIIACEBPJ, DFJLMOHJECJ, IEnumerator, JCNDEIPBHJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private HBFJPNFNPJH ADFLEHGMMEH;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private HBFJPNFNPJH HKLEIKNJPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xCE9CC0", Offset = "0xCE84C0", VA = "0x180CE9CC0", Slot = "23")]
		get
		{
			return default(HBFJPNFNPJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public HBFJPNFNPJH DLBALJDPGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x11D0820", Offset = "0x11CF020", VA = "0x1811D0820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float EOJNDEGPBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B43E0", Offset = "0x7B2BE0", VA = "0x1807B43E0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool CCGCPIEOAOI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x633D040", Offset = "0x633B840", VA = "0x18633D040", Slot = "24")]
	private bool APBMCFEMIMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x633D060", Offset = "0x633B860", VA = "0x18633D060", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x633D070", Offset = "0x633B870", VA = "0x18633D070")]
	public OJIBJCKPNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum FJDLPLHBAGN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class ABIJFLOIICC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum LMHHECKPJGN
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct BFFGPIBGACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public HBFJPNFNPJH KFKLDBEEPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public LMHHECKPJGN JAMBIHABJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public List<OGODDFDAMJO> IILHOGMFCJM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly LMHHECKPJGN[] LJPLCFDLNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly HBFJPNFNPJH JAKCEBDKIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool CMLDNNBCDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly OGODDFDAMJO[] ONKBJBLHKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly List<OGODDFDAMJO> DALOACPOEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<int> LAKGIAKMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<OGODDFDAMJO> GIAILDLIILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> JKIHCHMBCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly KHONKCIPAEN CJFHIPEPHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool JPKNKJMPOFM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public BFFGPIBGACI[,] HHOMDEICFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x762B10", Offset = "0x761310", VA = "0x180762B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6326950", Offset = "0x6325150", VA = "0x186326950")]
	public ABIJFLOIICC(HBFJPNFNPJH BPOHGAPJJAB, KHONKCIPAEN CJFHIPEPHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6325430", Offset = "0x6323C30", VA = "0x186325430")]
	public void BOJGGKNMPNH(OGODDFDAMJO IAMIIEKKNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x63260B0", Offset = "0x63248B0", VA = "0x1863260B0")]
	public void KGGFFKNPILH(IList<OGODDFDAMJO> DIHKEPOGGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6326500", Offset = "0x6324D00", VA = "0x186326500")]
	public void PHEOODILPJI(IList<OGODDFDAMJO> DIHKEPOGGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6325530", Offset = "0x6323D30", VA = "0x186325530")]
	private void CMNCEFLJPCL(OGODDFDAMJO IAMIIEKKNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6325BC0", Offset = "0x63243C0", VA = "0x186325BC0")]
	private void HBFILBCIJCA(IList<OGODDFDAMJO> DIHKEPOGGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6325A40", Offset = "0x6324240", VA = "0x186325A40")]
	private FJDLPLHBAGN GMKBEOFOLKO(OGODDFDAMJO IAMIIEKKNLI)
	{
		return default(FJDLPLHBAGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6325D50", Offset = "0x6324550", VA = "0x186325D50")]
	public void HFBGFFHILGI(float FKGOANJCMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6325EC0", Offset = "0x63246C0", VA = "0x186325EC0")]
	public void HJEHGPHMBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6325740", Offset = "0x6323F40", VA = "0x186325740")]
	private void FCGCNBAPDJH(List<OGODDFDAMJO> DIHKEPOGGDF, Stack<int> MEMBFFFKCKJ, bool NHEIDHEMLNP, float DMLOFNBAEAB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6325620", Offset = "0x6323E20", VA = "0x186325620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63263C0", Offset = "0x6324BC0", VA = "0x1863263C0")]
	private void OLKOLJBOPFP(List<OGODDFDAMJO> DIHKEPOGGDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class PLCCOCHMGJK : KHONKCIPAEN
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void DIIACMIGFHN(string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
	public void KLJCNEGFAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public PLCCOCHMGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class IGNKEIHLGCF : OFFLMOCOGIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Behaviour GNBHLGDNMIM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x63385B0", Offset = "0x6336DB0", VA = "0x1863385B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool IMJOLDEPIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6338650", Offset = "0x6336E50", VA = "0x186338650", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MGKCHKIDAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x6338630", Offset = "0x6336E30", VA = "0x186338630", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public IGNKEIHLGCF(Behaviour GNBHLGDNMIM)
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

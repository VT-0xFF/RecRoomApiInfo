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
public class AIJKDNDEDKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority FBFAKEBNJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x631A030", Offset = "0x6318E30", VA = "0x18631A030")]
	public AIJKDNDEDKG(ThreadPriority ACNNBGMBKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x631A020", Offset = "0x6318E20", VA = "0x18631A020", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> JFKCJGNKAFI(List<PlayerLoopSystem> LJGJEFKLGIF, int NLFJPIHJMON);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct GJFCFHMCCDH
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OGKGBIIOLAL
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static HJOHDOIHOEL LDKIENHAFGG;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x63344F0", Offset = "0x63332F0", VA = "0x1863344F0")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MAGAMMJLLJE
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static HJOHDOIHOEL NLDFJMCGCOD;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x632E930", Offset = "0x632D730", VA = "0x18632E930")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct KONNIJGGBAA
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static HJOHDOIHOEL KHNGGAJMPLB;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x632C8A0", Offset = "0x632B6A0", VA = "0x18632C8A0")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct KGLALEDBJJM
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static HJOHDOIHOEL FEOIFJOLEIP;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static HJOHDOIHOEL JBOFCAPLNOG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static HJOHDOIHOEL GOOOHPDNKLC;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static HJOHDOIHOEL DBFOKCBPAPB;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x632C4D0", Offset = "0x632B2D0", VA = "0x18632C4D0")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct LFIKIBEPCFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static HJOHDOIHOEL PNGIBLNDICE;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x632D8C0", Offset = "0x632C6C0", VA = "0x18632D8C0")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct JCPAIMLAEMN
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static HJOHDOIHOEL FEOIFJOLEIP;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static HJOHDOIHOEL JBOFCAPLNOG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static HJOHDOIHOEL GOOOHPDNKLC;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static HJOHDOIHOEL DBFOKCBPAPB;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6329050", Offset = "0x6327E50", VA = "0x186329050")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct LMFJFFMGIDB
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static HJOHDOIHOEL NALOLAHBFAA;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x632E500", Offset = "0x632D300", VA = "0x18632E500")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct POIFDIFOBNG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static HJOHDOIHOEL GHOPLIDKGOO;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6334B70", Offset = "0x6333970", VA = "0x186334B70")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct JKBKONJBDED
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static HJOHDOIHOEL NGPOCMBOFJG;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x63298C0", Offset = "0x63286C0", VA = "0x1863298C0")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct FIPCOLDODMF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static HJOHDOIHOEL LFDKNNGLDML;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x63237A0", Offset = "0x63225A0", VA = "0x1863237A0")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct DFJBNBFCAIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static HJOHDOIHOEL GOPMDOBADAB;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6322670", Offset = "0x6321470", VA = "0x186322670")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct MCEJLLPDAJI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static HJOHDOIHOEL PJICGGNBOKD;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x632EB30", Offset = "0x632D930", VA = "0x18632EB30")]
				public static PlayerLoopSystem OJLGFGOCFIL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum LDAJOEDHHCI : byte
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
			public struct LOCKKPBKFEN
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PEIFOHJKPLM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public LDAJOEDHHCI updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
					public PEIFOHJKPLM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x6334AF0", Offset = "0x63338F0", VA = "0x186334AF0")]
					internal void IMLNPBLCDJE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static KAPCIBMFMEE<LDAJOEDHHCI> GOFJJJEGOEC;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x632E760", Offset = "0x632D560", VA = "0x18632E760")]
				public static PlayerLoopSystem OJLGFGOCFIL(LDAJOEDHHCI OGHAHGLCEJO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct LGGAGHAABHP
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class FMJOEAMJBDF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public CKKPMMHDLMD.GMDMHGHOFKC key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
					public FMJOEAMJBDF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x63239A0", Offset = "0x63227A0", VA = "0x1863239A0")]
					internal void CPHNCDLIDJD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable FMNADHBDIKP;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x632E3D0", Offset = "0x632D1D0", VA = "0x18632E3D0")]
				public static PlayerLoopSystem DHIMKAHJOAF(CKKPMMHDLMD.GMDMHGHOFKC GMOPMNAPKBE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct MPPLJPFOEDK
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class AMPFGGIPNHH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public CKKPMMHDLMD.GMDMHGHOFKC key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
					public AMPFGGIPNHH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x631AD90", Offset = "0x6319B90", VA = "0x18631AD90")]
					internal void CPHNCDLIDJD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6330990", Offset = "0x632F790", VA = "0x186330990")]
				public static PlayerLoopSystem DHIMKAHJOAF(CKKPMMHDLMD.GMDMHGHOFKC GMOPMNAPKBE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class EODMMAKHILI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public EODMMAKHILI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6323570", Offset = "0x6322370", VA = "0x186323570")]
			internal List<PlayerLoopSystem> GGGFKCBBFMH(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EJGJAAKGMPO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool FHAANHLIMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x631ED60", Offset = "0x631DB60", VA = "0x18631ED60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x631FD40", Offset = "0x631EB40", VA = "0x18631FD40")]
		private static void ONGDOADKDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x631EDA0", Offset = "0x631DBA0", VA = "0x18631EDA0")]
		private static void CAMNEILJGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x631EB30", Offset = "0x631D930", VA = "0x18631EB30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x631FB80", Offset = "0x631E980", VA = "0x18631FB80")]
		private static void JEEDIGPAAKN(CKKPMMHDLMD.GMDMHGHOFKC GMOPMNAPKBE, PlayerLoopSystem JHNLHOHACLL, Type FPKHEGHEIBM, Type BIMPAAJLCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x631F7A0", Offset = "0x631E5A0", VA = "0x18631F7A0")]
		private static void GMBAFPPLNLC(PlayerLoopSystem JHNLHOHACLL, Type FPKHEGHEIBM, Type BIMPAAJLCME, JFKCJGNKAFI AKMGHEEIJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x631F670", Offset = "0x631E470", VA = "0x18631F670")]
		private static void CPAINKJMKEO(PlayerLoopSystem JHNLHOHACLL, Type FPKHEGHEIBM, Type BIMPAAJLCME, PlayerLoopSystem? CCIMNJCCCMN, PlayerLoopSystem? CPKPNAADENH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class CKKPMMHDLMD
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum GMDMHGHOFKC
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
	public class IBFAFKEMNIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly GMDMHGHOFKC IIJIFFIEEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly MLJJJHHILBM KNLMBNMDEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long BFEFOIOIGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long MIOKOBIPLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long BPAOECJEHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int ENEDPOADPJO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6327F70", Offset = "0x6326D70", VA = "0x186327F70")]
		public IBFAFKEMNIF(GMDMHGHOFKC HFCOKIPHJFC, int GBPAPMPPDGI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6327CD0", Offset = "0x6326AD0", VA = "0x186327CD0")]
		public void DJFFCAILPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6327F20", Offset = "0x6326D20", VA = "0x186327F20")]
		public void GBGCNOADENI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6327D40", Offset = "0x6326B40", VA = "0x186327D40")]
		public void FGLHPJOOHGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static GMDMHGHOFKC[] EFDHKNIHINM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static IBFAFKEMNIF[] EDPHFDLLCMA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x631D8D0", Offset = "0x631C6D0", VA = "0x18631D8D0")]
	public static IBFAFKEMNIF EBNANIDDEJG(GMDMHGHOFKC GMOPMNAPKBE, int GBPAPMPPDGI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x631D860", Offset = "0x631C660", VA = "0x18631D860")]
	public static IBFAFKEMNIF BKIFDGBGDKO(GMDMHGHOFKC GMOPMNAPKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x631DAB0", Offset = "0x631C8B0", VA = "0x18631DAB0")]
	public static void MFIMDPEGNOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MLJJJHHILBM : GCKEHPDFADH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int BNMMOJAHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> DIDIGPFELGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double OAPEGBFADLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double PDNOBEJABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double DGNPMEALJNN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MNPNFMGHLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6330810", Offset = "0x632F610", VA = "0x186330810", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double BNDMNLPBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1642F60", Offset = "0x1641D60", VA = "0x181642F60", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double DHJIOLBHJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C30D00", Offset = "0x1C2FB00", VA = "0x181C30D00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x63308E0", Offset = "0x632F6E0", VA = "0x1863308E0")]
	public MLJJJHHILBM(int ODDIDAALHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x63306F0", Offset = "0x632F4F0", VA = "0x1863306F0", Slot = "7")]
	public void GAKCDKEBAIL(double OBPGGDPOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6330870", Offset = "0x632F670", VA = "0x186330870", Slot = "8")]
	public void LJDFGIJMKMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class OCPMMEDFIOL : GCKEHPDFADH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long NENAAIFMEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double HBGKGFDGBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double KOBNOGAMGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double OFGOFJKNKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double DHAPENJFAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double OAPEGBFADLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double PDNOBEJABKG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BNDMNLPBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x532A560", Offset = "0x5329360", VA = "0x18532A560", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double DHJIOLBHJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x532AA50", Offset = "0x5329850", VA = "0x18532AA50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GKHMLNLDALE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x532AA20", Offset = "0x5329820", VA = "0x18532AA20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MNPNFMGHLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2001240", Offset = "0x2000040", VA = "0x182001240", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x63327B0", Offset = "0x63315B0", VA = "0x1863327B0", Slot = "7")]
	public virtual void GAKCDKEBAIL(double OBPGGDPOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63328D0", Offset = "0x63316D0", VA = "0x1863328D0", Slot = "8")]
	public virtual void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6331F00", Offset = "0x6330D00", VA = "0x186331F00")]
	public OCPMMEDFIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NLLMGCCENBM : OCPMMEDFIOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GOKGDIDJJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x532AA40", Offset = "0x5329840", VA = "0x18532AA40")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x532AA60", Offset = "0x5329860", VA = "0x18532AA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6331D90", Offset = "0x6330B90", VA = "0x186331D90", Slot = "7")]
	public override void GAKCDKEBAIL(double OBPGGDPOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6331EC0", Offset = "0x6330CC0", VA = "0x186331EC0", Slot = "8")]
	public override void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6331F00", Offset = "0x6330D00", VA = "0x186331F00")]
	public NLLMGCCENBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GCKEHPDFADH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MNPNFMGHLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double BNDMNLPBMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double DHJIOLBHJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ODHDLFEFGAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface MMIAFABGCCB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool DEBBLCBHNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MLCJINNMNAJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class BGDBCGNLLHJ<TPromise, TMainThreadPromise> : MMIAFABGCCB where TPromise : MMMPEMHFGNJ where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise EEKOHNACOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise NIBFEMPIKIM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise KLDJMECIMHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x44916B0", Offset = "0x44904B0", VA = "0x1844916B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DEBBLCBHNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4491710", Offset = "0x4490510", VA = "0x184491710", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
		protected BGDBCGNLLHJ(TPromise EEKOHNACOHD, TMainThreadPromise MJNOLGCAGOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4491760", Offset = "0x4490560", VA = "0x184491760", Slot = "5")]
		public void MLCJINNMNAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LBILLGKNKPD(TPromise EEKOHNACOHD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class HDFAFPKCLIC<T> : BGDBCGNLLHJ<MIDEJKJPMAF<T>, CHDLLIBCNCN<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x35D1D30", Offset = "0x35D0B30", VA = "0x1835D1D30")]
		public HDFAFPKCLIC(MIDEJKJPMAF<T> EEKOHNACOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x35D1AF0", Offset = "0x35D08F0", VA = "0x1835D1AF0", Slot = "6")]
		protected override void LBILLGKNKPD(MIDEJKJPMAF<T> EEKOHNACOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x348D540", Offset = "0x348C340", VA = "0x18348D540")]
		[CompilerGenerated]
		private void ODNLBOONOIL(T CGIMAKAECOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x35D1D00", Offset = "0x35D0B00", VA = "0x1835D1D00")]
		[CompilerGenerated]
		private void NHKLPAJAMGG(string HIFPPFEDDLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class IOPHBIMHEMH : MMIAFABGCCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action IPGJPNDBCJD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DEBBLCBHNHA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
		public IOPHBIMHEMH(Action IPGJPNDBCJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xADE100", Offset = "0xADCF00", VA = "0x180ADE100", Slot = "5")]
		public void MLCJINNMNAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<MMIAFABGCCB> ABBGHGEOGLM;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE30", Offset = "0x24FEC30", VA = "0x1824FFE30")]
	public static MIDEJKJPMAF<T> EKKOGOAAMND<T>(this MIDEJKJPMAF<T> EEKOHNACOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6332A10", Offset = "0x6331810", VA = "0x186332A10")]
	public static void EKKOGOAAMND(Action IPGJPNDBCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x24FFE90", Offset = "0x24FEC90", VA = "0x1824FFE90")]
	private static MIDEJKJPMAF<T> PMIGBOIPGIK<T>(MIDEJKJPMAF<T> EEKOHNACOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6332AB0", Offset = "0x63318B0", VA = "0x186332AB0")]
	private static void LHILBPOLJEF(MMIAFABGCCB KHOCNFHGGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6332CC0", Offset = "0x6331AC0", VA = "0x186332CC0")]
	private static void ODCCKBHKNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6332910", Offset = "0x6331710", VA = "0x186332910")]
	private static void BCMCEECJNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6332FA0", Offset = "0x6331DA0", VA = "0x186332FA0")]
	private static void OMJFNAEKLFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HMBGGFKEMMK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct LNIBHINHNOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> GMFHHGOJENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string NBIMMAELPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode IJKINAEDOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool AAJJDIOINFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x632E700", Offset = "0x632D500", VA = "0x18632E700")]
		public LNIBHINHNOB(TaskCompletionSource<Scene> JFBLGHIEAAF, string NBIMMAELPMJ, LoadSceneMode IJKINAEDOJN, bool AAJJDIOINFF, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct LFIMJCIDCJO : IAsyncStateMachine
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
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private AEMIIEBAFHL<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x632DAC0", Offset = "0x632C8C0", VA = "0x18632DAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x632E360", Offset = "0x632D160", VA = "0x18632E360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BCGLNAJPMEP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x631C430", Offset = "0x631B230", VA = "0x18631C430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x631C750", Offset = "0x631B550", VA = "0x18631C750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct BLMGADENCOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private LNIBHINHNOB <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x631CD60", Offset = "0x631BB60", VA = "0x18631CD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x631D110", Offset = "0x631BF10", VA = "0x18631D110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JOFEOOKNDEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CHDLLIBCNCN<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JOFEOOKNDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6329AC0", Offset = "0x63288C0", VA = "0x186329AC0")]
		internal void CBNFFILPPPM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KPKDDDBIDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

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
		private JOFEOOKNDEC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x632CAA0", Offset = "0x632B8A0", VA = "0x18632CAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x632D640", Offset = "0x632C440", VA = "0x18632D640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JELDBDADCEE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6329340", Offset = "0x6328140", VA = "0x186329340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6329850", Offset = "0x6328650", VA = "0x186329850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OEGHKLFPPEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AEMIIEBAFHL<string>.GMENFEPMDPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private AEMIIEBAFHL<string>.GMENFEPMDPA <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x63331D0", Offset = "0x6331FD0", VA = "0x1863331D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6333D20", Offset = "0x6332B20", VA = "0x186333D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class AMJCGBNDFNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AMJCGBNDFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x631AD60", Offset = "0x6319B60", VA = "0x18631AD60")]
		internal bool EFONILBMIOE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BDLJOECMJIJ : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public OGKAMIBOIGC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public BDLJOECMJIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x631CB90", Offset = "0x631B990", VA = "0x18631CB90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x631C800", Offset = "0x631B600", VA = "0x18631C800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x631C7B0", Offset = "0x631B5B0", VA = "0x18631C7B0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x631CB40", Offset = "0x631B940", VA = "0x18631CB40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IELPIKJCNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CHDLLIBCNCN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public IELPIKJCNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6328300", Offset = "0x6327100", VA = "0x186328300")]
		internal bool OPFELGMJCLH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6328080", Offset = "0x6326E80", VA = "0x186328080")]
		internal void NPKPAJMEKGP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class OENKLHDKKFJ : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public CHDLLIBCNCN<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private IELPIKJCNDL <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public OENKLHDKKFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6333D90", Offset = "0x6332B90", VA = "0x186333D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x63344A0", Offset = "0x63332A0", VA = "0x1863344A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> COGLDBIJKDO;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static MMMPEMHFGNJ IBPHHEBABKM;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation GMGNAHAJACB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static MMMPEMHFGNJ KFKEOFNKMOC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string BHJKLHKPABM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority KEHAECKMMDL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task NBCCEDNCIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> IHMLBDOIHPC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<LNIBHINHNOB> NLNOHNEBAMJ;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task GMOKKBKOMFC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool HIHDHBFIALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6325ED0", Offset = "0x6324CD0", VA = "0x186325ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool FMFJFHBOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x63264D0", Offset = "0x63252D0", VA = "0x1863264D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool NGNDEHBINHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6325200", Offset = "0x6324000", VA = "0x186325200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool BDOGFBDGBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6325AF0", Offset = "0x63248F0", VA = "0x186325AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MDGHCMBABCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63263C0", Offset = "0x63251C0", VA = "0x1863263C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6325890", Offset = "0x6324690", VA = "0x186325890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6326750", Offset = "0x6325550", VA = "0x186326750")]
	[NAMFIDBGMDI(HHHGCGKDFJI.EnteredEditModeNextFrame, 0)]
	private static void PHNMKEHEAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6326270", Offset = "0x6325070", VA = "0x186326270")]
	[AsyncStateMachine(typeof(LFIMJCIDCJO))]
	public static Task<Scene> LOKBAONEPEC(string NBIMMAELPMJ, LoadSceneMode IJKINAEDOJN = LoadSceneMode.Single, bool AAJJDIOINFF = false, [Optional] AEMIIEBAFHL<string>.GMENFEPMDPA ICENEAOGHKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6326570", Offset = "0x6325370", VA = "0x186326570")]
	[AsyncStateMachine(typeof(BCGLNAJPMEP))]
	private static Task NJGJEAEHENH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6325130", Offset = "0x6323F30", VA = "0x186325130")]
	[AsyncStateMachine(typeof(BLMGADENCOM))]
	private static Task AGCHKJPLKJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x63259A0", Offset = "0x63247A0", VA = "0x1863259A0")]
	[AsyncStateMachine(typeof(KPKDDDBIDJA))]
	private static Task<Scene> GBIFOIHOOKP(string NBIMMAELPMJ, LoadSceneMode IJKINAEDOJN, bool AAJJDIOINFF, AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6325D70", Offset = "0x6324B70", VA = "0x186325D70")]
	private static void JFBEIELIEEH(SceneInstance BBDPDFCKIOF, LoadSceneMode IJKINAEDOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6325CB0", Offset = "0x6324AB0", VA = "0x186325CB0")]
	private static void IOCJEDAFOEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63252A0", Offset = "0x63240A0", VA = "0x1863252A0")]
	[AsyncStateMachine(typeof(JELDBDADCEE))]
	private static Task<Scene> DDIEBALJOIP(string NBIMMAELPMJ, LoadSceneMode IJKINAEDOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x63254D0", Offset = "0x63242D0", VA = "0x1863254D0")]
	private static bool FADKPJODHAA(string NBIMMAELPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x63253C0", Offset = "0x63241C0", VA = "0x1863253C0")]
	[AsyncStateMachine(typeof(OEGHKLFPPEJ))]
	private static Task<Scene> DEMOAEJONMB(AEMIIEBAFHL<string>.GMENFEPMDPA OBBGAECDANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63260F0", Offset = "0x6324EF0", VA = "0x1863260F0")]
	public static MIDEJKJPMAF<Scene> LELFOELJNCH(string NBIMMAELPMJ, LoadSceneMode IJKINAEDOJN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63255C0", Offset = "0x63243C0", VA = "0x1863255C0")]
	public static MMMPEMHFGNJ FBOIGKCMPJA(string NBIMMAELPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6325C20", Offset = "0x6324A20", VA = "0x186325C20")]
	[IteratorStateMachine(typeof(BDLJOECMJIJ))]
	private static IEnumerator<JHKLHFOKPOC> IJKGFDJOGLP(string NBIMMAELPMJ, OGKAMIBOIGC BCKCJODOLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6325B80", Offset = "0x6324980", VA = "0x186325B80")]
	[IteratorStateMachine(typeof(OENKLHDKKFJ))]
	private static IEnumerator<JHKLHFOKPOC> HDPLBJNBLOC(string NBIMMAELPMJ, LoadSceneMode IJKINAEDOJN, CHDLLIBCNCN<Scene> BCKCJODOLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6326620", Offset = "0x6325420", VA = "0x186326620")]
	public static bool PFAOLICMGOJ([Out] string LLKHGGMJBHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class AIHDJEGGEBL
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6319F90", Offset = "0x6318D90", VA = "0x186319F90")]
	public static IDisposable OIJDKGDAOIH(this IHILHGKIJFA DDMHMHFODEB, float CPEIALAAAKH, Action<float> ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6319F10", Offset = "0x6318D10", VA = "0x186319F10")]
	public static IDisposable BFADAJDADFO(this IHILHGKIJFA DDMHMHFODEB, Action<float> ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6319E90", Offset = "0x6318C90", VA = "0x186319E90")]
	public static IDisposable AJFEHMOJBHI(this IHILHGKIJFA DDMHMHFODEB, Action<float> ONOFJJKGLBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NFDEFBEKJLA
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6331700", Offset = "0x6330500", VA = "0x186331700")]
	public static IDisposable GDIPHNMNNAB(this MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6331790", Offset = "0x6330590", VA = "0x186331790")]
	public static IDisposable GDIPHNMNNAB(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6331C60", Offset = "0x6330A60", VA = "0x186331C60")]
	public static IDisposable NCDLFODJGAN(this MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6331820", Offset = "0x6330620", VA = "0x186331820")]
	public static IDisposable ILGLEEIALCK(this MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6331530", Offset = "0x6330330", VA = "0x186331530")]
	public static IDisposable ECIOPMJCBLO(this MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x63314B0", Offset = "0x63302B0", VA = "0x1863314B0")]
	public static IDisposable DNNDPLOAAJJ(this MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6331270", Offset = "0x6330070", VA = "0x186331270")]
	public static IDisposable CBCOHFOAIOM(this MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6331CE0", Offset = "0x6330AE0", VA = "0x186331CE0")]
	public static IDisposable OJLCBJOFJKG(this MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6331390", Offset = "0x6330190", VA = "0x186331390")]
	public static IDisposable DBDGMFHBJOF(this MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6331B20", Offset = "0x6330920", VA = "0x186331B20")]
	public static IDisposable MIOJCMCPLMO(this MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6331940", Offset = "0x6330740", VA = "0x186331940")]
	public static IDisposable KOJFLDKDPCG(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x63319E0", Offset = "0x63307E0", VA = "0x1863319E0")]
	public static IDisposable LBMGMMHOFAJ(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6331A80", Offset = "0x6330880", VA = "0x186331A80")]
	public static IDisposable LIAICFFEJAB(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x63312F0", Offset = "0x63300F0", VA = "0x1863312F0")]
	public static IDisposable CHFNMPFICOF(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63318A0", Offset = "0x63306A0", VA = "0x1863318A0")]
	public static IDisposable KDHHJLIDEEL(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6331BC0", Offset = "0x63309C0", VA = "0x186331BC0")]
	public static IDisposable MOMBKIMEJNC(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x63315B0", Offset = "0x63303B0", VA = "0x1863315B0")]
	public static IDisposable EFLICBNHFLM(this MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6331650", Offset = "0x6330450", VA = "0x186331650")]
	public static IDisposable FONFDGCKKKL(this MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DGKAIBCDOLO
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class LCNODHHOILN : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CBKJDEDPNLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private ENNMIOPIHLA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public LCNODHHOILN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x632D790", Offset = "0x632C590", VA = "0x18632D790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x632D870", Offset = "0x632C670", VA = "0x18632D870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class GMGLMCJJEHP : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CBKJDEDPNLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private ENNMIOPIHLA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public GMGLMCJJEHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6324E20", Offset = "0x6323C20", VA = "0x186324E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6324F10", Offset = "0x6323D10", VA = "0x186324F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6322990", Offset = "0x6321790", VA = "0x186322990")]
	public static KFKJPENGGJI GDIPHNMNNAB(Action ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6322A40", Offset = "0x6321840", VA = "0x186322A40")]
	public static KFKJPENGGJI GDIPHNMNNAB(Behaviour DDMHMHFODEB, Action ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6322870", Offset = "0x6321670", VA = "0x186322870")]
	public static KFKJPENGGJI GDIPHNMNNAB(Behaviour DDMHMHFODEB, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6322B00", Offset = "0x6321900", VA = "0x186322B00")]
	[IteratorStateMachine(typeof(LCNODHHOILN))]
	private static IEnumerator<JHKLHFOKPOC> NMCDAMKCCGJ(CBKJDEDPNLB IMNBHGEKNIE, Action ONOFJJKGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6322B90", Offset = "0x6321990", VA = "0x186322B90")]
	[IteratorStateMachine(typeof(GMGLMCJJEHP))]
	private static IEnumerator<JHKLHFOKPOC> NMCDAMKCCGJ(CBKJDEDPNLB IMNBHGEKNIE, Action<float> ONOFJJKGLBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class FMOACAPMOAD : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class LBJMLLLCPPM : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public FMOACAPMOAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public LBJMLLLCPPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x632D6B0", Offset = "0x632C4B0", VA = "0x18632D6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x632D740", Offset = "0x632C540", VA = "0x18632D740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CBKJDEDPNLB COGIGCIJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action HKAKOHIKFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool EINAPJPJOIE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LEICACPBEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7656C0", Offset = "0x7644C0", VA = "0x1807656C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6323D00", Offset = "0x6322B00", VA = "0x186323D00")]
	public FMOACAPMOAD(CBKJDEDPNLB COGIGCIJCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6323BE0", Offset = "0x63229E0", VA = "0x186323BE0")]
	[IteratorStateMachine(typeof(LBJMLLLCPPM))]
	private IEnumerator<JHKLHFOKPOC> MEDDNHANFND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6323C60", Offset = "0x6322A60", VA = "0x186323C60", Slot = "4")]
	public void OnCompleted(Action HGNJPJGHAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	public void FLDDKOGIELH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class OHAMPDIJDGE
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x63346F0", Offset = "0x63334F0", VA = "0x1863346F0")]
	public static FMOACAPMOAD HAGMPFAAMAB(this CBKJDEDPNLB COGIGCIJCHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CEEEHJBEMGB
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class OPCKNFFNCKN : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public NJOIOAPNOEL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public OPCKNFFNCKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6334870", Offset = "0x6333670", VA = "0x186334870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x63348F0", Offset = "0x63336F0", VA = "0x1863348F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x631D500", Offset = "0x631C300", VA = "0x18631D500")]
	public static KFKJPENGGJI GDIPHNMNNAB(float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x631D3F0", Offset = "0x631C1F0", VA = "0x18631D3F0")]
	public static KFKJPENGGJI GDIPHNMNNAB(MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x631D2D0", Offset = "0x631C0D0", VA = "0x18631D2D0")]
	public static KFKJPENGGJI FKEMGDENEMO(MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x631D600", Offset = "0x631C400", VA = "0x18631D600")]
	public static KFKJPENGGJI MGKHFFPEFBO(IHILHGKIJFA DDMHMHFODEB, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x631D7A0", Offset = "0x631C5A0", VA = "0x18631D7A0")]
	private static IEnumerator<JHKLHFOKPOC> NMCDAMKCCGJ(JMGGMPODBLM BCODCCIMCHC, float CPEIALAAAKH, CBKJDEDPNLB IMNBHGEKNIE, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x631D270", Offset = "0x631C070", VA = "0x18631D270")]
	private static IEnumerator<JHKLHFOKPOC> FHGELPEACJP(JMGGMPODBLM BCODCCIMCHC, float CPEIALAAAKH, CBKJDEDPNLB IMNBHGEKNIE, Action<float> ONOFJJKGLBH, bool NGPEFAGKCHE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x631D710", Offset = "0x631C510", VA = "0x18631D710")]
	[IteratorStateMachine(typeof(OPCKNFFNCKN))]
	private static IEnumerator<JHKLHFOKPOC> MNPNFJLBKHG(NJOIOAPNOEL AMOAFOKOCCE, float CPEIALAAAKH, CBKJDEDPNLB IMNBHGEKNIE, Action<float> ONOFJJKGLBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PEEACLJKHCK
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FHLCHLPGKJF : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CBKJDEDPNLB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public FHLCHLPGKJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6323690", Offset = "0x6322490", VA = "0x186323690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6323750", Offset = "0x6322550", VA = "0x186323750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6334940", Offset = "0x6333740", VA = "0x186334940")]
	[IteratorStateMachine(typeof(FHLCHLPGKJF))]
	private static IEnumerator<JHKLHFOKPOC> HDLPANFDCPH(CBKJDEDPNLB COGIGCIJCHO, Func<bool> FAKFOJBAANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x63349D0", Offset = "0x63337D0", VA = "0x1863349D0")]
	public static KFKJPENGGJI OHGCJFFJMAD(this MonoBehaviour POCMKOMIDEC, Func<bool> FAKFOJBAANF, CBKJDEDPNLB COGIGCIJCHO = CBKJDEDPNLB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class CMMNLMAJDNG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class ODMKDBBLMFG : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CBKJDEDPNLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public ODMKDBBLMFG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6333110", Offset = "0x6331F10", VA = "0x186333110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6333180", Offset = "0x6331F80", VA = "0x186333180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KJCAFNLGPDN : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CBKJDEDPNLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private JHKLHFOKPOC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public KJCAFNLGPDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x632C7C0", Offset = "0x632B5C0", VA = "0x18632C7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x632C850", Offset = "0x632B650", VA = "0x18632C850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x631E8D0", Offset = "0x631D6D0", VA = "0x18631E8D0")]
	[IteratorStateMachine(typeof(ODMKDBBLMFG))]
	private static IEnumerator<JHKLHFOKPOC> MEDDNHANFND(float NNDFFBJHCAM, CBKJDEDPNLB IMNBHGEKNIE, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x631E670", Offset = "0x631D470", VA = "0x18631E670")]
	[IteratorStateMachine(typeof(KJCAFNLGPDN))]
	private static IEnumerator<JHKLHFOKPOC> HJHKBBICKIH(float NNDFFBJHCAM, CBKJDEDPNLB IMNBHGEKNIE, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x631E410", Offset = "0x631D210", VA = "0x18631E410")]
	public static IDisposable DLFCNHLFMEB(this MonoBehaviour POCMKOMIDEC, float NNDFFBJHCAM, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x631E9A0", Offset = "0x631D7A0", VA = "0x18631E9A0")]
	public static KFKJPENGGJI OFKLKLOGCKD(this MonoBehaviour POCMKOMIDEC, float NNDFFBJHCAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x631E2E0", Offset = "0x631D0E0", VA = "0x18631E2E0")]
	public static KFKJPENGGJI DLFCNHLFMEB(this MonoBehaviour POCMKOMIDEC, float NNDFFBJHCAM, CBKJDEDPNLB IMNBHGEKNIE, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x631E7E0", Offset = "0x631D5E0", VA = "0x18631E7E0")]
	public static KFKJPENGGJI JMBDFBOOJAP(this MonoBehaviour POCMKOMIDEC, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x631E2B0", Offset = "0x631D0B0", VA = "0x18631E2B0")]
	public static KFKJPENGGJI DKNPCCLCGIA(this MonoBehaviour POCMKOMIDEC, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x631E560", Offset = "0x631D360", VA = "0x18631E560")]
	public static KFKJPENGGJI FMMAFLLGLCH(this MonoBehaviour POCMKOMIDEC, Action LMMNIDGGPKJ, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x631E640", Offset = "0x631D440", VA = "0x18631E640")]
	public static KFKJPENGGJI HADNAOEEGKE(this MonoBehaviour POCMKOMIDEC, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x631E530", Offset = "0x631D330", VA = "0x18631E530")]
	public static KFKJPENGGJI FKJIGALNLDI(this MonoBehaviour POCMKOMIDEC, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x631E970", Offset = "0x631D770", VA = "0x18631E970")]
	public static KFKJPENGGJI OBNHBKBPBKF(this MonoBehaviour POCMKOMIDEC, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x631E1E0", Offset = "0x631CFE0", VA = "0x18631E1E0")]
	private static KFKJPENGGJI BAPEFGAJAPK(MonoBehaviour POCMKOMIDEC, CBKJDEDPNLB COGIGCIJCHO, Action LMMNIDGGPKJ, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x631E800", Offset = "0x631D600", VA = "0x18631E800")]
	public static KFKJPENGGJI JOLOIOFJPGM(this MonoBehaviour POCMKOMIDEC, float KCPMHMNBJHB, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x631E110", Offset = "0x631CF10", VA = "0x18631E110")]
	public static KFKJPENGGJI ACALBCDHOIC(this MonoBehaviour POCMKOMIDEC, float KCPMHMNBJHB, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x631EA60", Offset = "0x631D860", VA = "0x18631EA60")]
	public static KFKJPENGGJI OPBMGECAOBE(this MonoBehaviour POCMKOMIDEC, float KCPMHMNBJHB, Action LMMNIDGGPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x631E710", Offset = "0x631D510", VA = "0x18631E710")]
	public static KFKJPENGGJI IMLJFDMEDID(this MonoBehaviour POCMKOMIDEC, float KCPMHMNBJHB, Action LMMNIDGGPKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DKGFFIKBLKN : NEOPHDIDPCE, IEnumerable<NEOPHDIDPCE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<NEOPHDIDPCE> PMAAJCLNIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool PLNOHMNLIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action KODOHFNGJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool BKHDJGFKKPI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BIFEGHLHDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x63232F0", Offset = "0x63220F0", VA = "0x1863232F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JBHCMAHDMHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6323430", Offset = "0x6322230", VA = "0x186323430", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x63231D0", Offset = "0x6321FD0", VA = "0x1863231D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x63234D0", Offset = "0x63222D0", VA = "0x1863234D0")]
	public DKGFFIKBLKN([Optional] Action KODOHFNGJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x63230A0", Offset = "0x6321EA0", VA = "0x1863230A0")]
	public void EJEJBLJEAIN(NEOPHDIDPCE MBKNAPGLLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6322F40", Offset = "0x6321D40", VA = "0x186322F40")]
	private void CBPOPCMOGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6322F30", Offset = "0x6321D30", VA = "0x186322F30", Slot = "7")]
	public bool ADGJIMOEDFJ(bool PIOPLCOODHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6322C20", Offset = "0x6321A20", VA = "0x186322C20", Slot = "8")]
	public bool ADGJIMOEDFJ(Action IPGJPNDBCJD, bool PIOPLCOODHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6323270", Offset = "0x6322070", VA = "0x186323270", Slot = "9")]
	public IEnumerator<NEOPHDIDPCE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6323270", Offset = "0x6322070", VA = "0x186323270", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NNJDAPGNAMM : IODIPMHOPIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ADEDEJAJCHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NNJDAPGNAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public ADEDEJAJCHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6319C80", Offset = "0x6318A80", VA = "0x186319C80")]
		internal void EHJEHLFCIBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JPPJONLPOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NNJDAPGNAMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public JPPJONLPOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6319C80", Offset = "0x6318A80", VA = "0x186319C80")]
		internal void LKGHHGGKEHA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float JPOEBOKKEDB;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x63326B0", Offset = "0x63314B0", VA = "0x1863326B0")]
	public NNJDAPGNAMM(Behaviour DDMHMHFODEB, float JPOEBOKKEDB, [Optional] Action KODOHFNGJJJ, [Optional] NMEKMIOKOHP EHMKGIGLLPH, [Optional] JMGGMPODBLM BCODCCIMCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6332490", Offset = "0x6331290", VA = "0x186332490", Slot = "9")]
	protected override bool FJLGDEGBEBK(Action IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x63325A0", Offset = "0x63313A0", VA = "0x1863325A0", Slot = "10")]
	protected override bool LENGLDLMOIA(Action IPGJPNDBCJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface NEOPHDIDPCE
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BIFEGHLHDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action JBHCMAHDMHH;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ADGJIMOEDFJ(bool PIOPLCOODHB = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ADGJIMOEDFJ(Action IPGJPNDBCJD, bool PIOPLCOODHB = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class IODIPMHOPIJ : NEOPHDIDPCE
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class ADLHDAMGCFK : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public IODIPMHOPIJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public ADLHDAMGCFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6319D70", Offset = "0x6318B70", VA = "0x186319D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6319E40", Offset = "0x6318C40", VA = "0x186319E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour DDMHMHFODEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action KODOHFNGJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private GJDHHHJOJJP JEJFDOCKAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly NMEKMIOKOHP EHMKGIGLLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly JMGGMPODBLM BCODCCIMCHC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BIFEGHLHDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xE1B830", Offset = "0xE1A630", VA = "0x180E1B830", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JBHCMAHDMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6328870", Offset = "0x6327670", VA = "0x186328870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6328500", Offset = "0x6327300", VA = "0x186328500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6328930", Offset = "0x6327730", VA = "0x186328930")]
	protected IODIPMHOPIJ(Behaviour DDMHMHFODEB, [Optional] Action KODOHFNGJJJ, [Optional] NMEKMIOKOHP EHMKGIGLLPH, [Optional] JMGGMPODBLM BCODCCIMCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x63283E0", Offset = "0x63271E0", VA = "0x1863283E0", Slot = "7")]
	public bool ADGJIMOEDFJ(bool PIOPLCOODHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6328380", Offset = "0x6327180", VA = "0x186328380", Slot = "8")]
	public bool ADGJIMOEDFJ(Action IPGJPNDBCJD, bool PIOPLCOODHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool FJLGDEGBEBK(Action IPGJPNDBCJD);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LENGLDLMOIA(Action IPGJPNDBCJD);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6328910", Offset = "0x6327710", VA = "0x186328910")]
	protected void MPCFABBLBDD(Action IPGJPNDBCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6328630", Offset = "0x6327430", VA = "0x186328630")]
	protected MMMPEMHFGNJ KBAEHKHGNGE(float DCKCDNEGBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6328480", Offset = "0x6327280", VA = "0x186328480")]
	private void DGMKNMGGKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x63285A0", Offset = "0x63273A0", VA = "0x1863285A0")]
	[IteratorStateMachine(typeof(ADLHDAMGCFK))]
	private IEnumerator<JHKLHFOKPOC> JJGIMHCIOAN(float DCKCDNEGBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6328440", Offset = "0x6327240", VA = "0x186328440")]
	[CompilerGenerated]
	private void AHOHLOJGMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class CMBHDDJBNED : IODIPMHOPIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float JELMOLDIPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int BAFILOHJMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float NIEDIIFOGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] GBDJMFEIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int IHJPLHHIBNG;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x631DF70", Offset = "0x631CD70", VA = "0x18631DF70")]
	public CMBHDDJBNED(Behaviour DDMHMHFODEB, float IMLJEMICIDO, int BAFILOHJMJL, [Optional] Action KODOHFNGJJJ, float NIEDIIFOGGF = 0f, [Optional] NMEKMIOKOHP EHMKGIGLLPH, [Optional] JMGGMPODBLM BCODCCIMCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "9")]
	protected override bool FJLGDEGBEBK(Action IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x631DD70", Offset = "0x631CB70", VA = "0x18631DD70", Slot = "10")]
	protected override bool LENGLDLMOIA(Action IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x631DCF0", Offset = "0x631CAF0", VA = "0x18631DCF0")]
	private void AOKELKGGDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OLAGEHGGPFO : IODIPMHOPIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float JPOEBOKKEDB;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x63326B0", Offset = "0x63314B0", VA = "0x1863326B0")]
	public OLAGEHGGPFO(Behaviour DDMHMHFODEB, float JPOEBOKKEDB, [Optional] Action KODOHFNGJJJ, [Optional] NMEKMIOKOHP EHMKGIGLLPH, [Optional] JMGGMPODBLM BCODCCIMCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "9")]
	protected override bool FJLGDEGBEBK(Action IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6334830", Offset = "0x6333630", VA = "0x186334830", Slot = "10")]
	protected override bool LENGLDLMOIA(Action IPGJPNDBCJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class FNLGCPHCFJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ADFLIMDFEGK : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public ADFLIMDFEGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6319CB0", Offset = "0x6318AB0", VA = "0x186319CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6319D20", Offset = "0x6318B20", VA = "0x186319D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private KFKJPENGGJI KOHFHEMFCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private IHILHGKIJFA DDMHMHFODEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> CPHBMILODBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private CBKJDEDPNLB COGIGCIJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float FMGPPNOBMHL;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x63243A0", Offset = "0x63231A0", VA = "0x1863243A0")]
	public FNLGCPHCFJM(IHILHGKIJFA DDMHMHFODEB, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6324050", Offset = "0x6322E50", VA = "0x186324050")]
	private void JOEBIHNDOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6323EF0", Offset = "0x6322CF0", VA = "0x186323EF0")]
	private void GKJCOAFMHAK(string HIFPPFEDDLE, Action OPPJFEGMJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6323E10", Offset = "0x6322C10", VA = "0x186323E10")]
	[IteratorStateMachine(typeof(ADFLIMDFEGK))]
	private IEnumerator<JHKLHFOKPOC> AHNALEBNAIN(Action OPPJFEGMJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6323E90", Offset = "0x6322C90", VA = "0x186323E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x63241F0", Offset = "0x6322FF0", VA = "0x1863241F0")]
	[CompilerGenerated]
	private void MBABAPCDNHH(string KHAMCNNBIHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class IAHFNHBHPOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class BFDHBCAFHPD : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private JHKLHFOKPOC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public BFDHBCAFHPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6319CB0", Offset = "0x6318AB0", VA = "0x186319CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x631CC20", Offset = "0x631BA20", VA = "0x18631CC20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private KFKJPENGGJI KOHFHEMFCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour POCMKOMIDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action ONOFJJKGLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> CPHBMILODBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private CBKJDEDPNLB COGIGCIJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float FMGPPNOBMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool NGPEFAGKCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly NMEKMIOKOHP EHMKGIGLLPH;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6327AE0", Offset = "0x63268E0", VA = "0x186327AE0")]
	public IAHFNHBHPOD(MonoBehaviour POCMKOMIDEC, Action ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x63278A0", Offset = "0x63266A0", VA = "0x1863278A0")]
	public IAHFNHBHPOD(MonoBehaviour POCMKOMIDEC, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6327650", Offset = "0x6326450", VA = "0x186327650")]
	public IAHFNHBHPOD(MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x17DBB00", Offset = "0x17DA900", VA = "0x1817DBB00")]
	private IAHFNHBHPOD(NMEKMIOKOHP EHMKGIGLLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6327090", Offset = "0x6325E90", VA = "0x186327090")]
	internal static IAHFNHBHPOD JENEKNBKABL(MonoBehaviour POCMKOMIDEC, float CPEIALAAAKH, Action<float> ONOFJJKGLBH, CBKJDEDPNLB COGIGCIJCHO, bool NGPEFAGKCHE = true, [Optional] NMEKMIOKOHP EHMKGIGLLPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6326DF0", Offset = "0x6325BF0", VA = "0x186326DF0")]
	private void GDIPHNMNNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6326C40", Offset = "0x6325A40", VA = "0x186326C40")]
	private void FKLAJNDHBAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x63271C0", Offset = "0x6325FC0", VA = "0x1863271C0")]
	private void JOEBIHNDOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6327370", Offset = "0x6326170", VA = "0x186327370")]
	private void KIKGOPPAELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6326F60", Offset = "0x6325D60", VA = "0x186326F60")]
	private void GKJCOAFMHAK(string HIFPPFEDDLE, Action OPPJFEGMJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6326A40", Offset = "0x6325840", VA = "0x186326A40")]
	[IteratorStateMachine(typeof(BFDHBCAFHPD))]
	private IEnumerator<JHKLHFOKPOC> AHNALEBNAIN(Action OPPJFEGMJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6326B50", Offset = "0x6325950", VA = "0x186326B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6326BB0", Offset = "0x63259B0", VA = "0x186326BB0")]
	[CompilerGenerated]
	private void FGPEEHNMGDE(string KHAMCNNBIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6326AC0", Offset = "0x63258C0", VA = "0x186326AC0")]
	[CompilerGenerated]
	private void DFMCPDBEFGG(string KHAMCNNBIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x63275C0", Offset = "0x63263C0", VA = "0x1863275C0")]
	[CompilerGenerated]
	private void PGLDKIHBMAI(string KHAMCNNBIHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6327530", Offset = "0x6326330", VA = "0x186327530")]
	[CompilerGenerated]
	private void OMCOCNPLMAO(string KHAMCNNBIHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum PHMOHHKCOAH : byte
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
internal sealed class HGEHCKJPLCP : JMGGMPODBLM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float HEMKPPNPGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6325100", Offset = "0x6323F00", VA = "0x186325100", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float IKKCFOFHFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x63250F0", Offset = "0x6323EF0", VA = "0x1863250F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double NIEHKCGFBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6325110", Offset = "0x6323F10", VA = "0x186325110", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6325080", Offset = "0x6323E80", VA = "0x186325080")]
	[DJDJPHIPNFL(IEJLPKKICHC.None)]
	private static void AMIIDJBEOMM(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	[Preserve]
	internal HGEHCKJPLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface JHPBBFABIKN
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNJLLBHNMJN(string MEBBBIMBIJO);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGFEEMDKNCM();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface CHIJEFKOOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool LPNKMMHJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool MPGAFDNFCPB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class IPBMKHKFONA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public JOGPDFEOJIE GHCLELCBFHK;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FCFMLMDMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x75D180", Offset = "0x75BF80", VA = "0x18075D180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x76B340", Offset = "0x76A140", VA = "0x18076B340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6328CE0", Offset = "0x6327AE0", VA = "0x186328CE0")]
	public static JHKLHFOKPOC KNKGJDHKCMJ(IEnumerator<JHKLHFOKPOC> OFNEFDBLHEE, BPCONOBGKPE CJGEKBJNNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6328E40", Offset = "0x6327C40", VA = "0x186328E40")]
	public JHKLHFOKPOC KNKGJDHKCMJ(BPCONOBGKPE[] HAJAMOKGNNL, IEnumerator<JHKLHFOKPOC>[] BOALOAIELEO, JHKLHFOKPOC[] MBKPFMAMBBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6328CB0", Offset = "0x6327AB0", VA = "0x186328CB0")]
	public void EOABDMIGFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6328A30", Offset = "0x6327830", VA = "0x186328A30")]
	public void CBJDONAHFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6328B70", Offset = "0x6327970", VA = "0x186328B70")]
	public void CGFPHJDKOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6328CB0", Offset = "0x6327AB0", VA = "0x186328CB0")]
	public void NFNENOCCILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IPBMKHKFONA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class JOGPDFEOJIE
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JKPNNLMBJIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public IPBMKHKFONA DEHKPDKJLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IHILHGKIJFA DAMHEOAPJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BPCONOBGKPE GCNMAINMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<JHKLHFOKPOC> NNJAJADBKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JHKLHFOKPOC BFJAHKLNJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PHMOHHKCOAH IHHOPJHONDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct MPAFOGMJIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CBKJDEDPNLB JJGEJKLBEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<JKPNNLMBJIK> JCEDLPFIIEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class NEELBPLDNFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BPCONOBGKPE promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public JOGPDFEOJIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public IHILHGKIJFA context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public IPBMKHKFONA routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public PHMOHHKCOAH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JHKLHFOKPOC currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<JHKLHFOKPOC> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NEELBPLDNFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6330AC0", Offset = "0x632F8C0", VA = "0x186330AC0")]
		internal void JLHECHAGKNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class BPCNJMDLCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IPBMKHKFONA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public JOGPDFEOJIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BPCNJMDLCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x631D1B0", Offset = "0x631BFB0", VA = "0x18631D1B0")]
		internal void MJALNBKGENM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BNAFBLFILCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IPBMKHKFONA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public JOGPDFEOJIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BNAFBLFILCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x631D170", Offset = "0x631BF70", VA = "0x18631D170")]
		internal void FAKLCKCJAJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class AAAFINKOIMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IPBMKHKFONA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JOGPDFEOJIE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AAAFINKOIMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6319C40", Offset = "0x6318A40", VA = "0x186319C40")]
		internal void MINLPLPHPHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const PHMOHHKCOAH IDCMNECAFNP = PHMOHHKCOAH.Cancelled | PHMOHHKCOAH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly CBKJDEDPNLB COGIGCIJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] CGBPAPPILBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<PHMOHHKCOAH> DJKMOCDOJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> EDCKPCHDHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> DHKPJDDLCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> NIACMOAFCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> KOJIKMMHOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> APHGFMIKDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> KPKPKKGCLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private IPBMKHKFONA[] MNOLGLOIKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BPCONOBGKPE[] HAJAMOKGNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IHILHGKIJFA[] KFMHMKLMMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<JHKLHFOKPOC>[] HCENKEIHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private JHKLHFOKPOC[] GGEBEGKIGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int FHNNLLBFIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int LCFOKPAENOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int NHIJMHDNLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float BFLOOIFOKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NMGELCAFJHN BCFNJMLHAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle FMLNPIJGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<IPBMKHKFONA> GOKPLJOAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool FGBOHMHEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> CLGBADOPNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> KBBFIEKIGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool CNGLICAGNGK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public MPAFOGMJIPB[] BINDBIBLJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8B91D0", Offset = "0x8B7FD0", VA = "0x1808B91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6329F60", Offset = "0x6328D60", VA = "0x186329F60")]
	private static int BJEJGEBFMJG(CBKJDEDPNLB COGIGCIJCHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x632BE80", Offset = "0x632AC80", VA = "0x18632BE80")]
	public JOGPDFEOJIE(CBKJDEDPNLB COGIGCIJCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x632ACA0", Offset = "0x6329AA0", VA = "0x18632ACA0")]
	private void EDOLALPHKGM(int CIPJHPLOPOM, int GFCAFCJFLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x632BA50", Offset = "0x632A850", VA = "0x18632BA50")]
	public void OEGONIKNFEF(IHILHGKIJFA DDMHMHFODEB, JHKLHFOKPOC OGEHMOJIBDD, IEnumerator<JHKLHFOKPOC> OFNEFDBLHEE, BPCONOBGKPE CJGEKBJNNGI, [Optional] IPBMKHKFONA POHFGBGPOLN, PHMOHHKCOAH DCPAJLHBMNA = PHMOHHKCOAH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6329D20", Offset = "0x6328B20", VA = "0x186329D20")]
	public void APDLEJAKMAI(IEnumerable<JKPNNLMBJIK> HCNLPBBKMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6329F90", Offset = "0x6328D90", VA = "0x186329F90")]
	private JKPNNLMBJIK BODBGMLDOCM(int GEPDAAJEJNE)
	{
		return default(JKPNNLMBJIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x632A800", Offset = "0x6329600", VA = "0x18632A800")]
	private void DGNIHNNNIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2413560", Offset = "0x2412360", VA = "0x182413560")]
	private static void FBAFHNABHFA<T>(int GEPDAAJEJNE, T[] NDMMMCMLHOG, int GINFBCJKIJI, [Optional] T JBLDMALIHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x24135B0", Offset = "0x24123B0", VA = "0x1824135B0")]
	private static void FBAFHNABHFA<T>(int GEPDAAJEJNE, NativeArray<T> NDMMMCMLHOG, int GINFBCJKIJI, [Optional] T JBLDMALIHLL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x632A460", Offset = "0x6329260", VA = "0x18632A460")]
	private void CNBPEACIKAO(IEnumerable<JKPNNLMBJIK> HCNLPBBKMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x632B990", Offset = "0x632A790", VA = "0x18632B990")]
	private void ODGLOHOODGL(JKPNNLMBJIK DMBIJDFBEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x632AF00", Offset = "0x6329D00", VA = "0x18632AF00")]
	private IKJOFLFEAOD HNIOCBGLEGE(int HHNAFOOGJOH)
	{
		return default(IKJOFLFEAOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6329B20", Offset = "0x6328920", VA = "0x186329B20")]
	public void AFCLEGCGACP(float MGPAONHKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x632AE80", Offset = "0x6329C80", VA = "0x18632AE80")]
	private void FKBJAGCDKHO(Action APOJANFJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x632BCD0", Offset = "0x632AAD0", VA = "0x18632BCD0")]
	private void OJGIDAAACOL(Action APOJANFJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x632B160", Offset = "0x6329F60", VA = "0x18632B160")]
	public void HPHMKMIBICB(float MGPAONHKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x632BBD0", Offset = "0x632A9D0", VA = "0x18632BBD0")]
	public void OGJJNAJKDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x632B860", Offset = "0x632A660", VA = "0x18632B860")]
	public void NFNENOCCILA(IPBMKHKFONA AMOAFOKOCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x632BD50", Offset = "0x632AB50", VA = "0x18632BD50")]
	public void PHMEHGNBANK(IPBMKHKFONA AMOAFOKOCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x632AB70", Offset = "0x6329970", VA = "0x18632AB70")]
	public void EBDOMOIPHOJ(IPBMKHKFONA AMOAFOKOCCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IPFADEHCPEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly IPFADEHCPEO HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action MCEFAEIDKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool ICPHJFMOKBC;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public IPFADEHCPEO(Action MCEFAEIDKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6328F00", Offset = "0x6327D00", VA = "0x186328F00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface CGLMHOGIHJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DBHAJLIAKAD(UnityEngine.Object DDMHMHFODEB, Action<T> DBDFBGCPIKA);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface IFBPPNMLIPD<T> : CGLMHOGIHJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GKIDOAKADJB<T> : IFBPPNMLIPD<T>, CGLMHOGIHJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class EOLMMGDPJHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public GKIDOAKADJB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public GNFMGDAHMOJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public EOLMMGDPJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3053D10", Offset = "0x3052B10", VA = "0x183053D10")]
		internal void DAOAAAADIMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject IHOCBFOJLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<GNFMGDAHMOJ<UnityEngine.Object, Action<T>>> MMDKHKFOMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T CPAOFJJJBGN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T CAGIMKNDHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x352E050", Offset = "0x352CE50", VA = "0x18352E050", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x352E150", Offset = "0x352CF50", VA = "0x18352E150")]
	private static bool PIOJJFFHKNM(T APOJANFJHJO, T DFBIFCHBAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x352E250", Offset = "0x352D050", VA = "0x18352E250")]
	public GKIDOAKADJB(T KLFHKICPEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x352D6D0", Offset = "0x352C4D0", VA = "0x18352D6D0", Slot = "6")]
	public IDisposable DBHAJLIAKAD(UnityEngine.Object DDMHMHFODEB, Action<T> DBDFBGCPIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x352D9F0", Offset = "0x352C7F0", VA = "0x18352D9F0")]
	private void IKDDPJEAHDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class HAOONMCNGGA : HJKICJJJMKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly NMEKMIOKOHP EHMKGIGLLPH;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6324F60", Offset = "0x6323D60", VA = "0x186324F60")]
	[DJDJPHIPNFL(IEJLPKKICHC.None)]
	private static void AMIIDJBEOMM(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	[Preserve]
	internal HAOONMCNGGA([FGPOJKOJBFM(null)] NMEKMIOKOHP EHMKGIGLLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6324FD0", Offset = "0x6323DD0", VA = "0x186324FD0", Slot = "4")]
	public IDisposable MIOJCMCPLMO(float CPEIALAAAKH, Action<float> PMOMGAGBHKB, bool NGPEFAGKCHE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class AJJGOFDIMHP : ANNFPPABHNK, NMEKMIOKOHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private JOGPDFEOJIE[] KHBFIPCHLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private JHPBBFABIKN CDPPJODPONH;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x631A070", Offset = "0x6318E70", VA = "0x18631A070")]
	[DJDJPHIPNFL(IEJLPKKICHC.None)]
	private static void AMIIDJBEOMM(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x631ACA0", Offset = "0x6319AA0", VA = "0x18631ACA0")]
	[Preserve]
	public AJJGOFDIMHP([FGPOJKOJBFM(null)] CPHGMPIAMOD JMNECMBJBMB, [FGPOJKOJBFM(null)] JMGGMPODBLM BCODCCIMCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x631A510", Offset = "0x6319310", VA = "0x18631A510", Slot = "16")]
	public override KFKJPENGGJI GGIMIDPMMOJ(IHILHGKIJFA DDMHMHFODEB, IEnumerator<JHKLHFOKPOC> BKKEJGLBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x631A870", Offset = "0x6319670", VA = "0x18631A870", Slot = "17")]
	public override void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x631A260", Offset = "0x6319060", VA = "0x18631A260", Slot = "19")]
	public override void EDKKOANPJKO(CBKJDEDPNLB COGIGCIJCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x631AB00", Offset = "0x6319900", VA = "0x18631AB00", Slot = "18")]
	protected override void NCDLFODJGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x631AC70", Offset = "0x6319A70", VA = "0x18631AC70")]
	private JOGPDFEOJIE PCMMMHADNEN(CBKJDEDPNLB FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x631A640", Offset = "0x6319440", VA = "0x18631A640", Slot = "20")]
	internal override GMDKOFDMPEI HKFEBNKCGML(IEnumerator<JHKLHFOKPOC> BKKEJGLBBBO, Behaviour DDMHMHFODEB, BPCONOBGKPE CJGEKBJNNGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x631A490", Offset = "0x6319290", VA = "0x18631A490", Slot = "21")]
	internal override MJCHOJHIADP FKGMMFKDBMI(CBKJDEDPNLB IMNBHGEKNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x631A140", Offset = "0x6318F40", VA = "0x18631A140")]
	private void EDECFDDKEFM(JOGPDFEOJIE PKHMONFIOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x631A0E0", Offset = "0x6318EE0", VA = "0x18631A0E0", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct NMGELCAFJHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float IPJKKIEJKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int DCNFNMAFNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> OPIAENPEFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> HLAFNGBOEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> FIIJOEANCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<PHMOHHKCOAH> GHEDLPDPMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> AEEHPPAJDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> KOJIKMMHOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> DHKPJDDLCOP;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6332290", Offset = "0x6331090", VA = "0x186332290")]
	public static NMGELCAFJHN FLMMCOJOBIA(int PDAJALLFAJB, float MGPAONHKGHN, NativeArray<PHMOHHKCOAH> ANLHJBMDCJA, NativeArray<float> FMHJGHLFDKN, NativeArray<int> PGGBCOOCHFM, NativeArray<int> HJLIJHHHKKN, NativeArray<int> PIGBEMLEIFO, NativeArray<int> HLAFNGBOEGJ, NativeArray<int> FIIJOEANCFN)
	{
		return default(NMGELCAFJHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6331F70", Offset = "0x6330D70", VA = "0x186331F70", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6331F30", Offset = "0x6330D30", VA = "0x186331F30")]
	private bool EDHHKAOPFAC(int OCMJNDDMDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6332390", Offset = "0x6331190", VA = "0x186332390")]
	private void KGIIJHCMGJJ(NativeArray<int> GGEKJGOLDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x63322F0", Offset = "0x63310F0", VA = "0x1863322F0")]
	private int GBMHDHDAFFO(int CEFAJHMEDGG, int MFIBHLOOFNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x63323C0", Offset = "0x63311C0", VA = "0x1863323C0")]
	private void LKKGBPDEECH(NativeArray<int> GGEKJGOLDKP, int GFDEBNCCDDA, int CAAEKLGIBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6332050", Offset = "0x6330E50", VA = "0x186332050")]
	private void FFMHKFHBHEH(NativeArray<int> GGEKJGOLDKP, int PNDKBKJIMJB, int LLPDLFFBFPK, int GIIGNGNIBOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class ANNFPPABHNK : NMEKMIOKOHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly CPHGMPIAMOD JMNECMBJBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly JMGGMPODBLM BCODCCIMCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private MJCHOJHIADP[] MEJEBKHGNIK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static NMEKMIOKOHP IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x631B1D0", Offset = "0x6319FD0", VA = "0x18631B1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CBKJDEDPNLB PINOAEIFGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x75D180", Offset = "0x75BF80", VA = "0x18075D180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CBKJDEDPNLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76B340", Offset = "0x76A140", VA = "0x18076B340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JMGGMPODBLM HLODCOGAAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public JHKLHFOKPOC JBJCNPIKENE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x631B6D0", Offset = "0x631A4D0", VA = "0x18631B6D0")]
	public static KFKJPENGGJI GKMGDAELIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x631BF40", Offset = "0x631AD40", VA = "0x18631BF40")]
	[Preserve]
	protected ANNFPPABHNK([FGPOJKOJBFM(null)] CPHGMPIAMOD JMNECMBJBMB, [FGPOJKOJBFM(null)] JMGGMPODBLM BCODCCIMCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x631B7E0", Offset = "0x631A5E0", VA = "0x18631B7E0", Slot = "6")]
	public KFKJPENGGJI INEHGKEHGLC(IEnumerator<JHKLHFOKPOC> BKKEJGLBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x631B7F0", Offset = "0x631A5F0", VA = "0x18631B7F0", Slot = "7")]
	public KFKJPENGGJI INEHGKEHGLC(Behaviour DDMHMHFODEB, IEnumerator<JHKLHFOKPOC> BKKEJGLBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract KFKJPENGGJI GGIMIDPMMOJ(IHILHGKIJFA DDMHMHFODEB, IEnumerator<JHKLHFOKPOC> BKKEJGLBBBO);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x631BB00", Offset = "0x631A900", VA = "0x18631BB00", Slot = "17")]
	public virtual void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x631BCA0", Offset = "0x631AAA0", VA = "0x18631BCA0", Slot = "9")]
	public void MENDMLCBIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x631BF00", Offset = "0x631AD00", VA = "0x18631BF00", Slot = "18")]
	protected virtual void NCDLFODJGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x631BF20", Offset = "0x631AD20", VA = "0x18631BF20")]
	private void NLDFJMCGCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x631BA80", Offset = "0x631A880", VA = "0x18631BA80")]
	private void KHNGGAJMPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x631B7C0", Offset = "0x631A5C0", VA = "0x18631B7C0")]
	private void ILGLEEIALCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x631B5E0", Offset = "0x631A3E0", VA = "0x18631B5E0")]
	private void ECIOPMJCBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x631BEE0", Offset = "0x631ACE0", VA = "0x18631BEE0")]
	private void NALOLAHBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x631B6B0", Offset = "0x631A4B0", VA = "0x18631B6B0")]
	private void GHOPLIDKGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x631B690", Offset = "0x631A490", VA = "0x18631B690")]
	private void ENLFCGEBPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x631B600", Offset = "0x631A400", VA = "0x18631B600", Slot = "19")]
	public virtual void EDKKOANPJKO(CBKJDEDPNLB COGIGCIJCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x631B000", Offset = "0x6319E00", VA = "0x18631B000")]
	private void CDOJDILANNM(MJCHOJHIADP PKHMONFIOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B90360", Offset = "0x1B8F160", VA = "0x181B90360")]
	private MJCHOJHIADP ECILFPFNOPC(CBKJDEDPNLB FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract GMDKOFDMPEI HKFEBNKCGML(IEnumerator<JHKLHFOKPOC> BKKEJGLBBBO, Behaviour POCMKOMIDEC, BPCONOBGKPE IKNGMBMIOPD);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract MJCHOJHIADP FKGMMFKDBMI(CBKJDEDPNLB COGIGCIJCHO);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x631B220", Offset = "0x631A020", VA = "0x18631B220", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x631BAA0", Offset = "0x631A8A0", VA = "0x18631BAA0", Slot = "12")]
	public JHKLHFOKPOC KJEJINLBHOC(CBKJDEDPNLB IMNBHGEKNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x631B9F0", Offset = "0x631A7F0", VA = "0x18631B9F0", Slot = "13")]
	public JHKLHFOKPOC JECFGLLEJMG(float NNDFFBJHCAM, CBKJDEDPNLB IMNBHGEKNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x631B760", Offset = "0x631A560", VA = "0x18631B760", Slot = "14")]
	public JHKLHFOKPOC IDEOGNIELID(Func<bool> FAKFOJBAANF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class GMDKOFDMPEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly BPCONOBGKPE CJGEKBJNNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly CHIJEFKOOEG DDMHMHFODEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool FGLOAPMFENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string MEBBBIMBIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace BPBBCOHPKPM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<JHKLHFOKPOC> NNJAJADBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JHKLHFOKPOC BFJAHKLNJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LACDJKOHLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x63245F0", Offset = "0x63233F0", VA = "0x1863245F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool ONONMJCLHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x857F80", Offset = "0x856D80", VA = "0x180857F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x856A80", Offset = "0x855880", VA = "0x180856A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x63249D0", Offset = "0x63237D0", VA = "0x1863249D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float CIEEGFFMNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xF7F110", Offset = "0xF7DF10", VA = "0x180F7F110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x53293A0", Offset = "0x53281A0", VA = "0x1853293A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6324C60", Offset = "0x6323A60", VA = "0x186324C60")]
	public GMDKOFDMPEI(IEnumerator<JHKLHFOKPOC> OFNEFDBLHEE, CHIJEFKOOEG DDMHMHFODEB, BPCONOBGKPE CJGEKBJNNGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6324670", Offset = "0x6323470", VA = "0x186324670")]
	public JHKLHFOKPOC KNKGJDHKCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6324580", Offset = "0x6323380", VA = "0x186324580")]
	public bool CNPKNEEBGOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6324980", Offset = "0x6323780", VA = "0x186324980")]
	public void NFNENOCCILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6324B80", Offset = "0x6323980", VA = "0x186324B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7CDDA0", Offset = "0x7CCBA0", VA = "0x1807CDDA0")]
	[CompilerGenerated]
	private void ODNJEPFMOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class BPCONOBGKPE : ACNHLECFALL, KFKJPENGGJI, GJDHHHJOJJP, MMMPEMHFGNJ, IEnumerator, JHKLHFOKPOC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private CBKJDEDPNLB MHOCCPKAMGN;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private CBKJDEDPNLB CNPGMEANPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xD0B130", Offset = "0xD09F30", VA = "0x180D0B130", Slot = "23")]
		get
		{
			return default(CBKJDEDPNLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CBKJDEDPNLB GHCLELCBFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x11F2420", Offset = "0x11F1220", VA = "0x1811F2420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float NFEIOJCCENM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B0DB0", VA = "0x1807B1FB0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool JIFIFFCCDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x631D1F0", Offset = "0x631BFF0", VA = "0x18631D1F0", Slot = "24")]
	private bool CJPOAPAFKBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x631D210", Offset = "0x631C010", VA = "0x18631D210", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x631D220", Offset = "0x631C020", VA = "0x18631D220")]
	public BPCONOBGKPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum IKJOFLFEAOD : byte
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
internal sealed class MJCHOJHIADP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum LECNDCPENKB
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct MBONAGNDNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CBKJDEDPNLB JJGEJKLBEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public LECNDCPENKB BDFPIADCNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<GMDKOFDMPEI> EEFAIFEINJG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly LECNDCPENKB[] JEJEHNBPGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly CBKJDEDPNLB COGIGCIJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool FMGEFJIDKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly GMDKOFDMPEI[] MBICFPGJAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<GMDKOFDMPEI> JOEEKGOFHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> AKMDKEPFNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<GMDKOFDMPEI> IFOCCLIKFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> MPCHCDLAGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly JHPBBFABIKN LNGBJGEHNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool CNGLICAGNGK;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MBONAGNDNNM[,] KMBGPNALCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6330250", Offset = "0x632F050", VA = "0x186330250")]
	public MJCHOJHIADP(CBKJDEDPNLB IMNBHGEKNIE, JHPBBFABIKN LNGBJGEHNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x632F6E0", Offset = "0x632E4E0", VA = "0x18632F6E0")]
	public void KBJEJHEAAKC(GMDKOFDMPEI OFNEFDBLHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x632F3D0", Offset = "0x632E1D0", VA = "0x18632F3D0")]
	public void JJGMCKLAMCI(IList<GMDKOFDMPEI> BOALOAIELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x632FE00", Offset = "0x632EC00", VA = "0x18632FE00")]
	public void NKFAGGFBKHC(IList<GMDKOFDMPEI> BOALOAIELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x632F030", Offset = "0x632DE30", VA = "0x18632F030")]
	private void DCFKOBNAEAM(GMDKOFDMPEI OFNEFDBLHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x632F240", Offset = "0x632E040", VA = "0x18632F240")]
	private void JHLOCGPEMAK(IList<GMDKOFDMPEI> BOALOAIELEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x632F920", Offset = "0x632E720", VA = "0x18632F920")]
	private IKJOFLFEAOD LBGCJFLOGOC(GMDKOFDMPEI OFNEFDBLHEE)
	{
		return default(IKJOFLFEAOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x632FC90", Offset = "0x632EA90", VA = "0x18632FC90")]
	public void NCDLFODJGAN(float MGPAONHKGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x632FAA0", Offset = "0x632E8A0", VA = "0x18632FAA0")]
	public void MENDMLCBIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x632ED30", Offset = "0x632DB30", VA = "0x18632ED30")]
	private void AMGKCEHFOFG(List<GMDKOFDMPEI> BOALOAIELEO, Stack<int> NAJNCJLHBGO, bool PCJJEINGGLH, float CINEHHNLPKP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x632F120", Offset = "0x632DF20", VA = "0x18632F120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x632F7E0", Offset = "0x632E5E0", VA = "0x18632F7E0")]
	private void KKGNJHACFIF(List<GMDKOFDMPEI> BOALOAIELEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class FAECPAPPBNI : JHPBBFABIKN
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void DNJLLBHNMJN(string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
	public void LGFEEMDKNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FAECPAPPBNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class BJGCPFOODOO : CHIJEFKOOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour POCMKOMIDEC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x631CCE0", Offset = "0x631BAE0", VA = "0x18631CCE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LPNKMMHJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x631CC90", Offset = "0x631BA90", VA = "0x18631CC90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MPGAFDNFCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x631CC70", Offset = "0x631BA70", VA = "0x18631CC70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public BJGCPFOODOO(Behaviour POCMKOMIDEC)
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

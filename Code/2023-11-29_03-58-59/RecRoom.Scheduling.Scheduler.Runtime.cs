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
public class NOLCFHNDKIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority OOMBPJFFBAD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x650C570", Offset = "0x650B970", VA = "0x18650C570")]
	public NOLCFHNDKIB(ThreadPriority MFBPFEDIHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x650C560", Offset = "0x650B960", VA = "0x18650C560", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> DFLLMBFCPEP(List<PlayerLoopSystem> NKODNOBODNE, int OBOJKJFMCDO);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct INCBFGDFMBI
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct KMICHJGIAMB
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static FCJKIAIKOOM JIFJCLHFPKD;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6507E50", Offset = "0x6507250", VA = "0x186507E50")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct CMBDJOLPKKA
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static FCJKIAIKOOM MGHMGDCPDBB;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x64F83F0", Offset = "0x64F77F0", VA = "0x1864F83F0")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct BENCGCJLFMF
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static FCJKIAIKOOM EODLECMDMNL;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x64F51A0", Offset = "0x64F45A0", VA = "0x1864F51A0")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct CJGADEOFMCC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static FCJKIAIKOOM CHGHICHBFNK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static FCJKIAIKOOM BFODNODGKMJ;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static FCJKIAIKOOM GDLLBFNMMEI;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static FCJKIAIKOOM EFHDGHEFGEN;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x64F8100", Offset = "0x64F7500", VA = "0x1864F8100")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GKAEOENJNPC
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static FCJKIAIKOOM OFHMNOPFBFI;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6501E10", Offset = "0x6501210", VA = "0x186501E10")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct OHCGFGDIKDP
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static FCJKIAIKOOM CHGHICHBFNK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static FCJKIAIKOOM BFODNODGKMJ;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static FCJKIAIKOOM GDLLBFNMMEI;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static FCJKIAIKOOM EFHDGHEFGEN;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x650D420", Offset = "0x650C820", VA = "0x18650D420")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct LPDFPKOKCGB
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static FCJKIAIKOOM FIHAJOBLGFE;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x650B340", Offset = "0x650A740", VA = "0x18650B340")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct BPIDHAFKLMO
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static FCJKIAIKOOM BCCNCGIHPAC;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x64F5EA0", Offset = "0x64F52A0", VA = "0x1864F5EA0")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct EDNMMFFNDEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static FCJKIAIKOOM EKEOAANFIFA;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x64FE4A0", Offset = "0x64FD8A0", VA = "0x1864FE4A0")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct JAFOPCCADCH
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static FCJKIAIKOOM MDCPPDBNNGD;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6504610", Offset = "0x6503A10", VA = "0x186504610")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct IHPAEMJDGIK
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static FCJKIAIKOOM PBOPPCNHIDA;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6503FE0", Offset = "0x65033E0", VA = "0x186503FE0")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct BHAHGKCKIJC
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static FCJKIAIKOOM OMFOGKJBJDF;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x64F5970", Offset = "0x64F4D70", VA = "0x1864F5970")]
				public static PlayerLoopSystem NKCAEPLEGOC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum IHEGNDMADLN : byte
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
			public struct INMPFJJOKGI
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class DOBHFHOGLOA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public IHEGNDMADLN updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
					public DOBHFHOGLOA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x64FE420", Offset = "0x64FD820", VA = "0x1864FE420")]
					internal void GPNELFKIBPG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static CFBCANLCDFG<IHEGNDMADLN> DFJAKKOFCOM;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6504390", Offset = "0x6503790", VA = "0x186504390")]
				public static PlayerLoopSystem NKCAEPLEGOC(IHEGNDMADLN JPIJKEHBCOI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct JNPHDCMHHLC
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class GCPPDAMPCDA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public BFFODOABBJG.KMKHEOMGJMP key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
					public GCPPDAMPCDA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6500CC0", Offset = "0x65000C0", VA = "0x186500CC0")]
					internal void JIODCHABOJG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable EFJFAAGFHPM;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6505B90", Offset = "0x6504F90", VA = "0x186505B90")]
				public static PlayerLoopSystem KJEPIHMAHGE(BFFODOABBJG.KMKHEOMGJMP MIMFBLPNKOG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct CNFNDEBNBOC
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class PNCLCAMHPEE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public BFFODOABBJG.KMKHEOMGJMP key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
					public PNCLCAMHPEE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x650F820", Offset = "0x650EC20", VA = "0x18650F820")]
					internal void JIODCHABOJG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x64F8E90", Offset = "0x64F8290", VA = "0x1864F8E90")]
				public static PlayerLoopSystem KJEPIHMAHGE(BFFODOABBJG.KMKHEOMGJMP MIMFBLPNKOG)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class HMBBCDNKEJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public HMBBCDNKEJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6502F80", Offset = "0x6502380", VA = "0x186502F80")]
			internal List<PlayerLoopSystem> OLIOIJLNKMB(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool EHNBHPPIOOL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HEJAMABCBKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x64FC900", Offset = "0x64FBD00", VA = "0x1864FC900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64F9700", Offset = "0x64F8B00", VA = "0x1864F9700")]
		private static void LPLKGBDFJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64FC030", Offset = "0x64FB430", VA = "0x1864FC030")]
		private static void MGJBCDHHJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64F8FC0", Offset = "0x64F83C0", VA = "0x1864F8FC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64FC940", Offset = "0x64FBD40", VA = "0x1864FC940")]
		private static void PJOOIKJBKHN(BFFODOABBJG.KMKHEOMGJMP MIMFBLPNKOG, PlayerLoopSystem MCPKKGEHINI, Type LOIMIJKHFOA, Type HPJDIBJMCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64F9320", Offset = "0x64F8720", VA = "0x1864F9320")]
		private static void FNCHDOPLDJA(PlayerLoopSystem MCPKKGEHINI, Type LOIMIJKHFOA, Type HPJDIBJMCME, DFLLMBFCPEP PCANPNGLOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64F91F0", Offset = "0x64F85F0", VA = "0x1864F91F0")]
		private static void DKNGENAGNGK(PlayerLoopSystem MCPKKGEHINI, Type LOIMIJKHFOA, Type HPJDIBJMCME, PlayerLoopSystem? AEFEFHFJHAP, PlayerLoopSystem? MKIBPLGMFIG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BFFODOABBJG
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum KMKHEOMGJMP
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
	public class CCPEECNMCOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly KMKHEOMGJMP DMCHIDLCBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly APLLIPNICAC AGOOJNPNEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long NDIHPFMLNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long ENACCCMAMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long CFFDDJKFCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int GNKLGKJPHPM;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64F6340", Offset = "0x64F5740", VA = "0x1864F6340")]
		public CCPEECNMCOC(KMKHEOMGJMP MICEBNFDIOD, int DDNPMOLNDAI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64F60A0", Offset = "0x64F54A0", VA = "0x1864F60A0")]
		public void AOCBBGDBCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64F6110", Offset = "0x64F5510", VA = "0x1864F6110")]
		public void IJCHMBCCEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64F6160", Offset = "0x64F5560", VA = "0x1864F6160")]
		public void OAJBFJHDMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static KMKHEOMGJMP[] PAOEDNMKPOC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static CCPEECNMCOC[] NPNBDHDEELN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64F53A0", Offset = "0x64F47A0", VA = "0x1864F53A0")]
	public static CCPEECNMCOC BAJOPHNMIJC(KMKHEOMGJMP MIMFBLPNKOG, int DDNPMOLNDAI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64F5620", Offset = "0x64F4A20", VA = "0x1864F5620")]
	public static CCPEECNMCOC JDAAKJJOPND(KMKHEOMGJMP MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64F5580", Offset = "0x64F4980", VA = "0x1864F5580")]
	public static void HBEBCCHCIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class APLLIPNICAC : CEBMGDGEGLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int FINPOPJEFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> JPGMKOAEJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double COIHINIONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double COOPJHPKDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double IIJNICJHBEB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MNGMHBONMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64F4FC0", Offset = "0x64F43C0", VA = "0x1864F4FC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double DLBOJBKDCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1701F50", Offset = "0x1701350", VA = "0x181701F50", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KFADEEOFAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C961D0", Offset = "0x1C955D0", VA = "0x181C961D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64F5020", Offset = "0x64F4420", VA = "0x1864F5020")]
	public APLLIPNICAC(int KCBGGHNLING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64F4E30", Offset = "0x64F4230", VA = "0x1864F4E30", Slot = "7")]
	public void DFKPCPOCNKP(double OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64F4F50", Offset = "0x64F4350", VA = "0x1864F4F50", Slot = "8")]
	public void MADHOJJNIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KDLCBHBDFAI : CEBMGDGEGLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long APAKJDHFMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double MJDFNHOEKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double HAJKELPLGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double JBCIJJBNJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double KNAIFIMFHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double COIHINIONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double COOPJHPKDNO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double DLBOJBKDCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x54A7DB0", Offset = "0x54A71B0", VA = "0x1854A7DB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KFADEEOFAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x54A7920", Offset = "0x54A6D20", VA = "0x1854A7920", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double IFKLHOFKHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x54A7900", Offset = "0x54A6D00", VA = "0x1854A7900")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MNGMHBONMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x209EF00", Offset = "0x209E300", VA = "0x18209EF00", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6507610", Offset = "0x6506A10", VA = "0x186507610", Slot = "7")]
	public virtual void DFKPCPOCNKP(double OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6507730", Offset = "0x6506B30", VA = "0x186507730", Slot = "8")]
	public virtual void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6507770", Offset = "0x6506B70", VA = "0x186507770")]
	public KDLCBHBDFAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OFKGHDLHLCH : KDLCBHBDFAI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double AKBPLAMNLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x54A78E0", Offset = "0x54A6CE0", VA = "0x1854A78E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x54A78B0", Offset = "0x54A6CB0", VA = "0x1854A78B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x650D260", Offset = "0x650C660", VA = "0x18650D260", Slot = "7")]
	public override void DFKPCPOCNKP(double OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x650D390", Offset = "0x650C790", VA = "0x18650D390", Slot = "8")]
	public override void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6507770", Offset = "0x6506B70", VA = "0x186507770")]
	public OFKGHDLHLCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CEBMGDGEGLG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MNGMHBONMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double DLBOJBKDCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double KFADEEOFAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class JHPCKKLEEKB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface LKMGLEKIFCP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool IKKDGPLBKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GIIIEODFHFB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class MKKIKBJCGPA<TPromise, TMainThreadPromise> : LKMGLEKIFCP where TPromise : AIDJGFFPANM where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise MBNHGEOGCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise EAMMGFCGFEA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise AIGLEEBMPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x3CCE550", Offset = "0x3CCD950", VA = "0x183CCE550")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IKKDGPLBKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3CCE4E0", Offset = "0x3CCD8E0", VA = "0x183CCE4E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77CB20", Offset = "0x77BF20", VA = "0x18077CB20")]
		protected MKKIKBJCGPA(TPromise MBNHGEOGCCI, TMainThreadPromise LDNKJENEMGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE530", Offset = "0x3CCD930", VA = "0x183CCE530", Slot = "5")]
		public void GIIIEODFHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void CKKILGLACHC(TPromise MBNHGEOGCCI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class JFKAPCDGJCM<T> : MKKIKBJCGPA<CJNEKNCGBDK<T>, MABLGKOHHEM<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x38F0D10", Offset = "0x38F0110", VA = "0x1838F0D10")]
		public JFKAPCDGJCM(CJNEKNCGBDK<T> MBNHGEOGCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x38F0B90", Offset = "0x38EFF90", VA = "0x1838F0B90", Slot = "6")]
		protected override void CKKILGLACHC(CJNEKNCGBDK<T> MBNHGEOGCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x36D04A0", Offset = "0x36CF8A0", VA = "0x1836D04A0")]
		[CompilerGenerated]
		private void LIBMCNOCCJI(T KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x38F0CE0", Offset = "0x38F00E0", VA = "0x1838F0CE0")]
		[CompilerGenerated]
		private void KJGHCKEIKDK(string HCMLCAPJMPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class JIALHCGELKD : LKMGLEKIFCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action ONCLGAMIHNG;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IKKDGPLBKOO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
		public JIALHCGELKD(Action ONCLGAMIHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB5AFF0", Offset = "0xB5A3F0", VA = "0x180B5AFF0", Slot = "5")]
		public void GIIIEODFHFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<LKMGLEKIFCP> PIEKNEPPCGE;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x255F9F0", Offset = "0x255EDF0", VA = "0x18255F9F0")]
	public static CJNEKNCGBDK<T> HFNOHCANOMG<T>(this CJNEKNCGBDK<T> MBNHGEOGCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6504810", Offset = "0x6503C10", VA = "0x186504810")]
	public static void HFNOHCANOMG(Action ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x255F930", Offset = "0x255ED30", VA = "0x18255F930")]
	private static CJNEKNCGBDK<T> AAMHBNBCNHF<T>(CJNEKNCGBDK<T> MBNHGEOGCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6504C70", Offset = "0x6504070", VA = "0x186504C70")]
	private static void MKBMDAGAPML(LKMGLEKIFCP IHGFDGKPGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x65048B0", Offset = "0x6503CB0", VA = "0x1865048B0")]
	private static void JIEHFPJALKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6504E80", Offset = "0x6504280", VA = "0x186504E80")]
	private static void PHMDMGHEIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6504B90", Offset = "0x6503F90", VA = "0x186504B90")]
	private static void MIJIDBAOMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KBIOOECOJBP
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct AMDMELEEELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> MEGFAJBBGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string NBJJAOODIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode JMOOMHLOHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool HOJNBGNHMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly PIHHFPKOALH<string>.NABJKOHEGKG HNCDAPOCBHO;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64F4DD0", Offset = "0x64F41D0", VA = "0x1864F4DD0")]
		public AMDMELEEELO(TaskCompletionSource<Scene> DIKGLCLJFIC, string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB, bool HOJNBGNHMIB, PIHHFPKOALH<string>.NABJKOHEGKG HNCDAPOCBHO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IHKKFJBPOPG : IAsyncStateMachine
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
		public PIHHFPKOALH<string>.NABJKOHEGKG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PIHHFPKOALH<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x65036D0", Offset = "0x6502AD0", VA = "0x1865036D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6503F70", Offset = "0x6503370", VA = "0x186503F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct LKHJABIGFMK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x650AF40", Offset = "0x650A340", VA = "0x18650AF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x650B260", Offset = "0x650A660", VA = "0x18650B260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JICDIBHDKEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AMDMELEEELO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6505010", Offset = "0x6504410", VA = "0x186505010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65053C0", Offset = "0x65047C0", VA = "0x1865053C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class PCNFDLGBLCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MABLGKOHHEM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public PCNFDLGBLCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x650E390", Offset = "0x650D790", VA = "0x18650E390")]
		internal void EHAAFNJCOOB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FKOAFDAGCGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PIHHFPKOALH<string>.NABJKOHEGKG stackTimer;

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
		private PCNFDLGBLCK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private PIHHFPKOALH<string>.NABJKOHEGKG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private PIHHFPKOALH<string>.NABJKOHEGKG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64FF690", Offset = "0x64FEA90", VA = "0x1864FF690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6500230", Offset = "0x64FF630", VA = "0x186500230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OOJPFMMGEGH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x650D940", Offset = "0x650CD40", VA = "0x18650D940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x650DE50", Offset = "0x650D250", VA = "0x18650DE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OCEENDHIOHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PIHHFPKOALH<string>.NABJKOHEGKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private PIHHFPKOALH<string>.NABJKOHEGKG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private PIHHFPKOALH<string>.NABJKOHEGKG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x650C5B0", Offset = "0x650B9B0", VA = "0x18650C5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x650D100", Offset = "0x650C500", VA = "0x18650D100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MIPNAGFGJDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MIPNAGFGJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x650B600", Offset = "0x650AA00", VA = "0x18650B600")]
		internal bool APNKCNMANFD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DDHABPLILKK : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JOBBEGCJNAJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public DDHABPLILKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x64FCEE0", Offset = "0x64FC2E0", VA = "0x1864FCEE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64FCB00", Offset = "0x64FBF00", VA = "0x1864FCB00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64FCE40", Offset = "0x64FC240", VA = "0x1864FCE40")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64FCE90", Offset = "0x64FC290", VA = "0x1864FCE90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EFCPGNMBDLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public MABLGKOHHEM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public EFCPGNMBDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x64FE920", Offset = "0x64FDD20", VA = "0x1864FE920")]
		internal bool KEPGGAHNHPE(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64FE6A0", Offset = "0x64FDAA0", VA = "0x1864FE6A0")]
		internal void GMLGNKICBGO(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GFIDMOELFDO : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public MABLGKOHHEM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private EFCPGNMBDLI <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public GFIDMOELFDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6500F00", Offset = "0x6500300", VA = "0x186500F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6501610", Offset = "0x6500A10", VA = "0x186501610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> LMIOKDDGJDP;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static AIDJGFFPANM PHJIKCCEKAN;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation BIPPJJJOJDM;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AIDJGFFPANM MLMJAPFGBNB;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string ONHNJLMFOGM;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority MPMAJKJLJKP;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task GNMPLLEAPDK;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> JAMBMDIILCK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<AMDMELEEELO> JIJHOEOOPKC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task POJJFPNLNMB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool NBFNDDGCOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6506A00", Offset = "0x6505E00", VA = "0x186506A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BFNNOHLDFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6505EB0", Offset = "0x65052B0", VA = "0x186505EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PJOLAGMPJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6506C20", Offset = "0x6506020", VA = "0x186506C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool PLJKFHLOBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6506EB0", Offset = "0x65062B0", VA = "0x186506EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ENNFBIIDFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65072D0", Offset = "0x65066D0", VA = "0x1865072D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65071C0", Offset = "0x65065C0", VA = "0x1865071C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6505CC0", Offset = "0x65050C0", VA = "0x186505CC0")]
	[NDDANKAMPNK(HOIDNOLMCOA.EnteredEditModeNextFrame, 0)]
	private static void AJMPFPMHGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6506060", Offset = "0x6505460", VA = "0x186506060")]
	[AsyncStateMachine(typeof(IHKKFJBPOPG))]
	public static Task<Scene> CADPHILANIK(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB = LoadSceneMode.Single, bool HOJNBGNHMIB = false, [Optional] PIHHFPKOALH<string>.NABJKOHEGKG EINJOLOFJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x65062E0", Offset = "0x65056E0", VA = "0x1865062E0")]
	[AsyncStateMachine(typeof(LKHJABIGFMK))]
	private static Task CGEOADMHPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6506F40", Offset = "0x6506340", VA = "0x186506F40")]
	[AsyncStateMachine(typeof(JICDIBHDKEP))]
	private static Task KPIKHBEDGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6506D60", Offset = "0x6506160", VA = "0x186506D60")]
	[AsyncStateMachine(typeof(FKOAFDAGCGI))]
	private static Task<Scene> IGEEBPCEKHI(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB, bool HOJNBGNHMIB, PIHHFPKOALH<string>.NABJKOHEGKG HNCDAPOCBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6506510", Offset = "0x6505910", VA = "0x186506510")]
	private static void DGGKKFMCDGP(SceneInstance OJEBKBIJNNG, LoadSceneMode JMOOMHLOHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6506670", Offset = "0x6505A70", VA = "0x186506670")]
	private static void DJMFOPGKLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x65070A0", Offset = "0x65064A0", VA = "0x1865070A0")]
	[AsyncStateMachine(typeof(OOJPFMMGEGH))]
	private static Task<Scene> OILHACBNIKD(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6505DC0", Offset = "0x65051C0", VA = "0x186505DC0")]
	private static bool AKLPLFLGBEP(string NBJJAOODIGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6505F50", Offset = "0x6505350", VA = "0x186505F50")]
	[AsyncStateMachine(typeof(OCEENDHIOHL))]
	private static Task<Scene> BPBNABGAMAA(PIHHFPKOALH<string>.NABJKOHEGKG HNCDAPOCBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6506390", Offset = "0x6505790", VA = "0x186506390")]
	public static CJNEKNCGBDK<Scene> DBOJKFFIGNP(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6506730", Offset = "0x6505B30", VA = "0x186506730")]
	public static AIDJGFFPANM DNECFCIIDII(string NBJJAOODIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6507010", Offset = "0x6506410", VA = "0x186507010")]
	[IteratorStateMachine(typeof(DDHABPLILKK))]
	private static IEnumerator<EIIEDLICJGP> NMNBPCBHDMA(string NBJJAOODIGP, JOBBEGCJNAJ NFFJLCNOKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6506CC0", Offset = "0x65060C0", VA = "0x186506CC0")]
	[IteratorStateMachine(typeof(GFIDMOELFDO))]
	private static IEnumerator<EIIEDLICJGP> HLNBLJOAGPF(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB, MABLGKOHHEM<Scene> NFFJLCNOKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x65061B0", Offset = "0x65055B0", VA = "0x1865061B0")]
	public static bool CDCJOGBAGEH([Out] string DBJMEKGEPFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CDBJBJIDCII
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x64F64D0", Offset = "0x64F58D0", VA = "0x1864F64D0")]
	public static IDisposable KBIJFFHMOJM(this JLLGIDDFMND LAACBMJOJOJ, float JDPBFPGNKNK, Action<float> EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x64F6450", Offset = "0x64F5850", VA = "0x1864F6450")]
	public static IDisposable HNDMBJEOCDJ(this JLLGIDDFMND LAACBMJOJOJ, Action<float> EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x64F6560", Offset = "0x64F5960", VA = "0x1864F6560")]
	public static IDisposable KCKBHBNMDLK(this JLLGIDDFMND LAACBMJOJOJ, Action<float> EEBJMMELNII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MNIAHDKFEDK
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x650B880", Offset = "0x650AC80", VA = "0x18650B880")]
	public static IDisposable BJEJDIKODKG(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x650B7F0", Offset = "0x650ABF0", VA = "0x18650B7F0")]
	public static IDisposable BJEJDIKODKG(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x650BD40", Offset = "0x650B140", VA = "0x18650BD40")]
	public static IDisposable LFKJJNEOHNN(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x650BEF0", Offset = "0x650B2F0", VA = "0x18650BEF0")]
	public static IDisposable MNPPDGLOEEG(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x650BE70", Offset = "0x650B270", VA = "0x18650BE70")]
	public static IDisposable MNPPDGLOEEG(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x650BAF0", Offset = "0x650AEF0", VA = "0x18650BAF0")]
	public static IDisposable IELNLCCEBJE(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x650BB70", Offset = "0x650AF70", VA = "0x18650BB70")]
	public static IDisposable JAEICAJHCLC(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x650B770", Offset = "0x650AB70", VA = "0x18650B770")]
	public static IDisposable AKCENFLAMLH(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x650BDC0", Offset = "0x650B1C0", VA = "0x18650BDC0")]
	public static IDisposable LHIDDIOEFII(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x650BF70", Offset = "0x650B370", VA = "0x18650BF70")]
	public static IDisposable NLJCFKDPAFI(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x650C090", Offset = "0x650B490", VA = "0x18650C090")]
	public static IDisposable OIHPKDJOLBJ(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x650BA50", Offset = "0x650AE50", VA = "0x18650BA50")]
	public static IDisposable EEKLIEDFLFI(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x650B9B0", Offset = "0x650ADB0", VA = "0x18650B9B0")]
	public static IDisposable DGLMODHPHEP(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x650B630", Offset = "0x650AA30", VA = "0x18650B630")]
	public static IDisposable AAHKJFJIJHC(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x650B6D0", Offset = "0x650AAD0", VA = "0x18650B6D0")]
	public static IDisposable AAIKMFEFLCN(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x650B910", Offset = "0x650AD10", VA = "0x18650B910")]
	public static IDisposable DEMBEDEAJKK(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x650BBF0", Offset = "0x650AFF0", VA = "0x18650BBF0")]
	public static IDisposable JNFELBDHOGO(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x650C130", Offset = "0x650B530", VA = "0x18650C130")]
	public static IDisposable OPCACLOLADL(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x650BC90", Offset = "0x650B090", VA = "0x18650BC90")]
	public static IDisposable KAEAKIKONNO(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ABJBPCCBOGF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class CEELPFAAJKC : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CANKODDCPEJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private OHIFONGIMHF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public CEELPFAAJKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x64F65E0", Offset = "0x64F59E0", VA = "0x1864F65E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x64F66C0", Offset = "0x64F5AC0", VA = "0x1864F66C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class BGILGNOKAOL : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CANKODDCPEJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private OHIFONGIMHF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public BGILGNOKAOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x64F5830", Offset = "0x64F4C30", VA = "0x1864F5830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64F5920", Offset = "0x64F4D20", VA = "0x1864F5920", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64F4C00", Offset = "0x64F4000", VA = "0x1864F4C00")]
	public static BDOFDMHMNPK BJEJDIKODKG(Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64F4A20", Offset = "0x64F3E20", VA = "0x1864F4A20")]
	public static BDOFDMHMNPK BJEJDIKODKG(Behaviour LAACBMJOJOJ, Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64F4AE0", Offset = "0x64F3EE0", VA = "0x1864F4AE0")]
	public static BDOFDMHMNPK BJEJDIKODKG(Behaviour LAACBMJOJOJ, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64F4D40", Offset = "0x64F4140", VA = "0x1864F4D40")]
	[IteratorStateMachine(typeof(CEELPFAAJKC))]
	private static IEnumerator<EIIEDLICJGP> IJIHGAIHODC(CANKODDCPEJ JMODEJIPHGK, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64F4CB0", Offset = "0x64F40B0", VA = "0x1864F4CB0")]
	[IteratorStateMachine(typeof(BGILGNOKAOL))]
	private static IEnumerator<EIIEDLICJGP> IJIHGAIHODC(CANKODDCPEJ JMODEJIPHGK, Action<float> EEBJMMELNII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NOCBOIAPMOG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BJNDMLNDMPH : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public NOCBOIAPMOG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public BJNDMLNDMPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x64F5CB0", Offset = "0x64F50B0", VA = "0x1864F5CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64F5D40", Offset = "0x64F5140", VA = "0x1864F5D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CANKODDCPEJ KFALGGAKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action EHKHBHPAPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool EOCBLPNAHDK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool EGFKDANLCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772C20", VA = "0x180773820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x650C450", Offset = "0x650B850", VA = "0x18650C450")]
	public NOCBOIAPMOG(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x650C3D0", Offset = "0x650B7D0", VA = "0x18650C3D0")]
	[IteratorStateMachine(typeof(BJNDMLNDMPH))]
	private IEnumerator<EIIEDLICJGP> PJLPAGHABLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x650C330", Offset = "0x650B730", VA = "0x18650C330", Slot = "4")]
	public void OnCompleted(Action LMOHMBJDPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	public void LDDFCACIGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class BJCDBFPJACE
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x64F5B70", Offset = "0x64F4F70", VA = "0x1864F5B70")]
	public static NOCBOIAPMOG LPMEJOJAOBL(this CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class ICBIMFLELPG
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class BECMFJJGBBD : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public IBENKHGJKKE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public BECMFJJGBBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x64F50D0", Offset = "0x64F44D0", VA = "0x1864F50D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64F5150", Offset = "0x64F4550", VA = "0x1864F5150", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x65030A0", Offset = "0x65024A0", VA = "0x1865030A0")]
	public static BDOFDMHMNPK BJEJDIKODKG(float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x65031A0", Offset = "0x65025A0", VA = "0x1865031A0")]
	public static BDOFDMHMNPK BJEJDIKODKG(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x65033C0", Offset = "0x65027C0", VA = "0x1865033C0")]
	public static BDOFDMHMNPK EJMKBIGLCDA(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x65032B0", Offset = "0x65026B0", VA = "0x1865032B0")]
	public static BDOFDMHMNPK EAIBOEPDBMN(JLLGIDDFMND LAACBMJOJOJ, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6503540", Offset = "0x6502940", VA = "0x186503540")]
	private static IEnumerator<EIIEDLICJGP> IJIHGAIHODC(AGDENGFECFE ECINKGKIFIN, float JDPBFPGNKNK, CANKODDCPEJ JMODEJIPHGK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x65034E0", Offset = "0x65028E0", VA = "0x1865034E0")]
	private static IEnumerator<EIIEDLICJGP> HJHDMHLKKJE(AGDENGFECFE ECINKGKIFIN, float JDPBFPGNKNK, CANKODDCPEJ JMODEJIPHGK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6503600", Offset = "0x6502A00", VA = "0x186503600")]
	[IteratorStateMachine(typeof(BECMFJJGBBD))]
	private static IEnumerator<EIIEDLICJGP> LOBLLOBDCIA(IBENKHGJKKE EAAOMNOFOLD, float JDPBFPGNKNK, CANKODDCPEJ JMODEJIPHGK, Action<float> EEBJMMELNII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class INLMLHBEIHO
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BLMJNJPDMLG : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CANKODDCPEJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public BLMJNJPDMLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64F5D90", Offset = "0x64F5190", VA = "0x1864F5D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x64F5E50", Offset = "0x64F5250", VA = "0x1864F5E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6504300", Offset = "0x6503700", VA = "0x186504300")]
	[IteratorStateMachine(typeof(BLMJNJPDMLG))]
	private static IEnumerator<EIIEDLICJGP> LLJNDFNHHOB(CANKODDCPEJ KFALGGAKOBE, Func<bool> KCKDDHKPEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x65041E0", Offset = "0x65035E0", VA = "0x1865041E0")]
	public static BDOFDMHMNPK EGKGMKEFNIK(this MonoBehaviour PBJIGNAOGDC, Func<bool> KCKDDHKPEDN, CANKODDCPEJ KFALGGAKOBE = CANKODDCPEJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GBKOIGDKFKP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MBDCAJJNMPE : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public CANKODDCPEJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public MBDCAJJNMPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x650B540", Offset = "0x650A940", VA = "0x18650B540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x650B5B0", Offset = "0x650A9B0", VA = "0x18650B5B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class ONHALDDPLAG : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CANKODDCPEJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private EIIEDLICJGP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public ONHALDDPLAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x650D860", Offset = "0x650CC60", VA = "0x18650D860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x650D8F0", Offset = "0x650CCF0", VA = "0x18650D8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6500C20", Offset = "0x6500020", VA = "0x186500C20")]
	[IteratorStateMachine(typeof(MBDCAJJNMPE))]
	private static IEnumerator<EIIEDLICJGP> PJLPAGHABLN(float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x65006E0", Offset = "0x64FFAE0", VA = "0x1865006E0")]
	[IteratorStateMachine(typeof(ONHALDDPLAG))]
	private static IEnumerator<EIIEDLICJGP> HNOHOMKHBMH(float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6500590", Offset = "0x64FF990", VA = "0x186500590")]
	public static IDisposable FEBCNBGCHGP(this MonoBehaviour PBJIGNAOGDC, float IODAOFLOKJG, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6500780", Offset = "0x64FFB80", VA = "0x186500780")]
	public static BDOFDMHMNPK HOPHDIPEJPO(this MonoBehaviour PBJIGNAOGDC, float IODAOFLOKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6500460", Offset = "0x64FF860", VA = "0x186500460")]
	public static BDOFDMHMNPK FEBCNBGCHGP(this MonoBehaviour PBJIGNAOGDC, float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6500440", Offset = "0x64FF840", VA = "0x186500440")]
	public static BDOFDMHMNPK CDNOCLOKLNI(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6500AE0", Offset = "0x64FFEE0", VA = "0x186500AE0")]
	public static BDOFDMHMNPK MAEHGGKJJBK(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6500B40", Offset = "0x64FFF40", VA = "0x186500B40")]
	public static BDOFDMHMNPK PBAJJLCMIGC(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6500B10", Offset = "0x64FFF10", VA = "0x186500B10")]
	public static BDOFDMHMNPK MIONIDFAPIN(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65006B0", Offset = "0x64FFAB0", VA = "0x1865006B0")]
	public static BDOFDMHMNPK GMCDLJENFNB(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6500840", Offset = "0x64FFC40", VA = "0x186500840")]
	public static BDOFDMHMNPK IABIEPOJCJL(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6500940", Offset = "0x64FFD40", VA = "0x186500940")]
	private static BDOFDMHMNPK KGBCCFHJOGO(MonoBehaviour PBJIGNAOGDC, CANKODDCPEJ KFALGGAKOBE, Action KMOKEKJAEFE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65002A0", Offset = "0x64FF6A0", VA = "0x1865002A0")]
	public static BDOFDMHMNPK BCAJCOJAKFP(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6500870", Offset = "0x64FFC70", VA = "0x186500870")]
	public static BDOFDMHMNPK IPLCOPLKIPD(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6500A10", Offset = "0x64FFE10", VA = "0x186500A10")]
	public static BDOFDMHMNPK KODCIJCPLGM(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6500370", Offset = "0x64FF770", VA = "0x186500370")]
	public static BDOFDMHMNPK BLFHMGIMFMG(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GKFGELDNIJL : LGGNEBBFDDB, IEnumerable<LGGNEBBFDDB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<LGGNEBBFDDB> LBNMDJACOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool LMOLPJMPBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action CFMONLCNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool NPOIKJKDHJH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OOMCGGJEADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6502570", Offset = "0x6501970", VA = "0x186502570", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FBIHEIKFGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6502C20", Offset = "0x6502020", VA = "0x186502C20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6502B00", Offset = "0x6501F00", VA = "0x186502B00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6502E20", Offset = "0x6502220", VA = "0x186502E20")]
	public GKFGELDNIJL([Optional] Action CFMONLCNNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x65026B0", Offset = "0x6501AB0", VA = "0x1865026B0")]
	public void BKKEPFPDOJH(LGGNEBBFDDB GEDGCPKDEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6502CC0", Offset = "0x65020C0", VA = "0x186502CC0")]
	private void PIAFCDGADDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x65027E0", Offset = "0x6501BE0", VA = "0x1865027E0", Slot = "7")]
	public bool CAHOLFCGBMA(bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x65027F0", Offset = "0x6501BF0", VA = "0x1865027F0", Slot = "8")]
	public bool CAHOLFCGBMA(Action ONCLGAMIHNG, bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6502BA0", Offset = "0x6501FA0", VA = "0x186502BA0", Slot = "9")]
	public IEnumerator<LGGNEBBFDDB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6502BA0", Offset = "0x6501FA0", VA = "0x186502BA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DNBPIHOAAAF : KMALIPLJFAA
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CJEGFMJKOJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public DNBPIHOAAAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public CJEGFMJKOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x64F80D0", Offset = "0x64F74D0", VA = "0x1864F80D0")]
		internal void BGMACGMKEHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CNKALOLAEIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public DNBPIHOAAAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public CNKALOLAEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x64F80D0", Offset = "0x64F74D0", VA = "0x1864F80D0")]
		internal void BHGKOPLDKPC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float COHJDPAIOFP;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x64F4920", Offset = "0x64F3D20", VA = "0x1864F4920")]
	public DNBPIHOAAAF(Behaviour LAACBMJOJOJ, float COHJDPAIOFP, [Optional] Action CFMONLCNNOP, [Optional] DAHKGHMHLKA FDOFKCPCEMO, [Optional] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x64FE310", Offset = "0x64FD710", VA = "0x1864FE310", Slot = "9")]
	protected override bool LHOGILDLJCK(Action ONCLGAMIHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x64FE200", Offset = "0x64FD600", VA = "0x1864FE200", Slot = "10")]
	protected override bool COAGHJHMOLD(Action ONCLGAMIHNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface LGGNEBBFDDB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OOMCGGJEADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FBIHEIKFGMF;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CAHOLFCGBMA(bool EHGFADNFMAI = false);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CAHOLFCGBMA(Action ONCLGAMIHNG, bool EHGFADNFMAI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class KMALIPLJFAA : LGGNEBBFDDB
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class MPDJPKMKMHG : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public KMALIPLJFAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public MPDJPKMKMHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x650C1D0", Offset = "0x650B5D0", VA = "0x18650C1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x650C2A0", Offset = "0x650B6A0", VA = "0x18650C2A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour LAACBMJOJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action CFMONLCNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private BLKLMCIOEEC GPGDBPJPDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly DAHKGHMHLKA FDOFKCPCEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly AGDENGFECFE ECINKGKIFIN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OOMCGGJEADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xEA9850", Offset = "0xEA8C50", VA = "0x180EA9850", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FBIHEIKFGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x65079D0", Offset = "0x6506DD0", VA = "0x1865079D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6507860", Offset = "0x6506C60", VA = "0x186507860", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6507D50", Offset = "0x6507150", VA = "0x186507D50")]
	protected KMALIPLJFAA(Behaviour LAACBMJOJOJ, [Optional] Action CFMONLCNNOP, [Optional] DAHKGHMHLKA FDOFKCPCEMO, [Optional] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6507800", Offset = "0x6506C00", VA = "0x186507800", Slot = "7")]
	public bool CAHOLFCGBMA(bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x65077A0", Offset = "0x6506BA0", VA = "0x1865077A0", Slot = "8")]
	public bool CAHOLFCGBMA(Action ONCLGAMIHNG, bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LHOGILDLJCK(Action ONCLGAMIHNG);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool COAGHJHMOLD(Action ONCLGAMIHNG);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6507D30", Offset = "0x6507130", VA = "0x186507D30")]
	protected void PNKCMBKGBHE(Action ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6507AF0", Offset = "0x6506EF0", VA = "0x186507AF0")]
	protected AIDJGFFPANM MIGNJAKMFIP(float EMNJLCFBMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6507A70", Offset = "0x6506E70", VA = "0x186507A70")]
	private void MCEBPLLNIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6507900", Offset = "0x6506D00", VA = "0x186507900")]
	[IteratorStateMachine(typeof(MPDJPKMKMHG))]
	private IEnumerator<EIIEDLICJGP> HOHADDLAFKO(float EMNJLCFBMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6507990", Offset = "0x6506D90", VA = "0x186507990")]
	[CompilerGenerated]
	private void JOGDPMAPPFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LFKKHNALABO : KMALIPLJFAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float HOBIPDOOPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int FNFBMNJPHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float GKKIMPBBCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] MCCJHPIDLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int HCKHOLDAENP;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x65083F0", Offset = "0x65077F0", VA = "0x1865083F0")]
	public LFKKHNALABO(Behaviour LAACBMJOJOJ, float GPLDFGDMIAK, int FNFBMNJPHGH, [Optional] Action CFMONLCNNOP, float GKKIMPBBCJL = 0f, [Optional] DAHKGHMHLKA FDOFKCPCEMO, [Optional] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "9")]
	protected override bool LHOGILDLJCK(Action ONCLGAMIHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6508170", Offset = "0x6507570", VA = "0x186508170", Slot = "10")]
	protected override bool COAGHJHMOLD(Action ONCLGAMIHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6508370", Offset = "0x6507770", VA = "0x186508370")]
	private void OMKDCLJGAGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AAIGDAFPNJJ : KMALIPLJFAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float COHJDPAIOFP;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x64F4920", Offset = "0x64F3D20", VA = "0x1864F4920")]
	public AAIGDAFPNJJ(Behaviour LAACBMJOJOJ, float COHJDPAIOFP, [Optional] Action CFMONLCNNOP, [Optional] DAHKGHMHLKA FDOFKCPCEMO, [Optional] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "9")]
	protected override bool LHOGILDLJCK(Action ONCLGAMIHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x64F48E0", Offset = "0x64F3CE0", VA = "0x1864F48E0", Slot = "10")]
	protected override bool COAGHJHMOLD(Action ONCLGAMIHNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class JNDDGHENGDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GKMOINPPGGC : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public GKMOINPPGGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6502EC0", Offset = "0x65022C0", VA = "0x186502EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6502F30", Offset = "0x6502330", VA = "0x186502F30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private BDOFDMHMNPK MGKGFILNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JLLGIDDFMND LAACBMJOJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> NDCNBCFOPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private CANKODDCPEJ KFALGGAKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float AJKMAPAPCKA;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x65059B0", Offset = "0x6504DB0", VA = "0x1865059B0")]
	public JNDDGHENGDP(JLLGIDDFMND LAACBMJOJOJ, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6505480", Offset = "0x6504880", VA = "0x186505480")]
	private void HFGLEKBNNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6505620", Offset = "0x6504A20", VA = "0x186505620")]
	private void HIMOLCCBIFG(string HCMLCAPJMPH, Action EBBAKPGHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6505780", Offset = "0x6504B80", VA = "0x186505780")]
	[IteratorStateMachine(typeof(GKMOINPPGGC))]
	private IEnumerator<EIIEDLICJGP> JIDEGENNIJP(Action EBBAKPGHNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6505420", Offset = "0x6504820", VA = "0x186505420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6505800", Offset = "0x6504C00", VA = "0x186505800")]
	[CompilerGenerated]
	private void NINCFHOIEDA(string GAFOFJBHEBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class DJBHIOJCHBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class OHCAHAHOEBH : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public OHCAHAHOEBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6502EC0", Offset = "0x65022C0", VA = "0x186502EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x650D3D0", Offset = "0x650C7D0", VA = "0x18650D3D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private BDOFDMHMNPK MGKGFILNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour PBJIGNAOGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action EEBJMMELNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> NDCNBCFOPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private CANKODDCPEJ KFALGGAKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float AJKMAPAPCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool DCKHFPKOCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly DAHKGHMHLKA FDOFKCPCEMO;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x64FDB80", Offset = "0x64FCF80", VA = "0x1864FDB80")]
	public DJBHIOJCHBO(MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x64FDFC0", Offset = "0x64FD3C0", VA = "0x1864FDFC0")]
	public DJBHIOJCHBO(MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x64FDD70", Offset = "0x64FD170", VA = "0x1864FDD70")]
	public DJBHIOJCHBO(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x188F8F0", Offset = "0x188ECF0", VA = "0x18188F8F0")]
	private DJBHIOJCHBO(DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64FD810", Offset = "0x64FCC10", VA = "0x1864FD810")]
	internal static DJBHIOJCHBO HGIMDLPJDHO(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x64FD090", Offset = "0x64FC490", VA = "0x1864FD090")]
	private void BJEJDIKODKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x64FD4B0", Offset = "0x64FC8B0", VA = "0x1864FD4B0")]
	private void HBIJHMLKKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x64FD660", Offset = "0x64FCA60", VA = "0x1864FD660")]
	private void HFGLEKBNNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x64FD2F0", Offset = "0x64FC6F0", VA = "0x1864FD2F0")]
	private void FFEENIMIIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64FD940", Offset = "0x64FCD40", VA = "0x1864FD940")]
	private void HIMOLCCBIFG(string HCMLCAPJMPH, Action EBBAKPGHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x64FDB00", Offset = "0x64FCF00", VA = "0x1864FDB00")]
	[IteratorStateMachine(typeof(OHCAHAHOEBH))]
	private IEnumerator<EIIEDLICJGP> JIDEGENNIJP(Action EBBAKPGHNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x64FD200", Offset = "0x64FC600", VA = "0x1864FD200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x64FD000", Offset = "0x64FC400", VA = "0x1864FD000")]
	[CompilerGenerated]
	private void AHHJFKMAAHG(string GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x64FD260", Offset = "0x64FC660", VA = "0x1864FD260")]
	[CompilerGenerated]
	private void EIHLLBEKLNH(string GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x64FDA70", Offset = "0x64FCE70", VA = "0x1864FDA70")]
	[CompilerGenerated]
	private void IBCFKPBLILB(string GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64FCF70", Offset = "0x64FC370", VA = "0x1864FCF70")]
	[CompilerGenerated]
	private void AFNHGNPBJOK(string GAFOFJBHEBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum FPMAJGAKACB : byte
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
internal sealed class JAEBGHLOOKP : AGDENGFECFE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float DIMHDIBOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6504600", Offset = "0x6503A00", VA = "0x186504600", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HIPFFOBKPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6504560", Offset = "0x6503960", VA = "0x186504560", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double ADCPLMDBKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6504570", Offset = "0x6503970", VA = "0x186504570", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6504590", Offset = "0x6503990", VA = "0x186504590")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void HJJHDPAKHCO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	[Preserve]
	internal JAEBGHLOOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface NCHEKCHAENH
{
	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDFAPIHCKED(string MDFAJJKMBAI);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKEBAOIGIN();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface NGIMCMGIJPF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool KLNEECJHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DOOPCINNPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class PAJGAAHJDNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public LIMOBDMJLII EDONEEHCNOE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FFCPNJCJDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x77EAC0", Offset = "0x77DEC0", VA = "0x18077EAC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x650E030", Offset = "0x650D430", VA = "0x18650E030")]
	public static EIIEDLICJGP MCFLMDLEOIA(IEnumerator<EIIEDLICJGP> BKLKHLHIGPA, LOAIDDLGPPP AHLFODDIBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x650E190", Offset = "0x650D590", VA = "0x18650E190")]
	public EIIEDLICJGP MCFLMDLEOIA(LOAIDDLGPPP[] CMLNGHHJDNL, IEnumerator<EIIEDLICJGP>[] FCJAMAALOMH, EIIEDLICJGP[] GJDHFAOMNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x650DEC0", Offset = "0x650D2C0", VA = "0x18650DEC0")]
	public void AMOEMHIJICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x650E250", Offset = "0x650D650", VA = "0x18650E250")]
	public void OEDNOBOOEAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x650DEF0", Offset = "0x650D2F0", VA = "0x18650DEF0")]
	public void EFOOBCHKPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x650DEC0", Offset = "0x650D2C0", VA = "0x18650DEC0")]
	public void FKIPELKDAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public PAJGAAHJDNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class LIMOBDMJLII
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct FBKHFPOBOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public PAJGAAHJDNE CALCOBIGFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public JLLGIDDFMND BDGEKLPBHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public LOAIDDLGPPP COOHMGCNGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<EIIEDLICJGP> PFNPCCGJFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public EIIEDLICJGP FGKGPMDGLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FPMAJGAKACB HEFCJCHLAGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct INDJIPCBEOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public CANKODDCPEJ CLPBJAGDCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<FBKHFPOBOFL> HBPLJHCGCLH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GJIKPAJLABG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public LOAIDDLGPPP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LIMOBDMJLII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JLLGIDDFMND context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public PAJGAAHJDNE routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FPMAJGAKACB coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public EIIEDLICJGP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<EIIEDLICJGP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public GJIKPAJLABG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6501660", Offset = "0x6500A60", VA = "0x186501660")]
		internal void DKFFOEPHPHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NJKNNOCHJNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public PAJGAAHJDNE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public LIMOBDMJLII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public NJKNNOCHJNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x650C2F0", Offset = "0x650B6F0", VA = "0x18650C2F0")]
		internal void NDGPCMIODCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KCODKDGPLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public PAJGAAHJDNE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public LIMOBDMJLII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KCODKDGPLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x65075D0", Offset = "0x65069D0", VA = "0x1865075D0")]
		internal void GNIGFPLICLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class IGKABINOJAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public PAJGAAHJDNE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LIMOBDMJLII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public IGKABINOJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6503690", Offset = "0x6502A90", VA = "0x186503690")]
		internal void CFKGHMMGMHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const FPMAJGAKACB DLDHMOJNDOP = FPMAJGAKACB.Cancelled | FPMAJGAKACB.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly CANKODDCPEJ KFALGGAKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] EAEELNFDILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<FPMAJGAKACB> MFKFNNKFLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> DCFMECDKMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> MHCEPAGPBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> CLPJGCDKJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> NPCEGKGEOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> DFIANIGBEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> FCJJAOAOHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private PAJGAAHJDNE[] BPDABBABELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private LOAIDDLGPPP[] CMLNGHHJDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JLLGIDDFMND[] IDAOIFBMEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<EIIEDLICJGP>[] LBGGNBKLNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private EIIEDLICJGP[] JEHFJFBKMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int MLEFHAFICKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int EKJEIMGCNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int HBCDOOFIAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float KNABKOPNONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private GKCLKDADEJH JJJCMFJBPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle GFBHCFNKCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<PAJGAAHJDNE> INHGEGNJEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool CPJLKHBHEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> LJPACJDIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> ADGNGCAOGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool JGFHJCIJJCF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public INDJIPCBEOF[] GHHBPPJBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x964250", Offset = "0x963650", VA = "0x180964250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x650A8C0", Offset = "0x6509CC0", VA = "0x18650A8C0")]
	private static int PALNOKOEKAF(CANKODDCPEJ KFALGGAKOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x650A8F0", Offset = "0x6509CF0", VA = "0x18650A8F0")]
	public LIMOBDMJLII(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6509590", Offset = "0x6508990", VA = "0x186509590")]
	private void GACEHOOOJCG(int LNDNHIMNKDH, int KPPIOECHHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6508A30", Offset = "0x6507E30", VA = "0x186508A30")]
	public void DBNEKHBIAEG(JLLGIDDFMND LAACBMJOJOJ, EIIEDLICJGP BINJFEDHLMG, IEnumerator<EIIEDLICJGP> BKLKHLHIGPA, LOAIDDLGPPP AHLFODDIBHC, [Optional] PAJGAAHJDNE BLNGAHEGKJP, FPMAJGAKACB CCEBCEIFHPA = FPMAJGAKACB.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6509770", Offset = "0x6508B70", VA = "0x186509770")]
	public void GCMMIPEOEGJ(IEnumerable<FBKHFPOBOFL> AALDEDNGFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6508C30", Offset = "0x6508030", VA = "0x186508C30")]
	private FBKHFPOBOFL FEBDCODIAFF(int LIJOMHJNLJI)
	{
		return default(FBKHFPOBOFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x65086C0", Offset = "0x6507AC0", VA = "0x1865086C0")]
	private void CONHMNIMCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2584030", Offset = "0x2583430", VA = "0x182584030")]
	private static void DKGNBJIEGEI<T>(int LIJOMHJNLJI, T[] GLBJACBDNPI, int PEGIIHFIAHP, [Optional] T JHMGOBPBFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2584080", Offset = "0x2583480", VA = "0x182584080")]
	private static void DKGNBJIEGEI<T>(int LIJOMHJNLJI, NativeArray<T> GLBJACBDNPI, int PEGIIHFIAHP, [Optional] T JHMGOBPBFPI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6509A70", Offset = "0x6508E70", VA = "0x186509A70")]
	private void KCNAOHAIOLO(IEnumerable<FBKHFPOBOFL> AALDEDNGFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x65099B0", Offset = "0x6508DB0", VA = "0x1865099B0")]
	private void IDFPKMBLNEP(FBKHFPOBOFL DDLAFOHNDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6509330", Offset = "0x6508730", VA = "0x186509330")]
	private LJGOLBFBEMD GACAMMKPIKA(int CGPJMIBDKNG)
	{
		return default(LJGOLBFBEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6509FC0", Offset = "0x65093C0", VA = "0x186509FC0")]
	public void MFPKMNNDAHB(float JOANGLMKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6508BB0", Offset = "0x6507FB0", VA = "0x186508BB0")]
	private void ELNFPHFOFFA(Action JMHOJIPAIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6509E10", Offset = "0x6509210", VA = "0x186509E10")]
	private void KEJPLBBOPOM(Action JMHOJIPAIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x650A1C0", Offset = "0x65095C0", VA = "0x18650A1C0")]
	public void NCEDEHHHHOO(float JOANGLMKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6509100", Offset = "0x6508500", VA = "0x186509100")]
	public void FJNCMFNOBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6509200", Offset = "0x6508600", VA = "0x186509200")]
	public void FKIPELKDAKL(PAJGAAHJDNE EAAOMNOFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6509E90", Offset = "0x6509290", VA = "0x186509E90")]
	public void MBEKMKBLEME(PAJGAAHJDNE EAAOMNOFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6508590", Offset = "0x6507990", VA = "0x186508590")]
	public void CHJMBMHFHLD(PAJGAAHJDNE EAAOMNOFOLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class OLELCOMAMNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly OLELCOMAMNK ANKGPMLLDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action HDLFJBNADMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool CIECAMCCGCB;

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public OLELCOMAMNK(Action HDLFJBNADMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x650D710", Offset = "0x650CB10", VA = "0x18650D710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface CCOGJJKCAEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AFJPCNDJPMD(UnityEngine.Object LAACBMJOJOJ, Action<T> JAIEDAFGMOK);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface BCPPAFBICCD<T> : CCOGJJKCAEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MMPNGFOPHHC<T> : BCPPAFBICCD<T>, CCOGJJKCAEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class KCMNENBBLJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public MMPNGFOPHHC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public CMJMNONAAOE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KCMNENBBLJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3962740", Offset = "0x3961B40", VA = "0x183962740")]
		internal void KGABMDCCLMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject IECGKPBBCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<CMJMNONAAOE<UnityEngine.Object, Action<T>>> PHLNHIDCMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T CEAPCKMHKPM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F2620", VA = "0x1807F3220", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0DB0", Offset = "0x3CE01B0", VA = "0x183CE0DB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0C30", Offset = "0x3CE0030", VA = "0x183CE0C30")]
	private static bool BFECBGLIINN(T JMHOJIPAIMC, T MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CE0EE0", Offset = "0x3CE02E0", VA = "0x183CE0EE0")]
	public MMPNGFOPHHC(T BCMHALABOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE02B0", Offset = "0x3CDF6B0", VA = "0x183CE02B0", Slot = "6")]
	public IDisposable AFJPCNDJPMD(UnityEngine.Object LAACBMJOJOJ, Action<T> JAIEDAFGMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE05D0", Offset = "0x3CDF9D0", VA = "0x183CE05D0")]
	private void BDGFHMCPDNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class LCDPFENEELL : PALCOODAPFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly DAHKGHMHLKA FDOFKCPCEMO;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6508050", Offset = "0x6507450", VA = "0x186508050")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void HJJHDPAKHCO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	[Preserve]
	internal LCDPFENEELL([MJHHGJKKIMK(null)] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x65080C0", Offset = "0x65074C0", VA = "0x1865080C0", Slot = "4")]
	public IDisposable OIHPKDJOLBJ(float JDPBFPGNKNK, Action<float> PDECDCHNHMC, bool DCKHFPKOCIN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class EHOLFMJJEAL : PMKAOGFPDIL, DAHKGHMHLKA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private LIMOBDMJLII[] LKIBJJFGCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NCHEKCHAENH JLGOLLIBAHJ;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x64FECE0", Offset = "0x64FE0E0", VA = "0x1864FECE0")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void HJJHDPAKHCO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x64FF5D0", Offset = "0x64FE9D0", VA = "0x1864FF5D0")]
	[Preserve]
	public EHOLFMJJEAL([MJHHGJKKIMK(null)] NHEGGEMENKH GNGMMGMAMJD, [MJHHGJKKIMK(null)] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x64FF380", Offset = "0x64FE780", VA = "0x1864FF380", Slot = "17")]
	public override BDOFDMHMNPK NEIMDGECDCK(JLLGIDDFMND LAACBMJOJOJ, IEnumerator<EIIEDLICJGP> OKINDPHHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x64FF0F0", Offset = "0x64FE4F0", VA = "0x1864FF0F0", Slot = "18")]
	public override void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64FED50", Offset = "0x64FE150", VA = "0x1864FED50", Slot = "20")]
	public override void JGDNNPPMCPD(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x64FEF80", Offset = "0x64FE380", VA = "0x1864FEF80", Slot = "19")]
	protected override void LFKJJNEOHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x64FE9A0", Offset = "0x64FDDA0", VA = "0x1864FE9A0")]
	private LIMOBDMJLII CIANEDGLHHP(CANKODDCPEJ LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x64FEA30", Offset = "0x64FDE30", VA = "0x1864FEA30", Slot = "21")]
	internal override CMDCHNFILEE FGDBDBAKHLF(IEnumerator<EIIEDLICJGP> OKINDPHHPBN, Behaviour LAACBMJOJOJ, LOAIDDLGPPP AHLFODDIBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x64FEC60", Offset = "0x64FE060", VA = "0x1864FEC60", Slot = "22")]
	internal override CHBJINMJAGK FPELOBDHALB(CANKODDCPEJ JMODEJIPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x64FF4B0", Offset = "0x64FE8B0", VA = "0x1864FF4B0")]
	private void OAJFEHFBANP(LIMOBDMJLII LLEMOFNDDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x64FE9D0", Offset = "0x64FDDD0", VA = "0x1864FE9D0", Slot = "23")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct GKCLKDADEJH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float CJPEDKNHGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int EJOCGOIGEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> MIEGOKHBMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> LKNNFAGIPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> EPFBPOFCMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<FPMAJGAKACB> IFKOGDPHNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> HACIEGOIPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> NPCEGKGEOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> MHCEPAGPBEE;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6502320", Offset = "0x6501720", VA = "0x186502320")]
	public static GKCLKDADEJH EBILOFOJHAE(int LPLOFGIHJKC, float JOANGLMKMAI, NativeArray<FPMAJGAKACB> PKGHDGMIEMN, NativeArray<float> HIMFMJIABHC, NativeArray<int> MOLDDDEACAO, NativeArray<int> AMMBJFKLFPC, NativeArray<int> DAEMCLFOCCL, NativeArray<int> LKNNFAGIPCK, NativeArray<int> EPFBPOFCMMM)
	{
		return default(GKCLKDADEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6502380", Offset = "0x6501780", VA = "0x186502380", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6502530", Offset = "0x6501930", VA = "0x186502530")]
	private bool PNIGBPNDOPD(int DIENMHDGFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6502460", Offset = "0x6501860", VA = "0x186502460")]
	private void FKFGBAHIOAK(NativeArray<int> AGOLNOEJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6502490", Offset = "0x6501890", VA = "0x186502490")]
	private int LNNKDHFMIJK(int CAEBNGFJCDK, int BIMCKCHJJEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6502250", Offset = "0x6501650", VA = "0x186502250")]
	private void DFCIDMGGFNC(NativeArray<int> AGOLNOEJENC, int IPBMAPOGFEC, int BCPCCCLDBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6502010", Offset = "0x6501410", VA = "0x186502010")]
	private void COMCECGJPPN(NativeArray<int> AGOLNOEJENC, int MJAIEKLLNAE, int FKLHGACDAPL, int JIKEDNCLNEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class PMKAOGFPDIL : DAHKGHMHLKA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly NHEGGEMENKH GNGMMGMAMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly AGDENGFECFE ECINKGKIFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private CHBJINMJAGK[] HKEMIMCPBML;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DAHKGHMHLKA NMGLFNHIICP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x650EAB0", Offset = "0x650DEB0", VA = "0x18650EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CANKODDCPEJ OLIFEJGMHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CANKODDCPEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x77EAC0", Offset = "0x77DEC0", VA = "0x18077EAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AGDENGFECFE HJPBNELMMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public EIIEDLICJGP HLOPNPIMIMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EIIEDLICJGP PHHENMIHEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x770B10", Offset = "0x76FF10", VA = "0x180770B10", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x650EFB0", Offset = "0x650E3B0", VA = "0x18650EFB0")]
	public static BDOFDMHMNPK IKBINDEIAGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x650F330", Offset = "0x650E730", VA = "0x18650F330")]
	[Preserve]
	protected PMKAOGFPDIL([MJHHGJKKIMK(null)] NHEGGEMENKH GNGMMGMAMJD, [MJHHGJKKIMK(null)] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x650EEF0", Offset = "0x650E2F0", VA = "0x18650EEF0", Slot = "6")]
	public BDOFDMHMNPK IAACBCPLMFD(IEnumerator<EIIEDLICJGP> OKINDPHHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x650ECF0", Offset = "0x650E0F0", VA = "0x18650ECF0", Slot = "7")]
	public BDOFDMHMNPK IAACBCPLMFD(Behaviour LAACBMJOJOJ, IEnumerator<EIIEDLICJGP> OKINDPHHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract BDOFDMHMNPK NEIMDGECDCK(JLLGIDDFMND LAACBMJOJOJ, IEnumerator<EIIEDLICJGP> OKINDPHHPBN);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x650F150", Offset = "0x650E550", VA = "0x18650F150", Slot = "18")]
	public virtual void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x650E850", Offset = "0x650DC50", VA = "0x18650E850", Slot = "9")]
	public void EOJPPNEAFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x650F0D0", Offset = "0x650E4D0", VA = "0x18650F0D0", Slot = "19")]
	protected virtual void LFKJJNEOHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x650F2F0", Offset = "0x650E6F0", VA = "0x18650F2F0")]
	private void MGHMGDCPDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x650E830", Offset = "0x650DC30", VA = "0x18650E830")]
	private void EODLECMDMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x650F310", Offset = "0x650E710", VA = "0x18650F310")]
	private void MNPPDGLOEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x650EF90", Offset = "0x650E390", VA = "0x18650EF90")]
	private void IELNLCCEBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x650EA90", Offset = "0x650DE90", VA = "0x18650EA90")]
	private void FIHAJOBLGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x650E3F0", Offset = "0x650D7F0", VA = "0x18650E3F0")]
	private void BCCNCGIHPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x650EB00", Offset = "0x650DF00", VA = "0x18650EB00")]
	private void FPKCPAKEPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x650F040", Offset = "0x650E440", VA = "0x18650F040", Slot = "20")]
	public virtual void JGDNNPPMCPD(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x650EB20", Offset = "0x650DF20", VA = "0x18650EB20")]
	private void GPLHNBILOGL(CHBJINMJAGK LLEMOFNDDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BF5850", Offset = "0x1BF4C50", VA = "0x181BF5850")]
	private CHBJINMJAGK CJPHOJCKLJD(CANKODDCPEJ LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract CMDCHNFILEE FGDBDBAKHLF(IEnumerator<EIIEDLICJGP> OKINDPHHPBN, Behaviour PBJIGNAOGDC, LOAIDDLGPPP JHLHJDKDLNJ);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract CHBJINMJAGK FPELOBDHALB(CANKODDCPEJ KFALGGAKOBE);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x650E410", Offset = "0x650D810", VA = "0x18650E410", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x650E7D0", Offset = "0x650DBD0", VA = "0x18650E7D0", Slot = "13")]
	public EIIEDLICJGP EEKPECLBKPG(CANKODDCPEJ JMODEJIPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x650EF00", Offset = "0x650E300", VA = "0x18650EF00", Slot = "14")]
	public EIIEDLICJGP IDCNIANLMJE(float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x650F0F0", Offset = "0x650E4F0", VA = "0x18650F0F0", Slot = "15")]
	public EIIEDLICJGP LIMJOMMENFE(Func<bool> KCKDDHKPEDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class CMDCHNFILEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly LOAIDDLGPPP AHLFODDIBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly NGIMCMGIJPF LAACBMJOJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool PPJIJJGFAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string MDFAJJKMBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace FFEGBBHBJAH;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerator<EIIEDLICJGP> PFNPCCGJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public EIIEDLICJGP FGKGPMDGLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MPGGDCMLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x64F8B70", Offset = "0x64F7F70", VA = "0x1864F8B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool CIDGOHJPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF380", Offset = "0x7DE780", VA = "0x1807DF380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7DF390", Offset = "0x7DE790", VA = "0x1807DF390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x64F85F0", Offset = "0x64F79F0", VA = "0x1864F85F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float NBIJMHDLDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1026DC0", Offset = "0x10261C0", VA = "0x181026DC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x54A8CA0", Offset = "0x54A80A0", VA = "0x1854A8CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64F8CD0", Offset = "0x64F80D0", VA = "0x1864F8CD0")]
	public CMDCHNFILEE(IEnumerator<EIIEDLICJGP> BKLKHLHIGPA, NGIMCMGIJPF LAACBMJOJOJ, LOAIDDLGPPP AHLFODDIBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64F8860", Offset = "0x64F7C60", VA = "0x1864F8860")]
	public EIIEDLICJGP MCFLMDLEOIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64F87F0", Offset = "0x64F7BF0", VA = "0x1864F87F0")]
	public bool GPCOBNGBDAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64F87A0", Offset = "0x64F7BA0", VA = "0x1864F87A0")]
	public void FKIPELKDAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64F8BF0", Offset = "0x64F7FF0", VA = "0x1864F8BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x854F60", Offset = "0x854360", VA = "0x180854F60")]
	[CompilerGenerated]
	private void KHENNGEHCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class LOAIDDLGPPP : BDCEKNDLIHJ, BDOFDMHMNPK, BLKLMCIOEEC, AIDJGFFPANM, IEnumerator, EIIEDLICJGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private CANKODDCPEJ POCKCIBEJON;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private CANKODDCPEJ CLNDPMJHMNF
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xDA82D0", Offset = "0xDA76D0", VA = "0x180DA82D0", Slot = "23")]
		get
		{
			return default(CANKODDCPEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public CANKODDCPEJ EDONEEHCNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x129F8C0", Offset = "0x129ECC0", VA = "0x18129F8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private float ENHEFNDPIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6510", Offset = "0x7C5910", VA = "0x1807C6510", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CJHKEIPKBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x650B2D0", Offset = "0x650A6D0", VA = "0x18650B2D0", Slot = "24")]
	private bool LCOJBMOPCEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x650B2C0", Offset = "0x650A6C0", VA = "0x18650B2C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x650B2F0", Offset = "0x650A6F0", VA = "0x18650B2F0")]
	public LOAIDDLGPPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum LJGOLBFBEMD : byte
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
internal sealed class CHBJINMJAGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum MONNLFFABOO
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct OIGDCFDMNGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CANKODDCPEJ CLPBJAGDCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public MONNLFFABOO FNCPNNHHFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<CMDCHNFILEE> CINEEIJPENG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly MONNLFFABOO[] HLKIFHAGNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly CANKODDCPEJ KFALGGAKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool EPOAHPFJPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly CMDCHNFILEE[] FMAPGPDJCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<CMDCHNFILEE> FMFOCLOOPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> BHDBACNBIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<CMDCHNFILEE> AMCDCJAMNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> HIHOBIOIOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly NCHEKCHAENH FONPMNFEOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool JGFHJCIJJCF;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OIGDCFDMNGB[,] AIMFFEKHLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x770B10", Offset = "0x76FF10", VA = "0x180770B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x64F7C30", Offset = "0x64F7030", VA = "0x1864F7C30")]
	public CHBJINMJAGK(CANKODDCPEJ JMODEJIPHGK, NCHEKCHAENH FONPMNFEOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x64F6A10", Offset = "0x64F5E10", VA = "0x1864F6A10")]
	public void BDECOBGGJKP(CMDCHNFILEE BKLKHLHIGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x64F73B0", Offset = "0x64F67B0", VA = "0x1864F73B0")]
	public void JGMCBJCPKPP(IList<CMDCHNFILEE> FCJAMAALOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x64F70A0", Offset = "0x64F64A0", VA = "0x1864F70A0")]
	public void JGGHEKKCIBL(IList<CMDCHNFILEE> FCJAMAALOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x64F6C30", Offset = "0x64F6030", VA = "0x1864F6C30")]
	private void EFJLOONODCD(CMDCHNFILEE BKLKHLHIGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x64F6F10", Offset = "0x64F6310", VA = "0x1864F6F10")]
	private void HMDNIIODJDG(IList<CMDCHNFILEE> FCJAMAALOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x64F7970", Offset = "0x64F6D70", VA = "0x1864F7970")]
	private LJGOLBFBEMD OGMKIBOPBCE(CMDCHNFILEE BKLKHLHIGPA)
	{
		return default(LJGOLBFBEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x64F7800", Offset = "0x64F6C00", VA = "0x1864F7800")]
	public void LFKJJNEOHNN(float JOANGLMKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x64F6D20", Offset = "0x64F6120", VA = "0x1864F6D20")]
	public void EOJPPNEAFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x64F6710", Offset = "0x64F5B10", VA = "0x1864F6710")]
	private void APHOHFCPEBE(List<CMDCHNFILEE> FCJAMAALOMH, Stack<int> AACBCMJEKMN, bool GDHFBDLAPAC, float PFGDLODCJLB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x64F6B10", Offset = "0x64F5F10", VA = "0x1864F6B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x64F76C0", Offset = "0x64F6AC0", VA = "0x1864F76C0")]
	private void JMJJKDKFDPC(List<CMDCHNFILEE> FCJAMAALOMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class FCHOFIDDJHI : NCHEKCHAENH
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
	public void FDFAPIHCKED(string MDFAJJKMBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
	public void PLKEBAOIGIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public FCHOFIDDJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class OEGDIMMIHJL : NGIMCMGIJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour PBJIGNAOGDC;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x650D170", Offset = "0x650C570", VA = "0x18650D170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KLNEECJHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x650D210", Offset = "0x650C610", VA = "0x18650D210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool DOOPCINNPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x650D1F0", Offset = "0x650C5F0", VA = "0x18650D1F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public OEGDIMMIHJL(Behaviour PBJIGNAOGDC)
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

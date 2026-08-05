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
	[Cpp2IlInjected.Address(RVA = "0x650C490", Offset = "0x650B890", VA = "0x18650C490")]
	public NOLCFHNDKIB(ThreadPriority MFBPFEDIHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x650C480", Offset = "0x650B880", VA = "0x18650C480", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6507D70", Offset = "0x6507170", VA = "0x186507D70")]
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
				[Cpp2IlInjected.Address(RVA = "0x64F8310", Offset = "0x64F7710", VA = "0x1864F8310")]
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
				[Cpp2IlInjected.Address(RVA = "0x64F50C0", Offset = "0x64F44C0", VA = "0x1864F50C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64F8020", Offset = "0x64F7420", VA = "0x1864F8020")]
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
				[Cpp2IlInjected.Address(RVA = "0x6501D30", Offset = "0x6501130", VA = "0x186501D30")]
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
				[Cpp2IlInjected.Address(RVA = "0x650D340", Offset = "0x650C740", VA = "0x18650D340")]
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
				[Cpp2IlInjected.Address(RVA = "0x650B260", Offset = "0x650A660", VA = "0x18650B260")]
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
				[Cpp2IlInjected.Address(RVA = "0x64F5DC0", Offset = "0x64F51C0", VA = "0x1864F5DC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64FE3C0", Offset = "0x64FD7C0", VA = "0x1864FE3C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6504530", Offset = "0x6503930", VA = "0x186504530")]
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
				[Cpp2IlInjected.Address(RVA = "0x6503F00", Offset = "0x6503300", VA = "0x186503F00")]
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
				[Cpp2IlInjected.Address(RVA = "0x64F5890", Offset = "0x64F4C90", VA = "0x1864F5890")]
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
					[Cpp2IlInjected.Address(RVA = "0x64FE340", Offset = "0x64FD740", VA = "0x1864FE340")]
					internal void GPNELFKIBPG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static CFBCANLCDFG<IHEGNDMADLN> DFJAKKOFCOM;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x65042B0", Offset = "0x65036B0", VA = "0x1865042B0")]
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
					[Cpp2IlInjected.Address(RVA = "0x6500BE0", Offset = "0x64FFFE0", VA = "0x186500BE0")]
					internal void JIODCHABOJG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable EFJFAAGFHPM;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6505AB0", Offset = "0x6504EB0", VA = "0x186505AB0")]
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
					[Cpp2IlInjected.Address(RVA = "0x650F740", Offset = "0x650EB40", VA = "0x18650F740")]
					internal void JIODCHABOJG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x64F8DB0", Offset = "0x64F81B0", VA = "0x1864F8DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6502EA0", Offset = "0x65022A0", VA = "0x186502EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64FC820", Offset = "0x64FBC20", VA = "0x1864FC820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64F9620", Offset = "0x64F8A20", VA = "0x1864F9620")]
		private static void LPLKGBDFJCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64FBF50", Offset = "0x64FB350", VA = "0x1864FBF50")]
		private static void MGJBCDHHJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64F8EE0", Offset = "0x64F82E0", VA = "0x1864F8EE0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64FC860", Offset = "0x64FBC60", VA = "0x1864FC860")]
		private static void PJOOIKJBKHN(BFFODOABBJG.KMKHEOMGJMP MIMFBLPNKOG, PlayerLoopSystem MCPKKGEHINI, Type LOIMIJKHFOA, Type HPJDIBJMCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64F9240", Offset = "0x64F8640", VA = "0x1864F9240")]
		private static void FNCHDOPLDJA(PlayerLoopSystem MCPKKGEHINI, Type LOIMIJKHFOA, Type HPJDIBJMCME, DFLLMBFCPEP PCANPNGLOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64F9110", Offset = "0x64F8510", VA = "0x1864F9110")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F6260", Offset = "0x64F5660", VA = "0x1864F6260")]
		public CCPEECNMCOC(KMKHEOMGJMP MICEBNFDIOD, int DDNPMOLNDAI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64F5FC0", Offset = "0x64F53C0", VA = "0x1864F5FC0")]
		public void AOCBBGDBCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64F6030", Offset = "0x64F5430", VA = "0x1864F6030")]
		public void IJCHMBCCEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x64F6080", Offset = "0x64F5480", VA = "0x1864F6080")]
		public void OAJBFJHDMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static KMKHEOMGJMP[] PAOEDNMKPOC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static CCPEECNMCOC[] NPNBDHDEELN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x64F52C0", Offset = "0x64F46C0", VA = "0x1864F52C0")]
	public static CCPEECNMCOC BAJOPHNMIJC(KMKHEOMGJMP MIMFBLPNKOG, int DDNPMOLNDAI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64F5540", Offset = "0x64F4940", VA = "0x1864F5540")]
	public static CCPEECNMCOC JDAAKJJOPND(KMKHEOMGJMP MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x64F54A0", Offset = "0x64F48A0", VA = "0x1864F54A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F4EE0", Offset = "0x64F42E0", VA = "0x1864F4EE0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double DLBOJBKDCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1702000", Offset = "0x1701400", VA = "0x181702000", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KFADEEOFAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1C963C0", Offset = "0x1C957C0", VA = "0x181C963C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x64F4F40", Offset = "0x64F4340", VA = "0x1864F4F40")]
	public APLLIPNICAC(int KCBGGHNLING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x64F4D50", Offset = "0x64F4150", VA = "0x1864F4D50", Slot = "7")]
	public void DFKPCPOCNKP(double OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x64F4E70", Offset = "0x64F4270", VA = "0x1864F4E70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x54A7CD0", Offset = "0x54A70D0", VA = "0x1854A7CD0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double KFADEEOFAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x54A7840", Offset = "0x54A6C40", VA = "0x1854A7840", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double IFKLHOFKHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x54A7820", Offset = "0x54A6C20", VA = "0x1854A7820")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MNGMHBONMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x209EFC0", Offset = "0x209E3C0", VA = "0x18209EFC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6507530", Offset = "0x6506930", VA = "0x186507530", Slot = "7")]
	public virtual void DFKPCPOCNKP(double OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6507650", Offset = "0x6506A50", VA = "0x186507650", Slot = "8")]
	public virtual void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6507690", Offset = "0x6506A90", VA = "0x186507690")]
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
		[Cpp2IlInjected.Address(RVA = "0x54A7800", Offset = "0x54A6C00", VA = "0x1854A7800")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x54A77D0", Offset = "0x54A6BD0", VA = "0x1854A77D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x650D180", Offset = "0x650C580", VA = "0x18650D180", Slot = "7")]
	public override void DFKPCPOCNKP(double OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x650D2B0", Offset = "0x650C6B0", VA = "0x18650D2B0", Slot = "8")]
	public override void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6507690", Offset = "0x6506A90", VA = "0x186507690")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CCF9F0", Offset = "0x3CCEDF0", VA = "0x183CCF9F0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IKKDGPLBKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3CCF980", Offset = "0x3CCED80", VA = "0x183CCF980", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CCF9D0", Offset = "0x3CCEDD0", VA = "0x183CCF9D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x38F22C0", Offset = "0x38F16C0", VA = "0x1838F22C0")]
		public JFKAPCDGJCM(CJNEKNCGBDK<T> MBNHGEOGCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x38F2140", Offset = "0x38F1540", VA = "0x1838F2140", Slot = "6")]
		protected override void CKKILGLACHC(CJNEKNCGBDK<T> MBNHGEOGCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x36D1A50", Offset = "0x36D0E50", VA = "0x1836D1A50")]
		[CompilerGenerated]
		private void LIBMCNOCCJI(T KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x38F2290", Offset = "0x38F1690", VA = "0x1838F2290")]
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
		[Cpp2IlInjected.Address(RVA = "0xB5B0A0", Offset = "0xB5A4A0", VA = "0x180B5B0A0", Slot = "5")]
		public void GIIIEODFHFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<LKMGLEKIFCP> PIEKNEPPCGE;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x255FA80", Offset = "0x255EE80", VA = "0x18255FA80")]
	public static CJNEKNCGBDK<T> HFNOHCANOMG<T>(this CJNEKNCGBDK<T> MBNHGEOGCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6504730", Offset = "0x6503B30", VA = "0x186504730")]
	public static void HFNOHCANOMG(Action ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x255F9C0", Offset = "0x255EDC0", VA = "0x18255F9C0")]
	private static CJNEKNCGBDK<T> AAMHBNBCNHF<T>(CJNEKNCGBDK<T> MBNHGEOGCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6504B90", Offset = "0x6503F90", VA = "0x186504B90")]
	private static void MKBMDAGAPML(LKMGLEKIFCP IHGFDGKPGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x65047D0", Offset = "0x6503BD0", VA = "0x1865047D0")]
	private static void JIEHFPJALKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6504DA0", Offset = "0x65041A0", VA = "0x186504DA0")]
	private static void PHMDMGHEIAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6504AB0", Offset = "0x6503EB0", VA = "0x186504AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F4CF0", Offset = "0x64F40F0", VA = "0x1864F4CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65035F0", Offset = "0x65029F0", VA = "0x1865035F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6503E90", Offset = "0x6503290", VA = "0x186503E90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650AE60", Offset = "0x650A260", VA = "0x18650AE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x650B180", Offset = "0x650A580", VA = "0x18650B180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6504F30", Offset = "0x6504330", VA = "0x186504F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65052E0", Offset = "0x65046E0", VA = "0x1865052E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650E2B0", Offset = "0x650D6B0", VA = "0x18650E2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FF5B0", Offset = "0x64FE9B0", VA = "0x1864FF5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6500150", Offset = "0x64FF550", VA = "0x186500150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650D860", Offset = "0x650CC60", VA = "0x18650D860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x650DD70", Offset = "0x650D170", VA = "0x18650DD70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650C4D0", Offset = "0x650B8D0", VA = "0x18650C4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x650D020", Offset = "0x650C420", VA = "0x18650D020", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x650B520", Offset = "0x650A920", VA = "0x18650B520")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FCE00", Offset = "0x64FC200", VA = "0x1864FCE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64FCA20", Offset = "0x64FBE20", VA = "0x1864FCA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64FCD60", Offset = "0x64FC160", VA = "0x1864FCD60")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64FCDB0", Offset = "0x64FC1B0", VA = "0x1864FCDB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64FE840", Offset = "0x64FDC40", VA = "0x1864FE840")]
		internal bool KEPGGAHNHPE(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x64FE5C0", Offset = "0x64FD9C0", VA = "0x1864FE5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6500E20", Offset = "0x6500220", VA = "0x186500E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6501530", Offset = "0x6500930", VA = "0x186501530", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506920", Offset = "0x6505D20", VA = "0x186506920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BFNNOHLDFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6505DD0", Offset = "0x65051D0", VA = "0x186505DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PJOLAGMPJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6506B40", Offset = "0x6505F40", VA = "0x186506B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool PLJKFHLOBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6506DD0", Offset = "0x65061D0", VA = "0x186506DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ENNFBIIDFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x65071F0", Offset = "0x65065F0", VA = "0x1865071F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x65070E0", Offset = "0x65064E0", VA = "0x1865070E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6505BE0", Offset = "0x6504FE0", VA = "0x186505BE0")]
	[NDDANKAMPNK(HOIDNOLMCOA.EnteredEditModeNextFrame, 0)]
	private static void AJMPFPMHGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6505F80", Offset = "0x6505380", VA = "0x186505F80")]
	[AsyncStateMachine(typeof(IHKKFJBPOPG))]
	public static Task<Scene> CADPHILANIK(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB = LoadSceneMode.Single, bool HOJNBGNHMIB = false, [Optional] PIHHFPKOALH<string>.NABJKOHEGKG EINJOLOFJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6506200", Offset = "0x6505600", VA = "0x186506200")]
	[AsyncStateMachine(typeof(LKHJABIGFMK))]
	private static Task CGEOADMHPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6506E60", Offset = "0x6506260", VA = "0x186506E60")]
	[AsyncStateMachine(typeof(JICDIBHDKEP))]
	private static Task KPIKHBEDGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6506C80", Offset = "0x6506080", VA = "0x186506C80")]
	[AsyncStateMachine(typeof(FKOAFDAGCGI))]
	private static Task<Scene> IGEEBPCEKHI(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB, bool HOJNBGNHMIB, PIHHFPKOALH<string>.NABJKOHEGKG HNCDAPOCBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6506430", Offset = "0x6505830", VA = "0x186506430")]
	private static void DGGKKFMCDGP(SceneInstance OJEBKBIJNNG, LoadSceneMode JMOOMHLOHAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6506590", Offset = "0x6505990", VA = "0x186506590")]
	private static void DJMFOPGKLIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6506FC0", Offset = "0x65063C0", VA = "0x186506FC0")]
	[AsyncStateMachine(typeof(OOJPFMMGEGH))]
	private static Task<Scene> OILHACBNIKD(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6505CE0", Offset = "0x65050E0", VA = "0x186505CE0")]
	private static bool AKLPLFLGBEP(string NBJJAOODIGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6505E70", Offset = "0x6505270", VA = "0x186505E70")]
	[AsyncStateMachine(typeof(OCEENDHIOHL))]
	private static Task<Scene> BPBNABGAMAA(PIHHFPKOALH<string>.NABJKOHEGKG HNCDAPOCBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x65062B0", Offset = "0x65056B0", VA = "0x1865062B0")]
	public static CJNEKNCGBDK<Scene> DBOJKFFIGNP(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6506650", Offset = "0x6505A50", VA = "0x186506650")]
	public static AIDJGFFPANM DNECFCIIDII(string NBJJAOODIGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6506F30", Offset = "0x6506330", VA = "0x186506F30")]
	[IteratorStateMachine(typeof(DDHABPLILKK))]
	private static IEnumerator<EIIEDLICJGP> NMNBPCBHDMA(string NBJJAOODIGP, JOBBEGCJNAJ NFFJLCNOKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6506BE0", Offset = "0x6505FE0", VA = "0x186506BE0")]
	[IteratorStateMachine(typeof(GFIDMOELFDO))]
	private static IEnumerator<EIIEDLICJGP> HLNBLJOAGPF(string NBJJAOODIGP, LoadSceneMode JMOOMHLOHAB, MABLGKOHHEM<Scene> NFFJLCNOKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x65060D0", Offset = "0x65054D0", VA = "0x1865060D0")]
	public static bool CDCJOGBAGEH([Out] string DBJMEKGEPFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CDBJBJIDCII
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x64F63F0", Offset = "0x64F57F0", VA = "0x1864F63F0")]
	public static IDisposable KBIJFFHMOJM(this JLLGIDDFMND LAACBMJOJOJ, float JDPBFPGNKNK, Action<float> EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x64F6370", Offset = "0x64F5770", VA = "0x1864F6370")]
	public static IDisposable HNDMBJEOCDJ(this JLLGIDDFMND LAACBMJOJOJ, Action<float> EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x64F6480", Offset = "0x64F5880", VA = "0x1864F6480")]
	public static IDisposable KCKBHBNMDLK(this JLLGIDDFMND LAACBMJOJOJ, Action<float> EEBJMMELNII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MNIAHDKFEDK
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x650B7A0", Offset = "0x650ABA0", VA = "0x18650B7A0")]
	public static IDisposable BJEJDIKODKG(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x650B710", Offset = "0x650AB10", VA = "0x18650B710")]
	public static IDisposable BJEJDIKODKG(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x650BC60", Offset = "0x650B060", VA = "0x18650BC60")]
	public static IDisposable LFKJJNEOHNN(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x650BE10", Offset = "0x650B210", VA = "0x18650BE10")]
	public static IDisposable MNPPDGLOEEG(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x650BD90", Offset = "0x650B190", VA = "0x18650BD90")]
	public static IDisposable MNPPDGLOEEG(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x650BA10", Offset = "0x650AE10", VA = "0x18650BA10")]
	public static IDisposable IELNLCCEBJE(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x650BA90", Offset = "0x650AE90", VA = "0x18650BA90")]
	public static IDisposable JAEICAJHCLC(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x650B690", Offset = "0x650AA90", VA = "0x18650B690")]
	public static IDisposable AKCENFLAMLH(this MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x650BCE0", Offset = "0x650B0E0", VA = "0x18650BCE0")]
	public static IDisposable LHIDDIOEFII(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x650BE90", Offset = "0x650B290", VA = "0x18650BE90")]
	public static IDisposable NLJCFKDPAFI(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x650BFB0", Offset = "0x650B3B0", VA = "0x18650BFB0")]
	public static IDisposable OIHPKDJOLBJ(this MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x650B970", Offset = "0x650AD70", VA = "0x18650B970")]
	public static IDisposable EEKLIEDFLFI(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x650B8D0", Offset = "0x650ACD0", VA = "0x18650B8D0")]
	public static IDisposable DGLMODHPHEP(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x650B550", Offset = "0x650A950", VA = "0x18650B550")]
	public static IDisposable AAHKJFJIJHC(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x650B5F0", Offset = "0x650A9F0", VA = "0x18650B5F0")]
	public static IDisposable AAIKMFEFLCN(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x650B830", Offset = "0x650AC30", VA = "0x18650B830")]
	public static IDisposable DEMBEDEAJKK(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x650BB10", Offset = "0x650AF10", VA = "0x18650BB10")]
	public static IDisposable JNFELBDHOGO(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x650C050", Offset = "0x650B450", VA = "0x18650C050")]
	public static IDisposable OPCACLOLADL(this MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x650BBB0", Offset = "0x650AFB0", VA = "0x18650BBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F6500", Offset = "0x64F5900", VA = "0x1864F6500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x64F65E0", Offset = "0x64F59E0", VA = "0x1864F65E0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5750", Offset = "0x64F4B50", VA = "0x1864F5750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x64F5840", Offset = "0x64F4C40", VA = "0x1864F5840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64F4B20", Offset = "0x64F3F20", VA = "0x1864F4B20")]
	public static BDOFDMHMNPK BJEJDIKODKG(Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x64F4940", Offset = "0x64F3D40", VA = "0x1864F4940")]
	public static BDOFDMHMNPK BJEJDIKODKG(Behaviour LAACBMJOJOJ, Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x64F4A00", Offset = "0x64F3E00", VA = "0x1864F4A00")]
	public static BDOFDMHMNPK BJEJDIKODKG(Behaviour LAACBMJOJOJ, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64F4C60", Offset = "0x64F4060", VA = "0x1864F4C60")]
	[IteratorStateMachine(typeof(CEELPFAAJKC))]
	private static IEnumerator<EIIEDLICJGP> IJIHGAIHODC(CANKODDCPEJ JMODEJIPHGK, Action EEBJMMELNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x64F4BD0", Offset = "0x64F3FD0", VA = "0x1864F4BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5BD0", Offset = "0x64F4FD0", VA = "0x1864F5BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x64F5C60", Offset = "0x64F5060", VA = "0x1864F5C60", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x650C370", Offset = "0x650B770", VA = "0x18650C370")]
	public NOCBOIAPMOG(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x650C2F0", Offset = "0x650B6F0", VA = "0x18650C2F0")]
	[IteratorStateMachine(typeof(BJNDMLNDMPH))]
	private IEnumerator<EIIEDLICJGP> PJLPAGHABLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x650C250", Offset = "0x650B650", VA = "0x18650C250", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F5A90", Offset = "0x64F4E90", VA = "0x1864F5A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F4FF0", Offset = "0x64F43F0", VA = "0x1864F4FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64F5070", Offset = "0x64F4470", VA = "0x1864F5070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6502FC0", Offset = "0x65023C0", VA = "0x186502FC0")]
	public static BDOFDMHMNPK BJEJDIKODKG(float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x65030C0", Offset = "0x65024C0", VA = "0x1865030C0")]
	public static BDOFDMHMNPK BJEJDIKODKG(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x65032E0", Offset = "0x65026E0", VA = "0x1865032E0")]
	public static BDOFDMHMNPK EJMKBIGLCDA(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x65031D0", Offset = "0x65025D0", VA = "0x1865031D0")]
	public static BDOFDMHMNPK EAIBOEPDBMN(JLLGIDDFMND LAACBMJOJOJ, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6503460", Offset = "0x6502860", VA = "0x186503460")]
	private static IEnumerator<EIIEDLICJGP> IJIHGAIHODC(AGDENGFECFE ECINKGKIFIN, float JDPBFPGNKNK, CANKODDCPEJ JMODEJIPHGK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6503400", Offset = "0x6502800", VA = "0x186503400")]
	private static IEnumerator<EIIEDLICJGP> HJHDMHLKKJE(AGDENGFECFE ECINKGKIFIN, float JDPBFPGNKNK, CANKODDCPEJ JMODEJIPHGK, Action<float> EEBJMMELNII, bool DCKHFPKOCIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6503520", Offset = "0x6502920", VA = "0x186503520")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F5CB0", Offset = "0x64F50B0", VA = "0x1864F5CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x64F5D70", Offset = "0x64F5170", VA = "0x1864F5D70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6504220", Offset = "0x6503620", VA = "0x186504220")]
	[IteratorStateMachine(typeof(BLMJNJPDMLG))]
	private static IEnumerator<EIIEDLICJGP> LLJNDFNHHOB(CANKODDCPEJ KFALGGAKOBE, Func<bool> KCKDDHKPEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6504100", Offset = "0x6503500", VA = "0x186504100")]
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
		[Cpp2IlInjected.Address(RVA = "0x650B460", Offset = "0x650A860", VA = "0x18650B460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x650B4D0", Offset = "0x650A8D0", VA = "0x18650B4D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x650D780", Offset = "0x650CB80", VA = "0x18650D780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x650D810", Offset = "0x650CC10", VA = "0x18650D810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6500B40", Offset = "0x64FFF40", VA = "0x186500B40")]
	[IteratorStateMachine(typeof(MBDCAJJNMPE))]
	private static IEnumerator<EIIEDLICJGP> PJLPAGHABLN(float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6500600", Offset = "0x64FFA00", VA = "0x186500600")]
	[IteratorStateMachine(typeof(ONHALDDPLAG))]
	private static IEnumerator<EIIEDLICJGP> HNOHOMKHBMH(float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x65004B0", Offset = "0x64FF8B0", VA = "0x1865004B0")]
	public static IDisposable FEBCNBGCHGP(this MonoBehaviour PBJIGNAOGDC, float IODAOFLOKJG, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x65006A0", Offset = "0x64FFAA0", VA = "0x1865006A0")]
	public static BDOFDMHMNPK HOPHDIPEJPO(this MonoBehaviour PBJIGNAOGDC, float IODAOFLOKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6500380", Offset = "0x64FF780", VA = "0x186500380")]
	public static BDOFDMHMNPK FEBCNBGCHGP(this MonoBehaviour PBJIGNAOGDC, float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6500360", Offset = "0x64FF760", VA = "0x186500360")]
	public static BDOFDMHMNPK CDNOCLOKLNI(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6500A00", Offset = "0x64FFE00", VA = "0x186500A00")]
	public static BDOFDMHMNPK MAEHGGKJJBK(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6500A60", Offset = "0x64FFE60", VA = "0x186500A60")]
	public static BDOFDMHMNPK PBAJJLCMIGC(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6500A30", Offset = "0x64FFE30", VA = "0x186500A30")]
	public static BDOFDMHMNPK MIONIDFAPIN(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65005D0", Offset = "0x64FF9D0", VA = "0x1865005D0")]
	public static BDOFDMHMNPK GMCDLJENFNB(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6500760", Offset = "0x64FFB60", VA = "0x186500760")]
	public static BDOFDMHMNPK IABIEPOJCJL(this MonoBehaviour PBJIGNAOGDC, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6500860", Offset = "0x64FFC60", VA = "0x186500860")]
	private static BDOFDMHMNPK KGBCCFHJOGO(MonoBehaviour PBJIGNAOGDC, CANKODDCPEJ KFALGGAKOBE, Action KMOKEKJAEFE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65001C0", Offset = "0x64FF5C0", VA = "0x1865001C0")]
	public static BDOFDMHMNPK BCAJCOJAKFP(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6500790", Offset = "0x64FFB90", VA = "0x186500790")]
	public static BDOFDMHMNPK IPLCOPLKIPD(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6500930", Offset = "0x64FFD30", VA = "0x186500930")]
	public static BDOFDMHMNPK KODCIJCPLGM(this MonoBehaviour PBJIGNAOGDC, float BMMNFJEALKO, Action KMOKEKJAEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6500290", Offset = "0x64FF690", VA = "0x186500290")]
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
		[Cpp2IlInjected.Address(RVA = "0x6502490", Offset = "0x6501890", VA = "0x186502490", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FBIHEIKFGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6502B40", Offset = "0x6501F40", VA = "0x186502B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6502A20", Offset = "0x6501E20", VA = "0x186502A20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6502D40", Offset = "0x6502140", VA = "0x186502D40")]
	public GKFGELDNIJL([Optional] Action CFMONLCNNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x65025D0", Offset = "0x65019D0", VA = "0x1865025D0")]
	public void BKKEPFPDOJH(LGGNEBBFDDB GEDGCPKDEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6502BE0", Offset = "0x6501FE0", VA = "0x186502BE0")]
	private void PIAFCDGADDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6502700", Offset = "0x6501B00", VA = "0x186502700", Slot = "7")]
	public bool CAHOLFCGBMA(bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6502710", Offset = "0x6501B10", VA = "0x186502710", Slot = "8")]
	public bool CAHOLFCGBMA(Action ONCLGAMIHNG, bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6502AC0", Offset = "0x6501EC0", VA = "0x186502AC0", Slot = "9")]
	public IEnumerator<LGGNEBBFDDB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6502AC0", Offset = "0x6501EC0", VA = "0x186502AC0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F7FF0", Offset = "0x64F73F0", VA = "0x1864F7FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F7FF0", Offset = "0x64F73F0", VA = "0x1864F7FF0")]
		internal void BHGKOPLDKPC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float COHJDPAIOFP;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x64F4840", Offset = "0x64F3C40", VA = "0x1864F4840")]
	public DNBPIHOAAAF(Behaviour LAACBMJOJOJ, float COHJDPAIOFP, [Optional] Action CFMONLCNNOP, [Optional] DAHKGHMHLKA FDOFKCPCEMO, [Optional] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x64FE230", Offset = "0x64FD630", VA = "0x1864FE230", Slot = "9")]
	protected override bool LHOGILDLJCK(Action ONCLGAMIHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x64FE120", Offset = "0x64FD520", VA = "0x1864FE120", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x650C0F0", Offset = "0x650B4F0", VA = "0x18650C0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x650C1C0", Offset = "0x650B5C0", VA = "0x18650C1C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xEA9900", Offset = "0xEA8D00", VA = "0x180EA9900", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FBIHEIKFGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x65078F0", Offset = "0x6506CF0", VA = "0x1865078F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6507780", Offset = "0x6506B80", VA = "0x186507780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6507C70", Offset = "0x6507070", VA = "0x186507C70")]
	protected KMALIPLJFAA(Behaviour LAACBMJOJOJ, [Optional] Action CFMONLCNNOP, [Optional] DAHKGHMHLKA FDOFKCPCEMO, [Optional] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6507720", Offset = "0x6506B20", VA = "0x186507720", Slot = "7")]
	public bool CAHOLFCGBMA(bool EHGFADNFMAI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x65076C0", Offset = "0x6506AC0", VA = "0x1865076C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507C50", Offset = "0x6507050", VA = "0x186507C50")]
	protected void PNKCMBKGBHE(Action ONCLGAMIHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6507A10", Offset = "0x6506E10", VA = "0x186507A10")]
	protected AIDJGFFPANM MIGNJAKMFIP(float EMNJLCFBMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6507990", Offset = "0x6506D90", VA = "0x186507990")]
	private void MCEBPLLNIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6507820", Offset = "0x6506C20", VA = "0x186507820")]
	[IteratorStateMachine(typeof(MPDJPKMKMHG))]
	private IEnumerator<EIIEDLICJGP> HOHADDLAFKO(float EMNJLCFBMME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x65078B0", Offset = "0x6506CB0", VA = "0x1865078B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6508310", Offset = "0x6507710", VA = "0x186508310")]
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
	[Cpp2IlInjected.Address(RVA = "0x6508090", Offset = "0x6507490", VA = "0x186508090", Slot = "10")]
	protected override bool COAGHJHMOLD(Action ONCLGAMIHNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6508290", Offset = "0x6507690", VA = "0x186508290")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F4840", Offset = "0x64F3C40", VA = "0x1864F4840")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F4800", Offset = "0x64F3C00", VA = "0x1864F4800", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6502DE0", Offset = "0x65021E0", VA = "0x186502DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6502E50", Offset = "0x6502250", VA = "0x186502E50", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x65058D0", Offset = "0x6504CD0", VA = "0x1865058D0")]
	public JNDDGHENGDP(JLLGIDDFMND LAACBMJOJOJ, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x65053A0", Offset = "0x65047A0", VA = "0x1865053A0")]
	private void HFGLEKBNNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6505540", Offset = "0x6504940", VA = "0x186505540")]
	private void HIMOLCCBIFG(string HCMLCAPJMPH, Action EBBAKPGHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x65056A0", Offset = "0x6504AA0", VA = "0x1865056A0")]
	[IteratorStateMachine(typeof(GKMOINPPGGC))]
	private IEnumerator<EIIEDLICJGP> JIDEGENNIJP(Action EBBAKPGHNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6505340", Offset = "0x6504740", VA = "0x186505340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6505720", Offset = "0x6504B20", VA = "0x186505720")]
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
		[Cpp2IlInjected.Address(RVA = "0x6502DE0", Offset = "0x65021E0", VA = "0x186502DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x650D2F0", Offset = "0x650C6F0", VA = "0x18650D2F0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x64FDAA0", Offset = "0x64FCEA0", VA = "0x1864FDAA0")]
	public DJBHIOJCHBO(MonoBehaviour PBJIGNAOGDC, Action EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x64FDEE0", Offset = "0x64FD2E0", VA = "0x1864FDEE0")]
	public DJBHIOJCHBO(MonoBehaviour PBJIGNAOGDC, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x64FDC90", Offset = "0x64FD090", VA = "0x1864FDC90")]
	public DJBHIOJCHBO(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x188F9A0", Offset = "0x188EDA0", VA = "0x18188F9A0")]
	private DJBHIOJCHBO(DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x64FD730", Offset = "0x64FCB30", VA = "0x1864FD730")]
	internal static DJBHIOJCHBO HGIMDLPJDHO(MonoBehaviour PBJIGNAOGDC, float JDPBFPGNKNK, Action<float> EEBJMMELNII, CANKODDCPEJ KFALGGAKOBE, bool DCKHFPKOCIN = true, [Optional] DAHKGHMHLKA FDOFKCPCEMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x64FCFB0", Offset = "0x64FC3B0", VA = "0x1864FCFB0")]
	private void BJEJDIKODKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x64FD3D0", Offset = "0x64FC7D0", VA = "0x1864FD3D0")]
	private void HBIJHMLKKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x64FD580", Offset = "0x64FC980", VA = "0x1864FD580")]
	private void HFGLEKBNNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x64FD210", Offset = "0x64FC610", VA = "0x1864FD210")]
	private void FFEENIMIIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x64FD860", Offset = "0x64FCC60", VA = "0x1864FD860")]
	private void HIMOLCCBIFG(string HCMLCAPJMPH, Action EBBAKPGHNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x64FDA20", Offset = "0x64FCE20", VA = "0x1864FDA20")]
	[IteratorStateMachine(typeof(OHCAHAHOEBH))]
	private IEnumerator<EIIEDLICJGP> JIDEGENNIJP(Action EBBAKPGHNFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x64FD120", Offset = "0x64FC520", VA = "0x1864FD120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x64FCF20", Offset = "0x64FC320", VA = "0x1864FCF20")]
	[CompilerGenerated]
	private void AHHJFKMAAHG(string GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x64FD180", Offset = "0x64FC580", VA = "0x1864FD180")]
	[CompilerGenerated]
	private void EIHLLBEKLNH(string GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x64FD990", Offset = "0x64FCD90", VA = "0x1864FD990")]
	[CompilerGenerated]
	private void IBCFKPBLILB(string GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64FCE90", Offset = "0x64FC290", VA = "0x1864FCE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6504520", Offset = "0x6503920", VA = "0x186504520", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float HIPFFOBKPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6504480", Offset = "0x6503880", VA = "0x186504480", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double ADCPLMDBKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6504490", Offset = "0x6503890", VA = "0x186504490", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x65044B0", Offset = "0x65038B0", VA = "0x1865044B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x650DF50", Offset = "0x650D350", VA = "0x18650DF50")]
	public static EIIEDLICJGP MCFLMDLEOIA(IEnumerator<EIIEDLICJGP> BKLKHLHIGPA, LOAIDDLGPPP AHLFODDIBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x650E0B0", Offset = "0x650D4B0", VA = "0x18650E0B0")]
	public EIIEDLICJGP MCFLMDLEOIA(LOAIDDLGPPP[] CMLNGHHJDNL, IEnumerator<EIIEDLICJGP>[] FCJAMAALOMH, EIIEDLICJGP[] GJDHFAOMNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x650DDE0", Offset = "0x650D1E0", VA = "0x18650DDE0")]
	public void AMOEMHIJICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x650E170", Offset = "0x650D570", VA = "0x18650E170")]
	public void OEDNOBOOEAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x650DE10", Offset = "0x650D210", VA = "0x18650DE10")]
	public void EFOOBCHKPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x650DDE0", Offset = "0x650D1E0", VA = "0x18650DDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6501580", Offset = "0x6500980", VA = "0x186501580")]
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
		[Cpp2IlInjected.Address(RVA = "0x650C210", Offset = "0x650B610", VA = "0x18650C210")]
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
		[Cpp2IlInjected.Address(RVA = "0x65074F0", Offset = "0x65068F0", VA = "0x1865074F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65035B0", Offset = "0x65029B0", VA = "0x1865035B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x964300", Offset = "0x963700", VA = "0x180964300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x650A7E0", Offset = "0x6509BE0", VA = "0x18650A7E0")]
	private static int PALNOKOEKAF(CANKODDCPEJ KFALGGAKOBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x650A810", Offset = "0x6509C10", VA = "0x18650A810")]
	public LIMOBDMJLII(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x65094B0", Offset = "0x65088B0", VA = "0x1865094B0")]
	private void GACEHOOOJCG(int LNDNHIMNKDH, int KPPIOECHHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6508950", Offset = "0x6507D50", VA = "0x186508950")]
	public void DBNEKHBIAEG(JLLGIDDFMND LAACBMJOJOJ, EIIEDLICJGP BINJFEDHLMG, IEnumerator<EIIEDLICJGP> BKLKHLHIGPA, LOAIDDLGPPP AHLFODDIBHC, [Optional] PAJGAAHJDNE BLNGAHEGKJP, FPMAJGAKACB CCEBCEIFHPA = FPMAJGAKACB.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6509690", Offset = "0x6508A90", VA = "0x186509690")]
	public void GCMMIPEOEGJ(IEnumerable<FBKHFPOBOFL> AALDEDNGFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6508B50", Offset = "0x6507F50", VA = "0x186508B50")]
	private FBKHFPOBOFL FEBDCODIAFF(int LIJOMHJNLJI)
	{
		return default(FBKHFPOBOFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x65085E0", Offset = "0x65079E0", VA = "0x1865085E0")]
	private void CONHMNIMCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x25840C0", Offset = "0x25834C0", VA = "0x1825840C0")]
	private static void DKGNBJIEGEI<T>(int LIJOMHJNLJI, T[] GLBJACBDNPI, int PEGIIHFIAHP, [Optional] T JHMGOBPBFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2584110", Offset = "0x2583510", VA = "0x182584110")]
	private static void DKGNBJIEGEI<T>(int LIJOMHJNLJI, NativeArray<T> GLBJACBDNPI, int PEGIIHFIAHP, [Optional] T JHMGOBPBFPI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6509990", Offset = "0x6508D90", VA = "0x186509990")]
	private void KCNAOHAIOLO(IEnumerable<FBKHFPOBOFL> AALDEDNGFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x65098D0", Offset = "0x6508CD0", VA = "0x1865098D0")]
	private void IDFPKMBLNEP(FBKHFPOBOFL DDLAFOHNDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6509250", Offset = "0x6508650", VA = "0x186509250")]
	private LJGOLBFBEMD GACAMMKPIKA(int CGPJMIBDKNG)
	{
		return default(LJGOLBFBEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6509EE0", Offset = "0x65092E0", VA = "0x186509EE0")]
	public void MFPKMNNDAHB(float JOANGLMKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6508AD0", Offset = "0x6507ED0", VA = "0x186508AD0")]
	private void ELNFPHFOFFA(Action JMHOJIPAIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6509D30", Offset = "0x6509130", VA = "0x186509D30")]
	private void KEJPLBBOPOM(Action JMHOJIPAIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x650A0E0", Offset = "0x65094E0", VA = "0x18650A0E0")]
	public void NCEDEHHHHOO(float JOANGLMKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6509020", Offset = "0x6508420", VA = "0x186509020")]
	public void FJNCMFNOBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6509120", Offset = "0x6508520", VA = "0x186509120")]
	public void FKIPELKDAKL(PAJGAAHJDNE EAAOMNOFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6509DB0", Offset = "0x65091B0", VA = "0x186509DB0")]
	public void MBEKMKBLEME(PAJGAAHJDNE EAAOMNOFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x65084B0", Offset = "0x65078B0", VA = "0x1865084B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x650D630", Offset = "0x650CA30", VA = "0x18650D630", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3963C30", Offset = "0x3963030", VA = "0x183963C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F31F0", Offset = "0x7F25F0", VA = "0x1807F31F0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2250", Offset = "0x3CE1650", VA = "0x183CE2250", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CE20D0", Offset = "0x3CE14D0", VA = "0x183CE20D0")]
	private static bool BFECBGLIINN(T JMHOJIPAIMC, T MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2380", Offset = "0x3CE1780", VA = "0x183CE2380")]
	public MMPNGFOPHHC(T BCMHALABOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1750", Offset = "0x3CE0B50", VA = "0x183CE1750", Slot = "6")]
	public IDisposable AFJPCNDJPMD(UnityEngine.Object LAACBMJOJOJ, Action<T> JAIEDAFGMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1A70", Offset = "0x3CE0E70", VA = "0x183CE1A70")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507F70", Offset = "0x6507370", VA = "0x186507F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x6507FE0", Offset = "0x65073E0", VA = "0x186507FE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64FEC00", Offset = "0x64FE000", VA = "0x1864FEC00")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void HJJHDPAKHCO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x64FF4F0", Offset = "0x64FE8F0", VA = "0x1864FF4F0")]
	[Preserve]
	public EHOLFMJJEAL([MJHHGJKKIMK(null)] NHEGGEMENKH GNGMMGMAMJD, [MJHHGJKKIMK(null)] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x64FF2A0", Offset = "0x64FE6A0", VA = "0x1864FF2A0", Slot = "17")]
	public override BDOFDMHMNPK NEIMDGECDCK(JLLGIDDFMND LAACBMJOJOJ, IEnumerator<EIIEDLICJGP> OKINDPHHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x64FF010", Offset = "0x64FE410", VA = "0x1864FF010", Slot = "18")]
	public override void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x64FEC70", Offset = "0x64FE070", VA = "0x1864FEC70", Slot = "20")]
	public override void JGDNNPPMCPD(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x64FEEA0", Offset = "0x64FE2A0", VA = "0x1864FEEA0", Slot = "19")]
	protected override void LFKJJNEOHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x64FE8C0", Offset = "0x64FDCC0", VA = "0x1864FE8C0")]
	private LIMOBDMJLII CIANEDGLHHP(CANKODDCPEJ LFLAEPCPMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x64FE950", Offset = "0x64FDD50", VA = "0x1864FE950", Slot = "21")]
	internal override CMDCHNFILEE FGDBDBAKHLF(IEnumerator<EIIEDLICJGP> OKINDPHHPBN, Behaviour LAACBMJOJOJ, LOAIDDLGPPP AHLFODDIBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x64FEB80", Offset = "0x64FDF80", VA = "0x1864FEB80", Slot = "22")]
	internal override CHBJINMJAGK FPELOBDHALB(CANKODDCPEJ JMODEJIPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x64FF3D0", Offset = "0x64FE7D0", VA = "0x1864FF3D0")]
	private void OAJFEHFBANP(LIMOBDMJLII LLEMOFNDDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x64FE8F0", Offset = "0x64FDCF0", VA = "0x1864FE8F0", Slot = "23")]
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
	[Cpp2IlInjected.Address(RVA = "0x6502240", Offset = "0x6501640", VA = "0x186502240")]
	public static GKCLKDADEJH EBILOFOJHAE(int LPLOFGIHJKC, float JOANGLMKMAI, NativeArray<FPMAJGAKACB> PKGHDGMIEMN, NativeArray<float> HIMFMJIABHC, NativeArray<int> MOLDDDEACAO, NativeArray<int> AMMBJFKLFPC, NativeArray<int> DAEMCLFOCCL, NativeArray<int> LKNNFAGIPCK, NativeArray<int> EPFBPOFCMMM)
	{
		return default(GKCLKDADEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x65022A0", Offset = "0x65016A0", VA = "0x1865022A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6502450", Offset = "0x6501850", VA = "0x186502450")]
	private bool PNIGBPNDOPD(int DIENMHDGFGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6502380", Offset = "0x6501780", VA = "0x186502380")]
	private void FKFGBAHIOAK(NativeArray<int> AGOLNOEJENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x65023B0", Offset = "0x65017B0", VA = "0x1865023B0")]
	private int LNNKDHFMIJK(int CAEBNGFJCDK, int BIMCKCHJJEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6502170", Offset = "0x6501570", VA = "0x186502170")]
	private void DFCIDMGGFNC(NativeArray<int> AGOLNOEJENC, int IPBMAPOGFEC, int BCPCCCLDBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6501F30", Offset = "0x6501330", VA = "0x186501F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x650E9D0", Offset = "0x650DDD0", VA = "0x18650E9D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x650EED0", Offset = "0x650E2D0", VA = "0x18650EED0")]
	public static BDOFDMHMNPK IKBINDEIAGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x650F250", Offset = "0x650E650", VA = "0x18650F250")]
	[Preserve]
	protected PMKAOGFPDIL([MJHHGJKKIMK(null)] NHEGGEMENKH GNGMMGMAMJD, [MJHHGJKKIMK(null)] AGDENGFECFE ECINKGKIFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x650EE10", Offset = "0x650E210", VA = "0x18650EE10", Slot = "6")]
	public BDOFDMHMNPK IAACBCPLMFD(IEnumerator<EIIEDLICJGP> OKINDPHHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x650EC10", Offset = "0x650E010", VA = "0x18650EC10", Slot = "7")]
	public BDOFDMHMNPK IAACBCPLMFD(Behaviour LAACBMJOJOJ, IEnumerator<EIIEDLICJGP> OKINDPHHPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	public abstract BDOFDMHMNPK NEIMDGECDCK(JLLGIDDFMND LAACBMJOJOJ, IEnumerator<EIIEDLICJGP> OKINDPHHPBN);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x650F070", Offset = "0x650E470", VA = "0x18650F070", Slot = "18")]
	public virtual void MADHOJJNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x650E770", Offset = "0x650DB70", VA = "0x18650E770", Slot = "9")]
	public void EOJPPNEAFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x650EFF0", Offset = "0x650E3F0", VA = "0x18650EFF0", Slot = "19")]
	protected virtual void LFKJJNEOHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x650F210", Offset = "0x650E610", VA = "0x18650F210")]
	private void MGHMGDCPDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x650E750", Offset = "0x650DB50", VA = "0x18650E750")]
	private void EODLECMDMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x650F230", Offset = "0x650E630", VA = "0x18650F230")]
	private void MNPPDGLOEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x650EEB0", Offset = "0x650E2B0", VA = "0x18650EEB0")]
	private void IELNLCCEBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x650E9B0", Offset = "0x650DDB0", VA = "0x18650E9B0")]
	private void FIHAJOBLGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x650E310", Offset = "0x650D710", VA = "0x18650E310")]
	private void BCCNCGIHPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x650EA20", Offset = "0x650DE20", VA = "0x18650EA20")]
	private void FPKCPAKEPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x650EF60", Offset = "0x650E360", VA = "0x18650EF60", Slot = "20")]
	public virtual void JGDNNPPMCPD(CANKODDCPEJ KFALGGAKOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x650EA40", Offset = "0x650DE40", VA = "0x18650EA40")]
	private void GPLHNBILOGL(CHBJINMJAGK LLEMOFNDDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1BF5A40", Offset = "0x1BF4E40", VA = "0x181BF5A40")]
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
	[Cpp2IlInjected.Address(RVA = "0x650E330", Offset = "0x650D730", VA = "0x18650E330", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x650E6F0", Offset = "0x650DAF0", VA = "0x18650E6F0", Slot = "13")]
	public EIIEDLICJGP EEKPECLBKPG(CANKODDCPEJ JMODEJIPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x650EE20", Offset = "0x650E220", VA = "0x18650EE20", Slot = "14")]
	public EIIEDLICJGP IDCNIANLMJE(float IODAOFLOKJG, CANKODDCPEJ JMODEJIPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x650F010", Offset = "0x650E410", VA = "0x18650F010", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F8A90", Offset = "0x64F7E90", VA = "0x1864F8A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool CIDGOHJPOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF350", Offset = "0x7DE750", VA = "0x1807DF350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7DF360", Offset = "0x7DE760", VA = "0x1807DF360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x64F8510", Offset = "0x64F7910", VA = "0x1864F8510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float NBIJMHDLDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1026E70", Offset = "0x1026270", VA = "0x181026E70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x54A8BC0", Offset = "0x54A7FC0", VA = "0x1854A8BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64F8BF0", Offset = "0x64F7FF0", VA = "0x1864F8BF0")]
	public CMDCHNFILEE(IEnumerator<EIIEDLICJGP> BKLKHLHIGPA, NGIMCMGIJPF LAACBMJOJOJ, LOAIDDLGPPP AHLFODDIBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64F8780", Offset = "0x64F7B80", VA = "0x1864F8780")]
	public EIIEDLICJGP MCFLMDLEOIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64F8710", Offset = "0x64F7B10", VA = "0x1864F8710")]
	public bool GPCOBNGBDAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64F86C0", Offset = "0x64F7AC0", VA = "0x1864F86C0")]
	public void FKIPELKDAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64F8B10", Offset = "0x64F7F10", VA = "0x1864F8B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x854FA0", Offset = "0x8543A0", VA = "0x180854FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDA8380", Offset = "0xDA7780", VA = "0x180DA8380", Slot = "23")]
		get
		{
			return default(CANKODDCPEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public CANKODDCPEJ EDONEEHCNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x129F970", Offset = "0x129ED70", VA = "0x18129F970")]
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
	[Cpp2IlInjected.Address(RVA = "0x650B1F0", Offset = "0x650A5F0", VA = "0x18650B1F0", Slot = "24")]
	private bool LCOJBMOPCEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x650B1E0", Offset = "0x650A5E0", VA = "0x18650B1E0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x650B210", Offset = "0x650A610", VA = "0x18650B210")]
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
	[Cpp2IlInjected.Address(RVA = "0x64F7B50", Offset = "0x64F6F50", VA = "0x1864F7B50")]
	public CHBJINMJAGK(CANKODDCPEJ JMODEJIPHGK, NCHEKCHAENH FONPMNFEOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x64F6930", Offset = "0x64F5D30", VA = "0x1864F6930")]
	public void BDECOBGGJKP(CMDCHNFILEE BKLKHLHIGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x64F72D0", Offset = "0x64F66D0", VA = "0x1864F72D0")]
	public void JGMCBJCPKPP(IList<CMDCHNFILEE> FCJAMAALOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x64F6FC0", Offset = "0x64F63C0", VA = "0x1864F6FC0")]
	public void JGGHEKKCIBL(IList<CMDCHNFILEE> FCJAMAALOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x64F6B50", Offset = "0x64F5F50", VA = "0x1864F6B50")]
	private void EFJLOONODCD(CMDCHNFILEE BKLKHLHIGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x64F6E30", Offset = "0x64F6230", VA = "0x1864F6E30")]
	private void HMDNIIODJDG(IList<CMDCHNFILEE> FCJAMAALOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x64F7890", Offset = "0x64F6C90", VA = "0x1864F7890")]
	private LJGOLBFBEMD OGMKIBOPBCE(CMDCHNFILEE BKLKHLHIGPA)
	{
		return default(LJGOLBFBEMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x64F7720", Offset = "0x64F6B20", VA = "0x1864F7720")]
	public void LFKJJNEOHNN(float JOANGLMKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x64F6C40", Offset = "0x64F6040", VA = "0x1864F6C40")]
	public void EOJPPNEAFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x64F6630", Offset = "0x64F5A30", VA = "0x1864F6630")]
	private void APHOHFCPEBE(List<CMDCHNFILEE> FCJAMAALOMH, Stack<int> AACBCMJEKMN, bool GDHFBDLAPAC, float PFGDLODCJLB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x64F6A30", Offset = "0x64F5E30", VA = "0x1864F6A30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x64F75E0", Offset = "0x64F69E0", VA = "0x1864F75E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x650D090", Offset = "0x650C490", VA = "0x18650D090", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KLNEECJHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x650D130", Offset = "0x650C530", VA = "0x18650D130", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool DOOPCINNPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x650D110", Offset = "0x650C510", VA = "0x18650D110", Slot = "6")]
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

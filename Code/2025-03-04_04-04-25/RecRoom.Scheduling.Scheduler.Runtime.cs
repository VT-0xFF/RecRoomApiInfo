using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F617D0", Offset = "0x7F5FDD0", VA = "0x187F617D0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F684D0", Offset = "0x7F66AD0", VA = "0x187F684D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private delegate List<PlayerLoopSystem> HMMHJOCGBLE(List<PlayerLoopSystem> NECLJINCKDK, int ADLBHDMDIFE);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct NFJOLNPFJPH
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct FBHNMPAAOLN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static FKDOIPNGGAF OLKEMGEABBE;

				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x7F55060", Offset = "0x7F53660", VA = "0x187F55060")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct KGMHIBGIPGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static FKDOIPNGGAF GAFIFHHFHOC;

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7F5D090", Offset = "0x7F5B690", VA = "0x187F5D090")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct HGKBBHHBNJK
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static FKDOIPNGGAF FKHDPHOIEAC;

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x7F588D0", Offset = "0x7F56ED0", VA = "0x187F588D0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct IONJGBDLDOI
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static FKDOIPNGGAF ILHDHCIAIKB;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static FKDOIPNGGAF FDNDNKFIJAL;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static FKDOIPNGGAF LKDDILAPLJL;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static FKDOIPNGGAF LJJGFLNEOJJ;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7F5B9D0", Offset = "0x7F59FD0", VA = "0x187F5B9D0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct JKEKGMCJBKN
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static FKDOIPNGGAF LMHHPIBKIBF;

				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x7F5CC70", Offset = "0x7F5B270", VA = "0x187F5CC70")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct CJDIILLHDLL
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static FKDOIPNGGAF ILHDHCIAIKB;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static FKDOIPNGGAF FDNDNKFIJAL;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static FKDOIPNGGAF LKDDILAPLJL;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static FKDOIPNGGAF LJJGFLNEOJJ;

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x7F4C220", Offset = "0x7F4A820", VA = "0x187F4C220")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct PBFIKOJOJED
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static FKDOIPNGGAF HGBKDLPEPMN;

				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7F66EC0", Offset = "0x7F654C0", VA = "0x187F66EC0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct NDEKAILAJHJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static FKDOIPNGGAF DIBGHNPIMFD;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7F65C90", Offset = "0x7F64290", VA = "0x187F65C90")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct JACIKLAIBAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static FKDOIPNGGAF JGHFMFCIGON;

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x7F5BCC0", Offset = "0x7F5A2C0", VA = "0x187F5BCC0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct MCJIDGELKDI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static FKDOIPNGGAF FANNHIEGJHL;

				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7F623F0", Offset = "0x7F609F0", VA = "0x187F623F0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct LHLLHGMIMAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static FKDOIPNGGAF AJGGLFJDDBK;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x7F615D0", Offset = "0x7F5FBD0", VA = "0x187F615D0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct HLKHEMMHFEN
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static FKDOIPNGGAF HCJGIKPPLHA;

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x7F58CC0", Offset = "0x7F572C0", VA = "0x187F58CC0")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct JFFMIGAJPOM
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static FKDOIPNGGAF DFAFKGJLCEA;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x7F5CA70", Offset = "0x7F5B070", VA = "0x187F5CA70")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct IKGOBKEFBJI
			{
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static FKDOIPNGGAF FPJBJJHOIIG;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x7F5A000", Offset = "0x7F58600", VA = "0x187F5A000")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public struct NCKADBONABM
			{
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static FKDOIPNGGAF BNJBNDEADFB;

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7F65A90", Offset = "0x7F64090", VA = "0x187F65A90")]
				public static PlayerLoopSystem POCMBADNKNA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public enum DKDIHELMENL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public struct BDFFNMFDAEO
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class LAFGFDDDLCE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public DKDIHELMENL updateStage;

					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
					public LAFGFDDDLCE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x7F61430", Offset = "0x7F5FA30", VA = "0x187F61430")]
					internal void KMPPAFOCAPE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static JKOOBLENGDB<DKDIHELMENL> ICGOBMKAMEM;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7F4B880", Offset = "0x7F49E80", VA = "0x187F4B880")]
				public static PlayerLoopSystem POCMBADNKNA(DKDIHELMENL DMPBNKHPPFN)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000028")]
			internal struct HPAJGGNEJIH
			{
				[Cpp2IlInjected.Token(Token = "0x2000029")]
				[CompilerGenerated]
				private sealed class MFADIAKPJDE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public FBKDKHJNAMN.DCABFILEKBI key;

					[Cpp2IlInjected.Token(Token = "0x600005F")]
					[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
					public MFADIAKPJDE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x7F64060", Offset = "0x7F62660", VA = "0x187F64060")]
					internal void OMEEAIPPGLE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable NFLDEJBDFFD;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7F59ED0", Offset = "0x7F584D0", VA = "0x187F59ED0")]
				public static PlayerLoopSystem LIPLLHPADGJ(FBKDKHJNAMN.DCABFILEKBI LKMGECEEGEE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200002B")]
			internal struct CEOKDHOIBNA
			{
				[Cpp2IlInjected.Token(Token = "0x200002C")]
				[CompilerGenerated]
				private sealed class CFCJKMOPMNC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public FBKDKHJNAMN.DCABFILEKBI key;

					[Cpp2IlInjected.Token(Token = "0x6000065")]
					[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
					public CFCJKMOPMNC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x7F4BFA0", Offset = "0x7F4A5A0", VA = "0x187F4BFA0")]
					internal void OMEEAIPPGLE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7F4BE70", Offset = "0x7F4A470", VA = "0x187F4BE70")]
				public static PlayerLoopSystem LIPLLHPADGJ(FBKDKHJNAMN.DCABFILEKBI LKMGECEEGEE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HHHFOPFLCJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public HHHFOPFLCJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F58AD0", Offset = "0x7F570D0", VA = "0x187F58AD0")]
			internal List<PlayerLoopSystem> HCDODKJGMLF(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OCFJDIMJDNE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool DLIAJGKCEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7F51290", Offset = "0x7F4F890", VA = "0x187F51290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E1D0", Offset = "0x7F4C7D0", VA = "0x187F4E1D0")]
		private static void LBGELLEOEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D160", Offset = "0x7F4B760", VA = "0x187F4D160")]
		private static void CDCGIDCAAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D120", Offset = "0x7F4B720", VA = "0x187F4D120")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DF80", Offset = "0x7F4C580", VA = "0x187F4DF80")]
		private static void JMHLGENMPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F512D0", Offset = "0x7F4F8D0", VA = "0x187F512D0")]
		private static void PDJPGCOCKPB(FBKDKHJNAMN.DCABFILEKBI LKMGECEEGEE, PlayerLoopSystem POIPCELIJJK, Type BODJOEANDHC, Type LKHNLDMCJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DA70", Offset = "0x7F4C070", VA = "0x187F4DA70")]
		private static void DHGEKOHKEEK(PlayerLoopSystem POIPCELIJJK, Type BODJOEANDHC, Type LKHNLDMCJCL, HMMHJOCGBLE CGDCIGCDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DE50", Offset = "0x7F4C450", VA = "0x187F4DE50")]
		private static void HKPGCJEEHCA(PlayerLoopSystem POIPCELIJJK, Type BODJOEANDHC, Type LKHNLDMCJCL, PlayerLoopSystem? PEOEOHJOIFA, PlayerLoopSystem? PNLOAGOKEHO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FBKDKHJNAMN
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum DCABFILEKBI
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class MFAOOMEFEDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public readonly DCABFILEKBI COLPGBABMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly NABJBHIKGGL ANFLNDNGPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private long JBBOAGKKPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private long EDBJIMKMBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public long LIIFKKDGFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int HKCNOIBAKFO;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F643F0", Offset = "0x7F629F0", VA = "0x187F643F0")]
		public MFAOOMEFEDA(DCABFILEKBI CFAAJCGEJPH, int PBLJGICNHAL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F642F0", Offset = "0x7F628F0", VA = "0x187F642F0")]
		public void KCKGGOELEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F642A0", Offset = "0x7F628A0", VA = "0x187F642A0")]
		public void FFLGDCIPPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F64310", Offset = "0x7F62910", VA = "0x187F64310")]
		public void KPKHDKCADDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static DCABFILEKBI[] ENGJAELAFNJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static MFAOOMEFEDA[] HEBBNOGEEIP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F55260", Offset = "0x7F53860", VA = "0x187F55260")]
	public static MFAOOMEFEDA BCBFCCNMOCH(DCABFILEKBI LKMGECEEGEE, int PBLJGICNHAL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F553C0", Offset = "0x7F539C0", VA = "0x187F553C0")]
	public static MFAOOMEFEDA EAMFDADDMNG(DCABFILEKBI LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F55430", Offset = "0x7F53A30", VA = "0x187F55430")]
	public static void LCHOKPOPCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HOBFAMFPMPH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private interface EIMNBAHJEKI
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KDDFNIOPDBM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HMABCBLNCNE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class ONOMHHCKBMG : EIMNBAHJEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action PJDAFKMDDCG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KDDFNIOPDBM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
		public ONOMHHCKBMG(Action PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xF61AB0", Offset = "0xF600B0", VA = "0x180F61AB0", Slot = "5")]
		public void HMABCBLNCNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<EIMNBAHJEKI> MPFGGKOIHCD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F59BC0", Offset = "0x7F581C0", VA = "0x187F59BC0")]
	public static void GKIGLHKDACK(Action PJDAFKMDDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F596A0", Offset = "0x7F57CA0", VA = "0x187F596A0")]
	private static void AHIGDCCLNJA(EIMNBAHJEKI NGHMBJGMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F598C0", Offset = "0x7F57EC0", VA = "0x187F598C0")]
	private static void DFIFFIAGJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F59C60", Offset = "0x7F58260", VA = "0x187F59C60")]
	private static void JCLIONFKCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F59D60", Offset = "0x7F58360", VA = "0x187F59D60")]
	private static void OIALPPFDJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FNKNFNKKMFN
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct EICENDFKKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TaskCompletionSource<Scene> CKLPPHCDEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly string GOCBDOMNJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly LoadSceneMode EGNIBDJACLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly bool KFJFEEGFJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7F541F0", Offset = "0x7F527F0", VA = "0x187F541F0")]
		public EICENDFKKBE(TaskCompletionSource<Scene> MECOEADPMKH, string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL, bool KFJFEEGFJLE, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FPJEACFOCPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private FGFDKLMANEA<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F57860", Offset = "0x7F55E60", VA = "0x187F57860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F58100", Offset = "0x7F56700", VA = "0x187F58100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct DJGKAEJHAPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F52590", Offset = "0x7F50B90", VA = "0x187F52590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7F528B0", Offset = "0x7F50EB0", VA = "0x187F528B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CBDLHPHDNCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private EICENDFKKBE <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BA50", Offset = "0x7F4A050", VA = "0x187F4BA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BE10", Offset = "0x7F4A410", VA = "0x187F4BE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class DMAPIFADMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NINOOKDCBLL<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DMAPIFADMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F52910", Offset = "0x7F50F10", VA = "0x187F52910")]
		internal void OBOKENLJDIB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EBBHNHBBJCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private DMAPIFADMED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F52C80", Offset = "0x7F51280", VA = "0x187F52C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F53830", Offset = "0x7F51E30", VA = "0x187F53830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OKIBIKPOAKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private DJPNNBMEIAG <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private AsyncOperationHandle<SceneInstance> <handle>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7F666B0", Offset = "0x7F64CB0", VA = "0x187F666B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F66D70", Offset = "0x7F65370", VA = "0x187F66D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MCGPMCMCGFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FGFDKLMANEA<string>.ICBJPFEBGDJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private FGFDKLMANEA<string>.ICBJPFEBGDJ <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F61860", Offset = "0x7F5FE60", VA = "0x187F61860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F62380", Offset = "0x7F60980", VA = "0x187F62380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GKCEGJCCCHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public NINOOKDCBLL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public GKCEGJCCCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F58500", Offset = "0x7F56B00", VA = "0x187F58500")]
		internal bool OHPNMMFJDOH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F58280", Offset = "0x7F56880", VA = "0x187F58280")]
		internal void INBIAHKAHJE(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KOEDAPJNCCH : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NINOOKDCBLL<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private GKCEGJCCCHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private DJPNNBMEIAG <_>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public KOEDAPJNCCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F613D0", Offset = "0x7F5F9D0", VA = "0x187F613D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F60AE0", Offset = "0x7F5F0E0", VA = "0x187F60AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F60AC0", Offset = "0x7F5F0C0", VA = "0x187F60AC0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F61380", Offset = "0x7F5F980", VA = "0x187F61380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly ICollection<string> OJPFPNKJAKO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static HJOKANJAKGB BKMOMEEJIGC;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static AsyncOperation FOPNNGAKFII;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static HJOKANJAKGB HHFLDJLCJCE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static string OJJKNIBHGCL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static string LEJMIGJMIMO;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static ThreadPriority NHAHINDDHHG;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Task EMKOBDPKDCG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static List<SceneInstance> KNJEDKGEDCB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly Queue<EICENDFKKBE> EBKKHKNDNCM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static Task JPOMKIDFFEF;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> OCIJIPFEPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F568C0", Offset = "0x7F54EC0", VA = "0x187F568C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F567B0", Offset = "0x7F54DB0", VA = "0x187F567B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F55E30", Offset = "0x7F54430", VA = "0x187F55E30")]
	[JBPLEELDMPC(GALPNODIPPP.EnteredEditModeNextFrame, 0)]
	private static void FEOKOHJLKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F562A0", Offset = "0x7F548A0", VA = "0x187F562A0")]
	[AsyncStateMachine(typeof(FPJEACFOCPE))]
	public static Task<Scene> IMMCCBPEFCO(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL = LoadSceneMode.Single, bool KFJFEEGFJLE = false, [Optional] FGFDKLMANEA<string>.ICBJPFEBGDJ KCGHBECOBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F55FF0", Offset = "0x7F545F0", VA = "0x187F55FF0")]
	[AsyncStateMachine(typeof(DJGKAEJHAPF))]
	private static Task GDAGOJOGMCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F569D0", Offset = "0x7F54FD0", VA = "0x187F569D0")]
	[AsyncStateMachine(typeof(CBDLHPHDNCG))]
	private static Task PJLPNBCNOMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F55C40", Offset = "0x7F54240", VA = "0x187F55C40")]
	[AsyncStateMachine(typeof(EBBHNHBBJCL))]
	private static Task<Scene> DLJNHLINHOA(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL, bool KFJFEEGFJLE, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F56520", Offset = "0x7F54B20", VA = "0x187F56520")]
	private static void LMJMCMBFADJ(SceneInstance AIHLLHKMGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F55850", Offset = "0x7F53E50", VA = "0x187F55850")]
	private static void BOLHEGBONMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F55B10", Offset = "0x7F54110", VA = "0x187F55B10")]
	[AsyncStateMachine(typeof(OKIBIKPOAKJ))]
	private static Task<Scene> DDFGJCBCFDI(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F560A0", Offset = "0x7F546A0", VA = "0x187F560A0")]
	private static bool HGAGAIHNNPI(string GOCBDOMNJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F56190", Offset = "0x7F54790", VA = "0x187F56190")]
	[AsyncStateMachine(typeof(MCGPMCMCGFA))]
	private static Task<Scene> HMHPKIGMEPC(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F56630", Offset = "0x7F54C30", VA = "0x187F56630")]
	public static NEEPBAPEEOL<Scene> LPLPIOPOPLK(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F55D90", Offset = "0x7F54390", VA = "0x187F55D90")]
	[IteratorStateMachine(typeof(KOEDAPJNCCH))]
	private static IEnumerator<FBLKJCIOKGP> EACMELMABFE(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL, NINOOKDCBLL<Scene> JPBFMNPPLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F557F0", Offset = "0x7F53DF0", VA = "0x187F557F0")]
	public static void AMCCFPNAPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F55F30", Offset = "0x7F54530", VA = "0x187F55F30")]
	private static void FFPLNKAJNFE(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F563F0", Offset = "0x7F549F0", VA = "0x187F563F0")]
	public static bool LCAABHNEPHO([Out] string PNKNNGBOMLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HCALMBPOGCG
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F58780", Offset = "0x7F56D80", VA = "0x187F58780")]
	public static IDisposable GHFLFNNKHOE(this BMCDILGALJB BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F58700", Offset = "0x7F56D00", VA = "0x187F58700")]
	public static IDisposable ADNGLEDAFFE(this BMCDILGALJB BPPCEJGCMKA, Action<float> DMGPEODFGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F58810", Offset = "0x7F56E10", VA = "0x187F58810")]
	public static IDisposable HLFMHLFCAJA(this BMCDILGALJB BPPCEJGCMKA, Action<float> DMGPEODFGGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JDLMKCIMMMN
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x344FFE0", Offset = "0x344E5E0", VA = "0x18344FFE0")]
	[ABGINMJPEGK]
	public static IDisposable KCPAEDHHGLD<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3450190", Offset = "0x344E790", VA = "0x183450190")]
	[ABGINMJPEGK]
	public static IDisposable KCPAEDHHGLD<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3450470", Offset = "0x344EA70", VA = "0x183450470")]
	[ABGINMJPEGK]
	public static IDisposable PLJNMJIHBJD<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x344F9E0", Offset = "0x344DFE0", VA = "0x18344F9E0")]
	[ABGINMJPEGK]
	public static IDisposable ALLDOJBMADL<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x344F9E0", Offset = "0x344DFE0", VA = "0x18344F9E0")]
	[ABGINMJPEGK]
	public static IDisposable ALLDOJBMADL<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34503E0", Offset = "0x344E9E0", VA = "0x1834503E0")]
	[ABGINMJPEGK]
	public static IDisposable NIFCHODJFAH<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x344FA30", Offset = "0x344E030", VA = "0x18344FA30")]
	[ABGINMJPEGK]
	public static IDisposable BCHLOLGBDIP<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3450390", Offset = "0x344E990", VA = "0x183450390")]
	[ABGINMJPEGK]
	public static IDisposable LEGENFFIDOM<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3450430", Offset = "0x344EA30", VA = "0x183450430")]
	[ABGINMJPEGK]
	public static IDisposable NPIJKLLJBJE<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C890", Offset = "0x7F5AE90", VA = "0x187F5C890")]
	[ABGINMJPEGK]
	public static IDisposable NPIJKLLJBJE(this MonoBehaviour DCDHPNKMBKF, NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x344FE30", Offset = "0x344E430", VA = "0x18344FE30")]
	[ABGINMJPEGK]
	public static IDisposable KBJDEJOJHKF<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3450340", Offset = "0x344E940", VA = "0x183450340")]
	[ABGINMJPEGK]
	public static IDisposable LAENHLKEEKN<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x344FB40", Offset = "0x344E140", VA = "0x18344FB40")]
	[ABGINMJPEGK]
	public static IDisposable CNDLFGLHBOI<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x344FD70", Offset = "0x344E370", VA = "0x18344FD70")]
	[ABGINMJPEGK]
	public static IDisposable JFMEABLEFBH<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x344FAE0", Offset = "0x344E0E0", VA = "0x18344FAE0")]
	[ABGINMJPEGK]
	public static IDisposable CLKNPKJCOFP<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x344FD10", Offset = "0x344E310", VA = "0x18344FD10")]
	[ABGINMJPEGK]
	public static IDisposable HMMOCIKAMMH<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x344FC50", Offset = "0x344E250", VA = "0x18344FC50")]
	[ABGINMJPEGK]
	public static IDisposable FOEDBIBFAIH<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x344FBF0", Offset = "0x344E1F0", VA = "0x18344FBF0")]
	[ABGINMJPEGK]
	public static IDisposable FDJGDNMHMHK<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x344FA80", Offset = "0x344E080", VA = "0x18344FA80")]
	[ABGINMJPEGK]
	public static IDisposable BLBMHCHHAJK<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x344FBA0", Offset = "0x344E1A0", VA = "0x18344FBA0")]
	[ABGINMJPEGK]
	public static IDisposable DCBNGOHFBCA<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x344FDD0", Offset = "0x344E3D0", VA = "0x18344FDD0")]
	[ABGINMJPEGK]
	public static IDisposable JPPFNBPHIAK<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x344FCB0", Offset = "0x344E2B0", VA = "0x18344FCB0")]
	[ABGINMJPEGK]
	public static IDisposable HANMACNNPKE<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DNEEKLJPKCF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FDLEAKCAINA : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public OIMEBHOMAGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NGDGKLPMIKI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public FDLEAKCAINA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F55680", Offset = "0x7F53C80", VA = "0x187F55680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F55760", Offset = "0x7F53D60", VA = "0x187F55760", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class HMIPAJCBBMO : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public OIMEBHOMAGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private NGDGKLPMIKI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public HMIPAJCBBMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F58EC0", Offset = "0x7F574C0", VA = "0x187F58EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F58FB0", Offset = "0x7F575B0", VA = "0x187F58FB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F52A90", Offset = "0x7F51090", VA = "0x187F52A90")]
	public static HPLGDNGCOKN KCPAEDHHGLD(Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F52B10", Offset = "0x7F51110", VA = "0x187F52B10")]
	public static HPLGDNGCOKN KCPAEDHHGLD(Behaviour BPPCEJGCMKA, Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F52BA0", Offset = "0x7F511A0", VA = "0x187F52BA0")]
	public static HPLGDNGCOKN KCPAEDHHGLD(Behaviour BPPCEJGCMKA, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F52970", Offset = "0x7F50F70", VA = "0x187F52970")]
	[IteratorStateMachine(typeof(FDLEAKCAINA))]
	private static IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OIMEBHOMAGD CAPLBJNMICN, Action DMGPEODFGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F52A00", Offset = "0x7F51000", VA = "0x187F52A00")]
	[IteratorStateMachine(typeof(HMIPAJCBBMO))]
	private static IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OIMEBHOMAGD CAPLBJNMICN, Action<float> DMGPEODFGGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class NKJJKKFEALL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class NGGFCPBELIM : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public NKJJKKFEALL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public NGGFCPBELIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F65E90", Offset = "0x7F64490", VA = "0x187F65E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F65F20", Offset = "0x7F64520", VA = "0x187F65F20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly OIMEBHOMAGD LFGBMCCIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action ALCJFDMDFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool DENGCBIELFN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool INNLJOEIPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x956CE0", Offset = "0x9552E0", VA = "0x180956CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F66090", Offset = "0x7F64690", VA = "0x187F66090")]
	public NKJJKKFEALL(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F65F70", Offset = "0x7F64570", VA = "0x187F65F70")]
	[IteratorStateMachine(typeof(NGGFCPBELIM))]
	private IEnumerator<FBLKJCIOKGP> BEIOHCLMBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F65FF0", Offset = "0x7F645F0", VA = "0x187F65FF0", Slot = "4")]
	public void OnCompleted(Action KCPBOAEAJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public void PNMFNAONGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DCBMHLLFJBB
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F51490", Offset = "0x7F4FA90", VA = "0x187F51490")]
	public static NKJJKKFEALL CHPBIIJHJCK(this OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KJEHNFOIIJL
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HLDGCHKEPPB : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public NDNEHIAKGOE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public HLDGCHKEPPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F58BF0", Offset = "0x7F571F0", VA = "0x187F58BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F58C70", Offset = "0x7F57270", VA = "0x187F58C70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DE50", Offset = "0x7F5C450", VA = "0x187F5DE50")]
	public static HPLGDNGCOKN KCPAEDHHGLD(float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DF20", Offset = "0x7F5C520", VA = "0x187F5DF20")]
	public static HPLGDNGCOKN KCPAEDHHGLD(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DB40", Offset = "0x7F5C140", VA = "0x187F5DB40")]
	public static HPLGDNGCOKN EJOOMCFFIAB(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DCF0", Offset = "0x7F5C2F0", VA = "0x187F5DCF0")]
	public static HPLGDNGCOKN IIIABLLBFEN(BMCDILGALJB BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DC30", Offset = "0x7F5C230", VA = "0x187F5DC30")]
	private static IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OJJHKDPCLBJ KPAHHFHFDIA, float NCBKMBOOCHJ, OIMEBHOMAGD CAPLBJNMICN, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DFF0", Offset = "0x7F5C5F0", VA = "0x187F5DFF0")]
	private static IEnumerator<FBLKJCIOKGP> MIGLMBJAMNH(OJJHKDPCLBJ KPAHHFHFDIA, float NCBKMBOOCHJ, OIMEBHOMAGD CAPLBJNMICN, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DDC0", Offset = "0x7F5C3C0", VA = "0x187F5DDC0")]
	[IteratorStateMachine(typeof(HLDGCHKEPPB))]
	private static IEnumerator<FBLKJCIOKGP> JNJICDDOFCF(NDNEHIAKGOE HJMLDIIALEC, float NCBKMBOOCHJ, OIMEBHOMAGD CAPLBJNMICN, Action<float> DMGPEODFGGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class ELJBGMLGPND
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PCGKGCBFGNC : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OIMEBHOMAGD queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public PCGKGCBFGNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F670C0", Offset = "0x7F656C0", VA = "0x187F670C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F67180", Offset = "0x7F65780", VA = "0x187F67180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F54EF0", Offset = "0x7F534F0", VA = "0x187F54EF0")]
	[IteratorStateMachine(typeof(PCGKGCBFGNC))]
	private static IEnumerator<FBLKJCIOKGP> BCDDGGBJBIA(OIMEBHOMAGD LFGBMCCIBAB, Func<bool> CMPFGFPGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F54F80", Offset = "0x7F53580", VA = "0x187F54F80")]
	public static HPLGDNGCOKN MMAJGOLBEJM(this MonoBehaviour DCDHPNKMBKF, Func<bool> CMPFGFPGHEP, OIMEBHOMAGD LFGBMCCIBAB = OIMEBHOMAGD.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JAPMFJJOOOC
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class NMHJHPINDMN : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public OIMEBHOMAGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public NMHJHPINDMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F661A0", Offset = "0x7F647A0", VA = "0x187F661A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F66210", Offset = "0x7F64810", VA = "0x187F66210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class JFOAPDNHJOC<T> : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public OIMEBHOMAGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public JFOAPDNHJOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49C9560", Offset = "0x49C7B60", VA = "0x1849C9560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x49C9600", Offset = "0x49C7C00", VA = "0x1849C9600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class OPNFDMFKLMA : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public OIMEBHOMAGD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private FBLKJCIOKGP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public OPNFDMFKLMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F66DE0", Offset = "0x7F653E0", VA = "0x187F66DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7F66E70", Offset = "0x7F65470", VA = "0x187F66E70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BF60", Offset = "0x7F5A560", VA = "0x187F5BF60")]
	[IteratorStateMachine(typeof(NMHJHPINDMN))]
	private static IEnumerator<FBLKJCIOKGP> BEIOHCLMBCM(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x344D290", Offset = "0x344B890", VA = "0x18344D290")]
	[IteratorStateMachine(typeof(JFOAPDNHJOC<>))]
	private static IEnumerator<FBLKJCIOKGP> BEIOHCLMBCM<T>(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action<T> BPHLLBLGCAD, T ICONKPKJBGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C450", Offset = "0x7F5AA50", VA = "0x187F5C450")]
	[IteratorStateMachine(typeof(OPNFDMFKLMA))]
	private static IEnumerator<FBLKJCIOKGP> NMENBEOGBLF(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C680", Offset = "0x7F5AC80", VA = "0x187F5C680")]
	public static IDisposable PDMJHHKIHNK(this MonoBehaviour DCDHPNKMBKF, float HKPDGGGHFLH, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C800", Offset = "0x7F5AE00", VA = "0x187F5C800")]
	public static HPLGDNGCOKN PMANGDGIEFB(this MonoBehaviour DCDHPNKMBKF, float HKPDGGGHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C590", Offset = "0x7F5AB90", VA = "0x187F5C590")]
	public static HPLGDNGCOKN PDMJHHKIHNK(this MonoBehaviour DCDHPNKMBKF, float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BEC0", Offset = "0x7F5A4C0", VA = "0x187F5BEC0")]
	public static HPLGDNGCOKN ADDFLCPFPIA(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x344D240", Offset = "0x344B840", VA = "0x18344D240")]
	public static HPLGDNGCOKN ADDFLCPFPIA<T>(this MonoBehaviour DCDHPNKMBKF, Action<T> BPHLLBLGCAD, T ICONKPKJBGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C000", Offset = "0x7F5A600", VA = "0x187F5C000")]
	public static HPLGDNGCOKN BHJDOFGLAPB(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C270", Offset = "0x7F5A870", VA = "0x187F5C270")]
	public static HPLGDNGCOKN GLJLPJBPFAB(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C310", Offset = "0x7F5A910", VA = "0x187F5C310")]
	public static HPLGDNGCOKN IDMCHIANLBP(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C1D0", Offset = "0x7F5A7D0", VA = "0x187F5C1D0")]
	public static HPLGDNGCOKN FNBBPMMIMIN(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C760", Offset = "0x7F5AD60", VA = "0x187F5C760")]
	public static HPLGDNGCOKN PHMDPHBGNIH(MonoBehaviour DCDHPNKMBKF, OIMEBHOMAGD LFGBMCCIBAB, Action BPHLLBLGCAD, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x344D370", Offset = "0x344B970", VA = "0x18344D370")]
	public static HPLGDNGCOKN PHMDPHBGNIH<T>(MonoBehaviour DCDHPNKMBKF, OIMEBHOMAGD LFGBMCCIBAB, Action<T> BPHLLBLGCAD, T ICONKPKJBGN, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C140", Offset = "0x7F5A740", VA = "0x187F5C140")]
	public static HPLGDNGCOKN CCOEJEMPHIJ(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C3B0", Offset = "0x7F5A9B0", VA = "0x187F5C3B0")]
	public static HPLGDNGCOKN KIIPHAEOPCI(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C0A0", Offset = "0x7F5A6A0", VA = "0x187F5C0A0")]
	public static HPLGDNGCOKN BJOKEAKLFBP(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7F5C4F0", Offset = "0x7F5AAF0", VA = "0x187F5C4F0")]
	public static HPLGDNGCOKN OHHGFDHOLMI(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EDHBCAOBFFK : BKFMNGCFFLF, IEnumerable<BKFMNGCFFLF>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly List<BKFMNGCFFLF> DMDFIKONIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool CEDFNFFEHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action PGEFKCHPJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool CCOIFOPAKNP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JFDLIOKBCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F53CF0", Offset = "0x7F522F0", VA = "0x187F53CF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPGOBDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7F53B20", Offset = "0x7F52120", VA = "0x187F53B20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7F53A00", Offset = "0x7F52000", VA = "0x187F53A00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7F54150", Offset = "0x7F52750", VA = "0x187F54150")]
	public EDHBCAOBFFK([Optional] Action PGEFKCHPJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7F53BC0", Offset = "0x7F521C0", VA = "0x187F53BC0")]
	public void HBHDBABAKDP(BKFMNGCFFLF OCKDEKFOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7F538A0", Offset = "0x7F51EA0", VA = "0x187F538A0")]
	private void BDMNFFLIKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7F54140", Offset = "0x7F52740", VA = "0x187F54140", Slot = "7")]
	public bool MBJGFMMMDOI(bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7F53E30", Offset = "0x7F52430", VA = "0x187F53E30", Slot = "8")]
	public bool MBJGFMMMDOI(Action PJDAFKMDDCG, bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7F53AA0", Offset = "0x7F520A0", VA = "0x187F53AA0", Slot = "9")]
	public IEnumerator<BKFMNGCFFLF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7F53AA0", Offset = "0x7F520A0", VA = "0x187F53AA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class KDHBDNBAHOB : DFMMBKBAAJH
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FLFNAEKBCON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public KDHBDNBAHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FLFNAEKBCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7F52560", Offset = "0x7F50B60", VA = "0x187F52560")]
		internal void KJMCHLAFCKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class DGLCLGMHCBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public KDHBDNBAHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DGLCLGMHCBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F52560", Offset = "0x7F50B60", VA = "0x187F52560")]
		internal void GMHJNNFKAGP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float NOIMACGINNE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7F585C0", Offset = "0x7F56BC0", VA = "0x187F585C0")]
	public KDHBDNBAHOB(Behaviour BPPCEJGCMKA, float NOIMACGINNE, [Optional] Action PGEFKCHPJDA, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CF80", Offset = "0x7F5B580", VA = "0x187F5CF80", Slot = "9")]
	protected override bool IKKLPGHNHDJ(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5CE70", Offset = "0x7F5B470", VA = "0x187F5CE70", Slot = "10")]
	protected override bool AAJFCFEGHJP(Action PJDAFKMDDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BKFMNGCFFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JFDLIOKBCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OPGOBDDOBOF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBJGFMMMDOI(bool MHOOEDPKADD = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MBJGFMMMDOI(Action PJDAFKMDDCG, bool MHOOEDPKADD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class DFMMBKBAAJH : BKFMNGCFFLF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LBLOMMJIBCG : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public DFMMBKBAAJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public LBLOMMJIBCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F614B0", Offset = "0x7F5FAB0", VA = "0x187F614B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7F61580", Offset = "0x7F5FB80", VA = "0x187F61580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Behaviour BPPCEJGCMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Action PGEFKCHPJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private AEIHFJALFJE KDPDHFNGCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly MEFKNEOFFHC JGFDBKNDMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly OJJHKDPCLBJ KPAHHFHFDIA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JFDLIOKBCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x181B110", Offset = "0x1819710", VA = "0x18181B110", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPGOBDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7F52020", Offset = "0x7F50620", VA = "0x187F52020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7F51F00", Offset = "0x7F50500", VA = "0x187F51F00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7F52430", Offset = "0x7F50A30", VA = "0x187F52430")]
	protected DFMMBKBAAJH(Behaviour BPPCEJGCMKA, [Optional] Action PGEFKCHPJDA, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F523B0", Offset = "0x7F509B0", VA = "0x187F523B0", Slot = "7")]
	public bool MBJGFMMMDOI(bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F52350", Offset = "0x7F50950", VA = "0x187F52350", Slot = "8")]
	public bool MBJGFMMMDOI(Action PJDAFKMDDCG, bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool IKKLPGHNHDJ(Action PJDAFKMDDCG);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool AAJFCFEGHJP(Action PJDAFKMDDCG);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F52410", Offset = "0x7F50A10", VA = "0x187F52410")]
	protected void OOJODOMLJLJ(Action PJDAFKMDDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F520C0", Offset = "0x7F506C0", VA = "0x187F520C0")]
	protected HJOKANJAKGB ICBFBMKJLII(float LKDAAJDJIMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7F51FA0", Offset = "0x7F505A0", VA = "0x187F51FA0")]
	private void BPFKIPBICKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7F51E70", Offset = "0x7F50470", VA = "0x187F51E70")]
	[IteratorStateMachine(typeof(LBLOMMJIBCG))]
	private IEnumerator<FBLKJCIOKGP> AICHBDAIGME(float LKDAAJDJIMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7F52310", Offset = "0x7F50910", VA = "0x187F52310")]
	[CompilerGenerated]
	private void JAKJOCAEFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OFFHHMHBING : DFMMBKBAAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly float KALFDENKDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int MIKPOALDBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float MCJJAKLIGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly float[] PCFLJCKIBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int KJBDHCGDCEE;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7F664E0", Offset = "0x7F64AE0", VA = "0x187F664E0")]
	public OFFHHMHBING(Behaviour BPPCEJGCMKA, float EHJECKBKCJJ, int MIKPOALDBBN, [Optional] Action PGEFKCHPJDA, float MCJJAKLIGJG = 0f, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "9")]
	protected override bool IKKLPGHNHDJ(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7F66260", Offset = "0x7F64860", VA = "0x187F66260", Slot = "10")]
	protected override bool AAJFCFEGHJP(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7F66460", Offset = "0x7F64A60", VA = "0x187F66460")]
	private void NKGPJBIANCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HADPEHNHANA : DFMMBKBAAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float NOIMACGINNE;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7F585C0", Offset = "0x7F56BC0", VA = "0x187F585C0")]
	public HADPEHNHANA(Behaviour BPPCEJGCMKA, float NOIMACGINNE, [Optional] Action PGEFKCHPJDA, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "9")]
	protected override bool IKKLPGHNHDJ(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7F58580", Offset = "0x7F56B80", VA = "0x187F58580", Slot = "10")]
	protected override bool AAJFCFEGHJP(Action PJDAFKMDDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class HNOIAFBJDLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AJILLINEGIB : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public AJILLINEGIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B7C0", Offset = "0x7F49DC0", VA = "0x187F4B7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B830", Offset = "0x7F49E30", VA = "0x187F4B830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private HPLGDNGCOKN ECCAPDIEPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private BMCDILGALJB BPPCEJGCMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Action<float> HILALHBBJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private OIMEBHOMAGD LFGBMCCIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private float KGLNFBKGDEI;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7F59500", Offset = "0x7F57B00", VA = "0x187F59500")]
	public HNOIAFBJDLO(BMCDILGALJB BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7F59310", Offset = "0x7F57910", VA = "0x187F59310")]
	private void MPOENKLOAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F591E0", Offset = "0x7F577E0", VA = "0x187F591E0")]
	private void LJBLIPKDFML(string IFMHONGNKHP, Action EDFNLKFMHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7F59480", Offset = "0x7F57A80", VA = "0x187F59480")]
	[IteratorStateMachine(typeof(AJILLINEGIB))]
	private IEnumerator<FBLKJCIOKGP> OHNLBGOGKCO(Action EDFNLKFMHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F59180", Offset = "0x7F57780", VA = "0x187F59180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7F59000", Offset = "0x7F57600", VA = "0x187F59000")]
	[CompilerGenerated]
	private void CFLMGDFBBLF(string JNJDMGFBFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class MOHFKOCOJAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MEFMLNBMLAH : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public MEFMLNBMLAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B7C0", Offset = "0x7F49DC0", VA = "0x187F4B7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7F64010", Offset = "0x7F62610", VA = "0x187F64010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private HPLGDNGCOKN ECCAPDIEPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private MonoBehaviour DCDHPNKMBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Action DMGPEODFGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private Action<float> HILALHBBJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private OIMEBHOMAGD LFGBMCCIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float KGLNFBKGDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private bool NGLJKGBDGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly MEFKNEOFFHC JGFDBKNDMLP;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7F65730", Offset = "0x7F63D30", VA = "0x187F65730")]
	public MOHFKOCOJAP(MonoBehaviour DCDHPNKMBKF, Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7F658C0", Offset = "0x7F63EC0", VA = "0x187F658C0")]
	public MOHFKOCOJAP(MonoBehaviour DCDHPNKMBKF, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7F65550", Offset = "0x7F63B50", VA = "0x187F65550")]
	public MOHFKOCOJAP(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x46E82D0", Offset = "0x46E68D0", VA = "0x1846E82D0")]
	private MOHFKOCOJAP(MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7F65320", Offset = "0x7F63920", VA = "0x187F65320")]
	internal static MOHFKOCOJAP PLANJDOLGKM(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7F64DB0", Offset = "0x7F633B0", VA = "0x187F64DB0")]
	private void KCPAEDHHGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7F64C30", Offset = "0x7F63230", VA = "0x187F64C30")]
	private void HGLFMCDJLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7F65130", Offset = "0x7F63730", VA = "0x187F65130")]
	private void MPOENKLOAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7F649B0", Offset = "0x7F62FB0", VA = "0x187F649B0")]
	private void CLGIJIKLOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7F64EE0", Offset = "0x7F634E0", VA = "0x187F64EE0")]
	private void LJBLIPKDFML(string IFMHONGNKHP, Action EDFNLKFMHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7F652A0", Offset = "0x7F638A0", VA = "0x187F652A0")]
	[IteratorStateMachine(typeof(MEFMLNBMLAH))]
	private IEnumerator<FBLKJCIOKGP> OHNLBGOGKCO(Action EDFNLKFMHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7F64B40", Offset = "0x7F63140", VA = "0x187F64B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7F65010", Offset = "0x7F63610", VA = "0x187F65010")]
	[CompilerGenerated]
	private void LKBMCDGCCGF(string JNJDMGFBFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7F64920", Offset = "0x7F62F20", VA = "0x187F64920")]
	[CompilerGenerated]
	private void AHCIOENIJKN(string JNJDMGFBFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7F64BA0", Offset = "0x7F631A0", VA = "0x187F64BA0")]
	[CompilerGenerated]
	private void GMCEGGBIBEN(string JNJDMGFBFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7F650A0", Offset = "0x7F636A0", VA = "0x187F650A0")]
	[CompilerGenerated]
	private void MNPPHNNHDDH(string JNJDMGFBFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum BCINMLKFIDL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal sealed class PMJKOABFPEP : OJJHKDPCLBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float CAPILIHKBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7F67250", Offset = "0x7F65850", VA = "0x187F67250", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float GMPPNNBLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F671D0", Offset = "0x7F657D0", VA = "0x187F671D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double OOGBABHPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7F67260", Offset = "0x7F65860", VA = "0x187F67260", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7F671E0", Offset = "0x7F657E0", VA = "0x187F671E0")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	[UnityEngine.Scripting.Preserve]
	internal PMJKOABFPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface LMEMKNHCAAM
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EONCCLLIMBE(string OMOOEGOLALI);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JGOKHHJEPCO();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface EAJGHEFBJLI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool PKFLGBGJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NDMNAAJJLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class AFELDIKGJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public KLKJLMDLKCG MFJNLMJALAJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MPMCCDHNNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B4F0", Offset = "0x7F49AF0", VA = "0x187F4B4F0")]
	public static FBLKJCIOKGP HPPBJLPLLBF(IEnumerator<FBLKJCIOKGP> MAKLGEBLGAC, KMACFHMAHPJ ACMOBPAMBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B430", Offset = "0x7F49A30", VA = "0x187F4B430")]
	public FBLKJCIOKGP HPPBJLPLLBF(KMACFHMAHPJ[] PMHCNAFCBHL, IEnumerator<FBLKJCIOKGP>[] DEHPICHPDFO, FBLKJCIOKGP[] APAJOEBFNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B2C0", Offset = "0x7F498C0", VA = "0x187F4B2C0")]
	public void BJDDBJDFPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B2F0", Offset = "0x7F498F0", VA = "0x187F4B2F0")]
	public void BBIEFDJMMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B650", Offset = "0x7F49C50", VA = "0x187F4B650")]
	public void IAHAOEEBCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B2C0", Offset = "0x7F498C0", VA = "0x187F4B2C0")]
	public void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public AFELDIKGJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class KLKJLMDLKCG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DMENFHCGHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AFELDIKGJIM AMKNOKMLFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public BMCDILGALJB KKKLHABLMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public KMACFHMAHPJ CNOMNJHBKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public IEnumerator<FBLKJCIOKGP> BOPBHIJALIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FBLKJCIOKGP GGHFAFHCHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public BCINMLKFIDL EOFMOPFIIKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct ODIOFLJLKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public OIMEBHOMAGD JIIJIHIADFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<DMENFHCGHKM> MEBHDJALBKG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DFDPCLDGNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public KMACFHMAHPJ promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public KLKJLMDLKCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public BMCDILGALJB context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AFELDIKGJIM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BCINMLKFIDL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public FBLKJCIOKGP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public IEnumerator<FBLKJCIOKGP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public DFDPCLDGNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7F515A0", Offset = "0x7F4FBA0", VA = "0x187F515A0")]
		internal void DKKIPLPBKEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NKKNPAJFKCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AFELDIKGJIM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public KLKJLMDLKCG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public NKKNPAJFKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7F66160", Offset = "0x7F64760", VA = "0x187F66160")]
		internal void LHNJIOIOLDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FMABEEFPDGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AFELDIKGJIM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public KLKJLMDLKCG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FMABEEFPDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7F557B0", Offset = "0x7F53DB0", VA = "0x187F557B0")]
		internal void BKMGKOCBFCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class HFKLNDOOKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AFELDIKGJIM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public KLKJLMDLKCG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HFKLNDOOKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F58890", Offset = "0x7F56E90", VA = "0x187F58890")]
		internal void OJKFHGMMLPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private const BCINMLKFIDL FJABKGCMKLP = BCINMLKFIDL.Cancelled | BCINMLKFIDL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly OIMEBHOMAGD LFGBMCCIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool[] MFMICDNBMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private NativeArray<BCINMLKFIDL> LHMJGJHLHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeArray<float> PEJLCFAHENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> KNIHBGPIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<int> BKLPEHBEHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> JILGMLOCPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> GMHAHFOFEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> DKLBNPCLAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private AFELDIKGJIM[] DDJFNFEGOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private KMACFHMAHPJ[] PMHCNAFCBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private BMCDILGALJB[] IECBIBCKDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private IEnumerator<FBLKJCIOKGP>[] PPPLKKCKALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private FBLKJCIOKGP[] NMJPDEFJFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CBBKKJIEIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int CCAKDDNOMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int ALOJAOINMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float FOPBAINKBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private CKAAJCLBPIB KNACDNLOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private JobHandle DBBHAJHJBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<AFELDIKGJIM> ECIBMAJFICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool OHFGECNAGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<Action> KOMKHODMJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<Action> CAALGAPDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool LGCEODGIMMC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ODIOFLJLKEB[] FBLJHHEMIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA2D0F0", Offset = "0xA2B6F0", VA = "0x180A2D0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7F60230", Offset = "0x7F5E830", VA = "0x187F60230")]
	private static int OCJBPLKJKGO(OIMEBHOMAGD LFGBMCCIBAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7F603E0", Offset = "0x7F5E9E0", VA = "0x187F603E0")]
	public KLKJLMDLKCG(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F930", Offset = "0x7F5DF30", VA = "0x187F5F930")]
	private void MPBFGJPIAIH(int CANKPOFEILP, int FAEMGGEHCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7F60260", Offset = "0x7F5E860", VA = "0x187F60260")]
	public void OLBFPKKJHMO(BMCDILGALJB BPPCEJGCMKA, FBLKJCIOKGP LNOOJGMBJHA, IEnumerator<FBLKJCIOKGP> MAKLGEBLGAC, KMACFHMAHPJ ACMOBPAMBFB, [Optional] AFELDIKGJIM LJJHGMMHHMO, BCINMLKFIDL HCGLIPCDIAC = BCINMLKFIDL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F4F0", Offset = "0x7F5DAF0", VA = "0x187F5F4F0")]
	public void KLHNJBNJIGK(IEnumerable<DMENFHCGHKM> AGNNKOOCECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EA20", Offset = "0x7F5D020", VA = "0x187F5EA20")]
	private DMENFHCGHKM KBFJFFJMMIO(int OPBLCEPHDHO)
	{
		return default(DMENFHCGHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E350", Offset = "0x7F5C950", VA = "0x187F5E350")]
	private void FLGJJACAOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x34B7BA0", Offset = "0x34B61A0", VA = "0x1834B7BA0")]
	private static void NIAFPKHNLGD<T>(int OPBLCEPHDHO, T[] DDOOOEHLJBB, int IBMHAIHIDJJ, [Optional] T FLCNPNJNIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x34B7BF0", Offset = "0x34B61F0", VA = "0x1834B7BF0")]
	private static void NIAFPKHNLGD<T>(int OPBLCEPHDHO, NativeArray<T> DDOOOEHLJBB, int IBMHAIHIDJJ, [Optional] T FLCNPNJNIDC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F150", Offset = "0x7F5D750", VA = "0x187F5F150")]
	private void KIDCFCNOBGI(IEnumerable<DMENFHCGHKM> AGNNKOOCECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E200", Offset = "0x7F5C800", VA = "0x187F5E200")]
	private void BCGLIPAPOJH(DMENFHCGHKM CKCEFDBDABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E7C0", Offset = "0x7F5CDC0", VA = "0x187F5E7C0")]
	private DFBDLHJMHCL IGHNMCNNDJN(int MBJPNHOHEJM)
	{
		return default(DFBDLHJMHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F730", Offset = "0x7F5DD30", VA = "0x187F5F730")]
	public void MCEFMMAHEGG(float LOJMONJPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E180", Offset = "0x7F5C780", VA = "0x187F5E180")]
	private void BAKHLPBLPBI(Action AMGCKABOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E2D0", Offset = "0x7F5C8D0", VA = "0x187F5E2D0")]
	private void DKDGICCJPMK(Action AMGCKABOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7F5FB10", Offset = "0x7F5E110", VA = "0x187F5FB10")]
	public void NNPIKPLLCGA(float LOJMONJPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E6C0", Offset = "0x7F5CCC0", VA = "0x187F5E6C0")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7F5E050", Offset = "0x7F5C650", VA = "0x187F5E050")]
	public void APDCJKMBNFA(AFELDIKGJIM HJMLDIIALEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7F5EEF0", Offset = "0x7F5D4F0", VA = "0x187F5EEF0")]
	public void KBHMPLKPKMH(AFELDIKGJIM HJMLDIIALEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7F5F020", Offset = "0x7F5D620", VA = "0x187F5F020")]
	public void KCAOLOFCNNB(AFELDIKGJIM HJMLDIIALEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GJCFLAKCACI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public static readonly GJCFLAKCACI DGEEMDAPOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly Action BKAIFAJPEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public GJCFLAKCACI(Action BKAIFAJPEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x761A000", Offset = "0x7618600", VA = "0x18761A000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface MFHOOENAFBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JOAIAECFCEH(UnityEngine.Object BPPCEJGCMKA, Action<T> LFIJDBJEFBD);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface JEJMCHKMOLF<T> : MFHOOENAFBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	new T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class HEBGOBDHHPO<T> : JEJMCHKMOLF<T>, MFHOOENAFBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class FMLCOHEMFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public HEBGOBDHHPO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public CANEJCIOAKL<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FMLCOHEMFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4436B00", Offset = "0x4435100", VA = "0x184436B00")]
		internal void MBANDGNFECM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static GameObject ICLIMBKBIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<CANEJCIOAKL<UnityEngine.Object, Action<T>>> GKLPJBAMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private T LBFGIHNCMOP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4629840", Offset = "0x4627E40", VA = "0x184629840", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4629C40", Offset = "0x4628240", VA = "0x184629C40")]
	private static bool JPLLIPAIDFP(T AMGCKABOOPF, T PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x462A3B0", Offset = "0x46289B0", VA = "0x18462A3B0")]
	public HEBGOBDHHPO(T OLAFDLKMDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4629A90", Offset = "0x4628090", VA = "0x184629A90", Slot = "6")]
	public IDisposable JOAIAECFCEH(UnityEngine.Object BPPCEJGCMKA, Action<T> LFIJDBJEFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x462A070", Offset = "0x4628670", VA = "0x18462A070")]
	private void KIDPKJOANND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class FPCEGEOKNGA : LHJPLLHHNOK
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private class MHKGKKIKBBB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		private class AIJDHNDLNBH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private int KGHCKLKGJKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private MHKGKKIKBBB CAPLBJNMICN;

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD56B70", Offset = "0xD55170", VA = "0x180D56B70")]
			public AIJDHNDLNBH(int KGHCKLKGJKM, MHKGKKIKBBB CAPLBJNMICN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F4B790", Offset = "0x7F49D90", VA = "0x187F4B790", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class PKAMMKJNBPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public PKAMMKJNBPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xC53F60", Offset = "0xC52560", VA = "0x180C53F60")]
			internal bool BLCNIMHKKJK(CNEDHKBAAAA e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class IKHNEEFDFFL : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public MHKGKKIKBBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public OJJHKDPCLBJ timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private NGDGKLPMIKI <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private List<CNEDHKBAAAA> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CD")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public IKHNEEFDFFL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x7F5A200", Offset = "0x7F58800", VA = "0x187F5A200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7F5A530", Offset = "0x7F58B30", VA = "0x187F5A530", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly OIMEBHOMAGD LFGBMCCIBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private HPLGDNGCOKN ACMOBPAMBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly List<CNEDHKBAAAA> ONOIJFJJLNH;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F64880", Offset = "0x7F62E80", VA = "0x187F64880")]
		public MHKGKKIKBBB(OIMEBHOMAGD LFGBMCCIBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F64480", Offset = "0x7F62A80", VA = "0x187F64480")]
		public IDisposable BIMBOEFGFOH(CNEDHKBAAAA BGNGLILFNLL, MEFKNEOFFHC JGFDBKNDMLP, OJJHKDPCLBJ ACNLNBKGHCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F646F0", Offset = "0x7F62CF0", VA = "0x187F646F0")]
		private void GMOJJPALAKG(int KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F64660", Offset = "0x7F62C60", VA = "0x187F64660")]
		[IteratorStateMachine(typeof(IKHNEEFDFFL))]
		private IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OJJHKDPCLBJ ACNLNBKGHCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F64610", Offset = "0x7F62C10", VA = "0x187F64610", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private class CNEDHKBAAAA
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public enum HGIBMJOBAKP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x4000169")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static int CJNICCHJNNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public readonly int AOALABMLPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public readonly NFEDKEMNHKL KKKLHABLMLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly MonoBehaviour DPKOCFBIJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public readonly Action PLJNMJIHBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public readonly Action<float> IFMEOIIKHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public readonly float GKGCGPKKCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float PEJLCFAHENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public readonly string OPDMIMOEGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public readonly bool CJCJJEPGCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public readonly HGIBMJOBAKP KDMEPNEKFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool FPNOGNNJFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool KLBNJAIGHJG;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CFA0", Offset = "0x7F4B5A0", VA = "0x187F4CFA0")]
		public CNEDHKBAAAA(NFEDKEMNHKL BPPCEJGCMKA, Action DMGPEODFGGC, bool BNEMCMHGEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CE20", Offset = "0x7F4B420", VA = "0x187F4CE20")]
		public CNEDHKBAAAA(NFEDKEMNHKL BPPCEJGCMKA, Action<float> DMGPEODFGGC, bool BNEMCMHGEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CC40", Offset = "0x7F4B240", VA = "0x187F4CC40")]
		public CNEDHKBAAAA(NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OJJHKDPCLBJ ACNLNBKGHCE, HGIBMJOBAKP LIAGJJDNDHN, bool NGLJKGBDGKD, bool BNEMCMHGEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CA70", Offset = "0x7F4B070", VA = "0x187F4CA70")]
		public bool IAOGLOKLKGP(float KGDKBIOOEOP, float GJIDBFHGEOE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly MEFKNEOFFHC JGFDBKNDMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly OJJHKDPCLBJ KPAHHFHFDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<OIMEBHOMAGD, MHKGKKIKBBB> OMFLPIHGILC;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F56E10", Offset = "0x7F55410", VA = "0x187F56E10")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void JKJPFNEPFPA(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F577A0", Offset = "0x7F55DA0", VA = "0x187F577A0")]
	[UnityEngine.Scripting.Preserve]
	internal FPCEGEOKNGA([IBJCGEMJMJL(null)] MEFKNEOFFHC JGFDBKNDMLP, [IBJCGEMJMJL(null)] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F573C0", Offset = "0x7F559C0", VA = "0x187F573C0", Slot = "4")]
	public IDisposable PLJNMJIHBJD(NFEDKEMNHKL BPPCEJGCMKA, Action IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F575B0", Offset = "0x7F55BB0", VA = "0x187F575B0", Slot = "5")]
	public IDisposable PLJNMJIHBJD(NFEDKEMNHKL BPPCEJGCMKA, Action<float> IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F57040", Offset = "0x7F55640", VA = "0x187F57040", Slot = "7")]
	public IDisposable LAENHLKEEKN(NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F572C0", Offset = "0x7F558C0", VA = "0x187F572C0", Slot = "8")]
	public IDisposable LPCAAPHEEOJ(NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F57140", Offset = "0x7F55740", VA = "0x187F57140", Slot = "6")]
	public IDisposable LAENHLKEEKN(float NCBKMBOOCHJ, Action<float> IJCKFHFIADK, bool NGLJKGBDGKD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F56E80", Offset = "0x7F55480", VA = "0x187F56E80", Slot = "9")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F56CD0", Offset = "0x7F552D0", VA = "0x187F56CD0")]
	private MHKGKKIKBBB FJJCNBHJGKL(OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class EKKELDDHIIG : ILLHNBLILPD, MEFKNEOFFHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private KLKJLMDLKCG[] HCMBEMCGMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private LMEMKNHCAAM EOCPFDKBEBG;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F54700", Offset = "0x7F52D00", VA = "0x187F54700")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7F54E30", Offset = "0x7F53430", VA = "0x187F54E30")]
	[UnityEngine.Scripting.Preserve]
	public EKKELDDHIIG([IBJCGEMJMJL(null)] BOPONHNNBBC LJBFIDFJMHN, [IBJCGEMJMJL(null)] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F544B0", Offset = "0x7F52AB0", VA = "0x187F544B0", Slot = "19")]
	public override HPLGDNGCOKN BHLOMFMEOCO(BMCDILGALJB BPPCEJGCMKA, IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F549A0", Offset = "0x7F52FA0", VA = "0x187F549A0", Slot = "20")]
	public override void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F54770", Offset = "0x7F52D70", VA = "0x187F54770", Slot = "22")]
	public override void JHGDNMNAOAI(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F54D60", Offset = "0x7F53360", VA = "0x187F54D60", Slot = "21")]
	protected override void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F54250", Offset = "0x7F52850", VA = "0x187F54250")]
	private KLKJLMDLKCG AALINBPJDNP(OIMEBHOMAGD BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F54280", Offset = "0x7F52880", VA = "0x187F54280", Slot = "23")]
	internal override KHDNFFJAFBP ALOHLCDIMJN(IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP, Behaviour BPPCEJGCMKA, KMACFHMAHPJ ACMOBPAMBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F545E0", Offset = "0x7F52BE0", VA = "0x187F545E0", Slot = "24")]
	internal override MDNGIPCNPCF DPPPLCKBOAA(OIMEBHOMAGD CAPLBJNMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F54C40", Offset = "0x7F53240", VA = "0x187F54C40")]
	private void OMAPBMKPLLO(KLKJLMDLKCG IHNPLIMPGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F546A0", Offset = "0x7F52CA0", VA = "0x187F546A0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[BurstCompile]
internal struct CKAAJCLBPIB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ReadOnly]
	public float BGFEMNIAACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ReadOnly]
	public int ILDBDHNPHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<int> EPLKJIAFONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> KDOEPKPKNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<int> OLEEEGNDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ReadOnly]
	public NativeArray<BCINMLKFIDL> CMHBDGJIFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	public NativeArray<float> HAFHFAPBDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[WriteOnly]
	public NativeArray<int> JILGMLOCPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[WriteOnly]
	public NativeArray<int> KNIHBGPIPGP;

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CA10", Offset = "0x7F4B010", VA = "0x187F4CA10")]
	public static CKAAJCLBPIB OILMBKHFGKP(int JBLPJKGNDGH, float LOJMONJPLCB, NativeArray<BCINMLKFIDL> HFAHDDHJBIH, NativeArray<float> ELDOKBIJINA, NativeArray<int> MKGBNGEABJA, NativeArray<int> FIJIJODJOPF, NativeArray<int> ENLMLFOJNAF, NativeArray<int> KDOEPKPKNDC, NativeArray<int> OLEEEGNDNCL)
	{
		return default(CKAAJCLBPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C8C0", Offset = "0x7F4AEC0", VA = "0x187F4C8C0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C9A0", Offset = "0x7F4AFA0", VA = "0x187F4C9A0")]
	private bool FENEBKIIIJH(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C9E0", Offset = "0x7F4AFE0", VA = "0x187F4C9E0")]
	private void FLAOHBOLGNH(NativeArray<int> IPJLMGNKKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C750", Offset = "0x7F4AD50", VA = "0x187F4C750")]
	private int CEEJFNNFCHD(int DOEDICBKPCK, int JAEOJHGOKIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C7F0", Offset = "0x7F4ADF0", VA = "0x187F4C7F0")]
	private void EJHNHLBOOFA(NativeArray<int> IPJLMGNKKAH, int BJBDCKOMDKP, int FBIKENCMLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C510", Offset = "0x7F4AB10", VA = "0x187F4C510")]
	private void CDMKEANEMGO(NativeArray<int> IPJLMGNKKAH, int FIKGNFONKKP, int APJBGIEPICH, int DKINKMBKNGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public abstract class ILLHNBLILPD : MEFKNEOFFHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly BOPONHNNBBC LJBFIDFJMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	protected readonly OJJHKDPCLBJ KPAHHFHFDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private MDNGIPCNPCF[] DJEHKFBNPKI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public static MEFKNEOFFHC IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F5B140", Offset = "0x7F59740", VA = "0x187F5B140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OIMEBHOMAGD BONMBLGKHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OIMEBHOMAGD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public OJJHKDPCLBJ FDLLKFHNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public FBLKJCIOKGP OHCMDFBNIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FBLKJCIOKGP HOFOAABMHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FBLKJCIOKGP LGHHCGIINOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FBLKJCIOKGP ALAOBAALCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AD40", Offset = "0x7F59340", VA = "0x187F5AD40")]
	public static HPLGDNGCOKN JPKKDKGNDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B4E0", Offset = "0x7F59AE0", VA = "0x187F5B4E0")]
	[UnityEngine.Scripting.Preserve]
	protected ILLHNBLILPD([IBJCGEMJMJL(null)] BOPONHNNBBC LJBFIDFJMHN, [IBJCGEMJMJL(null)] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AAA0", Offset = "0x7F590A0", VA = "0x187F5AAA0", Slot = "6")]
	public HPLGDNGCOKN IKIFLPOJPIB(IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AAB0", Offset = "0x7F590B0", VA = "0x187F5AAB0", Slot = "7")]
	public HPLGDNGCOKN IKIFLPOJPIB(Behaviour BPPCEJGCMKA, IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract HPLGDNGCOKN BHLOMFMEOCO(BMCDILGALJB BPPCEJGCMKA, IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ADD0", Offset = "0x7F593D0", VA = "0x187F5ADD0", Slot = "20")]
	public virtual void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B1F0", Offset = "0x7F597F0", VA = "0x187F5B1F0", Slot = "9")]
	public void PINHAAOCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B430", Offset = "0x7F59A30", VA = "0x187F5B430", Slot = "21")]
	protected virtual void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AA00", Offset = "0x7F59000", VA = "0x187F5AA00")]
	private void GAFIFHHFHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A9E0", Offset = "0x7F58FE0", VA = "0x187F5A9E0")]
	private void FKHDPHOIEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A580", Offset = "0x7F58B80", VA = "0x187F5A580")]
	private void ALLDOJBMADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B1D0", Offset = "0x7F597D0", VA = "0x187F5B1D0")]
	private void NIFCHODJFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AA20", Offset = "0x7F59020", VA = "0x187F5AA20")]
	private void HGBKDLPEPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A600", Offset = "0x7F58C00", VA = "0x187F5A600")]
	private void DIBGHNPIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B1B0", Offset = "0x7F597B0", VA = "0x187F5B1B0")]
	private void MGAENHCEGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ACB0", Offset = "0x7F592B0", VA = "0x187F5ACB0", Slot = "22")]
	public virtual void JHGDNMNAOAI(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AF70", Offset = "0x7F59570", VA = "0x187F5AF70")]
	private void LCKFGMPJKPP(MDNGIPCNPCF IHNPLIMPGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2485630", Offset = "0x2483C30", VA = "0x182485630")]
	private MDNGIPCNPCF DFEDJFFNJFH(OIMEBHOMAGD BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract KHDNFFJAFBP ALOHLCDIMJN(IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP, Behaviour DCDHPNKMBKF, KMACFHMAHPJ LBIIDPMGCFP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract MDNGIPCNPCF DPPPLCKBOAA(OIMEBHOMAGD LFGBMCCIBAB);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A620", Offset = "0x7F58C20", VA = "0x187F5A620", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7F5AA40", Offset = "0x7F59040", VA = "0x187F5AA40", Slot = "15")]
	public FBLKJCIOKGP IDCFHOJNOID(OIMEBHOMAGD CAPLBJNMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7F5B450", Offset = "0x7F59A50", VA = "0x187F5B450", Slot = "16")]
	public FBLKJCIOKGP PNOPMCKDNGJ(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A5A0", Offset = "0x7F58BA0", VA = "0x187F5A5A0", Slot = "17")]
	public FBLKJCIOKGP DBFDANEECPK(Func<bool> CMPFGFPGHEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal sealed class KHDNFFJAFBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly KMACFHMAHPJ ACMOBPAMBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EAJGHEFBJLI BPPCEJGCMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly bool LOLBOHLMIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private string OMOOEGOLALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private StackTrace HCMCKPOLBNP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<FBLKJCIOKGP> BOPBHIJALIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FBLKJCIOKGP GGHFAFHCHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CLBGPOJDHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D290", Offset = "0x7F5B890", VA = "0x187F5D290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool IOFEOAIMEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE920", Offset = "0xAACF20", VA = "0x180AAE920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAE45B0", Offset = "0xAE2BB0", VA = "0x180AE45B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D680", Offset = "0x7F5BC80", VA = "0x187F5D680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HDOFLJBLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xEA5EE0", Offset = "0xEA44E0", VA = "0x180EA5EE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x697C4F0", Offset = "0x697AAF0", VA = "0x18697C4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D980", Offset = "0x7F5BF80", VA = "0x187F5D980")]
	public KHDNFFJAFBP(IEnumerator<FBLKJCIOKGP> MAKLGEBLGAC, EAJGHEFBJLI BPPCEJGCMKA, KMACFHMAHPJ ACMOBPAMBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D360", Offset = "0x7F5B960", VA = "0x187F5D360")]
	public FBLKJCIOKGP HPPBJLPLLBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D830", Offset = "0x7F5BE30", VA = "0x187F5D830")]
	public bool MJHGICNIGEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D310", Offset = "0x7F5B910", VA = "0x187F5D310")]
	public void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7F5D8A0", Offset = "0x7F5BEA0", VA = "0x187F5D8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xB4B790", Offset = "0xB49D90", VA = "0x180B4B790")]
	[CompilerGenerated]
	private void GNHCILBGHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal sealed class KMACFHMAHPJ : CLHPMPABOAJ, HPLGDNGCOKN, AEIHFJALFJE, HJOKANJAKGB, IEnumerator, FBLKJCIOKGP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private OIMEBHOMAGD DGPNFDDCDJM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private OIMEBHOMAGD DECAAHLLOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xC07450", Offset = "0xC05A50", VA = "0x180C07450", Slot = "23")]
		get
		{
			return default(OIMEBHOMAGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OIMEBHOMAGD MFJNLMJALAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD7FA60", Offset = "0xD7E060", VA = "0x180D7FA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float HLLIIJAIMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA77FC0", Offset = "0xA765C0", VA = "0x180A77FC0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BPHBNBPPCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7F60A40", Offset = "0x7F5F040", VA = "0x187F60A40", Slot = "24")]
	private bool BAKAGOGOLML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7F60A60", Offset = "0x7F5F060", VA = "0x187F60A60", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7F60A70", Offset = "0x7F5F070", VA = "0x187F60A70")]
	public KMACFHMAHPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal enum DFBDLHJMHCL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal sealed class MDNGIPCNPCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum GODHNMNFHNL
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct GDHPLDEDEOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OIMEBHOMAGD JIIJIHIADFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public GODHNMNFHNL LIMLBNOEDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public List<KHDNFFJAFBP> MPBINALOGEG;
	}

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly GODHNMNFHNL[] BEFDPPIDBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly OIMEBHOMAGD LFGBMCCIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool BMDKIOLGJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly KHDNFFJAFBP[] JINIGHNHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly List<KHDNFFJAFBP> JAIDLNJBHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly Stack<int> KHBONHKNDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly List<KHDNFFJAFBP> CBOKIIEHOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Stack<int> LCOFIKFBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LMEMKNHCAAM GKAIIIDNJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private bool LGCEODGIMMC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GDHPLDEDEOH[,] GFALOIGLOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7F63B60", Offset = "0x7F62160", VA = "0x187F63B60")]
	public MDNGIPCNPCF(OIMEBHOMAGD CAPLBJNMICN, LMEMKNHCAAM GKAIIIDNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7F62B50", Offset = "0x7F61150", VA = "0x187F62B50")]
	public void GEFAIJPPHEF(KHDNFFJAFBP MAKLGEBLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7F62710", Offset = "0x7F60D10", VA = "0x187F62710")]
	public void FBBLBAJKAFO(IList<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7F62C60", Offset = "0x7F61260", VA = "0x187F62C60")]
	public void JFACHAFOHAN(IList<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7F630F0", Offset = "0x7F616F0", VA = "0x187F630F0")]
	private void NANKGEEKECL(KHDNFFJAFBP MAKLGEBLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7F62F60", Offset = "0x7F61560", VA = "0x187F62F60")]
	private void MLFMPOLLBBG(IList<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7F631E0", Offset = "0x7F617E0", VA = "0x187F631E0")]
	private DFBDLHJMHCL OCIJCOMBOKM(KHDNFFJAFBP MAKLGEBLGAC)
	{
		return default(DFBDLHJMHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7F638B0", Offset = "0x7F61EB0", VA = "0x187F638B0")]
	public void PLJNMJIHBJD(float LOJMONJPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7F636C0", Offset = "0x7F61CC0", VA = "0x187F636C0")]
	public void PINHAAOCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7F63360", Offset = "0x7F61960", VA = "0x187F63360")]
	private void PBJGADGIPKB(List<KHDNFFJAFBP> DEHPICHPDFO, Stack<int> ICCMDPLJLJA, bool CODNBMIJEAC, float BDDJEOEPKAH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7F625F0", Offset = "0x7F60BF0", VA = "0x187F625F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7F62A10", Offset = "0x7F61010", VA = "0x187F62A10")]
	private void FONBLPDDKIG(List<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class BKBAFKDCCHP : LMEMKNHCAAM
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	public void EONCCLLIMBE(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
	public void JGOKHHJEPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public BKBAFKDCCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class DFMJCBCALDF : EAJGHEFBJLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Behaviour DCDHPNKMBKF;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7F51DF0", Offset = "0x7F503F0", VA = "0x187F51DF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PKFLGBGJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7F51DA0", Offset = "0x7F503A0", VA = "0x187F51DA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool NDMNAAJJLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7F51D80", Offset = "0x7F50380", VA = "0x187F51D80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public DFMJCBCALDF(Behaviour DCDHPNKMBKF)
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

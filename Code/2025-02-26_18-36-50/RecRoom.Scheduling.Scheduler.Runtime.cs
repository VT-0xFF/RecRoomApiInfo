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
		[Cpp2IlInjected.Address(RVA = "0x7EBD020", Offset = "0x7EBC420", VA = "0x187EBD020", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC3D20", Offset = "0x7EC3120", VA = "0x187EC3D20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB08B0", Offset = "0x7EAFCB0", VA = "0x187EB08B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB88E0", Offset = "0x7EB7CE0", VA = "0x187EB88E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB4120", Offset = "0x7EB3520", VA = "0x187EB4120")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB7220", Offset = "0x7EB6620", VA = "0x187EB7220")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB84C0", Offset = "0x7EB78C0", VA = "0x187EB84C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EA7A70", Offset = "0x7EA6E70", VA = "0x187EA7A70")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EC2710", Offset = "0x7EC1B10", VA = "0x187EC2710")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EC14E0", Offset = "0x7EC08E0", VA = "0x187EC14E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB7510", Offset = "0x7EB6910", VA = "0x187EB7510")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBDC40", Offset = "0x7EBD040", VA = "0x187EBDC40")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EBCE20", Offset = "0x7EBC220", VA = "0x187EBCE20")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB4510", Offset = "0x7EB3910", VA = "0x187EB4510")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB82C0", Offset = "0x7EB76C0", VA = "0x187EB82C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EB5850", Offset = "0x7EB4C50", VA = "0x187EB5850")]
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
				[Cpp2IlInjected.Address(RVA = "0x7EC12E0", Offset = "0x7EC06E0", VA = "0x187EC12E0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
					public LAFGFDDDLCE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600005D")]
					[Cpp2IlInjected.Address(RVA = "0x7EBCC80", Offset = "0x7EBC080", VA = "0x187EBCC80")]
					internal void KMPPAFOCAPE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public static JKOOBLENGDB<DKDIHELMENL> ICGOBMKAMEM;

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x7EA70D0", Offset = "0x7EA64D0", VA = "0x187EA70D0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
					public MFADIAKPJDE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000060")]
					[Cpp2IlInjected.Address(RVA = "0x7EBF8B0", Offset = "0x7EBECB0", VA = "0x187EBF8B0")]
					internal void OMEEAIPPGLE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public static IDisposable NFLDEJBDFFD;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7EB5720", Offset = "0x7EB4B20", VA = "0x187EB5720")]
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
					[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
					public CFCJKMOPMNC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000066")]
					[Cpp2IlInjected.Address(RVA = "0x7EA77F0", Offset = "0x7EA6BF0", VA = "0x187EA77F0")]
					internal void OMEEAIPPGLE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7EA76C0", Offset = "0x7EA6AC0", VA = "0x187EA76C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public HHHFOPFLCJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7EB4320", Offset = "0x7EB3720", VA = "0x187EB4320")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EACAE0", Offset = "0x7EABEE0", VA = "0x187EACAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9A20", Offset = "0x7EA8E20", VA = "0x187EA9A20")]
		private static void LBGELLEOEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EA89B0", Offset = "0x7EA7DB0", VA = "0x187EA89B0")]
		private static void CDCGIDCAAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8970", Offset = "0x7EA7D70", VA = "0x187EA8970")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7EA97D0", Offset = "0x7EA8BD0", VA = "0x187EA97D0")]
		private static void JMHLGENMPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EACB20", Offset = "0x7EABF20", VA = "0x187EACB20")]
		private static void PDJPGCOCKPB(FBKDKHJNAMN.DCABFILEKBI LKMGECEEGEE, PlayerLoopSystem POIPCELIJJK, Type BODJOEANDHC, Type LKHNLDMCJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA92C0", Offset = "0x7EA86C0", VA = "0x187EA92C0")]
		private static void DHGEKOHKEEK(PlayerLoopSystem POIPCELIJJK, Type BODJOEANDHC, Type LKHNLDMCJCL, HMMHJOCGBLE CGDCIGCDDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA96A0", Offset = "0x7EA8AA0", VA = "0x187EA96A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EBFC40", Offset = "0x7EBF040", VA = "0x187EBFC40")]
		public MFAOOMEFEDA(DCABFILEKBI CFAAJCGEJPH, int PBLJGICNHAL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFB40", Offset = "0x7EBEF40", VA = "0x187EBFB40")]
		public void KCKGGOELEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFAF0", Offset = "0x7EBEEF0", VA = "0x187EBFAF0")]
		public void FFLGDCIPPMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFB60", Offset = "0x7EBEF60", VA = "0x187EBFB60")]
		public void KPKHDKCADDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static DCABFILEKBI[] ENGJAELAFNJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static MFAOOMEFEDA[] HEBBNOGEEIP;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0AB0", Offset = "0x7EAFEB0", VA = "0x187EB0AB0")]
	public static MFAOOMEFEDA BCBFCCNMOCH(DCABFILEKBI LKMGECEEGEE, int PBLJGICNHAL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0C10", Offset = "0x7EB0010", VA = "0x187EB0C10")]
	public static MFAOOMEFEDA EAMFDADDMNG(DCABFILEKBI LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0C80", Offset = "0x7EB0080", VA = "0x187EB0C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
		public ONOMHHCKBMG(Action PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xF4F410", Offset = "0xF4E810", VA = "0x180F4F410", Slot = "5")]
		public void HMABCBLNCNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<EIMNBAHJEKI> MPFGGKOIHCD;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5410", Offset = "0x7EB4810", VA = "0x187EB5410")]
	public static void GKIGLHKDACK(Action PJDAFKMDDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4EF0", Offset = "0x7EB42F0", VA = "0x187EB4EF0")]
	private static void AHIGDCCLNJA(EIMNBAHJEKI NGHMBJGMMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5110", Offset = "0x7EB4510", VA = "0x187EB5110")]
	private static void DFIFFIAGJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB54B0", Offset = "0x7EB48B0", VA = "0x187EB54B0")]
	private static void JCLIONFKCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB55B0", Offset = "0x7EB49B0", VA = "0x187EB55B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAFA40", Offset = "0x7EAEE40", VA = "0x187EAFA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB30B0", Offset = "0x7EB24B0", VA = "0x187EB30B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3950", Offset = "0x7EB2D50", VA = "0x187EB3950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EADDE0", Offset = "0x7EAD1E0", VA = "0x187EADDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE100", Offset = "0x7EAD500", VA = "0x187EAE100", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA72A0", Offset = "0x7EA66A0", VA = "0x187EA72A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7660", Offset = "0x7EA6A60", VA = "0x187EA7660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DMAPIFADMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE160", Offset = "0x7EAD560", VA = "0x187EAE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAE4D0", Offset = "0x7EAD8D0", VA = "0x187EAE4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF080", Offset = "0x7EAE480", VA = "0x187EAF080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC1F00", Offset = "0x7EC1300", VA = "0x187EC1F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC25C0", Offset = "0x7EC19C0", VA = "0x187EC25C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EBD0B0", Offset = "0x7EBC4B0", VA = "0x187EBD0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7EBDBD0", Offset = "0x7EBCFD0", VA = "0x187EBDBD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public GKCEGJCCCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3D50", Offset = "0x7EB3150", VA = "0x187EB3D50")]
		internal bool OHPNMMFJDOH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3AD0", Offset = "0x7EB2ED0", VA = "0x187EB3AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public KOEDAPJNCCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EBCC20", Offset = "0x7EBC020", VA = "0x187EBCC20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EBC330", Offset = "0x7EBB730", VA = "0x187EBC330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EBC310", Offset = "0x7EBB710", VA = "0x187EBC310")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7EBCBD0", Offset = "0x7EBBFD0", VA = "0x187EBCBD0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB2110", Offset = "0x7EB1510", VA = "0x187EB2110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7EB2000", Offset = "0x7EB1400", VA = "0x187EB2000")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1680", Offset = "0x7EB0A80", VA = "0x187EB1680")]
	[JBPLEELDMPC(GALPNODIPPP.EnteredEditModeNextFrame, 0)]
	private static void FEOKOHJLKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1AF0", Offset = "0x7EB0EF0", VA = "0x187EB1AF0")]
	[AsyncStateMachine(typeof(FPJEACFOCPE))]
	public static Task<Scene> IMMCCBPEFCO(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL = LoadSceneMode.Single, bool KFJFEEGFJLE = false, [Optional] FGFDKLMANEA<string>.ICBJPFEBGDJ KCGHBECOBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1840", Offset = "0x7EB0C40", VA = "0x187EB1840")]
	[AsyncStateMachine(typeof(DJGKAEJHAPF))]
	private static Task GDAGOJOGMCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2220", Offset = "0x7EB1620", VA = "0x187EB2220")]
	[AsyncStateMachine(typeof(CBDLHPHDNCG))]
	private static Task PJLPNBCNOMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1490", Offset = "0x7EB0890", VA = "0x187EB1490")]
	[AsyncStateMachine(typeof(EBBHNHBBJCL))]
	private static Task<Scene> DLJNHLINHOA(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL, bool KFJFEEGFJLE, FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1D70", Offset = "0x7EB1170", VA = "0x187EB1D70")]
	private static void LMJMCMBFADJ(SceneInstance AIHLLHKMGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB10A0", Offset = "0x7EB04A0", VA = "0x187EB10A0")]
	private static void BOLHEGBONMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1360", Offset = "0x7EB0760", VA = "0x187EB1360")]
	[AsyncStateMachine(typeof(OKIBIKPOAKJ))]
	private static Task<Scene> DDFGJCBCFDI(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB18F0", Offset = "0x7EB0CF0", VA = "0x187EB18F0")]
	private static bool HGAGAIHNNPI(string GOCBDOMNJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB19E0", Offset = "0x7EB0DE0", VA = "0x187EB19E0")]
	[AsyncStateMachine(typeof(MCGPMCMCGFA))]
	private static Task<Scene> HMHPKIGMEPC(FGFDKLMANEA<string>.ICBJPFEBGDJ EPDIGDJPOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1E80", Offset = "0x7EB1280", VA = "0x187EB1E80")]
	public static NEEPBAPEEOL<Scene> LPLPIOPOPLK(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB15E0", Offset = "0x7EB09E0", VA = "0x187EB15E0")]
	[IteratorStateMachine(typeof(KOEDAPJNCCH))]
	private static IEnumerator<FBLKJCIOKGP> EACMELMABFE(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL, NINOOKDCBLL<Scene> JPBFMNPPLDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1040", Offset = "0x7EB0440", VA = "0x187EB1040")]
	public static void AMCCFPNAPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1780", Offset = "0x7EB0B80", VA = "0x187EB1780")]
	private static void FFPLNKAJNFE(string GOCBDOMNJJE, LoadSceneMode EGNIBDJACLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1C40", Offset = "0x7EB1040", VA = "0x187EB1C40")]
	public static bool LCAABHNEPHO([Out] string PNKNNGBOMLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HCALMBPOGCG
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3FD0", Offset = "0x7EB33D0", VA = "0x187EB3FD0")]
	public static IDisposable GHFLFNNKHOE(this BMCDILGALJB BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3F50", Offset = "0x7EB3350", VA = "0x187EB3F50")]
	public static IDisposable ADNGLEDAFFE(this BMCDILGALJB BPPCEJGCMKA, Action<float> DMGPEODFGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4060", Offset = "0x7EB3460", VA = "0x187EB4060")]
	public static IDisposable HLFMHLFCAJA(this BMCDILGALJB BPPCEJGCMKA, Action<float> DMGPEODFGGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JDLMKCIMMMN
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33E3DF0", Offset = "0x33E31F0", VA = "0x1833E3DF0")]
	[ABGINMJPEGK]
	public static IDisposable KCPAEDHHGLD<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x33E3FA0", Offset = "0x33E33A0", VA = "0x1833E3FA0")]
	[ABGINMJPEGK]
	public static IDisposable KCPAEDHHGLD<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x33E4280", Offset = "0x33E3680", VA = "0x1833E4280")]
	[ABGINMJPEGK]
	public static IDisposable PLJNMJIHBJD<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x33E37F0", Offset = "0x33E2BF0", VA = "0x1833E37F0")]
	[ABGINMJPEGK]
	public static IDisposable ALLDOJBMADL<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x33E37F0", Offset = "0x33E2BF0", VA = "0x1833E37F0")]
	[ABGINMJPEGK]
	public static IDisposable ALLDOJBMADL<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x33E41F0", Offset = "0x33E35F0", VA = "0x1833E41F0")]
	[ABGINMJPEGK]
	public static IDisposable NIFCHODJFAH<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x33E3840", Offset = "0x33E2C40", VA = "0x1833E3840")]
	[ABGINMJPEGK]
	public static IDisposable BCHLOLGBDIP<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x33E41A0", Offset = "0x33E35A0", VA = "0x1833E41A0")]
	[ABGINMJPEGK]
	public static IDisposable LEGENFFIDOM<T>(this T DCDHPNKMBKF, Action DMGPEODFGGC, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x33E4240", Offset = "0x33E3640", VA = "0x1833E4240")]
	[ABGINMJPEGK]
	public static IDisposable NPIJKLLJBJE<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB80E0", Offset = "0x7EB74E0", VA = "0x187EB80E0")]
	[ABGINMJPEGK]
	public static IDisposable NPIJKLLJBJE(this MonoBehaviour DCDHPNKMBKF, NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33E3C40", Offset = "0x33E3040", VA = "0x1833E3C40")]
	[ABGINMJPEGK]
	public static IDisposable KBJDEJOJHKF<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x33E4150", Offset = "0x33E3550", VA = "0x1833E4150")]
	[ABGINMJPEGK]
	public static IDisposable LAENHLKEEKN<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x33E3950", Offset = "0x33E2D50", VA = "0x1833E3950")]
	[ABGINMJPEGK]
	public static IDisposable CNDLFGLHBOI<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x33E3B80", Offset = "0x33E2F80", VA = "0x1833E3B80")]
	[ABGINMJPEGK]
	public static IDisposable JFMEABLEFBH<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x33E38F0", Offset = "0x33E2CF0", VA = "0x1833E38F0")]
	[ABGINMJPEGK]
	public static IDisposable CLKNPKJCOFP<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x33E3B20", Offset = "0x33E2F20", VA = "0x1833E3B20")]
	[ABGINMJPEGK]
	public static IDisposable HMMOCIKAMMH<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x33E3A60", Offset = "0x33E2E60", VA = "0x1833E3A60")]
	[ABGINMJPEGK]
	public static IDisposable FOEDBIBFAIH<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x33E3A00", Offset = "0x33E2E00", VA = "0x1833E3A00")]
	[ABGINMJPEGK]
	public static IDisposable FDJGDNMHMHK<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x33E3890", Offset = "0x33E2C90", VA = "0x1833E3890")]
	[ABGINMJPEGK]
	public static IDisposable BLBMHCHHAJK<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x33E39B0", Offset = "0x33E2DB0", VA = "0x1833E39B0")]
	[ABGINMJPEGK]
	public static IDisposable DCBNGOHFBCA<T>(this T DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x33E3BE0", Offset = "0x33E2FE0", VA = "0x1833E3BE0")]
	[ABGINMJPEGK]
	public static IDisposable JPPFNBPHIAK<T>(this T DCDHPNKMBKF, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true) where T : MonoBehaviour, NFEDKEMNHKL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x33E3AC0", Offset = "0x33E2EC0", VA = "0x1833E3AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public FDLEAKCAINA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0ED0", Offset = "0x7EB02D0", VA = "0x187EB0ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0FB0", Offset = "0x7EB03B0", VA = "0x187EB0FB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public HMIPAJCBBMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7EB4710", Offset = "0x7EB3B10", VA = "0x187EB4710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7EB4800", Offset = "0x7EB3C00", VA = "0x187EB4800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE2E0", Offset = "0x7EAD6E0", VA = "0x187EAE2E0")]
	public static HPLGDNGCOKN KCPAEDHHGLD(Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE360", Offset = "0x7EAD760", VA = "0x187EAE360")]
	public static HPLGDNGCOKN KCPAEDHHGLD(Behaviour BPPCEJGCMKA, Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE3F0", Offset = "0x7EAD7F0", VA = "0x187EAE3F0")]
	public static HPLGDNGCOKN KCPAEDHHGLD(Behaviour BPPCEJGCMKA, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE1C0", Offset = "0x7EAD5C0", VA = "0x187EAE1C0")]
	[IteratorStateMachine(typeof(FDLEAKCAINA))]
	private static IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OIMEBHOMAGD CAPLBJNMICN, Action DMGPEODFGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE250", Offset = "0x7EAD650", VA = "0x187EAE250")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public NGGFCPBELIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EC16E0", Offset = "0x7EC0AE0", VA = "0x187EC16E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1770", Offset = "0x7EC0B70", VA = "0x187EC1770", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x94FCE0", Offset = "0x94F0E0", VA = "0x18094FCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EC18E0", Offset = "0x7EC0CE0", VA = "0x187EC18E0")]
	public NKJJKKFEALL(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EC17C0", Offset = "0x7EC0BC0", VA = "0x187EC17C0")]
	[IteratorStateMachine(typeof(NGGFCPBELIM))]
	private IEnumerator<FBLKJCIOKGP> BEIOHCLMBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1840", Offset = "0x7EC0C40", VA = "0x187EC1840", Slot = "4")]
	public void OnCompleted(Action KCPBOAEAJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public void PNMFNAONGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DCBMHLLFJBB
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EACCE0", Offset = "0x7EAC0E0", VA = "0x187EACCE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public HLDGCHKEPPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7EB4440", Offset = "0x7EB3840", VA = "0x187EB4440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7EB44C0", Offset = "0x7EB38C0", VA = "0x187EB44C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB96A0", Offset = "0x7EB8AA0", VA = "0x187EB96A0")]
	public static HPLGDNGCOKN KCPAEDHHGLD(float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9770", Offset = "0x7EB8B70", VA = "0x187EB9770")]
	public static HPLGDNGCOKN KCPAEDHHGLD(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9390", Offset = "0x7EB8790", VA = "0x187EB9390")]
	public static HPLGDNGCOKN EJOOMCFFIAB(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9540", Offset = "0x7EB8940", VA = "0x187EB9540")]
	public static HPLGDNGCOKN IIIABLLBFEN(BMCDILGALJB BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9480", Offset = "0x7EB8880", VA = "0x187EB9480")]
	private static IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OJJHKDPCLBJ KPAHHFHFDIA, float NCBKMBOOCHJ, OIMEBHOMAGD CAPLBJNMICN, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9840", Offset = "0x7EB8C40", VA = "0x187EB9840")]
	private static IEnumerator<FBLKJCIOKGP> MIGLMBJAMNH(OJJHKDPCLBJ KPAHHFHFDIA, float NCBKMBOOCHJ, OIMEBHOMAGD CAPLBJNMICN, Action<float> DMGPEODFGGC, bool NGLJKGBDGKD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9610", Offset = "0x7EB8A10", VA = "0x187EB9610")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public PCGKGCBFGNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2910", Offset = "0x7EC1D10", VA = "0x187EC2910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7EC29D0", Offset = "0x7EC1DD0", VA = "0x187EC29D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0740", Offset = "0x7EAFB40", VA = "0x187EB0740")]
	[IteratorStateMachine(typeof(PCGKGCBFGNC))]
	private static IEnumerator<FBLKJCIOKGP> BCDDGGBJBIA(OIMEBHOMAGD LFGBMCCIBAB, Func<bool> CMPFGFPGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB07D0", Offset = "0x7EAFBD0", VA = "0x187EB07D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public NMHJHPINDMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC19F0", Offset = "0x7EC0DF0", VA = "0x187EC19F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1A60", Offset = "0x7EC0E60", VA = "0x187EC1A60", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public JFOAPDNHJOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x496DB60", Offset = "0x496CF60", VA = "0x18496DB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x496DC00", Offset = "0x496D000", VA = "0x18496DC00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public OPNFDMFKLMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2630", Offset = "0x7EC1A30", VA = "0x187EC2630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC26C0", Offset = "0x7EC1AC0", VA = "0x187EC26C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB77B0", Offset = "0x7EB6BB0", VA = "0x187EB77B0")]
	[IteratorStateMachine(typeof(NMHJHPINDMN))]
	private static IEnumerator<FBLKJCIOKGP> BEIOHCLMBCM(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x33E10A0", Offset = "0x33E04A0", VA = "0x1833E10A0")]
	[IteratorStateMachine(typeof(JFOAPDNHJOC<>))]
	private static IEnumerator<FBLKJCIOKGP> BEIOHCLMBCM<T>(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action<T> BPHLLBLGCAD, T ICONKPKJBGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7CA0", Offset = "0x7EB70A0", VA = "0x187EB7CA0")]
	[IteratorStateMachine(typeof(OPNFDMFKLMA))]
	private static IEnumerator<FBLKJCIOKGP> NMENBEOGBLF(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7ED0", Offset = "0x7EB72D0", VA = "0x187EB7ED0")]
	public static IDisposable PDMJHHKIHNK(this MonoBehaviour DCDHPNKMBKF, float HKPDGGGHFLH, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8050", Offset = "0x7EB7450", VA = "0x187EB8050")]
	public static HPLGDNGCOKN PMANGDGIEFB(this MonoBehaviour DCDHPNKMBKF, float HKPDGGGHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7DE0", Offset = "0x7EB71E0", VA = "0x187EB7DE0")]
	public static HPLGDNGCOKN PDMJHHKIHNK(this MonoBehaviour DCDHPNKMBKF, float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7710", Offset = "0x7EB6B10", VA = "0x187EB7710")]
	public static HPLGDNGCOKN ADDFLCPFPIA(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x33E1050", Offset = "0x33E0450", VA = "0x1833E1050")]
	public static HPLGDNGCOKN ADDFLCPFPIA<T>(this MonoBehaviour DCDHPNKMBKF, Action<T> BPHLLBLGCAD, T ICONKPKJBGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7850", Offset = "0x7EB6C50", VA = "0x187EB7850")]
	public static HPLGDNGCOKN BHJDOFGLAPB(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7AC0", Offset = "0x7EB6EC0", VA = "0x187EB7AC0")]
	public static HPLGDNGCOKN GLJLPJBPFAB(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7B60", Offset = "0x7EB6F60", VA = "0x187EB7B60")]
	public static HPLGDNGCOKN IDMCHIANLBP(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7A20", Offset = "0x7EB6E20", VA = "0x187EB7A20")]
	public static HPLGDNGCOKN FNBBPMMIMIN(this MonoBehaviour DCDHPNKMBKF, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7FB0", Offset = "0x7EB73B0", VA = "0x187EB7FB0")]
	public static HPLGDNGCOKN PHMDPHBGNIH(MonoBehaviour DCDHPNKMBKF, OIMEBHOMAGD LFGBMCCIBAB, Action BPHLLBLGCAD, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x33E1180", Offset = "0x33E0580", VA = "0x1833E1180")]
	public static HPLGDNGCOKN PHMDPHBGNIH<T>(MonoBehaviour DCDHPNKMBKF, OIMEBHOMAGD LFGBMCCIBAB, Action<T> BPHLLBLGCAD, T ICONKPKJBGN, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7990", Offset = "0x7EB6D90", VA = "0x187EB7990")]
	public static HPLGDNGCOKN CCOEJEMPHIJ(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7C00", Offset = "0x7EB7000", VA = "0x187EB7C00")]
	public static HPLGDNGCOKN KIIPHAEOPCI(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7EB78F0", Offset = "0x7EB6CF0", VA = "0x187EB78F0")]
	public static HPLGDNGCOKN BJOKEAKLFBP(this MonoBehaviour DCDHPNKMBKF, float KMKAOFFCODG, Action BPHLLBLGCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7EB7D40", Offset = "0x7EB7140", VA = "0x187EB7D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAF540", Offset = "0x7EAE940", VA = "0x187EAF540", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPGOBDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF370", Offset = "0x7EAE770", VA = "0x187EAF370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF250", Offset = "0x7EAE650", VA = "0x187EAF250", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF9A0", Offset = "0x7EAEDA0", VA = "0x187EAF9A0")]
	public EDHBCAOBFFK([Optional] Action PGEFKCHPJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF410", Offset = "0x7EAE810", VA = "0x187EAF410")]
	public void HBHDBABAKDP(BKFMNGCFFLF OCKDEKFOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF0F0", Offset = "0x7EAE4F0", VA = "0x187EAF0F0")]
	private void BDMNFFLIKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF990", Offset = "0x7EAED90", VA = "0x187EAF990", Slot = "7")]
	public bool MBJGFMMMDOI(bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF680", Offset = "0x7EAEA80", VA = "0x187EAF680", Slot = "8")]
	public bool MBJGFMMMDOI(Action PJDAFKMDDCG, bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF2F0", Offset = "0x7EAE6F0", VA = "0x187EAF2F0", Slot = "9")]
	public IEnumerator<BKFMNGCFFLF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF2F0", Offset = "0x7EAE6F0", VA = "0x187EAF2F0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FLFNAEKBCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7EADDB0", Offset = "0x7EAD1B0", VA = "0x187EADDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DGLCLGMHCBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7EADDB0", Offset = "0x7EAD1B0", VA = "0x187EADDB0")]
		internal void GMHJNNFKAGP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float NOIMACGINNE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3E10", Offset = "0x7EB3210", VA = "0x187EB3E10")]
	public KDHBDNBAHOB(Behaviour BPPCEJGCMKA, float NOIMACGINNE, [Optional] Action PGEFKCHPJDA, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB87D0", Offset = "0x7EB7BD0", VA = "0x187EB87D0", Slot = "9")]
	protected override bool IKKLPGHNHDJ(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB86C0", Offset = "0x7EB7AC0", VA = "0x187EB86C0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public LBLOMMJIBCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7EBCD00", Offset = "0x7EBC100", VA = "0x187EBCD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7EBCDD0", Offset = "0x7EBC1D0", VA = "0x187EBCDD0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1802050", Offset = "0x1801450", VA = "0x181802050", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPGOBDDOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD870", Offset = "0x7EACC70", VA = "0x187EAD870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD750", Offset = "0x7EACB50", VA = "0x187EAD750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7EADC80", Offset = "0x7EAD080", VA = "0x187EADC80")]
	protected DFMMBKBAAJH(Behaviour BPPCEJGCMKA, [Optional] Action PGEFKCHPJDA, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7EADC00", Offset = "0x7EAD000", VA = "0x187EADC00", Slot = "7")]
	public bool MBJGFMMMDOI(bool MHOOEDPKADD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7EADBA0", Offset = "0x7EACFA0", VA = "0x187EADBA0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EADC60", Offset = "0x7EAD060", VA = "0x187EADC60")]
	protected void OOJODOMLJLJ(Action PJDAFKMDDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD910", Offset = "0x7EACD10", VA = "0x187EAD910")]
	protected HJOKANJAKGB ICBFBMKJLII(float LKDAAJDJIMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD7F0", Offset = "0x7EACBF0", VA = "0x187EAD7F0")]
	private void BPFKIPBICKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7EAD6C0", Offset = "0x7EACAC0", VA = "0x187EAD6C0")]
	[IteratorStateMachine(typeof(LBLOMMJIBCG))]
	private IEnumerator<FBLKJCIOKGP> AICHBDAIGME(float LKDAAJDJIMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7EADB60", Offset = "0x7EACF60", VA = "0x187EADB60")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EC1D30", Offset = "0x7EC1130", VA = "0x187EC1D30")]
	public OFFHHMHBING(Behaviour BPPCEJGCMKA, float EHJECKBKCJJ, int MIKPOALDBBN, [Optional] Action PGEFKCHPJDA, float MCJJAKLIGJG = 0f, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "9")]
	protected override bool IKKLPGHNHDJ(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1AB0", Offset = "0x7EC0EB0", VA = "0x187EC1AB0", Slot = "10")]
	protected override bool AAJFCFEGHJP(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1CB0", Offset = "0x7EC10B0", VA = "0x187EC1CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EB3E10", Offset = "0x7EB3210", VA = "0x187EB3E10")]
	public HADPEHNHANA(Behaviour BPPCEJGCMKA, float NOIMACGINNE, [Optional] Action PGEFKCHPJDA, [Optional] MEFKNEOFFHC JGFDBKNDMLP, [Optional] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "9")]
	protected override bool IKKLPGHNHDJ(Action PJDAFKMDDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB3DD0", Offset = "0x7EB31D0", VA = "0x187EB3DD0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public AJILLINEGIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7010", Offset = "0x7EA6410", VA = "0x187EA7010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7080", Offset = "0x7EA6480", VA = "0x187EA7080", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EB4D50", Offset = "0x7EB4150", VA = "0x187EB4D50")]
	public HNOIAFBJDLO(BMCDILGALJB BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4B60", Offset = "0x7EB3F60", VA = "0x187EB4B60")]
	private void MPOENKLOAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4A30", Offset = "0x7EB3E30", VA = "0x187EB4A30")]
	private void LJBLIPKDFML(string IFMHONGNKHP, Action EDFNLKFMHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4CD0", Offset = "0x7EB40D0", VA = "0x187EB4CD0")]
	[IteratorStateMachine(typeof(AJILLINEGIB))]
	private IEnumerator<FBLKJCIOKGP> OHNLBGOGKCO(Action EDFNLKFMHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7EB49D0", Offset = "0x7EB3DD0", VA = "0x187EB49D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7EB4850", Offset = "0x7EB3C50", VA = "0x187EB4850")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public MEFMLNBMLAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA7010", Offset = "0x7EA6410", VA = "0x187EA7010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF860", Offset = "0x7EBEC60", VA = "0x187EBF860", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EC0F80", Offset = "0x7EC0380", VA = "0x187EC0F80")]
	public MOHFKOCOJAP(MonoBehaviour DCDHPNKMBKF, Action DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7EC1110", Offset = "0x7EC0510", VA = "0x187EC1110")]
	public MOHFKOCOJAP(MonoBehaviour DCDHPNKMBKF, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0DA0", Offset = "0x7EC01A0", VA = "0x187EC0DA0")]
	public MOHFKOCOJAP(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0xC11840", Offset = "0xC10C40", VA = "0x180C11840")]
	private MOHFKOCOJAP(MEFKNEOFFHC JGFDBKNDMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0B70", Offset = "0x7EBFF70", VA = "0x187EC0B70")]
	internal static MOHFKOCOJAP PLANJDOLGKM(MonoBehaviour DCDHPNKMBKF, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, [Optional] MEFKNEOFFHC JGFDBKNDMLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0600", Offset = "0x7EBFA00", VA = "0x187EC0600")]
	private void KCPAEDHHGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0480", Offset = "0x7EBF880", VA = "0x187EC0480")]
	private void HGLFMCDJLDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0980", Offset = "0x7EBFD80", VA = "0x187EC0980")]
	private void MPOENKLOAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0200", Offset = "0x7EBF600", VA = "0x187EC0200")]
	private void CLGIJIKLOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0730", Offset = "0x7EBFB30", VA = "0x187EC0730")]
	private void LJBLIPKDFML(string IFMHONGNKHP, Action EDFNLKFMHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0AF0", Offset = "0x7EBFEF0", VA = "0x187EC0AF0")]
	[IteratorStateMachine(typeof(MEFMLNBMLAH))]
	private IEnumerator<FBLKJCIOKGP> OHNLBGOGKCO(Action EDFNLKFMHDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0390", Offset = "0x7EBF790", VA = "0x187EC0390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0860", Offset = "0x7EBFC60", VA = "0x187EC0860")]
	[CompilerGenerated]
	private void LKBMCDGCCGF(string JNJDMGFBFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7EC0170", Offset = "0x7EBF570", VA = "0x187EC0170")]
	[CompilerGenerated]
	private void AHCIOENIJKN(string JNJDMGFBFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7EC03F0", Offset = "0x7EBF7F0", VA = "0x187EC03F0")]
	[CompilerGenerated]
	private void GMCEGGBIBEN(string JNJDMGFBFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7EC08F0", Offset = "0x7EBFCF0", VA = "0x187EC08F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC2AA0", Offset = "0x7EC1EA0", VA = "0x187EC2AA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public float GMPPNNBLOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2A20", Offset = "0x7EC1E20", VA = "0x187EC2A20", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public double OOGBABHPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2AB0", Offset = "0x7EC1EB0", VA = "0x187EC2AB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7EC2A30", Offset = "0x7EC1E30", VA = "0x187EC2A30")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x952480", Offset = "0x951880", VA = "0x180952480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6D40", Offset = "0x7EA6140", VA = "0x187EA6D40")]
	public static FBLKJCIOKGP HPPBJLPLLBF(IEnumerator<FBLKJCIOKGP> MAKLGEBLGAC, KMACFHMAHPJ ACMOBPAMBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6C80", Offset = "0x7EA6080", VA = "0x187EA6C80")]
	public FBLKJCIOKGP HPPBJLPLLBF(KMACFHMAHPJ[] PMHCNAFCBHL, IEnumerator<FBLKJCIOKGP>[] DEHPICHPDFO, FBLKJCIOKGP[] APAJOEBFNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6B10", Offset = "0x7EA5F10", VA = "0x187EA6B10")]
	public void BJDDBJDFPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6B40", Offset = "0x7EA5F40", VA = "0x187EA6B40")]
	public void BBIEFDJMMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6EA0", Offset = "0x7EA62A0", VA = "0x187EA6EA0")]
	public void IAHAOEEBCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7EA6B10", Offset = "0x7EA5F10", VA = "0x187EA6B10")]
	public void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public DFDPCLDGNMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7EACDF0", Offset = "0x7EAC1F0", VA = "0x187EACDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public NKKNPAJFKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC19B0", Offset = "0x7EC0DB0", VA = "0x187EC19B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FMABEEFPDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1000", Offset = "0x7EB0400", VA = "0x187EB1000")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HFKLNDOOKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7EB40E0", Offset = "0x7EB34E0", VA = "0x187EB40E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA257A0", Offset = "0xA24BA0", VA = "0x180A257A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBA80", Offset = "0x7EBAE80", VA = "0x187EBBA80")]
	private static int OCJBPLKJKGO(OIMEBHOMAGD LFGBMCCIBAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBC30", Offset = "0x7EBB030", VA = "0x187EBBC30")]
	public KLKJLMDLKCG(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7EBB180", Offset = "0x7EBA580", VA = "0x187EBB180")]
	private void MPBFGJPIAIH(int CANKPOFEILP, int FAEMGGEHCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7EBBAB0", Offset = "0x7EBAEB0", VA = "0x187EBBAB0")]
	public void OLBFPKKJHMO(BMCDILGALJB BPPCEJGCMKA, FBLKJCIOKGP LNOOJGMBJHA, IEnumerator<FBLKJCIOKGP> MAKLGEBLGAC, KMACFHMAHPJ ACMOBPAMBFB, [Optional] AFELDIKGJIM LJJHGMMHHMO, BCINMLKFIDL HCGLIPCDIAC = BCINMLKFIDL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBAD40", Offset = "0x7EBA140", VA = "0x187EBAD40")]
	public void KLHNJBNJIGK(IEnumerable<DMENFHCGHKM> AGNNKOOCECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA270", Offset = "0x7EB9670", VA = "0x187EBA270")]
	private DMENFHCGHKM KBFJFFJMMIO(int OPBLCEPHDHO)
	{
		return default(DMENFHCGHKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9BA0", Offset = "0x7EB8FA0", VA = "0x187EB9BA0")]
	private void FLGJJACAOGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x346D300", Offset = "0x346C700", VA = "0x18346D300")]
	private static void NIAFPKHNLGD<T>(int OPBLCEPHDHO, T[] DDOOOEHLJBB, int IBMHAIHIDJJ, [Optional] T FLCNPNJNIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x346D350", Offset = "0x346C750", VA = "0x18346D350")]
	private static void NIAFPKHNLGD<T>(int OPBLCEPHDHO, NativeArray<T> DDOOOEHLJBB, int IBMHAIHIDJJ, [Optional] T FLCNPNJNIDC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA9A0", Offset = "0x7EB9DA0", VA = "0x187EBA9A0")]
	private void KIDCFCNOBGI(IEnumerable<DMENFHCGHKM> AGNNKOOCECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9A50", Offset = "0x7EB8E50", VA = "0x187EB9A50")]
	private void BCGLIPAPOJH(DMENFHCGHKM CKCEFDBDABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA010", Offset = "0x7EB9410", VA = "0x187EBA010")]
	private DFBDLHJMHCL IGHNMCNNDJN(int MBJPNHOHEJM)
	{
		return default(DFBDLHJMHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7EBAF80", Offset = "0x7EBA380", VA = "0x187EBAF80")]
	public void MCEFMMAHEGG(float LOJMONJPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7EB99D0", Offset = "0x7EB8DD0", VA = "0x187EB99D0")]
	private void BAKHLPBLPBI(Action AMGCKABOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9B20", Offset = "0x7EB8F20", VA = "0x187EB9B20")]
	private void DKDGICCJPMK(Action AMGCKABOOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7EBB360", Offset = "0x7EBA760", VA = "0x187EBB360")]
	public void NNPIKPLLCGA(float LOJMONJPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9F10", Offset = "0x7EB9310", VA = "0x187EB9F10")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7EB98A0", Offset = "0x7EB8CA0", VA = "0x187EB98A0")]
	public void APDCJKMBNFA(AFELDIKGJIM HJMLDIIALEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA740", Offset = "0x7EB9B40", VA = "0x187EBA740")]
	public void KBHMPLKPKMH(AFELDIKGJIM HJMLDIIALEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA870", Offset = "0x7EB9C70", VA = "0x187EBA870")]
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
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public GJCFLAKCACI(Action BKAIFAJPEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x757BA70", Offset = "0x757AE70", VA = "0x18757BA70", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public FMLCOHEMFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x43DCF20", Offset = "0x43DC320", VA = "0x1843DCF20")]
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
		[Cpp2IlInjected.Address(RVA = "0xBACAA0", Offset = "0xBABEA0", VA = "0x180BACAA0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x45CF8C0", Offset = "0x45CECC0", VA = "0x1845CF8C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x45CFCC0", Offset = "0x45CF0C0", VA = "0x1845CFCC0")]
	private static bool JPLLIPAIDFP(T AMGCKABOOPF, T PPCFCAEIJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x45D0430", Offset = "0x45CF830", VA = "0x1845D0430")]
	public HEBGOBDHHPO(T OLAFDLKMDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x45CFB10", Offset = "0x45CEF10", VA = "0x1845CFB10", Slot = "6")]
	public IDisposable JOAIAECFCEH(UnityEngine.Object BPPCEJGCMKA, Action<T> LFIJDBJEFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x45D00F0", Offset = "0x45CF4F0", VA = "0x1845D00F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD48CE0", Offset = "0xD480E0", VA = "0x180D48CE0")]
			public AIJDHNDLNBH(int KGHCKLKGJKM, MHKGKKIKBBB CAPLBJNMICN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x7EA6FE0", Offset = "0x7EA63E0", VA = "0x187EA6FE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public PKAMMKJNBPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1C48FC0", Offset = "0x1C483C0", VA = "0x181C48FC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public IKHNEEFDFFL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x7EB5A50", Offset = "0x7EB4E50", VA = "0x187EB5A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7EB5D80", Offset = "0x7EB5180", VA = "0x187EB5D80", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC00D0", Offset = "0x7EBF4D0", VA = "0x187EC00D0")]
		public MHKGKKIKBBB(OIMEBHOMAGD LFGBMCCIBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFCD0", Offset = "0x7EBF0D0", VA = "0x187EBFCD0")]
		public IDisposable BIMBOEFGFOH(CNEDHKBAAAA BGNGLILFNLL, MEFKNEOFFHC JGFDBKNDMLP, OJJHKDPCLBJ ACNLNBKGHCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFF40", Offset = "0x7EBF340", VA = "0x187EBFF40")]
		private void GMOJJPALAKG(int KGHCKLKGJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFEB0", Offset = "0x7EBF2B0", VA = "0x187EBFEB0")]
		[IteratorStateMachine(typeof(IKHNEEFDFFL))]
		private IEnumerator<FBLKJCIOKGP> ENNPJIEPGGO(OJJHKDPCLBJ ACNLNBKGHCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EBFE60", Offset = "0x7EBF260", VA = "0x187EBFE60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA87F0", Offset = "0x7EA7BF0", VA = "0x187EA87F0")]
		public CNEDHKBAAAA(NFEDKEMNHKL BPPCEJGCMKA, Action DMGPEODFGGC, bool BNEMCMHGEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8670", Offset = "0x7EA7A70", VA = "0x187EA8670")]
		public CNEDHKBAAAA(NFEDKEMNHKL BPPCEJGCMKA, Action<float> DMGPEODFGGC, bool BNEMCMHGEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8490", Offset = "0x7EA7890", VA = "0x187EA8490")]
		public CNEDHKBAAAA(NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> DMGPEODFGGC, OJJHKDPCLBJ ACNLNBKGHCE, HGIBMJOBAKP LIAGJJDNDHN, bool NGLJKGBDGKD, bool BNEMCMHGEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7EA82C0", Offset = "0x7EA76C0", VA = "0x187EA82C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EB2660", Offset = "0x7EB1A60", VA = "0x187EB2660")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void JKJPFNEPFPA(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2FF0", Offset = "0x7EB23F0", VA = "0x187EB2FF0")]
	[UnityEngine.Scripting.Preserve]
	internal FPCEGEOKNGA([IBJCGEMJMJL(null)] MEFKNEOFFHC JGFDBKNDMLP, [IBJCGEMJMJL(null)] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2C10", Offset = "0x7EB2010", VA = "0x187EB2C10", Slot = "4")]
	public IDisposable PLJNMJIHBJD(NFEDKEMNHKL BPPCEJGCMKA, Action IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2E00", Offset = "0x7EB2200", VA = "0x187EB2E00", Slot = "5")]
	public IDisposable PLJNMJIHBJD(NFEDKEMNHKL BPPCEJGCMKA, Action<float> IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2890", Offset = "0x7EB1C90", VA = "0x187EB2890", Slot = "7")]
	public IDisposable LAENHLKEEKN(NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2B10", Offset = "0x7EB1F10", VA = "0x187EB2B10", Slot = "8")]
	public IDisposable LPCAAPHEEOJ(NFEDKEMNHKL BPPCEJGCMKA, float NCBKMBOOCHJ, Action<float> IJCKFHFIADK, OIMEBHOMAGD LFGBMCCIBAB, bool NGLJKGBDGKD = true, bool BNEMCMHGEIH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2990", Offset = "0x7EB1D90", VA = "0x187EB2990", Slot = "6")]
	public IDisposable LAENHLKEEKN(float NCBKMBOOCHJ, Action<float> IJCKFHFIADK, bool NGLJKGBDGKD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x7EB26D0", Offset = "0x7EB1AD0", VA = "0x187EB26D0", Slot = "9")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EB2520", Offset = "0x7EB1920", VA = "0x187EB2520")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EAFF50", Offset = "0x7EAF350", VA = "0x187EAFF50")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0680", Offset = "0x7EAFA80", VA = "0x187EB0680")]
	[UnityEngine.Scripting.Preserve]
	public EKKELDDHIIG([IBJCGEMJMJL(null)] BOPONHNNBBC LJBFIDFJMHN, [IBJCGEMJMJL(null)] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFD00", Offset = "0x7EAF100", VA = "0x187EAFD00", Slot = "19")]
	public override HPLGDNGCOKN BHLOMFMEOCO(BMCDILGALJB BPPCEJGCMKA, IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB01F0", Offset = "0x7EAF5F0", VA = "0x187EB01F0", Slot = "20")]
	public override void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFFC0", Offset = "0x7EAF3C0", VA = "0x187EAFFC0", Slot = "22")]
	public override void JHGDNMNAOAI(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB05B0", Offset = "0x7EAF9B0", VA = "0x187EB05B0", Slot = "21")]
	protected override void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFAA0", Offset = "0x7EAEEA0", VA = "0x187EAFAA0")]
	private KLKJLMDLKCG AALINBPJDNP(OIMEBHOMAGD BMIPLDLMPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFAD0", Offset = "0x7EAEED0", VA = "0x187EAFAD0", Slot = "23")]
	internal override KHDNFFJAFBP ALOHLCDIMJN(IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP, Behaviour BPPCEJGCMKA, KMACFHMAHPJ ACMOBPAMBFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFE30", Offset = "0x7EAF230", VA = "0x187EAFE30", Slot = "24")]
	internal override MDNGIPCNPCF DPPPLCKBOAA(OIMEBHOMAGD CAPLBJNMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0490", Offset = "0x7EAF890", VA = "0x187EB0490")]
	private void OMAPBMKPLLO(KLKJLMDLKCG IHNPLIMPGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFEF0", Offset = "0x7EAF2F0", VA = "0x187EAFEF0", Slot = "25")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EA8260", Offset = "0x7EA7660", VA = "0x187EA8260")]
	public static CKAAJCLBPIB OILMBKHFGKP(int JBLPJKGNDGH, float LOJMONJPLCB, NativeArray<BCINMLKFIDL> HFAHDDHJBIH, NativeArray<float> ELDOKBIJINA, NativeArray<int> MKGBNGEABJA, NativeArray<int> FIJIJODJOPF, NativeArray<int> ENLMLFOJNAF, NativeArray<int> KDOEPKPKNDC, NativeArray<int> OLEEEGNDNCL)
	{
		return default(CKAAJCLBPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8110", Offset = "0x7EA7510", VA = "0x187EA8110", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7EA81F0", Offset = "0x7EA75F0", VA = "0x187EA81F0")]
	private bool FENEBKIIIJH(int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8230", Offset = "0x7EA7630", VA = "0x187EA8230")]
	private void FLAOHBOLGNH(NativeArray<int> IPJLMGNKKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7EA7FA0", Offset = "0x7EA73A0", VA = "0x187EA7FA0")]
	private int CEEJFNNFCHD(int DOEDICBKPCK, int JAEOJHGOKIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7EA8040", Offset = "0x7EA7440", VA = "0x187EA8040")]
	private void EJHNHLBOOFA(NativeArray<int> IPJLMGNKKAH, int BJBDCKOMDKP, int FBIKENCMLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7EA7D60", Offset = "0x7EA7160", VA = "0x187EA7D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB6990", Offset = "0x7EB5D90", VA = "0x187EB6990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public static bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OIMEBHOMAGD BONMBLGKHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OIMEBHOMAGD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x952480", Offset = "0x951880", VA = "0x180952480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public OJJHKDPCLBJ FDLLKFHNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public FBLKJCIOKGP OHCMDFBNIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6590", Offset = "0x7EB5990", VA = "0x187EB6590")]
	public static HPLGDNGCOKN JPKKDKGNDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6D30", Offset = "0x7EB6130", VA = "0x187EB6D30")]
	[UnityEngine.Scripting.Preserve]
	protected ILLHNBLILPD([IBJCGEMJMJL(null)] BOPONHNNBBC LJBFIDFJMHN, [IBJCGEMJMJL(null)] OJJHKDPCLBJ KPAHHFHFDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB62F0", Offset = "0x7EB56F0", VA = "0x187EB62F0", Slot = "6")]
	public HPLGDNGCOKN IKIFLPOJPIB(IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6300", Offset = "0x7EB5700", VA = "0x187EB6300", Slot = "7")]
	public HPLGDNGCOKN IKIFLPOJPIB(Behaviour BPPCEJGCMKA, IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract HPLGDNGCOKN BHLOMFMEOCO(BMCDILGALJB BPPCEJGCMKA, IEnumerator<FBLKJCIOKGP> LLCKAFOCLEP);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6620", Offset = "0x7EB5A20", VA = "0x187EB6620", Slot = "20")]
	public virtual void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6A40", Offset = "0x7EB5E40", VA = "0x187EB6A40", Slot = "9")]
	public void PINHAAOCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6C80", Offset = "0x7EB6080", VA = "0x187EB6C80", Slot = "21")]
	protected virtual void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6250", Offset = "0x7EB5650", VA = "0x187EB6250")]
	private void GAFIFHHFHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6230", Offset = "0x7EB5630", VA = "0x187EB6230")]
	private void FKHDPHOIEAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5DD0", Offset = "0x7EB51D0", VA = "0x187EB5DD0")]
	private void ALLDOJBMADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6A20", Offset = "0x7EB5E20", VA = "0x187EB6A20")]
	private void NIFCHODJFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6270", Offset = "0x7EB5670", VA = "0x187EB6270")]
	private void HGBKDLPEPMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5E50", Offset = "0x7EB5250", VA = "0x187EB5E50")]
	private void DIBGHNPIMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6A00", Offset = "0x7EB5E00", VA = "0x187EB6A00")]
	private void MGAENHCEGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6500", Offset = "0x7EB5900", VA = "0x187EB6500", Slot = "22")]
	public virtual void JHGDNMNAOAI(OIMEBHOMAGD LFGBMCCIBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7EB67C0", Offset = "0x7EB5BC0", VA = "0x187EB67C0")]
	private void LCKFGMPJKPP(MDNGIPCNPCF IHNPLIMPGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x24528B0", Offset = "0x2451CB0", VA = "0x1824528B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7EB5E70", Offset = "0x7EB5270", VA = "0x187EB5E70", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6290", Offset = "0x7EB5690", VA = "0x187EB6290", Slot = "15")]
	public FBLKJCIOKGP IDCFHOJNOID(OIMEBHOMAGD CAPLBJNMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7EB6CA0", Offset = "0x7EB60A0", VA = "0x187EB6CA0", Slot = "16")]
	public FBLKJCIOKGP PNOPMCKDNGJ(float HKPDGGGHFLH, OIMEBHOMAGD CAPLBJNMICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7EB5DF0", Offset = "0x7EB51F0", VA = "0x187EB5DF0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FBLKJCIOKGP GGHFAFHCHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CLBGPOJDHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7EB8AE0", Offset = "0x7EB7EE0", VA = "0x187EB8AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool IOFEOAIMEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A00", Offset = "0xAA5E00", VA = "0x180AA6A00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xADC660", Offset = "0xADBA60", VA = "0x180ADC660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB8ED0", Offset = "0x7EB82D0", VA = "0x187EB8ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HDOFLJBLEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xE93860", Offset = "0xE92C60", VA = "0x180E93860")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6916EF0", Offset = "0x69162F0", VA = "0x186916EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7EB91D0", Offset = "0x7EB85D0", VA = "0x187EB91D0")]
	public KHDNFFJAFBP(IEnumerator<FBLKJCIOKGP> MAKLGEBLGAC, EAJGHEFBJLI BPPCEJGCMKA, KMACFHMAHPJ ACMOBPAMBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8BB0", Offset = "0x7EB7FB0", VA = "0x187EB8BB0")]
	public FBLKJCIOKGP HPPBJLPLLBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7EB9080", Offset = "0x7EB8480", VA = "0x187EB9080")]
	public bool MJHGICNIGEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7EB8B60", Offset = "0x7EB7F60", VA = "0x187EB8B60")]
	public void APDCJKMBNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7EB90F0", Offset = "0x7EB84F0", VA = "0x187EB90F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xB433E0", Offset = "0xB427E0", VA = "0x180B433E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC018C0", Offset = "0xC00CC0", VA = "0x180C018C0", Slot = "23")]
		get
		{
			return default(OIMEBHOMAGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public OIMEBHOMAGD MFJNLMJALAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xD71D80", Offset = "0xD71180", VA = "0x180D71D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float HLLIIJAIMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA6F850", Offset = "0xA6EC50", VA = "0x180A6F850", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BPHBNBPPCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7EBC290", Offset = "0x7EBB690", VA = "0x187EBC290", Slot = "24")]
	private bool BAKAGOGOLML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7EBC2B0", Offset = "0x7EBB6B0", VA = "0x187EBC2B0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7EBC2C0", Offset = "0x7EBB6C0", VA = "0x187EBC2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF3B0", Offset = "0x7EBE7B0", VA = "0x187EBF3B0")]
	public MDNGIPCNPCF(OIMEBHOMAGD CAPLBJNMICN, LMEMKNHCAAM GKAIIIDNJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE3A0", Offset = "0x7EBD7A0", VA = "0x187EBE3A0")]
	public void GEFAIJPPHEF(KHDNFFJAFBP MAKLGEBLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDF60", Offset = "0x7EBD360", VA = "0x187EBDF60")]
	public void FBBLBAJKAFO(IList<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE4B0", Offset = "0x7EBD8B0", VA = "0x187EBE4B0")]
	public void JFACHAFOHAN(IList<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE940", Offset = "0x7EBDD40", VA = "0x187EBE940")]
	private void NANKGEEKECL(KHDNFFJAFBP MAKLGEBLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE7B0", Offset = "0x7EBDBB0", VA = "0x187EBE7B0")]
	private void MLFMPOLLBBG(IList<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEA30", Offset = "0x7EBDE30", VA = "0x187EBEA30")]
	private DFBDLHJMHCL OCIJCOMBOKM(KHDNFFJAFBP MAKLGEBLGAC)
	{
		return default(DFBDLHJMHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7EBF100", Offset = "0x7EBE500", VA = "0x187EBF100")]
	public void PLJNMJIHBJD(float LOJMONJPLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEF10", Offset = "0x7EBE310", VA = "0x187EBEF10")]
	public void PINHAAOCOKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x7EBEBB0", Offset = "0x7EBDFB0", VA = "0x187EBEBB0")]
	private void PBJGADGIPKB(List<KHDNFFJAFBP> DEHPICHPDFO, Stack<int> ICCMDPLJLJA, bool CODNBMIJEAC, float BDDJEOEPKAH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7EBDE40", Offset = "0x7EBD240", VA = "0x187EBDE40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7EBE260", Offset = "0x7EBD660", VA = "0x187EBE260")]
	private void FONBLPDDKIG(List<KHDNFFJAFBP> DEHPICHPDFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class BKBAFKDCCHP : LMEMKNHCAAM
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public void EONCCLLIMBE(string OMOOEGOLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
	public void JGOKHHJEPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAD640", Offset = "0x7EACA40", VA = "0x187EAD640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PKFLGBGJCDM
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD5F0", Offset = "0x7EAC9F0", VA = "0x187EAD5F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool NDMNAAJJLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD5D0", Offset = "0x7EAC9D0", VA = "0x187EAD5D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
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

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
public class ECHDHFAHHDM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority GPNBCANHBII;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5145870", Offset = "0x5144870", VA = "0x185145870")]
	public ECHDHFAHHDM(ThreadPriority JCKDCFIOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5145860", Offset = "0x5144860", VA = "0x185145860", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> EONNLCMADDO(List<PlayerLoopSystem> NEFLIPPAGDL, int IOCPDNKCFPL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct JFBOGHAIGLB
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct MNNFBILAFEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static MONMJFCKPLO PKDOIBBHMAL;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5150090", Offset = "0x514F090", VA = "0x185150090")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct ECLKADGHGHF
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static MONMJFCKPLO CFIKLBBAMBB;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x51458B0", Offset = "0x51448B0", VA = "0x1851458B0")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct MGAPKOEFECE
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static MONMJFCKPLO CLOABJPMNMA;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x514FC10", Offset = "0x514EC10", VA = "0x18514FC10")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct JGGMJGGBPNB
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static MONMJFCKPLO BCIFNOOAFDA;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static MONMJFCKPLO DJJNHNKGGNP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static MONMJFCKPLO CPGHALCKODG;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static MONMJFCKPLO LFBIILACLOD;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x514DBA0", Offset = "0x514CBA0", VA = "0x18514DBA0")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct PEAKFMPDOPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static MONMJFCKPLO HCLACDGKNGI;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5156470", Offset = "0x5155470", VA = "0x185156470")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct EHDENLOOPKL
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static MONMJFCKPLO BCIFNOOAFDA;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static MONMJFCKPLO DJJNHNKGGNP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static MONMJFCKPLO CPGHALCKODG;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static MONMJFCKPLO LFBIILACLOD;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5145E40", Offset = "0x5144E40", VA = "0x185145E40")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HNOHBKFGHMI
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static MONMJFCKPLO EMOJFIFOOOP;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x514ACC0", Offset = "0x5149CC0", VA = "0x18514ACC0")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct INBDPFOBOBH
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static MONMJFCKPLO KLMPOPBEHLJ;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x514B570", Offset = "0x514A570", VA = "0x18514B570")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct INLKNEIBCDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static MONMJFCKPLO MPLJFKLNFFC;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x514B780", Offset = "0x514A780", VA = "0x18514B780")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OGLJGGPMGFJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static MONMJFCKPLO IIIFCFDFNIM;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5153F00", Offset = "0x5152F00", VA = "0x185153F00")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct CLEFODEFPEK
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static MONMJFCKPLO BAFJPABMPEL;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x513FB40", Offset = "0x513EB40", VA = "0x18513FB40")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct ODLPMNIPFLI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static MONMJFCKPLO DFIAOJIJFAH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5153920", Offset = "0x5152920", VA = "0x185153920")]
				public static PlayerLoopSystem BBJGHECDAAK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum CHLBIFCNFHG : byte
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
			public struct AKEICAOIDAH
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class NCCJGINJIBN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public CHLBIFCNFHG updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
					public NCCJGINJIBN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x5150600", Offset = "0x514F600", VA = "0x185150600")]
					internal void ELHJPJHJBOG()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static OIDLICKKMBF<CHLBIFCNFHG> KODJOLKNGPA;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x513BB20", Offset = "0x513AB20", VA = "0x18513BB20")]
				public static PlayerLoopSystem BBJGHECDAAK(CHLBIFCNFHG GGCKJHNAEMK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct MOKHDIKLPPJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class MLKNEJLHMAI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public CGKDDBGENCK.IPOJKDAMNEL key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
					public MLKNEJLHMAI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x514FE20", Offset = "0x514EE20", VA = "0x18514FE20")]
					internal void CNBEKMELCON()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable GMPLEAMFAAH;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x51502A0", Offset = "0x514F2A0", VA = "0x1851502A0")]
				public static PlayerLoopSystem KDEGIDNMEMC(CGKDDBGENCK.IPOJKDAMNEL CDBHHMNALJL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct MAHFMNNJGPL
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class MCEKCGLNJAD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public CGKDDBGENCK.IPOJKDAMNEL key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
					public MCEKCGLNJAD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x514F980", Offset = "0x514E980", VA = "0x18514F980")]
					internal void CNBEKMELCON()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x514F7C0", Offset = "0x514E7C0", VA = "0x18514F7C0")]
				public static PlayerLoopSystem KDEGIDNMEMC(CGKDDBGENCK.IPOJKDAMNEL CDBHHMNALJL)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class FPNENFFAAHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public FPNENFFAAHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5146CC0", Offset = "0x5145CC0", VA = "0x185146CC0")]
			internal List<PlayerLoopSystem> MNFGGOKOIPL(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool LHOONEDBLMJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LLLDMMFLNHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5143C30", Offset = "0x5142C30", VA = "0x185143C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5143150", Offset = "0x5142150", VA = "0x185143150")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x51403E0", Offset = "0x513F3E0", VA = "0x1851403E0")]
		private static void CFBCLFOLJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5143190", Offset = "0x5142190", VA = "0x185143190")]
		private static void MFDGKMCGADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51400B0", Offset = "0x513F0B0", VA = "0x1851400B0")]
		private static void BHCCMABDGJM(string MGNHBOJEIEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x513FE80", Offset = "0x513EE80", VA = "0x18513FE80")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5143A60", Offset = "0x5142A60", VA = "0x185143A60")]
		private static void OAAFACOKDHD(CGKDDBGENCK.IPOJKDAMNEL CDBHHMNALJL, ref PlayerLoopSystem OOBMICFGAOM, Type KEEGHCBELCA, Type LBPFKPKKAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5142D30", Offset = "0x5141D30", VA = "0x185142D30")]
		private static void EFEBJEGKPAM(ref PlayerLoopSystem OOBMICFGAOM, Type KEEGHCBELCA, Type LBPFKPKKAJI, EONNLCMADDO HLEGMLAKBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x513FD50", Offset = "0x513ED50", VA = "0x18513FD50")]
		private static void AKNPMLPMFEK(ref PlayerLoopSystem OOBMICFGAOM, Type KEEGHCBELCA, Type LBPFKPKKAJI, PlayerLoopSystem? IGGLPDJGCPD, PlayerLoopSystem? BGIEFPMPKFA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class CGKDDBGENCK
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum IPOJKDAMNEL
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
	public class OEHPDKOEHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly IPOJKDAMNEL GALDFDFAFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly KMNIHDIGGOO GDFODEMCLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long BLIELNJAJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long PPAFBMEEHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long HOANBBNNJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int JKOEIBAAKEH;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5153E00", Offset = "0x5152E00", VA = "0x185153E00")]
		public OEHPDKOEHEA(IPOJKDAMNEL MOEOCHECCJG, int EPJFKPAKNPD = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5153B30", Offset = "0x5152B30", VA = "0x185153B30")]
		public void FCBOKGDADMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5153BA0", Offset = "0x5152BA0", VA = "0x185153BA0")]
		public void OLJLFHLJAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5153C00", Offset = "0x5152C00", VA = "0x185153C00")]
		public void PPHHBOMFMPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static IPOJKDAMNEL[] FNHKIOAAPKN;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static OEHPDKOEHEA[] ICPPAAPHEBJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x513F5B0", Offset = "0x513E5B0", VA = "0x18513F5B0")]
	public static OEHPDKOEHEA CFPJEJFKFLM(IPOJKDAMNEL CDBHHMNALJL, int EPJFKPAKNPD = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x513F840", Offset = "0x513E840", VA = "0x18513F840")]
	public static OEHPDKOEHEA LMFLOPNNBFA(IPOJKDAMNEL CDBHHMNALJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x513F790", Offset = "0x513E790", VA = "0x18513F790")]
	public static void HLGIICLFCAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HBFLENHGFMB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private interface FINIMPCECLK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KODABCMCLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OHNMHKDFAKC();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private abstract class PDMOEFKIMAO<TPromise, TMainThreadPromise> : FINIMPCECLK where TPromise : FHJJKILLDME where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TPromise HBJLHMDDNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly TMainThreadPromise PMELELPFPMA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise DMAIFKPDDIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x32DD730", Offset = "0x32DC730", VA = "0x1832DD730")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KODABCMCLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x32DD6E0", Offset = "0x32DC6E0", VA = "0x1832DD6E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E2BCA0", Offset = "0x1E2ACA0", VA = "0x181E2BCA0")]
		protected PDMOEFKIMAO(TPromise HBJLHMDDNMH, TMainThreadPromise HGDMAABKGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x32DD790", Offset = "0x32DC790", VA = "0x1832DD790", Slot = "5")]
		public void OHNMHKDFAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void GJKHBIMOJEM(TPromise HBJLHMDDNMH);
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class GCLPDBNICJM<T> : PDMOEFKIMAO<LJAJHHFEMAM<T>, BIMBCAIOAGD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2C87300", Offset = "0x2C86300", VA = "0x182C87300")]
		public GCLPDBNICJM(LJAJHHFEMAM<T> HBJLHMDDNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2C87100", Offset = "0x2C86100", VA = "0x182C87100", Slot = "6")]
		protected override void GJKHBIMOJEM(LJAJHHFEMAM<T> HBJLHMDDNMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2C870D0", Offset = "0x2C860D0", VA = "0x182C870D0")]
		[CompilerGenerated]
		private void CHDJJMDDBHF(T MLAOHBBKEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1365290", Offset = "0x1364290", VA = "0x181365290")]
		[CompilerGenerated]
		private void EPJAEPAOBIO(string NAFECGLLOCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class DAEPDNGBAGB : FINIMPCECLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Action NPNCNABHINE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KODABCMCLPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
		public DAEPDNGBAGB(Action NPNCNABHINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x948240", Offset = "0x947240", VA = "0x180948240", Slot = "5")]
		public void OHNMHKDFAKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<FINIMPCECLK> ELEFCHJGDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29697B0", Offset = "0x29687B0", VA = "0x1829697B0")]
	public static LJAJHHFEMAM<T> PLCAMFOIJHO<T>(this LJAJHHFEMAM<T> HBJLHMDDNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5148660", Offset = "0x5147660", VA = "0x185148660")]
	public static void PLCAMFOIJHO(Action NPNCNABHINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29696F0", Offset = "0x29686F0", VA = "0x1829696F0")]
	private static LJAJHHFEMAM<T> PDNHMIDMCKK<T>(LJAJHHFEMAM<T> HBJLHMDDNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5148090", Offset = "0x5147090", VA = "0x185148090")]
	private static void FIMLANIBBGG(FINIMPCECLK JGCINJKDFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5148290", Offset = "0x5147290", VA = "0x185148290")]
	private static void MMDDOGPPDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5147F90", Offset = "0x5146F90", VA = "0x185147F90")]
	private static void DOCIPANCMPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5148590", Offset = "0x5147590", VA = "0x185148590")]
	private static void NECKCPEIEEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JEAKBNFAMNI
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct MCDOJGCLKIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<Scene> CGEKFHEKGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string PBKPNMBFKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly LoadSceneMode KNFNCCBJDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool IKJLNNNBEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x514F920", Offset = "0x514E920", VA = "0x18514F920")]
		public MCDOJGCLKIG(TaskCompletionSource<Scene> MLEHDPAHMOH, string PBKPNMBFKAM, LoadSceneMode KNFNCCBJDJM, bool IKJLNNNBEMG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OMLCEKPLHDM : IAsyncStateMachine
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
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GLHOFFEBKJL<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private KNFCNAAJFDG <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private MCDOJGCLKIG <queuedSceneLoad>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OMLCEKPLHDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5154600", Offset = "0x5153600", VA = "0x185154600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class JHPHIKJOJGF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JHPHIKJOJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x514DE60", Offset = "0x514CE60", VA = "0x18514DE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class BEOBLDDONCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private MCDOJGCLKIG <dequeued>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BEOBLDDONCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x513BD40", Offset = "0x513AD40", VA = "0x18513BD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JAIHJCNKNBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public BIMBCAIOAGD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public JAIHJCNKNBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x514B990", Offset = "0x514A990", VA = "0x18514B990")]
		internal void MJCKOEDKGAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class GLFGINHMKDL : IAsyncStateMachine
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
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private JAIHJCNKNBJ <>8__2;

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
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public GLFGINHMKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x51474C0", Offset = "0x51464C0", VA = "0x1851474C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class OINGKEGJFCA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public OINGKEGJFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5154110", Offset = "0x5153110", VA = "0x185154110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LNGLPCGBHPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public GLHOFFEBKJL<string>.OADOKMKENLA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private GLHOFFEBKJL<string>.OADOKMKENLA <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LNGLPCGBHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x514EC20", Offset = "0x514DC20", VA = "0x18514EC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class DCNLHKAOEII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public DCNLHKAOEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5145830", Offset = "0x5144830", VA = "0x185145830")]
		internal bool KIHCOJDMCFK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class IBDDLNHNKFI : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public JIPDPKKGEMC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DCNLHKAOEII <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public IBDDLNHNKFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x514B390", Offset = "0x514A390", VA = "0x18514B390", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x514AFD0", Offset = "0x5149FD0", VA = "0x18514AFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x514AF80", Offset = "0x5149F80", VA = "0x18514AF80")]
		private void JIJNIFIPMPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x514B350", Offset = "0x514A350", VA = "0x18514B350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class CDDILDDMOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public BIMBCAIOAGD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CDDILDDMOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x513F280", Offset = "0x513E280", VA = "0x18513F280")]
		internal bool PBMEHPOFNOK(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x513F010", Offset = "0x513E010", VA = "0x18513F010")]
		internal void CNFIFGHPMLG(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BFLOGANOMBH : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BIMBCAIOAGD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private CDDILDDMOHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public BFLOGANOMBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x513DAB0", Offset = "0x513CAB0", VA = "0x18513DAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x513E2E0", Offset = "0x513D2E0", VA = "0x18513E2E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ICollection<string> EEHEFHMKDJM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static FHJJKILLDME BJEMLIPNDEO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AsyncOperation HNOHBDHKGHO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static FHJJKILLDME ANJABOOKGHN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static string CMDNPMAEMPF;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ThreadPriority NIJBCNMAALC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task INKKKBCAIOD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static List<SceneInstance> JOHBJLLNFDO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Queue<MCDOJGCLKIG> BMJDIJBGDEO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Task GGOACMNHABJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool CKFNAHNMGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x514CFF0", Offset = "0x514BFF0", VA = "0x18514CFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool BPHKEFIJLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x514C720", Offset = "0x514B720", VA = "0x18514C720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool IPMDMHIMHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x514D270", Offset = "0x514C270", VA = "0x18514D270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool JGEGILDDOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x514C8D0", Offset = "0x514B8D0", VA = "0x18514C8D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CCCENHPAPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x514C980", Offset = "0x514B980", VA = "0x18514C980")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x514CDF0", Offset = "0x514BDF0", VA = "0x18514CDF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x514C650", Offset = "0x514B650", VA = "0x18514C650")]
	[PPMJBBHKDPA(BIABBNOAALP.EnteredEditModeNextFrame, 0)]
	private static void FJAJIFGKNJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x514BEB0", Offset = "0x514AEB0", VA = "0x18514BEB0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OMLCEKPLHDM))]
	public static Task<Scene> AKPFAMMELFL(string PBKPNMBFKAM, LoadSceneMode KNFNCCBJDJM = LoadSceneMode.Single, bool IKJLNNNBEMG = false, [Optional] GLHOFFEBKJL<string>.OADOKMKENLA OJFDHJGECME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x514CEF0", Offset = "0x514BEF0", VA = "0x18514CEF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JHPHIKJOJGF))]
	private static Task MBLEENKKKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x514C0F0", Offset = "0x514B0F0", VA = "0x18514C0F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BEOBLDDONCB))]
	private static Task CIFOCOLFHJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x514D330", Offset = "0x514C330", VA = "0x18514D330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GLFGINHMKDL))]
	private static Task<Scene> OCMLOMANDOH(string PBKPNMBFKAM, LoadSceneMode KNFNCCBJDJM, bool IKJLNNNBEMG, GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x514C1F0", Offset = "0x514B1F0", VA = "0x18514C1F0")]
	private static void CLIPMILKFAI(SceneInstance CKGLHMMPGOL, LoadSceneMode KNFNCCBJDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x514C5B0", Offset = "0x514B5B0", VA = "0x18514C5B0")]
	private static void FIIPHPNEHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x514CC90", Offset = "0x514BC90", VA = "0x18514CC90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OINGKEGJFCA))]
	private static Task<Scene> KJODBNHPHIN(string PBKPNMBFKAM, LoadSceneMode KNFNCCBJDJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x514C7E0", Offset = "0x514B7E0", VA = "0x18514C7E0")]
	private static bool GBOBPEBMHDE(string PBKPNMBFKAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x514BB70", Offset = "0x514AB70", VA = "0x18514BB70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNGLPCGBHPE))]
	private static Task<Scene> AFDLNGLNPML(GLHOFFEBKJL<string>.OADOKMKENLA NMPIFEOKAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x514BCC0", Offset = "0x514ACC0", VA = "0x18514BCC0")]
	public static LJAJHHFEMAM<Scene> AHJCCOJMIKC(string PBKPNMBFKAM, LoadSceneMode KNFNCCBJDJM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x514C2E0", Offset = "0x514B2E0", VA = "0x18514C2E0")]
	public static FHJJKILLDME EGKDLEEHDAM(string PBKPNMBFKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x514C060", Offset = "0x514B060", VA = "0x18514C060")]
	[IteratorStateMachine(typeof(IBDDLNHNKFI))]
	private static IEnumerator<KNGCLBDEHMD> BFLHCJOBHND(string PBKPNMBFKAM, JIPDPKKGEMC COAEFBEPNFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x514CA80", Offset = "0x514BA80", VA = "0x18514CA80")]
	[IteratorStateMachine(typeof(BFLOGANOMBH))]
	private static IEnumerator<KNGCLBDEHMD> KCCFBLOGMFJ(string PBKPNMBFKAM, LoadSceneMode KNFNCCBJDJM, BIMBCAIOAGD<Scene> COAEFBEPNFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x514CB20", Offset = "0x514BB20", VA = "0x18514CB20")]
	public static bool KFCKHHIKDDD(out string AEJLGGNAHBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class KMNIHDIGGOO : OLJEJILANOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int ELPEJBJLEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Queue<double> BAGDKNFINEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private double BEMEKAFAHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double OPMIDBCHPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double BDJICGAOCBO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double PBPMNINBKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x514E6F0", Offset = "0x514D6F0", VA = "0x18514E6F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double PFBNCDDECOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x162E350", Offset = "0x162D350", VA = "0x18162E350", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double OOPCKKHMLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3E51700", Offset = "0x3E50700", VA = "0x183E51700", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x514E900", Offset = "0x514D900", VA = "0x18514E900")]
	public KMNIHDIGGOO(int ELLHBBEEBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x514E7D0", Offset = "0x514D7D0", VA = "0x18514E7D0", Slot = "7")]
	public void ONODPIKPHIL(double PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x514E760", Offset = "0x514D760", VA = "0x18514E760", Slot = "8")]
	public void OMJIIKCHOAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class PMDJOOGPCMO : OLJEJILANOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private long PFDGPOIGHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double MLCODGJDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double NEEGBOAFEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double MGGOOCDLAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private double PNNJADEKLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private double BEMEKAFAHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private double OPMIDBCHPFD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA1FB30", Offset = "0xA1EB30", VA = "0x180A1FB30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double PFBNCDDECOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x51567D0", Offset = "0x51557D0", VA = "0x1851567D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double OOPCKKHMLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x51567E0", Offset = "0x51557E0", VA = "0x1851567E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double HKKFGDGJJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x51567C0", Offset = "0x51557C0", VA = "0x1851567C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double PBPMNINBKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x51567B0", Offset = "0x51557B0", VA = "0x1851567B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5156830", Offset = "0x5155830", VA = "0x185156830", Slot = "7")]
	public virtual void ONODPIKPHIL(double PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x51567F0", Offset = "0x51557F0", VA = "0x1851567F0", Slot = "8")]
	public virtual void OMJIIKCHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x513F480", Offset = "0x513E480", VA = "0x18513F480")]
	public PMDJOOGPCMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class CFBMKFEAOMD : PMDJOOGPCMO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double LCGAPHHCJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x427D4D0", Offset = "0x427C4D0", VA = "0x18427D4D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x427D4E0", Offset = "0x427C4E0", VA = "0x18427D4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x513F340", Offset = "0x513E340", VA = "0x18513F340", Slot = "7")]
	public override void ONODPIKPHIL(double PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x513F300", Offset = "0x513E300", VA = "0x18513F300", Slot = "8")]
	public override void OMJIIKCHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x513F480", Offset = "0x513E480", VA = "0x18513F480")]
	public CFBMKFEAOMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface OLJEJILANOM
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double PBPMNINBKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double PFBNCDDECOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double OOPCKKHMLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class IBDABPBLOCA : IPCBBHJJGBD
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float KFJKJEBKJNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x514AF50", Offset = "0x5149F50", VA = "0x18514AF50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float PNOHBAEJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x514AED0", Offset = "0x5149ED0", VA = "0x18514AED0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double JIGMIGLILGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x514AF60", Offset = "0x5149F60", VA = "0x18514AF60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x514AEE0", Offset = "0x5149EE0", VA = "0x18514AEE0")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	[Preserve]
	internal IBDABPBLOCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class HFCOOGBBIAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KFJECPIJPND : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public HFCOOGBBIAJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public KFJECPIJPND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x514E1A0", Offset = "0x514D1A0", VA = "0x18514E1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x514E240", Offset = "0x514D240", VA = "0x18514E240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private HLPOIIAFIGC DICOMABKEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private MonoBehaviour HKPIJEMAGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action DHMIBILCIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Action<float> FKMMOCPGKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float HINFGLFEGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool NCOHILCNNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly OGKJIMKMPEO IMKCGOMNNLN;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5149C90", Offset = "0x5148C90", VA = "0x185149C90")]
	public HFCOOGBBIAJ(MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5149E90", Offset = "0x5148E90", VA = "0x185149E90")]
	public HFCOOGBBIAJ(MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x514A0D0", Offset = "0x51490D0", VA = "0x18514A0D0")]
	public HFCOOGBBIAJ(MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x400BD70", Offset = "0x400AD70", VA = "0x18400BD70")]
	private HFCOOGBBIAJ(OGKJIMKMPEO IMKCGOMNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5149320", Offset = "0x5148320", VA = "0x185149320")]
	internal static HFCOOGBBIAJ FDOHEEFGAMC(MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x51497C0", Offset = "0x51487C0", VA = "0x1851497C0")]
	private void OFMDBLBBEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5149AE0", Offset = "0x5148AE0", VA = "0x185149AE0")]
	private void PGHCAJNALBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5149930", Offset = "0x5148930", VA = "0x185149930")]
	private void OPDGDCJBEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x51490F0", Offset = "0x51480F0", VA = "0x1851490F0")]
	private void DLAHNCCBEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x51494D0", Offset = "0x51484D0", VA = "0x1851494D0")]
	private void HBHIOCBBEBG(string NAFECGLLOCD, Action POFHBAANBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5149610", Offset = "0x5148610", VA = "0x185149610")]
	[IteratorStateMachine(typeof(KFJECPIJPND))]
	private IEnumerator<KNGCLBDEHMD> IIBICCHHOHF(Action POFHBAANBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x51492C0", Offset = "0x51482C0", VA = "0x1851492C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5149730", Offset = "0x5148730", VA = "0x185149730")]
	[CompilerGenerated]
	private void OCOFEIKEDAD(string LDCEOCMADFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5149060", Offset = "0x5148060", VA = "0x185149060")]
	[CompilerGenerated]
	private void ALJCLKGCFEH(string LDCEOCMADFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x51496A0", Offset = "0x51486A0", VA = "0x1851496A0")]
	[CompilerGenerated]
	private void MFOJIHPIONH(string LDCEOCMADFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5149440", Offset = "0x5148440", VA = "0x185149440")]
	[CompilerGenerated]
	private void GPGAHOGEDHE(string LDCEOCMADFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct JEIJMEMPHGF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ReadOnly]
	public float PDIEOBELLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	public int FAOFJJLJNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<int> LGIEIGALOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<int> CPOGLFICFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeArray<int> ACNMNIGMNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	public NativeArray<AIOMIHOONPA> PMNDCBABNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	public NativeArray<float> BGMACLKBPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[WriteOnly]
	public NativeArray<int> MBLEEEAANGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[WriteOnly]
	public NativeArray<int> JAHLDEEDJDO;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x514D7B0", Offset = "0x514C7B0", VA = "0x18514D7B0")]
	public static JEIJMEMPHGF GGPPECCFBMF(int BLHLIPLJALP, float ODGMAFGIDPK, NativeArray<AIOMIHOONPA> AGMBPOKEBNH, NativeArray<float> GJGIJHOKCNF, NativeArray<int> JPBNCGALLJE, NativeArray<int> KFEMELOBFPH, NativeArray<int> PPKFFNDLNOD, NativeArray<int> CPOGLFICFIJ, NativeArray<int> ACNMNIGMNKI)
	{
		return default(JEIJMEMPHGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x514D6D0", Offset = "0x514C6D0", VA = "0x18514D6D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x514D660", Offset = "0x514C660", VA = "0x18514D660")]
	private bool DABNLGINNLA(int EJNMEMKEIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x514D6A0", Offset = "0x514C6A0", VA = "0x18514D6A0")]
	private void DNLLBDBLPKF(NativeArray<int> DGNIOJAGELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x514DB40", Offset = "0x514CB40", VA = "0x18514DB40")]
	private int OMKBEKGILNG(int LHDPPIALIBN, int FOLFHJONFOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x514D860", Offset = "0x514C860", VA = "0x18514D860")]
	private void KCOJPCEANJO(NativeArray<int> DGNIOJAGELE, int ICIDIOBNBOF, int LGPLIEDGINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x514D930", Offset = "0x514C930", VA = "0x18514D930")]
	private void NCGONCFEIBN(NativeArray<int> DGNIOJAGELE, int EAAMKEGEAAL, int GDIGKOBODLJ, int OJMJMKCACFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KMJADCOGBCP : GGCLEJFAABA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float KLHELBEBHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int EDBMOABHJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float CLBCBONLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly float[] MGFMFPKNHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int IHNEEKNJJFH;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x514E540", Offset = "0x514D540", VA = "0x18514E540")]
	public KMJADCOGBCP(Behaviour HBLIBBFCHOD, float NGOKAOIHJCE, int EDBMOABHJKK, [Optional] Action JEAOMBPKMMG, float CLBCBONLILA = 0f, [Optional] OGKJIMKMPEO IMKCGOMNNLN, [Optional] IPCBBHJJGBD CODOLHGBEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "9")]
	protected override bool JNDDAMHMAHC(Action NPNCNABHINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x514E310", Offset = "0x514D310", VA = "0x18514E310", Slot = "10")]
	protected override bool JAAMPKLIFFE(Action NPNCNABHINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x514E280", Offset = "0x514D280", VA = "0x18514E280")]
	private void CCPKKLOEEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class DADJBCBMDIJ : OGKJIMKMPEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NGCLAGDODPD HIPPJIDAPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly IPCBBHJJGBD CODOLHGBEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly DNOBMEPMBIP OFMLNBHDFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private BFBKONPADHD[] OBGIAIAFCAG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static OGKJIMKMPEO PCFKPPACGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5144050", Offset = "0x5143050", VA = "0x185144050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool HFIGPCOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FMDGDHGGIHP.FCICHGPMJMF AJIDAKMHFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FMDGDHGGIHP.FCICHGPMJMF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4D660", Offset = "0xA4C660", VA = "0x180A4D660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IPCBBHJJGBD IBMGLEFJAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x51449F0", Offset = "0x51439F0", VA = "0x1851449F0")]
	public static HLPOIIAFIGC OPOFEKHKPBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5144A80", Offset = "0x5143A80", VA = "0x185144A80")]
	[Preserve]
	protected DADJBCBMDIJ([KMDNJCFAMOJ(null)] NGCLAGDODPD HIPPJIDAPBC, [KMDNJCFAMOJ(null)] IPCBBHJJGBD CODOLHGBEDI, [KMDNJCFAMOJ(null)] DNOBMEPMBIP OFMLNBHDFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51442F0", Offset = "0x51432F0", VA = "0x1851442F0", Slot = "6")]
	public HLPOIIAFIGC ICIKLLEKAKC(IEnumerator<KNGCLBDEHMD> PKEMFJMACCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x51440C0", Offset = "0x51430C0", VA = "0x1851440C0", Slot = "7")]
	public HLPOIIAFIGC ICIKLLEKAKC(Behaviour HBLIBBFCHOD, IEnumerator<KNGCLBDEHMD> PKEMFJMACCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract HLPOIIAFIGC MJGGGKLMECF(AJGKJIHECLA HBLIBBFCHOD, IEnumerator<KNGCLBDEHMD> PKEMFJMACCH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5144810", Offset = "0x5143810", VA = "0x185144810", Slot = "13")]
	public virtual void OMJIIKCHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5144790", Offset = "0x5143790", VA = "0x185144790", Slot = "9")]
	public void MLKCDCGFIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C38EC0", Offset = "0x1C37EC0", VA = "0x181C38EC0", Slot = "14")]
	protected virtual void IAKPNNGGIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5143C70", Offset = "0x5142C70", VA = "0x185143C70")]
	private void CFIKLBBAMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5143C90", Offset = "0x5142C90", VA = "0x185143C90")]
	private void CLOABJPMNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x51440A0", Offset = "0x51430A0", VA = "0x1851440A0")]
	private void FKCLEOPDOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5144300", Offset = "0x5143300", VA = "0x185144300")]
	private void IPGKMFGFMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5144030", Offset = "0x5143030", VA = "0x185144030")]
	private void EMOJFIFOOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5144530", Offset = "0x5143530", VA = "0x185144530")]
	private void KLMPOPBEHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x51447F0", Offset = "0x51437F0", VA = "0x1851447F0")]
	private void NNGKBCHLMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5144550", Offset = "0x5143550", VA = "0x185144550", Slot = "15")]
	public virtual void LPNGCNDFFGB(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5144320", Offset = "0x5143320", VA = "0x185144320")]
	private void JEENFNIGNEG(BFBKONPADHD DOLJLBBCGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x51444F0", Offset = "0x51434F0", VA = "0x1851444F0")]
	private BFBKONPADHD KIGBNCBDHOL(FMDGDHGGIHP.FCICHGPMJMF FLAJIGGIBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract FOGCNELEJHD DFBOLAFHOLA(IEnumerator<KNGCLBDEHMD> PKEMFJMACCH, Behaviour HKPIJEMAGKJ, GKKDCOEHLPP HILJLMMDODE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract BFBKONPADHD JJALAKNKFLL(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5143CB0", Offset = "0x5142CB0", VA = "0x185143CB0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class CANCJKAGPIA : DADJBCBMDIJ, OGKJIMKMPEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NMBEPHPGCLL[] DFCLIOJNPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private CPOLCLKDNGM NCPANGOMMNL;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x513E740", Offset = "0x513D740", VA = "0x18513E740")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x513EF40", Offset = "0x513DF40", VA = "0x18513EF40")]
	[Preserve]
	public CANCJKAGPIA([KMDNJCFAMOJ(null)] NGCLAGDODPD HIPPJIDAPBC, [KMDNJCFAMOJ(null)] IPCBBHJJGBD CODOLHGBEDI, [KMDNJCFAMOJ(null)] DNOBMEPMBIP OFMLNBHDFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x513EB10", Offset = "0x513DB10", VA = "0x18513EB10", Slot = "12")]
	public override HLPOIIAFIGC MJGGGKLMECF(AJGKJIHECLA HBLIBBFCHOD, IEnumerator<KNGCLBDEHMD> PKEMFJMACCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x513EC60", Offset = "0x513DC60", VA = "0x18513EC60", Slot = "13")]
	public override void OMJIIKCHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x513E940", Offset = "0x513D940", VA = "0x18513E940", Slot = "15")]
	public override void LPNGCNDFFGB(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x513E7F0", Offset = "0x513D7F0", VA = "0x18513E7F0", Slot = "14")]
	protected override void IAKPNNGGIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x513E7B0", Offset = "0x513D7B0", VA = "0x18513E7B0")]
	private NMBEPHPGCLL GBFPODKGBGF(FMDGDHGGIHP.FCICHGPMJMF FLAJIGGIBOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x513E440", Offset = "0x513D440", VA = "0x18513E440", Slot = "16")]
	internal override FOGCNELEJHD DFBOLAFHOLA(IEnumerator<KNGCLBDEHMD> PKEMFJMACCH, Behaviour HBLIBBFCHOD, GKKDCOEHLPP EPKNGPIMMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x513E8D0", Offset = "0x513D8D0", VA = "0x18513E8D0", Slot = "17")]
	internal override BFBKONPADHD JJALAKNKFLL(FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x513E5B0", Offset = "0x513D5B0", VA = "0x18513E5B0")]
	private void DFJENPCOAEI(NMBEPHPGCLL DOLJLBBCGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x513E6D0", Offset = "0x513D6D0", VA = "0x18513E6D0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class EKAKPGFPOFF
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class CFEJABCJHLH : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public FMDGDHGGIHP.FCICHGPMJMF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public CFEJABCJHLH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x513F4C0", Offset = "0x513E4C0", VA = "0x18513F4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x513F570", Offset = "0x513E570", VA = "0x18513F570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5146320", Offset = "0x5145320", VA = "0x185146320")]
	[IteratorStateMachine(typeof(CFEJABCJHLH))]
	private static IEnumerator<KNGCLBDEHMD> FDFIHLHPIPP(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, Func<bool> DPPDDDFEPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5146210", Offset = "0x5145210", VA = "0x185146210")]
	public static HLPOIIAFIGC DLCMFEGDJHE(this MonoBehaviour HKPIJEMAGKJ, Func<bool> DPPDDDFEPOI, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM = FMDGDHGGIHP.FCICHGPMJMF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FOGCNELEJHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly GKKDCOEHLPP EPKNGPIMMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly GFOJHGMHDIL HBLIBBFCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly bool OMAJBEJLIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private string OKONKHNEMOO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<KNGCLBDEHMD> ONCGMBEENIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KNGCLBDEHMD DMNKLAJLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KBAIGLLCPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x51468C0", Offset = "0x51458C0", VA = "0x1851468C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FHIJADBAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xB87710", Offset = "0xB86710", VA = "0x180B87710")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xB87720", Offset = "0xB86720", VA = "0x180B87720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5146740", Offset = "0x5145740", VA = "0x185146740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float FNFOCAPCEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xF9FE40", Offset = "0xF9EE40", VA = "0x180F9FE40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x17DFCC0", Offset = "0x17DECC0", VA = "0x1817DFCC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5146AA0", Offset = "0x5145AA0", VA = "0x185146AA0")]
	public FOGCNELEJHD(IEnumerator<KNGCLBDEHMD> IAHNKNAFEAH, GFOJHGMHDIL HBLIBBFCHOD, GKKDCOEHLPP EPKNGPIMMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x51464B0", Offset = "0x51454B0", VA = "0x1851464B0")]
	public KNGCLBDEHMD GLOAKIKAGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5146430", Offset = "0x5145430", VA = "0x185146430")]
	public bool GANOPBIICNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5146940", Offset = "0x5145940", VA = "0x185146940")]
	public void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x51469C0", Offset = "0x51459C0", VA = "0x1851469C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xE3C3A0", Offset = "0xE3B3A0", VA = "0x180E3C3A0")]
	[CompilerGenerated]
	private void NGBDNAIPFMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ONHGNGLAFBI
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class AJAOABLBDCL : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BJFNHLNBPDP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FMDGDHGGIHP.FCICHGPMJMF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public AJAOABLBDCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x513BA40", Offset = "0x513AA40", VA = "0x18513BA40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x513BAE0", Offset = "0x513AAE0", VA = "0x18513BAE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51551A0", Offset = "0x51541A0", VA = "0x1851551A0")]
	public static HLPOIIAFIGC OFMDBLBBEBP(float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x51552A0", Offset = "0x51542A0", VA = "0x1851552A0")]
	public static HLPOIIAFIGC OFMDBLBBEBP(MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5155080", Offset = "0x5154080", VA = "0x185155080")]
	public static HLPOIIAFIGC MPIICOEAPOK(MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5154EC0", Offset = "0x5153EC0", VA = "0x185154EC0")]
	public static HLPOIIAFIGC FLCCOHHJEKJ(AJGKJIHECLA HBLIBBFCHOD, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5154FD0", Offset = "0x5153FD0", VA = "0x185154FD0")]
	private static IEnumerator<KNGCLBDEHMD> LAIKKIFIKMC(IPCBBHJJGBD CODOLHGBEDI, float CMCCKAPPDBG, FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5154DB0", Offset = "0x5153DB0", VA = "0x185154DB0")]
	private static IEnumerator<KNGCLBDEHMD> BCBNJALHEDL(IPCBBHJJGBD CODOLHGBEDI, float CMCCKAPPDBG, FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5154E10", Offset = "0x5153E10", VA = "0x185154E10")]
	[IteratorStateMachine(typeof(AJAOABLBDCL))]
	private static IEnumerator<KNGCLBDEHMD> FIDCEMNCHDI(BJFNHLNBPDP HKPBKOHHOCB, float CMCCKAPPDBG, FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action<float> DHMIBILCIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface PCNONHGMBEE
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HACAJIGKMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JFBOLJGKFFP;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LMGGEGJKHDJ(bool CAMEGMHBOIN = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LMGGEGJKHDJ(Action NPNCNABHINE, bool CAMEGMHBOIN = false);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LIIECBMCCKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public static readonly LIIECBMCCKH PELFLFHGHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Action JFFFBEGIMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool PPEKOOOIOOG;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1C49640", Offset = "0x1C48640", VA = "0x181C49640")]
	public LIIECBMCCKH(Action JFFFBEGIMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x514EB00", Offset = "0x514DB00", VA = "0x18514EB00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface CJGFOJKNCGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OCEGDPAFAHK(UnityEngine.Object HBLIBBFCHOD, Action<T> HPGLJLEHBFD);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface EKLODKALGGI<T> : CJGFOJKNCGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HNJJHCMMCLI<T> : EKLODKALGGI<T>, CJGFOJKNCGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KOJCAHJHPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public HNJJHCMMCLI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public AKDCKAFOKIK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public KOJCAHJHPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x35F0490", Offset = "0x35EF490", VA = "0x1835F0490")]
		internal void KACKJNGPKBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static GameObject GMGHNCHLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<AKDCKAFOKIK<UnityEngine.Object, Action<T>>> GDDPGCNOMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private T IFCAFLFIMCL;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x115BD20", Offset = "0x115AD20", VA = "0x18115BD20", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x35183D0", Offset = "0x35173D0", VA = "0x1835183D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3518430", Offset = "0x3517430", VA = "0x183518430")]
	private static bool IFBACHCCNJB(T CDICEDNOPPN, T ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3518880", Offset = "0x3517880", VA = "0x183518880")]
	public HNJJHCMMCLI(T JADJKIBNHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x35184F0", Offset = "0x35174F0", VA = "0x1835184F0", Slot = "6")]
	public IDisposable OCEGDPAFAHK(UnityEngine.Object HBLIBBFCHOD, Action<T> HPGLJLEHBFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3517FE0", Offset = "0x3516FE0", VA = "0x183517FE0")]
	private void GMONPKHBAMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface CPOLCLKDNGM
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCEMNIINAID(string OKONKHNEMOO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHNAAIHEEIA();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class BMMOJAAPHKM : CPOLCLKDNGM
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
	public void GCEMNIINAID(string OKONKHNEMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
	public void KHNAAIHEEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public BMMOJAAPHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class MOOCHFOKJMN : GGCLEJFAABA
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CJDFPFPLABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public MOOCHFOKJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public CJDFPFPLABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x513BA10", Offset = "0x513AA10", VA = "0x18513BA10")]
		internal void NLLKEJEHINL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ABBGIGCDCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public MOOCHFOKJMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public ABBGIGCDCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x513BA10", Offset = "0x513AA10", VA = "0x18513BA10")]
		internal void NLBKCJLINAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly float CAABBNNGNLN;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x514B460", Offset = "0x514A460", VA = "0x18514B460")]
	public MOOCHFOKJMN(Behaviour HBLIBBFCHOD, float CAABBNNGNLN, [Optional] Action JEAOMBPKMMG, [Optional] OGKJIMKMPEO IMKCGOMNNLN, [Optional] IPCBBHJJGBD CODOLHGBEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5150500", Offset = "0x514F500", VA = "0x185150500", Slot = "9")]
	protected override bool JNDDAMHMAHC(Action NPNCNABHINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5150400", Offset = "0x514F400", VA = "0x185150400", Slot = "10")]
	protected override bool JAAMPKLIFFE(Action NPNCNABHINE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class HELCHCFHKJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GMJCGIMJGLD : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public HELCHCFHKJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public GMJCGIMJGLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5147EB0", Offset = "0x5146EB0", VA = "0x185147EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5147F50", Offset = "0x5146F50", VA = "0x185147F50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private HLPOIIAFIGC DICOMABKEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private AJGKJIHECLA HBLIBBFCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private Action<float> FKMMOCPGKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float HINFGLFEGBA;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5148E80", Offset = "0x5147E80", VA = "0x185148E80")]
	public HELCHCFHKJL(AJGKJIHECLA HBLIBBFCHOD, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5148CD0", Offset = "0x5147CD0", VA = "0x185148CD0")]
	private void OPDGDCJBEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5148900", Offset = "0x5147900", VA = "0x185148900")]
	private void HBHIOCBBEBG(string NAFECGLLOCD, Action POFHBAANBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5148A80", Offset = "0x5147A80", VA = "0x185148A80")]
	[IteratorStateMachine(typeof(GMJCGIMJGLD))]
	private IEnumerator<KNGCLBDEHMD> IIBICCHHOHF(Action POFHBAANBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x51488A0", Offset = "0x51478A0", VA = "0x1851488A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5148B10", Offset = "0x5147B10", VA = "0x185148B10")]
	[CompilerGenerated]
	private void JLPNDPFLGPN(string LDCEOCMADFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NMBEPHPGCLL
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct KLINMDAFCGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public OPNBMEPIJPF JKJLCOHIHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AJGKJIHECLA KCLBBEOMLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public GKKDCOEHLPP FEBIGFDMKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<KNGCLBDEHMD> ONCGMBEENIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public KNGCLBDEHMD DMNKLAJLAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AIOMIHOONPA JECKFOPKDAM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct JFCDFEPCNML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public FMDGDHGGIHP.FCICHGPMJMF BGOCMPPMGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<KLINMDAFCGC> OMIPGOBEDMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class NDPAODAKFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GKKDCOEHLPP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public NMBEPHPGCLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AJGKJIHECLA context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public OPNBMEPIJPF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AIOMIHOONPA coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KNGCLBDEHMD currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<KNGCLBDEHMD> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public NDPAODAKFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5150690", Offset = "0x514F690", VA = "0x185150690")]
		internal void JAOPGFPBHFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class BDMDALJDMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public OPNBMEPIJPF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public NMBEPHPGCLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public BDMDALJDMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x513BD00", Offset = "0x513AD00", VA = "0x18513BD00")]
		internal void KCNOODPILIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PNLLKDOHCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public OPNBMEPIJPF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public NMBEPHPGCLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public PNLLKDOHCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5156960", Offset = "0x5155960", VA = "0x185156960")]
		internal void IJHNNDFGPIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class LDOEEKABNBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public OPNBMEPIJPF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public NMBEPHPGCLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public LDOEEKABNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x514E9B0", Offset = "0x514D9B0", VA = "0x18514E9B0")]
		internal void EBOMJMPONIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const AIOMIHOONPA NOAGLBIFJFP = AIOMIHOONPA.Cancelled | AIOMIHOONPA.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] HIGKIHGBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<AIOMIHOONPA> FAHHONLIBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> HIDCOEOICDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> JAHLDEEDJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> IIGGKDNDKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> MBLEEEAANGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> JEJGKFAFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> MLKBDNJDDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private OPNBMEPIJPF[] PMADAIAGCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private GKKDCOEHLPP[] HPIDKEHEAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private AJGKJIHECLA[] IJCKMIJFPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<KNGCLBDEHMD>[] OBENCPPAFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KNGCLBDEHMD[] MBEINGGOJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int OPLLLCBOGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JEBBAFBPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int KGGMBPMLJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float DIIGEBCEJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JEIJMEMPHGF FIGDPCEGEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle JBENMMEAIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<OPNBMEPIJPF> APCIKLHKFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool NNJADJGGEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> JLBMHGOLFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> FENEJJFACCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool FDMGHEHJFLO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JFCDFEPCNML[] CEDDHCEAJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1056D10", Offset = "0x1055D10", VA = "0x181056D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x51532E0", Offset = "0x51522E0", VA = "0x1851532E0")]
	private static int PEDFKLLLNHD(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5153310", Offset = "0x5152310", VA = "0x185153310")]
	public NMBEPHPGCLL(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x51516B0", Offset = "0x51506B0", VA = "0x1851516B0")]
	private void ECDLHGMLFGE(ref int DEDABLBBCBD, int DDILFEHKFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5151530", Offset = "0x5150530", VA = "0x185151530")]
	public void CFHDPNPNMJK(AJGKJIHECLA HBLIBBFCHOD, KNGCLBDEHMD OELKLHMILJG, IEnumerator<KNGCLBDEHMD> IAHNKNAFEAH, GKKDCOEHLPP EPKNGPIMMHD, [Optional] OPNBMEPIJPF FALFGBDIEAB, AIOMIHOONPA CIHOFFOAOFJ = AIOMIHOONPA.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5152180", Offset = "0x5151180", VA = "0x185152180")]
	public void GPEMHCPBCGJ(IEnumerable<KLINMDAFCGC> EDCFCHJPEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5152D80", Offset = "0x5151D80", VA = "0x185152D80")]
	private KLINMDAFCGC NPIMPGFGDEH(int OOEBMFCCMMK)
	{
		return default(KLINMDAFCGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5151B00", Offset = "0x5150B00", VA = "0x185151B00")]
	private void ENKKMMFNBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3121780", Offset = "0x3120780", VA = "0x183121780")]
	private static void PHJADDOHLCG<T>(int OOEBMFCCMMK, T[] IBBMHIEDBHK, int GFFJJOEGODF, [Optional] T CEBDMCOJFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3121760", Offset = "0x3120760", VA = "0x183121760")]
	private static void PHJADDOHLCG<T>(int OOEBMFCCMMK, NativeArray<T> IBBMHIEDBHK, int GFFJJOEGODF, [Optional] T CEBDMCOJFBN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5151EB0", Offset = "0x5150EB0", VA = "0x185151EB0")]
	private void FEBEMLPLPDO(IEnumerable<KLINMDAFCGC> EDCFCHJPEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5151230", Offset = "0x5150230", VA = "0x185151230")]
	private void BFJNBJADKKA(KLINMDAFCGC HOBDIBENBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5150F70", Offset = "0x514FF70", VA = "0x185150F70")]
	private ELAPKEPBDGD AFKNIPHADEJ(int EFKNEEEPDIC)
	{
		return default(ELAPKEPBDGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5151920", Offset = "0x5150920", VA = "0x185151920")]
	public void EGBKHKGEBOP(float ODGMAFGIDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x51518A0", Offset = "0x51508A0", VA = "0x1851518A0")]
	private void ECJMHFHIMEM(Action CDICEDNOPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5152BD0", Offset = "0x5151BD0", VA = "0x185152BD0")]
	private void NGDHCLBOKEN(Action CDICEDNOPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5152490", Offset = "0x5151490", VA = "0x185152490")]
	public void MCKBHLJGPGJ(float ODGMAFGIDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5151300", Offset = "0x5150300", VA = "0x185151300")]
	public void BHAMNPKBJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5152C50", Offset = "0x5151C50", VA = "0x185152C50")]
	public void NICHPHNHEPJ(OPNBMEPIJPF HKPBKOHHOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5152360", Offset = "0x5151360", VA = "0x185152360")]
	public void JDCFFOKEHGJ(OPNBMEPIJPF HKPBKOHHOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5151400", Offset = "0x5150400", VA = "0x185151400")]
	public void BMKFLIMAGJP(OPNBMEPIJPF HKPBKOHHOCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HGNDPPABELE : PCNONHGMBEE, IEnumerable<PCNONHGMBEE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly List<PCNONHGMBEE> FJPFEJOCLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool JKNDMCNEMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Action JEAOMBPKMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private bool JCOELDKKPLF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HACAJIGKMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x514A460", Offset = "0x5149460", VA = "0x18514A460", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JFBOLJGKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x514A320", Offset = "0x5149320", VA = "0x18514A320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x514A3C0", Offset = "0x51493C0", VA = "0x18514A3C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x514AC20", Offset = "0x5149C20", VA = "0x18514AC20")]
	public HGNDPPABELE([Optional] Action JEAOMBPKMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x514A780", Offset = "0x5149780", VA = "0x18514A780")]
	public void KKDPLFKFCJN(PCNONHGMBEE JOMPEEOFOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x514A620", Offset = "0x5149620", VA = "0x18514A620")]
	private void HHABIEGOKNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x514A8A0", Offset = "0x51498A0", VA = "0x18514A8A0", Slot = "7")]
	public bool LMGGEGJKHDJ(bool CAMEGMHBOIN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x514A8C0", Offset = "0x51498C0", VA = "0x18514A8C0", Slot = "8")]
	public bool LMGGEGJKHDJ(Action NPNCNABHINE, bool CAMEGMHBOIN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x514A5A0", Offset = "0x51495A0", VA = "0x18514A5A0", Slot = "9")]
	public IEnumerator<PCNONHGMBEE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x514ABA0", Offset = "0x5149BA0", VA = "0x18514ABA0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class GGCLEJFAABA : PCNONHGMBEE
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class LGCLPOIEKAK : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public GGCLEJFAABA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public LGCLPOIEKAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x514E9F0", Offset = "0x514D9F0", VA = "0x18514E9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x514EAC0", Offset = "0x514DAC0", VA = "0x18514EAC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly Behaviour HBLIBBFCHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly Action JEAOMBPKMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private BFCCHDPGONK HNGPPKDDIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly OGKJIMKMPEO IMKCGOMNNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	protected readonly IPCBBHJJGBD CODOLHGBEDI;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HACAJIGKMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xC29950", Offset = "0xC28950", VA = "0x180C29950", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action JFBOLJGKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5146FE0", Offset = "0x5145FE0", VA = "0x185146FE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5147080", Offset = "0x5146080", VA = "0x185147080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5147330", Offset = "0x5146330", VA = "0x185147330")]
	protected GGCLEJFAABA(Behaviour HBLIBBFCHOD, [Optional] Action JEAOMBPKMMG, [Optional] OGKJIMKMPEO IMKCGOMNNLN, [Optional] IPCBBHJJGBD CODOLHGBEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x51472D0", Offset = "0x51462D0", VA = "0x1851472D0", Slot = "7")]
	public bool LMGGEGJKHDJ(bool CAMEGMHBOIN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5147280", Offset = "0x5146280", VA = "0x185147280", Slot = "8")]
	public bool LMGGEGJKHDJ(Action NPNCNABHINE, bool CAMEGMHBOIN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JNDDAMHMAHC(Action NPNCNABHINE);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JAAMPKLIFFE(Action NPNCNABHINE);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x51471A0", Offset = "0x51461A0", VA = "0x1851471A0")]
	protected void FCMDKHODGPD(Action NPNCNABHINE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5146DE0", Offset = "0x5145DE0", VA = "0x185146DE0")]
	protected FHJJKILLDME BGFKBBKJFEL(float ICAMICGGEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x51471C0", Offset = "0x51461C0", VA = "0x1851471C0")]
	private void GMHKALECJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5147120", Offset = "0x5146120", VA = "0x185147120")]
	[IteratorStateMachine(typeof(LGCLPOIEKAK))]
	private IEnumerator<KNGCLBDEHMD> EKPCONFMMEH(float ICAMICGGEIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5147240", Offset = "0x5146240", VA = "0x185147240")]
	[CompilerGenerated]
	private void JILEHFJMCKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
internal enum AIOMIHOONPA : byte
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
internal class OPNBMEPIJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public NMBEPHPGCLL GHCABBOGFPP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int EHPNNEFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA4D660", Offset = "0xA4C660", VA = "0x180A4D660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x51554F0", Offset = "0x51544F0", VA = "0x1851554F0")]
	public static KNGCLBDEHMD GLOAKIKAGKN(IEnumerator<KNGCLBDEHMD> IAHNKNAFEAH, GKKDCOEHLPP EPKNGPIMMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x51556A0", Offset = "0x51546A0", VA = "0x1851556A0")]
	public KNGCLBDEHMD GLOAKIKAGKN(GKKDCOEHLPP[] HPIDKEHEAED, IEnumerator<KNGCLBDEHMD>[] EBAJJOGCPFP, KNGCLBDEHMD[] MDPHKLKLLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x51558C0", Offset = "0x51548C0", VA = "0x1851558C0")]
	public void NJEHLECEJBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5155780", Offset = "0x5154780", VA = "0x185155780")]
	public void KBAOLEOOAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x51553B0", Offset = "0x51543B0", VA = "0x1851553B0")]
	public void DKEFFGCPCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x51558C0", Offset = "0x51548C0", VA = "0x1851558C0")]
	public void NICHPHNHEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public OPNBMEPIJPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class LOJNGJGHJIC : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PBLLGBEICHO : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public LOJNGJGHJIC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public PBLLGBEICHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x51558F0", Offset = "0x51548F0", VA = "0x1851558F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x51559D0", Offset = "0x51549D0", VA = "0x1851559D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Action EHCLHDGJCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool GDJEDCJJAKH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KMMILJAOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4B0", Offset = "0xA4A4B0", VA = "0x180A4B4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x514F6C0", Offset = "0x514E6C0", VA = "0x18514F6C0")]
	public LOJNGJGHJIC(FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x514F5D0", Offset = "0x514E5D0", VA = "0x18514F5D0")]
	[IteratorStateMachine(typeof(PBLLGBEICHO))]
	private IEnumerator<KNGCLBDEHMD> KOEBAIIDNJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x514F640", Offset = "0x514E640", VA = "0x18514F640", Slot = "4")]
	public void OnCompleted(Action LJGOHJMDDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120")]
	public void OOPHNHDDMPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class PLIADIIADOL
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5156680", Offset = "0x5155680", VA = "0x185156680")]
	public static LOJNGJGHJIC CLBNKIPBPIG(this FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class CHEKDAPPEJK : DIOJCDHECGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly OGKJIMKMPEO IMKCGOMNNLN;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x513FAD0", Offset = "0x513EAD0", VA = "0x18513FAD0")]
	[OHDKPIIHCBL(BGEACDHIFOF.None)]
	private static void FHIGGLJNFIH(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	[Preserve]
	internal CHEKDAPPEJK([KMDNJCFAMOJ(null)] OGKJIMKMPEO IMKCGOMNNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x513FA30", Offset = "0x513EA30", VA = "0x18513FA30", Slot = "4")]
	public IDisposable DKNNNDALNJK(float CMCCKAPPDBG, Action<float> PAFCNGJPIGM, bool NCOHILCNNDG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum ELAPKEPBDGD : byte
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
internal sealed class BFBKONPADHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum CIKDKJODGFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct JPDNHJOLKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public FMDGDHGGIHP.FCICHGPMJMF BGOCMPPMGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public CIKDKJODGFG KOIOMNIDLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public List<FOGCNELEJHD> BBOLJGAKMCF;
	}

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static readonly CIKDKJODGFG[] LABMKHCGLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private bool JHAMLJPGALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly FOGCNELEJHD[] BBFIPEHEHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly List<FOGCNELEJHD> LMHGOFMFMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Stack<int> JKDGDNLFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly List<FOGCNELEJHD> CIPJJKGBAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Stack<int> NPGECEGDPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly CPOLCLKDNGM ICMIMOOHAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private bool FDMGHEHJFLO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JPDNHJOLKMN[,] AJHCFBGOEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x513D5E0", Offset = "0x513C5E0", VA = "0x18513D5E0")]
	public BFBKONPADHD(FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, CPOLCLKDNGM ICMIMOOHAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x513CD40", Offset = "0x513BD40", VA = "0x18513CD40")]
	public void LAJDAHDCGNK(FOGCNELEJHD IAHNKNAFEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x513D200", Offset = "0x513C200", VA = "0x18513D200")]
	public void PGHDBGGLFJK(IList<FOGCNELEJHD> EBAJJOGCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x513C210", Offset = "0x513B210", VA = "0x18513C210")]
	public void CIPJGCGLJFA(IList<FOGCNELEJHD> EBAJJOGCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x513C110", Offset = "0x513B110", VA = "0x18513C110")]
	private void BCOLKIPLMOL(FOGCNELEJHD IAHNKNAFEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x513D070", Offset = "0x513C070", VA = "0x18513D070")]
	private void NOAPAGOEEPL(IList<FOGCNELEJHD> EBAJJOGCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x513C750", Offset = "0x513B750", VA = "0x18513C750")]
	private ELAPKEPBDGD FBOBHANJGJO(FOGCNELEJHD IAHNKNAFEAH)
	{
		return default(ELAPKEPBDGD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x513CBF0", Offset = "0x513BBF0", VA = "0x18513CBF0")]
	public void IAKPNNGGIIJ(float ODGMAFGIDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x513CE60", Offset = "0x513BE60", VA = "0x18513CE60")]
	public void MLKCDCGFIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x513C8B0", Offset = "0x513B8B0", VA = "0x18513C8B0")]
	private void FOEEEHOENKD(List<FOGCNELEJHD> EBAJJOGCPFP, Stack<int> LLPLBLALMBI, bool FJKHIEAHENC, float NPECMLPHEHK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x513C610", Offset = "0x513B610", VA = "0x18513C610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x513C4E0", Offset = "0x513B4E0", VA = "0x18513C4E0")]
	private void CPDJIHNAOPO(List<FOGCNELEJHD> EBAJJOGCPFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class EJNGDJHLJDO : GFOJHGMHDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Behaviour HKPIJEMAGKJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5146160", Offset = "0x5145160", VA = "0x185146160", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EKIGGAAGMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5146100", Offset = "0x5145100", VA = "0x185146100", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GMDEGFKPMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x51461F0", Offset = "0x51451F0", VA = "0x1851461F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x934550", Offset = "0x933550", VA = "0x180934550")]
	public EJNGDJHLJDO(Behaviour HKPIJEMAGKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class IEKLIPHKFBN : GGCLEJFAABA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly float CAABBNNGNLN;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x514B460", Offset = "0x514A460", VA = "0x18514B460")]
	public IEKLIPHKFBN(Behaviour HBLIBBFCHOD, float CAABBNNGNLN, [Optional] Action JEAOMBPKMMG, [Optional] OGKJIMKMPEO IMKCGOMNNLN, [Optional] IPCBBHJJGBD CODOLHGBEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x84F1E0", Offset = "0x84E1E0", VA = "0x18084F1E0", Slot = "9")]
	protected override bool JNDDAMHMAHC(Action NPNCNABHINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x514B420", Offset = "0x514A420", VA = "0x18514B420", Slot = "10")]
	protected override bool JAAMPKLIFFE(Action NPNCNABHINE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class JCMLLBMFPBO
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x514BAF0", Offset = "0x514AAF0", VA = "0x18514BAF0")]
	public static IDisposable NJNNICHCHHD(this AJGKJIHECLA HBLIBBFCHOD, float CMCCKAPPDBG, Action<float> DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x514BA70", Offset = "0x514AA70", VA = "0x18514BA70")]
	public static IDisposable MMGDCCAEFJD(this AJGKJIHECLA HBLIBBFCHOD, Action<float> DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x514B9F0", Offset = "0x514A9F0", VA = "0x18514B9F0")]
	public static IDisposable LHNDGBOONEA(this AJGKJIHECLA HBLIBBFCHOD, Action<float> DHMIBILCIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class EGDGFKNCODE
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class FPAOADEKDKC : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public FMDGDHGGIHP.FCICHGPMJMF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private BDEEKEGAGKO <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public FPAOADEKDKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5146BB0", Offset = "0x5145BB0", VA = "0x185146BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5146C80", Offset = "0x5145C80", VA = "0x185146C80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class HBLJOGHGCJM : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public FMDGDHGGIHP.FCICHGPMJMF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private BDEEKEGAGKO <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public HBLJOGHGCJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5148770", Offset = "0x5147770", VA = "0x185148770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5148860", Offset = "0x5147860", VA = "0x185148860", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5145D90", Offset = "0x5144D90", VA = "0x185145D90")]
	public static HLPOIIAFIGC OFMDBLBBEBP(Action DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5145CD0", Offset = "0x5144CD0", VA = "0x185145CD0")]
	public static HLPOIIAFIGC OFMDBLBBEBP(Behaviour HBLIBBFCHOD, Action DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5145BC0", Offset = "0x5144BC0", VA = "0x185145BC0")]
	public static HLPOIIAFIGC OFMDBLBBEBP(Behaviour HBLIBBFCHOD, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5145AC0", Offset = "0x5144AC0", VA = "0x185145AC0")]
	[IteratorStateMachine(typeof(FPAOADEKDKC))]
	private static IEnumerator<KNGCLBDEHMD> LAIKKIFIKMC(FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5145B40", Offset = "0x5144B40", VA = "0x185145B40")]
	[IteratorStateMachine(typeof(HBLJOGHGCJM))]
	private static IEnumerator<KNGCLBDEHMD> LAIKKIFIKMC(FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action<float> DHMIBILCIEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class PDLCEJCADBM
{
	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5156350", Offset = "0x5155350", VA = "0x185156350")]
	public static IDisposable OFMDBLBBEBP(this MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x51562D0", Offset = "0x51552D0", VA = "0x1851562D0")]
	public static IDisposable OFMDBLBBEBP(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5156020", Offset = "0x5155020", VA = "0x185156020")]
	public static IDisposable IAKPNNGGIIJ(this MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5155DF0", Offset = "0x5154DF0", VA = "0x185155DF0")]
	public static IDisposable FKCLEOPDOMB(this MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5156090", Offset = "0x5155090", VA = "0x185156090")]
	public static IDisposable IPGKMFGFMLB(this MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5155BC0", Offset = "0x5154BC0", VA = "0x185155BC0")]
	public static IDisposable CPPMCHBHCIK(this MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5155D70", Offset = "0x5154D70", VA = "0x185155D70")]
	public static IDisposable FFMOPJJAPBK(this MonoBehaviour HKPIJEMAGKJ, Action DHMIBILCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5156230", Offset = "0x5155230", VA = "0x185156230")]
	public static IDisposable LNKEPDDGGJM(this MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5155A10", Offset = "0x5154A10", VA = "0x185155A10")]
	public static IDisposable AAMNMBKBAKC(this MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5155CD0", Offset = "0x5154CD0", VA = "0x185155CD0")]
	public static IDisposable DKNNNDALNJK(this MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5155B30", Offset = "0x5154B30", VA = "0x185155B30")]
	public static IDisposable CEJDHHNKMDJ(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5155C40", Offset = "0x5154C40", VA = "0x185155C40")]
	public static IDisposable DCOMABJLGKI(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5156110", Offset = "0x5155110", VA = "0x185156110")]
	public static IDisposable JGFNCKOPGPM(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5155E70", Offset = "0x5154E70", VA = "0x185155E70")]
	public static IDisposable GFBLADHIGMJ(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x51561A0", Offset = "0x51551A0", VA = "0x1851561A0")]
	public static IDisposable LNCDBFKOOML(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5155F90", Offset = "0x5154F90", VA = "0x185155F90")]
	public static IDisposable HAGJNAOKPOO(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5155F00", Offset = "0x5154F00", VA = "0x185155F00")]
	public static IDisposable GHLOAFPENIP(this MonoBehaviour HKPIJEMAGKJ, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x51563D0", Offset = "0x51553D0", VA = "0x1851563D0")]
	public static IDisposable OJNEDOOJIEM(this MonoBehaviour HKPIJEMAGKJ, float CMCCKAPPDBG, Action<float> DHMIBILCIEN, bool NCOHILCNNDG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class GKKDCOEHLPP : NMMDBNHKACP, HLPOIIAFIGC, BFCCHDPGONK, FHJJKILLDME, IEnumerator, KNGCLBDEHMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private FMDGDHGGIHP.FCICHGPMJMF KEABBOHBMLA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private FMDGDHGGIHP.FCICHGPMJMF HGCMGDLJDPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1520", Offset = "0x2DF0520", VA = "0x182DF1520", Slot = "23")]
		get
		{
			return default(FMDGDHGGIHP.FCICHGPMJMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FMDGDHGGIHP.FCICHGPMJMF GHCABBOGFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xADBD70", Offset = "0xADAD70", VA = "0x180ADBD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float HOHLOEGGPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA0C1F0", Offset = "0xA0B1F0", VA = "0x180A0C1F0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AEGKOLNHOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5147440", Offset = "0x5146440", VA = "0x185147440", Slot = "24")]
	private bool HFCMPJOFPPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5147430", Offset = "0x5146430", VA = "0x185147430", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5147460", Offset = "0x5146460", VA = "0x185147460")]
	public GKKDCOEHLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal interface GFOJHGMHDIL
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EKIGGAAGMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GMDEGFKPMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class DBKEJNFMPJG
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class NIFEJABPDBL : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public FMDGDHGGIHP.FCICHGPMJMF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public NIFEJABPDBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5150E70", Offset = "0x514FE70", VA = "0x185150E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5150F30", Offset = "0x514FF30", VA = "0x185150F30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class BKKDAIDJINH : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private KNGCLBDEHMD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public FMDGDHGGIHP.FCICHGPMJMF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private KNGCLBDEHMD <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
		[DebuggerHidden]
		public BKKDAIDJINH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x513E320", Offset = "0x513D320", VA = "0x18513E320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x513E400", Offset = "0x513D400", VA = "0x18513E400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x51453E0", Offset = "0x51443E0", VA = "0x1851453E0")]
	[IteratorStateMachine(typeof(NIFEJABPDBL))]
	private static IEnumerator<KNGCLBDEHMD> KOEBAIIDNJD(float PHEFFDENMLF, FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5144E30", Offset = "0x5143E30", VA = "0x185144E30")]
	[IteratorStateMachine(typeof(BKKDAIDJINH))]
	private static IEnumerator<KNGCLBDEHMD> BIPKALILJDG(float PHEFFDENMLF, FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5144F90", Offset = "0x5143F90", VA = "0x185144F90")]
	public static IDisposable FDCKOIFIGJB(this MonoBehaviour HKPIJEMAGKJ, float PHEFFDENMLF, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5145320", Offset = "0x5144320", VA = "0x185145320")]
	public static HLPOIIAFIGC KGLCDMDKIJJ(this MonoBehaviour HKPIJEMAGKJ, float PHEFFDENMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x51450B0", Offset = "0x51440B0", VA = "0x1851450B0")]
	public static HLPOIIAFIGC FDCKOIFIGJB(this MonoBehaviour HKPIJEMAGKJ, float PHEFFDENMLF, FMDGDHGGIHP.FCICHGPMJMF FKCHLLIHJNM, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5145740", Offset = "0x5144740", VA = "0x185145740")]
	public static HLPOIIAFIGC OKHPCEAKOKF(this MonoBehaviour HKPIJEMAGKJ, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x51451E0", Offset = "0x51441E0", VA = "0x1851451E0")]
	public static HLPOIIAFIGC HCHCOMPEEBJ(this MonoBehaviour HKPIJEMAGKJ, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5145240", Offset = "0x5144240", VA = "0x185145240")]
	public static HLPOIIAFIGC JOKHGAKEHMD(this MonoBehaviour HKPIJEMAGKJ, Action DGLOJMONMHM, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5145470", Offset = "0x5144470", VA = "0x185145470")]
	public static HLPOIIAFIGC LCMFBDBNABI(this MonoBehaviour HKPIJEMAGKJ, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5145710", Offset = "0x5144710", VA = "0x185145710")]
	public static HLPOIIAFIGC MPIMJCEJLKN(this MonoBehaviour HKPIJEMAGKJ, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5145210", Offset = "0x5144210", VA = "0x185145210")]
	public static HLPOIIAFIGC JGEMJAMOHMD(this MonoBehaviour HKPIJEMAGKJ, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5145760", Offset = "0x5144760", VA = "0x185145760")]
	private static HLPOIIAFIGC PCOFIDABNOM(MonoBehaviour HKPIJEMAGKJ, FMDGDHGGIHP.FCICHGPMJMF ELNGBAJNMDM, Action DGLOJMONMHM, [Optional] OGKJIMKMPEO IMKCGOMNNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5145640", Offset = "0x5144640", VA = "0x185145640")]
	public static HLPOIIAFIGC MIJCLHEBLIB(this MonoBehaviour HKPIJEMAGKJ, float NEHKOHNOJKM, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5144EC0", Offset = "0x5143EC0", VA = "0x185144EC0")]
	public static HLPOIIAFIGC FBJGJNDAFOC(this MonoBehaviour HKPIJEMAGKJ, float NEHKOHNOJKM, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5145570", Offset = "0x5144570", VA = "0x185145570")]
	public static HLPOIIAFIGC MFOJOFOJJPO(this MonoBehaviour HKPIJEMAGKJ, float NEHKOHNOJKM, Action DGLOJMONMHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x51454A0", Offset = "0x51444A0", VA = "0x1851454A0")]
	public static HLPOIIAFIGC LJFFCMCNIJF(this MonoBehaviour HKPIJEMAGKJ, float NEHKOHNOJKM, Action DGLOJMONMHM)
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

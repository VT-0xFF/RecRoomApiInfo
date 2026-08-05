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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> LGJNCCPGMHK(List<PlayerLoopSystem> CGJFCEBAMGP, int EAIBKGDJPAH);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct GCFADOOHKPB
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct PGFGENOFNKN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static CLOBMDANPDK HILPIFKOCGO;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x72DF910", Offset = "0x72DDF10", VA = "0x1872DF910")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct GINNBINDKPO
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static CLOBMDANPDK JLPJAFKDHOH;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x72CE600", Offset = "0x72CCC00", VA = "0x1872CE600")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct DPPMBGGHOHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static CLOBMDANPDK JGKPHPFOCED;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x72CD530", Offset = "0x72CBB30", VA = "0x1872CD530")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct BOFDKNCCLKL
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static CLOBMDANPDK NIIHKPAKAHM;

				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CLOBMDANPDK MBGJEGGMEJP;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CLOBMDANPDK CNBKDOGIMJM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CLOBMDANPDK EMNBMJNHLFO;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x72C8410", Offset = "0x72C6A10", VA = "0x1872C8410")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct ECLGEHILBPC
			{
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static CLOBMDANPDK DAEIAAKFAFL;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x72CD710", Offset = "0x72CBD10", VA = "0x1872CD710")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			public struct GICFFJAGGML
			{
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public static CLOBMDANPDK NIIHKPAKAHM;

				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CLOBMDANPDK MBGJEGGMEJP;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CLOBMDANPDK CNBKDOGIMJM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CLOBMDANPDK EMNBMJNHLFO;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x72CE330", Offset = "0x72CC930", VA = "0x1872CE330")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct PAMMKOLBCCI
			{
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static CLOBMDANPDK MMJEMCOPLLF;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x72DDB50", Offset = "0x72DC150", VA = "0x1872DDB50")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct FEBAFEICDBJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static CLOBMDANPDK MKPMEONLDEA;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x72CDF60", Offset = "0x72CC560", VA = "0x1872CDF60")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct PNMIGFDJEKB
			{
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static CLOBMDANPDK EMGJFCBDHEH;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x72E1620", Offset = "0x72DFC20", VA = "0x1872E1620")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct MPOJFENFFJF
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static CLOBMDANPDK MELDPLOKHPH;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x72DB9A0", Offset = "0x72D9FA0", VA = "0x1872DB9A0")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct PPACAAAAIEM
			{
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static CLOBMDANPDK GEJAJLGCHOI;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x72E1800", Offset = "0x72DFE00", VA = "0x1872E1800")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public struct EOAHNCGBFEB
			{
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static CLOBMDANPDK IOJFEEADMON;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x72CDD80", Offset = "0x72CC380", VA = "0x1872CDD80")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct HLLACMIKMAB
			{
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static CLOBMDANPDK FAMJNGEAMAF;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x72CF8D0", Offset = "0x72CDED0", VA = "0x1872CF8D0")]
				public static PlayerLoopSystem FHMNFKHBLKL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public enum JLLKMKKBKAH : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct IINCAAIKDFI
			{
				[Cpp2IlInjected.Token(Token = "0x2000021")]
				[CompilerGenerated]
				private sealed class EFCDPLDOEOM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public JLLKMKKBKAH updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
					public EFCDPLDOEOM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x72CD8F0", Offset = "0x72CBEF0", VA = "0x1872CD8F0")]
					internal void JGAGGNCIODL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static BEJAMOEFGKL<JLLKMKKBKAH> PEELHJEIHJE;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x72D2E80", Offset = "0x72D1480", VA = "0x1872D2E80")]
				public static PlayerLoopSystem FHMNFKHBLKL(JLLKMKKBKAH DOIEMKEENCG)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct EKAPFFCBONB
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class OJNOKNIIMCL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public BGFAJHGCHMD.ICGMOONEPFI key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
					public OJNOKNIIMCL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x72DD620", Offset = "0x72DBC20", VA = "0x1872DD620")]
					internal void OHFKPNJKGHL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public static IDisposable FOEOEDIBHDD;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x72CD970", Offset = "0x72CBF70", VA = "0x1872CD970")]
				public static PlayerLoopSystem DIELAJPCPEG(BGFAJHGCHMD.ICGMOONEPFI MNBFPOFIDHA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			internal struct KNLLHEHDMFG
			{
				[Cpp2IlInjected.Token(Token = "0x2000026")]
				[CompilerGenerated]
				private sealed class CDFBFJFONNF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public BGFAJHGCHMD.ICGMOONEPFI key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
					public CDFBFJFONNF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x72C8720", Offset = "0x72C6D20", VA = "0x1872C8720")]
					internal void OHFKPNJKGHL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x72D8EE0", Offset = "0x72D74E0", VA = "0x1872D8EE0")]
				public static PlayerLoopSystem DIELAJPCPEG(BGFAJHGCHMD.ICGMOONEPFI MNBFPOFIDHA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class HOHGJLNMECI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public HOHGJLNMECI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x72D2440", Offset = "0x72D0A40", VA = "0x1872D2440")]
			internal List<PlayerLoopSystem> AOKEDGEJEND(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool FKJPABJMEID;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool BIONIGJEKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x72C8F20", Offset = "0x72C7520", VA = "0x1872C8F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72C8F60", Offset = "0x72C7560", VA = "0x1872C8F60")]
		private static void GBLKBOCDGCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72CBEC0", Offset = "0x72CA4C0", VA = "0x1872CBEC0")]
		private static void PEBJCPEJEHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72C89D0", Offset = "0x72C6FD0", VA = "0x1872C89D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72CBC80", Offset = "0x72CA280", VA = "0x1872CBC80")]
		private static void PDFHEAEBOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72CBAC0", Offset = "0x72CA0C0", VA = "0x1872CBAC0")]
		private static void HJIFLMHJDCI(BGFAJHGCHMD.ICGMOONEPFI MNBFPOFIDHA, PlayerLoopSystem DLAJHIGFKPG, Type MMIGOJCENBM, Type PCPDDFABHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72C8B40", Offset = "0x72C7140", VA = "0x1872C8B40")]
		private static void FHCJAOGMBEB(PlayerLoopSystem DLAJHIGFKPG, Type MMIGOJCENBM, Type PCPDDFABHFD, LGJNCCPGMHK FBEKNCOCOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72C8A10", Offset = "0x72C7010", VA = "0x1872C8A10")]
		private static void FDNEFIOLFPF(PlayerLoopSystem DLAJHIGFKPG, Type MMIGOJCENBM, Type PCPDDFABHFD, PlayerLoopSystem? PLDLJINIGGI, PlayerLoopSystem? EACNOBMNHBE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BGFAJHGCHMD
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum ICGMOONEPFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JKFMAKPHEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly ICGMOONEPFI LHNAPDAJNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly LGFOEFOIINO MOBLHAAEMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private long EKHHPDFLEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long BNDGAFCKPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public long LKLALLLCNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int MJIODPHJKDB;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72D5D60", Offset = "0x72D4360", VA = "0x1872D5D60")]
		public JKFMAKPHEPK(ICGMOONEPFI FEPEKHBMIDM, int LPCNFDIJHPH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x72D5B10", Offset = "0x72D4110", VA = "0x1872D5B10")]
		public void LOIFJGIOMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72D5AC0", Offset = "0x72D40C0", VA = "0x1872D5AC0")]
		public void BHOFNPEMAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x72D5B80", Offset = "0x72D4180", VA = "0x1872D5B80")]
		public void PPMAODJILOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static ICGMOONEPFI[] NGIFBJPFEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static JKFMAKPHEPK[] AAAIOFBMOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x72C7100", Offset = "0x72C5700", VA = "0x1872C7100")]
	public static JKFMAKPHEPK LBJKPONEPFL(ICGMOONEPFI MNBFPOFIDHA, int LPCNFDIJHPH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72C7090", Offset = "0x72C5690", VA = "0x1872C7090")]
	public static JKFMAKPHEPK EOINIBNIDLD(ICGMOONEPFI MNBFPOFIDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x72C6FF0", Offset = "0x72C55F0", VA = "0x1872C6FF0")]
	public static void AOPNPFMBNLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LGFOEFOIINO : DPHDLMKNLJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int AAALPDPMJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Queue<double> DNCFFJJCPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private double OABIMBHOJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double DGMKDBICIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double BJEKIILGFJD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double ICLHDIJDHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72D9E50", Offset = "0x72D8450", VA = "0x1872D9E50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double DDCAEHJOPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1B66380", Offset = "0x1B64980", VA = "0x181B66380", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OEKJKHGKJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F80B40", Offset = "0x1F7F140", VA = "0x181F80B40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72D9EB0", Offset = "0x72D84B0", VA = "0x1872D9EB0")]
	public LGFOEFOIINO(int OKHPKFBMAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72D9D30", Offset = "0x72D8330", VA = "0x1872D9D30", Slot = "7")]
	public void KCPJMHAKODB(double GAELHANIPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72D9CC0", Offset = "0x72D82C0", VA = "0x1872D9CC0", Slot = "8")]
	public void BOPCGMPFNGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OBPNDMJHFCC : DPHDLMKNLJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private long FDDANCOAHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double EHOCCHPBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double MBIDLGEDNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double CGFDEDJENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double AEEJDBAKPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double OABIMBHOJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double DGMKDBICIEO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double DDCAEHJOPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B6D0", Offset = "0x5F49CD0", VA = "0x185F4B6D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OEKJKHGKJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B6E0", Offset = "0x5F49CE0", VA = "0x185F4B6E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double AMJKCFLNJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B690", Offset = "0x5F49C90", VA = "0x185F4B690")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double ICLHDIJDHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x25790E0", Offset = "0x25776E0", VA = "0x1825790E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72DC450", Offset = "0x72DAA50", VA = "0x1872DC450", Slot = "7")]
	public virtual void KCPJMHAKODB(double GAELHANIPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x72DC410", Offset = "0x72DAA10", VA = "0x1872DC410", Slot = "8")]
	public virtual void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x72D2860", Offset = "0x72D0E60", VA = "0x1872D2860")]
	public OBPNDMJHFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IHBPALAJGOA : OBPNDMJHFCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CGICGNAPDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B710", Offset = "0x5F49D10", VA = "0x185F4B710")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5F4B6C0", Offset = "0x5F49CC0", VA = "0x185F4B6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72D2730", Offset = "0x72D0D30", VA = "0x1872D2730", Slot = "7")]
	public override void KCPJMHAKODB(double GAELHANIPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72D26F0", Offset = "0x72D0CF0", VA = "0x1872D26F0", Slot = "8")]
	public override void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x72D2860", Offset = "0x72D0E60", VA = "0x1872D2860")]
	public IHBPALAJGOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface DPHDLMKNLJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double ICLHDIJDHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double DDCAEHJOPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OEKJKHGKJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class HAGCBOIGABA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private interface ANKEFJOFGME
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool FOCNGDCCILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FFGIMBFIPNG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private abstract class DMJMBMMOGNH<TPromise, TMainThreadPromise> : ANKEFJOFGME where TPromise : MKEIEIBMPOE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TPromise GNNDEPKCIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly TMainThreadPromise KILNDIHENCI;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise PFEEPPPEELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x587C360", Offset = "0x587A960", VA = "0x18587C360")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FOCNGDCCILL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x587C3C0", Offset = "0x587A9C0", VA = "0x18587C3C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
		protected DMJMBMMOGNH(TPromise GNNDEPKCIAB, TMainThreadPromise EEFBDMKELNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x587C340", Offset = "0x587A940", VA = "0x18587C340", Slot = "5")]
		public void FFGIMBFIPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EEAGGBEFBHE(TPromise GNNDEPKCIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class KBPDJDIKJNN<T> : DMJMBMMOGNH<DNKNPFLFPMI<T>, FLIBNLGBOAG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x41CAEA0", Offset = "0x41C94A0", VA = "0x1841CAEA0")]
		public KBPDJDIKJNN(DNKNPFLFPMI<T> GNNDEPKCIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x41CAC80", Offset = "0x41C9280", VA = "0x1841CAC80", Slot = "6")]
		protected override void EEAGGBEFBHE(DNKNPFLFPMI<T> GNNDEPKCIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8EC0", Offset = "0x3CB74C0", VA = "0x183CB8EC0")]
		[CompilerGenerated]
		private void BGOKNAKBKMB(T JKLHKLABFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x41CAC20", Offset = "0x41C9220", VA = "0x1841CAC20")]
		[CompilerGenerated]
		private void AMOGNOEFEBF(string BDGJCBKBDPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class GGEAJLJGGGM : ANKEFJOFGME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Action IJDJHMGAIOM;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool FOCNGDCCILL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
		public GGEAJLJGGGM(Action IJDJHMGAIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F4DA0", Offset = "0x9F33A0", VA = "0x1809F4DA0", Slot = "5")]
		public void FFGIMBFIPNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ANKEFJOFGME> CAEJANADMBM;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BBF0", Offset = "0x2B7A1F0", VA = "0x182B7BBF0")]
	public static DNKNPFLFPMI<T> OIBABCNFEMO<T>(this DNKNPFLFPMI<T> GNNDEPKCIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72CF330", Offset = "0x72CD930", VA = "0x1872CF330")]
	public static void OIBABCNFEMO(Action IJDJHMGAIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BB00", Offset = "0x2B7A100", VA = "0x182B7BB00")]
	private static DNKNPFLFPMI<T> BIADOKBPJNC<T>(DNKNPFLFPMI<T> GNNDEPKCIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72CF130", Offset = "0x72CD730", VA = "0x1872CF130")]
	private static void LBPDGKJOFMB(ANKEFJOFGME GCMFHCFHCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72CED50", Offset = "0x72CD350", VA = "0x1872CED50")]
	private static void EFGKEFJMEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72CF030", Offset = "0x72CD630", VA = "0x1872CF030")]
	private static void ENGBPHNDLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72CEC80", Offset = "0x72CD280", VA = "0x1872CEC80")]
	private static void EEAJDNACBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JKLACHNAOAH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private struct GBHKMCLKLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public TaskCompletionSource<Scene> HGKOAKLCDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly string FHGJMMBJGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly LoadSceneMode CBELDOIEFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly bool PONEJMNBEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72CE2D0", Offset = "0x72CC8D0", VA = "0x1872CE2D0")]
		public GBHKMCLKLHF(TaskCompletionSource<Scene> LPLEFMNFOII, string FHGJMMBJGMK, LoadSceneMode CBELDOIEFJP, bool PONEJMNBEPI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct BHBCFKMBKFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private NEGKJPNCLPM<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72C7470", Offset = "0x72C5A70", VA = "0x1872C7470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72C7D10", Offset = "0x72C6310", VA = "0x1872C7D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct MPFOHMNEFKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72DB630", Offset = "0x72D9C30", VA = "0x1872DB630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72DB940", Offset = "0x72D9F40", VA = "0x1872DB940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct LKGJIBAENNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private GBHKMCLKLHF <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72DA430", Offset = "0x72D8A30", VA = "0x1872DA430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72DA7E0", Offset = "0x72D8DE0", VA = "0x1872DA7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class JHKDLBHBDBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public FLIBNLGBOAG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JHKDLBHBDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x72D4EC0", Offset = "0x72D34C0", VA = "0x1872D4EC0")]
		internal void AANKBCGKMGB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KKKNIJGEGMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private JHKDLBHBDBO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x72D82D0", Offset = "0x72D68D0", VA = "0x1872D82D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x72D8E70", Offset = "0x72D7470", VA = "0x1872D8E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct JDCKNHBGIJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x72D3040", Offset = "0x72D1640", VA = "0x1872D3040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72D3510", Offset = "0x72D1B10", VA = "0x1872D3510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct LFCLCKFJBIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public NEGKJPNCLPM<string>.GBKOFALFHEN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private NEGKJPNCLPM<string>.GBKOFALFHEN <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72D9010", Offset = "0x72D7610", VA = "0x1872D9010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72D9B60", Offset = "0x72D8160", VA = "0x1872D9B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LOOIHMNOPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LOOIHMNOPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72DA920", Offset = "0x72D8F20", VA = "0x1872DA920")]
		internal bool OKMIMFOPNAL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GMDEJKMLPGM : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FILOAGJMCDA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public GMDEJKMLPGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72CEBB0", Offset = "0x72CD1B0", VA = "0x1872CEBB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72CE7E0", Offset = "0x72CCDE0", VA = "0x1872CE7E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72CEB10", Offset = "0x72CD110", VA = "0x1872CEB10")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x72CEB60", Offset = "0x72CD160", VA = "0x1872CEB60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class ENCAEOLFNGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public FLIBNLGBOAG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ENCAEOLFNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72CDD00", Offset = "0x72CC300", VA = "0x1872CDD00")]
		internal bool LFJGEDPDPDF(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72CDAA0", Offset = "0x72CC0A0", VA = "0x1872CDAA0")]
		internal void KNKJAHDEFHB(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OFIHJFNCOLK : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public FLIBNLGBOAG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private ENCAEOLFNGC <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public OFIHJFNCOLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x72DCE90", Offset = "0x72DB490", VA = "0x1872DCE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x72DD4F0", Offset = "0x72DBAF0", VA = "0x1872DD4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly ICollection<string> IKADEJBDGMH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static MKEIEIBMPOE NDLMCPBAHIP;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static AsyncOperation AKHAGDDIGBI;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static MKEIEIBMPOE CFBEBPBOPEK;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static string LFBLMPFIDBN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static ThreadPriority HFIENNHNMIF;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task OAHBMNIHBLG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static List<SceneInstance> PPJDBEIGHEP;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly Queue<GBHKMCLKLHF> CHFJNBGJFCH;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static Task CIKOHGBBIOE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool JHKHFIDAKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x72D6F40", Offset = "0x72D5540", VA = "0x1872D6F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool EMIADDDNFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x72D6870", Offset = "0x72D4E70", VA = "0x1872D6870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool POJDMAOPGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72D74A0", Offset = "0x72D5AA0", VA = "0x1872D74A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool OOJKHICJGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72D6580", Offset = "0x72D4B80", VA = "0x1872D6580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BIABFOBCAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x72D6910", Offset = "0x72D4F10", VA = "0x1872D6910")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72D7540", Offset = "0x72D5B40", VA = "0x1872D7540")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72D5FF0", Offset = "0x72D45F0", VA = "0x1872D5FF0")]
	[EGHEHMMMCAK(KNFLANAHCAH.EnteredEditModeNextFrame, 0)]
	private static void AOFHAMIHGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72D6720", Offset = "0x72D4D20", VA = "0x1872D6720")]
	[AsyncStateMachine(typeof(BHBCFKMBKFJ))]
	public static Task<Scene> EJJDCDPEJOH(string FHGJMMBJGMK, LoadSceneMode CBELDOIEFJP = LoadSceneMode.Single, bool PONEJMNBEPI = false, [Optional] NEGKJPNCLPM<string>.GBKOFALFHEN GDIGDIMPEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72D7150", Offset = "0x72D5750", VA = "0x1872D7150")]
	[AsyncStateMachine(typeof(MPFOHMNEFKK))]
	private static Task LNPJLBICMFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x72D6C70", Offset = "0x72D5270", VA = "0x1872D6C70")]
	[AsyncStateMachine(typeof(LKGJIBAENNE))]
	private static Task JKAKDHLOMKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x72D63A0", Offset = "0x72D49A0", VA = "0x1872D63A0")]
	[AsyncStateMachine(typeof(KKKNIJGEGMH))]
	private static Task<Scene> CFFOFNOMOOC(string FHGJMMBJGMK, LoadSceneMode CBELDOIEFJP, bool PONEJMNBEPI, NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x72D6610", Offset = "0x72D4C10", VA = "0x1872D6610")]
	private static void EIBBDAAAEPA(SceneInstance GCEDGJIKNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72D72A0", Offset = "0x72D58A0", VA = "0x1872D72A0")]
	private static void NKFFNKMCNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72D6B50", Offset = "0x72D5150", VA = "0x1872D6B50")]
	[AsyncStateMachine(typeof(JDCKNHBGIJL))]
	private static Task<Scene> HPIIEDJDAIF(string FHGJMMBJGMK, LoadSceneMode CBELDOIEFJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72D6D40", Offset = "0x72D5340", VA = "0x1872D6D40")]
	private static bool JPEFFIANGMH(string FHGJMMBJGMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72D6E30", Offset = "0x72D5430", VA = "0x1872D6E30")]
	[AsyncStateMachine(typeof(LFCLCKFJBIB))]
	private static Task<Scene> KIJIFIBAPNC(NEGKJPNCLPM<string>.GBKOFALFHEN HAINHOKBAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72D5E70", Offset = "0x72D4470", VA = "0x1872D5E70")]
	public static DNKNPFLFPMI<Scene> ALLNADPIMML(string FHGJMMBJGMK, LoadSceneMode CBELDOIEFJP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72D60E0", Offset = "0x72D46E0", VA = "0x1872D60E0")]
	public static MKEIEIBMPOE CEOAEBOEFCH(string FHGJMMBJGMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x72D64F0", Offset = "0x72D4AF0", VA = "0x1872D64F0")]
	[IteratorStateMachine(typeof(GMDEJKMLPGM))]
	private static IEnumerator<FDDBCEBEBAE> CLCCILKBOMB(string FHGJMMBJGMK, FILOAGJMCDA KDKDCBANAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72D7200", Offset = "0x72D5800", VA = "0x1872D7200")]
	[IteratorStateMachine(typeof(OFIHJFNCOLK))]
	private static IEnumerator<FDDBCEBEBAE> MIPOPNPMDIE(string FHGJMMBJGMK, LoadSceneMode CBELDOIEFJP, FLIBNLGBOAG<Scene> KDKDCBANAGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72D6A20", Offset = "0x72D5020", VA = "0x1872D6A20")]
	public static bool HOMPIFHHFHL([Out] string KFOGADOOHEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IFANOMIAMIH
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x72D2560", Offset = "0x72D0B60", VA = "0x1872D2560")]
	public static IDisposable EHGNJFECIDJ(this JIAECHDCFPJ MGIHCPMKPNG, float CPBEJMOONAF, Action<float> FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x72D2670", Offset = "0x72D0C70", VA = "0x1872D2670")]
	public static IDisposable NOEMEHGFJOM(this JIAECHDCFPJ MGIHCPMKPNG, Action<float> FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x72D25F0", Offset = "0x72D0BF0", VA = "0x1872D25F0")]
	public static IDisposable KBNEFDPMJKJ(this JIAECHDCFPJ MGIHCPMKPNG, Action<float> FLPFLCGJPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JJGCKFBHIDE
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72D4F20", Offset = "0x72D3520", VA = "0x1872D4F20")]
	public static IDisposable BNBKGEPKHML(this MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x72D4FB0", Offset = "0x72D35B0", VA = "0x1872D4FB0")]
	public static IDisposable BNBKGEPKHML(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x72D5040", Offset = "0x72D3640", VA = "0x1872D5040")]
	public static IDisposable CCBJGFJMACJ(this MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x72D5770", Offset = "0x72D3D70", VA = "0x1872D5770")]
	public static IDisposable MPCNGICJMFF(this MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x72D57F0", Offset = "0x72D3DF0", VA = "0x1872D57F0")]
	public static IDisposable MPCNGICJMFF(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72D5490", Offset = "0x72D3A90", VA = "0x1872D5490")]
	public static IDisposable HOEDBKOHCKA(this MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72D5920", Offset = "0x72D3F20", VA = "0x1872D5920")]
	public static IDisposable NPDELNJBAMH(this MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x72D5A40", Offset = "0x72D4040", VA = "0x1872D5A40")]
	public static IDisposable OMCBKPPGCEC(this MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x72D5870", Offset = "0x72D3E70", VA = "0x1872D5870")]
	public static IDisposable NCLDOAAHKFD(this MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x72D55B0", Offset = "0x72D3BB0", VA = "0x1872D55B0")]
	public static IDisposable MJLBKNNAIJF(this MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x72D50C0", Offset = "0x72D36C0", VA = "0x1872D50C0")]
	public static IDisposable CMMHBEHEOJA(this MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x72D5510", Offset = "0x72D3B10", VA = "0x1872D5510")]
	public static IDisposable MICMGHGLNPC(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72D5160", Offset = "0x72D3760", VA = "0x1872D5160")]
	public static IDisposable CNPKFDNEHIE(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x72D56D0", Offset = "0x72D3CD0", VA = "0x1872D56D0")]
	public static IDisposable MMCOOAIAGKD(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72D5350", Offset = "0x72D3950", VA = "0x1872D5350")]
	public static IDisposable GIMNIFEECEL(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72D5200", Offset = "0x72D3800", VA = "0x1872D5200")]
	public static IDisposable CPKHOKLJLIE(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72D53F0", Offset = "0x72D39F0", VA = "0x1872D53F0")]
	public static IDisposable GNJMBPOPIKI(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72D59A0", Offset = "0x72D3FA0", VA = "0x1872D59A0")]
	public static IDisposable OLEKDCEHGOP(this MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72D52A0", Offset = "0x72D38A0", VA = "0x1872D52A0")]
	public static IDisposable FLKIEIKHENB(this MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DAJCHOIIPHK
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OOCEHMCNBND : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public OFIIIOIBNHO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private OBCBMOCKOPH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public OOCEHMCNBND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x72DDA20", Offset = "0x72DC020", VA = "0x1872DDA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72DDB00", Offset = "0x72DC100", VA = "0x1872DDB00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FLJKOLBPMEB : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public OFIIIOIBNHO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private OBCBMOCKOPH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public FLJKOLBPMEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72CE190", Offset = "0x72CC790", VA = "0x1872CE190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x72CE280", Offset = "0x72CC880", VA = "0x1872CE280", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x72CCAF0", Offset = "0x72CB0F0", VA = "0x1872CCAF0")]
	public static MCOHGCAFPBM BNBKGEPKHML(Action FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x72CC910", Offset = "0x72CAF10", VA = "0x1872CC910")]
	public static MCOHGCAFPBM BNBKGEPKHML(Behaviour MGIHCPMKPNG, Action FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x72CC9D0", Offset = "0x72CAFD0", VA = "0x1872CC9D0")]
	public static MCOHGCAFPBM BNBKGEPKHML(Behaviour MGIHCPMKPNG, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x72CCBA0", Offset = "0x72CB1A0", VA = "0x1872CCBA0")]
	[IteratorStateMachine(typeof(OOCEHMCNBND))]
	private static IEnumerator<FDDBCEBEBAE> PLACJMEIBOH(OFIIIOIBNHO PLFCIPAANHJ, Action FLPFLCGJPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x72CCC30", Offset = "0x72CB230", VA = "0x1872CCC30")]
	[IteratorStateMachine(typeof(FLJKOLBPMEB))]
	private static IEnumerator<FDDBCEBEBAE> PLACJMEIBOH(OFIIIOIBNHO PLFCIPAANHJ, Action<float> FLPFLCGJPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BAGHLMOJAKO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class OGOHAPNKPAC : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public BAGHLMOJAKO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public OGOHAPNKPAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72DD540", Offset = "0x72DBB40", VA = "0x1872DD540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x72DD5D0", Offset = "0x72DBBD0", VA = "0x1872DD5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly OFIIIOIBNHO KKKINOJGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Action ADDGBCNCAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool CDABGKDNGDL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CBHOFFDJBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8656E0", Offset = "0x863CE0", VA = "0x1808656E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x72C6EE0", Offset = "0x72C54E0", VA = "0x1872C6EE0")]
	public BAGHLMOJAKO(OFIIIOIBNHO KKKINOJGEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x72C6DC0", Offset = "0x72C53C0", VA = "0x1872C6DC0")]
	[IteratorStateMachine(typeof(OGOHAPNKPAC))]
	private IEnumerator<FDDBCEBEBAE> BEKLOECKDBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72C6E40", Offset = "0x72C5440", VA = "0x1872C6E40", Slot = "4")]
	public void OnCompleted(Action FJBNHIAOKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	public void MOICIHMECBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class HCJGKBOKMBP
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x72CF460", Offset = "0x72CDA60", VA = "0x1872CF460")]
	public static BAGHLMOJAKO FLHBGNMEBOM(this OFIIIOIBNHO KKKINOJGEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IHMALCJNAJL
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DOAKOLGILCK : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CKPOMCFHANG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public DOAKOLGILCK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72CD3B0", Offset = "0x72CB9B0", VA = "0x1872CD3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x72CD430", Offset = "0x72CBA30", VA = "0x1872CD430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72D2890", Offset = "0x72D0E90", VA = "0x1872D2890")]
	public static MCOHGCAFPBM BNBKGEPKHML(float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72D2990", Offset = "0x72D0F90", VA = "0x1872D2990")]
	public static MCOHGCAFPBM BNBKGEPKHML(MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72D2CA0", Offset = "0x72D12A0", VA = "0x1872D2CA0")]
	public static MCOHGCAFPBM OOLGKAOOJBJ(MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72D2AA0", Offset = "0x72D10A0", VA = "0x1872D2AA0")]
	public static MCOHGCAFPBM MHBBFAMGNJL(JIAECHDCFPJ MGIHCPMKPNG, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72D2DC0", Offset = "0x72D13C0", VA = "0x1872D2DC0")]
	private static IEnumerator<FDDBCEBEBAE> PLACJMEIBOH(EIBLCLHNKLD HLOHBCEHEOF, float CPBEJMOONAF, OFIIIOIBNHO PLFCIPAANHJ, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x72D2C40", Offset = "0x72D1240", VA = "0x1872D2C40")]
	private static IEnumerator<FDDBCEBEBAE> OLCAFDCMODD(EIBLCLHNKLD HLOHBCEHEOF, float CPBEJMOONAF, OFIIIOIBNHO PLFCIPAANHJ, Action<float> FLPFLCGJPGM, bool LBBHNEEMDIN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x72D2BB0", Offset = "0x72D11B0", VA = "0x1872D2BB0")]
	[IteratorStateMachine(typeof(DOAKOLGILCK))]
	private static IEnumerator<FDDBCEBEBAE> NIACFCBCAAH(CKPOMCFHANG BPNMHNHIGBA, float CPBEJMOONAF, OFIIIOIBNHO PLFCIPAANHJ, Action<float> FLPFLCGJPGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BNAFILBEOBF
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class HIGBNDOOPMM : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public OFIIIOIBNHO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public HIGBNDOOPMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x72CF5A0", Offset = "0x72CDBA0", VA = "0x1872CF5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x72CF660", Offset = "0x72CDC60", VA = "0x1872CF660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72C82C0", Offset = "0x72C68C0", VA = "0x1872C82C0")]
	[IteratorStateMachine(typeof(HIGBNDOOPMM))]
	private static IEnumerator<FDDBCEBEBAE> OCEGHOFHJFD(OFIIIOIBNHO KKKINOJGEDE, Func<bool> LECPJGKPNPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x72C81A0", Offset = "0x72C67A0", VA = "0x1872C81A0")]
	public static MCOHGCAFPBM ECPEGCMPADG(this MonoBehaviour NCLGKFFOINP, Func<bool> LECPJGKPNPA, OFIIIOIBNHO KKKINOJGEDE = OFIIIOIBNHO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KINCPNBJOFH
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class KDABOHAHPKF : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public OFIIIOIBNHO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public KDABOHAHPKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72D7820", Offset = "0x72D5E20", VA = "0x1872D7820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x72D7890", Offset = "0x72D5E90", VA = "0x1872D7890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class LNHACPNNEDP : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public OFIIIOIBNHO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private FDDBCEBEBAE <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public LNHACPNNEDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72DA840", Offset = "0x72D8E40", VA = "0x1872DA840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72DA8D0", Offset = "0x72D8ED0", VA = "0x1872DA8D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72D79B0", Offset = "0x72D5FB0", VA = "0x1872D79B0")]
	[IteratorStateMachine(typeof(KDABOHAHPKF))]
	private static IEnumerator<FDDBCEBEBAE> BEKLOECKDBG(float OPCFFCHKCFF, OFIIIOIBNHO PLFCIPAANHJ, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72D8000", Offset = "0x72D6600", VA = "0x1872D8000")]
	[IteratorStateMachine(typeof(LNHACPNNEDP))]
	private static IEnumerator<FDDBCEBEBAE> IBIDIIPHJKO(float OPCFFCHKCFF, OFIIIOIBNHO PLFCIPAANHJ, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72D7BF0", Offset = "0x72D61F0", VA = "0x1872D7BF0")]
	public static IDisposable DPHOPIJOKPO(this MonoBehaviour NCLGKFFOINP, float OPCFFCHKCFF, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72D7B30", Offset = "0x72D6130", VA = "0x1872D7B30")]
	public static MCOHGCAFPBM BMAOFIEKKPF(this MonoBehaviour NCLGKFFOINP, float OPCFFCHKCFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72D7D10", Offset = "0x72D6310", VA = "0x1872D7D10")]
	public static MCOHGCAFPBM DPHOPIJOKPO(this MonoBehaviour NCLGKFFOINP, float OPCFFCHKCFF, OFIIIOIBNHO PLFCIPAANHJ, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72D7FE0", Offset = "0x72D65E0", VA = "0x1872D7FE0")]
	public static MCOHGCAFPBM HDLGLCAELOH(this MonoBehaviour NCLGKFFOINP, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72D81D0", Offset = "0x72D67D0", VA = "0x1872D81D0")]
	public static MCOHGCAFPBM OKPLJKPDHHF(this MonoBehaviour NCLGKFFOINP, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72D7A50", Offset = "0x72D6050", VA = "0x1872D7A50")]
	public static MCOHGCAFPBM BHDLAIMPOLP(this MonoBehaviour NCLGKFFOINP, Action MMBIFBKCHGP, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x72D80A0", Offset = "0x72D66A0", VA = "0x1872D80A0")]
	public static MCOHGCAFPBM IDCLLMMFPJD(this MonoBehaviour NCLGKFFOINP, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72D81A0", Offset = "0x72D67A0", VA = "0x1872D81A0")]
	public static MCOHGCAFPBM LOKBDLGPACA(this MonoBehaviour NCLGKFFOINP, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72D80D0", Offset = "0x72D66D0", VA = "0x1872D80D0")]
	private static MCOHGCAFPBM KPDGNECJMKF(MonoBehaviour NCLGKFFOINP, OFIIIOIBNHO KKKINOJGEDE, Action MMBIFBKCHGP, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72D7F10", Offset = "0x72D6510", VA = "0x1872D7F10")]
	public static MCOHGCAFPBM FDBLFNLDHAH(this MonoBehaviour NCLGKFFOINP, float LPHIGFKHNND, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72D7E40", Offset = "0x72D6440", VA = "0x1872D7E40")]
	public static MCOHGCAFPBM FCEEGCHPIAF(this MonoBehaviour NCLGKFFOINP, float LPHIGFKHNND, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x72D8200", Offset = "0x72D6800", VA = "0x1872D8200")]
	public static MCOHGCAFPBM PBBOPJHPNNI(this MonoBehaviour NCLGKFFOINP, float LPHIGFKHNND, Action MMBIFBKCHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x72D78E0", Offset = "0x72D5EE0", VA = "0x1872D78E0")]
	public static MCOHGCAFPBM AHDBENPEJCE(this MonoBehaviour NCLGKFFOINP, float LPHIGFKHNND, Action MMBIFBKCHGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ODCALKKHEMN : IEJGDNGCKOI, IEnumerable<IEJGDNGCKOI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly List<IEJGDNGCKOI> GMMFIECPPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool FBFFHJDAHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action OCMAPCHKJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool BMAANMEOKKG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KHFMDKBCBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x72DCCC0", Offset = "0x72DB2C0", VA = "0x1872DCCC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CANGFCCPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72DC7F0", Offset = "0x72DADF0", VA = "0x1872DC7F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x72DC890", Offset = "0x72DAE90", VA = "0x1872DC890", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72DCDF0", Offset = "0x72DB3F0", VA = "0x1872DCDF0")]
	public ODCALKKHEMN([Optional] Action OCMAPCHKJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72DC570", Offset = "0x72DAB70", VA = "0x1872DC570")]
	public void AGMNBECNIJC(IEJGDNGCKOI LKLHAJDMFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x72DC6A0", Offset = "0x72DACA0", VA = "0x1872DC6A0")]
	private void DNDNKBEPGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x72DCCB0", Offset = "0x72DB2B0", VA = "0x1872DCCB0", Slot = "7")]
	public bool LNDOCFKPFCO(bool EFJJGJMLHPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x72DC9B0", Offset = "0x72DAFB0", VA = "0x1872DC9B0", Slot = "8")]
	public bool LNDOCFKPFCO(Action IJDJHMGAIOM, bool EFJJGJMLHPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x72DC930", Offset = "0x72DAF30", VA = "0x1872DC930", Slot = "9")]
	public IEnumerator<IEJGDNGCKOI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72DC930", Offset = "0x72DAF30", VA = "0x1872DC930", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HLEDABFLMPN : ALDBCECKPPB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class ICBIPECCHIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public HLEDABFLMPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ICBIPECCHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x72CD220", Offset = "0x72CB820", VA = "0x1872CD220")]
		internal void JPHDAFGMBGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DMNJCDLPONM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HLEDABFLMPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DMNJCDLPONM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x72CD220", Offset = "0x72CB820", VA = "0x1872CD220")]
		internal void BJKIMKFAMMG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly float NEGDHGFLJEG;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72CC810", Offset = "0x72CAE10", VA = "0x1872CC810")]
	public HLEDABFLMPN(Behaviour MGIHCPMKPNG, float NEGDHGFLJEG, [Optional] Action OCMAPCHKJJG, [Optional] PCFKKJJFCHN CGHHFMGJMPG, [Optional] EIBLCLHNKLD HLOHBCEHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72CF6B0", Offset = "0x72CDCB0", VA = "0x1872CF6B0", Slot = "9")]
	protected override bool CHPPAOFNIFB(Action IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72CF7C0", Offset = "0x72CDDC0", VA = "0x1872CF7C0", Slot = "10")]
	protected override bool NNADINABHNN(Action IJDJHMGAIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface IEJGDNGCKOI
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KHFMDKBCBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action CANGFCCPNFP;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LNDOCFKPFCO(bool EFJJGJMLHPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LNDOCFKPFCO(Action IJDJHMGAIOM, bool EFJJGJMLHPN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public abstract class ALDBCECKPPB : IEJGDNGCKOI
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class NOPFOFBNKHK : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public ALDBCECKPPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public NOPFOFBNKHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x72DC2F0", Offset = "0x72DA8F0", VA = "0x1872DC2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x72DC3C0", Offset = "0x72DA9C0", VA = "0x1872DC3C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Behaviour MGIHCPMKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action OCMAPCHKJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private JIMPAEGGIFL GOCHMBPEBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PCFKKJJFCHN CGHHFMGJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly EIBLCLHNKLD HLOHBCEHEOF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KHFMDKBCBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xF81400", Offset = "0xF7FA00", VA = "0x180F81400", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CANGFCCPNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72C69D0", Offset = "0x72C4FD0", VA = "0x1872C69D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72C6AB0", Offset = "0x72C50B0", VA = "0x1872C6AB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x72C6CC0", Offset = "0x72C52C0", VA = "0x1872C6CC0")]
	protected ALDBCECKPPB(Behaviour MGIHCPMKPNG, [Optional] Action OCMAPCHKJJG, [Optional] PCFKKJJFCHN CGHHFMGJMPG, [Optional] EIBLCLHNKLD HLOHBCEHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x72C6B70", Offset = "0x72C5170", VA = "0x1872C6B70", Slot = "7")]
	public bool LNDOCFKPFCO(bool EFJJGJMLHPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x72C6BD0", Offset = "0x72C51D0", VA = "0x1872C6BD0", Slot = "8")]
	public bool LNDOCFKPFCO(Action IJDJHMGAIOM, bool EFJJGJMLHPN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CHPPAOFNIFB(Action IJDJHMGAIOM);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NNADINABHNN(Action IJDJHMGAIOM);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72C6B50", Offset = "0x72C5150", VA = "0x1872C6B50")]
	protected void KDDOOEMPKEO(Action IJDJHMGAIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x72C6710", Offset = "0x72C4D10", VA = "0x1872C6710")]
	protected MKEIEIBMPOE BEFHPBNPGLG(float FNIKMIIBLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x72C6950", Offset = "0x72C4F50", VA = "0x1872C6950")]
	private void DPBJJPKFMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x72C6C30", Offset = "0x72C5230", VA = "0x1872C6C30")]
	[IteratorStateMachine(typeof(NOPFOFBNKHK))]
	private IEnumerator<FDDBCEBEBAE> LNHMBFAFPNP(float FNIKMIIBLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72C6A70", Offset = "0x72C5070", VA = "0x1872C6A70")]
	[CompilerGenerated]
	private void GODMAPNDKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BHKEOLAHMJC : ALDBCECKPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float KKAMFPFCIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly int PJNGGCDAFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float OJOGKMMACCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float[] FIACDEMCGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int KFLJELHNKDN;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x72C8000", Offset = "0x72C6600", VA = "0x1872C8000")]
	public BHKEOLAHMJC(Behaviour MGIHCPMKPNG, float KLPNNFJDNNL, int PJNGGCDAFEM, [Optional] Action OCMAPCHKJJG, float OJOGKMMACCJ = 0f, [Optional] PCFKKJJFCHN CGHHFMGJMPG, [Optional] EIBLCLHNKLD HLOHBCEHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "9")]
	protected override bool CHPPAOFNIFB(Action IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72C7E00", Offset = "0x72C6400", VA = "0x1872C7E00", Slot = "10")]
	protected override bool NNADINABHNN(Action IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72C7D80", Offset = "0x72C6380", VA = "0x1872C7D80")]
	private void MGMBOCJIHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DAIKHAEHEBE : ALDBCECKPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly float NEGDHGFLJEG;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72CC810", Offset = "0x72CAE10", VA = "0x1872CC810")]
	public DAIKHAEHEBE(Behaviour MGIHCPMKPNG, float NEGDHGFLJEG, [Optional] Action OCMAPCHKJJG, [Optional] PCFKKJJFCHN CGHHFMGJMPG, [Optional] EIBLCLHNKLD HLOHBCEHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "9")]
	protected override bool CHPPAOFNIFB(Action IJDJHMGAIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72CC7D0", Offset = "0x72CADD0", VA = "0x1872CC7D0", Slot = "10")]
	protected override bool NNADINABHNN(Action IJDJHMGAIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public sealed class NEGKLJGOEJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BNGKOGOCFIN : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public BNGKOGOCFIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72C8350", Offset = "0x72C6950", VA = "0x1872C8350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x72C83C0", Offset = "0x72C69C0", VA = "0x1872C83C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private MCOHGCAFPBM HLEGDAHKEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private JIAECHDCFPJ MGIHCPMKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Action<float> NCNOFCOEHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private OFIIIOIBNHO KKKINOJGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private float HKFPELPMDML;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72DC110", Offset = "0x72DA710", VA = "0x1872DC110")]
	public NEGKLJGOEJF(JIAECHDCFPJ MGIHCPMKPNG, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x72DBC60", Offset = "0x72DA260", VA = "0x1872DBC60")]
	private void EMEGLAMNLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72DBE00", Offset = "0x72DA400", VA = "0x1872DBE00")]
	private void EPLFBBFIEHF(string BDGJCBKBDPI, Action FHKGMPONEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72DBB80", Offset = "0x72DA180", VA = "0x1872DBB80")]
	[IteratorStateMachine(typeof(BNGKOGOCFIN))]
	private IEnumerator<FDDBCEBEBAE> AOPLAELHLJI(Action FHKGMPONEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72DBC00", Offset = "0x72DA200", VA = "0x1872DBC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x72DBF60", Offset = "0x72DA560", VA = "0x1872DBF60")]
	[CompilerGenerated]
	private void GCPIBHDEDPC(string OOIEOIIANBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class PNADJLBFBKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class FHFGAHGHEKL : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public FHFGAHGHEKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x72C8350", Offset = "0x72C6950", VA = "0x1872C8350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72CE140", Offset = "0x72CC740", VA = "0x1872CE140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private MCOHGCAFPBM HLEGDAHKEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MonoBehaviour NCLGKFFOINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Action FLPFLCGJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action<float> NCNOFCOEHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private OFIIIOIBNHO KKKINOJGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float HKFPELPMDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool LBBHNEEMDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly PCFKKJJFCHN CGHHFMGJMPG;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72E11E0", Offset = "0x72DF7E0", VA = "0x1872E11E0")]
	public PNADJLBFBKM(MonoBehaviour NCLGKFFOINP, Action FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x72E0FA0", Offset = "0x72DF5A0", VA = "0x1872E0FA0")]
	public PNADJLBFBKM(MonoBehaviour NCLGKFFOINP, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x72E13D0", Offset = "0x72DF9D0", VA = "0x1872E13D0")]
	public PNADJLBFBKM(MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DFB0", Offset = "0x3D7C5B0", VA = "0x183D7DFB0")]
	private PNADJLBFBKM(PCFKKJJFCHN CGHHFMGJMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x72E0D50", Offset = "0x72DF350", VA = "0x1872E0D50")]
	internal static PNADJLBFBKM PJJAPOIDLAD(MonoBehaviour NCLGKFFOINP, float CPBEJMOONAF, Action<float> FLPFLCGJPGM, OFIIIOIBNHO KKKINOJGEDE, bool LBBHNEEMDIN = true, [Optional] PCFKKJJFCHN CGHHFMGJMPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x72E0410", Offset = "0x72DEA10", VA = "0x1872E0410")]
	private void BNBKGEPKHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x72E0950", Offset = "0x72DEF50", VA = "0x1872E0950")]
	private void JAHKIBKALLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x72E0670", Offset = "0x72DEC70", VA = "0x1872E0670")]
	private void EMEGLAMNLCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x72E0B00", Offset = "0x72DF100", VA = "0x1872E0B00")]
	private void JLHMCBBPPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x72E0820", Offset = "0x72DEE20", VA = "0x1872E0820")]
	private void EPLFBBFIEHF(string BDGJCBKBDPI, Action FHKGMPONEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x72E0390", Offset = "0x72DE990", VA = "0x1872E0390")]
	[IteratorStateMachine(typeof(FHFGAHGHEKL))]
	private IEnumerator<FDDBCEBEBAE> AOPLAELHLJI(Action FHKGMPONEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x72E0610", Offset = "0x72DEC10", VA = "0x1872E0610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x72E0CC0", Offset = "0x72DF2C0", VA = "0x1872E0CC0")]
	[CompilerGenerated]
	private void KNAIIOKNNFI(string OOIEOIIANBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72E0E80", Offset = "0x72DF480", VA = "0x1872E0E80")]
	[CompilerGenerated]
	private void PJKLEFKJEBB(string OOIEOIIANBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x72E0580", Offset = "0x72DEB80", VA = "0x1872E0580")]
	[CompilerGenerated]
	private void DBCEKLELHDM(string OOIEOIIANBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x72E0F10", Offset = "0x72DF510", VA = "0x1872E0F10")]
	[CompilerGenerated]
	private void PKDEIDJLAPH(string OOIEOIIANBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[Flags]
internal enum AFFMLDMDLAG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class DPAHFEIBCGF : EIBLCLHNKLD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float HDINCNEOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72CD4F0", Offset = "0x72CBAF0", VA = "0x1872CD4F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float GBGHOFHIODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72CD500", Offset = "0x72CBB00", VA = "0x1872CD500", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double EOEBNHBIELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x72CD510", Offset = "0x72CBB10", VA = "0x1872CD510", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x72CD480", Offset = "0x72CBA80", VA = "0x1872CD480")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	[Preserve]
	internal DPAHFEIBCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface GHELGPHLHED
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFNLNHEFIHG(string LGJDNDBECCI);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAKBMAFHLJF();
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface JIHLMCFJIGF
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool ADAIPAMBJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool OBJGMHOEKNH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal class LIMPOGNPLDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public HMHAICEBNFI NKDDFFLINBK;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JPOHIBGABMB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A0", Offset = "0x85DAA0", VA = "0x18085F4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x72DA210", Offset = "0x72D8810", VA = "0x1872DA210")]
	public static FDDBCEBEBAE ONGDOPEFPJH(IEnumerator<FDDBCEBEBAE> KBLLKJMCLOD, ONJAMOMOHMM PNHJHEEKKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x72DA370", Offset = "0x72D8970", VA = "0x1872DA370")]
	public FDDBCEBEBAE ONGDOPEFPJH(ONJAMOMOHMM[] BLJMNNLENBB, IEnumerator<FDDBCEBEBAE>[] CIPNBEOIBCF, FDDBCEBEBAE[] EKJNLBCOPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x72DA0A0", Offset = "0x72D86A0", VA = "0x1872DA0A0")]
	public void FJAOMKPPIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72DA0D0", Offset = "0x72D86D0", VA = "0x1872DA0D0")]
	public void DNPFGDOOAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72D9F60", Offset = "0x72D8560", VA = "0x1872D9F60")]
	public void AFIOAMBJKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72DA0A0", Offset = "0x72D86A0", VA = "0x1872DA0A0")]
	public void CKNDFKENKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public LIMPOGNPLDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal sealed class HMHAICEBNFI
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct EJPJOPLHLPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public LIMPOGNPLDE NDGGHHPMABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public JIAECHDCFPJ DJLOFFJKKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ONJAMOMOHMM NKLIHJKEFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IEnumerator<FDDBCEBEBAE> EKGKGIBFCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public FDDBCEBEBAE GOFAKDPLCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AFFMLDMDLAG HDIHAMMJOKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct PBCCFLPBHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OFIIIOIBNHO KGIFGHPBEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public List<EJPJOPLHLPD> KLOLJNINPFE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PDLDNKJPDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public ONJAMOMOHMM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public HMHAICEBNFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JIAECHDCFPJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public LIMPOGNPLDE routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AFFMLDMDLAG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public FDDBCEBEBAE currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IEnumerator<FDDBCEBEBAE> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public PDLDNKJPDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x72DF160", Offset = "0x72DD760", VA = "0x1872DF160")]
		internal void FHKNMCJDBPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class GPFKOMJACCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public LIMPOGNPLDE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public HMHAICEBNFI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public GPFKOMJACCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x72CEC40", Offset = "0x72CD240", VA = "0x1872CEC40")]
		internal void HEDGKLBLKGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DNMEFOAJLOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public LIMPOGNPLDE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public HMHAICEBNFI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DNMEFOAJLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x72CD250", Offset = "0x72CB850", VA = "0x1872CD250")]
		internal void PDOFDJBOAOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BOOHIEGHNEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public LIMPOGNPLDE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HMHAICEBNFI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BOOHIEGHNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x72C86E0", Offset = "0x72C6CE0", VA = "0x1872C86E0")]
		internal void DPMOPKFJEAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const AFFMLDMDLAG ELAMNMHNDDA = AFFMLDMDLAG.Cancelled | AFFMLDMDLAG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly OFIIIOIBNHO KKKINOJGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool[] KEOKPCFKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<AFFMLDMDLAG> OPPGFCECBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<float> PNELLCPOGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> NACIHIBNIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> NAOGBJNEMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> KBBEJCAEIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> CMGIPLKPHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> LAMEABMPANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private LIMPOGNPLDE[] OEEDAGBKHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private ONJAMOMOHMM[] BLJMNNLENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private JIAECHDCFPJ[] KPHBBEIAFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IEnumerator<FDDBCEBEBAE>[] MICOOJAJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FDDBCEBEBAE[] LJLIMEFLGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int DEFMFGGAFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int HDGFIGFBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly int HMGCDCANKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float PFEJIKBNGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private DFDPAOCJHJM LOBAENMLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private JobHandle MNACJFHBFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<LIMPOGNPLDE> NEFPPKJJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool FLJDHEKPCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private List<Action> JBOMNJANKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> JENCJLKDEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool PDCOMJHMCFG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PBCCFLPBHMC[] IJONJDBGOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9A50E0", Offset = "0x9A36E0", VA = "0x1809A50E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x72D1510", Offset = "0x72CFB10", VA = "0x1872D1510")]
	private static int JCAGPDHNIIH(OFIIIOIBNHO KKKINOJGEDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x72D1E10", Offset = "0x72D0410", VA = "0x1872D1E10")]
	public HMHAICEBNFI(OFIIIOIBNHO KKKINOJGEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x72D1330", Offset = "0x72CF930", VA = "0x1872D1330")]
	private void JADGIDJIOEB(int COKCGKJLBAK, int LLJLDMCELCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x72D11B0", Offset = "0x72CF7B0", VA = "0x1872D11B0")]
	public void IPJGHGKCEBL(JIAECHDCFPJ MGIHCPMKPNG, FDDBCEBEBAE HJELKLAFOBI, IEnumerator<FDDBCEBEBAE> KBLLKJMCLOD, ONJAMOMOHMM PNHJHEEKKBI, [Optional] LIMPOGNPLDE ALPGNFBDCJJ, AFFMLDMDLAG FMOEHHHCCML = AFFMLDMDLAG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x72D01B0", Offset = "0x72CE7B0", VA = "0x1872D01B0")]
	public void CLHGPBLINON(IEnumerable<EJPJOPLHLPD> BPCAGOMOAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x72CFBB0", Offset = "0x72CE1B0", VA = "0x1872CFBB0")]
	private EJPJOPLHLPD CIFBCLBMGHA(int GIPGMJMCBNP)
	{
		return default(EJPJOPLHLPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x72D03F0", Offset = "0x72CE9F0", VA = "0x1872D03F0")]
	private void CNEDJGPDPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B8C920", Offset = "0x2B8AF20", VA = "0x182B8C920")]
	private static void BGKJEJMMCPI<T>(int GIPGMJMCBNP, T[] OPMJDFICIGF, int PPOFLGDKIBE, [Optional] T IAENAGBKMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B8C970", Offset = "0x2B8AF70", VA = "0x182B8C970")]
	private static void BGKJEJMMCPI<T>(int GIPGMJMCBNP, NativeArray<T> OPMJDFICIGF, int PPOFLGDKIBE, [Optional] T IAENAGBKMLM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x72D19A0", Offset = "0x72CFFA0", VA = "0x1872D19A0")]
	private void OIJJNIJGOFE(IEnumerable<EJPJOPLHLPD> BPCAGOMOAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x72D1D50", Offset = "0x72D0350", VA = "0x1872D1D50")]
	private void ONHNEHCJNMG(EJPJOPLHLPD MIOLJNCMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x72D1740", Offset = "0x72CFD40", VA = "0x1872D1740")]
	private NCJCEEHIOHD KOIBNJPAJKE(int EAGEHJNDFIJ)
	{
		return default(NCJCEEHIOHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x72D1540", Offset = "0x72CFB40", VA = "0x1872D1540")]
	public void JGBEDGBOLEN(float KHKDAGALAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72D09C0", Offset = "0x72CEFC0", VA = "0x1872D09C0")]
	private void FNIIFDHIENB(Action EJHDJMODPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x72D1130", Offset = "0x72CF730", VA = "0x1872D1130")]
	private void IOGLBONAPMM(Action EJHDJMODPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x72D0A40", Offset = "0x72CF040", VA = "0x1872D0A40")]
	public void GGDAJJHFFEF(float KHKDAGALAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72CFAB0", Offset = "0x72CE0B0", VA = "0x1872CFAB0")]
	public void BEBGJICOPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x72D0080", Offset = "0x72CE680", VA = "0x1872D0080")]
	public void CKNDFKENKDO(LIMPOGNPLDE BPNMHNHIGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x72D0760", Offset = "0x72CED60", VA = "0x1872D0760")]
	public void DNJDNNPBJBM(LIMPOGNPLDE BPNMHNHIGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x72D0890", Offset = "0x72CEE90", VA = "0x1872D0890")]
	public void FEFPMLFOBIM(LIMPOGNPLDE BPNMHNHIGBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class ONDEDMKCNAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly ONDEDMKCNAC IJMGMBPJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Action BBIGAGCAOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool PCNGABNNECG;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public ONDEDMKCNAC(Action BBIGAGCAOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A86340", Offset = "0x6A84940", VA = "0x186A86340", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface CIMMNMLEFBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable DDNFLHJBNMD(UnityEngine.Object MGIHCPMKPNG, Action<T> OMCHNCKFDKG);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FKKBHKPGDLO<T> : CIMMNMLEFBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class LLLIPPLBBLF<T> : FKKBHKPGDLO<T>, CIMMNMLEFBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class DKKJLMHHBBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public LLLIPPLBBLF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public NOHAONPGECK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DKKJLMHHBBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5873BF0", Offset = "0x58721F0", VA = "0x185873BF0")]
		internal void PELMPOGLAFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static GameObject MGMOGLFPIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<NOHAONPGECK<UnityEngine.Object, Action<T>>> HEOIGIAMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private T AJMJPNNFKLO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x96BEB0", Offset = "0x96A4B0", VA = "0x18096BEB0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x42E1A70", Offset = "0x42E0070", VA = "0x1842E1A70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x42E1210", Offset = "0x42DF810", VA = "0x1842E1210")]
	private static bool KGKKEBLCENK(T EJHDJMODPJO, T PNLANOPNMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x42E1BF0", Offset = "0x42E01F0", VA = "0x1842E1BF0")]
	public LLLIPPLBBLF(T OBHCLAOMNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x42E0E90", Offset = "0x42DF490", VA = "0x1842E0E90", Slot = "6")]
	public IDisposable DDNFLHJBNMD(UnityEngine.Object MGIHCPMKPNG, Action<T> OMCHNCKFDKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x42E1660", Offset = "0x42DFC60", VA = "0x1842E1660")]
	private void KKOAAKCIOMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class DNOEINMJHHI : EKFGCLAPBFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly PCFKKJJFCHN CGHHFMGJMPG;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x72CD340", Offset = "0x72CB940", VA = "0x1872CD340")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	[Preserve]
	internal DNOEINMJHHI([JLPFJOFFNLM(null)] PCFKKJJFCHN CGHHFMGJMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x72CD290", Offset = "0x72CB890", VA = "0x1872CD290", Slot = "4")]
	public IDisposable CMMHBEHEOJA(float CPBEJMOONAF, Action<float> MAPPKFKPMBJ, bool LBBHNEEMDIN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class MNPLJJCONAE : PCPOCMNNJCK, PCFKKJJFCHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private HMHAICEBNFI[] LOCBBKEGBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private GHELGPHLHED NHOMMMFIFIF;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x72DAD80", Offset = "0x72D9380", VA = "0x1872DAD80")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x72DB570", Offset = "0x72D9B70", VA = "0x1872DB570")]
	[Preserve]
	public MNPLJJCONAE([JLPFJOFFNLM(null)] CMLEAMAKLKO NILONACDDLN, [JLPFJOFFNLM(null)] EIBLCLHNKLD HLOHBCEHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x72DB2A0", Offset = "0x72D98A0", VA = "0x1872DB2A0", Slot = "18")]
	public override MCOHGCAFPBM MDKHLDFINAE(JIAECHDCFPJ MGIHCPMKPNG, IEnumerator<FDDBCEBEBAE> AHJPNBIIKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x72DA950", Offset = "0x72D8F50", VA = "0x1872DA950", Slot = "19")]
	public override void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72DAE50", Offset = "0x72D9450", VA = "0x1872DAE50", Slot = "21")]
	public override void EKAJOKPCGPN(OFIIIOIBNHO KKKINOJGEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72DABE0", Offset = "0x72D91E0", VA = "0x1872DABE0", Slot = "20")]
	protected override void CCBJGFJMACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72DAD50", Offset = "0x72D9350", VA = "0x1872DAD50")]
	private HMHAICEBNFI CCOCHDJMCCA(OFIIIOIBNHO BDKLEMDNAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x72DB080", Offset = "0x72D9680", VA = "0x1872DB080", Slot = "22")]
	internal override PKOALCHHCBJ MADNIHLMNDI(IEnumerator<FDDBCEBEBAE> AHJPNBIIKJI, Behaviour MGIHCPMKPNG, ONJAMOMOHMM PNHJHEEKKBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x72DB4F0", Offset = "0x72D9AF0", VA = "0x1872DB4F0", Slot = "23")]
	internal override JHHANKCKBCP OPPDNDKOABN(OFIIIOIBNHO PLFCIPAANHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x72DB3D0", Offset = "0x72D99D0", VA = "0x1872DB3D0")]
	private void MDMOIMACIBJ(HMHAICEBNFI KNCKAEMNDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x72DADF0", Offset = "0x72D93F0", VA = "0x1872DADF0", Slot = "24")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BurstCompile]
internal struct DFDPAOCJHJM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	public float HCBBJHBHCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public int BJILAEOHLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private NativeArray<int> NIKEKKNAHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> DMPGFBCCBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> GEKMLGACCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	public NativeArray<AFFMLDMDLAG> KPDONPEALCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<float> DNIGBKCEKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[WriteOnly]
	public NativeArray<int> KBBEJCAEIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> NACIHIBNIIM;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72CD0C0", Offset = "0x72CB6C0", VA = "0x1872CD0C0")]
	public static DFDPAOCJHJM KKJEMJBKDLP(int IHKANAFOIKK, float KHKDAGALAAP, NativeArray<AFFMLDMDLAG> EGIGCKIADBB, NativeArray<float> FIKGFIKCEGC, NativeArray<int> LEJLJEJEJJC, NativeArray<int> OAPCOHCLLGH, NativeArray<int> APINMGOMPPC, NativeArray<int> DMPGFBCCBJE, NativeArray<int> GEKMLGACCIB)
	{
		return default(DFDPAOCJHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x72CCDA0", Offset = "0x72CB3A0", VA = "0x1872CCDA0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x72CCCC0", Offset = "0x72CB2C0", VA = "0x1872CCCC0")]
	private bool BDABEJOJLCN(int EBDMAJMOJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x72CD120", Offset = "0x72CB720", VA = "0x1872CD120")]
	private void LOIDLCEJIPI(NativeArray<int> JOGNBCLEEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x72CCD00", Offset = "0x72CB300", VA = "0x1872CCD00")]
	private int CLPMGBMJJPC(int CAEFEJMCOMF, int DLCFCKOOKDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72CD150", Offset = "0x72CB750", VA = "0x1872CD150")]
	private void MELPDMLOFFM(NativeArray<int> JOGNBCLEEKD, int BKNAHFJHJGF, int IIMGHHPJFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x72CCE80", Offset = "0x72CB480", VA = "0x1872CCE80")]
	private void FOHIGFJGEMM(NativeArray<int> JOGNBCLEEKD, int JEFOIMFFDOM, int DOEIBPGEDPO, int FENEOHAGMLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class PCPOCMNNJCK : PCFKKJJFCHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly CMLEAMAKLKO NILONACDDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly EIBLCLHNKLD HLOHBCEHEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private JHHANKCKBCP[] IAPHNGIHNPK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static PCFKKJJFCHN HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x72DE710", Offset = "0x72DCD10", VA = "0x1872DE710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OFIIIOIBNHO OPIEPENMPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OFIIIOIBNHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A0", Offset = "0x85DAA0", VA = "0x18085F4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EIBLCLHNKLD MKOKAOEPFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FDDBCEBEBAE AJAMLMHDBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public FDDBCEBEBAE NGOFNNJDKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FDDBCEBEBAE GGIKPMEEAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x72DE580", Offset = "0x72DCB80", VA = "0x1872DE580")]
	public static MCOHGCAFPBM HDMCAIFKKIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72DEC70", Offset = "0x72DD270", VA = "0x1872DEC70")]
	[Preserve]
	protected PCPOCMNNJCK([JLPFJOFFNLM(null)] CMLEAMAKLKO NILONACDDLN, [JLPFJOFFNLM(null)] EIBLCLHNKLD HLOHBCEHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72DE9A0", Offset = "0x72DCFA0", VA = "0x1872DE9A0", Slot = "6")]
	public MCOHGCAFPBM NGPKEBHLPHO(IEnumerator<FDDBCEBEBAE> AHJPNBIIKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72DE7A0", Offset = "0x72DCDA0", VA = "0x1872DE7A0", Slot = "7")]
	public MCOHGCAFPBM NGPKEBHLPHO(Behaviour MGIHCPMKPNG, IEnumerator<FDDBCEBEBAE> AHJPNBIIKJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	public abstract MCOHGCAFPBM MDKHLDFINAE(JIAECHDCFPJ MGIHCPMKPNG, IEnumerator<FDDBCEBEBAE> AHJPNBIIKJI);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72DDD30", Offset = "0x72DC330", VA = "0x1872DDD30", Slot = "19")]
	public virtual void BOPCGMPFNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72DE340", Offset = "0x72DC940", VA = "0x1872DE340", Slot = "9")]
	public void EKICGOEBPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72DDED0", Offset = "0x72DC4D0", VA = "0x1872DDED0", Slot = "20")]
	protected virtual void CCBJGFJMACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72DE6B0", Offset = "0x72DCCB0", VA = "0x1872DE6B0")]
	private void JLPJAFKDHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72DE690", Offset = "0x72DCC90", VA = "0x1872DE690")]
	private void JGKPHPFOCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x72DE780", Offset = "0x72DCD80", VA = "0x1872DE780")]
	private void MPCNGICJMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x72DE610", Offset = "0x72DCC10", VA = "0x1872DE610")]
	private void HOEDBKOHCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x72DE760", Offset = "0x72DCD60", VA = "0x1872DE760")]
	private void MMJEMCOPLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x72DE6F0", Offset = "0x72DCCF0", VA = "0x1872DE6F0")]
	private void MKPMEONLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x72DE6D0", Offset = "0x72DCCD0", VA = "0x1872DE6D0")]
	private void KMKBONJIMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x72DE2B0", Offset = "0x72DC8B0", VA = "0x1872DE2B0", Slot = "21")]
	public virtual void EKAJOKPCGPN(OFIIIOIBNHO KKKINOJGEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x72DEA40", Offset = "0x72DD040", VA = "0x1872DEA40")]
	private void OFBMKBPCFNK(JHHANKCKBCP KNCKAEMNDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1EE0590", Offset = "0x1EDEB90", VA = "0x181EE0590")]
	private JHHANKCKBCP MMJAKMOMEHK(OFIIIOIBNHO BDKLEMDNAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	internal abstract PKOALCHHCBJ MADNIHLMNDI(IEnumerator<FDDBCEBEBAE> AHJPNBIIKJI, Behaviour NCLGKFFOINP, ONJAMOMOHMM GFJKNDOGNNM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract JHHANKCKBCP OPPDNDKOABN(OFIIIOIBNHO KKKINOJGEDE);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72DDEF0", Offset = "0x72DC4F0", VA = "0x1872DDEF0", Slot = "24")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x72DE630", Offset = "0x72DCC30", VA = "0x1872DE630", Slot = "14")]
	public FDDBCEBEBAE HOJPBAOCEIG(OFIIIOIBNHO PLFCIPAANHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x72DE9B0", Offset = "0x72DCFB0", VA = "0x1872DE9B0", Slot = "15")]
	public FDDBCEBEBAE NOAEJAACCKB(float OPCFFCHKCFF, OFIIIOIBNHO PLFCIPAANHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x72DEC10", Offset = "0x72DD210", VA = "0x1872DEC10", Slot = "16")]
	public FDDBCEBEBAE PFNNMGHNBAO(Func<bool> LECPJGKPNPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class PKOALCHHCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly ONJAMOMOHMM PNHJHEEKKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly JIHLMCFJIGF MGIHCPMKPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly bool PEOEGJIHCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private string LGJDNDBECCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private StackTrace EFGPIBFIGPM;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IEnumerator<FDDBCEBEBAE> EKGKGIBFCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public FDDBCEBEBAE GOFAKDPLCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool IEENMDHHOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x72DFAF0", Offset = "0x72DE0F0", VA = "0x1872DFAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool ENFEHHDKCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x96BE30", Offset = "0x96A430", VA = "0x18096BE30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAE5EF0", Offset = "0xAE44F0", VA = "0x180AE5EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x72DFBC0", Offset = "0x72DE1C0", VA = "0x1872DFBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float BHPIHBOKJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x96BDD0", Offset = "0x96A3D0", VA = "0x18096BDD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5F46550", Offset = "0x5F44B50", VA = "0x185F46550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x72E01D0", Offset = "0x72DE7D0", VA = "0x1872E01D0")]
	public PKOALCHHCBJ(IEnumerator<FDDBCEBEBAE> KBLLKJMCLOD, JIHLMCFJIGF MGIHCPMKPNG, ONJAMOMOHMM PNHJHEEKKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x72DFDE0", Offset = "0x72DE3E0", VA = "0x1872DFDE0")]
	public FDDBCEBEBAE ONGDOPEFPJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x72DFD70", Offset = "0x72DE370", VA = "0x1872DFD70")]
	public bool LJBIKNGFADP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x72DFB70", Offset = "0x72DE170", VA = "0x1872DFB70")]
	public void CKNDFKENKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x72E00F0", Offset = "0x72DE6F0", VA = "0x1872E00F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xB64600", Offset = "0xB62C00", VA = "0x180B64600")]
	[CompilerGenerated]
	private void DKFFNOFAFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class ONJAMOMOHMM : BBJCIAFCPAB, MCOHGCAFPBM, JIMPAEGGIFL, MKEIEIBMPOE, IEnumerator, FDDBCEBEBAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private OFIIIOIBNHO GPLNLOEJPCD;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private OFIIIOIBNHO ELJPOOHBFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x10F2A90", Offset = "0x10F1090", VA = "0x1810F2A90", Slot = "23")]
		get
		{
			return default(OFIIIOIBNHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public OFIIIOIBNHO NKDDFFLINBK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1639DF0", Offset = "0x16383F0", VA = "0x181639DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private float OPALJEODCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x964270", Offset = "0x962870", VA = "0x180964270", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool COPIAKPCEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x72DD9B0", Offset = "0x72DBFB0", VA = "0x1872DD9B0", Slot = "24")]
	private bool HBEHNMDBNLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x72DD9A0", Offset = "0x72DBFA0", VA = "0x1872DD9A0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x72DD9D0", Offset = "0x72DBFD0", VA = "0x1872DD9D0")]
	public ONJAMOMOHMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal enum NCJCEEHIOHD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal sealed class JHHANKCKBCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum JBJIPBGKADH
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct MBPKKKBFGKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public OFIIIOIBNHO KGIFGHPBEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public JBJIPBGKADH JKCLPEMFIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public List<PKOALCHHCBJ> LPIMCOMCLDF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly JBJIPBGKADH[] CPEHGLONGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly OFIIIOIBNHO KKKINOJGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private bool EFKLDFKEEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly PKOALCHHCBJ[] LKPNDNBLJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly List<PKOALCHHCBJ> LCMILDCCAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<int> BIOICMFNLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<PKOALCHHCBJ> BIDLPMFBLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Stack<int> FMGELDACKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly GHELGPHLHED ANMIMDAFHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private bool PDCOMJHMCFG;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public MBPKKKBFGKF[,] LICCJKHBPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x72D4A40", Offset = "0x72D3040", VA = "0x1872D4A40")]
	public JHHANKCKBCP(OFIIIOIBNHO PLFCIPAANHJ, GHELGPHLHED ANMIMDAFHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x72D3920", Offset = "0x72D1F20", VA = "0x1872D3920")]
	public void DMDLNOLCION(PKOALCHHCBJ KBLLKJMCLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x72D44A0", Offset = "0x72D2AA0", VA = "0x1872D44A0")]
	public void OPADEFJBEFC(IList<PKOALCHHCBJ> CIPNBEOIBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x72D3D30", Offset = "0x72D2330", VA = "0x1872D3D30")]
	public void IIEPOJKKJHA(IList<PKOALCHHCBJ> CIPNBEOIBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x72D36C0", Offset = "0x72D1CC0", VA = "0x1872D36C0")]
	private void BIMICMLIKKL(PKOALCHHCBJ KBLLKJMCLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x72D4320", Offset = "0x72D2920", VA = "0x1872D4320")]
	private void NHNLJINIFBK(IList<PKOALCHHCBJ> CIPNBEOIBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x72D4790", Offset = "0x72D2D90", VA = "0x1872D4790")]
	private NCJCEEHIOHD PGADLIFAHPJ(PKOALCHHCBJ KBLLKJMCLOD)
	{
		return default(NCJCEEHIOHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x72D37B0", Offset = "0x72D1DB0", VA = "0x1872D37B0")]
	public void CCBJGFJMACJ(float KHKDAGALAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x72D3B40", Offset = "0x72D2140", VA = "0x1872D3B40")]
	public void EKICGOEBPHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x72D4020", Offset = "0x72D2620", VA = "0x1872D4020")]
	private void NEAIBMPICIK(List<PKOALCHHCBJ> CIPNBEOIBCF, Stack<int> JBHNFAFMPJL, bool PMNNAAAIHLD, float LFMFOJPOBNP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x72D3A20", Offset = "0x72D2020", VA = "0x1872D3A20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x72D3580", Offset = "0x72D1B80", VA = "0x1872D3580")]
	private void APFJFFGJKAF(List<PKOALCHHCBJ> CIPNBEOIBCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class MPBOGMFBIMF : GHELGPHLHED
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
	public void AFNLNHEFIHG(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
	public void IAKBMAFHLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MPBOGMFBIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class LGELGLEEGMH : JIHLMCFJIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Behaviour NCLGKFFOINP;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72D9BD0", Offset = "0x72D81D0", VA = "0x1872D9BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool ADAIPAMBJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x72D9C50", Offset = "0x72D8250", VA = "0x1872D9C50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool OBJGMHOEKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x72D9CA0", Offset = "0x72D82A0", VA = "0x1872D9CA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public LGELGLEEGMH(Behaviour NCLGKFFOINP)
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

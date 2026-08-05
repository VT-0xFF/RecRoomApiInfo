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
public class BLFBDJGMPNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority FFMPLFNBLMI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63637D0", Offset = "0x6361FD0", VA = "0x1863637D0")]
	public BLFBDJGMPNJ(ThreadPriority NMJAHJIMGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63637C0", Offset = "0x6361FC0", VA = "0x1863637C0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> MBPHBLPBINL(List<PlayerLoopSystem> FOCFONOKHED, int PNMMECDJKNB);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct LPEGIFHLGLK
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct MDCKJMBMKKA
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static BJPMGBAMGNN BDAKJNHFPOJ;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6374DD0", Offset = "0x63735D0", VA = "0x186374DD0")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct ONDPKDLAIBG
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static BJPMGBAMGNN OEJCFFFPADN;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6379DA0", Offset = "0x63785A0", VA = "0x186379DA0")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct KEBHIPEEMPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static BJPMGBAMGNN HJBHOFKCOBO;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6372A10", Offset = "0x6371210", VA = "0x186372A10")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct MFHCIFKEDFO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BJPMGBAMGNN JCKOADMPPDJ;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BJPMGBAMGNN DMAFOOHCCCK;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BJPMGBAMGNN CBPKKAOIDHK;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static BJPMGBAMGNN EPLLINBBKJO;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6375290", Offset = "0x6373A90", VA = "0x186375290")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct KAOAGMCOPOK
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static BJPMGBAMGNN IAJBBPCHFKM;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x63724F0", Offset = "0x6370CF0", VA = "0x1863724F0")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct DEIPFPLCAMC
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BJPMGBAMGNN JCKOADMPPDJ;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BJPMGBAMGNN DMAFOOHCCCK;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BJPMGBAMGNN CBPKKAOIDHK;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static BJPMGBAMGNN EPLLINBBKJO;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x636A240", Offset = "0x6368A40", VA = "0x18636A240")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct FPPFGMOFHJD
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static BJPMGBAMGNN FOAGDNEBHFP;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x636EA40", Offset = "0x636D240", VA = "0x18636EA40")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct MPBDJJOCIBL
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static BJPMGBAMGNN LEPFNBJGLCF;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6375970", Offset = "0x6374170", VA = "0x186375970")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct DJHIHPLPDNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static BJPMGBAMGNN GFGJDBKCLJL;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x636A590", Offset = "0x6368D90", VA = "0x18636A590")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct KBEBMABJHBE
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static BJPMGBAMGNN FIONGOLFAIO;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x63726F0", Offset = "0x6370EF0", VA = "0x1863726F0")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct MJFJMLCPPOP
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static BJPMGBAMGNN NPAMBHMLAEK;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6375640", Offset = "0x6373E40", VA = "0x186375640")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct PKFMJGJKHOD
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static BJPMGBAMGNN OLHKCFCFLCA;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x637BE50", Offset = "0x637A650", VA = "0x18637BE50")]
				public static PlayerLoopSystem MFGEOJLIBLK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum ADOEKKJLAIA : byte
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
			public struct AAIEHGLJGMK
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class OMAPCGPAILA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public ADOEKKJLAIA updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
					public OMAPCGPAILA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x6379D20", Offset = "0x6378520", VA = "0x186379D20")]
					internal void LOHOKDNAODM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static MBOBMBMLJPH<ADOEKKJLAIA> ALLHPEMENHD;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6361290", Offset = "0x635FA90", VA = "0x186361290")]
				public static PlayerLoopSystem MFGEOJLIBLK(ADOEKKJLAIA IJEPMBBEHAC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct MLIDKEPKEPB
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class PKBEMEMAPCM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public FALJMEHMHBJ.FONHIGFABND key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
					public PKBEMEMAPCM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x637BC10", Offset = "0x637A410", VA = "0x18637BC10")]
					internal void ILOMIPBJELC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable LOKOMDDMBIN;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6375840", Offset = "0x6374040", VA = "0x186375840")]
				public static PlayerLoopSystem JLPAKFONJMM(FALJMEHMHBJ.FONHIGFABND OHPCNPKOLBJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct OJMGOMOACMM
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class MFBLNFLAPFK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public FALJMEHMHBJ.FONHIGFABND key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
					public MFBLNFLAPFK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x6375020", Offset = "0x6373820", VA = "0x186375020")]
					internal void ILOMIPBJELC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6379BC0", Offset = "0x63783C0", VA = "0x186379BC0")]
				public static PlayerLoopSystem JLPAKFONJMM(FALJMEHMHBJ.FONHIGFABND OHPCNPKOLBJ)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class EPNPHNAAPBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public EPNPHNAAPBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x636DCA0", Offset = "0x636C4A0", VA = "0x18636DCA0")]
			internal List<PlayerLoopSystem> KEIBLNAJCGE(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OMDFIMOPJOG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool LJGGGHPFFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6368FA0", Offset = "0x63677A0", VA = "0x186368FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6366670", Offset = "0x6364E70", VA = "0x186366670")]
		private static void HNIAIKKNMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6368FE0", Offset = "0x63677E0", VA = "0x186368FE0")]
		private static void PCCGGCGENPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6365D70", Offset = "0x6364570", VA = "0x186365D70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6365FA0", Offset = "0x63647A0", VA = "0x186365FA0")]
		private static void DDOAEBDOKAM(FALJMEHMHBJ.FONHIGFABND OHPCNPKOLBJ, PlayerLoopSystem EPKOMAPLHLK, Type OABBKBOELKC, Type NDOJGDHFIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6366160", Offset = "0x6364960", VA = "0x186366160")]
		private static void EFMFOCNEDFC(PlayerLoopSystem EPKOMAPLHLK, Type OABBKBOELKC, Type NDOJGDHFIOD, MBPHBLPBINL ONCEAIDPMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6366540", Offset = "0x6364D40", VA = "0x186366540")]
		private static void HIFNMHBKAAP(PlayerLoopSystem EPKOMAPLHLK, Type OABBKBOELKC, Type NDOJGDHFIOD, PlayerLoopSystem? EENHOPLJJLL, PlayerLoopSystem? MLFGGOCBIAN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FALJMEHMHBJ
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum FONHIGFABND
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
	public class JKNLKJIAKBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly FONHIGFABND EHDKCMLPJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly LFJJAKDBBJK ALDBONKCHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long OECIMPBJPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long GJENEGKDHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long PMAFOFPELBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int AEHPBNJIEKO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x63708E0", Offset = "0x636F0E0", VA = "0x1863708E0")]
		public JKNLKJIAKBD(FONHIGFABND LIIALJLCNPC, int OIJFEEFBOKI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6370870", Offset = "0x636F070", VA = "0x186370870")]
		public void OOJAHBLFLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6370640", Offset = "0x636EE40", VA = "0x186370640")]
		public void IDJENGPHDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6370690", Offset = "0x636EE90", VA = "0x186370690")]
		public void KPIGIPLOJHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static FONHIGFABND[] DLAMDLIJOJI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static JKNLKJIAKBD[] NFOKNEPJGMJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x636DE30", Offset = "0x636C630", VA = "0x18636DE30")]
	public static JKNLKJIAKBD HGFGCAJFONO(FONHIGFABND OHPCNPKOLBJ, int OIJFEEFBOKI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x636DDC0", Offset = "0x636C5C0", VA = "0x18636DDC0")]
	public static JKNLKJIAKBD BLMHGJCGONI(FONHIGFABND OHPCNPKOLBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x636E010", Offset = "0x636C810", VA = "0x18636E010")]
	public static void LDBEPBDJKMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LFJJAKDBBJK : OJHKJFKJOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int LOLOPAEDFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> HAMIGOFCIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double NBPDHCAMINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double JEGKJPODFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double DFOBPGMOMMC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double EFPCFKDNLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6374BA0", Offset = "0x63733A0", VA = "0x186374BA0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double BBEKDHDCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1615510", Offset = "0x1613D10", VA = "0x181615510", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EJIPIIAAPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1BFC3B0", Offset = "0x1BFABB0", VA = "0x181BFC3B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6374C00", Offset = "0x6373400", VA = "0x186374C00")]
	public LFJJAKDBBJK(int HGBPLBEOLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6374A10", Offset = "0x6373210", VA = "0x186374A10", Slot = "7")]
	public void CMILMKENEMI(double LLMHDPLKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6374B30", Offset = "0x6373330", VA = "0x186374B30", Slot = "8")]
	public void FCKDKLKEHNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IBLEMPAICLG : OJHKJFKJOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long EHGKBCBKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double GGMBBMACBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double EHLECEBBJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double KJFANBMFNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double PGBALGCBNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double NBPDHCAMINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double JEGKJPODFLL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BBEKDHDCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x538BFC0", Offset = "0x538A7C0", VA = "0x18538BFC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EJIPIIAAPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x538BF80", Offset = "0x538A780", VA = "0x18538BF80", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MGGILOJIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x538BB00", Offset = "0x538A300", VA = "0x18538BB00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double EFPCFKDNLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6410", Offset = "0x1FB4C10", VA = "0x181FB6410", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x63701E0", Offset = "0x636E9E0", VA = "0x1863701E0", Slot = "7")]
	public virtual void CMILMKENEMI(double LLMHDPLKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6370300", Offset = "0x636EB00", VA = "0x186370300", Slot = "8")]
	public virtual void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6362B40", Offset = "0x6361340", VA = "0x186362B40")]
	public IBLEMPAICLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AKOBGJDCIOL : IBLEMPAICLG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double MCKFFABGCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x538BFE0", Offset = "0x538A7E0", VA = "0x18538BFE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x538BB10", Offset = "0x538A310", VA = "0x18538BB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63629D0", Offset = "0x63611D0", VA = "0x1863629D0", Slot = "7")]
	public override void CMILMKENEMI(double LLMHDPLKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6362B00", Offset = "0x6361300", VA = "0x186362B00", Slot = "8")]
	public override void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6362B40", Offset = "0x6361340", VA = "0x186362B40")]
	public AKOBGJDCIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OJHKJFKJOFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double EFPCFKDNLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double BBEKDHDCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double EJIPIIAAPLG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class GOJJJDIHFBB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface OLPILDACHOE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool GOBBBDCFFLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ACJKICPGHOE();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class BFCHCANAKNP<TPromise, TMainThreadPromise> : OLPILDACHOE where TPromise : CPOBDANHFCI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise BAJMLKIDADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise MBGHDJGHPON;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise LIGLMJKJBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x43F26E0", Offset = "0x43F0EE0", VA = "0x1843F26E0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GOBBBDCFFLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x43F2690", Offset = "0x43F0E90", VA = "0x1843F2690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
		protected BFCHCANAKNP(TPromise BAJMLKIDADG, TMainThreadPromise FENLDGDCJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x43F2670", Offset = "0x43F0E70", VA = "0x1843F2670", Slot = "5")]
		public void ACJKICPGHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EDFCLHJJEFG(TPromise BAJMLKIDADG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FHHBNLNGBLD<T> : BFCHCANAKNP<NLPPPLCCBHA<T>, DCJEPGNABII<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3414850", Offset = "0x3413050", VA = "0x183414850")]
		public FHHBNLNGBLD(NLPPPLCCBHA<T> BAJMLKIDADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3414610", Offset = "0x3412E10", VA = "0x183414610", Slot = "6")]
		protected override void EDFCLHJJEFG(NLPPPLCCBHA<T> BAJMLKIDADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x30ADF20", Offset = "0x30AC720", VA = "0x1830ADF20")]
		[CompilerGenerated]
		private void CDJLOABJBOD(T KMHAEDONIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3414820", Offset = "0x3413020", VA = "0x183414820")]
		[CompilerGenerated]
		private void MNJNIEJFGDI(string HLPKEEDLIBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FOBMNBOLGIC : OLPILDACHOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action OONIIOMBHJI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GOBBBDCFFLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
		public FOBMNBOLGIC(Action OONIIOMBHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xACECC0", Offset = "0xACD4C0", VA = "0x180ACECC0", Slot = "5")]
		public void ACJKICPGHOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<OLPILDACHOE> PHACDCEAFNE;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2365D30", Offset = "0x2364530", VA = "0x182365D30")]
	public static NLPPPLCCBHA<T> NJFGFEIJDKG<T>(this NLPPPLCCBHA<T> BAJMLKIDADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x636F920", Offset = "0x636E120", VA = "0x18636F920")]
	public static void NJFGFEIJDKG(Action OONIIOMBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2365C70", Offset = "0x2364470", VA = "0x182365C70")]
	private static NLPPPLCCBHA<T> EMEPFIPOGHK<T>(NLPPPLCCBHA<T> BAJMLKIDADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x636F250", Offset = "0x636DA50", VA = "0x18636F250")]
	private static void CCGMHOJINGI(OLPILDACHOE BIICNKJAIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x636F460", Offset = "0x636DC60", VA = "0x18636F460")]
	private static void EKBPMHFKLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x636F740", Offset = "0x636DF40", VA = "0x18636F740")]
	private static void HOIHCNJCHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x636F840", Offset = "0x636E040", VA = "0x18636F840")]
	private static void MPIJEIKKNBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KKFGCNMGEOP
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct DGMKDGKBMLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> BKHHJKBGFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string JACEFLIJGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode BLMEMLNDLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool POPOELKFFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x636A530", Offset = "0x6368D30", VA = "0x18636A530")]
		public DGMKDGKBMLG(TaskCompletionSource<Scene> PBJEENFPOAA, string JACEFLIJGKH, LoadSceneMode BLMEMLNDLJL, bool POPOELKFFIE, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BFNIAGOBACK : IAsyncStateMachine
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
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private ANHHFLMKBPC<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x6362EB0", Offset = "0x63616B0", VA = "0x186362EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6363750", Offset = "0x6361F50", VA = "0x186363750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EEFPHHPKGKJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x636B9A0", Offset = "0x636A1A0", VA = "0x18636B9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x636BCC0", Offset = "0x636A4C0", VA = "0x18636BCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct KLCGFJCMDMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private DGMKDGKBMLG <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6374520", Offset = "0x6372D20", VA = "0x186374520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63748D0", Offset = "0x63730D0", VA = "0x1863748D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FLCEHMODNAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DCJEPGNABII<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FLCEHMODNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x636E8D0", Offset = "0x636D0D0", VA = "0x18636E8D0")]
		internal void MBLHMDIOOHM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ADFOCOOCNMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

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
		private FLCEHMODNAL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6361460", Offset = "0x635FC60", VA = "0x186361460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6362000", Offset = "0x6360800", VA = "0x186362000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct AJHHHOEOHOF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6362450", Offset = "0x6360C50", VA = "0x186362450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6362960", Offset = "0x6361160", VA = "0x186362960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct CMJAFLBKKHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ANHHFLMKBPC<string>.AJPBBELKCKG stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private ANHHFLMKBPC<string>.AJPBBELKCKG <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6364A30", Offset = "0x6363230", VA = "0x186364A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6365580", Offset = "0x6363D80", VA = "0x186365580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OLPDBBFNMCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public OLPDBBFNMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6379CF0", Offset = "0x63784F0", VA = "0x186379CF0")]
		internal bool OIDPKAFKCAN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NCHBJMPCIKM : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public FBEIGKILPLF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public NCHBJMPCIKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6378DF0", Offset = "0x63775F0", VA = "0x186378DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6378A10", Offset = "0x6377210", VA = "0x186378A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6378D50", Offset = "0x6377550", VA = "0x186378D50")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6378DA0", Offset = "0x63775A0", VA = "0x186378DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BECPEBCOLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public DCJEPGNABII<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BECPEBCOLBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6362E30", Offset = "0x6361630", VA = "0x186362E30")]
		internal bool LAFNLELOIGO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6362BB0", Offset = "0x63613B0", VA = "0x186362BB0")]
		internal void CIFBPHLEEIA(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DDLKEMNDHKH : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public DCJEPGNABII<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private BECPEBCOLBN <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public DDLKEMNDHKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6369AE0", Offset = "0x63682E0", VA = "0x186369AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x636A1F0", Offset = "0x63689F0", VA = "0x18636A1F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> FIGCFIIKALF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static CPOBDANHFCI IOCFCGIKGHE;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation GCKIGNCFGJP;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static CPOBDANHFCI AIOPILJKLEN;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string IJBDPOGBFCL;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority IPLADBIJPHM;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task EOCAJBLABLA;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> HAPKIIIEAPK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<DGMKDGKBMLG> OOJEPGPPEBD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task JEPLOOCEJFD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IOMAPIIHGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6373890", Offset = "0x6372090", VA = "0x186373890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool LBCACIPJNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6373520", Offset = "0x6371D20", VA = "0x186373520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool MFMAOHMCCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6373F50", Offset = "0x6372750", VA = "0x186373F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool DHHBIIDPAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6372E80", Offset = "0x6371680", VA = "0x186372E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KEAAFGHCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6372C10", Offset = "0x6371410", VA = "0x186372C10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6373020", Offset = "0x6371820", VA = "0x186373020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6373E50", Offset = "0x6372650", VA = "0x186373E50")]
	[GDLMDJGGJNB(KNIGDGBBDKN.EnteredEditModeNextFrame, 0)]
	private static void MLPBOICFPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6373FF0", Offset = "0x63727F0", VA = "0x186373FF0")]
	[AsyncStateMachine(typeof(BFNIAGOBACK))]
	public static Task<Scene> ONCIPIGKPBE(string JACEFLIJGKH, LoadSceneMode BLMEMLNDLJL = LoadSceneMode.Single, bool POPOELKFFIE = false, [Optional] ANHHFLMKBPC<string>.AJPBBELKCKG OMKMGKBOOMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6373470", Offset = "0x6371C70", VA = "0x186373470")]
	[AsyncStateMachine(typeof(EEFPHHPKGKJ))]
	private static Task IDFAFKGNBBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6372D20", Offset = "0x6371520", VA = "0x186372D20")]
	[AsyncStateMachine(typeof(KLCGFJCMDMK))]
	private static Task AGGLKPLIDJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6373C10", Offset = "0x6372410", VA = "0x186373C10")]
	[AsyncStateMachine(typeof(ADFOCOOCNMI))]
	private static Task<Scene> LHLMCHCPJJF(string JACEFLIJGKH, LoadSceneMode BLMEMLNDLJL, bool POPOELKFFIE, ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6373AB0", Offset = "0x63722B0", VA = "0x186373AB0")]
	private static void KEJFMLLAJGL(SceneInstance IALEADLNNLH, LoadSceneMode BLMEMLNDLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6374270", Offset = "0x6372A70", VA = "0x186374270")]
	private static void PHIGGPOFKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x63731D0", Offset = "0x63719D0", VA = "0x1863731D0")]
	[AsyncStateMachine(typeof(AJHHHOEOHOF))]
	private static Task<Scene> GHAJCODBKNM(string JACEFLIJGKH, LoadSceneMode BLMEMLNDLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6373D60", Offset = "0x6372560", VA = "0x186373D60")]
	private static bool LJIEFGEPBPM(string JACEFLIJGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6372F10", Offset = "0x6371710", VA = "0x186372F10")]
	[AsyncStateMachine(typeof(CMJAFLBKKHF))]
	private static Task<Scene> DPBAEIPGHOE(ANHHFLMKBPC<string>.AJPBBELKCKG EPPMBEIGFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x63732F0", Offset = "0x6371AF0", VA = "0x1863732F0")]
	public static NLPPPLCCBHA<Scene> HBJIMGGHOED(string JACEFLIJGKH, LoadSceneMode BLMEMLNDLJL = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x63735C0", Offset = "0x6371DC0", VA = "0x1863735C0")]
	public static CPOBDANHFCI IKKNEBJKCIP(string JACEFLIJGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6372DF0", Offset = "0x63715F0", VA = "0x186372DF0")]
	[IteratorStateMachine(typeof(NCHBJMPCIKM))]
	private static IEnumerator<DENFKKKFFPI> DCMOFLKOIKG(string JACEFLIJGKH, FBEIGKILPLF KLBGBPGKAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6373130", Offset = "0x6371930", VA = "0x186373130")]
	[IteratorStateMachine(typeof(DDLKEMNDHKH))]
	private static IEnumerator<DENFKKKFFPI> FDKLPBKDPFF(string JACEFLIJGKH, LoadSceneMode BLMEMLNDLJL, DCJEPGNABII<Scene> KLBGBPGKAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6374140", Offset = "0x6372940", VA = "0x186374140")]
	public static bool PGDLLPGBCFJ([Out] string BOHKGBHEBPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PLJHLDIKMIH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x637C050", Offset = "0x637A850", VA = "0x18637C050")]
	public static IDisposable IGFPDOODGAG(this BJPHJOMINEO FJNGJOFLBMD, float DJLEJAPDDMO, Action<float> CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x637C160", Offset = "0x637A960", VA = "0x18637C160")]
	public static IDisposable MMNAHOEMAOF(this BJPHJOMINEO FJNGJOFLBMD, Action<float> CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x637C0E0", Offset = "0x637A8E0", VA = "0x18637C0E0")]
	public static IDisposable MCKINOIEKJB(this BJPHJOMINEO FJNGJOFLBMD, Action<float> CPAELIEJCIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OADBMNFBEGI
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63797D0", Offset = "0x6377FD0", VA = "0x1863797D0")]
	public static IDisposable PFLNKCPEBDG(this MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6379860", Offset = "0x6378060", VA = "0x186379860")]
	public static IDisposable PFLNKCPEBDG(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63790F0", Offset = "0x63778F0", VA = "0x1863790F0")]
	public static IDisposable IDAKBLNHKFP(this MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6379070", Offset = "0x6377870", VA = "0x186379070")]
	public static IDisposable BJCOGLJOKLA(this MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6379350", Offset = "0x6377B50", VA = "0x186379350")]
	public static IDisposable MDHPIDLBGLO(this MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6379630", Offset = "0x6377E30", VA = "0x186379630")]
	public static IDisposable OHGNDNEBEFM(this MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x63793D0", Offset = "0x6377BD0", VA = "0x1863793D0")]
	public static IDisposable MFMLCLDHPMP(this MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6378FC0", Offset = "0x63777C0", VA = "0x186378FC0")]
	public static IDisposable BEAGEGNONGG(this MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x63796B0", Offset = "0x6377EB0", VA = "0x1863796B0")]
	public static IDisposable PDCNPJPAFIA(this MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6379450", Offset = "0x6377C50", VA = "0x186379450")]
	public static IDisposable MIPDHMLINAI(this MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6378E80", Offset = "0x6377680", VA = "0x186378E80")]
	public static IDisposable ACIAKKHDKBO(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6379170", Offset = "0x6377970", VA = "0x186379170")]
	public static IDisposable JFKBDMNLKMJ(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6379590", Offset = "0x6377D90", VA = "0x186379590")]
	public static IDisposable ODLKBNOEPLF(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x63794F0", Offset = "0x6377CF0", VA = "0x1863794F0")]
	public static IDisposable NMPOLLMDCGF(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63792B0", Offset = "0x6377AB0", VA = "0x1863792B0")]
	public static IDisposable LIIIFJAHCFI(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6379210", Offset = "0x6377A10", VA = "0x186379210")]
	public static IDisposable KANJDBAHGGO(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6378F20", Offset = "0x6377720", VA = "0x186378F20")]
	public static IDisposable AEBBDNJJDPJ(this MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x63798F0", Offset = "0x63780F0", VA = "0x1863798F0")]
	public static IDisposable PFOCEBEDFBO(this MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ADPMHJEMCDB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PJPJPFEGBNE : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JGKDNNHAPDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private ELIJBFMGOAK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public PJPJPFEGBNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x637BAE0", Offset = "0x637A2E0", VA = "0x18637BAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x637BBC0", Offset = "0x637A3C0", VA = "0x18637BBC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class KAMKOCAFPIG : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public JGKDNNHAPDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private ELIJBFMGOAK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public KAMKOCAFPIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x63723B0", Offset = "0x6370BB0", VA = "0x1863723B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x63724A0", Offset = "0x6370CA0", VA = "0x1863724A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6362250", Offset = "0x6360A50", VA = "0x186362250")]
	public static GCEJIALBLON PFLNKCPEBDG(Action CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6362190", Offset = "0x6360990", VA = "0x186362190")]
	public static GCEJIALBLON PFLNKCPEBDG(Behaviour FJNGJOFLBMD, Action CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6362300", Offset = "0x6360B00", VA = "0x186362300")]
	public static GCEJIALBLON PFLNKCPEBDG(Behaviour FJNGJOFLBMD, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6362100", Offset = "0x6360900", VA = "0x186362100")]
	[IteratorStateMachine(typeof(PJPJPFEGBNE))]
	private static IEnumerator<DENFKKKFFPI> JFLOAOHCGGE(JGKDNNHAPDI IKEMBHLKPGK, Action CPAELIEJCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6362070", Offset = "0x6360870", VA = "0x186362070")]
	[IteratorStateMachine(typeof(KAMKOCAFPIG))]
	private static IEnumerator<DENFKKKFFPI> JFLOAOHCGGE(JGKDNNHAPDI IKEMBHLKPGK, Action<float> CPAELIEJCIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DCKCFPCDBCL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KLMEBGKFBPN : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public DCKCFPCDBCL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public KLMEBGKFBPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6374930", Offset = "0x6373130", VA = "0x186374930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x63749C0", Offset = "0x63731C0", VA = "0x1863749C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JGKDNNHAPDI KEKEKOGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action AODNDEMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool JFONNOLOJIA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BPOJGNBFEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76E480", Offset = "0x76CC80", VA = "0x18076E480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x63699D0", Offset = "0x63681D0", VA = "0x1863699D0")]
	public DCKCFPCDBCL(JGKDNNHAPDI KEKEKOGBDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x63698B0", Offset = "0x63680B0", VA = "0x1863698B0")]
	[IteratorStateMachine(typeof(KLMEBGKFBPN))]
	private IEnumerator<DENFKKKFFPI> KCNKAIMPNNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6369930", Offset = "0x6368130", VA = "0x186369930", Slot = "4")]
	public void OnCompleted(Action BBABPBKNAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	public void MLIHKFKLEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class PINOBCIHKJG
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x637B9A0", Offset = "0x637A1A0", VA = "0x18637B9A0")]
	public static DCKCFPCDBCL CNPPKHCHJBE(this JGKDNNHAPDI KEKEKOGBDLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CHHLAOFNLMK
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NBIOBBLGBAB : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public PJFNEEDJAMF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public NBIOBBLGBAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6378940", Offset = "0x6377140", VA = "0x186378940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x63789C0", Offset = "0x63771C0", VA = "0x1863789C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6364930", Offset = "0x6363130", VA = "0x186364930")]
	public static GCEJIALBLON PFLNKCPEBDG(float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6364820", Offset = "0x6363020", VA = "0x186364820")]
	public static GCEJIALBLON PFLNKCPEBDG(MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6364530", Offset = "0x6362D30", VA = "0x186364530")]
	public static GCEJIALBLON JDPCDKMPLGH(MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6364710", Offset = "0x6362F10", VA = "0x186364710")]
	public static GCEJIALBLON LDFCAAGCLOC(BJPHJOMINEO FJNGJOFLBMD, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6364650", Offset = "0x6362E50", VA = "0x186364650")]
	private static IEnumerator<DENFKKKFFPI> JFLOAOHCGGE(LCLPNDLPDOM IJCMIBOIMNO, float DJLEJAPDDMO, JGKDNNHAPDI IKEMBHLKPGK, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x63644D0", Offset = "0x6362CD0", VA = "0x1863644D0")]
	private static IEnumerator<DENFKKKFFPI> JADMOIPFGMP(LCLPNDLPDOM IJCMIBOIMNO, float DJLEJAPDDMO, JGKDNNHAPDI IKEMBHLKPGK, Action<float> CPAELIEJCIB, bool MBDKJFCJJBN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6364440", Offset = "0x6362C40", VA = "0x186364440")]
	[IteratorStateMachine(typeof(NBIOBBLGBAB))]
	private static IEnumerator<DENFKKKFFPI> FAFIKMKDFOH(PJFNEEDJAMF MGFADFINGED, float DJLEJAPDDMO, JGKDNNHAPDI IKEMBHLKPGK, Action<float> CPAELIEJCIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IHKIICPDGFC
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class FPAEFGAAJLO : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public JGKDNNHAPDI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public FPAEFGAAJLO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x636E930", Offset = "0x636D130", VA = "0x18636E930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x636E9F0", Offset = "0x636D1F0", VA = "0x18636E9F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6370340", Offset = "0x636EB40", VA = "0x186370340")]
	[IteratorStateMachine(typeof(FPAEFGAAJLO))]
	private static IEnumerator<DENFKKKFFPI> KENGIJDEDFB(JGKDNNHAPDI KEKEKOGBDLA, Func<bool> AGJELNEAJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x63703D0", Offset = "0x636EBD0", VA = "0x1863703D0")]
	public static GCEJIALBLON MNHPMIFDIMG(this MonoBehaviour MNJFIIDDKBO, Func<bool> AGJELNEAJON, JGKDNNHAPDI KEKEKOGBDLA = JGKDNNHAPDI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class DLPAJGELKAG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class MGGFLOHBICD : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public JGKDNNHAPDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public MGGFLOHBICD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6375580", Offset = "0x6373D80", VA = "0x186375580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63755F0", Offset = "0x6373DF0", VA = "0x1863755F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HCFDAPJEFEE : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public JGKDNNHAPDI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private DENFKKKFFPI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public HCFDAPJEFEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6370100", Offset = "0x636E900", VA = "0x186370100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6370190", Offset = "0x636E990", VA = "0x186370190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x636ACD0", Offset = "0x63694D0", VA = "0x18636ACD0")]
	[IteratorStateMachine(typeof(MGGFLOHBICD))]
	private static IEnumerator<DENFKKKFFPI> KCNKAIMPNNE(float HAHNMEKBEPD, JGKDNNHAPDI IKEMBHLKPGK, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x636B0B0", Offset = "0x63698B0", VA = "0x18636B0B0")]
	[IteratorStateMachine(typeof(HCFDAPJEFEE))]
	private static IEnumerator<DENFKKKFFPI> NFGHBDOIDLA(float HAHNMEKBEPD, JGKDNNHAPDI IKEMBHLKPGK, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x636A880", Offset = "0x6369080", VA = "0x18636A880")]
	public static IDisposable EMBPEFLGEIA(this MonoBehaviour MNJFIIDDKBO, float HAHNMEKBEPD, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x636ABE0", Offset = "0x63693E0", VA = "0x18636ABE0")]
	public static GCEJIALBLON IGHDOCJIBOP(this MonoBehaviour MNJFIIDDKBO, float HAHNMEKBEPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x636A9A0", Offset = "0x63691A0", VA = "0x18636A9A0")]
	public static GCEJIALBLON EMBPEFLGEIA(this MonoBehaviour MNJFIIDDKBO, float HAHNMEKBEPD, JGKDNNHAPDI IKEMBHLKPGK, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x636A790", Offset = "0x6368F90", VA = "0x18636A790")]
	public static GCEJIALBLON AJCFPHNBKPL(this MonoBehaviour MNJFIIDDKBO, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x636B180", Offset = "0x6369980", VA = "0x18636B180")]
	public static GCEJIALBLON OFOFKDGFODI(this MonoBehaviour MNJFIIDDKBO, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x636AAD0", Offset = "0x63692D0", VA = "0x18636AAD0")]
	public static GCEJIALBLON HEELLCGDIBJ(this MonoBehaviour MNJFIIDDKBO, Action KFJLELLEOLL, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x636B150", Offset = "0x6369950", VA = "0x18636B150")]
	public static GCEJIALBLON NPFCDJKODFC(this MonoBehaviour MNJFIIDDKBO, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x636ABB0", Offset = "0x63693B0", VA = "0x18636ABB0")]
	public static GCEJIALBLON HEFPKHAMPKB(this MonoBehaviour MNJFIIDDKBO, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x636ACA0", Offset = "0x63694A0", VA = "0x18636ACA0")]
	public static GCEJIALBLON JJBGFPHCBPH(this MonoBehaviour MNJFIIDDKBO, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x636A7B0", Offset = "0x6368FB0", VA = "0x18636A7B0")]
	private static GCEJIALBLON CLFKDKHBBBC(MonoBehaviour MNJFIIDDKBO, JGKDNNHAPDI KEKEKOGBDLA, Action KFJLELLEOLL, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x636AD70", Offset = "0x6369570", VA = "0x18636AD70")]
	public static GCEJIALBLON KIFELNOAHPE(this MonoBehaviour MNJFIIDDKBO, float KEDFADMHMEH, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x636AF10", Offset = "0x6369710", VA = "0x18636AF10")]
	public static GCEJIALBLON MPBJIICPFMF(this MonoBehaviour MNJFIIDDKBO, float KEDFADMHMEH, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x636AE40", Offset = "0x6369640", VA = "0x18636AE40")]
	public static GCEJIALBLON LHMCMIMHCON(this MonoBehaviour MNJFIIDDKBO, float KEDFADMHMEH, Action KFJLELLEOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x636AFE0", Offset = "0x63697E0", VA = "0x18636AFE0")]
	public static GCEJIALBLON NBDPIHMHJHO(this MonoBehaviour MNJFIIDDKBO, float KEDFADMHMEH, Action KFJLELLEOLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EGEDJAEKDAG : EAJMBGCNADA, IEnumerable<EAJMBGCNADA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<EAJMBGCNADA> BJEFMHPBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool FEFAJIKBLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action DBDPCCLJPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ABFNNLLHOEL;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FIJOGNPBIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x636D6E0", Offset = "0x636BEE0", VA = "0x18636D6E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BFOEFIIJNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x636D8A0", Offset = "0x636C0A0", VA = "0x18636D8A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x636D940", Offset = "0x636C140", VA = "0x18636D940", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x636DB40", Offset = "0x636C340", VA = "0x18636DB40")]
	public EGEDJAEKDAG([Optional] Action DBDPCCLJPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x636D5B0", Offset = "0x636BDB0", VA = "0x18636D5B0")]
	public void BONJGFNEKBE(EAJMBGCNADA CAIHCAKGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x636D9E0", Offset = "0x636C1E0", VA = "0x18636D9E0")]
	private void OJOENBGIGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x636D5A0", Offset = "0x636BDA0", VA = "0x18636D5A0", Slot = "7")]
	public bool BIFLPNNBOBL(bool AKFFELDLHDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x636D290", Offset = "0x636BA90", VA = "0x18636D290", Slot = "8")]
	public bool BIFLPNNBOBL(Action OONIIOMBHJI, bool AKFFELDLHDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x636D820", Offset = "0x636C020", VA = "0x18636D820", Slot = "9")]
	public IEnumerator<EAJMBGCNADA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x636D820", Offset = "0x636C020", VA = "0x18636D820", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OIBGHNDBHHF : GONBCCNHANM
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ELOLEABFNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public OIBGHNDBHHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ELOLEABFNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6362420", Offset = "0x6360C20", VA = "0x186362420")]
		internal void PEPJNOLGNNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class AEAADHIDGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public OIBGHNDBHHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public AEAADHIDGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6362420", Offset = "0x6360C20", VA = "0x186362420")]
		internal void INMIIDKCHHB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float KKLNELIKBIJ;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x636BD60", Offset = "0x636A560", VA = "0x18636BD60")]
	public OIBGHNDBHHF(Behaviour FJNGJOFLBMD, float KKLNELIKBIJ, [Optional] Action DBDPCCLJPNC, [Optional] KHGOEJKDLML KOKEOGPCAPH, [Optional] LCLPNDLPDOM IJCMIBOIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x63799A0", Offset = "0x63781A0", VA = "0x1863799A0", Slot = "9")]
	protected override bool DKGOKCPFPLC(Action OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6379AB0", Offset = "0x63782B0", VA = "0x186379AB0", Slot = "10")]
	protected override bool EFDMMEGOAHK(Action OONIIOMBHJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EAJMBGCNADA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FIJOGNPBIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action BFOEFIIJNIM;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIFLPNNBOBL(bool AKFFELDLHDA = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIFLPNNBOBL(Action OONIIOMBHJI, bool AKFFELDLHDA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class GONBCCNHANM : EAJMBGCNADA
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class KDGDIHNNOLM : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GONBCCNHANM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public KDGDIHNNOLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x63728F0", Offset = "0x63710F0", VA = "0x1863728F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x63729C0", Offset = "0x63711C0", VA = "0x1863729C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour FJNGJOFLBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action DBDPCCLJPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private IFNBCJFCEDL IMPNNPGLFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly KHGOEJKDLML KOKEOGPCAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly LCLPNDLPDOM IJCMIBOIMNO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FIJOGNPBIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xDE1A60", Offset = "0xDE0260", VA = "0x180DE1A60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BFOEFIIJNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x636FC40", Offset = "0x636E440", VA = "0x18636FC40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x636FF60", Offset = "0x636E760", VA = "0x18636FF60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6370000", Offset = "0x636E800", VA = "0x186370000")]
	protected GONBCCNHANM(Behaviour FJNGJOFLBMD, [Optional] Action DBDPCCLJPNC, [Optional] KHGOEJKDLML KOKEOGPCAPH, [Optional] LCLPNDLPDOM IJCMIBOIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x636FA50", Offset = "0x636E250", VA = "0x18636FA50", Slot = "7")]
	public bool BIFLPNNBOBL(bool AKFFELDLHDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x636FAB0", Offset = "0x636E2B0", VA = "0x18636FAB0", Slot = "8")]
	public bool BIFLPNNBOBL(Action OONIIOMBHJI, bool AKFFELDLHDA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool DKGOKCPFPLC(Action OONIIOMBHJI);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EFDMMEGOAHK(Action OONIIOMBHJI);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x636FB10", Offset = "0x636E310", VA = "0x18636FB10")]
	protected void DANDDBIDOHA(Action OONIIOMBHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x636FCE0", Offset = "0x636E4E0", VA = "0x18636FCE0")]
	protected CPOBDANHFCI LAJNKLPIGIE(float JPFLHJGBBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x636FB30", Offset = "0x636E330", VA = "0x18636FB30")]
	private void EBJMIMEDMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x636FBB0", Offset = "0x636E3B0", VA = "0x18636FBB0")]
	[IteratorStateMachine(typeof(KDGDIHNNOLM))]
	private IEnumerator<DENFKKKFFPI> GALJGDCHPBF(float JPFLHJGBBEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x636FF20", Offset = "0x636E720", VA = "0x18636FF20")]
	[CompilerGenerated]
	private void NIBKEINBNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class MPIMEBOALPB : GONBCCNHANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float ANNPHMMBJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int EELAAAAGJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float FKDKNNFEPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] FABEANIBGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int OGDCKBEBGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6375DF0", Offset = "0x63745F0", VA = "0x186375DF0")]
	public MPIMEBOALPB(Behaviour FJNGJOFLBMD, float DEKIFHCCAJP, int EELAAAAGJMH, [Optional] Action DBDPCCLJPNC, float FKDKNNFEPDG = 0f, [Optional] KHGOEJKDLML KOKEOGPCAPH, [Optional] LCLPNDLPDOM IJCMIBOIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "9")]
	protected override bool DKGOKCPFPLC(Action OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6375B70", Offset = "0x6374370", VA = "0x186375B70", Slot = "10")]
	protected override bool EFDMMEGOAHK(Action OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6375D70", Offset = "0x6374570", VA = "0x186375D70")]
	private void GFFIOGDFDFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EFDAELJJAPI : GONBCCNHANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float KKLNELIKBIJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x636BD60", Offset = "0x636A560", VA = "0x18636BD60")]
	public EFDAELJJAPI(Behaviour FJNGJOFLBMD, float KKLNELIKBIJ, [Optional] Action DBDPCCLJPNC, [Optional] KHGOEJKDLML KOKEOGPCAPH, [Optional] LCLPNDLPDOM IJCMIBOIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "9")]
	protected override bool DKGOKCPFPLC(Action OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x636BD20", Offset = "0x636A520", VA = "0x18636BD20", Slot = "10")]
	protected override bool EFDMMEGOAHK(Action OONIIOMBHJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class PFADJLOLCJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class EIKAAFACKFN : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public EIKAAFACKFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x636DBE0", Offset = "0x636C3E0", VA = "0x18636DBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x636DC50", Offset = "0x636C450", VA = "0x18636DC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private GCEJIALBLON KDCOJBHAFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private BJPHJOMINEO FJNGJOFLBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> PGFAGBAHEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JGKDNNHAPDI KEKEKOGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float JMNPKJMEJIM;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x637B7C0", Offset = "0x6379FC0", VA = "0x18637B7C0")]
	public PFADJLOLCJN(BJPHJOMINEO FJNGJOFLBMD, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x637B620", Offset = "0x6379E20", VA = "0x18637B620")]
	private void OLPLCGKAIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x637B4C0", Offset = "0x6379CC0", VA = "0x18637B4C0")]
	private void LEDGODMGOBO(string HLPKEEDLIBL, Action DCPFEJNMILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x637B440", Offset = "0x6379C40", VA = "0x18637B440")]
	[IteratorStateMachine(typeof(EIKAAFACKFN))]
	private IEnumerator<DENFKKKFFPI> FEGFNBBJKOB(Action DCPFEJNMILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x637B3E0", Offset = "0x6379BE0", VA = "0x18637B3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x637B230", Offset = "0x6379A30", VA = "0x18637B230")]
	[CompilerGenerated]
	private void BMOEKOHOABH(string KHOFKDAGHHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class PAHALNAGEAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MENKMFINGEF : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public MENKMFINGEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x636DBE0", Offset = "0x636C3E0", VA = "0x18636DBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6374FD0", Offset = "0x63737D0", VA = "0x186374FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GCEJIALBLON KDCOJBHAFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour MNJFIIDDKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action CPAELIEJCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> PGFAGBAHEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JGKDNNHAPDI KEKEKOGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float JMNPKJMEJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool MBDKJFCJJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly KHGOEJKDLML KOKEOGPCAPH;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x637ADF0", Offset = "0x63795F0", VA = "0x18637ADF0")]
	public PAHALNAGEAN(MonoBehaviour MNJFIIDDKBO, Action CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x637ABB0", Offset = "0x63793B0", VA = "0x18637ABB0")]
	public PAHALNAGEAN(MonoBehaviour MNJFIIDDKBO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x637AFE0", Offset = "0x63797E0", VA = "0x18637AFE0")]
	public PAHALNAGEAN(MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x179E400", Offset = "0x179CC00", VA = "0x18179E400")]
	private PAHALNAGEAN(KHGOEJKDLML KOKEOGPCAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x637AA80", Offset = "0x6379280", VA = "0x18637AA80")]
	internal static PAHALNAGEAN PIBKNBOOPLC(MonoBehaviour MNJFIIDDKBO, float DJLEJAPDDMO, Action<float> CPAELIEJCIB, JGKDNNHAPDI KEKEKOGBDLA, bool MBDKJFCJJBN = true, [Optional] KHGOEJKDLML KOKEOGPCAPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x637A910", Offset = "0x6379110", VA = "0x18637A910")]
	private void PFLNKCPEBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x637A230", Offset = "0x6378A30", VA = "0x18637A230")]
	private void FKLNIOKLMAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x637A760", Offset = "0x6378F60", VA = "0x18637A760")]
	private void OLPLCGKAIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x637A5A0", Offset = "0x6378DA0", VA = "0x18637A5A0")]
	private void MBEAGKDIDHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x637A470", Offset = "0x6378C70", VA = "0x18637A470")]
	private void LEDGODMGOBO(string HLPKEEDLIBL, Action DCPFEJNMILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x637A1B0", Offset = "0x63789B0", VA = "0x18637A1B0")]
	[IteratorStateMachine(typeof(MENKMFINGEF))]
	private IEnumerator<DENFKKKFFPI> FEGFNBBJKOB(Action DCPFEJNMILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x637A0C0", Offset = "0x63788C0", VA = "0x18637A0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x637A3E0", Offset = "0x6378BE0", VA = "0x18637A3E0")]
	[CompilerGenerated]
	private void IONDJDKJJCK(string KHOFKDAGHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6379FA0", Offset = "0x63787A0", VA = "0x186379FA0")]
	[CompilerGenerated]
	private void ALEGKJGNEPI(string KHOFKDAGHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x637A120", Offset = "0x6378920", VA = "0x18637A120")]
	[CompilerGenerated]
	private void EJCBOAEDBFP(string KHOFKDAGHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x637A030", Offset = "0x6378830", VA = "0x18637A030")]
	[CompilerGenerated]
	private void BKNPCEFOEBG(string KHOFKDAGHHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum LOKKAAFPNAC : byte
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
internal sealed class GFNINMCPPBO : LCLPNDLPDOM
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float KFDIGGONKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x636F1A0", Offset = "0x636D9A0", VA = "0x18636F1A0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float EHAMNBAJLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x636F1B0", Offset = "0x636D9B0", VA = "0x18636F1B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double IDOGCGMNAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x636F1C0", Offset = "0x636D9C0", VA = "0x18636F1C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x636F1E0", Offset = "0x636D9E0", VA = "0x18636F1E0")]
	[NJKKEFDLCAD(AFMDLPKJFNK.None)]
	private static void OGKGNDNNKLL(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	[Preserve]
	internal GFNINMCPPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface IBFLEIPAKKA
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGLPFECNIK(string HNHMJGCODBA);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEDDOEAJCDB();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface KDBPJDGIMGB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool FEAHJNJLDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool FNCJLBNCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class FKODMGGMOCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public NALLNDLBGNB GKNNNPHGFAP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NEMCGPAIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x76A250", Offset = "0x768A50", VA = "0x18076A250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x636E400", Offset = "0x636CC00", VA = "0x18636E400")]
	public static DENFKKKFFPI DEAKNCJONEB(IEnumerator<DENFKKKFFPI> FKJOKOHDMPM, FGDLBPBCPGI AIIPKCMFMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x636E560", Offset = "0x636CD60", VA = "0x18636E560")]
	public DENFKKKFFPI DEAKNCJONEB(FGDLBPBCPGI[] MNJBMEINJJI, IEnumerator<DENFKKKFFPI>[] HCLGALOIBDE, DENFKKKFFPI[] MKIAIHPCHAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x636E620", Offset = "0x636CE20", VA = "0x18636E620")]
	public void LCFPFHDBDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x636E790", Offset = "0x636CF90", VA = "0x18636E790")]
	public void LIMGEKDCHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x636E650", Offset = "0x636CE50", VA = "0x18636E650")]
	public void LEJCDHOMMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x636E620", Offset = "0x636CE20", VA = "0x18636E620")]
	public void PJCBOPOMMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FKODMGGMOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class NALLNDLBGNB
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PEHLLEPFPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public FKODMGGMOCD ICIECLFELEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public BJPHJOMINEO HJDKGHCJLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public FGDLBPBCPGI LCIBDBHONOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<DENFKKKFFPI> OHMDCOOAFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public DENFKKKFFPI JMBIBKICMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LOKKAAFPNAC KFMBBOOOPFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct IKDKPOCEDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public JGKDNNHAPDI IJNNKNMJNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<PEHLLEPFPCC> HIDLEKGLKGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class ECKMIMJAPEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public FGDLBPBCPGI promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public NALLNDLBGNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public BJPHJOMINEO context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public FKODMGGMOCD routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public LOKKAAFPNAC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DENFKKKFFPI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<DENFKKKFFPI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ECKMIMJAPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x636B1B0", Offset = "0x63699B0", VA = "0x18636B1B0")]
		internal void MAPAGPAJFIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class FKLNNPFJHCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FKODMGGMOCD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public NALLNDLBGNB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FKLNNPFJHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x636E3C0", Offset = "0x636CBC0", VA = "0x18636E3C0")]
		internal void JHGDDJJLKAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class APPFHBACHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public FKODMGGMOCD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public NALLNDLBGNB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public APPFHBACHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6362B70", Offset = "0x6361370", VA = "0x186362B70")]
		internal void KCEHAAJBCKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class ECPNMIJAGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public FKODMGGMOCD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public NALLNDLBGNB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ECPNMIJAGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x636B960", Offset = "0x636A160", VA = "0x18636B960")]
		internal void DDMHGDFDFJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const LOKKAAFPNAC BFPOJPDJJCP = LOKKAAFPNAC.Cancelled | LOKKAAFPNAC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly JGKDNNHAPDI KEKEKOGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] EIGBFIBFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<LOKKAAFPNAC> GNNOADMDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> FMFPJDCCALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> OKNGCLLHLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> CLOCLMIJGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> LEHLDFGLLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> NNJAKPJEOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> ICDKBFEKAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FKODMGGMOCD[] FKKBMGNOJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private FGDLBPBCPGI[] MNJBMEINJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private BJPHJOMINEO[] AAJJCEFBGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<DENFKKKFFPI>[] KDCMBHBGDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private DENFKKKFFPI[] CIIDINBDFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int KLFGEGIAGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int AFOFPPEGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int NCDCDGCBIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float BPIGMKAPLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private GDDOOIDJLPB HCLKLNGNEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle INPMLCCBOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<FKODMGGMOCD> FILBFMHEAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool POBHINLEGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> HODOMCDAABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> EEANNLMEGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool DHCLLLEKJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IKDKPOCEDOA[] MOKIMIOKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8B6440", Offset = "0x8B4C40", VA = "0x1808B6440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6376320", Offset = "0x6374B20", VA = "0x186376320")]
	private static int EDIMJPIDNMM(JGKDNNHAPDI KEKEKOGBDLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x63782F0", Offset = "0x6376AF0", VA = "0x1863782F0")]
	public NALLNDLBGNB(JGKDNNHAPDI KEKEKOGBDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6378110", Offset = "0x6376910", VA = "0x186378110")]
	private void PLHNCJKLBCD(int KNCKKGGGOKF, int LLINBMPENBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x63766C0", Offset = "0x6374EC0", VA = "0x1863766C0")]
	public void FAKHEGEFOCE(BJPHJOMINEO FJNGJOFLBMD, DENFKKKFFPI OFKBGPDHALM, IEnumerator<DENFKKKFFPI> FKJOKOHDMPM, FGDLBPBCPGI AIIPKCMFMEG, [Optional] FKODMGGMOCD HONNHEAEPPJ, LOKKAAFPNAC FMFDPHMNOLD = LOKKAAFPNAC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6377DA0", Offset = "0x63765A0", VA = "0x186377DA0")]
	public void PICPGKCGLMM(IEnumerable<PEHLLEPFPCC> LIGEKOKIBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6376D70", Offset = "0x6375570", VA = "0x186376D70")]
	private PEHLLEPFPCC MNLHCFONLCO(int ENMOANGICOF)
	{
		return default(PEHLLEPFPCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6376350", Offset = "0x6374B50", VA = "0x186376350")]
	private void EFCDDJEAHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x24AEB70", Offset = "0x24AD370", VA = "0x1824AEB70")]
	private static void BAIOAJHOKHI<T>(int ENMOANGICOF, T[] NCAHLJNMPIE, int ALCHALOFNIJ, [Optional] T DFJCJIPNENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x24AEBC0", Offset = "0x24AD3C0", VA = "0x1824AEBC0")]
	private static void BAIOAJHOKHI<T>(int ENMOANGICOF, NativeArray<T> NCAHLJNMPIE, int ALCHALOFNIJ, [Optional] T DFJCJIPNENO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6377A00", Offset = "0x6376200", VA = "0x186377A00")]
	private void PBLNEBFIBHH(IEnumerable<PEHLLEPFPCC> LIGEKOKIBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6377940", Offset = "0x6376140", VA = "0x186377940")]
	private void OEJLNCGGOLP(PEHLLEPFPCC LOAFGJNCBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6375F90", Offset = "0x6374790", VA = "0x186375F90")]
	private ADAHACMPPIP AAMPOEIPGCC(int HNJGMBKGFIN)
	{
		return default(ADAHACMPPIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6376AF0", Offset = "0x63752F0", VA = "0x186376AF0")]
	public void LMMHEFGIPJO(float GEIFHFPKBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6376CF0", Offset = "0x63754F0", VA = "0x186376CF0")]
	private void MBDOJBHDPGG(Action EOFAJFKEBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6376840", Offset = "0x6375040", VA = "0x186376840")]
	private void FIKEIPDEONM(Action EOFAJFKEBLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6377240", Offset = "0x6375A40", VA = "0x186377240")]
	public void MPELDKIIEHA(float GEIFHFPKBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x63768C0", Offset = "0x63750C0", VA = "0x1863768C0")]
	public void FILLLFKPAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6377FE0", Offset = "0x63767E0", VA = "0x186377FE0")]
	public void PJCBOPOMMKH(FKODMGGMOCD MGFADFINGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x63761F0", Offset = "0x63749F0", VA = "0x1863761F0")]
	public void DLGOMCEIOOB(FKODMGGMOCD MGFADFINGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x63769C0", Offset = "0x63751C0", VA = "0x1863769C0")]
	public void JMCHNGOFJBF(FKODMGGMOCD MGFADFINGED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class JICGBMLLAOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly JICGBMLLAOA AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action AOHFFNINPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool CBPCANBMLCP;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public JICGBMLLAOA(Action AOHFFNINPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x63704F0", Offset = "0x636ECF0", VA = "0x1863704F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface BFGKMBBEGLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CJALGBIDKCK(UnityEngine.Object FJNGJOFLBMD, Action<T> KAEAJMIGNMM);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface ABLFKELMHJC<T> : BFGKMBBEGLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class PCGPHNGMEHA<T> : ABLFKELMHJC<T>, BFGKMBBEGLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class BPCDAIFNPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public PCGPHNGMEHA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public FBDJHKIIFOH<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BPCDAIFNPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x48962F0", Offset = "0x4894AF0", VA = "0x1848962F0")]
		internal void ENFOOAMPAJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject GNKFJPCMDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<FBDJHKIIFOH<UnityEngine.Object, Action<T>>> LLOBHHMDMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T KOAPPMGPKLM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T PENMJFOMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3DA3CC0", Offset = "0x3DA24C0", VA = "0x183DA3CC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3D70", Offset = "0x3DA2570", VA = "0x183DA3D70")]
	private static bool GJIFLIECPIL(T EOFAJFKEBLN, T DNOEGKBPKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DA44A0", Offset = "0x3DA2CA0", VA = "0x183DA44A0")]
	public PCGPHNGMEHA(T IDOAHCPJHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DA3AB0", Offset = "0x3DA22B0", VA = "0x183DA3AB0", Slot = "6")]
	public IDisposable CJALGBIDKCK(UnityEngine.Object FJNGJOFLBMD, Action<T> KAEAJMIGNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DA4170", Offset = "0x3DA2970", VA = "0x183DA4170")]
	private void MELHOCFGCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class LGIMGFIDOPM : KIBKFJJEHIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly KHGOEJKDLML KOKEOGPCAPH;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6374D60", Offset = "0x6373560", VA = "0x186374D60")]
	[NJKKEFDLCAD(AFMDLPKJFNK.None)]
	private static void OGKGNDNNKLL(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	[Preserve]
	internal LGIMGFIDOPM([KEKICHOEFEB(null)] KHGOEJKDLML KOKEOGPCAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6374CB0", Offset = "0x63734B0", VA = "0x186374CB0", Slot = "4")]
	public IDisposable MIPDHMLINAI(float DJLEJAPDDMO, Action<float> ABCKGGDLEKO, bool MBDKJFCJJBN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class CANJPIDDALF : EFKJGNDGDBB, KHGOEJKDLML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NALLNDLBGNB[] ALJAHNPPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private IBFLEIPAKKA HHBHHDJMNNM;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6364290", Offset = "0x6362A90", VA = "0x186364290")]
	[NJKKEFDLCAD(AFMDLPKJFNK.None)]
	private static void OGKGNDNNKLL(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6364380", Offset = "0x6362B80", VA = "0x186364380")]
	[Preserve]
	public CANJPIDDALF([KEKICHOEFEB(null)] DLHKCJLDEBP DPALNLIKJJL, [KEKICHOEFEB(null)] LCLPNDLPDOM IJCMIBOIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6364160", Offset = "0x6362960", VA = "0x186364160", Slot = "16")]
	public override GCEJIALBLON JFOKHADOIFP(BJPHJOMINEO FJNGJOFLBMD, IEnumerator<DENFKKKFFPI> EJFGMPEABAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6363D30", Offset = "0x6362530", VA = "0x186363D30", Slot = "17")]
	public override void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x63639E0", Offset = "0x63621E0", VA = "0x1863639E0", Slot = "19")]
	public override void EBGLKOAFMCO(JGKDNNHAPDI KEKEKOGBDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6363FC0", Offset = "0x63627C0", VA = "0x186363FC0", Slot = "18")]
	protected override void IDAKBLNHKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6364130", Offset = "0x6362930", VA = "0x186364130")]
	private NALLNDLBGNB IHBGLBBFOJM(JGKDNNHAPDI GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6363810", Offset = "0x6362010", VA = "0x186363810", Slot = "20")]
	internal override CPPENEICGCH DJFIFEEKIJO(IEnumerator<DENFKKKFFPI> EJFGMPEABAD, Behaviour FJNGJOFLBMD, FGDLBPBCPGI AIIPKCMFMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6364300", Offset = "0x6362B00", VA = "0x186364300", Slot = "21")]
	internal override JPALKDBHNBJ PEPOBHGBPPK(JGKDNNHAPDI IKEMBHLKPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6363C10", Offset = "0x6362410", VA = "0x186363C10")]
	private void EIBICJIKANA(NALLNDLBGNB DONFAGNPBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6363980", Offset = "0x6362180", VA = "0x186363980", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct GDDOOIDJLPB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float HIBLPEDLHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int KIMIOOPGKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> HAKPFGEOMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> JMKPOKDMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> JGIOEKBGEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<LOKKAAFPNAC> JBCGAPLNKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> DLMHGCCJMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> LEHLDFGLLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> OKNGCLLHLFP;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x636EE00", Offset = "0x636D600", VA = "0x18636EE00")]
	public static GDDOOIDJLPB KLKFANDJKFE(int GHODMLNCDKM, float GEIFHFPKBKG, NativeArray<LOKKAAFPNAC> LPLHBAHCJLA, NativeArray<float> FKMAANFMIJJ, NativeArray<int> DMPLCKJNNIM, NativeArray<int> KPJFFDOHGKP, NativeArray<int> EAJLGEFNEME, NativeArray<int> JMKPOKDMEHB, NativeArray<int> JGIOEKBGEAD)
	{
		return default(GDDOOIDJLPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x636ED20", Offset = "0x636D520", VA = "0x18636ED20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x636EC40", Offset = "0x636D440", VA = "0x18636EC40")]
	private bool CJEBLEDGJJJ(int LFEFGCGCIAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x636EF30", Offset = "0x636D730", VA = "0x18636EF30")]
	private void MKBJDJNKDIB(NativeArray<int> CGNGGDDCICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x636EC80", Offset = "0x636D480", VA = "0x18636EC80")]
	private int EGLMJFCKPJO(int JOFCEFHBBND, int CDOFGBBAOOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x636EE60", Offset = "0x636D660", VA = "0x18636EE60")]
	private void KMBGCGOMEGP(NativeArray<int> CGNGGDDCICO, int NNEFFFAJKCB, int FPMFDFOAOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x636EF60", Offset = "0x636D760", VA = "0x18636EF60")]
	private void MPDHNGCHGAA(NativeArray<int> CGNGGDDCICO, int FGNFIEFEDCN, int KGMPKBGEHHE, int MCCEAAEDHKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class EFKJGNDGDBB : KHGOEJKDLML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly DLHKCJLDEBP DPALNLIKJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly LCLPNDLPDOM IJCMIBOIMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private JPALKDBHNBJ[] NALLGLCNKDM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static KHGOEJKDLML FLMPJFHFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x636C840", Offset = "0x636B040", VA = "0x18636C840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JGKDNNHAPDI ABACCAFHCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JGKDNNHAPDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x76A250", Offset = "0x768A50", VA = "0x18076A250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LCLPNDLPDOM KKIOHFOMCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DENFKKKFFPI MPIOBMBOHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x636BEA0", Offset = "0x636A6A0", VA = "0x18636BEA0")]
	public static GCEJIALBLON DDPDFCNCJBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x636CDA0", Offset = "0x636B5A0", VA = "0x18636CDA0")]
	[Preserve]
	protected EFKJGNDGDBB([KEKICHOEFEB(null)] DLHKCJLDEBP DPALNLIKJJL, [KEKICHOEFEB(null)] LCLPNDLPDOM IJCMIBOIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x636C8B0", Offset = "0x636B0B0", VA = "0x18636C8B0", Slot = "6")]
	public GCEJIALBLON MFGPHFHEOBL(IEnumerator<DENFKKKFFPI> EJFGMPEABAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x636C8C0", Offset = "0x636B0C0", VA = "0x18636C8C0", Slot = "7")]
	public GCEJIALBLON MFGPHFHEOBL(Behaviour FJNGJOFLBMD, IEnumerator<DENFKKKFFPI> EJFGMPEABAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract GCEJIALBLON JFOKHADOIFP(BJPHJOMINEO FJNGJOFLBMD, IEnumerator<DENFKKKFFPI> EJFGMPEABAD);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x636C380", Offset = "0x636AB80", VA = "0x18636C380", Slot = "17")]
	public virtual void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x636C5E0", Offset = "0x636ADE0", VA = "0x18636C5E0", Slot = "9")]
	public void ILKKEDNHGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x636C560", Offset = "0x636AD60", VA = "0x18636C560", Slot = "18")]
	protected virtual void IDAKBLNHKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x636CB50", Offset = "0x636B350", VA = "0x18636CB50")]
	private void OEJCFFFPADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x636C540", Offset = "0x636AD40", VA = "0x18636C540")]
	private void HJBHOFKCOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x636BE60", Offset = "0x636A660", VA = "0x18636BE60")]
	private void BJCOGLJOKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x636C890", Offset = "0x636B090", VA = "0x18636C890")]
	private void MDHPIDLBGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x636C520", Offset = "0x636AD20", VA = "0x18636C520")]
	private void FOAGDNEBHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x636C820", Offset = "0x636B020", VA = "0x18636C820")]
	private void LEPFNBJGLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x636BE80", Offset = "0x636A680", VA = "0x18636BE80")]
	private void CHOEJMBCAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x636C2F0", Offset = "0x636AAF0", VA = "0x18636C2F0", Slot = "19")]
	public virtual void EBGLKOAFMCO(JGKDNNHAPDI KEKEKOGBDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x636CBD0", Offset = "0x636B3D0", VA = "0x18636CBD0")]
	private void ONJKDLEHEPL(JPALKDBHNBJ DONFAGNPBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BA10", Offset = "0x1B5A210", VA = "0x181B5BA10")]
	private JPALKDBHNBJ MMKBOJJJLOI(JGKDNNHAPDI GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract CPPENEICGCH DJFIFEEKIJO(IEnumerator<DENFKKKFFPI> EJFGMPEABAD, Behaviour MNJFIIDDKBO, FGDLBPBCPGI FGKCIFDHAIG);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract JPALKDBHNBJ PEPOBHGBPPK(JGKDNNHAPDI KEKEKOGBDLA);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x636BF30", Offset = "0x636A730", VA = "0x18636BF30", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x636CB70", Offset = "0x636B370", VA = "0x18636CB70", Slot = "12")]
	public DENFKKKFFPI OGAMIGGICKH(JGKDNNHAPDI IKEMBHLKPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x636CAC0", Offset = "0x636B2C0", VA = "0x18636CAC0", Slot = "13")]
	public DENFKKKFFPI MJOAJHPAFDO(float HAHNMEKBEPD, JGKDNNHAPDI IKEMBHLKPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x636C580", Offset = "0x636AD80", VA = "0x18636C580", Slot = "14")]
	public DENFKKKFFPI IHLBLKLLPHM(Func<bool> AGJELNEAJON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class CPPENEICGCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly FGDLBPBCPGI AIIPKCMFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly KDBPJDGIMGB FJNGJOFLBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool ONDBMGJCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string HNHMJGCODBA;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<DENFKKKFFPI> OHMDCOOAFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DENFKKKFFPI JMBIBKICMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool OLBOHHNFGCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x63655F0", Offset = "0x6363DF0", VA = "0x1863655F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool JMGFOCDOPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x802FF0", Offset = "0x8017F0", VA = "0x180802FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAED7F0", Offset = "0xAEBFF0", VA = "0x180AED7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6365910", Offset = "0x6364110", VA = "0x186365910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float KMOIMBIMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1017550", Offset = "0x1015D50", VA = "0x181017550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x10D3E00", Offset = "0x10D2600", VA = "0x1810D3E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6365C60", Offset = "0x6364460", VA = "0x186365C60")]
	public CPPENEICGCH(IEnumerator<DENFKKKFFPI> FKJOKOHDMPM, KDBPJDGIMGB FJNGJOFLBMD, FGDLBPBCPGI AIIPKCMFMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6365670", Offset = "0x6363E70", VA = "0x186365670")]
	public DENFKKKFFPI DEAKNCJONEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6365AC0", Offset = "0x63642C0", VA = "0x186365AC0")]
	public bool IALDPOPHGOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6365B30", Offset = "0x6364330", VA = "0x186365B30")]
	public void PJCBOPOMMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6365B80", Offset = "0x6364380", VA = "0x186365B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x81A510", Offset = "0x818D10", VA = "0x18081A510")]
	[CompilerGenerated]
	private void MEJLKAGADEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class FGDLBPBCPGI : LKNOMMCBGAF, GCEJIALBLON, IFNBCJFCEDL, CPOBDANHFCI, IEnumerator, DENFKKKFFPI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private JGKDNNHAPDI LCOIMBMPJHE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private JGKDNNHAPDI CGIIFJFPBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xCF07C0", Offset = "0xCEEFC0", VA = "0x180CF07C0", Slot = "23")]
		get
		{
			return default(JGKDNNHAPDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public JGKDNNHAPDI GKNNNPHGFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x11D2830", Offset = "0x11D1030", VA = "0x1811D2830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float JODAKBFGGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5580", Offset = "0x7B3D80", VA = "0x1807B5580", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool KPBCAIFEGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x636E260", Offset = "0x636CA60", VA = "0x18636E260", Slot = "24")]
	private bool ODHJCJPBHOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x636E250", Offset = "0x636CA50", VA = "0x18636E250", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x636E280", Offset = "0x636CA80", VA = "0x18636E280")]
	public FGDLBPBCPGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum ADAHACMPPIP : byte
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
internal sealed class JPALKDBHNBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum EDBGDBCDJMM
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct PEABDOJPPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public JGKDNNHAPDI IJNNKNMJNMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public EDBGDBCDJMM JPGKPEFMJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public List<CPPENEICGCH> PPLFFONLKCB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly EDBGDBCDJMM[] CJBACCLGEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly JGKDNNHAPDI KEKEKOGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool INALMPGILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly CPPENEICGCH[] DFFAKMKNEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly List<CPPENEICGCH> IDNBMKDPOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<int> FGIKBIPDMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<CPPENEICGCH> JKLJCJELHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Stack<int> LOKMFGMLJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly IBFLEIPAKKA KNBPJAOLCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool DHCLLLEKJBJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public PEABDOJPPFO[,] KOMOJPPIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6371F10", Offset = "0x6370710", VA = "0x186371F10")]
	public JPALKDBHNBJ(JGKDNNHAPDI IKEMBHLKPGK, IBFLEIPAKKA KNBPJAOLCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6371710", Offset = "0x636FF10", VA = "0x186371710")]
	public void MOIDPDPCPAM(CPPENEICGCH FKJOKOHDMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x63709F0", Offset = "0x636F1F0", VA = "0x1863709F0")]
	public void CEMEHLJDKJO(IList<CPPENEICGCH> HCLGALOIBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63710A0", Offset = "0x636F8A0", VA = "0x1863710A0")]
	public void HDNFECHFLFK(IList<CPPENEICGCH> HCLGALOIBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6370FB0", Offset = "0x636F7B0", VA = "0x186370FB0")]
	private void FFGFIJJADBJ(CPPENEICGCH FKJOKOHDMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6370E20", Offset = "0x636F620", VA = "0x186370E20")]
	private void EJAGIDBACHD(IList<CPPENEICGCH> HCLGALOIBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6371950", Offset = "0x6370150", VA = "0x186371950")]
	private ADAHACMPPIP OLNCIHKDNKD(CPPENEICGCH FKJOKOHDMPM)
	{
		return default(ADAHACMPPIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x63713B0", Offset = "0x636FBB0", VA = "0x1863713B0")]
	public void IDAKBLNHKFP(float GEIFHFPKBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6371520", Offset = "0x636FD20", VA = "0x186371520")]
	public void ILKKEDNHGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6371AD0", Offset = "0x63702D0", VA = "0x186371AD0")]
	private void PGDOEHANFIJ(List<CPPENEICGCH> HCLGALOIBDE, Stack<int> CIMJJHCAGMF, bool BHLGNALCJEF, float HGKCCNLBHKP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6370D00", Offset = "0x636F500", VA = "0x186370D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6371810", Offset = "0x6370010", VA = "0x186371810")]
	private void OBFBJGOCNCG(List<CPPENEICGCH> HCLGALOIBDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class NLDEOCDHJGP : IBFLEIPAKKA
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void ONGLPFECNIK(string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
	public void BEDDOEAJCDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NLDEOCDHJGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class FIFJMCLMBMP : KDBPJDGIMGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Behaviour MNJFIIDDKBO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x636E320", Offset = "0x636CB20", VA = "0x18636E320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FEAHJNJLDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x636E2D0", Offset = "0x636CAD0", VA = "0x18636E2D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool FNCJLBNCPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x636E3A0", Offset = "0x636CBA0", VA = "0x18636E3A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public FIFJMCLMBMP(Behaviour MNJFIIDDKBO)
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

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
public class EPPOKHFEGGE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority HALEIMNOHNA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x682D980", Offset = "0x682C780", VA = "0x18682D980")]
	public EPPOKHFEGGE(ThreadPriority PMAFIPKLHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x682D970", Offset = "0x682C770", VA = "0x18682D970", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> NPHFHDLDEKB(List<PlayerLoopSystem> DMLMBBJOCMO, int NPKFDOPOPNB);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct GCIBOEIFLBH
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct HKLOLDGBMFN
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static BHHPLLLFBGO GJLBPCBGKDN;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x68303B0", Offset = "0x682F1B0", VA = "0x1868303B0")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GCOOJONDBML
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static BHHPLLLFBGO FFGPPANBMHG;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x682E6D0", Offset = "0x682D4D0", VA = "0x18682E6D0")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct EPJCHBEHPML
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static BHHPLLLFBGO KCJMOPELKBH;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x682D770", Offset = "0x682C570", VA = "0x18682D770")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct ONDHJMHIAGE
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BHHPLLLFBGO LPLEDIGBJCN;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BHHPLLLFBGO KMLJHPPFFHJ;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BHHPLLLFBGO HJCMHLOEFHP;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static BHHPLLLFBGO MLHLKFPFOAA;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6839480", Offset = "0x6838280", VA = "0x186839480")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct MLBNIKPCPJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static BHHPLLLFBGO IGGOLJCAAOP;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6834BE0", Offset = "0x68339E0", VA = "0x186834BE0")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct HCBAOKMOJPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BHHPLLLFBGO LPLEDIGBJCN;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BHHPLLLFBGO KMLJHPPFFHJ;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BHHPLLLFBGO HJCMHLOEFHP;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static BHHPLLLFBGO MLHLKFPFOAA;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x682FEF0", Offset = "0x682ECF0", VA = "0x18682FEF0")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CJBIKHIELEN
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static BHHPLLLFBGO DGILGBBIJGL;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6828180", Offset = "0x6826F80", VA = "0x186828180")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct DKKIOIENMJL
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static BHHPLLLFBGO GMEJJDFMCEC;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x682C500", Offset = "0x682B300", VA = "0x18682C500")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct HAJFMONNIJC
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static BHHPLLLFBGO ABHDENBKIEH;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x682F9A0", Offset = "0x682E7A0", VA = "0x18682F9A0")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct GJLJAHAOPHI
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static BHHPLLLFBGO JCGAPEHBENG;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x682E990", Offset = "0x682D790", VA = "0x18682E990")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct JFPHFDCIIKH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static BHHPLLLFBGO LOCDNJFALJL;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6832910", Offset = "0x6831710", VA = "0x186832910")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct NHGCCAICEHE
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static BHHPLLLFBGO KKDPFKALPNL;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6836880", Offset = "0x6835680", VA = "0x186836880")]
				public static PlayerLoopSystem NBIIOOBDPED()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum CNLGOIPAPAP : byte
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
			public struct PMHPNFGINCA
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class HNACGOPLCNJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public CNLGOIPAPAP updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
					public HNACGOPLCNJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x68305B0", Offset = "0x682F3B0", VA = "0x1868305B0")]
					internal void BCMCEOGGGCH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static EOPEMIILONN<CNLGOIPAPAP> EOFKFBBHJAD;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x683D300", Offset = "0x683C100", VA = "0x18683D300")]
				public static PlayerLoopSystem NBIIOOBDPED(CNLGOIPAPAP FJEAJJKPODC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct LMJFGPGHLLI
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class HBGCGHPOKNP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public MJHHKPAHEOD.HFGKCAKCMDL key;

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
					public HBGCGHPOKNP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x682FBA0", Offset = "0x682E9A0", VA = "0x18682FBA0")]
					internal void LJGBBIFJPDN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable GMHFGHEEBAF;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x6833C30", Offset = "0x6832A30", VA = "0x186833C30")]
				public static PlayerLoopSystem DNOEIGGFMKM(MJHHKPAHEOD.HFGKCAKCMDL JCMGBFKGKLO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct OCPHIMIJPEO
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class JCEJCJCJDKC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public MJHHKPAHEOD.HFGKCAKCMDL key;

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
					public JCEJCJCJDKC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000054")]
					[Cpp2IlInjected.Address(RVA = "0x6832660", Offset = "0x6831460", VA = "0x186832660")]
					internal void LJGBBIFJPDN()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x6837420", Offset = "0x6836220", VA = "0x186837420")]
				public static PlayerLoopSystem DNOEIGGFMKM(MJHHKPAHEOD.HFGKCAKCMDL JCMGBFKGKLO)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IHJBDLEJPDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public IHJBDLEJPDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6831D90", Offset = "0x6830B90", VA = "0x186831D90")]
			internal List<PlayerLoopSystem> BDPKGBIGLHM(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FOJANJCNLEK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool LJAKLPIMIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x68293E0", Offset = "0x68281E0", VA = "0x1868293E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6829420", Offset = "0x6828220", VA = "0x186829420")]
		private static void FBFNNCBBJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68289E0", Offset = "0x68277E0", VA = "0x1868289E0")]
		private static void BIBHCMHEPPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68287B0", Offset = "0x68275B0", VA = "0x1868287B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x682C130", Offset = "0x682AF30", VA = "0x18682C130")]
		private static void OHNEBKEPGNO(MJHHKPAHEOD.HFGKCAKCMDL JCMGBFKGKLO, PlayerLoopSystem PPDGLEFNLIF, Type MEOEFKDLLIK, Type ACGLKCMKDBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x682BD50", Offset = "0x682AB50", VA = "0x18682BD50")]
		private static void JMLENLPBBBF(PlayerLoopSystem PPDGLEFNLIF, Type MEOEFKDLLIK, Type ACGLKCMKDBI, NPHFHDLDEKB OCFACJAGMMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68292B0", Offset = "0x68280B0", VA = "0x1868292B0")]
		private static void EAHCBCHGLFM(PlayerLoopSystem PPDGLEFNLIF, Type MEOEFKDLLIK, Type ACGLKCMKDBI, PlayerLoopSystem? HDIJPEGJPCL, PlayerLoopSystem? BPBKJMBBDLP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class MJHHKPAHEOD
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum HFGKCAKCMDL
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
	public class EAPOMEPAGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly HFGKCAKCMDL DLFILGKJPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly GBOFOBDPPGL CDMBEICDFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long DGNIDNCAIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long EJIEDMPNNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long HEJDIBNEEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int NEIJODCOHKN;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x682CF40", Offset = "0x682BD40", VA = "0x18682CF40")]
		public EAPOMEPAGGM(HFGKCAKCMDL BIOFDGKDADC, int EFGJJLEGFPG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x682CE80", Offset = "0x682BC80", VA = "0x18682CE80")]
		public void JOPFKDMDBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x682CEF0", Offset = "0x682BCF0", VA = "0x18682CEF0")]
		public void OAJAMECOLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x682CCA0", Offset = "0x682BAA0", VA = "0x18682CCA0")]
		public void JKNAPIGIMOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static HFGKCAKCMDL[] KJKPPNLKPON;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EAPOMEPAGGM[] HAIEHCHMIMA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6834750", Offset = "0x6833550", VA = "0x186834750")]
	public static EAPOMEPAGGM CGCIIBBKFIE(HFGKCAKCMDL JCMGBFKGKLO, int EFGJJLEGFPG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6834930", Offset = "0x6833730", VA = "0x186834930")]
	public static EAPOMEPAGGM KBDHLOBNGPJ(HFGKCAKCMDL JCMGBFKGKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68349A0", Offset = "0x68337A0", VA = "0x1868349A0")]
	public static void PHEKGJANLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GBOFOBDPPGL : HCBKMNMKOOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int FEOCKPDLFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Queue<double> EOFFIHFGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private double EAKGPCAEIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private double MKKECNHBALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private double MABCFMLAADD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MDBIKAKJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x682DEB0", Offset = "0x682CCB0", VA = "0x18682DEB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double NAGNIFGBDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x17A2FB0", Offset = "0x17A1DB0", VA = "0x1817A2FB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JGHDCNBHBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D46CA0", Offset = "0x1D45AA0", VA = "0x181D46CA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x682E0A0", Offset = "0x682CEA0", VA = "0x18682E0A0")]
	public GBOFOBDPPGL(int GJPPGDCFPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x682DF10", Offset = "0x682CD10", VA = "0x18682DF10", Slot = "7")]
	public void KPHPGGGBBOG(double NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x682E030", Offset = "0x682CE30", VA = "0x18682E030", Slot = "8")]
	public void MNGHADJNDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NOLDCBJHLLB : HCBKMNMKOOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private long BPFMGMBDOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double NJNCHPFBMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double CKPIHHNCPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double CINAGNGAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private double IKHKEPMKNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double EAKGPCAEIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double MKKECNHBALN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double NAGNIFGBDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x55FF660", Offset = "0x55FE460", VA = "0x1855FF660", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JGHDCNBHBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x55FFB40", Offset = "0x55FE940", VA = "0x1855FFB40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double ACHOPLKLFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x55FF670", Offset = "0x55FE470", VA = "0x1855FF670")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MDBIKAKJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2204BB0", Offset = "0x22039B0", VA = "0x182204BB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6837280", Offset = "0x6836080", VA = "0x186837280", Slot = "7")]
	public virtual void KPHPGGGBBOG(double NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68373A0", Offset = "0x68361A0", VA = "0x1868373A0", Slot = "8")]
	public virtual void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6830380", Offset = "0x682F180", VA = "0x186830380")]
	public NOLDCBJHLLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HIAEBAHPOIP : NOLDCBJHLLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LCDNHNFCBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x55FF690", Offset = "0x55FE490", VA = "0x1855FF690")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x55FFB10", Offset = "0x55FE910", VA = "0x1855FFB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6830210", Offset = "0x682F010", VA = "0x186830210", Slot = "7")]
	public override void KPHPGGGBBOG(double NGFDKOKHGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6830340", Offset = "0x682F140", VA = "0x186830340", Slot = "8")]
	public override void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6830380", Offset = "0x682F180", VA = "0x186830380")]
	public HIAEBAHPOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface HCBKMNMKOOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MDBIKAKJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double NAGNIFGBDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JGHDCNBHBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NJCGIGAAGCI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private interface OKINFPBFFGH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool ANKMBGHNLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GMFECOINAPH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private abstract class IFIJBBOAHJB<TPromise, TMainThreadPromise> : OKINFPBFFGH where TPromise : AJKHGLHHDGH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TPromise DFELBDHBJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly TMainThreadPromise KCMDGPJHMAH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise CDMFFNEDAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x384BAB0", Offset = "0x384A8B0", VA = "0x18384BAB0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ANKMBGHNLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x384BA40", Offset = "0x384A840", VA = "0x18384BA40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
		protected IFIJBBOAHJB(TPromise DFELBDHBJJD, TMainThreadPromise CDABDKAJCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x384BA90", Offset = "0x384A890", VA = "0x18384BA90", Slot = "5")]
		public void GMFECOINAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HHDEGDCOMIC(TPromise DFELBDHBJJD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class ILLEMAPDMKF<T> : IFIJBBOAHJB<DOPLGHLIBGN<T>, KLKALBNGLCD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x386E320", Offset = "0x386D120", VA = "0x18386E320")]
		public ILLEMAPDMKF(DOPLGHLIBGN<T> DFELBDHBJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x386E140", Offset = "0x386CF40", VA = "0x18386E140", Slot = "6")]
		protected override void HHDEGDCOMIC(DOPLGHLIBGN<T> DFELBDHBJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x370A080", Offset = "0x3708E80", VA = "0x18370A080")]
		[CompilerGenerated]
		private void AOLDLGMDGBB(T BGCCPJGDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x386E2F0", Offset = "0x386D0F0", VA = "0x18386E2F0")]
		[CompilerGenerated]
		private void LONAPKLMFLL(string OLGJDMIGDKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class CKKMOIJLIML : OKINFPBFFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action ENHEBPDFNME;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ANKMBGHNLIK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
		public CKKMOIJLIML(Action ENHEBPDFNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBB1A90", Offset = "0xBB0890", VA = "0x180BB1A90", Slot = "5")]
		public void GMFECOINAPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<OKINFPBFFGH> GMGGIADHHOH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2830EC0", Offset = "0x282FCC0", VA = "0x182830EC0")]
	public static DOPLGHLIBGN<T> MAKOOBMLDNF<T>(this DOPLGHLIBGN<T> DFELBDHBJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6836F40", Offset = "0x6835D40", VA = "0x186836F40")]
	public static void MAKOOBMLDNF(Action ENHEBPDFNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2830E00", Offset = "0x282FC00", VA = "0x182830E00")]
	private static DOPLGHLIBGN<T> IDCHJCKHHEN<T>(DOPLGHLIBGN<T> DFELBDHBJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6836FE0", Offset = "0x6835DE0", VA = "0x186836FE0")]
	private static void NAOBHMOKGBI(OKINFPBFFGH NPDGFNGHOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6836C60", Offset = "0x6835A60", VA = "0x186836C60")]
	private static void HIOHAKDEIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6836A80", Offset = "0x6835880", VA = "0x186836A80")]
	private static void FPLFIDPHHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6836B80", Offset = "0x6835980", VA = "0x186836B80")]
	private static void GPIFDCKDHDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OONLKKDCLBH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct EKKPAJJAPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TaskCompletionSource<Scene> JIJBEEAGCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public readonly string AOIKHKIKFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly LoadSceneMode MPFGDDEBDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly bool BGIBKNJLMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x682D710", Offset = "0x682C510", VA = "0x18682D710")]
		public EKKPAJJAPBH(TaskCompletionSource<Scene> HNGGKIBECFD, string AOIKHKIKFNC, LoadSceneMode MPFGDDEBDHC, bool BGIBKNJLMHA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct BFMCNFJFCKJ : IAsyncStateMachine
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
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private GAKKIOAFLLE<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x68258E0", Offset = "0x68246E0", VA = "0x1868258E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6826180", Offset = "0x6824F80", VA = "0x186826180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct PPKHGBEJADO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x683D4D0", Offset = "0x683C2D0", VA = "0x18683D4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x683D7F0", Offset = "0x683C5F0", VA = "0x18683D7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FIHBEDECKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private EKKPAJJAPBH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x682D9C0", Offset = "0x682C7C0", VA = "0x18682D9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x682DD70", Offset = "0x682CB70", VA = "0x18682DD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CAMKELNNION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KLKALBNGLCD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CAMKELNNION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6827EF0", Offset = "0x6826CF0", VA = "0x186827EF0")]
		internal void AMBHKPAMPPE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct GODJAEPLDNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

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
		private CAMKELNNION <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x682ECA0", Offset = "0x682DAA0", VA = "0x18682ECA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x682F840", Offset = "0x682E640", VA = "0x18682F840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct GCOGCOMBLDE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x682E150", Offset = "0x682CF50", VA = "0x18682E150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x682E660", Offset = "0x682D460", VA = "0x18682E660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OOPKFAMBPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public GAKKIOAFLLE<string>.AGJOEKMHOHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private GAKKIOAFLLE<string>.AGJOEKMHOHC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x683B080", Offset = "0x6839E80", VA = "0x18683B080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x683BBD0", Offset = "0x683A9D0", VA = "0x18683BBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HCOEKBJBHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public HCOEKBJBHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x68301E0", Offset = "0x682EFE0", VA = "0x1868301E0")]
		internal bool ANJEGGICHOB()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class BGHOIJHJJNP : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public ANGKAGKCEHL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public BGHOIJHJJNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68265D0", Offset = "0x68253D0", VA = "0x1868265D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x68261F0", Offset = "0x6824FF0", VA = "0x1868261F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6826530", Offset = "0x6825330", VA = "0x186826530")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6826580", Offset = "0x6825380", VA = "0x186826580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KOFJIJIMPGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KLKALBNGLCD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KOFJIJIMPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6833BB0", Offset = "0x68329B0", VA = "0x186833BB0")]
		internal bool DJMNHBBMEMO(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6833930", Offset = "0x6832730", VA = "0x186833930")]
		internal void ACLCCKJKNNH(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KEDJJEJDHOC : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public KLKALBNGLCD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private KOFJIJIMPGE <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public KEDJJEJDHOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6832C70", Offset = "0x6831A70", VA = "0x186832C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6833380", Offset = "0x6832180", VA = "0x186833380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly ICollection<string> EACLLFBNDBF;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static AJKHGLHHDGH OCEDKHMGJKF;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static AsyncOperation FINIPNACENP;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static AJKHGLHHDGH BGHLKIJDKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static string NIJEDKBPNHC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static ThreadPriority IFLMGJGIDAL;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static Task POCDFPCAOLD;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static List<SceneInstance> KKJPOBPGHGC;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly Queue<EKKPAJJAPBH> EADLJABHOMM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static Task CNDEIIJOAEH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool NLNDLBOCIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x683AC70", Offset = "0x6839A70", VA = "0x18683AC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool COLDEOFNNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6839F10", Offset = "0x6838D10", VA = "0x186839F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool GANHHBAKFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x683A700", Offset = "0x6839500", VA = "0x18683A700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool GJCMOIDAODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6839CA0", Offset = "0x6838AA0", VA = "0x186839CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HPBMFJGNIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6839770", Offset = "0x6838570", VA = "0x186839770")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6839880", Offset = "0x6838680", VA = "0x186839880")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x683A600", Offset = "0x6839400", VA = "0x18683A600")]
	[MKMKKCMJPMD(BAGLMHABOOI.EnteredEditModeNextFrame, 0)]
	private static void KENKPKLPCBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6839DC0", Offset = "0x6838BC0", VA = "0x186839DC0")]
	[AsyncStateMachine(typeof(BFMCNFJFCKJ))]
	public static Task<Scene> EKBCGGOBJLE(string AOIKHKIKFNC, LoadSceneMode MPFGDDEBDHC = LoadSceneMode.Single, bool BGIBKNJLMHA = false, [Optional] GAKKIOAFLLE<string>.AGJOEKMHOHC GMMCKFHANKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x683AA70", Offset = "0x6839870", VA = "0x18683AA70")]
	[AsyncStateMachine(typeof(PPKHGBEJADO))]
	private static Task MIENKKHIEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6839BD0", Offset = "0x68389D0", VA = "0x186839BD0")]
	[AsyncStateMachine(typeof(FIHBEDECKOK))]
	private static Task CHABOMKCNJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x683AB20", Offset = "0x6839920", VA = "0x18683AB20")]
	[AsyncStateMachine(typeof(GODJAEPLDNO))]
	private static Task<Scene> NCBEDKDHPJP(string AOIKHKIKFNC, LoadSceneMode MPFGDDEBDHC, bool BGIBKNJLMHA, GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6839FB0", Offset = "0x6838DB0", VA = "0x186839FB0")]
	private static void GFFHLECMCPM(SceneInstance NNOMIIGCPPJ, LoadSceneMode MPFGDDEBDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6839B10", Offset = "0x6838910", VA = "0x186839B10")]
	private static void CEPGHOBNNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x683A4E0", Offset = "0x68392E0", VA = "0x18683A4E0")]
	[AsyncStateMachine(typeof(GCOGCOMBLDE))]
	private static Task<Scene> JAEOEKINDAK(string AOIKHKIKFNC, LoadSceneMode MPFGDDEBDHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x683A110", Offset = "0x6838F10", VA = "0x18683A110")]
	private static bool HFJNBPLMFPM(string AOIKHKIKFNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x683A3D0", Offset = "0x68391D0", VA = "0x18683A3D0")]
	[AsyncStateMachine(typeof(OOPKFAMBPMC))]
	private static Task<Scene> IPGDFHNNEMJ(GAKKIOAFLLE<string>.AGJOEKMHOHC IBHCMDAJECC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6839990", Offset = "0x6838790", VA = "0x186839990")]
	public static DOPLGHLIBGN<Scene> CDGLDOOBMLF(string AOIKHKIKFNC, LoadSceneMode MPFGDDEBDHC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x683A7A0", Offset = "0x68395A0", VA = "0x18683A7A0")]
	public static AJKHGLHHDGH MDKLGLIPHJG(string AOIKHKIKFNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6839D30", Offset = "0x6838B30", VA = "0x186839D30")]
	[IteratorStateMachine(typeof(BGHOIJHJJNP))]
	private static IEnumerator<FOAIHJNBGIP> DLHCGIOINKD(string AOIKHKIKFNC, ANGKAGKCEHL MEHKAFJLGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x683A330", Offset = "0x6839130", VA = "0x18683A330")]
	[IteratorStateMachine(typeof(KEDJJEJDHOC))]
	private static IEnumerator<FOAIHJNBGIP> IJAOFLCBAIM(string AOIKHKIKFNC, LoadSceneMode MPFGDDEBDHC, KLKALBNGLCD<Scene> MEHKAFJLGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x683A200", Offset = "0x6839000", VA = "0x18683A200")]
	public static bool HGJKEIDBFGD([Out] string DFGAPOOCPDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EAOKFPFPHGH
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x682CB10", Offset = "0x682B910", VA = "0x18682CB10")]
	public static IDisposable CKCLIOAJNCC(this DODDKKLBDDP HOLFPPNPJAH, float CPEOMLABFOD, Action<float> ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x682CBA0", Offset = "0x682B9A0", VA = "0x18682CBA0")]
	public static IDisposable KECBLNDAGFB(this DODDKKLBDDP HOLFPPNPJAH, Action<float> ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x682CC20", Offset = "0x682BA20", VA = "0x18682CC20")]
	public static IDisposable KJICDPPBIAL(this DODDKKLBDDP HOLFPPNPJAH, Action<float> ECAHKGEBDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BLNOIMOBJNE
{
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6827770", Offset = "0x6826570", VA = "0x186827770")]
	public static IDisposable HKAIDANNFCF(this MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68276E0", Offset = "0x68264E0", VA = "0x1868276E0")]
	public static IDisposable HKAIDANNFCF(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6827BA0", Offset = "0x68269A0", VA = "0x186827BA0")]
	public static IDisposable LLIADGIKINC(this MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6827CA0", Offset = "0x6826AA0", VA = "0x186827CA0")]
	public static IDisposable MBMAKNJPLGK(this MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6827C20", Offset = "0x6826A20", VA = "0x186827C20")]
	public static IDisposable MBMAKNJPLGK(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6827B20", Offset = "0x6826920", VA = "0x186827B20")]
	public static IDisposable KHALEDIHAJH(this MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6827D20", Offset = "0x6826B20", VA = "0x186827D20")]
	public static IDisposable MHELOKCAJOE(this MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6827400", Offset = "0x6826200", VA = "0x186827400")]
	public static IDisposable DIHFIOOAPBI(this MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6827350", Offset = "0x6826150", VA = "0x186827350")]
	public static IDisposable AHDKHAKFFKF(this MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6827480", Offset = "0x6826280", VA = "0x186827480")]
	public static IDisposable FNDNMBLNPOO(this MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68279E0", Offset = "0x68267E0", VA = "0x1868279E0")]
	public static IDisposable JLBEAHCEAIF(this MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6827A80", Offset = "0x6826880", VA = "0x186827A80")]
	public static IDisposable KBGLIFGBFFC(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6827E50", Offset = "0x6826C50", VA = "0x186827E50")]
	public static IDisposable PJCGKAAMJEN(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68275A0", Offset = "0x68263A0", VA = "0x1868275A0")]
	public static IDisposable GAPANEHHHMK(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68278A0", Offset = "0x68266A0", VA = "0x1868278A0")]
	public static IDisposable ILJBILFKBFI(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6827640", Offset = "0x6826440", VA = "0x186827640")]
	public static IDisposable GHEOPCKHLDG(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6827800", Offset = "0x6826600", VA = "0x186827800")]
	public static IDisposable IKOCPGNNBAE(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6827940", Offset = "0x6826740", VA = "0x186827940")]
	public static IDisposable JEIHGEEOOBP(this MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6827DA0", Offset = "0x6826BA0", VA = "0x186827DA0")]
	public static IDisposable NDJCIIBFPJG(this MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CPDKDCKNOCA
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EDNBBNPHDLN : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BDFKPAJKOLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private NDPKEDLADPH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public EDNBBNPHDLN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x682D050", Offset = "0x682BE50", VA = "0x18682D050", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x682D130", Offset = "0x682BF30", VA = "0x18682D130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class DGLPHGHCGOM : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BDFKPAJKOLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NDPKEDLADPH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public DGLPHGHCGOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x682C2F0", Offset = "0x682B0F0", VA = "0x18682C2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x682C3E0", Offset = "0x682B1E0", VA = "0x18682C3E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68285E0", Offset = "0x68273E0", VA = "0x1868285E0")]
	public static JAAHELMEOKP HKAIDANNFCF(Action ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6828520", Offset = "0x6827320", VA = "0x186828520")]
	public static JAAHELMEOKP HKAIDANNFCF(Behaviour HOLFPPNPJAH, Action ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6828400", Offset = "0x6827200", VA = "0x186828400")]
	public static JAAHELMEOKP HKAIDANNFCF(Behaviour HOLFPPNPJAH, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6828720", Offset = "0x6827520", VA = "0x186828720")]
	[IteratorStateMachine(typeof(EDNBBNPHDLN))]
	private static IEnumerator<FOAIHJNBGIP> ILAIPAGEPPO(BDFKPAJKOLB DOHAMGIDJBI, Action ECAHKGEBDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6828690", Offset = "0x6827490", VA = "0x186828690")]
	[IteratorStateMachine(typeof(DGLPHGHCGOM))]
	private static IEnumerator<FOAIHJNBGIP> ILAIPAGEPPO(BDFKPAJKOLB DOHAMGIDJBI, Action<float> ECAHKGEBDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CIJLBIJLCNO : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class MLJGLFDFOPF : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public CIJLBIJLCNO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public MLJGLFDFOPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68367A0", Offset = "0x68355A0", VA = "0x1868367A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6836830", Offset = "0x6835630", VA = "0x186836830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly BDFKPAJKOLB DDMOEEIIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Action JILFHFHILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool FCMOJCBMJJE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DCMADFCNNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7ABFC0", VA = "0x1807AD1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6828070", Offset = "0x6826E70", VA = "0x186828070")]
	public CIJLBIJLCNO(BDFKPAJKOLB DDMOEEIIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6827F50", Offset = "0x6826D50", VA = "0x186827F50")]
	[IteratorStateMachine(typeof(MLJGLFDFOPF))]
	private IEnumerator<FOAIHJNBGIP> IAPGFMPKBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6827FD0", Offset = "0x6826DD0", VA = "0x186827FD0", Slot = "4")]
	public void OnCompleted(Action COMGHKCJHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
	public void IKJACAJEPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class KKOMCBMCDDA
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x68337F0", Offset = "0x68325F0", VA = "0x1868337F0")]
	public static CIJLBIJLCNO KEPGPNEAKDP(this BDFKPAJKOLB DDMOEEIIHJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class BACCAAAHAAE
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class DIBLCHKDCKE : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public EJJPBBIENLL schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public DIBLCHKDCKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x682C430", Offset = "0x682B230", VA = "0x18682C430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x682C4B0", Offset = "0x682B2B0", VA = "0x18682C4B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x68253E0", Offset = "0x68241E0", VA = "0x1868253E0")]
	public static JAAHELMEOKP HKAIDANNFCF(float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68254E0", Offset = "0x68242E0", VA = "0x1868254E0")]
	public static JAAHELMEOKP HKAIDANNFCF(MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6825260", Offset = "0x6824060", VA = "0x186825260")]
	public static JAAHELMEOKP CNHDGGLDPLP(MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x68255F0", Offset = "0x68243F0", VA = "0x1868255F0")]
	public static JAAHELMEOKP IJMFFHLLHMC(DODDKKLBDDP HOLFPPNPJAH, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6825700", Offset = "0x6824500", VA = "0x186825700")]
	private static IEnumerator<FOAIHJNBGIP> ILAIPAGEPPO(CHDKJJPHLOF JECPFGDLLME, float CPEOMLABFOD, BDFKPAJKOLB DOHAMGIDJBI, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6825380", Offset = "0x6824180", VA = "0x186825380")]
	private static IEnumerator<FOAIHJNBGIP> GCEMOKDHJOH(CHDKJJPHLOF JECPFGDLLME, float CPEOMLABFOD, BDFKPAJKOLB DOHAMGIDJBI, Action<float> ECAHKGEBDHG, bool IOLGHGNEJJM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x68251D0", Offset = "0x6823FD0", VA = "0x1868251D0")]
	[IteratorStateMachine(typeof(DIBLCHKDCKE))]
	private static IEnumerator<FOAIHJNBGIP> ABJCCFCJKJH(EJJPBBIENLL DKOMLEMJIEE, float CPEOMLABFOD, BDFKPAJKOLB DOHAMGIDJBI, Action<float> ECAHKGEBDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class OLOPHHKPMCH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class GMOLGBGKHBL : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public BDFKPAJKOLB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public GMOLGBGKHBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x682EB90", Offset = "0x682D990", VA = "0x18682EB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x682EC50", Offset = "0x682DA50", VA = "0x18682EC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6838AA0", Offset = "0x68378A0", VA = "0x186838AA0")]
	[IteratorStateMachine(typeof(GMOLGBGKHBL))]
	private static IEnumerator<FOAIHJNBGIP> LDAPBFLFKNC(BDFKPAJKOLB DDMOEEIIHJF, Func<bool> CCJANDCJFAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6838980", Offset = "0x6837780", VA = "0x186838980")]
	public static JAAHELMEOKP EGPFMIEAFEB(this MonoBehaviour OGDFPCJOLPE, Func<bool> CCJANDCJFAE, BDFKPAJKOLB DDMOEEIIHJF = BDFKPAJKOLB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class MIFDFGHMLIL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GFLCDGGNALC : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BDFKPAJKOLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public GFLCDGGNALC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x682E8D0", Offset = "0x682D6D0", VA = "0x18682E8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x682E940", Offset = "0x682D740", VA = "0x18682E940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class FLABEHBLMLP : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public BDFKPAJKOLB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private FOAIHJNBGIP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public FLABEHBLMLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x682DDD0", Offset = "0x682CBD0", VA = "0x18682DDD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x682DE60", Offset = "0x682CC60", VA = "0x18682DE60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6833F90", Offset = "0x6832D90", VA = "0x186833F90")]
	[IteratorStateMachine(typeof(GFLCDGGNALC))]
	private static IEnumerator<FOAIHJNBGIP> IAPGFMPKBGG(float JDMCAOCKBDE, BDFKPAJKOLB DOHAMGIDJBI, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6833D60", Offset = "0x6832B60", VA = "0x186833D60")]
	[IteratorStateMachine(typeof(FLABEHBLMLP))]
	private static IEnumerator<FOAIHJNBGIP> AOLDINOCGJO(float JDMCAOCKBDE, BDFKPAJKOLB DOHAMGIDJBI, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6834360", Offset = "0x6833160", VA = "0x186834360")]
	public static IDisposable KIJACFFFCAH(this MonoBehaviour OGDFPCJOLPE, float JDMCAOCKBDE, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6833E00", Offset = "0x6832C00", VA = "0x186833E00")]
	public static JAAHELMEOKP FLGOMAPONIL(this MonoBehaviour OGDFPCJOLPE, float JDMCAOCKBDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6834230", Offset = "0x6833030", VA = "0x186834230")]
	public static JAAHELMEOKP KIJACFFFCAH(this MonoBehaviour OGDFPCJOLPE, float JDMCAOCKBDE, BDFKPAJKOLB DOHAMGIDJBI, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6834550", Offset = "0x6833350", VA = "0x186834550")]
	public static JAAHELMEOKP MGNEEFPGOFE(this MonoBehaviour OGDFPCJOLPE, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6834640", Offset = "0x6833440", VA = "0x186834640")]
	public static JAAHELMEOKP OEFDIFADALF(this MonoBehaviour OGDFPCJOLPE, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6834670", Offset = "0x6833470", VA = "0x186834670")]
	public static JAAHELMEOKP PNCNKGJJKJF(this MonoBehaviour OGDFPCJOLPE, Action ANOLKHFMNBM, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6834130", Offset = "0x6832F30", VA = "0x186834130")]
	public static JAAHELMEOKP JICOBJEGBMI(this MonoBehaviour OGDFPCJOLPE, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6834030", Offset = "0x6832E30", VA = "0x186834030")]
	public static JAAHELMEOKP IGKFLLEMGIK(this MonoBehaviour OGDFPCJOLPE, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6833EC0", Offset = "0x6832CC0", VA = "0x186833EC0")]
	private static JAAHELMEOKP FMKFOMALNAO(MonoBehaviour OGDFPCJOLPE, BDFKPAJKOLB DDMOEEIIHJF, Action ANOLKHFMNBM, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6834160", Offset = "0x6832F60", VA = "0x186834160")]
	public static JAAHELMEOKP KHGAMALNMNH(this MonoBehaviour OGDFPCJOLPE, float FBBKKMONECA, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6834570", Offset = "0x6833370", VA = "0x186834570")]
	public static JAAHELMEOKP NLJEFAMAEJE(this MonoBehaviour OGDFPCJOLPE, float FBBKKMONECA, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6834480", Offset = "0x6833280", VA = "0x186834480")]
	public static JAAHELMEOKP KNFGGDDIFAM(this MonoBehaviour OGDFPCJOLPE, float FBBKKMONECA, Action ANOLKHFMNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6834060", Offset = "0x6832E60", VA = "0x186834060")]
	public static JAAHELMEOKP ILMIGFHDELI(this MonoBehaviour OGDFPCJOLPE, float FBBKKMONECA, Action ANOLKHFMNBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OMNNKKAHLCI : BKAHBINOIGO, IEnumerable<BKAHBINOIGO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<BKAHBINOIGO> DNPLMNLALGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool EOKBBPEIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Action MJFDHAHIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool AILJDNDPMGO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DNDCGIGCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x68390C0", Offset = "0x6837EC0", VA = "0x1868390C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OIKBJDDNEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6838F80", Offset = "0x6837D80", VA = "0x186838F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6839020", Offset = "0x6837E20", VA = "0x186839020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x68393E0", Offset = "0x68381E0", VA = "0x1868393E0")]
	public OMNNKKAHLCI([Optional] Action MJFDHAHIMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6838E50", Offset = "0x6837C50", VA = "0x186838E50")]
	public void ANMBPKAMKOK(BKAHBINOIGO HFPPEPGFBJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6839200", Offset = "0x6838000", VA = "0x186839200")]
	private void EICPNFDBFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6838B30", Offset = "0x6837930", VA = "0x186838B30", Slot = "7")]
	public bool AEHOHADDAMK(bool KCOHBBNEOFL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6838B40", Offset = "0x6837940", VA = "0x186838B40", Slot = "8")]
	public bool AEHOHADDAMK(Action ENHEBPDFNME, bool KCOHBBNEOFL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6839360", Offset = "0x6838160", VA = "0x186839360", Slot = "9")]
	public IEnumerator<BKAHBINOIGO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6839360", Offset = "0x6838160", VA = "0x186839360", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class DNLOBIKKMEA : PCBJHIENLMO
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KDCOJKPAFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public DNLOBIKKMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public KDCOJKPAFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x682D180", Offset = "0x682BF80", VA = "0x18682D180")]
		internal void EICINJOKCBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EFABJCIKCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public DNLOBIKKMEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EFABJCIKCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x682D180", Offset = "0x682BF80", VA = "0x18682D180")]
		internal void ODCINEOEICM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly float LILFPALIBNO;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x682C9D0", Offset = "0x682B7D0", VA = "0x18682C9D0")]
	public DNLOBIKKMEA(Behaviour HOLFPPNPJAH, float LILFPALIBNO, [Optional] Action MJFDHAHIMBB, [Optional] FLGAHHENDKL APDOPEGHFKC, [Optional] CHDKJJPHLOF JECPFGDLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x682C7B0", Offset = "0x682B5B0", VA = "0x18682C7B0", Slot = "9")]
	protected override bool CEOKIOAKFKL(Action ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x682C8C0", Offset = "0x682B6C0", VA = "0x18682C8C0", Slot = "10")]
	protected override bool PAFPJDEMPAF(Action ENHEBPDFNME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BKAHBINOIGO
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DNDCGIGCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OIKBJDDNEGA;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AEHOHADDAMK(bool KCOHBBNEOFL = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AEHOHADDAMK(Action ENHEBPDFNME, bool KCOHBBNEOFL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class PCBJHIENLMO : BKAHBINOIGO
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class BDDOMKDKAKJ : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PCBJHIENLMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public BDDOMKDKAKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x68257C0", Offset = "0x68245C0", VA = "0x1868257C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6825890", Offset = "0x6824690", VA = "0x186825890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly Behaviour HOLFPPNPJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action MJFDHAHIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private CGFEIOGFEMJ JHDPFBIMFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly FLGAHHENDKL APDOPEGHFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly CHDKJJPHLOF JECPFGDLLME;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DNDCGIGCAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xF344C0", Offset = "0xF332C0", VA = "0x180F344C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OIKBJDDNEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x683C7E0", Offset = "0x683B5E0", VA = "0x18683C7E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x683C880", Offset = "0x683B680", VA = "0x18683C880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x683CA90", Offset = "0x683B890", VA = "0x18683CA90")]
	protected PCBJHIENLMO(Behaviour HOLFPPNPJAH, [Optional] Action MJFDHAHIMBB, [Optional] FLGAHHENDKL APDOPEGHFKC, [Optional] CHDKJJPHLOF JECPFGDLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x683C540", Offset = "0x683B340", VA = "0x18683C540", Slot = "7")]
	public bool AEHOHADDAMK(bool KCOHBBNEOFL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x683C4E0", Offset = "0x683B2E0", VA = "0x18683C4E0", Slot = "8")]
	public bool AEHOHADDAMK(Action ENHEBPDFNME, bool KCOHBBNEOFL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CEOKIOAKFKL(Action ENHEBPDFNME);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PAFPJDEMPAF(Action ENHEBPDFNME);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x683C920", Offset = "0x683B720", VA = "0x18683C920")]
	protected void FACHEMKJMBJ(Action ENHEBPDFNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x683C5A0", Offset = "0x683B3A0", VA = "0x18683C5A0")]
	protected AJKHGLHHDGH BCHJABGPAEM(float JABPPPAGBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x683C940", Offset = "0x683B740", VA = "0x18683C940")]
	private void KLFAIMHGLCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x683CA00", Offset = "0x683B800", VA = "0x18683CA00")]
	[IteratorStateMachine(typeof(BDDOMKDKAKJ))]
	private IEnumerator<FOAIHJNBGIP> PPGKMFJONGK(float JABPPPAGBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x683C9C0", Offset = "0x683B7C0", VA = "0x18683C9C0")]
	[CompilerGenerated]
	private void LFFKGJGJFEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KJJPLONJIJM : PCBJHIENLMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly float FLBNBOHGBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly int LNFACJFOJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly float AGCIHJANNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly float[] HBNKMPGJPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int BNGLHPOMNBN;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6833650", Offset = "0x6832450", VA = "0x186833650")]
	public KJJPLONJIJM(Behaviour HOLFPPNPJAH, float BPFMNCANGJN, int LNFACJFOJEF, [Optional] Action MJFDHAHIMBB, float AGCIHJANNOG = 0f, [Optional] FLGAHHENDKL APDOPEGHFKC, [Optional] CHDKJJPHLOF JECPFGDLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "9")]
	protected override bool CEOKIOAKFKL(Action ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6833450", Offset = "0x6832250", VA = "0x186833450", Slot = "10")]
	protected override bool PAFPJDEMPAF(Action ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x68333D0", Offset = "0x68321D0", VA = "0x1868333D0")]
	private void EBGCPJJCBAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DPCMCDFBGDJ : PCBJHIENLMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly float LILFPALIBNO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x682C9D0", Offset = "0x682B7D0", VA = "0x18682C9D0")]
	public DPCMCDFBGDJ(Behaviour HOLFPPNPJAH, float LILFPALIBNO, [Optional] Action MJFDHAHIMBB, [Optional] FLGAHHENDKL APDOPEGHFKC, [Optional] CHDKJJPHLOF JECPFGDLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "9")]
	protected override bool CEOKIOAKFKL(Action ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x682CAD0", Offset = "0x682B8D0", VA = "0x18682CAD0", Slot = "10")]
	protected override bool PAFPJDEMPAF(Action ENHEBPDFNME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class PHFIGALLOKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class ANMFKGINFMD : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public ANMFKGINFMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6822710", Offset = "0x6821510", VA = "0x186822710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6825180", Offset = "0x6823F80", VA = "0x186825180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private JAAHELMEOKP IACDCDDOKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private DODDKKLBDDP HOLFPPNPJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Action<float> NHEPPBDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private BDFKPAJKOLB DDMOEEIIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float GFLGPACPHDJ;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x683D120", Offset = "0x683BF20", VA = "0x18683D120")]
	public PHFIGALLOKA(DODDKKLBDDP HOLFPPNPJAH, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x683CB90", Offset = "0x683B990", VA = "0x18683CB90")]
	private void BOHNBJHCAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x683CD30", Offset = "0x683BB30", VA = "0x18683CD30")]
	private void DAKELJPMBAM(string OLGJDMIGDKI, Action JOADGGGHJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x683D0A0", Offset = "0x683BEA0", VA = "0x18683D0A0")]
	[IteratorStateMachine(typeof(ANMFKGINFMD))]
	private IEnumerator<FOAIHJNBGIP> NBJHNPCFGBP(Action JOADGGGHJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x683CE90", Offset = "0x683BC90", VA = "0x18683CE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x683CEF0", Offset = "0x683BCF0", VA = "0x18683CEF0")]
	[CompilerGenerated]
	private void MJFCFEGICMM(string IHEECNGJNNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class IGKECNEOIKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class AAEIADJHECC : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private FOAIHJNBGIP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public AAEIADJHECC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6822710", Offset = "0x6821510", VA = "0x186822710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6822780", Offset = "0x6821580", VA = "0x186822780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private JAAHELMEOKP IACDCDDOKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MonoBehaviour OGDFPCJOLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Action ECAHKGEBDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Action<float> NHEPPBDDAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private BDFKPAJKOLB DDMOEEIIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float GFLGPACPHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool IOLGHGNEJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly FLGAHHENDKL APDOPEGHFKC;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6831950", Offset = "0x6830750", VA = "0x186831950")]
	public IGKECNEOIKO(MonoBehaviour OGDFPCJOLPE, Action ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6831710", Offset = "0x6830510", VA = "0x186831710")]
	public IGKECNEOIKO(MonoBehaviour OGDFPCJOLPE, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6831B40", Offset = "0x6830940", VA = "0x186831B40")]
	public IGKECNEOIKO(MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1915D10", Offset = "0x1914B10", VA = "0x181915D10")]
	private IGKECNEOIKO(FLGAHHENDKL APDOPEGHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x68314D0", Offset = "0x68302D0", VA = "0x1868314D0")]
	internal static IGKECNEOIKO LLADKFEEGOF(MonoBehaviour OGDFPCJOLPE, float CPEOMLABFOD, Action<float> ECAHKGEBDHG, BDFKPAJKOLB DDMOEEIIHJF, bool IOLGHGNEJJM = true, [Optional] FLGAHHENDKL APDOPEGHFKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6830ED0", Offset = "0x682FCD0", VA = "0x186830ED0")]
	private void HKAIDANNFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6831320", Offset = "0x6830120", VA = "0x186831320")]
	private void JILENFMBMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6830B00", Offset = "0x682F900", VA = "0x186830B00")]
	private void BOHNBJHCAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x68310D0", Offset = "0x682FED0", VA = "0x1868310D0")]
	private void IKDODEKAGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6830CB0", Offset = "0x682FAB0", VA = "0x186830CB0")]
	private void DAKELJPMBAM(string OLGJDMIGDKI, Action JOADGGGHJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6831600", Offset = "0x6830400", VA = "0x186831600")]
	[IteratorStateMachine(typeof(AAEIADJHECC))]
	private IEnumerator<FOAIHJNBGIP> NBJHNPCFGBP(Action JOADGGGHJHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6830E70", Offset = "0x682FC70", VA = "0x186830E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6831040", Offset = "0x682FE40", VA = "0x186831040")]
	[CompilerGenerated]
	private void IIJIODGBAHE(string IHEECNGJNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6831680", Offset = "0x6830480", VA = "0x186831680")]
	[CompilerGenerated]
	private void PACIOCGDOIJ(string IHEECNGJNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6831290", Offset = "0x6830090", VA = "0x186831290")]
	[CompilerGenerated]
	private void JBOMLKADINH(string IHEECNGJNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6830DE0", Offset = "0x682FBE0", VA = "0x186830DE0")]
	[CompilerGenerated]
	private void DPALPOCLDPD(string IHEECNGJNNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Flags]
internal enum FLPKKFPNKCG : byte
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
internal sealed class DLOPMMBLGFC : CHDKJJPHLOF
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float INFPDOOBKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x682C700", Offset = "0x682B500", VA = "0x18682C700", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float LKIPGOJHJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x682C710", Offset = "0x682B510", VA = "0x18682C710", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double IKHCPEKKIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x682C720", Offset = "0x682B520", VA = "0x18682C720", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x682C740", Offset = "0x682B540", VA = "0x18682C740")]
	[NAAAALLPNIA(PBKIGNPNCFO.None)]
	private static void LDHJJHENCJM(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[Preserve]
	internal DLOPMMBLGFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal interface MICNNNGPHKE
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNEKMOEPADM(string OHHBGJPCFJD);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJEMICLLACO();
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal interface EJOALAKIHOA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool FNOLGJBGBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool PPAFNGAGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal class IDOAEFGPHKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public AAKDAPLEIBO JOJDKFBIGHL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int CCEAOHGDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2BB0", VA = "0x1807B3DB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x68306F0", Offset = "0x682F4F0", VA = "0x1868306F0")]
	public static FOAIHJNBGIP AKDKIPNDIFL(IEnumerator<FOAIHJNBGIP> KLILMMGKBMA, CLLJPGEPJPC NFFBABGBFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6830630", Offset = "0x682F430", VA = "0x186830630")]
	public FOAIHJNBGIP AKDKIPNDIFL(CLLJPGEPJPC[] MCPEMHGGBOG, IEnumerator<FOAIHJNBGIP>[] MKGDEJIOBNO, FOAIHJNBGIP[] LOCLLKILCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6830850", Offset = "0x682F650", VA = "0x186830850")]
	public void LPBFODIAHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x68309C0", Offset = "0x682F7C0", VA = "0x1868309C0")]
	public void NPCHJBKOONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6830880", Offset = "0x682F680", VA = "0x186830880")]
	public void MOLDNDAAPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6830850", Offset = "0x682F650", VA = "0x186830850")]
	public void DFGOIMAHHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public IDOAEFGPHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal sealed class AAKDAPLEIBO
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct CMIIPIKHLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public IDOAEFGPHKK PABAAGMFOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public DODDKKLBDDP IOEPJOJMNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public CLLJPGEPJPC HMEAPBPOLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IEnumerator<FOAIHJNBGIP> IHGJBCNLNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public FOAIHJNBGIP JEGOPPGKAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FLPKKFPNKCG OOMAOAIFIGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct NBAFJEEDHNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public BDFKPAJKOLB BCLDKHGABGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<CMIIPIKHLMA> FOPCPEDGBND;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IKMLGHIHAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CLLJPGEPJPC promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AAKDAPLEIBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public DODDKKLBDDP context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public IDOAEFGPHKK routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FLPKKFPNKCG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public FOAIHJNBGIP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public IEnumerator<FOAIHJNBGIP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IKMLGHIHAAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6831EB0", Offset = "0x6830CB0", VA = "0x186831EB0")]
		internal void JAHFPBPIDEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class NPDEMCKACGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IDOAEFGPHKK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public AAKDAPLEIBO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NPDEMCKACGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x68373E0", Offset = "0x68361E0", VA = "0x1868373E0")]
		internal void FJHNPEHFGIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JDDKGHHDMGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IDOAEFGPHKK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public AAKDAPLEIBO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JDDKGHHDMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x68328D0", Offset = "0x68316D0", VA = "0x1868328D0")]
		internal void JKNDOBEGKBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class JOIKCEHFGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public IDOAEFGPHKK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AAKDAPLEIBO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JOIKCEHFGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6832C30", Offset = "0x6831A30", VA = "0x186832C30")]
		internal void HIADILGCNMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private const FLPKKFPNKCG KMJJDBCLLII = FLPKKFPNKCG.Cancelled | FLPKKFPNKCG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly BDFKPAJKOLB DDMOEEIIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool[] COINCJFNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<FLPKKFPNKCG> EKKHKHANKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<float> KGNBIFONLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<int> BGHHGMKNMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> KNDLNMGFIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> BKIPFJIGACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> ELBAOHOJMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> EKLECFOKDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private IDOAEFGPHKK[] CEFGHGEMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CLLJPGEPJPC[] MCPEMHGGBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DODDKKLBDDP[] NLBMHPKLMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IEnumerator<FOAIHJNBGIP>[] EBMELOJILJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private FOAIHJNBGIP[] PGCJFIMEGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int DIMGPFPPMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int BKPALGGNBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly int ILMMPAFNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float HLDNGGMIMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private EFONJPMPMPK LNBMCEMNJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JobHandle FHMMEDIMIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private List<IDOAEFGPHKK> BJPIICPBONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool ODKDCCFEELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private List<Action> PFBDGPNBCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> ABNAMKDLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private bool PBJDEACBJDB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NBAFJEEDHNJ[] LNABKKLONLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x91E160", Offset = "0x91CF60", VA = "0x18091E160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6822C70", Offset = "0x6821A70", VA = "0x186822C70")]
	private static int BEMDCHJJNDE(BDFKPAJKOLB DDMOEEIIHJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6824B30", Offset = "0x6823930", VA = "0x186824B30")]
	public AAKDAPLEIBO(BDFKPAJKOLB DDMOEEIIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x68236D0", Offset = "0x68224D0", VA = "0x1868236D0")]
	private void FMNPJMFFECF(int JNGLIKMFAKB, int FAMPDCHPGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6822DD0", Offset = "0x6821BD0", VA = "0x186822DD0")]
	public void DGEKJAKPELH(DODDKKLBDDP HOLFPPNPJAH, FOAIHJNBGIP BCBHGGBOCMK, IEnumerator<FOAIHJNBGIP> KLILMMGKBMA, CLLJPGEPJPC NFFBABGBFPO, [Optional] IDOAEFGPHKK DBKINJBJKAL, FLPKKFPNKCG BHLMGOEJEJO = FLPKKFPNKCG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x68248F0", Offset = "0x68236F0", VA = "0x1868248F0")]
	public void PALGEKGKIDP(IEnumerable<CMIIPIKHLMA> BNOKEBGEDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6824420", Offset = "0x6823220", VA = "0x186824420")]
	private CMIIPIKHLMA PAAILDCCIPE(int DMFGGALOOLD)
	{
		return default(CMIIPIKHLMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x68227D0", Offset = "0x68215D0", VA = "0x1868227D0")]
	private void AEOIHABPMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD9B0", Offset = "0x2CBC7B0", VA = "0x182CBD9B0")]
	private static void ACFOBHHEMME<T>(int DMFGGALOOLD, T[] COAMAOBMIOC, int DDGPJFNNFJK, [Optional] T DABDOMEOMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDA00", Offset = "0x2CBC800", VA = "0x182CBDA00")]
	private static void ACFOBHHEMME<T>(int DMFGGALOOLD, NativeArray<T> COAMAOBMIOC, int DDGPJFNNFJK, [Optional] T DABDOMEOMLP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6823330", Offset = "0x6822130", VA = "0x186823330")]
	private void FHHEIGNICDC(IEnumerable<CMIIPIKHLMA> BNOKEBGEDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6824230", Offset = "0x6823030", VA = "0x186824230")]
	private void KPAJIHJGIIG(CMIIPIKHLMA MDBKNEABNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6822FD0", Offset = "0x6821DD0", VA = "0x186822FD0")]
	private EBOKABEHLNO EDLOADHDEPD(int NMPPPIDDBOC)
	{
		return default(EBOKABEHLNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6824030", Offset = "0x6822E30", VA = "0x186824030")]
	public void JFGEGNEDADA(float PLKNIACIGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6822F50", Offset = "0x6821D50", VA = "0x186822F50")]
	private void EDGPHCABMCM(Action GCMDJKOKHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6823FB0", Offset = "0x6822DB0", VA = "0x186823FB0")]
	private void HDDDGPKKOIH(Action GCMDJKOKHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x68238B0", Offset = "0x68226B0", VA = "0x1868238B0")]
	public void GCHGNFJDIKK(float PLKNIACIGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6823230", Offset = "0x6822030", VA = "0x186823230")]
	public void EMJKKLCOFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6822CA0", Offset = "0x6821AA0", VA = "0x186822CA0")]
	public void DFGOIMAHHAK(IDOAEFGPHKK DKOMLEMJIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x68242F0", Offset = "0x68230F0", VA = "0x1868242F0")]
	public void MDNAADKDOBG(IDOAEFGPHKK DKOMLEMJIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6822B40", Offset = "0x6821940", VA = "0x186822B40")]
	public void BCCLGFHICML(IDOAEFGPHKK DKOMLEMJIEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class HBKJGEDLODJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public static readonly HBKJGEDLODJ NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Action MHKMOBJEBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool OADMEOKPNBL;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public HBKJGEDLODJ(Action MHKMOBJEBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x609B9E0", Offset = "0x609A7E0", VA = "0x18609B9E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface MALCKCJOBEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LLJJBJLDJDK(UnityEngine.Object HOLFPPNPJAH, Action<T> PJACPPNHKPN);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface EFAAFAMMCBH<T> : MALCKCJOBEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class FPFHAMJPNAC<T> : EFAAFAMMCBH<T>, MALCKCJOBEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class CJODNIONEDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public FPFHAMJPNAC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public DNBANAGLFEI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CJODNIONEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4A56250", Offset = "0x4A55050", VA = "0x184A56250")]
		internal void GAHNFFGGMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static GameObject CKECIGBJHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<DNBANAGLFEI<UnityEngine.Object, Action<T>>> CMONGMJBOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T PIAOMDKMNKA;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x35E67A0", Offset = "0x35E55A0", VA = "0x1835E67A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x35E68D0", Offset = "0x35E56D0", VA = "0x1835E68D0")]
	private static bool LEEFDKMPPHI(T GCMDJKOKHCO, T LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x35E6CC0", Offset = "0x35E5AC0", VA = "0x1835E6CC0")]
	public FPFHAMJPNAC(T ONPPCKLGPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x35E69A0", Offset = "0x35E57A0", VA = "0x1835E69A0", Slot = "6")]
	public IDisposable LLJJBJLDJDK(UnityEngine.Object HOLFPPNPJAH, Action<T> PJACPPNHKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x35E6140", Offset = "0x35E4F40", VA = "0x1835E6140")]
	private void DHLNEOFGDDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class JLAMHJGCHCM : OEKMCJPLBIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FLGAHHENDKL APDOPEGHFKC;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6832BC0", Offset = "0x68319C0", VA = "0x186832BC0")]
	[NAAAALLPNIA(PBKIGNPNCFO.None)]
	private static void LDHJJHENCJM(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	[Preserve]
	internal JLAMHJGCHCM([LICAMFFCLCL(null)] FLGAHHENDKL APDOPEGHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6832B10", Offset = "0x6831910", VA = "0x186832B10", Slot = "4")]
	public IDisposable JLBEAHCEAIF(float CPEOMLABFOD, Action<float> IDFHKFHMFGD, bool IOLGHGNEJJM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class BJPGBLEHKGH : OKHNFNPICIE, FLGAHHENDKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private AAKDAPLEIBO[] CJEKIIIDMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private MICNNNGPHKE FOKNEJPIELO;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6826E20", Offset = "0x6825C20", VA = "0x186826E20")]
	[NAAAALLPNIA(PBKIGNPNCFO.None)]
	private static void LDHJJHENCJM(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6827290", Offset = "0x6826090", VA = "0x186827290")]
	[Preserve]
	public BJPGBLEHKGH([LICAMFFCLCL(null)] DJHJGNKNHBF BCIJEIFOEMH, [LICAMFFCLCL(null)] CHDKJJPHLOF JECPFGDLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6826CF0", Offset = "0x6825AF0", VA = "0x186826CF0", Slot = "16")]
	public override JAAHELMEOKP LBOAFFNBGIM(DODDKKLBDDP HOLFPPNPJAH, IEnumerator<FOAIHJNBGIP> AENKPMHLEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6827000", Offset = "0x6825E00", VA = "0x186827000", Slot = "17")]
	public override void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6826810", Offset = "0x6825610", VA = "0x186826810", Slot = "19")]
	public override void JLPHNPDDAJH(BDFKPAJKOLB DDMOEEIIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6826E90", Offset = "0x6825C90", VA = "0x186826E90", Slot = "18")]
	protected override void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x68267E0", Offset = "0x68255E0", VA = "0x1868267E0")]
	private AAKDAPLEIBO JLHDLNMBKEH(BDFKPAJKOLB HFFNCGFKMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6826A40", Offset = "0x6825840", VA = "0x186826A40", Slot = "20")]
	internal override OPPKLDNGOLL KOGICEEOMDB(IEnumerator<FOAIHJNBGIP> AENKPMHLEHD, Behaviour HOLFPPNPJAH, CLLJPGEPJPC NFFBABGBFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6826C70", Offset = "0x6825A70", VA = "0x186826C70", Slot = "21")]
	internal override MLDAGIMFELJ LALOAMGGBPJ(BDFKPAJKOLB DOHAMGIDJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x68266C0", Offset = "0x68254C0", VA = "0x1868266C0")]
	private void HLGOMNCCOHE(AAKDAPLEIBO HNPCIBACFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6826660", Offset = "0x6825460", VA = "0x186826660", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[BurstCompile]
internal struct EFONJPMPMPK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	public float JFGMDLNCBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	public int KOBJEGLOGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NativeArray<int> FKCOPGGANLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private NativeArray<int> HICNLLFMGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private NativeArray<int> IPPBOOPEODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public NativeArray<FLPKKFPNKCG> AGOKIKMFJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	public NativeArray<float> LGEMFLNDPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[WriteOnly]
	public NativeArray<int> BKIPFJIGACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[WriteOnly]
	public NativeArray<int> BGHHGMKNMOH;

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x682D370", Offset = "0x682C170", VA = "0x18682D370")]
	public static EFONJPMPMPK IKNJBMGGGFK(int OLNFLJANFMO, float PLKNIACIGLP, NativeArray<FLPKKFPNKCG> PNEMEFODDBA, NativeArray<float> JEFOEKIANMB, NativeArray<int> GLPEPMLCNKI, NativeArray<int> KDNJPHEGFGO, NativeArray<int> NJMLJFNOALH, NativeArray<int> HICNLLFMGHM, NativeArray<int> IPPBOOPEODD)
	{
		return default(EFONJPMPMPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x682D1F0", Offset = "0x682BFF0", VA = "0x18682D1F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x682D1B0", Offset = "0x682BFB0", VA = "0x18682D1B0")]
	private bool ALIKIHJGPFP(int ENPOKNEMOMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x682D3D0", Offset = "0x682C1D0", VA = "0x18682D3D0")]
	private void JJACGNIDOLC(NativeArray<int> NEJIMKHBJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x682D2D0", Offset = "0x682C0D0", VA = "0x18682D2D0")]
	private int GMBCGCFDFPI(int KGACFHIJHGI, int JGPOPNHHKHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x682D400", Offset = "0x682C200", VA = "0x18682D400")]
	private void LCNDFDAALGH(NativeArray<int> NEJIMKHBJEM, int ADLPNIDCBGE, int KEGMCPHLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x682D4D0", Offset = "0x682C2D0", VA = "0x18682D4D0")]
	private void MJCCFJFJHMG(NativeArray<int> NEJIMKHBJEM, int HDDPMCIHJMH, int AGGNAAEIKJL, int MOFAMKGLNDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class OKHNFNPICIE : FLGAHHENDKL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly DJHJGNKNHBF BCIJEIFOEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected readonly CHDKJJPHLOF JECPFGDLLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private MLDAGIMFELJ[] AMDGCFHPLJH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static FLGAHHENDKL AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x68383B0", Offset = "0x68371B0", VA = "0x1868383B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BDFKPAJKOLB DCJDFHBNHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BDFKPAJKOLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2BB0", VA = "0x1807B3DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CHDKJJPHLOF NKFJBNFGCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FOAIHJNBGIP POJHMNIPDOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6838400", Offset = "0x6837200", VA = "0x186838400")]
	public static JAAHELMEOKP NLKLMOHKNBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6838490", Offset = "0x6837290", VA = "0x186838490")]
	[Preserve]
	protected OKHNFNPICIE([LICAMFFCLCL(null)] DJHJGNKNHBF BCIJEIFOEMH, [LICAMFFCLCL(null)] CHDKJJPHLOF JECPFGDLLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6837F50", Offset = "0x6836D50", VA = "0x186837F50", Slot = "6")]
	public JAAHELMEOKP MICHEHPNDIJ(IEnumerator<FOAIHJNBGIP> AENKPMHLEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6837F60", Offset = "0x6836D60", VA = "0x186837F60", Slot = "7")]
	public JAAHELMEOKP MICHEHPNDIJ(Behaviour HOLFPPNPJAH, IEnumerator<FOAIHJNBGIP> AENKPMHLEHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract JAAHELMEOKP LBOAFFNBGIM(DODDKKLBDDP HOLFPPNPJAH, IEnumerator<FOAIHJNBGIP> AENKPMHLEHD);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x68381F0", Offset = "0x6836FF0", VA = "0x1868381F0", Slot = "17")]
	public virtual void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6837550", Offset = "0x6836350", VA = "0x186837550", Slot = "9")]
	public void AABLEABACGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6837F10", Offset = "0x6836D10", VA = "0x186837F10", Slot = "18")]
	protected virtual void LLIADGIKINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6837C30", Offset = "0x6836A30", VA = "0x186837C30")]
	private void FFGPPANBMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6837ED0", Offset = "0x6836CD0", VA = "0x186837ED0")]
	private void KCJMOPELKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6837F30", Offset = "0x6836D30", VA = "0x186837F30")]
	private void MBMAKNJPLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6837EF0", Offset = "0x6836CF0", VA = "0x186837EF0")]
	private void KHALEDIHAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6837850", Offset = "0x6836650", VA = "0x186837850")]
	private void DGILGBBIJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6837E20", Offset = "0x6836C20", VA = "0x186837E20")]
	private void GMEJJDFMCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6838390", Offset = "0x6837190", VA = "0x186838390")]
	private void NCKPODDIDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6837E40", Offset = "0x6836C40", VA = "0x186837E40", Slot = "19")]
	public virtual void JLPHNPDDAJH(BDFKPAJKOLB DDMOEEIIHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6837C50", Offset = "0x6836A50", VA = "0x186837C50")]
	private void GICAKGNAGAI(MLDAGIMFELJ HNPCIBACFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1CA6310", Offset = "0x1CA5110", VA = "0x181CA6310")]
	private MLDAGIMFELJ NACJAIJNFKK(BDFKPAJKOLB HFFNCGFKMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract OPPKLDNGOLL KOGICEEOMDB(IEnumerator<FOAIHJNBGIP> AENKPMHLEHD, Behaviour OGDFPCJOLPE, CLLJPGEPJPC GDBPGBKIAKM);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract MLDAGIMFELJ LALOAMGGBPJ(BDFKPAJKOLB DDMOEEIIHJF);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6837870", Offset = "0x6836670", VA = "0x186837870", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6837790", Offset = "0x6836590", VA = "0x186837790", Slot = "12")]
	public FOAIHJNBGIP BLPAGFNBJJO(BDFKPAJKOLB DOHAMGIDJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6838160", Offset = "0x6836F60", VA = "0x186838160", Slot = "13")]
	public FOAIHJNBGIP MLDLAEGBEKI(float JDMCAOCKBDE, BDFKPAJKOLB DOHAMGIDJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68377F0", Offset = "0x68365F0", VA = "0x1868377F0", Slot = "14")]
	public FOAIHJNBGIP CJLBMOGOIHK(Func<bool> CCJANDCJFAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal sealed class OPPKLDNGOLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly CLLJPGEPJPC NFFBABGBFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly EJOALAKIHOA HOLFPPNPJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly bool AGOKHFLMGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private string OHHBGJPCFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private StackTrace IJFJLHPMGAD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<FOAIHJNBGIP> IHGJBCNLNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FOAIHJNBGIP JEGOPPGKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool CCFOEDHAEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x683C150", Offset = "0x683AF50", VA = "0x18683C150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MJOAMLPIPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x819140", Offset = "0x817F40", VA = "0x180819140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x819150", Offset = "0x817F50", VA = "0x180819150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x683BF50", Offset = "0x683AD50", VA = "0x18683BF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float FPDCCMOEMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1096820", Offset = "0x1095620", VA = "0x181096820")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x55FC740", Offset = "0x55FB540", VA = "0x1855FC740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x683C320", Offset = "0x683B120", VA = "0x18683C320")]
	public OPPKLDNGOLL(IEnumerator<FOAIHJNBGIP> KLILMMGKBMA, EJOALAKIHOA HOLFPPNPJAH, CLLJPGEPJPC NFFBABGBFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x683BC40", Offset = "0x683AA40", VA = "0x18683BC40")]
	public FOAIHJNBGIP AKDKIPNDIFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x683C1D0", Offset = "0x683AFD0", VA = "0x18683C1D0")]
	public bool PJPJNDDBDFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x683C100", Offset = "0x683AF00", VA = "0x18683C100")]
	public void DFGOIMAHHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x683C240", Offset = "0x683B040", VA = "0x18683C240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x89BA50", Offset = "0x89A850", VA = "0x18089BA50")]
	[CompilerGenerated]
	private void GIBIHJOLHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class CLLJPGEPJPC : NPNJFNKJFKO, JAAHELMEOKP, CGFEIOGFEMJ, AJKHGLHHDGH, IEnumerator, FOAIHJNBGIP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private BDFKPAJKOLB DEDNIEIKIDM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private BDFKPAJKOLB GAHGFHONIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xE11520", Offset = "0xE10320", VA = "0x180E11520", Slot = "23")]
		get
		{
			return default(BDFKPAJKOLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public BDFKPAJKOLB JOJDKFBIGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x12FB1C0", Offset = "0x12F9FC0", VA = "0x1812FB1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float HOMJEHLBPND
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7940", Offset = "0x7F6740", VA = "0x1807F7940", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NFMHEMNOACC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6828390", Offset = "0x6827190", VA = "0x186828390", Slot = "24")]
	private bool NGLHHIJBDEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6828380", Offset = "0x6827180", VA = "0x186828380", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x68283B0", Offset = "0x68271B0", VA = "0x1868283B0")]
	public CLLJPGEPJPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal enum EBOKABEHLNO : byte
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
internal sealed class MLDAGIMFELJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum MBMHEOAKMGF
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct CCIDLGDAHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public BDFKPAJKOLB BCLDKHGABGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public MBMHEOAKMGF DIBIAKKCBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public List<OPPKLDNGOLL> MAGCOJEHDLD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly MBMHEOAKMGF[] HMEENEADEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly BDFKPAJKOLB DDMOEEIIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private bool LPJLFIOFFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly OPPKLDNGOLL[] FMHDNCPJJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<OPPKLDNGOLL> LEGADKCNKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> HOADKMCCGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly List<OPPKLDNGOLL> OKHNLLCLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<int> ILLMLJDGCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly MICNNNGPHKE IIMIKPDNNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private bool PBJDEACBJDB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public CCIDLGDAHIF[,] DNOCOEKGCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6836300", Offset = "0x6835100", VA = "0x186836300")]
	public MLDAGIMFELJ(BDFKPAJKOLB DOHAMGIDJBI, MICNNNGPHKE IIMIKPDNNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6835A10", Offset = "0x6834810", VA = "0x186835A10")]
	public void HABFAIKFGAB(OPPKLDNGOLL KLILMMGKBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6834FD0", Offset = "0x6833DD0", VA = "0x186834FD0")]
	public void CHNOLGLBCDB(IList<OPPKLDNGOLL> MKGDEJIOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6835700", Offset = "0x6834500", VA = "0x186835700")]
	public void GDEOLCABFBA(IList<OPPKLDNGOLL> MKGDEJIOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x68360D0", Offset = "0x6834ED0", VA = "0x1868360D0")]
	private void PAOCNFAKEAF(OPPKLDNGOLL KLILMMGKBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6835C50", Offset = "0x6834A50", VA = "0x186835C50")]
	private void JBIIKDGMIHO(IList<OPPKLDNGOLL> MKGDEJIOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6835DE0", Offset = "0x6834BE0", VA = "0x186835DE0")]
	private EBOKABEHLNO KKOPJLGPLOG(OPPKLDNGOLL KLILMMGKBMA)
	{
		return default(EBOKABEHLNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6835F60", Offset = "0x6834D60", VA = "0x186835F60")]
	public void LLIADGIKINC(float PLKNIACIGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6834DE0", Offset = "0x6833BE0", VA = "0x186834DE0")]
	public void AABLEABACGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x68352E0", Offset = "0x68340E0", VA = "0x1868352E0")]
	private void CPJDKIBJBME(List<OPPKLDNGOLL> MKGDEJIOBNO, Stack<int> CGNEJAONNHM, bool LDLGINALPJE, float KIOEGBNPNHP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x68355E0", Offset = "0x68343E0", VA = "0x1868355E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6835B10", Offset = "0x6834910", VA = "0x186835B10")]
	private void IAIAFGPJDIN(List<OPPKLDNGOLL> MKGDEJIOBNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal class EPCMCDKPIOL : MICNNNGPHKE
{
	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public void PNEKMOEPADM(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
	public void OJEMICLLACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EPCMCDKPIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal class GONKNIHDAOO : EJOALAKIHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Behaviour OGDFPCJOLPE;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x682F8B0", Offset = "0x682E6B0", VA = "0x18682F8B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FNOLGJBGBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x682F930", Offset = "0x682E730", VA = "0x18682F930", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PPAFNGAGJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x682F980", Offset = "0x682E780", VA = "0x18682F980", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public GONKNIHDAOO(Behaviour OGDFPCJOLPE)
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

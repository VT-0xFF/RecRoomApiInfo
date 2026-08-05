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
public class PCHNJKGKBFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority PBBJLIKEANK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x568FAA0", Offset = "0x568ECA0", VA = "0x18568FAA0")]
	public PCHNJKGKBFN(ThreadPriority CILMPBGINFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x568FA90", Offset = "0x568EC90", VA = "0x18568FA90", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> EDBLNCAMHMB(List<PlayerLoopSystem> ENKAKAIOPHC, int CGJCFHIENMG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct PMDDDLPJAEE
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct NOFPLCEBPHM
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static CJPPGPOGFKM HDPEFLDNAKI;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x568E120", Offset = "0x568D320", VA = "0x18568E120")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct OAKGDGEHFCJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static CJPPGPOGFKM OJACMIEFLBK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x568E330", Offset = "0x568D530", VA = "0x18568E330")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct JEJMPBKAFAO
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static CJPPGPOGFKM IOLFIADIDAK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x5682880", Offset = "0x5681A80", VA = "0x185682880")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct HNEGMJHNPIP
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CJPPGPOGFKM BNGNPMNBABC;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CJPPGPOGFKM JBJNDCGEIHP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CJPPGPOGFKM GKHNKCDHHFO;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static CJPPGPOGFKM DLLDFIIABNP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5680670", Offset = "0x567F870", VA = "0x185680670")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct OKBDLMDHNPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static CJPPGPOGFKM PNHCONPBBOF;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x568E9C0", Offset = "0x568DBC0", VA = "0x18568E9C0")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct FJBCBOGOOGF
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CJPPGPOGFKM BNGNPMNBABC;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CJPPGPOGFKM JBJNDCGEIHP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CJPPGPOGFKM GKHNKCDHHFO;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static CJPPGPOGFKM DLLDFIIABNP;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x567D120", Offset = "0x567C320", VA = "0x18567D120")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HLDMCEIBGKG
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static CJPPGPOGFKM OMKGHJMNDGH;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5680460", Offset = "0x567F660", VA = "0x185680460")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct MIGCOLFJFJG
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static CJPPGPOGFKM IHBAEEIOKDH;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x568A320", Offset = "0x5689520", VA = "0x18568A320")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct ICENELAFNNI
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static CJPPGPOGFKM EGEEABJKNFF;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5680930", Offset = "0x567FB30", VA = "0x185680930")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct DECIKNACDJP
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static CJPPGPOGFKM BBCDGDIHCFA;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x567B510", Offset = "0x567A710", VA = "0x18567B510")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct CDCHCMEPMLF
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static CJPPGPOGFKM OBFNCNIJMOM;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x56773C0", Offset = "0x56765C0", VA = "0x1856773C0")]
				public static PlayerLoopSystem OPAOJCDKIMG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public enum OPKPPLIFGMJ : byte
			{
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct JICLOPPNKLP
			{
				[Cpp2IlInjected.Token(Token = "0x200001E")]
				[CompilerGenerated]
				private sealed class EOEOIAIOFJD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					public OPKPPLIFGMJ updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
					public EOEOIAIOFJD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x567C510", Offset = "0x567B710", VA = "0x18567C510")]
					internal void OMEEHDDMMGE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static KODDBGBLBCG<OPKPPLIFGMJ> KKGLMLDAPAP;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5683970", Offset = "0x5682B70", VA = "0x185683970")]
				public static PlayerLoopSystem OPAOJCDKIMG(OPKPPLIFGMJ ECAJPCFBGCA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct ELIFECIIBEM
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class HBHACADIMDH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public JPIIGCFJHJP.CCKLIKHPLOL key;

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
					public HBHACADIMDH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x567EAD0", Offset = "0x567DCD0", VA = "0x18567EAD0")]
					internal void IDELNDEMKEC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable JIEONGLGPCP;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x567C3B0", Offset = "0x567B5B0", VA = "0x18567C3B0")]
				public static PlayerLoopSystem IJJIBMKFOAO(JPIIGCFJHJP.CCKLIKHPLOL PPNIGBBPGOI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct KJICCJPFAKJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class BFOEHPCLMHM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public JPIIGCFJHJP.CCKLIKHPLOL key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
					public BFOEHPCLMHM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x5676F30", Offset = "0x5676130", VA = "0x185676F30")]
					internal void IDELNDEMKEC()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x5686BA0", Offset = "0x5685DA0", VA = "0x185686BA0")]
				public static PlayerLoopSystem IJJIBMKFOAO(JPIIGCFJHJP.CCKLIKHPLOL PPNIGBBPGOI)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class CAMIFIDKEEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public CAMIFIDKEEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x56772A0", Offset = "0x56764A0", VA = "0x1856772A0")]
			internal List<PlayerLoopSystem> KICMEBEIFOH(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DOMKCAMOKGG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IOPFIJBFLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5678D20", Offset = "0x5677F20", VA = "0x185678D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x56780E0", Offset = "0x56772E0", VA = "0x1856780E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5678D60", Offset = "0x5677F60", VA = "0x185678D60")]
		private static void LHDOIBEDILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5678120", Offset = "0x5677320", VA = "0x185678120")]
		private static void IELOHBGEPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x56789F0", Offset = "0x5677BF0", VA = "0x1856789F0")]
		private static void JHLLKJJKGBF(string JHMBIPNFNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x56778C0", Offset = "0x5676AC0", VA = "0x1856778C0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5677AF0", Offset = "0x5676CF0", VA = "0x185677AF0")]
		private static void EOIJHKPOMMJ(JPIIGCFJHJP.CCKLIKHPLOL PPNIGBBPGOI, ref PlayerLoopSystem EDDEINEBIPB, Type EKKGELCEFAC, Type CMKOPALAABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5677CC0", Offset = "0x5676EC0", VA = "0x185677CC0")]
		private static void GLIIDFNJDAH(ref PlayerLoopSystem EDDEINEBIPB, Type EKKGELCEFAC, Type CMKOPALAABP, EDBLNCAMHMB OBADODJCMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x567B3E0", Offset = "0x567A5E0", VA = "0x18567B3E0")]
		private static void MFLHLPKHKEE(ref PlayerLoopSystem EDDEINEBIPB, Type EKKGELCEFAC, Type CMKOPALAABP, PlayerLoopSystem? LGPECMEGECF, PlayerLoopSystem? AENKFFLKEOG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JPIIGCFJHJP
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum CCKLIKHPLOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AFHEIIHNNBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly CCKLIKHPLOL EAJIHLEAENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly JNDOEPOGICE OHHANOOCJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long DHGHOEGBHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private long MAIJHOKAENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long EENHLOOKABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int OHEHLBOKBFB;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5675FA0", Offset = "0x56751A0", VA = "0x185675FA0")]
		public AFHEIIHNNBD(CCKLIKHPLOL LNFHCOGPELM, int POEKKGHGIIH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5675CD0", Offset = "0x5674ED0", VA = "0x185675CD0")]
		public void CCEKPMKMMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5675D40", Offset = "0x5674F40", VA = "0x185675D40")]
		public void DDNELMEDJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5675DA0", Offset = "0x5674FA0", VA = "0x185675DA0")]
		public void KHENOGGDNBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static CCKLIKHPLOL[] CONJNMPPCOI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static AFHEIIHNNBD[] JGNJLDKCJMC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x56843E0", Offset = "0x56835E0", VA = "0x1856843E0")]
	public static AFHEIIHNNBD IIMJFJNLLEE(CCKLIKHPLOL PPNIGBBPGOI, int POEKKGHGIIH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x56845C0", Offset = "0x56837C0", VA = "0x1856845C0")]
	public static AFHEIIHNNBD MODPAGCMOCG(CCKLIKHPLOL PPNIGBBPGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5684650", Offset = "0x5683850", VA = "0x185684650")]
	public static void PCDOPAKICFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HJJOFGHKKIM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private interface JDPPHPDCJOO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IGEHJICCCDD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HEEDEOJNDNP();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private abstract class JAKEHPPMEBF<TPromise, TMainThreadPromise> : JDPPHPDCJOO where TPromise : OOPPNGPPPLE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly TPromise DHIBJIMMMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		protected readonly TMainThreadPromise GJMEBHHAAEH;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise NHHAIOMMNGE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x34D9700", Offset = "0x34D8900", VA = "0x1834D9700")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IGEHJICCCDD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x34D9680", Offset = "0x34D8880", VA = "0x1834D9680", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D46320", Offset = "0x2D45520", VA = "0x182D46320")]
		protected JAKEHPPMEBF(TPromise DHIBJIMMMGL, TMainThreadPromise ICILDJKGEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x34D96D0", Offset = "0x34D88D0", VA = "0x1834D96D0", Slot = "5")]
		public void HEEDEOJNDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HABDLBGAFMF(TPromise DHIBJIMMMGL);
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class FFKDFPFFCML<T> : JAKEHPPMEBF<NHJDNADPIAN<T>, JFMAKJPJKJA<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C46550", Offset = "0x4C45750", VA = "0x184C46550")]
		public FFKDFPFFCML(NHJDNADPIAN<T> DHIBJIMMMGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C46320", Offset = "0x4C45520", VA = "0x184C46320", Slot = "6")]
		protected override void HABDLBGAFMF(NHJDNADPIAN<T> DHIBJIMMMGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4C46520", Offset = "0x4C45720", VA = "0x184C46520")]
		[CompilerGenerated]
		private void IDNNDEKEHBD(T GAFKIBJKPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1917AE0", Offset = "0x1916CE0", VA = "0x181917AE0")]
		[CompilerGenerated]
		private void OHCGHIOAAHP(string KLEKJFJOCHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class AJBPDEKEJHE : JDPPHPDCJOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Action JFFMHPNGJBK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IGEHJICCCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
		public AJBPDEKEJHE(Action JFFMHPNGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x15BB090", Offset = "0x15BA290", VA = "0x1815BB090", Slot = "5")]
		public void HEEDEOJNDNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<JDPPHPDCJOO> OKJOBJCKODF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x286E300", Offset = "0x286D500", VA = "0x18286E300")]
	public static NHJDNADPIAN<T> JNMAHAPKFCJ<T>(this NHJDNADPIAN<T> DHIBJIMMMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x567FE50", Offset = "0x567F050", VA = "0x18567FE50")]
	public static void JNMAHAPKFCJ(Action JFFMHPNGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x286E240", Offset = "0x286D440", VA = "0x18286E240")]
	private static NHJDNADPIAN<T> FDGCECDHKPA<T>(NHJDNADPIAN<T> DHIBJIMMMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x56801E0", Offset = "0x567F3E0", VA = "0x1856801E0")]
	private static void NBMKDMAKKGH(JDPPHPDCJOO DDONLLIPGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x567FEE0", Offset = "0x567F0E0", VA = "0x18567FEE0")]
	private static void KMBIFHBHCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x567FD50", Offset = "0x567EF50", VA = "0x18567FD50")]
	private static void JBIJKEINBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x567FC80", Offset = "0x567EE80", VA = "0x18567FC80")]
	private static void FDGNEIDLNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class MAMEFAHJPIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private struct IMDKKKAIMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> EJFDMLOMDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string BHNAPHDEPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode OOEIEGHCOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool AEFHNDBCMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56826F0", Offset = "0x56818F0", VA = "0x1856826F0")]
		public IMDKKKAIMEI(TaskCompletionSource<Scene> FIMLJLMBECG, string BHNAPHDEPMN, LoadSceneMode OOEIEGHCOGO, bool AEFHNDBCMIG, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class GDOKDINGCDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private FDMIABHIEGI<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private JJCILEKGKNO <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IMDKKKAIMEI <queuedSceneLoad>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GDOKDINGCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x567DC00", Offset = "0x567CE00", VA = "0x18567DC00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NBLJCDHMDOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NBLJCDHMDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x568D880", Offset = "0x568CA80", VA = "0x18568D880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OIAMFDKJINI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IMDKKKAIMEI <dequeued>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Scene <scene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private Scene <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public OIAMFDKJINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x568E5F0", Offset = "0x568D7F0", VA = "0x18568E5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class FODHNPFNIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public JFMAKJPJKJA<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public FODHNPFNIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x567DBA0", Offset = "0x567CDA0", VA = "0x18567DBA0")]
		internal void JMKKHOIMNNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JEPDPHHELIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private FODHNPFNIJO <>8__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool <shouldLoadEmptyScene>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Scene <emptyScene>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Scene <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JEPDPHHELIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5682A90", Offset = "0x5681C90", VA = "0x185682A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class JGBDGLFEOKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private AsyncOperationHandle<SceneInstance> <handle>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private SceneInstance <instance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public JGBDGLFEOKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5683480", Offset = "0x5682680", VA = "0x185683480", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class HCHEIKPLJDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public FDMIABHIEGI<string>.JOOBNAKNCND stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private FDMIABHIEGI<string>.JOOBNAKNCND <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public HCHEIKPLJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x567ED40", Offset = "0x567DF40", VA = "0x18567ED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class BFDCJPDDKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public BFDCJPDDKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5676F00", Offset = "0x5676100", VA = "0x185676F00")]
		internal bool PAADHNFIKIA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class HDHFKNOLDBH : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public DAFGDOMLDFF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private BFDCJPDDKOO <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public HDHFKNOLDBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x567FAE0", Offset = "0x567ECE0", VA = "0x18567FAE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x567F720", Offset = "0x567E920", VA = "0x18567F720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x567F6D0", Offset = "0x567E8D0", VA = "0x18567F6D0")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x567FAA0", Offset = "0x567ECA0", VA = "0x18567FAA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class CKINLNDEHLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public JFMAKJPJKJA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public CKINLNDEHLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5677840", Offset = "0x5676A40", VA = "0x185677840")]
		internal bool PEJHEIIOEBI(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x56775D0", Offset = "0x56767D0", VA = "0x1856775D0")]
		internal void MGICHKPMOFJ(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class OKLKHIKGBMN : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public JFMAKJPJKJA<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private CKINLNDEHLC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public OKLKHIKGBMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x568EBD0", Offset = "0x568DDD0", VA = "0x18568EBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x568F400", Offset = "0x568E600", VA = "0x18568F400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ICollection<string> INFBJMFGPMN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static OOPPNGPPPLE IEMKAOFNOHN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation FKFNLFLNDBG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static OOPPNGPPPLE OMPDDIFFHJK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string JNBEGEHGBPG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority EIKEKPFMAFM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task CNHMOGPOLAG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static List<SceneInstance> DBPINCDJPAJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<IMDKKKAIMEI> DJGOEIOJNHJ;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task LOKEIMNKLNB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool ONGLLCKGCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5689250", Offset = "0x5688450", VA = "0x185689250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool BGILNPGGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x56899E0", Offset = "0x5688BE0", VA = "0x1856899E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool NDJGGANPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5689F80", Offset = "0x5689180", VA = "0x185689F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool OEGMMEDJLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5689BF0", Offset = "0x5688DF0", VA = "0x185689BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GLPIJMJLHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5688BC0", Offset = "0x5687DC0", VA = "0x185688BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5688A20", Offset = "0x5687C20", VA = "0x185688A20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5688CC0", Offset = "0x5687EC0", VA = "0x185688CC0")]
	[GCPIAKNECPG(DFCDCLLOMEG.EnteredEditModeNextFrame, 0)]
	private static void FJLLLLBAAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5689830", Offset = "0x5688A30", VA = "0x185689830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GDOKDINGCDP))]
	public static Task<Scene> JIJKHEABPEC(string BHNAPHDEPMN, LoadSceneMode OOEIEGHCOGO = LoadSceneMode.Single, bool AEFHNDBCMIG = false, [Optional] FDMIABHIEGI<string>.JOOBNAKNCND ELGPLHIFLMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x56894D0", Offset = "0x56886D0", VA = "0x1856894D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NBLJCDHMDOO))]
	private static Task IHHIDDGEPPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5688830", Offset = "0x5687A30", VA = "0x185688830")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OIAMFDKJINI))]
	private static Task BLFIDENOGBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5689DD0", Offset = "0x5688FD0", VA = "0x185689DD0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEPDPHHELIB))]
	private static Task<Scene> PCIGONPDAOD(string BHNAPHDEPMN, LoadSceneMode OOEIEGHCOGO, bool AEFHNDBCMIG, FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5688930", Offset = "0x5687B30", VA = "0x185688930")]
	private static void CENBAJPLHBD(SceneInstance LGFCIPNNCDA, LoadSceneMode OOEIEGHCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5688B20", Offset = "0x5687D20", VA = "0x185688B20")]
	private static void FDLINEPEPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x568A040", Offset = "0x5689240", VA = "0x18568A040")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGBDGLFEOKJ))]
	private static Task<Scene> PMBJMNAPFAB(string BHNAPHDEPMN, LoadSceneMode OOEIEGHCOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5689740", Offset = "0x5688940", VA = "0x185689740")]
	private static bool IPKELKDHIOE(string BHNAPHDEPMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5689AA0", Offset = "0x5688CA0", VA = "0x185689AA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HCHEIKPLJDN))]
	private static Task<Scene> LNMMIAAAPCG(FDMIABHIEGI<string>.JOOBNAKNCND NGADIHKHGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5688D90", Offset = "0x5687F90", VA = "0x185688D90")]
	public static NHJDNADPIAN<Scene> FLBLOGEFINE(string BHNAPHDEPMN, LoadSceneMode OOEIEGHCOGO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5688F80", Offset = "0x5688180", VA = "0x185688F80")]
	public static OOPPNGPPPLE GMHNNAOGLJE(string BHNAPHDEPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5689CA0", Offset = "0x5688EA0", VA = "0x185689CA0")]
	[IteratorStateMachine(typeof(HDHFKNOLDBH))]
	private static IEnumerator<HGAIOCFFOOA> OHILHHMABKL(string BHNAPHDEPMN, DAFGDOMLDFF FIJAFMICGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5689D30", Offset = "0x5688F30", VA = "0x185689D30")]
	[IteratorStateMachine(typeof(OKLKHIKGBMN))]
	private static IEnumerator<HGAIOCFFOOA> OLHACHOEDPN(string BHNAPHDEPMN, LoadSceneMode OOEIEGHCOGO, JFMAKJPJKJA<Scene> FIJAFMICGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x56895D0", Offset = "0x56887D0", VA = "0x1856895D0")]
	public static bool INCAAMAOICN(out string FGBEPLDGOMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JNDOEPOGICE : DILJNBLPCFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int AHFAIHLNINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Queue<double> BACEGJCHKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private double PAOMAJAMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private double CALOKHBDGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private double KAEOHJIIEPE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double EPOHCCELGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5683CF0", Offset = "0x5682EF0", VA = "0x185683CF0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HHHGPOFJACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x125EA80", Offset = "0x125DC80", VA = "0x18125EA80", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double FHJGJPBACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x125EAD0", Offset = "0x125DCD0", VA = "0x18125EAD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5683D60", Offset = "0x5682F60", VA = "0x185683D60")]
	public JNDOEPOGICE(int JFENJAIDHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5683BC0", Offset = "0x5682DC0", VA = "0x185683BC0", Slot = "7")]
	public void INKGDMJOAMI(double HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5683B50", Offset = "0x5682D50", VA = "0x185683B50", Slot = "8")]
	public void BLKLFBLJHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class AHCHGMFBECJ : DILJNBLPCFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private long IGDJHHPIJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double AGJHLIHJMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double GMAHEPCLAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private double KAAHNKOFNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double MFCGGOMBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double PAOMAJAMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double CALOKHBDGFN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D44A0", Offset = "0x8D36A0", VA = "0x1808D44A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double HHHGPOFJACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x56760E0", Offset = "0x56752E0", VA = "0x1856760E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double FHJGJPBACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1287A90", Offset = "0x1286C90", VA = "0x181287A90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double NCBKKJNDEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x56760F0", Offset = "0x56752F0", VA = "0x1856760F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double EPOHCCELGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x556C9E0", Offset = "0x556BBE0", VA = "0x18556C9E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5676100", Offset = "0x5675300", VA = "0x185676100", Slot = "7")]
	public virtual void INKGDMJOAMI(double HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x56760A0", Offset = "0x56752A0", VA = "0x1856760A0", Slot = "8")]
	public virtual void BLKLFBLJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5676230", Offset = "0x5675430", VA = "0x185676230")]
	public AHCHGMFBECJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EOMMDOOLFKO : AHCHGMFBECJ
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double MODOGFDEFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x125EF10", Offset = "0x125E110", VA = "0x18125EF10")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x125EA10", Offset = "0x125DC10", VA = "0x18125EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x567C5E0", Offset = "0x567B7E0", VA = "0x18567C5E0", Slot = "7")]
	public override void INKGDMJOAMI(double HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x567C5A0", Offset = "0x567B7A0", VA = "0x18567C5A0", Slot = "8")]
	public override void BLKLFBLJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5676230", Offset = "0x5675430", VA = "0x185676230")]
	public EOMMDOOLFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DILJNBLPCFH
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double EPOHCCELGIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double HHHGPOFJACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double FHJGJPBACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class OHKPHPJKHPL : LAKCKOGKCLI
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float PPLJONCIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x568E5D0", Offset = "0x568D7D0", VA = "0x18568E5D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float HGMDHOGALIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x568E5E0", Offset = "0x568D7E0", VA = "0x18568E5E0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double NANOOMHBJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x568E5B0", Offset = "0x568D7B0", VA = "0x18568E5B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x568E540", Offset = "0x568D740", VA = "0x18568E540")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	[Preserve]
	internal OHKPHPJKHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class IKGLMLDAIPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BPFFBEGKACE : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public IKGLMLDAIPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public BPFFBEGKACE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x56771C0", Offset = "0x56763C0", VA = "0x1856771C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5677260", Offset = "0x5676460", VA = "0x185677260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private HDFNBFCGAOH HFDCLLHPOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private MonoBehaviour PKHPCABJFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Action LLAEABMBHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Action<float> CFCJINFBMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float OHAENGGCBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private bool GMCAIEAGGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly HOBPEPKDKNI CHAOLJOCGCA;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5681860", Offset = "0x5680A60", VA = "0x185681860")]
	public IKGLMLDAIPH(MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5681A60", Offset = "0x5680C60", VA = "0x185681A60")]
	public IKGLMLDAIPH(MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5681CA0", Offset = "0x5680EA0", VA = "0x185681CA0")]
	public IKGLMLDAIPH(MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x44F45E0", Offset = "0x44F37E0", VA = "0x1844F45E0")]
	private IKGLMLDAIPH(HOBPEPKDKNI CHAOLJOCGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5680DE0", Offset = "0x567FFE0", VA = "0x185680DE0")]
	internal static IKGLMLDAIPH CFBHIBBOFLK(MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x56816F0", Offset = "0x56808F0", VA = "0x1856816F0")]
	private void OMMLMLLBLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5680C30", Offset = "0x567FE30", VA = "0x185680C30")]
	private void ACPOGDBEPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5681390", Offset = "0x5680590", VA = "0x185681390")]
	private void ILHMHPFHLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5680F00", Offset = "0x5680100", VA = "0x185680F00")]
	private void CNODMHENCCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5681130", Offset = "0x5680330", VA = "0x185681130")]
	private void FBDOGNMCKAB(string KLEKJFJOCHO, Action PHKLJOGHFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5681300", Offset = "0x5680500", VA = "0x185681300")]
	[IteratorStateMachine(typeof(BPFFBEGKACE))]
	private IEnumerator<HGAIOCFFOOA> HJPHOFNBLIN(Action PHKLJOGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x56810D0", Offset = "0x56802D0", VA = "0x1856810D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5681540", Offset = "0x5680740", VA = "0x185681540")]
	[CompilerGenerated]
	private void KCOKACOAHID(string DFGDJPCDEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x56815D0", Offset = "0x56807D0", VA = "0x1856815D0")]
	[CompilerGenerated]
	private void LADIKOICPDG(string DFGDJPCDEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5681270", Offset = "0x5680470", VA = "0x185681270")]
	[CompilerGenerated]
	private void GENCAJBMJLI(string DFGDJPCDEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5681660", Offset = "0x5680860", VA = "0x185681660")]
	[CompilerGenerated]
	private void LMFHPLIGKGH(string DFGDJPCDEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BurstCompile]
internal struct JPEHNAECCOK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ReadOnly]
	public float ANBNAKAALJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[ReadOnly]
	public int LFNDGEIHBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeArray<int> MHMJHDDNAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> NONILNDJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> FAOANCICEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	public NativeArray<HPGEMCIAPDN> IKPOGLJJMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	public NativeArray<float> LAOCGJMEMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[WriteOnly]
	public NativeArray<int> KLMIOCGKAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[WriteOnly]
	public NativeArray<int> FPJEDPCOHFJ;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5684330", Offset = "0x5683530", VA = "0x185684330")]
	public static JPEHNAECCOK LNIGJBIDADO(int NPELCFIMILM, float JKBNDGJADPH, NativeArray<HPGEMCIAPDN> LONNEIMPDJN, NativeArray<float> GJIBLLGJDGA, NativeArray<int> OKGLALHMLGP, NativeArray<int> MEMAPPHDPMJ, NativeArray<int> KJCODLAEMMG, NativeArray<int> NONILNDJGDF, NativeArray<int> FAOANCICEIK)
	{
		return default(JPEHNAECCOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5683F30", Offset = "0x5683130", VA = "0x185683F30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x56840E0", Offset = "0x56832E0", VA = "0x1856840E0")]
	private bool KHEONGFINHP(int MMFFFGBLCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5683F00", Offset = "0x5683100", VA = "0x185683F00")]
	private void EKBHJBGOEBC(NativeArray<int> JALEKMIAALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5683EA0", Offset = "0x56830A0", VA = "0x185683EA0")]
	private int EGLHLCIOKHG(int KJFPHEPHBCI, int NJNHKOJHAIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5684010", Offset = "0x5683210", VA = "0x185684010")]
	private void JGPCMJHOAAA(NativeArray<int> JALEKMIAALJ, int HFMINFFOABI, int KDPBEOJMKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5684120", Offset = "0x5683320", VA = "0x185684120")]
	private void LAEOOOOMNMH(NativeArray<int> JALEKMIAALJ, int LOHANFILCCD, int PDELNNGGEHA, int HNDIJBLHGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class PNFCICLLFBI : ONKDFGABFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly float JCBDLKHKGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int HMPGAAMMGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly float DGPOMJNPHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float[] FCLFENPJNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int GENGCNFMJGB;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x568FDA0", Offset = "0x568EFA0", VA = "0x18568FDA0")]
	public PNFCICLLFBI(Behaviour APPLJOFCBIB, float FLKKMOJKLNA, int HMPGAAMMGKC, [Optional] Action CHNJIGLCIHO, float DGPOMJNPHHC = 0f, [Optional] HOBPEPKDKNI CHAOLJOCGCA, [Optional] LAKCKOGKCLI NLDIHCDEEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "9")]
	protected override bool MFGOIBLBGOP(Action JFFMHPNGJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x568FB70", Offset = "0x568ED70", VA = "0x18568FB70", Slot = "10")]
	protected override bool NAMFGDNGBJB(Action JFFMHPNGJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x568FAE0", Offset = "0x568ECE0", VA = "0x18568FAE0")]
	private void JNIDNPFNONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class LGMKOMKGHFA : HOBPEPKDKNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly OALJEHGGMAD IAOLLPNAOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly LAKCKOGKCLI NLDIHCDEEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly PBBMMENMONO PCPHGCCHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private KCCKGIBPGPB[] NCMMJDOOPCG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static HOBPEPKDKNI EBEPLDELFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5688170", Offset = "0x5687370", VA = "0x185688170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool GAIAFJLIGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GMGILNDCDCO.EKJHGBKIKMC HNBMJDIMPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(GMGILNDCDCO.EKJHGBKIKMC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x841E20", Offset = "0x841020", VA = "0x180841E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LAKCKOGKCLI HHPEMCMKDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5687E70", Offset = "0x5687070", VA = "0x185687E70")]
	public static HDFNBFCGAOH IABFGKHCMLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5688440", Offset = "0x5687640", VA = "0x185688440")]
	[Preserve]
	protected LGMKOMKGHFA([IDNKOMINBGM(null)] OALJEHGGMAD IAOLLPNAOOO, [IDNKOMINBGM(null)] LAKCKOGKCLI NLDIHCDEEIL, [IDNKOMINBGM(null)] PBBMMENMONO PCPHGCCHMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5688430", Offset = "0x5687630", VA = "0x185688430", Slot = "6")]
	public HDFNBFCGAOH ONDGBMOLAPF(IEnumerator<HGAIOCFFOOA> BNDIIPCADDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5688200", Offset = "0x5687400", VA = "0x185688200", Slot = "7")]
	public HDFNBFCGAOH ONDGBMOLAPF(Behaviour APPLJOFCBIB, IEnumerator<HGAIOCFFOOA> BNDIIPCADDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract HDFNBFCGAOH OGKEPMKCPLI(LBNBHKKHGCG APPLJOFCBIB, IEnumerator<HGAIOCFFOOA> BNDIIPCADDP);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56876D0", Offset = "0x56868D0", VA = "0x1856876D0", Slot = "13")]
	public virtual void BLKLFBLJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5687670", Offset = "0x5686870", VA = "0x185687670", Slot = "9")]
	public void ACNBOCNEOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x26FF720", Offset = "0x26FE920", VA = "0x1826FF720", Slot = "14")]
	protected virtual void BOOFGHHIEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x56881C0", Offset = "0x56873C0", VA = "0x1856881C0")]
	private void OJACMIEFLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5688110", Offset = "0x5687310", VA = "0x185688110")]
	private void IOLFIADIDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5688130", Offset = "0x5687330", VA = "0x185688130")]
	private void NBOBGDMCJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5688150", Offset = "0x5687350", VA = "0x185688150")]
	private void ODAPINLBCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56881E0", Offset = "0x56873E0", VA = "0x1856881E0")]
	private void OMKGHJMNDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5687F00", Offset = "0x5687100", VA = "0x185687F00")]
	private void IHBAEEIOKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5687F20", Offset = "0x5687120", VA = "0x185687F20")]
	private void IIAMOKLOENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5687C30", Offset = "0x5686E30", VA = "0x185687C30", Slot = "15")]
	public virtual void FGBEABMNGGK(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5687F40", Offset = "0x5687140", VA = "0x185687F40")]
	private void IMIBOBOKBOO(KCCKGIBPGPB ALPFEJOMLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1037580", Offset = "0x1036780", VA = "0x181037580")]
	private KCCKGIBPGPB KLBOEKPHIGF(GMGILNDCDCO.EKJHGBKIKMC JAACLLLIGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract PNJLIJHKELO OPPKLHCKHMF(IEnumerator<HGAIOCFFOOA> BNDIIPCADDP, Behaviour PKHPCABJFOL, JPBOFCAILKM PEODACGAMOP);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract KCCKGIBPGPB NPIDDMOJNBF(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x56878B0", Offset = "0x5686AB0", VA = "0x1856878B0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DICPBIPLPDB : LGMKOMKGHFA, HOBPEPKDKNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MMPMCPDLGLB[] JEIGAOEHJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LFHMANDKBCF JPMOGFHMIGJ;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x567B720", Offset = "0x567A920", VA = "0x18567B720")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x567C220", Offset = "0x567B420", VA = "0x18567C220")]
	[Preserve]
	public DICPBIPLPDB([IDNKOMINBGM(null)] OALJEHGGMAD IAOLLPNAOOO, [IDNKOMINBGM(null)] LAKCKOGKCLI NLDIHCDEEIL, [IDNKOMINBGM(null)] PBBMMENMONO PCPHGCCHMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x567BF20", Offset = "0x567B120", VA = "0x18567BF20", Slot = "12")]
	public override HDFNBFCGAOH OGKEPMKCPLI(LBNBHKKHGCG APPLJOFCBIB, IEnumerator<HGAIOCFFOOA> BNDIIPCADDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x567B790", Offset = "0x567A990", VA = "0x18567B790", Slot = "13")]
	public override void BLKLFBLJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x567BBC0", Offset = "0x567ADC0", VA = "0x18567BBC0", Slot = "15")]
	public override void FGBEABMNGGK(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x567BA70", Offset = "0x567AC70", VA = "0x18567BA70", Slot = "14")]
	protected override void BOOFGHHIEIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x567C1E0", Offset = "0x567B3E0", VA = "0x18567C1E0")]
	private MMPMCPDLGLB PFJIGMMKOFP(GMGILNDCDCO.EKJHGBKIKMC JAACLLLIGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x567C070", Offset = "0x567B270", VA = "0x18567C070", Slot = "16")]
	internal override PNJLIJHKELO OPPKLHCKHMF(IEnumerator<HGAIOCFFOOA> BNDIIPCADDP, Behaviour APPLJOFCBIB, JPBOFCAILKM IPHCMLMIPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x567BEB0", Offset = "0x567B0B0", VA = "0x18567BEB0", Slot = "17")]
	internal override KCCKGIBPGPB NPIDDMOJNBF(GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x567BD90", Offset = "0x567AF90", VA = "0x18567BD90")]
	private void MHNDLLEPCEK(MMPMCPDLGLB ALPFEJOMLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x567BB50", Offset = "0x567AD50", VA = "0x18567BB50", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NLLOFBLHDDL
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class IDIFHFOGGMK : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public GMGILNDCDCO.EKJHGBKIKMC queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public IDIFHFOGGMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5680B40", Offset = "0x567FD40", VA = "0x185680B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5680BF0", Offset = "0x567FDF0", VA = "0x185680BF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x568DD10", Offset = "0x568CF10", VA = "0x18568DD10")]
	[IteratorStateMachine(typeof(IDIFHFOGGMK))]
	private static IEnumerator<HGAIOCFFOOA> FMGOCBFKMKA(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, Func<bool> FDGKKJMBOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x568DD90", Offset = "0x568CF90", VA = "0x18568DD90")]
	public static HDFNBFCGAOH JMEPOBGPEKD(this MonoBehaviour PKHPCABJFOL, Func<bool> FDGKKJMBOEA, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH = GMGILNDCDCO.EKJHGBKIKMC.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class PNJLIJHKELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly JPBOFCAILKM IPHCMLMIPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly OPIADAJNKLB APPLJOFCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool GLMJLNCICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private string PCKMHBLNCII;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<HGAIOCFFOOA> CFKNOPJOIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HGAIOCFFOOA EIBIEENPDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JMKPCEIPJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5690460", Offset = "0x568F660", VA = "0x185690460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EHCHAKBBEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x980020", Offset = "0x97F220", VA = "0x180980020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x980010", Offset = "0x97F210", VA = "0x180980010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x568FFD0", Offset = "0x568F1D0", VA = "0x18568FFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float BCACOHINLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xB9E450", Offset = "0xB9D650", VA = "0x180B9E450")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xB9E640", Offset = "0xB9D840", VA = "0x180B9E640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x56905C0", Offset = "0x568F7C0", VA = "0x1856905C0")]
	public PNJLIJHKELO(IEnumerator<HGAIOCFFOOA> CGDGEFKFGKE, OPIADAJNKLB APPLJOFCBIB, JPBOFCAILKM IPHCMLMIPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x56901D0", Offset = "0x568F3D0", VA = "0x1856901D0")]
	public HGAIOCFFOOA NAKMJBNHPHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x568FF50", Offset = "0x568F150", VA = "0x18568FF50")]
	public bool CALIEDFPKIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5690150", Offset = "0x568F350", VA = "0x185690150")]
	public void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x56904E0", Offset = "0x568F6E0", VA = "0x1856904E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x162D530", Offset = "0x162C730", VA = "0x18162D530")]
	[CompilerGenerated]
	private void GNCDEAKPHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class LAGBMGMEBEF
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NAOFGFKGCDI : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public HBGFJGEIKEE schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public GMGILNDCDCO.EKJHGBKIKMC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public NAOFGFKGCDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x568D7A0", Offset = "0x568C9A0", VA = "0x18568D7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x568D840", Offset = "0x568CA40", VA = "0x18568D840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5687210", Offset = "0x5686410", VA = "0x185687210")]
	public static HDFNBFCGAOH OMMLMLLBLMA(float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5687310", Offset = "0x5686510", VA = "0x185687310")]
	public static HDFNBFCGAOH OMMLMLLBLMA(MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56870F0", Offset = "0x56862F0", VA = "0x1856870F0")]
	public static HDFNBFCGAOH MHOJJBLLKLG(MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5686E20", Offset = "0x5686020", VA = "0x185686E20")]
	public static HDFNBFCGAOH EENDCIIMOMI(LBNBHKKHGCG APPLJOFCBIB, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5686F90", Offset = "0x5686190", VA = "0x185686F90")]
	private static IEnumerator<HGAIOCFFOOA> IEDCMMBALHM(LAKCKOGKCLI NLDIHCDEEIL, float GMJNHCPHGNB, GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5686F30", Offset = "0x5686130", VA = "0x185686F30")]
	private static IEnumerator<HGAIOCFFOOA> EFLIMKKHOHP(LAKCKOGKCLI NLDIHCDEEIL, float GMJNHCPHGNB, GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5687040", Offset = "0x5686240", VA = "0x185687040")]
	[IteratorStateMachine(typeof(NAOFGFKGCDI))]
	private static IEnumerator<HGAIOCFFOOA> LMMHHKLPGOM(HBGFJGEIKEE ACFNGKCANGB, float GMJNHCPHGNB, GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action<float> LLAEABMBHMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface MNICDPEMOPD
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool HGIKHAHKFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action KPGPCLOEKKP;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJGFHMIKOBJ(bool PPHFAHHOGGC = false);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BJGFHMIKOBJ(Action JFFMHPNGJBK, bool PPHFAHHOGGC = false);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class LBBHLABNGJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly LBBHLABNGJL GKMFIPLKNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Action FHKJMOKBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool PFALPCMNDEH;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1871FF0", Offset = "0x18711F0", VA = "0x181871FF0")]
	public LBBHLABNGJL(Action FHKJMOKBLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5687550", Offset = "0x5686750", VA = "0x185687550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface JAILNLICPLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable ANODACNDLDI(UnityEngine.Object APPLJOFCBIB, Action<T> PKHDHAPHLMC);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BGHGHNHGLNH<T> : JAILNLICPLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DNFLMHMLDKL<T> : BGHGHNHGLNH<T>, JAILNLICPLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BGDGEIBJCFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public DNFLMHMLDKL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public CKOLBNLDHJH<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BGDGEIBJCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x33E9F20", Offset = "0x33E9120", VA = "0x1833E9F20")]
		internal void FBFKKMCIMMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject HBNICLKIBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<CKOLBNLDHJH<UnityEngine.Object, Action<T>>> NEPFOBFPIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T KENHNLBFBND;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xCADD80", Offset = "0xCACF80", VA = "0x180CADD80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x37878A0", Offset = "0x3786AA0", VA = "0x1837878A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3787900", Offset = "0x3786B00", VA = "0x183787900")]
	private static bool MPKGCEMGKOL(T KCJELMMMDCA, T NMKMEIDKGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3787A70", Offset = "0x3786C70", VA = "0x183787A70")]
	public DNFLMHMLDKL(T JHLMCHMMHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x37876B0", Offset = "0x37868B0", VA = "0x1837876B0", Slot = "6")]
	public IDisposable ANODACNDLDI(UnityEngine.Object APPLJOFCBIB, Action<T> PKHDHAPHLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x37871D0", Offset = "0x37863D0", VA = "0x1837871D0")]
	private void AJGJJEMKCLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal interface LFHMANDKBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KABDIPGBLAM(string PCKMHBLNCII);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDOMNDGKFMI();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class CFICLDDACDC : LFHMANDKBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
	public void KABDIPGBLAM(string PCKMHBLNCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
	public void JDOMNDGKFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CFICLDDACDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class GOCHCCAOBPA : ONKDFGABFDD
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EIAGEHOGIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public GOCHCCAOBPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EIAGEHOGIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x567C380", Offset = "0x567B580", VA = "0x18567C380")]
		internal void MJFKICHLFPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LGOIBONABDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public GOCHCCAOBPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LGOIBONABDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x567C380", Offset = "0x567B580", VA = "0x18567C380")]
		internal void NBOJOFLJJLA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float POBFIFNOIBA;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x567E9C0", Offset = "0x567DBC0", VA = "0x18567E9C0")]
	public GOCHCCAOBPA(Behaviour APPLJOFCBIB, float POBFIFNOIBA, [Optional] Action CHNJIGLCIHO, [Optional] HOBPEPKDKNI CHAOLJOCGCA, [Optional] LAKCKOGKCLI NLDIHCDEEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x567E7C0", Offset = "0x567D9C0", VA = "0x18567E7C0", Slot = "9")]
	protected override bool MFGOIBLBGOP(Action JFFMHPNGJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x567E8C0", Offset = "0x567DAC0", VA = "0x18567E8C0", Slot = "10")]
	protected override bool NAMFGDNGBJB(Action JFFMHPNGJBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class FKOKMBGBLJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class KMCFILLBJMM : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public FKOKMBGBLJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public KMCFILLBJMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5686D00", Offset = "0x5685F00", VA = "0x185686D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5686DA0", Offset = "0x5685FA0", VA = "0x185686DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private HDFNBFCGAOH HFDCLLHPOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private LBNBHKKHGCG APPLJOFCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private Action<float> CFCJINFBMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float OHAENGGCBCH;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x567D9C0", Offset = "0x567CBC0", VA = "0x18567D9C0")]
	public FKOKMBGBLJL(LBNBHKKHGCG APPLJOFCBIB, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x567D810", Offset = "0x567CA10", VA = "0x18567D810")]
	private void ILHMHPFHLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x567D600", Offset = "0x567C800", VA = "0x18567D600")]
	private void FBDOGNMCKAB(string KLEKJFJOCHO, Action PHKLJOGHFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x567D780", Offset = "0x567C980", VA = "0x18567D780")]
	[IteratorStateMachine(typeof(KMCFILLBJMM))]
	private IEnumerator<HGAIOCFFOOA> HJPHOFNBLIN(Action PHKLJOGHFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x567D3E0", Offset = "0x567C5E0", VA = "0x18567D3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x567D440", Offset = "0x567C640", VA = "0x18567D440")]
	[CompilerGenerated]
	private void EBLENDDIKJC(string DFGDJPCDEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class MMPMCPDLGLB
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct IMACOEMLLEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public MPHCLNGMKMC LCBEJOOEBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public LBNBHKKHGCG LPJLFJOGNIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public JPBOFCAILKM AIJCKJJIIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<HGAIOCFFOOA> CFKNOPJOIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HGAIOCFFOOA EIBIEENPDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public HPGEMCIAPDN OFDPABPBEDI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct AKMLICGAOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public GMGILNDCDCO.EKJHGBKIKMC LMLMNPEIEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<IMACOEMLLEL> LABBGFBMHOK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ILPOGMJOKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public JPBOFCAILKM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public MMPMCPDLGLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public LBNBHKKHGCG context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public MPHCLNGMKMC routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public HPGEMCIAPDN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public HGAIOCFFOOA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<HGAIOCFFOOA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ILPOGMJOKCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5681EF0", Offset = "0x56810F0", VA = "0x185681EF0")]
		internal void LAGKLKJCCMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NKMPICNHEAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public MPHCLNGMKMC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public MMPMCPDLGLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public NKMPICNHEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x568DCD0", Offset = "0x568CED0", VA = "0x18568DCD0")]
		internal void AFJIMADOEKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GNGAJBBMBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public MPHCLNGMKMC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public MMPMCPDLGLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public GNGAJBBMBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x567E780", Offset = "0x567D980", VA = "0x18567E780")]
		internal void LBFGBFHMPHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class LLPHAICMKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MPHCLNGMKMC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public MMPMCPDLGLB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LLPHAICMKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x56887F0", Offset = "0x56879F0", VA = "0x1856887F0")]
		internal void BHEKABEOEPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const HPGEMCIAPDN FNKOMJALMHN = HPGEMCIAPDN.Cancelled | HPGEMCIAPDN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] JDFMPBCGJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<HPGEMCIAPDN> NNIPKKAOKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> FIJACOEMDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> FPJEDPCOHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> EGLOPAEDCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> KLMIOCGKAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> LLKKMEPHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> MDPLCLCCHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private MPHCLNGMKMC[] GJLMDFPJNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JPBOFCAILKM[] FEFBGKBGFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private LBNBHKKHGCG[] FFLLENCIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<HGAIOCFFOOA>[] ODPACCHNANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private HGAIOCFFOOA[] BMAAPNFNHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int EMPEAGKEOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HBHBCIIAIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int HNFKAJOGDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float KDPCDGCJEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JPEHNAECCOK JPAONDJHHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle OMPPLFAKLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<MPHCLNGMKMC> ENPCCKFOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool AJDLEDIGOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> NLHPKPMKEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> LNMIPAOLIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool JDGNLABCACI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AKMLICGAOLO[] LPOKCJFKHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1483DB0", Offset = "0x1482FB0", VA = "0x181483DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x568CB50", Offset = "0x568BD50", VA = "0x18568CB50")]
	private static int PBKEMEFICBD(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x568CC50", Offset = "0x568BE50", VA = "0x18568CC50")]
	public MMPMCPDLGLB(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x568B7E0", Offset = "0x568A9E0", VA = "0x18568B7E0")]
	private void GBKKNBOPFHG(ref int FNJFBLPBOCI, int CPACIPCDNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x568AB70", Offset = "0x5689D70", VA = "0x18568AB70")]
	public void AGONAPLNABM(LBNBHKKHGCG APPLJOFCBIB, HGAIOCFFOOA EKMMMEPNMAN, IEnumerator<HGAIOCFFOOA> CGDGEFKFGKE, JPBOFCAILKM IPHCMLMIPHN, [Optional] MPHCLNGMKMC BOJBIMDPKLP, HPGEMCIAPDN BBLBGHKAFFM = HPGEMCIAPDN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x568C130", Offset = "0x568B330", VA = "0x18568C130")]
	public void MCHLPOMICIK(IEnumerable<IMACOEMLLEL> CCMJLCLBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x568C310", Offset = "0x568B510", VA = "0x18568C310")]
	private IMACOEMLLEL MCKCIJPIMDH(int IKAJMKMHIJD)
	{
		return default(IMACOEMLLEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x568B430", Offset = "0x568A630", VA = "0x18568B430")]
	private void DKPIOBPIFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2EE96B0", Offset = "0x2EE88B0", VA = "0x182EE96B0")]
	private static void NOOFCONFBLH<T>(int IKAJMKMHIJD, T[] BJCHDADMOFA, int KOIBEABAMCA, [Optional] T HPIKLJNAOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9690", Offset = "0x2EE8890", VA = "0x182EE9690")]
	private static void NOOFCONFBLH<T>(int IKAJMKMHIJD, NativeArray<T> BJCHDADMOFA, int KOIBEABAMCA, [Optional] T HPIKLJNAOIL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x568BD30", Offset = "0x568AF30", VA = "0x18568BD30")]
	private void JPFCINIGKIE(IEnumerable<IMACOEMLLEL> CCMJLCLBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x568CB80", Offset = "0x568BD80", VA = "0x18568CB80")]
	private void PLMBPBFJINM(IMACOEMLLEL PDPMEIDKAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x568A8B0", Offset = "0x5689AB0", VA = "0x18568A8B0")]
	private AKKGFODJKGL AGKMCJOKCKB(int JPKHKLIECKO)
	{
		return default(AKKGFODJKGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x568BA50", Offset = "0x568AC50", VA = "0x18568BA50")]
	public void HFDFAFJLDDN(float JKBNDGJADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x568C870", Offset = "0x568BA70", VA = "0x18568C870")]
	private void MHEDMELFHNA(Action KCJELMMMDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x568B9D0", Offset = "0x568ABD0", VA = "0x18568B9D0")]
	private void GJPKMPPEOCE(Action KCJELMMMDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x568ACF0", Offset = "0x5689EF0", VA = "0x18568ACF0")]
	public void BMGMJKNGDGN(float JKBNDGJADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x568BC30", Offset = "0x568AE30", VA = "0x18568BC30")]
	public void JKAFMKKGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x568C000", Offset = "0x568B200", VA = "0x18568C000")]
	public void LFPEABENKGO(MPHCLNGMKMC ACFNGKCANGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x568CA20", Offset = "0x568BC20", VA = "0x18568CA20")]
	public void OPIKCMHHOJJ(MPHCLNGMKMC ACFNGKCANGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x568C8F0", Offset = "0x568BAF0", VA = "0x18568C8F0")]
	public void OHIMAAFCNGC(MPHCLNGMKMC ACFNGKCANGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class KDBNHNHAELI : MNICDPEMOPD, IEnumerable<MNICDPEMOPD>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly List<MNICDPEMOPD> NGJIKPFGECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool CCLHLPHAHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Action CHNJIGLCIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool NONGOEDPHJA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HGIKHAHKFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5686780", Offset = "0x5685980", VA = "0x185686780", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KPGPCLOEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x56866E0", Offset = "0x56858E0", VA = "0x1856866E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x56868C0", Offset = "0x5685AC0", VA = "0x1856868C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5686B00", Offset = "0x5685D00", VA = "0x185686B00")]
	public KDBNHNHAELI([Optional] Action CHNJIGLCIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5686960", Offset = "0x5685B60", VA = "0x185686960")]
	public void PPMBLONPHPF(MNICDPEMOPD KPCJJFEGJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5686500", Offset = "0x5685700", VA = "0x185686500")]
	private void DOALCJMMIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5686200", Offset = "0x5685400", VA = "0x185686200", Slot = "7")]
	public bool BJGFHMIKOBJ(bool PPHFAHHOGGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5686220", Offset = "0x5685420", VA = "0x185686220", Slot = "8")]
	public bool BJGFHMIKOBJ(Action JFFMHPNGJBK, bool PPHFAHHOGGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5686660", Offset = "0x5685860", VA = "0x185686660", Slot = "9")]
	public IEnumerator<MNICDPEMOPD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5686A80", Offset = "0x5685C80", VA = "0x185686A80", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class ONKDFGABFDD : MNICDPEMOPD
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class GJLFCPJPHFP : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public ONKDFGABFDD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public GJLFCPJPHFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x567E480", Offset = "0x567D680", VA = "0x18567E480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x567E550", Offset = "0x567D750", VA = "0x18567E550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Behaviour APPLJOFCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Action CHNJIGLCIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private MMEJLKMBIHL GDILJCNHJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly HOBPEPKDKNI CHAOLJOCGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	protected readonly LAKCKOGKCLI NLDIHCDEEIL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HGIKHAHKFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x927230", Offset = "0x926430", VA = "0x180927230", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KPGPCLOEKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x568F7D0", Offset = "0x568E9D0", VA = "0x18568F7D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x568F8F0", Offset = "0x568EAF0", VA = "0x18568F8F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x568F990", Offset = "0x568EB90", VA = "0x18568F990")]
	protected ONKDFGABFDD(Behaviour APPLJOFCBIB, [Optional] Action CHNJIGLCIHO, [Optional] HOBPEPKDKNI CHAOLJOCGCA, [Optional] LAKCKOGKCLI NLDIHCDEEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x568F440", Offset = "0x568E640", VA = "0x18568F440", Slot = "7")]
	public bool BJGFHMIKOBJ(bool PPHFAHHOGGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x568F4A0", Offset = "0x568E6A0", VA = "0x18568F4A0", Slot = "8")]
	public bool BJGFHMIKOBJ(Action JFFMHPNGJBK, bool PPHFAHHOGGC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MFGOIBLBGOP(Action JFFMHPNGJBK);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NAMFGDNGBJB(Action JFFMHPNGJBK);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x568F4F0", Offset = "0x568E6F0", VA = "0x18568F4F0")]
	protected void CMHPBNPOINL(Action JFFMHPNGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x568F590", Offset = "0x568E790", VA = "0x18568F590")]
	protected OOPPNGPPPLE EJEADGPPFHC(float DDFIFFCEFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x568F510", Offset = "0x568E710", VA = "0x18568F510")]
	private void EDCACEHEJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x568F870", Offset = "0x568EA70", VA = "0x18568F870")]
	[IteratorStateMachine(typeof(GJLFCPJPHFP))]
	private IEnumerator<HGAIOCFFOOA> KPNJFHBPHOG(float DDFIFFCEFPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x568F790", Offset = "0x568E990", VA = "0x18568F790")]
	[CompilerGenerated]
	private void HBLCLHABBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Flags]
internal enum HPGEMCIAPDN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal class MPHCLNGMKMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public MMPMCPDLGLB DLNDFDLLPCD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int FPMEKFLEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x841E20", Offset = "0x841020", VA = "0x180841E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x568D5F0", Offset = "0x568C7F0", VA = "0x18568D5F0")]
	public static HGAIOCFFOOA NAKMJBNHPHF(IEnumerator<HGAIOCFFOOA> CGDGEFKFGKE, JPBOFCAILKM IPHCMLMIPHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x568D510", Offset = "0x568C710", VA = "0x18568D510")]
	public HGAIOCFFOOA NAKMJBNHPHF(JPBOFCAILKM[] FEFBGKBGFDA, IEnumerator<HGAIOCFFOOA>[] ADJLFCCJBDO, HGAIOCFFOOA[] GOENOFLNONI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x568D4E0", Offset = "0x568C6E0", VA = "0x18568D4E0")]
	public void NKAGLNLPAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x568D260", Offset = "0x568C460", VA = "0x18568D260")]
	public void FJFGBHNKLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x568D3A0", Offset = "0x568C5A0", VA = "0x18568D3A0")]
	public void JNIPNOFLKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x568D4E0", Offset = "0x568C6E0", VA = "0x18568D4E0")]
	public void LFPEABENKGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public MPHCLNGMKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GKHKGHAJAII : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class AIEFCEPGHHD : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public GKHKGHAJAII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public AIEFCEPGHHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5676270", Offset = "0x5675470", VA = "0x185676270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5676350", Offset = "0x5675550", VA = "0x185676350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Action APBHGKMMGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool MOIICADHAOE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8F3030", Offset = "0x8F2230", VA = "0x1808F3030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x567E680", Offset = "0x567D880", VA = "0x18567E680")]
	public GKHKGHAJAII(GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x567E590", Offset = "0x567D790", VA = "0x18567E590")]
	[IteratorStateMachine(typeof(AIEFCEPGHHD))]
	private IEnumerator<HGAIOCFFOOA> EFJKPDBNNFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x567E600", Offset = "0x567D800", VA = "0x18567E600", Slot = "4")]
	public void OnCompleted(Action LFJEPMDGHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public void NBFCJMCBDCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class LAPLHMGDOIJ
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5687420", Offset = "0x5686620", VA = "0x185687420")]
	public static GKHKGHAJAII LBFELGIGDIH(this GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class AIJNHLJJFLA : HJGJBBBCHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly HOBPEPKDKNI CHAOLJOCGCA;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5676DF0", Offset = "0x5675FF0", VA = "0x185676DF0")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	[Preserve]
	internal AIJNHLJJFLA([IDNKOMINBGM(null)] HOBPEPKDKNI CHAOLJOCGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5676E60", Offset = "0x5676060", VA = "0x185676E60", Slot = "4")]
	public IDisposable NHEOFEDFMOL(float GMJNHCPHGNB, Action<float> NMCNKNBHPHF, bool GMCAIEAGGMK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum AKKGFODJKGL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class KCCKGIBPGPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum IIDKNPOCMGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct CGJOBMENKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public GMGILNDCDCO.EKJHGBKIKMC LMLMNPEIEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public IIDKNPOCMGM OLCFAMPNKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public List<PNJLIJHKELO> DGBPJNPIBGH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly IIDKNPOCMGM[] NHKOIJIGEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool IHMHNNCBAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly PNJLIJHKELO[] LJKPKIANLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly List<PNJLIJHKELO> GOPLIJEOGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly Stack<int> ECLPLMBENJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<PNJLIJHKELO> LIMMPOENELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Stack<int> AOLKOHBFHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly LFHMANDKBCF DHAMOHGFOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool JDGNLABCACI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public CGJOBMENKKG[,] AOHJKGEKDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5685D30", Offset = "0x5684F30", VA = "0x185685D30")]
	public KCCKGIBPGPB(GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, LFHMANDKBCF DHAMOHGFOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5684D20", Offset = "0x5683F20", VA = "0x185684D20")]
	public void DEHNDCHFJKP(PNJLIJHKELO CGDGEFKFGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5685110", Offset = "0x5684310", VA = "0x185685110")]
	public void FFPGIOJODJK(IList<PNJLIJHKELO> ADJLFCCJBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5685610", Offset = "0x5684810", VA = "0x185685610")]
	public void IPCCFNONDNJ(IList<PNJLIJHKELO> ADJLFCCJBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5685510", Offset = "0x5684710", VA = "0x185685510")]
	private void INCKLBHPLEJ(PNJLIJHKELO CGDGEFKFGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5684F80", Offset = "0x5684180", VA = "0x185684F80")]
	private void ECJDALJPKBL(IList<PNJLIJHKELO> ADJLFCCJBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5684BC0", Offset = "0x5683DC0", VA = "0x185684BC0")]
	private AKKGFODJKGL DABAPOECHKM(PNJLIJHKELO CGDGEFKFGKE)
	{
		return default(AKKGFODJKGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5684A70", Offset = "0x5683C70", VA = "0x185684A70")]
	public void BOOFGHHIEIL(float JKBNDGJADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5684860", Offset = "0x5683A60", VA = "0x185684860")]
	public void ACNBOCNEOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x56858E0", Offset = "0x5684AE0", VA = "0x1856858E0")]
	private void KLBDIILMDGM(List<PNJLIJHKELO> ADJLFCCJBDO, Stack<int> BCFJLPLBKAG, bool DPOEMKKHPBF, float APNHJDMBKJE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5684E40", Offset = "0x5684040", VA = "0x185684E40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x56853E0", Offset = "0x56845E0", VA = "0x1856853E0")]
	private void FOIPEDCHLGN(List<PNJLIJHKELO> ADJLFCCJBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class NKBAAGKAGGG : OPIADAJNKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Behaviour PKHPCABJFOL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x568DBE0", Offset = "0x568CDE0", VA = "0x18568DBE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MFBCPFGMBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568CE70", VA = "0x18568DC70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ANPFAECBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x568DBC0", Offset = "0x568CDC0", VA = "0x18568DBC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x8D7A20", Offset = "0x8D6C20", VA = "0x1808D7A20")]
	public NKBAAGKAGGG(Behaviour PKHPCABJFOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KPEADHPCBGI : ONKDFGABFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly float POBFIFNOIBA;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x567E9C0", Offset = "0x567DBC0", VA = "0x18567E9C0")]
	public KPEADHPCBGI(Behaviour APPLJOFCBIB, float POBFIFNOIBA, [Optional] Action CHNJIGLCIHO, [Optional] HOBPEPKDKNI CHAOLJOCGCA, [Optional] LAKCKOGKCLI NLDIHCDEEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "9")]
	protected override bool MFGOIBLBGOP(Action JFFMHPNGJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5686DE0", Offset = "0x5685FE0", VA = "0x185686DE0", Slot = "10")]
	protected override bool NAMFGDNGBJB(Action JFFMHPNGJBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class NLODAGJHHBG
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x568DFA0", Offset = "0x568D1A0", VA = "0x18568DFA0")]
	public static IDisposable PBEPLMIAHEN(this LBNBHKKHGCG APPLJOFCBIB, float GMJNHCPHGNB, Action<float> LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x568DEA0", Offset = "0x568D0A0", VA = "0x18568DEA0")]
	public static IDisposable BBGHPLHKEJB(this LBNBHKKHGCG APPLJOFCBIB, Action<float> LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x568DF20", Offset = "0x568D120", VA = "0x18568DF20")]
	public static IDisposable JHGAAOIPOHD(this LBNBHKKHGCG APPLJOFCBIB, Action<float> LLAEABMBHMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class MMEPLECBLDN
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class HFIAMPGFKHA : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public GMGILNDCDCO.EKJHGBKIKMC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private FBGMCKPMBOC <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public HFIAMPGFKHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x567FB70", Offset = "0x567ED70", VA = "0x18567FB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x567FC40", Offset = "0x567EE40", VA = "0x18567FC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class JDMJNKAHKNN : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public GMGILNDCDCO.EKJHGBKIKMC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private FBGMCKPMBOC <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public JDMJNKAHKNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5682750", Offset = "0x5681950", VA = "0x185682750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5682840", Offset = "0x5681A40", VA = "0x185682840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x568A6F0", Offset = "0x56898F0", VA = "0x18568A6F0")]
	public static HDFNBFCGAOH OMMLMLLBLMA(Action LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x568A630", Offset = "0x5689830", VA = "0x18568A630")]
	public static HDFNBFCGAOH OMMLMLLBLMA(Behaviour APPLJOFCBIB, Action LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x568A7A0", Offset = "0x56899A0", VA = "0x18568A7A0")]
	public static HDFNBFCGAOH OMMLMLLBLMA(Behaviour APPLJOFCBIB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x568A5B0", Offset = "0x56897B0", VA = "0x18568A5B0")]
	[IteratorStateMachine(typeof(HFIAMPGFKHA))]
	private static IEnumerator<HGAIOCFFOOA> IEDCMMBALHM(GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x568A530", Offset = "0x5689730", VA = "0x18568A530")]
	[IteratorStateMachine(typeof(JDMJNKAHKNN))]
	private static IEnumerator<HGAIOCFFOOA> IEDCMMBALHM(GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action<float> LLAEABMBHMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class AIIKGGENLPC
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5676CF0", Offset = "0x5675EF0", VA = "0x185676CF0")]
	public static IDisposable OMMLMLLBLMA(this MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5676D70", Offset = "0x5675F70", VA = "0x185676D70")]
	public static IDisposable OMMLMLLBLMA(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5676420", Offset = "0x5675620", VA = "0x185676420")]
	public static IDisposable BOOFGHHIEIL(this MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5676B50", Offset = "0x5675D50", VA = "0x185676B50")]
	public static IDisposable NBOBGDMCJKB(this MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5676C70", Offset = "0x5675E70", VA = "0x185676C70")]
	public static IDisposable ODAPINLBCLF(this MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5676750", Offset = "0x5675950", VA = "0x185676750")]
	public static IDisposable JCLNNDJOLCB(this MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5676520", Offset = "0x5675720", VA = "0x185676520")]
	public static IDisposable DCLFIPMAABO(this MonoBehaviour PKHPCABJFOL, Action LLAEABMBHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5676AB0", Offset = "0x5675CB0", VA = "0x185676AB0")]
	public static IDisposable MOJIFJAHEOI(this MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5676870", Offset = "0x5675A70", VA = "0x185676870")]
	public static IDisposable JJDOKHAABHL(this MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5676BD0", Offset = "0x5675DD0", VA = "0x185676BD0")]
	public static IDisposable NHEOFEDFMOL(this MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5676630", Offset = "0x5675830", VA = "0x185676630")]
	public static IDisposable GMDADBHGCHI(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5676A20", Offset = "0x5675C20", VA = "0x185676A20")]
	public static IDisposable MDHJLGEDGOJ(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x56766C0", Offset = "0x56758C0", VA = "0x1856766C0")]
	public static IDisposable GOCMLPMLKMO(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5676490", Offset = "0x5675690", VA = "0x185676490")]
	public static IDisposable CMEHANNKJJL(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x56765A0", Offset = "0x56757A0", VA = "0x1856765A0")]
	public static IDisposable EOKLDLKFFBL(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5676390", Offset = "0x5675590", VA = "0x185676390")]
	public static IDisposable ADNLPFMGHAJ(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5676990", Offset = "0x5675B90", VA = "0x185676990")]
	public static IDisposable KKEIBKIFDPO(this MonoBehaviour PKHPCABJFOL, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x56767D0", Offset = "0x56759D0", VA = "0x1856767D0")]
	public static IDisposable JGCAGNDDFFA(this MonoBehaviour PKHPCABJFOL, float GMJNHCPHGNB, Action<float> LLAEABMBHMH, bool GMCAIEAGGMK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class JPBOFCAILKM : PIFHNGBGPBL, HDFNBFCGAOH, MMEJLKMBIHL, OOPPNGPPPLE, IEnumerator, HGAIOCFFOOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private GMGILNDCDCO.EKJHGBKIKMC KGKNEMILPJB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private GMGILNDCDCO.EKJHGBKIKMC KCCLAEMGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1287F30", Offset = "0x1287130", VA = "0x181287F30", Slot = "23")]
		get
		{
			return default(GMGILNDCDCO.EKJHGBKIKMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GMGILNDCDCO.EKJHGBKIKMC DLNDFDLLPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x931320", Offset = "0x930520", VA = "0x180931320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float NJCEHLLJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xE19670", Offset = "0xE18870", VA = "0x180E19670", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AMDEJJBKNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5683E20", Offset = "0x5683020", VA = "0x185683E20", Slot = "24")]
	private bool OCJBJOGJIIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5683E10", Offset = "0x5683010", VA = "0x185683E10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5683E40", Offset = "0x5683040", VA = "0x185683E40")]
	public JPBOFCAILKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface OPIADAJNKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool MFBCPFGMBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool ANPFAECBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class FBIMNAOCIJN
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class NNEGKBPDPEJ : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public GMGILNDCDCO.EKJHGBKIKMC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public NNEGKBPDPEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x568E020", Offset = "0x568D220", VA = "0x18568E020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x568E0E0", Offset = "0x568D2E0", VA = "0x18568E0E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class GIOJPMMECMN : IEnumerator<HGAIOCFFOOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HGAIOCFFOOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public GMGILNDCDCO.EKJHGBKIKMC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private HGAIOCFFOOA <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private HGAIOCFFOOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2E0", Offset = "0x8DB4E0", VA = "0x1808DC2E0")]
		[DebuggerHidden]
		public GIOJPMMECMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x567E360", Offset = "0x567D560", VA = "0x18567E360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x567E440", Offset = "0x567D640", VA = "0x18567E440", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x567C920", Offset = "0x567BB20", VA = "0x18567C920")]
	[IteratorStateMachine(typeof(NNEGKBPDPEJ))]
	private static IEnumerator<HGAIOCFFOOA> EFJKPDBNNFJ(float KFAABCMFLLA, GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x567D090", Offset = "0x567C290", VA = "0x18567D090")]
	[IteratorStateMachine(typeof(GIOJPMMECMN))]
	private static IEnumerator<HGAIOCFFOOA> PIEHCCJJFHO(float KFAABCMFLLA, GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x567CD80", Offset = "0x567BF80", VA = "0x18567CD80")]
	public static IDisposable JDGMAIJCMBD(this MonoBehaviour PKHPCABJFOL, float KFAABCMFLLA, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x567CEA0", Offset = "0x567C0A0", VA = "0x18567CEA0")]
	public static HDFNBFCGAOH JNDJFNNPFDM(this MonoBehaviour PKHPCABJFOL, float KFAABCMFLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x567CC50", Offset = "0x567BE50", VA = "0x18567CC50")]
	public static HDFNBFCGAOH JDGMAIJCMBD(this MonoBehaviour PKHPCABJFOL, float KFAABCMFLLA, GMGILNDCDCO.EKJHGBKIKMC JMMNJJCIEMI, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x567D040", Offset = "0x567C240", VA = "0x18567D040")]
	public static HDFNBFCGAOH MJLLNMMMPLF(this MonoBehaviour PKHPCABJFOL, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x567C8F0", Offset = "0x567BAF0", VA = "0x18567C8F0")]
	public static HDFNBFCGAOH CHMHLBFFOOG(this MonoBehaviour PKHPCABJFOL, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x567CF60", Offset = "0x567C160", VA = "0x18567CF60")]
	public static HDFNBFCGAOH KGECKAFOPBO(this MonoBehaviour PKHPCABJFOL, Action MKHLEPDKFPF, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x567C8C0", Offset = "0x567BAC0", VA = "0x18567C8C0")]
	public static HDFNBFCGAOH CECAEPHANBJ(this MonoBehaviour PKHPCABJFOL, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x567D060", Offset = "0x567C260", VA = "0x18567D060")]
	public static HDFNBFCGAOH OKIJLAFAMLM(this MonoBehaviour PKHPCABJFOL, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x567CC20", Offset = "0x567BE20", VA = "0x18567CC20")]
	public static HDFNBFCGAOH IODPKAGMNPJ(this MonoBehaviour PKHPCABJFOL, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x567C7F0", Offset = "0x567B9F0", VA = "0x18567C7F0")]
	private static HDFNBFCGAOH CCNEPKJHDBD(MonoBehaviour PKHPCABJFOL, GMGILNDCDCO.EKJHGBKIKMC DIHACOLLIPH, Action MKHLEPDKFPF, [Optional] HOBPEPKDKNI CHAOLJOCGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x567C720", Offset = "0x567B920", VA = "0x18567C720")]
	public static HDFNBFCGAOH BJMHAKAMGJM(this MonoBehaviour PKHPCABJFOL, float GGMLAAFJDBG, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x567CB50", Offset = "0x567BD50", VA = "0x18567CB50")]
	public static HDFNBFCGAOH HHLFBOIANIP(this MonoBehaviour PKHPCABJFOL, float GGMLAAFJDBG, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x567C9B0", Offset = "0x567BBB0", VA = "0x18567C9B0")]
	public static HDFNBFCGAOH GIBDCJELLGF(this MonoBehaviour PKHPCABJFOL, float GGMLAAFJDBG, Action MKHLEPDKFPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x567CA80", Offset = "0x567BC80", VA = "0x18567CA80")]
	public static HDFNBFCGAOH HDIOIPHAKOG(this MonoBehaviour PKHPCABJFOL, float GGMLAAFJDBG, Action MKHLEPDKFPF)
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

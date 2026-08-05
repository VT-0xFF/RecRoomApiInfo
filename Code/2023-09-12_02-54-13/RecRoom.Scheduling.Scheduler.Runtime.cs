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
public class EHHGGHOBIAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority EAOPCIHECPC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F98580", Offset = "0x4F97980", VA = "0x184F98580")]
	public EHHGGHOBIAA(ThreadPriority CKDGEEEBJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F98570", Offset = "0x4F97970", VA = "0x184F98570", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> EPAIOFKNGFL(List<PlayerLoopSystem> NNFPDEGNOEP, int CKNGKCOEGNN);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct EPDFIFMEOPI
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct ACAJDJAEPDG
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static MLPFDGHACOI EBMNMEMLFNA;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4F8C470", Offset = "0x4F8B870", VA = "0x184F8C470")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MKKAABJFHHE
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static MLPFDGHACOI GGDGLNBFJIL;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4FA3960", Offset = "0x4FA2D60", VA = "0x184FA3960")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct OFJLGGJJBOE
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static MLPFDGHACOI OIBAABMILIC;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4FA4510", Offset = "0x4FA3910", VA = "0x184FA4510")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct PACJIMBPEKP
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static MLPFDGHACOI KPBIJKCEPML;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static MLPFDGHACOI OBIMEANFPGN;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static MLPFDGHACOI FDBHEGCABDG;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static MLPFDGHACOI OHMAHPBJLMB;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4FA4DA0", Offset = "0x4FA41A0", VA = "0x184FA4DA0")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct FPINCEABKMP
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static MLPFDGHACOI GNBBBJFADKD;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4F99750", Offset = "0x4F98B50", VA = "0x184F99750")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PEPJLABHICK
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static MLPFDGHACOI KPBIJKCEPML;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static MLPFDGHACOI OBIMEANFPGN;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static MLPFDGHACOI FDBHEGCABDG;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static MLPFDGHACOI OHMAHPBJLMB;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x4FA5060", Offset = "0x4FA4460", VA = "0x184FA5060")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct JLMJIFAAGDG
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static MLPFDGHACOI FFMPNGBHBPB;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x4FA0840", Offset = "0x4F9FC40", VA = "0x184FA0840")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct LIPJDPAOCOJ
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static MLPFDGHACOI JGHFMAHPCAI;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x4FA3350", Offset = "0x4FA2750", VA = "0x184FA3350")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct AACIODABHDL
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static MLPFDGHACOI IMNHFFMMLLE;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x4F8C260", Offset = "0x4F8B660", VA = "0x184F8C260")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct OLNGIDNNPED
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static MLPFDGHACOI LFLBIPDNENN;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x4FA4B90", Offset = "0x4FA3F90", VA = "0x184FA4B90")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct EBDCFNEHGNH
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static MLPFDGHACOI NGOPKNIFPOF;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4F98360", Offset = "0x4F97760", VA = "0x184F98360")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct EJFACJIBJAM
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static MLPFDGHACOI IEPOFOGNGCF;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4F985C0", Offset = "0x4F979C0", VA = "0x184F985C0")]
				public static PlayerLoopSystem OLCJIDLGBBL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum LKGCAENCMNP : byte
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
			public struct CMOIFMHEGKC
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PIJHFKOCAPE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public LKGCAENCMNP updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
					public PIJHFKOCAPE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x4FA5C90", Offset = "0x4FA5090", VA = "0x184FA5C90")]
					internal void OLILEJHBNPL()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000036")]
				public static PJFJKKKIAHI<LKGCAENCMNP> AAEIPEIMIII;

				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x4F92900", Offset = "0x4F91D00", VA = "0x184F92900")]
				public static PlayerLoopSystem OLCJIDLGBBL(LKGCAENCMNP KBKHLLKGMHF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			internal struct MHIHOPKKEAJ
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class FDPDCJHDGJD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public FKBHOOAALFH.MNAKDAHGIEO key;

					[Cpp2IlInjected.Token(Token = "0x6000051")]
					[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
					public FDPDCJHDGJD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x4F98860", Offset = "0x4F97C60", VA = "0x184F98860")]
					internal void GJDFBHPOJIH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000038")]
				public static IDisposable MLPNLKJAALC;

				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x4FA36A0", Offset = "0x4FA2AA0", VA = "0x184FA36A0")]
				public static PlayerLoopSystem EAHLDPEONDM(FKBHOOAALFH.MNAKDAHGIEO PMMAAICOJOP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000024")]
			internal struct MIMCNPHAIME
			{
				[Cpp2IlInjected.Token(Token = "0x2000025")]
				[CompilerGenerated]
				private sealed class NGPEACEKCNL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public FKBHOOAALFH.MNAKDAHGIEO key;

					[Cpp2IlInjected.Token(Token = "0x6000057")]
					[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
					public NGPEACEKCNL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x4FA3C90", Offset = "0x4FA3090", VA = "0x184FA3C90")]
					internal void GJDFBHPOJIH()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x4FA3800", Offset = "0x4FA2C00", VA = "0x184FA3800")]
				public static PlayerLoopSystem EAHLDPEONDM(FKBHOOAALFH.MNAKDAHGIEO PMMAAICOJOP)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class NFGLNMJACPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public NFGLNMJACPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4FA3B70", Offset = "0x4FA2F70", VA = "0x184FA3B70")]
			internal List<PlayerLoopSystem> OHCOMBLOLBA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OKCOPPLBGDI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool CIAJPCHKPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4F97160", Offset = "0x4F96560", VA = "0x184F97160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4F974D0", Offset = "0x4F968D0", VA = "0x184F974D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4F93C40", Offset = "0x4F93040", VA = "0x184F93C40")]
		private static void HPKEOBGKMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F96890", Offset = "0x4F95C90", VA = "0x184F96890")]
		private static void JMHBPLDJIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F971A0", Offset = "0x4F965A0", VA = "0x184F971A0")]
		private static void MMPOKBMLEBO(string AMOIBOEBNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4F935F0", Offset = "0x4F929F0", VA = "0x184F935F0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4F966C0", Offset = "0x4F95AC0", VA = "0x184F966C0")]
		private static void IGPKBABLAAA(FKBHOOAALFH.MNAKDAHGIEO PMMAAICOJOP, ref PlayerLoopSystem BJOKMMJKJPC, Type GHCILENLLFF, Type NNFFOAGGEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4F93820", Offset = "0x4F92C20", VA = "0x184F93820")]
		private static void DKPBIHPCGCK(ref PlayerLoopSystem BJOKMMJKJPC, Type GHCILENLLFF, Type NNFFOAGGEKM, EPAIOFKNGFL ALGCCMEHBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4F96590", Offset = "0x4F95990", VA = "0x184F96590")]
		private static void IAAALDFJMHO(ref PlayerLoopSystem BJOKMMJKJPC, Type GHCILENLLFF, Type NNFFOAGGEKM, PlayerLoopSystem? GDHALBHMCOE, PlayerLoopSystem? GDLNJBIFHGF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FKBHOOAALFH
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum MNAKDAHGIEO
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
	public class NHMFGPOFEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly MNAKDAHGIEO KDJMHJLOLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly GNJEFLFHIAJ PNFNJICOIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private long HMAJLLPJHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private long BHIEFGICJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long MGBHDPMCBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int OOABHNEDFOB;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4FA41F0", Offset = "0x4FA35F0", VA = "0x184FA41F0")]
		public NHMFGPOFEJG(MNAKDAHGIEO PPHGAOIGFAM, int FMPMNDMKCLJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4120", Offset = "0x4FA3520", VA = "0x184FA4120")]
		public void HEGJKGOCAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4190", Offset = "0x4FA3590", VA = "0x184FA4190")]
		public void LACLBHECEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3F20", Offset = "0x4FA3320", VA = "0x184FA3F20")]
		public void GMLJJLCJKEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static MNAKDAHGIEO[] JCAHGPFCBKE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static NHMFGPOFEJG[] IHPLEHLCGPH;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F993D0", Offset = "0x4F987D0", VA = "0x184F993D0")]
	public static NHMFGPOFEJG OFEFDNABJLM(MNAKDAHGIEO PMMAAICOJOP, int FMPMNDMKCLJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F99340", Offset = "0x4F98740", VA = "0x184F99340")]
	public static NHMFGPOFEJG EFLMKDBJCNJ(MNAKDAHGIEO PMMAAICOJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4F99290", Offset = "0x4F98690", VA = "0x184F99290")]
	public static void EAIMEMDGJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DHPJKKPDHAC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private interface CPFKODECNIL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GFJDIDMONHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LKEHBOFLELP();
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private abstract class EJAGMPBLJAL<TPromise, TMainThreadPromise> : CPFKODECNIL where TPromise : LMHNGLGIJDH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TPromise CNKAFIEKCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected readonly TMainThreadPromise DDOMHHGLGLL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise GJDNHIDPKNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2B780E0", Offset = "0x2B774E0", VA = "0x182B780E0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GFJDIDMONHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B78090", Offset = "0x2B77490", VA = "0x182B78090", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2456A10", Offset = "0x2455E10", VA = "0x182456A10")]
		protected EJAGMPBLJAL(TPromise CNKAFIEKCEM, TMainThreadPromise IGNCHEKJLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B78140", Offset = "0x2B77540", VA = "0x182B78140", Slot = "5")]
		public void LKEHBOFLELP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void KEJANADHIOK(TPromise CNKAFIEKCEM);
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class IAAHFEDMIHN<T> : EJAGMPBLJAL<KDCMFGDLEKL<T>, KLOLCAIIKNK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x15CA5A0", Offset = "0x15C99A0", VA = "0x1815CA5A0")]
		public IAAHFEDMIHN(KDCMFGDLEKL<T> CNKAFIEKCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x15CA3A0", Offset = "0x15C97A0", VA = "0x1815CA3A0", Slot = "6")]
		protected override void KEJANADHIOK(KDCMFGDLEKL<T> CNKAFIEKCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x15CA370", Offset = "0x15C9770", VA = "0x1815CA370")]
		[CompilerGenerated]
		private void BBNHIKMJMJF(T MOOEDNDCGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x92BDD0", Offset = "0x92B1D0", VA = "0x18092BDD0")]
		[CompilerGenerated]
		private void JDOLCHMGGDM(string FOMNCGOADBK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GDBFKCDKMOG : CPFKODECNIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Action NDPBOAHDPLI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GFJDIDMONHP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
		public GDBFKCDKMOG(Action NDPBOAHDPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF920", Offset = "0x8BED20", VA = "0x1808BF920", Slot = "5")]
		public void LKEHBOFLELP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<CPFKODECNIL> GLJFOPFDECN;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E6A0", Offset = "0x2C7DAA0", VA = "0x182C7E6A0")]
	public static KDCMFGDLEKL<T> AMIBDIHECAA<T>(this KDCMFGDLEKL<T> CNKAFIEKCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4F97510", Offset = "0x4F96910", VA = "0x184F97510")]
	public static void AMIBDIHECAA(Action NDPBOAHDPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E710", Offset = "0x2C7DB10", VA = "0x182C7E710")]
	private static KDCMFGDLEKL<T> JGPAKPKJELL<T>(KDCMFGDLEKL<T> CNKAFIEKCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4F975A0", Offset = "0x4F969A0", VA = "0x184F975A0")]
	private static void GDKOOLDBFEC(CPFKODECNIL JEHFHEIFLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4F97970", Offset = "0x4F96D70", VA = "0x184F97970")]
	private static void NDADAOENKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4F97870", Offset = "0x4F96C70", VA = "0x184F97870")]
	private static void GPAJNAPACFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4F977A0", Offset = "0x4F96BA0", VA = "0x184F977A0")]
	private static void GOMFEMBBBNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class JCPAAJFCFAN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct NOHONPHMCMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TaskCompletionSource<Scene> PPBPGILJHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly string HGLBIHJJLGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly LoadSceneMode CALBOODFAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool FPLFNEBCKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4FA42F0", Offset = "0x4FA36F0", VA = "0x184FA42F0")]
		public NOHONPHMCMC(TaskCompletionSource<Scene> MBCLGDFFCMD, string HGLBIHJJLGC, LoadSceneMode CALBOODFAOI, bool FPLFNEBCKDB, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class AMKJEMEJOOM : IAsyncStateMachine
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
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private CPMEPPENFLB<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CNCFPMNNGFM <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private NOHONPHMCMC <queuedSceneLoad>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AMKJEMEJOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4F8EC40", Offset = "0x4F8E040", VA = "0x184F8EC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class KAHBCMBOIML : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KAHBCMBOIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1450", Offset = "0x4FA0850", VA = "0x184FA1450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PIAHKFJJOOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private NOHONPHMCMC <dequeued>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PIAHKFJJOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4FA58C0", Offset = "0x4FA4CC0", VA = "0x184FA58C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class PGHECCEFDCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KLOLCAIIKNK<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PGHECCEFDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x4FA5860", Offset = "0x4FA4C60", VA = "0x184FA5860")]
		internal void CIGCIKCCJCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BHLECFAKLEL : IAsyncStateMachine
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
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private PGHECCEFDCG <>8__2;

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
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BHLECFAKLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F5D0", Offset = "0x4F8E9D0", VA = "0x184F8F5D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LCGNDPBGMDA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LCGNDPBGMDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2990", Offset = "0x4FA1D90", VA = "0x184FA2990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KCNODPCBBLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CPMEPPENFLB<string>.PEFDMNJICBO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private CPMEPPENFLB<string>.PEFDMNJICBO <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KCNODPCBBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4FA1790", Offset = "0x4FA0B90", VA = "0x184FA1790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MDOKHCJLCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MDOKHCJLCFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3560", Offset = "0x4FA2960", VA = "0x184FA3560")]
		internal bool JAEJOIBAMHI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KPEJNEPKPPE : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LGAKEDCJAKH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MDOKHCJLCFC <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public KPEJNEPKPPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2900", Offset = "0x4FA1D00", VA = "0x184FA2900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2530", Offset = "0x4FA1930", VA = "0x184FA2530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2870", Offset = "0x4FA1C70", VA = "0x184FA2870")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4FA28C0", Offset = "0x4FA1CC0", VA = "0x184FA28C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HIPKEJLIBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public KLOLCAIIKNK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HIPKEJLIBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F9CEB0", Offset = "0x4F9C2B0", VA = "0x184F9CEB0")]
		internal bool PIBCFIAOLFH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F9CC40", Offset = "0x4F9C040", VA = "0x184F9CC40")]
		internal void OGICHFCELCC(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class CMBNCHEDEFB : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KLOLCAIIKNK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private HIPKEJLIBIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public CMBNCHEDEFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4F91FF0", Offset = "0x4F913F0", VA = "0x184F91FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4F927F0", Offset = "0x4F91BF0", VA = "0x184F927F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly ICollection<string> FICHGJBCKMA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static LMHNGLGIJDH NLEADBOJMJI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AsyncOperation CBEJJAICDBF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static LMHNGLGIJDH GNNPMIHJPGM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static string HKPILCPPPFF;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static ThreadPriority PJHLNNLFMAI;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task GDPICFAILHG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static List<SceneInstance> MCMDJBBKACM;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly Queue<NOHONPHMCMC> OBBOBAHGJJF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Task MHOLLPGNKBP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool BBNEGNFOBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4F9F6E0", Offset = "0x4F9EAE0", VA = "0x184F9F6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool KIKBENAPNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4F9E2E0", Offset = "0x4F9D6E0", VA = "0x184F9E2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool HABFJAPEGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4F9ED20", Offset = "0x4F9E120", VA = "0x184F9ED20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool BPLEFOEIJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4F9EF80", Offset = "0x4F9E380", VA = "0x184F9EF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GHHIMEFPEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4F9F960", Offset = "0x4F9ED60", VA = "0x184F9F960")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4F9F480", Offset = "0x4F9E880", VA = "0x184F9F480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E4F0", Offset = "0x4F9D8F0", VA = "0x184F9E4F0")]
	[JBOBMCDMAPA(LNELBDJPNNB.EnteredEditModeNextFrame, 0)]
	private static void GDIGLLFHFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F1E0", Offset = "0x4F9E5E0", VA = "0x184F9F1E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMKJEMEJOOM))]
	public static Task<Scene> MMLDLIFDOIK(string HGLBIHJJLGC, LoadSceneMode CALBOODFAOI = LoadSceneMode.Single, bool FPLFNEBCKDB = false, [Optional] CPMEPPENFLB<string>.PEFDMNJICBO FHNNCDLHLKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EDE0", Offset = "0x4F9E1E0", VA = "0x184F9EDE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KAHBCMBOIML))]
	private static Task JMPJDOBHIEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E1E0", Offset = "0x4F9D5E0", VA = "0x184F9E1E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PIAHKFJJOOF))]
	private static Task BEHEKIADNKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F030", Offset = "0x4F9E430", VA = "0x184F9F030")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHLECFAKLEL))]
	private static Task<Scene> MKNOJJFBANO(string HGLBIHJJLGC, LoadSceneMode CALBOODFAOI, bool FPLFNEBCKDB, CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F390", Offset = "0x4F9E790", VA = "0x184F9F390")]
	private static void NNGPJKLJKDL(SceneInstance IILNPDLGJIK, LoadSceneMode CALBOODFAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EEE0", Offset = "0x4F9E2E0", VA = "0x184F9EEE0")]
	private static void KDKIIHPJCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9F580", Offset = "0x4F9E980", VA = "0x184F9F580")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LCGNDPBGMDA))]
	private static Task<Scene> PDHIAPPBJAF(string HGLBIHJJLGC, LoadSceneMode CALBOODFAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9FA60", Offset = "0x4F9EE60", VA = "0x184F9FA60")]
	private static bool POFBHNLIHJL(string HGLBIHJJLGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E3A0", Offset = "0x4F9D7A0", VA = "0x184F9E3A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KCNODPCBBLF))]
	private static Task<Scene> ECEFIJAMHIA(CPMEPPENFLB<string>.PEFDMNJICBO ILHHOPLAPCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E660", Offset = "0x4F9DA60", VA = "0x184F9E660")]
	public static KDCMFGDLEKL<Scene> GILJBKFHDLF(string HGLBIHJJLGC, LoadSceneMode CALBOODFAOI = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E850", Offset = "0x4F9DC50", VA = "0x184F9E850")]
	public static LMHNGLGIJDH HGPIDPCOBDN(string HGLBIHJJLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EB20", Offset = "0x4F9DF20", VA = "0x184F9EB20")]
	[IteratorStateMachine(typeof(KPEJNEPKPPE))]
	private static IEnumerator<PHFLFKPMCCG> HJJAPBCFBMM(string HGLBIHJJLGC, LGAKEDCJAKH FNPHNPKEEDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E5C0", Offset = "0x4F9D9C0", VA = "0x184F9E5C0")]
	[IteratorStateMachine(typeof(CMBNCHEDEFB))]
	private static IEnumerator<PHFLFKPMCCG> GEEOGGNIPOJ(string HGLBIHJJLGC, LoadSceneMode CALBOODFAOI, KLOLCAIIKNK<Scene> FNPHNPKEEDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EBB0", Offset = "0x4F9DFB0", VA = "0x184F9EBB0")]
	public static bool ILHDICOMLPN(out string NINBLILEOMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GNJEFLFHIAJ : KFJCANDJNGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int BHPCKAKNJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Queue<double> BNEMFLKBGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private double BBMNFGPBPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double KBFJHJENIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double CHHKBHMBEJP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double GKMNOEJJCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4F9C8C0", Offset = "0x4F9BCC0", VA = "0x184F9C8C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double LCECEDDKPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xB38700", Offset = "0xB37B00", VA = "0x180B38700", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double DHBAIBMHDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CD60", Offset = "0x3F8C160", VA = "0x183F8CD60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C930", Offset = "0x4F9BD30", VA = "0x184F9C930")]
	public GNJEFLFHIAJ(int FAHAFJADELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C720", Offset = "0x4F9BB20", VA = "0x184F9C720", Slot = "7")]
	public void FKBPMNCLDHC(double GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C850", Offset = "0x4F9BC50", VA = "0x184F9C850", Slot = "8")]
	public void IKCBOKMOGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KHIHNLDENOO : KFJCANDJNGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private long FJFMKNIHPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double LGGKDPNPLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double PNFCONDEKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double GIMMPEMAMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private double MNAINEDOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private double BBMNFGPBPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private double KBFJHJENIED;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9FC8D0", Offset = "0x9FBCD0", VA = "0x1809FC8D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double LCECEDDKPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4FA24D0", Offset = "0x4FA18D0", VA = "0x184FA24D0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double DHBAIBMHDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2350", Offset = "0x4FA1750", VA = "0x184FA2350", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double GNFKPNPPLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2340", Offset = "0x4FA1740", VA = "0x184FA2340")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double GKMNOEJJCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4FA24E0", Offset = "0x4FA18E0", VA = "0x184FA24E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2360", Offset = "0x4FA1760", VA = "0x184FA2360", Slot = "7")]
	public virtual void FKBPMNCLDHC(double GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2490", Offset = "0x4FA1890", VA = "0x184FA2490", Slot = "8")]
	public virtual void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4FA24F0", Offset = "0x4FA18F0", VA = "0x184FA24F0")]
	public KHIHNLDENOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class OEOKLBHIGEG : KHIHNLDENOO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double PCPNMHEPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CDC0", Offset = "0x3F8C1C0", VA = "0x183F8CDC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F8CDB0", Offset = "0x3F8C1B0", VA = "0x183F8CDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4390", Offset = "0x4FA3790", VA = "0x184FA4390", Slot = "7")]
	public override void FKBPMNCLDHC(double GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4FA44D0", Offset = "0x4FA38D0", VA = "0x184FA44D0", Slot = "8")]
	public override void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4FA24F0", Offset = "0x4FA18F0", VA = "0x184FA24F0")]
	public OEOKLBHIGEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KFJCANDJNGC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double GKMNOEJJCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double LCECEDDKPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double DHBAIBMHDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class COGFHFHIMMH : GGDNLKAAGIA
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float HNDENAKKHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4F93560", Offset = "0x4F92960", VA = "0x184F93560", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float EPMHGOGCHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x4F935E0", Offset = "0x4F929E0", VA = "0x184F935E0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double GPDDMOHGDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4F93540", Offset = "0x4F92940", VA = "0x184F93540", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F93570", Offset = "0x4F92970", VA = "0x184F93570")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	[Preserve]
	internal COGFHFHIMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class AFHBKNHIIHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class GCDBMOAMOFE : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AFHBKNHIIHC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public GCDBMOAMOFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4F99B50", Offset = "0x4F98F50", VA = "0x184F99B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4F9C5B0", Offset = "0x4F9B9B0", VA = "0x184F9C5B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IMJDOMFMBGH OPGLNBCACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private MonoBehaviour MGABPIINBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Action AEDPMLPENPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Action<float> NJDHHHDDHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private FKCMFGAFJFA PGPJEOCIBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float PJEIILGDGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool EIHELKBOHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly GNILGMCMPBL NEELIDMCIKP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D860", Offset = "0x4F8CC60", VA = "0x184F8D860")]
	public AFHBKNHIIHC(MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D620", Offset = "0x4F8CA20", VA = "0x184F8D620")]
	public AFHBKNHIIHC(MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D3D0", Offset = "0x4F8C7D0", VA = "0x184F8D3D0")]
	public AFHBKNHIIHC(MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3F27090", Offset = "0x3F26490", VA = "0x183F27090")]
	private AFHBKNHIIHC(GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D2B0", Offset = "0x4F8C6B0", VA = "0x184F8D2B0")]
	internal static AFHBKNHIIHC OODIOHNFCAJ(MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C8C0", Offset = "0x4F8BCC0", VA = "0x184F8C8C0")]
	private void DJMBMMHGNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CFC0", Offset = "0x4F8C3C0", VA = "0x184F8CFC0")]
	private void KJOOPNPEOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CC60", Offset = "0x4F8C060", VA = "0x184F8CC60")]
	private void GOBNDPNPDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CA90", Offset = "0x4F8BE90", VA = "0x184F8CA90")]
	private void FJAMNNPGNJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F8D170", Offset = "0x4F8C570", VA = "0x184F8D170")]
	private void MHMKAIPDOJM(string FOMNCGOADBK, Action NMHGNPHMPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CEA0", Offset = "0x4F8C2A0", VA = "0x184F8CEA0")]
	[IteratorStateMachine(typeof(GCDBMOAMOFE))]
	private IEnumerator<PHFLFKPMCCG> JENOLKCOLPF(Action NMHGNPHMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CA30", Offset = "0x4F8BE30", VA = "0x184F8CA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C7A0", Offset = "0x4F8BBA0", VA = "0x184F8C7A0")]
	[CompilerGenerated]
	private void AJPDBFJDMBK(string ONGNPCCGCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C830", Offset = "0x4F8BC30", VA = "0x184F8C830")]
	[CompilerGenerated]
	private void BJJNIAEADNA(string ONGNPCCGCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CE10", Offset = "0x4F8C210", VA = "0x184F8CE10")]
	[CompilerGenerated]
	private void IEIBJEFMKLN(string ONGNPCCGCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CF30", Offset = "0x4F8C330", VA = "0x184F8CF30")]
	[CompilerGenerated]
	private void JMPAJGCMHNC(string ONGNPCCGCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct PFLAHEPLPML : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[ReadOnly]
	public float ABDPIDJLMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	public int CGFKEHNLKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private NativeArray<int> DEJPFAGCKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NativeArray<int> GBOAMPNGMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private NativeArray<int> DMCGGAFGBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	public NativeArray<ENGLDNGGJBP> ODGPDDNBMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	public NativeArray<float> FJBPCCBOLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[WriteOnly]
	public NativeArray<int> JIFCAAMCGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[WriteOnly]
	public NativeArray<int> GMHAMNAEHJG;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5350", Offset = "0x4FA4750", VA = "0x184FA5350")]
	public static PFLAHEPLPML DEDAFMGEJMH(int KDKKGGDLPDE, float OMPNLCOODHC, NativeArray<ENGLDNGGJBP> CGFJPCFJOEH, NativeArray<float> GOOADJKDNPC, NativeArray<int> KADJGDOMONL, NativeArray<int> BEBFDFNIKGD, NativeArray<int> NAKHHLGFGJH, NativeArray<int> GBOAMPNGMFK, NativeArray<int> DMCGGAFGBIA)
	{
		return default(PFLAHEPLPML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5400", Offset = "0x4FA4800", VA = "0x184FA5400", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5540", Offset = "0x4FA4940", VA = "0x184FA5540")]
	private bool LGCOLAOBDEP(int BNOAGGNAMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5320", Offset = "0x4FA4720", VA = "0x184FA5320")]
	private void CLDJHNAKHGD(NativeArray<int> FFNMGNFHKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4FA54E0", Offset = "0x4FA48E0", VA = "0x184FA54E0")]
	private int GIKDIFCILCL(int NJMFFFAHPDD, int JIPCNJLKEGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5580", Offset = "0x4FA4980", VA = "0x184FA5580")]
	private void NGELNOILPAC(NativeArray<int> FFNMGNFHKCF, int MNCBPLLFEKH, int OEMJPJIELLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5650", Offset = "0x4FA4A50", VA = "0x184FA5650")]
	private void NJPLPNOPEBJ(NativeArray<int> FFNMGNFHKCF, int BAMCFCOKDHD, int FPOGEHHBJOE, int CCJDEKJEFPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class OFMBOCGBLOC : BIDHKPHPMOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float PCKLILPPPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly int KOOGPIGEKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly float GDAKLLOPOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly float[] KLFPAGHGDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int DIDHMGLFGDE;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4FA49E0", Offset = "0x4FA3DE0", VA = "0x184FA49E0")]
	public OFMBOCGBLOC(Behaviour AKPCLGIGABA, float AGAFNBEEEGP, int KOOGPIGEKHC, [Optional] Action CIEMLGBJJHG, float GDAKLLOPOEO = 0f, [Optional] GNILGMCMPBL NEELIDMCIKP, [Optional] GGDNLKAAGIA PCKLAENDCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "9")]
	protected override bool AACEJCPJLBK(Action NDPBOAHDPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4FA47B0", Offset = "0x4FA3BB0", VA = "0x184FA47B0", Slot = "10")]
	protected override bool JIOMPJJHBGJ(Action NDPBOAHDPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4720", Offset = "0x4FA3B20", VA = "0x184FA4720")]
	private void DMFCEAIJANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class PKAGDIIGMKK : GNILGMCMPBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly AGAJJBLMBLJ OBNKFPBIDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly GGDNLKAAGIA PCKLAENDCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BIHAMLJJHFP[] HDGOEDAKAFO;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static GNILGMCMPBL FNGGPKJOCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4FA6B30", Offset = "0x4FA5F30", VA = "0x184FA6B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool HPOMJOMGINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public FKCMFGAFJFA LMKAIFJLFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FKCMFGAFJFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9C1170", Offset = "0x9C0570", VA = "0x1809C1170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GGDNLKAAGIA BGAIFEJMMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PHFLFKPMCCG GHNENNOGOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6A70", Offset = "0x4FA5E70", VA = "0x184FA6A70")]
	public static IMJDOMFMBGH JEPEMFJBPHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6C60", Offset = "0x4FA6060", VA = "0x184FA6C60")]
	[Preserve]
	protected PKAGDIIGMKK([JLJFOFICIEA(null)] AGAJJBLMBLJ OBNKFPBIDIP, [JLJFOFICIEA(null)] GGDNLKAAGIA PCKLAENDCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6550", Offset = "0x4FA5950", VA = "0x184FA6550", Slot = "6")]
	public IMJDOMFMBGH FOLFCGOHDPG(IEnumerator<PHFLFKPMCCG> ADPDBKOGJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6320", Offset = "0x4FA5720", VA = "0x184FA6320", Slot = "7")]
	public IMJDOMFMBGH FOLFCGOHDPG(Behaviour AKPCLGIGABA, IEnumerator<PHFLFKPMCCG> ADPDBKOGJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract IMJDOMFMBGH PEOKOBJNOJG(GAEFMEGEODI AKPCLGIGABA, IEnumerator<PHFLFKPMCCG> ADPDBKOGJKA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6830", Offset = "0x4FA5C30", VA = "0x184FA6830", Slot = "17")]
	public virtual void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4FA67D0", Offset = "0x4FA5BD0", VA = "0x184FA67D0", Slot = "9")]
	public void HBGICMFFECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4FA67B0", Offset = "0x4FA5BB0", VA = "0x184FA67B0", Slot = "18")]
	protected virtual void GLINDFMMGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6560", Offset = "0x4FA5960", VA = "0x184FA6560")]
	private void GGDGLNBFJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6B80", Offset = "0x4FA5F80", VA = "0x184FA6B80")]
	private void OIBAABMILIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5D20", Offset = "0x4FA5120", VA = "0x184FA5D20")]
	private void BKGCCEADAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6BA0", Offset = "0x4FA5FA0", VA = "0x184FA6BA0")]
	private void OJDMEHEMBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6300", Offset = "0x4FA5700", VA = "0x184FA6300")]
	private void FFMPNGBHBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6B10", Offset = "0x4FA5F10", VA = "0x184FA6B10")]
	private void JGHFMAHPCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6BC0", Offset = "0x4FA5FC0", VA = "0x184FA6BC0")]
	private void PJAKGCLFPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4FA60C0", Offset = "0x4FA54C0", VA = "0x184FA60C0", Slot = "19")]
	public virtual void EPJGJBHCAIA(FKCMFGAFJFA PGPJEOCIBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6580", Offset = "0x4FA5980", VA = "0x184FA6580")]
	private void GHPCBOLNDKA(BIHAMLJJHFP JIPLIBIIAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A651C0", Offset = "0x2A645C0", VA = "0x182A651C0")]
	private BIHAMLJJHFP HAPHFKOMPME(FKCMFGAFJFA GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract IOKPLBKKMNP CBBOAEMHBJI(IEnumerator<PHFLFKPMCCG> ADPDBKOGJKA, Behaviour MGABPIINBEH, PNFIHELELEM NOPCEJJFAEG);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract BIHAMLJJHFP OIDECIHAIPI(FKCMFGAFJFA PGPJEOCIBPN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4FA5D40", Offset = "0x4FA5140", VA = "0x184FA5D40", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6A10", Offset = "0x4FA5E10", VA = "0x184FA6A10", Slot = "12")]
	public PHFLFKPMCCG IPBKIPAPCGD(FKCMFGAFJFA CLAOAKAOJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6BE0", Offset = "0x4FA5FE0", VA = "0x184FA6BE0", Slot = "13")]
	public PHFLFKPMCCG PLLBGNHCBCI(float KEGCBGNJKBP, FKCMFGAFJFA CLAOAKAOJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6750", Offset = "0x4FA5B50", VA = "0x184FA6750", Slot = "14")]
	public PHFLFKPMCCG GKDOMIENOLH(Func<bool> IGGOFNKLKDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class AKDIOKFEJKL : PKAGDIIGMKK, GNILGMCMPBL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private GBPFJDMDCJO[] HBGDONFGMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private FHGFGFBEPGL BINPAJCFJIM;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E7F0", Offset = "0x4F8DBF0", VA = "0x184F8E7F0")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4F8EB80", Offset = "0x4F8DF80", VA = "0x184F8EB80")]
	[Preserve]
	public AKDIOKFEJKL([JLJFOFICIEA(null)] AGAJJBLMBLJ OBNKFPBIDIP, [JLJFOFICIEA(null)] GGDNLKAAGIA PCKLAENDCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4F8EA30", Offset = "0x4F8DE30", VA = "0x184F8EA30", Slot = "16")]
	public override IMJDOMFMBGH PEOKOBJNOJG(GAEFMEGEODI AKPCLGIGABA, IEnumerator<PHFLFKPMCCG> ADPDBKOGJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E520", Offset = "0x4F8D920", VA = "0x184F8E520", Slot = "17")]
	public override void IKCBOKMOGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E270", Offset = "0x4F8D670", VA = "0x184F8E270", Slot = "19")]
	public override void EPJGJBHCAIA(FKCMFGAFJFA PGPJEOCIBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E440", Offset = "0x4F8D840", VA = "0x184F8E440", Slot = "18")]
	protected override void GLINDFMMGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E980", Offset = "0x4F8DD80", VA = "0x184F8E980")]
	private GBPFJDMDCJO NHJAJONGJJF(FKCMFGAFJFA GANFKPHKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E090", Offset = "0x4F8D490", VA = "0x184F8E090", Slot = "20")]
	internal override IOKPLBKKMNP CBBOAEMHBJI(IEnumerator<PHFLFKPMCCG> ADPDBKOGJKA, Behaviour AKPCLGIGABA, PNFIHELELEM LNIBEAPDNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E9C0", Offset = "0x4F8DDC0", VA = "0x184F8E9C0", Slot = "21")]
	internal override BIHAMLJJHFP OIDECIHAIPI(FKCMFGAFJFA CLAOAKAOJHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E860", Offset = "0x4F8DC60", VA = "0x184F8E860")]
	private void NEBFFPFFCHM(GBPFJDMDCJO JIPLIBIIAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E200", Offset = "0x4F8D600", VA = "0x184F8E200", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HNOEHABEPIA
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class KGDKKBEICCM : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public FKCMFGAFJFA queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public KGDKKBEICCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2250", Offset = "0x4FA1650", VA = "0x184FA2250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2300", Offset = "0x4FA1700", VA = "0x184FA2300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D8D0", Offset = "0x4F9CCD0", VA = "0x184F9D8D0")]
	[IteratorStateMachine(typeof(KGDKKBEICCM))]
	private static IEnumerator<PHFLFKPMCCG> DBGPMCCFONG(FKCMFGAFJFA PGPJEOCIBPN, Func<bool> IGGOFNKLKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D950", Offset = "0x4F9CD50", VA = "0x184F9D950")]
	public static IMJDOMFMBGH LNOGLMLIIFN(this MonoBehaviour MGABPIINBEH, Func<bool> IGGOFNKLKDD, FKCMFGAFJFA PGPJEOCIBPN = FKCMFGAFJFA.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class IOKPLBKKMNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly PNFIHELELEM LNIBEAPDNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly KGIGGMKOAEI AKPCLGIGABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly bool MDGKCFEPCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private string GDKOBCHHFLB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IEnumerator<PHFLFKPMCCG> NGOEMJMCNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public PHFLFKPMCCG FADPAJAFJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FBCPPCFJKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4F9DF70", Offset = "0x4F9D370", VA = "0x184F9DF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CBAGJMOJMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xADC6C0", Offset = "0xADBAC0", VA = "0x180ADC6C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xE422B0", Offset = "0xE416B0", VA = "0x180E422B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4F9DB60", Offset = "0x4F9CF60", VA = "0x184F9DB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float GCEFBMHNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xC2F780", Offset = "0xC2EB80", VA = "0x180C2F780")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xDB7A00", Offset = "0xDB6E00", VA = "0x180DB7A00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4F9E0D0", Offset = "0x4F9D4D0", VA = "0x184F9E0D0")]
	public IOKPLBKKMNP(IEnumerator<PHFLFKPMCCG> AFALHKHMMCP, KGIGGMKOAEI AKPCLGIGABA, PNFIHELELEM LNIBEAPDNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4F9DCE0", Offset = "0x4F9D0E0", VA = "0x184F9DCE0")]
	public PHFLFKPMCCG OKCEHAOBHAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4F9DAE0", Offset = "0x4F9CEE0", VA = "0x184F9DAE0")]
	public bool KNOJBNGFJCM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4F9DA60", Offset = "0x4F9CE60", VA = "0x184F9DA60")]
	public void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4F9DFF0", Offset = "0x4F9D3F0", VA = "0x184F9DFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xED9280", Offset = "0xED8680", VA = "0x180ED9280")]
	[CompilerGenerated]
	private void HOBILDDADCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AGNPDKOCFEB
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class HCKFEGDDHDD : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public KMAJPHOAMBK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public FKCMFGAFJFA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public HCKFEGDDHDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4F9CB60", Offset = "0x4F9BF60", VA = "0x184F9CB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4F9CC00", Offset = "0x4F9C000", VA = "0x184F9CC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DA60", Offset = "0x4F8CE60", VA = "0x184F8DA60")]
	public static IMJDOMFMBGH DJMBMMHGNLG(float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DB60", Offset = "0x4F8CF60", VA = "0x184F8DB60")]
	public static IMJDOMFMBGH DJMBMMHGNLG(MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DC70", Offset = "0x4F8D070", VA = "0x184F8DC70")]
	public static IMJDOMFMBGH HHEPMHGCNBA(MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DE40", Offset = "0x4F8D240", VA = "0x184F8DE40")]
	public static IMJDOMFMBGH IEDIJGIOHNN(GAEFMEGEODI AKPCLGIGABA, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DD90", Offset = "0x4F8D190", VA = "0x184F8DD90")]
	private static IEnumerator<PHFLFKPMCCG> ICAMFGHPHKF(GGDNLKAAGIA PCKLAENDCOP, float OEGACPCCMBB, FKCMFGAFJFA CLAOAKAOJHH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DF50", Offset = "0x4F8D350", VA = "0x184F8DF50")]
	private static IEnumerator<PHFLFKPMCCG> LBNCBGNMKLF(GGDNLKAAGIA PCKLAENDCOP, float OEGACPCCMBB, FKCMFGAFJFA CLAOAKAOJHH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DFB0", Offset = "0x4F8D3B0", VA = "0x184F8DFB0")]
	[IteratorStateMachine(typeof(HCKFEGDDHDD))]
	private static IEnumerator<PHFLFKPMCCG> MANGIIOMFGA(KMAJPHOAMBK JALDPMDAICL, float OEGACPCCMBB, FKCMFGAFJFA CLAOAKAOJHH, Action<float> AEDPMLPENPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface EFLLKKBCPLH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool FECJCDLPFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action OABEIAKJBFJ;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JAJINCCLAAE(bool DGLCECEILBL = false);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JAJINCCLAAE(Action NDPBOAHDPLI, bool DGLCECEILBL = false);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AFGHBCBALAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly AFGHBCBALAD AOKDNNAFLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Action FANNNKENAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool IAEKIDJDAJF;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA02820", Offset = "0xA01C20", VA = "0x180A02820")]
	public AFGHBCBALAD(Action FANNNKENAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C680", Offset = "0x4F8BA80", VA = "0x184F8C680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JLCKNMGOCFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	T EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable AJGCNKPNGFK(UnityEngine.Object AKPCLGIGABA, Action<T> MDCMAMGPIPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface KICDEBFLHGF<T> : JLCKNMGOCFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	new T EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NBGDEHKIBLG<T> : KICDEBFLHGF<T>, JLCKNMGOCFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class POGMPMDDGOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NBGDEHKIBLG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public HJGJDPGFLKA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public POGMPMDDGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x244AA30", Offset = "0x2449E30", VA = "0x18244AA30")]
		internal void EHKIBKGDLMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static GameObject PNDCDICLJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly List<HJGJDPGFLKA<UnityEngine.Object, Action<T>>> CJBKNJIACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private T OPPHNHJJPEA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xE19CC0", Offset = "0xE190C0", VA = "0x180E19CC0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1D40BF0", Offset = "0x1D3FFF0", VA = "0x181D40BF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1D40C50", Offset = "0x1D40050", VA = "0x181D40C50")]
	private static bool MFDFFJEOFII(T NPBBJPKPNCJ, T KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1D40CC0", Offset = "0x1D400C0", VA = "0x181D40CC0")]
	public NBGDEHKIBLG(T MKIGOCDJLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1D40710", Offset = "0x1D3FB10", VA = "0x181D40710", Slot = "6")]
	public IDisposable AJGCNKPNGFK(UnityEngine.Object AKPCLGIGABA, Action<T> MDCMAMGPIPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1D40880", Offset = "0x1D3FC80", VA = "0x181D40880")]
	private void HAONOPFBKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface FHGFGFBEPGL
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEONNLBJNBN(string GDKOBCHHFLB);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCLMFPHHMGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class NADHHMGGGAH : FHGFGFBEPGL
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void DEONNLBJNBN(string GDKOBCHHFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void NCLMFPHHMGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public NADHHMGGGAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LDKDMMNBJKH : BIDHKPHPMOH
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AJNKDMGCLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public LDKDMMNBJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AJNKDMGCLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4F8E060", Offset = "0x4F8D460", VA = "0x184F8E060")]
		internal void JNADOFLJINB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class JKCOBOMHOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public LDKDMMNBJKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JKCOBOMHOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4F8E060", Offset = "0x4F8D460", VA = "0x184F8E060")]
		internal void ICCAOCDEPGN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly float FJOHAEAMNMA;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3080", Offset = "0x4FA2480", VA = "0x184FA3080")]
	public LDKDMMNBJKH(Behaviour AKPCLGIGABA, float FJOHAEAMNMA, [Optional] Action CIEMLGBJJHG, [Optional] GNILGMCMPBL NEELIDMCIKP, [Optional] GGDNLKAAGIA PCKLAENDCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2E80", Offset = "0x4FA2280", VA = "0x184FA2E80", Slot = "9")]
	protected override bool AACEJCPJLBK(Action NDPBOAHDPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2F80", Offset = "0x4FA2380", VA = "0x184FA2F80", Slot = "10")]
	protected override bool JIOMPJJHBGJ(Action NDPBOAHDPLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class FGBJHKBJHLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GBHMPGBPMPJ : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public FGBJHKBJHLL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public GBHMPGBPMPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4F99B50", Offset = "0x4F98F50", VA = "0x184F99B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4F99BC0", Offset = "0x4F98FC0", VA = "0x184F99BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private IMJDOMFMBGH OPGLNBCACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private GAEFMEGEODI AKPCLGIGABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Action<float> NJDHHHDDHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private FKCMFGAFJFA PGPJEOCIBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float PJEIILGDGLK;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4F990B0", Offset = "0x4F984B0", VA = "0x184F990B0")]
	public FGBJHKBJHLL(GAEFMEGEODI AKPCLGIGABA, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4F98B30", Offset = "0x4F97F30", VA = "0x184F98B30")]
	private void GOBNDPNPDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x4F98F30", Offset = "0x4F98330", VA = "0x184F98F30")]
	private void MHMKAIPDOJM(string FOMNCGOADBK, Action NMHGNPHMPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4F98CE0", Offset = "0x4F980E0", VA = "0x184F98CE0")]
	[IteratorStateMachine(typeof(GBHMPGBPMPJ))]
	private IEnumerator<PHFLFKPMCCG> JENOLKCOLPF(Action NMHGNPHMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4F98AD0", Offset = "0x4F97ED0", VA = "0x184F98AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4F98D70", Offset = "0x4F98170", VA = "0x184F98D70")]
	[CompilerGenerated]
	private void MEPFNCAHNKL(string ONGNPCCGCCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GBPFJDMDCJO
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct NCPKNDEFPHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public EALEELONICB EOHAHOHFEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GAEFMEGEODI IKLENBPEBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PNFIHELELEM BLNJACJPPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public IEnumerator<PHFLFKPMCCG> NGOEMJMCNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public PHFLFKPMCCG FADPAJAFJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public ENGLDNGGJBP JGCOJIDDEBH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct MBOPKLAFGEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public FKCMFGAFJFA LIJGIIGOJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public List<NCPKNDEFPHM> LGGGJACNAOO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class JEEIIELHKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public PNFIHELELEM promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public GBPFJDMDCJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public GAEFMEGEODI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public EALEELONICB routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ENGLDNGGJBP coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public PHFLFKPMCCG currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public IEnumerator<PHFLFKPMCCG> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JEEIIELHKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4F9FCD0", Offset = "0x4F9F0D0", VA = "0x184F9FCD0")]
		internal void DKMLHOMPJHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class CFPNMMHHHHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public EALEELONICB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public GBPFJDMDCJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CFPNMMHHHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4F91FB0", Offset = "0x4F913B0", VA = "0x184F91FB0")]
		internal void NNPMFPBIPNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class PPFOFLLIILH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public EALEELONICB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public GBPFJDMDCJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PPFOFLLIILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7170", Offset = "0x4FA6570", VA = "0x184FA7170")]
		internal void EGMPBKEFMLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class FOJGKMGKDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public EALEELONICB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public GBPFJDMDCJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FOJGKMGKDML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4F99710", Offset = "0x4F98B10", VA = "0x184F99710")]
		internal void ICJBIODHDCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const ENGLDNGGJBP KOJDHNCKKOJ = ENGLDNGGJBP.Cancelled | ENGLDNGGJBP.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FKCMFGAFJFA PGPJEOCIBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool[] NPOGHGNOABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<ENGLDNGGJBP> JLGIAEKHNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<float> GNNAHFLKHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> GMHAMNAEHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private NativeArray<int> EFOHGEBDGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private NativeArray<int> JIFCAAMCGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<int> ACIMDFPAFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<int> CGBJDMBJAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EALEELONICB[] FDJNMHFEDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private PNFIHELELEM[] CMLFOBENEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private GAEFMEGEODI[] NCLBDKPCIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private IEnumerator<PHFLFKPMCCG>[] HMMMBCIBMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private PHFLFKPMCCG[] OKNMLCDGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int LDKJGADAIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int GLDHDJHPIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly int HKCLKEPCHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float OPPLONLKNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private PFLAHEPLPML DEIFIDNDNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private JobHandle NDJHPAHDMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private List<EALEELONICB> JCNDLGDKBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private bool FPHIKAMPMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private List<Action> BLENKBJNOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private List<Action> KEIOPIACBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private bool BOAHPEOCPNL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MBOPKLAFGEP[] LBINLDHGNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xC2F790", Offset = "0xC2EB90", VA = "0x180C2F790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BF70", Offset = "0x4F9B370", VA = "0x184F9BF70")]
	private static int ONOHKGKJECP(FKCMFGAFJFA PGPJEOCIBPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BFA0", Offset = "0x4F9B3A0", VA = "0x184F9BFA0")]
	public GBPFJDMDCJO(FKCMFGAFJFA PGPJEOCIBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4F99E00", Offset = "0x4F99200", VA = "0x184F99E00")]
	private void BKNGMGKJOPD(ref int LEBMKHACLPM, int ILJAKNJOLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4F9AE10", Offset = "0x4F9A210", VA = "0x184F9AE10")]
	public void GDBJCNOLOJJ(GAEFMEGEODI AKPCLGIGABA, PHFLFKPMCCG KIGGHHBBENP, IEnumerator<PHFLFKPMCCG> AFALHKHMMCP, PNFIHELELEM LNIBEAPDNEC, [Optional] EALEELONICB BOBPIMDPBKD, ENGLDNGGJBP CKIMNBGKMPH = ENGLDNGGJBP.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9BD90", Offset = "0x4F9B190", VA = "0x184F9BD90")]
	public void ONBMGKENJDO(IEnumerable<NCPKNDEFPHM> OJPHHPEBPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B830", Offset = "0x4F9AC30", VA = "0x184F9B830")]
	private NCPKNDEFPHM MKGNMIJAENI(int KPEFMFLFLPF)
	{
		return default(NCPKNDEFPHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B250", Offset = "0x4F9A650", VA = "0x184F9B250")]
	private void HJPJJCPPEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x16D53A0", Offset = "0x16D47A0", VA = "0x1816D53A0")]
	private static void GCGCPIDKAME<T>(int KPEFMFLFLPF, T[] IBNKPKKKHBO, int AJCINIIEJAJ, [Optional] T OFDNELAMJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x16D5380", Offset = "0x16D4780", VA = "0x1816D5380")]
	private static void GCGCPIDKAME<T>(int KPEFMFLFLPF, NativeArray<T> IBNKPKKKHBO, int AJCINIIEJAJ, [Optional] T OFDNELAMJOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4F99FF0", Offset = "0x4F993F0", VA = "0x184F99FF0")]
	private void CEPBFDMGGHO(IEnumerable<NCPKNDEFPHM> OJPHHPEBPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4F99C00", Offset = "0x4F99000", VA = "0x184F99C00")]
	private void BENLHAECGAN(NCPKNDEFPHM HFGKDLMOPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4F9AF90", Offset = "0x4F9A390", VA = "0x184F9AF90")]
	private CGOGKJKIEAM HFGCCGHKMIE(int CANGLGBHMCG)
	{
		return default(CGOGKJKIEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A2C0", Offset = "0x4F996C0", VA = "0x184F9A2C0")]
	public void DABOEFAJLOD(float OMPNLCOODHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4F9AC60", Offset = "0x4F9A060", VA = "0x184F9AC60")]
	private void EFGJPPLOBCG(Action NPBBJPKPNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4F9ABE0", Offset = "0x4F99FE0", VA = "0x184F9ABE0")]
	private void EDBABGELDBN(Action NPBBJPKPNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4F9A4A0", Offset = "0x4F998A0", VA = "0x184F9A4A0")]
	public void ECNJNLBMGEN(float OMPNLCOODHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B600", Offset = "0x4F9AA00", VA = "0x184F9B600")]
	public void KAEENGGDABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4F9ACE0", Offset = "0x4F9A0E0", VA = "0x184F9ACE0")]
	public void EIFJDOAKCLM(EALEELONICB JALDPMDAICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9B700", Offset = "0x4F9AB00", VA = "0x184F9B700")]
	public void LBMFAMHHCPE(EALEELONICB JALDPMDAICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4F99CD0", Offset = "0x4F990D0", VA = "0x184F99CD0")]
	public void BJBPHJFMGEP(EALEELONICB JALDPMDAICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HNNAHMCPIDH : EFLLKKBCPLH, IEnumerable<EFLLKKBCPLH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<EFLLKKBCPLH> BPHMCOOCDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool ELONDDDDHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Action CIEMLGBJJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private bool HCMIJAHIFAC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FECJCDLPFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D4B0", Offset = "0x4F9C8B0", VA = "0x184F9D4B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OABEIAKJBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D710", Offset = "0x4F9CB10", VA = "0x184F9D710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4F9D410", Offset = "0x4F9C810", VA = "0x184F9D410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D830", Offset = "0x4F9CC30", VA = "0x184F9D830")]
	public HNNAHMCPIDH([Optional] Action CIEMLGBJJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D5F0", Offset = "0x4F9C9F0", VA = "0x184F9D5F0")]
	public void NNFBEGDMHOD(EFLLKKBCPLH IMADIPFAPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4F9CF30", Offset = "0x4F9C330", VA = "0x184F9CF30")]
	private void GBEFIHBDDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D110", Offset = "0x4F9C510", VA = "0x184F9D110", Slot = "7")]
	public bool JAJINCCLAAE(bool DGLCECEILBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D130", Offset = "0x4F9C530", VA = "0x184F9D130", Slot = "8")]
	public bool JAJINCCLAAE(Action NDPBOAHDPLI, bool DGLCECEILBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D090", Offset = "0x4F9C490", VA = "0x184F9D090", Slot = "9")]
	public IEnumerator<EFLLKKBCPLH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D7B0", Offset = "0x4F9CBB0", VA = "0x184F9D7B0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class BIDHKPHPMOH : EFLLKKBCPLH
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KEDLDIHJAIH : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public BIDHKPHPMOH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public KEDLDIHJAIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2140", Offset = "0x4FA1540", VA = "0x184FA2140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4FA2210", Offset = "0x4FA1610", VA = "0x184FA2210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly Behaviour AKPCLGIGABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Action CIEMLGBJJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private PMFPAFFNEKC DNGPKHIEMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly GNILGMCMPBL NEELIDMCIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	protected readonly GGDNLKAAGIA PCKLAENDCOP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FECJCDLPFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x19B5F70", Offset = "0x19B5370", VA = "0x1819B5F70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OABEIAKJBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4F90470", Offset = "0x4F8F870", VA = "0x184F90470", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4F903B0", Offset = "0x4F8F7B0", VA = "0x184F903B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F90510", Offset = "0x4F8F910", VA = "0x184F90510")]
	protected BIDHKPHPMOH(Behaviour AKPCLGIGABA, [Optional] Action CIEMLGBJJHG, [Optional] GNILGMCMPBL NEELIDMCIKP, [Optional] GGDNLKAAGIA PCKLAENDCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F90300", Offset = "0x4F8F700", VA = "0x184F90300", Slot = "7")]
	public bool JAJINCCLAAE(bool DGLCECEILBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F90360", Offset = "0x4F8F760", VA = "0x184F90360", Slot = "8")]
	public bool JAJINCCLAAE(Action NDPBOAHDPLI, bool DGLCECEILBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool AACEJCPJLBK(Action NDPBOAHDPLI);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JIOMPJJHBGJ(Action NDPBOAHDPLI);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F90450", Offset = "0x4F8F850", VA = "0x184F90450")]
	protected void OMMNJCCIAPO(Action NDPBOAHDPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4F8FFC0", Offset = "0x4F8F3C0", VA = "0x184F8FFC0")]
	protected LMHNGLGIJDH BMAFDJBJENN(float EOHBELFFLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4F90200", Offset = "0x4F8F600", VA = "0x184F90200")]
	private void DILAGINJFCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x4F90280", Offset = "0x4F8F680", VA = "0x184F90280")]
	[IteratorStateMachine(typeof(KEDLDIHJAIH))]
	private IEnumerator<PHFLFKPMCCG> IGFODMIBJHJ(float EOHBELFFLLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4F901C0", Offset = "0x4F8F5C0", VA = "0x184F901C0")]
	[CompilerGenerated]
	private void CFJEPHJBIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
internal enum ENGLDNGGJBP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class EALEELONICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public GBPFJDMDCJO NCMLDIKGIPF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9C1170", Offset = "0x9C0570", VA = "0x1809C1170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4F981B0", Offset = "0x4F975B0", VA = "0x184F981B0")]
	public static PHFLFKPMCCG OKCEHAOBHAJ(IEnumerator<PHFLFKPMCCG> AFALHKHMMCP, PNFIHELELEM LNIBEAPDNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4F980D0", Offset = "0x4F974D0", VA = "0x184F980D0")]
	public PHFLFKPMCCG OKCEHAOBHAJ(PNFIHELELEM[] CMLFOBENEPL, IEnumerator<PHFLFKPMCCG>[] DIIIFCELLKC, PHFLFKPMCCG[] EKKBDEOLDGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4F980A0", Offset = "0x4F974A0", VA = "0x184F980A0")]
	public void EHFJBFLKBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4F97F60", Offset = "0x4F97360", VA = "0x184F97F60")]
	public void EGIFDNLNPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4F97E20", Offset = "0x4F97220", VA = "0x184F97E20")]
	public void BCPMAIFPKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4F980A0", Offset = "0x4F974A0", VA = "0x184F980A0")]
	public void EIFJDOAKCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public EALEELONICB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class GANGODLBBDF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BBFMADJJJBB : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public GANGODLBBDF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public BBFMADJJJBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F500", Offset = "0x4F8E900", VA = "0x184F8F500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F590", Offset = "0x4F8E990", VA = "0x184F8F590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly FKCMFGAFJFA PGPJEOCIBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Action EAJADFEIADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool DKCFCCEDAMB;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool CEFOKEMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5070", Offset = "0x8C4470", VA = "0x1808C5070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4F99A50", Offset = "0x4F98E50", VA = "0x184F99A50")]
	public GANGODLBBDF(FKCMFGAFJFA PGPJEOCIBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4F99960", Offset = "0x4F98D60", VA = "0x184F99960")]
	[IteratorStateMachine(typeof(BBFMADJJJBB))]
	private IEnumerator<PHFLFKPMCCG> FPDNDJGEIIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4F999D0", Offset = "0x4F98DD0", VA = "0x184F999D0", Slot = "4")]
	public void OnCompleted(Action MCFPIEIMKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public void PAABFEFEGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class GLHEBGLGPOG
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C5F0", Offset = "0x4F9B9F0", VA = "0x184F9C5F0")]
	public static GANGODLBBDF OHPNENBCPKD(this FKCMFGAFJFA PGPJEOCIBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class MEODIBHDPBM : CCNELKHLPDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly GNILGMCMPBL NEELIDMCIKP;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3630", Offset = "0x4FA2A30", VA = "0x184FA3630")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	[Preserve]
	internal MEODIBHDPBM([JLJFOFICIEA(null)] GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3590", Offset = "0x4FA2990", VA = "0x184FA3590", Slot = "4")]
	public IDisposable FKKBCKLJHDG(float OEGACPCCMBB, Action<float> IPDGCBIIEII, bool EIHELKBOHHB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum CGOGKJKIEAM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class BIHAMLJJHFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum MOCEJDODCOB
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct BMKBJOCGCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public FKCMFGAFJFA LIJGIIGOJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public MOCEJDODCOB IKHNLGCFFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public List<IOKPLBKKMNP> FKANPINLADO;
	}

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly MOCEJDODCOB[] FDCBILIGCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly FKCMFGAFJFA PGPJEOCIBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private bool BCHFDFHLOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly IOKPLBKKMNP[] OEHGABDJDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly List<IOKPLBKKMNP> AAAMHAHHHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly Stack<int> AABEBLIBPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly List<IOKPLBKKMNP> ECDKMBHKMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Stack<int> PMIFPMIKNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly FHGFGFBEPGL NPDBCCKKGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool BOAHPEOCPNL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BMKBJOCGCAO[,] APHOCLNFFHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F91AE0", Offset = "0x4F90EE0", VA = "0x184F91AE0")]
	public BIHAMLJJHFP(FKCMFGAFJFA CLAOAKAOJHH, FHGFGFBEPGL NPDBCCKKGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F913E0", Offset = "0x4F907E0", VA = "0x184F913E0")]
	public void LAJFMCLNJML(IOKPLBKKMNP AFALHKHMMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F91110", Offset = "0x4F90510", VA = "0x184F91110")]
	public void KGHEHJEPFJA(IList<IOKPLBKKMNP> DIIIFCELLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F90610", Offset = "0x4F8FA10", VA = "0x184F90610")]
	public void ACDCOCOGAKC(IList<IOKPLBKKMNP> DIIIFCELLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F908E0", Offset = "0x4F8FCE0", VA = "0x184F908E0")]
	private void AHGDEFAFGDE(IOKPLBKKMNP AFALHKHMMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4F91840", Offset = "0x4F90C40", VA = "0x184F91840")]
	private void PDLHAPOJOHI(IList<IOKPLBKKMNP> DIIIFCELLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4F90B20", Offset = "0x4F8FF20", VA = "0x184F90B20")]
	private CGOGKJKIEAM FLGENFCEMPK(IOKPLBKKMNP AFALHKHMMCP)
	{
		return default(CGOGKJKIEAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4F90C80", Offset = "0x4F90080", VA = "0x184F90C80")]
	public void GLINDFMMGLK(float OMPNLCOODHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F90DD0", Offset = "0x4F901D0", VA = "0x184F90DD0")]
	public void HBGICMFFECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F91500", Offset = "0x4F90900", VA = "0x184F91500")]
	private void OEBDMCJPJKJ(List<IOKPLBKKMNP> DIIIFCELLKC, Stack<int> OLLDDKPHMLO, bool DNPFCJBKAHA, float DLILGGMJJAP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4F909E0", Offset = "0x4F8FDE0", VA = "0x184F909E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4F90FE0", Offset = "0x4F903E0", VA = "0x184F90FE0")]
	private void INALEHPOEPB(List<IOKPLBKKMNP> DIIIFCELLKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class AMNJBGPALDE : KGIGGMKOAEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly Behaviour MGABPIINBEH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F450", Offset = "0x4F8E850", VA = "0x184F8F450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool AOHMFPJGKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F3F0", Offset = "0x4F8E7F0", VA = "0x184F8F3F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ODECNMKDKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F4E0", Offset = "0x4F8E8E0", VA = "0x184F8F4E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public AMNJBGPALDE(Behaviour MGABPIINBEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class NPKPGKNOLIG : BIDHKPHPMOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly float FJOHAEAMNMA;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3080", Offset = "0x4FA2480", VA = "0x184FA3080")]
	public NPKPGKNOLIG(Behaviour AKPCLGIGABA, float FJOHAEAMNMA, [Optional] Action CIEMLGBJJHG, [Optional] GNILGMCMPBL NEELIDMCIKP, [Optional] GGDNLKAAGIA PCKLAENDCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "9")]
	protected override bool AACEJCPJLBK(Action NDPBOAHDPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4FA4350", Offset = "0x4FA3750", VA = "0x184FA4350", Slot = "10")]
	protected override bool JIOMPJJHBGJ(Action NDPBOAHDPLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class HBHNMFKDEPO
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F9CA60", Offset = "0x4F9BE60", VA = "0x184F9CA60")]
	public static IDisposable OAAGDKABJLG(this GAEFMEGEODI AKPCLGIGABA, float OEGACPCCMBB, Action<float> AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F9C9E0", Offset = "0x4F9BDE0", VA = "0x184F9C9E0")]
	public static IDisposable DGMCHOBLJFE(this GAEFMEGEODI AKPCLGIGABA, Action<float> AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F9CAE0", Offset = "0x4F9BEE0", VA = "0x184F9CAE0")]
	public static IDisposable PDFBEICEEMP(this GAEFMEGEODI AKPCLGIGABA, Action<float> AEDPMLPENPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class JLDGFPELNDH
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class LIKGMECIFDJ : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public FKCMFGAFJFA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private PHCJFBEGJDG <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public LIKGMECIFDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3240", Offset = "0x4FA2640", VA = "0x184FA3240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3310", Offset = "0x4FA2710", VA = "0x184FA3310", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class DKDJPHECKHA : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FKCMFGAFJFA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private PHCJFBEGJDG <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public DKDJPHECKHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4F97CF0", Offset = "0x4F970F0", VA = "0x184F97CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4F97DE0", Offset = "0x4F971E0", VA = "0x184F97DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0580", Offset = "0x4F9F980", VA = "0x184FA0580")]
	public static IMJDOMFMBGH DJMBMMHGNLG(Action AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4FA04C0", Offset = "0x4F9F8C0", VA = "0x184FA04C0")]
	public static IMJDOMFMBGH DJMBMMHGNLG(Behaviour AKPCLGIGABA, Action AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0630", Offset = "0x4F9FA30", VA = "0x184FA0630")]
	public static IMJDOMFMBGH DJMBMMHGNLG(Behaviour AKPCLGIGABA, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0740", Offset = "0x4F9FB40", VA = "0x184FA0740")]
	[IteratorStateMachine(typeof(LIKGMECIFDJ))]
	private static IEnumerator<PHFLFKPMCCG> ICAMFGHPHKF(FKCMFGAFJFA CLAOAKAOJHH, Action AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x4FA07C0", Offset = "0x4F9FBC0", VA = "0x184FA07C0")]
	[IteratorStateMachine(typeof(DKDJPHECKHA))]
	private static IEnumerator<PHFLFKPMCCG> ICAMFGHPHKF(FKCMFGAFJFA CLAOAKAOJHH, Action<float> AEDPMLPENPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public static class CNGMDGEMLON
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F92D90", Offset = "0x4F92190", VA = "0x184F92D90")]
	public static IDisposable DJMBMMHGNLG(this MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F92D10", Offset = "0x4F92110", VA = "0x184F92D10")]
	public static IDisposable DJMBMMHGNLG(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F92FE0", Offset = "0x4F923E0", VA = "0x184F92FE0")]
	public static IDisposable GLINDFMMGLK(this MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F92C90", Offset = "0x4F92090", VA = "0x184F92C90")]
	public static IDisposable BKGCCEADAFP(this MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4F934C0", Offset = "0x4F928C0", VA = "0x184F934C0")]
	public static IDisposable OJDMEHEMBJE(this MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F93050", Offset = "0x4F92450", VA = "0x184F93050")]
	public static IDisposable HAFCONHMIDE(this MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F933B0", Offset = "0x4F927B0", VA = "0x184F933B0")]
	public static IDisposable NFKNALDLKDL(this MonoBehaviour MGABPIINBEH, Action AEDPMLPENPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F92E10", Offset = "0x4F92210", VA = "0x184F92E10")]
	public static IDisposable EAMMEJJDFJP(this MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F930D0", Offset = "0x4F924D0", VA = "0x184F930D0")]
	public static IDisposable HFFMCHBPCCB(this MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, FKCMFGAFJFA PGPJEOCIBPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4F92F40", Offset = "0x4F92340", VA = "0x184F92F40")]
	public static IDisposable FKKBCKLJHDG(this MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4F931F0", Offset = "0x4F925F0", VA = "0x184F931F0")]
	public static IDisposable HONLIGBMCEM(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4F93320", Offset = "0x4F92720", VA = "0x184F93320")]
	public static IDisposable NDOAAKBBHKI(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4F93430", Offset = "0x4F92830", VA = "0x184F93430")]
	public static IDisposable NLKPLCENBCE(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4F92AE0", Offset = "0x4F91EE0", VA = "0x184F92AE0")]
	public static IDisposable AGEPEJEJJFE(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4F92C00", Offset = "0x4F92000", VA = "0x184F92C00")]
	public static IDisposable BGIOOGDNFHM(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4F92EB0", Offset = "0x4F922B0", VA = "0x184F92EB0")]
	public static IDisposable EJNDFAPLBHH(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4F92B70", Offset = "0x4F91F70", VA = "0x184F92B70")]
	public static IDisposable AMMEEFPLBIC(this MonoBehaviour MGABPIINBEH, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4F93280", Offset = "0x4F92680", VA = "0x184F93280")]
	public static IDisposable IHFMCCIGIKI(this MonoBehaviour MGABPIINBEH, float OEGACPCCMBB, Action<float> AEDPMLPENPN, bool EIHELKBOHHB = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class PNFIHELELEM : OMGHDDIPCMD, IMJDOMFMBGH, PMFPAFFNEKC, LMHNGLGIJDH, IEnumerator, PHFLFKPMCCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private FKCMFGAFJFA BDMCHKMHFDD;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private FKCMFGAFJFA KPOPHKJIPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x172EAF0", Offset = "0x172DEF0", VA = "0x18172EAF0", Slot = "23")]
		get
		{
			return default(FKCMFGAFJFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FKCMFGAFJFA NCMLDIKGIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x10AEFF0", Offset = "0x10AE3F0", VA = "0x1810AEFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private float CBOAKKDFFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xE58050", Offset = "0xE57450", VA = "0x180E58050", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool ANNCEACNOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA70F0", Offset = "0x4FA64F0", VA = "0x184FA70F0", Slot = "24")]
	private bool KMCPPIEAPDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4FA70E0", Offset = "0x4FA64E0", VA = "0x184FA70E0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4FA7110", Offset = "0x4FA6510", VA = "0x184FA7110")]
	public PNFIHELELEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal interface KGIGGMKOAEI
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool AOHMFPJGKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool ODECNMKDKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class JNHPNFFJNJH
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class LGDJOJMHDKM : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public FKCMFGAFJFA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public LGDJOJMHDKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3190", Offset = "0x4FA2590", VA = "0x184FA3190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4FA3200", Offset = "0x4FA2600", VA = "0x184FA3200", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class CMHOEPKFCPB : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public FKCMFGAFJFA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private PHFLFKPMCCG <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public CMHOEPKFCPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4F92830", Offset = "0x4F91C30", VA = "0x184F92830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4F928C0", Offset = "0x4F91CC0", VA = "0x184F928C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0D90", Offset = "0x4FA0190", VA = "0x184FA0D90")]
	[IteratorStateMachine(typeof(LGDJOJMHDKM))]
	private static IEnumerator<PHFLFKPMCCG> FPDNDJGEIIC(float KEGCBGNJKBP, FKCMFGAFJFA CLAOAKAOJHH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1170", Offset = "0x4FA0570", VA = "0x184FA1170")]
	[IteratorStateMachine(typeof(CMHOEPKFCPB))]
	private static IEnumerator<PHFLFKPMCCG> NLIGLJFOFED(float KEGCBGNJKBP, FKCMFGAFJFA CLAOAKAOJHH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1200", Offset = "0x4FA0600", VA = "0x184FA1200")]
	public static IDisposable OBMNBJGMNNP(this MonoBehaviour MGABPIINBEH, float KEGCBGNJKBP, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0CD0", Offset = "0x4FA00D0", VA = "0x184FA0CD0")]
	public static IMJDOMFMBGH ENPNBEELLLA(this MonoBehaviour MGABPIINBEH, float KEGCBGNJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4FA1320", Offset = "0x4FA0720", VA = "0x184FA1320")]
	public static IMJDOMFMBGH OBMNBJGMNNP(this MonoBehaviour MGABPIINBEH, float KEGCBGNJKBP, FKCMFGAFJFA CLAOAKAOJHH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0A50", Offset = "0x4F9FE50", VA = "0x184FA0A50")]
	public static IMJDOMFMBGH AHGKCNCPFPO(this MonoBehaviour MGABPIINBEH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0B70", Offset = "0x4F9FF70", VA = "0x184FA0B70")]
	public static IMJDOMFMBGH BNGMGCMFGJD(this MonoBehaviour MGABPIINBEH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0FC0", Offset = "0x4FA03C0", VA = "0x184FA0FC0")]
	public static IMJDOMFMBGH JDNBPDDILFJ(this MonoBehaviour MGABPIINBEH, Action IHEKINJBFIK, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0CA0", Offset = "0x4FA00A0", VA = "0x184FA0CA0")]
	public static IMJDOMFMBGH CLLEGINCKHA(this MonoBehaviour MGABPIINBEH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0B40", Offset = "0x4F9FF40", VA = "0x184FA0B40")]
	public static IMJDOMFMBGH BCNCFALHFLA(this MonoBehaviour MGABPIINBEH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0BA0", Offset = "0x4F9FFA0", VA = "0x184FA0BA0")]
	public static IMJDOMFMBGH BPNEFCAEMMM(this MonoBehaviour MGABPIINBEH, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0BD0", Offset = "0x4F9FFD0", VA = "0x184FA0BD0")]
	private static IMJDOMFMBGH CACALDAMEIK(MonoBehaviour MGABPIINBEH, FKCMFGAFJFA PGPJEOCIBPN, Action IHEKINJBFIK, [Optional] GNILGMCMPBL NEELIDMCIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0A70", Offset = "0x4F9FE70", VA = "0x184FA0A70")]
	public static IMJDOMFMBGH AIOGOLFLPMF(this MonoBehaviour MGABPIINBEH, float FKDCGMGOLNJ, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0EF0", Offset = "0x4FA02F0", VA = "0x184FA0EF0")]
	public static IMJDOMFMBGH GAMBFJPGAIO(this MonoBehaviour MGABPIINBEH, float FKDCGMGOLNJ, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4FA10A0", Offset = "0x4FA04A0", VA = "0x184FA10A0")]
	public static IMJDOMFMBGH JFEPPOJGFPN(this MonoBehaviour MGABPIINBEH, float FKDCGMGOLNJ, Action IHEKINJBFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4FA0E20", Offset = "0x4FA0220", VA = "0x184FA0E20")]
	public static IMJDOMFMBGH FPLDFLFMBKO(this MonoBehaviour MGABPIINBEH, float FKDCGMGOLNJ, Action IHEKINJBFIK)
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

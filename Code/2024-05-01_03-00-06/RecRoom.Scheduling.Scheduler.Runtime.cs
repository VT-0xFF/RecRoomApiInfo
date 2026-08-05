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
public class JNOKAMMOPIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority GOAKHDJOAMP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6AC09D0", Offset = "0x6ABF7D0", VA = "0x186AC09D0")]
	public JNOKAMMOPIN(ThreadPriority KKEHGJJPCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6AC09C0", Offset = "0x6ABF7C0", VA = "0x186AC09C0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> IJCCFCELCHK(List<PlayerLoopSystem> MPEHBIEDKFD, int FMBIBBOAGBC);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct HMAGMFMCNCC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PMDKNILFEOC
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static BFNGIAHHPKE MOGCKFJBGDD;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6AC6DD0", Offset = "0x6AC5BD0", VA = "0x186AC6DD0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GELBLIBKHFG
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static BFNGIAHHPKE FPKHNPOEMJO;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6ABABD0", Offset = "0x6AB99D0", VA = "0x186ABABD0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct FGBCMCOPAMP
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static BFNGIAHHPKE PADBOIBKBFM;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6ABA810", Offset = "0x6AB9610", VA = "0x186ABA810")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct OFMFCKMKHMB
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BFNGIAHHPKE OMLPLHDCEFH;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BFNGIAHHPKE KDHIJFCFCGI;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BFNGIAHHPKE BIBHOHLHBDD;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static BFNGIAHHPKE KGBMOAALFMI;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6AC5AA0", Offset = "0x6AC48A0", VA = "0x186AC5AA0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct EJAMPKPAJNN
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static BFNGIAHHPKE LFCNEHONELM;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6AB9020", Offset = "0x6AB7E20", VA = "0x186AB9020")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct FAKKHFCDIHA
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BFNGIAHHPKE OMLPLHDCEFH;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BFNGIAHHPKE KDHIJFCFCGI;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BFNGIAHHPKE BIBHOHLHBDD;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static BFNGIAHHPKE KGBMOAALFMI;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6AB9A20", Offset = "0x6AB8820", VA = "0x186AB9A20")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct BPGIKENJCFP
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static BFNGIAHHPKE IDDEMMAIILM;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6AAF920", Offset = "0x6AAE720", VA = "0x186AAF920")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct JBGFANJNPCA
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static BFNGIAHHPKE HPKDPKJFLOA;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6AC01F0", Offset = "0x6ABEFF0", VA = "0x186AC01F0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct PONHFAJBDJH
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static BFNGIAHHPKE LMCFOOGFICI;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6AC7480", Offset = "0x6AC6280", VA = "0x186AC7480")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct LOFBDFIDILC
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static BFNGIAHHPKE EGAKKDNCANL;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6AC31B0", Offset = "0x6AC1FB0", VA = "0x186AC31B0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct FGHMELHILJK
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static BFNGIAHHPKE DILOEMOHGOH;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6ABA9F0", Offset = "0x6AB97F0", VA = "0x186ABA9F0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct MLHHKNLPCEA
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static BFNGIAHHPKE IHAGGOFNADJ;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6AC3530", Offset = "0x6AC2330", VA = "0x186AC3530")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct ALPLNOALKNP
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static BFNGIAHHPKE MNKIJMLCEED;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6AAD1A0", Offset = "0x6AABFA0", VA = "0x186AAD1A0")]
				public static PlayerLoopSystem PBGLKEFHNAN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum IFNLHAIOJNG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				Unset,
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				Initialization,
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				EarlyUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				FixedUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				PreUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				Update,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PreLateUpdate,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PostLateUpdate
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public struct OOFIGABHHPA
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class JMINCIILPGC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public IFNLHAIOJNG updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
					public JMINCIILPGC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x6AC0940", Offset = "0x6ABF740", VA = "0x186AC0940")]
					internal void GEIDGJKHPLM()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static BFFNIPDAHMM<IFNLHAIOJNG> IBKAOBDPMFI;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x6AC5EF0", Offset = "0x6AC4CF0", VA = "0x186AC5EF0")]
				public static PlayerLoopSystem PBGLKEFHNAN(IFNLHAIOJNG HFMLJOIDPHO)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct OEDJPJIAGCH
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class HLEIHFLINOD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public AGHILDMKFNJ.ILEOBFMBNMB key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
					public HLEIHFLINOD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x6ABE8D0", Offset = "0x6ABD6D0", VA = "0x186ABE8D0")]
					internal void IKKMOIINMIE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable FBFMIPAFDAH;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x6AC5970", Offset = "0x6AC4770", VA = "0x186AC5970")]
				public static PlayerLoopSystem FGKJMIAFDNN(AGHILDMKFNJ.ILEOBFMBNMB OBPLDLNDJLE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct OANLHJOCAAM
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class FEILLJKKEDI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public AGHILDMKFNJ.ILEOBFMBNMB key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
					public FEILLJKKEDI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x6AB9EB0", Offset = "0x6AB8CB0", VA = "0x186AB9EB0")]
					internal void IKKMOIINMIE()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6AC5690", Offset = "0x6AC4490", VA = "0x186AC5690")]
				public static PlayerLoopSystem FGKJMIAFDNN(AGHILDMKFNJ.ILEOBFMBNMB OBPLDLNDJLE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class DCGMMJIBFEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public DCGMMJIBFEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6AB54E0", Offset = "0x6AB42E0", VA = "0x186AB54E0")]
			internal List<PlayerLoopSystem> NFDIENHOEOA(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool LCAHFLLHELM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool LMJEEKHEOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6AB1680", Offset = "0x6AB0480", VA = "0x186AB1680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2700", Offset = "0x6AB1500", VA = "0x186AB2700")]
		private static void NGHPIGDIAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1DF0", Offset = "0x6AB0BF0", VA = "0x186AB1DF0")]
		private static void MKENEFMNNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AB16C0", Offset = "0x6AB04C0", VA = "0x186AB16C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5260", Offset = "0x6AB4060", VA = "0x186AB5260")]
		private static void PPIBMADHMAA(AGHILDMKFNJ.ILEOBFMBNMB OBPLDLNDJLE, PlayerLoopSystem MNCECOPDLFD, Type FMAJKLCKICG, Type ADNJEHBBDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AB18E0", Offset = "0x6AB06E0", VA = "0x186AB18E0")]
		private static void GFCAFFJAMEE(PlayerLoopSystem MNCECOPDLFD, Type FMAJKLCKICG, Type ADNJEHBBDNL, IJCCFCELCHK IHFDKLOHJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1CC0", Offset = "0x6AB0AC0", VA = "0x186AB1CC0")]
		private static void MJGBGDCAMJA(PlayerLoopSystem MNCECOPDLFD, Type FMAJKLCKICG, Type ADNJEHBBDNL, PlayerLoopSystem? BLKPDMFEHLO, PlayerLoopSystem? FPICMILJKLA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class AGHILDMKFNJ
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum ILEOBFMBNMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		OMPrePhysicsFixedUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class COIKNKKIEKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly ILEOBFMBNMB GNJONAEHIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly PLOLPOFLLOD IBOFPNNNIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long PIPKNGPBOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long ALBHJALIGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long NMHALHELCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int LDHEOHMHKII;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1570", Offset = "0x6AB0370", VA = "0x186AB1570")]
		public COIKNKKIEKK(ILEOBFMBNMB EJODKEOBJOF, int GGKJFFHAKEE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AB12D0", Offset = "0x6AB00D0", VA = "0x186AB12D0")]
		public void BLMDGDMOLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1520", Offset = "0x6AB0320", VA = "0x186AB1520")]
		public void OLJFKAFDKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1340", Offset = "0x6AB0140", VA = "0x186AB1340")]
		public void NIOKDDEDJLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static ILEOBFMBNMB[] AEIAIJDFDFB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static COIKNKKIEKK[] EJHLPNMHLIG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AACC90", Offset = "0x6AABA90", VA = "0x186AACC90")]
	public static COIKNKKIEKK EGPNLCPLBBB(ILEOBFMBNMB OBPLDLNDJLE, int GGKJFFHAKEE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AACC20", Offset = "0x6AABA20", VA = "0x186AACC20")]
	public static COIKNKKIEKK DEOBMGAMLDB(ILEOBFMBNMB OBPLDLNDJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AACE70", Offset = "0x6AABC70", VA = "0x186AACE70")]
	public static void IPMOFKABHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PLOLPOFLLOD : HPHBANGKHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int EHMGJDCIBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> OMPIHODFHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double CGPMFEMKNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double BKMAHFHDFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double CAHPHLIOMCG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double AGMPGEFHDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6CC0", Offset = "0x6AC5AC0", VA = "0x186AC6CC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double OPBPKEINGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x18935E0", Offset = "0x18923E0", VA = "0x1818935E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GCJLLKLAOON
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6EA0", Offset = "0x1DE5CA0", VA = "0x181DE6EA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6D20", Offset = "0x6AC5B20", VA = "0x186AC6D20")]
	public PLOLPOFLLOD(int DOFNKIPHPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6BA0", Offset = "0x6AC59A0", VA = "0x186AC6BA0", Slot = "7")]
	public void NIILLHFHPAE(double FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6B30", Offset = "0x6AC5930", VA = "0x186AC6B30", Slot = "8")]
	public void HJOLGBAAIAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AOJILHHFLDD : HPHBANGKHEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long NJKDAMEBDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double EAIJDOPDILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double KOEAMPGMBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double CNFAKEJLLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double PELEALBKCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double CGPMFEMKNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double BKMAHFHDFAF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double OPBPKEINGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57FE600", Offset = "0x57FD400", VA = "0x1857FE600", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GCJLLKLAOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x57FE5D0", Offset = "0x57FD3D0", VA = "0x1857FE5D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double PAILGBKLMKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57FE5E0", Offset = "0x57FD3E0", VA = "0x1857FE5E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double AGMPGEFHDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x236D210", Offset = "0x236C010", VA = "0x18236D210", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD3C0", Offset = "0x6AAC1C0", VA = "0x186AAD3C0", Slot = "7")]
	public virtual void NIILLHFHPAE(double FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD380", Offset = "0x6AAC180", VA = "0x186AAD380", Slot = "8")]
	public virtual void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD4E0", Offset = "0x6AAC2E0", VA = "0x186AAD4E0")]
	public AOJILHHFLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MPDJIONLNGJ : AOJILHHFLDD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GDLHLIFLDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x57FE5F0", Offset = "0x57FD3F0", VA = "0x1857FE5F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x57FEA80", Offset = "0x57FD880", VA = "0x1857FEA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5560", Offset = "0x6AC4360", VA = "0x186AC5560", Slot = "7")]
	public override void NIILLHFHPAE(double FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5520", Offset = "0x6AC4320", VA = "0x186AC5520", Slot = "8")]
	public override void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD4E0", Offset = "0x6AAC2E0", VA = "0x186AAD4E0")]
	public MPDJIONLNGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HPHBANGKHEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double AGMPGEFHDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double OPBPKEINGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double GCJLLKLAOON
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BKNBNIDONPL
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface KLNBKIPPMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool DIACAGFOLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AFNFFFKBJBI();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class CEJOMMIFHMP<TPromise, TMainThreadPromise> : KLNBKIPPMKJ where TPromise : LKLLCIBDBNN where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise KDKLNAFCFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise KGDFILAHMNJ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise FOJNGCKOOOE
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F0B0", Offset = "0x4C4DEB0", VA = "0x184C4F0B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DIACAGFOLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4C4F060", Offset = "0x4C4DE60", VA = "0x184C4F060", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6D90", Offset = "0x7B5B90", VA = "0x1807B6D90")]
		protected CEJOMMIFHMP(TPromise KDKLNAFCFDM, TMainThreadPromise IPNJOJFNOOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F040", Offset = "0x4C4DE40", VA = "0x184C4F040", Slot = "5")]
		public void AFNFFFKBJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void NDDCEMGHFLL(TPromise KDKLNAFCFDM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class KKEICOFDBJM<T> : CEJOMMIFHMP<NPCIDDLFILB<T>, BOOHFGEKJLO<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FC10", Offset = "0x3D0EA10", VA = "0x183D0FC10")]
		public KKEICOFDBJM(NPCIDDLFILB<T> KDKLNAFCFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FA70", Offset = "0x3D0E870", VA = "0x183D0FA70", Slot = "6")]
		protected override void NDDCEMGHFLL(NPCIDDLFILB<T> KDKLNAFCFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FA40", Offset = "0x3D0E840", VA = "0x183D0FA40")]
		[CompilerGenerated]
		private void CIGLMCMAJIG(T FJMMLPMLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FA10", Offset = "0x3D0E810", VA = "0x183D0FA10")]
		[CompilerGenerated]
		private void BNFBHCELJCA(string EPIMHJFIPDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class MHHELIKFPIG : KLNBKIPPMKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action GOECALGCLOK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool DIACAGFOLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
		public MHHELIKFPIG(Action GOECALGCLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC2A4C0", Offset = "0xC292C0", VA = "0x180C2A4C0", Slot = "5")]
		public void AFNFFFKBJBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<KLNBKIPPMKJ> NAFKMLIFKOI;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26AB610", Offset = "0x26AA410", VA = "0x1826AB610")]
	public static NPCIDDLFILB<T> PFJHCMPECPO<T>(this NPCIDDLFILB<T> KDKLNAFCFDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE810", Offset = "0x6AAD610", VA = "0x186AAE810")]
	public static void PFJHCMPECPO(Action GOECALGCLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26AB550", Offset = "0x26AA350", VA = "0x1826AB550")]
	private static NPCIDDLFILB<T> CBPKPHANEKE<T>(NPCIDDLFILB<T> KDKLNAFCFDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE5A0", Offset = "0x6AAD3A0", VA = "0x186AAE5A0")]
	private static void NLGELAGAJPO(KLNBKIPPMKJ IJPJNDJENEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE1C0", Offset = "0x6AACFC0", VA = "0x186AAE1C0")]
	private static void FEEBHFKONDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE4A0", Offset = "0x6AAD2A0", VA = "0x186AAE4A0")]
	private static void GBKHMNIGFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE0F0", Offset = "0x6AACEF0", VA = "0x186AAE0F0")]
	private static void DIKHBOODLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HDHBIDEGJOA
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OMBPCGDDLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> OPINGIHMNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string ONFIFMPHJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode MBGGMHGFJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool FHFALKBLLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5D70", Offset = "0x6AC4B70", VA = "0x186AC5D70")]
		public OMBPCGDDLOF(TaskCompletionSource<Scene> KBJNIEAGNFI, string ONFIFMPHJHJ, LoadSceneMode MBGGMHGFJMJ, bool FHFALKBLLEO, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct PDNNPNACNGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private DIMFGGHDEDI<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6AC60B0", Offset = "0x6AC4EB0", VA = "0x186AC60B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6950", Offset = "0x6AC5750", VA = "0x186AC6950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct CEHKJLJECMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFB00", Offset = "0x6AAE900", VA = "0x186AAFB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFE10", Offset = "0x6AAEC10", VA = "0x186AAFE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DLIKGAIBOPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private OMBPCGDDLOF <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5640", Offset = "0x6AB4440", VA = "0x186AB5640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB59F0", Offset = "0x6AB47F0", VA = "0x186AB59F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class INPEHMEAOCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BOOHFGEKJLO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public INPEHMEAOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEF00", Offset = "0x6ABDD00", VA = "0x186ABEF00")]
		internal void PODIEGFNFBD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct LIOFGEEHNEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private INPEHMEAOCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AC25A0", Offset = "0x6AC13A0", VA = "0x186AC25A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3140", Offset = "0x6AC1F40", VA = "0x186AC3140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JKPKEEEMHGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AC03D0", Offset = "0x6ABF1D0", VA = "0x186AC03D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AC08D0", Offset = "0x6ABF6D0", VA = "0x186AC08D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct MOHEHPFBMMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DIMFGGHDEDI<string>.NJDBOGMFDFJ stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DIMFGGHDEDI<string>.NJDBOGMFDFJ <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3C80", Offset = "0x6AC2A80", VA = "0x186AC3C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AC47D0", Offset = "0x6AC35D0", VA = "0x186AC47D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MLJBINJFKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MLJBINJFKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3710", Offset = "0x6AC2510", VA = "0x186AC3710")]
		internal bool BEDEJBKGCJJ()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CNFKNOFHPJA : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public JGKLBIBCBIK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public CNFKNOFHPJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1240", Offset = "0x6AB0040", VA = "0x186AB1240", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0EC0", Offset = "0x6AAFCC0", VA = "0x186AB0EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0E70", Offset = "0x6AAFC70", VA = "0x186AB0E70")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB11F0", Offset = "0x6AAFFF0", VA = "0x186AB11F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class CINFNMFCLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public BOOHFGEKJLO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CINFNMFCLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB00D0", Offset = "0x6AAEED0", VA = "0x186AB00D0")]
		internal bool IGMDGJCGNGI(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6AAFE70", Offset = "0x6AAEC70", VA = "0x186AAFE70")]
		internal void BJNJOICFDJP(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EMCKNJGCGPB : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BOOHFGEKJLO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private CINFNMFCLCP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public EMCKNJGCGPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6AB92E0", Offset = "0x6AB80E0", VA = "0x186AB92E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6AB99D0", Offset = "0x6AB87D0", VA = "0x186AB99D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> KKNHMLFNEHA;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static LKLLCIBDBNN FJCFJKINNAO;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation ENMNLGNAMPK;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static LKLLCIBDBNN BKJEOFLKEHN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string LIMJJDDEHDD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority ECDFHPNNFDE;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task IPDONDPKCFA;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> CCFMJHHHHGA;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<OMBPCGDDLOF> DANGAIIHGPK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task OOBMJBONCJM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool NDJIIJGLJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD6C0", Offset = "0x6ABC4C0", VA = "0x186ABD6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool KBDFHJOHALK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE070", Offset = "0x6ABCE70", VA = "0x186ABE070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool LKNEGGKFDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE3C0", Offset = "0x6ABD1C0", VA = "0x186ABE3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool BPDPPKEJHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD150", Offset = "0x6ABBF50", VA = "0x186ABD150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FKNCIHBCBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDAF0", Offset = "0x6ABC8F0", VA = "0x186ABDAF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD5B0", Offset = "0x6ABC3B0", VA = "0x186ABD5B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE610", Offset = "0x6ABD410", VA = "0x186ABE610")]
	[MMKPLPPCOMH(BADADLHKHLN.EnteredEditModeNextFrame, 0)]
	private static void PLPEGJKIOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDC00", Offset = "0x6ABCA00", VA = "0x186ABDC00")]
	[AsyncStateMachine(typeof(PDNNPNACNGJ))]
	public static Task<Scene> GBDNFLEIAJO(string ONFIFMPHJHJ, LoadSceneMode MBGGMHGFJMJ = LoadSceneMode.Single, bool FHFALKBLLEO = false, [Optional] DIMFGGHDEDI<string>.NJDBOGMFDFJ CCDKAKLNEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD0A0", Offset = "0x6ABBEA0", VA = "0x186ABD0A0")]
	[AsyncStateMachine(typeof(CEHKJLJECMB))]
	private static Task AHLKECHIIJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDFA0", Offset = "0x6ABCDA0", VA = "0x186ABDFA0")]
	[AsyncStateMachine(typeof(DLIKGAIBOPG))]
	private static Task HNADFOEBFPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE110", Offset = "0x6ABCF10", VA = "0x186ABE110")]
	[AsyncStateMachine(typeof(LIOFGEEHNEF))]
	private static Task<Scene> JHIMNAODEON(string ONFIFMPHJHJ, LoadSceneMode MBGGMHGFJMJ, bool FHFALKBLLEO, DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE260", Offset = "0x6ABD060", VA = "0x186ABE260")]
	private static void KDMHIHMPOMF(SceneInstance LOMIFCBLBKN, LoadSceneMode MBGGMHGFJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE550", Offset = "0x6ABD350", VA = "0x186ABE550")]
	private static void PAMBFDONJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDE80", Offset = "0x6ABCC80", VA = "0x186ABDE80")]
	[AsyncStateMachine(typeof(JKPKEEEMHGF))]
	private static Task<Scene> HKEGMHLIAGI(string ONFIFMPHJHJ, LoadSceneMode MBGGMHGFJMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6ABE460", Offset = "0x6ABD260", VA = "0x186ABE460")]
	private static bool OJFKMFFDOEC(string ONFIFMPHJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD4A0", Offset = "0x6ABC2A0", VA = "0x186ABD4A0")]
	[AsyncStateMachine(typeof(MOHEHPFBMMN))]
	private static Task<Scene> DBJKCOMMHGP(DIMFGGHDEDI<string>.NJDBOGMFDFJ LDOAFHHBOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD8D0", Offset = "0x6ABC6D0", VA = "0x186ABD8D0")]
	public static NPCIDDLFILB<Scene> EIHLBIAGLOM(string ONFIFMPHJHJ, LoadSceneMode MBGGMHGFJMJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD1E0", Offset = "0x6ABBFE0", VA = "0x186ABD1E0")]
	public static LKLLCIBDBNN COEPMCMDHGN(string ONFIFMPHJHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6ABD010", Offset = "0x6ABBE10", VA = "0x186ABD010")]
	[IteratorStateMachine(typeof(CNFKNOFHPJA))]
	private static IEnumerator<KMOACDBBKNB> AGODMOBAKCC(string ONFIFMPHJHJ, JGKLBIBCBIK MBJFNKHNGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDA50", Offset = "0x6ABC850", VA = "0x186ABDA50")]
	[IteratorStateMachine(typeof(EMCKNJGCGPB))]
	private static IEnumerator<KMOACDBBKNB> EJACOKILKLC(string ONFIFMPHJHJ, LoadSceneMode MBGGMHGFJMJ, BOOHFGEKJLO<Scene> MBJFNKHNGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6ABDD50", Offset = "0x6ABCB50", VA = "0x186ABDD50")]
	public static bool GDNEECCDFOO([Out] string GOALFGAKBGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MMIGNIJKELN
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3740", Offset = "0x6AC2540", VA = "0x186AC3740")]
	public static IDisposable BIHINGBIJON(this PJINDEFEPHD EJDIFPAIGMC, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3850", Offset = "0x6AC2650", VA = "0x186AC3850")]
	public static IDisposable OOFJJCBOPOH(this PJINDEFEPHD EJDIFPAIGMC, Action<float> KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC37D0", Offset = "0x6AC25D0", VA = "0x186AC37D0")]
	public static IDisposable MOLGNCGHCKJ(this PJINDEFEPHD EJDIFPAIGMC, Action<float> KOAPOMOHLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class EBDMGCANAPE
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8750", Offset = "0x6AB7550", VA = "0x186AB8750")]
	public static IDisposable EAKJHJPOEJB(this MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB86C0", Offset = "0x6AB74C0", VA = "0x186AB86C0")]
	public static IDisposable EAKJHJPOEJB(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8FA0", Offset = "0x6AB7DA0", VA = "0x186AB8FA0")]
	public static IDisposable PHAFDIODDDG(this MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8C40", Offset = "0x6AB7A40", VA = "0x186AB8C40")]
	public static IDisposable JAGFKKAKGKN(this MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8CC0", Offset = "0x6AB7AC0", VA = "0x186AB8CC0")]
	public static IDisposable JAGFKKAKGKN(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8640", Offset = "0x6AB7440", VA = "0x186AB8640")]
	public static IDisposable DJCHEMFHOPC(this MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB85C0", Offset = "0x6AB73C0", VA = "0x186AB85C0")]
	public static IDisposable CNJHDAMBGLJ(this MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8890", Offset = "0x6AB7690", VA = "0x186AB8890")]
	public static IDisposable FAKDJCFCNIE(this MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB87E0", Offset = "0x6AB75E0", VA = "0x186AB87E0")]
	public static IDisposable EOFDGBBPLII(this MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8DE0", Offset = "0x6AB7BE0", VA = "0x186AB8DE0")]
	public static IDisposable MCKEMIIBDNM(this MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8BA0", Offset = "0x6AB79A0", VA = "0x186AB8BA0")]
	public static IDisposable IHCCJGDNINL(this MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A60", Offset = "0x6AB7860", VA = "0x186AB8A60")]
	public static IDisposable HAALDGAKAIL(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB89C0", Offset = "0x6AB77C0", VA = "0x186AB89C0")]
	public static IDisposable GCDAGLCJPAN(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8480", Offset = "0x6AB7280", VA = "0x186AB8480")]
	public static IDisposable AJHIMLJAAMK(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8B00", Offset = "0x6AB7900", VA = "0x186AB8B00")]
	public static IDisposable HDGEFKMPCGD(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8D40", Offset = "0x6AB7B40", VA = "0x186AB8D40")]
	public static IDisposable JNPMBAAEODP(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8520", Offset = "0x6AB7320", VA = "0x186AB8520")]
	public static IDisposable BNKBFMMFNFL(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8F00", Offset = "0x6AB7D00", VA = "0x186AB8F00")]
	public static IDisposable MFJOEBIFFNN(this MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8910", Offset = "0x6AB7710", VA = "0x186AB8910")]
	public static IDisposable FNPOMKMDCHB(this MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MMJBDJCAHOD
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PIONCCFGNFK : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AIHCOJBADIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private ENCPBCBKPMH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public PIONCCFGNFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6AC69C0", Offset = "0x6AC57C0", VA = "0x186AC69C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6AA0", Offset = "0x6AC58A0", VA = "0x186AC6AA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FCKNLAPLCPA : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AIHCOJBADIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private ENCPBCBKPMH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public FCKNLAPLCPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9D70", Offset = "0x6AB8B70", VA = "0x186AB9D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9E60", Offset = "0x6AB8C60", VA = "0x186AB9E60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3BD0", Offset = "0x6AC29D0", VA = "0x186AC3BD0")]
	public static DPFFPCFAMJN EAKJHJPOEJB(Action KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC39F0", Offset = "0x6AC27F0", VA = "0x186AC39F0")]
	public static DPFFPCFAMJN EAKJHJPOEJB(Behaviour EJDIFPAIGMC, Action KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3AB0", Offset = "0x6AC28B0", VA = "0x186AC3AB0")]
	public static DPFFPCFAMJN EAKJHJPOEJB(Behaviour EJDIFPAIGMC, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC38D0", Offset = "0x6AC26D0", VA = "0x186AC38D0")]
	[IteratorStateMachine(typeof(PIONCCFGNFK))]
	private static IEnumerator<KMOACDBBKNB> DEKJILECOAP(AIHCOJBADIL AFCPPEOPCNC, Action KOAPOMOHLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3960", Offset = "0x6AC2760", VA = "0x186AC3960")]
	[IteratorStateMachine(typeof(FCKNLAPLCPA))]
	private static IEnumerator<KMOACDBBKNB> DEKJILECOAP(AIHCOJBADIL AFCPPEOPCNC, Action<float> KOAPOMOHLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class AONDLDPJFOB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MLGPBCBMLEA : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AONDLDPJFOB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public MLGPBCBMLEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3450", Offset = "0x6AC2250", VA = "0x186AC3450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6AC34E0", Offset = "0x6AC22E0", VA = "0x186AC34E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly AIHCOJBADIL APEAAJPNJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action GDEPLMFAKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool FEBHBHFAAJH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IHFMGFBNHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7BA880", Offset = "0x7B9680", VA = "0x1807BA880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD630", Offset = "0x6AAC430", VA = "0x186AAD630")]
	public AONDLDPJFOB(AIHCOJBADIL APEAAJPNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD5B0", Offset = "0x6AAC3B0", VA = "0x186AAD5B0")]
	[IteratorStateMachine(typeof(MLGPBCBMLEA))]
	private IEnumerator<KMOACDBBKNB> POEFNMAKGEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD510", Offset = "0x6AAC310", VA = "0x186AAD510", Slot = "4")]
	public void OnCompleted(Action FENNPGADFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public void MOKGMELIOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IGDBIENHIFM
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEC80", Offset = "0x6ABDA80", VA = "0x186ABEC80")]
	public static AONDLDPJFOB AGKNNCIHMJP(this AIHCOJBADIL APEAAJPNJOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BNPPJCOIAKM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class KPONJHHFHIM : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public NFOCHHNGOOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public KPONJHHFHIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0E30", Offset = "0x6ABFC30", VA = "0x186AC0E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0EB0", Offset = "0x6ABFCB0", VA = "0x186AC0EB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEC20", Offset = "0x6AADA20", VA = "0x186AAEC20")]
	public static DPFFPCFAMJN EAKJHJPOEJB(float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEB10", Offset = "0x6AAD910", VA = "0x186AAEB10")]
	public static DPFFPCFAMJN EAKJHJPOEJB(MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6AAED20", Offset = "0x6AADB20", VA = "0x186AAED20")]
	public static DPFFPCFAMJN FKNIHGHAEGM(MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEA00", Offset = "0x6AAD800", VA = "0x186AAEA00")]
	public static DPFFPCFAMJN DOADIIPLELE(PJINDEFEPHD EJDIFPAIGMC, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE940", Offset = "0x6AAD740", VA = "0x186AAE940")]
	private static IEnumerator<KMOACDBBKNB> DEKJILECOAP(DHPKJCMEHAE EOEDJHJOPDI, float PKLIIDKKFHI, AIHCOJBADIL AFCPPEOPCNC, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEED0", Offset = "0x6AADCD0", VA = "0x186AAEED0")]
	private static IEnumerator<KMOACDBBKNB> MEAGIJJFMGF(DHPKJCMEHAE EOEDJHJOPDI, float PKLIIDKKFHI, AIHCOJBADIL AFCPPEOPCNC, Action<float> KOAPOMOHLOG, bool PFMPJGINEHF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEE40", Offset = "0x6AADC40", VA = "0x186AAEE40")]
	[IteratorStateMachine(typeof(KPONJHHFHIM))]
	private static IEnumerator<KMOACDBBKNB> IGDMJLCAPPG(NFOCHHNGOOF HBABEGLHNKB, float PKLIIDKKFHI, AIHCOJBADIL AFCPPEOPCNC, Action<float> KOAPOMOHLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OEAPMDODLHE
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class BCNFIGKBJDL : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AIHCOJBADIL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public BCNFIGKBJDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD740", Offset = "0x6AAC540", VA = "0x186AAD740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD800", Offset = "0x6AAC600", VA = "0x186AAD800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC58E0", Offset = "0x6AC46E0", VA = "0x186AC58E0")]
	[IteratorStateMachine(typeof(BCNFIGKBJDL))]
	private static IEnumerator<KMOACDBBKNB> AEMPGBBJCJB(AIHCOJBADIL APEAAJPNJOJ, Func<bool> CBAOJAAOCLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC57C0", Offset = "0x6AC45C0", VA = "0x186AC57C0")]
	public static DPFFPCFAMJN ADIJFPFBHGO(this MonoBehaviour MBBOOCKAMOE, Func<bool> CBAOJAAOCLI, AIHCOJBADIL APEAAJPNJOJ = AIHCOJBADIL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class BOAOJKFEANF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class MKFIGOEADFJ : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AIHCOJBADIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public MKFIGOEADFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3390", Offset = "0x6AC2190", VA = "0x186AC3390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3400", Offset = "0x6AC2200", VA = "0x186AC3400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class EJGMNGGEBEJ : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AIHCOJBADIL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private KMOACDBBKNB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public EJGMNGGEBEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9200", Offset = "0x6AB8000", VA = "0x186AB9200", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9290", Offset = "0x6AB8090", VA = "0x186AB9290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF880", Offset = "0x6AAE680", VA = "0x186AAF880")]
	[IteratorStateMachine(typeof(MKFIGOEADFJ))]
	private static IEnumerator<KMOACDBBKNB> POEFNMAKGEN(float GKFGFCFKANC, AIHCOJBADIL AFCPPEOPCNC, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF530", Offset = "0x6AAE330", VA = "0x186AAF530")]
	[IteratorStateMachine(typeof(EJGMNGGEBEJ))]
	private static IEnumerator<KMOACDBBKNB> ILEAAFAMAEI(float GKFGFCFKANC, AIHCOJBADIL AFCPPEOPCNC, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF1E0", Offset = "0x6AADFE0", VA = "0x186AAF1E0")]
	public static IDisposable FIIMAFFHKBL(this MonoBehaviour MBBOOCKAMOE, float GKFGFCFKANC, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF6C0", Offset = "0x6AAE4C0", VA = "0x186AAF6C0")]
	public static DPFFPCFAMJN LLJAMHJPODP(this MonoBehaviour MBBOOCKAMOE, float GKFGFCFKANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF300", Offset = "0x6AAE100", VA = "0x186AAF300")]
	public static DPFFPCFAMJN FIIMAFFHKBL(this MonoBehaviour MBBOOCKAMOE, float GKFGFCFKANC, AIHCOJBADIL AFCPPEOPCNC, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF5D0", Offset = "0x6AAE3D0", VA = "0x186AAF5D0")]
	public static DPFFPCFAMJN KMNIAOFBNKB(this MonoBehaviour MBBOOCKAMOE, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF0E0", Offset = "0x6AADEE0", VA = "0x186AAF0E0")]
	public static DPFFPCFAMJN DKBEFGLLAIH(this MonoBehaviour MBBOOCKAMOE, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEF30", Offset = "0x6AADD30", VA = "0x186AAEF30")]
	public static DPFFPCFAMJN ANLCKFAPHMA(this MonoBehaviour MBBOOCKAMOE, Action HAEHEOGNGAP, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF500", Offset = "0x6AAE300", VA = "0x186AAF500")]
	public static DPFFPCFAMJN HJPOEIJBPAN(this MonoBehaviour MBBOOCKAMOE, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF850", Offset = "0x6AAE650", VA = "0x186AAF850")]
	public static DPFFPCFAMJN MPFCEAPHOFM(this MonoBehaviour MBBOOCKAMOE, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF110", Offset = "0x6AADF10", VA = "0x186AAF110")]
	private static DPFFPCFAMJN DLPEFHGMIDL(MonoBehaviour MBBOOCKAMOE, AIHCOJBADIL APEAAJPNJOJ, Action HAEHEOGNGAP, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF5F0", Offset = "0x6AAE3F0", VA = "0x186AAF5F0")]
	public static DPFFPCFAMJN LKLFIDCGNHE(this MonoBehaviour MBBOOCKAMOE, float PHAEEFHPOAA, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF010", Offset = "0x6AADE10", VA = "0x186AAF010")]
	public static DPFFPCFAMJN BBPCNJDDNMM(this MonoBehaviour MBBOOCKAMOE, float PHAEEFHPOAA, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF780", Offset = "0x6AAE580", VA = "0x186AAF780")]
	public static DPFFPCFAMJN LMGOEAKHDGJ(this MonoBehaviour MBBOOCKAMOE, float PHAEEFHPOAA, Action HAEHEOGNGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF430", Offset = "0x6AAE230", VA = "0x186AAF430")]
	public static DPFFPCFAMJN FJMNEHBBIGC(this MonoBehaviour MBBOOCKAMOE, float PHAEEFHPOAA, Action HAEHEOGNGAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ACACJBMKGON : NIDHBFEFBLJ, IEnumerable<NIDHBFEFBLJ>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<NIDHBFEFBLJ> CFANELDAMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool IJNCJJKPPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action IADFHLMCEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool HINFLIGCLEB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AEHDCFFIMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC780", Offset = "0x6AAB580", VA = "0x186AAC780", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KCBAIKEAEKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6AACAE0", Offset = "0x6AAB8E0", VA = "0x186AACAE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AACA40", Offset = "0x6AAB840", VA = "0x186AACA40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6AACB80", Offset = "0x6AAB980", VA = "0x186AACB80")]
	public ACACJBMKGON([Optional] Action IADFHLMCEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC8B0", Offset = "0x6AAB6B0", VA = "0x186AAC8B0")]
	public void HDCMKJKDALC(NIDHBFEFBLJ BKMALMAPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC5B0", Offset = "0x6AAB3B0", VA = "0x186AAC5B0")]
	private void CPMLFAJECPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC5A0", Offset = "0x6AAB3A0", VA = "0x186AAC5A0", Slot = "7")]
	public bool CNNGDLNHEFD(bool NLMEJPDDFJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC2A0", Offset = "0x6AAB0A0", VA = "0x186AAC2A0", Slot = "8")]
	public bool CNNGDLNHEFD(Action GOECALGCLOK, bool NLMEJPDDFJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC700", Offset = "0x6AAB500", VA = "0x186AAC700", Slot = "9")]
	public IEnumerator<NIDHBFEFBLJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC700", Offset = "0x6AAB500", VA = "0x186AAC700", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LCDMKLNHGOF : FFBJKNFKPKL
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class GNMMBOLCOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LCDMKLNHGOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GNMMBOLCOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6ABADB0", Offset = "0x6AB9BB0", VA = "0x186ABADB0")]
		internal void FMBLIMNGIBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class GHMGCHCJNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LCDMKLNHGOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GHMGCHCJNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6ABADB0", Offset = "0x6AB9BB0", VA = "0x186ABADB0")]
		internal void LFEIFNFPBAL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float NMDNOPELMIF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEE00", Offset = "0x6ABDC00", VA = "0x186ABEE00")]
	public LCDMKLNHGOF(Behaviour EJDIFPAIGMC, float NMDNOPELMIF, [Optional] Action IADFHLMCEDC, [Optional] LOCKJLIIGOB PJGOLCHPGEA, [Optional] DHPKJCMEHAE EOEDJHJOPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1010", Offset = "0x6ABFE10", VA = "0x186AC1010", Slot = "9")]
	protected override bool PNGKPCDLCOI(Action GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0F00", Offset = "0x6ABFD00", VA = "0x186AC0F00", Slot = "10")]
	protected override bool APJGFLLGHLK(Action GOECALGCLOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface NIDHBFEFBLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool AEHDCFFIMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KCBAIKEAEKM;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CNNGDLNHEFD(bool NLMEJPDDFJD = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CNNGDLNHEFD(Action GOECALGCLOK, bool NLMEJPDDFJD = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class FFBJKNFKPKL : NIDHBFEFBLJ
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HBHOMCNOJCG : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public FFBJKNFKPKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public HBHOMCNOJCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCEF0", Offset = "0x6ABBCF0", VA = "0x186ABCEF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCFC0", Offset = "0x6ABBDC0", VA = "0x186ABCFC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour EJDIFPAIGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action IADFHLMCEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private EEFNJOFHHBM JOLDLANEACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly LOCKJLIIGOB PJGOLCHPGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly DHPKJCMEHAE EOEDJHJOPDI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool AEHDCFFIMNA
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xFBB750", Offset = "0xFBA550", VA = "0x180FBB750", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KCBAIKEAEKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA670", Offset = "0x6AB9470", VA = "0x186ABA670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA550", Offset = "0x6AB9350", VA = "0x186ABA550", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA710", Offset = "0x6AB9510", VA = "0x186ABA710")]
	protected FFBJKNFKPKL(Behaviour EJDIFPAIGMC, [Optional] Action IADFHLMCEDC, [Optional] LOCKJLIIGOB PJGOLCHPGEA, [Optional] DHPKJCMEHAE EOEDJHJOPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA3C0", Offset = "0x6AB91C0", VA = "0x186ABA3C0", Slot = "7")]
	public bool CNNGDLNHEFD(bool NLMEJPDDFJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA420", Offset = "0x6AB9220", VA = "0x186ABA420", Slot = "8")]
	public bool CNNGDLNHEFD(Action GOECALGCLOK, bool NLMEJPDDFJD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool PNGKPCDLCOI(Action GOECALGCLOK);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool APJGFLLGHLK(Action GOECALGCLOK);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA160", Offset = "0x6AB8F60", VA = "0x186ABA160")]
	protected void CCBAHAHKMLI(Action GOECALGCLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA180", Offset = "0x6AB8F80", VA = "0x186ABA180")]
	protected LKLLCIBDBNN CJDIJHNPHJA(float GAPIMALKIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA5F0", Offset = "0x6AB93F0", VA = "0x186ABA5F0")]
	private void LEDHJHMOIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA4C0", Offset = "0x6AB92C0", VA = "0x186ABA4C0")]
	[IteratorStateMachine(typeof(HBHOMCNOJCG))]
	private IEnumerator<KMOACDBBKNB> EOHJPIINCND(float GAPIMALKIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA480", Offset = "0x6AB9280", VA = "0x186ABA480")]
	[CompilerGenerated]
	private void DKNEIODAOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class JOGNNCOOGFO : FFBJKNFKPKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float BMKIOCDEACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int DMNMGCEEDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float LEOPBCPNNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] ONIFKJCMEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int MEFDKHDHOPM;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0C90", Offset = "0x6ABFA90", VA = "0x186AC0C90")]
	public JOGNNCOOGFO(Behaviour EJDIFPAIGMC, float JHDCEEFFDEH, int DMNMGCEEDIB, [Optional] Action IADFHLMCEDC, float LEOPBCPNNDM = 0f, [Optional] LOCKJLIIGOB PJGOLCHPGEA, [Optional] DHPKJCMEHAE EOEDJHJOPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "9")]
	protected override bool PNGKPCDLCOI(Action GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0A10", Offset = "0x6ABF810", VA = "0x186AC0A10", Slot = "10")]
	protected override bool APJGFLLGHLK(Action GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0C10", Offset = "0x6ABFA10", VA = "0x186AC0C10")]
	private void JDJCLNCMKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IGLMOBKBDLE : FFBJKNFKPKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float NMDNOPELMIF;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEE00", Offset = "0x6ABDC00", VA = "0x186ABEE00")]
	public IGLMOBKBDLE(Behaviour EJDIFPAIGMC, float NMDNOPELMIF, [Optional] Action IADFHLMCEDC, [Optional] LOCKJLIIGOB PJGOLCHPGEA, [Optional] DHPKJCMEHAE EOEDJHJOPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "9")]
	protected override bool PNGKPCDLCOI(Action GOECALGCLOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEDC0", Offset = "0x6ABDBC0", VA = "0x186ABEDC0", Slot = "10")]
	protected override bool APJGFLLGHLK(Action GOECALGCLOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class GPNLCEAPEEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class LHEDPBCPNKD : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public LHEDPBCPNKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5420", Offset = "0x6AB4220", VA = "0x186AB5420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2550", Offset = "0x6AC1350", VA = "0x186AC2550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private DPFFPCFAMJN KIHPAIFKALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private PJINDEFEPHD EJDIFPAIGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> POINAMKAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private AIHCOJBADIL APEAAJPNJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float ICCBNIMJIPF;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCD10", Offset = "0x6ABBB10", VA = "0x186ABCD10")]
	public GPNLCEAPEEM(PJINDEFEPHD EJDIFPAIGMC, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC9C0", Offset = "0x6ABB7C0", VA = "0x186ABC9C0")]
	private void OEOJNPGLGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC7E0", Offset = "0x6ABB5E0", VA = "0x186ABC7E0")]
	private void HBMBNHHJHMF(string EPIMHJFIPDE, Action AOLEEGJCMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC940", Offset = "0x6ABB740", VA = "0x186ABC940")]
	[IteratorStateMachine(typeof(LHEDPBCPNKD))]
	private IEnumerator<KMOACDBBKNB> HINIPNFAHBL(Action AOLEEGJCMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC780", Offset = "0x6ABB580", VA = "0x186ABC780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCB60", Offset = "0x6ABB960", VA = "0x186ABCB60")]
	[CompilerGenerated]
	private void OPKFBPEGOJK(string CCDENENMPHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class JAHCGCIDFBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class DBFBIJCMECA : IEnumerator<KMOACDBBKNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private KMOACDBBKNB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private KMOACDBBKNB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
		[DebuggerHidden]
		public DBFBIJCMECA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5420", Offset = "0x6AB4220", VA = "0x186AB5420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5490", Offset = "0x6AB4290", VA = "0x186AB5490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private DPFFPCFAMJN KIHPAIFKALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour MBBOOCKAMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action KOAPOMOHLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> POINAMKAPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private AIHCOJBADIL APEAAJPNJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float ICCBNIMJIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool PFMPJGINEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly LOCKJLIIGOB PJGOLCHPGEA;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFB70", Offset = "0x6ABE970", VA = "0x186ABFB70")]
	public JAHCGCIDFBN(MonoBehaviour MBBOOCKAMOE, Action KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFD60", Offset = "0x6ABEB60", VA = "0x186ABFD60")]
	public JAHCGCIDFBN(MonoBehaviour MBBOOCKAMOE, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFFA0", Offset = "0x6ABEDA0", VA = "0x186ABFFA0")]
	public JAHCGCIDFBN(MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1A230E0", Offset = "0x1A21EE0", VA = "0x181A230E0")]
	private JAHCGCIDFBN(LOCKJLIIGOB PJGOLCHPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF640", Offset = "0x6ABE440", VA = "0x186ABF640")]
	internal static JAHCGCIDFBN JPAECEEEDAB(MonoBehaviour MBBOOCKAMOE, float PKLIIDKKFHI, Action<float> KOAPOMOHLOG, AIHCOJBADIL APEAAJPNJOJ, bool PFMPJGINEHF = true, [Optional] LOCKJLIIGOB PJGOLCHPGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF050", Offset = "0x6ABDE50", VA = "0x186ABF050")]
	private void EAKJHJPOEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF410", Offset = "0x6ABE210", VA = "0x186ABF410")]
	private void HHIMCOELINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF9C0", Offset = "0x6ABE7C0", VA = "0x186ABF9C0")]
	private void OEOJNPGLGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF800", Offset = "0x6ABE600", VA = "0x186ABF800")]
	private void NAIDELBJINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF250", Offset = "0x6ABE050", VA = "0x186ABF250")]
	private void HBMBNHHJHMF(string EPIMHJFIPDE, Action AOLEEGJCMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF5C0", Offset = "0x6ABE3C0", VA = "0x186ABF5C0")]
	[IteratorStateMachine(typeof(DBFBIJCMECA))]
	private IEnumerator<KMOACDBBKNB> HINIPNFAHBL(Action AOLEEGJCMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEFF0", Offset = "0x6ABDDF0", VA = "0x186ABEFF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF380", Offset = "0x6ABE180", VA = "0x186ABF380")]
	[CompilerGenerated]
	private void HEAGECJKNEK(string CCDENENMPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABEF60", Offset = "0x6ABDD60", VA = "0x186ABEF60")]
	[CompilerGenerated]
	private void AEFDGAALCJC(string CCDENENMPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF1C0", Offset = "0x6ABDFC0", VA = "0x186ABF1C0")]
	[CompilerGenerated]
	private void GHAJJNNNNHK(string CCDENENMPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABF770", Offset = "0x6ABE570", VA = "0x186ABF770")]
	[CompilerGenerated]
	private void KNGFNJHANCA(string CCDENENMPHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum IICOCBILMDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal sealed class DOMCFAJHBDK : DHPKJCMEHAE
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float FAALLNJCFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6AB83E0", Offset = "0x6AB71E0", VA = "0x186AB83E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float NKIGPAAPPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6AB83D0", Offset = "0x6AB71D0", VA = "0x186AB83D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double DGJPNOBJGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8460", Offset = "0x6AB7260", VA = "0x186AB8460", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6AB83F0", Offset = "0x6AB71F0", VA = "0x186AB83F0")]
	[DPHBJKOLDBD(OHNOEEJKPCM.None)]
	private static void LLBAHKJCIHJ(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	[Preserve]
	internal DOMCFAJHBDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface KMIBHKLCJHB
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDMMIIOGHHN(string PHEKPMAPPHM);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOGGAJEMHKD();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface MKKDJEAFIEC
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool LDNDMEBKADH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool NIGBENPLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class POBEFJEEBBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public DLKAMMPEIKM HIIBNDGIEJG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int PCBIBNEPCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FE0", Offset = "0x7B3DE0", VA = "0x1807B4FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7260", Offset = "0x6AC6060", VA = "0x186AC7260")]
	public static KMOACDBBKNB PMAOCDFPNBC(IEnumerator<KMOACDBBKNB> CFAFCJOEHPA, FCIIKDHMPHB LMKBOALMHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6AC73C0", Offset = "0x6AC61C0", VA = "0x186AC73C0")]
	public KMOACDBBKNB PMAOCDFPNBC(FCIIKDHMPHB[] KEEHFIHBBPA, IEnumerator<KMOACDBBKNB>[] FBCDDPICMOJ, KMOACDBBKNB[] EFFBNOKNGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6AC70F0", Offset = "0x6AC5EF0", VA = "0x186AC70F0")]
	public void FODALDDIIDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6FB0", Offset = "0x6AC5DB0", VA = "0x186AC6FB0")]
	public void BLLPCOKAJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7120", Offset = "0x6AC5F20", VA = "0x186AC7120")]
	public void GKHKMJIPLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6AC70F0", Offset = "0x6AC5EF0", VA = "0x186AC70F0")]
	public void NAFIDGCMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public POBEFJEEBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class DLKAMMPEIKM
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct KGANFAMNCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public POBEFJEEBBJ FNFOCGBPFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PJINDEFEPHD JDCDDIADONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FCIIKDHMPHB KBECFFHKNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<KMOACDBBKNB> MCLGDHAGIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public KMOACDBBKNB GEEKIACIKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public IICOCBILMDB BNKMHDHGNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct KABLCGBPNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AIHCOJBADIL CBHGDADBCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<KGANFAMNCEC> PFEKNBKFEBI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class CLHNBKBGCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public FCIIKDHMPHB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public DLKAMMPEIKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public PJINDEFEPHD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public POBEFJEEBBJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public IICOCBILMDB coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KMOACDBBKNB currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<KMOACDBBKNB> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CLHNBKBGCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6AB06B0", Offset = "0x6AAF4B0", VA = "0x186AB06B0")]
		internal void PKGCEKEEDOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class PLNFDHJKPHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public POBEFJEEBBJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public DLKAMMPEIKM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public PLNFDHJKPHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6AF0", Offset = "0x6AC58F0", VA = "0x186AC6AF0")]
		internal void GKKDJDLGLLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class HLEMBPNOMFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public POBEFJEEBBJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public DLKAMMPEIKM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HLEMBPNOMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEB50", Offset = "0x6ABD950", VA = "0x186ABEB50")]
		internal void NAKJLDGECPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class DCJAGEKDOOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public POBEFJEEBBJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public DLKAMMPEIKM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DCJAGEKDOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5600", Offset = "0x6AB4400", VA = "0x186AB5600")]
		internal void BPGDPHKOMJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const IICOCBILMDB FGHLLHFELPI = IICOCBILMDB.Cancelled | IICOCBILMDB.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly AIHCOJBADIL APEAAJPNJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] DHEMLBOOADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<IICOCBILMDB> OBIKAJFJAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> FKHJFCLHKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> DLBKIOEKLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> LLMJIMCEMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> GGKBBIPDMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> CLAIKEGAGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> PJAOLJKFAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private POBEFJEEBBJ[] PAGNJPKMHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private FCIIKDHMPHB[] KEEHFIHBBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private PJINDEFEPHD[] OAEJOIEMPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<KMOACDBBKNB>[] AKPIGOKHLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KMOACDBBKNB[] DJNAKPJNLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int CLANPIPMDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int GIOLCDOMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int PMLCCAFBPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float AIFOGEMAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private CINLFBJGLAC JAACAFNBIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle PKLMHBKCHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<POBEFJEEBBJ> MAHHFAAGNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool LHDDBPDJMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> JJEGFBFJIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> JMGEJGFKGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool FMAGMELLPFG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public KABLCGBPNAN[] PNCFFDHBOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA1CC70", Offset = "0xA1BA70", VA = "0x180A1CC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6AB76C0", Offset = "0x6AB64C0", VA = "0x186AB76C0")]
	private static int LJELLNOOPJN(AIHCOJBADIL APEAAJPNJOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7D90", Offset = "0x6AB6B90", VA = "0x186AB7D90")]
	public DLKAMMPEIKM(AIHCOJBADIL APEAAJPNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7BB0", Offset = "0x6AB69B0", VA = "0x186AB7BB0")]
	private void PLBLMEOOHBK(int MJCLDGINFBA, int FIHACGGBBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5DC0", Offset = "0x6AB4BC0", VA = "0x186AB5DC0")]
	public void CNOIEHHELAI(PJINDEFEPHD EJDIFPAIGMC, KMOACDBBKNB EINOPHBHANG, IEnumerator<KMOACDBBKNB> CFAFCJOEHPA, FCIIKDHMPHB LMKBOALMHHB, [Optional] POBEFJEEBBJ NELNJCAEMLL, IICOCBILMDB IOMJMIPIJBJ = IICOCBILMDB.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6CB0", Offset = "0x6AB5AB0", VA = "0x186AB6CB0")]
	public void EMBCACFGACK(IEnumerable<KGANFAMNCEC> MHDPEPKPMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5F40", Offset = "0x6AB4D40", VA = "0x186AB5F40")]
	private KGANFAMNCEC COGOPAGFCEJ(int BAOGBEKJLAA)
	{
		return default(KGANFAMNCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5A50", Offset = "0x6AB4850", VA = "0x186AB5A50")]
	private void BJINIJMCKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2758B20", Offset = "0x2757920", VA = "0x182758B20")]
	private static void HCEAGEOKDHP<T>(int BAOGBEKJLAA, T[] EBBDKIEJLFF, int CGDBKIJPKOF, [Optional] T FDALPCLKKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2758B70", Offset = "0x2757970", VA = "0x182758B70")]
	private static void HCEAGEOKDHP<T>(int BAOGBEKJLAA, NativeArray<T> EBBDKIEJLFF, int CGDBKIJPKOF, [Optional] T FDALPCLKKEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB76F0", Offset = "0x6AB64F0", VA = "0x186AB76F0")]
	private void LMNMHDKPHCG(IEnumerable<KGANFAMNCEC> MHDPEPKPMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7300", Offset = "0x6AB6100", VA = "0x186AB7300")]
	private void IEDJEJNEPKE(KGANFAMNCEC NGEKELHALGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6EF0", Offset = "0x6AB5CF0", VA = "0x186AB6EF0")]
	private JHOAAHKELGB FIMEDJLJLEO(int MPKEPJIGFNP)
	{
		return default(JHOAAHKELGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB74C0", Offset = "0x6AB62C0", VA = "0x186AB74C0")]
	public void LJCPOEHLGKF(float EIJMBHBKALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7280", Offset = "0x6AB6080", VA = "0x186AB7280")]
	private void IAEHNOAJBAG(Action CGAHKNIFIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6540", Offset = "0x6AB5340", VA = "0x186AB6540")]
	private void EIOJONCDPGN(Action CGAHKNIFIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AB65C0", Offset = "0x6AB53C0", VA = "0x186AB65C0")]
	public void EKBFDGFMLPI(float EIJMBHBKALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB73C0", Offset = "0x6AB61C0", VA = "0x186AB73C0")]
	public void KGELIFGGPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7A80", Offset = "0x6AB6880", VA = "0x186AB7A80")]
	public void NAFIDGCMLCM(POBEFJEEBBJ HBABEGLHNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7150", Offset = "0x6AB5F50", VA = "0x186AB7150")]
	public void HJBHNIDOLLE(POBEFJEEBBJ HBABEGLHNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6410", Offset = "0x6AB5210", VA = "0x186AB6410")]
	public void EBJELDAHOCH(POBEFJEEBBJ HBABEGLHNKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ALAELGMOGFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly ALAELGMOGFE CNCELEPFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action ANEGJLMNFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool KJIMDOIMIPD;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public ALAELGMOGFE(Action ANEGJLMNFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x62CCD50", Offset = "0x62CBB50", VA = "0x1862CCD50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface DOPLMBOKEKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NIAPAMPKGNM(UnityEngine.Object EJDIFPAIGMC, Action<T> DANHKJMMAIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface JENMMCFHBKG<T> : DOPLMBOKEKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class ECDMFMEFANG<T> : JENMMCFHBKG<T>, DOPLMBOKEKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class JEFFIOFMBMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public ECDMFMEFANG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public KGCPBIMDGMA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JEFFIOFMBMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C1ED30", Offset = "0x3C1DB30", VA = "0x183C1ED30")]
		internal void LHADDMPOFPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject HBCOFCCKGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<KGCPBIMDGMA<UnityEngine.Object, Action<T>>> HGHBJHMKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T BJBKDOFCAAO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3476970", Offset = "0x3475770", VA = "0x183476970", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x34769E0", Offset = "0x34757E0", VA = "0x1834769E0")]
	private static bool KMMNFGBAGML(T CGAHKNIFIAB, T CJOKOOBKDLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3476E80", Offset = "0x3475C80", VA = "0x183476E80")]
	public ECDMFMEFANG(T NENHBEFHIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3476AD0", Offset = "0x34758D0", VA = "0x183476AD0", Slot = "6")]
	public IDisposable NIAPAMPKGNM(UnityEngine.Object EJDIFPAIGMC, Action<T> DANHKJMMAIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3476310", Offset = "0x3475110", VA = "0x183476310")]
	private void BDIMKJMJKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class OOAGLGALLDB : BKIPPNAKMAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly LOCKJLIIGOB PJGOLCHPGEA;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5E80", Offset = "0x6AC4C80", VA = "0x186AC5E80")]
	[DPHBJKOLDBD(OHNOEEJKPCM.None)]
	private static void LLBAHKJCIHJ(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	[Preserve]
	internal OOAGLGALLDB([PENMPEOFMMN(null)] LOCKJLIIGOB PJGOLCHPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5DD0", Offset = "0x6AC4BD0", VA = "0x186AC5DD0", Slot = "4")]
	public IDisposable IHCCJGDNINL(float PKLIIDKKFHI, Action<float> KPIAINDMMOB, bool PFMPJGINEHF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class MOKCECBELDO : LFFLMCGBPJD, LOCKJLIIGOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private DLKAMMPEIKM[] DJLAOJNMIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private KMIBHKLCJHB CHAOOPDOKEI;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AC50D0", Offset = "0x6AC3ED0", VA = "0x186AC50D0")]
	[DPHBJKOLDBD(OHNOEEJKPCM.None)]
	private static void LLBAHKJCIHJ(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5460", Offset = "0x6AC4260", VA = "0x186AC5460")]
	[Preserve]
	public MOKCECBELDO([PENMPEOFMMN(null)] FAOIOJHJAFB KIBGICOMONC, [PENMPEOFMMN(null)] DHPKJCMEHAE EOEDJHJOPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC51C0", Offset = "0x6AC3FC0", VA = "0x186AC51C0", Slot = "16")]
	public override DPFFPCFAMJN NFIGGAJHIIH(PJINDEFEPHD EJDIFPAIGMC, IEnumerator<KMOACDBBKNB> DLGNEDMAFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4D20", Offset = "0x6AC3B20", VA = "0x186AC4D20", Slot = "17")]
	public override void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4AC0", Offset = "0x6AC38C0", VA = "0x186AC4AC0", Slot = "19")]
	public override void EFBFJFHHLAB(AIHCOJBADIL APEAAJPNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC52F0", Offset = "0x6AC40F0", VA = "0x186AC52F0", Slot = "18")]
	protected override void PHAFDIODDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4CF0", Offset = "0x6AC3AF0", VA = "0x186AC4CF0")]
	private DLKAMMPEIKM HDBGFNEOGIO(AIHCOJBADIL DDEINLAGLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4840", Offset = "0x6AC3640", VA = "0x186AC4840", Slot = "20")]
	internal override BEAKOIJIFJN DLPDLIKKNPI(IEnumerator<KMOACDBBKNB> DLGNEDMAFLI, Behaviour EJDIFPAIGMC, FCIIKDHMPHB LMKBOALMHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5140", Offset = "0x6AC3F40", VA = "0x186AC5140", Slot = "21")]
	internal override GICFJODHBBJ NAOKBNMBMMO(AIHCOJBADIL AFCPPEOPCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4FB0", Offset = "0x6AC3DB0", VA = "0x186AC4FB0")]
	private void IFAMAEHDKFG(DLKAMMPEIKM PCKCMLMGNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4A60", Offset = "0x6AC3860", VA = "0x186AC4A60", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct CINLFBJGLAC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float NOJNKFEIIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int KKPLJMGNAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> JOOFJPGKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> MFKMDBJMIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> KLGPICEMHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<IICOCBILMDB> PBJCDNCKMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> POKFKKPKGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> GGKBBIPDMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> DLBKIOEKLCL;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0150", Offset = "0x6AAEF50", VA = "0x186AB0150")]
	public static CINLFBJGLAC ANGJMEBBFOG(int BEPDHHCJNHC, float EIJMBHBKALN, NativeArray<IICOCBILMDB> HNDOCOCJOHJ, NativeArray<float> NDBNFBKLIBN, NativeArray<int> HBIMFEMNDDG, NativeArray<int> PGKKEKHLMOD, NativeArray<int> KMFKIFIHDEL, NativeArray<int> MFKMDBJMIHC, NativeArray<int> KLGPICEMHBG)
	{
		return default(CINLFBJGLAC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0320", Offset = "0x6AAF120", VA = "0x186AB0320", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0640", Offset = "0x6AAF440", VA = "0x186AB0640")]
	private bool IKMKGMBFFCH(int AELAKOMEEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0680", Offset = "0x6AAF480", VA = "0x186AB0680")]
	private void MCEKMHNPIAL(NativeArray<int> IIEPPHLALMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB01B0", Offset = "0x6AAEFB0", VA = "0x186AB01B0")]
	private int DFNFKDPNFHL(int GCLJDJDENJG, int ELKADBAAPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0250", Offset = "0x6AAF050", VA = "0x186AB0250")]
	private void DHNIPECDCEH(NativeArray<int> IIEPPHLALMH, int BJKIMIGANDM, int HFJACMIAHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0400", Offset = "0x6AAF200", VA = "0x186AB0400")]
	private void GEHKLPLLFGE(NativeArray<int> IIEPPHLALMH, int CCHIJPPBMHC, int DKCBOLHJJIA, int HKDAHIHLOGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class LFFLMCGBPJD : LOCKJLIIGOB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly FAOIOJHJAFB KIBGICOMONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly DHPKJCMEHAE EOEDJHJOPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private GICFJODHBBJ[] LLGJIPMPGIM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static LOCKJLIIGOB LLCJIHIKEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1120", Offset = "0x6ABFF20", VA = "0x186AC1120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool HLCDKGLKBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AIHCOJBADIL OEDKCJJHMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AIHCOJBADIL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FE0", Offset = "0x7B3DE0", VA = "0x1807B4FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DHPKJCMEHAE NDLOEEMPJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KMOACDBBKNB FOPADNOKCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1F90", Offset = "0x6AC0D90", VA = "0x186AC1F90")]
	public static DPFFPCFAMJN MPDHNJNCOLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2060", Offset = "0x6AC0E60", VA = "0x186AC2060")]
	[Preserve]
	protected LFFLMCGBPJD([PENMPEOFMMN(null)] FAOIOJHJAFB KIBGICOMONC, [PENMPEOFMMN(null)] DHPKJCMEHAE EOEDJHJOPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1170", Offset = "0x6ABFF70", VA = "0x186AC1170", Slot = "6")]
	public DPFFPCFAMJN AHOFDHJJGBG(IEnumerator<KMOACDBBKNB> DLGNEDMAFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1180", Offset = "0x6ABFF80", VA = "0x186AC1180", Slot = "7")]
	public DPFFPCFAMJN AHOFDHJJGBG(Behaviour EJDIFPAIGMC, IEnumerator<KMOACDBBKNB> DLGNEDMAFLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract DPFFPCFAMJN NFIGGAJHIIH(PJINDEFEPHD EJDIFPAIGMC, IEnumerator<KMOACDBBKNB> DLGNEDMAFLI);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1980", Offset = "0x6AC0780", VA = "0x186AC1980", Slot = "17")]
	public virtual void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1B80", Offset = "0x6AC0980", VA = "0x186AC1B80", Slot = "9")]
	public void LFMMCKMPIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2040", Offset = "0x6AC0E40", VA = "0x186AC2040", Slot = "18")]
	protected virtual void PHAFDIODDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC18E0", Offset = "0x6AC06E0", VA = "0x186AC18E0")]
	private void FPKHNPOEMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2020", Offset = "0x6AC0E20", VA = "0x186AC2020")]
	private void PADBOIBKBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1B60", Offset = "0x6AC0960", VA = "0x186AC1B60")]
	private void JAGFKKAKGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1470", Offset = "0x6AC0270", VA = "0x186AC1470")]
	private void DJCHEMFHOPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1B40", Offset = "0x6AC0940", VA = "0x186AC1B40")]
	private void IDDEMMAIILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1B20", Offset = "0x6AC0920", VA = "0x186AC1B20")]
	private void HPKDPKJFLOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1960", Offset = "0x6AC0760", VA = "0x186AC1960")]
	private void GKCPLHPICJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1850", Offset = "0x6AC0650", VA = "0x186AC1850", Slot = "19")]
	public virtual void EFBFJFHHLAB(AIHCOJBADIL APEAAJPNJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1DC0", Offset = "0x6AC0BC0", VA = "0x186AC1DC0")]
	private void MEDFDNMGMFM(GICFJODHBBJ PCKCMLMGNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D45ED0", Offset = "0x1D44CD0", VA = "0x181D45ED0")]
	private GICFJODHBBJ GONBHNENFNG(AIHCOJBADIL DDEINLAGLLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract BEAKOIJIFJN DLPDLIKKNPI(IEnumerator<KMOACDBBKNB> DLGNEDMAFLI, Behaviour MBBOOCKAMOE, FCIIKDHMPHB MBGILEOHHHC);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract GICFJODHBBJ NAOKBNMBMMO(AIHCOJBADIL APEAAJPNJOJ);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1490", Offset = "0x6AC0290", VA = "0x186AC1490", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1900", Offset = "0x6AC0700", VA = "0x186AC1900", Slot = "12")]
	public KMOACDBBKNB GDEPOJBNDFE(AIHCOJBADIL AFCPPEOPCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1380", Offset = "0x6AC0180", VA = "0x186AC1380", Slot = "13")]
	public KMOACDBBKNB BOMIAOEOJPE(float GKFGFCFKANC, AIHCOJBADIL AFCPPEOPCNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC1410", Offset = "0x6AC0210", VA = "0x186AC1410", Slot = "14")]
	public KMOACDBBKNB CKGIDMDOGOL(Func<bool> CBAOJAAOCLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class BEAKOIJIFJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FCIIKDHMPHB LMKBOALMHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly MKKDJEAFIEC EJDIFPAIGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool JCPKLHBGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string PHEKPMAPPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace PADCBDGGFND;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<KMOACDBBKNB> MCLGDHAGIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KMOACDBBKNB GEEKIACIKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool KECABHJEKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6AADA70", Offset = "0x6AAC870", VA = "0x186AADA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool GOEKPDIACPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x879BE0", Offset = "0x8789E0", VA = "0x180879BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x879D00", Offset = "0x878B00", VA = "0x180879D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD850", Offset = "0x6AAC650", VA = "0x186AAD850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float CBFOIPLNHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1127190", Offset = "0x1125F90", VA = "0x181127190")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x57F8260", Offset = "0x57F7060", VA = "0x1857F8260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6AADF30", Offset = "0x6AACD30", VA = "0x186AADF30")]
	public BEAKOIJIFJN(IEnumerator<KMOACDBBKNB> CFAFCJOEHPA, MKKDJEAFIEC EJDIFPAIGMC, FCIIKDHMPHB LMKBOALMHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6AADB40", Offset = "0x6AAC940", VA = "0x186AADB40")]
	public KMOACDBBKNB PMAOCDFPNBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6AADA00", Offset = "0x6AAC800", VA = "0x186AADA00")]
	public bool DFAMBMFDLNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6AADAF0", Offset = "0x6AAC8F0", VA = "0x186AADAF0")]
	public void NAFIDGCMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6AADE50", Offset = "0x6AACC50", VA = "0x186AADE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9061A0", Offset = "0x904FA0", VA = "0x1809061A0")]
	[CompilerGenerated]
	private void LLKGEBHFGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class FCIIKDHMPHB : IKFJONDKNGE, DPFFPCFAMJN, EEFNJOFHHBM, LKLLCIBDBNN, IEnumerator, KMOACDBBKNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private AIHCOJBADIL LHAOKCFNKBG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private AIHCOJBADIL EOPACJBLKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xEA70F0", Offset = "0xEA5EF0", VA = "0x180EA70F0", Slot = "23")]
		get
		{
			return default(AIHCOJBADIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public AIHCOJBADIL HIIBNDGIEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x13BFD60", Offset = "0x13BEB60", VA = "0x1813BFD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float BFHOFDHLJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8C6570", Offset = "0x8C5370", VA = "0x1808C6570", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool OEBGDIOOLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9CF0", Offset = "0x6AB8AF0", VA = "0x186AB9CF0", Slot = "24")]
	private bool BMFPJDOMGJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9D10", Offset = "0x6AB8B10", VA = "0x186AB9D10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9D20", Offset = "0x6AB8B20", VA = "0x186AB9D20")]
	public FCIIKDHMPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum JHOAAHKELGB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal sealed class GICFJODHBBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum IJPLHLPJHGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct AKGFAGOMOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AIHCOJBADIL CBHGDADBCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public IJPLHLPJHGB NAKBGBLJCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<BEAKOIJIFJN> AEGACBFNNNF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly IJPLHLPJHGB[] FAKBCAKDCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly AIHCOJBADIL APEAAJPNJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool ECIJLMBEDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly BEAKOIJIFJN[] FAPHIDNNNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<BEAKOIJIFJN> HBPAELMKDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> JNCHDBNPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<BEAKOIJIFJN> OLFFJPNCHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> BHLCADJHHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly KMIBHKLCJHB BNOFNDHINHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool FMAGMELLPFG;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public AKGFAGOMOCN[,] ONOHNOLEJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7AE540", Offset = "0x7AD340", VA = "0x1807AE540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC2F0", Offset = "0x6ABB0F0", VA = "0x186ABC2F0")]
	public GICFJODHBBJ(AIHCOJBADIL AFCPPEOPCNC, KMIBHKLCJHB BNOFNDHINHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBF40", Offset = "0x6ABAD40", VA = "0x186ABBF40")]
	public void PGIAIGEAFCM(BEAKOIJIFJN CFAFCJOEHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB1C0", Offset = "0x6AB9FC0", VA = "0x186ABB1C0")]
	public void ECLECHGJOOC(IList<BEAKOIJIFJN> FBCDDPICMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB5F0", Offset = "0x6ABA3F0", VA = "0x186ABB5F0")]
	public void JPFMEJMNKKD(IList<BEAKOIJIFJN> FBCDDPICMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB4A0", Offset = "0x6ABA2A0", VA = "0x186ABB4A0")]
	private void JMHLPKOHDBL(BEAKOIJIFJN CFAFCJOEHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBDC0", Offset = "0x6ABABC0", VA = "0x186ABBDC0")]
	private void NDAFJLKHNLI(IList<BEAKOIJIFJN> FBCDDPICMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABADE0", Offset = "0x6AB9BE0", VA = "0x186ABADE0")]
	private JHOAAHKELGB ABDLONOPBCA(BEAKOIJIFJN CFAFCJOEHPA)
	{
		return default(JHOAAHKELGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC050", Offset = "0x6ABAE50", VA = "0x186ABC050")]
	public void PHAFDIODDDG(float EIJMBHBKALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBBD0", Offset = "0x6ABA9D0", VA = "0x186ABBBD0")]
	public void LFMMCKMPIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB8D0", Offset = "0x6ABA6D0", VA = "0x186ABB8D0")]
	private void KJIPOHJPPEA(List<BEAKOIJIFJN> FBCDDPICMOJ, Stack<int> CBINJPCPNOG, bool PEAMGJDBJKP, float LFOCPDPDEEB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB0A0", Offset = "0x6AB9EA0", VA = "0x186ABB0A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAF60", Offset = "0x6AB9D60", VA = "0x186ABAF60")]
	private void BANELBPBPCP(List<BEAKOIJIFJN> FBCDDPICMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class OJJCAKLANKP : KMIBHKLCJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public void GDMMIIOGHHN(string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
	public void EOGGAJEMHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OJJCAKLANKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class IAJCIFEEKEE : MKKDJEAFIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour MBBOOCKAMOE;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEB90", Offset = "0x6ABD990", VA = "0x186ABEB90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LDNDMEBKADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC30", Offset = "0x6ABDA30", VA = "0x186ABEC30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NIGBENPLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC10", Offset = "0x6ABDA10", VA = "0x186ABEC10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x1807B1CB0")]
	public IAJCIFEEKEE(Behaviour MBBOOCKAMOE)
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

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
public class ELBGAJOMFDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority CCNBJCFEJEN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6E00", Offset = "0x6CB6000", VA = "0x186CB6E00")]
	public ELBGAJOMFDH(ThreadPriority CFMHFICCGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6DF0", Offset = "0x6CB5FF0", VA = "0x186CB6DF0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> BCMONHPOJMM(List<PlayerLoopSystem> CEMOGLNJAIJ, int DDPCPHBHLOI);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct BPLKFNOMOLA
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EHHEJFAHDEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static OJHEJHCKNBB DLIMNDHNOBI;

				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x6CB6270", Offset = "0x6CB5470", VA = "0x186CB6270")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct ALGBJNMPCAD
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static OJHEJHCKNBB GLNONMKICNM;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6CAC450", Offset = "0x6CAB650", VA = "0x186CAC450")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct FKHHNFPLGAM
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static OJHEJHCKNBB EAOAHNAFAIH;

				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x6CB7930", Offset = "0x6CB6B30", VA = "0x186CB7930")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct EKDEBKOOKHE
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static OJHEJHCKNBB MMJLGGEGJMJ;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static OJHEJHCKNBB GKKABGHDPJP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static OJHEJHCKNBB JHNKBBMMIKJ;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static OJHEJHCKNBB KKANDBBDCDA;

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x6CB69F0", Offset = "0x6CB5BF0", VA = "0x186CB69F0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct ACECLBJPLDK
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static OJHEJHCKNBB DMMPJHNHPCJ;

				[Cpp2IlInjected.Token(Token = "0x6000020")]
				[Cpp2IlInjected.Address(RVA = "0x6CA87A0", Offset = "0x6CA79A0", VA = "0x186CA87A0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct HFHKBHCIJNP
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static OJHEJHCKNBB MMJLGGEGJMJ;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static OJHEJHCKNBB GKKABGHDPJP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static OJHEJHCKNBB JHNKBBMMIKJ;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static OJHEJHCKNBB KKANDBBDCDA;

				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x6CBA1E0", Offset = "0x6CB93E0", VA = "0x186CBA1E0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MHNHGEHFCGO
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static OJHEJHCKNBB AJCGONNKLAF;

				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x6CC11D0", Offset = "0x6CC03D0", VA = "0x186CC11D0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct COEJIJGFPHO
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static OJHEJHCKNBB LHPMIJIDGFD;

				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6CAF9D0", Offset = "0x6CAEBD0", VA = "0x186CAF9D0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct PDFIGBJBNFG
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static OJHEJHCKNBB HDJBLMPJKCH;

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6CC3220", Offset = "0x6CC2420", VA = "0x186CC3220")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct CILMDJNDFOM
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static OJHEJHCKNBB BCBDJBPALCJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6CAF2A0", Offset = "0x6CAE4A0", VA = "0x186CAF2A0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct AMGHGEKHPMC
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static OJHEJHCKNBB HCKADMFPFMI;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6CAC650", Offset = "0x6CAB850", VA = "0x186CAC650")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct FCGMJBLHBFH
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static OJHEJHCKNBB JKMAIBENMFP;

				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x6CB6FA0", Offset = "0x6CB61A0", VA = "0x186CB6FA0")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct MLKEJPDANFA
			{
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public static OJHEJHCKNBB HLFNAHGKJHB;

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6CC1E00", Offset = "0x6CC1000", VA = "0x186CC1E00")]
				public static PlayerLoopSystem PPBLPGCCDOK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public enum KBMNLPLHPLC : byte
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
			public struct BNBJKGGCAHC
			{
				[Cpp2IlInjected.Token(Token = "0x2000022")]
				[CompilerGenerated]
				private sealed class BDGLPFFOLHN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public KBMNLPLHPLC updateStage;

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
					public BDGLPFFOLHN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000050")]
					[Cpp2IlInjected.Address(RVA = "0x6CADC80", Offset = "0x6CACE80", VA = "0x186CADC80")]
					internal void IDGODAKHHHJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public static HKGPCDCMJHO<KBMNLPLHPLC> OEOMMPKKMIC;

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x6CAEE60", Offset = "0x6CAE060", VA = "0x186CAEE60")]
				public static PlayerLoopSystem PPBLPGCCDOK(KBMNLPLHPLC BGGLEMBLGLH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000023")]
			internal struct HNPHLJOEAFO
			{
				[Cpp2IlInjected.Token(Token = "0x2000024")]
				[CompilerGenerated]
				private sealed class BLDKHADNJJL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public DDFGKFMNLJD.ICIODDJOLIJ key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
					public BLDKHADNJJL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x6CAEC20", Offset = "0x6CADE20", VA = "0x186CAEC20")]
					internal void IEACIAIHMCP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public static IDisposable HHFMKPFMHKJ;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x6CBAE80", Offset = "0x6CBA080", VA = "0x186CBAE80")]
				public static PlayerLoopSystem AKKOICBGHDL(DDFGKFMNLJD.ICIODDJOLIJ MNOIAMGNLNL)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			internal struct JLBDLEIMAFF
			{
				[Cpp2IlInjected.Token(Token = "0x2000027")]
				[CompilerGenerated]
				private sealed class DMEPNHEHAIO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					public DDFGKFMNLJD.ICIODDJOLIJ key;

					[Cpp2IlInjected.Token(Token = "0x6000058")]
					[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
					public DMEPNHEHAIO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0x6CB41B0", Offset = "0x6CB33B0", VA = "0x186CB41B0")]
					internal void IEACIAIHMCP()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6CBC4D0", Offset = "0x6CBB6D0", VA = "0x186CBC4D0")]
				public static PlayerLoopSystem AKKOICBGHDL(DDFGKFMNLJD.ICIODDJOLIJ MNOIAMGNLNL)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class ACAMEJDDCLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ACAMEJDDCLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6CA8680", Offset = "0x6CA7880", VA = "0x186CA8680")]
			internal List<PlayerLoopSystem> FKFGCCOELEO(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool FLMCPLBOBAJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool EPNGKJPECCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6CB30D0", Offset = "0x6CB22D0", VA = "0x186CB30D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6CB04D0", Offset = "0x6CAF6D0", VA = "0x186CB04D0")]
		private static void KEAGALCEIGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3110", Offset = "0x6CB2310", VA = "0x186CB3110")]
		private static void NPDFGJJOLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFD00", Offset = "0x6CAEF00", VA = "0x186CAFD00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFF30", Offset = "0x6CAF130", VA = "0x186CAFF30")]
		private static void EALOANJEBHP(DDFGKFMNLJD.ICIODDJOLIJ MNOIAMGNLNL, PlayerLoopSystem OMNJCGKOHJI, Type NMJLPPAFLEN, Type AHDHJFCCDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6CB00F0", Offset = "0x6CAF2F0", VA = "0x186CB00F0")]
		private static void FAGEJBGHKBL(PlayerLoopSystem OMNJCGKOHJI, Type NMJLPPAFLEN, Type AHDHJFCCDBE, BCMONHPOJMM EGDMMFFPGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CAFBD0", Offset = "0x6CAEDD0", VA = "0x186CAFBD0")]
		private static void APODMMLODEG(PlayerLoopSystem OMNJCGKOHJI, Type NMJLPPAFLEN, Type AHDHJFCCDBE, PlayerLoopSystem? EDDGFLDNNHJ, PlayerLoopSystem? FLKLGHGEGDD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DDFGKFMNLJD
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum ICIODDJOLIJ
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
	public class AHALCGAOIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly ICIODDJOLIJ KKAMDIKILJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly JLGFPFGCLMA BENAMMABNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private long GLBNBBAOIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private long LJNEEFIFFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public long GNBFIFGAILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int NIPPGLOENDI;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA800", Offset = "0x6CA9A00", VA = "0x186CAA800")]
		public AHALCGAOIFO(ICIODDJOLIJ COMKOIGLOBP, int JJNAMCNAEBL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA790", Offset = "0x6CA9990", VA = "0x186CAA790")]
		public void OBFNLPNHIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA740", Offset = "0x6CA9940", VA = "0x186CAA740")]
		public void KLDLDOHCENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA560", Offset = "0x6CA9760", VA = "0x186CAA560")]
		public void KDHMBADMGCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static ICIODDJOLIJ[] DIBPDNNDNBC;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static AHALCGAOIFO[] NHIJAMNLJHN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3C70", Offset = "0x6CB2E70", VA = "0x186CB3C70")]
	public static AHALCGAOIFO ELEJIHFDLJC(ICIODDJOLIJ MNOIAMGNLNL, int JJNAMCNAEBL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3C00", Offset = "0x6CB2E00", VA = "0x186CB3C00")]
	public static AHALCGAOIFO CKAOLFCAHGA(ICIODDJOLIJ MNOIAMGNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3E50", Offset = "0x6CB3050", VA = "0x186CB3E50")]
	public static void GONGMOHONOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JLGFPFGCLMA : HLBHGJMDPAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int ONLEBMHHHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Queue<double> CNJCABFLHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private double EEMOHNLEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private double GINACGGICNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private double COEHBMCFMDG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double FHLBPFIMPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC600", Offset = "0x6CBB800", VA = "0x186CBC600", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double BOOPGDKEGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x19880F0", Offset = "0x19872F0", VA = "0x1819880F0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JEIMPDEKLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E62DA0", Offset = "0x1E61FA0", VA = "0x181E62DA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC7F0", Offset = "0x6CBB9F0", VA = "0x186CBC7F0")]
	public JLGFPFGCLMA(int DMGNHFFPMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC6D0", Offset = "0x6CBB8D0", VA = "0x186CBC6D0", Slot = "7")]
	public void EGNOJMOMPNH(double LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC660", Offset = "0x6CBB860", VA = "0x186CBC660", Slot = "8")]
	public void CFPPHLPBNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GDOPIGLFGJG : HLBHGJMDPAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private long BIFLOKBJAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private double KGLLJBNEDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private double PFALKNLECCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private double JFHEEECHLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private double LODBKOBJAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private double EEMOHNLEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private double GINACGGICNB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BOOPGDKEGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x59C8D00", Offset = "0x59C7F00", VA = "0x1859C8D00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEIMPDEKLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x59C91E0", Offset = "0x59C83E0", VA = "0x1859C91E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BEBOCJFEIMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x59C8D40", Offset = "0x59C7F40", VA = "0x1859C8D40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FHLBPFIMPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2420080", Offset = "0x241F280", VA = "0x182420080", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8CD0", Offset = "0x6CB7ED0", VA = "0x186CB8CD0", Slot = "7")]
	public virtual void EGNOJMOMPNH(double LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8C90", Offset = "0x6CB7E90", VA = "0x186CB8C90", Slot = "8")]
	public virtual void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8B50", Offset = "0x6CA7D50", VA = "0x186CA8B50")]
	public GDOPIGLFGJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class AGDBOGNLPPK : GDOPIGLFGJG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double BIAAIBJILJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x59C8D90", Offset = "0x59C7F90", VA = "0x1859C8D90")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x59C8D30", Offset = "0x59C7F30", VA = "0x1859C8D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8A20", Offset = "0x6CA7C20", VA = "0x186CA8A20", Slot = "7")]
	public override void EGNOJMOMPNH(double LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA89E0", Offset = "0x6CA7BE0", VA = "0x186CA89E0", Slot = "8")]
	public override void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8B50", Offset = "0x6CA7D50", VA = "0x186CA8B50")]
	public AGDBOGNLPPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface HLBHGJMDPAA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double FHLBPFIMPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double BOOPGDKEGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JEIMPDEKLIF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BHNGHFFPBAK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private interface DEPICPEHCJL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool HHAGAEEGGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JDPAOPOAJJL();
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private abstract class EDPPJEMHGDL<TPromise, TMainThreadPromise> : DEPICPEHCJL where TPromise : BNCJCHBDCBI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly TPromise JAKKANAOBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly TMainThreadPromise EDDGFCHLJKE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise DOBLNFMHAOI
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3570F40", Offset = "0x3570140", VA = "0x183570F40")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HHAGAEEGGDN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3570EF0", Offset = "0x35700F0", VA = "0x183570EF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D1780", Offset = "0x7D0980", VA = "0x1807D1780")]
		protected EDPPJEMHGDL(TPromise JAKKANAOBLO, TMainThreadPromise PKFDNLDCFCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3570FA0", Offset = "0x35701A0", VA = "0x183570FA0", Slot = "5")]
		public void JDPAOPOAJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void MGIFOFIJFHD(TPromise JAKKANAOBLO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private class CBELNNGEMNI<T> : EDPPJEMHGDL<PMIHBBCEMHD<T>, ACKCNCGOGDB<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5050", Offset = "0x4EA4250", VA = "0x184EA5050")]
		public CBELNNGEMNI(PMIHBBCEMHD<T> JAKKANAOBLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4E20", Offset = "0x4EA4020", VA = "0x184EA4E20", Slot = "6")]
		protected override void MGIFOFIJFHD(PMIHBBCEMHD<T> JAKKANAOBLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0F00", Offset = "0x3CF0100", VA = "0x183CF0F00")]
		[CompilerGenerated]
		private void CPCFPHGFPCB(T JBENFHJBMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5020", Offset = "0x4EA4220", VA = "0x184EA5020")]
		[CompilerGenerated]
		private void OBONNLBEOHP(string KFNIFKKFLAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class GFKBKBCJGJK : DEPICPEHCJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Action BGMBJALDBDD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HHAGAEEGGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
		public GFKBKBCJGJK(Action BGMBJALDBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x87B7C0", Offset = "0x87A9C0", VA = "0x18087B7C0", Slot = "5")]
		public void JDPAOPOAJJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly List<DEPICPEHCJL> LMLBEJLCIHL;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27759B0", Offset = "0x2774BB0", VA = "0x1827759B0")]
	public static PMIHBBCEMHD<T> NCCLEAEBPJD<T>(this PMIHBBCEMHD<T> JAKKANAOBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE590", Offset = "0x6CAD790", VA = "0x186CAE590")]
	public static void NCCLEAEBPJD(Action BGMBJALDBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27758F0", Offset = "0x2774AF0", VA = "0x1827758F0")]
	private static PMIHBBCEMHD<T> IOMDMHNAKKN<T>(PMIHBBCEMHD<T> JAKKANAOBLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE910", Offset = "0x6CADB10", VA = "0x186CAE910")]
	private static void PLBKAAOHBFI(DEPICPEHCJL EPFCFACKEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE630", Offset = "0x6CAD830", VA = "0x186CAE630")]
	private static void OFDGCJALDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE490", Offset = "0x6CAD690", VA = "0x186CAE490")]
	private static void MDBFBEBIBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE3B0", Offset = "0x6CAD5B0", VA = "0x186CAE3B0")]
	private static void DNOAGBLACIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AGLLKNFBAKN
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct FIMFACEILJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TaskCompletionSource<Scene> NKNFNFDBKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly string OBIFCNHIBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly LoadSceneMode AGBNFNPFOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool FKFMBKPLPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly CEIEAABKFOO<string>.DDLAMDHALOK IPCCBANMNNI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB78D0", Offset = "0x6CB6AD0", VA = "0x186CB78D0")]
		public FIMFACEILJA(TaskCompletionSource<Scene> ANAAMEIIOFB, string OBIFCNHIBDF, LoadSceneMode AGBNFNPFOKO, bool FKFMBKPLPKC, CEIEAABKFOO<string>.DDLAMDHALOK IPCCBANMNNI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct IBPCGAMEDEP : IAsyncStateMachine
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
		public CEIEAABKFOO<string>.DDLAMDHALOK stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private CEIEAABKFOO<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x6CBAFB0", Offset = "0x6CBA1B0", VA = "0x186CBAFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB850", Offset = "0x6CBAA50", VA = "0x186CBB850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GHMDOKMDIPP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6CB8DF0", Offset = "0x6CB7FF0", VA = "0x186CB8DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9110", Offset = "0x6CB8310", VA = "0x186CB9110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct GJLBOKEOHBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private FIMFACEILJA <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9170", Offset = "0x6CB8370", VA = "0x186CB9170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9520", Offset = "0x6CB8720", VA = "0x186CB9520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class JMPKGHLIAGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public ACKCNCGOGDB<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JMPKGHLIAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD1F0", Offset = "0x6CBC3F0", VA = "0x186CBD1F0")]
		internal void OHONLIOHFNP()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct IMOIOJNBBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CEIEAABKFOO<string>.DDLAMDHALOK stackTimer;

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
		private JMPKGHLIAGM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private CEIEAABKFOO<string>.DDLAMDHALOK <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private CEIEAABKFOO<string>.DDLAMDHALOK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB8C0", Offset = "0x6CBAAC0", VA = "0x186CBB8C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC460", Offset = "0x6CBB660", VA = "0x186CBC460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CJFDAFPGOJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private AsyncOperationHandle<SceneInstance> <handle>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter<SceneInstance> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF4A0", Offset = "0x6CAE6A0", VA = "0x186CAF4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF960", Offset = "0x6CAEB60", VA = "0x186CAF960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct DNJBGJAEEAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CEIEAABKFOO<string>.DDLAMDHALOK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private CEIEAABKFOO<string>.DDLAMDHALOK <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private CEIEAABKFOO<string>.DDLAMDHALOK <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4420", Offset = "0x6CB3620", VA = "0x186CB4420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CB4F70", Offset = "0x6CB4170", VA = "0x186CB4F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DAIBBIEDHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public DAIBBIEDHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3A20", Offset = "0x6CB2C20", VA = "0x186CB3A20")]
		internal bool PCONKEEEBCP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GAPFBFCDPHG : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public MFGPODLAJFB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public GAPFBFCDPHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7F10", Offset = "0x6CB7110", VA = "0x186CB7F10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7B80", Offset = "0x6CB6D80", VA = "0x186CB7B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7B30", Offset = "0x6CB6D30", VA = "0x186CB7B30")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7EC0", Offset = "0x6CB70C0", VA = "0x186CB7EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NNJFIKGJADE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public ACKCNCGOGDB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public NNJFIKGJADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2450", Offset = "0x6CC1650", VA = "0x186CC2450")]
		internal bool PIJKBNBCODH(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6CC21D0", Offset = "0x6CC13D0", VA = "0x186CC21D0")]
		internal void GEPOAFMLJMO(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class PBIMCMJKAFL : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ACKCNCGOGDB<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private NNJFIKGJADE <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public PBIMCMJKAFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2B50", Offset = "0x6CC1D50", VA = "0x186CC2B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6CC31D0", Offset = "0x6CC23D0", VA = "0x186CC31D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly ICollection<string> MFGPCGJKHPB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static BNCJCHBDCBI CLEANBJIMMG;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static AsyncOperation HMKFBMCLANF;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static BNCJCHBDCBI DNOEFANKGDI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static string KGNOFCJNDOB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static ThreadPriority BBHKKCFLGMB;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static Task BOBANGFPKMP;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static List<SceneInstance> KJJJPKHGPBP;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly Queue<FIMFACEILJA> BJPJHGCFPDO;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Task NGOPOONJLPL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool PHFLLBLMAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9700", Offset = "0x6CA8900", VA = "0x186CA9700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool IEEFDDGOJLM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9410", Offset = "0x6CA8610", VA = "0x186CA9410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool OOGEFHLIJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9370", Offset = "0x6CA8570", VA = "0x186CA9370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LMAKLLEKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8ED0", Offset = "0x6CA80D0", VA = "0x186CA8ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EDDHIOCNPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9D90", Offset = "0x6CA8F90", VA = "0x186CA9D90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9A30", Offset = "0x6CA8C30", VA = "0x186CA9A30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6CA94B0", Offset = "0x6CA86B0", VA = "0x186CA94B0")]
	[EAOPJFMECEI(PHCAOMDNDGN.EnteredEditModeNextFrame, 0)]
	private static void LJOLKCLOLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA95B0", Offset = "0x6CA87B0", VA = "0x186CA95B0")]
	[AsyncStateMachine(typeof(IBPCGAMEDEP))]
	public static Task<Scene> LLFFFEKAKJK(string OBIFCNHIBDF, LoadSceneMode AGBNFNPFOKO = LoadSceneMode.Single, bool FKFMBKPLPKC = false, [Optional] CEIEAABKFOO<string>.DDLAMDHALOK AANJHJIDBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA92C0", Offset = "0x6CA84C0", VA = "0x186CA92C0")]
	[AsyncStateMachine(typeof(GHMDOKMDIPP))]
	private static Task HJAPDOLFBIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8D10", Offset = "0x6CA7F10", VA = "0x186CA8D10")]
	[AsyncStateMachine(typeof(GJLBOKEOHBH))]
	private static Task CPINFBCGFBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8F60", Offset = "0x6CA8160", VA = "0x186CA8F60")]
	[AsyncStateMachine(typeof(IMOIOJNBBOI))]
	private static Task<Scene> DPKOACFJHDI(string OBIFCNHIBDF, LoadSceneMode AGBNFNPFOKO, bool FKFMBKPLPKC, CEIEAABKFOO<string>.DDLAMDHALOK IPCCBANMNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8DE0", Offset = "0x6CA7FE0", VA = "0x186CA8DE0")]
	private static void DCBDMNHHAOA(SceneInstance PNLOKOBAKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9EA0", Offset = "0x6CA90A0", VA = "0x186CA9EA0")]
	private static void PMAPPFAIDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9C70", Offset = "0x6CA8E70", VA = "0x186CA9C70")]
	[AsyncStateMachine(typeof(CJFDAFPGOJM))]
	private static Task<Scene> OIJEDMMMCKG(string OBIFCNHIBDF, LoadSceneMode AGBNFNPFOKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8B80", Offset = "0x6CA7D80", VA = "0x186CA8B80")]
	private static bool AODDPMNJMLO(string OBIFCNHIBDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9920", Offset = "0x6CA8B20", VA = "0x186CA9920")]
	[AsyncStateMachine(typeof(DNJBGJAEEAM))]
	private static Task<Scene> NEIBIBEHHMK(CEIEAABKFOO<string>.DDLAMDHALOK IPCCBANMNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9140", Offset = "0x6CA8340", VA = "0x186CA9140")]
	public static PMIHBBCEMHD<Scene> EHNGAOPPEOJ(string OBIFCNHIBDF, LoadSceneMode AGBNFNPFOKO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA0A0", Offset = "0x6CA92A0", VA = "0x186CAA0A0")]
	public static BNCJCHBDCBI PODEOOGNEDJ(string OBIFCNHIBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA90B0", Offset = "0x6CA82B0", VA = "0x186CA90B0")]
	[IteratorStateMachine(typeof(GAPFBFCDPHG))]
	private static IEnumerator<AEBIBAEBDOJ> EBMPEBJKGIH(string OBIFCNHIBDF, MFGPODLAJFB LIGNDCCKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8C70", Offset = "0x6CA7E70", VA = "0x186CA8C70")]
	[IteratorStateMachine(typeof(PBIMCMJKAFL))]
	private static IEnumerator<AEBIBAEBDOJ> BCOIHLGOHEF(string OBIFCNHIBDF, LoadSceneMode AGBNFNPFOKO, ACKCNCGOGDB<Scene> LIGNDCCKKPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9B40", Offset = "0x6CA8D40", VA = "0x186CA9B40")]
	public static bool OHMMILHKAIC([Out] string DCAJAEAPKJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JMELIMODOMD
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD060", Offset = "0x6CBC260", VA = "0x186CBD060")]
	public static IDisposable GOCLJOIJNHE(this OKLILHAGNLK EOIJJPCMNGA, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD170", Offset = "0x6CBC370", VA = "0x186CBD170")]
	public static IDisposable OBBABHKFFKJ(this OKLILHAGNLK EOIJJPCMNGA, Action<float> PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD0F0", Offset = "0x6CBC2F0", VA = "0x186CBD0F0")]
	public static IDisposable LIPLEKGCEJM(this OKLILHAGNLK EOIJJPCMNGA, Action<float> PGMNFLGPPCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class HEIIMBAAMPP
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9A30", Offset = "0x6CB8C30", VA = "0x186CB9A30")]
	public static IDisposable FDIOMHGPBIC(this MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB99A0", Offset = "0x6CB8BA0", VA = "0x186CB99A0")]
	public static IDisposable FDIOMHGPBIC(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB96C0", Offset = "0x6CB88C0", VA = "0x186CB96C0")]
	public static IDisposable DBKEHPIBNHN(this MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9CC0", Offset = "0x6CB8EC0", VA = "0x186CB9CC0")]
	public static IDisposable HLFNFEDAPBL(this MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9D40", Offset = "0x6CB8F40", VA = "0x186CB9D40")]
	public static IDisposable HLFNFEDAPBL(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA160", Offset = "0x6CB9360", VA = "0x186CBA160")]
	public static IDisposable PGCGPOFCACA(this MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9640", Offset = "0x6CB8840", VA = "0x186CB9640")]
	public static IDisposable AINLCFPMIBM(this MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB97E0", Offset = "0x6CB89E0", VA = "0x186CB97E0")]
	public static IDisposable DIGNOPBDFKD(this MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9B60", Offset = "0x6CB8D60", VA = "0x186CB9B60")]
	public static IDisposable FMKLJFAAFNM(this MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9E60", Offset = "0x6CB9060", VA = "0x186CB9E60")]
	public static IDisposable IPBAMKIDFIO(this MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9860", Offset = "0x6CB8A60", VA = "0x186CB9860")]
	public static IDisposable EAGPINEEGPI(this MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9900", Offset = "0x6CB8B00", VA = "0x186CB9900")]
	public static IDisposable FCLMBDAEJEL(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA020", Offset = "0x6CB9220", VA = "0x186CBA020")]
	public static IDisposable PDHBMODGIIB(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9F80", Offset = "0x6CB9180", VA = "0x186CB9F80")]
	public static IDisposable OIMCAIKCNOK(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9AC0", Offset = "0x6CB8CC0", VA = "0x186CB9AC0")]
	public static IDisposable FGLHMJJCLEE(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9DC0", Offset = "0x6CB8FC0", VA = "0x186CB9DC0")]
	public static IDisposable IDKEDGGDBNB(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9740", Offset = "0x6CB8940", VA = "0x186CB9740")]
	public static IDisposable DEOCLLHMJPM(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA0C0", Offset = "0x6CB92C0", VA = "0x186CBA0C0")]
	public static IDisposable PFKHDNKPHEM(this MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9C10", Offset = "0x6CB8E10", VA = "0x186CB9C10")]
	public static IDisposable HEBOMNACMIC(this MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NOLGCJOOOFA
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class PAPIGLNOMDA : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public ADPKHEFCKGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private FAPPJKCAKHK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public PAPIGLNOMDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2A20", Offset = "0x6CC1C20", VA = "0x186CC2A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2B00", Offset = "0x6CC1D00", VA = "0x186CC2B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class AJMBAKMOING : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public ADPKHEFCKGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private FAPPJKCAKHK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public AJMBAKMOING(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC310", Offset = "0x6CAB510", VA = "0x186CAC310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC400", Offset = "0x6CAB600", VA = "0x186CAC400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6CC26B0", Offset = "0x6CC18B0", VA = "0x186CC26B0")]
	public static MGBJAGNHOEE FDIOMHGPBIC(Action PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CC24D0", Offset = "0x6CC16D0", VA = "0x186CC24D0")]
	public static MGBJAGNHOEE FDIOMHGPBIC(Behaviour EOIJJPCMNGA, Action PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2590", Offset = "0x6CC1790", VA = "0x186CC2590")]
	public static MGBJAGNHOEE FDIOMHGPBIC(Behaviour EOIJJPCMNGA, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2760", Offset = "0x6CC1960", VA = "0x186CC2760")]
	[IteratorStateMachine(typeof(PAPIGLNOMDA))]
	private static IEnumerator<AEBIBAEBDOJ> LHKCJEMHPNI(ADPKHEFCKGP EBICMOKHPAM, Action PGMNFLGPPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CC27F0", Offset = "0x6CC19F0", VA = "0x186CC27F0")]
	[IteratorStateMachine(typeof(AJMBAKMOING))]
	private static IEnumerator<AEBIBAEBDOJ> LHKCJEMHPNI(ADPKHEFCKGP EBICMOKHPAM, Action<float> PGMNFLGPPCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CEJOCCNBMHE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LMJLPMLMLLK : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public CEJOCCNBMHE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public LMJLPMLMLLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CC10F0", Offset = "0x6CC02F0", VA = "0x186CC10F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1180", Offset = "0x6CC0380", VA = "0x186CC1180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly ADPKHEFCKGP BGOAJDAJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Action AOHBKPBILEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool CJHJDMLBILA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OIFHOEMAKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA50", Offset = "0x7CDC50", VA = "0x1807CEA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF150", Offset = "0x6CAE350", VA = "0x186CAF150")]
	public CEJOCCNBMHE(ADPKHEFCKGP BGOAJDAJJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF030", Offset = "0x6CAE230", VA = "0x186CAF030")]
	[IteratorStateMachine(typeof(LMJLPMLMLLK))]
	private IEnumerator<AEBIBAEBDOJ> HGINCBEDMMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF0B0", Offset = "0x6CAE2B0", VA = "0x186CAF0B0", Slot = "4")]
	public void OnCompleted(Action HPPNEDMIMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	public void HHGANOLMKHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class FHLKOONLEKB
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7790", Offset = "0x6CB6990", VA = "0x186CB7790")]
	public static CEJOCCNBMHE JGCOKBEJCBN(this ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class FCNKELFJGPH
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class OMOKPBHEDKB : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public LNCOGIAOCHH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public OMOKPBHEDKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2950", Offset = "0x6CC1B50", VA = "0x186CC2950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC29D0", Offset = "0x6CC1BD0", VA = "0x186CC29D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6CB72B0", Offset = "0x6CB64B0", VA = "0x186CB72B0")]
	public static MGBJAGNHOEE FDIOMHGPBIC(float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6CB71A0", Offset = "0x6CB63A0", VA = "0x186CB71A0")]
	public static MGBJAGNHOEE FDIOMHGPBIC(MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7610", Offset = "0x6CB6810", VA = "0x186CB7610")]
	public static MGBJAGNHOEE NCHOOAKDFOM(MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6CB73B0", Offset = "0x6CB65B0", VA = "0x186CB73B0")]
	public static MGBJAGNHOEE JCBGCPBDHNP(OKLILHAGNLK EOIJJPCMNGA, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7550", Offset = "0x6CB6750", VA = "0x186CB7550")]
	private static IEnumerator<AEBIBAEBDOJ> LHKCJEMHPNI(DMHIANCOLDD KHPOAPBJGAJ, float JMJEOOGPDKI, ADPKHEFCKGP EBICMOKHPAM, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7730", Offset = "0x6CB6930", VA = "0x186CB7730")]
	private static IEnumerator<AEBIBAEBDOJ> PMEGNFPBDKA(DMHIANCOLDD KHPOAPBJGAJ, float JMJEOOGPDKI, ADPKHEFCKGP EBICMOKHPAM, Action<float> PGMNFLGPPCI, bool KOAPEIAHGGA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6CB74C0", Offset = "0x6CB66C0", VA = "0x186CB74C0")]
	[IteratorStateMachine(typeof(OMOKPBHEDKB))]
	private static IEnumerator<AEBIBAEBDOJ> LHBHMCFGEFD(LNCOGIAOCHH CIEMOJNJMIE, float JMJEOOGPDKI, ADPKHEFCKGP EBICMOKHPAM, Action<float> PGMNFLGPPCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class DBGGELEDOKJ
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class EKGGFADDOIE : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public ADPKHEFCKGP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public EKGGFADDOIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6CE0", Offset = "0x6CB5EE0", VA = "0x186CB6CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6DA0", Offset = "0x6CB5FA0", VA = "0x186CB6DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3B70", Offset = "0x6CB2D70", VA = "0x186CB3B70")]
	[IteratorStateMachine(typeof(EKGGFADDOIE))]
	private static IEnumerator<AEBIBAEBDOJ> MMEJBDHIPLN(ADPKHEFCKGP BGOAJDAJJJJ, Func<bool> GNKJEJLMAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3A50", Offset = "0x6CB2C50", VA = "0x186CB3A50")]
	public static MGBJAGNHOEE IPACACMHKLM(this MonoBehaviour MNJAELFPAAK, Func<bool> GNKJEJLMAJG, ADPKHEFCKGP BGOAJDAJJJJ = ADPKHEFCKGP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class MIAPKGOMDDN
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GNHFDAFGFCI : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public ADPKHEFCKGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public GNHFDAFGFCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9580", Offset = "0x6CB8780", VA = "0x186CB9580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6CB95F0", Offset = "0x6CB87F0", VA = "0x186CB95F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class KCACAPGGFGC : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public ADPKHEFCKGP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private AEBIBAEBDOJ <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public KCACAPGGFGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFBF0", Offset = "0x6CBEDF0", VA = "0x186CBFBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFC80", Offset = "0x6CBEE80", VA = "0x186CBFC80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6CC19B0", Offset = "0x6CC0BB0", VA = "0x186CC19B0")]
	[IteratorStateMachine(typeof(GNHFDAFGFCI))]
	private static IEnumerator<AEBIBAEBDOJ> HGINCBEDMMP(float CNDFBLFAGOA, ADPKHEFCKGP EBICMOKHPAM, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1CF0", Offset = "0x6CC0EF0", VA = "0x186CC1CF0")]
	[IteratorStateMachine(typeof(KCACAPGGFGC))]
	private static IEnumerator<AEBIBAEBDOJ> MFKDCNGBBCD(float CNDFBLFAGOA, ADPKHEFCKGP EBICMOKHPAM, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1670", Offset = "0x6CC0870", VA = "0x186CC1670")]
	public static IDisposable GIDAENINMBI(this MonoBehaviour MNJAELFPAAK, float CNDFBLFAGOA, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6CC14B0", Offset = "0x6CC06B0", VA = "0x186CC14B0")]
	public static MGBJAGNHOEE DGNNMLLHHJF(this MonoBehaviour MNJAELFPAAK, float CNDFBLFAGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1790", Offset = "0x6CC0990", VA = "0x186CC1790")]
	public static MGBJAGNHOEE GIDAENINMBI(this MonoBehaviour MNJAELFPAAK, float CNDFBLFAGOA, ADPKHEFCKGP EBICMOKHPAM, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC18C0", Offset = "0x6CC0AC0", VA = "0x186CC18C0")]
	public static MGBJAGNHOEE GLKLLIBJDIP(this MonoBehaviour MNJAELFPAAK, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1D90", Offset = "0x6CC0F90", VA = "0x186CC1D90")]
	public static MGBJAGNHOEE PKLJHJBGIGM(this MonoBehaviour MNJAELFPAAK, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC13D0", Offset = "0x6CC05D0", VA = "0x186CC13D0")]
	public static MGBJAGNHOEE BKLCFHIDDLE(this MonoBehaviour MNJAELFPAAK, Action IKBJCBBBOIM, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1570", Offset = "0x6CC0770", VA = "0x186CC1570")]
	public static MGBJAGNHOEE DOEMEBLCJFF(this MonoBehaviour MNJAELFPAAK, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1BF0", Offset = "0x6CC0DF0", VA = "0x186CC1BF0")]
	public static MGBJAGNHOEE JGMJNAKCFBH(this MonoBehaviour MNJAELFPAAK, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1B20", Offset = "0x6CC0D20", VA = "0x186CC1B20")]
	private static MGBJAGNHOEE JGBNDEGICFO(MonoBehaviour MNJAELFPAAK, ADPKHEFCKGP BGOAJDAJJJJ, Action IKBJCBBBOIM, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6CC15A0", Offset = "0x6CC07A0", VA = "0x186CC15A0")]
	public static MGBJAGNHOEE FGAJMAPKKJC(this MonoBehaviour MNJAELFPAAK, float LCBJOHPJGFO, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6CC18E0", Offset = "0x6CC0AE0", VA = "0x186CC18E0")]
	public static MGBJAGNHOEE GMFDOPPDOLO(this MonoBehaviour MNJAELFPAAK, float LCBJOHPJGFO, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1C20", Offset = "0x6CC0E20", VA = "0x186CC1C20")]
	public static MGBJAGNHOEE JHHMHNBCPJL(this MonoBehaviour MNJAELFPAAK, float LCBJOHPJGFO, Action IKBJCBBBOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1A50", Offset = "0x6CC0C50", VA = "0x186CC1A50")]
	public static MGBJAGNHOEE IEAFJHAHAAD(this MonoBehaviour MNJAELFPAAK, float LCBJOHPJGFO, Action IKBJCBBBOIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HKBMELIGAOG : BMJMBLNOFIE, IEnumerable<BMJMBLNOFIE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly List<BMJMBLNOFIE> CHOBOLPPFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool MJOLILJGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action AEALJIFHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool IJIHGMDPAHG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool ENMPHDPNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6CBAB10", Offset = "0x6CB9D10", VA = "0x186CBAB10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KEDDEOPIKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6CBA630", Offset = "0x6CB9830", VA = "0x186CBA630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6CBA6D0", Offset = "0x6CB98D0", VA = "0x186CBA6D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6CBADE0", Offset = "0x6CB9FE0", VA = "0x186CBADE0")]
	public HKBMELIGAOG([Optional] Action AEALJIFHAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAC50", Offset = "0x6CB9E50", VA = "0x186CBAC50")]
	public void LGLNKEHGBKE(BMJMBLNOFIE GIDLLBLEDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA4D0", Offset = "0x6CB96D0", VA = "0x186CBA4D0")]
	private void CAKAJDEDLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA7F0", Offset = "0x6CB99F0", VA = "0x186CBA7F0", Slot = "7")]
	public bool IANMALICMKK(bool LBPGAAMAJKE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA800", Offset = "0x6CB9A00", VA = "0x186CBA800", Slot = "8")]
	public bool IANMALICMKK(Action BGMBJALDBDD, bool LBPGAAMAJKE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA770", Offset = "0x6CB9970", VA = "0x186CBA770", Slot = "9")]
	public IEnumerator<BMJMBLNOFIE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA770", Offset = "0x6CB9970", VA = "0x186CBA770", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LIKDGGBJIAG : BFDBDOCMNDE
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class AJAIMGCHDFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public LIKDGGBJIAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AJAIMGCHDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC2E0", Offset = "0x6CAB4E0", VA = "0x186CAC2E0")]
		internal void IKBIMGBIMII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class JBDJMFDCIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public LIKDGGBJIAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JBDJMFDCIGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC2E0", Offset = "0x6CAB4E0", VA = "0x186CAC2E0")]
		internal void JGDKCNJLGCM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly float LMICGNDDAGL;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0750", Offset = "0x6CBF950", VA = "0x186CC0750")]
	public LIKDGGBJIAG(Behaviour EOIJJPCMNGA, float LMICGNDDAGL, [Optional] Action AEALJIFHAGD, [Optional] CDBPDONECIJ DKNGCACELHF, [Optional] DMHIANCOLDD KHPOAPBJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0530", Offset = "0x6CBF730", VA = "0x186CC0530", Slot = "9")]
	protected override bool BGNMAHENGMA(Action BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0640", Offset = "0x6CBF840", VA = "0x186CC0640", Slot = "10")]
	protected override bool FOCHPGFHMPH(Action BGMBJALDBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface BMJMBLNOFIE
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ENMPHDPNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KEDDEOPIKHD;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IANMALICMKK(bool LBPGAAMAJKE = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IANMALICMKK(Action BGMBJALDBDD, bool LBPGAAMAJKE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class BFDBDOCMNDE : BMJMBLNOFIE
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ENFDIIMKCJP : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BFDBDOCMNDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public ENFDIIMKCJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6E80", Offset = "0x6CB6080", VA = "0x186CB6E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6F50", Offset = "0x6CB6150", VA = "0x186CB6F50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Behaviour EOIJJPCMNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action AEALJIFHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private GJCJPABGAJD GLIABMPHOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly CDBPDONECIJ DKNGCACELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly DMHIANCOLDD KHPOAPBJGAJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ENMPHDPNMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x105ABA0", Offset = "0x1059DA0", VA = "0x18105ABA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action KEDDEOPIKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6CADD60", Offset = "0x6CACF60", VA = "0x186CADD60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6CADE00", Offset = "0x6CAD000", VA = "0x186CADE00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE2B0", Offset = "0x6CAD4B0", VA = "0x186CAE2B0")]
	protected BFDBDOCMNDE(Behaviour EOIJJPCMNGA, [Optional] Action AEALJIFHAGD, [Optional] CDBPDONECIJ DKNGCACELHF, [Optional] DMHIANCOLDD KHPOAPBJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6CADF00", Offset = "0x6CAD100", VA = "0x186CADF00", Slot = "7")]
	public bool IANMALICMKK(bool LBPGAAMAJKE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6CADEA0", Offset = "0x6CAD0A0", VA = "0x186CADEA0", Slot = "8")]
	public bool IANMALICMKK(Action BGMBJALDBDD, bool LBPGAAMAJKE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BGNMAHENGMA(Action BGMBJALDBDD);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FOCHPGFHMPH(Action BGMBJALDBDD);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6CADD00", Offset = "0x6CACF00", VA = "0x186CADD00")]
	protected void CNFLOAGOHLM(Action BGMBJALDBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6CADF60", Offset = "0x6CAD160", VA = "0x186CADF60")]
	protected BNCJCHBDCBI JKFLCIDNJJM(float FEFLPFIAOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE230", Offset = "0x6CAD430", VA = "0x186CAE230")]
	private void PGOBCIFGKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE1A0", Offset = "0x6CAD3A0", VA = "0x186CAE1A0")]
	[IteratorStateMachine(typeof(ENFDIIMKCJP))]
	private IEnumerator<AEBIBAEBDOJ> OLLDBMNHEKN(float FEFLPFIAOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6CADD20", Offset = "0x6CACF20", VA = "0x186CADD20")]
	[CompilerGenerated]
	private void FCLHBPEELLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PLDBMGJPIGF : BFDBDOCMNDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly float PHMKEOGCODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly int GIIFFMGPHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly float BGLMOLIIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly float[] FPKBGKMCFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int OOPOMAHDGCD;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3C00", Offset = "0x6CC2E00", VA = "0x186CC3C00")]
	public PLDBMGJPIGF(Behaviour EOIJJPCMNGA, float LBKMPMCFFFC, int GIIFFMGPHLB, [Optional] Action AEALJIFHAGD, float BGLMOLIIDID = 0f, [Optional] CDBPDONECIJ DKNGCACELHF, [Optional] DMHIANCOLDD KHPOAPBJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "9")]
	protected override bool BGNMAHENGMA(Action BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3980", Offset = "0x6CC2B80", VA = "0x186CC3980", Slot = "10")]
	protected override bool FOCHPGFHMPH(Action BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3B80", Offset = "0x6CC2D80", VA = "0x186CC3B80")]
	private void OPEEKJPHEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class MKGPIKNOAEG : BFDBDOCMNDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly float LMICGNDDAGL;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0750", Offset = "0x6CBF950", VA = "0x186CC0750")]
	public MKGPIKNOAEG(Behaviour EOIJJPCMNGA, float LMICGNDDAGL, [Optional] Action AEALJIFHAGD, [Optional] CDBPDONECIJ DKNGCACELHF, [Optional] DMHIANCOLDD KHPOAPBJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "9")]
	protected override bool BGNMAHENGMA(Action BGMBJALDBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1DC0", Offset = "0x6CC0FC0", VA = "0x186CC1DC0", Slot = "10")]
	protected override bool FOCHPGFHMPH(Action BGMBJALDBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public sealed class LGCEPNMJOEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class NCLCIAFDPNO : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public NCLCIAFDPNO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2000", Offset = "0x6CC1200", VA = "0x186CC2000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2070", Offset = "0x6CC1270", VA = "0x186CC2070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private MGBJAGNHOEE IEHDMDJIJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private OKLILHAGNLK EOIJJPCMNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Action<float> LDJHJCPOANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private ADPKHEFCKGP BGOAJDAJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float LEJAKOFKIJK;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0350", Offset = "0x6CBF550", VA = "0x186CC0350")]
	public LGCEPNMJOEO(OKLILHAGNLK EOIJJPCMNGA, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6CC01B0", Offset = "0x6CBF3B0", VA = "0x186CC01B0")]
	private void LNIEKNFPBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFFD0", Offset = "0x6CBF1D0", VA = "0x186CBFFD0")]
	private void ELPOMNBNAKI(string KFNIFKKFLAO, Action GHOAKJADLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0130", Offset = "0x6CBF330", VA = "0x186CC0130")]
	[IteratorStateMachine(typeof(NCLCIAFDPNO))]
	private IEnumerator<AEBIBAEBDOJ> JANKNNIMJFM(Action GHOAKJADLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFF70", Offset = "0x6CBF170", VA = "0x186CBFF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFDC0", Offset = "0x6CBEFC0", VA = "0x186CBFDC0")]
	[CompilerGenerated]
	private void CNAGCHCFOEB(string NJNKMHCCCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class EDANMAPDMOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class NOONMEKBKAN : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public NOONMEKBKAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2000", Offset = "0x6CC1200", VA = "0x186CC2000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2880", Offset = "0x6CC1A80", VA = "0x186CC2880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private MGBJAGNHOEE IEHDMDJIJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MonoBehaviour MNJAELFPAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Action PGMNFLGPPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Action<float> LDJHJCPOANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private ADPKHEFCKGP BGOAJDAJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float LEJAKOFKIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool KOAPEIAHGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly CDBPDONECIJ DKNGCACELHF;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6080", Offset = "0x6CB5280", VA = "0x186CB6080")]
	public EDANMAPDMOA(MonoBehaviour MNJAELFPAAK, Action PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5E40", Offset = "0x6CB5040", VA = "0x186CB5E40")]
	public EDANMAPDMOA(MonoBehaviour MNJAELFPAAK, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5BF0", Offset = "0x6CB4DF0", VA = "0x186CB5BF0")]
	public EDANMAPDMOA(MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1B26940", Offset = "0x1B25B40", VA = "0x181B26940")]
	private EDANMAPDMOA(CDBPDONECIJ DKNGCACELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6CB56D0", Offset = "0x6CB48D0", VA = "0x186CB56D0")]
	internal static EDANMAPDMOA JHLCDOMNKMC(MonoBehaviour MNJAELFPAAK, float JMJEOOGPDKI, Action<float> PGMNFLGPPCI, ADPKHEFCKGP BGOAJDAJJJJ, bool KOAPEIAHGGA = true, [Optional] CDBPDONECIJ DKNGCACELHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5450", Offset = "0x6CB4650", VA = "0x186CB5450")]
	private void FDIOMHGPBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5A40", Offset = "0x6CB4C40", VA = "0x186CB5A40")]
	private void PLBOOCGCNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5800", Offset = "0x6CB4A00", VA = "0x186CB5800")]
	private void LNIEKNFPBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5070", Offset = "0x6CB4270", VA = "0x186CB5070")]
	private void CLFFIDOONFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5290", Offset = "0x6CB4490", VA = "0x186CB5290")]
	private void ELPOMNBNAKI(string KFNIFKKFLAO, Action GHOAKJADLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5650", Offset = "0x6CB4850", VA = "0x186CB5650")]
	[IteratorStateMachine(typeof(NOONMEKBKAN))]
	private IEnumerator<AEBIBAEBDOJ> JANKNNIMJFM(Action GHOAKJADLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5230", Offset = "0x6CB4430", VA = "0x186CB5230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB53C0", Offset = "0x6CB45C0", VA = "0x186CB53C0")]
	[CompilerGenerated]
	private void FCJOBMFGLMN(string NJNKMHCCCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4FE0", Offset = "0x6CB41E0", VA = "0x186CB4FE0")]
	[CompilerGenerated]
	private void CKEKAPCBJOH(string NJNKMHCCCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB59B0", Offset = "0x6CB4BB0", VA = "0x186CB59B0")]
	[CompilerGenerated]
	private void MPLDLFDGMPH(string NJNKMHCCCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB55C0", Offset = "0x6CB47C0", VA = "0x186CB55C0")]
	[CompilerGenerated]
	private void GMEPIFEIONF(string NJNKMHCCCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[Flags]
internal enum GBPLLMGKKJJ : byte
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
internal sealed class EILFENHJNEO : DMHIANCOLDD
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float DAFGCOCANMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6470", Offset = "0x6CB5670", VA = "0x186CB6470", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float KKINDPBIMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6CB64F0", Offset = "0x6CB56F0", VA = "0x186CB64F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public double AHDOEICMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6500", Offset = "0x6CB5700", VA = "0x186CB6500", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6480", Offset = "0x6CB5680", VA = "0x186CB6480")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void DPFLJEJBPJI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	[Preserve]
	internal EILFENHJNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal interface PDNMDDPOFAF
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMCKOPHPNDA(string IIADHBOODBK);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFMCDEFPNOG();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal interface NKGPKKIFDCA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool FHMOGPBMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool CKHCAAFJNJI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
internal class EJCFEJLMDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public JOJBKCOPJLF IPFIKLPNNLG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int DMDPAHAMEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CE040", Offset = "0x7CD240", VA = "0x1807CE040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6520", Offset = "0x6CB5720", VA = "0x186CB6520")]
	public static AEBIBAEBDOJ DGMGPLAIOLA(IEnumerator<AEBIBAEBDOJ> CHJGCJJFMHP, OLPPBFBJGED KNAMOHMAFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6680", Offset = "0x6CB5880", VA = "0x186CB6680")]
	public AEBIBAEBDOJ DGMGPLAIOLA(OLPPBFBJGED[] KJEJLAFIIOP, IEnumerator<AEBIBAEBDOJ>[] KLAICAPAEGH, AEBIBAEBDOJ[] FDPMHOAPKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6880", Offset = "0x6CB5A80", VA = "0x186CB6880")]
	public void PJFLJONKPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6CB68B0", Offset = "0x6CB5AB0", VA = "0x186CB68B0")]
	public void MKAHBILDGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6740", Offset = "0x6CB5940", VA = "0x186CB6740")]
	public void FABLNHHJKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6880", Offset = "0x6CB5A80", VA = "0x186CB6880")]
	public void MCBLLIMDNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public EJCFEJLMDAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class JOJBKCOPJLF
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct OLODAFCMIJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public EJCFEJLMDAG LMLGLLHNNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OKLILHAGNLK LHGEDCJBIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public OLPPBFBJGED EDNADMBAIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public IEnumerator<AEBIBAEBDOJ> KJJEMJNIAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AEBIBAEBDOJ KAHEFDFDLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GBPLLMGKKJJ FIOBFHAGJMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct FLNCECNJMIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ADPKHEFCKGP AMNLFAPILCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<OLODAFCMIJG> PMHNFGFBMCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JLIOBIHFEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public OLPPBFBJGED promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JOJBKCOPJLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public OKLILHAGNLK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EJCFEJLMDAG routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public GBPLLMGKKJJ coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AEBIBAEBDOJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public IEnumerator<AEBIBAEBDOJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public JLIOBIHFEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC8A0", Offset = "0x6CBBAA0", VA = "0x186CBC8A0")]
		internal void MMGDJBNAMAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class EMACDPMBPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public EJCFEJLMDAG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JOJBKCOPJLF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EMACDPMBPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CB6E40", Offset = "0x6CB6040", VA = "0x186CB6E40")]
		internal void CPOPJEKDGPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class ADIOFJBFFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public EJCFEJLMDAG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public JOJBKCOPJLF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public ADIOFJBFFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA89A0", Offset = "0x6CA7BA0", VA = "0x186CA89A0")]
		internal void CNOENCJDEEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class CICCEJBGDGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public EJCFEJLMDAG schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public JOJBKCOPJLF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public CICCEJBGDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF260", Offset = "0x6CAE460", VA = "0x186CAF260")]
		internal void MCFDOMGALJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const GBPLLMGKKJJ MMKBDIJHGLL = GBPLLMGKKJJ.Cancelled | GBPLLMGKKJJ.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly ADPKHEFCKGP BGOAJDAJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private bool[] OCKGKEIGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<GBPLLMGKKJJ> BDJCABIMHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<float> ABMJHHLONFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> AMBFCEKBIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> NANIOEIAOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private NativeArray<int> NECIOGHOFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private NativeArray<int> PBNHLLCHEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private NativeArray<int> ODAEPDCDJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private EJCFEJLMDAG[] OPBEOKHKKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private OLPPBFBJGED[] KJEJLAFIIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private OKLILHAGNLK[] LBLDNOOJLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private IEnumerator<AEBIBAEBDOJ>[] PKDFDBILLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private AEBIBAEBDOJ[] KNEOBKOBJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private int NKJJNEOFJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EFDILNFHNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly int OFCOBKFBGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float GANPPHKFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private PIJFAJOOLEA HHBIHPLNJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JobHandle OBFCEOCDNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<EJCFEJLMDAG> CCEKGJFKIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool BEEKKIMMEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private List<Action> JDOGOBBDDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private List<Action> DJFKGKOCNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private bool JFPMEHEECIH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public FLNCECNJMIP[] CCKMKAMOCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x834C00", Offset = "0x833E00", VA = "0x180834C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE2C0", Offset = "0x6CBD4C0", VA = "0x186CBE2C0")]
	private static int DIDNINMNFGF(ADPKHEFCKGP BGOAJDAJJJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF5A0", Offset = "0x6CBE7A0", VA = "0x186CBF5A0")]
	public JOJBKCOPJLF(ADPKHEFCKGP BGOAJDAJJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF2C0", Offset = "0x6CBE4C0", VA = "0x186CBF2C0")]
	private void NOOKOFLDNGI(int KFGOJADFHNL, int KBADBFMPHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBED20", Offset = "0x6CBDF20", VA = "0x186CBED20")]
	public void KDEIFPEHPJG(OKLILHAGNLK EOIJJPCMNGA, AEBIBAEBDOJ ODJGKPKJJFH, IEnumerator<AEBIBAEBDOJ> CHJGCJJFMHP, OLPPBFBJGED KNAMOHMAFIG, [Optional] EJCFEJLMDAG NANIGFFKNPA, GBPLLMGKKJJ IGICANCDFKD = GBPLLMGKKJJ.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE750", Offset = "0x6CBD950", VA = "0x186CBE750")]
	public void HLFHLDCGEJO(IEnumerable<OLODAFCMIJG> HAJOPJPBIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD5C0", Offset = "0x6CBC7C0", VA = "0x186CBD5C0")]
	private OLODAFCMIJG AOMJKCADNDA(int KAKPCAKGCIM)
	{
		return default(OLODAFCMIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD250", Offset = "0x6CBC450", VA = "0x186CBD250")]
	private void AJLKLJJBGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x29F6380", Offset = "0x29F5580", VA = "0x1829F6380")]
	private static void NENKHAAGAPF<T>(int KAKPCAKGCIM, T[] ADLCAMAAPDN, int AGHIAPEPFJE, [Optional] T BCCKMPMGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x29F63D0", Offset = "0x29F55D0", VA = "0x1829F63D0")]
	private static void NENKHAAGAPF<T>(int KAKPCAKGCIM, NativeArray<T> ADLCAMAAPDN, int AGHIAPEPFJE, [Optional] T BCCKMPMGBKG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE990", Offset = "0x6CBDB90", VA = "0x186CBE990")]
	private void JPLFDAFFBAH(IEnumerable<OLODAFCMIJG> HAJOPJPBIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEEA0", Offset = "0x6CBE0A0", VA = "0x186CBEEA0")]
	private void KNAIGNNENOP(OLODAFCMIJG GMJFCBFJBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE4F0", Offset = "0x6CBD6F0", VA = "0x186CBE4F0")]
	private GNJNCDNEIAN GJEHEMAIFML(int ABLAPFEDDBL)
	{
		return default(GNJNCDNEIAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE2F0", Offset = "0x6CBD4F0", VA = "0x186CBE2F0")]
	public void FHMOKNDIIFE(float HJNBFIECMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF240", Offset = "0x6CBE440", VA = "0x186CBF240")]
	private void MLHAOHKIDAE(Action BPOHBPAMNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEF60", Offset = "0x6CBE160", VA = "0x186CBEF60")]
	private void LMJOAMGNGPA(Action BPOHBPAMNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDBC0", Offset = "0x6CBCDC0", VA = "0x186CBDBC0")]
	public void DGOMLDDFIKD(float HJNBFIECMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF4A0", Offset = "0x6CBE6A0", VA = "0x186CBF4A0")]
	public void PGPPPADIAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEFE0", Offset = "0x6CBE1E0", VA = "0x186CBEFE0")]
	public void MCBLLIMDNAM(EJCFEJLMDAG CIEMOJNJMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDA90", Offset = "0x6CBCC90", VA = "0x186CBDA90")]
	public void BHNKGMJECBP(EJCFEJLMDAG CIEMOJNJMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF110", Offset = "0x6CBE310", VA = "0x186CBF110")]
	public void MCDMGKLMBAF(EJCFEJLMDAG CIEMOJNJMIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NLEKJADDGJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public static readonly NLEKJADDGJB NECMJGIIDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly Action JJBMIHNECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private bool NHFBHKGIGAE;

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public NLEKJADDGJB(Action JJBMIHNECNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x64B78A0", Offset = "0x64B6AA0", VA = "0x1864B78A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface IHHHONGIKNE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable KDBGHJBKFNF(UnityEngine.Object EOIJJPCMNGA, Action<T> PBEPLMNMEBP);
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface NFGIIEOMEBC<T> : IHHHONGIKNE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	new T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NJPLKIOIAEE<T> : NFGIIEOMEBC<T>, IHHHONGIKNE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class GIGDDDJEIME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public NJPLKIOIAEE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JPAGMGAIGPN<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public GIGDDDJEIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x39D51B0", Offset = "0x39D43B0", VA = "0x1839D51B0")]
		internal void DMNKOACFPLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static GameObject JBBHJMJKKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<JPAGMGAIGPN<UnityEngine.Object, Action<T>>> BFJEGCHLEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T KIGIIIIIGPK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x41B43E0", Offset = "0x41B35E0", VA = "0x1841B43E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x41B42A0", Offset = "0x41B34A0", VA = "0x1841B42A0")]
	private static bool HACKCOEGPLO(T BPOHBPAMNLC, T NOIIDJMAOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x41B4D30", Offset = "0x41B3F30", VA = "0x1841B4D30")]
	public NJPLKIOIAEE(T NDFJNJECMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x41B4450", Offset = "0x41B3650", VA = "0x1841B4450", Slot = "6")]
	public IDisposable KDBGHJBKFNF(UnityEngine.Object EOIJJPCMNGA, Action<T> PBEPLMNMEBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x41B4A40", Offset = "0x41B3C40", VA = "0x1841B4A40")]
	private void MGALBJEAKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class DFCPNMJLOMH : CBALPFAINJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly CDBPDONECIJ DKNGCACELHF;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4090", Offset = "0x6CB3290", VA = "0x186CB4090")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void DPFLJEJBPJI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	[Preserve]
	internal DFCPNMJLOMH([KFHLAIGNCCH(null)] CDBPDONECIJ DKNGCACELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4100", Offset = "0x6CB3300", VA = "0x186CB4100", Slot = "4")]
	public IDisposable EAGPINEEGPI(float JMJEOOGPDKI, Action<float> GPGHCLCHGND, bool KOAPEIAHGGA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GBGMOMHNFDD : ANFCFKCOBGI, CDBPDONECIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private JOJBKCOPJLF[] HNALOBFEBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private PDNMDDPOFAF FBNLGBJIGNK;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB83A0", Offset = "0x6CB75A0", VA = "0x186CB83A0")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void DPFLJEJBPJI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BD0", Offset = "0x6CB7DD0", VA = "0x186CB8BD0")]
	[Preserve]
	public GBGMOMHNFDD([KFHLAIGNCCH(null)] NDMHPECFMDH ABCJMMEJHCN, [KFHLAIGNCCH(null)] DMHIANCOLDD KHPOAPBJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6CB89F0", Offset = "0x6CB7BF0", VA = "0x186CB89F0", Slot = "16")]
	public override MGBJAGNHOEE IJEPJDJPCIP(OKLILHAGNLK EOIJJPCMNGA, IEnumerator<AEBIBAEBDOJ> MIPGJOOJHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7FA0", Offset = "0x6CB71A0", VA = "0x186CB7FA0", Slot = "17")]
	public override void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8470", Offset = "0x6CB7670", VA = "0x186CB8470", Slot = "19")]
	public override void FMMKEOJGCKN(ADPKHEFCKGP BGOAJDAJJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8230", Offset = "0x6CB7430", VA = "0x186CB8230", Slot = "18")]
	protected override void DBKEHPIBNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8BA0", Offset = "0x6CB7DA0", VA = "0x186CB8BA0")]
	private JOJBKCOPJLF LEMONIBBALJ(ADPKHEFCKGP HHJOOHJDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB86A0", Offset = "0x6CB78A0", VA = "0x186CB86A0", Slot = "20")]
	internal override LJNCGLBMMLP GEOLAFDBJHP(IEnumerator<AEBIBAEBDOJ> MIPGJOOJHLF, Behaviour EOIJJPCMNGA, OLPPBFBJGED KNAMOHMAFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B20", Offset = "0x6CB7D20", VA = "0x186CB8B20", Slot = "21")]
	internal override AHLDMKEGJBB LEGIEDMLMDJ(ADPKHEFCKGP EBICMOKHPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB88D0", Offset = "0x6CB7AD0", VA = "0x186CB88D0")]
	private void HDIDNKJEDMK(JOJBKCOPJLF BFDAAGGMPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8410", Offset = "0x6CB7610", VA = "0x186CB8410", Slot = "22")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[BurstCompile]
internal struct PIJFAJOOLEA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	public float GFPFEBAOCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	public int CKKBPNPEFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private NativeArray<int> FKOKOGFBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> OBJDOPAAOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> BGKHKNDOJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	public NativeArray<GBPLLMGKKJJ> HAKHFLEJGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[ReadOnly]
	public NativeArray<float> PBLOBLEFNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[WriteOnly]
	public NativeArray<int> NECIOGHOFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[WriteOnly]
	public NativeArray<int> AMBFCEKBIJC;

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3420", Offset = "0x6CC2620", VA = "0x186CC3420")]
	public static PIJFAJOOLEA ADOMMGOMPJC(int NEKHCMJCDPI, float HJNBFIECMFA, NativeArray<GBPLLMGKKJJ> PKKBHBKHJIE, NativeArray<float> EFEJMJMNPAI, NativeArray<int> JFJLDGMABDA, NativeArray<int> PLIHBHLODPI, NativeArray<int> JDELBOHJHDH, NativeArray<int> OBJDOPAAOFN, NativeArray<int> BGKHKNDOJLB)
	{
		return default(PIJFAJOOLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3590", Offset = "0x6CC2790", VA = "0x186CC3590", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6CC34B0", Offset = "0x6CC26B0", VA = "0x186CC34B0")]
	private bool DJBOPLHONEE(int PMNHOLIPOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3480", Offset = "0x6CC2680", VA = "0x186CC3480")]
	private void CCEBJGKACAK(NativeArray<int> LCMJHGDLFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CC34F0", Offset = "0x6CC26F0", VA = "0x186CC34F0")]
	private int ECBGEOBOKHC(int DKLFMGGMEFM, int AHJFPHOAGEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3670", Offset = "0x6CC2870", VA = "0x186CC3670")]
	private void HDEDGOGEPFO(NativeArray<int> LCMJHGDLFJG, int IJLMHLHBKLK, int EHGBCDPMKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3740", Offset = "0x6CC2940", VA = "0x186CC3740")]
	private void LHFEMCCBNKL(NativeArray<int> LCMJHGDLFJG, int LCCDAHBBLNG, int GFDJDGGFOLH, int NBANENHEAIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public abstract class ANFCFKCOBGI : CDBPDONECIJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly NDMHPECFMDH ABCJMMEJHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected readonly DMHIANCOLDD KHPOAPBJGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private AHLDMKEGJBB[] DBFKPAHDCAH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static CDBPDONECIJ LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6CACC50", Offset = "0x6CABE50", VA = "0x186CACC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ADPKHEFCKGP MKNLHIHLLHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(ADPKHEFCKGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE040", Offset = "0x7CD240", VA = "0x1807CE040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DMHIANCOLDD GAFDHAGANOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AEBIBAEBDOJ JAOFLBLEFCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD2D0", Offset = "0x6CAC4D0", VA = "0x186CAD2D0")]
	public static MGBJAGNHOEE GLMNAMGCIEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD790", Offset = "0x6CAC990", VA = "0x186CAD790")]
	[Preserve]
	protected ANFCFKCOBGI([KFHLAIGNCCH(null)] NDMHPECFMDH ABCJMMEJHCN, [KFHLAIGNCCH(null)] DMHIANCOLDD KHPOAPBJGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6CACA70", Offset = "0x6CABC70", VA = "0x186CACA70", Slot = "6")]
	public MGBJAGNHOEE AMLDLFJMPOP(IEnumerator<AEBIBAEBDOJ> MIPGJOOJHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC870", Offset = "0x6CABA70", VA = "0x186CAC870", Slot = "7")]
	public MGBJAGNHOEE AMLDLFJMPOP(Behaviour EOIJJPCMNGA, IEnumerator<AEBIBAEBDOJ> MIPGJOOJHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public abstract MGBJAGNHOEE IJEPJDJPCIP(OKLILHAGNLK EOIJJPCMNGA, IEnumerator<AEBIBAEBDOJ> MIPGJOOJHLF);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6CACCA0", Offset = "0x6CABEA0", VA = "0x186CACCA0", Slot = "17")]
	public virtual void CFPPHLPBNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD3A0", Offset = "0x6CAC5A0", VA = "0x186CAD3A0", Slot = "9")]
	public void IBFIBPCOOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6CACE40", Offset = "0x6CAC040", VA = "0x186CACE40", Slot = "18")]
	protected virtual void DBKEHPIBNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD360", Offset = "0x6CAC560", VA = "0x186CAD360")]
	private void GLNONMKICNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD220", Offset = "0x6CAC420", VA = "0x186CAD220")]
	private void EAOAHNAFAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD380", Offset = "0x6CAC580", VA = "0x186CAD380")]
	private void HLFNFEDAPBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD770", Offset = "0x6CAC970", VA = "0x186CAD770")]
	private void PGCGPOFCACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC850", Offset = "0x6CABA50", VA = "0x186CAC850")]
	private void AJCGONNKLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD660", Offset = "0x6CAC860", VA = "0x186CAD660")]
	private void LHPMIJIDGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD5E0", Offset = "0x6CAC7E0", VA = "0x186CAD5E0")]
	private void JIGLIMNCCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD240", Offset = "0x6CAC440", VA = "0x186CAD240", Slot = "19")]
	public virtual void FMMKEOJGCKN(ADPKHEFCKGP BGOAJDAJJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CACA80", Offset = "0x6CABC80", VA = "0x186CACA80")]
	private void BKCMFKCGDBJ(AHLDMKEGJBB BFDAAGGMPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1DC12E0", Offset = "0x1DC04E0", VA = "0x181DC12E0")]
	private AHLDMKEGJBB LJAOLEBEFNN(ADPKHEFCKGP HHJOOHJDNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "20")]
	internal abstract LJNCGLBMMLP GEOLAFDBJHP(IEnumerator<AEBIBAEBDOJ> MIPGJOOJHLF, Behaviour MNJAELFPAAK, OLPPBFBJGED OADKHAONNFK);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "21")]
	internal abstract AHLDMKEGJBB LEGIEDMLMDJ(ADPKHEFCKGP BGOAJDAJJJJ);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6CACE60", Offset = "0x6CAC060", VA = "0x186CACE60", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD680", Offset = "0x6CAC880", VA = "0x186CAD680", Slot = "12")]
	public AEBIBAEBDOJ MMBOKEMKBDC(ADPKHEFCKGP EBICMOKHPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD6E0", Offset = "0x6CAC8E0", VA = "0x186CAD6E0", Slot = "13")]
	public AEBIBAEBDOJ NAGKHEPALLB(float CNDFBLFAGOA, ADPKHEFCKGP EBICMOKHPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD600", Offset = "0x6CAC800", VA = "0x186CAD600", Slot = "14")]
	public AEBIBAEBDOJ KMAFHDPMJHC(Func<bool> GNKJEJLMAJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal sealed class LJNCGLBMMLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly OLPPBFBJGED KNAMOHMAFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly NKGPKKIFDCA EOIJJPCMNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly bool LFKMANKIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private string IIADHBOODBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private StackTrace GEDMOLODLHD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IEnumerator<AEBIBAEBDOJ> KJJEMJNIAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public AEBIBAEBDOJ KAHEFDFDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool NNJDONGHHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0BD0", Offset = "0x6CBFDD0", VA = "0x186CC0BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HKKNFAKENFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x919310", Offset = "0x918510", VA = "0x180919310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x919430", Offset = "0x918630", VA = "0x180919430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0C50", Offset = "0x6CBFE50", VA = "0x186CC0C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float DBDCDJIDBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x834EC0", Offset = "0x8340C0", VA = "0x180834EC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x59CAF30", Offset = "0x59CA130", VA = "0x1859CAF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0F30", Offset = "0x6CC0130", VA = "0x186CC0F30")]
	public LJNCGLBMMLP(IEnumerator<AEBIBAEBDOJ> CHJGCJJFMHP, NKGPKKIFDCA EOIJJPCMNGA, OLPPBFBJGED KNAMOHMAFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6CC08C0", Offset = "0x6CBFAC0", VA = "0x186CC08C0")]
	public AEBIBAEBDOJ DGMGPLAIOLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0850", Offset = "0x6CBFA50", VA = "0x186CC0850")]
	public bool DCJCDDIFEJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0E00", Offset = "0x6CC0000", VA = "0x186CC0E00")]
	public void MCBLLIMDNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0E50", Offset = "0x6CC0050", VA = "0x186CC0E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9CF040", Offset = "0x9CE240", VA = "0x1809CF040")]
	[CompilerGenerated]
	private void CMBBMLNLJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal sealed class OLPPBFBJGED : PFDKFIADJPC, MGBJAGNHOEE, GJCJPABGAJD, BNCJCHBDCBI, IEnumerator, AEBIBAEBDOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private ADPKHEFCKGP JLDGNHABDEF;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private ADPKHEFCKGP CENHCPMDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xF5B4D0", Offset = "0xF5A6D0", VA = "0x180F5B4D0", Slot = "23")]
		get
		{
			return default(ADPKHEFCKGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public ADPKHEFCKGP IPFIKLPNNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1484FF0", Offset = "0x14841F0", VA = "0x181484FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private float DHJIKBBFOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x965900", Offset = "0x964B00", VA = "0x180965900", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EFGCAIMJFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC28D0", Offset = "0x6CC1AD0", VA = "0x186CC28D0", Slot = "24")]
	private bool BKHDJGCMHKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6CC28F0", Offset = "0x6CC1AF0", VA = "0x186CC28F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2900", Offset = "0x6CC1B00", VA = "0x186CC2900")]
	public OLPPBFBJGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal enum GNJNCDNEIAN : byte
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
internal sealed class AHLDMKEGJBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum MAKGKAHLJFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct MLIFKJEFMFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public ADPKHEFCKGP AMNLFAPILCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public MAKGKAHLJFD JIAFMBFJCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public List<LJNCGLBMMLP> ICKCKCCBNFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly MAKGKAHLJFD[] BNHKKCLJOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly ADPKHEFCKGP BGOAJDAJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool DDLLHFOFBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly LJNCGLBMMLP[] GHLNKCFHOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<LJNCGLBMMLP> FNONDAGPMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Stack<int> PANPFLINAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly List<LJNCGLBMMLP> MBACMCMNJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Stack<int> PHIAAAFOOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly PDNMDDPOFAF KHNDACCLKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private bool JFPMEHEECIH;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public MLIFKJEFMFC[,] IMDGLGJFMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6CABE30", Offset = "0x6CAB030", VA = "0x186CABE30")]
	public AHLDMKEGJBB(ADPKHEFCKGP EBICMOKHPAM, PDNMDDPOFAF KHNDACCLKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6CAABA0", Offset = "0x6CA9DA0", VA = "0x186CAABA0")]
	public void GCJLPIJFNKO(LJNCGLBMMLP CHJGCJJFMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6CABA10", Offset = "0x6CAAC10", VA = "0x186CABA10")]
	public void PEDLIOHFDIA(IList<LJNCGLBMMLP> KLAICAPAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6CAACB0", Offset = "0x6CA9EB0", VA = "0x186CAACB0")]
	public void GLOBMOJHGFK(IList<LJNCGLBMMLP> KLAICAPAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB8C0", Offset = "0x6CAAAC0", VA = "0x186CAB8C0")]
	private void OLKENPIAKBE(LJNCGLBMMLP CHJGCJJFMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB480", Offset = "0x6CAA680", VA = "0x186CAB480")]
	private void IJIELKKALKI(IList<LJNCGLBMMLP> KLAICAPAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB600", Offset = "0x6CAA800", VA = "0x186CAB600")]
	private GNJNCDNEIAN JKJJNLOMGNH(LJNCGLBMMLP CHJGCJJFMHP)
	{
		return default(GNJNCDNEIAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA910", Offset = "0x6CA9B10", VA = "0x186CAA910")]
	public void DBKEHPIBNHN(float HJNBFIECMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB290", Offset = "0x6CAA490", VA = "0x186CAB290")]
	public void IBFIBPCOOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAF90", Offset = "0x6CAA190", VA = "0x186CAAF90")]
	private void HCFNOEAKGGL(List<LJNCGLBMMLP> KLAICAPAEGH, Stack<int> NDOAPNGMKLI, bool LBKGLCEPNNN, float DHONFCEMEPH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAA80", Offset = "0x6CA9C80", VA = "0x186CAAA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB780", Offset = "0x6CAA980", VA = "0x186CAB780")]
	private void LKOMDABMKDA(List<LJNCGLBMMLP> KLAICAPAEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class IIGIHMMEIIE : PDNMDDPOFAF
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
	public void LMCKOPHPNDA(string IIADHBOODBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
	public void PFMCDEFPNOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public IIGIHMMEIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class LDDDDCKKNCC : NKGPKKIFDCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Behaviour MNJAELFPAAK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFD40", Offset = "0x6CBEF40", VA = "0x186CBFD40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FHMOGPBMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFCD0", Offset = "0x6CBEED0", VA = "0x186CBFCD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CKHCAAFJNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6CBFD20", Offset = "0x6CBEF20", VA = "0x186CBFD20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public LDDDDCKKNCC(Behaviour MNJAELFPAAK)
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

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
public class FMCJEDGGDPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority NLIDPDJDJGI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x516A960", Offset = "0x5168F60", VA = "0x18516A960")]
	public FMCJEDGGDPG(ThreadPriority MCLMKPIFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x516A950", Offset = "0x5168F50", VA = "0x18516A950", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> FJGKKGEPBAP(List<PlayerLoopSystem> AAGNKENEBPD, int FJEOFMOPJAF);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct LNJFLADHOMK
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EDMNPJFJLOD
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static BOBAGNNLEHP HFOFHFKFBMJ;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5169630", Offset = "0x5167C30", VA = "0x185169630")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MFOLPCENKDD
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static BOBAGNNLEHP PIOMFCGIIEH;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5178040", Offset = "0x5176640", VA = "0x185178040")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PAJDNAEGFBD
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static BOBAGNNLEHP ILPDPBIMPNE;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x517A160", Offset = "0x5178760", VA = "0x18517A160")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct JCLPFENNDFO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static BOBAGNNLEHP CFBMMAIKBPI;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static BOBAGNNLEHP GKMBPIIIIFG;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static BOBAGNNLEHP GKFNOACJHPN;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static BOBAGNNLEHP BHHFFGIGONN;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5170CC0", Offset = "0x516F2C0", VA = "0x185170CC0")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct BPGBNNIKEPM
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static BOBAGNNLEHP MDDGIHHMIIE;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5162700", Offset = "0x5160D00", VA = "0x185162700")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct GGBFIKNCJEE
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static BOBAGNNLEHP CFBMMAIKBPI;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static BOBAGNNLEHP GKMBPIIIIFG;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static BOBAGNNLEHP GKFNOACJHPN;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static BOBAGNNLEHP BHHFFGIGONN;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x516B920", Offset = "0x5169F20", VA = "0x18516B920")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct GNEEOLKJJII
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static BOBAGNNLEHP HKGJJOHICBL;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x516BCD0", Offset = "0x516A2D0", VA = "0x18516BCD0")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct NGHPMLKIIJE
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static BOBAGNNLEHP OGJKPBJJLEO;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5178DA0", Offset = "0x51773A0", VA = "0x185178DA0")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct BCHDCEIGGGC
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static BOBAGNNLEHP KFCIMJJDAIA;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5160910", Offset = "0x515EF10", VA = "0x185160910")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct HHCBHDDEEII
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static BOBAGNNLEHP BDHFEFHKPIP;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x516DD80", Offset = "0x516C380", VA = "0x18516DD80")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct FODHPEDOMOA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static BOBAGNNLEHP MPMIGDJKIBG;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x516A9A0", Offset = "0x5168FA0", VA = "0x18516A9A0")]
				public static PlayerLoopSystem OAHKCJFNHDC()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public enum MBKANHCGDFP : byte
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
			public struct BBBJINJJKEA
			{
				[Cpp2IlInjected.Token(Token = "0x200001E")]
				[CompilerGenerated]
				private sealed class MIJHNMHEKCN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					public MBKANHCGDFP updateStage;

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
					public MIJHNMHEKCN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004A")]
					[Cpp2IlInjected.Address(RVA = "0x5178550", Offset = "0x5176B50", VA = "0x185178550")]
					internal void ECDDMACJGCD()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static NGNHBGJPOEA<MBKANHCGDFP> COPCCELCNJK;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5160730", Offset = "0x515ED30", VA = "0x185160730")]
				public static PlayerLoopSystem OAHKCJFNHDC(MBKANHCGDFP BCJJOKNLMJI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct ADINJPMGKGC
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class FIADOAKAEDP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public DFEAHJJIMOF.PHPMJOJNMDF key;

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
					public FIADOAKAEDP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004D")]
					[Cpp2IlInjected.Address(RVA = "0x516A650", Offset = "0x5168C50", VA = "0x18516A650")]
					internal void DCCLAKNAGMJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000035")]
				public static IDisposable NCNCMMIAKCF;

				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x515FC30", Offset = "0x515E230", VA = "0x18515FC30")]
				public static PlayerLoopSystem IBPDDLPPFLI(DFEAHJJIMOF.PHPMJOJNMDF NAJDAPHOGEH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000022")]
			internal struct MICFCEBHBBE
			{
				[Cpp2IlInjected.Token(Token = "0x2000023")]
				[CompilerGenerated]
				private sealed class BLLOJMMMAPC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public DFEAHJJIMOF.PHPMJOJNMDF key;

					[Cpp2IlInjected.Token(Token = "0x6000052")]
					[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
					public BLLOJMMMAPC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000053")]
					[Cpp2IlInjected.Address(RVA = "0x51612A0", Offset = "0x515F8A0", VA = "0x1851612A0")]
					internal void DCCLAKNAGMJ()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x51783F0", Offset = "0x51769F0", VA = "0x1851783F0")]
				public static PlayerLoopSystem IBPDDLPPFLI(DFEAHJJIMOF.PHPMJOJNMDF NAJDAPHOGEH)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class HKOJOHHHCNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public HKOJOHHHCNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x516FD20", Offset = "0x516E320", VA = "0x18516FD20")]
			internal List<PlayerLoopSystem> NHLLFBLKGIM(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool MDNGHGCCDOI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LFMJIPKEDJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x51669C0", Offset = "0x5164FC0", VA = "0x1851669C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5166A00", Offset = "0x5165000", VA = "0x185166A00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5164340", Offset = "0x5162940", VA = "0x185164340")]
		private static void HBHNKBPMFLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5163320", Offset = "0x5161920", VA = "0x185163320")]
		private static void CIDAONPPDOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5164010", Offset = "0x5162610", VA = "0x185164010")]
		private static void GCGPBDLODHB(string IDFBMAKJFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5162F20", Offset = "0x5161520", VA = "0x185162F20")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5163150", Offset = "0x5161750", VA = "0x185163150")]
		private static void CGMINMDGAME(DFEAHJJIMOF.PHPMJOJNMDF NAJDAPHOGEH, ref PlayerLoopSystem AKKHPPEEBMJ, Type EJOEICGFKGE, Type FDBGOJJKFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5163BF0", Offset = "0x51621F0", VA = "0x185163BF0")]
		private static void EGAJMBEDBDL(ref PlayerLoopSystem AKKHPPEEBMJ, Type EJOEICGFKGE, Type FDBGOJJKFCK, FJGKKGEPBAP FHJGHJBBIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5166A40", Offset = "0x5165040", VA = "0x185166A40")]
		private static void LCABDPMIDGB(ref PlayerLoopSystem AKKHPPEEBMJ, Type EJOEICGFKGE, Type FDBGOJJKFCK, PlayerLoopSystem? EMFAMJKKFCC, PlayerLoopSystem? IKPMNGGDOKM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DFEAHJJIMOF
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum PHPMJOJNMDF
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
	public class FPPIEBJNIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly PHPMJOJNMDF DABBFHIFGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly BNKDLLNJKIK NLCOAJKCGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private long GFOKIDOPAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private long JHGNFCMINBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long OLCJIMGDDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int LOKKJNOOPON;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x516B820", Offset = "0x5169E20", VA = "0x18516B820")]
		public FPPIEBJNIMN(PHPMJOJNMDF BFMEMOONKLJ, int ENENJONOOHF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x516B550", Offset = "0x5169B50", VA = "0x18516B550")]
		public void DMKNCNFAAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x516B7C0", Offset = "0x5169DC0", VA = "0x18516B7C0")]
		public void LJFOOGGPJFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x516B5C0", Offset = "0x5169BC0", VA = "0x18516B5C0")]
		public void LCPNLBKNKCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static PHPMJOJNMDF[] BPAIKBHIPFO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static FPPIEBJNIMN[] NLIDHBPCDHN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5168D80", Offset = "0x5167380", VA = "0x185168D80")]
	public static FPPIEBJNIMN IEIEFHCFBCK(PHPMJOJNMDF NAJDAPHOGEH, int ENENJONOOHF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5168C40", Offset = "0x5167240", VA = "0x185168C40")]
	public static FPPIEBJNIMN ALCBFEOLNCC(PHPMJOJNMDF NAJDAPHOGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5168CD0", Offset = "0x51672D0", VA = "0x185168CD0")]
	public static void BDLJJPBCCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class LMILGFALLKN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private interface EBFFDDPKECI
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool GFCFCDPICKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LOJGLKLMFMO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private abstract class JOLFMBCLJBB<TPromise, TMainThreadPromise> : EBFFDDPKECI where TPromise : ADCACBFKFKM where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly TPromise JAELCOBJGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		protected readonly TMainThreadPromise DAEFOHGKBFB;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TPromise GIPPHIIMMAG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2E74D70", Offset = "0x2E73370", VA = "0x182E74D70")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GFCFCDPICKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x2E74DD0", Offset = "0x2E733D0", VA = "0x182E74DD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1EF81D0", Offset = "0x1EF67D0", VA = "0x181EF81D0")]
		protected JOLFMBCLJBB(TPromise JAELCOBJGFF, TMainThreadPromise DEIJHEECBJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2E74E20", Offset = "0x2E73420", VA = "0x182E74E20", Slot = "5")]
		public void LOJGLKLMFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void IIDOMOEDBCM(TPromise JAELCOBJGFF);
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class FBMABKNCEGE<T> : JOLFMBCLJBB<LEKACFEIBBA<T>, CDOEGNNFKFF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1658D10", Offset = "0x1657310", VA = "0x181658D10")]
		public FBMABKNCEGE(LEKACFEIBBA<T> JAELCOBJGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1658AE0", Offset = "0x16570E0", VA = "0x181658AE0", Slot = "6")]
		protected override void IIDOMOEDBCM(LEKACFEIBBA<T> JAELCOBJGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1658CE0", Offset = "0x16572E0", VA = "0x181658CE0")]
		[CompilerGenerated]
		private void JAAFLJNDFEM(T COGPMIAOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x122C440", Offset = "0x122AA40", VA = "0x18122C440")]
		[CompilerGenerated]
		private void KJJDGMEJKPE(string KAEDNDEPIBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class NBNGKPCHPCB : EBFFDDPKECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Action INJMGBDPOBO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GFCFCDPICKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
		public NBNGKPCHPCB(Action INJMGBDPOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x94CC50", Offset = "0x94B250", VA = "0x18094CC50", Slot = "5")]
		public void LOJGLKLMFMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<EBFFDDPKECI> HOGICPIJAED;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x233AC40", Offset = "0x2339240", VA = "0x18233AC40")]
	public static LEKACFEIBBA<T> IIAGKOLLJEO<T>(this LEKACFEIBBA<T> JAELCOBJGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5175B20", Offset = "0x5174120", VA = "0x185175B20")]
	public static void IIAGKOLLJEO(Action INJMGBDPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x233ACB0", Offset = "0x23392B0", VA = "0x18233ACB0")]
	private static LEKACFEIBBA<T> PLPKJCEOCKG<T>(LEKACFEIBBA<T> JAELCOBJGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5175BB0", Offset = "0x51741B0", VA = "0x185175BB0")]
	private static void MCCGBCNLMNK(EBFFDDPKECI FBJFBEOODHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5175750", Offset = "0x5173D50", VA = "0x185175750")]
	private static void HNLBPPKOKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5175650", Offset = "0x5173C50", VA = "0x185175650")]
	private static void DMKFNGJAAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5175A50", Offset = "0x5174050", VA = "0x185175A50")]
	private static void HPDEIFGPFGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HDGDENONGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private struct BLNCBGDJPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> KBKBKFMCOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string HBJAIAIJNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode LNLGPIAHLCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool PDMFAMLNECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5161530", Offset = "0x515FB30", VA = "0x185161530")]
		public BLNCBGDJPHF(TaskCompletionSource<Scene> PIOIJHMDOGD, string HBJAIAIJNHL, LoadSceneMode LNLGPIAHLCO, bool PDMFAMLNECL, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BAPBHOAJOCD : IAsyncStateMachine
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
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private NHNLOHOBNME<string> <toDispose>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private GLGLBCADGJK <stackTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private BLNCBGDJPHF <queuedSceneLoad>5__4;

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
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BAPBHOAJOCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x515FEC0", Offset = "0x515E4C0", VA = "0x18515FEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LCFABLNPDOL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LCFABLNPDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x51751A0", Offset = "0x51737A0", VA = "0x1851751A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CFOCLFMIBGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private BLNCBGDJPHF <dequeued>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public CFOCLFMIBGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5162910", Offset = "0x5160F10", VA = "0x185162910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class EOFGGMGJMOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CDOEGNNFKFF<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EOFGGMGJMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x51699D0", Offset = "0x5167FD0", VA = "0x1851699D0")]
		internal void GGIIEENNBLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class IAPBPDCFNME : IAsyncStateMachine
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
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <loadSceneTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private EOFGGMGJMOA <>8__2;

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
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Scene <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IAPBPDCFNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x516FF50", Offset = "0x516E550", VA = "0x18516FF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LNALLDMEEFB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LNALLDMEEFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5175E30", Offset = "0x5174430", VA = "0x185175E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ODNKJBMADKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public NHNLOHOBNME<string>.NOELMCIDFEB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private Scene <emptyScene>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <emptySceneRoutineTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <emptySceneTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private Scene <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private NHNLOHOBNME<string>.NOELMCIDFEB <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ODNKJBMADKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5179760", Offset = "0x5177D60", VA = "0x185179760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ONBBHAKLDLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ONBBHAKLDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x517A130", Offset = "0x5178730", VA = "0x18517A130")]
		internal bool EIBFHOKNGPM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NHIIPLLCEAE : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public MDOIJNHMNCN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private IDisposable <sample>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ONBBHAKLDLD <>8__3;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public NHIIPLLCEAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x51793C0", Offset = "0x51779C0", VA = "0x1851793C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5178FB0", Offset = "0x51775B0", VA = "0x185178FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5179330", Offset = "0x5177930", VA = "0x185179330")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5179380", Offset = "0x5177980", VA = "0x185179380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JMGEJACINED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CDOEGNNFKFF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public JMGEJACINED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5170F80", Offset = "0x516F580", VA = "0x185170F80")]
		internal bool DHALDJELIAL(Scene scene)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5171000", Offset = "0x516F600", VA = "0x185171000")]
		internal void FACNNFIJOCG(Scene scene, LoadSceneMode mode)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KMGAGNNJLJN : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CDOEGNNFKFF<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private JMGEJACINED <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private IDisposable <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private Exception <ex>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public KMGAGNNJLJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5171F80", Offset = "0x5170580", VA = "0x185171F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x51727B0", Offset = "0x5170DB0", VA = "0x1851727B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ICollection<string> KNLEDCJIDEB;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static ADCACBFKFKM LAPEMGLJAOO;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation BIICFDOOIBG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static ADCACBFKFKM PKMDMFCANJH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string ODGDHOPNNJO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority BCKLFKKLGNO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task PKBEPPGLIMO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static List<SceneInstance> JEMEHBPGNNC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<BLNCBGDJPHF> OOGMNAKCDJH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task BFGFBIDCDHM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool PLAPHBIMGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x516C360", Offset = "0x516A960", VA = "0x18516C360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private static bool DCAKHDFHJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x516C890", Offset = "0x516AE90", VA = "0x18516C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private static bool KDFLHBILJOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x516C7D0", Offset = "0x516ADD0", VA = "0x18516C7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private static bool JJCOOBDHDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x516D9E0", Offset = "0x516BFE0", VA = "0x18516D9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MIBMMNJDOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x516CAE0", Offset = "0x516B0E0", VA = "0x18516CAE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x516CD90", Offset = "0x516B390", VA = "0x18516CD90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x516C290", Offset = "0x516A890", VA = "0x18516C290")]
	[BEIEJGBHBAP(HEKNLLBMOLL.EnteredEditModeNextFrame, 0)]
	private static void BPNGODPBFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x516CBE0", Offset = "0x516B1E0", VA = "0x18516CBE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BAPBHOAJOCD))]
	public static Task<Scene> KAPIHEOHGBP(string HBJAIAIJNHL, LoadSceneMode LNLGPIAHLCO = LoadSceneMode.Single, bool PDMFAMLNECL = false, [Optional] NHNLOHOBNME<string>.NOELMCIDFEB MNGPHFCDHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x516D6F0", Offset = "0x516BCF0", VA = "0x18516D6F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LCFABLNPDOL))]
	private static Task OJAOEIAIDBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x516C9E0", Offset = "0x516AFE0", VA = "0x18516C9E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CFOCLFMIBGE))]
	private static Task GLPPALFCDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x516D450", Offset = "0x516BA50", VA = "0x18516D450")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IAPBPDCFNME))]
	private static Task<Scene> NKCILMNPCLG(string HBJAIAIJNHL, LoadSceneMode LNLGPIAHLCO, bool PDMFAMLNECL, NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x516D600", Offset = "0x516BC00", VA = "0x18516D600")]
	private static void OGAHLBAGLCD(SceneInstance CMNEOBJBOCK, LoadSceneMode LNLGPIAHLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x516D250", Offset = "0x516B850", VA = "0x18516D250")]
	private static void NDJIFMCILPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x516D2F0", Offset = "0x516B8F0", VA = "0x18516D2F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LNALLDMEEFB))]
	private static Task<Scene> NHCFHCDDGID(string HBJAIAIJNHL, LoadSceneMode LNLGPIAHLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x516CE90", Offset = "0x516B490", VA = "0x18516CE90")]
	private static bool KFLGIOCLIHM(string HBJAIAIJNHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x516C5E0", Offset = "0x516ABE0", VA = "0x18516C5E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ODNKJBMADKO))]
	private static Task<Scene> CLHIKNIGBNA(NHNLOHOBNME<string>.NOELMCIDFEB FLAKFKAEKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x516D7F0", Offset = "0x516BDF0", VA = "0x18516D7F0")]
	public static LEKACFEIBBA<Scene> OJJJAKABCIG(string HBJAIAIJNHL, LoadSceneMode LNLGPIAHLCO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x516CF80", Offset = "0x516B580", VA = "0x18516CF80")]
	public static ADCACBFKFKM KMOOOCICAMH(string HBJAIAIJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x516C950", Offset = "0x516AF50", VA = "0x18516C950")]
	[IteratorStateMachine(typeof(NHIIPLLCEAE))]
	private static IEnumerator<NGCINEPJDAB> GAELAMOACEJ(string HBJAIAIJNHL, MDOIJNHMNCN LENIPDCIJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x516C730", Offset = "0x516AD30", VA = "0x18516C730")]
	[IteratorStateMachine(typeof(KMGAGNNJLJN))]
	private static IEnumerator<NGCINEPJDAB> ECOHLPAMANF(string HBJAIAIJNHL, LoadSceneMode LNLGPIAHLCO, CDOEGNNFKFF<Scene> LENIPDCIJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x516DA90", Offset = "0x516C090", VA = "0x18516DA90")]
	public static bool ONJECBPAKOO(out string GMLFOLBKBOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BNKDLLNJKIK : CGGPLBCOMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int IBPJKNKLINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Queue<double> MPEOLEINFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private double OKHAFKCALGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private double KMEINNAJPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private double AFBKKGFDOFN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public double BEBJIDDDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5161A70", Offset = "0x5160070", VA = "0x185161A70", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double HFKKFPGKELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x175F910", Offset = "0x175DF10", VA = "0x18175F910", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double MCJJBONCDID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2E60", Offset = "0x3DC1460", VA = "0x183DC2E60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5161C10", Offset = "0x5160210", VA = "0x185161C10")]
	public BNKDLLNJKIK(int FHLDMMKIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5161AE0", Offset = "0x51600E0", VA = "0x185161AE0", Slot = "7")]
	public void KKACKCIJKKC(double CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5161A00", Offset = "0x5160000", VA = "0x185161A00", Slot = "8")]
	public void BCFKLBADKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class MHMPBEGNDAM : CGGPLBCOMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private long EGIKAKGFKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private double PCCKEKHGFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private double FAOBDAGHIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private double INHIIKAMFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private double FJINLKHODFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private double OKHAFKCALGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private double KMEINNAJPFI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9584E0", Offset = "0x956AE0", VA = "0x1809584E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double HFKKFPGKELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x51783E0", Offset = "0x51769E0", VA = "0x1851783E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public double MCJJBONCDID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x51782A0", Offset = "0x51768A0", VA = "0x1851782A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public double IBKIPFNCBDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5178290", Offset = "0x5176890", VA = "0x185178290")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public double BEBJIDDDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x508A7B0", Offset = "0x5088DB0", VA = "0x18508A7B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x51782B0", Offset = "0x51768B0", VA = "0x1851782B0", Slot = "7")]
	public virtual void KKACKCIJKKC(double CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5178250", Offset = "0x5176850", VA = "0x185178250", Slot = "8")]
	public virtual void BCFKLBADKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x516A510", Offset = "0x5168B10", VA = "0x18516A510")]
	public MHMPBEGNDAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FGAKFJPCIPG : MHMPBEGNDAM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public double DLBMKHMEEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9980", Offset = "0x3EF7F80", VA = "0x183EF9980")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9990", Offset = "0x3EF7F90", VA = "0x183EF9990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x516A3D0", Offset = "0x51689D0", VA = "0x18516A3D0", Slot = "7")]
	public override void KKACKCIJKKC(double CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x516A390", Offset = "0x5168990", VA = "0x18516A390", Slot = "8")]
	public override void BCFKLBADKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x516A510", Offset = "0x5168B10", VA = "0x18516A510")]
	public FGAKFJPCIPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CGGPLBCOMCE
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double BEBJIDDDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double HFKKFPGKELC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	double MCJJBONCDID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class JOEKIEEAMAN : HIIHACBNOPE
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float EONLDJLDEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5171420", Offset = "0x516FA20", VA = "0x185171420", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public float GEKOGAHGGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5171430", Offset = "0x516FA30", VA = "0x185171430", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public double AKPCNBJFGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5171400", Offset = "0x516FA00", VA = "0x185171400", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5171390", Offset = "0x516F990", VA = "0x185171390")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	[Preserve]
	internal JOEKIEEAMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class LNDDKCHCMLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class LJPEKFNNKAM : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public LNDDKCHCMLN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public LJPEKFNNKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5175570", Offset = "0x5173B70", VA = "0x185175570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5175610", Offset = "0x5173C10", VA = "0x185175610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private CJLKEKBECCD CGJNLANLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private MonoBehaviour HDCKPNAJBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Action OBDGKOOMMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Action<float> OIGBFNKDDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float NNHCKLPANAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private bool DEAJNPKJIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly KJBDCMOEPPK PCEPCKIAOGH;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5177190", Offset = "0x5175790", VA = "0x185177190")]
	public LNDDKCHCMLN(MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5176F50", Offset = "0x5175550", VA = "0x185176F50")]
	public LNDDKCHCMLN(MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5177390", Offset = "0x5175990", VA = "0x185177390")]
	public LNDDKCHCMLN(MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A5FC50", Offset = "0x3A5E250", VA = "0x183A5FC50")]
	private LNDDKCHCMLN(KJBDCMOEPPK PCEPCKIAOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5176AB0", Offset = "0x51750B0", VA = "0x185176AB0")]
	internal static LNDDKCHCMLN LPBEJLKKBIG(MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5176770", Offset = "0x5174D70", VA = "0x185176770")]
	private void HKFKBCADFDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5176530", Offset = "0x5174B30", VA = "0x185176530")]
	private void FOLDJEEGIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5176320", Offset = "0x5174920", VA = "0x185176320")]
	private void DCCPDEBHECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x51768E0", Offset = "0x5174EE0", VA = "0x1851768E0")]
	private void JJNJHAEMDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5176CF0", Offset = "0x51752F0", VA = "0x185176CF0")]
	private void OLKMALLOOFH(string KAEDNDEPIBA, Action JEMFKFGEFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5176EC0", Offset = "0x51754C0", VA = "0x185176EC0")]
	[IteratorStateMachine(typeof(LJPEKFNNKAM))]
	private IEnumerator<NGCINEPJDAB> POLHDKMPOEC(Action JEMFKFGEFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x51764D0", Offset = "0x5174AD0", VA = "0x1851764D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x51766E0", Offset = "0x5174CE0", VA = "0x1851766E0")]
	[CompilerGenerated]
	private void HGHOKCCIOMD(string OHPJJHOMFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5176C60", Offset = "0x5175260", VA = "0x185176C60")]
	[CompilerGenerated]
	private void NJNOKFDKFDB(string OHPJJHOMFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5176BD0", Offset = "0x51751D0", VA = "0x185176BD0")]
	[CompilerGenerated]
	private void NIHPDLAPMNK(string OHPJJHOMFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5176E30", Offset = "0x5175430", VA = "0x185176E30")]
	[CompilerGenerated]
	private void PEANCOLOPCA(string OHPJJHOMFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BurstCompile]
internal struct JOJGFDFOKNF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ReadOnly]
	public float GMHDEAHJDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[ReadOnly]
	public int JLADGCHEICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeArray<int> IILPIBLHNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> ELLNFFDLGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> KJDNFONHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	public NativeArray<IFGLLBCILPH> IHJPGFLIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	public NativeArray<float> ANAPNAJLPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[WriteOnly]
	public NativeArray<int> KALMPLDKNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[WriteOnly]
	public NativeArray<int> MELGCLHOMIJ;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x51718D0", Offset = "0x516FED0", VA = "0x1851718D0")]
	public static JOJGFDFOKNF PJDMJLOGMBM(int MPMBMIMNJOA, float JAJIOMNNJCE, NativeArray<IFGLLBCILPH> KKCNDFCCIHB, NativeArray<float> EBIGGAIADKI, NativeArray<int> LHIFJGAMMEO, NativeArray<int> KENPIAODJBG, NativeArray<int> PHGNEJKBMIE, NativeArray<int> ELLNFFDLGMD, NativeArray<int> KJDNFONHGLL)
	{
		return default(JOJGFDFOKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x51714D0", Offset = "0x516FAD0", VA = "0x1851714D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x51717C0", Offset = "0x516FDC0", VA = "0x1851717C0")]
	private bool JGMEFNJEOBJ(int IIOMOLKAONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5171440", Offset = "0x516FA40", VA = "0x185171440")]
	private void ACFDFCMCIAK(NativeArray<int> FCPLINDOOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5171470", Offset = "0x516FA70", VA = "0x185171470")]
	private int CDOPCBMHNLH(int AKPHBHANJAC, int AIBMHLDJDDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5171800", Offset = "0x516FE00", VA = "0x185171800")]
	private void KFDOLNHLKJK(NativeArray<int> FCPLINDOOEO, int IHIPOJJDJMF, int MBLEGMGDGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x51715B0", Offset = "0x516FBB0", VA = "0x1851715B0")]
	private void FEFHNAMHMMA(NativeArray<int> FCPLINDOOEO, int IACJHCIJMHH, int MIDOGGPOCNH, int NNEPLBEHOGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BMIMMDLOAPI : DANNPEHEEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly float CGACLKABNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int DNKLANKKKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly float FKKNOGCGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly float[] FEFKPHKJKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int ALHBOAJEJHB;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5161850", Offset = "0x515FE50", VA = "0x185161850")]
	public BMIMMDLOAPI(Behaviour JHAKINLMMJL, float JBCKAEMECKP, int DNKLANKKKHD, [Optional] Action EBIPALFCGLD, float FKKNOGCGDPB = 0f, [Optional] KJBDCMOEPPK PCEPCKIAOGH, [Optional] HIIHACBNOPE OJMOMAFCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "9")]
	protected override bool GFELLNBJLOI(Action INJMGBDPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5161590", Offset = "0x515FB90", VA = "0x185161590", Slot = "10")]
	protected override bool BCCMFDPIAHE(Action INJMGBDPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x51617C0", Offset = "0x515FDC0", VA = "0x1851617C0")]
	private void GMPLLGNMMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class HHGELGCKIKG : KJBDCMOEPPK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly GCFOBCGKOME KCDIPEJCJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly HIIHACBNOPE OJMOMAFCOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly APALKAPBDFJ CGKPKJDFNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private DBJAHPEJENP[] GMEBDFEHGMF;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static KJBDCMOEPPK FBBAELKBDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x516ED50", Offset = "0x516D350", VA = "0x18516ED50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool AGOOCBLDBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public PIDFMOOOHBA.JFIAFIOIOLN DFPPKKDHHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(PIDFMOOOHBA.JFIAFIOIOLN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x954A40", Offset = "0x953040", VA = "0x180954A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HIIHACBNOPE JDIAMMHMPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x516E3B0", Offset = "0x516C9B0", VA = "0x18516E3B0")]
	public static CJLKEKBECCD BDBDPGKIPMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x516EDA0", Offset = "0x516D3A0", VA = "0x18516EDA0")]
	[Preserve]
	protected HHGELGCKIKG([NALHKAIJJND(null)] GCFOBCGKOME KCDIPEJCJBE, [NALHKAIJJND(null)] HIIHACBNOPE OJMOMAFCOBG, [NALHKAIJJND(null)] APALKAPBDFJ CGKPKJDFNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x516EA50", Offset = "0x516D050", VA = "0x18516EA50", Slot = "6")]
	public CJLKEKBECCD INHJMLKPHDN(IEnumerator<NGCINEPJDAB> PJIEOIJAKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x516EA60", Offset = "0x516D060", VA = "0x18516EA60", Slot = "7")]
	public CJLKEKBECCD INHJMLKPHDN(Behaviour JHAKINLMMJL, IEnumerator<NGCINEPJDAB> PJIEOIJAKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract CJLKEKBECCD OHNEBEKGJBH(GIEJKNDPIIN JHAKINLMMJL, IEnumerator<NGCINEPJDAB> PJIEOIJAKFL);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x516DF90", Offset = "0x516C590", VA = "0x18516DF90", Slot = "13")]
	public virtual void BCFKLBADKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x516ECB0", Offset = "0x516D2B0", VA = "0x18516ECB0", Slot = "9")]
	public void OCDKAJABPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1AF6530", Offset = "0x1AF4B30", VA = "0x181AF6530", Slot = "14")]
	protected virtual void BNCEMHGMHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x516ED30", Offset = "0x516D330", VA = "0x18516ED30")]
	private void PIOMFCGIIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x516EA30", Offset = "0x516D030", VA = "0x18516EA30")]
	private void ILPDPBIMPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x516EC90", Offset = "0x516D290", VA = "0x18516EC90")]
	private void OBHHBEMGIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x516E650", Offset = "0x516CC50", VA = "0x18516E650")]
	private void DDALLDJNAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x516EA10", Offset = "0x516D010", VA = "0x18516EA10")]
	private void HKGJJOHICBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x516ED10", Offset = "0x516D310", VA = "0x18516ED10")]
	private void OGJKPBJJLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x516E9F0", Offset = "0x516CFF0", VA = "0x18516E9F0")]
	private void GODMFFFHFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x516E170", Offset = "0x516C770", VA = "0x18516E170", Slot = "15")]
	public virtual void BCKNHGPIODO(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x516E480", Offset = "0x516CA80", VA = "0x18516E480")]
	private void CLKMBHKKEFB(DBJAHPEJENP AGPDPKDKHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x516E440", Offset = "0x516CA40", VA = "0x18516E440")]
	private DBJAHPEJENP BJFADOBEKED(PIDFMOOOHBA.JFIAFIOIOLN LFBJHCMDIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract BKHDKIBKNJG KNLKGJMNKJD(IEnumerator<NGCINEPJDAB> PJIEOIJAKFL, Behaviour HDCKPNAJBJH, LJABLJPKCKN ADOIBAIHPCA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract DBJAHPEJENP KHOBCCOHFCE(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x516E670", Offset = "0x516CC70", VA = "0x18516E670", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class HHLOCEMMFNM : HHGELGCKIKG, KJBDCMOEPPK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private KNOALKMCKPH[] OOEFMIGMJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JFANMNMNLHA HIGFELLCMJA;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x516F150", Offset = "0x516D750", VA = "0x18516F150")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x516FC50", Offset = "0x516E250", VA = "0x18516FC50")]
	[Preserve]
	public HHLOCEMMFNM([NALHKAIJJND(null)] GCFOBCGKOME KCDIPEJCJBE, [NALHKAIJJND(null)] HIIHACBNOPE OJMOMAFCOBG, [NALHKAIJJND(null)] APALKAPBDFJ CGKPKJDFNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x516FAC0", Offset = "0x516E0C0", VA = "0x18516FAC0", Slot = "12")]
	public override CJLKEKBECCD OHNEBEKGJBH(GIEJKNDPIIN JHAKINLMMJL, IEnumerator<NGCINEPJDAB> PJIEOIJAKFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x516F1C0", Offset = "0x516D7C0", VA = "0x18516F1C0", Slot = "13")]
	public override void BCFKLBADKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x516F4A0", Offset = "0x516DAA0", VA = "0x18516F4A0", Slot = "15")]
	public override void BCKNHGPIODO(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x516F670", Offset = "0x516DC70", VA = "0x18516F670", Slot = "14")]
	protected override void BNCEMHGMHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x516FC10", Offset = "0x516E210", VA = "0x18516FC10")]
	private KNOALKMCKPH OLMOGBLCGBA(PIDFMOOOHBA.JFIAFIOIOLN LFBJHCMDIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x516F950", Offset = "0x516DF50", VA = "0x18516F950", Slot = "16")]
	internal override BKHDKIBKNJG KNLKGJMNKJD(IEnumerator<NGCINEPJDAB> PJIEOIJAKFL, Behaviour JHAKINLMMJL, LJABLJPKCKN GBMBJBEJAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x516F8E0", Offset = "0x516DEE0", VA = "0x18516F8E0", Slot = "17")]
	internal override DBJAHPEJENP KHOBCCOHFCE(PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x516F750", Offset = "0x516DD50", VA = "0x18516F750")]
	private void CEGEBAEGNLJ(KNOALKMCKPH AGPDPKDKHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x516F870", Offset = "0x516DE70", VA = "0x18516F870", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class EIGPNDFEBDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class GGKFBLGHJBL : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public PIDFMOOOHBA.JFIAFIOIOLN queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public GGKFBLGHJBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x516BBE0", Offset = "0x516A1E0", VA = "0x18516BBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x516BC90", Offset = "0x516A290", VA = "0x18516BC90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5169950", Offset = "0x5167F50", VA = "0x185169950")]
	[IteratorStateMachine(typeof(GGKFBLGHJBL))]
	private static IEnumerator<NGCINEPJDAB> GHOBGCCILPN(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, Func<bool> JDNFFFIDLDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5169840", Offset = "0x5167E40", VA = "0x185169840")]
	public static CJLKEKBECCD BLOABGBABHE(this MonoBehaviour HDCKPNAJBJH, Func<bool> JDNFFFIDLDI, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD = PIDFMOOOHBA.JFIAFIOIOLN.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class BKHDKIBKNJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly LJABLJPKCKN GBMBJBEJAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly DBICGKNCKAP JHAKINLMMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool MGDJNCPMOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private string HNPIEGONNBC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEnumerator<NGCINEPJDAB> CFMKLFOFFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public NGCINEPJDAB MLDOBGMFCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HPOKNPJJJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5160FB0", Offset = "0x515F5B0", VA = "0x185160FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool AAFBAIFMGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xAC35A0", Offset = "0xAC1BA0", VA = "0x180AC35A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xD343E0", Offset = "0xD329E0", VA = "0x180D343E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5160B20", Offset = "0x515F120", VA = "0x185160B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float CJMECMOBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xBF9130", Offset = "0xBF7730", VA = "0x180BF9130")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x123E590", Offset = "0x123CB90", VA = "0x18123E590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5161190", Offset = "0x515F790", VA = "0x185161190")]
	public BKHDKIBKNJG(IEnumerator<NGCINEPJDAB> MCJHNELIFNJ, DBICGKNCKAP JHAKINLMMJL, LJABLJPKCKN GBMBJBEJAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5160D20", Offset = "0x515F320", VA = "0x185160D20")]
	public NGCINEPJDAB MGCEEDLKKCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5161030", Offset = "0x515F630", VA = "0x185161030")]
	public bool OCABCJNGHPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5160CA0", Offset = "0x515F2A0", VA = "0x185160CA0")]
	public void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51610B0", Offset = "0x515F6B0", VA = "0x1851610B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x105C420", Offset = "0x105AA20", VA = "0x18105C420")]
	[CompilerGenerated]
	private void LEOGGBMFPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KGKLHFDEEOC
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class DENKOJDJFJA : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IGDIAAILAGJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public PIDFMOOOHBA.JFIAFIOIOLN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public DENKOJDJFJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5168B60", Offset = "0x5167160", VA = "0x185168B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5168C00", Offset = "0x5167200", VA = "0x185168C00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5171D10", Offset = "0x5170310", VA = "0x185171D10")]
	public static CJLKEKBECCD HKFKBCADFDD(float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5171E10", Offset = "0x5170410", VA = "0x185171E10")]
	public static CJLKEKBECCD HKFKBCADFDD(MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5171BF0", Offset = "0x51701F0", VA = "0x185171BF0")]
	public static CJLKEKBECCD HFLFKBCCFOJ(MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5171980", Offset = "0x516FF80", VA = "0x185171980")]
	public static CJLKEKBECCD ANHOJKOCIBG(GIEJKNDPIIN JHAKINLMMJL, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5171B40", Offset = "0x5170140", VA = "0x185171B40")]
	private static IEnumerator<NGCINEPJDAB> FNLKLMOEOBF(HIIHACBNOPE OJMOMAFCOBG, float IDEKFHOIGPH, PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5171F20", Offset = "0x5170520", VA = "0x185171F20")]
	private static IEnumerator<NGCINEPJDAB> MNGNOFCOHAM(HIIHACBNOPE OJMOMAFCOBG, float IDEKFHOIGPH, PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5171A90", Offset = "0x5170090", VA = "0x185171A90")]
	[IteratorStateMachine(typeof(DENKOJDJFJA))]
	private static IEnumerator<NGCINEPJDAB> CLGCOACMOKA(IGDIAAILAGJ OHOFDPILLOH, float IDEKFHOIGPH, PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action<float> OBDGKOOMMEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DHMNPAHLFJK
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool ELBHONIOLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BDDDHGICLIM;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IOGPKCOBMLJ(bool PNPIPMIPGBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IOGPKCOBMLJ(Action INJMGBDPOBO, bool PNPIPMIPGBD = false);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class HBLHPAKLANP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly HBLHPAKLANP JKPLIBNKDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Action KLNANHLGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool EAOOMFEELLL;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x17AA8A0", Offset = "0x17A8EA0", VA = "0x1817AA8A0")]
	public HBLHPAKLANP(Action KLNANHLGAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x516BFF0", Offset = "0x516A5F0", VA = "0x18516BFF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DNEOCAOOOMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JNAOLJOAHLF(UnityEngine.Object JHAKINLMMJL, Action<T> AHJFMKBNKFK);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface CHKHKCDNFPK<T> : DNEOCAOOOMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class KIKGAEBOKFJ<T> : CHKHKCDNFPK<T>, DNEOCAOOOMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class DIIMFLGAHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public KIKGAEBOKFJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public GDLIAFLNCEG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public DIIMFLGAHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2F1AF00", Offset = "0x2F19500", VA = "0x182F1AF00")]
		internal void DPPAOJHOGAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject JLLDMFJJOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<GDLIAFLNCEG<UnityEngine.Object, Action<T>>> KFGCNJGJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T GBIEDBFLHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xF7BB70", Offset = "0xF7A170", VA = "0x180F7BB70", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x261BF30", Offset = "0x261A530", VA = "0x18261BF30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x261C2F0", Offset = "0x261A8F0", VA = "0x18261C2F0")]
	private static bool MNIPDKNOEDN(T LLAFGJINMOA, T LKIHFBEPDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x261C460", Offset = "0x261AA60", VA = "0x18261C460")]
	public KIKGAEBOKFJ(T KIHBOBGKKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x261C010", Offset = "0x261A610", VA = "0x18261C010", Slot = "6")]
	public IDisposable JNAOLJOAHLF(UnityEngine.Object JHAKINLMMJL, Action<T> AHJFMKBNKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x261BBC0", Offset = "0x261A1C0", VA = "0x18261BBC0")]
	private void CNFHPOMABNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal interface JFANMNMNLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOBJDKBMNPH(string HNPIEGONNBC);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECCEOBFKHPH();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal class DJMKFOIDBFK : JFANMNMNLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "4")]
	public void FOBJDKBMNPH(string HNPIEGONNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
	public void ECCEOBFKHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public DJMKFOIDBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NOGOILOGIIO : DANNPEHEEBA
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class DFEPPFFCFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public NOGOILOGIIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public DFEPPFFCFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x51690C0", Offset = "0x51676C0", VA = "0x1851690C0")]
		internal void DEFBJONBCJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LPABNPJMMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NOGOILOGIIO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LPABNPJMMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x51690C0", Offset = "0x51676C0", VA = "0x1851690C0")]
		internal void DAOMOMOJOAC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly float KFLCMNPEHDH;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5179650", Offset = "0x5177C50", VA = "0x185179650")]
	public NOGOILOGIIO(Behaviour JHAKINLMMJL, float KFLCMNPEHDH, [Optional] Action EBIPALFCGLD, [Optional] KJBDCMOEPPK PCEPCKIAOGH, [Optional] HIIHACBNOPE OJMOMAFCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5179550", Offset = "0x5177B50", VA = "0x185179550", Slot = "9")]
	protected override bool GFELLNBJLOI(Action INJMGBDPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5179450", Offset = "0x5177A50", VA = "0x185179450", Slot = "10")]
	protected override bool BCCMFDPIAHE(Action INJMGBDPOBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class MPENFPNNAIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PFBLPEMAMKL : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Action requeueAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public MPENFPNNAIL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public PFBLPEMAMKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x517A370", Offset = "0x5178970", VA = "0x18517A370", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x517A410", Offset = "0x5178A10", VA = "0x18517A410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private CJLKEKBECCD CGJNLANLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private GIEJKNDPIIN JHAKINLMMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private Action<float> OIGBFNKDDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float NNHCKLPANAH;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5178BC0", Offset = "0x51771C0", VA = "0x185178BC0")]
	public MPENFPNNAIL(GIEJKNDPIIN JHAKINLMMJL, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x51785E0", Offset = "0x5176BE0", VA = "0x1851785E0")]
	private void DCCPDEBHECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x51787F0", Offset = "0x5176DF0", VA = "0x1851787F0")]
	private void OLKMALLOOFH(string KAEDNDEPIBA, Action JEMFKFGEFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5178B30", Offset = "0x5177130", VA = "0x185178B30")]
	[IteratorStateMachine(typeof(PFBLPEMAMKL))]
	private IEnumerator<NGCINEPJDAB> POLHDKMPOEC(Action JEMFKFGEFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5178790", Offset = "0x5176D90", VA = "0x185178790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5178970", Offset = "0x5176F70", VA = "0x185178970")]
	[CompilerGenerated]
	private void PBGHGOPBEHF(string OHPJJHOMFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class KNOALKMCKPH
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct MAHOOHHAKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public DHLGMNFNGEJ MPOJKLHFMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GIEJKNDPIIN EOBKJJPNIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public LJABLJPKCKN EBNDDMPLOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public IEnumerator<NGCINEPJDAB> CFMKLFOFFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NGCINEPJDAB MLDOBGMFCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public IFGLLBCILPH NNNJIENAONE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NENCMFNCPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PIDFMOOOHBA.JFIAFIOIOLN LJHKFBJJNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public List<MAHOOHHAKLC> AKOPGPDIMMO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FBMOFLMBOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public LJABLJPKCKN promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public KNOALKMCKPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public GIEJKNDPIIN context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public DHLGMNFNGEJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public IFGLLBCILPH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NGCINEPJDAB currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public IEnumerator<NGCINEPJDAB> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public FBMOFLMBOHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5169A70", Offset = "0x5168070", VA = "0x185169A70")]
		internal void LGMBBBCHBPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BOHNKMEMJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public DHLGMNFNGEJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public KNOALKMCKPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public BOHNKMEMJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x51626C0", Offset = "0x5160CC0", VA = "0x1851626C0")]
		internal void PNAJIOLDKDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PLJNHGGFLNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public DHLGMNFNGEJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public KNOALKMCKPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public PLJNHGGFLNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x517A640", Offset = "0x5178C40", VA = "0x18517A640")]
		internal void PBJAFCEKHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class EOFLHGEHKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public DHLGMNFNGEJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public KNOALKMCKPH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public EOFLHGEHKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5169A30", Offset = "0x5168030", VA = "0x185169A30")]
		internal void MNMEOHBKEMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private const IFGLLBCILPH PCNIIJOEPPM = IFGLLBCILPH.Cancelled | IFGLLBCILPH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool[] NHOBEGGNGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private NativeArray<IFGLLBCILPH> EDBNHEABPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private NativeArray<float> JKPPLAEGJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private NativeArray<int> MELGCLHOMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private NativeArray<int> JNBILFNJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private NativeArray<int> KALMPLDKNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private NativeArray<int> HLMGOJCEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private NativeArray<int> HAFKPJMIPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private DHLGMNFNGEJ[] EIAPIAKINGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private LJABLJPKCKN[] OEEDBPPONHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private GIEJKNDPIIN[] MNPJLJPABEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IEnumerator<NGCINEPJDAB>[] JDANJKFIOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private NGCINEPJDAB[] KCPGGONOFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int DJKDDJHKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int IOKNIDFIOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly int HMICDBABIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float GMBKADHJJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private JOJGFDFOKNF JPEGEIFKMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private JobHandle IJJALGFFADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private List<DHLGMNFNGEJ> BBNKLEMIJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private bool BGHPLAKAKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private List<Action> IFOMOFGMHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<Action> MEKHAKIAHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool GEALAGLMBAH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NENCMFNCPEO[] OJMPICDEDOE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1018F80", Offset = "0x1017580", VA = "0x181018F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5174A30", Offset = "0x5173030", VA = "0x185174A30")]
	private static int NKHFBLHHOJB(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5174B90", Offset = "0x5173190", VA = "0x185174B90")]
	public KNOALKMCKPH(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5174570", Offset = "0x5172B70", VA = "0x185174570")]
	private void MGICFGHCOPM(ref int EJIEIALLODM, int BGODJEBBIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x51742C0", Offset = "0x51728C0", VA = "0x1851742C0")]
	public void INHAOHIABJG(GIEJKNDPIIN JHAKINLMMJL, NGCINEPJDAB NAHFPGKBAGH, IEnumerator<NGCINEPJDAB> MCJHNELIFNJ, LJABLJPKCKN GBMBJBEJAAE, [Optional] DHLGMNFNGEJ HBAOPCPDBKJ, IFGLLBCILPH LGOANIGDEEJ = IFGLLBCILPH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x51730E0", Offset = "0x51716E0", VA = "0x1851730E0")]
	public void CJIDPAHKBHA(IEnumerable<MAHOOHHAKLC> DDCDAKPDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5172B80", Offset = "0x5171180", VA = "0x185172B80")]
	private MAHOOHHAKLC CJFBOEAEIGD(int GMBPOMBJEBF)
	{
		return default(MAHOOHHAKLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x51734A0", Offset = "0x5171AA0", VA = "0x1851734A0")]
	private void FFNKAAHNAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x388A380", Offset = "0x3888980", VA = "0x18388A380")]
	private static void AJJNBDFFFFN<T>(int GMBPOMBJEBF, T[] IFLFLAJCAML, int BMEHIBKNEIE, [Optional] T HEPCHNIJMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x388A360", Offset = "0x3888960", VA = "0x18388A360")]
	private static void AJJNBDFFFFN<T>(int GMBPOMBJEBF, NativeArray<T> IFLFLAJCAML, int BMEHIBKNEIE, [Optional] T HEPCHNIJMNE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5174760", Offset = "0x5172D60", VA = "0x185174760")]
	private void NAGPANKPGHO(IEnumerable<MAHOOHHAKLC> DDCDAKPDFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x51727F0", Offset = "0x5170DF0", VA = "0x1851727F0")]
	private void ADOGKPGPAMJ(MAHOOHHAKLC EMNIHLMELIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x51728C0", Offset = "0x5170EC0", VA = "0x1851728C0")]
	private KNIHKKDLAHC AIBCLADMIHM(int HBHDPPHELHO)
	{
		return default(KNIHKKDLAHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x51732C0", Offset = "0x51718C0", VA = "0x1851732C0")]
	public void DBIHDIBMACM(float JAJIOMNNJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5173850", Offset = "0x5171E50", VA = "0x185173850")]
	private void GEALDKOAOJD(Action LLAFGJINMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x51738D0", Offset = "0x5171ED0", VA = "0x1851738D0")]
	private void GLIIOANKLPB(Action LLAFGJINMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5173950", Offset = "0x5171F50", VA = "0x185173950")]
	public void GLPKLNGPBOI(float JAJIOMNNJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x51741C0", Offset = "0x51727C0", VA = "0x1851741C0")]
	public void IBHEPNJODHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5174090", Offset = "0x5172690", VA = "0x185174090")]
	public void HEJEPKMNJEJ(DHLGMNFNGEJ OHOFDPILLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5174440", Offset = "0x5172A40", VA = "0x185174440")]
	public void LJHLCMHAPJO(DHLGMNFNGEJ OHOFDPILLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5174A60", Offset = "0x5173060", VA = "0x185174A60")]
	public void PEBHNBPIHHA(DHLGMNFNGEJ OHOFDPILLOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class FPGMGMDFKAN : DHMNPAHLFJK, IEnumerable<DHMNPAHLFJK>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly List<DHMNPAHLFJK> CLAGBFMOBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private bool HDGCOHMHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Action EBIPALFCGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool LGIFIHBBMBI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ELBHONIOLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x516ABB0", Offset = "0x51691B0", VA = "0x18516ABB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BDDDHGICLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x516B270", Offset = "0x5169870", VA = "0x18516B270", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x516B1D0", Offset = "0x51697D0", VA = "0x18516B1D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x516B4B0", Offset = "0x5169AB0", VA = "0x18516B4B0")]
	public FPGMGMDFKAN([Optional] Action EBIPALFCGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x516B310", Offset = "0x5169910", VA = "0x18516B310")]
	public void PEECNHFNIGK(DHMNPAHLFJK NCOOEHLKPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x516ACF0", Offset = "0x51692F0", VA = "0x18516ACF0")]
	private void EEIHKAOEJFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x516AED0", Offset = "0x51694D0", VA = "0x18516AED0", Slot = "7")]
	public bool IOGPKCOBMLJ(bool PNPIPMIPGBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x516AEF0", Offset = "0x51694F0", VA = "0x18516AEF0", Slot = "8")]
	public bool IOGPKCOBMLJ(Action INJMGBDPOBO, bool PNPIPMIPGBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x516AE50", Offset = "0x5169450", VA = "0x18516AE50", Slot = "9")]
	public IEnumerator<DHMNPAHLFJK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x516B430", Offset = "0x5169A30", VA = "0x18516B430", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class DANNPEHEEBA : DHMNPAHLFJK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CKKEDGAJMNE : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public DANNPEHEEBA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public CKKEDGAJMNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5162CE0", Offset = "0x51612E0", VA = "0x185162CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5162DB0", Offset = "0x51613B0", VA = "0x185162DB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly Behaviour JHAKINLMMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Action EBIPALFCGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private LABEIOOIHEC KIDKCIJCDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly KJBDCMOEPPK PCEPCKIAOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	protected readonly HIIHACBNOPE OJMOMAFCOBG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ELBHONIOLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA95E00", Offset = "0xA94400", VA = "0x180A95E00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BDDDHGICLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5167020", Offset = "0x5165620", VA = "0x185167020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5166D40", Offset = "0x5165340", VA = "0x185166D40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x51670C0", Offset = "0x51656C0", VA = "0x1851670C0")]
	protected DANNPEHEEBA(Behaviour JHAKINLMMJL, [Optional] Action EBIPALFCGLD, [Optional] KJBDCMOEPPK PCEPCKIAOGH, [Optional] HIIHACBNOPE OJMOMAFCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5166C60", Offset = "0x5165260", VA = "0x185166C60", Slot = "7")]
	public bool IOGPKCOBMLJ(bool PNPIPMIPGBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5166C10", Offset = "0x5165210", VA = "0x185166C10", Slot = "8")]
	public bool IOGPKCOBMLJ(Action INJMGBDPOBO, bool PNPIPMIPGBD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GFELLNBJLOI(Action INJMGBDPOBO);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BCCMFDPIAHE(Action INJMGBDPOBO);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5166B70", Offset = "0x5165170", VA = "0x185166B70")]
	protected void AMCFDCHCKPB(Action INJMGBDPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5166E20", Offset = "0x5165420", VA = "0x185166E20")]
	protected ADCACBFKFKM MHAOCEMLOLI(float CHDMFHKBCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5166CC0", Offset = "0x51652C0", VA = "0x185166CC0")]
	private void JNAPLJKIAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5166B90", Offset = "0x5165190", VA = "0x185166B90")]
	[IteratorStateMachine(typeof(CKKEDGAJMNE))]
	private IEnumerator<NGCINEPJDAB> DFAJEPJHBEC(float CHDMFHKBCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5166DE0", Offset = "0x51653E0", VA = "0x185166DE0")]
	[CompilerGenerated]
	private void KMLIIINILCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Flags]
internal enum IFGLLBCILPH : byte
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
internal class DHLGMNFNGEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public KNOALKMCKPH OOLJODLECLJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int IKGMLJIBDML
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x954A40", Offset = "0x953040", VA = "0x180954A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x51693A0", Offset = "0x51679A0", VA = "0x1851693A0")]
	public static NGCINEPJDAB MGCEEDLKKCJ(IEnumerator<NGCINEPJDAB> MCJHNELIFNJ, LJABLJPKCKN GBMBJBEJAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5169550", Offset = "0x5167B50", VA = "0x185169550")]
	public NGCINEPJDAB MGCEEDLKKCJ(LJABLJPKCKN[] OEEDBPPONHD, IEnumerator<NGCINEPJDAB>[] HCHAJKAPPJL, NGCINEPJDAB[] CHGMONOBGDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5169370", Offset = "0x5167970", VA = "0x185169370")]
	public void LAIGHDNKIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5169230", Offset = "0x5167830", VA = "0x185169230")]
	public void FDEGAFEFINM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x51690F0", Offset = "0x51676F0", VA = "0x1851690F0")]
	public void BIJGJPLCHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5169370", Offset = "0x5167970", VA = "0x185169370")]
	public void HEJEPKMNJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public DHLGMNFNGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PGJNCEIJPLI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FFPLEBIIKIM : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public PGJNCEIJPLI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public FFPLEBIIKIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x516A270", Offset = "0x5168870", VA = "0x18516A270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x516A350", Offset = "0x5168950", VA = "0x18516A350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Action FIPLCGAPAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool IDAIBAKLEBP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x944DD0", Offset = "0x9433D0", VA = "0x180944DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x517A540", Offset = "0x5178B40", VA = "0x18517A540")]
	public PGJNCEIJPLI(PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x517A450", Offset = "0x5178A50", VA = "0x18517A450")]
	[IteratorStateMachine(typeof(FFPLEBIIKIM))]
	private IEnumerator<NGCINEPJDAB> FEBDLEONBNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x517A4C0", Offset = "0x5178AC0", VA = "0x18517A4C0", Slot = "4")]
	public void OnCompleted(Action HLDAFHMDKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public void ALBOHFGOEHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class AHFMBENJOEH
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x515FD90", Offset = "0x515E390", VA = "0x18515FD90")]
	public static PGJNCEIJPLI AHOLKDCPEHF(this PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class HPOLOAHMDIL : PHCPDFDAHLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly KJBDCMOEPPK PCEPCKIAOGH;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x516FE40", Offset = "0x516E440", VA = "0x18516FE40")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	private static void ACDBAIMHKIG(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	[Preserve]
	internal HPOLOAHMDIL([NALHKAIJJND(null)] KJBDCMOEPPK PCEPCKIAOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x516FEB0", Offset = "0x516E4B0", VA = "0x18516FEB0", Slot = "4")]
	public IDisposable GPIBNOLGPJG(float IDEKFHOIGPH, Action<float> OIBMDOLHJFJ, bool DEAJNPKJIDG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum KNIHKKDLAHC : byte
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
internal sealed class DBJAHPEJENP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum FEICHLHIADJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct BPAINHLIDJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public PIDFMOOOHBA.JFIAFIOIOLN LJHKFBJJNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public FEICHLHIADJ NDMBNMFIGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public List<BKHDKIBKNJG> EPFMCFFFMJF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly FEICHLHIADJ[] LLJLEEJMGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool BLLHBAIAMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly BKHDKIBKNJG[] CCJBLHCABEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly List<BKHDKIBKNJG> KNIFBMIPBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly Stack<int> JJBHNOGMPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly List<BKHDKIBKNJG> OPAPHMGJBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Stack<int> CHFFPOJFCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly JFANMNMNLHA ODGAAMFFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private bool GEALAGLMBAH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BPAINHLIDJK[,] DDBDEOOHLNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x944010", Offset = "0x942610", VA = "0x180944010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5168690", Offset = "0x5166C90", VA = "0x185168690")]
	public DBJAHPEJENP(PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, JFANMNMNLHA ODGAAMFFFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5168460", Offset = "0x5166A60", VA = "0x185168460")]
	public void PKGHIIGGDEH(BKHDKIBKNJG MCJHNELIFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x51671C0", Offset = "0x51657C0", VA = "0x1851671C0")]
	public void AIACKAAPHMD(IList<BKHDKIBKNJG> HCHAJKAPPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5167820", Offset = "0x5165E20", VA = "0x185167820")]
	public void GICLLAIDCOE(IList<BKHDKIBKNJG> HCHAJKAPPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x51675E0", Offset = "0x5165BE0", VA = "0x1851675E0")]
	private void CICKNJCLCJO(BKHDKIBKNJG MCJHNELIFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x51682D0", Offset = "0x51668D0", VA = "0x1851682D0")]
	private void PCMAHLOCKPA(IList<BKHDKIBKNJG> HCHAJKAPPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5167AF0", Offset = "0x51660F0", VA = "0x185167AF0")]
	private KNIHKKDLAHC IKOHKGKOCKG(BKHDKIBKNJG MCJHNELIFNJ)
	{
		return default(KNIHKKDLAHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5167490", Offset = "0x5165A90", VA = "0x185167490")]
	public void BNCEMHGMHAM(float JAJIOMNNJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x51680C0", Offset = "0x51666C0", VA = "0x1851680C0")]
	public void OCDKAJABPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5167C50", Offset = "0x5166250", VA = "0x185167C50")]
	private void LMKFFBBJPEG(List<BKHDKIBKNJG> HCHAJKAPPJL, Stack<int> EMGMOANOFGN, bool OALDNNODPEC, float FPMOPGKLGKJ = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x51676E0", Offset = "0x5165CE0", VA = "0x1851676E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5167F90", Offset = "0x5166590", VA = "0x185167F90")]
	private void NEPGIFDKPGB(List<BKHDKIBKNJG> HCHAJKAPPJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class GPCNOGLMIAB : DBICGKNCKAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Behaviour HDCKPNAJBJH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x516BEE0", Offset = "0x516A4E0", VA = "0x18516BEE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AGEMAHLPNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x516BF70", Offset = "0x516A570", VA = "0x18516BF70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DMCANPNGEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x516BFD0", Offset = "0x516A5D0", VA = "0x18516BFD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x959E30", Offset = "0x958430", VA = "0x180959E30")]
	public GPCNOGLMIAB(Behaviour HDCKPNAJBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class OJMGHBIFCGG : DANNPEHEEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly float KFLCMNPEHDH;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5179650", Offset = "0x5177C50", VA = "0x185179650")]
	public OJMGHBIFCGG(Behaviour JHAKINLMMJL, float KFLCMNPEHDH, [Optional] Action EBIPALFCGLD, [Optional] KJBDCMOEPPK PCEPCKIAOGH, [Optional] HIIHACBNOPE OJMOMAFCOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "9")]
	protected override bool GFELLNBJLOI(Action INJMGBDPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x517A0F0", Offset = "0x51786F0", VA = "0x18517A0F0", Slot = "10")]
	protected override bool BCCMFDPIAHE(Action INJMGBDPOBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class HDANJHODJKM
{
	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x516C190", Offset = "0x516A790", VA = "0x18516C190")]
	public static IDisposable GBFJNIDONEO(this GIEJKNDPIIN JHAKINLMMJL, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x516C210", Offset = "0x516A810", VA = "0x18516C210")]
	public static IDisposable HHKECDIPFFC(this GIEJKNDPIIN JHAKINLMMJL, Action<float> OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x516C110", Offset = "0x516A710", VA = "0x18516C110")]
	public static IDisposable CHNDADDAPEB(this GIEJKNDPIIN JHAKINLMMJL, Action<float> OBDGKOOMMEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class JAPOILOBDKL
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class BAPCLDEHKCG : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public PIDFMOOOHBA.JFIAFIOIOLN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private AOCHCJBOAEC <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public BAPCLDEHKCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5160620", Offset = "0x515EC20", VA = "0x185160620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x51606F0", Offset = "0x515ECF0", VA = "0x1851606F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class CNFIMEAOJMC : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public PIDFMOOOHBA.JFIAFIOIOLN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private AOCHCJBOAEC <schedule>5__1;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public CNFIMEAOJMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5162DF0", Offset = "0x51613F0", VA = "0x185162DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5162EE0", Offset = "0x51614E0", VA = "0x185162EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5170C10", Offset = "0x516F210", VA = "0x185170C10")]
	public static CJLKEKBECCD HKFKBCADFDD(Action OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5170A40", Offset = "0x516F040", VA = "0x185170A40")]
	public static CJLKEKBECCD HKFKBCADFDD(Behaviour JHAKINLMMJL, Action OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5170B00", Offset = "0x516F100", VA = "0x185170B00")]
	public static CJLKEKBECCD HKFKBCADFDD(Behaviour JHAKINLMMJL, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5170940", Offset = "0x516EF40", VA = "0x185170940")]
	[IteratorStateMachine(typeof(BAPCLDEHKCG))]
	private static IEnumerator<NGCINEPJDAB> FNLKLMOEOBF(PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x51709C0", Offset = "0x516EFC0", VA = "0x1851709C0")]
	[IteratorStateMachine(typeof(CNFIMEAOJMC))]
	private static IEnumerator<NGCINEPJDAB> FNLKLMOEOBF(PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action<float> OBDGKOOMMEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class MCEKFLHNLEF
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5177BD0", Offset = "0x51761D0", VA = "0x185177BD0")]
	public static IDisposable HKFKBCADFDD(this MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5177B50", Offset = "0x5176150", VA = "0x185177B50")]
	public static IDisposable HKFKBCADFDD(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5177670", Offset = "0x5175C70", VA = "0x185177670")]
	public static IDisposable BNCEMHGMHAM(this MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5177F20", Offset = "0x5176520", VA = "0x185177F20")]
	public static IDisposable OBHHBEMGIKN(this MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x51779A0", Offset = "0x5175FA0", VA = "0x1851779A0")]
	public static IDisposable DDALLDJNAOI(this MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x51778A0", Offset = "0x5175EA0", VA = "0x1851778A0")]
	public static IDisposable CPFKGPALPBE(this MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5177920", Offset = "0x5175F20", VA = "0x185177920")]
	public static IDisposable DBPCEKCENHJ(this MonoBehaviour HDCKPNAJBJH, Action OBDGKOOMMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5177800", Offset = "0x5175E00", VA = "0x185177800")]
	public static IDisposable CBMLEPFMPJM(this MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5177E00", Offset = "0x5176400", VA = "0x185177E00")]
	public static IDisposable OAOIKKEBCCO(this MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5177AB0", Offset = "0x51760B0", VA = "0x185177AB0")]
	public static IDisposable GPIBNOLGPJG(this MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5177A20", Offset = "0x5176020", VA = "0x185177A20")]
	public static IDisposable GIDDNEGCAMH(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5177C50", Offset = "0x5176250", VA = "0x185177C50")]
	public static IDisposable KBMIBGOOKEO(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5177CE0", Offset = "0x51762E0", VA = "0x185177CE0")]
	public static IDisposable KDEKCCNJLGN(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x51775E0", Offset = "0x5175BE0", VA = "0x1851775E0")]
	public static IDisposable BLHBJBCFDII(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x51776E0", Offset = "0x5175CE0", VA = "0x1851776E0")]
	public static IDisposable BPOAGAFFOCA(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5177770", Offset = "0x5175D70", VA = "0x185177770")]
	public static IDisposable CAOAIDPKMKN(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5177D70", Offset = "0x5176370", VA = "0x185177D70")]
	public static IDisposable LDNOBEGGALM(this MonoBehaviour HDCKPNAJBJH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5177FA0", Offset = "0x51765A0", VA = "0x185177FA0")]
	public static IDisposable PPFBLDHJKCO(this MonoBehaviour HDCKPNAJBJH, float IDEKFHOIGPH, Action<float> OBDGKOOMMEA, bool DEAJNPKJIDG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal sealed class LJABLJPKCKN : LAKANFGDDAI, CJLKEKBECCD, LABEIOOIHEC, ADCACBFKFKM, IEnumerator, NGCINEPJDAB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private PIDFMOOOHBA.JFIAFIOIOLN FKNKDECAHCF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private PIDFMOOOHBA.JFIAFIOIOLN PCMILILBEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x37B96F0", Offset = "0x37B7CF0", VA = "0x1837B96F0", Slot = "23")]
		get
		{
			return default(PIDFMOOOHBA.JFIAFIOIOLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public PIDFMOOOHBA.JFIAFIOIOLN OOLJODLECLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA72750", Offset = "0xA70D50", VA = "0x180A72750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private float IHFKCOJCPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xE673D0", Offset = "0xE659D0", VA = "0x180E673D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HKANBDCEOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x51754F0", Offset = "0x5173AF0", VA = "0x1851754F0", Slot = "24")]
	private bool FDKHDEJONII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x51754E0", Offset = "0x5173AE0", VA = "0x1851754E0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5175510", Offset = "0x5173B10", VA = "0x185175510")]
	public LJABLJPKCKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal interface DBICGKNCKAP
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool AGEMAHLPNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool DMCANPNGEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class BNNGGDBPKGM
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class FHDOALFIPBB : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public PIDFMOOOHBA.JFIAFIOIOLN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public FHDOALFIPBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x516A550", Offset = "0x5168B50", VA = "0x18516A550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x516A610", Offset = "0x5168C10", VA = "0x18516A610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JNGINDJIGAP : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private NGCINEPJDAB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public PIDFMOOOHBA.JFIAFIOIOLN queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private NGCINEPJDAB <wait>5__1;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
		[DebuggerHidden]
		public JNGINDJIGAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5171270", Offset = "0x516F870", VA = "0x185171270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5171350", Offset = "0x516F950", VA = "0x185171350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5161F00", Offset = "0x5160500", VA = "0x185161F00")]
	[IteratorStateMachine(typeof(FHDOALFIPBB))]
	private static IEnumerator<NGCINEPJDAB> FEBDLEONBNG(float HCHPBOOIDPB, PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5161D80", Offset = "0x5160380", VA = "0x185161D80")]
	[IteratorStateMachine(typeof(JNGINDJIGAP))]
	private static IEnumerator<NGCINEPJDAB> AEGPJADBPMP(float HCHPBOOIDPB, PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x51622D0", Offset = "0x51608D0", VA = "0x1851622D0")]
	public static IDisposable KBMOPFFMBJF(this MonoBehaviour HDCKPNAJBJH, float HCHPBOOIDPB, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5161CC0", Offset = "0x51602C0", VA = "0x185161CC0")]
	public static CJLKEKBECCD AANJEJAPPKN(this MonoBehaviour HDCKPNAJBJH, float HCHPBOOIDPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x51623F0", Offset = "0x51609F0", VA = "0x1851623F0")]
	public static CJLKEKBECCD KBMOPFFMBJF(this MonoBehaviour HDCKPNAJBJH, float HCHPBOOIDPB, PIDFMOOOHBA.JFIAFIOIOLN EONKNHAALPO, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5161E10", Offset = "0x5160410", VA = "0x185161E10")]
	public static CJLKEKBECCD DBHJPNDBDED(this MonoBehaviour HDCKPNAJBJH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5162190", Offset = "0x5160790", VA = "0x185162190")]
	public static CJLKEKBECCD HBAOBFLPDLJ(this MonoBehaviour HDCKPNAJBJH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x51621F0", Offset = "0x51607F0", VA = "0x1851621F0")]
	public static CJLKEKBECCD JCPGNGHAGDK(this MonoBehaviour HDCKPNAJBJH, Action NPLMCEHNFJK, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5162160", Offset = "0x5160760", VA = "0x185162160")]
	public static CJLKEKBECCD GLLDKGFPKMJ(this MonoBehaviour HDCKPNAJBJH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5162130", Offset = "0x5160730", VA = "0x185162130")]
	public static CJLKEKBECCD GKOBEMIMNNK(this MonoBehaviour HDCKPNAJBJH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x51621C0", Offset = "0x51607C0", VA = "0x1851621C0")]
	public static CJLKEKBECCD IKLDBNMDLIE(this MonoBehaviour HDCKPNAJBJH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5161F90", Offset = "0x5160590", VA = "0x185161F90")]
	private static CJLKEKBECCD FICLENMBEMP(MonoBehaviour HDCKPNAJBJH, PIDFMOOOHBA.JFIAFIOIOLN IDKDPCIDFLD, Action NPLMCEHNFJK, [Optional] KJBDCMOEPPK PCEPCKIAOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5161E30", Offset = "0x5160430", VA = "0x185161E30")]
	public static CJLKEKBECCD DGNHMNGPHPH(this MonoBehaviour HDCKPNAJBJH, float EJOHPJKLIKH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5162520", Offset = "0x5160B20", VA = "0x185162520")]
	public static CJLKEKBECCD KJDCHGEDAFB(this MonoBehaviour HDCKPNAJBJH, float EJOHPJKLIKH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5162060", Offset = "0x5160660", VA = "0x185162060")]
	public static CJLKEKBECCD GIAGHIANINF(this MonoBehaviour HDCKPNAJBJH, float EJOHPJKLIKH, Action NPLMCEHNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x51625F0", Offset = "0x5160BF0", VA = "0x1851625F0")]
	public static CJLKEKBECCD PHOLPGBFNOD(this MonoBehaviour HDCKPNAJBJH, float EJOHPJKLIKH, Action NPLMCEHNFJK)
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

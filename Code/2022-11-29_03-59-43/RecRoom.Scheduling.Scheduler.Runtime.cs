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
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MHNGKFLBHPH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority HFGLFNACJBM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5336E80", Offset = "0x5335A80", VA = "0x185336E80")]
	public MHNGKFLBHPH(ThreadPriority BHOEIGICFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5336E70", Offset = "0x5335A70", VA = "0x185336E70", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> GNGDDGPANJB(List<PlayerLoopSystem> PCMOOAJDLNB, int ECANFOAMNBD);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct IJPHGAHBDOM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct KPHBLEAGDFH
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DEFJOCBMFPI FMIIJKDCPAP;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5335F10", Offset = "0x5334B10", VA = "0x185335F10")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct KGELACGJJAP
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DEFJOCBMFPI CACGAHDKIEE;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5335D30", Offset = "0x5334930", VA = "0x185335D30")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct GLACCGLKFEP
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DEFJOCBMFPI GACCGONGCHP;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x532D5A0", Offset = "0x532C1A0", VA = "0x18532D5A0")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LDBIDEIMHKD
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DEFJOCBMFPI MKKEGAFHOEP;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static DEFJOCBMFPI BMHNEHPNANP;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static DEFJOCBMFPI LJMCHPPANHP;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DEFJOCBMFPI JCKBKBCANOP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5336280", Offset = "0x5334E80", VA = "0x185336280")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct NLKGNCALFAE
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static DEFJOCBMFPI DPBOEFLPCCI;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5337E60", Offset = "0x5336A60", VA = "0x185337E60")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct NFCHIMAKADF
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static DEFJOCBMFPI MKKEGAFHOEP;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static DEFJOCBMFPI BMHNEHPNANP;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static DEFJOCBMFPI LJMCHPPANHP;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static DEFJOCBMFPI JCKBKBCANOP;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5337BD0", Offset = "0x53367D0", VA = "0x185337BD0")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct CBHINAONCIK
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static DEFJOCBMFPI MJMMFABHMBI;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5324330", Offset = "0x5322F30", VA = "0x185324330")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct EPDPCAENHBM
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static DEFJOCBMFPI CFMAOEOKKHA;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x532B520", Offset = "0x532A120", VA = "0x18532B520")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct CGCPOPCIHLF
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static DEFJOCBMFPI CBLIJEJAAMK;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5324510", Offset = "0x5323110", VA = "0x185324510")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct BCLCHBEDAEF
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static DEFJOCBMFPI JEFNHGNLOFA;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5323630", Offset = "0x5322230", VA = "0x185323630")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BPHPHDILPBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static DEFJOCBMFPI ACBNFOMEEBM;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5324150", Offset = "0x5322D50", VA = "0x185324150")]
				public static PlayerLoopSystem GBLEJJJONCA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct CPMJNNECHDD
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class PBAFLLPMOCB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public EBLLHHNBFCC.PPCOFMFHCKJ key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
					public PBAFLLPMOCB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x533A300", Offset = "0x5338F00", VA = "0x18533A300")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable GKKIDIIPMEJ;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x53249B0", Offset = "0x53235B0", VA = "0x1853249B0")]
				public static PlayerLoopSystem OKHCPKFLCCH(EBLLHHNBFCC.PPCOFMFHCKJ BIMCDHOFDCP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct PAOLEICFGFN
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class GNJJGPGOCDE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public EBLLHHNBFCC.PPCOFMFHCKJ key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
					public GNJJGPGOCDE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x532D840", Offset = "0x532C440", VA = "0x18532D840")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x533A1D0", Offset = "0x5338DD0", VA = "0x18533A1D0")]
				public static PlayerLoopSystem OKHCPKFLCCH(EBLLHHNBFCC.PPCOFMFHCKJ BIMCDHOFDCP)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class BFBMAIKFDEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public BFBMAIKFDEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5323810", Offset = "0x5322410", VA = "0x185323810")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool APLGFOPNLHB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool CEAHCLJODNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5324D10", Offset = "0x5323910", VA = "0x185324D10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5324E80", Offset = "0x5323A80", VA = "0x185324E80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5324EC0", Offset = "0x5323AC0", VA = "0x185324EC0")]
		private static void HIFBBOPOIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5327090", Offset = "0x5325C90", VA = "0x185327090")]
		private static void IGODEHBPAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5326D60", Offset = "0x5325960", VA = "0x185326D60")]
		private static void HNBJPHBKBJO(string GIPFCAFIOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5324AE0", Offset = "0x53236E0", VA = "0x185324AE0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5327960", Offset = "0x5326560", VA = "0x185327960")]
		private static void KHNJDAFBJFD(EBLLHHNBFCC.PPCOFMFHCKJ BIMCDHOFDCP, ref PlayerLoopSystem GODGDLHJJPD, Type LEEGHOAFOHP, Type LHNOIPBBOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5327B20", Offset = "0x5326720", VA = "0x185327B20")]
		private static void OGKPAJPOMFM(ref PlayerLoopSystem GODGDLHJJPD, Type LEEGHOAFOHP, Type LHNOIPBBOOK, GNGDDGPANJB PAIGEGHGIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5324D50", Offset = "0x5323950", VA = "0x185324D50")]
		private static void CJAAALOIJJO(ref PlayerLoopSystem GODGDLHJJPD, Type LEEGHOAFOHP, Type LHNOIPBBOOK, PlayerLoopSystem? APCOHEFMDLF, PlayerLoopSystem? HFFLOLHAIPD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class EBLLHHNBFCC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum PPCOFMFHCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class JPOFOGFEIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly PPCOFMFHCKJ ODMLFECCAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly EANGANCLODE MAMPJCENMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long JFMAOBFPHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long DIIAALKMPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long JGODOAONLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int OADLLMHBCKO;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5334D00", Offset = "0x5333900", VA = "0x185334D00")]
		public JPOFOGFEIJN(PPCOFMFHCKJ GIMIOFODJHN, int CHLKAAMBGIC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5334C30", Offset = "0x5333830", VA = "0x185334C30")]
		public void JHPGHNGHPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5334CA0", Offset = "0x53338A0", VA = "0x185334CA0")]
		public void NHNIJMHGNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5334A30", Offset = "0x5333630", VA = "0x185334A30")]
		public void EBKCKEICDOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static PPCOFMFHCKJ[] GCOAIEAMCBN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static JPOFOGFEIJN[] GPLCFBKELNI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x532A890", Offset = "0x5329490", VA = "0x18532A890")]
	public static JPOFOGFEIJN CEHHMEIFMHI(PPCOFMFHCKJ BIMCDHOFDCP, int CHLKAAMBGIC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x532AB10", Offset = "0x5329710", VA = "0x18532AB10")]
	public static JPOFOGFEIJN JAAMKEGNEPG(PPCOFMFHCKJ BIMCDHOFDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x532AA60", Offset = "0x5329660", VA = "0x18532AA60")]
	public static void EFJDGOLIFKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class EANGANCLODE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int HOKCNBHCHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> KOFJCOPEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double HKPINKIDAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double MFHJKPMAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double POELIPHPFHJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double EKBPBPMHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x532A300", Offset = "0x5328F00", VA = "0x18532A300", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x532A360", Offset = "0x5328F60", VA = "0x18532A360")]
	public EANGANCLODE(int MOCEKIMCEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x532A160", Offset = "0x5328D60", VA = "0x18532A160", Slot = "4")]
	public void BOGIPIDACAM(double FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x532A290", Offset = "0x5328E90", VA = "0x18532A290", Slot = "5")]
	public void FBGINNLGAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DEPHEGCJIOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long CGKKILDEEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double NAJLDNGAFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double NIOPDFDGPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double OALABBELKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double FENLGEKFIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double HKPINKIDAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double MFHJKPMAGKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PFBHMKAFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x36578E0", Offset = "0x36564E0", VA = "0x1836578E0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double BCAEAPDLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xABE400", Offset = "0xABD000", VA = "0x180ABE400", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double NPAKKKPBMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x325BFB0", Offset = "0x325ABB0", VA = "0x18325BFB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EKBPBPMHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3657810", Offset = "0x3656410", VA = "0x183657810", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5329E60", Offset = "0x5328A60", VA = "0x185329E60", Slot = "7")]
	public void BOGIPIDACAM(double FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5329F90", Offset = "0x5328B90", VA = "0x185329F90", Slot = "8")]
	public void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5329FD0", Offset = "0x5328BD0", VA = "0x185329FD0")]
	public DEPHEGCJIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class LHLFIECIAEI
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface AEDFBHIPANF
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool MHBPOKGCJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DNAKJMIBDKI();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class NGPMGGAEJPG<TPromise, TMainThreadPromise> : AEDFBHIPANF where TPromise : FKDPJJAEIFK where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise ODKFFOINEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise NPKEAMGPOBK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise FKFEMPCFDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2699EE0", Offset = "0x2698AE0", VA = "0x182699EE0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MHBPOKGCJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2699F40", Offset = "0x2698B40", VA = "0x182699F40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x250A8D0", Offset = "0x25094D0", VA = "0x18250A8D0")]
		protected NGPMGGAEJPG(TPromise ODKFFOINEIJ, TMainThreadPromise OGAAKNMEFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2699EB0", Offset = "0x2698AB0", VA = "0x182699EB0", Slot = "5")]
		public void DNAKJMIBDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void FCBGILKBLKH(TPromise ODKFFOINEIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class ECEGBGGJFBD<T> : NGPMGGAEJPG<global::CGDFFALNLAC<T>, global::ENFBMJFPLIK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2DE70C0", Offset = "0x2DE5CC0", VA = "0x182DE70C0")]
		public ECEGBGGJFBD(global::CGDFFALNLAC<T> ODKFFOINEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6F30", Offset = "0x2DE5B30", VA = "0x182DE6F30", Slot = "6")]
		protected override void FCBGILKBLKH(global::CGDFFALNLAC<T> ODKFFOINEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2DE7090", Offset = "0x2DE5C90", VA = "0x182DE7090")]
		[CompilerGenerated]
		private void INLEKAGNMHC(T BMBFIGGJLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1335550", Offset = "0x1334150", VA = "0x181335550")]
		[CompilerGenerated]
		private void CPLBJKDMKON(string OMKDGOMBDIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class CKBCJKPCOID : AEDFBHIPANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action KDJGJCHCIKK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHBPOKGCJOO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
		public CKBCJKPCOID(Action KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1364A40", Offset = "0x1363640", VA = "0x181364A40", Slot = "5")]
		public void DNAKJMIBDKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<AEDFBHIPANF> KOEOMAMMMGP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D17630", Offset = "0x3D16230", VA = "0x183D17630")]
	public static global::CGDFFALNLAC<T> JJKGNPPODBD<T>(this global::CGDFFALNLAC<T> ODKFFOINEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5336A80", Offset = "0x5335680", VA = "0x185336A80")]
	public static void JJKGNPPODBD(Action KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3D17570", Offset = "0x3D16170", VA = "0x183D17570")]
	private static global::CGDFFALNLAC<T> CPEHKFJDLDG<T>(global::CGDFFALNLAC<T> ODKFFOINEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5336B10", Offset = "0x5335710", VA = "0x185336B10")]
	private static void NDJJBGEHDEG(AEDFBHIPANF IGJGLOHNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5336690", Offset = "0x5335290", VA = "0x185336690")]
	private static void DCOJGNNLJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5336980", Offset = "0x5335580", VA = "0x185336980")]
	private static void JEEGHEKPJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x53365C0", Offset = "0x53351C0", VA = "0x1853365C0")]
	private static void BDMMINGOPML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DEGFEIMDJGK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct BMLNBKAPFIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> GGNGJMAGHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string BIHFIHKHIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode FDGCFCFBADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool IMDFFNIBLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly CEJMOEANPLC PDHDLCNGDKN;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x53240F0", Offset = "0x5322CF0", VA = "0x1853240F0")]
		public BMLNBKAPFIO(TaskCompletionSource<Scene> NFDBDOFNPHG, string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM, bool IMDFFNIBLHP, CEJMOEANPLC PDHDLCNGDKN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct IMNAOIADKLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CEJMOEANPLC stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::EEKDJEFEHJA<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x53321C0", Offset = "0x5330DC0", VA = "0x1853321C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5332830", Offset = "0x5331430", VA = "0x185332830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct EBHODFGLNLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x532A590", Offset = "0x5329190", VA = "0x18532A590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct JNBDOEFFALP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private BMLNBKAPFIO <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5333B80", Offset = "0x5332780", VA = "0x185333B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DF20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IBBCECOAFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::ENFBMJFPLIK<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public IBBCECOAFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5330330", Offset = "0x532EF30", VA = "0x185330330")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DDOOLLFDKAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IBBCECOAFNG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private CEJMOEANPLC <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private CEJMOEANPLC <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5328100", Offset = "0x5326D00", VA = "0x185328100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5328A80", Offset = "0x5327680", VA = "0x185328A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct GGIOGKDFGJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CEJMOEANPLC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CEJMOEANPLC <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private CEJMOEANPLC <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x532C3E0", Offset = "0x532AFE0", VA = "0x18532C3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x532CC20", Offset = "0x532B820", VA = "0x18532CC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DOIPFAHCKGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public DOIPFAHCKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x532A000", Offset = "0x5328C00", VA = "0x18532A000")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ANBOOGPEDME : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public LNEJMGPOKKP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public ANBOOGPEDME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5323550", Offset = "0x5322150", VA = "0x185323550", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x53231F0", Offset = "0x5321DF0", VA = "0x1853231F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x53235E0", Offset = "0x53221E0", VA = "0x1853235E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5323510", Offset = "0x5322110", VA = "0x185323510", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GGCPIJHJNEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::ENFBMJFPLIK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GGCPIJHJNEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OOOHPFPMJLF : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::ENFBMJFPLIK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private GGCPIJHJNEI <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public OOOHPFPMJLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5339A70", Offset = "0x5338670", VA = "0x185339A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5339EC0", Offset = "0x5338AC0", VA = "0x185339EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static FKDPJJAEIFK DGKBNNJCPPK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation AMJCENPHLOA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static FKDPJJAEIFK DHHIPFAOFEG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string LDNGMICMHFO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority CPHCCNCECPE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task FKDDPGNMNNG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<BMLNBKAPFIO> GKCCIOMGCEB;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task NOANFHOACBH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool PDAHIJCIDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5329070", Offset = "0x5327C70", VA = "0x185329070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool FCOGECBNJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5328E80", Offset = "0x5327A80", VA = "0x185328E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool GDNHAGBOJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5329CE0", Offset = "0x53288E0", VA = "0x185329CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KHJFAFOBPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5329230", Offset = "0x5327E30", VA = "0x185329230")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5329520", Offset = "0x5328120", VA = "0x185329520")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5329A10", Offset = "0x5328610", VA = "0x185329A10")]
	[ECPMKACBNFP(JMKOAIIKPBP.EnteredEditModeNextFrame, 0)]
	private static void MIPGHHOMFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x53293C0", Offset = "0x5327FC0", VA = "0x1853293C0")]
	[AsyncStateMachine(typeof(IMNAOIADKLH))]
	public static Task<Scene> FOJPEBJCGFH(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM = LoadSceneMode.Single, bool IMDFFNIBLHP = false, [Optional] CEJMOEANPLC BDIDLIGCMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5328AD0", Offset = "0x53276D0", VA = "0x185328AD0")]
	[AsyncStateMachine(typeof(EBHODFGLNLJ))]
	private static Task ALMHPINAKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5329920", Offset = "0x5328520", VA = "0x185329920")]
	[AsyncStateMachine(typeof(JNBDOEFFALP))]
	private static Task LPMHFODDGOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5329B80", Offset = "0x5328780", VA = "0x185329B80")]
	[AsyncStateMachine(typeof(DDOOLLFDKAE))]
	private static Task<Scene> OOKKECMOMKL(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM, bool IMDFFNIBLHP, CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5328F30", Offset = "0x5327B30", VA = "0x185328F30")]
	[AsyncStateMachine(typeof(GGIOGKDFGJL))]
	private static Task<Scene> BGIJGPPFOEK(CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5329620", Offset = "0x5328220", VA = "0x185329620")]
	public static global::CGDFFALNLAC<Scene> HNNAAALEHJL(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5328BA0", Offset = "0x53277A0", VA = "0x185328BA0")]
	public static FKDPJJAEIFK ANMHCOFMFBK(string BIHFIHKHIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5329330", Offset = "0x5327F30", VA = "0x185329330")]
	[IteratorStateMachine(typeof(ANBOOGPEDME))]
	private static IEnumerator<LGOBDJKCLEL> FMKHDHGAKML(string BIHFIHKHIBA, LNEJMGPOKKP CGNDBLJLCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5329AE0", Offset = "0x53286E0", VA = "0x185329AE0")]
	[IteratorStateMachine(typeof(OOOHPFPMJLF))]
	private static IEnumerator<LGOBDJKCLEL> OLNOMHGKFPN(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM, global::ENFBMJFPLIK<Scene> CGNDBLJLCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53297C0", Offset = "0x53283C0", VA = "0x1853297C0")]
	public static bool JDMMDFHECGL(out string LNHDPALMDNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CMJPILMGIDM
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x53248B0", Offset = "0x53234B0", VA = "0x1853248B0")]
	public static IDisposable LMFCNJFOIHP(this PMNJCJEPGMK EDPENIGJGLF, float AHLEDACMFEN, Action<float> IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5324830", Offset = "0x5323430", VA = "0x185324830")]
	public static IDisposable LDLLELDOOON(this PMNJCJEPGMK EDPENIGJGLF, Action<float> IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5324930", Offset = "0x5323530", VA = "0x185324930")]
	public static IDisposable NPCLCFBLMBM(this PMNJCJEPGMK EDPENIGJGLF, Action<float> IPFHHMKILIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FIJKNABMGMG
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x532B780", Offset = "0x532A380", VA = "0x18532B780")]
	public static IDisposable AHLGFKHMAIH(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x532B700", Offset = "0x532A300", VA = "0x18532B700")]
	public static IDisposable AHLGFKHMAIH(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x532BE30", Offset = "0x532AA30", VA = "0x18532BE30")]
	public static IDisposable LPIFGEKCIOM(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x532B800", Offset = "0x532A400", VA = "0x18532B800")]
	public static IDisposable ALNCNIFJAAA(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x532BD20", Offset = "0x532A920", VA = "0x18532BD20")]
	public static IDisposable KJGPIOGKJKD(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x532BEA0", Offset = "0x532AAA0", VA = "0x18532BEA0")]
	public static IDisposable NKPJCIJBOPO(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x532BB80", Offset = "0x532A780", VA = "0x18532BB80")]
	public static IDisposable IOKGMGDICKJ(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x532BAE0", Offset = "0x532A6E0", VA = "0x18532BAE0")]
	public static IDisposable IEOBFPECPEM(this MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x532BA40", Offset = "0x532A640", VA = "0x18532BA40")]
	public static IDisposable HMMJCJJIDLN(this MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x532B9B0", Offset = "0x532A5B0", VA = "0x18532B9B0")]
	public static IDisposable EJBHPPIOIIE(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x532B880", Offset = "0x532A480", VA = "0x18532B880")]
	public static IDisposable CAHAIAFFEME(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x532BF20", Offset = "0x532AB20", VA = "0x18532BF20")]
	public static IDisposable OBJGJCKLPIG(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x532BFB0", Offset = "0x532ABB0", VA = "0x18532BFB0")]
	public static IDisposable ODLGOAEFMCL(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x532BC00", Offset = "0x532A800", VA = "0x18532BC00")]
	public static IDisposable KFNBFLCDJMI(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x532BDA0", Offset = "0x532A9A0", VA = "0x18532BDA0")]
	public static IDisposable LEOMGPMPANH(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x532BC90", Offset = "0x532A890", VA = "0x18532BC90")]
	public static IDisposable KHEPCLMMBDG(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x532B910", Offset = "0x532A510", VA = "0x18532B910")]
	public static IDisposable CLIBDIOJGHP(this MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x532C040", Offset = "0x532AC40", VA = "0x18532C040")]
	public static IDisposable PNAAFCFGNDE(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NDAFCKAMKGG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class AJGCKPPEPFK : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AGIGAFJFFKN.CPOGHHGJJHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private EFGCGAPKDDH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public AJGCKPPEPFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x53230F0", Offset = "0x5321CF0", VA = "0x1853230F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x53231B0", Offset = "0x5321DB0", VA = "0x1853231B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DPIADKNMFAP : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AGIGAFJFFKN.CPOGHHGJJHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private EFGCGAPKDDH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public DPIADKNMFAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x532A030", Offset = "0x5328C30", VA = "0x18532A030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x532A120", Offset = "0x5328D20", VA = "0x18532A120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x53379B0", Offset = "0x53365B0", VA = "0x1853379B0")]
	public static LOGJIJEEBDN AHLGFKHMAIH(Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x53377E0", Offset = "0x53363E0", VA = "0x1853377E0")]
	public static LOGJIJEEBDN AHLGFKHMAIH(Behaviour EDPENIGJGLF, Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x53378A0", Offset = "0x53364A0", VA = "0x1853378A0")]
	public static LOGJIJEEBDN AHLGFKHMAIH(Behaviour EDPENIGJGLF, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5337B50", Offset = "0x5336750", VA = "0x185337B50")]
	[IteratorStateMachine(typeof(AJGCKPPEPFK))]
	private static IEnumerator<LGOBDJKCLEL> IDNAABOCAHH(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5337AD0", Offset = "0x53366D0", VA = "0x185337AD0")]
	[IteratorStateMachine(typeof(DPIADKNMFAP))]
	private static IEnumerator<LGOBDJKCLEL> IDNAABOCAHH(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, Action<float> IPFHHMKILIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PAFMDKCODBC
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EBCAHJNPIMB : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public PBLCKBAIGPC schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AGIGAFJFFKN.CPOGHHGJJHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private AGDJFGHCIGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public EBCAHJNPIMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x532A410", Offset = "0x5329010", VA = "0x18532A410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x532A550", Offset = "0x5329150", VA = "0x18532A550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5339F00", Offset = "0x5338B00", VA = "0x185339F00")]
	public static LOGJIJEEBDN AHLGFKHMAIH(MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x533A0C0", Offset = "0x5338CC0", VA = "0x18533A0C0")]
	public static LOGJIJEEBDN JKLGCPGHPJB(PMNJCJEPGMK EDPENIGJGLF, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x533A010", Offset = "0x5338C10", VA = "0x18533A010")]
	[IteratorStateMachine(typeof(EBCAHJNPIMB))]
	private static IEnumerator<LGOBDJKCLEL> IDNAABOCAHH(PBLCKBAIGPC CONMNDPHEEJ, float AHLEDACMFEN, AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LBCOCGFGGIN
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BIPLDPGOOKM : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AGIGAFJFFKN.CPOGHHGJJHJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public BIPLDPGOOKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5323930", Offset = "0x5322530", VA = "0x185323930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x53239E0", Offset = "0x53225E0", VA = "0x1853239E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x53360F0", Offset = "0x5334CF0", VA = "0x1853360F0")]
	[IteratorStateMachine(typeof(BIPLDPGOOKM))]
	private static IEnumerator<LGOBDJKCLEL> GKGHCAMNNNE(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, Func<bool> KLFAJEFIDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5336170", Offset = "0x5334D70", VA = "0x185336170")]
	public static LOGJIJEEBDN KDEHIEFHEGD(this MonoBehaviour CACIHNMLHAH, Func<bool> KLFAJEFIDKC, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK = AGIGAFJFFKN.CPOGHHGJJHJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MLJKKJCMBLH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class EPBLLKJFHMO : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AGIGAFJFFKN.CPOGHHGJJHJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public EPBLLKJFHMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x532B420", Offset = "0x532A020", VA = "0x18532B420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x532B4E0", Offset = "0x532A0E0", VA = "0x18532B4E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x53373B0", Offset = "0x5335FB0", VA = "0x1853373B0")]
	[IteratorStateMachine(typeof(EPBLLKJFHMO))]
	private static IEnumerator<LGOBDJKCLEL> MFDEPGKDKIJ(float KGGLLCMFPGN, AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5336F20", Offset = "0x5335B20", VA = "0x185336F20")]
	public static LOGJIJEEBDN CIGCBFKBNLA(this MonoBehaviour CACIHNMLHAH, float KGGLLCMFPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x53371B0", Offset = "0x5335DB0", VA = "0x1853371B0")]
	public static LOGJIJEEBDN JMJFFIAJHFO(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5337180", Offset = "0x5335D80", VA = "0x185337180")]
	public static LOGJIJEEBDN ICJJNEJANMD(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53372D0", Offset = "0x5335ED0", VA = "0x1853372D0")]
	public static LOGJIJEEBDN MCOOLGECADC(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5336EC0", Offset = "0x5335AC0", VA = "0x185336EC0")]
	public static LOGJIJEEBDN AFBLAEPAHOE(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5336EF0", Offset = "0x5335AF0", VA = "0x185336EF0")]
	public static LOGJIJEEBDN BEPGLJKLOAG(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x53371D0", Offset = "0x5335DD0", VA = "0x1853371D0")]
	public static LOGJIJEEBDN LEKNECGILNK(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5336FE0", Offset = "0x5335BE0", VA = "0x185336FE0")]
	private static LOGJIJEEBDN FKCKCDEJLAM(MonoBehaviour CACIHNMLHAH, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, Action FEADACHODCB, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5337440", Offset = "0x5336040", VA = "0x185337440")]
	public static LOGJIJEEBDN NEJOOAECFFI(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5337510", Offset = "0x5336110", VA = "0x185337510")]
	public static LOGJIJEEBDN OAONFCDNKCO(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5337200", Offset = "0x5335E00", VA = "0x185337200")]
	public static LOGJIJEEBDN LGOCHNCJOOF(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x53370B0", Offset = "0x5335CB0", VA = "0x1853370B0")]
	public static LOGJIJEEBDN HPDMPHOJLJK(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class GJJELJJDOPM : CMBFHICPACF, IEnumerable<CMBFHICPACF>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<CMBFHICPACF> ABJBGPIKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool NNDEAHCJJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action NEHOJJMPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool OMHNPPKKLLA;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool KDCNLOHGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x532CDA0", Offset = "0x532B9A0", VA = "0x18532CDA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EPEJOKGMFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x532D2F0", Offset = "0x532BEF0", VA = "0x18532D2F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x532CF60", Offset = "0x532BB60", VA = "0x18532CF60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x532D500", Offset = "0x532C100", VA = "0x18532D500")]
	public GJJELJJDOPM([Optional] Action NEHOJJMPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x532CC70", Offset = "0x532B870", VA = "0x18532CC70")]
	public void ELGBPIMHCCH(CMBFHICPACF OCJDCLKOPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x532D390", Offset = "0x532BF90", VA = "0x18532D390")]
	private void MNEPAOKPHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x532D000", Offset = "0x532BC00", VA = "0x18532D000", Slot = "7")]
	public bool KOHBNODOOEI(bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x532D010", Offset = "0x532BC10", VA = "0x18532D010", Slot = "8")]
	public bool KOHBNODOOEI(Action KDJGJCHCIKK, bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x532CEE0", Offset = "0x532BAE0", VA = "0x18532CEE0", Slot = "9")]
	public IEnumerator<CMBFHICPACF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x532CEE0", Offset = "0x532BAE0", VA = "0x18532CEE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MLNLECBGKNI : BLCGBDKHKNP
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HKLHMFAAMLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public MLNLECBGKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public HKLHMFAAMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x532D780", Offset = "0x532C380", VA = "0x18532D780")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class GMNADFCKEGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public MLNLECBGKNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GMNADFCKEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x532D780", Offset = "0x532C380", VA = "0x18532D780")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float MJJJLIIPOGF;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5324730", Offset = "0x5323330", VA = "0x185324730")]
	public MLNLECBGKNI(Behaviour EDPENIGJGLF, float MJJJLIIPOGF, [Optional] Action NEHOJJMPMCD, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x53376E0", Offset = "0x53362E0", VA = "0x1853376E0", Slot = "9")]
	protected override bool OJFOOEHONCJ(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x53375E0", Offset = "0x53361E0", VA = "0x1853375E0", Slot = "10")]
	protected override bool NCDEHCLOHFC(Action KDJGJCHCIKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface CMBFHICPACF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool KDCNLOHGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action EPEJOKGMFAG;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KOHBNODOOEI(bool JOGFOOOHGFG = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KOHBNODOOEI(Action KDJGJCHCIKK, bool JOGFOOOHGFG = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class BLCGBDKHKNP : CMBFHICPACF
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class OKPAHDHBGHM : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public BLCGBDKHKNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public OKPAHDHBGHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5339960", Offset = "0x5338560", VA = "0x185339960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5339A30", Offset = "0x5338630", VA = "0x185339A30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour EDPENIGJGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action NEHOJJMPMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private ALDLEBFHJGM HBNBGANNKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly GOFKDIOBLPL LNMBBJJCJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly PBLCKBAIGPC CONMNDPHEEJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KDCNLOHGOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C8910", Offset = "0x6C7510", VA = "0x1806C8910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EPEJOKGMFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5323F50", Offset = "0x5322B50", VA = "0x185323F50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5323E00", Offset = "0x5322A00", VA = "0x185323E00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5323FF0", Offset = "0x5322BF0", VA = "0x185323FF0")]
	protected BLCGBDKHKNP(Behaviour EDPENIGJGLF, [Optional] Action NEHOJJMPMCD, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5323EF0", Offset = "0x5322AF0", VA = "0x185323EF0", Slot = "7")]
	public bool KOHBNODOOEI(bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5323EA0", Offset = "0x5322AA0", VA = "0x185323EA0", Slot = "8")]
	public bool KOHBNODOOEI(Action KDJGJCHCIKK, bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OJFOOEHONCJ(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NCDEHCLOHFC(Action KDJGJCHCIKK);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5323DE0", Offset = "0x53229E0", VA = "0x185323DE0")]
	protected void IHCEBFICLBM(Action KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5323BE0", Offset = "0x53227E0", VA = "0x185323BE0")]
	protected FKDPJJAEIFK EDIHKKOEOPE(float CINBMJOKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5323B20", Offset = "0x5322720", VA = "0x185323B20")]
	private void BNHCDAJPFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5323AA0", Offset = "0x53226A0", VA = "0x185323AA0")]
	[IteratorStateMachine(typeof(OKPAHDHBGHM))]
	private IEnumerator<LGOBDJKCLEL> ADKCJBMBGDG(float CINBMJOKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5323BA0", Offset = "0x53227A0", VA = "0x185323BA0")]
	[CompilerGenerated]
	private void DMOKEDHDBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JHFLHAGHNPP : BLCGBDKHKNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float DDJIABFJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int ELBNKHHNAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float EAFLGAGJHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] CNPCGEKJEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int AGEPOJAEMLB;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x53339D0", Offset = "0x53325D0", VA = "0x1853339D0")]
	public JHFLHAGHNPP(Behaviour EDPENIGJGLF, float MKMPHEENGMG, int ELBNKHHNAHB, [Optional] Action NEHOJJMPMCD, float EAFLGAGJHHO = 0f, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "9")]
	protected override bool OJFOOEHONCJ(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5333710", Offset = "0x5332310", VA = "0x185333710", Slot = "10")]
	protected override bool NCDEHCLOHFC(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5333940", Offset = "0x5332540", VA = "0x185333940")]
	private void NJKEAPHPBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CLHDKHGLABH : BLCGBDKHKNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float MJJJLIIPOGF;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5324730", Offset = "0x5323330", VA = "0x185324730")]
	public CLHDKHGLABH(Behaviour EDPENIGJGLF, float MJJJLIIPOGF, [Optional] Action NEHOJJMPMCD, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00", Slot = "9")]
	protected override bool OJFOOEHONCJ(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53246F0", Offset = "0x53232F0", VA = "0x1853246F0", Slot = "10")]
	protected override bool NCDEHCLOHFC(Action KDJGJCHCIKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class INPMPPGDDOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class DCKPDMAFJFA : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public DCKPDMAFJFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5328020", Offset = "0x5326C20", VA = "0x185328020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x53280C0", Offset = "0x5326CC0", VA = "0x1853280C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private LOGJIJEEBDN FDGJACFCANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PMNJCJEPGMK EDPENIGJGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> ADPAGMJFBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float BMLAPEIOONG;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5332E10", Offset = "0x5331A10", VA = "0x185332E10")]
	public INPMPPGDDOL(PMNJCJEPGMK EDPENIGJGLF, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5332880", Offset = "0x5331480", VA = "0x185332880")]
	private void ANAKLICPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5332A30", Offset = "0x5331630", VA = "0x185332A30")]
	private void DFIHJDOGGMH(string OMKDGOMBDIM, Action OMIHFECFEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5332DA0", Offset = "0x53319A0", VA = "0x185332DA0")]
	[IteratorStateMachine(typeof(DCKPDMAFJFA))]
	private IEnumerator<LGOBDJKCLEL> GDGAMNKFINF(Action OMIHFECFEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5332D40", Offset = "0x5331940", VA = "0x185332D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5332B90", Offset = "0x5331790", VA = "0x185332B90")]
	[CompilerGenerated]
	private void DICEFDIOMKE(string AENGIJLJHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class KFDGNINFNIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class MDMKNKNCBBA : IEnumerator<LGOBDJKCLEL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private LGOBDJKCLEL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private LGOBDJKCLEL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public MDMKNKNCBBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5336D90", Offset = "0x5335990", VA = "0x185336D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5336E30", Offset = "0x5335A30", VA = "0x185336E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LOGJIJEEBDN FDGJACFCANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour CACIHNMLHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action IPFHHMKILIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> ADPAGMJFBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float BMLAPEIOONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool IHMAMIJPBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly GOFKDIOBLPL LNMBBJJCJOB;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5335690", Offset = "0x5334290", VA = "0x185335690")]
	public KFDGNINFNIL(MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5335890", Offset = "0x5334490", VA = "0x185335890")]
	public KFDGNINFNIL(MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5335AD0", Offset = "0x53346D0", VA = "0x185335AD0")]
	public KFDGNINFNIL(MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5334E00", Offset = "0x5333A00", VA = "0x185334E00")]
	private void AHLGFKHMAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x53354E0", Offset = "0x53340E0", VA = "0x1853354E0")]
	private void PLHIMDCFFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5334F70", Offset = "0x5333B70", VA = "0x185334F70")]
	private void ANAKLICPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5335130", Offset = "0x5333D30", VA = "0x185335130")]
	private void DFIHJDOGGMH(string OMKDGOMBDIM, Action OMIHFECFEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x53352C0", Offset = "0x5333EC0", VA = "0x1853352C0")]
	[IteratorStateMachine(typeof(MDMKNKNCBBA))]
	private IEnumerator<LGOBDJKCLEL> GDGAMNKFINF(Action OMIHFECFEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5335260", Offset = "0x5333E60", VA = "0x185335260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5335330", Offset = "0x5333F30", VA = "0x185335330")]
	[CompilerGenerated]
	private void GLDEHIHGOCE(string AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x53353C0", Offset = "0x5333FC0", VA = "0x1853353C0")]
	[CompilerGenerated]
	private void JAGJACLCENG(string AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5335450", Offset = "0x5334050", VA = "0x185335450")]
	[CompilerGenerated]
	private void PDDLEFFBKDJ(string AENGIJLJHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum DJMKPHEFCCN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class LDONPIOOKEC : PBLCKBAIGPC
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float EKJKODFECND
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5336510", Offset = "0x5335110", VA = "0x185336510", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float KONHMGIJNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x53365B0", Offset = "0x53351B0", VA = "0x1853365B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double LNGCFOHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5336520", Offset = "0x5335120", VA = "0x185336520", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5336540", Offset = "0x5335140", VA = "0x185336540")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void FNPDOJFFBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	[Preserve]
	internal LDONPIOOKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface FBBIDIDHOLE
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKJLNBCMJOL(string NLCIGFDKGEE);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGMHOCNICIM();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface JAKMHNKCPDA
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DNEMJMCMOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool JABBODADOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class OCBKPMALMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public HLCKICOEKGN GBANOMNCDGN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696B30", VA = "0x180697F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5339340", Offset = "0x5337F40", VA = "0x185339340")]
	public static LGOBDJKCLEL JLKLKBHFDMH(IEnumerator<LGOBDJKCLEL> MMAPPEJOCAD, ILAAKECGBDP NMLBIEFPGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53394F0", Offset = "0x53380F0", VA = "0x1853394F0")]
	public LGOBDJKCLEL JLKLKBHFDMH(ILAAKECGBDP[] LNLAKFFPLGI, IEnumerator<LGOBDJKCLEL>[] APBKNLKFFOC, LGOBDJKCLEL[] DENIILIAGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5339310", Offset = "0x5337F10", VA = "0x185339310")]
	public void HILLCDNMLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5339710", Offset = "0x5338310", VA = "0x185339710")]
	public void MHMFAMOJCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x53395D0", Offset = "0x53381D0", VA = "0x1853395D0")]
	public void KCKIAKDKMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5339310", Offset = "0x5337F10", VA = "0x185339310")]
	public void CIAEBEDAGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OCBKPMALMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class HLCKICOEKGN
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct GFNCFMKGLNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public OCBKPMALMOF LDLBJPPDJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PMNJCJEPGMK LDMDKFCJFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public ILAAKECGBDP BHMNJBPECAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<LGOBDJKCLEL> BCHCIDMOGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public LGOBDJKCLEL KPHPMIENNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DJMKPHEFCCN EBILNNPHGBE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EEIGJMCNCDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AGIGAFJFFKN.CPOGHHGJJHJ CIGBFOMNDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<GFNCFMKGLNF> OABJHKJNLFI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EHNEAKAOHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public HLCKICOEKGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public PMNJCJEPGMK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public OCBKPMALMOF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DJMKPHEFCCN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ILAAKECGBDP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LGOBDJKCLEL currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<LGOBDJKCLEL> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public EHNEAKAOHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x532AD00", Offset = "0x5329900", VA = "0x18532AD00")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class BIPOGBJNCPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public OCBKPMALMOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public HLCKICOEKGN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BIPOGBJNCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5323A20", Offset = "0x5322620", VA = "0x185323A20")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BKADIFIAALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public OCBKPMALMOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HLCKICOEKGN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BKADIFIAALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5323A60", Offset = "0x5322660", VA = "0x185323A60")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class FJIIIFGENMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public OCBKPMALMOF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HLCKICOEKGN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public FJIIIFGENMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x532C0D0", Offset = "0x532ACD0", VA = "0x18532C0D0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const DJMKPHEFCCN BMFDOGPPCBB = DJMKPHEFCCN.Cancelled | DJMKPHEFCCN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] PCGEGJFGJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<DJMKPHEFCCN> EGDHLEKOIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> APDAEDCOGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> APCLDHNFAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> HFNNAMAJPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> HHMBHFGJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> KMNEJLEBKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> APANBHCAPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private OCBKPMALMOF[] POBNDMLBHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private ILAAKECGBDP[] LNLAKFFPLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PMNJCJEPGMK[] HDGLKFIBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<LGOBDJKCLEL>[] JDELOILFGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private LGOBDJKCLEL[] HNIAHKCHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int PFPKKBCEFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int BPGPHKEJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int FLELPJPPFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float BLLGILAFLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private IJNKAFLFHNK CGPCLOMHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle JJNNEBEBICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<OCBKPMALMOF> OJJLHGLNEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool PPKLJBKPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> EGKLIEJNDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> ECLCHFGCNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool NLNBKNPOLLJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public EEIGJMCNCDN[] HNKDMNPNFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x13AF3D0", Offset = "0x13ADFD0", VA = "0x1813AF3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x532E430", Offset = "0x532D030", VA = "0x18532E430")]
	private static int DADCFPPFOAP(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x532FD30", Offset = "0x532E930", VA = "0x18532FD30")]
	public HLCKICOEKGN(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x532F2D0", Offset = "0x532DED0", VA = "0x18532F2D0")]
	private void JOOAGJICEGG(ref int KLOILOLBHCI, int NMAJBHOILMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x532F4C0", Offset = "0x532E0C0", VA = "0x18532F4C0")]
	public void MCIHDOCKBEB(PMNJCJEPGMK EDPENIGJGLF, LGOBDJKCLEL OBONFADGGNC, IEnumerator<LGOBDJKCLEL> MMAPPEJOCAD, ILAAKECGBDP NMLBIEFPGAJ, [Optional] OCBKPMALMOF IDMIJLBHPCC, DJMKPHEFCCN OFCPGMIIBHP = DJMKPHEFCCN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x532EAE0", Offset = "0x532D6E0", VA = "0x18532EAE0")]
	public void ELGAMDPPEBI(IEnumerable<GFNCFMKGLNF> PALKKPGBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x532DF20", Offset = "0x532CB20", VA = "0x18532DF20")]
	private GFNCFMKGLNF DABBNOPBIEN(int LFJLCOFFLAB)
	{
		return default(GFNCFMKGLNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x532ECD0", Offset = "0x532D8D0", VA = "0x18532ECD0")]
	private void HFIEJHNIGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2C82D60", Offset = "0x2C81960", VA = "0x182C82D60")]
	private static void LJJHIMOKLGJ<T>(int LFJLCOFFLAB, T[] PENKLAEPAFN, int LBLAPKMJFKP, [Optional] T PBIPOIONKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2C82D40", Offset = "0x2C81940", VA = "0x182C82D40")]
	private static void LJJHIMOKLGJ<T>(int LFJLCOFFLAB, NativeArray<T> PENKLAEPAFN, int LBLAPKMJFKP, [Optional] T PBIPOIONKEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x532DAC0", Offset = "0x532C6C0", VA = "0x18532DAC0")]
	private void BHDFHCKOLBJ(IEnumerable<GFNCFMKGLNF> PALKKPGBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x532F640", Offset = "0x532E240", VA = "0x18532F640")]
	private void MOMCDENFGCI(GFNCFMKGLNF HHBDNJOFKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x532F710", Offset = "0x532E310", VA = "0x18532F710")]
	private EDFOJIMBGIM OJHEBIIADDG(int HKPBLIHEGDE)
	{
		return default(EDFOJIMBGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x532FB50", Offset = "0x532E750", VA = "0x18532FB50")]
	public void PABEFPAKHCH(float JMGIEMIHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x532F9D0", Offset = "0x532E5D0", VA = "0x18532F9D0")]
	private void OJMEOFEEGEK(Action LEOEMBMBFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x532DEA0", Offset = "0x532CAA0", VA = "0x18532DEA0")]
	private void CNNKJMADKNG(Action LEOEMBMBFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x532E460", Offset = "0x532D060", VA = "0x18532E460")]
	public void EGHLCLBELDC(float JMGIEMIHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x532FA50", Offset = "0x532E650", VA = "0x18532FA50")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x532DD70", Offset = "0x532C970", VA = "0x18532DD70")]
	public void CIAEBEDAGAM(OCBKPMALMOF MJDOAAJPNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x532F1A0", Offset = "0x532DDA0", VA = "0x18532F1A0")]
	public void JJDCNDIGJDL(OCBKPMALMOF MJDOAAJPNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x532F070", Offset = "0x532DC70", VA = "0x18532F070")]
	public void HMIHJKLLFCK(OCBKPMALMOF MJDOAAJPNPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class OAEIIBONPLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly OAEIIBONPLF PHIHNICJGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action AFPMFAHAGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool LFPHADEPEGI;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	public OAEIIBONPLF(Action AFPMFAHAGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x53391F0", Offset = "0x5337DF0", VA = "0x1853391F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface CIDJKBFIFNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NMBJBBJCOAJ(UnityEngine.Object EDPENIGJGLF, Action<T> HLMNGIBMFAO);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface EIDAOPBJKEC<T> : global::CIDJKBFIFNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class JEEMOIFFBDC<T> : global::EIDAOPBJKEC<T>, global::CIDJKBFIFNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class OANAFHLOKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::JEEMOIFFBDC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::LJNOPIFCOMG<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public OANAFHLOKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x27DFF00", Offset = "0x27DEB00", VA = "0x1827DFF00")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject PODLNFAMHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::LJNOPIFCOMG<UnityEngine.Object, Action<T>>> GLLJBNCFFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T LDEOAHKFDIG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6904D0", VA = "0x1806918D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B12B00", Offset = "0x2B11700", VA = "0x182B12B00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2B12B60", Offset = "0x2B11760", VA = "0x182B12B60")]
	private static bool DFNKPADHOAL(T LEOEMBMBFBC, T GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2B13630", Offset = "0x2B12230", VA = "0x182B13630")]
	public JEEMOIFFBDC(T KBCACIBDIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2B13420", Offset = "0x2B12020", VA = "0x182B13420", Slot = "6")]
	public IDisposable NMBJBBJCOAJ(UnityEngine.Object EDPENIGJGLF, Action<T> HLMNGIBMFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2B12F50", Offset = "0x2B11B50", VA = "0x182B12F50")]
	private void HLNIPELHKMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class DBGHGABEDKB : FJGCGJBADIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly GOFKDIOBLPL LNMBBJJCJOB;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5327F10", Offset = "0x5326B10", VA = "0x185327F10")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void FNPDOJFFBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	[Preserve]
	internal DBGHGABEDKB([MAEEAOEDELI(null)] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5327F80", Offset = "0x5326B80", VA = "0x185327F80", Slot = "4")]
	public IDisposable HMMJCJJIDLN(float AHLEDACMFEN, Action<float> PKPGAEOFIGD, bool IHMAMIJPBNM = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct IJNKAFLFHNK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float IJCBKGKDHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int PJOCNLFBELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> NGAGMALKCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> CDCPOEEKBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> MBAKLBOJGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<DJMKPHEFCCN> GAKKBIKNGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> IMIPNADOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> HHMBHFGJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> APCLDHNFAGO;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5331F30", Offset = "0x5330B30", VA = "0x185331F30")]
	public static IJNKAFLFHNK GLBIKEOEKPG(int LMGMIPEFJPA, float JMGIEMIHBGG, NativeArray<DJMKPHEFCCN> EPFELDHKEPO, NativeArray<float> JJGEPFCPCBK, NativeArray<int> OHPABMFJOIP, NativeArray<int> PNOBJEIEPJC, NativeArray<int> KAHKHIDGDPP, NativeArray<int> CDCPOEEKBHP, NativeArray<int> MBAKLBOJGGJ)
	{
		return default(IJNKAFLFHNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5331E50", Offset = "0x5330A50", VA = "0x185331E50", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x53320C0", Offset = "0x5330CC0", VA = "0x1853320C0")]
	private bool JIJOLHGLJAB(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5332100", Offset = "0x5330D00", VA = "0x185332100")]
	private void PJIHBPNNCGH(NativeArray<int> ANNPKHOCPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5331F90", Offset = "0x5330B90", VA = "0x185331F90")]
	private int IJDMBOEDCNJ(int NFDJKLDKEFF, int GHFMKLAAOKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5331FF0", Offset = "0x5330BF0", VA = "0x185331FF0")]
	private void IPKMLKKNAPO(NativeArray<int> ANNPKHOCPIN, int CNDLJBCLDMB, int PHOLGHPIFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5331C20", Offset = "0x5330820", VA = "0x185331C20")]
	private void CFMPNPCGCFP(NativeArray<int> ANNPKHOCPIN, int HGPDCENLHMJ, int FFPILLGJIFP, int FHMCIFLKOKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class JOKPBGLAHBN : NNDEOACODNN, GOFKDIOBLPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private HLCKICOEKGN[] NCCELALFMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private FBBIDIDHOLE NBLLHOIMNAJ;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5334260", Offset = "0x5332E60", VA = "0x185334260")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void FNPDOJFFBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5334960", Offset = "0x5333560", VA = "0x185334960")]
	[Preserve]
	public JOKPBGLAHBN([MAEEAOEDELI(null)] EABLLNECEBB BAPOCPBOGOO, [MAEEAOEDELI(null)] PBLCKBAIGPC CONMNDPHEEJ, [MAEEAOEDELI(null)] IGBFBJPBAJO FDHILCCHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x53342D0", Offset = "0x5332ED0", VA = "0x1853342D0", Slot = "12")]
	public override LOGJIJEEBDN ICDAKAEKLHE(PMNJCJEPGMK EDPENIGJGLF, IEnumerator<LGOBDJKCLEL> AFIOECAKMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5333F80", Offset = "0x5332B80", VA = "0x185333F80", Slot = "13")]
	public override void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5334410", Offset = "0x5333010", VA = "0x185334410", Slot = "15")]
	public override void IFHIDEGOEAJ(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x53347D0", Offset = "0x53333D0", VA = "0x1853347D0", Slot = "14")]
	protected override void LPIFGEKCIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5334790", Offset = "0x5333390", VA = "0x185334790")]
	private HLCKICOEKGN LBOKEJFJOCP(AGIGAFJFFKN.CPOGHHGJJHJ BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x53348B0", Offset = "0x53334B0", VA = "0x1853348B0", Slot = "16")]
	internal override IPHGJFLHKOE NKIHMJFDDMA(IEnumerator<LGOBDJKCLEL> AFIOECAKMCA, Behaviour EDPENIGJGLF, ILAAKECGBDP NMLBIEFPGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5334720", Offset = "0x5333320", VA = "0x185334720", Slot = "17")]
	internal override IEOAOMCMNEM JABAOKFEPJN(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x53345F0", Offset = "0x53331F0", VA = "0x1853345F0")]
	private void IGCOBGMAFLG(HLCKICOEKGN AKMODECIOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5333F10", Offset = "0x5332B10", VA = "0x185333F10", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class NNDEOACODNN : GOFKDIOBLPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly EABLLNECEBB BAPOCPBOGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly PBLCKBAIGPC CONMNDPHEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly IGBFBJPBAJO FDHILCCHGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private IEOAOMCMNEM[] JNDLBHICODP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static GOFKDIOBLPL EBMHMHOHCNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5338AC0", Offset = "0x53376C0", VA = "0x185338AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool MKNOGDLMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AGIGAFJFFKN.CPOGHHGJJHJ GODBFADIHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AGIGAFJFFKN.CPOGHHGJJHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696B30", VA = "0x180697F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PBLCKBAIGPC HBFCGMJPDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5338DA0", Offset = "0x53379A0", VA = "0x185338DA0")]
	public static LOGJIJEEBDN OFPADCBODKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5338E40", Offset = "0x5337A40", VA = "0x185338E40")]
	[Preserve]
	protected NNDEOACODNN([MAEEAOEDELI(null)] EABLLNECEBB BAPOCPBOGOO, [MAEEAOEDELI(null)] PBLCKBAIGPC CONMNDPHEEJ, [MAEEAOEDELI(null)] IGBFBJPBAJO FDHILCCHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5338290", Offset = "0x5336E90", VA = "0x185338290", Slot = "6")]
	public LOGJIJEEBDN BLFPKNOMADF(IEnumerator<LGOBDJKCLEL> AFIOECAKMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5338060", Offset = "0x5336C60", VA = "0x185338060", Slot = "7")]
	public LOGJIJEEBDN BLFPKNOMADF(Behaviour EDPENIGJGLF, IEnumerator<LGOBDJKCLEL> AFIOECAKMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract LOGJIJEEBDN ICDAKAEKLHE(PMNJCJEPGMK EDPENIGJGLF, IEnumerator<LGOBDJKCLEL> AFIOECAKMCA);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5338680", Offset = "0x5337280", VA = "0x185338680", Slot = "13")]
	public virtual void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5338B10", Offset = "0x5337710", VA = "0x185338B10", Slot = "9")]
	public void KGBLEECBKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5338D60", Offset = "0x5337960", VA = "0x185338D60", Slot = "14")]
	protected virtual void LPIFGEKCIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x53382A0", Offset = "0x5336EA0", VA = "0x1853382A0")]
	private void CACGAHDKIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5338860", Offset = "0x5337460", VA = "0x185338860")]
	private void GACCGONGCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5338040", Offset = "0x5336C40", VA = "0x185338040")]
	private void ALNCNIFJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5338B70", Offset = "0x5337770", VA = "0x185338B70")]
	private void KJGPIOGKJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5338D80", Offset = "0x5337980", VA = "0x185338D80")]
	private void MJMMFABHMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x53382C0", Offset = "0x5336EC0", VA = "0x1853382C0")]
	private void CFMAOEOKKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5338660", Offset = "0x5337260", VA = "0x185338660")]
	private void EIIMJIMBPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5338880", Offset = "0x5337480", VA = "0x185338880", Slot = "15")]
	public virtual void IFHIDEGOEAJ(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5338B90", Offset = "0x5337790", VA = "0x185338B90")]
	private void LOMBCMKMAMN(IEOAOMCMNEM AKMODECIOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xC42D90", Offset = "0xC41990", VA = "0x180C42D90")]
	private IEOAOMCMNEM DBPLOMDAAFE(AGIGAFJFFKN.CPOGHHGJJHJ BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract IPHGJFLHKOE NKIHMJFDDMA(IEnumerator<LGOBDJKCLEL> AFIOECAKMCA, Behaviour CACIHNMLHAH, ILAAKECGBDP LFMHAGGOOLF);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract IEOAOMCMNEM JABAOKFEPJN(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x53382E0", Offset = "0x5336EE0", VA = "0x1853382E0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class IPHGJFLHKOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly ILAAKECGBDP NMLBIEFPGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly JAKMHNKCPDA EDPENIGJGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool GGJMNLINIFL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<LGOBDJKCLEL> BCHCIDMOGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695D30", VA = "0x180697130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LGOBDJKCLEL KPHPMIENNCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x697140", Offset = "0x695D40", VA = "0x180697140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LDKIIKFEPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5333340", Offset = "0x5331F40", VA = "0x185333340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool BDICJEADIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8732B0", Offset = "0x871EB0", VA = "0x1808732B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8126F0", Offset = "0x8112F0", VA = "0x1808126F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67D190", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float JONDBMKOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1315890", Offset = "0x1314490", VA = "0x181315890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x13157E0", Offset = "0x13143E0", VA = "0x1813157E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x53334F0", Offset = "0x53320F0", VA = "0x1853334F0")]
	public IPHGJFLHKOE(IEnumerator<LGOBDJKCLEL> MMAPPEJOCAD, JAKMHNKCPDA EDPENIGJGLF, ILAAKECGBDP NMLBIEFPGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5333080", Offset = "0x5331C80", VA = "0x185333080")]
	public LGOBDJKCLEL JLKLKBHFDMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x53333C0", Offset = "0x5331FC0", VA = "0x1853333C0")]
	public bool OCPIJIDEKLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5333000", Offset = "0x5331C00", VA = "0x185333000")]
	public void CIAEBEDAGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5333430", Offset = "0x5332030", VA = "0x185333430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x19BC590", Offset = "0x19BB190", VA = "0x1819BC590")]
	[CompilerGenerated]
	private void IMICDJOKDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class ILAAKECGBDP : GNOBGLLFLAG, LOGJIJEEBDN, ALDLEBFHJGM, FKDPJJAEIFK, IEnumerator, LGOBDJKCLEL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private AGIGAFJFFKN.CPOGHHGJJHJ IGCMJJCFKNN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private AGIGAFJFFKN.CPOGHHGJJHJ NJENPPDABPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x71B510", Offset = "0x71A110", VA = "0x18071B510", Slot = "23")]
		get
		{
			return default(AGIGAFJFFKN.CPOGHHGJJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AGIGAFJFFKN.CPOGHHGJJHJ GBANOMNCDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x81CB40", Offset = "0x81B740", VA = "0x18081CB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float HMBBEDPCMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x11684C0", Offset = "0x11670C0", VA = "0x1811684C0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5332140", Offset = "0x5330D40", VA = "0x185332140", Slot = "24")]
	private bool LBNHPJDKFHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5332130", Offset = "0x5330D30", VA = "0x185332130", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5332160", Offset = "0x5330D60", VA = "0x185332160")]
	public ILAAKECGBDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum EDFOJIMBGIM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class IEOAOMCMNEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum MNPAAHEGILB
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct DDBJDIDNPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AGIGAFJFFKN.CPOGHHGJJHJ CIGBFOMNDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public MNPAAHEGILB MPFMJDJBDNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<IPHGJFLHKOE> IEIADIDEBLF;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly MNPAAHEGILB[] KJKEIMCMHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool FGBBKBFLMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly IPHGJFLHKOE[] MMOKPNJPPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<IPHGJFLHKOE> KDMENNHMBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> JOCMOJPKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<IPHGJFLHKOE> NHEFADNPAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> FCPFMMCBMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly FBBIDIDHOLE LHBBBFAPPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool NLNBKNPOLLJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DDBJDIDNPJI[,] HAKOEGHPADM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675CD0", VA = "0x1806770D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5331750", Offset = "0x5330350", VA = "0x185331750")]
	public IEOAOMCMNEM(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, FBBIDIDHOLE LHBBBFAPPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5330CF0", Offset = "0x532F8F0", VA = "0x185330CF0")]
	public void JDPHIBAGAHH(IPHGJFLHKOE MMAPPEJOCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5330920", Offset = "0x532F520", VA = "0x185330920")]
	public void EPHDNMGJCBI(IList<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5330390", Offset = "0x532EF90", VA = "0x185330390")]
	public void CKNMGGLMPBP(IList<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5330BF0", Offset = "0x532F7F0", VA = "0x185330BF0")]
	private void IDPPAMIHDOA(IPHGJFLHKOE MMAPPEJOCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5330660", Offset = "0x532F260", VA = "0x185330660")]
	private void DMJPFPHDIHK(IList<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5331380", Offset = "0x532FF80", VA = "0x185331380")]
	private EDFOJIMBGIM OGAMELEIMEC(IPHGJFLHKOE MMAPPEJOCAD)
	{
		return default(EDFOJIMBGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5331020", Offset = "0x532FC20", VA = "0x185331020")]
	public void LPIFGEKCIOM(float JMGIEMIHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5330E10", Offset = "0x532FA10", VA = "0x185330E10")]
	public void KGBLEECBKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5331160", Offset = "0x532FD60", VA = "0x185331160")]
	private void NAGPPOEGMJJ(List<IPHGJFLHKOE> APBKNLKFFOC, Stack<int> HCICGOBEEOP, bool EIIOBMJOKEK, float LCPAEHCCHGK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x53307E0", Offset = "0x532F3E0", VA = "0x1853307E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5331520", Offset = "0x5330120", VA = "0x185331520")]
	private void ONFCACMHIOJ(List<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class HDPFKLDONFK : FBBIDIDHOLE
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public void OKJLNBCMJOL(string NLCIGFDKGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
	public void MGMHOCNICIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HDPFKLDONFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class OJLOCEAFCEI : JAKMHNKCPDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour CACIHNMLHAH;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5339870", Offset = "0x5338470", VA = "0x185339870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DNEMJMCMOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5339900", Offset = "0x5338500", VA = "0x185339900", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JABBODADOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5339850", Offset = "0x5338450", VA = "0x185339850", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	public OJLOCEAFCEI(Behaviour CACIHNMLHAH)
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

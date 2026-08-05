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
	[Cpp2IlInjected.Address(RVA = "0x5288970", Offset = "0x5287770", VA = "0x185288970")]
	public MHNGKFLBHPH(ThreadPriority BHOEIGICFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5288960", Offset = "0x5287760", VA = "0x185288960", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5287A00", Offset = "0x5286800", VA = "0x185287A00")]
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
				[Cpp2IlInjected.Address(RVA = "0x5287820", Offset = "0x5286620", VA = "0x185287820")]
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
				[Cpp2IlInjected.Address(RVA = "0x527F090", Offset = "0x527DE90", VA = "0x18527F090")]
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
				[Cpp2IlInjected.Address(RVA = "0x5287D70", Offset = "0x5286B70", VA = "0x185287D70")]
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
				[Cpp2IlInjected.Address(RVA = "0x5289950", Offset = "0x5288750", VA = "0x185289950")]
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
				[Cpp2IlInjected.Address(RVA = "0x52896C0", Offset = "0x52884C0", VA = "0x1852896C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5275E20", Offset = "0x5274C20", VA = "0x185275E20")]
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
				[Cpp2IlInjected.Address(RVA = "0x527D010", Offset = "0x527BE10", VA = "0x18527D010")]
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
				[Cpp2IlInjected.Address(RVA = "0x5276000", Offset = "0x5274E00", VA = "0x185276000")]
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
				[Cpp2IlInjected.Address(RVA = "0x5275120", Offset = "0x5273F20", VA = "0x185275120")]
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
				[Cpp2IlInjected.Address(RVA = "0x5275C40", Offset = "0x5274A40", VA = "0x185275C40")]
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
					[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
					public PBAFLLPMOCB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x528BDF0", Offset = "0x528ABF0", VA = "0x18528BDF0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable GKKIDIIPMEJ;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x52764A0", Offset = "0x52752A0", VA = "0x1852764A0")]
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
					[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
					public GNJJGPGOCDE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x527F330", Offset = "0x527E130", VA = "0x18527F330")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x528BCC0", Offset = "0x528AAC0", VA = "0x18528BCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public BFBMAIKFDEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5275300", Offset = "0x5274100", VA = "0x185275300")]
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
			[Cpp2IlInjected.Address(RVA = "0x5276800", Offset = "0x5275600", VA = "0x185276800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5276970", Offset = "0x5275770", VA = "0x185276970")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x52769B0", Offset = "0x52757B0", VA = "0x1852769B0")]
		private static void HIFBBOPOIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5278B80", Offset = "0x5277980", VA = "0x185278B80")]
		private static void IGODEHBPAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5278850", Offset = "0x5277650", VA = "0x185278850")]
		private static void HNBJPHBKBJO(string GIPFCAFIOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x52765D0", Offset = "0x52753D0", VA = "0x1852765D0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5279450", Offset = "0x5278250", VA = "0x185279450")]
		private static void KHNJDAFBJFD(EBLLHHNBFCC.PPCOFMFHCKJ BIMCDHOFDCP, ref PlayerLoopSystem GODGDLHJJPD, Type LEEGHOAFOHP, Type LHNOIPBBOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5279610", Offset = "0x5278410", VA = "0x185279610")]
		private static void OGKPAJPOMFM(ref PlayerLoopSystem GODGDLHJJPD, Type LEEGHOAFOHP, Type LHNOIPBBOOK, GNGDDGPANJB PAIGEGHGIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5276840", Offset = "0x5275640", VA = "0x185276840")]
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
		[Cpp2IlInjected.Address(RVA = "0x52867F0", Offset = "0x52855F0", VA = "0x1852867F0")]
		public JPOFOGFEIJN(PPCOFMFHCKJ GIMIOFODJHN, int CHLKAAMBGIC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5286720", Offset = "0x5285520", VA = "0x185286720")]
		public void JHPGHNGHPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5286790", Offset = "0x5285590", VA = "0x185286790")]
		public void NHNIJMHGNON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5286520", Offset = "0x5285320", VA = "0x185286520")]
		public void EBKCKEICDOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static PPCOFMFHCKJ[] GCOAIEAMCBN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static JPOFOGFEIJN[] GPLCFBKELNI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x527C380", Offset = "0x527B180", VA = "0x18527C380")]
	public static JPOFOGFEIJN CEHHMEIFMHI(PPCOFMFHCKJ BIMCDHOFDCP, int CHLKAAMBGIC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x527C600", Offset = "0x527B400", VA = "0x18527C600")]
	public static JPOFOGFEIJN JAAMKEGNEPG(PPCOFMFHCKJ BIMCDHOFDCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x527C550", Offset = "0x527B350", VA = "0x18527C550")]
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
		[Cpp2IlInjected.Address(RVA = "0x527BDF0", Offset = "0x527ABF0", VA = "0x18527BDF0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x527BE50", Offset = "0x527AC50", VA = "0x18527BE50")]
	public EANGANCLODE(int MOCEKIMCEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x527BC50", Offset = "0x527AA50", VA = "0x18527BC50", Slot = "4")]
	public void BOGIPIDACAM(double FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x527BD80", Offset = "0x527AB80", VA = "0x18527BD80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PFBHMKAFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7EBBD0", Offset = "0x7EA9D0", VA = "0x1807EBBD0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double BCAEAPDLMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7EBC50", Offset = "0x7EAA50", VA = "0x1807EBC50", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double NPAKKKPBMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x704780", Offset = "0x703580", VA = "0x180704780")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EKBPBPMHPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EA8E0", VA = "0x1807EBAE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x527B950", Offset = "0x527A750", VA = "0x18527B950", Slot = "7")]
	public void BOGIPIDACAM(double FIHIOAOIPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x527BA80", Offset = "0x527A880", VA = "0x18527BA80", Slot = "8")]
	public void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x527BAC0", Offset = "0x527A8C0", VA = "0x18527BAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BDCC70", Offset = "0x2BDBA70", VA = "0x182BDCC70")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MHBPOKGCJOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x2BDCCD0", Offset = "0x2BDBAD0", VA = "0x182BDCCD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x259F230", Offset = "0x259E030", VA = "0x18259F230")]
		protected NGPMGGAEJPG(TPromise ODKFFOINEIJ, TMainThreadPromise OGAAKNMEFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCC40", Offset = "0x2BDBA40", VA = "0x182BDCC40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3304BE0", Offset = "0x33039E0", VA = "0x183304BE0")]
		public ECEGBGGJFBD(global::CGDFFALNLAC<T> ODKFFOINEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x33049F0", Offset = "0x33037F0", VA = "0x1833049F0", Slot = "6")]
		protected override void FCBGILKBLKH(global::CGDFFALNLAC<T> ODKFFOINEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3304BB0", Offset = "0x33039B0", VA = "0x183304BB0")]
		[CompilerGenerated]
		private void INLEKAGNMHC(T BMBFIGGJLDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1769D70", Offset = "0x1768B70", VA = "0x181769D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
		public CKBCJKPCOID(Action KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1476B60", Offset = "0x1475960", VA = "0x181476B60", Slot = "5")]
		public void DNAKJMIBDKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<AEDFBHIPANF> KOEOMAMMMGP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2DD6040", Offset = "0x2DD4E40", VA = "0x182DD6040")]
	public static global::CGDFFALNLAC<T> JJKGNPPODBD<T>(this global::CGDFFALNLAC<T> ODKFFOINEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5288570", Offset = "0x5287370", VA = "0x185288570")]
	public static void JJKGNPPODBD(Action KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5F80", Offset = "0x2DD4D80", VA = "0x182DD5F80")]
	private static global::CGDFFALNLAC<T> CPEHKFJDLDG<T>(global::CGDFFALNLAC<T> ODKFFOINEIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5288600", Offset = "0x5287400", VA = "0x185288600")]
	private static void NDJJBGEHDEG(AEDFBHIPANF IGJGLOHNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5288180", Offset = "0x5286F80", VA = "0x185288180")]
	private static void DCOJGNNLJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5288470", Offset = "0x5287270", VA = "0x185288470")]
	private static void JEEGHEKPJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x52880B0", Offset = "0x5286EB0", VA = "0x1852880B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5275BE0", Offset = "0x52749E0", VA = "0x185275BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5283CB0", Offset = "0x5282AB0", VA = "0x185283CB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5284320", Offset = "0x5283120", VA = "0x185284320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x527C080", Offset = "0x527AE80", VA = "0x18527C080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5285670", Offset = "0x5284470", VA = "0x185285670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FA0", Offset = "0x6F4DA0", VA = "0x1806F5FA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public IBBCECOAFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5281E20", Offset = "0x5280C20", VA = "0x185281E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5279BF0", Offset = "0x52789F0", VA = "0x185279BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x527A570", Offset = "0x5279370", VA = "0x18527A570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x527DED0", Offset = "0x527CCD0", VA = "0x18527DED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x527E710", Offset = "0x527D510", VA = "0x18527E710", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public DOIPFAHCKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x527BAF0", Offset = "0x527A8F0", VA = "0x18527BAF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public ANBOOGPEDME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5275040", Offset = "0x5273E40", VA = "0x185275040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5274CE0", Offset = "0x5273AE0", VA = "0x185274CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x52750D0", Offset = "0x5273ED0", VA = "0x1852750D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5275000", Offset = "0x5273E00", VA = "0x185275000", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public OOOHPFPMJLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x528B560", Offset = "0x528A360", VA = "0x18528B560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x528B9B0", Offset = "0x528A7B0", VA = "0x18528B9B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x527AB60", Offset = "0x5279960", VA = "0x18527AB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool FCOGECBNJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x527A970", Offset = "0x5279770", VA = "0x18527A970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool GDNHAGBOJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x527B7D0", Offset = "0x527A5D0", VA = "0x18527B7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KHJFAFOBPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x527AD20", Offset = "0x5279B20", VA = "0x18527AD20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x527B010", Offset = "0x5279E10", VA = "0x18527B010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x527B500", Offset = "0x527A300", VA = "0x18527B500")]
	[ECPMKACBNFP(JMKOAIIKPBP.EnteredEditModeNextFrame, 0)]
	private static void MIPGHHOMFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x527AEB0", Offset = "0x5279CB0", VA = "0x18527AEB0")]
	[AsyncStateMachine(typeof(IMNAOIADKLH))]
	public static Task<Scene> FOJPEBJCGFH(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM = LoadSceneMode.Single, bool IMDFFNIBLHP = false, [Optional] CEJMOEANPLC BDIDLIGCMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x527A5C0", Offset = "0x52793C0", VA = "0x18527A5C0")]
	[AsyncStateMachine(typeof(EBHODFGLNLJ))]
	private static Task ALMHPINAKMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x527B410", Offset = "0x527A210", VA = "0x18527B410")]
	[AsyncStateMachine(typeof(JNBDOEFFALP))]
	private static Task LPMHFODDGOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x527B670", Offset = "0x527A470", VA = "0x18527B670")]
	[AsyncStateMachine(typeof(DDOOLLFDKAE))]
	private static Task<Scene> OOKKECMOMKL(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM, bool IMDFFNIBLHP, CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x527AA20", Offset = "0x5279820", VA = "0x18527AA20")]
	[AsyncStateMachine(typeof(GGIOGKDFGJL))]
	private static Task<Scene> BGIJGPPFOEK(CEJMOEANPLC PDHDLCNGDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x527B110", Offset = "0x5279F10", VA = "0x18527B110")]
	public static global::CGDFFALNLAC<Scene> HNNAAALEHJL(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x527A690", Offset = "0x5279490", VA = "0x18527A690")]
	public static FKDPJJAEIFK ANMHCOFMFBK(string BIHFIHKHIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x527AE20", Offset = "0x5279C20", VA = "0x18527AE20")]
	[IteratorStateMachine(typeof(ANBOOGPEDME))]
	private static IEnumerator<LGOBDJKCLEL> FMKHDHGAKML(string BIHFIHKHIBA, LNEJMGPOKKP CGNDBLJLCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x527B5D0", Offset = "0x527A3D0", VA = "0x18527B5D0")]
	[IteratorStateMachine(typeof(OOOHPFPMJLF))]
	private static IEnumerator<LGOBDJKCLEL> OLNOMHGKFPN(string BIHFIHKHIBA, LoadSceneMode FDGCFCFBADM, global::ENFBMJFPLIK<Scene> CGNDBLJLCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x527B2B0", Offset = "0x527A0B0", VA = "0x18527B2B0")]
	public static bool JDMMDFHECGL(out string LNHDPALMDNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CMJPILMGIDM
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x52763A0", Offset = "0x52751A0", VA = "0x1852763A0")]
	public static IDisposable LMFCNJFOIHP(this PMNJCJEPGMK EDPENIGJGLF, float AHLEDACMFEN, Action<float> IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5276320", Offset = "0x5275120", VA = "0x185276320")]
	public static IDisposable LDLLELDOOON(this PMNJCJEPGMK EDPENIGJGLF, Action<float> IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5276420", Offset = "0x5275220", VA = "0x185276420")]
	public static IDisposable NPCLCFBLMBM(this PMNJCJEPGMK EDPENIGJGLF, Action<float> IPFHHMKILIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FIJKNABMGMG
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x527D270", Offset = "0x527C070", VA = "0x18527D270")]
	public static IDisposable AHLGFKHMAIH(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x527D1F0", Offset = "0x527BFF0", VA = "0x18527D1F0")]
	public static IDisposable AHLGFKHMAIH(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x527D920", Offset = "0x527C720", VA = "0x18527D920")]
	public static IDisposable LPIFGEKCIOM(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x527D2F0", Offset = "0x527C0F0", VA = "0x18527D2F0")]
	public static IDisposable ALNCNIFJAAA(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x527D810", Offset = "0x527C610", VA = "0x18527D810")]
	public static IDisposable KJGPIOGKJKD(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x527D990", Offset = "0x527C790", VA = "0x18527D990")]
	public static IDisposable NKPJCIJBOPO(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x527D670", Offset = "0x527C470", VA = "0x18527D670")]
	public static IDisposable IOKGMGDICKJ(this MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x527D5D0", Offset = "0x527C3D0", VA = "0x18527D5D0")]
	public static IDisposable IEOBFPECPEM(this MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x527D530", Offset = "0x527C330", VA = "0x18527D530")]
	public static IDisposable HMMJCJJIDLN(this MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x527D4A0", Offset = "0x527C2A0", VA = "0x18527D4A0")]
	public static IDisposable EJBHPPIOIIE(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x527D370", Offset = "0x527C170", VA = "0x18527D370")]
	public static IDisposable CAHAIAFFEME(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x527DA10", Offset = "0x527C810", VA = "0x18527DA10")]
	public static IDisposable OBJGJCKLPIG(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x527DAA0", Offset = "0x527C8A0", VA = "0x18527DAA0")]
	public static IDisposable ODLGOAEFMCL(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x527D6F0", Offset = "0x527C4F0", VA = "0x18527D6F0")]
	public static IDisposable KFNBFLCDJMI(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x527D890", Offset = "0x527C690", VA = "0x18527D890")]
	public static IDisposable LEOMGPMPANH(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x527D780", Offset = "0x527C580", VA = "0x18527D780")]
	public static IDisposable KHEPCLMMBDG(this MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x527D400", Offset = "0x527C200", VA = "0x18527D400")]
	public static IDisposable CLIBDIOJGHP(this MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, bool IHMAMIJPBNM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x527DB30", Offset = "0x527C930", VA = "0x18527DB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public AJGCKPPEPFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5274BE0", Offset = "0x52739E0", VA = "0x185274BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5274CA0", Offset = "0x5273AA0", VA = "0x185274CA0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public DPIADKNMFAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x527BB20", Offset = "0x527A920", VA = "0x18527BB20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x527BC10", Offset = "0x527AA10", VA = "0x18527BC10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x52894A0", Offset = "0x52882A0", VA = "0x1852894A0")]
	public static LOGJIJEEBDN AHLGFKHMAIH(Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x52892D0", Offset = "0x52880D0", VA = "0x1852892D0")]
	public static LOGJIJEEBDN AHLGFKHMAIH(Behaviour EDPENIGJGLF, Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5289390", Offset = "0x5288190", VA = "0x185289390")]
	public static LOGJIJEEBDN AHLGFKHMAIH(Behaviour EDPENIGJGLF, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5289640", Offset = "0x5288440", VA = "0x185289640")]
	[IteratorStateMachine(typeof(AJGCKPPEPFK))]
	private static IEnumerator<LGOBDJKCLEL> IDNAABOCAHH(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, Action IPFHHMKILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x52895C0", Offset = "0x52883C0", VA = "0x1852895C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public EBCAHJNPIMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x527BF00", Offset = "0x527AD00", VA = "0x18527BF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x527C040", Offset = "0x527AE40", VA = "0x18527C040", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x528B9F0", Offset = "0x528A7F0", VA = "0x18528B9F0")]
	public static LOGJIJEEBDN AHLGFKHMAIH(MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x528BBB0", Offset = "0x528A9B0", VA = "0x18528BBB0")]
	public static LOGJIJEEBDN JKLGCPGHPJB(PMNJCJEPGMK EDPENIGJGLF, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x528BB00", Offset = "0x528A900", VA = "0x18528BB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public BIPLDPGOOKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5275420", Offset = "0x5274220", VA = "0x185275420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x52754D0", Offset = "0x52742D0", VA = "0x1852754D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5287BE0", Offset = "0x52869E0", VA = "0x185287BE0")]
	[IteratorStateMachine(typeof(BIPLDPGOOKM))]
	private static IEnumerator<LGOBDJKCLEL> GKGHCAMNNNE(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, Func<bool> KLFAJEFIDKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5287C60", Offset = "0x5286A60", VA = "0x185287C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public EPBLLKJFHMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x527CF10", Offset = "0x527BD10", VA = "0x18527CF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x527CFD0", Offset = "0x527BDD0", VA = "0x18527CFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5288EA0", Offset = "0x5287CA0", VA = "0x185288EA0")]
	[IteratorStateMachine(typeof(EPBLLKJFHMO))]
	private static IEnumerator<LGOBDJKCLEL> MFDEPGKDKIJ(float KGGLLCMFPGN, AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5288A10", Offset = "0x5287810", VA = "0x185288A10")]
	public static LOGJIJEEBDN CIGCBFKBNLA(this MonoBehaviour CACIHNMLHAH, float KGGLLCMFPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5288CA0", Offset = "0x5287AA0", VA = "0x185288CA0")]
	public static LOGJIJEEBDN JMJFFIAJHFO(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5288C70", Offset = "0x5287A70", VA = "0x185288C70")]
	public static LOGJIJEEBDN ICJJNEJANMD(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5288DC0", Offset = "0x5287BC0", VA = "0x185288DC0")]
	public static LOGJIJEEBDN MCOOLGECADC(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x52889B0", Offset = "0x52877B0", VA = "0x1852889B0")]
	public static LOGJIJEEBDN AFBLAEPAHOE(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x52889E0", Offset = "0x52877E0", VA = "0x1852889E0")]
	public static LOGJIJEEBDN BEPGLJKLOAG(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5288CC0", Offset = "0x5287AC0", VA = "0x185288CC0")]
	public static LOGJIJEEBDN LEKNECGILNK(this MonoBehaviour CACIHNMLHAH, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5288AD0", Offset = "0x52878D0", VA = "0x185288AD0")]
	private static LOGJIJEEBDN FKCKCDEJLAM(MonoBehaviour CACIHNMLHAH, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, Action FEADACHODCB, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5288F30", Offset = "0x5287D30", VA = "0x185288F30")]
	public static LOGJIJEEBDN NEJOOAECFFI(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5289000", Offset = "0x5287E00", VA = "0x185289000")]
	public static LOGJIJEEBDN OAONFCDNKCO(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5288CF0", Offset = "0x5287AF0", VA = "0x185288CF0")]
	public static LOGJIJEEBDN LGOCHNCJOOF(this MonoBehaviour CACIHNMLHAH, float KGAECJLLEEE, Action FEADACHODCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5288BA0", Offset = "0x52879A0", VA = "0x185288BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x527E890", Offset = "0x527D690", VA = "0x18527E890", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action EPEJOKGMFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x527EDE0", Offset = "0x527DBE0", VA = "0x18527EDE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x527EA50", Offset = "0x527D850", VA = "0x18527EA50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x527EFF0", Offset = "0x527DDF0", VA = "0x18527EFF0")]
	public GJJELJJDOPM([Optional] Action NEHOJJMPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x527E760", Offset = "0x527D560", VA = "0x18527E760")]
	public void ELGBPIMHCCH(CMBFHICPACF OCJDCLKOPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x527EE80", Offset = "0x527DC80", VA = "0x18527EE80")]
	private void MNEPAOKPHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x527EAF0", Offset = "0x527D8F0", VA = "0x18527EAF0", Slot = "7")]
	public bool KOHBNODOOEI(bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x527EB00", Offset = "0x527D900", VA = "0x18527EB00", Slot = "8")]
	public bool KOHBNODOOEI(Action KDJGJCHCIKK, bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x527E9D0", Offset = "0x527D7D0", VA = "0x18527E9D0", Slot = "9")]
	public IEnumerator<CMBFHICPACF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x527E9D0", Offset = "0x527D7D0", VA = "0x18527E9D0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public HKLHMFAAMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x527F270", Offset = "0x527E070", VA = "0x18527F270")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GMNADFCKEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x527F270", Offset = "0x527E070", VA = "0x18527F270")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float MJJJLIIPOGF;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5276220", Offset = "0x5275020", VA = "0x185276220")]
	public MLNLECBGKNI(Behaviour EDPENIGJGLF, float MJJJLIIPOGF, [Optional] Action NEHOJJMPMCD, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x52891D0", Offset = "0x5287FD0", VA = "0x1852891D0", Slot = "9")]
	protected override bool OJFOOEHONCJ(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x52890D0", Offset = "0x5287ED0", VA = "0x1852890D0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public OKPAHDHBGHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x528B450", Offset = "0x528A250", VA = "0x18528B450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x528B520", Offset = "0x528A320", VA = "0x18528B520", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C2B0", Offset = "0x79B0B0", VA = "0x18079C2B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EPEJOKGMFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5275A40", Offset = "0x5274840", VA = "0x185275A40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x52758F0", Offset = "0x52746F0", VA = "0x1852758F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5275AE0", Offset = "0x52748E0", VA = "0x185275AE0")]
	protected BLCGBDKHKNP(Behaviour EDPENIGJGLF, [Optional] Action NEHOJJMPMCD, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x52759E0", Offset = "0x52747E0", VA = "0x1852759E0", Slot = "7")]
	public bool KOHBNODOOEI(bool JOGFOOOHGFG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5275990", Offset = "0x5274790", VA = "0x185275990", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x52758D0", Offset = "0x52746D0", VA = "0x1852758D0")]
	protected void IHCEBFICLBM(Action KDJGJCHCIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x52756D0", Offset = "0x52744D0", VA = "0x1852756D0")]
	protected FKDPJJAEIFK EDIHKKOEOPE(float CINBMJOKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5275610", Offset = "0x5274410", VA = "0x185275610")]
	private void BNHCDAJPFNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5275590", Offset = "0x5274390", VA = "0x185275590")]
	[IteratorStateMachine(typeof(OKPAHDHBGHM))]
	private IEnumerator<LGOBDJKCLEL> ADKCJBMBGDG(float CINBMJOKHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5275690", Offset = "0x5274490", VA = "0x185275690")]
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
	[Cpp2IlInjected.Address(RVA = "0x52854C0", Offset = "0x52842C0", VA = "0x1852854C0")]
	public JHFLHAGHNPP(Behaviour EDPENIGJGLF, float MKMPHEENGMG, int ELBNKHHNAHB, [Optional] Action NEHOJJMPMCD, float EAFLGAGJHHO = 0f, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "9")]
	protected override bool OJFOOEHONCJ(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5285200", Offset = "0x5284000", VA = "0x185285200", Slot = "10")]
	protected override bool NCDEHCLOHFC(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5285430", Offset = "0x5284230", VA = "0x185285430")]
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
	[Cpp2IlInjected.Address(RVA = "0x5276220", Offset = "0x5275020", VA = "0x185276220")]
	public CLHDKHGLABH(Behaviour EDPENIGJGLF, float MJJJLIIPOGF, [Optional] Action NEHOJJMPMCD, [Optional] GOFKDIOBLPL LNMBBJJCJOB, [Optional] PBLCKBAIGPC CONMNDPHEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0", Slot = "9")]
	protected override bool OJFOOEHONCJ(Action KDJGJCHCIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x52761E0", Offset = "0x5274FE0", VA = "0x1852761E0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public DCKPDMAFJFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5279B10", Offset = "0x5278910", VA = "0x185279B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5279BB0", Offset = "0x52789B0", VA = "0x185279BB0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x5284900", Offset = "0x5283700", VA = "0x185284900")]
	public INPMPPGDDOL(PMNJCJEPGMK EDPENIGJGLF, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5284370", Offset = "0x5283170", VA = "0x185284370")]
	private void ANAKLICPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5284520", Offset = "0x5283320", VA = "0x185284520")]
	private void DFIHJDOGGMH(string OMKDGOMBDIM, Action OMIHFECFEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5284890", Offset = "0x5283690", VA = "0x185284890")]
	[IteratorStateMachine(typeof(DCKPDMAFJFA))]
	private IEnumerator<LGOBDJKCLEL> GDGAMNKFINF(Action OMIHFECFEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5284830", Offset = "0x5283630", VA = "0x185284830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5284680", Offset = "0x5283480", VA = "0x185284680")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public MDMKNKNCBBA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5288880", Offset = "0x5287680", VA = "0x185288880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5288920", Offset = "0x5287720", VA = "0x185288920", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x5287180", Offset = "0x5285F80", VA = "0x185287180")]
	public KFDGNINFNIL(MonoBehaviour CACIHNMLHAH, Action IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5287380", Offset = "0x5286180", VA = "0x185287380")]
	public KFDGNINFNIL(MonoBehaviour CACIHNMLHAH, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x52875C0", Offset = "0x52863C0", VA = "0x1852875C0")]
	public KFDGNINFNIL(MonoBehaviour CACIHNMLHAH, float AHLEDACMFEN, Action<float> IPFHHMKILIK, AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK, bool IHMAMIJPBNM = true, [Optional] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x52868F0", Offset = "0x52856F0", VA = "0x1852868F0")]
	private void AHLGFKHMAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5286FD0", Offset = "0x5285DD0", VA = "0x185286FD0")]
	private void PLHIMDCFFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5286A60", Offset = "0x5285860", VA = "0x185286A60")]
	private void ANAKLICPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5286C20", Offset = "0x5285A20", VA = "0x185286C20")]
	private void DFIHJDOGGMH(string OMKDGOMBDIM, Action OMIHFECFEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5286DB0", Offset = "0x5285BB0", VA = "0x185286DB0")]
	[IteratorStateMachine(typeof(MDMKNKNCBBA))]
	private IEnumerator<LGOBDJKCLEL> GDGAMNKFINF(Action OMIHFECFEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5286D50", Offset = "0x5285B50", VA = "0x185286D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5286E20", Offset = "0x5285C20", VA = "0x185286E20")]
	[CompilerGenerated]
	private void GLDEHIHGOCE(string AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5286EB0", Offset = "0x5285CB0", VA = "0x185286EB0")]
	[CompilerGenerated]
	private void JAGJACLCENG(string AENGIJLJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5286F40", Offset = "0x5285D40", VA = "0x185286F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5288000", Offset = "0x5286E00", VA = "0x185288000", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float KONHMGIJNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x52880A0", Offset = "0x5286EA0", VA = "0x1852880A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double LNGCFOHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5288010", Offset = "0x5286E10", VA = "0x185288010", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5288030", Offset = "0x5286E30", VA = "0x185288030")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void FNPDOJFFBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BA0", Offset = "0x6C09A0", VA = "0x1806C1BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x528AE30", Offset = "0x5289C30", VA = "0x18528AE30")]
	public static LGOBDJKCLEL JLKLKBHFDMH(IEnumerator<LGOBDJKCLEL> MMAPPEJOCAD, ILAAKECGBDP NMLBIEFPGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x528AFE0", Offset = "0x5289DE0", VA = "0x18528AFE0")]
	public LGOBDJKCLEL JLKLKBHFDMH(ILAAKECGBDP[] LNLAKFFPLGI, IEnumerator<LGOBDJKCLEL>[] APBKNLKFFOC, LGOBDJKCLEL[] DENIILIAGIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x528AE00", Offset = "0x5289C00", VA = "0x18528AE00")]
	public void HILLCDNMLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x528B200", Offset = "0x528A000", VA = "0x18528B200")]
	public void MHMFAMOJCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x528B0C0", Offset = "0x5289EC0", VA = "0x18528B0C0")]
	public void KCKIAKDKMML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x528AE00", Offset = "0x5289C00", VA = "0x18528AE00")]
	public void CIAEBEDAGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public EHNEAKAOHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x527C7F0", Offset = "0x527B5F0", VA = "0x18527C7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BIPOGBJNCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5275510", Offset = "0x5274310", VA = "0x185275510")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BKADIFIAALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5275550", Offset = "0x5274350", VA = "0x185275550")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public FJIIIFGENMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x527DBC0", Offset = "0x527C9C0", VA = "0x18527DBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x697BC0", Offset = "0x6969C0", VA = "0x180697BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x527FF20", Offset = "0x527ED20", VA = "0x18527FF20")]
	private static int DADCFPPFOAP(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5281820", Offset = "0x5280620", VA = "0x185281820")]
	public HLCKICOEKGN(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5280DC0", Offset = "0x527FBC0", VA = "0x185280DC0")]
	private void JOOAGJICEGG(ref int KLOILOLBHCI, int NMAJBHOILMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5280FB0", Offset = "0x527FDB0", VA = "0x185280FB0")]
	public void MCIHDOCKBEB(PMNJCJEPGMK EDPENIGJGLF, LGOBDJKCLEL OBONFADGGNC, IEnumerator<LGOBDJKCLEL> MMAPPEJOCAD, ILAAKECGBDP NMLBIEFPGAJ, [Optional] OCBKPMALMOF IDMIJLBHPCC, DJMKPHEFCCN OFCPGMIIBHP = DJMKPHEFCCN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x52805D0", Offset = "0x527F3D0", VA = "0x1852805D0")]
	public void ELGAMDPPEBI(IEnumerable<GFNCFMKGLNF> PALKKPGBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x527FA10", Offset = "0x527E810", VA = "0x18527FA10")]
	private GFNCFMKGLNF DABBNOPBIEN(int LFJLCOFFLAB)
	{
		return default(GFNCFMKGLNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x52807C0", Offset = "0x527F5C0", VA = "0x1852807C0")]
	private void HFIEJHNIGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A6E0", Offset = "0x2D994E0", VA = "0x182D9A6E0")]
	private static void LJJHIMOKLGJ<T>(int LFJLCOFFLAB, T[] PENKLAEPAFN, int LBLAPKMJFKP, [Optional] T PBIPOIONKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A6C0", Offset = "0x2D994C0", VA = "0x182D9A6C0")]
	private static void LJJHIMOKLGJ<T>(int LFJLCOFFLAB, NativeArray<T> PENKLAEPAFN, int LBLAPKMJFKP, [Optional] T PBIPOIONKEA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x527F5B0", Offset = "0x527E3B0", VA = "0x18527F5B0")]
	private void BHDFHCKOLBJ(IEnumerable<GFNCFMKGLNF> PALKKPGBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5281130", Offset = "0x527FF30", VA = "0x185281130")]
	private void MOMCDENFGCI(GFNCFMKGLNF HHBDNJOFKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5281200", Offset = "0x5280000", VA = "0x185281200")]
	private EDFOJIMBGIM OJHEBIIADDG(int HKPBLIHEGDE)
	{
		return default(EDFOJIMBGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5281640", Offset = "0x5280440", VA = "0x185281640")]
	public void PABEFPAKHCH(float JMGIEMIHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x52814C0", Offset = "0x52802C0", VA = "0x1852814C0")]
	private void OJMEOFEEGEK(Action LEOEMBMBFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x527F990", Offset = "0x527E790", VA = "0x18527F990")]
	private void CNNKJMADKNG(Action LEOEMBMBFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x527FF50", Offset = "0x527ED50", VA = "0x18527FF50")]
	public void EGHLCLBELDC(float JMGIEMIHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5281540", Offset = "0x5280340", VA = "0x185281540")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x527F860", Offset = "0x527E660", VA = "0x18527F860")]
	public void CIAEBEDAGAM(OCBKPMALMOF MJDOAAJPNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5280C90", Offset = "0x527FA90", VA = "0x185280C90")]
	public void JJDCNDIGJDL(OCBKPMALMOF MJDOAAJPNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5280B60", Offset = "0x527F960", VA = "0x185280B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	public OAEIIBONPLF(Action AFPMFAHAGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x528ACE0", Offset = "0x5289AE0", VA = "0x18528ACE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public OANAFHLOKIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2F0B890", Offset = "0x2F0A690", VA = "0x182F0B890")]
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
		[Cpp2IlInjected.Address(RVA = "0x726EF0", Offset = "0x725CF0", VA = "0x180726EF0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3119DA0", Offset = "0x3118BA0", VA = "0x183119DA0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3119E00", Offset = "0x3118C00", VA = "0x183119E00")]
	private static bool DFNKPADHOAL(T LEOEMBMBFBC, T GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x311A8D0", Offset = "0x31196D0", VA = "0x18311A8D0")]
	public JEEMOIFFBDC(T KBCACIBDIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x311A6C0", Offset = "0x31194C0", VA = "0x18311A6C0", Slot = "6")]
	public IDisposable NMBJBBJCOAJ(UnityEngine.Object EDPENIGJGLF, Action<T> HLMNGIBMFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x311A1F0", Offset = "0x3118FF0", VA = "0x18311A1F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5279A00", Offset = "0x5278800", VA = "0x185279A00")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void FNPDOJFFBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	[Preserve]
	internal DBGHGABEDKB([MAEEAOEDELI(null)] GOFKDIOBLPL LNMBBJJCJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5279A70", Offset = "0x5278870", VA = "0x185279A70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5283A20", Offset = "0x5282820", VA = "0x185283A20")]
	public static IJNKAFLFHNK GLBIKEOEKPG(int LMGMIPEFJPA, float JMGIEMIHBGG, NativeArray<DJMKPHEFCCN> EPFELDHKEPO, NativeArray<float> JJGEPFCPCBK, NativeArray<int> OHPABMFJOIP, NativeArray<int> PNOBJEIEPJC, NativeArray<int> KAHKHIDGDPP, NativeArray<int> CDCPOEEKBHP, NativeArray<int> MBAKLBOJGGJ)
	{
		return default(IJNKAFLFHNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5283940", Offset = "0x5282740", VA = "0x185283940", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5283BB0", Offset = "0x52829B0", VA = "0x185283BB0")]
	private bool JIJOLHGLJAB(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5283BF0", Offset = "0x52829F0", VA = "0x185283BF0")]
	private void PJIHBPNNCGH(NativeArray<int> ANNPKHOCPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5283A80", Offset = "0x5282880", VA = "0x185283A80")]
	private int IJDMBOEDCNJ(int NFDJKLDKEFF, int GHFMKLAAOKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5283AE0", Offset = "0x52828E0", VA = "0x185283AE0")]
	private void IPKMLKKNAPO(NativeArray<int> ANNPKHOCPIN, int CNDLJBCLDMB, int PHOLGHPIFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5283710", Offset = "0x5282510", VA = "0x185283710")]
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
	[Cpp2IlInjected.Address(RVA = "0x5285D50", Offset = "0x5284B50", VA = "0x185285D50")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	private static void FNPDOJFFBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5286450", Offset = "0x5285250", VA = "0x185286450")]
	[Preserve]
	public JOKPBGLAHBN([MAEEAOEDELI(null)] EABLLNECEBB BAPOCPBOGOO, [MAEEAOEDELI(null)] PBLCKBAIGPC CONMNDPHEEJ, [MAEEAOEDELI(null)] IGBFBJPBAJO FDHILCCHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5285DC0", Offset = "0x5284BC0", VA = "0x185285DC0", Slot = "12")]
	public override LOGJIJEEBDN ICDAKAEKLHE(PMNJCJEPGMK EDPENIGJGLF, IEnumerator<LGOBDJKCLEL> AFIOECAKMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5285A70", Offset = "0x5284870", VA = "0x185285A70", Slot = "13")]
	public override void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5285F00", Offset = "0x5284D00", VA = "0x185285F00", Slot = "15")]
	public override void IFHIDEGOEAJ(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x52862C0", Offset = "0x52850C0", VA = "0x1852862C0", Slot = "14")]
	protected override void LPIFGEKCIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5286280", Offset = "0x5285080", VA = "0x185286280")]
	private HLCKICOEKGN LBOKEJFJOCP(AGIGAFJFFKN.CPOGHHGJJHJ BIEGICDMJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x52863A0", Offset = "0x52851A0", VA = "0x1852863A0", Slot = "16")]
	internal override IPHGJFLHKOE NKIHMJFDDMA(IEnumerator<LGOBDJKCLEL> AFIOECAKMCA, Behaviour EDPENIGJGLF, ILAAKECGBDP NMLBIEFPGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5286210", Offset = "0x5285010", VA = "0x185286210", Slot = "17")]
	internal override IEOAOMCMNEM JABAOKFEPJN(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x52860E0", Offset = "0x5284EE0", VA = "0x1852860E0")]
	private void IGCOBGMAFLG(HLCKICOEKGN AKMODECIOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5285A00", Offset = "0x5284800", VA = "0x185285A00", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x528A5B0", Offset = "0x52893B0", VA = "0x18528A5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool MKNOGDLMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AGIGAFJFFKN.CPOGHHGJJHJ GODBFADIHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AGIGAFJFFKN.CPOGHHGJJHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BA0", Offset = "0x6C09A0", VA = "0x1806C1BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PBLCKBAIGPC HBFCGMJPDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x528A890", Offset = "0x5289690", VA = "0x18528A890")]
	public static LOGJIJEEBDN OFPADCBODKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x528A930", Offset = "0x5289730", VA = "0x18528A930")]
	[Preserve]
	protected NNDEOACODNN([MAEEAOEDELI(null)] EABLLNECEBB BAPOCPBOGOO, [MAEEAOEDELI(null)] PBLCKBAIGPC CONMNDPHEEJ, [MAEEAOEDELI(null)] IGBFBJPBAJO FDHILCCHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5289D80", Offset = "0x5288B80", VA = "0x185289D80", Slot = "6")]
	public LOGJIJEEBDN BLFPKNOMADF(IEnumerator<LGOBDJKCLEL> AFIOECAKMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5289B50", Offset = "0x5288950", VA = "0x185289B50", Slot = "7")]
	public LOGJIJEEBDN BLFPKNOMADF(Behaviour EDPENIGJGLF, IEnumerator<LGOBDJKCLEL> AFIOECAKMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract LOGJIJEEBDN ICDAKAEKLHE(PMNJCJEPGMK EDPENIGJGLF, IEnumerator<LGOBDJKCLEL> AFIOECAKMCA);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x528A170", Offset = "0x5288F70", VA = "0x18528A170", Slot = "13")]
	public virtual void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x528A600", Offset = "0x5289400", VA = "0x18528A600", Slot = "9")]
	public void KGBLEECBKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x528A850", Offset = "0x5289650", VA = "0x18528A850", Slot = "14")]
	protected virtual void LPIFGEKCIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5289D90", Offset = "0x5288B90", VA = "0x185289D90")]
	private void CACGAHDKIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x528A350", Offset = "0x5289150", VA = "0x18528A350")]
	private void GACCGONGCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5289B30", Offset = "0x5288930", VA = "0x185289B30")]
	private void ALNCNIFJAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x528A660", Offset = "0x5289460", VA = "0x18528A660")]
	private void KJGPIOGKJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x528A870", Offset = "0x5289670", VA = "0x18528A870")]
	private void MJMMFABHMBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5289DB0", Offset = "0x5288BB0", VA = "0x185289DB0")]
	private void CFMAOEOKKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x528A150", Offset = "0x5288F50", VA = "0x18528A150")]
	private void EIIMJIMBPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x528A370", Offset = "0x5289170", VA = "0x18528A370", Slot = "15")]
	public virtual void IFHIDEGOEAJ(AGIGAFJFFKN.CPOGHHGJJHJ GDAJCKODMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x528A680", Offset = "0x5289480", VA = "0x18528A680")]
	private void LOMBCMKMAMN(IEOAOMCMNEM AKMODECIOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x103BFD0", Offset = "0x103ADD0", VA = "0x18103BFD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5289DD0", Offset = "0x5288BD0", VA = "0x185289DD0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6507C0", Offset = "0x64F5C0", VA = "0x1806507C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LGOBDJKCLEL KPHPMIENNCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x65A2C0", Offset = "0x6590C0", VA = "0x18065A2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool LDKIIKFEPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5284E30", Offset = "0x5283C30", VA = "0x185284E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool BDICJEADIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AC2B0", Offset = "0x8AB0B0", VA = "0x1808AC2B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AC320", Offset = "0x8AB120", VA = "0x1808AC320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x1806500E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float JONDBMKOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x705F70", Offset = "0x704D70", VA = "0x180705F70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x11533A0", Offset = "0x11521A0", VA = "0x1811533A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5284FE0", Offset = "0x5283DE0", VA = "0x185284FE0")]
	public IPHGJFLHKOE(IEnumerator<LGOBDJKCLEL> MMAPPEJOCAD, JAKMHNKCPDA EDPENIGJGLF, ILAAKECGBDP NMLBIEFPGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5284B70", Offset = "0x5283970", VA = "0x185284B70")]
	public LGOBDJKCLEL JLKLKBHFDMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5284EB0", Offset = "0x5283CB0", VA = "0x185284EB0")]
	public bool OCPIJIDEKLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5284AF0", Offset = "0x52838F0", VA = "0x185284AF0")]
	public void CIAEBEDAGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5284F20", Offset = "0x5283D20", VA = "0x185284F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F1AD10", Offset = "0x1F19B10", VA = "0x181F1AD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EBF70", Offset = "0x6EAD70", VA = "0x1806EBF70", Slot = "23")]
		get
		{
			return default(AGIGAFJFFKN.CPOGHHGJJHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AGIGAFJFFKN.CPOGHHGJJHJ GBANOMNCDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x73A4C0", Offset = "0x7392C0", VA = "0x18073A4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float HMBBEDPCMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7EBB10", Offset = "0x7EA910", VA = "0x1807EBB10", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5283C30", Offset = "0x5282A30", VA = "0x185283C30", Slot = "24")]
	private bool LBNHPJDKFHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5283C20", Offset = "0x5282A20", VA = "0x185283C20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5283C50", Offset = "0x5282A50", VA = "0x185283C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x656280", Offset = "0x655080", VA = "0x180656280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5283240", Offset = "0x5282040", VA = "0x185283240")]
	public IEOAOMCMNEM(AGIGAFJFFKN.CPOGHHGJJHJ HCNMCJADDJL, FBBIDIDHOLE LHBBBFAPPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x52827E0", Offset = "0x52815E0", VA = "0x1852827E0")]
	public void JDPHIBAGAHH(IPHGJFLHKOE MMAPPEJOCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5282410", Offset = "0x5281210", VA = "0x185282410")]
	public void EPHDNMGJCBI(IList<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5281E80", Offset = "0x5280C80", VA = "0x185281E80")]
	public void CKNMGGLMPBP(IList<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x52826E0", Offset = "0x52814E0", VA = "0x1852826E0")]
	private void IDPPAMIHDOA(IPHGJFLHKOE MMAPPEJOCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5282150", Offset = "0x5280F50", VA = "0x185282150")]
	private void DMJPFPHDIHK(IList<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5282E70", Offset = "0x5281C70", VA = "0x185282E70")]
	private EDFOJIMBGIM OGAMELEIMEC(IPHGJFLHKOE MMAPPEJOCAD)
	{
		return default(EDFOJIMBGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5282B10", Offset = "0x5281910", VA = "0x185282B10")]
	public void LPIFGEKCIOM(float JMGIEMIHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5282900", Offset = "0x5281700", VA = "0x185282900")]
	public void KGBLEECBKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5282C50", Offset = "0x5281A50", VA = "0x185282C50")]
	private void NAGPPOEGMJJ(List<IPHGJFLHKOE> APBKNLKFFOC, Stack<int> HCICGOBEEOP, bool EIIOBMJOKEK, float LCPAEHCCHGK = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x52822D0", Offset = "0x52810D0", VA = "0x1852822D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5283010", Offset = "0x5281E10", VA = "0x185283010")]
	private void ONFCACMHIOJ(List<IPHGJFLHKOE> APBKNLKFFOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class HDPFKLDONFK : FBBIDIDHOLE
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	public void OKJLNBCMJOL(string NLCIGFDKGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
	public void MGMHOCNICIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x528B360", Offset = "0x528A160", VA = "0x18528B360", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DNEMJMCMOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x528B3F0", Offset = "0x528A1F0", VA = "0x18528B3F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JABBODADOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x528B340", Offset = "0x528A140", VA = "0x18528B340", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
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

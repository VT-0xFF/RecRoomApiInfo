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
public class CNNLEIJPKJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KHKCBFGCADF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x55FAEF0", Offset = "0x55F96F0", VA = "0x1855FAEF0")]
	public CNNLEIJPKJJ(ThreadPriority GPPMDPCFPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x55FAEE0", Offset = "0x55F96E0", VA = "0x1855FAEE0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> MLLBPOMDFFC(List<PlayerLoopSystem> CPOMNNHFPBO, int CEEIJFPAGLP);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct BCNODKHGGBO
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OFJKPENIDEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static IFEOEDLAFMF OPLOKKBABMM;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x560AA70", Offset = "0x5609270", VA = "0x18560AA70")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct BKCPFEHBGFP
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static IFEOEDLAFMF BDBKADEEFMJ;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x55F8060", Offset = "0x55F6860", VA = "0x1855F8060")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PDEFBFFIDGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static IFEOEDLAFMF AIHAGLPJGBD;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x560B3F0", Offset = "0x5609BF0", VA = "0x18560B3F0")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LJCMHJALLOG
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static IFEOEDLAFMF CJMANKLFMCM;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static IFEOEDLAFMF HPPMODOKOPM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IFEOEDLAFMF MJJKFFGKOBL;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static IFEOEDLAFMF GFJODPPGCPN;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x56083C0", Offset = "0x5606BC0", VA = "0x1856083C0")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GKLIHMLMJAJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IFEOEDLAFMF IIDCENANJFN;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5602040", Offset = "0x5600840", VA = "0x185602040")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct BDGGCBDGOBJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static IFEOEDLAFMF CJMANKLFMCM;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static IFEOEDLAFMF HPPMODOKOPM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static IFEOEDLAFMF MJJKFFGKOBL;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static IFEOEDLAFMF GFJODPPGCPN;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x55F7A30", Offset = "0x55F6230", VA = "0x1855F7A30")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HABDOJBGHFN
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static IFEOEDLAFMF AKALKHBMHCI;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5602550", Offset = "0x5600D50", VA = "0x185602550")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct INNCLMOHILI
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static IFEOEDLAFMF FJMFIHDAHCA;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5604690", Offset = "0x5602E90", VA = "0x185604690")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct MFIIIHOBJPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static IFEOEDLAFMF LNNNIODIEBN;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5608A00", Offset = "0x5607200", VA = "0x185608A00")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct DLDCPDKFLCH
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static IFEOEDLAFMF CCFODMNIIEO;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x55FECC0", Offset = "0x55FD4C0", VA = "0x1855FECC0")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct IHOELAEPBNO
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static IFEOEDLAFMF CBDEBHFGDAH;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5603B40", Offset = "0x5602340", VA = "0x185603B40")]
				public static PlayerLoopSystem DDHOPBPKFEK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct DGFJINDAPFF
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class PIPAFBGLFJB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public OFKFJLAOKMI.HGAICOMBHLB key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
					public PIPAFBGLFJB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x560BC20", Offset = "0x560A420", VA = "0x18560BC20")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable LNAJGIMFEGC;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x55FE360", Offset = "0x55FCB60", VA = "0x1855FE360")]
				public static PlayerLoopSystem OOJGCJKNENK(OFKFJLAOKMI.HGAICOMBHLB NHBANLNJEIH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct DOGGBDOJFDP
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class MCDENHBIJJE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public OFKFJLAOKMI.HGAICOMBHLB key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
					public MCDENHBIJJE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x5608650", Offset = "0x5606E50", VA = "0x185608650")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x55FF7F0", Offset = "0x55FDFF0", VA = "0x1855FF7F0")]
				public static PlayerLoopSystem OOJGCJKNENK(OFKFJLAOKMI.HGAICOMBHLB NHBANLNJEIH)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class MCJLLJGDJOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MCJLLJGDJOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x56088E0", Offset = "0x56070E0", VA = "0x1856088E0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KNCHINJPJKJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool CBAPIGCDKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x55FD040", Offset = "0x55FB840", VA = "0x1855FD040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x55FB160", Offset = "0x55F9960", VA = "0x1855FB160")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x55FB1A0", Offset = "0x55F99A0", VA = "0x1855FB1A0")]
		private static void DGHODKIHLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55FD080", Offset = "0x55FB880", VA = "0x1855FD080")]
		private static void GFIOCNELJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55FE030", Offset = "0x55FC830", VA = "0x1855FE030")]
		private static void PNDEGLFHPGC(string ALBJNLAOBJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x55FAF30", Offset = "0x55F9730", VA = "0x1855FAF30")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55FDD40", Offset = "0x55FC540", VA = "0x1855FDD40")]
		private static void MBEMJJBKIIA(OFKFJLAOKMI.HGAICOMBHLB NHBANLNJEIH, ref PlayerLoopSystem ABIAHPODJOC, Type COBMOIOKNIN, Type GGIHNOOFHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55FD950", Offset = "0x55FC150", VA = "0x1855FD950")]
		private static void LIJNPPIPPEO(ref PlayerLoopSystem ABIAHPODJOC, Type COBMOIOKNIN, Type GGIHNOOFHLH, MLLBPOMDFFC IECMOLCGGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55FDF00", Offset = "0x55FC700", VA = "0x1855FDF00")]
		private static void OJLEJOCCGID(ref PlayerLoopSystem ABIAHPODJOC, Type COBMOIOKNIN, Type GGIHNOOFHLH, PlayerLoopSystem? FPNOBMBDDEM, PlayerLoopSystem? EPOEJJEABMD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OFKFJLAOKMI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum HGAICOMBHLB
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
	public class BCOEBIHKFMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly HGAICOMBHLB KLJOPADMGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CENFMLGOEGO DLOAGLCFKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long JIMOHJNGFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long LMMJLDEONNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long LJCGMGIINAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int PGLEIOHMLKL;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x55F7930", Offset = "0x55F6130", VA = "0x1855F7930")]
		public BCOEBIHKFMF(HGAICOMBHLB FLHAENMIJDB, int NJMCLLIFCMF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x55F78C0", Offset = "0x55F60C0", VA = "0x1855F78C0")]
		public void MFKHODDLFJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x55F7860", Offset = "0x55F6060", VA = "0x1855F7860")]
		public void GBGCCAOBACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x55F7660", Offset = "0x55F5E60", VA = "0x1855F7660")]
		public void DAAJCGAJFDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static HGAICOMBHLB[] BGAKPKLGJMN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static BCOEBIHKFMF[] ILJHLGNGOOK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x560AC50", Offset = "0x5609450", VA = "0x18560AC50")]
	public static BCOEBIHKFMF CBNGDOMOPMJ(HGAICOMBHLB NHBANLNJEIH, int NJMCLLIFCMF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x560AED0", Offset = "0x56096D0", VA = "0x18560AED0")]
	public static BCOEBIHKFMF LFNEMEKMONP(HGAICOMBHLB NHBANLNJEIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x560AE20", Offset = "0x5609620", VA = "0x18560AE20")]
	public static void GCLNOIBIHFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CENFMLGOEGO : CNMCGOJCIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int NCIJKDAKDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> CICLOEOKKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double BPCHPMCLFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double HDHNBDLKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double GBJCKCHBAIC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MDMEBFPNIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55FAB20", Offset = "0x55F9320", VA = "0x1855FAB20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double POBIAGGNGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F7FFF0", Offset = "0x1F7E7F0", VA = "0x181F7FFF0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double DIAPCHAJDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x350C3F0", Offset = "0x350ABF0", VA = "0x18350C3F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55FAD20", Offset = "0x55F9520", VA = "0x1855FAD20")]
	public CENFMLGOEGO(int JBBGEEIPLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55FABF0", Offset = "0x55F93F0", VA = "0x1855FABF0", Slot = "7")]
	public void PHFEHBBCDEF(double EAPKDOJGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55FAB80", Offset = "0x55F9380", VA = "0x1855FAB80", Slot = "8")]
	public void NDKMADGHFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ADBHKKPPPEM : CNMCGOJCIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long FCKFNIPNJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double NNFIEIJCMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double ELFDINCEOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double JFBLLPMMAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double OBIFOGGAFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double BPCHPMCLFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double HDHNBDLKAPM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long EIFLHBHGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double POBIAGGNGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x38C2190", Offset = "0x38C0990", VA = "0x1838C2190", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double DIAPCHAJDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA45E30", Offset = "0xA44630", VA = "0x180A45E30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NLKPACEDIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x350C3E0", Offset = "0x350ABE0", VA = "0x18350C3E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MDMEBFPNIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x38C20C0", Offset = "0x38C08C0", VA = "0x1838C20C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55F4920", Offset = "0x55F3120", VA = "0x1855F4920", Slot = "7")]
	public virtual void PHFEHBBCDEF(double EAPKDOJGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55F48E0", Offset = "0x55F30E0", VA = "0x1855F48E0", Slot = "8")]
	public virtual void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55F48B0", Offset = "0x55F30B0", VA = "0x1855F48B0")]
	public ADBHKKPPPEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ABMOJKAPEPE : ADBHKKPPPEM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double EDKDNIODHEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x55F4720", Offset = "0x55F2F20", VA = "0x1855F4720")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x55F4710", Offset = "0x55F2F10", VA = "0x1855F4710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55F4770", Offset = "0x55F2F70", VA = "0x1855F4770", Slot = "7")]
	public override void PHFEHBBCDEF(double EAPKDOJGNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55F4730", Offset = "0x55F2F30", VA = "0x1855F4730", Slot = "8")]
	public override void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55F48B0", Offset = "0x55F30B0", VA = "0x1855F48B0")]
	public ABMOJKAPEPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface CNMCGOJCIPE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double MDMEBFPNIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double POBIAGGNGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double DIAPCHAJDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class BCGCDOMODDD
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private interface FOKDGGAAPNM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool NHGLHDCKMHK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MNPDJHGOCNG();
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private abstract class PMNGILLHIIB<TPromise, TMainThreadPromise> : FOKDGGAAPNM where TPromise : LDGADANDBIO where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly TPromise HFLBBAIJAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly TMainThreadPromise CIIKIJIMHGO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise JKKKGPBHBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x3718300", Offset = "0x3716B00", VA = "0x183718300")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NHGLHDCKMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3718360", Offset = "0x3716B60", VA = "0x183718360", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x25B1330", Offset = "0x25AFB30", VA = "0x1825B1330")]
		protected PMNGILLHIIB(TPromise HFLBBAIJAJL, TMainThreadPromise OIOODKBDAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x37182D0", Offset = "0x3716AD0", VA = "0x1837182D0", Slot = "5")]
		public void MNPDJHGOCNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BHLLCOOCLGF(TPromise HFLBBAIJAJL);
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class AONNBDDDFKH<T> : PMNGILLHIIB<global::FGLDKEJLAKB<T>, global::OGBIEJAIDCG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2EA3470", Offset = "0x2EA1C70", VA = "0x182EA3470")]
		public AONNBDDDFKH(global::FGLDKEJLAKB<T> HFLBBAIJAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2EA3230", Offset = "0x2EA1A30", VA = "0x182EA3230", Slot = "6")]
		protected override void BHLLCOOCLGF(global::FGLDKEJLAKB<T> HFLBBAIJAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2EA3440", Offset = "0x2EA1C40", VA = "0x182EA3440")]
		[CompilerGenerated]
		private void DGJOJKJJKGJ(T KGFIMLECODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x149AAD0", Offset = "0x14992D0", VA = "0x18149AAD0")]
		[CompilerGenerated]
		private void MLOCCOGILHH(string EMPPPODHBFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class OBMBCDHGAII : FOKDGGAAPNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Action BEHJPKINPFB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NHGLHDCKMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
		public OBMBCDHGAII(Action BEHJPKINPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x10BBF50", Offset = "0x10BA750", VA = "0x1810BBF50", Slot = "5")]
		public void MNPDJHGOCNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<FOKDGGAAPNM> KFEKFGDFAGK;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23DD0B0", Offset = "0x23DB8B0", VA = "0x1823DD0B0")]
	public static global::FGLDKEJLAKB<T> DMPCPLKEJDC<T>(this global::FGLDKEJLAKB<T> HFLBBAIJAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55F6E90", Offset = "0x55F5690", VA = "0x1855F6E90")]
	public static void DMPCPLKEJDC(Action BEHJPKINPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x23DD120", Offset = "0x23DB920", VA = "0x1823DD120")]
	private static global::FGLDKEJLAKB<T> MOODOLPANML<T>(global::FGLDKEJLAKB<T> HFLBBAIJAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55F70F0", Offset = "0x55F58F0", VA = "0x1855F70F0")]
	private static void LCLMDEENLFH(FOKDGGAAPNM EEGKGPIHLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55F72F0", Offset = "0x55F5AF0", VA = "0x1855F72F0")]
	private static void NOJJDMAKIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55F6FF0", Offset = "0x55F57F0", VA = "0x1855F6FF0")]
	private static void KGEPDELKOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55F6F20", Offset = "0x55F5720", VA = "0x1855F6F20")]
	private static void FGJEAKFFLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class EPEAADEOIDK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private struct GKPHFAMFFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> EJLDCFJKNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string DLIOPMAIDMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode IJIBAHPBKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool MDCMJOHHGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly NFFBCAHKINE EEEJJBAEBPN;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5602220", Offset = "0x5600A20", VA = "0x185602220")]
		public GKPHFAMFFGI(TaskCompletionSource<Scene> MEHGOGHLHOM, string DLIOPMAIDMI, LoadSceneMode IJIBAHPBKFM, bool MDCMJOHHGHC, NFFBCAHKINE EEEJJBAEBPN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct HKBOHBPEGOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NFFBCAHKINE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private global::IDCECOPBNKH<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5603250", Offset = "0x5601A50", VA = "0x185603250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56038C0", Offset = "0x56020C0", VA = "0x1856038C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct FKELDMFPGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5601290", Offset = "0x55FFA90", VA = "0x185601290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct OCDAPCMLNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GKPHFAMFFGI <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x560A6E0", Offset = "0x5608EE0", VA = "0x18560A6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DD320", Offset = "0x6DBB20", VA = "0x1806DD320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class NJODHGEJHKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::OGBIEJAIDCG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public NJODHGEJHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x560A080", Offset = "0x5608880", VA = "0x18560A080")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct CACKDIJFMKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NFFBCAHKINE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private NJODHGEJHKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private NFFBCAHKINE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private NFFBCAHKINE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55F8240", Offset = "0x55F6A40", VA = "0x1855F8240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x55F8BC0", Offset = "0x55F73C0", VA = "0x1855F8BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct INAKJPBHBLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NFFBCAHKINE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private NFFBCAHKINE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NFFBCAHKINE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5603E00", Offset = "0x5602600", VA = "0x185603E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5604640", Offset = "0x5602E40", VA = "0x185604640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IFLHPLNAACD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IFLHPLNAACD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5603B10", Offset = "0x5602310", VA = "0x185603B10")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EIFEKJKPGMO : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public MAMJDBJDFAF onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public EIFEKJKPGMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x55FFC80", Offset = "0x55FE480", VA = "0x1855FFC80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55FF920", Offset = "0x55FE120", VA = "0x1855FF920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55FFD10", Offset = "0x55FE510", VA = "0x1855FFD10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x55FFC40", Offset = "0x55FE440", VA = "0x1855FFC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GPOALKCLLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::OGBIEJAIDCG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GPOALKCLLJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class GGFKOGDDBGB : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::OGBIEJAIDCG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private GPOALKCLLJJ <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public GGFKOGDDBGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5601B70", Offset = "0x5600370", VA = "0x185601B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5601FC0", Offset = "0x56007C0", VA = "0x185601FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static LDGADANDBIO DOFDDGJLJFC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AsyncOperation BGOPKPFLDCA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static LDGADANDBIO CMAKMCCJEMK;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static string IPAKKMLOIEB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ThreadPriority LEEJMHMJEHM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Task MHPCHLONMBG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<GKPHFAMFFGI> ICBGCAHMJKN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task HLHAHHCCGKF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool BGENAEOOPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5600E20", Offset = "0x55FF620", VA = "0x185600E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool BFAIPNEOBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56008B0", Offset = "0x55FF0B0", VA = "0x1856008B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HGKHGOBHIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5601080", Offset = "0x55FF880", VA = "0x185601080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> PNEEJEEFBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x55FFFD0", Offset = "0x55FE7D0", VA = "0x1855FFFD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5600230", Offset = "0x55FEA30", VA = "0x185600230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5600960", Offset = "0x55FF160", VA = "0x185600960")]
	[GHKHCFMPNPN(HCEJJADFNPJ.EnteredEditModeNextFrame, 0)]
	private static void NADHDLIPDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55FFE70", Offset = "0x55FE670", VA = "0x1855FFE70")]
	[AsyncStateMachine(typeof(HKBOHBPEGOP))]
	public static Task<Scene> DIMMAMIHJOE(string DLIOPMAIDMI, LoadSceneMode IJIBAHPBKFM = LoadSceneMode.Single, bool MDCMJOHHGHC = false, [Optional] NFFBCAHKINE MPNGGAAMNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x56000D0", Offset = "0x55FE8D0", VA = "0x1856000D0")]
	[AsyncStateMachine(typeof(FKELDMFPGAP))]
	private static Task FCABEONNNOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5600BD0", Offset = "0x55FF3D0", VA = "0x185600BD0")]
	[AsyncStateMachine(typeof(OCDAPCMLNDO))]
	private static Task ODNPNHEHBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5600330", Offset = "0x55FEB30", VA = "0x185600330")]
	[AsyncStateMachine(typeof(CACKDIJFMKH))]
	private static Task<Scene> JCJKEOHCNAK(string DLIOPMAIDMI, LoadSceneMode IJIBAHPBKFM, bool MDCMJOHHGHC, NFFBCAHKINE EEEJJBAEBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5600490", Offset = "0x55FEC90", VA = "0x185600490")]
	[AsyncStateMachine(typeof(INAKJPBHBLJ))]
	private static Task<Scene> KMGNPNMLNKK(NFFBCAHKINE EEEJJBAEBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5600A30", Offset = "0x55FF230", VA = "0x185600A30")]
	public static global::FGLDKEJLAKB<Scene> NDOBKEJPBPH(string DLIOPMAIDMI, LoadSceneMode IJIBAHPBKFM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56005D0", Offset = "0x55FEDD0", VA = "0x1856005D0")]
	public static LDGADANDBIO LFDGACKHCII(string DLIOPMAIDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x56001A0", Offset = "0x55FE9A0", VA = "0x1856001A0")]
	[IteratorStateMachine(typeof(EIFEKJKPGMO))]
	private static IEnumerator<MBIPJOOACNE> GBFPAPGEDGH(string DLIOPMAIDMI, MAMJDBJDFAF ABAHGMNBPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5600FE0", Offset = "0x55FF7E0", VA = "0x185600FE0")]
	[IteratorStateMachine(typeof(GGFKOGDDBGB))]
	private static IEnumerator<MBIPJOOACNE> OMNHEJLAFHK(string DLIOPMAIDMI, LoadSceneMode IJIBAHPBKFM, global::OGBIEJAIDCG<Scene> ABAHGMNBPKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5600CC0", Offset = "0x55FF4C0", VA = "0x185600CC0")]
	public static bool OHLAKHMNEDJ(out string JPPJHODCMIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BHLIJBGLMLI
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x55F7EE0", Offset = "0x55F66E0", VA = "0x1855F7EE0")]
	public static IDisposable FDHLMOHGDMN(this EELELJHIFAH CDBJCAAPIOD, float IKLANOEMCIC, Action<float> CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x55F7F60", Offset = "0x55F6760", VA = "0x1855F7F60")]
	public static IDisposable KHGAHJAMGEK(this EELELJHIFAH CDBJCAAPIOD, Action<float> CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x55F7FE0", Offset = "0x55F67E0", VA = "0x1855F7FE0")]
	public static IDisposable LKPNOGBILCP(this EELELJHIFAH CDBJCAAPIOD, Action<float> CKDDIDABPBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ANPBFBJMNOF
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x55F5C60", Offset = "0x55F4460", VA = "0x1855F5C60")]
	public static IDisposable PCHKFEDAGHL(this MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x55F5BE0", Offset = "0x55F43E0", VA = "0x1855F5BE0")]
	public static IDisposable PCHKFEDAGHL(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x55F55B0", Offset = "0x55F3DB0", VA = "0x1855F55B0")]
	public static IDisposable CEKLEBHDAHA(this MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x55F56A0", Offset = "0x55F3EA0", VA = "0x1855F56A0")]
	public static IDisposable DADOMEAMFHA(this MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x55F54A0", Offset = "0x55F3CA0", VA = "0x1855F54A0")]
	public static IDisposable BLEGBBMBOFL(this MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55F5990", Offset = "0x55F4190", VA = "0x1855F5990")]
	public static IDisposable JFFGCFNBONB(this MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55F5620", Offset = "0x55F3E20", VA = "0x1855F5620")]
	public static IDisposable CEMJKAMHCFL(this MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55F52E0", Offset = "0x55F3AE0", VA = "0x1855F52E0")]
	public static IDisposable AGBKNOPIEEO(this MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55F5840", Offset = "0x55F4040", VA = "0x1855F5840")]
	public static IDisposable FAJPCJGHKBD(this MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55F5B40", Offset = "0x55F4340", VA = "0x1855F5B40")]
	public static IDisposable OKNOJHFDIFO(this MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55F5520", Offset = "0x55F3D20", VA = "0x1855F5520")]
	public static IDisposable BNCMIGHKEMM(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55F5870", Offset = "0x55F4070", VA = "0x1855F5870")]
	public static IDisposable FJHBOMBEAPN(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55F5AB0", Offset = "0x55F42B0", VA = "0x1855F5AB0")]
	public static IDisposable NLIKDKELGAC(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55F5380", Offset = "0x55F3B80", VA = "0x1855F5380")]
	public static IDisposable AHDMPOFKGNG(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55F57B0", Offset = "0x55F3FB0", VA = "0x1855F57B0")]
	public static IDisposable EIHGABGOHFI(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x55F5720", Offset = "0x55F3F20", VA = "0x1855F5720")]
	public static IDisposable DKKBAEGBKJL(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x55F5410", Offset = "0x55F3C10", VA = "0x1855F5410")]
	public static IDisposable BBDOJLOGIAC(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55F5A10", Offset = "0x55F4210", VA = "0x1855F5A10")]
	public static IDisposable JFJGLCPHGDO(this MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x55F5900", Offset = "0x55F4100", VA = "0x1855F5900")]
	public static IDisposable IMOGHFAPCAP(this MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class AMLODEJEMIP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DNHLKBIJMFC : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public BHIELCKBJMH.DEBLDMONPBH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private AHLPIKNFEKO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public DNHLKBIJMFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x55FEFE0", Offset = "0x55FD7E0", VA = "0x1855FEFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x55FF0A0", Offset = "0x55FD8A0", VA = "0x1855FF0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class OOAKACLKNFP : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public BHIELCKBJMH.DEBLDMONPBH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private AHLPIKNFEKO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public OOAKACLKNFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x560B1D0", Offset = "0x56099D0", VA = "0x18560B1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x560B2C0", Offset = "0x5609AC0", VA = "0x18560B2C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55F5060", Offset = "0x55F3860", VA = "0x1855F5060")]
	public static BGFJNOHFIGD PCHKFEDAGHL(Action CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55F5220", Offset = "0x55F3A20", VA = "0x1855F5220")]
	public static BGFJNOHFIGD PCHKFEDAGHL(Behaviour CDBJCAAPIOD, Action CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55F5110", Offset = "0x55F3910", VA = "0x1855F5110")]
	public static BGFJNOHFIGD PCHKFEDAGHL(Behaviour CDBJCAAPIOD, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x55F4FE0", Offset = "0x55F37E0", VA = "0x1855F4FE0")]
	[IteratorStateMachine(typeof(DNHLKBIJMFC))]
	private static IEnumerator<MBIPJOOACNE> CJLLNAOBCBC(BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, Action CKDDIDABPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x55F4F60", Offset = "0x55F3760", VA = "0x1855F4F60")]
	[IteratorStateMachine(typeof(OOAKACLKNFP))]
	private static IEnumerator<MBIPJOOACNE> CJLLNAOBCBC(BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, Action<float> CKDDIDABPBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class FNEMGAACCNF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class OBAAMCFNGIP : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public MENCGCFBMMH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public OBAAMCFNGIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x560A600", Offset = "0x5608E00", VA = "0x18560A600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x560A6A0", Offset = "0x5608EA0", VA = "0x18560A6A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5601A70", Offset = "0x5600270", VA = "0x185601A70")]
	public static BGFJNOHFIGD PCHKFEDAGHL(float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5601960", Offset = "0x5600160", VA = "0x185601960")]
	public static BGFJNOHFIGD PCHKFEDAGHL(MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5601840", Offset = "0x5600040", VA = "0x185601840")]
	public static BGFJNOHFIGD MPMKHHCOMJB(MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x56016D0", Offset = "0x55FFED0", VA = "0x1856016D0")]
	public static BGFJNOHFIGD MDFICKOIJPD(EELELJHIFAH CDBJCAAPIOD, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5601590", Offset = "0x55FFD90", VA = "0x185601590")]
	private static IEnumerator<MBIPJOOACNE> CJLLNAOBCBC(IDAAFGAEAOF OBLPLHNBPPP, float IKLANOEMCIC, BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x56017E0", Offset = "0x55FFFE0", VA = "0x1856017E0")]
	private static IEnumerator<MBIPJOOACNE> MLKNCLLIILC(IDAAFGAEAOF OBLPLHNBPPP, float IKLANOEMCIC, BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, Action<float> CKDDIDABPBA, bool JPLPNLMHKMG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5601640", Offset = "0x55FFE40", VA = "0x185601640")]
	[IteratorStateMachine(typeof(OBAAMCFNGIP))]
	private static IEnumerator<MBIPJOOACNE> EDCIDMGDHDG(MENCGCFBMMH ACAFABCAHPF, float IKLANOEMCIC, BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, Action<float> CKDDIDABPBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KLGIFCJEELK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OPAOFNMAMFB : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public BHIELCKBJMH.DEBLDMONPBH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public OPAOFNMAMFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x560B300", Offset = "0x5609B00", VA = "0x18560B300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x560B3B0", Offset = "0x5609BB0", VA = "0x18560B3B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5607BD0", Offset = "0x56063D0", VA = "0x185607BD0")]
	[IteratorStateMachine(typeof(OPAOFNMAMFB))]
	private static IEnumerator<MBIPJOOACNE> PPDFIHKNMID(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, Func<bool> BEPKDGELANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5607AC0", Offset = "0x56062C0", VA = "0x185607AC0")]
	public static BGFJNOHFIGD JBBGCJDGEIO(this MonoBehaviour OBOMOBPDMCG, Func<bool> BEPKDGELANG, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN = BHIELCKBJMH.DEBLDMONPBH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AAFGPIGFLEL
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class BHHGKPJKIMH : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public BHIELCKBJMH.DEBLDMONPBH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public BHHGKPJKIMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x55F7DE0", Offset = "0x55F65E0", VA = "0x1855F7DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x55F7EA0", Offset = "0x55F66A0", VA = "0x1855F7EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x55F4370", Offset = "0x55F2B70", VA = "0x1855F4370")]
	[IteratorStateMachine(typeof(BHHGKPJKIMH))]
	private static IEnumerator<MBIPJOOACNE> CMCBCBFANJB(float GEINLHGIKPG, BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x55F41E0", Offset = "0x55F29E0", VA = "0x1855F41E0")]
	public static BGFJNOHFIGD CCCGBKBEPJF(this MonoBehaviour OBOMOBPDMCG, float GEINLHGIKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x55F3FF0", Offset = "0x55F27F0", VA = "0x1855F3FF0")]
	public static BGFJNOHFIGD AOGILFEJNDI(this MonoBehaviour OBOMOBPDMCG, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55F4610", Offset = "0x55F2E10", VA = "0x1855F4610")]
	public static BGFJNOHFIGD KDKDCHPEJCJ(this MonoBehaviour OBOMOBPDMCG, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x55F44D0", Offset = "0x55F2CD0", VA = "0x1855F44D0")]
	public static BGFJNOHFIGD FEMAABKIANG(this MonoBehaviour OBOMOBPDMCG, Action MBJOEFPNKEP, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55F45B0", Offset = "0x55F2DB0", VA = "0x1855F45B0")]
	public static BGFJNOHFIGD HEIFCJOKOPJ(this MonoBehaviour OBOMOBPDMCG, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x55F45E0", Offset = "0x55F2DE0", VA = "0x1855F45E0")]
	public static BGFJNOHFIGD JMJICDBPIIO(this MonoBehaviour OBOMOBPDMCG, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x55F40E0", Offset = "0x55F28E0", VA = "0x1855F40E0")]
	public static BGFJNOHFIGD BNNOMBDGBPN(this MonoBehaviour OBOMOBPDMCG, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x55F4010", Offset = "0x55F2810", VA = "0x1855F4010")]
	private static BGFJNOHFIGD BJEIKFNPLCE(MonoBehaviour OBOMOBPDMCG, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, Action MBJOEFPNKEP, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x55F4400", Offset = "0x55F2C00", VA = "0x1855F4400")]
	public static BGFJNOHFIGD EKMMIHAJEBJ(this MonoBehaviour OBOMOBPDMCG, float NEKIOEHBOKN, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x55F42A0", Offset = "0x55F2AA0", VA = "0x1855F42A0")]
	public static BGFJNOHFIGD CFGJPJHHPLN(this MonoBehaviour OBOMOBPDMCG, float NEKIOEHBOKN, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55F4110", Offset = "0x55F2910", VA = "0x1855F4110")]
	public static BGFJNOHFIGD CAIFKBNJMPI(this MonoBehaviour OBOMOBPDMCG, float NEKIOEHBOKN, Action MBJOEFPNKEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55F4640", Offset = "0x55F2E40", VA = "0x1855F4640")]
	public static BGFJNOHFIGD LEBIIIHGGCA(this MonoBehaviour OBOMOBPDMCG, float NEKIOEHBOKN, Action MBJOEFPNKEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class KCIPFIKMJPE : DGOKDLEOCFL, IEnumerable<DGOKDLEOCFL>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly List<DGOKDLEOCFL> GPEPOFNDLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool CBEFFDFEHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action FAKMMKJLLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool JBBFKIGKOBB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool CIGAIPHHJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x56078E0", Offset = "0x56060E0", VA = "0x1856078E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HJAEMLONONG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5607230", Offset = "0x5605A30", VA = "0x185607230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5607190", Offset = "0x5605990", VA = "0x185607190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5607A20", Offset = "0x5606220", VA = "0x185607A20")]
	public KCIPFIKMJPE([Optional] Action FAKMMKJLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5607350", Offset = "0x5605B50", VA = "0x185607350")]
	public void LGCDELLOPGJ(DGOKDLEOCFL CPDBNPFPFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5607480", Offset = "0x5605C80", VA = "0x185607480")]
	private void MDIMFMFCNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x56078D0", Offset = "0x56060D0", VA = "0x1856078D0", Slot = "7")]
	public bool OOODJOGJAKM(bool HMGJFCJOMJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x56075F0", Offset = "0x5605DF0", VA = "0x1856075F0", Slot = "8")]
	public bool OOODJOGJAKM(Action BEHJPKINPFB, bool HMGJFCJOMJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x56072D0", Offset = "0x5605AD0", VA = "0x1856072D0", Slot = "9")]
	public IEnumerator<DGOKDLEOCFL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x56072D0", Offset = "0x5605AD0", VA = "0x1856072D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class ICBFBBHEKOM : PEPBAOGCHJG
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HANIHHNHEHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public ICBFBBHEKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public HANIHHNHEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x55FEC90", Offset = "0x55FD490", VA = "0x1855FEC90")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class DHKEJKAKDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public ICBFBBHEKOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public DHKEJKAKDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x55FEC90", Offset = "0x55FD490", VA = "0x1855FEC90")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly float IDKIMDMFILJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55FEEE0", Offset = "0x55FD6E0", VA = "0x1855FEEE0")]
	public ICBFBBHEKOM(Behaviour CDBJCAAPIOD, float IDKIMDMFILJ, [Optional] Action FAKMMKJLLLB, [Optional] FAKBKKNPBOM IPPKJPIDOPE, [Optional] IDAAFGAEAOF OBLPLHNBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5603A10", Offset = "0x5602210", VA = "0x185603A10", Slot = "9")]
	protected override bool OKIIDHBHEAH(Action BEHJPKINPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5603910", Offset = "0x5602110", VA = "0x185603910", Slot = "10")]
	protected override bool GBBGPGLMKCN(Action BEHJPKINPFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DGOKDLEOCFL
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CIGAIPHHJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action HJAEMLONONG;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOODJOGJAKM(bool HMGJFCJOMJC = false);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OOODJOGJAKM(Action BEHJPKINPFB, bool HMGJFCJOMJC = false);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class PEPBAOGCHJG : DGOKDLEOCFL
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EKDNLJBLBOF : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public PEPBAOGCHJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public EKDNLJBLBOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x55FFD60", Offset = "0x55FE560", VA = "0x1855FFD60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x55FFE30", Offset = "0x55FE630", VA = "0x1855FFE30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly Behaviour CDBJCAAPIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Action FAKMMKJLLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private KKCOJBHLCCF EJNNIKKBBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly FAKBKKNPBOM IPPKJPIDOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	protected readonly IDAAFGAEAOF OBLPLHNBPPP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CIGAIPHHJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x726650", Offset = "0x724E50", VA = "0x180726650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HJAEMLONONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x560B6F0", Offset = "0x5609EF0", VA = "0x18560B6F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x560B650", Offset = "0x5609E50", VA = "0x18560B650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x560BB20", Offset = "0x560A320", VA = "0x18560BB20")]
	protected PEPBAOGCHJG(Behaviour CDBJCAAPIOD, [Optional] Action FAKMMKJLLLB, [Optional] FAKBKKNPBOM IPPKJPIDOPE, [Optional] IDAAFGAEAOF OBLPLHNBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x560BAC0", Offset = "0x560A2C0", VA = "0x18560BAC0", Slot = "7")]
	public bool OOODJOGJAKM(bool HMGJFCJOMJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x560BA70", Offset = "0x560A270", VA = "0x18560BA70", Slot = "8")]
	public bool OOODJOGJAKM(Action BEHJPKINPFB, bool HMGJFCJOMJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OKIIDHBHEAH(Action BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GBBGPGLMKCN(Action BEHJPKINPFB);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x560B790", Offset = "0x5609F90", VA = "0x18560B790")]
	protected void GJCHIFOPMDG(Action BEHJPKINPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x560B7B0", Offset = "0x5609FB0", VA = "0x18560B7B0")]
	protected LDGADANDBIO LGPELLDPEKC(float IGHCILDIJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x560B5D0", Offset = "0x5609DD0", VA = "0x18560B5D0")]
	private void ANPIJKJOJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x560B9B0", Offset = "0x560A1B0", VA = "0x18560B9B0")]
	[IteratorStateMachine(typeof(EKDNLJBLBOF))]
	private IEnumerator<MBIPJOOACNE> MHJGFADPBAB(float IGHCILDIJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x560BA30", Offset = "0x560A230", VA = "0x18560BA30")]
	[CompilerGenerated]
	private void NCFEMJJOKHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NLBFHCMHGAF : PEPBAOGCHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly float MBBNJDGFAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly int JJMHAFFMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly float DBGOOGEAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float[] CMKOGHECBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int FPMBJKGGBCA;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x560A3A0", Offset = "0x5608BA0", VA = "0x18560A3A0")]
	public NLBFHCMHGAF(Behaviour CDBJCAAPIOD, float HCEGDPLMEHO, int JJMHAFFMNIL, [Optional] Action FAKMMKJLLLB, float DBGOOGEAHMD = 0f, [Optional] FAKBKKNPBOM IPPKJPIDOPE, [Optional] IDAAFGAEAOF OBLPLHNBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "9")]
	protected override bool OKIIDHBHEAH(Action BEHJPKINPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x560A0E0", Offset = "0x56088E0", VA = "0x18560A0E0", Slot = "10")]
	protected override bool GBBGPGLMKCN(Action BEHJPKINPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x560A310", Offset = "0x5608B10", VA = "0x18560A310")]
	private void NHGEAPCCKJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class DNDDNHFCFHO : PEPBAOGCHJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float IDKIMDMFILJ;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x55FEEE0", Offset = "0x55FD6E0", VA = "0x1855FEEE0")]
	public DNDDNHFCFHO(Behaviour CDBJCAAPIOD, float IDKIMDMFILJ, [Optional] Action FAKMMKJLLLB, [Optional] FAKBKKNPBOM IPPKJPIDOPE, [Optional] IDAAFGAEAOF OBLPLHNBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "9")]
	protected override bool OKIIDHBHEAH(Action BEHJPKINPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55FEEA0", Offset = "0x55FD6A0", VA = "0x1855FEEA0", Slot = "10")]
	protected override bool GBBGPGLMKCN(Action BEHJPKINPFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class KMBMPOGDGOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PJHDPIBIHMD : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public PJHDPIBIHMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x560BE90", Offset = "0x560A690", VA = "0x18560BE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x560BF30", Offset = "0x560A730", VA = "0x18560BF30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private BGFJNOHFIGD CHLLNKKCPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private EELELJHIFAH CDBJCAAPIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Action<float> MIPGMHJKPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float KHFNDCIMPOE;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x56081E0", Offset = "0x56069E0", VA = "0x1856081E0")]
	public KMBMPOGDGOG(EELELJHIFAH CDBJCAAPIOD, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5608030", Offset = "0x5606830", VA = "0x185608030")]
	private void PLIKNBDLBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5607C50", Offset = "0x5606450", VA = "0x185607C50")]
	private void ACAKOAOIAMG(string EMPPPODHBFE, Action KEJHIBFHHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5607E10", Offset = "0x5606610", VA = "0x185607E10")]
	[IteratorStateMachine(typeof(PJHDPIBIHMD))]
	private IEnumerator<MBIPJOOACNE> LPDHNBNCCLB(Action KEJHIBFHHHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5607DB0", Offset = "0x56065B0", VA = "0x185607DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5607E80", Offset = "0x5606680", VA = "0x185607E80")]
	[CompilerGenerated]
	private void LPJMAPIHFGB(string ODBOKKABIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class MPPFHKNDPEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ILHHAIPDHGC : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public ILHHAIPDHGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5603D20", Offset = "0x5602520", VA = "0x185603D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5603DC0", Offset = "0x56025C0", VA = "0x185603DC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private BGFJNOHFIGD CHLLNKKCPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MonoBehaviour OBOMOBPDMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Action CKDDIDABPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Action<float> MIPGMHJKPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float KHFNDCIMPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool JPLPNLMHKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly FAKBKKNPBOM IPPKJPIDOPE;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x56099F0", Offset = "0x56081F0", VA = "0x1856099F0")]
	public MPPFHKNDPEE(MonoBehaviour OBOMOBPDMCG, Action CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5609E40", Offset = "0x5608640", VA = "0x185609E40")]
	public MPPFHKNDPEE(MonoBehaviour OBOMOBPDMCG, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5609BF0", Offset = "0x56083F0", VA = "0x185609BF0")]
	public MPPFHKNDPEE(MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4247250", Offset = "0x4245A50", VA = "0x184247250")]
	private MPPFHKNDPEE(FAKBKKNPBOM IPPKJPIDOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5609210", Offset = "0x5607A10", VA = "0x185609210")]
	internal static MPPFHKNDPEE IEDPCJMIGJD(MonoBehaviour OBOMOBPDMCG, float IKLANOEMCIC, Action<float> CKDDIDABPBA, BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, bool JPLPNLMHKMG = true, [Optional] FAKBKKNPBOM IPPKJPIDOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x56096D0", Offset = "0x5607ED0", VA = "0x1856096D0")]
	private void PCHKFEDAGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5609000", Offset = "0x5607800", VA = "0x185609000")]
	private void CJCNLNBDOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5609840", Offset = "0x5608040", VA = "0x185609840")]
	private void PLIKNBDLBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5608E30", Offset = "0x5607630", VA = "0x185608E30")]
	private void BIKIDFKKBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5608D00", Offset = "0x5607500", VA = "0x185608D00")]
	private void ACAKOAOIAMG(string EMPPPODHBFE, Action KEJHIBFHHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5609540", Offset = "0x5607D40", VA = "0x185609540")]
	[IteratorStateMachine(typeof(ILHHAIPDHGC))]
	private IEnumerator<MBIPJOOACNE> LPDHNBNCCLB(Action KEJHIBFHHHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56091B0", Offset = "0x56079B0", VA = "0x1856091B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5608C70", Offset = "0x5607470", VA = "0x185608C70")]
	[CompilerGenerated]
	private void ABPMEGLCPON(string ODBOKKABIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x56095B0", Offset = "0x5607DB0", VA = "0x1856095B0")]
	[CompilerGenerated]
	private void NKBGFPJOGLG(string ODBOKKABIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5609640", Offset = "0x5607E40", VA = "0x185609640")]
	[CompilerGenerated]
	private void OMNLOFAEOBK(string ODBOKKABIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x56094B0", Offset = "0x5607CB0", VA = "0x1856094B0")]
	[CompilerGenerated]
	private void IILFJCJEBLI(string ODBOKKABIBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[Flags]
internal enum MOKOHBCMBBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class OAEECPADOEL : IDAAFGAEAOF
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float GBHJKICHLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x560A550", Offset = "0x5608D50", VA = "0x18560A550", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float NJGPFPNEHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x560A5D0", Offset = "0x5608DD0", VA = "0x18560A5D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public double HJFINJEKCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x560A5E0", Offset = "0x5608DE0", VA = "0x18560A5E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x560A560", Offset = "0x5608D60", VA = "0x18560A560")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
	private static void OCOAIBMMGNP(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	[Preserve]
	internal OAEECPADOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal interface NFPCMPHBIMA
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NONIJGJIFAO(string LOIAMCEJAFO);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFFAJHONOHL();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal interface BMCODCBMBEB
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool BFCAGIPBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool PEHIDIOMFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class CBJINILGMMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public JPGNJECEELI EFEHKJCJBNL;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int FPGJPBIHINK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F30", Offset = "0x6F4730", VA = "0x1806F5F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x55F8C40", Offset = "0x55F7440", VA = "0x1855F8C40")]
	public static MBIPJOOACNE MKCFODOOCKA(IEnumerator<MBIPJOOACNE> CMLJNJEIPIO, FHPAPNIBCJP JKEFCKLOCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x55F8DF0", Offset = "0x55F75F0", VA = "0x1855F8DF0")]
	public MBIPJOOACNE MKCFODOOCKA(FHPAPNIBCJP[] GKDDIHLELPN, IEnumerator<MBIPJOOACNE>[] HCLHCEMHBLJ, MBIPJOOACNE[] LEMMOJADNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x55F8C10", Offset = "0x55F7410", VA = "0x1855F8C10")]
	public void MPHLCNKMLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x55F9010", Offset = "0x55F7810", VA = "0x1855F9010")]
	public void OHDEFKFBBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x55F8ED0", Offset = "0x55F76D0", VA = "0x1855F8ED0")]
	public void NIHBBMDHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x55F8C10", Offset = "0x55F7410", VA = "0x1855F8C10")]
	public void EEAGBOGPJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CBJINILGMMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class JPGNJECEELI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct LCEEFLKHEFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public CBJINILGMMD BFJDDGCAHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public EELELJHIFAH EFNNBMNPNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public FHPAPNIBCJP FBDJHBDHDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public IEnumerator<MBIPJOOACNE> AMFKPBODJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MBIPJOOACNE KIKCKJIJPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public MOKOHBCMBBG MPLBOEDPCAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct BNDAABCAMHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public BHIELCKBJMH.DEBLDMONPBH BJCAJAALJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<LCEEFLKHEFP> ILEMNKAOFJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class DHGCOEMKGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public FHPAPNIBCJP promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public JPGNJECEELI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public EELELJHIFAH context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public CBJINILGMMD routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public MOKOHBCMBBG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public MBIPJOOACNE currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public IEnumerator<MBIPJOOACNE> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public DHGCOEMKGEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x55FE490", Offset = "0x55FCC90", VA = "0x1855FE490")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PMFJPCEIKEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CBJINILGMMD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public JPGNJECEELI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public PMFJPCEIKEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x560BF70", Offset = "0x560A770", VA = "0x18560BF70")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CDHCGOPLJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public CBJINILGMMD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JPGNJECEELI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public CDHCGOPLJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x55FAAE0", Offset = "0x55F92E0", VA = "0x1855FAAE0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class GIHABNMJGBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CBJINILGMMD schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JPGNJECEELI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public GIHABNMJGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5602000", Offset = "0x5600800", VA = "0x185602000")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private const MOKOHBCMBBG KHKHEDOEAJH = MOKOHBCMBBG.Cancelled | MOKOHBCMBBG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool[] GBAMAKLMGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private NativeArray<MOKOHBCMBBG> LMGMKOHDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NativeArray<float> OJHGMJAPGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeArray<int> GONMNNKKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<int> BGGKFHKFPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<int> AGOENPKHJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> GMLCJIMCEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> LMGEBBAMCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private CBJINILGMMD[] GJCFFJKBPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private FHPAPNIBCJP[] GKDDIHLELPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private EELELJHIFAH[] GHHDJMMLBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private IEnumerator<MBIPJOOACNE>[] EJEDHELBFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private MBIPJOOACNE[] BNKNHPGLFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int PFKKMOPCOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int EBGHKBFPDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly int DKJBFNPJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float OJKNKDPLLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private AFJMAOBKOPD CMLGBDDPOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private JobHandle JNIODLEDPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private List<CBJINILGMMD> ODPGKLHGICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private bool ABBPLJCNBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private List<Action> MMHAPFBOJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<Action> HMCBBDPINBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool CKAOLPNJHDA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BNDAABCAMHD[] LKLECINEGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xF3B4A0", Offset = "0xF39CA0", VA = "0x180F3B4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5606370", Offset = "0x5604B70", VA = "0x185606370")]
	private static int HNEAJHGIOOO(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5606B90", Offset = "0x5605390", VA = "0x185606B90")]
	public JPGNJECEELI(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x56050F0", Offset = "0x56038F0", VA = "0x1856050F0")]
	private void EIGLIGOCIOE(ref int CFJONPHKADF, int DKCHJHAIGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x56068C0", Offset = "0x56050C0", VA = "0x1856068C0")]
	public void NMBAPOOGMAP(EELELJHIFAH CDBJCAAPIOD, MBIPJOOACNE FHGAPGBMJOF, IEnumerator<MBIPJOOACNE> CMLJNJEIPIO, FHPAPNIBCJP JKEFCKLOCOL, [Optional] CBJINILGMMD DBPHDLFJFKE, MOKOHBCMBBG KEGMCAKJNLM = MOKOHBCMBBG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5605920", Offset = "0x5604120", VA = "0x185605920")]
	public void FKLAKIJPDJB(IEnumerable<LCEEFLKHEFP> CFCBJCOGCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x56052E0", Offset = "0x5603AE0", VA = "0x1856052E0")]
	private LCEEFLKHEFP ELIJEOJBJJM(int HKCNPJKFIPB)
	{
		return default(LCEEFLKHEFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x56063A0", Offset = "0x5604BA0", VA = "0x1856063A0")]
	private void IGELFCOANFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x14A9EF0", Offset = "0x14A86F0", VA = "0x1814A9EF0")]
	private static void GDFJOLKIGLD<T>(int HKCNPJKFIPB, T[] OKGPMLJDHOD, int GIGKIGNPJAP, [Optional] T PHGPFMAKAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x14A9ED0", Offset = "0x14A86D0", VA = "0x1814A9ED0")]
	private static void GDFJOLKIGLD<T>(int HKCNPJKFIPB, NativeArray<T> OKGPMLJDHOD, int GIGKIGNPJAP, [Optional] T PHGPFMAKAKL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5604B30", Offset = "0x5603330", VA = "0x185604B30")]
	private void CDAEKBHEGGD(IEnumerable<LCEEFLKHEFP> CFCBJCOGCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5606AC0", Offset = "0x56052C0", VA = "0x185606AC0")]
	private void OFGEHHEBJOP(LCEEFLKHEFP OAEGMOKFIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5604870", Offset = "0x5603070", VA = "0x185604870")]
	private KMLOBGMKFIG AFDJELIPABP(int PMAOCIHDBBP)
	{
		return default(KMLOBGMKFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5604DE0", Offset = "0x56035E0", VA = "0x185604DE0")]
	public void CNMEKDNBGPC(float HGJJIMHGDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5606840", Offset = "0x5605040", VA = "0x185606840")]
	private void KCDFHLBENJM(Action HDPOKDCLGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5606A40", Offset = "0x5605240", VA = "0x185606A40")]
	private void NPIBPEPEDHD(Action HDPOKDCLGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5605C40", Offset = "0x5604440", VA = "0x185605C40")]
	public void GEHPDGDOOIN(float HGJJIMHGDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5606740", Offset = "0x5604F40", VA = "0x185606740")]
	public void IPHJFMDKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5604FC0", Offset = "0x56037C0", VA = "0x185604FC0")]
	public void EEAGBOGPJOM(CBJINILGMMD ACAFABCAHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5605B10", Offset = "0x5604310", VA = "0x185605B10")]
	public void FLIOKADGAHG(CBJINILGMMD ACAFABCAHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x56057F0", Offset = "0x5603FF0", VA = "0x1856057F0")]
	public void FEIAADAACII(CBJINILGMMD ACAFABCAHPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class BDIBLIHHMBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public static readonly BDIBLIHHMBN BOMLFOCAALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Action GNGKAIKLCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private bool IFDCADIMIGO;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	public BDIBLIHHMBN(Action GNGKAIKLCJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x55F7CC0", Offset = "0x55F64C0", VA = "0x1855F7CC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface CJKJMHJFPJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PIPNDDIAODJ(UnityEngine.Object CDBJCAAPIOD, Action<T> HPJOEKIJCAO);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface AFKCJCHIHFG<T> : global::CJKJMHJFPJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	new T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class AOOGANEIILO<T> : global::AFKCJCHIHFG<T>, global::CJKJMHJFPJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class GEKDMGCHPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public global::AOOGANEIILO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public global::JLNALEJLLLA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
		public GEKDMGCHPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3791D40", Offset = "0x3790540", VA = "0x183791D40")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static GameObject FFALCJOIHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly List<global::JLNALEJLLLA<UnityEngine.Object, Action<T>>> EPKOHBAMJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private T OHLNFEODIBJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public T PPNOOBBHMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2EA4960", Offset = "0x2EA3160", VA = "0x182EA4960", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4900", Offset = "0x2EA3100", VA = "0x182EA4900")]
	private static bool ACDPMCFIMML(T HDPOKDCLGGE, T JBKIIGINOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5480", Offset = "0x2EA3C80", VA = "0x182EA5480")]
	public AOOGANEIILO(T DNPEHMHKJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA5100", Offset = "0x2EA3900", VA = "0x182EA5100", Slot = "6")]
	public IDisposable PIPNDDIAODJ(UnityEngine.Object CDBJCAAPIOD, Action<T> HPJOEKIJCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA4A40", Offset = "0x2EA3240", VA = "0x182EA4A40")]
	private void JDEIAPCHMJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal class CLNJODLKPNK : PDPMJBEPPLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly FAKBKKNPBOM IPPKJPIDOPE;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x55FADD0", Offset = "0x55F95D0", VA = "0x1855FADD0")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
	private static void OCOAIBMMGNP(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	[Preserve]
	internal CLNJODLKPNK([LJAGOLJKNEF(null)] FAKBKKNPBOM IPPKJPIDOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x55FAE40", Offset = "0x55F9640", VA = "0x1855FAE40", Slot = "4")]
	public IDisposable OKNOJHFDIFO(float IKLANOEMCIC, Action<float> MKOFIMIHGLL, bool JPLPNLMHKMG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[BurstCompile]
internal struct AFJMAOBKOPD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[ReadOnly]
	public float HECJINGLDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[ReadOnly]
	public int IFNBIMOOIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private NativeArray<int> PBLEAKLOHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NativeArray<int> NGECFLIHPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private NativeArray<int> JDBMMHMEBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[ReadOnly]
	public NativeArray<MOKOHBCMBBG> CGKFOKHFLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[ReadOnly]
	public NativeArray<float> FNPJGGDPIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[WriteOnly]
	public NativeArray<int> AGOENPKHJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[WriteOnly]
	public NativeArray<int> GONMNNKKJHE;

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x55F4F00", Offset = "0x55F3700", VA = "0x1855F4F00")]
	public static AFJMAOBKOPD OJONNLHFKNA(int AGGGOGANEMM, float HGJJIMHGDGP, NativeArray<MOKOHBCMBBG> ECOOGGLJNPI, NativeArray<float> MBLPPMDNJAG, NativeArray<int> PALMPPBKPGF, NativeArray<int> EGMGAAHMBOM, NativeArray<int> MEICPEOEOOG, NativeArray<int> NGECFLIHPPH, NativeArray<int> JDBMMHMEBGF)
	{
		return default(AFJMAOBKOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x55F4B20", Offset = "0x55F3320", VA = "0x1855F4B20", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x55F4EC0", Offset = "0x55F36C0", VA = "0x1855F4EC0")]
	private bool OEMMMKGFMMM(int LHHBOCAHDEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x55F4E90", Offset = "0x55F3690", VA = "0x1855F4E90")]
	private void NDODJMHOIFN(NativeArray<int> GAOKJOENLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x55F4C00", Offset = "0x55F3400", VA = "0x1855F4C00")]
	private int MKPBABOLAEF(int DJMEODMDCBO, int LJFGELCLCHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x55F4A50", Offset = "0x55F3250", VA = "0x1855F4A50")]
	private void BIGEDOMNLEP(NativeArray<int> GAOKJOENLFG, int MILLDFOBCBK, int OLPEMMMHJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x55F4C60", Offset = "0x55F3460", VA = "0x1855F4C60")]
	private void MLKMOIAEBNC(NativeArray<int> GAOKJOENLFG, int CCFCPEDBLJF, int GFEAEMBCJDN, int LGMJFCNHBLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class HFFIBMFJFAP : APBMFDGACHG, FAKBKKNPBOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private JPGNJECEELI[] EBFFIMFNPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private NFPCMPHBIMA AGIJNKCNGGD;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5603110", Offset = "0x5601910", VA = "0x185603110")]
	[HAHBDBPNEOA(MDCFJLLNHDJ.None)]
	private static void OCOAIBMMGNP(BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5603180", Offset = "0x5601980", VA = "0x185603180")]
	[Preserve]
	public HFFIBMFJFAP([LJAGOLJKNEF(null)] LNCFFHBDNAK CPALLMNOPLB, [LJAGOLJKNEF(null)] IDAAFGAEAOF OBLPLHNBPPP, [LJAGOLJKNEF(null)] OMFMGFEBFNN MBPKJLDKAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5602730", Offset = "0x5600F30", VA = "0x185602730", Slot = "12")]
	public override BGFJNOHFIGD CBHJAKDKNOC(EELELJHIFAH CDBJCAAPIOD, IEnumerator<MBIPJOOACNE> BJNJJHCLELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5602E30", Offset = "0x5601630", VA = "0x185602E30", Slot = "13")]
	public override void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5602B60", Offset = "0x5601360", VA = "0x185602B60", Slot = "15")]
	public override void IBDIGIPFDFA(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5602870", Offset = "0x5601070", VA = "0x185602870", Slot = "14")]
	protected override void CEKLEBHDAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5602D40", Offset = "0x5601540", VA = "0x185602D40")]
	private JPGNJECEELI IHJDMMOCPJM(BHIELCKBJMH.DEBLDMONPBH EHPFPOFFCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5602D80", Offset = "0x5601580", VA = "0x185602D80", Slot = "16")]
	internal override DOCNECICKIF MEKOMPJPFGK(IEnumerator<MBIPJOOACNE> BJNJJHCLELJ, Behaviour CDBJCAAPIOD, FHPAPNIBCJP JKEFCKLOCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5602A80", Offset = "0x5601280", VA = "0x185602A80", Slot = "17")]
	internal override CBJMBDKONHK COEGKAHBADI(BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5602950", Offset = "0x5601150", VA = "0x185602950")]
	private void CKINMEDNIAN(JPGNJECEELI KMNGBDLPJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5602AF0", Offset = "0x56012F0", VA = "0x185602AF0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class APBMFDGACHG : FAKBKKNPBOM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly LNCFFHBDNAK CPALLMNOPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	protected readonly IDAAFGAEAOF OBLPLHNBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly OMFMGFEBFNN MBPKJLDKAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private CBJMBDKONHK[] DKHKMLCDAIK;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static FAKBKKNPBOM PDCOCJBICGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x55F6120", Offset = "0x55F4920", VA = "0x1855F6120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static bool MMIMOGPFBMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BHIELCKBJMH.DEBLDMONPBH KJJFDEDAPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BHIELCKBJMH.DEBLDMONPBH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5F30", Offset = "0x6F4730", VA = "0x1806F5F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IDAAFGAEAOF OMFJKMKGLGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x55F6610", Offset = "0x55F4E10", VA = "0x1855F6610")]
	public static BGFJNOHFIGD JBJCDEBJMNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x55F6AE0", Offset = "0x55F52E0", VA = "0x1855F6AE0")]
	[Preserve]
	protected APBMFDGACHG([LJAGOLJKNEF(null)] LNCFFHBDNAK CPALLMNOPLB, [LJAGOLJKNEF(null)] IDAAFGAEAOF OBLPLHNBPPP, [LJAGOLJKNEF(null)] OMFMGFEBFNN MBPKJLDKAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x55F6170", Offset = "0x55F4970", VA = "0x1855F6170", Slot = "6")]
	public BGFJNOHFIGD EJLHMMJIABH(IEnumerator<MBIPJOOACNE> BJNJJHCLELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x55F6180", Offset = "0x55F4980", VA = "0x1855F6180", Slot = "7")]
	public BGFJNOHFIGD EJLHMMJIABH(Behaviour CDBJCAAPIOD, IEnumerator<MBIPJOOACNE> BJNJJHCLELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract BGFJNOHFIGD CBHJAKDKNOC(EELELJHIFAH CDBJCAAPIOD, IEnumerator<MBIPJOOACNE> BJNJJHCLELJ);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x55F66B0", Offset = "0x55F4EB0", VA = "0x1855F66B0", Slot = "13")]
	public virtual void NDKMADGHFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x55F6890", Offset = "0x55F5090", VA = "0x1855F6890", Slot = "9")]
	public void OACFMMLIPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x55F5D60", Offset = "0x55F4560", VA = "0x1855F5D60", Slot = "14")]
	protected virtual void CEKLEBHDAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x55F5D20", Offset = "0x55F4520", VA = "0x1855F5D20")]
	private void BDBKADEEFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x55F5CE0", Offset = "0x55F44E0", VA = "0x1855F5CE0")]
	private void AIHAGLPJGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x55F5D80", Offset = "0x55F4580", VA = "0x1855F5D80")]
	private void DADOMEAMFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x55F5D40", Offset = "0x55F4540", VA = "0x1855F5D40")]
	private void BLEGBBMBOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x55F5D00", Offset = "0x55F4500", VA = "0x1855F5D00")]
	private void AKALKHBMHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x55F63B0", Offset = "0x55F4BB0", VA = "0x1855F63B0")]
	private void FJMFIHDAHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x55F6AC0", Offset = "0x55F52C0", VA = "0x1855F6AC0")]
	private void PPAPJAHKNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x55F63D0", Offset = "0x55F4BD0", VA = "0x1855F63D0", Slot = "15")]
	public virtual void IBDIGIPFDFA(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x55F68F0", Offset = "0x55F50F0", VA = "0x1855F68F0")]
	private void POCFBHHLGHG(CBJMBDKONHK KMNGBDLPJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0xB98610", Offset = "0xB96E10", VA = "0x180B98610")]
	private CBJMBDKONHK ALHNOENBEKJ(BHIELCKBJMH.DEBLDMONPBH EHPFPOFFCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract DOCNECICKIF MEKOMPJPFGK(IEnumerator<MBIPJOOACNE> BJNJJHCLELJ, Behaviour OBOMOBPDMCG, FHPAPNIBCJP NHKBAENIHND);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract CBJMBDKONHK COEGKAHBADI(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x55F5DA0", Offset = "0x55F45A0", VA = "0x1855F5DA0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal sealed class DOCNECICKIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly FHPAPNIBCJP JKEFCKLOCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly BMCODCBMBEB CDBJCAAPIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool MMKLMABNAIL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IEnumerator<MBIPJOOACNE> AMFKPBODJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MBIPJOOACNE KIKCKJIJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5140", Offset = "0x6F3940", VA = "0x1806F5140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HMKILDBBMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x55FF1D0", Offset = "0x55FD9D0", VA = "0x1855FF1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BDEDCEJDKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA57D60", Offset = "0xA56560", VA = "0x180A57D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x29897C0", Offset = "0x2987FC0", VA = "0x1829897C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6DC590", Offset = "0x6DAD90", VA = "0x1806DC590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public float EADJMEHEJFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xF422D0", Offset = "0xF40AD0", VA = "0x180F422D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xF423B0", Offset = "0xF40BB0", VA = "0x180F423B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x55FF5D0", Offset = "0x55FDDD0", VA = "0x1855FF5D0")]
	public DOCNECICKIF(IEnumerator<MBIPJOOACNE> CMLJNJEIPIO, BMCODCBMBEB CDBJCAAPIOD, FHPAPNIBCJP JKEFCKLOCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x55FF250", Offset = "0x55FDA50", VA = "0x1855FF250")]
	public MBIPJOOACNE MKCFODOOCKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x55FF0E0", Offset = "0x55FD8E0", VA = "0x1855FF0E0")]
	public bool BFPJNJFCLNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x55FF150", Offset = "0x55FD950", VA = "0x1855FF150")]
	public void EEAGBOGPJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x55FF510", Offset = "0x55FDD10", VA = "0x1855FF510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x182F4A0", Offset = "0x182DCA0", VA = "0x18182F4A0")]
	[CompilerGenerated]
	private void JMJKEPDBEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class FHPAPNIBCJP : MIEMGGOCAIB, BGFJNOHFIGD, KKCOJBHLCCF, LDGADANDBIO, IEnumerator, MBIPJOOACNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private BHIELCKBJMH.DEBLDMONPBH IKNGLFJPKBH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private BHIELCKBJMH.DEBLDMONPBH FHLGEKJKLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x779530", Offset = "0x777D30", VA = "0x180779530", Slot = "23")]
		get
		{
			return default(BHIELCKBJMH.DEBLDMONPBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BHIELCKBJMH.DEBLDMONPBH EFEHKJCJBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1B0", Offset = "0xA3C9B0", VA = "0x180A3E1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private float GMNKKCHLIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x116C6B0", Offset = "0x116AEB0", VA = "0x18116C6B0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool OHCNIBLLGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5601210", Offset = "0x55FFA10", VA = "0x185601210", Slot = "24")]
	private bool POOOGMLDGDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5601200", Offset = "0x55FFA00", VA = "0x185601200", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5601230", Offset = "0x55FFA30", VA = "0x185601230")]
	public FHPAPNIBCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal enum KMLOBGMKFIG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal sealed class CBJMBDKONHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum NPAMKFHKCIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct DLAOKCIIDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public BHIELCKBJMH.DEBLDMONPBH BJCAJAALJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public NPAMKFHKCIN KCCIBCCKFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public List<DOCNECICKIF> FHFPCMOINKB;
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly NPAMKFHKCIN[] CFEPPBMCPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool BFNIMABCDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly DOCNECICKIF[] KBBEKFGAMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly List<DOCNECICKIF> FBDHPCMKJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly Stack<int> HKICLFNJMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly List<DOCNECICKIF> KCHLLGNGJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly Stack<int> HDDBBOJAMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly NFPCMPHBIMA APFKPGDIJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool CKAOLPNJHDA;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public DLAOKCIIDLC[,] HLLJDDNJPCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x55FA610", Offset = "0x55F8E10", VA = "0x1855FA610")]
	public CBJMBDKONHK(BHIELCKBJMH.DEBLDMONPBH MIBMLLHOOBD, NFPCMPHBIMA APFKPGDIJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x55FA1D0", Offset = "0x55F89D0", VA = "0x1855FA1D0")]
	public void NHPDEFIKFJC(DOCNECICKIF CMLJNJEIPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x55F9C60", Offset = "0x55F8460", VA = "0x1855F9C60")]
	public void FMJNNDKOAHE(IList<DOCNECICKIF> HCLHCEMHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x55F9850", Offset = "0x55F8050", VA = "0x1855F9850")]
	public void CIIAEEDGJKJ(IList<DOCNECICKIF> HCLHCEMHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x55F9150", Offset = "0x55F7950", VA = "0x1855F9150")]
	private void AOCHPGPNBCP(DOCNECICKIF CMLJNJEIPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x55F9F30", Offset = "0x55F8730", VA = "0x1855F9F30")]
	private void IBJJIAJKLCH(IList<DOCNECICKIF> HCLHCEMHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x55F9570", Offset = "0x55F7D70", VA = "0x1855F9570")]
	private KMLOBGMKFIG BFCMJHFDKAM(DOCNECICKIF CMLJNJEIPIO)
	{
		return default(KMLOBGMKFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x55F9710", Offset = "0x55F7F10", VA = "0x1855F9710")]
	public void CEKLEBHDAHA(float HGJJIMHGDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x55FA2F0", Offset = "0x55F8AF0", VA = "0x1855FA2F0")]
	public void OACFMMLIPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x55F9250", Offset = "0x55F7A50", VA = "0x1855F9250")]
	private void AOPAEDFFPJN(List<DOCNECICKIF> HCLHCEMHBLJ, Stack<int> HAHFMJEBFBJ, bool GBPNAILDJGC, float HBGGHGPEONH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x55F9B20", Offset = "0x55F8320", VA = "0x1855F9B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x55FA0B0", Offset = "0x55F88B0", VA = "0x1855FA0B0")]
	private void IMOEMCFNDAH(List<DOCNECICKIF> HCLHCEMHBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal class DDIIBFHCPOL : NFPCMPHBIMA
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "4")]
	public void NONIJGJIFAO(string LOIAMCEJAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
	public void AFFAJHONOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DDIIBFHCPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class OKNINCOFLNC : BMCODCBMBEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Behaviour OBOMOBPDMCG;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string ILMHEGPAEKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x560B140", Offset = "0x5609940", VA = "0x18560B140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BFCAGIPBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x560B0E0", Offset = "0x56098E0", VA = "0x18560B0E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool PEHIDIOMFDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x560B0C0", Offset = "0x56098C0", VA = "0x18560B0C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6D5F40", Offset = "0x6D4740", VA = "0x1806D5F40")]
	public OKNINCOFLNC(Behaviour OBOMOBPDMCG)
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

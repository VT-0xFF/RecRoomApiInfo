using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> EMAJFOEJBNA(List<PlayerLoopSystem> AGLHPPMIIHD, int HGKOCLBPHCD);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct JMBPNGKEBPD
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct LJPOBBCFHJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static DHPKBHAFIMD JKLJCFBLLPH;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4041540", Offset = "0x403FD40", VA = "0x184041540")]
				public static PlayerLoopSystem OINGHNKBCCB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct LHNJJCMOLFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static DHPKBHAFIMD JBBIGGBJAMH;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x40413A0", Offset = "0x403FBA0", VA = "0x1840413A0")]
				public static PlayerLoopSystem OINGHNKBCCB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct FLMKMOIIDEG
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static DHPKBHAFIMD NOBPHJNBCCK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x403B6C0", Offset = "0x4039EC0", VA = "0x18403B6C0")]
				public static PlayerLoopSystem OINGHNKBCCB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct NDCOKEALLIH
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static DHPKBHAFIMD ILLIILEPCBA;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4044720", Offset = "0x4042F20", VA = "0x184044720")]
				public static PlayerLoopSystem OINGHNKBCCB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct AEJCLAELNGK
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class HOKHCCBNCKH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public PINGCHNDHEL.IGEGMHEGPAE key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
					public HOKHCCBNCKH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x403E090", Offset = "0x403C890", VA = "0x18403E090")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable OMOPBDNJPDN;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4035900", Offset = "0x4034100", VA = "0x184035900")]
				public static PlayerLoopSystem GFNDBLIIOCA(PINGCHNDHEL.IGEGMHEGPAE PONAFPGHKNA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct ODEHFCIPAIP
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class JCKIFAKKION
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public PINGCHNDHEL.IGEGMHEGPAE key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
					public JCKIFAKKION()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x403EF90", Offset = "0x403D790", VA = "0x18403EF90")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x4044EA0", Offset = "0x40436A0", VA = "0x184044EA0")]
				public static PlayerLoopSystem GFNDBLIIOCA(PINGCHNDHEL.IGEGMHEGPAE PONAFPGHKNA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MKMKDIIPLMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public MKMKDIIPLMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x40438A0", Offset = "0x40420A0", VA = "0x1840438A0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool EJIOEHPMHMG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool MEIFDDOEHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4038AC0", Offset = "0x40372C0", VA = "0x184038AC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4038B00", Offset = "0x4037300", VA = "0x184038B00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4037A00", Offset = "0x4036200", VA = "0x184037A00")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4038B40", Offset = "0x4037340", VA = "0x184038B40")]
		private static void KIPOKOFCBCF(PINGCHNDHEL.IGEGMHEGPAE PONAFPGHKNA, ref PlayerLoopSystem AIDMAPGGDIM, Type BMLCHADKNPP, Type CFIAICOENNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4038EA0", Offset = "0x40376A0", VA = "0x184038EA0")]
		private static void LIBNDHBLKBH(ref PlayerLoopSystem AIDMAPGGDIM, Type BMLCHADKNPP, Type CFIAICOENNJ, EMAJFOEJBNA NJJPFCOBIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4038DA0", Offset = "0x40375A0", VA = "0x184038DA0")]
		private static void KNAKCEDCBPO(ref PlayerLoopSystem AIDMAPGGDIM, Type BMLCHADKNPP, Type CFIAICOENNJ, PlayerLoopSystem? FDDBODEDIDK, PlayerLoopSystem? ALDEPDJENII)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PINGCHNDHEL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum IGEGMHEGPAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class BNKIGMIAOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly IGEGMHEGPAE LINBJLBHAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly ECIGLMBCELJ BDLMMOEGGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long OKELIKDBKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long AFAILEKMOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long IEDALNIOMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int PLGPEAOJAIM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4037550", Offset = "0x4035D50", VA = "0x184037550")]
		public BNKIGMIAOMK(IGEGMHEGPAE IIGLGFJOGFF, int JDDBIMAMNJI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4037530", Offset = "0x4035D30", VA = "0x184037530")]
		public void PJICEKFGOIC(int LHPKFLOBDOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4037250", Offset = "0x4035A50", VA = "0x184037250")]
		public void GBKBMNMFBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x40371F0", Offset = "0x40359F0", VA = "0x1840371F0")]
		public void FEJDBDGDBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x40372C0", Offset = "0x4035AC0", VA = "0x1840372C0")]
		public void NLDHMAAIKMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4037490", Offset = "0x4035C90", VA = "0x184037490")]
		public double PFDGPBPMLGD(int EIMHEILMCPP)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int HPCPMCBKAMD = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static IGEGMHEGPAE[] CLKLCDBBPHE;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BNKIGMIAOMK[] FOKCMNHCPCI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4045480", Offset = "0x4043C80", VA = "0x184045480")]
	public static BNKIGMIAOMK MKHKBOIBAMC(IGEGMHEGPAE PONAFPGHKNA, int JDDBIMAMNJI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x40453F0", Offset = "0x4043BF0", VA = "0x1840453F0")]
	public static BNKIGMIAOMK IFNCHJIGDPO(IGEGMHEGPAE PONAFPGHKNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4045340", Offset = "0x4043B40", VA = "0x184045340")]
	public static void GCPMHEOENJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ECIGLMBCELJ : NLJEGBMPOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int HDILAAHDKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> ICBBOPGHGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double CGJLHCNEEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double NGAPIFAHFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double LPNBEBFNNKE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BCANEHAHPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4039D60", Offset = "0x4038560", VA = "0x184039D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MNIKOJNOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4039EA0", Offset = "0x40386A0", VA = "0x184039EA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OAKIMCKEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7A09C0", Offset = "0x79F1C0", VA = "0x1807A09C0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double IMCNGFBMHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B080", Offset = "0x2B59880", VA = "0x182B5B080", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4039F70", Offset = "0x4038770", VA = "0x184039F70")]
	public ECIGLMBCELJ(int NPGIINIEICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4039DA0", Offset = "0x40385A0", VA = "0x184039DA0", Slot = "4")]
	public void CEDHBPEIDOL(double PHALGOPGPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4039F00", Offset = "0x4038700", VA = "0x184039F00", Slot = "5")]
	public void NMFGMFMEHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MPJICGACPHL : NLJEGBMPOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long MICAHCBFICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double KAJJOENHNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double PHHBDFKJIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double PNIIJIPCLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double BLHBHPFBJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double CGJLHCNEEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double NGAPIFAHFIA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OAKIMCKEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2FD75D0", Offset = "0x2FD5DD0", VA = "0x182FD75D0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double IMCNGFBMHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x29AC610", Offset = "0x29AAE10", VA = "0x1829AC610", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double OLMPFFBIKND
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B080", Offset = "0x2B59880", VA = "0x182B5B080")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DDGMJNIEDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5B070", Offset = "0x2B59870", VA = "0x182B5B070")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MNIKOJNOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7500", Offset = "0x2FD5D00", VA = "0x182FD7500", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4044590", Offset = "0x4042D90", VA = "0x184044590", Slot = "4")]
	public void CEDHBPEIDOL(double PHALGOPGPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x40446B0", Offset = "0x4042EB0", VA = "0x1840446B0", Slot = "5")]
	public void NMFGMFMEHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x40446F0", Offset = "0x4042EF0", VA = "0x1840446F0")]
	public MPJICGACPHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NLJEGBMPOFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MNIKOJNOFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OAKIMCKEIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double IMCNGFBMHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEDHBPEIDOL(double PHALGOPGPFE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMFGMFMEHKK();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ENMHOFCHOON
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface AAEKKAGHELJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool ANCCEBCDOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MIJPJJEKELF();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AFEKJALAOGD();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class GHLELGLPFGD<TPromise, TMainThreadPromise> : AAEKKAGHELJ where TPromise : JFNFLBIAFDM where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise FOKKNKLBGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise EICADHEEKKC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise PGEGCHIFDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1F75A80", Offset = "0x1F74280", VA = "0x181F75A80")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ANCCEBCDOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1F75AE0", Offset = "0x1F742E0", VA = "0x181F75AE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x12AC870", Offset = "0x12AB070", VA = "0x1812AC870")]
		protected GHLELGLPFGD(TPromise FOKKNKLBGMH, TMainThreadPromise NAKAKAFHPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F75B90", Offset = "0x1F74390", VA = "0x181F75B90", Slot = "5")]
		public void MIJPJJEKELF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F75A50", Offset = "0x1F74250", VA = "0x181F75A50", Slot = "6")]
		public void AFEKJALAOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void JHMKECANGAH(TPromise FOKKNKLBGMH);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void PDMPCPIMDKO();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class BONLOGGANFG<T> : GHLELGLPFGD<global::GHMNNNIJAKN<T>, global::BBIKMBOLBHD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D740", Offset = "0x1F6BF40", VA = "0x181F6D740")]
		public BONLOGGANFG(global::GHMNNNIJAKN<T> FOKKNKLBGMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D560", Offset = "0x1F6BD60", VA = "0x181F6D560", Slot = "7")]
		protected override void JHMKECANGAH(global::GHMNNNIJAKN<T> FOKKNKLBGMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D6E0", Offset = "0x1F6BEE0", VA = "0x181F6D6E0", Slot = "8")]
		protected override void PDMPCPIMDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D530", Offset = "0x1F6BD30", VA = "0x181F6D530")]
		[CompilerGenerated]
		private void AEOBHDLDNJA(T GBDMLAIBOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D6B0", Offset = "0x1F6BEB0", VA = "0x181F6D6B0")]
		[CompilerGenerated]
		private void MKKOLHCLBHO(string IKFKMGDIJDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class HACKAJDANKP : GHLELGLPFGD<JFNFLBIAFDM, PFHHFCMCGEB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x403D6F0", Offset = "0x403BEF0", VA = "0x18403D6F0")]
		public HACKAJDANKP(JFNFLBIAFDM FOKKNKLBGMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x403D5D0", Offset = "0x403BDD0", VA = "0x18403D5D0", Slot = "7")]
		protected override void JHMKECANGAH(JFNFLBIAFDM FOKKNKLBGMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x403D6A0", Offset = "0x403BEA0", VA = "0x18403D6A0", Slot = "8")]
		protected override void PDMPCPIMDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F4A70", Offset = "0x9F3270", VA = "0x1809F4A70")]
		[CompilerGenerated]
		private void AEOBHDLDNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xF71210", Offset = "0xF6FA10", VA = "0x180F71210")]
		[CompilerGenerated]
		private void MKKOLHCLBHO(string IKFKMGDIJDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OCLLFEFIEBJ : AAEKKAGHELJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action PDPDEJOFENK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ANCCEBCDOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x53A030", Offset = "0x538830", VA = "0x18053A030", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x59DDB0", Offset = "0x59C5B0", VA = "0x18059DDB0")]
		public OCLLFEFIEBJ(Action PDPDEJOFENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xCB1E70", Offset = "0xCB0670", VA = "0x180CB1E70", Slot = "5")]
		public void MIJPJJEKELF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "6")]
		public void AFEKJALAOGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<AAEKKAGHELJ> ECBOAIIGPDK;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x18C6EA0", Offset = "0x18C56A0", VA = "0x1818C6EA0")]
	public static global::GHMNNNIJAKN<T> NMAPBPOHLKG<T>(this global::GHMNNNIJAKN<T> FOKKNKLBGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x403B310", Offset = "0x4039B10", VA = "0x18403B310")]
	public static JFNFLBIAFDM NMAPBPOHLKG(this JFNFLBIAFDM FOKKNKLBGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x403B420", Offset = "0x4039C20", VA = "0x18403B420")]
	public static void NMAPBPOHLKG(Action PDPDEJOFENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x18C6DE0", Offset = "0x18C55E0", VA = "0x1818C6DE0")]
	private static global::GHMNNNIJAKN<T> CFBILGDKIMB<T>(global::GHMNNNIJAKN<T> FOKKNKLBGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x403AE60", Offset = "0x4039660", VA = "0x18403AE60")]
	private static JFNFLBIAFDM CFBILGDKIMB(JFNFLBIAFDM FOKKNKLBGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x403AC80", Offset = "0x4039480", VA = "0x18403AC80")]
	private static void BFCLAKNCHII(AAEKKAGHELJ GEGNBNMEEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x403AF40", Offset = "0x4039740", VA = "0x18403AF40")]
	private static void FDAFFKFMOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x403B4A0", Offset = "0x4039CA0", VA = "0x18403B4A0")]
	private static void OIBPJDIPODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x403B260", Offset = "0x4039A60", VA = "0x18403B260")]
	private static void GCHJIIGAIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class BKODBLEFAOP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KKKPLLAOMNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PFHHFCMCGEB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public KKKPLLAOMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4040F30", Offset = "0x403F730", VA = "0x184040F30")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4040F20", Offset = "0x403F720", VA = "0x184040F20")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LPBCLENNKID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public LPBCLENNKID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x40416E0", Offset = "0x403FEE0", VA = "0x1840416E0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DGBLDAMCEGE : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PFHHFCMCGEB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public DGBLDAMCEGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x40394E0", Offset = "0x4037CE0", VA = "0x1840394E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4039210", Offset = "0x4037A10", VA = "0x184039210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4039590", Offset = "0x4037D90", VA = "0x184039590")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4039490", Offset = "0x4037C90", VA = "0x184039490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ALLJBBBDCMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public PFHHFCMCGEB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public ALLJBBBDCMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CDGILCJOFAI : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PFHHFCMCGEB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private ALLJBBBDCMC <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public CDGILCJOFAI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4037630", Offset = "0x4035E30", VA = "0x184037630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4037980", Offset = "0x4036180", VA = "0x184037980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string GDCCGPNAGHA = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string LHADBACNNCC = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string NEPGFJECDML = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string KGIFDOABJAF = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string KDMNCECCDJK = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float BGEKANMJDIG = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static JFNFLBIAFDM NJLAJOJJJJG;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation POPJCNPDIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static JFNFLBIAFDM GJMLIGJNIAD;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string DMDGFGMPKOM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority MOLLKJGHGCF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool CJNKBFDPGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4036C70", Offset = "0x4035470", VA = "0x184036C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool CFNDJAAOPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4036E40", Offset = "0x4035640", VA = "0x184036E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool LBFJMOAJLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4036AF0", Offset = "0x40352F0", VA = "0x184036AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> KDOGHGPPAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4036D10", Offset = "0x4035510", VA = "0x184036D10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4036B50", Offset = "0x4035350", VA = "0x184036B50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4036EA0", Offset = "0x40356A0", VA = "0x184036EA0")]
	public static JFNFLBIAFDM JOLLOEGLKMA(string KNKLDONPFAN, LoadSceneMode JPHANCOPILK = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4036FE0", Offset = "0x40357E0", VA = "0x184036FE0")]
	public static JFNFLBIAFDM MGDKALDHEFM(string KNKLDONPFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4036C00", Offset = "0x4035400", VA = "0x184036C00")]
	[IteratorStateMachine(typeof(DGBLDAMCEGE))]
	private static IEnumerator<OPGJILMPEBL> ENDDJMEHELL(string KNKLDONPFAN, PFHHFCMCGEB DJPFBKLFDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4036DC0", Offset = "0x40355C0", VA = "0x184036DC0")]
	[IteratorStateMachine(typeof(CDGILCJOFAI))]
	private static IEnumerator<OPGJILMPEBL> IIBMJFHLBBD(string KNKLDONPFAN, LoadSceneMode JPHANCOPILK, PFHHFCMCGEB DJPFBKLFDLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EMJFOLANDND
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x403A760", Offset = "0x4038F60", VA = "0x18403A760")]
	public static IDisposable IGGJDAJGDBB(this MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x403A5A0", Offset = "0x4038DA0", VA = "0x18403A5A0")]
	public static IDisposable IGGJDAJGDBB(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x403A440", Offset = "0x4038C40", VA = "0x18403A440")]
	public static IDisposable EJMJBMIEAIP(this MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x403A160", Offset = "0x4038960", VA = "0x18403A160")]
	public static IDisposable ANAPHFOGPNE(this MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x403A3D0", Offset = "0x4038BD0", VA = "0x18403A3D0")]
	public static IDisposable EIOJINFKABJ(this MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x403AA80", Offset = "0x4039280", VA = "0x18403AA80")]
	public static IDisposable NPLBAPMMDIC(this MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x403A530", Offset = "0x4038D30", VA = "0x18403A530")]
	public static IDisposable FMGDNDEOHPA(this MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x403A8E0", Offset = "0x40390E0", VA = "0x18403A8E0")]
	public static IDisposable JJFPJANGHDL(this MJMCBJDEMFF PFCNEODPHJH, float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x403A1D0", Offset = "0x40389D0", VA = "0x18403A1D0")]
	public static IDisposable BANJOBLFJCJ(this MJMCBJDEMFF PFCNEODPHJH, float BPABIKKHKAK, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x403A4B0", Offset = "0x4038CB0", VA = "0x18403A4B0")]
	public static IDisposable EOPIFCOIFKC(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x403A2D0", Offset = "0x4038AD0", VA = "0x18403A2D0")]
	public static IDisposable CONNDGODMPK(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x403A350", Offset = "0x4038B50", VA = "0x18403A350")]
	public static IDisposable CPDLJNKHKAO(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x403AAF0", Offset = "0x40392F0", VA = "0x18403AAF0")]
	public static IDisposable OIHLOGNBOOB(this MJMCBJDEMFF PFCNEODPHJH, float BPABIKKHKAK, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x403AA00", Offset = "0x4039200", VA = "0x18403AA00")]
	public static IDisposable LKFEOEIKKKF(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x403A7E0", Offset = "0x4038FE0", VA = "0x18403A7E0")]
	public static IDisposable IMINEOBKEOI(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x403A860", Offset = "0x4039060", VA = "0x18403A860")]
	public static IDisposable JGCAOFCOKAE(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x403A970", Offset = "0x4039170", VA = "0x18403A970")]
	public static IDisposable LEJPIHFKECP(this MJMCBJDEMFF PFCNEODPHJH, float BPABIKKHKAK, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x403A250", Offset = "0x4038A50", VA = "0x18403A250")]
	public static IDisposable CMDJEMOKEOE(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x403AC00", Offset = "0x4039400", VA = "0x18403AC00")]
	public static IDisposable PAGAJFGEJHJ(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x403AB80", Offset = "0x4039380", VA = "0x18403AB80")]
	public static IDisposable PAALFBKMPOC(this MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GPCGIBCAHBB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x403D340", Offset = "0x403BB40", VA = "0x18403D340")]
	public static IDisposable NHKCKIAFJLN(this MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x403D180", Offset = "0x403B980", VA = "0x18403D180")]
	public static IDisposable NHKCKIAFJLN(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x403CD80", Offset = "0x403B580", VA = "0x18403CD80")]
	public static IDisposable GEBMKMPLJAL(this MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x403C930", Offset = "0x403B130", VA = "0x18403C930")]
	public static IDisposable ABJLBIINOMJ(this MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x403CE70", Offset = "0x403B670", VA = "0x18403CE70")]
	public static IDisposable GMLJCIHDBFN(this MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x403CD10", Offset = "0x403B510", VA = "0x18403CD10")]
	public static IDisposable EMPGHABIBAD(this MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x403C9A0", Offset = "0x403B1A0", VA = "0x18403C9A0")]
	public static IDisposable AEMMKBDOEIE(this MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x403CFE0", Offset = "0x403B7E0", VA = "0x18403CFE0")]
	public static IDisposable IIBJLJPDOPP(this MonoBehaviour GAFALDHGAID, float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x403CF60", Offset = "0x403B760", VA = "0x18403CF60")]
	public static IDisposable HDMGOFOHKHN(this MonoBehaviour GAFALDHGAID, float BPABIKKHKAK, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x403D100", Offset = "0x403B900", VA = "0x18403D100")]
	public static IDisposable NDPEECLLKEI(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x403CB90", Offset = "0x403B390", VA = "0x18403CB90")]
	public static IDisposable EAIFDFGMJPA(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x403CDF0", Offset = "0x403B5F0", VA = "0x18403CDF0")]
	public static IDisposable GLKOOJIDKDL(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x403CC10", Offset = "0x403B410", VA = "0x18403CC10")]
	public static IDisposable EFGCCIIBFKL(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x403D440", Offset = "0x403BC40", VA = "0x18403D440")]
	public static IDisposable OKPPEEAHNHF(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x403CC90", Offset = "0x403B490", VA = "0x18403CC90")]
	public static IDisposable EHNCEFKGCCC(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x403D070", Offset = "0x403B870", VA = "0x18403D070")]
	public static IDisposable IODIJNNPDPK(this MonoBehaviour GAFALDHGAID, float BPABIKKHKAK, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x403CB10", Offset = "0x403B310", VA = "0x18403CB10")]
	public static IDisposable CJFJFFBGPDM(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x403CA10", Offset = "0x403B210", VA = "0x18403CA10")]
	public static IDisposable BBMJGDCCBBJ(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x403CA90", Offset = "0x403B290", VA = "0x18403CA90")]
	public static IDisposable BNHBGNEEPEH(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x403D540", Offset = "0x403BD40", VA = "0x18403D540")]
	public static IDisposable PPLNKGLJGNM(this MonoBehaviour GAFALDHGAID, float BPABIKKHKAK, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x403CEE0", Offset = "0x403B6E0", VA = "0x18403CEE0")]
	public static IDisposable HACBHLLGKAH(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x403D4C0", Offset = "0x403BCC0", VA = "0x18403D4C0")]
	public static IDisposable PBENLIGAPGM(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x403D3C0", Offset = "0x403BBC0", VA = "0x18403D3C0")]
	public static IDisposable NOLPAEBCCJH(this MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class HIFGLJPNGEI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JAEFHPONHJP : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public ECOBBIEENFC.CGEEIAJOLFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LFOOJNPOFEK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public JAEFHPONHJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x403EE70", Offset = "0x403D670", VA = "0x18403EE70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x403EF40", Offset = "0x403D740", VA = "0x18403EF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class OJJIFNAPFJH : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ECOBBIEENFC.CGEEIAJOLFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LFOOJNPOFEK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public OJJIFNAPFJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4044FA0", Offset = "0x40437A0", VA = "0x184044FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4045090", Offset = "0x4043890", VA = "0x184045090", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x403DDA0", Offset = "0x403C5A0", VA = "0x18403DDA0")]
	public static PMAFHAMHOLN NHKCKIAFJLN(Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x403DBA0", Offset = "0x403C3A0", VA = "0x18403DBA0")]
	public static PMAFHAMHOLN NHKCKIAFJLN(Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x403DE90", Offset = "0x403C690", VA = "0x18403DE90")]
	public static PMAFHAMHOLN NHKCKIAFJLN(Behaviour PFCNEODPHJH, Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x403DC90", Offset = "0x403C490", VA = "0x18403DC90")]
	public static PMAFHAMHOLN NHKCKIAFJLN(Behaviour PFCNEODPHJH, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x403D980", Offset = "0x403C180", VA = "0x18403D980")]
	public static PMAFHAMHOLN IGGJDAJGDBB(MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x403DA90", Offset = "0x403C290", VA = "0x18403DA90")]
	public static PMAFHAMHOLN IGGJDAJGDBB(MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x403D910", Offset = "0x403C110", VA = "0x18403D910")]
	[IteratorStateMachine(typeof(JAEFHPONHJP))]
	private static IEnumerator<OPGJILMPEBL> CPKBNAPPNKM(ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB, Action MGGHKDONOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x403D8A0", Offset = "0x403C0A0", VA = "0x18403D8A0")]
	[IteratorStateMachine(typeof(OJJIFNAPFJH))]
	private static IEnumerator<OPGJILMPEBL> CPKBNAPPNKM(ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB, Action<float> MGGHKDONOAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DHBHNFJIIPN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IFAINGFENJD : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ECOBBIEENFC.CGEEIAJOLFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private PAPLHPLDCGI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public IFAINGFENJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x403E140", Offset = "0x403C940", VA = "0x18403E140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x403E230", Offset = "0x403CA30", VA = "0x18403E230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4039720", Offset = "0x4037F20", VA = "0x184039720")]
	public static PMAFHAMHOLN NHKCKIAFJLN(float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4039660", Offset = "0x4037E60", VA = "0x184039660")]
	public static PMAFHAMHOLN NHKCKIAFJLN(MonoBehaviour GAFALDHGAID, float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x40397D0", Offset = "0x4037FD0", VA = "0x1840397D0")]
	public static PMAFHAMHOLN PNNBJCGCOLM(MJMCBJDEMFF PFCNEODPHJH, float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x40395E0", Offset = "0x4037DE0", VA = "0x1840395E0")]
	[IteratorStateMachine(typeof(IFAINGFENJD))]
	private static IEnumerator<OPGJILMPEBL> CPKBNAPPNKM(float BPABIKKHKAK, ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB, Action<float> MGGHKDONOAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PMCNKGCHPOA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EPAJIJBHHHI : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ECOBBIEENFC.CGEEIAJOLFB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public EPAJIJBHHHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x403B5D0", Offset = "0x4039DD0", VA = "0x18403B5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x403B670", Offset = "0x4039E70", VA = "0x18403B670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x40458D0", Offset = "0x40440D0", VA = "0x1840458D0")]
	[IteratorStateMachine(typeof(EPAJIJBHHHI))]
	private static IEnumerator<OPGJILMPEBL> KMMDDGJALNF(ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK, Func<bool> OOKPGPEBHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4045780", Offset = "0x4043F80", VA = "0x184045780")]
	public static PMAFHAMHOLN GCOLDFNBOEB(this MonoBehaviour GAFALDHGAID, Func<bool> OOKPGPEBHEP, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK = ECOBBIEENFC.CGEEIAJOLFB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GNAIHBJGKID
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AEHKOLKBHDF : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public ECOBBIEENFC.CGEEIAJOLFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public AEHKOLKBHDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4035800", Offset = "0x4034000", VA = "0x184035800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x40358B0", Offset = "0x40340B0", VA = "0x1840358B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GNOMDFMONEO : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public ECOBBIEENFC.CGEEIAJOLFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private OPGJILMPEBL <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public GNOMDFMONEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x403C820", Offset = "0x403B020", VA = "0x18403C820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x403C8E0", Offset = "0x403B0E0", VA = "0x18403C8E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x403BC60", Offset = "0x403A460", VA = "0x18403BC60")]
	[IteratorStateMachine(typeof(AEHKOLKBHDF))]
	private static IEnumerator<OPGJILMPEBL> ACNIGNGHNMG(float OPFFMGBDJEC, ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x403BD10", Offset = "0x403A510", VA = "0x18403BD10")]
	[IteratorStateMachine(typeof(GNOMDFMONEO))]
	private static IEnumerator<OPGJILMPEBL> CDJLLENLPJB(float OPFFMGBDJEC, ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x403BFF0", Offset = "0x403A7F0", VA = "0x18403BFF0")]
	public static IDisposable EOLOGJIOOLJ(this MonoBehaviour GAFALDHGAID, float OPFFMGBDJEC, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x403C460", Offset = "0x403AC60", VA = "0x18403C460")]
	public static PMAFHAMHOLN LCMKJIOCKNI(this MonoBehaviour GAFALDHGAID, float OPFFMGBDJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x403BEA0", Offset = "0x403A6A0", VA = "0x18403BEA0")]
	public static PMAFHAMHOLN EOLOGJIOOLJ(this MonoBehaviour GAFALDHGAID, float OPFFMGBDJEC, ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x403BCE0", Offset = "0x403A4E0", VA = "0x18403BCE0")]
	public static PMAFHAMHOLN AGILGFACILH(this MonoBehaviour GAFALDHGAID, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x403BCF0", Offset = "0x403A4F0", VA = "0x18403BCF0")]
	public static PMAFHAMHOLN AKNKKGFPAMB(this MonoBehaviour GAFALDHGAID, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x403C7C0", Offset = "0x403AFC0", VA = "0x18403C7C0")]
	public static PMAFHAMHOLN MHJONOGFJBJ(this MonoBehaviour GAFALDHGAID, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x403BD00", Offset = "0x403A500", VA = "0x18403BD00")]
	public static PMAFHAMHOLN AMLPBMBIJLD(this MonoBehaviour GAFALDHGAID, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x403C7D0", Offset = "0x403AFD0", VA = "0x18403C7D0")]
	public static PMAFHAMHOLN NGLMKDLPMNJ(this MonoBehaviour GAFALDHGAID, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x403C130", Offset = "0x403A930", VA = "0x18403C130")]
	private static PMAFHAMHOLN FJPMJLMKNHA(MonoBehaviour GAFALDHGAID, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x403C6B0", Offset = "0x403AEB0", VA = "0x18403C6B0")]
	public static PMAFHAMHOLN MFDEDKAJOHF(this MonoBehaviour GAFALDHGAID, float FCAKKGKJEHJ, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x403BD90", Offset = "0x403A590", VA = "0x18403BD90")]
	public static PMAFHAMHOLN DIEDDFGNBNI(this MonoBehaviour GAFALDHGAID, float FCAKKGKJEHJ, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x403C5A0", Offset = "0x403ADA0", VA = "0x18403C5A0")]
	public static PMAFHAMHOLN MDHJOLDKJIO(this MonoBehaviour GAFALDHGAID, float FCAKKGKJEHJ, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x403C350", Offset = "0x403AB50", VA = "0x18403C350")]
	public static PMAFHAMHOLN KIOGPKPAADG(this MonoBehaviour GAFALDHGAID, float FCAKKGKJEHJ, Action BIFIHOBLFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x403C240", Offset = "0x403AA40", VA = "0x18403C240")]
	public static PMAFHAMHOLN GKMPJJHFFHE(this MonoBehaviour GAFALDHGAID, float FCAKKGKJEHJ, Action BIFIHOBLFDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class LCFDKCIDHPL : DOKLFAIAJOO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class DEIEHCOJDIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public LCFDKCIDHPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public DEIEHCOJDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x40379D0", Offset = "0x40361D0", VA = "0x1840379D0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CIFCLIFFHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LCFDKCIDHPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public CIFCLIFFHHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x40379D0", Offset = "0x40361D0", VA = "0x1840379D0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly float ILCEPFHKECH;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x403A040", Offset = "0x4038840", VA = "0x18403A040")]
	public LCFDKCIDHPL(Behaviour PFCNEODPHJH, float ILCEPFHKECH, [Optional] Action KPKGKDDLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4041110", Offset = "0x403F910", VA = "0x184041110", Slot = "9")]
	protected override bool BAEENIEJMCO(Action PDPDEJOFENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x40411E0", Offset = "0x403F9E0", VA = "0x1840411E0", Slot = "10")]
	protected override bool NFFILGKIIBI(Action PDPDEJOFENK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JJGOIILFBFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BDHNAIANBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CJHKGCIIDAE;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KPLKPHOIDOD(bool ECMFLMJNKPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KPLKPHOIDOD(Action PDPDEJOFENK, bool ECMFLMJNKPO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class DOKLFAIAJOO : JJGOIILFBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LCMJBKKJBCE : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public LCMJBKKJBCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x40412B0", Offset = "0x403FAB0", VA = "0x1840412B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4041350", Offset = "0x403FB50", VA = "0x184041350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Behaviour PFCNEODPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Action KPKGKDDLBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private EGOMDMLEOFB LDBCBFANKJF;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool BDHNAIANBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B1110", Offset = "0x7AF910", VA = "0x1807B1110", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CJHKGCIIDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x40398B0", Offset = "0x40380B0", VA = "0x1840398B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4039AD0", Offset = "0x40382D0", VA = "0x184039AD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1DFC440", Offset = "0x1DFAC40", VA = "0x181DFC440")]
	protected DOKLFAIAJOO(Behaviour PFCNEODPHJH, [Optional] Action KPKGKDDLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4039A20", Offset = "0x4038220", VA = "0x184039A20", Slot = "7")]
	public bool KPLKPHOIDOD(bool ECMFLMJNKPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4039A80", Offset = "0x4038280", VA = "0x184039A80", Slot = "8")]
	public bool KPLKPHOIDOD(Action PDPDEJOFENK, bool ECMFLMJNKPO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool BAEENIEJMCO(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NFFILGKIIBI(Action PDPDEJOFENK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4039890", Offset = "0x4038090", VA = "0x184039890")]
	protected void BJGCOECJJCB(Action PDPDEJOFENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4039B90", Offset = "0x4038390", VA = "0x184039B90")]
	protected JFNFLBIAFDM OCBOOAHBNBP(float IIEELEHMJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4039950", Offset = "0x4038150", VA = "0x184039950")]
	private void GFKKINENEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x40399C0", Offset = "0x40381C0", VA = "0x1840399C0")]
	[IteratorStateMachine(typeof(LCMJBKKJBCE))]
	private static IEnumerator<OPGJILMPEBL> HPCNMHFBGFC(float IIEELEHMJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4039B70", Offset = "0x4038370", VA = "0x184039B70")]
	[CompilerGenerated]
	private void NJJDNKNFJHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GBGBDOGKIIE : DOKLFAIAJOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float BNNGFBPMKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int EDIMEIAPEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float PGFKEDBHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float[] ONEAFANPGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int HNMAFPPGHCJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GOFODDKFNGM KMDDEMKJLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD70", Offset = "0x4DA570", VA = "0x1804DBD70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x403BB10", Offset = "0x403A310", VA = "0x18403BB10")]
	public GBGBDOGKIIE(Behaviour PFCNEODPHJH, float OOMPPIFBONM, int EDIMEIAPEKJ, [Optional] Action KPKGKDDLBDF, float PGFKEDBHLPL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5121A0", Offset = "0x5109A0", VA = "0x1805121A0", Slot = "9")]
	protected override bool BAEENIEJMCO(Action PDPDEJOFENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x403B8F0", Offset = "0x403A0F0", VA = "0x18403B8F0", Slot = "10")]
	protected override bool NFFILGKIIBI(Action PDPDEJOFENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x403B860", Offset = "0x403A060", VA = "0x18403B860")]
	private void BLNDPKHDOIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EECAMCFNNLM : DOKLFAIAJOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float ILCEPFHKECH;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x403A040", Offset = "0x4038840", VA = "0x18403A040")]
	public EECAMCFNNLM(Behaviour PFCNEODPHJH, float ILCEPFHKECH, [Optional] Action KPKGKDDLBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5121A0", Offset = "0x5109A0", VA = "0x1805121A0", Slot = "9")]
	protected override bool BAEENIEJMCO(Action PDPDEJOFENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x403A000", Offset = "0x4038800", VA = "0x18403A000", Slot = "10")]
	protected override bool NFFILGKIIBI(Action PDPDEJOFENK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IHJKAJJFGGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OLJMLOJNHIK : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public OLJMLOJNHIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x40450E0", Offset = "0x40438E0", VA = "0x1840450E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x40451D0", Offset = "0x40439D0", VA = "0x1840451D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PMAFHAMHOLN ADHDLHCFIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private MJMCBJDEMFF PFCNEODPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action MGGHKDONOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> BMPKNEENHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float KMEOFOGPFAI;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x403EB90", Offset = "0x403D390", VA = "0x18403EB90")]
	public IHJKAJJFGGB(MJMCBJDEMFF PFCNEODPHJH, Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x403EA00", Offset = "0x403D200", VA = "0x18403EA00")]
	public IHJKAJJFGGB(MJMCBJDEMFF PFCNEODPHJH, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x403ED20", Offset = "0x403D520", VA = "0x18403ED20")]
	public IHJKAJJFGGB(MJMCBJDEMFF PFCNEODPHJH, float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x403E6E0", Offset = "0x403CEE0", VA = "0x18403E6E0")]
	private void NHKCKIAFJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x403E3B0", Offset = "0x403CBB0", VA = "0x18403E3B0")]
	private void CKLCHDCEBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x403E280", Offset = "0x403CA80", VA = "0x18403E280")]
	private void APEEAMEFKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x403E8E0", Offset = "0x403D0E0", VA = "0x18403E8E0")]
	private void PAIKDDPKLKE(string IKFKMGDIJDE, Action JBADLCFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x403E680", Offset = "0x403CE80", VA = "0x18403E680")]
	[IteratorStateMachine(typeof(OLJMLOJNHIK))]
	private IEnumerator<OPGJILMPEBL> EPNJPFHOCCP(Action JBADLCFNECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x403E5B0", Offset = "0x403CDB0", VA = "0x18403E5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x403E860", Offset = "0x403D060", VA = "0x18403E860")]
	[CompilerGenerated]
	private void OKCDAHIOFON(string LKMCNIANCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x403E530", Offset = "0x403CD30", VA = "0x18403E530")]
	[CompilerGenerated]
	private void CMNPIIJNLMN(string LKMCNIANCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x403E600", Offset = "0x403CE00", VA = "0x18403E600")]
	[CompilerGenerated]
	private void EJIMPOJDDJK(string LKMCNIANCPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class MNGNEHBJHDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HEMLAAMFIFD : IEnumerator<OPGJILMPEBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private OPGJILMPEBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private OPGJILMPEBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
		[DebuggerHidden]
		public HEMLAAMFIFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x403D760", Offset = "0x403BF60", VA = "0x18403D760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x403D850", Offset = "0x403C050", VA = "0x18403D850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private PMAFHAMHOLN ADHDLHCFIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private MonoBehaviour GAFALDHGAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Action MGGHKDONOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action<float> BMPKNEENHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float KMEOFOGPFAI;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4044400", Offset = "0x4042C00", VA = "0x184044400")]
	public MNGNEHBJHDB(MonoBehaviour GAFALDHGAID, Action MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4044270", Offset = "0x4042A70", VA = "0x184044270")]
	public MNGNEHBJHDB(MonoBehaviour GAFALDHGAID, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4044120", Offset = "0x4042920", VA = "0x184044120")]
	public MNGNEHBJHDB(MonoBehaviour GAFALDHGAID, float BPABIKKHKAK, Action<float> MGGHKDONOAO, ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4043E00", Offset = "0x4042600", VA = "0x184043E00")]
	private void NHKCKIAFJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4043AD0", Offset = "0x40422D0", VA = "0x184043AD0")]
	private void CKLCHDCEBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x40439A0", Offset = "0x40421A0", VA = "0x1840439A0")]
	private void APEEAMEFKHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4044000", Offset = "0x4042800", VA = "0x184044000")]
	private void PAIKDDPKLKE(string IKFKMGDIJDE, Action JBADLCFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4043DA0", Offset = "0x40425A0", VA = "0x184043DA0")]
	[IteratorStateMachine(typeof(HEMLAAMFIFD))]
	private IEnumerator<OPGJILMPEBL> EPNJPFHOCCP(Action JBADLCFNECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4043CD0", Offset = "0x40424D0", VA = "0x184043CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4043F80", Offset = "0x4042780", VA = "0x184043F80")]
	[CompilerGenerated]
	private void OKCDAHIOFON(string LKMCNIANCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4043C50", Offset = "0x4042450", VA = "0x184043C50")]
	[CompilerGenerated]
	private void CMNPIIJNLMN(string LKMCNIANCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4043D20", Offset = "0x4042520", VA = "0x184043D20")]
	[CompilerGenerated]
	private void EJIMPOJDDJK(string LKMCNIANCPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MGFCJLOECEE
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int ABJDNEFCIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class HOAGGMFHBLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly HOAGGMFHBLG AHOHMEEEIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Action OIEMABKJIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool KEIDMNCCLCJ;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x59DDB0", Offset = "0x59C5B0", VA = "0x18059DDB0")]
	public HOAGGMFHBLG(Action OIEMABKJIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x403DFA0", Offset = "0x403C7A0", VA = "0x18403DFA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AGHBPKDGAAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T FAIFGLIBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NALKLGLFKNK(Action<T> AMPKMBCOLGA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable NALKLGLFKNK(UnityEngine.Object PFCNEODPHJH, Action<T> AMPKMBCOLGA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MFGJGJHEKKC<T> : global::AGHBPKDGAAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T FAIFGLIBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KJHDNOBOAOI<T> : global::MFGJGJHEKKC<T>, global::AGHBPKDGAAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MNIOJCLHCEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public global::KJHDNOBOAOI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::PEAPGKHMIMP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public MNIOJCLHCEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x25BD290", Offset = "0x25BBA90", VA = "0x1825BD290")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static GameObject KMPLBHAMAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<global::PEAPGKHMIMP<UnityEngine.Object, Action<T>>> ILEBPCHMCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T GLDJCCCMBJD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object HPMIEILDIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x25B6F70", Offset = "0x25B5770", VA = "0x1825B6F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T FAIFGLIBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5B6350", Offset = "0x5B4B50", VA = "0x1805B6350", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x25B6D00", Offset = "0x25B5500", VA = "0x1825B6D00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x25B6C30", Offset = "0x25B5430", VA = "0x1825B6C30")]
	private static bool AELNGALBFCN(T JOJPMNEANEI, T DALEFJAMHJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x25B7C10", Offset = "0x25B6410", VA = "0x1825B7C10")]
	public KJHDNOBOAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x25B7B80", Offset = "0x25B6380", VA = "0x1825B7B80")]
	public KJHDNOBOAOI(T MHAABHNCIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x25B71A0", Offset = "0x25B59A0", VA = "0x1825B71A0")]
	public void KOGKOBKIHMG(T BKBGKDHNKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x25B7800", Offset = "0x25B6000", VA = "0x1825B7800", Slot = "7")]
	public IDisposable NALKLGLFKNK(Action<T> AMPKMBCOLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x25B7870", Offset = "0x25B6070", VA = "0x1825B7870", Slot = "8")]
	public IDisposable NALKLGLFKNK(UnityEngine.Object PFCNEODPHJH, Action<T> AMPKMBCOLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x25B71C0", Offset = "0x25B59C0", VA = "0x1825B71C0")]
	private void MOGFMMEFMAK()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<CEBFEHDFGNN, Scheduler>, CEBFEHDFGNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class BFNOJHLNCMP : MGFCJLOECEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public MEBKGNMLOAG EJEOIOAPINH;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int ABJDNEFCIGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x4E1860", Offset = "0x4E0060", VA = "0x1804E1860", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x5B6330", Offset = "0x5B4B30", VA = "0x1805B6330")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4036990", Offset = "0x4035190", VA = "0x184036990")]
			public static OPGJILMPEBL NFKJNFOLAHH(IEnumerator<OPGJILMPEBL> HBONJFPLFPM, PGLDGNMAEEN JCFDMLOHLFH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x40368C0", Offset = "0x40350C0", VA = "0x1840368C0")]
			public OPGJILMPEBL NFKJNFOLAHH(PGLDGNMAEEN[] BHGOFPLGOAJ, IEnumerator<OPGJILMPEBL>[] NNIBMNBCJGP, OPGJILMPEBL[] MEHKKGANBAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4036710", Offset = "0x4034F10", VA = "0x184036710")]
			public void MDINFINIJCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4036740", Offset = "0x4034F40", VA = "0x184036740")]
			public void GPKKGLJAAKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4036800", Offset = "0x4035000", VA = "0x184036800")]
			public void LLNPKJNKNHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4036710", Offset = "0x4034F10", VA = "0x184036710")]
			public void AFEKJALAOGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
			public BFNOJHLNCMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class MEBKGNMLOAG
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct FHNHLOABANC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public BFNOJHLNCMP BAPKJEHACNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public MJMCBJDEMFF FEGBLDNHBJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public PGLDGNMAEEN COMDJNCEJFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public IEnumerator<OPGJILMPEBL> NKCGFLCKGOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public OPGJILMPEBL PKNJNJOGDFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public LDINLMBAGCM LCFOFEDBKDH;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct MLAMBNAKNGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public ECOBBIEENFC.CGEEIAJOLFB JJBEDONJKFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public List<FHNHLOABANC> FKPHCHNNECC;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class APDHIHKFFKE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public MEBKGNMLOAG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public MJMCBJDEMFF context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public BFNOJHLNCMP routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public LDINLMBAGCM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public PGLDGNMAEEN promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public OPGJILMPEBL currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public IEnumerator<OPGJILMPEBL> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public APDHIHKFFKE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x40360C0", Offset = "0x40348C0", VA = "0x1840360C0")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class GDCJOAGBNCM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public BFNOJHLNCMP schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public MEBKGNMLOAG <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public GDCJOAGBNCM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x403BC20", Offset = "0x403A420", VA = "0x18403BC20")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class GNKJLEIMJIO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public BFNOJHLNCMP schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public MEBKGNMLOAG <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public GNKJLEIMJIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x403C7E0", Offset = "0x403AFE0", VA = "0x18403C7E0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class EIJGANABNEE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public BFNOJHLNCMP schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public MEBKGNMLOAG <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
				public EIJGANABNEE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x403A090", Offset = "0x4038890", VA = "0x18403A090")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private readonly ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool[] POFCOMIABJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<LDINLMBAGCM> GDJJMNKIFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<float> CFCFIMJGMCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> MHILFNMHJCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> BNPDOBFKALB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> FMEKNDEGJEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> GEGHKHMCNMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> BPPHGEDEJCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private BFNOJHLNCMP[] EOLALIKNDIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private PGLDGNMAEEN[] BHGOFPLGOAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private MJMCBJDEMFF[] KCBKFHCKFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private IEnumerator<OPGJILMPEBL>[] IJDMBAJPCKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private OPGJILMPEBL[] FMAEHEDIKIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int BKOHKGHKLIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private int MGJIDFDCMAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private readonly int IHJPFAPHJIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private float EFJMFPCNJBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private AILLHNEEGDG PFCAIGLGPKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private JobHandle AALKFHDPMPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<BFNOJHLNCMP> HCDIBFPLFHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool CAOKNFIMCPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<Action> OEKAGFBBMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private List<Action> KJDENGPDNGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private bool IJNHBJHCCOI;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public MLAMBNAKNGE[] OLCPGCFFONP
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x588490", Offset = "0x586C90", VA = "0x180588490")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int JFCHHKEEFEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x6C94B0", Offset = "0x6C7CB0", VA = "0x1806C94B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4042550", Offset = "0x4040D50", VA = "0x184042550")]
			private static int JBIFENLPBCP(ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x40433D0", Offset = "0x4041BD0", VA = "0x1840433D0")]
			public MEBKGNMLOAG(ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4041960", Offset = "0x4040160", VA = "0x184041960")]
			private void DMGKOAFIGGB(ref int LOIMCKGPMHH, int EFPBFJHFINF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4042E70", Offset = "0x4041670", VA = "0x184042E70")]
			public void OOHABBPGHIO(MJMCBJDEMFF PFCNEODPHJH, OPGJILMPEBL DMNHOJJOFDI, IEnumerator<OPGJILMPEBL> HBONJFPLFPM, PGLDGNMAEEN JCFDMLOHLFH, [Optional] BFNOJHLNCMP KCKENFGGLDI, LDINLMBAGCM NGBEMOPHMBM = LDINLMBAGCM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4042C80", Offset = "0x4041480", VA = "0x184042C80")]
			public void OKGNGIDOIKE(IEnumerable<FHNHLOABANC> ADCBOGBJDIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4042FA0", Offset = "0x40417A0", VA = "0x184042FA0")]
			private FHNHLOABANC PBGJAAEOGFH(int GNMANLPPEBA)
			{
				return default(FHNHLOABANC);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4042950", Offset = "0x4041150", VA = "0x184042950")]
			private void KCPMJKFEKEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1560A30", Offset = "0x155F230", VA = "0x181560A30")]
			private static void AOBICGPELPN<T>(int GNMANLPPEBA, T[] HKDOLEPCIEF, int HMOCDAEHBDK, [Optional] T KFHPACNFEJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1560A10", Offset = "0x155F210", VA = "0x181560A10")]
			private static void AOBICGPELPN<T>(int GNMANLPPEBA, NativeArray<T> HKDOLEPCIEF, int HMOCDAEHBDK, [Optional] T KFHPACNFEJH) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4042200", Offset = "0x4040A00", VA = "0x184042200")]
			private void HLFOKIPDJIH(IEnumerable<FHNHLOABANC> ADCBOGBJDIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x40418A0", Offset = "0x40400A0", VA = "0x1840418A0")]
			private void CHIJINLKENN(FHNHLOABANC EAJGMMEIGDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4042580", Offset = "0x4040D80", VA = "0x184042580")]
			private KLGBKBLINGD JCADPPFFIPD(int DGMPIKPEOKD)
			{
				return default(KLGBKBLINGD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4041B70", Offset = "0x4040370", VA = "0x184041B70")]
			public void GDOBCOGMJGF(float OEDBFKJHEBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x40428D0", Offset = "0x40410D0", VA = "0x1840428D0")]
			private void JKNGENMIAEM(Action JOJPMNEANEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4041AF0", Offset = "0x40402F0", VA = "0x184041AF0")]
			private void FMHIJBFAGOA(Action JOJPMNEANEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x4041D60", Offset = "0x4040560", VA = "0x184041D60")]
			public void HABAJEEJEDJ(float OEDBFKJHEBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4041710", Offset = "0x403FF10", VA = "0x184041710")]
			public void ADDJJGOGOME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x40417F0", Offset = "0x403FFF0", VA = "0x1840417F0")]
			public void AFEKJALAOGD(BFNOJHLNCMP CNJOBHOJCNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x40424A0", Offset = "0x4040CA0", VA = "0x1840424A0")]
			public void IGADNFHEMHM(BFNOJHLNCMP CNJOBHOJCNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4042820", Offset = "0x4041020", VA = "0x184042820")]
			public void JDEOGKJKJFN(BFNOJHLNCMP CNJOBHOJCNL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct AILLHNEEGDG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			[ReadOnly]
			public float NFHLOIPJJFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			[ReadOnly]
			public int IEKDJGNLFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private NativeArray<int> KMINBHIIPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private NativeArray<int> KCNPEPDCCKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> IBGBCIAGCKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[ReadOnly]
			public NativeArray<LDINLMBAGCM> JNJCGIFBPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			[ReadOnly]
			public NativeArray<float> OGBIFPOOJJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[WriteOnly]
			public NativeArray<int> FMEKNDEGJEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[WriteOnly]
			public NativeArray<int> MHILFNMHJCA;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4035E50", Offset = "0x4034650", VA = "0x184035E50")]
			public static AILLHNEEGDG MJCPAEDCHAE(int DBJCJFILFEH, float OEDBFKJHEBC, NativeArray<LDINLMBAGCM> FCOHJHLKAIG, NativeArray<float> PEPOBOPLLAL, NativeArray<int> HJGPABIPMGD, NativeArray<int> NBDENOIOGEO, NativeArray<int> FJDFOEEBADF, NativeArray<int> KCNPEPDCCKL, NativeArray<int> IBGBCIAGCKE)
			{
				return default(AILLHNEEGDG);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4035B10", Offset = "0x4034310", VA = "0x184035B10", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4035AD0", Offset = "0x40342D0", VA = "0x184035AD0")]
			private bool CHKGBPHLDPE(int MPFKOFCNLNB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4035BF0", Offset = "0x40343F0", VA = "0x184035BF0")]
			private void JMDJCFLGPMJ(NativeArray<int> AAGKPMMHHNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4035F20", Offset = "0x4034720", VA = "0x184035F20")]
			private int NLDCJKMHCNJ(int HPJNBAGOPIE, int CANOFEJFIMP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4035A00", Offset = "0x4034200", VA = "0x184035A00")]
			private void AMBGJIMNONG(NativeArray<int> AAGKPMMHHNJ, int LILEDGIGKBJ, int MKKKGEBAKHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4035C20", Offset = "0x4034420", VA = "0x184035C20")]
			private void JNPHHGLOEHM(NativeArray<int> AAGKPMMHHNJ, int NHINCFFAIJP, int LBLNFEJLBGJ, int DKDAENCGFKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class JGOBIAPNHHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private readonly PGLDGNMAEEN JCFDMLOHLFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private readonly Behaviour PFCNEODPHJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly bool AHNJIBAGJGB;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<OPGJILMPEBL> NKCGFLCKGOF
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public OPGJILMPEBL PKNJNJOGDFD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4D7820", Offset = "0x4D6020", VA = "0x1804D7820")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool PIFMPIAOOGJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x403F450", Offset = "0x403DC50", VA = "0x18403F450")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool JKGKFHDNGLI
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x9A6430", Offset = "0x9A4C30", VA = "0x1809A6430")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x1A540D0", Offset = "0x1A528D0", VA = "0x181A540D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string HIDCHKFDOPP
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x4DBD40", Offset = "0x4DA540", VA = "0x1804DBD40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x4DBD80", Offset = "0x4DA580", VA = "0x1804DBD80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float NIALNIFBKAF
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x81BC60", Offset = "0x81A460", VA = "0x18081BC60")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x81BA80", Offset = "0x81A280", VA = "0x18081BA80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x403F570", Offset = "0x403DD70", VA = "0x18403F570")]
			public JGOBIAPNHHP(IEnumerator<OPGJILMPEBL> HBONJFPLFPM, Behaviour PFCNEODPHJH, PGLDGNMAEEN JCFDMLOHLFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x403F1B0", Offset = "0x403D9B0", VA = "0x18403F1B0")]
			public OPGJILMPEBL NFKJNFOLAHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x403F3C0", Offset = "0x403DBC0", VA = "0x18403F3C0")]
			public bool OMKJGGCLPJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x403F120", Offset = "0x403D920", VA = "0x18403F120")]
			public void AFEKJALAOGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x403F4E0", Offset = "0x403DCE0", VA = "0x18403F4E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xD10FF0", Offset = "0xD0F7F0", VA = "0x180D10FF0")]
			[CompilerGenerated]
			private void FFMNHEOEFBF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class PGLDGNMAEEN : MDBCJDJCJFE, PMAFHAMHOLN, EGOMDMLEOFB, JFNFLBIAFDM, IEnumerator, OPGJILMPEBL, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private ECOBBIEENFC.CGEEIAJOLFB FAODBJAJHNL;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private ECOBBIEENFC.CGEEIAJOLFB EKMDDBNADBJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F10", Offset = "0x5D4710", VA = "0x1805D5F10", Slot = "23")]
				get
				{
					return default(ECOBBIEENFC.CGEEIAJOLFB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public ECOBBIEENFC.CGEEIAJOLFB EJEOIOAPINH
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x5D5F10", Offset = "0x5D4710", VA = "0x1805D5F10")]
				get
				{
					return default(ECOBBIEENFC.CGEEIAJOLFB);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0xB0ACA0", Offset = "0xB094A0", VA = "0x180B0ACA0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float GDEDHMENMPG
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x5A49D0", Offset = "0x5A31D0", VA = "0x1805A49D0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4045230", Offset = "0x4043A30", VA = "0x184045230", Slot = "24")]
			private bool IAMHADJJLHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4045220", Offset = "0x4043A20", VA = "0x184045220", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x4045250", Offset = "0x4043A50", VA = "0x184045250")]
			public PGLDGNMAEEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum KLGBKBLINGD : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class KJEILKJHOKG : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum FLGPOGGPGBM
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct BJKLBFCDFOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public ECOBBIEENFC.CGEEIAJOLFB JJBEDONJKFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public FLGPOGGPGBM IANJFOFNAJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public List<JGOBIAPNHHP> ODMAOHKPFOL;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private static readonly FLGPOGGPGBM[] JHCCDBBEFEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly ECOBBIEENFC.CGEEIAJOLFB IDBKFILIGFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private bool BLGIJMDFDMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly JGOBIAPNHHP[] CCJJHALIKHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly List<JGOBIAPNHHP> IHBENAFIDHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly Stack<int> HKPNOOJGPPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<JGOBIAPNHHP> NEBDJGLDEMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> NJLFPLHOLCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private bool IJNHBJHCCOI;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public BJKLBFCDFOH[,] LPFANHIIFDC
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x4DBD20", Offset = "0x4DA520", VA = "0x1804DBD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int JFCHHKEEFEM
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x4040650", Offset = "0x403EE50", VA = "0x184040650")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x4040B40", Offset = "0x403F340", VA = "0x184040B40")]
			public KJEILKJHOKG(ECOBBIEENFC.CGEEIAJOLFB GPGAEHMOJKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x4040370", Offset = "0x403EB70", VA = "0x184040370")]
			public void GCMIOMPADNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x4040A60", Offset = "0x403F260", VA = "0x184040A60")]
			public void OOHODNHJACA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4040430", Offset = "0x403EC30", VA = "0x184040430")]
			private void GLOOAKOGDHA(IReadOnlyList<JGOBIAPNHHP> JDBOCINBGNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4040550", Offset = "0x403ED50", VA = "0x184040550")]
			public void IHAODDMJDKM(JGOBIAPNHHP HBONJFPLFPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x40400F0", Offset = "0x403E8F0", VA = "0x1840400F0")]
			public void FLGDDPLCGLD(IList<JGOBIAPNHHP> NNIBMNBCJGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x403F9C0", Offset = "0x403E1C0", VA = "0x18403F9C0")]
			public void BLBECBGEPPM(IList<JGOBIAPNHHP> NNIBMNBCJGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x403F6F0", Offset = "0x403DEF0", VA = "0x18403F6F0")]
			private void AHCKBLJLKJC(JGOBIAPNHHP HBONJFPLFPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x403FF80", Offset = "0x403E780", VA = "0x18403FF80")]
			private void EOICEAMBBGM(IList<JGOBIAPNHHP> NNIBMNBCJGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x40407C0", Offset = "0x403EFC0", VA = "0x1840407C0")]
			private KLGBKBLINGD JFGDCJGDBJA(JGOBIAPNHHP HBONJFPLFPM)
			{
				return default(KLGBKBLINGD);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x4040380", Offset = "0x403EB80", VA = "0x184040380")]
			public void GEBMKMPLJAL(float OEDBFKJHEBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x403FD80", Offset = "0x403E580", VA = "0x18403FD80")]
			public void EMJBEEOAENJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x403F7E0", Offset = "0x403DFE0", VA = "0x18403F7E0")]
			private void AIICHHHGGIG(List<JGOBIAPNHHP> NNIBMNBCJGP, Stack<int> FHAFKIIGLIC, bool GHCJLIOMHOP, float LPNFKNHBHLM = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x403FC40", Offset = "0x403E440", VA = "0x18403FC40", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4040940", Offset = "0x403F140", VA = "0x184040940")]
			private void NHAPFGNFDDF(List<JGOBIAPNHHP> NNIBMNBCJGP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum LDINLMBAGCM : byte
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

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class JDEIDLGFOMH : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public JDEIDLGFOMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x403F050", Offset = "0x403D850", VA = "0x18403F050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x403F0D0", Offset = "0x403D8D0", VA = "0x18403F0D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private const LDINLMBAGCM EHPFHHGNIAC = LDINLMBAGCM.Cancelled | LDINLMBAGCM.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly ECOBBIEENFC.CGEEIAJOLFB[] KNGJGEIAEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private KJEILKJHOKG[] NAOAPNBOGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private MEBKGNMLOAG[] ADANLICHFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private Coroutine NAGBPKPDBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private WaitForEndOfFrame HFLMFGFPCMH;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ECOBBIEENFC.CGEEIAJOLFB LNBBCAJGHNF
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x5907C0", Offset = "0x58EFC0", VA = "0x1805907C0")]
			[CompilerGenerated]
			get
			{
				return default(ECOBBIEENFC.CGEEIAJOLFB);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x590780", Offset = "0x58EF80", VA = "0x180590780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PFAJNJNCBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x6583C0", Offset = "0x656BC0", VA = "0x1806583C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xFF9440", Offset = "0xFF7C40", VA = "0x180FF9440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int JFCHHKEEFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4047290", Offset = "0x4045A90", VA = "0x184047290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4045E90", Offset = "0x4044690", VA = "0x184045E90")]
		public static PMAFHAMHOLN GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4045940", Offset = "0x4044140", VA = "0x184045940", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4046250", Offset = "0x4044A50", VA = "0x184046250", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4045DE0", Offset = "0x40445E0", VA = "0x184045DE0")]
		private KJEILKJHOKG DIILKKKIHMN(ECOBBIEENFC.CGEEIAJOLFB AOIJDDCBKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2842890", Offset = "0x2841090", VA = "0x182842890")]
		private MEBKGNMLOAG FMIAOLPJDND(ECOBBIEENFC.CGEEIAJOLFB AOIJDDCBKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x40466E0", Offset = "0x4044EE0", VA = "0x1840466E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x40466B0", Offset = "0x4044EB0", VA = "0x1840466B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4047080", Offset = "0x4045880", VA = "0x184047080")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4046220", Offset = "0x4044A20", VA = "0x184046220")]
		private void JKLJCFBLLPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4046050", Offset = "0x4044850", VA = "0x184046050")]
		private void JBBIGGBJAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4045E80", Offset = "0x4044680", VA = "0x184045E80")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4046230", Offset = "0x4044A30", VA = "0x184046230")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4046240", Offset = "0x4044A40", VA = "0x184046240")]
		private void NOBPHJNBCCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4045E20", Offset = "0x4044620", VA = "0x184045E20")]
		[IteratorStateMachine(typeof(JDEIDLGFOMH))]
		private IEnumerator FFNILINLMBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4046BA0", Offset = "0x40453A0", VA = "0x184046BA0", Slot = "7")]
		public PMAFHAMHOLN Run(IEnumerator<OPGJILMPEBL> INNGNJMMCOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4046880", Offset = "0x4045080", VA = "0x184046880", Slot = "8")]
		public PMAFHAMHOLN Run(Behaviour PFCNEODPHJH, IEnumerator<OPGJILMPEBL> INNGNJMMCOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4046750", Offset = "0x4044F50", VA = "0x184046750", Slot = "9")]
		public PMAFHAMHOLN RunJobbed(MJMCBJDEMFF PFCNEODPHJH, IEnumerator<OPGJILMPEBL> INNGNJMMCOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4045D80", Offset = "0x4044580", VA = "0x184045D80", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4046BB0", Offset = "0x40453B0", VA = "0x184046BB0")]
		public void UpdateQueue(ECOBBIEENFC.CGEEIAJOLFB MDJNLKELEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4046060", Offset = "0x4044860", VA = "0x184046060")]
		private void JDADKGKJNIL(KJEILKJHOKG EABBGPCDDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4045F30", Offset = "0x4044730", VA = "0x184045F30")]
		private void HLCKDEAMBMN(MEBKGNMLOAG EABBGPCDDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4047230", Offset = "0x4045A30", VA = "0x184047230")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class PHCDAOLCKEP
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x40452B0", Offset = "0x4043AB0", VA = "0x1840452B0")]
	[EHMMDJEBAHC]
	private static void PFFHEPFDHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class PLBGNBIFJNB : GOFODDKFNGM
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float FDPONHBFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4045750", Offset = "0x4043F50", VA = "0x184045750", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float DPPEAMGLCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4045720", Offset = "0x4043F20", VA = "0x184045720", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float BOCLFALLACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4045770", Offset = "0x4043F70", VA = "0x184045770", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int ALHJKLEKHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4045760", Offset = "0x4043F60", VA = "0x184045760", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double KFBDLBLPFMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4045730", Offset = "0x4043F30", VA = "0x184045730", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public PLBGNBIFJNB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NNEGPLICMMD
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] JIMKOONODID;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int NMMFCBLNDCI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int PHIEOBCOOJB;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger DPMJLFEPCLI;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public NNEGPLICMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x40448C0", Offset = "0x40430C0", VA = "0x1840448C0")]
	private static string CFIIEEFNNDM(byte[] DALEFJAMHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x40449C0", Offset = "0x40431C0", VA = "0x1840449C0")]
	public static string DHILBOIALCB(byte[] EGBGAEKCIGK, bool DAJGEBLMHFN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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

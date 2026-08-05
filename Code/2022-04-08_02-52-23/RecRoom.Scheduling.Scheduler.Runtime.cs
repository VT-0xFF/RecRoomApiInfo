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
		private delegate List<PlayerLoopSystem> FJJHJOMKEHF(List<PlayerLoopSystem> JKMDODNCHHK, int NJNHBJBEOHC);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct JHOLHNMHHBB
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct HBGGKKKDMKB
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static LKKJDCJIBEF DKNLDDBAFAF;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4815020", Offset = "0x4813E20", VA = "0x184815020")]
				public static PlayerLoopSystem OFONJFECFAH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct PJENBPIGIBB
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static LKKJDCJIBEF AMFNCKCIJCB;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x481CDB0", Offset = "0x481BBB0", VA = "0x18481CDB0")]
				public static PlayerLoopSystem OFONJFECFAH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct KHCKILJAHCG
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static LKKJDCJIBEF JGANNFFDOFN;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x481A300", Offset = "0x4819100", VA = "0x18481A300")]
				public static PlayerLoopSystem OFONJFECFAH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct CFMNPOEOPEP
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static LKKJDCJIBEF NNNBCNOJAMM;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4810480", Offset = "0x480F280", VA = "0x184810480")]
				public static PlayerLoopSystem OFONJFECFAH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct NJHCLLBMOCE
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class LJEPAHEGFCA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public DMKMGJFNKEF.KBJJPIDABFF key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
					public LJEPAHEGFCA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x481B430", Offset = "0x481A230", VA = "0x18481B430")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable DCCDOKDLBAD;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x481C7C0", Offset = "0x481B5C0", VA = "0x18481C7C0")]
				public static PlayerLoopSystem EAEJJMKFIFP(DMKMGJFNKEF.KBJJPIDABFF IFKOMGEEEMC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct PJPAJIEMCCH
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class GPFHPIDBGIM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public DMKMGJFNKEF.KBJJPIDABFF key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
					public GPFHPIDBGIM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x4814F60", Offset = "0x4813D60", VA = "0x184814F60")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x481D190", Offset = "0x481BF90", VA = "0x18481D190")]
				public static PlayerLoopSystem EAEJJMKFIFP(DMKMGJFNKEF.KBJJPIDABFF IFKOMGEEEMC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JENCBNILJLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public JENCBNILJLG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x48170B0", Offset = "0x4815EB0", VA = "0x1848170B0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool FGKCCJMCBHB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ACBNDICFGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4811EC0", Offset = "0x4810CC0", VA = "0x184811EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x48123A0", Offset = "0x48111A0", VA = "0x1848123A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4810C40", Offset = "0x480FA40", VA = "0x184810C40")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4810A70", Offset = "0x480F870", VA = "0x184810A70")]
		private static void APDANGKPAIF(DMKMGJFNKEF.KBJJPIDABFF IFKOMGEEEMC, ref PlayerLoopSystem JELDNEIMIEK, Type LHBMEHMLKGH, Type AOJFAAKKOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4812020", Offset = "0x4810E20", VA = "0x184812020")]
		private static void ODCLDFEMACH(ref PlayerLoopSystem JELDNEIMIEK, Type LHBMEHMLKGH, Type AOJFAAKKOEK, FJJHJOMKEHF JOCLAKEHICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4811F00", Offset = "0x4810D00", VA = "0x184811F00")]
		private static void ENPIPGAFJCE(ref PlayerLoopSystem JELDNEIMIEK, Type LHBMEHMLKGH, Type AOJFAAKKOEK, PlayerLoopSystem? CJNBEAMAMKG, PlayerLoopSystem? OHOJHCFLOJM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DMKMGJFNKEF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KBJJPIDABFF
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
	public class CAFIEBJIPLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KBJJPIDABFF ECFBFOFGEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly JHADGPKMDJB CCKEJHBMAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long ILGGNEHHABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long DBGOIEEIJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long FKFLLBBHDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int KPACPCNPNOC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x480FF80", Offset = "0x480ED80", VA = "0x18480FF80")]
		public CAFIEBJIPLG(KBJJPIDABFF LNDCAGPJLJG, int FJAEHFKOOLF = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x480FF60", Offset = "0x480ED60", VA = "0x18480FF60")]
		public void ILHMNDEIMMO(int OFHJJCACKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x480FEF0", Offset = "0x480ECF0", VA = "0x18480FEF0")]
		public void HPMIPKDEOMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x480FC20", Offset = "0x480EA20", VA = "0x18480FC20")]
		public void BLMCBEMFGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x480FD20", Offset = "0x480EB20", VA = "0x18480FD20")]
		public void HHMKLCHJCNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x480FC80", Offset = "0x480EA80", VA = "0x18480FC80")]
		public double BNKMNAEENMK(int NPFHMBJHGDC)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int FLLNKFDPNHP = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static KBJJPIDABFF[] IDBGOPOIABC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static CAFIEBJIPLG[] AAAFJIMANAD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4812B60", Offset = "0x4811960", VA = "0x184812B60")]
	public static CAFIEBJIPLG KJPMFBDAMOI(KBJJPIDABFF IFKOMGEEEMC, int FJAEHFKOOLF = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4812AD0", Offset = "0x48118D0", VA = "0x184812AD0")]
	public static CAFIEBJIPLG CIMFNOMAGLG(KBJJPIDABFF IFKOMGEEEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4812A20", Offset = "0x4811820", VA = "0x184812A20")]
	public static void BMGJOJDMJOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JHADGPKMDJB : KFCPJJKEOCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int ANPMGICJKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> JFKMLOPOMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double GJMMLPKFABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double IPDCECLMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double NMGOHGPEMLD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KPLMIIMNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x48171B0", Offset = "0x4815FB0", VA = "0x1848171B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LAAGJBABMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4817360", Offset = "0x4816160", VA = "0x184817360", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LGKFJFIPBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10CC0C0", Offset = "0x10CAEC0", VA = "0x1810CC0C0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double CDPOBENFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE88560", Offset = "0xE87360", VA = "0x180E88560", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48173C0", Offset = "0x48161C0", VA = "0x1848173C0")]
	public JHADGPKMDJB(int KEPONADGAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x48171F0", Offset = "0x4815FF0", VA = "0x1848171F0", Slot = "4")]
	public void FFCCJACNCPH(double HGHHGPACLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x48172F0", Offset = "0x48160F0", VA = "0x1848172F0", Slot = "5")]
	public void FJGFFBLJIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DFHHCEBOIIN : KFCPJJKEOCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long FDHPLBOBCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double FGMLNGLDGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double LHHFCBDHPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double MDGFJKPABKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double OBADHHJMAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double GJMMLPKFABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double IPDCECLMOMH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LGKFJFIPBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x10CC0B0", Offset = "0x10CAEB0", VA = "0x1810CC0B0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double CDPOBENFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xDDB060", Offset = "0xDD9E60", VA = "0x180DDB060", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double NHFODDOCEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE88560", Offset = "0xE87360", VA = "0x180E88560")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DNEDJFNPJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE88550", Offset = "0xE87350", VA = "0x180E88550")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double LAAGJBABMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x10CBFD0", Offset = "0x10CADD0", VA = "0x1810CBFD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x48127C0", Offset = "0x48115C0", VA = "0x1848127C0", Slot = "4")]
	public void FFCCJACNCPH(double HGHHGPACLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x48128E0", Offset = "0x48116E0", VA = "0x1848128E0", Slot = "5")]
	public void FJGFFBLJIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4812920", Offset = "0x4811720", VA = "0x184812920")]
	public DFHHCEBOIIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KFCPJJKEOCM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LAAGJBABMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LGKFJFIPBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double CDPOBENFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FFCCJACNCPH(double HGHHGPACLPK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJGFFBLJIND();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GNDBLFABFIC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface IJJGDLEGLCI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool NPDFOMOGPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ALCOILIHPJM();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LOCNBBKNFPC();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class INJFFEOHBBH<TPromise, TMainThreadPromise> : IJJGDLEGLCI where TPromise : PCDEFPAPNCL where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise MIHOPJPKJKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise HCFIAEDGMCO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise LNBFKHPIEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x28C32B0", Offset = "0x28C20B0", VA = "0x1828C32B0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NPDFOMOGPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x28C3230", Offset = "0x28C2030", VA = "0x1828C3230", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x28C3310", Offset = "0x28C2110", VA = "0x1828C3310")]
		protected INJFFEOHBBH(TPromise MIHOPJPKJKG, TMainThreadPromise FDMIKECFBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x28C3280", Offset = "0x28C2080", VA = "0x1828C3280", Slot = "5")]
		public void ALCOILIHPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xDB5D80", Offset = "0xDB4B80", VA = "0x180DB5D80", Slot = "6")]
		public void LOCNBBKNFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void LHALPNOECDA(TPromise MIHOPJPKJKG);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void PHEABHHIANJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class MGBHHEFBKHJ<T> : INJFFEOHBBH<global::CBNPJNGNOBA<T>, global::CDLEAIJLAJI<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x28C3630", Offset = "0x28C2430", VA = "0x1828C3630")]
		public MGBHHEFBKHJ(global::CBNPJNGNOBA<T> MIHOPJPKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x28C33D0", Offset = "0x28C21D0", VA = "0x1828C33D0", Slot = "7")]
		protected override void LHALPNOECDA(global::CBNPJNGNOBA<T> MIHOPJPKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x28C35D0", Offset = "0x28C23D0", VA = "0x1828C35D0", Slot = "8")]
		protected override void PHEABHHIANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x28C3370", Offset = "0x28C2170", VA = "0x1828C3370")]
		[CompilerGenerated]
		private void FGJFIBFLHDD(T OEKNFPMCAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x28C33A0", Offset = "0x28C21A0", VA = "0x1828C33A0")]
		[CompilerGenerated]
		private void HHDAGKEGAIK(string IHOKHFNAGGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class LOMLMNMEMJO : INJFFEOHBBH<PCDEFPAPNCL, NLHJDENEFGK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x481C310", Offset = "0x481B110", VA = "0x18481C310")]
		public LOMLMNMEMJO(PCDEFPAPNCL MIHOPJPKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x481C1F0", Offset = "0x481AFF0", VA = "0x18481C1F0", Slot = "7")]
		protected override void LHALPNOECDA(PCDEFPAPNCL MIHOPJPKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x481C2C0", Offset = "0x481B0C0", VA = "0x18481C2C0", Slot = "8")]
		protected override void PHEABHHIANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1F37570", Offset = "0x1F36370", VA = "0x181F37570")]
		[CompilerGenerated]
		private void FGJFIBFLHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2305DF0", Offset = "0x2304BF0", VA = "0x182305DF0")]
		[CompilerGenerated]
		private void HHDAGKEGAIK(string IHOKHFNAGGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class BCBACNJEAGE : IJJGDLEGLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action DIKCECEKHKC;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NPDFOMOGPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x522FE0", Offset = "0x521DE0", VA = "0x180522FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x593550", Offset = "0x592350", VA = "0x180593550")]
		public BCBACNJEAGE(Action DIKCECEKHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x10DC040", Offset = "0x10DAE40", VA = "0x1810DC040", Slot = "5")]
		public void ALCOILIHPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "6")]
		public void LOCNBBKNFPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<IJJGDLEGLCI> PEHCFHJGGAP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x26AB0F0", Offset = "0x26A9EF0", VA = "0x1826AB0F0")]
	public static global::CBNPJNGNOBA<T> NGNGPGIDOFP<T>(this global::CBNPJNGNOBA<T> MIHOPJPKJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4814870", Offset = "0x4813670", VA = "0x184814870")]
	public static PCDEFPAPNCL NGNGPGIDOFP(this PCDEFPAPNCL MIHOPJPKJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4814980", Offset = "0x4813780", VA = "0x184814980")]
	public static void NGNGPGIDOFP(Action DIKCECEKHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x26AB030", Offset = "0x26A9E30", VA = "0x1826AB030")]
	private static global::CBNPJNGNOBA<T> CKKCGGFLFBH<T>(global::CBNPJNGNOBA<T> MIHOPJPKJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x48144F0", Offset = "0x48132F0", VA = "0x1848144F0")]
	private static PCDEFPAPNCL CKKCGGFLFBH(PCDEFPAPNCL MIHOPJPKJKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4814680", Offset = "0x4813480", VA = "0x184814680")]
	private static void JCOICNDJIEG(IJJGDLEGLCI EGBLOONPNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x48141D0", Offset = "0x4812FD0", VA = "0x1848141D0")]
	private static void BNGIMANIKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4814A10", Offset = "0x4813810", VA = "0x184814A10")]
	private static void OIANAJMCDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x48145D0", Offset = "0x48133D0", VA = "0x1848145D0")]
	private static void DDCDOFBHEKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class HFPDDBBHEBK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PJOANNKNDAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NLHJDENEFGK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public PJOANNKNDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x481CF90", Offset = "0x481BD90", VA = "0x18481CF90")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x481CF80", Offset = "0x481BD80", VA = "0x18481CF80")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GDDHOMIECNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public GDDHOMIECNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x48141A0", Offset = "0x4812FA0", VA = "0x1848141A0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GNIGHMCKEAA : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NLHJDENEFGK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public GNIGHMCKEAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4814E60", Offset = "0x4813C60", VA = "0x184814E60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4814B40", Offset = "0x4813940", VA = "0x184814B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4814F10", Offset = "0x4813D10", VA = "0x184814F10")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4814E10", Offset = "0x4813C10", VA = "0x184814E10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MEDNCGPFLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NLHJDENEFGK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public MEDNCGPFLGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CPMIMIIEBPK : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NLHJDENEFGK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private MEDNCGPFLGP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public CPMIMIIEBPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4810690", Offset = "0x480F490", VA = "0x184810690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4810A20", Offset = "0x480F820", VA = "0x184810A20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string MPFPNLPAJJN = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string JKHNPAPJPJF = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string CKPPPFPBKDM = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string IHOEDDABCOE = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string ANAMGCFCLAK = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float KMGGMNDKFGJ = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static PCDEFPAPNCL BPNJLJCCJIH;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation NFAHHEBOKMF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static PCDEFPAPNCL FOIHJDHEEPK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string OPEBLOBHGMG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority ACEMPAFDPPK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool JGHOFKGFPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x48151F0", Offset = "0x4813FF0", VA = "0x1848151F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool OILAPHGOOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x48159B0", Offset = "0x48147B0", VA = "0x1848159B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool KNKMGHLAENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4815720", Offset = "0x4814520", VA = "0x184815720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HDIIABMMBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4815670", Offset = "0x4814470", VA = "0x184815670")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4815510", Offset = "0x4814310", VA = "0x184815510")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x48155C0", Offset = "0x48143C0", VA = "0x1848155C0")]
	[LNPBCMJNPOF(KMPCCFGDDMG.EnteredEditModeNextFrame, 0)]
	private static void HCBICAEOPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4815320", Offset = "0x4814120", VA = "0x184815320")]
	public static PCDEFPAPNCL DAGFBFCFPKO(string CFMPJJPINDC, LoadSceneMode NMLHBANNKOL = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4815780", Offset = "0x4814580", VA = "0x184815780")]
	public static PCDEFPAPNCL OFBGKCGJKJM(string CFMPJJPINDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4815290", Offset = "0x4814090", VA = "0x184815290")]
	[IteratorStateMachine(typeof(GNIGHMCKEAA))]
	private static IEnumerator<JBHCACLLONB> CGCBBKPBLHL(string CFMPJJPINDC, NLHJDENEFGK GFDAEKANNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4815480", Offset = "0x4814280", VA = "0x184815480")]
	[IteratorStateMachine(typeof(CPMIMIIEBPK))]
	private static IEnumerator<JBHCACLLONB> DHPGJDCODOH(string CFMPJJPINDC, LoadSceneMode NMLHBANNKOL, NLHJDENEFGK GFDAEKANNCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class GCNKGEPKHAB
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4814020", Offset = "0x4812E20", VA = "0x184814020")]
	public static IDisposable OKHICJNMECE(this FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48140A0", Offset = "0x4812EA0", VA = "0x1848140A0")]
	public static IDisposable OKHICJNMECE(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4813A30", Offset = "0x4812830", VA = "0x184813A30")]
	public static IDisposable DGAKLPBJJGK(this FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4813C10", Offset = "0x4812A10", VA = "0x184813C10")]
	public static IDisposable HPILANEBJBO(this FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48137C0", Offset = "0x48125C0", VA = "0x1848137C0")]
	public static IDisposable AHBPIIFKKHB(this FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4813B20", Offset = "0x4812920", VA = "0x184813B20")]
	public static IDisposable FFMEBMPOHMG(this FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4813EA0", Offset = "0x4812CA0", VA = "0x184813EA0")]
	public static IDisposable JMNPPKOKOBE(this FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4813F10", Offset = "0x4812D10", VA = "0x184813F10")]
	public static IDisposable LEHBDCIMFPJ(this FJFKFCKFAIE MILHAHGHJGA, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4813AA0", Offset = "0x48128A0", VA = "0x184813AA0")]
	public static IDisposable ELAHHJAHKJC(this FJFKFCKFAIE MILHAHGHJGA, float EFCLDIMDMOF, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x48138B0", Offset = "0x48126B0", VA = "0x1848138B0")]
	public static IDisposable BJOFDBAHPIB(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4813B90", Offset = "0x4812990", VA = "0x184813B90")]
	public static IDisposable GKBKCOCDJFC(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4814120", Offset = "0x4812F20", VA = "0x184814120")]
	public static IDisposable PNLLBNLJNOA(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4813E10", Offset = "0x4812C10", VA = "0x184813E10")]
	public static IDisposable JLBKFOHHEAD(this FJFKFCKFAIE MILHAHGHJGA, float EFCLDIMDMOF, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4813930", Offset = "0x4812730", VA = "0x184813930")]
	public static IDisposable CFBHLGPPAPE(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4813FA0", Offset = "0x4812DA0", VA = "0x184813FA0")]
	public static IDisposable LJPBEFODMJI(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4813D90", Offset = "0x4812B90", VA = "0x184813D90")]
	public static IDisposable JLBILFILGIJ(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4813C80", Offset = "0x4812A80", VA = "0x184813C80")]
	public static IDisposable IKCHFOBLGIP(this FJFKFCKFAIE MILHAHGHJGA, float EFCLDIMDMOF, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48139B0", Offset = "0x48127B0", VA = "0x1848139B0")]
	public static IDisposable DBNIJNKDIHH(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4813830", Offset = "0x4812630", VA = "0x184813830")]
	public static IDisposable BFAFGCAPBML(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4813D10", Offset = "0x4812B10", VA = "0x184813D10")]
	public static IDisposable JBPDOPDCCKN(this FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AHLGKGGGFOK
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x480E230", Offset = "0x480D030", VA = "0x18480E230")]
	public static IDisposable NCJCBBMDJPD(this MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x480E1B0", Offset = "0x480CFB0", VA = "0x18480E1B0")]
	public static IDisposable NCJCBBMDJPD(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x480DDD0", Offset = "0x480CBD0", VA = "0x18480DDD0")]
	public static IDisposable IFLCLMJCIDJ(this MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x480D6E0", Offset = "0x480C4E0", VA = "0x18480D6E0")]
	public static IDisposable ADJLEOCOBMP(this MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x480D7F0", Offset = "0x480C5F0", VA = "0x18480D7F0")]
	public static IDisposable BJELINAJEBC(this MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x480DD60", Offset = "0x480CB60", VA = "0x18480DD60")]
	public static IDisposable HIIDKDMMAGJ(this MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x480DB40", Offset = "0x480C940", VA = "0x18480DB40")]
	public static IDisposable EBMPEOAODJH(this MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x480D750", Offset = "0x480C550", VA = "0x18480D750")]
	public static IDisposable AIKBDNCHOGL(this MonoBehaviour POLNMJBCCJF, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x480DED0", Offset = "0x480CCD0", VA = "0x18480DED0")]
	public static IDisposable JMHKAKNGKBE(this MonoBehaviour POLNMJBCCJF, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x480DE40", Offset = "0x480CC40", VA = "0x18480DE40")]
	public static IDisposable JEGAKCIONOE(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x480DCD0", Offset = "0x480CAD0", VA = "0x18480DCD0")]
	public static IDisposable FPFEOIMHONM(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x480E120", Offset = "0x480CF20", VA = "0x18480E120")]
	public static IDisposable MMGHGKLCGDM(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x480DBB0", Offset = "0x480C9B0", VA = "0x18480DBB0")]
	public static IDisposable FBDMJPFBLAD(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x480D8F0", Offset = "0x480C6F0", VA = "0x18480D8F0")]
	public static IDisposable DBCLDDIFDDH(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x480DA10", Offset = "0x480C810", VA = "0x18480DA10")]
	public static IDisposable DOIINHKPBLG(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x480DFF0", Offset = "0x480CDF0", VA = "0x18480DFF0")]
	public static IDisposable LALAIJCENME(this MonoBehaviour POLNMJBCCJF, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x480E2B0", Offset = "0x480D0B0", VA = "0x18480E2B0")]
	public static IDisposable OGCGNPODDEC(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x480E090", Offset = "0x480CE90", VA = "0x18480E090")]
	public static IDisposable LCDFFKJAPEI(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x480DC40", Offset = "0x480CA40", VA = "0x18480DC40")]
	public static IDisposable FMNBCLNHOJF(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x480DAA0", Offset = "0x480C8A0", VA = "0x18480DAA0")]
	public static IDisposable EBJEDLIHJEM(this MonoBehaviour POLNMJBCCJF, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x480D980", Offset = "0x480C780", VA = "0x18480D980")]
	public static IDisposable DICFJDABDEI(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x480D860", Offset = "0x480C660", VA = "0x18480D860")]
	public static IDisposable BMKAGDDEGFK(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x480DF60", Offset = "0x480CD60", VA = "0x18480DF60")]
	public static IDisposable KOACCNGCDDD(this MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LMDKLFDJINA
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MJHHGBJHFEH : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DIFOGFDGGIP.JJAOFAKCOIJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private FKBGFCFMKDH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public MJHHGBJHFEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x481C4D0", Offset = "0x481B2D0", VA = "0x18481C4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x481C590", Offset = "0x481B390", VA = "0x18481C590", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class PGLLNJMKAMF : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public DIFOGFDGGIP.JJAOFAKCOIJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private FKBGFCFMKDH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public PGLLNJMKAMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x481CB20", Offset = "0x481B920", VA = "0x18481CB20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x481CC00", Offset = "0x481BA00", VA = "0x18481CC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x481BCE0", Offset = "0x481AAE0", VA = "0x18481BCE0")]
	public static OIOIEKMKHHG NCJCBBMDJPD(Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x481BEE0", Offset = "0x481ACE0", VA = "0x18481BEE0")]
	public static OIOIEKMKHHG NCJCBBMDJPD(Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x481BBD0", Offset = "0x481A9D0", VA = "0x18481BBD0")]
	public static OIOIEKMKHHG NCJCBBMDJPD(Behaviour MILHAHGHJGA, Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x481BDD0", Offset = "0x481ABD0", VA = "0x18481BDD0")]
	public static OIOIEKMKHHG NCJCBBMDJPD(Behaviour MILHAHGHJGA, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x481C0E0", Offset = "0x481AEE0", VA = "0x18481C0E0")]
	public static OIOIEKMKHHG OKHICJNMECE(FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x481BFD0", Offset = "0x481ADD0", VA = "0x18481BFD0")]
	public static OIOIEKMKHHG OKHICJNMECE(FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x481BB50", Offset = "0x481A950", VA = "0x18481BB50")]
	[IteratorStateMachine(typeof(MJHHGBJHFEH))]
	private static IEnumerator<JBHCACLLONB> CGGELJBBLNG(DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP, Action KCMFADLFGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x481BAD0", Offset = "0x481A8D0", VA = "0x18481BAD0")]
	[IteratorStateMachine(typeof(PGLLNJMKAMF))]
	private static IEnumerator<JBHCACLLONB> CGGELJBBLNG(DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP, Action<float> KCMFADLFGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class IADCPBPKOKF
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PIJCGLIKCAH : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DIFOGFDGGIP.JJAOFAKCOIJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private CLCGJOJKOPP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public PIJCGLIKCAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x481CC50", Offset = "0x481BA50", VA = "0x18481CC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x481CD60", Offset = "0x481BB60", VA = "0x18481CD60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4815C30", Offset = "0x4814A30", VA = "0x184815C30")]
	public static OIOIEKMKHHG NCJCBBMDJPD(float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4815B70", Offset = "0x4814970", VA = "0x184815B70")]
	public static OIOIEKMKHHG NCJCBBMDJPD(MonoBehaviour POLNMJBCCJF, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4815A10", Offset = "0x4814810", VA = "0x184815A10")]
	public static OIOIEKMKHHG CDNJKDOCNHM(FJFKFCKFAIE MILHAHGHJGA, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, bool ECPDJOODNMP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4815AD0", Offset = "0x48148D0", VA = "0x184815AD0")]
	[IteratorStateMachine(typeof(PIJCGLIKCAH))]
	private static IEnumerator<JBHCACLLONB> CGGELJBBLNG(float EFCLDIMDMOF, DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP, Action<float> KCMFADLFGOE, bool ECPDJOODNMP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MOALLBILENN
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class OCKGNDEDICC : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DIFOGFDGGIP.JJAOFAKCOIJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public OCKGNDEDICC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x481C8E0", Offset = "0x481B6E0", VA = "0x18481C8E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x481C990", Offset = "0x481B790", VA = "0x18481C990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x481C740", Offset = "0x481B540", VA = "0x18481C740")]
	[IteratorStateMachine(typeof(OCKGNDEDICC))]
	private static IEnumerator<JBHCACLLONB> FHCAABFHLOG(DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, Func<bool> HLGLPNKFAOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x481C5E0", Offset = "0x481B3E0", VA = "0x18481C5E0")]
	public static OIOIEKMKHHG ELPGPBGGEKC(this MonoBehaviour POLNMJBCCJF, Func<bool> HLGLPNKFAOI, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE = DIFOGFDGGIP.JJAOFAKCOIJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KGNDCPGKNHF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EEPGACPFJOB : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DIFOGFDGGIP.JJAOFAKCOIJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public EEPGACPFJOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4812E30", Offset = "0x4811C30", VA = "0x184812E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4812EF0", Offset = "0x4811CF0", VA = "0x184812EF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LGFHHHONMML : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DIFOGFDGGIP.JJAOFAKCOIJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private JBHCACLLONB <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public LGFHHHONMML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x481B310", Offset = "0x481A110", VA = "0x18481B310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x481B3E0", Offset = "0x481A1E0", VA = "0x18481B3E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x481A020", Offset = "0x4818E20", VA = "0x18481A020")]
	[IteratorStateMachine(typeof(EEPGACPFJOB))]
	private static IEnumerator<JBHCACLLONB> IJMLINOHNKJ(float LEGFMECKOED, DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4819D80", Offset = "0x4818B80", VA = "0x184819D80")]
	[IteratorStateMachine(typeof(LGFHHHONMML))]
	private static IEnumerator<JBHCACLLONB> HHALGIMBKKL(float LEGFMECKOED, DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4819780", Offset = "0x4818580", VA = "0x184819780")]
	public static IDisposable ADDMMNJKOJK(this MonoBehaviour POLNMJBCCJF, float LEGFMECKOED, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4819F20", Offset = "0x4818D20", VA = "0x184819F20")]
	public static OIOIEKMKHHG IJBEPHDAODG(this MonoBehaviour POLNMJBCCJF, float LEGFMECKOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x48198D0", Offset = "0x48186D0", VA = "0x1848198D0")]
	public static OIOIEKMKHHG ADDMMNJKOJK(this MonoBehaviour POLNMJBCCJF, float LEGFMECKOED, DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x481A0B0", Offset = "0x4818EB0", VA = "0x18481A0B0")]
	public static OIOIEKMKHHG MLJGGCLOLEM(this MonoBehaviour POLNMJBCCJF, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4819A30", Offset = "0x4818830", VA = "0x184819A30")]
	public static OIOIEKMKHHG AKCDNIDAOPD(this MonoBehaviour POLNMJBCCJF, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x481A0C0", Offset = "0x4818EC0", VA = "0x18481A0C0")]
	public static OIOIEKMKHHG MPFPKNOJENK(this MonoBehaviour POLNMJBCCJF, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x481A0D0", Offset = "0x4818ED0", VA = "0x18481A0D0")]
	public static OIOIEKMKHHG NCMIDIJAOGE(this MonoBehaviour POLNMJBCCJF, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4819A40", Offset = "0x4818840", VA = "0x184819A40")]
	public static OIOIEKMKHHG DANCGEFJKKE(this MonoBehaviour POLNMJBCCJF, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x481A1F0", Offset = "0x4818FF0", VA = "0x18481A1F0")]
	private static OIOIEKMKHHG PGCKFENLMMA(MonoBehaviour POLNMJBCCJF, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4819B60", Offset = "0x4818960", VA = "0x184819B60")]
	public static OIOIEKMKHHG FILIIPINFMG(this MonoBehaviour POLNMJBCCJF, float DGHNDJFHIOE, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x481A0E0", Offset = "0x4818EE0", VA = "0x18481A0E0")]
	public static OIOIEKMKHHG OHLJFFBEHCO(this MonoBehaviour POLNMJBCCJF, float DGHNDJFHIOE, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4819A50", Offset = "0x4818850", VA = "0x184819A50")]
	public static OIOIEKMKHHG EJIMIIAMNFH(this MonoBehaviour POLNMJBCCJF, float DGHNDJFHIOE, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4819E10", Offset = "0x4818C10", VA = "0x184819E10")]
	public static OIOIEKMKHHG HMHHHKMNEHD(this MonoBehaviour POLNMJBCCJF, float DGHNDJFHIOE, Action FENIMACHIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4819C70", Offset = "0x4818A70", VA = "0x184819C70")]
	public static OIOIEKMKHHG HCNKLKGPODB(this MonoBehaviour POLNMJBCCJF, float DGHNDJFHIOE, Action FENIMACHIPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class EPAPCLCLOEL : AEMPIGLOMFN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class BPMBMFJKJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public EPAPCLCLOEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public BPMBMFJKJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x480FBF0", Offset = "0x480E9F0", VA = "0x18480FBF0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class LJGLKKAJAKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public EPAPCLCLOEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public LJGLKKAJAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x480FBF0", Offset = "0x480E9F0", VA = "0x18480FBF0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float DGMAPPDMKNH;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4813100", Offset = "0x4811F00", VA = "0x184813100")]
	public EPAPCLCLOEL(Behaviour MILHAHGHJGA, float DGMAPPDMKNH, [Optional] Action IEBKOKDNGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4813020", Offset = "0x4811E20", VA = "0x184813020", Slot = "9")]
	protected override bool LLACIFBBKDP(Action DIKCECEKHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4812F40", Offset = "0x4811D40", VA = "0x184812F40", Slot = "10")]
	protected override bool FDMGAOLLGFL(Action DIKCECEKHKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface AFFFOBMKEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ENGAKCGHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MJLMOJEADOE;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDHMOANCCIH(bool ANDMDMBPIBE = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DDHMOANCCIH(Action DIKCECEKHKC, bool ANDMDMBPIBE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class AEMPIGLOMFN : AFFFOBMKEPC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class AGOCIHALMAB : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public AGOCIHALMAB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x480D5F0", Offset = "0x480C3F0", VA = "0x18480D5F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x480D690", Offset = "0x480C490", VA = "0x18480D690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour MILHAHGHJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action IEBKOKDNGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private BGKJFFOOBBF MICHNIKBMGG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ENGAKCGHIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1040E40", Offset = "0x103FC40", VA = "0x181040E40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MJLMOJEADOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x480D2E0", Offset = "0x480C0E0", VA = "0x18480D2E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x480D130", Offset = "0x480BF30", VA = "0x18480D130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x480D5A0", Offset = "0x480C3A0", VA = "0x18480D5A0")]
	protected AEMPIGLOMFN(Behaviour MILHAHGHJGA, [Optional] Action IEBKOKDNGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x480D1D0", Offset = "0x480BFD0", VA = "0x18480D1D0", Slot = "7")]
	public bool DDHMOANCCIH(bool ANDMDMBPIBE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x480D230", Offset = "0x480C030", VA = "0x18480D230", Slot = "8")]
	public bool DDHMOANCCIH(Action DIKCECEKHKC, bool ANDMDMBPIBE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LLACIFBBKDP(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FDMGAOLLGFL(Action DIKCECEKHKC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x480D0A0", Offset = "0x480BEA0", VA = "0x18480D0A0")]
	protected void AOMIMMOFPOF(Action DIKCECEKHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x480D3C0", Offset = "0x480C1C0", VA = "0x18480D3C0")]
	protected PCDEFPAPNCL PNHCBDGFLNF(float HCNDCABBEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x480D0C0", Offset = "0x480BEC0", VA = "0x18480D0C0")]
	private void CFIOGFNDPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x480D280", Offset = "0x480C080", VA = "0x18480D280")]
	[IteratorStateMachine(typeof(AGOCIHALMAB))]
	private static IEnumerator<JBHCACLLONB> EGDIELLFIFC(float HCNDCABBEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x480D380", Offset = "0x480C180", VA = "0x18480D380")]
	[CompilerGenerated]
	private void MLPNCADLEAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DEHDHBAEPPF : AEMPIGLOMFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float IBFBLFJFCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int CFEDGCAFKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float OGHBMGAGCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] JKHBAJHLBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int FJJBGCKOPKC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KEKLNPALAGC IACIGCMODEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4812690", Offset = "0x4811490", VA = "0x184812690")]
	public DEHDHBAEPPF(Behaviour MILHAHGHJGA, float PDGOPKKANKN, int CFEDGCAFKPI, [Optional] Action IEBKOKDNGPI, float OGHBMGAGCFA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x522EC0", Offset = "0x521CC0", VA = "0x180522EC0", Slot = "9")]
	protected override bool LLACIFBBKDP(Action DIKCECEKHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x48123E0", Offset = "0x48111E0", VA = "0x1848123E0", Slot = "10")]
	protected override bool FDMGAOLLGFL(Action DIKCECEKHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4812600", Offset = "0x4811400", VA = "0x184812600")]
	private void PPANAIMIKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FMMBHPHLJIB : AEMPIGLOMFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float DGMAPPDMKNH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4813100", Offset = "0x4811F00", VA = "0x184813100")]
	public FMMBHPHLJIB(Behaviour MILHAHGHJGA, float DGMAPPDMKNH, [Optional] Action IEBKOKDNGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x522EC0", Offset = "0x521CC0", VA = "0x180522EC0", Slot = "9")]
	protected override bool LLACIFBBKDP(Action DIKCECEKHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x48131F0", Offset = "0x4811FF0", VA = "0x1848131F0", Slot = "10")]
	protected override bool FDMGAOLLGFL(Action DIKCECEKHKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class KHHBMNJIPCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class KPJCPHHKMFP : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public KPJCPHHKMFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x481B1C0", Offset = "0x4819FC0", VA = "0x18481B1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x481B2C0", Offset = "0x481A0C0", VA = "0x18481B2C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private OIOIEKMKHHG JICAGDNPNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private FJFKFCKFAIE MILHAHGHJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action KCMFADLFGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> ONPEMNANKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float KHCLKGNMFHH;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x481B000", Offset = "0x4819E00", VA = "0x18481B000")]
	public KHHBMNJIPCI(FJFKFCKFAIE MILHAHGHJGA, Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x481AE40", Offset = "0x4819C40", VA = "0x18481AE40")]
	public KHHBMNJIPCI(FJFKFCKFAIE MILHAHGHJGA, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x481ACC0", Offset = "0x4819AC0", VA = "0x18481ACC0")]
	public KHHBMNJIPCI(FJFKFCKFAIE MILHAHGHJGA, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x481AB30", Offset = "0x4819930", VA = "0x18481AB30")]
	private void NCJCBBMDJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x481A4D0", Offset = "0x48192D0", VA = "0x18481A4D0")]
	private void AFNAECLDBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x481A750", Offset = "0x4819550", VA = "0x18481A750")]
	private void DNLLPODNAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x481AA00", Offset = "0x4819800", VA = "0x18481AA00")]
	private void MLLGFKLFCJA(string IHOKHFNAGGO, Action AOEMPCGMMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x481A660", Offset = "0x4819460", VA = "0x18481A660")]
	[IteratorStateMachine(typeof(KPJCPHHKMFP))]
	private IEnumerator<JBHCACLLONB> BFKLIHLBBJP(Action AOEMPCGMMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x481A8A0", Offset = "0x48196A0", VA = "0x18481A8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x481A6D0", Offset = "0x48194D0", VA = "0x18481A6D0")]
	[CompilerGenerated]
	private void CPDOHLJEGAO(string FLNLIILPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x481A900", Offset = "0x4819700", VA = "0x18481A900")]
	[CompilerGenerated]
	private void KKJIBCIMGBC(string FLNLIILPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x481A980", Offset = "0x4819780", VA = "0x18481A980")]
	[CompilerGenerated]
	private void MBGNIENAHNE(string FLNLIILPCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class IAEGAAIEGKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class POEFEJHAIGC : IEnumerator<JBHCACLLONB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private JBHCACLLONB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private JBHCACLLONB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
		[DebuggerHidden]
		public POEFEJHAIGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x481DA00", Offset = "0x481C800", VA = "0x18481DA00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x481DB00", Offset = "0x481C900", VA = "0x18481DB00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private OIOIEKMKHHG JICAGDNPNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour POLNMJBCCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action KCMFADLFGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> ONPEMNANKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float KHCLKGNMFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool ECPDJOODNMP;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4816840", Offset = "0x4815640", VA = "0x184816840")]
	public IAEGAAIEGKM(MonoBehaviour POLNMJBCCJF, Action KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4816680", Offset = "0x4815480", VA = "0x184816680")]
	public IAEGAAIEGKM(MonoBehaviour POLNMJBCCJF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x48164E0", Offset = "0x48152E0", VA = "0x1848164E0")]
	public IAEGAAIEGKM(MonoBehaviour POLNMJBCCJF, float EFCLDIMDMOF, Action<float> KCMFADLFGOE, DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE, bool ECPDJOODNMP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x48162D0", Offset = "0x48150D0", VA = "0x1848162D0")]
	private void NCJCBBMDJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4815CF0", Offset = "0x4814AF0", VA = "0x184815CF0")]
	private void AFNAECLDBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4815F70", Offset = "0x4814D70", VA = "0x184815F70")]
	private void DNLLPODNAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x48161A0", Offset = "0x4814FA0", VA = "0x1848161A0")]
	private void MLLGFKLFCJA(string IHOKHFNAGGO, Action AOEMPCGMMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4815E80", Offset = "0x4814C80", VA = "0x184815E80")]
	[IteratorStateMachine(typeof(POEFEJHAIGC))]
	private IEnumerator<JBHCACLLONB> BFKLIHLBBJP(Action AOEMPCGMMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x48160C0", Offset = "0x4814EC0", VA = "0x1848160C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4815EF0", Offset = "0x4814CF0", VA = "0x184815EF0")]
	[CompilerGenerated]
	private void CCMDHOCGGGB(string FLNLIILPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4816460", Offset = "0x4815260", VA = "0x184816460")]
	[CompilerGenerated]
	private void PPKFCPBIIKE(string FLNLIILPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4816120", Offset = "0x4814F20", VA = "0x184816120")]
	[CompilerGenerated]
	private void KKEALCAMBLN(string FLNLIILPCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface OBLOBLPLONM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int LNKLOMNFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PDPMFAGPKPD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly PDPMFAGPKPD HFMHLPNCPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action NHHAFFMKNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool PCDAJGPJMFE;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x593550", Offset = "0x592350", VA = "0x180593550")]
	public PDPMFAGPKPD(Action NHHAFFMKNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x481CA20", Offset = "0x481B820", VA = "0x18481CA20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface JDEPDNMBFHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CPIBPLAELIL(Action<T> MCIEPNMOCKC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable CPIBPLAELIL(UnityEngine.Object MILHAHGHJGA, Action<T> MCIEPNMOCKC);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface EJGKDJPDKJM<T> : global::JDEPDNMBFHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ONHOHCEODAK<T> : global::EJGKDJPDKJM<T>, global::JDEPDNMBFHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KECHPLLCNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::ONHOHCEODAK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::ALJHLAKNACE<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public KECHPLLCNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3538A60", Offset = "0x3537860", VA = "0x183538A60")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject FJIOFKOFNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::ALJHLAKNACE<UnityEngine.Object, Action<T>>> NOPILGMDJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T LJDACMEPBIM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object FBAAPAPBLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x353EB80", Offset = "0x353D980", VA = "0x18353EB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x769780", Offset = "0x768580", VA = "0x180769780", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x353F3F0", Offset = "0x353E1F0", VA = "0x18353F3F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x353E8D0", Offset = "0x353D6D0", VA = "0x18353E8D0")]
	private static bool HJONAFDOBCK(T OCNFPNPPOJC, T BAHCPBFJIGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x353F4D0", Offset = "0x353E2D0", VA = "0x18353F4D0")]
	public ONHOHCEODAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x353F5A0", Offset = "0x353E3A0", VA = "0x18353F5A0")]
	public ONHOHCEODAK(T NGKMDHIOOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x353E8B0", Offset = "0x353D6B0", VA = "0x18353E8B0")]
	public void HAKGFLOMBGN(T MBGAGEJIJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x353E540", Offset = "0x353D340", VA = "0x18353E540", Slot = "7")]
	public IDisposable CPIBPLAELIL(Action<T> MCIEPNMOCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x353E710", Offset = "0x353D510", VA = "0x18353E710", Slot = "8")]
	public IDisposable CPIBPLAELIL(UnityEngine.Object MILHAHGHJGA, Action<T> MCIEPNMOCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x353ED90", Offset = "0x353DB90", VA = "0x18353ED90")]
	private void NOADLIBEFEM()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<KFEGEFDGHAD, Scheduler>, KFEGEFDGHAD
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class CFAAMBFHNAK : OBLOBLPLONM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public JLHNDILDJEJ OCDGKJFBFPO;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int LNKLOMNFFKL
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x522ED0", Offset = "0x521CD0", VA = "0x180522ED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x522EE0", Offset = "0x521CE0", VA = "0x180522EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x48100A0", Offset = "0x480EEA0", VA = "0x1848100A0")]
			public static JBHCACLLONB EBBJMAMDBHH(IEnumerator<JBHCACLLONB> BBPJMMENHNH, PLPFJGKCJNJ ONDLHLPELBB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4810200", Offset = "0x480F000", VA = "0x184810200")]
			public JBHCACLLONB EBBJMAMDBHH(PLPFJGKCJNJ[] OOBGFOKEKBE, IEnumerator<JBHCACLLONB>[] NPFPNHDEGDA, JBHCACLLONB[] MMFMIANMPCN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4810070", Offset = "0x480EE70", VA = "0x184810070")]
			public void DMBIOKMCIKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x48103B0", Offset = "0x480F1B0", VA = "0x1848103B0")]
			public void NDCNFNMJFCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x48102E0", Offset = "0x480F0E0", VA = "0x1848102E0")]
			public void EDEGOCALPII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4810070", Offset = "0x480EE70", VA = "0x184810070")]
			public void LOCNBBKNFPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
			public CFAAMBFHNAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class JLHNDILDJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct AFOELHDKCHN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public CFAAMBFHNAK KJMKNGDJCAM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public FJFKFCKFAIE EOJLJKDNANO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public PLPFJGKCJNJ EBJFBJOEHEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<JBHCACLLONB> IANFCNOHOBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public JBHCACLLONB CNELHNCBNAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public HJCJMDKPJAG LDMABLOKLIJ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct HPLOLDEBKBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public DIFOGFDGGIP.JJAOFAKCOIJ CJOOFBNELCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<AFOELHDKCHN> IKEMAFFIBKO;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class INEGHJPIGFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public JLHNDILDJEJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public FJFKFCKFAIE context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public CFAAMBFHNAK routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public HJCJMDKPJAG coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public PLPFJGKCJNJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public JBHCACLLONB currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<JBHCACLLONB> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
				public INEGHJPIGFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x4816A00", Offset = "0x4815800", VA = "0x184816A00")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class OINCDPPHOAB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public CFAAMBFHNAK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public JLHNDILDJEJ <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
				public OINCDPPHOAB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x481C9E0", Offset = "0x481B7E0", VA = "0x18481C9E0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class CKLIODEMEDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public CFAAMBFHNAK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public JLHNDILDJEJ <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
				public CKLIODEMEDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x4810650", Offset = "0x480F450", VA = "0x184810650")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class DMGHBAFLJFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public CFAAMBFHNAK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public JLHNDILDJEJ <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
				public DMGHBAFLJFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x48129E0", Offset = "0x48117E0", VA = "0x1848129E0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] MOLPDEODOGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<HJCJMDKPJAG> NKEFGEFLOCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> INFCOHPCACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> CIGECCBGEPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> CDPKPMLPBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> HLFNLAPNKNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> JLKMJIJJEAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> OAAOPFFLMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private CFAAMBFHNAK[] AHAMKMDNGBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private PLPFJGKCJNJ[] OOBGFOKEKBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private FJFKFCKFAIE[] IKHENHHBJJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<JBHCACLLONB>[] BBOODMKKALI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private JBHCACLLONB[] GPPNBEHACOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int CHEGGLFLKEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int IMNCEOIPJNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int KNAEJNLEJCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float KFAJGBMJPJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private FONCFLKCMJN IICIAHDJJLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle DMHKJJAAPNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<CFAAMBFHNAK> CKNFNEGFDJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool NOJCMNCJAOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> IEIMKMDMFFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> GDICCGONMHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool NIBAGBKAOMD;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public HPLOLDEBKBC[] CLCLOEAMDHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x5CCCF0", Offset = "0x5CBAF0", VA = "0x1805CCCF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int DLIFCKKHDLF
			{
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x7697A0", Offset = "0x7685A0", VA = "0x1807697A0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4817F50", Offset = "0x4816D50", VA = "0x184817F50")]
			private static int HPDMEJELBOA(DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4819230", Offset = "0x4818030", VA = "0x184819230")]
			public JLHNDILDJEJ(DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4818A60", Offset = "0x4817860", VA = "0x184818A60")]
			private void NCOODGIOPFK(ref int OOODKCAJLKF, int NHHFLLOMGGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4818900", Offset = "0x4817700", VA = "0x184818900")]
			public void MAIFLJJPIMO(FJFKFCKFAIE MILHAHGHJGA, JBHCACLLONB GJDALMOGNNK, IEnumerator<JBHCACLLONB> BBPJMMENHNH, PLPFJGKCJNJ ONDLHLPELBB, [Optional] CFAAMBFHNAK PHLPBDNLBND, HJCJMDKPJAG KAPBCHKICAM = HJCJMDKPJAG.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4817F80", Offset = "0x4816D80", VA = "0x184817F80")]
			public void IHIMNBJJFFJ(IEnumerable<AFOELHDKCHN> PNGCPIOCEIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4817460", Offset = "0x4816260", VA = "0x184817460")]
			private AFOELHDKCHN BMKNLEIIAII(int CEHDIHBCKKB)
			{
				return default(AFOELHDKCHN);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4818230", Offset = "0x4817030", VA = "0x184818230")]
			private void KCJOFCEDMNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x29A47C0", Offset = "0x29A35C0", VA = "0x1829A47C0")]
			private static void JLHPELLJCOM<T>(int CEHDIHBCKKB, T[] FHNOLDNBOHE, int ILOELBIABFJ, [Optional] T OJNFJBLFHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x29A47A0", Offset = "0x29A35A0", VA = "0x1829A47A0")]
			private static void JLHPELLJCOM<T>(int CEHDIHBCKKB, NativeArray<T> FHNOLDNBOHE, int ILOELBIABFJ, [Optional] T OJNFJBLFHAA) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x48185A0", Offset = "0x48173A0", VA = "0x1848185A0")]
			private void KOAONBLJBLK(IEnumerable<AFOELHDKCHN> PNGCPIOCEIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4817C20", Offset = "0x4816A20", VA = "0x184817C20")]
			private void CLELJLMLKIO(AFOELHDKCHN HKIHEMEDHIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4817960", Offset = "0x4816760", VA = "0x184817960")]
			private KPKIPDAIBDC CFPKNELBOPB(int NBLOOHGBLJF)
			{
				return default(KPKIPDAIBDC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4817D60", Offset = "0x4816B60", VA = "0x184817D60")]
			public void DLAKKBMDNHA(float KIBCBHPGCJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x48178E0", Offset = "0x48166E0", VA = "0x1848178E0")]
			private void CBBFPMIDMMC(Action OCNFPNPPOJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x4817CE0", Offset = "0x4816AE0", VA = "0x184817CE0")]
			private void COHLEJNMOJO(Action OCNFPNPPOJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4818BF0", Offset = "0x48179F0", VA = "0x184818BF0")]
			public void PAIIBHMLLPN(float KIBCBHPGCJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4819090", Offset = "0x4817E90", VA = "0x184819090")]
			public void PKIKJPNJAMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4818840", Offset = "0x4817640", VA = "0x184818840")]
			public void LOCNBBKNFPC(CFAAMBFHNAK EHLIIGMFOMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4818170", Offset = "0x4816F70", VA = "0x184818170")]
			public void JHNDHNJKNHK(CFAAMBFHNAK EHLIIGMFOMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x4819170", Offset = "0x4817F70", VA = "0x184819170")]
			public void PPNNPFACMOC(CFAAMBFHNAK EHLIIGMFOMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct FONCFLKCMJN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float OEAHPBELCGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int HAPALPGHLCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> GEAJGFOOEAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> PJINICPGCDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> ECGGHPKBACB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<HJCJMDKPJAG> BKECNKGBHPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> AEMEIJAHFNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> HLFNLAPNKNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> CIGECCBGEPA;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x48135B0", Offset = "0x48123B0", VA = "0x1848135B0")]
			public static FONCFLKCMJN FBNMOHOMNBD(int GJFOMADIHGF, float KIBCBHPGCJA, NativeArray<HJCJMDKPJAG> IOGMJMOBBBN, NativeArray<float> BCAPDEJBJJD, NativeArray<int> GDMLEEEAIOG, NativeArray<int> HJLFLECFOAJ, NativeArray<int> LINIMLKKKJI, NativeArray<int> PJINICPGCDP, NativeArray<int> ECGGHPKBACB)
			{
				return default(FONCFLKCMJN);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x48134D0", Offset = "0x48122D0", VA = "0x1848134D0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4813780", Offset = "0x4812580", VA = "0x184813780")]
			private bool KFMBCMJFNHP(int IMDCPBGFCMD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4813750", Offset = "0x4812550", VA = "0x184813750")]
			private void IBFHJGONPMF(NativeArray<int> DGNLNACMLHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4813230", Offset = "0x4812030", VA = "0x184813230")]
			private int AHKAPBADAMC(int AJNBOLKKEGC, int AHPIAHNMHPC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4813680", Offset = "0x4812480", VA = "0x184813680")]
			private void HJNHELJJKHO(NativeArray<int> DGNLNACMLHM, int INGJBOICPHM, int PAPLNEJJJMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x48132A0", Offset = "0x48120A0", VA = "0x1848132A0")]
			private void ANAFCPBBFDC(NativeArray<int> DGNLNACMLHM, int DCDBFKJILDH, int OMAAHGKIHDO, int CJCAPOFMNHK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class LJMFPLJLCJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly PLPFJGKCJNJ ONDLHLPELBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour MILHAHGHJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool PPEKEMPIELJ;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<JBHCACLLONB> IANFCNOHOBN
			{
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public JBHCACLLONB CNELHNCBNAG
			{
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool AGIOGPHGHMC
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x481B4E0", Offset = "0x481A2E0", VA = "0x18481B4E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool LENAMIOHLFP
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x6982A0", Offset = "0x6970A0", VA = "0x1806982A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x6982C0", Offset = "0x6970C0", VA = "0x1806982C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string PDFFKONPKMF
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x523010", Offset = "0x521E10", VA = "0x180523010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x523020", Offset = "0x521E20", VA = "0x180523020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float OMOFBPOECOG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x89FDA0", Offset = "0x89EBA0", VA = "0x18089FDA0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0xBD2E80", Offset = "0xBD1C80", VA = "0x180BD2E80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x481B930", Offset = "0x481A730", VA = "0x18481B930")]
			public LJMFPLJLCJL(IEnumerator<JBHCACLLONB> BBPJMMENHNH, Behaviour MILHAHGHJGA, PLPFJGKCJNJ ONDLHLPELBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x481B570", Offset = "0x481A370", VA = "0x18481B570")]
			public JBHCACLLONB EBBJMAMDBHH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x481B780", Offset = "0x481A580", VA = "0x18481B780")]
			public bool HFKMGJAHBCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x481B810", Offset = "0x481A610", VA = "0x18481B810")]
			public void LOCNBBKNFPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x481B8A0", Offset = "0x481A6A0", VA = "0x18481B8A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1FB7DB0", Offset = "0x1FB6BB0", VA = "0x181FB7DB0")]
			[CompilerGenerated]
			private void FKKDJJHPDOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class PLPFJGKCJNJ : FPJNDLKFEOG, OIOIEKMKHHG, BGKJFFOOBBF, PCDEFPAPNCL, IEnumerator, JBHCACLLONB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private DIFOGFDGGIP.JJAOFAKCOIJ OMIJOJCEBPM;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private DIFOGFDGGIP.JJAOFAKCOIJ LHNHJPLOJLM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x547180", Offset = "0x545F80", VA = "0x180547180", Slot = "23")]
				get
				{
					return default(DIFOGFDGGIP.JJAOFAKCOIJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public DIFOGFDGGIP.JJAOFAKCOIJ OCDGKJFBFPO
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x547180", Offset = "0x545F80", VA = "0x180547180")]
				get
				{
					return default(DIFOGFDGGIP.JJAOFAKCOIJ);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x83CD30", Offset = "0x83BB30", VA = "0x18083CD30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float OECCAONMJAL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xA5A890", Offset = "0xA59690", VA = "0x180A5A890", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x481D2C0", Offset = "0x481C0C0", VA = "0x18481D2C0", Slot = "24")]
			private bool FKDFAEADAND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x481D2B0", Offset = "0x481C0B0", VA = "0x18481D2B0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x481D2E0", Offset = "0x481C0E0", VA = "0x18481D2E0")]
			public PLPFJGKCJNJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum KPKIPDAIBDC : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class BKJKOKHFHLE : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum BDMEFHNOMAD
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct GJIDFHKOGOC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public DIFOGFDGGIP.JJAOFAKCOIJ CJOOFBNELCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public BDMEFHNOMAD KBIFHDKBKCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<LJMFPLJLCJL> IJEOEKBOLDO;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly BDMEFHNOMAD[] EMKFPCIPOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly DIFOGFDGGIP.JJAOFAKCOIJ JCIEEDEFBLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool AIMMCPJKJIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly LJMFPLJLCJL[] DJKNFIODMEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<LJMFPLJLCJL> GHEKFJNGPDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> LILDAKCFDHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<LJMFPLJLCJL> HGONAJCFEBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> LEDAKHNOEMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool NIBAGBKAOMD;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public GJIDFHKOGOC[,] JCOIDDAGGJF
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x535D70", Offset = "0x534B70", VA = "0x180535D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int DLIFCKKHDLF
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x480E850", Offset = "0x480D650", VA = "0x18480E850")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x480F7A0", Offset = "0x480E5A0", VA = "0x18480F7A0")]
			public BKJKOKHFHLE(DIFOGFDGGIP.JJAOFAKCOIJ JIINJIBJJBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x480E5E0", Offset = "0x480D3E0", VA = "0x18480E5E0")]
			public void CNBMGAEMMMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x480EFB0", Offset = "0x480DDB0", VA = "0x18480EFB0")]
			public void HGMIOPBMIGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x480E340", Offset = "0x480D140", VA = "0x18480E340")]
			private void BABDJDCGHOG(IReadOnlyList<LJMFPLJLCJL> HMCEKCFHGEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x480F110", Offset = "0x480DF10", VA = "0x18480F110")]
			public void ICDACNEADGB(LJMFPLJLCJL BBPJMMENHNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x480ED30", Offset = "0x480DB30", VA = "0x18480ED30")]
			public void HALPDHPDENM(IList<LJMFPLJLCJL> NPFPNHDEGDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x480EAB0", Offset = "0x480D8B0", VA = "0x18480EAB0")]
			public void GMJFNHEEAOJ(IList<LJMFPLJLCJL> NPFPNHDEGDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x480E9C0", Offset = "0x480D7C0", VA = "0x18480E9C0")]
			private void GFDBNHOFLAL(LJMFPLJLCJL BBPJMMENHNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x480E470", Offset = "0x480D270", VA = "0x18480E470")]
			private void CBJOOJEBOND(IList<LJMFPLJLCJL> NPFPNHDEGDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x480EFC0", Offset = "0x480DDC0", VA = "0x18480EFC0")]
			private KPKIPDAIBDC HMMDKBCGHCI(LJMFPLJLCJL BBPJMMENHNH)
			{
				return default(KPKIPDAIBDC);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x480F410", Offset = "0x480E210", VA = "0x18480F410")]
			public void IFLCLMJCIDJ(float KIBCBHPGCJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x480F4C0", Offset = "0x480E2C0", VA = "0x18480F4C0")]
			public void JKMDBMPNIFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x480F230", Offset = "0x480E030", VA = "0x18480F230")]
			private void IEMCHPBBJNB(List<LJMFPLJLCJL> NPFPNHDEGDA, Stack<int> JDBPDEDDBEK, bool MAOHGIKGPBE, float OPKJPAKAGDO = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x480E5F0", Offset = "0x480D3F0", VA = "0x18480E5F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x480E730", Offset = "0x480D530", VA = "0x18480E730")]
			private void FELNPKEIJEA(List<LJMFPLJLCJL> NPFPNHDEGDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum HJCJMDKPJAG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class PNJJJAENENL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x58EB40", Offset = "0x58D940", VA = "0x18058EB40")]
			[DebuggerHidden]
			public PNJJJAENENL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x481D340", Offset = "0x481C140", VA = "0x18481D340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x481D3C0", Offset = "0x481C1C0", VA = "0x18481D3C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const HJCJMDKPJAG ABAKDBKONOA = HJCJMDKPJAG.Cancelled | HJCJMDKPJAG.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly DIFOGFDGGIP.JJAOFAKCOIJ[] PFBFPFMCCAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private BKJKOKHFHLE[] OMCDPGPGDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private JLHNDILDJEJ[] BOGPDAMAFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine OFCNIMFNNAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame IONBNHKPMME;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public DIFOGFDGGIP.JJAOFAKCOIJ FFOOLDIPICI
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x595210", Offset = "0x594010", VA = "0x180595210")]
			[CompilerGenerated]
			get
			{
				return default(DIFOGFDGGIP.JJAOFAKCOIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5A3710", Offset = "0x5A2510", VA = "0x1805A3710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool AJNFKIBCOFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x765320", Offset = "0x764120", VA = "0x180765320", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x5A3740", Offset = "0x5A2540", VA = "0x1805A3740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int DLIFCKKHDLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x481F4E0", Offset = "0x481E2E0", VA = "0x18481F4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x481E3C0", Offset = "0x481D1C0", VA = "0x18481E3C0")]
		public static OIOIEKMKHHG GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x481DBC0", Offset = "0x481C9C0", VA = "0x18481DBC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x481E530", Offset = "0x481D330", VA = "0x18481E530", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x481E480", Offset = "0x481D280", VA = "0x18481E480")]
		private BKJKOKHFHLE MNHKEPGNOGJ(DIFOGFDGGIP.JJAOFAKCOIJ FEGCMBEFABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xCAE1D0", Offset = "0xCACFD0", VA = "0x180CAE1D0")]
		private JLHNDILDJEJ COACIJNGPBD(DIFOGFDGGIP.JJAOFAKCOIJ FEGCMBEFABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x481E9F0", Offset = "0x481D7F0", VA = "0x18481E9F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x481E9B0", Offset = "0x481D7B0", VA = "0x18481E9B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x481F2B0", Offset = "0x481E0B0", VA = "0x18481F2B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x481E3A0", Offset = "0x481D1A0", VA = "0x18481E3A0")]
		private void DKNLDDBAFAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x481DBB0", Offset = "0x481C9B0", VA = "0x18481DBB0")]
		private void AMFNCKCIJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x481E3B0", Offset = "0x481D1B0", VA = "0x18481E3B0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x481E470", Offset = "0x481D270", VA = "0x18481E470")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x481E460", Offset = "0x481D260", VA = "0x18481E460")]
		private void JGANNFFDOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x481E4C0", Offset = "0x481D2C0", VA = "0x18481E4C0")]
		[IteratorStateMachine(typeof(PNJJJAENENL))]
		private IEnumerator OFLCEEIJPCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x481EDD0", Offset = "0x481DBD0", VA = "0x18481EDD0", Slot = "7")]
		public OIOIEKMKHHG Run(IEnumerator<JBHCACLLONB> KLOPBJNBMFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x481EBA0", Offset = "0x481D9A0", VA = "0x18481EBA0", Slot = "8")]
		public OIOIEKMKHHG Run(Behaviour MILHAHGHJGA, IEnumerator<JBHCACLLONB> KLOPBJNBMFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x481EA70", Offset = "0x481D870", VA = "0x18481EA70", Slot = "9")]
		public OIOIEKMKHHG RunJobbed(FJFKFCKFAIE MILHAHGHJGA, IEnumerator<JBHCACLLONB> KLOPBJNBMFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x481E340", Offset = "0x481D140", VA = "0x18481E340", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x481EDE0", Offset = "0x481DBE0", VA = "0x18481EDE0")]
		public void UpdateQueue(DIFOGFDGGIP.JJAOFAKCOIJ HOPJKFGBEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x481E180", Offset = "0x481CF80", VA = "0x18481E180")]
		private void BGHPENPICMI(BKJKOKHFHLE PHPBKGJAGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x481E060", Offset = "0x481CE60", VA = "0x18481E060")]
		private void BBGCMLAGCMJ(JLHNDILDJEJ PHPBKGJAGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x481F470", Offset = "0x481E270", VA = "0x18481F470")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class DHEFEPPCGIF
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4812950", Offset = "0x4811750", VA = "0x184812950")]
	[LKBOCBPCLAE]
	private static void LNBLCEPPLFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class POOGEGJKCFM : KEKLNPALAGC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float CMFJIOJHBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x481DB50", Offset = "0x481C950", VA = "0x18481DB50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float GNAJIMFFENA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x481DBA0", Offset = "0x481C9A0", VA = "0x18481DBA0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float FMDOOGNINJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x481DB70", Offset = "0x481C970", VA = "0x18481DB70", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BOBIHOGALCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x481DB60", Offset = "0x481C960", VA = "0x18481DB60", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double KCDEFJIFBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x481DB80", Offset = "0x481C980", VA = "0x18481DB80", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public POOGEGJKCFM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PNNMOCCLFDL
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] MBBLNMFMFMG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int MGBCGAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int GGINOEAOLGL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger FIINFAJLNBA;

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNNMOCCLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x481D410", Offset = "0x481C210", VA = "0x18481D410")]
	private static string NFPHDFCNCGP(byte[] BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x481D510", Offset = "0x481C310", VA = "0x18481D510")]
	public static string NLBDLCJIPCH(byte[] IEDOMBJDKEO, bool HAFBALPHMDI)
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

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
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

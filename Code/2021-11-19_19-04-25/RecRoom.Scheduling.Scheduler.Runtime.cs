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
		private delegate List<PlayerLoopSystem> NBJLEFNCILJ(List<PlayerLoopSystem> LBMFPDMKFHP, int DFFMKCGPINE);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct HFKDFGCIHAO
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct OPLACOIPPAG
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static IDIKKKGOEOH KGABGDANAGD;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x3ABC670", Offset = "0x3ABB670", VA = "0x183ABC670")]
				public static PlayerLoopSystem HHFMALGJIKD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct MBLGIFFPDFD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static IDIKKKGOEOH CIBKOFPPDEC;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3ABA3C0", Offset = "0x3AB93C0", VA = "0x183ABA3C0")]
				public static PlayerLoopSystem HHFMALGJIKD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct CIBMNGONGHK
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static IDIKKKGOEOH BGDLGNJHGFB;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3AB02E0", Offset = "0x3AAF2E0", VA = "0x183AB02E0")]
				public static PlayerLoopSystem HHFMALGJIKD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct GLOMELFCLHI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class NCKPHPBGAKI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public CAIOOKFDFIJ.KNFMLGIDGKL key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
					public NCKPHPBGAKI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x3ABAB60", Offset = "0x3AB9B60", VA = "0x183ABAB60")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable IFOCBBGEDOL;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3AB4C30", Offset = "0x3AB3C30", VA = "0x183AB4C30")]
				public static PlayerLoopSystem DHFMDAIBCKA(CAIOOKFDFIJ.KNFMLGIDGKL FNHMPFHLGJM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct BINJPHCLELO
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class LCMNKIOENKO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public CAIOOKFDFIJ.KNFMLGIDGKL key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
					public LCMNKIOENKO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x3AB81C0", Offset = "0x3AB71C0", VA = "0x183AB81C0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3AAE4A0", Offset = "0x3AAD4A0", VA = "0x183AAE4A0")]
				public static PlayerLoopSystem DHFMDAIBCKA(CAIOOKFDFIJ.KNFMLGIDGKL FNHMPFHLGJM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JGFONEMGGDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public JGFONEMGGDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3AB71F0", Offset = "0x3AB61F0", VA = "0x183AB71F0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool AFDPLBNBCFH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool JFBFAAMICAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0FA0", Offset = "0x3AAFFA0", VA = "0x183AB0FA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3AB2090", Offset = "0x3AB1090", VA = "0x183AB2090")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0FE0", Offset = "0x3AAFFE0", VA = "0x183AB0FE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1E30", Offset = "0x3AB0E30", VA = "0x183AB1E30")]
		private static void CAKLJMKIDDB(CAIOOKFDFIJ.KNFMLGIDGKL FNHMPFHLGJM, ref PlayerLoopSystem OCJEBDFBBFP, Type LFAOOFOGCNF, Type MLJDHCPEMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AB21D0", Offset = "0x3AB11D0", VA = "0x183AB21D0")]
		private static void NBBDHAJMGJH(ref PlayerLoopSystem OCJEBDFBBFP, Type LFAOOFOGCNF, Type MLJDHCPEMEA, NBJLEFNCILJ EDCPAFNDMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AB20D0", Offset = "0x3AB10D0", VA = "0x183AB20D0")]
		private static void MPAKLGPNOHE(ref PlayerLoopSystem OCJEBDFBBFP, Type LFAOOFOGCNF, Type MLJDHCPEMEA, PlayerLoopSystem? HOOHJAKJOKP, PlayerLoopSystem? FPCONCPALEH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CAIOOKFDFIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum KNFMLGIDGKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class FPOFNDMFENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly KNFMLGIDGKL BPEGIPOLGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly EKCGAMCIDLO PMIJEDKBHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long GIOBNIBLHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long NJJPPGPJFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long OKKELMJJPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int AJFDLOILMEJ;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4720", Offset = "0x3AB3720", VA = "0x183AB4720")]
		public FPOFNDMFENI(KNFMLGIDGKL FECPPMPFJLA, int EELBNJIFAIP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB44D0", Offset = "0x3AB34D0", VA = "0x183AB44D0")]
		public void IEAPNBKPKFP(int OPHEGCPJNDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4460", Offset = "0x3AB3460", VA = "0x183AB4460")]
		public void HCMIJHOBBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB46C0", Offset = "0x3AB36C0", VA = "0x183AB46C0")]
		public void KEGNFBGCMLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB44F0", Offset = "0x3AB34F0", VA = "0x183AB44F0")]
		public void JDEEJMPOAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB43C0", Offset = "0x3AB33C0", VA = "0x183AB43C0")]
		public double FBGHMEFMDIA(int MBAODNLKGOA)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int OLCJPJKANCK = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static KNFMLGIDGKL[] DAFDCAMMHCO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static FPOFNDMFENI[] CAJIHMINBEJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEA10", Offset = "0x3AADA10", VA = "0x183AAEA10")]
	public static FPOFNDMFENI LHMMINJGBDC(KNFMLGIDGKL FNHMPFHLGJM, int EELBNJIFAIP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEBA0", Offset = "0x3AADBA0", VA = "0x183AAEBA0")]
	public static FPOFNDMFENI NAAFEOFIIGA(KNFMLGIDGKL FNHMPFHLGJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE960", Offset = "0x3AAD960", VA = "0x183AAE960")]
	public static void BIGNBNCHCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EKCGAMCIDLO : HAANBFMDCDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int KKCGEKFHOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> OGHAKLKFKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double HCHOCAAOOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double BBIOOCDGHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double NLOBPDCNCJK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DEIJPFDHIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3F90", Offset = "0x3AB2F90", VA = "0x183AB3F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MFFEKEHFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AB40D0", Offset = "0x3AB30D0", VA = "0x183AB40D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BEGHKHCEEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAC0", Offset = "0xBFEAC0", VA = "0x180BFFAC0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double OALHCAPMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB890", Offset = "0x2DFA890", VA = "0x182DFB890", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AB41A0", Offset = "0x3AB31A0", VA = "0x183AB41A0")]
	public EKCGAMCIDLO(int MDMKGABNLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3FD0", Offset = "0x3AB2FD0", VA = "0x183AB3FD0", Slot = "4")]
	public void DBOFMCCACKN(double CIIDGEOMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4130", Offset = "0x3AB3130", VA = "0x183AB4130", Slot = "5")]
	public void ILCKLPOILDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EPDHGDFIODL : HAANBFMDCDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long EBJHAIHBKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double FBLDMBLEEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double ICONMIDFMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double HEAPFIKPHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double AOCCNJJMJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double HCHOCAAOOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double BBIOOCDGHIH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DINAJDNNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BEGHKHCEEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x684940", Offset = "0x683940", VA = "0x180684940", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double OALHCAPMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x795A80", Offset = "0x794A80", VA = "0x180795A80", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double KKAMMCBBFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB890", Offset = "0x2DFA890", VA = "0x182DFB890")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DPNEMIKOMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x35485A0", Offset = "0x35475A0", VA = "0x1835485A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MFFEKEHFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB7C0", Offset = "0x2DFA7C0", VA = "0x182DFB7C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4230", Offset = "0x3AB3230", VA = "0x183AB4230", Slot = "4")]
	public void DBOFMCCACKN(double CIIDGEOMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4350", Offset = "0x3AB3350", VA = "0x183AB4350", Slot = "5")]
	public void ILCKLPOILDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4390", Offset = "0x3AB3390", VA = "0x183AB4390")]
	public EPDHGDFIODL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HAANBFMDCDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MFFEKEHFNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BEGHKHCEEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double OALHCAPMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBOFMCCACKN(double CIIDGEOMGCJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILCKLPOILDK();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CAJNCKINJFB
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface AFDIOOILFMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool ABODMFDNGGN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MBGDLPLIOOP();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BNLKFAHJCMJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class IHEGKMPHKMO<TPromise, TMainThreadPromise> : AFDIOOILFMK where TPromise : EBJFPPEJHJH where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise MOJILAEFINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise NDNGJAHFBBB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise HPNNJCHHKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1F3CA30", Offset = "0x1F3BA30", VA = "0x181F3CA30")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ABODMFDNGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1F3CA90", Offset = "0x1F3BA90", VA = "0x181F3CA90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1BFAE00", Offset = "0x1BF9E00", VA = "0x181BFAE00")]
		protected IHEGKMPHKMO(TPromise MOJILAEFINC, TMainThreadPromise DPIECEFJCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1F3CAE0", Offset = "0x1F3BAE0", VA = "0x181F3CAE0", Slot = "5")]
		public void MBGDLPLIOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1D984B0", Offset = "0x1D974B0", VA = "0x181D984B0", Slot = "6")]
		public void BNLKFAHJCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void IIOKAIOAINL(TPromise MOJILAEFINC);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void NHGAECOJADM();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class LCOBDKHJMPN<T> : IHEGKMPHKMO<global::CFGAGIADBID<T>, global::EDPCHJECIEG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F230", Offset = "0x1F3E230", VA = "0x181F3F230")]
		public LCOBDKHJMPN(global::CFGAGIADBID<T> MOJILAEFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F050", Offset = "0x1F3E050", VA = "0x181F3F050", Slot = "7")]
		protected override void IIOKAIOAINL(global::CFGAGIADBID<T> MOJILAEFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F1D0", Offset = "0x1F3E1D0", VA = "0x181F3F1D0", Slot = "8")]
		protected override void NHGAECOJADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F020", Offset = "0x1F3E020", VA = "0x181F3F020")]
		[CompilerGenerated]
		private void HKODOGHNICA(T KFPDCJGFCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F1A0", Offset = "0x1F3E1A0", VA = "0x181F3F1A0")]
		[CompilerGenerated]
		private void KIIOAKHGOJB(string MCGGOOFMGFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LNAIJJAHEKP : IHEGKMPHKMO<EBJFPPEJHJH, CLCJEEPDPCK>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA350", Offset = "0x3AB9350", VA = "0x183ABA350")]
		public LNAIJJAHEKP(EBJFPPEJHJH MOJILAEFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA230", Offset = "0x3AB9230", VA = "0x183ABA230", Slot = "7")]
		protected override void IIOKAIOAINL(EBJFPPEJHJH MOJILAEFINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA300", Offset = "0x3AB9300", VA = "0x183ABA300", Slot = "8")]
		protected override void NHGAECOJADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE1EA50", Offset = "0xE1DA50", VA = "0x180E1EA50")]
		[CompilerGenerated]
		private void HKODOGHNICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x171C7C0", Offset = "0x171B7C0", VA = "0x18171C7C0")]
		[CompilerGenerated]
		private void KIIOAKHGOJB(string MCGGOOFMGFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class IJHGLOIBDIG : AFDIOOILFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action HMDBAELNEEE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ABODMFDNGGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x428F60", Offset = "0x427F60", VA = "0x180428F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x514D10", Offset = "0x513D10", VA = "0x180514D10")]
		public IJHGLOIBDIG(Action HMDBAELNEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1599040", Offset = "0x1598040", VA = "0x181599040", Slot = "5")]
		public void MBGDLPLIOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "6")]
		public void BNLKFAHJCMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<AFDIOOILFMK> HNOGAMAKPBH;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1ABF810", Offset = "0x1ABE810", VA = "0x181ABF810")]
	public static global::CFGAGIADBID<T> BMKAHMJAJBN<T>(this global::CFGAGIADBID<T> MOJILAEFINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEDF0", Offset = "0x3AADDF0", VA = "0x183AAEDF0")]
	public static EBJFPPEJHJH BMKAHMJAJBN(this EBJFPPEJHJH MOJILAEFINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEF00", Offset = "0x3AADF00", VA = "0x183AAEF00")]
	public static void BMKAHMJAJBN(Action HMDBAELNEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1ABF880", Offset = "0x1ABE880", VA = "0x181ABF880")]
	private static global::CFGAGIADBID<T> IANHPAIIPAD<T>(global::CFGAGIADBID<T> MOJILAEFINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF050", Offset = "0x3AAE050", VA = "0x183AAF050")]
	private static EBJFPPEJHJH IANHPAIIPAD(EBJFPPEJHJH MOJILAEFINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF130", Offset = "0x3AAE130", VA = "0x183AAF130")]
	private static void JIKOPKHPIFJ(AFDIOOILFMK COIMNHCIMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF310", Offset = "0x3AAE310", VA = "0x183AAF310")]
	private static void OBFMHKBNPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEF80", Offset = "0x3AADF80", VA = "0x183AAEF80")]
	private static void CPJCJKCFGCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAED40", Offset = "0x3AADD40", VA = "0x183AAED40")]
	private static void APFLHCPKGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class AMFOCDBGPIH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NGKPJGGKGEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CLCJEEPDPCK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public NGKPJGGKGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3ABAD10", Offset = "0x3AB9D10", VA = "0x183ABAD10")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3ABAD00", Offset = "0x3AB9D00", VA = "0x183ABAD00")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DHHCCBMMEAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public DHHCCBMMEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2C10", Offset = "0x3AB1C10", VA = "0x183AB2C10")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DDIKAIHPGOK : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CLCJEEPDPCK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public DDIKAIHPGOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2B10", Offset = "0x3AB1B10", VA = "0x183AB2B10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2840", Offset = "0x3AB1840", VA = "0x183AB2840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2BC0", Offset = "0x3AB1BC0", VA = "0x183AB2BC0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2AC0", Offset = "0x3AB1AC0", VA = "0x183AB2AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KIPIJLFGOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CLCJEEPDPCK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public KIPIJLFGOBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GKCDBEKIBLD : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CLCJEEPDPCK onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private KIPIJLFGOBA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public GKCDBEKIBLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4890", Offset = "0x3AB3890", VA = "0x183AB4890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4BE0", Offset = "0x3AB3BE0", VA = "0x183AB4BE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string IENCJGMKCAK = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string JEAMINNDAKI = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string KDADIGLLIPI = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string KDAPILPPMFE = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string ENOOFICOLPD = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float CAGJMKNKNOK = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static EBJFPPEJHJH GFGAMEMGLNE;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation ONNMEBFAMJA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static EBJFPPEJHJH NEHDCEKOGLF;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string JDKANHHBMGM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority KKHNGBLFJKJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool KOIBPNPPMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE310", Offset = "0x3AAD310", VA = "0x183AAE310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool DCJFAJAHLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3AADFE0", Offset = "0x3AACFE0", VA = "0x183AADFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool JIFCNMPIOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE2B0", Offset = "0x3AAD2B0", VA = "0x183AAE2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NPDMBDBDHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3AADCB0", Offset = "0x3AACCB0", VA = "0x183AADCB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE040", Offset = "0x3AAD040", VA = "0x183AAE040")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE170", Offset = "0x3AAD170", VA = "0x183AAE170")]
	public static EBJFPPEJHJH HDOCHFLCHAD(string HHIAAMLDEND, LoadSceneMode NLOBDPEAAMG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3AADDD0", Offset = "0x3AACDD0", VA = "0x183AADDD0")]
	public static EBJFPPEJHJH EFLDHDBNDND(string HHIAAMLDEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3AADD60", Offset = "0x3AACD60", VA = "0x183AADD60")]
	[IteratorStateMachine(typeof(DDIKAIHPGOK))]
	private static IEnumerator<MKDOJLNJHKD> DHJCIAMIJID(string HHIAAMLDEND, CLCJEEPDPCK IMABKBCHOHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE0F0", Offset = "0x3AAD0F0", VA = "0x183AAE0F0")]
	[IteratorStateMachine(typeof(GKCDBEKIBLD))]
	private static IEnumerator<MKDOJLNJHKD> GNGHIAOHPHB(string HHIAAMLDEND, LoadSceneMode NLOBDPEAAMG, CLCJEEPDPCK IMABKBCHOHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CKALEEGDKED
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0B20", Offset = "0x3AAFB20", VA = "0x183AB0B20")]
	public static IDisposable HOEHGKPNILG(this APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0960", Offset = "0x3AAF960", VA = "0x183AB0960")]
	public static IDisposable HOEHGKPNILG(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3AB07E0", Offset = "0x3AAF7E0", VA = "0x183AB07E0")]
	public static IDisposable FOJKMCDHLHN(this APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0770", Offset = "0x3AAF770", VA = "0x183AB0770")]
	public static IDisposable FKDJIJIEKDA(this APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0700", Offset = "0x3AAF700", VA = "0x183AB0700")]
	public static IDisposable FJECBCONBIA(this APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0C30", Offset = "0x3AAFC30", VA = "0x183AB0C30")]
	public static IDisposable KEGNDDJCJIO(this APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0D20", Offset = "0x3AAFD20", VA = "0x183AB0D20")]
	public static IDisposable MKILNINDFJG(this APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB08D0", Offset = "0x3AAF8D0", VA = "0x183AB08D0")]
	public static IDisposable GPCJDPAHBCF(this APKDMFAAHKI LJKCBGIFJKE, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0F20", Offset = "0x3AAFF20", VA = "0x183AB0F20")]
	public static IDisposable PNOOOAHIKAB(this APKDMFAAHKI LJKCBGIFJKE, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0CA0", Offset = "0x3AAFCA0", VA = "0x183AB0CA0")]
	public static IDisposable MBLMBBNDLJE(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0680", Offset = "0x3AAF680", VA = "0x183AB0680")]
	public static IDisposable DKAIOCFENFP(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0480", Offset = "0x3AAF480", VA = "0x183AB0480")]
	public static IDisposable AFAPLDLAKBG(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0E90", Offset = "0x3AAFE90", VA = "0x183AB0E90")]
	public static IDisposable PKEKIBMKAFF(this APKDMFAAHKI LJKCBGIFJKE, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0580", Offset = "0x3AAF580", VA = "0x183AB0580")]
	public static IDisposable DHLJFJLHHDG(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0850", Offset = "0x3AAF850", VA = "0x183AB0850")]
	public static IDisposable FPFMCGOGCLB(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0D90", Offset = "0x3AAFD90", VA = "0x183AB0D90")]
	public static IDisposable NOOPPJFHLMC(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0BA0", Offset = "0x3AAFBA0", VA = "0x183AB0BA0")]
	public static IDisposable KEACEOLODPJ(this APKDMFAAHKI LJKCBGIFJKE, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0500", Offset = "0x3AAF500", VA = "0x183AB0500")]
	public static IDisposable DGNGHHDBHJL(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0E10", Offset = "0x3AAFE10", VA = "0x183AB0E10")]
	public static IDisposable PBBGOMKJNBP(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0600", Offset = "0x3AAF600", VA = "0x183AB0600")]
	public static IDisposable DJKPMMPKKML(this APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ONNBHCIGAHH
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBD10", Offset = "0x3ABAD10", VA = "0x183ABBD10")]
	public static IDisposable CFKJIFEDOGB(this MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBB50", Offset = "0x3ABAB50", VA = "0x183ABBB50")]
	public static IDisposable CFKJIFEDOGB(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBA60", Offset = "0x3ABAA60", VA = "0x183ABBA60")]
	public static IDisposable AELFABGBJOO(this MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBE00", Offset = "0x3ABAE00", VA = "0x183ABBE00")]
	public static IDisposable DMJNJPBBKID(this MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC080", Offset = "0x3ABB080", VA = "0x183ABC080")]
	public static IDisposable GFELNAFMCDL(this MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC3F0", Offset = "0x3ABB3F0", VA = "0x183ABC3F0")]
	public static IDisposable JBFIPALBKPN(this MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBD90", Offset = "0x3ABAD90", VA = "0x183ABBD90")]
	public static IDisposable CLCNPJFFPPA(this MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC5E0", Offset = "0x3ABB5E0", VA = "0x183ABC5E0")]
	public static IDisposable PJDDLAFFCCM(this MonoBehaviour DMBKBILOLNI, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC270", Offset = "0x3ABB270", VA = "0x183ABC270")]
	public static IDisposable HNBDCBLCFIC(this MonoBehaviour DMBKBILOLNI, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC2F0", Offset = "0x3ABB2F0", VA = "0x183ABC2F0")]
	public static IDisposable ILOEBDADALD(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC0F0", Offset = "0x3ABB0F0", VA = "0x183ABC0F0")]
	public static IDisposable GPAOMHPNOHG(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC460", Offset = "0x3ABB460", VA = "0x183ABC460")]
	public static IDisposable MBKLPDGEHJD(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC1F0", Offset = "0x3ABB1F0", VA = "0x183ABC1F0")]
	public static IDisposable HLPOLCCNHGJ(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC4E0", Offset = "0x3ABB4E0", VA = "0x183ABC4E0")]
	public static IDisposable MCHEIMCOEFK(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC000", Offset = "0x3ABB000", VA = "0x183ABC000")]
	public static IDisposable FKICEODGONA(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBEF0", Offset = "0x3ABAEF0", VA = "0x183ABBEF0")]
	public static IDisposable FGIJCEEEOLC(this MonoBehaviour DMBKBILOLNI, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBAD0", Offset = "0x3ABAAD0", VA = "0x183ABBAD0")]
	public static IDisposable ANFGIBOJOFD(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC560", Offset = "0x3ABB560", VA = "0x183ABC560")]
	public static IDisposable PFGLNODDBJK(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBF80", Offset = "0x3ABAF80", VA = "0x183ABBF80")]
	public static IDisposable FKHBMDAKKEB(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB9D0", Offset = "0x3ABA9D0", VA = "0x183ABB9D0")]
	public static IDisposable ABDDHHIPCKO(this MonoBehaviour DMBKBILOLNI, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBE70", Offset = "0x3ABAE70", VA = "0x183ABBE70")]
	public static IDisposable EOGCGBNHLLJ(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC170", Offset = "0x3ABB170", VA = "0x183ABC170")]
	public static IDisposable HFJKFENHFJL(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC370", Offset = "0x3ABB370", VA = "0x183ABC370")]
	public static IDisposable INNGFDAPAAE(this MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KJMELEDLKEM
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class NCEOMKMIGMI : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JLHCHGPAHDJ.JOKKMFMHBPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private BNJCHOFKKFL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public NCEOMKMIGMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3ABAA40", Offset = "0x3AB9A40", VA = "0x183ABAA40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3ABAB10", Offset = "0x3AB9B10", VA = "0x183ABAB10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ECIJDJDIACL : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public JLHCHGPAHDJ.JOKKMFMHBPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private BNJCHOFKKFL <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public ECIJDJDIACL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3C10", Offset = "0x3AB2C10", VA = "0x183AB3C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3D00", Offset = "0x3AB2D00", VA = "0x183AB3D00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7C80", Offset = "0x3AB6C80", VA = "0x183AB7C80")]
	public static PPJBCEPCKCN CFKJIFEDOGB(Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7B90", Offset = "0x3AB6B90", VA = "0x183AB7B90")]
	public static PPJBCEPCKCN CFKJIFEDOGB(Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7D70", Offset = "0x3AB6D70", VA = "0x183AB7D70")]
	public static PPJBCEPCKCN CFKJIFEDOGB(Behaviour LJKCBGIFJKE, Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7A80", Offset = "0x3AB6A80", VA = "0x183AB7A80")]
	public static PPJBCEPCKCN CFKJIFEDOGB(Behaviour LJKCBGIFJKE, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7F90", Offset = "0x3AB6F90", VA = "0x183AB7F90")]
	public static PPJBCEPCKCN HOEHGKPNILG(APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7E80", Offset = "0x3AB6E80", VA = "0x183AB7E80")]
	public static PPJBCEPCKCN HOEHGKPNILG(APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB80A0", Offset = "0x3AB70A0", VA = "0x183AB80A0")]
	[IteratorStateMachine(typeof(NCEOMKMIGMI))]
	private static IEnumerator<MKDOJLNJHKD> OGLLBAHNLAO(JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ, Action MEJGEIJNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8110", Offset = "0x3AB7110", VA = "0x183AB8110")]
	[IteratorStateMachine(typeof(ECIJDJDIACL))]
	private static IEnumerator<MKDOJLNJHKD> OGLLBAHNLAO(JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NBHOJFDLDKE
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EDAAHLDGGJC : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public JLHCHGPAHDJ.JOKKMFMHBPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private HIAOFKNLPIH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public EDAAHLDGGJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3D50", Offset = "0x3AB2D50", VA = "0x183AB3D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3E40", Offset = "0x3AB2E40", VA = "0x183AB3E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA700", Offset = "0x3AB9700", VA = "0x183ABA700")]
	public static PPJBCEPCKCN CFKJIFEDOGB(float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA7B0", Offset = "0x3AB97B0", VA = "0x183ABA7B0")]
	public static PPJBCEPCKCN CFKJIFEDOGB(MonoBehaviour DMBKBILOLNI, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA870", Offset = "0x3AB9870", VA = "0x183ABA870")]
	public static PPJBCEPCKCN IIFBGHEOPDB(APKDMFAAHKI LJKCBGIFJKE, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA930", Offset = "0x3AB9930", VA = "0x183ABA930")]
	[IteratorStateMachine(typeof(EDAAHLDGGJC))]
	private static IEnumerator<MKDOJLNJHKD> OGLLBAHNLAO(float NIEMEMDCOKP, JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ, Action<float> MEJGEIJNPPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DBDHBJIOCHC
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NCLFFHBKILO : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public JLHCHGPAHDJ.JOKKMFMHBPB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public NCLFFHBKILO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3ABAC10", Offset = "0x3AB9C10", VA = "0x183ABAC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3ABACB0", Offset = "0x3AB9CB0", VA = "0x183ABACB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2540", Offset = "0x3AB1540", VA = "0x183AB2540")]
	[IteratorStateMachine(typeof(NCLFFHBKILO))]
	private static IEnumerator<MKDOJLNJHKD> EOGLIIPLMEO(JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL, Func<bool> OHKNCIKKDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB25B0", Offset = "0x3AB15B0", VA = "0x183AB25B0")]
	public static PPJBCEPCKCN GDFIONFGNKK(this MonoBehaviour DMBKBILOLNI, Func<bool> OHKNCIKKDKL, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL = JLHCHGPAHDJ.JOKKMFMHBPB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class POLPDMOOHHP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class EJMODMBOLLA : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public JLHCHGPAHDJ.JOKKMFMHBPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public EJMODMBOLLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3E90", Offset = "0x3AB2E90", VA = "0x183AB3E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3F40", Offset = "0x3AB2F40", VA = "0x183AB3F40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LHPFGBDDEDP : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public JLHCHGPAHDJ.JOKKMFMHBPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private MKDOJLNJHKD <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public LHPFGBDDEDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA120", Offset = "0x3AB9120", VA = "0x183ABA120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA1E0", Offset = "0x3AB91E0", VA = "0x183ABA1E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD4D0", Offset = "0x3ABC4D0", VA = "0x183ABD4D0")]
	[IteratorStateMachine(typeof(EJMODMBOLLA))]
	private static IEnumerator<MKDOJLNJHKD> KEMDOJIBPKK(float GLLDPBBBJJN, JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCE60", Offset = "0x3ABBE60", VA = "0x183ABCE60")]
	[IteratorStateMachine(typeof(LHPFGBDDEDP))]
	private static IEnumerator<MKDOJLNJHKD> BELIIBFAJMK(float GLLDPBBBJJN, JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD390", Offset = "0x3ABC390", VA = "0x183ABD390")]
	public static IDisposable JKOACBMNAPM(this MonoBehaviour DMBKBILOLNI, float GLLDPBBBJJN, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD8A0", Offset = "0x3ABC8A0", VA = "0x183ABD8A0")]
	public static PPJBCEPCKCN PJEHJHDNMHP(this MonoBehaviour DMBKBILOLNI, float GLLDPBBBJJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD240", Offset = "0x3ABC240", VA = "0x183ABD240")]
	public static PPJBCEPCKCN JKOACBMNAPM(this MonoBehaviour DMBKBILOLNI, float GLLDPBBBJJN, JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD220", Offset = "0x3ABC220", VA = "0x183ABD220")]
	public static PPJBCEPCKCN IOEDDNMBMDD(this MonoBehaviour DMBKBILOLNI, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD100", Offset = "0x3ABC100", VA = "0x183ABD100")]
	public static PPJBCEPCKCN IBKCFLFALDK(this MonoBehaviour DMBKBILOLNI, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD660", Offset = "0x3ABC660", VA = "0x183ABD660")]
	public static PPJBCEPCKCN KIHIDBBLAOG(this MonoBehaviour DMBKBILOLNI, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD670", Offset = "0x3ABC670", VA = "0x183ABD670")]
	public static PPJBCEPCKCN LPJJAJOOLMD(this MonoBehaviour DMBKBILOLNI, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD230", Offset = "0x3ABC230", VA = "0x183ABD230")]
	public static PPJBCEPCKCN JDEOJKMLPHC(this MonoBehaviour DMBKBILOLNI, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD550", Offset = "0x3ABC550", VA = "0x183ABD550")]
	private static PPJBCEPCKCN KFLMHCNMIAJ(MonoBehaviour DMBKBILOLNI, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCEE0", Offset = "0x3ABBEE0", VA = "0x183ABCEE0")]
	public static PPJBCEPCKCN GKOEGKLKKJF(this MonoBehaviour DMBKBILOLNI, float EEDHCCOANIG, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3ABCFF0", Offset = "0x3ABBFF0", VA = "0x183ABCFF0")]
	public static PPJBCEPCKCN GNGBAMMEAGI(this MonoBehaviour DMBKBILOLNI, float EEDHCCOANIG, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD110", Offset = "0x3ABC110", VA = "0x183ABD110")]
	public static PPJBCEPCKCN IKPHDHNAOLH(this MonoBehaviour DMBKBILOLNI, float EEDHCCOANIG, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD790", Offset = "0x3ABC790", VA = "0x183ABD790")]
	public static PPJBCEPCKCN OCCHGJNPDKM(this MonoBehaviour DMBKBILOLNI, float EEDHCCOANIG, Action OKHAFMJNCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABD680", Offset = "0x3ABC680", VA = "0x183ABD680")]
	public static PPJBCEPCKCN MHDIGMKONKF(this MonoBehaviour DMBKBILOLNI, float EEDHCCOANIG, Action OKHAFMJNCNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class MJLHCNGAGFL : OJCPJIFKBNA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LECKOHJOFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MJLHCNGAGFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public LECKOHJOFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6F90", Offset = "0x3AB5F90", VA = "0x183AB6F90")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HHDOPIBJCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MJLHCNGAGFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public HHDOPIBJCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6F90", Offset = "0x3AB5F90", VA = "0x183AB6F90")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float DKKFFBCFKMF;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AB82C0", Offset = "0x3AB72C0", VA = "0x183AB82C0")]
	public MJLHCNGAGFL(Behaviour LJKCBGIFJKE, float DKKFFBCFKMF, [Optional] Action DELIMKHIINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA560", Offset = "0x3AB9560", VA = "0x183ABA560", Slot = "9")]
	protected override bool NMAMFFPHNGE(Action HMDBAELNEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA630", Offset = "0x3AB9630", VA = "0x183ABA630", Slot = "10")]
	protected override bool OCDOAJOCKIP(Action HMDBAELNEEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KHJMCIFJIMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool CHMMHNFMEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MPIGAOAOFMJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNPBOBMDIDD(bool CFCFKNPJMNI = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNPBOBMDIDD(Action HMDBAELNEEE, bool CFCFKNPJMNI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class OJCPJIFKBNA : KHJMCIFJIMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class HMPDMDPOLOD : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public HMPDMDPOLOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6FC0", Offset = "0x3AB5FC0", VA = "0x183AB6FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7060", Offset = "0x3AB6060", VA = "0x183AB7060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour LJKCBGIFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action DELIMKHIINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private DPOOMLLAPDH EIMPHOFOCLP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CHMMHNFMEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2AC0", Offset = "0x8B1AC0", VA = "0x1808B2AC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MPIGAOAOFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB060", Offset = "0x3ABA060", VA = "0x183ABB060", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3ABB3A0", Offset = "0x3ABA3A0", VA = "0x183ABB3A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2437530", Offset = "0x2436530", VA = "0x182437530")]
	protected OJCPJIFKBNA(Behaviour LJKCBGIFJKE, [Optional] Action DELIMKHIINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB150", Offset = "0x3ABA150", VA = "0x183ABB150", Slot = "7")]
	public bool FNPBOBMDIDD(bool CFCFKNPJMNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB100", Offset = "0x3ABA100", VA = "0x183ABB100", Slot = "8")]
	public bool FNPBOBMDIDD(Action HMDBAELNEEE, bool CFCFKNPJMNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool NMAMFFPHNGE(Action HMDBAELNEEE);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OCDOAJOCKIP(Action HMDBAELNEEE);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB040", Offset = "0x3ABA040", VA = "0x183ABB040")]
	protected void DEOFMFHPGMJ(Action HMDBAELNEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB1B0", Offset = "0x3ABA1B0", VA = "0x183ABB1B0")]
	protected EBJFPPEJHJH GFELJPBDBKB(float FLEFFINBLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAFD0", Offset = "0x3AB9FD0", VA = "0x183ABAFD0")]
	private void DAHJIINFLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAF70", Offset = "0x3AB9F70", VA = "0x183ABAF70")]
	[IteratorStateMachine(typeof(HMPDMDPOLOD))]
	private static IEnumerator<MKDOJLNJHKD> BDIPLKHIENK(float FLEFFINBLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB380", Offset = "0x3ABA380", VA = "0x183ABB380")]
	[CompilerGenerated]
	private void OHKHMPCAPHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BMFIGLHPFCJ : OJCPJIFKBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float PHGBEJNCEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int EJNFAJCABJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float MOJOFJFANND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] JGKDLHIOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int GGKODICACAM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GPLBBAOPPJD AOOEJNKGHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x44F670", Offset = "0x44E670", VA = "0x18044F670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x517DD0", Offset = "0x516DD0", VA = "0x180517DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE850", Offset = "0x3AAD850", VA = "0x183AAE850")]
	public BMFIGLHPFCJ(Behaviour LJKCBGIFJKE, float MHCIANPBEBE, int EJNFAJCABJL, [Optional] Action DELIMKHIINI, float MOJOFJFANND = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x428E40", Offset = "0x427E40", VA = "0x180428E40", Slot = "9")]
	protected override bool NMAMFFPHNGE(Action HMDBAELNEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE630", Offset = "0x3AAD630", VA = "0x183AAE630", Slot = "10")]
	protected override bool OCDOAJOCKIP(Action HMDBAELNEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE5A0", Offset = "0x3AAD5A0", VA = "0x183AAE5A0")]
	private void KAEGOJDOPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LFBOMHPLBBF : OJCPJIFKBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float DKKFFBCFKMF;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AB82C0", Offset = "0x3AB72C0", VA = "0x183AB82C0")]
	public LFBOMHPLBBF(Behaviour LJKCBGIFJKE, float DKKFFBCFKMF, [Optional] Action DELIMKHIINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x428E40", Offset = "0x427E40", VA = "0x180428E40", Slot = "9")]
	protected override bool NMAMFFPHNGE(Action HMDBAELNEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8280", Offset = "0x3AB7280", VA = "0x183AB8280", Slot = "10")]
	protected override bool OCDOAJOCKIP(Action HMDBAELNEEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CGGJJKHNOGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class INHOKKDLMBK : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public INHOKKDLMBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3AB70B0", Offset = "0x3AB60B0", VA = "0x183AB70B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3AB71A0", Offset = "0x3AB61A0", VA = "0x183AB71A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private PPJBCEPCKCN HHIBCEOHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private APKDMFAAHKI LJKCBGIFJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action MEJGEIJNPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> BKEANBJGPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float APLIEGOOOMJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0150", Offset = "0x3AAF150", VA = "0x183AB0150")]
	public CGGJJKHNOGB(APKDMFAAHKI LJKCBGIFJKE, Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAEE70", VA = "0x183AAFE70")]
	public CGGJJKHNOGB(APKDMFAAHKI LJKCBGIFJKE, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0000", Offset = "0x3AAF000", VA = "0x183AB0000")]
	public CGGJJKHNOGB(APKDMFAAHKI LJKCBGIFJKE, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF950", Offset = "0x3AAE950", VA = "0x183AAF950")]
	private void CFKJIFEDOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF6F0", Offset = "0x3AAE6F0", VA = "0x183AAF6F0")]
	private void AJOODEANOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFD40", Offset = "0x3AAED40", VA = "0x183AAFD40")]
	private void OFNGLLFHGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFBA0", Offset = "0x3AAEBA0", VA = "0x183AAFBA0")]
	private void LEKOEOAHHFM(string MCGGOOFMGFP, Action ADKMINDCPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF870", Offset = "0x3AAE870", VA = "0x183AAF870")]
	[IteratorStateMachine(typeof(INHOKKDLMBK))]
	private IEnumerator<MKDOJLNJHKD> ANEPINKHBHE(Action ADKMINDCPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFAD0", Offset = "0x3AAEAD0", VA = "0x183AAFAD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF8D0", Offset = "0x3AAE8D0", VA = "0x183AAF8D0")]
	[CompilerGenerated]
	private void CCCJAHBCJMK(string GNHMBININJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFB20", Offset = "0x3AAEB20", VA = "0x183AAFB20")]
	[CompilerGenerated]
	private void EFGCPFEBGDL(string GNHMBININJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAECC0", VA = "0x183AAFCC0")]
	[CompilerGenerated]
	private void NHAKMKFEHIO(string GNHMBININJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class DHOCDBPECHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class DBKKOOJMCNK : IEnumerator<MKDOJLNJHKD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private MKDOJLNJHKD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private MKDOJLNJHKD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
		[DebuggerHidden]
		public DBKKOOJMCNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2700", Offset = "0x3AB1700", VA = "0x183AB2700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB27F0", Offset = "0x3AB17F0", VA = "0x183AB27F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private PPJBCEPCKCN HHIBCEOHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour DMBKBILOLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action MEJGEIJNPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> BKEANBJGPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float APLIEGOOOMJ;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3550", Offset = "0x3AB2550", VA = "0x183AB3550")]
	public DHOCDBPECHK(MonoBehaviour DMBKBILOLNI, Action MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB33C0", Offset = "0x3AB23C0", VA = "0x183AB33C0")]
	public DHOCDBPECHK(MonoBehaviour DMBKBILOLNI, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB36E0", Offset = "0x3AB26E0", VA = "0x183AB36E0")]
	public DHOCDBPECHK(MonoBehaviour DMBKBILOLNI, float NIEMEMDCOKP, Action<float> MEJGEIJNPPJ, JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2EA0", Offset = "0x3AB1EA0", VA = "0x183AB2EA0")]
	private void CFKJIFEDOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2C40", Offset = "0x3AB1C40", VA = "0x183AB2C40")]
	private void AJOODEANOJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3290", Offset = "0x3AB2290", VA = "0x183AB3290")]
	private void OFNGLLFHGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3AB30F0", Offset = "0x3AB20F0", VA = "0x183AB30F0")]
	private void LEKOEOAHHFM(string MCGGOOFMGFP, Action ADKMINDCPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2DC0", Offset = "0x3AB1DC0", VA = "0x183AB2DC0")]
	[IteratorStateMachine(typeof(DBKKOOJMCNK))]
	private IEnumerator<MKDOJLNJHKD> ANEPINKHBHE(Action ADKMINDCPJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3020", Offset = "0x3AB2020", VA = "0x183AB3020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2E20", Offset = "0x3AB1E20", VA = "0x183AB2E20")]
	[CompilerGenerated]
	private void CCCJAHBCJMK(string GNHMBININJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3070", Offset = "0x3AB2070", VA = "0x183AB3070")]
	[CompilerGenerated]
	private void EFGCPFEBGDL(string GNHMBININJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3AB3210", Offset = "0x3AB2210", VA = "0x183AB3210")]
	[CompilerGenerated]
	private void NHAKMKFEHIO(string GNHMBININJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface GBPOHFABBHH
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int FBCGJEKBOOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BFKMLHKLFNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly BFKMLHKLFNP EGFFJAJNOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action AKIDGAJAAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool JMENAGHLHGI;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x514D10", Offset = "0x513D10", VA = "0x180514D10")]
	public BFKMLHKLFNP(Action AKIDGAJAAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAE3B0", Offset = "0x3AAD3B0", VA = "0x183AAE3B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MKONHOEECIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T MJMAKEDLBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PFLMBMMMFDH(Action<T> DKJPAMDDDCH);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable PFLMBMMMFDH(UnityEngine.Object LJKCBGIFJKE, Action<T> DKJPAMDDDCH);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface BDPCCKIBEOC<T> : global::MKONHOEECIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T MJMAKEDLBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JGDALINJGAH<T> : global::BDPCCKIBEOC<T>, global::MKONHOEECIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class CMIKBILHNBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::JGDALINJGAH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::JBEDGAJIMHP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public CMIKBILHNBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1BF17B0", Offset = "0x1BF07B0", VA = "0x181BF17B0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject LLPIDANLMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::JBEDGAJIMHP<UnityEngine.Object, Action<T>>> ALDDPNLDIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T JPMGCLOHEED;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object HGEKOLBKNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1BFBD40", Offset = "0x1BFAD40", VA = "0x181BFBD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T MJMAKEDLBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F80", Offset = "0x5B3F80", VA = "0x1805B4F80", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1BFBCE0", Offset = "0x1BFACE0", VA = "0x181BFBCE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1BFBBE0", Offset = "0x1BFABE0", VA = "0x181BFBBE0")]
	private static bool COINOHADHPI(T JGNBJFDANMK, T AFFHLKNKJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1BFCA90", Offset = "0x1BFBA90", VA = "0x181BFCA90")]
	public JGDALINJGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1BFCAC0", Offset = "0x1BFBAC0", VA = "0x181BFCAC0")]
	public JGDALINJGAH(T JPCCCOJEJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1BFBBA0", Offset = "0x1BFABA0", VA = "0x181BFBBA0")]
	public void AOPEOECHOEJ(T DNFFJBLOIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1BFC160", Offset = "0x1BFB160", VA = "0x181BFC160", Slot = "7")]
	public IDisposable PFLMBMMMFDH(Action<T> DKJPAMDDDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1BFC1D0", Offset = "0x1BFB1D0", VA = "0x181BFC1D0", Slot = "8")]
	public IDisposable PFLMBMMMFDH(UnityEngine.Object LJKCBGIFJKE, Action<T> DKJPAMDDDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1BFC770", Offset = "0x1BFB770", VA = "0x181BFC770")]
	private void PHEBGKIEMCP()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<DKCJOHCPMCK, Scheduler>, DKCJOHCPMCK
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class DKLLPMMFBKN : GBPOHFABBHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public HFDLFDMNECP PBEIGDCCEHN;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int FBCGJEKBOOF
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x428E50", Offset = "0x427E50", VA = "0x180428E50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x428E60", Offset = "0x427E60", VA = "0x180428E60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3AB39F0", Offset = "0x3AB29F0", VA = "0x183AB39F0")]
			public static MKDOJLNJHKD DPHLHCEDJIA(IEnumerator<MKDOJLNJHKD> KIOHDKHAJOH, GIGMGLKBJJP GIEFOJPBPGE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3920", Offset = "0x3AB2920", VA = "0x183AB3920")]
			public MKDOJLNJHKD DPHLHCEDJIA(GIGMGLKBJJP[] JBJCGOGOBLD, IEnumerator<MKDOJLNJHKD>[] PGFFGIEHADJ, MKDOJLNJHKD[] LFLJOECNLBH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3AB38F0", Offset = "0x3AB28F0", VA = "0x183AB38F0")]
			public void BONLNLHFIHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3830", Offset = "0x3AB2830", VA = "0x183AB3830")]
			public void AHMDICIMABN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3B50", Offset = "0x3AB2B50", VA = "0x183AB3B50")]
			public void LABABNBFCHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3AB38F0", Offset = "0x3AB28F0", VA = "0x183AB38F0")]
			public void BNLKFAHJCMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
			public DKLLPMMFBKN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class HFDLFDMNECP
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct DNBKOINICDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public DKLLPMMFBKN EOLLNKJHEFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public APKDMFAAHKI MBCHCJEOELK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public GIGMGLKBJJP PBDMDBCANNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<MKDOJLNJHKD> PFKMHMNODMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public MKDOJLNJHKD BJFMHMOJDJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public JJEKNIBFEKG BIELJMADPFD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct CDDEMCKLGKO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public JLHCHGPAHDJ.JOKKMFMHBPB LMJLLFFNEHP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<DNBKOINICDE> NCIEAFNJAEB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class PBMCOHLIEBK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public HFDLFDMNECP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public APKDMFAAHKI context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public DKLLPMMFBKN routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public JJEKNIBFEKG coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public GIGMGLKBJJP promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public MKDOJLNJHKD currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<MKDOJLNJHKD> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
				public PBMCOHLIEBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x3ABC810", Offset = "0x3ABB810", VA = "0x183ABC810")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class OHODFJGJNMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public DKLLPMMFBKN schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public HFDLFDMNECP <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
				public OHODFJGJNMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x3ABAF30", Offset = "0x3AB9F30", VA = "0x183ABAF30")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class KKGLGCEHMLI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public DKLLPMMFBKN schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public HFDLFDMNECP <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
				public KKGLGCEHMLI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x3AB8180", Offset = "0x3AB7180", VA = "0x183AB8180")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class OGIMFGDCEPF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public DKLLPMMFBKN schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public HFDLFDMNECP <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
				public OGIMFGDCEPF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x3ABAEF0", Offset = "0x3AB9EF0", VA = "0x183ABAEF0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] BFBGPDLLKCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<JJEKNIBFEKG> DIGENAPLLDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> JJKCCBGPFKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> EJOCAHIPEMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> LAGAPPINPKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> BCOLHCLIEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> ICHLGKLKDGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> LPJODMKLIAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private DKLLPMMFBKN[] GGKDOAPHFFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private GIGMGLKBJJP[] JBJCGOGOBLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private APKDMFAAHKI[] OGFHCIBABME;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<MKDOJLNJHKD>[] AANJDMPMBEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private MKDOJLNJHKD[] OGLEDFEHLMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int ABDBOKKBCLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int FLHMGHOMCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int HMLBINEOLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float KHCGEAJJPAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private OKJHANKAHFF NCGOBBCHDDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle POMBNGOCPID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<DKLLPMMFBKN> IDNEPEEBKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool DBBKOGNNMCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> OCGLOGBNFGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> ADMKFAGEHFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool EHEKLGGOEDN;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public CDDEMCKLGKO[] IGALCMGCODJ
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x6F7D90", Offset = "0x6F6D90", VA = "0x1806F7D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int MNOMMDPPMNC
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x946C60", Offset = "0x945C60", VA = "0x180946C60")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB67C0", Offset = "0x3AB57C0", VA = "0x183AB67C0")]
			private static int NFLKOPLHJDD(JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3AB6AC0", Offset = "0x3AB5AC0", VA = "0x183AB6AC0")]
			public HFDLFDMNECP(JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5E30", Offset = "0x3AB4E30", VA = "0x183AB5E30")]
			private void LDCNPHCAOHJ(ref int FBKJEEHNEIF, int EELMOHFMLEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5090", Offset = "0x3AB4090", VA = "0x183AB5090")]
			public void DGLIDJFJOFN(APKDMFAAHKI LJKCBGIFJKE, MKDOJLNJHKD DINBEGIPIKI, IEnumerator<MKDOJLNJHKD> KIOHDKHAJOH, GIGMGLKBJJP GIEFOJPBPGE, [Optional] DKLLPMMFBKN FCHEGEAENFB, JJEKNIBFEKG DJBFNMJAPML = JJEKNIBFEKG.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5810", Offset = "0x3AB4810", VA = "0x183AB5810")]
			public void IGBBLPFAFOI(IEnumerable<DNBKOINICDE> AJJFDBPMIPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5A00", Offset = "0x3AB4A00", VA = "0x183AB5A00")]
			private DNBKOINICDE KIGPNIJDBON(int KPNMKCBAJGH)
			{
				return default(DNBKOINICDE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3AB54E0", Offset = "0x3AB44E0", VA = "0x183AB54E0")]
			private void FMGIDIGHNDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x199D7E0", Offset = "0x199C7E0", VA = "0x18199D7E0")]
			private static void POFNINONHMM<T>(int KPNMKCBAJGH, T[] CGDKFDGHNMD, int JMGGFMEEKPN, [Optional] T OGKMOJIJBEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x199D7C0", Offset = "0x199C7C0", VA = "0x18199D7C0")]
			private static void POFNINONHMM<T>(int KPNMKCBAJGH, NativeArray<T> CGDKFDGHNMD, int JMGGFMEEKPN, [Optional] T OGKMOJIJBEI) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3AB51C0", Offset = "0x3AB41C0", VA = "0x183AB51C0")]
			private void EGMHCJNFOIK(IEnumerable<DNBKOINICDE> AJJFDBPMIPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3AB6700", Offset = "0x3AB5700", VA = "0x183AB6700")]
			private void NAIMDHKFLEA(DNBKOINICDE EJLMHAFBDFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5FC0", Offset = "0x3AB4FC0", VA = "0x183AB5FC0")]
			private JNKGNGEKBNH LMJEFMAPJEE(int GNHHIDEMFGN)
			{
				return default(JNKGNGEKBNH);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3AB68D0", Offset = "0x3AB58D0", VA = "0x183AB68D0")]
			public void PKEINEKNIJD(float FOJBKCAEHJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4E00", Offset = "0x3AB3E00", VA = "0x183AB4E00")]
			private void AENMFBJMHCH(Action JGNBJFDANMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5460", Offset = "0x3AB4460", VA = "0x183AB5460")]
			private void FCMKGACNFIP(Action JGNBJFDANMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x3AB6260", Offset = "0x3AB5260", VA = "0x183AB6260")]
			public void MMGEGFANDHA(float FOJBKCAEHJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x3AB67F0", Offset = "0x3AB57F0", VA = "0x183AB67F0")]
			public void PFGPAPCIHGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4F30", Offset = "0x3AB3F30", VA = "0x183AB4F30")]
			public void BNLKFAHJCMJ(DKLLPMMFBKN PBDCDDKBGBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4E80", Offset = "0x3AB3E80", VA = "0x183AB4E80")]
			public void AIAJFMHAFOD(DKLLPMMFBKN PBDCDDKBGBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4FE0", Offset = "0x3AB3FE0", VA = "0x183AB4FE0")]
			public void DCPBHKMLHDH(DKLLPMMFBKN PBDCDDKBGBP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct OKJHANKAHFF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float KEIFDAKDGBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int KEHBJPAFPNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> LALHIDCCBHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> FBBIOBMJLAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> MAEGBOJCEAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<JJEKNIBFEKG> PEKHOECFEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> GPNFOCKDOIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> BCOLHCLIEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> EJOCAHIPEMJ;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB550", Offset = "0x3ABA550", VA = "0x183ABB550")]
			public static OKJHANKAHFF FIOHCBANLKE(int HDLFEADMBLC, float FOJBKCAEHJF, NativeArray<JJEKNIBFEKG> IIPEFGPEAOH, NativeArray<float> OABKGHJCJJM, NativeArray<int> FLFMDDKMONA, NativeArray<int> DFNAJAHHJBD, NativeArray<int> INFBAJEMBPA, NativeArray<int> FBBIOBMJLAG, NativeArray<int> MAEGBOJCEAI)
			{
				return default(OKJHANKAHFF);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB470", Offset = "0x3ABA470", VA = "0x183ABB470", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB920", Offset = "0x3ABA920", VA = "0x183ABB920")]
			private bool LKKGKIHJBNK(int JPADDGNBPOA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB440", Offset = "0x3ABA440", VA = "0x183ABB440")]
			private void CDDMJNDFOPI(NativeArray<int> CBGJJPLONII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB960", Offset = "0x3ABA960", VA = "0x183ABB960")]
			private int OPIFNCLLCMK(int PDMKJCPJNCP, int GJDHEMINFEE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB620", Offset = "0x3ABA620", VA = "0x183ABB620")]
			private void IHKDGGOJOKK(NativeArray<int> CBGJJPLONII, int LJCLPPPEPJB, int GNMICCACPMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3ABB6F0", Offset = "0x3ABA6F0", VA = "0x183ABB6F0")]
			private void JKCDMNBAFDD(NativeArray<int> CBGJJPLONII, int PDNMMEFNECD, int IBDINKONKDM, int DOOOCCMGPOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class KCLLMBEGINB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly GIGMGLKBJJP GIEFOJPBPGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour LJKCBGIFJKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool AFOIICCNJBI;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<MKDOJLNJHKD> PFKMHMNODMC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x428440", Offset = "0x427440", VA = "0x180428440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public MKDOJLNJHKD BJFMHMOJDJB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x428450", Offset = "0x427450", VA = "0x180428450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool BLGHBJKNKAI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x3AB7620", Offset = "0x3AB6620", VA = "0x183AB7620")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool CAPIGDGJOKP
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x661B70", Offset = "0x660B70", VA = "0x180661B70")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x677AE0", Offset = "0x676AE0", VA = "0x180677AE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string DDBCGNNCNNM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x428F90", Offset = "0x427F90", VA = "0x180428F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x428FA0", Offset = "0x427FA0", VA = "0x180428FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float PDFAKNAPEPN
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xF920E0", Offset = "0xF910E0", VA = "0x180F920E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xF921C0", Offset = "0xF911C0", VA = "0x180F921C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3AB77D0", Offset = "0x3AB67D0", VA = "0x183AB77D0")]
			public KCLLMBEGINB(IEnumerator<MKDOJLNJHKD> KIOHDKHAJOH, Behaviour LJKCBGIFJKE, GIGMGLKBJJP GIEFOJPBPGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3AB7410", Offset = "0x3AB6410", VA = "0x183AB7410")]
			public MKDOJLNJHKD DPHLHCEDJIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3AB76B0", Offset = "0x3AB66B0", VA = "0x183AB76B0")]
			public bool PANGEEEMNAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3AB7380", Offset = "0x3AB6380", VA = "0x183AB7380")]
			public void BNLKFAHJCMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB7740", Offset = "0x3AB6740", VA = "0x183AB7740", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x118F110", Offset = "0x118E110", VA = "0x18118F110")]
			[CompilerGenerated]
			private void OFNNABLCMOO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class GIGMGLKBJJP : PLCEAFOJAAI, PPJBCEPCKCN, DPOOMLLAPDH, EBJFPPEJHJH, IEnumerator, MKDOJLNJHKD, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private JLHCHGPAHDJ.JOKKMFMHBPB IBLFIODICNH;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private JLHCHGPAHDJ.JOKKMFMHBPB KJNIKOGICID
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x44C290", Offset = "0x44B290", VA = "0x18044C290", Slot = "23")]
				get
				{
					return default(JLHCHGPAHDJ.JOKKMFMHBPB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public JLHCHGPAHDJ.JOKKMFMHBPB PBEIGDCCEHN
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x44C290", Offset = "0x44B290", VA = "0x18044C290")]
				get
				{
					return default(JLHCHGPAHDJ.JOKKMFMHBPB);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5F3230", Offset = "0x5F2230", VA = "0x1805F3230")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float NPMIMEDMBPI
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xB9B8B0", Offset = "0xB9A8B0", VA = "0x180B9B8B0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4810", Offset = "0x3AB3810", VA = "0x183AB4810", Slot = "24")]
			private bool EJMIAGCIEED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4800", Offset = "0x3AB3800", VA = "0x183AB4800", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4830", Offset = "0x3AB3830", VA = "0x183AB4830")]
			public GIGMGLKBJJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum JNKGNGEKBNH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class LHDFCACIMEG : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum BHOELNKAGCG
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct DGBGIOGJDEJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public JLHCHGPAHDJ.JOKKMFMHBPB LMJLLFFNEHP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public BHOELNKAGCG AGJHIPJCEMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<KCLLMBEGINB> FFIDNNEMEBJ;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly BHOELNKAGCG[] BECBHPPEKKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly JLHCHGPAHDJ.JOKKMFMHBPB GEFCCPCDEIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool PPGEBNPIJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly KCLLMBEGINB[] OHKJMHAOHCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<KCLLMBEGINB> EMHHDEANOKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> MCEMHGCJFAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<KCLLMBEGINB> MELINCFCPFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> IOFCCNMBPID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool EHEKLGGOEDN;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public DGBGIOGJDEJ[,] LEPAJPBGLKC
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x43B470", Offset = "0x43A470", VA = "0x18043B470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int MNOMMDPPMNC
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x3AB9540", Offset = "0x3AB8540", VA = "0x183AB9540")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9D40", Offset = "0x3AB8D40", VA = "0x183AB9D40")]
			public LHDFCACIMEG(JLHCHGPAHDJ.JOKKMFMHBPB AOKMLIKJOIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3AB99D0", Offset = "0x3AB89D0", VA = "0x183AB99D0")]
			public void MMKCILEJBAO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9530", Offset = "0x3AB8530", VA = "0x183AB9530")]
			public void KJDOLKOBKDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3AB96B0", Offset = "0x3AB86B0", VA = "0x183AB96B0")]
			private void LFKBLMIENHO(IReadOnlyList<KCLLMBEGINB> JBFEPFLGEJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8E50", Offset = "0x3AB7E50", VA = "0x183AB8E50")]
			public void FDGIEDOMFIF(KCLLMBEGINB KIOHDKHAJOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8BD0", Offset = "0x3AB7BD0", VA = "0x183AB8BD0")]
			public void EIBMHBHPJGB(IList<KCLLMBEGINB> PGFFGIEHADJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3AB92B0", Offset = "0x3AB82B0", VA = "0x183AB92B0")]
			public void ICAPEOLHADO(IList<KCLLMBEGINB> PGFFGIEHADJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3AB89A0", Offset = "0x3AB79A0", VA = "0x183AB89A0")]
			private void CBHHPIHOILN(KCLLMBEGINB KIOHDKHAJOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3AB99E0", Offset = "0x3AB89E0", VA = "0x183AB99E0")]
			private void MMLNNAGDABM(IList<KCLLMBEGINB> PGFFGIEHADJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9130", Offset = "0x3AB8130", VA = "0x183AB9130")]
			private JNKGNGEKBNH GPKLAIDKKEM(KCLLMBEGINB KIOHDKHAJOH)
			{
				return default(JNKGNGEKBNH);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3AB88F0", Offset = "0x3AB78F0", VA = "0x183AB88F0")]
			public void AELFABGBJOO(float FOJBKCAEHJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x3AB97D0", Offset = "0x3AB87D0", VA = "0x183AB97D0")]
			public void LIJPGNFOEBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8F50", Offset = "0x3AB7F50", VA = "0x183AB8F50")]
			private void FHLOMBPEFFK(List<KCLLMBEGINB> PGFFGIEHADJ, Stack<int> OJNCHDNMNPO, bool AEFADJMCAAH, float JPLNCKIEPIJ = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8A90", Offset = "0x3AB7A90", VA = "0x183AB8A90", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9B50", Offset = "0x3AB8B50", VA = "0x183AB9B50")]
			private void PLEMLEGBIBP(List<KCLLMBEGINB> PGFFGIEHADJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum JJEKNIBFEKG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class HAKKCBONJOE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x513CF0", Offset = "0x512CF0", VA = "0x180513CF0")]
			[DebuggerHidden]
			public HAKKCBONJOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4D30", Offset = "0x3AB3D30", VA = "0x183AB4D30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4DB0", Offset = "0x3AB3DB0", VA = "0x183AB4DB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const JJEKNIBFEKG MGBFPHLKPII = JJEKNIBFEKG.Cancelled | JJEKNIBFEKG.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly JLHCHGPAHDJ.JOKKMFMHBPB[] LGGGKOJLJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private LHDFCACIMEG[] MHMKEBIOKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private HFDLFDMNECP[] DGGMJCGFIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine INGMDBJFKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame EKEIJOEAKEA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public JLHCHGPAHDJ.JOKKMFMHBPB ACJBOFLFDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4AC0A0", Offset = "0x4AB0A0", VA = "0x1804AC0A0")]
			[CompilerGenerated]
			get
			{
				return default(JLHCHGPAHDJ.JOKKMFMHBPB);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x531770", Offset = "0x530770", VA = "0x180531770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GKPBFKDODII
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x661870", Offset = "0x660870", VA = "0x180661870", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1771750", Offset = "0x1770750", VA = "0x181771750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int MNOMMDPPMNC
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3ABF330", Offset = "0x3ABE330", VA = "0x183ABF330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDFD0", Offset = "0x3ABCFD0", VA = "0x183ABDFD0")]
		public static PPJBCEPCKCN GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDB00", Offset = "0x3ABCB00", VA = "0x183ABDB00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE290", Offset = "0x3ABD290", VA = "0x183ABE290", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE250", Offset = "0x3ABD250", VA = "0x183ABE250")]
		private LHDFCACIMEG MIPLENFKIFM(JLHCHGPAHDJ.JOKKMFMHBPB OGJIHDMNCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6C6200", Offset = "0x6C5200", VA = "0x1806C6200")]
		private HFDLFDMNECP OPCJMAACIGG(JLHCHGPAHDJ.JOKKMFMHBPB OGJIHDMNCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE720", Offset = "0x3ABD720", VA = "0x183ABE720")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE6F0", Offset = "0x3ABD6F0", VA = "0x183ABE6F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3ABF120", Offset = "0x3ABE120", VA = "0x183ABF120")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE230", Offset = "0x3ABD230", VA = "0x183ABE230")]
		private void KGABGDANAGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDF50", Offset = "0x3ABCF50", VA = "0x183ABDF50")]
		private void CIBKOFPPDEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDFC0", Offset = "0x3ABCFC0", VA = "0x183ABDFC0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE240", Offset = "0x3ABD240", VA = "0x183ABE240")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDF40", Offset = "0x3ABCF40", VA = "0x183ABDF40")]
		private void BGDLGNJHGFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE790", Offset = "0x3ABD790", VA = "0x183ABE790")]
		[IteratorStateMachine(typeof(HAKKCBONJOE))]
		private IEnumerator PHJFBKIEFDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3ABEC40", Offset = "0x3ABDC40", VA = "0x183ABEC40", Slot = "7")]
		public PPJBCEPCKCN Run(IEnumerator<MKDOJLNJHKD> PGEOLKHEDBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE920", Offset = "0x3ABD920", VA = "0x183ABE920", Slot = "8")]
		public PPJBCEPCKCN Run(Behaviour LJKCBGIFJKE, IEnumerator<MKDOJLNJHKD> PGEOLKHEDBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE7F0", Offset = "0x3ABD7F0", VA = "0x183ABE7F0", Slot = "9")]
		public PPJBCEPCKCN RunJobbed(APKDMFAAHKI LJKCBGIFJKE, IEnumerator<MKDOJLNJHKD> PGEOLKHEDBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDF60", Offset = "0x3ABCF60", VA = "0x183ABDF60", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABEC50", Offset = "0x3ABDC50", VA = "0x183ABEC50")]
		public void UpdateQueue(JLHCHGPAHDJ.JOKKMFMHBPB GBGMAOKOCHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE070", Offset = "0x3ABD070", VA = "0x183ABE070")]
		private void KENKNPHKJIK(LHDFCACIMEG NFAJKFFEOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD9E0", Offset = "0x3ABC9E0", VA = "0x183ABD9E0")]
		private void AGJEKMJKCAL(HFDLFDMNECP NFAJKFFEOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3ABF2D0", Offset = "0x3ABE2D0", VA = "0x183ABF2D0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class JGHPBFMDKID
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB72F0", Offset = "0x3AB62F0", VA = "0x183AB72F0")]
	[DENNFMOJHMM]
	private static void AAIBGKJCEGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class CBHLDNGCJNK : GPLBBAOPPJD
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float CBPJDPBGGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF6E0", Offset = "0x3AAE6E0", VA = "0x183AAF6E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float LAKFBCGGJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF6B0", Offset = "0x3AAE6B0", VA = "0x183AAF6B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float BGDNEPGJOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF6C0", Offset = "0x3AAE6C0", VA = "0x183AAF6C0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MBPDNFHFKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF6D0", Offset = "0x3AAE6D0", VA = "0x183AAF6D0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double EGPDCCINGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF690", Offset = "0x3AAE690", VA = "0x183AAF690", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	public CBHLDNGCJNK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LGDKMIAMCPL
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] LLKCDANIMKG;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int KMKLKIAMDMD;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int BIIMDIBEBNB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger IFDENKAOIAA;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	public LGDKMIAMCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8310", Offset = "0x3AB7310", VA = "0x183AB8310")]
	private static string CIKBPDDNPOK(byte[] AFFHLKNKJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8410", Offset = "0x3AB7410", VA = "0x183AB8410")]
	public static string PKHKMHCALIH(byte[] CKHCBGBCFMM, bool INBKMGGNPMJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
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

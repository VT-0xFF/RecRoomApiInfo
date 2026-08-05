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
		private delegate List<PlayerLoopSystem> IFGDCKLKDNA(List<PlayerLoopSystem> BLBIOABGPPE, int BDHCMMHKADK);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct JOJCEPGECLN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct BLNGBBPJMMN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MAEEJHBHLJC CCGBALHGOFC;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x3C96080", Offset = "0x3C95280", VA = "0x183C96080")]
				public static PlayerLoopSystem JELCLBAMCIN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct KEBHIPFGJEM
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MAEEJHBHLJC LJBDLDAIADI;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3C9E950", Offset = "0x3C9DB50", VA = "0x183C9E950")]
				public static PlayerLoopSystem JELCLBAMCIN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct KAFLFNGLAKA
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MAEEJHBHLJC JAEMBEPHGJF;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3C9E160", Offset = "0x3C9D360", VA = "0x183C9E160")]
				public static PlayerLoopSystem JELCLBAMCIN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct PDPGJDFPMBF
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class JGCNOMLHBCH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public FKMKHOBNDAM.PMAPCAECJHO key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
					public JGCNOMLHBCH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x3C9E0B0", Offset = "0x3C9D2B0", VA = "0x183C9E0B0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable HCNAEHACNNK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3CA3540", Offset = "0x3CA2740", VA = "0x183CA3540")]
				public static PlayerLoopSystem BFLJEBIPEKJ(FKMKHOBNDAM.PMAPCAECJHO FIIDMDOOCIB)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct OBMHHJJJAIB
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class PCIJDDDLAIB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public FKMKHOBNDAM.PMAPCAECJHO key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
					public PCIJDDDLAIB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x3CA2EA0", Offset = "0x3CA20A0", VA = "0x183CA2EA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3CA1360", Offset = "0x3CA0560", VA = "0x183CA1360")]
				public static PlayerLoopSystem BFLJEBIPEKJ(FKMKHOBNDAM.PMAPCAECJHO FIIDMDOOCIB)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class HCBAPLIMAPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public HCBAPLIMAPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3C9DBF0", Offset = "0x3C9CDF0", VA = "0x183C9DBF0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool DEGLLGDCOAE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LPHCKGNBGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3C971B0", Offset = "0x3C963B0", VA = "0x183C971B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3C97170", Offset = "0x3C96370", VA = "0x183C97170")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3C96320", Offset = "0x3C95520", VA = "0x183C96320")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3C97560", Offset = "0x3C96760", VA = "0x183C97560")]
		private static void NEPIOOOKEPP(FKMKHOBNDAM.PMAPCAECJHO FIIDMDOOCIB, ref PlayerLoopSystem MOBMHJEODPE, Type FLPIJOENMCN, Type EDEDMNMAAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3C971F0", Offset = "0x3C963F0", VA = "0x183C971F0")]
		private static void NBFFHJIEHOI(ref PlayerLoopSystem MOBMHJEODPE, Type FLPIJOENMCN, Type EDEDMNMAAFA, IFGDCKLKDNA JCPCOGEEAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C977C0", Offset = "0x3C969C0", VA = "0x183C977C0")]
		private static void ODOPKHAEIJB(ref PlayerLoopSystem MOBMHJEODPE, Type FLPIJOENMCN, Type EDEDMNMAAFA, PlayerLoopSystem? ADLOOFDGIHP, PlayerLoopSystem? PCKLGKHFAPE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FKMKHOBNDAM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PMAPCAECJHO
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
	public class NOOHGAKPCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly PMAPCAECJHO AABLGJLAHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly FELEBFPDAMH FNKLAKGBNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long BEEMIGGPBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long LCBICNBAACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long KCDBHPDLECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int MNEEDEJBOKA;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3CA10F0", Offset = "0x3CA02F0", VA = "0x183CA10F0")]
		public NOOHGAKPCFO(PMAPCAECJHO NNNHDBDOJGA, int NENBODAABMO = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0F60", Offset = "0x3CA0160", VA = "0x183CA0F60")]
		public void GMMFAJLNCJL(int IONGCKJOABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0F80", Offset = "0x3CA0180", VA = "0x183CA0F80")]
		public void GOHMJOFMDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0FF0", Offset = "0x3CA01F0", VA = "0x183CA0FF0")]
		public void HNALIJCHEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0D90", Offset = "0x3C9FF90", VA = "0x183CA0D90")]
		public void ALKAKIADBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1050", Offset = "0x3CA0250", VA = "0x183CA1050")]
		public double PEPOMNJHDLN(int MMDBBMNNNOD)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int JKKNPLPPNPK = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static PMAPCAECJHO[] JLEGPKICPLP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static NOOHGAKPCFO[] PEMPHBHGGCB;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BF20", Offset = "0x3C9B120", VA = "0x183C9BF20")]
	public static NOOHGAKPCFO CDMOOOKLLIG(PMAPCAECJHO FIIDMDOOCIB, int NENBODAABMO = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C0B0", Offset = "0x3C9B2B0", VA = "0x183C9C0B0")]
	public static NOOHGAKPCFO LJOBFFCMJFG(PMAPCAECJHO FIIDMDOOCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C140", Offset = "0x3C9B340", VA = "0x183C9C140")]
	public static void MGGGGENCBKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FELEBFPDAMH : LPCIBCOCIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CKOCIENDEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> MHPKCECGPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double JIDAPDOEDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double OJOEKGCCPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double OLIJLONBKGF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IBENKCGEBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3C9ACB0", Offset = "0x3C99EB0", VA = "0x183C9ACB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GIHBDLBOPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AC50", Offset = "0x3C99E50", VA = "0x183C9AC50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FGFABKFFKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD5CE20", Offset = "0xD5C020", VA = "0x180D5CE20", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double NEJHEDHIIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2AC0", Offset = "0x2BE1CC0", VA = "0x182BE2AC0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ACF0", Offset = "0x3C99EF0", VA = "0x183C9ACF0")]
	public FELEBFPDAMH(int EMBMJIPBHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AAE0", Offset = "0x3C99CE0", VA = "0x183C9AAE0", Slot = "4")]
	public void BKLDBEHPNHO(double KKGCJBKLPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ABE0", Offset = "0x3C99DE0", VA = "0x183C9ABE0", Slot = "5")]
	public void BNIOLOBANIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NAMGHJMHIPF : LPCIBCOCIOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long LOPNMMNMIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double FCABDKJPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double NAGBOOCEKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double LHNNIALODEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double KNKNBJNJACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double JIDAPDOEDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double OJOEKGCCPFP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long HACPMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double FGFABKFFKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2659910", Offset = "0x2658B10", VA = "0x182659910", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NEJHEDHIIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AA0", Offset = "0x6E6CA0", VA = "0x1806E7AA0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double ADJBJGIELKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2AC0", Offset = "0x2BE1CC0", VA = "0x182BE2AC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JHFMNJJNBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2AB0", Offset = "0x2BE1CB0", VA = "0x182BE2AB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double GIHBDLBOPME
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2F5B760", Offset = "0x2F5A960", VA = "0x182F5B760", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9FFC0", Offset = "0x3C9F1C0", VA = "0x183C9FFC0", Slot = "4")]
	public void BKLDBEHPNHO(double KKGCJBKLPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA00E0", Offset = "0x3C9F2E0", VA = "0x183CA00E0", Slot = "5")]
	public void BNIOLOBANIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0120", Offset = "0x3C9F320", VA = "0x183CA0120")]
	public NAMGHJMHIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LPCIBCOCIOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GIHBDLBOPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double FGFABKFFKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double NEJHEDHIIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKLDBEHPNHO(double KKGCJBKLPEC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNIOLOBANIC();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NEEHGPADBKA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface CBDAKGBFEDH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool OAELBJBIJMK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NPJHDMFBKOI();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LHNIFMAJKFN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class ECNLKJNNHGE<TPromise, TMainThreadPromise> : CBDAKGBFEDH where TPromise : MLALFLMLHEI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise PMGFCDJCHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise BHNDOMDLGCB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise BFLDAMILIAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2062210", Offset = "0x2061410", VA = "0x182062210")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OAELBJBIJMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x20622A0", Offset = "0x20614A0", VA = "0x1820622A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x196C4B0", Offset = "0x196B6B0", VA = "0x18196C4B0")]
		protected ECNLKJNNHGE(TPromise PMGFCDJCHDB, TMainThreadPromise DJKKANELGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2062270", Offset = "0x2061470", VA = "0x182062270", Slot = "5")]
		public void NPJHDMFBKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1965F90", Offset = "0x1965190", VA = "0x181965F90", Slot = "6")]
		public void LHNIFMAJKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void IOCCKEOGLOO(TPromise PMGFCDJCHDB);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void LEAPHKPDGCA();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class PEFCGIADOGK<T> : ECNLKJNNHGE<global::GFAADABKIAG<T>, global::FLNHJFLHBAN<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2074CE0", Offset = "0x2073EE0", VA = "0x182074CE0")]
		public PEFCGIADOGK(global::GFAADABKIAG<T> PMGFCDJCHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2074AB0", Offset = "0x2073CB0", VA = "0x182074AB0", Slot = "7")]
		protected override void IOCCKEOGLOO(global::GFAADABKIAG<T> PMGFCDJCHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2074C50", Offset = "0x2073E50", VA = "0x182074C50", Slot = "8")]
		protected override void LEAPHKPDGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2074A80", Offset = "0x2073C80", VA = "0x182074A80")]
		[CompilerGenerated]
		private void DLLGGNIOAPO(T DKJBHJBBAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2074CB0", Offset = "0x2073EB0", VA = "0x182074CB0")]
		[CompilerGenerated]
		private void PHLGADJMEOO(string IKNIEMKPGCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class OBKHPIJENDD : ECNLKJNNHGE<MLALFLMLHEI, LMLIEBFGMMN>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA12F0", Offset = "0x3CA04F0", VA = "0x183CA12F0")]
		public OBKHPIJENDD(MLALFLMLHEI PMGFCDJCHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA11D0", Offset = "0x3CA03D0", VA = "0x183CA11D0", Slot = "7")]
		protected override void IOCCKEOGLOO(MLALFLMLHEI PMGFCDJCHDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA12A0", Offset = "0x3CA04A0", VA = "0x183CA12A0", Slot = "8")]
		protected override void LEAPHKPDGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xB04770", Offset = "0xB03970", VA = "0x180B04770")]
		[CompilerGenerated]
		private void DLLGGNIOAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x15C0690", Offset = "0x15BF890", VA = "0x1815C0690")]
		[CompilerGenerated]
		private void PHLGADJMEOO(string IKNIEMKPGCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class LLJMBJLPKGG : CBDAKGBFEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action DMBCNIHDJBD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OAELBJBIJMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x46FF60", Offset = "0x46F160", VA = "0x18046FF60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
		public LLJMBJLPKGG(Action DMBCNIHDJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x13939B0", Offset = "0x1392BB0", VA = "0x1813939B0", Slot = "5")]
		public void NPJHDMFBKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "6")]
		public void LHNIFMAJKFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<CBDAKGBFEDH> MFCMMNGNDMN;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x19F73A0", Offset = "0x19F65A0", VA = "0x1819F73A0")]
	public static global::GFAADABKIAG<T> BCGALIAKEHL<T>(this global::GFAADABKIAG<T> PMGFCDJCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0190", Offset = "0x3C9F390", VA = "0x183CA0190")]
	public static MLALFLMLHEI BCGALIAKEHL(this MLALFLMLHEI PMGFCDJCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3CA02A0", Offset = "0x3C9F4A0", VA = "0x183CA02A0")]
	public static void BCGALIAKEHL(Action DMBCNIHDJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x19F7410", Offset = "0x19F6610", VA = "0x1819F7410")]
	private static global::GFAADABKIAG<T> ECAFHDHBALL<T>(global::GFAADABKIAG<T> PMGFCDJCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3CA03F0", Offset = "0x3C9F5F0", VA = "0x183CA03F0")]
	private static MLALFLMLHEI ECAFHDHBALL(MLALFLMLHEI PMGFCDJCHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3CA04D0", Offset = "0x3C9F6D0", VA = "0x183CA04D0")]
	private static void ELEPHANINKH(CBDAKGBFEDH NBJCKHMKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA06B0", Offset = "0x3C9F8B0", VA = "0x183CA06B0")]
	private static void FOHBOEMBACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0320", Offset = "0x3C9F520", VA = "0x183CA0320")]
	private static void CBAFEANGIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA09D0", Offset = "0x3C9FBD0", VA = "0x183CA09D0")]
	private static void GCKPJJDKIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PFBMOBKGODJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class DPADEOJNOFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LMLIEBFGMMN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public DPADEOJNOFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C97910", Offset = "0x3C96B10", VA = "0x183C97910")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C97900", Offset = "0x3C96B00", VA = "0x183C97900")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ICJAMLNEHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public ICJAMLNEHDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DEB0", Offset = "0x3C9D0B0", VA = "0x183C9DEB0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MFBLIBGCGPB : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LMLIEBFGMMN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public MFBLIBGCGPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FC50", Offset = "0x3C9EE50", VA = "0x183C9FC50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F980", Offset = "0x3C9EB80", VA = "0x183C9F980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FD00", Offset = "0x3C9EF00", VA = "0x183C9FD00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FC00", Offset = "0x3C9EE00", VA = "0x183C9FC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MIPBHCHABGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LMLIEBFGMMN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public MIPBHCHABGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OGKNLDPOAMA : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LMLIEBFGMMN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private MIPBHCHABGA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public OGKNLDPOAMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1FE0", Offset = "0x3CA11E0", VA = "0x183CA1FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3CA2330", Offset = "0x3CA1530", VA = "0x183CA2330", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string PGJIPIIOEDP = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string CLKPEOAGJHE = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string GHIJDBEOLOD = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string KGEFBPNIIGG = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string CCMEGPGKAOP = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float OFGKGIFAPCG = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static MLALFLMLHEI ABJKBFDBMIE;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation JNAFNBGMIJE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static MLALFLMLHEI LNNGLENBMBH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string GCLHFLGELGE;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority JGNNCHLKKPI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool GEBPJAEHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3A30", Offset = "0x3CA2C30", VA = "0x183CA3A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PBKCIALEPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3CA36B0", Offset = "0x3CA28B0", VA = "0x183CA36B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool HIBFEEKOOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3AD0", Offset = "0x3CA2CD0", VA = "0x183CA3AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> AEGKPBLEPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3850", Offset = "0x3CA2A50", VA = "0x183CA3850")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3900", Offset = "0x3CA2B00", VA = "0x183CA3900")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3710", Offset = "0x3CA2910", VA = "0x183CA3710")]
	public static MLALFLMLHEI EANFGNCDGKG(string JKFDDFFHBBK, LoadSceneMode PPPPCCMDFLN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3B30", Offset = "0x3CA2D30", VA = "0x183CA3B30")]
	public static MLALFLMLHEI NAPHFFAJGCN(string JKFDDFFHBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3640", Offset = "0x3CA2840", VA = "0x183CA3640")]
	[IteratorStateMachine(typeof(MFBLIBGCGPB))]
	private static IEnumerator<GAGJCGDODGC> BFKKFIACHPB(string JKFDDFFHBBK, LMLIEBFGMMN DOKCENADNIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA39B0", Offset = "0x3CA2BB0", VA = "0x183CA39B0")]
	[IteratorStateMachine(typeof(OGKNLDPOAMA))]
	private static IEnumerator<GAGJCGDODGC> IENLNEEMDDJ(string JKFDDFFHBBK, LoadSceneMode PPPPCCMDFLN, LMLIEBFGMMN DOKCENADNIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OOJPPOLOCPE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2590", Offset = "0x3CA1790", VA = "0x183CA2590")]
	public static IDisposable DOAOFHOOHFJ(this MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2610", Offset = "0x3CA1810", VA = "0x183CA2610")]
	public static IDisposable DOAOFHOOHFJ(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2BC0", Offset = "0x3CA1DC0", VA = "0x183CA2BC0")]
	public static IDisposable ODFAMCDOJJF(this MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2CC0", Offset = "0x3CA1EC0", VA = "0x183CA2CC0")]
	public static IDisposable PBJBGMJKGJL(this MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2DA0", Offset = "0x3CA1FA0", VA = "0x183CA2DA0")]
	public static IDisposable PMKAAHNNDLE(this MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2D30", Offset = "0x3CA1F30", VA = "0x183CA2D30")]
	public static IDisposable PLFJKLDIMOL(this MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2950", Offset = "0x3CA1B50", VA = "0x183CA2950")]
	public static IDisposable JLGBLGAPBAL(this MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2E10", Offset = "0x3CA2010", VA = "0x183CA2E10")]
	public static IDisposable PNOMIEDFCBM(this MBBEIFLIIKN MEFIPNMPAKF, float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2B40", Offset = "0x3CA1D40", VA = "0x183CA2B40")]
	public static IDisposable MMHMDKPAEGL(this MBBEIFLIIKN MEFIPNMPAKF, float OPBNICHNHHF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA29C0", Offset = "0x3CA1BC0", VA = "0x183CA29C0")]
	public static IDisposable KEPOOCNJPGJ(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2380", Offset = "0x3CA1580", VA = "0x183CA2380")]
	public static IDisposable AGAMOLGDLMC(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2AC0", Offset = "0x3CA1CC0", VA = "0x183CA2AC0")]
	public static IDisposable KILGLIDMHGI(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2500", Offset = "0x3CA1700", VA = "0x183CA2500")]
	public static IDisposable DFIBOOGNNDC(this MBBEIFLIIKN MEFIPNMPAKF, float OPBNICHNHHF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2A40", Offset = "0x3CA1C40", VA = "0x183CA2A40")]
	public static IDisposable KGHPNGLMNLD(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CA28D0", Offset = "0x3CA1AD0", VA = "0x183CA28D0")]
	public static IDisposable INKGHDBOAOI(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2480", Offset = "0x3CA1680", VA = "0x183CA2480")]
	public static IDisposable BAHNECCOOLB(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2C30", Offset = "0x3CA1E30", VA = "0x183CA2C30")]
	public static IDisposable OFMIJJMLOFN(this MBBEIFLIIKN MEFIPNMPAKF, float OPBNICHNHHF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2400", Offset = "0x3CA1600", VA = "0x183CA2400")]
	public static IDisposable BAAHJDJJJJK(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3CA27D0", Offset = "0x3CA19D0", VA = "0x183CA27D0")]
	public static IDisposable DOBPNIAICEM(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2850", Offset = "0x3CA1A50", VA = "0x183CA2850")]
	public static IDisposable ICLHLAEKBPG(this MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class FHNAPHMHOHI
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BC90", Offset = "0x3C9AE90", VA = "0x183C9BC90")]
	public static IDisposable OECAEBOLGJL(this MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BAD0", Offset = "0x3C9ACD0", VA = "0x183C9BAD0")]
	public static IDisposable OECAEBOLGJL(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BE80", Offset = "0x3C9B080", VA = "0x183C9BE80")]
	public static IDisposable PLPDAPDFNAC(this MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B460", Offset = "0x3C9A660", VA = "0x183C9B460")]
	public static IDisposable CPONCLJKJNJ(this MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B770", Offset = "0x3C9A970", VA = "0x183C9B770")]
	public static IDisposable JMBEGAKLCAP(this MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BD90", Offset = "0x3C9AF90", VA = "0x183C9BD90")]
	public static IDisposable OHACIFBNMIK(this MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BA60", Offset = "0x3C9AC60", VA = "0x183C9BA60")]
	public static IDisposable NMEHCNJBBKJ(this MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B550", Offset = "0x3C9A750", VA = "0x183C9B550")]
	public static IDisposable HAJIKANJNMP(this MonoBehaviour FEDLFPCLHMI, float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B860", Offset = "0x3C9AA60", VA = "0x183C9B860")]
	public static IDisposable MEPKDDPJPCI(this MonoBehaviour FEDLFPCLHMI, float OPBNICHNHHF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BD10", Offset = "0x3C9AF10", VA = "0x183C9BD10")]
	public static IDisposable OGEKGJLKDON(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B9E0", Offset = "0x3C9ABE0", VA = "0x183C9B9E0")]
	public static IDisposable NLKGPCENEBB(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B360", Offset = "0x3C9A560", VA = "0x183C9B360")]
	public static IDisposable CABKKJBFMKN(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B7E0", Offset = "0x3C9A9E0", VA = "0x183C9B7E0")]
	public static IDisposable KLPOCFMDHOM(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B3E0", Offset = "0x3C9A5E0", VA = "0x183C9B3E0")]
	public static IDisposable CLCCKFLEGBK(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B960", Offset = "0x3C9AB60", VA = "0x183C9B960")]
	public static IDisposable NCBBCMJJKNH(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B250", Offset = "0x3C9A450", VA = "0x183C9B250")]
	public static IDisposable BEEBGPAIFBA(this MonoBehaviour FEDLFPCLHMI, float OPBNICHNHHF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B4D0", Offset = "0x3C9A6D0", VA = "0x183C9B4D0")]
	public static IDisposable GMGKKFGDJIL(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B6F0", Offset = "0x3C9A8F0", VA = "0x183C9B6F0")]
	public static IDisposable JFGNDFDIGBK(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B8E0", Offset = "0x3C9AAE0", VA = "0x183C9B8E0")]
	public static IDisposable MFDDFOCMMFN(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B660", Offset = "0x3C9A860", VA = "0x183C9B660")]
	public static IDisposable IDDAEFDPOEF(this MonoBehaviour FEDLFPCLHMI, float OPBNICHNHHF, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B5E0", Offset = "0x3C9A7E0", VA = "0x183C9B5E0")]
	public static IDisposable HMFGOOCKEJD(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BE00", Offset = "0x3C9B000", VA = "0x183C9BE00")]
	public static IDisposable PHPLOMEIGOH(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B2E0", Offset = "0x3C9A4E0", VA = "0x183C9B2E0")]
	public static IDisposable BMONDNOIBJF(this MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ECLCGDGLJCN
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class APNFFFOAOFF : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public GFIGKKNJOIH.OAGKLGIDJML queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private EAOIPEHHJGJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public APNFFFOAOFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C95A90", Offset = "0x3C94C90", VA = "0x183C95A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C95B60", Offset = "0x3C94D60", VA = "0x183C95B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IPODFDBFIBM : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GFIGKKNJOIH.OAGKLGIDJML queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EAOIPEHHJGJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public IPODFDBFIBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DF70", Offset = "0x3C9D170", VA = "0x183C9DF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E060", Offset = "0x3C9D260", VA = "0x183C9E060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C97F00", Offset = "0x3C97100", VA = "0x183C97F00")]
	public static BLKCKFJNHGD OECAEBOLGJL(Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3C97FF0", Offset = "0x3C971F0", VA = "0x183C97FF0")]
	public static BLKCKFJNHGD OECAEBOLGJL(Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C97DF0", Offset = "0x3C96FF0", VA = "0x183C97DF0")]
	public static BLKCKFJNHGD OECAEBOLGJL(Behaviour MEFIPNMPAKF, Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C980E0", Offset = "0x3C972E0", VA = "0x183C980E0")]
	public static BLKCKFJNHGD OECAEBOLGJL(Behaviour MEFIPNMPAKF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C97AF0", Offset = "0x3C96CF0", VA = "0x183C97AF0")]
	public static BLKCKFJNHGD DOAOFHOOHFJ(MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3C97C00", Offset = "0x3C96E00", VA = "0x183C97C00")]
	public static BLKCKFJNHGD DOAOFHOOHFJ(MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3C97D80", Offset = "0x3C96F80", VA = "0x183C97D80")]
	[IteratorStateMachine(typeof(APNFFFOAOFF))]
	private static IEnumerator<GAGJCGDODGC> HOOFPAAEDDE(GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD, Action JIMCDJPCPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3C97D10", Offset = "0x3C96F10", VA = "0x183C97D10")]
	[IteratorStateMachine(typeof(IPODFDBFIBM))]
	private static IEnumerator<GAGJCGDODGC> HOOFPAAEDDE(GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD, Action<float> JIMCDJPCPGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NLFHHDMNLNP
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MGIGBPGKEKC : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public GFIGKKNJOIH.OAGKLGIDJML queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private JAFGKPMFGDN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public MGIGBPGKEKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FD50", Offset = "0x3C9EF50", VA = "0x183C9FD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FE40", Offset = "0x3C9F040", VA = "0x183C9FE40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0C20", Offset = "0x3C9FE20", VA = "0x183CA0C20")]
	public static BLKCKFJNHGD OECAEBOLGJL(float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0CD0", Offset = "0x3C9FED0", VA = "0x183CA0CD0")]
	public static BLKCKFJNHGD OECAEBOLGJL(MonoBehaviour FEDLFPCLHMI, float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0AE0", Offset = "0x3C9FCE0", VA = "0x183CA0AE0")]
	public static BLKCKFJNHGD ELFGKMALFIB(MBBEIFLIIKN MEFIPNMPAKF, float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0BA0", Offset = "0x3C9FDA0", VA = "0x183CA0BA0")]
	[IteratorStateMachine(typeof(MGIGBPGKEKC))]
	private static IEnumerator<GAGJCGDODGC> HOOFPAAEDDE(float OPBNICHNHHF, GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD, Action<float> JIMCDJPCPGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HMOKHKBNFFB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FGEEEGIIGDC : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public GFIGKKNJOIH.OAGKLGIDJML queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public FGEEEGIIGDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AD80", Offset = "0x3C99F80", VA = "0x183C9AD80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AE20", Offset = "0x3C9A020", VA = "0x183C9AE20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3C9DCF0", Offset = "0x3C9CEF0", VA = "0x183C9DCF0")]
	[IteratorStateMachine(typeof(FGEEEGIIGDC))]
	private static IEnumerator<GAGJCGDODGC> BANCCDIEPJP(GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD, Func<bool> INONAOBJCGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3C9DD60", Offset = "0x3C9CF60", VA = "0x183C9DD60")]
	public static BLKCKFJNHGD JAEOOGAFFDA(this MonoBehaviour FEDLFPCLHMI, Func<bool> INONAOBJCGH, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD = GFIGKKNJOIH.OAGKLGIDJML.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OCLANDAIIJN
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class BNECNIJJPLC : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GFIGKKNJOIH.OAGKLGIDJML queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public BNECNIJJPLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C96220", Offset = "0x3C95420", VA = "0x183C96220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C962D0", Offset = "0x3C954D0", VA = "0x183C962D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HAHHFLFPCEJ : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GFIGKKNJOIH.OAGKLGIDJML queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private GAGJCGDODGC <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public HAHHFLFPCEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DAE0", Offset = "0x3C9CCE0", VA = "0x183C9DAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DBA0", Offset = "0x3C9CDA0", VA = "0x183C9DBA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1AB0", Offset = "0x3CA0CB0", VA = "0x183CA1AB0")]
	[IteratorStateMachine(typeof(BNECNIJJPLC))]
	private static IEnumerator<GAGJCGDODGC> LBGODPMCLEE(float IDOGEAIEEHG, GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1910", Offset = "0x3CA0B10", VA = "0x183CA1910")]
	[IteratorStateMachine(typeof(HAHHFLFPCEJ))]
	private static IEnumerator<GAGJCGDODGC> JPPFONABLKG(float IDOGEAIEEHG, GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1EA0", Offset = "0x3CA10A0", VA = "0x183CA1EA0")]
	public static IDisposable NMGKHDGNJJD(this MonoBehaviour FEDLFPCLHMI, float IDOGEAIEEHG, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1580", Offset = "0x3CA0780", VA = "0x183CA1580")]
	public static BLKCKFJNHGD BMHLLAOECIF(this MonoBehaviour FEDLFPCLHMI, float IDOGEAIEEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1D50", Offset = "0x3CA0F50", VA = "0x183CA1D50")]
	public static BLKCKFJNHGD NMGKHDGNJJD(this MonoBehaviour FEDLFPCLHMI, float IDOGEAIEEHG, GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1460", Offset = "0x3CA0660", VA = "0x183CA1460")]
	public static BLKCKFJNHGD ACBGNNGHGFB(this MonoBehaviour FEDLFPCLHMI, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3CA18F0", Offset = "0x3CA0AF0", VA = "0x183CA18F0")]
	public static BLKCKFJNHGD JKJGJPMFGHD(this MonoBehaviour FEDLFPCLHMI, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1900", Offset = "0x3CA0B00", VA = "0x183CA1900")]
	public static BLKCKFJNHGD JPCJJIHNCPH(this MonoBehaviour FEDLFPCLHMI, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3CA16C0", Offset = "0x3CA08C0", VA = "0x183CA16C0")]
	public static BLKCKFJNHGD HMONKLGMFAA(this MonoBehaviour FEDLFPCLHMI, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1990", Offset = "0x3CA0B90", VA = "0x183CA1990")]
	public static BLKCKFJNHGD KGMJGFHJONL(this MonoBehaviour FEDLFPCLHMI, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1C40", Offset = "0x3CA0E40", VA = "0x183CA1C40")]
	private static BLKCKFJNHGD MPNONDLKKGG(MonoBehaviour FEDLFPCLHMI, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3CA16D0", Offset = "0x3CA08D0", VA = "0x183CA16D0")]
	public static BLKCKFJNHGD JAJCBEAOGPK(this MonoBehaviour FEDLFPCLHMI, float GHFHLPAPCCL, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1470", Offset = "0x3CA0670", VA = "0x183CA1470")]
	public static BLKCKFJNHGD ANNHNBMGFIC(this MonoBehaviour FEDLFPCLHMI, float GHFHLPAPCCL, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3CA17E0", Offset = "0x3CA09E0", VA = "0x183CA17E0")]
	public static BLKCKFJNHGD JGMBALPAMKJ(this MonoBehaviour FEDLFPCLHMI, float GHFHLPAPCCL, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3CA1B30", Offset = "0x3CA0D30", VA = "0x183CA1B30")]
	public static BLKCKFJNHGD LCAHNKCMBDB(this MonoBehaviour FEDLFPCLHMI, float GHFHLPAPCCL, Action NENGKGJFOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3CA19A0", Offset = "0x3CA0BA0", VA = "0x183CA19A0")]
	public static BLKCKFJNHGD KKFFGOJCEBC(this MonoBehaviour FEDLFPCLHMI, float GHFHLPAPCCL, Action NENGKGJFOHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class AMIGFHELPLO : LNCEHAJGOGF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FJDCDLPBICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AMIGFHELPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public FJDCDLPBICI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BEF0", Offset = "0x3C9B0F0", VA = "0x183C9BEF0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OGGIOBCFFBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AMIGFHELPLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public OGGIOBCFFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C9BEF0", Offset = "0x3C9B0F0", VA = "0x183C9BEF0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float HBEDAPJPHMP;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3C95A40", Offset = "0x3C94C40", VA = "0x183C95A40")]
	public AMIGFHELPLO(Behaviour MEFIPNMPAKF, float HBEDAPJPHMP, [Optional] Action PAEFMDFGPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3C95970", Offset = "0x3C94B70", VA = "0x183C95970", Slot = "9")]
	protected override bool OBNMDDGOOFI(Action DMBCNIHDJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3C958A0", Offset = "0x3C94AA0", VA = "0x183C958A0", Slot = "10")]
	protected override bool CMMIGJHIDKA(Action DMBCNIHDJBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface BEDPNLGABHC
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool EGOJGLACBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPOJAENHHGJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DPCBJHCGPCF(bool FDCLCPBPPIC = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPCBJHCGPCF(Action DMBCNIHDJBD, bool FDCLCPBPPIC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class LNCEHAJGOGF : BEDPNLGABHC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class LODOLOFCPOI : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public LODOLOFCPOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F7A0", Offset = "0x3C9E9A0", VA = "0x183C9F7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F840", Offset = "0x3C9EA40", VA = "0x183C9F840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour MEFIPNMPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action PAEFMDFGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private HPCHDIGGLNN MGADEICIDCE;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool EGOJGLACBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E8210", Offset = "0x7E7410", VA = "0x1807E8210", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action HPOJAENHHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F510", Offset = "0x3C9E710", VA = "0x183C9F510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F470", Offset = "0x3C9E670", VA = "0x183C9F470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2082040", Offset = "0x2081240", VA = "0x182082040")]
	protected LNCEHAJGOGF(Behaviour MEFIPNMPAKF, [Optional] Action PAEFMDFGPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F410", Offset = "0x3C9E610", VA = "0x183C9F410", Slot = "7")]
	public bool DPCBJHCGPCF(bool FDCLCPBPPIC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F3C0", Offset = "0x3C9E5C0", VA = "0x183C9F3C0", Slot = "8")]
	public bool DPCBJHCGPCF(Action DMBCNIHDJBD, bool FDCLCPBPPIC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OBNMDDGOOFI(Action DMBCNIHDJBD);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CMMIGJHIDKA(Action DMBCNIHDJBD);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F3A0", Offset = "0x3C9E5A0", VA = "0x183C9F3A0")]
	protected void CNLCCKLEFPC(Action DMBCNIHDJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F5B0", Offset = "0x3C9E7B0", VA = "0x183C9F5B0")]
	protected MLALFLMLHEI IMGHIHHDKCN(float FMMGJBBOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F2D0", Offset = "0x3C9E4D0", VA = "0x183C9F2D0")]
	private void CDDAOGEBFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F340", Offset = "0x3C9E540", VA = "0x183C9F340")]
	[IteratorStateMachine(typeof(LODOLOFCPOI))]
	private static IEnumerator<GAGJCGDODGC> CMDNJHGGFOJ(float FMMGJBBOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F780", Offset = "0x3C9E980", VA = "0x183C9F780")]
	[CompilerGenerated]
	private void LAILNNDAGBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BDEBGCHBGEK : LNCEHAJGOGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float DGFNBPHBMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int MDDKEELNGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float JFFDICAOBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] KLPGLJJAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int KOOOJABGLBA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BOGJPMPBIMP IGLLANOIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x496670", Offset = "0x495870", VA = "0x180496670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x52F650", Offset = "0x52E850", VA = "0x18052F650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3C95E60", Offset = "0x3C95060", VA = "0x183C95E60")]
	public BDEBGCHBGEK(Behaviour MEFIPNMPAKF, float MPLCAIEMFLB, int MDDKEELNGDN, [Optional] Action PAEFMDFGPLG, float JFFDICAOBPC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40", Slot = "9")]
	protected override bool OBNMDDGOOFI(Action DMBCNIHDJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3C95C40", Offset = "0x3C94E40", VA = "0x183C95C40", Slot = "10")]
	protected override bool CMMIGJHIDKA(Action DMBCNIHDJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3C95BB0", Offset = "0x3C94DB0", VA = "0x183C95BB0")]
	private void APPAFKLKPBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class KPPBNDMPFEK : LNCEHAJGOGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float HBEDAPJPHMP;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3C95A40", Offset = "0x3C94C40", VA = "0x183C95A40")]
	public KPPBNDMPFEK(Behaviour MEFIPNMPAKF, float HBEDAPJPHMP, [Optional] Action PAEFMDFGPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40", Slot = "9")]
	protected override bool OBNMDDGOOFI(Action DMBCNIHDJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F150", Offset = "0x3C9E350", VA = "0x183C9F150", Slot = "10")]
	protected override bool CMMIGJHIDKA(Action DMBCNIHDJBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class FNJOGKFJBMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LCCKHMBNJAF : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public LCCKHMBNJAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F190", Offset = "0x3C9E390", VA = "0x183C9F190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F280", Offset = "0x3C9E480", VA = "0x183C9F280", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private BLKCKFJNHGD MFPIHBOGAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private MBBEIFLIIKN MEFIPNMPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action JIMCDJPCPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> EJKDFGICKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float HMLIBLAGDJA;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CBD0", Offset = "0x3C9BDD0", VA = "0x183C9CBD0")]
	public FNJOGKFJBMH(MBBEIFLIIKN MEFIPNMPAKF, Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CD60", Offset = "0x3C9BF60", VA = "0x183C9CD60")]
	public FNJOGKFJBMH(MBBEIFLIIKN MEFIPNMPAKF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CA80", Offset = "0x3C9BC80", VA = "0x183C9CA80")]
	public FNJOGKFJBMH(MBBEIFLIIKN MEFIPNMPAKF, float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C900", Offset = "0x3C9BB00", VA = "0x183C9C900")]
	private void OECAEBOLGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C420", Offset = "0x3C9B620", VA = "0x183C9C420")]
	private void DEOLELIEJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C6F0", Offset = "0x3C9B8F0", VA = "0x183C9C6F0")]
	private void LHEGCHIHJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C300", Offset = "0x3C9B500", VA = "0x183C9C300")]
	private void AALANKBLNCN(string IKNIEMKPGCP, Action CDHENHFDPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C8A0", Offset = "0x3C9BAA0", VA = "0x183C9C8A0")]
	[IteratorStateMachine(typeof(LCCKHMBNJAF))]
	private IEnumerator<GAGJCGDODGC> NCFNOMGMIOD(Action CDHENHFDPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C5A0", Offset = "0x3C9B7A0", VA = "0x183C9C5A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C670", Offset = "0x3C9B870", VA = "0x183C9C670")]
	[CompilerGenerated]
	private void KGBOENGEGKN(string HHEDDBLEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C5F0", Offset = "0x3C9B7F0", VA = "0x183C9C5F0")]
	[CompilerGenerated]
	private void EFENGMNEAKO(string HHEDDBLEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C820", Offset = "0x3C9BA20", VA = "0x183C9C820")]
	[CompilerGenerated]
	private void MEBNILGPKGG(string HHEDDBLEJEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GEBLOPCFONC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FEHFGOKFPLC : IEnumerator<GAGJCGDODGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private GAGJCGDODGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private GAGJCGDODGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
		[DebuggerHidden]
		public FEHFGOKFPLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A9A0", Offset = "0x3C99BA0", VA = "0x183C9A9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AA90", Offset = "0x3C99C90", VA = "0x183C9AA90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BLKCKFJNHGD MFPIHBOGAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour FEDLFPCLHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action JIMCDJPCPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> EJKDFGICKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float HMLIBLAGDJA;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D950", Offset = "0x3C9CB50", VA = "0x183C9D950")]
	public GEBLOPCFONC(MonoBehaviour FEDLFPCLHMI, Action JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D670", Offset = "0x3C9C870", VA = "0x183C9D670")]
	public GEBLOPCFONC(MonoBehaviour FEDLFPCLHMI, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D800", Offset = "0x3C9CA00", VA = "0x183C9D800")]
	public GEBLOPCFONC(MonoBehaviour FEDLFPCLHMI, float OPBNICHNHHF, Action<float> JIMCDJPCPGB, GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D4F0", Offset = "0x3C9C6F0", VA = "0x183C9D4F0")]
	private void OECAEBOLGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D010", Offset = "0x3C9C210", VA = "0x183C9D010")]
	private void DEOLELIEJLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D2E0", Offset = "0x3C9C4E0", VA = "0x183C9D2E0")]
	private void LHEGCHIHJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3C9CEF0", Offset = "0x3C9C0F0", VA = "0x183C9CEF0")]
	private void AALANKBLNCN(string IKNIEMKPGCP, Action CDHENHFDPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D490", Offset = "0x3C9C690", VA = "0x183C9D490")]
	[IteratorStateMachine(typeof(FEHFGOKFPLC))]
	private IEnumerator<GAGJCGDODGC> NCFNOMGMIOD(Action CDHENHFDPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D190", Offset = "0x3C9C390", VA = "0x183C9D190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D260", Offset = "0x3C9C460", VA = "0x183C9D260")]
	[CompilerGenerated]
	private void KGBOENGEGKN(string HHEDDBLEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D1E0", Offset = "0x3C9C3E0", VA = "0x183C9D1E0")]
	[CompilerGenerated]
	private void EFENGMNEAKO(string HHEDDBLEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3C9D410", Offset = "0x3C9C610", VA = "0x183C9D410")]
	[CompilerGenerated]
	private void MEBNILGPKGG(string HHEDDBLEJEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PPOGPLDCMOC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int FGBDOBMIKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MAABPINLMBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly MAABPINLMBD MICLENIJPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action BAFFMEOCKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool ONLFFCIEFKJ;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
	public MAABPINLMBD(Action BAFFMEOCKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9F890", Offset = "0x3C9EA90", VA = "0x183C9F890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HPIOAAJNMJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T NAHOADDLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable BDHFLDNBKEO(Action<T> FCOCMAGKPOE);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable BDHFLDNBKEO(UnityEngine.Object MEFIPNMPAKF, Action<T> FCOCMAGKPOE);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KMILBMIEECA<T> : global::HPIOAAJNMJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T NAHOADDLJAD
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
public class ELAOHEIGEMM<T> : global::KMILBMIEECA<T>, global::HPIOAAJNMJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PLABJCOIIMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::ELAOHEIGEMM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::IJPAEFGICEK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public PLABJCOIIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x20C97C0", Offset = "0x20C89C0", VA = "0x1820C97C0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject INLOAKBGBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::IJPAEFGICEK<UnityEngine.Object, Action<T>>> MOJKBPIHALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T FBMIKJAGIHN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object PBOIAAODGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x20C1350", Offset = "0x20C0550", VA = "0x1820C1350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T NAHOADDLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC890", Offset = "0x5CBA90", VA = "0x1805CC890", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x20C1080", Offset = "0x20C0280", VA = "0x1820C1080", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x20C0FE0", Offset = "0x20C01E0", VA = "0x1820C0FE0")]
	private static bool FCFJLGJJAEJ(T CIJGEHFBDAJ, T BECJLMJILAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x20C15F0", Offset = "0x20C07F0", VA = "0x1820C15F0")]
	public ELAOHEIGEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x20C1560", Offset = "0x20C0760", VA = "0x1820C1560")]
	public ELAOHEIGEMM(T HOJINKKKPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x20C0FC0", Offset = "0x20C01C0", VA = "0x1820C0FC0")]
	public void EGDBGCGOFII(T CJDOMIBLFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x20C08F0", Offset = "0x20BFAF0", VA = "0x1820C08F0", Slot = "7")]
	public IDisposable BDHFLDNBKEO(Action<T> FCOCMAGKPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x20C07B0", Offset = "0x20BF9B0", VA = "0x1820C07B0", Slot = "8")]
	public IDisposable BDHFLDNBKEO(UnityEngine.Object MEFIPNMPAKF, Action<T> FCOCMAGKPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x20C0C80", Offset = "0x20BFE80", VA = "0x1820C0C80")]
	private void EGCBOICOCBF()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<CDFDGMPDAEL, Scheduler>, CDFDGMPDAEL
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class FHEJBBDDFCI : PPOGPLDCMOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public EMCLFGGAMJO OEFDBJJLHMF;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int FGBDOBMIKJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x46FE50", Offset = "0x46F050", VA = "0x18046FE50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x46FE60", Offset = "0x46F060", VA = "0x18046FE60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3C9B0F0", Offset = "0x3C9A2F0", VA = "0x183C9B0F0")]
			public static GAGJCGDODGC MLLCJFPLJNP(IEnumerator<GAGJCGDODGC> EMOEBNMDKJF, EJBPHIGPHFN BAEPNLBPEOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3C9B020", Offset = "0x3C9A220", VA = "0x183C9B020")]
			public GAGJCGDODGC MLLCJFPLJNP(EJBPHIGPHFN[] IMHCPIIKFGH, IEnumerator<GAGJCGDODGC>[] OCOGPADMILO, GAGJCGDODGC[] OMPHIIHJGJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3C9AF30", Offset = "0x3C9A130", VA = "0x183C9AF30")]
			public void BDHHAMMLNOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3C9AF60", Offset = "0x3C9A160", VA = "0x183C9AF60")]
			public void JKMMDNDLCIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3C9AE70", Offset = "0x3C9A070", VA = "0x183C9AE70")]
			public void ADEMCEACKAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3C9AF30", Offset = "0x3C9A130", VA = "0x183C9AF30")]
			public void LHNIFMAJKFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public FHEJBBDDFCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class EMCLFGGAMJO
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct DPDLHEEBHJO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public FHEJBBDDFCI KIJKOFDGEIJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public MBBEIFLIIKN NMCFAMJJEFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public EJBPHIGPHFN KAOMNEPPLOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<GAGJCGDODGC> JNMPGKAFHBE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public GAGJCGDODGC KIMOGMEAHDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public ONIIJMBHEMB KOHMKKNMKHK;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct HFCPIIIOIAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public GFIGKKNJOIH.OAGKLGIDJML HDIACJIFCLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<DPDLHEEBHJO> MNKFKDLJOPA;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class KBKIMBNIGEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public EMCLFGGAMJO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public MBBEIFLIIKN context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public FHEJBBDDFCI routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public ONIIJMBHEMB coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public EJBPHIGPHFN promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public GAGJCGDODGC currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<GAGJCGDODGC> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
				public KBKIMBNIGEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x3C9E300", Offset = "0x3C9D500", VA = "0x183C9E300")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class DLFGDJJKHKI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public FHEJBBDDFCI schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public EMCLFGGAMJO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
				public DLFGDJJKHKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x3C978C0", Offset = "0x3C96AC0", VA = "0x183C978C0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class BINELDNFPHA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public FHEJBBDDFCI schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public EMCLFGGAMJO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
				public BINELDNFPHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x3C96040", Offset = "0x3C95240", VA = "0x183C96040")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class NCNKDKOIAOP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public FHEJBBDDFCI schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public EMCLFGGAMJO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
				public NCNKDKOIAOP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x3CA0150", Offset = "0x3C9F350", VA = "0x183CA0150")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] IHNJDNNCNPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<ONIIJMBHEMB> LMAELMMAHEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> NFCGFEIOBLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> LEIKDNMAKOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> PFCNCHGOLEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> MANPOFIAEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> HHMKBHCJICA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> NCDMOACMNCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private FHEJBBDDFCI[] HEHAAIBEFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private EJBPHIGPHFN[] IMHCPIIKFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private MBBEIFLIIKN[] NMINMCFKMNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<GAGJCGDODGC>[] HJGDEDJBEBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private GAGJCGDODGC[] BGFFNBFBFNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int GMIDKMLOGCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int KLLMEICHFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int PPGCFALKDHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float LKJCJDEJDPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private EDOGHJCOBJB DADIPLIJHNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle OMEPLDLHOAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<FHEJBBDDFCI> ECLJNEFPOCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool GFLBBFJELJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> BHAKEDPJOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> NGLJHBHMPKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool JNELKFBKDPB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public HFCPIIIOIAK[] JCEFOEFFPLI
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x684A10", Offset = "0x683C10", VA = "0x180684A10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int PBCDCOGEFGC
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x8635F0", Offset = "0x8627F0", VA = "0x1808635F0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3C98D30", Offset = "0x3C97F30", VA = "0x183C98D30")]
			private static int CNADBDOHBJO(GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3C9A4D0", Offset = "0x3C996D0", VA = "0x183C9A4D0")]
			public EMCLFGGAMJO(GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3C99DE0", Offset = "0x3C98FE0", VA = "0x183C99DE0")]
			private void MKFGKDPMAHO(ref int FDMMIGBDBEH, int DHJJANOMBAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3C99B80", Offset = "0x3C98D80", VA = "0x183C99B80")]
			public void JHIFPFGLBLO(MBBEIFLIIKN MEFIPNMPAKF, GAGJCGDODGC PCHDJJPHFGK, IEnumerator<GAGJCGDODGC> EMOEBNMDKJF, EJBPHIGPHFN BAEPNLBPEOA, [Optional] FHEJBBDDFCI POOPKOALGCJ, ONIIJMBHEMB BMEJCEIAAAC = ONIIJMBHEMB.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3C98B40", Offset = "0x3C97D40", VA = "0x183C98B40")]
			public void ANIANBDECJD(IEnumerable<DPDLHEEBHJO> IFGMKNBDGGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3C9A0A0", Offset = "0x3C992A0", VA = "0x183C9A0A0")]
			private DPDLHEEBHJO OOLJAACKAJJ(int MFGGGJNEONK)
			{
				return default(DPDLHEEBHJO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3C98810", Offset = "0x3C97A10", VA = "0x183C98810")]
			private void AGHEINBGGDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1A49C50", Offset = "0x1A48E50", VA = "0x181A49C50")]
			private static void NNLHAMCOAKH<T>(int MFGGGJNEONK, T[] LKMHDBICJAF, int AEFLDANFMFH, [Optional] T BBLOMMNBLBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1A49C30", Offset = "0x1A48E30", VA = "0x181A49C30")]
			private static void NNLHAMCOAKH<T>(int MFGGGJNEONK, NativeArray<T> LKMHDBICJAF, int AEFLDANFMFH, [Optional] T BBLOMMNBLBK) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3C992B0", Offset = "0x3C984B0", VA = "0x183C992B0")]
			private void FADAMEIAKEK(IEnumerable<DPDLHEEBHJO> IFGMKNBDGGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3C99550", Offset = "0x3C98750", VA = "0x183C99550")]
			private void GAFJBMKEPAD(DPDLHEEBHJO CAOGPIFCGMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3C99610", Offset = "0x3C98810", VA = "0x183C99610")]
			private GPJHCCKHPHE GBJGGKLKLCF(int OIMANPNOCMD)
			{
				return default(GPJHCCKHPHE);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3C99990", Offset = "0x3C98B90", VA = "0x183C99990")]
			public void HOPDOPGDPAJ(float LPBHNPNCPAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3C99D60", Offset = "0x3C98F60", VA = "0x183C99D60")]
			private void MFCCKLJFAKO(Action CIJGEHFBDAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3C9A020", Offset = "0x3C99220", VA = "0x183C9A020")]
			private void NAMDBKNDDMH(Action CIJGEHFBDAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x3C98D60", Offset = "0x3C97F60", VA = "0x183C98D60")]
			public void COPNIBPBLAL(float LPBHNPNCPAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x3C998B0", Offset = "0x3C98AB0", VA = "0x183C998B0")]
			public void HJKEOFHMIOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3C99CB0", Offset = "0x3C98EB0", VA = "0x183C99CB0")]
			public void LHNIFMAJKFN(FHEJBBDDFCI EEPPCGKDCEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3C99200", Offset = "0x3C98400", VA = "0x183C99200")]
			public void DLCOCNLGEHD(FHEJBBDDFCI EEPPCGKDCEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3C99F70", Offset = "0x3C99170", VA = "0x183C99F70")]
			public void MNLBLKGKKPG(FHEJBBDDFCI EEPPCGKDCEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct EDOGHJCOBJB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float BJENCICAOFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int MEOOAEFIKJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> EMNBJIIMFAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> JGJBJOBLBML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> NEPIODBONDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<ONIIJMBHEMB> KLLNKDHGJDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> AKJHPNKCJEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> MANPOFIAEIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> LEIKDNMAKOD;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3C981F0", Offset = "0x3C973F0", VA = "0x183C981F0")]
			public static EDOGHJCOBJB BNELFEDOIHI(int FBKNNJICFCJ, float LPBHNPNCPAB, NativeArray<ONIIJMBHEMB> CGAFJICFAKG, NativeArray<float> DDCAFHIFIJN, NativeArray<int> FPPGCNIADAH, NativeArray<int> FEFIBKBEOFP, NativeArray<int> FCCPDLDFPBI, NativeArray<int> JGJBJOBLBML, NativeArray<int> NEPIODBONDB)
			{
				return default(EDOGHJCOBJB);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3C98300", Offset = "0x3C97500", VA = "0x183C98300", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3C982C0", Offset = "0x3C974C0", VA = "0x183C982C0")]
			private bool CLEPPBCGCEM(int GOIONDNCAOG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3C983E0", Offset = "0x3C975E0", VA = "0x183C983E0")]
			private void GBIKLJEGKOE(NativeArray<int> DLCCEMLPNAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3C98640", Offset = "0x3C97840", VA = "0x183C98640")]
			private int MCLHLALECHD(int ABNLNONAEFP, int BPACGKFHEHE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3C986B0", Offset = "0x3C978B0", VA = "0x183C986B0")]
			private void NDJAHELNCCC(NativeArray<int> DLCCEMLPNAF, int OIOLBNMLACC, int PCMDBNECPDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3C98410", Offset = "0x3C97610", VA = "0x183C98410")]
			private void ICEGBCKINDO(NativeArray<int> DLCCEMLPNAF, int NKMPLBEAMBC, int KHAIMOMNEBK, int BFLBBKAMJNB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class KINBMDNMJJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly EJBPHIGPHFN BAEPNLBPEOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour MEFIPNMPAKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool HBGPFJCEKGM;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<GAGJCGDODGC> JNMPGKAFHBE
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x46F440", Offset = "0x46E640", VA = "0x18046F440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public GAGJCGDODGC KIMOGMEAHDH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x46F450", Offset = "0x46E650", VA = "0x18046F450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool ACBPCGAGOEK
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x3C9EB80", Offset = "0x3C9DD80", VA = "0x183C9EB80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool LDBKAGIDLNL
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x63E010", Offset = "0x63D210", VA = "0x18063E010")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1DACC10", Offset = "0x1DABE10", VA = "0x181DACC10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string KMBGCHDFCPL
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x46FF90", Offset = "0x46F190", VA = "0x18046FF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x46FFA0", Offset = "0x46F1A0", VA = "0x18046FFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float CLPEEGNNHAA
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xE631E0", Offset = "0xE623E0", VA = "0x180E631E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xE62DC0", Offset = "0xE61FC0", VA = "0x180E62DC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3C9EFD0", Offset = "0x3C9E1D0", VA = "0x183C9EFD0")]
			public KINBMDNMJJI(IEnumerator<GAGJCGDODGC> EMOEBNMDKJF, Behaviour MEFIPNMPAKF, EJBPHIGPHFN BAEPNLBPEOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3C9ECA0", Offset = "0x3C9DEA0", VA = "0x183C9ECA0")]
			public GAGJCGDODGC MLLCJFPLJNP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3C9EEB0", Offset = "0x3C9E0B0", VA = "0x183C9EEB0")]
			public bool ODBGCNGLACM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3C9EC10", Offset = "0x3C9DE10", VA = "0x183C9EC10")]
			public void LHNIFMAJKFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3C9EF40", Offset = "0x3C9E140", VA = "0x183C9EF40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x142E2A0", Offset = "0x142D4A0", VA = "0x18142E2A0")]
			[CompilerGenerated]
			private void GINCBHPEJCJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class EJBPHIGPHFN : NGJKMMDMKID, BLKCKFJNHGD, HPCHDIGGLNN, MLALFLMLHEI, IEnumerator, GAGJCGDODGC, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private GFIGKKNJOIH.OAGKLGIDJML BEMEIMIKJDI;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private GFIGKKNJOIH.OAGKLGIDJML NGOJNJLCFDK
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x493290", Offset = "0x492490", VA = "0x180493290", Slot = "23")]
				get
				{
					return default(GFIGKKNJOIH.OAGKLGIDJML);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public GFIGKKNJOIH.OAGKLGIDJML OEFDBJJLHMF
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x493290", Offset = "0x492490", VA = "0x180493290")]
				get
				{
					return default(GFIGKKNJOIH.OAGKLGIDJML);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5F0EE0", Offset = "0x5F00E0", VA = "0x1805F0EE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float NEABLDNDPFJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xBE7610", Offset = "0xBE6810", VA = "0x180BE7610", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3C98790", Offset = "0x3C97990", VA = "0x183C98790", Slot = "24")]
			private bool PBIOCDMPPEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3C98780", Offset = "0x3C97980", VA = "0x183C98780", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3C987B0", Offset = "0x3C979B0", VA = "0x183C987B0")]
			public EJBPHIGPHFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum GPJHCCKHPHE : byte
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
		private sealed class PPAECICDEMD : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum GIHBIBOPFDG
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct MNDPGNOKLEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public GFIGKKNJOIH.OAGKLGIDJML HDIACJIFCLB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public GIHBIBOPFDG IINBBBOLKJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<KINBMDNMJJI> HCKGAELJCJM;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly GIHBIBOPFDG[] EMFCOMDMEDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly GFIGKKNJOIH.OAGKLGIDJML CPKFODFNMCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool OEMJANOCJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly KINBMDNMJJI[] AFGGKOCDFMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<KINBMDNMJJI> PCNMOHDONBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> ONENOLPOLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<KINBMDNMJJI> JOFICHCKBOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> IJGEEKDOMNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool JNELKFBKDPB;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public MNDPGNOKLEH[,] GBAAEBAHIHB
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x482470", Offset = "0x481670", VA = "0x180482470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int PBCDCOGEFGC
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x3CA4220", Offset = "0x3CA3420", VA = "0x183CA4220")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3CA5190", Offset = "0x3CA4390", VA = "0x183CA5190")]
			public PPAECICDEMD(GFIGKKNJOIH.OAGKLGIDJML JHCFIOBHJPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3CA46B0", Offset = "0x3CA38B0", VA = "0x183CA46B0")]
			public void GEEGLNBLMIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x3CA46C0", Offset = "0x3CA38C0", VA = "0x183CA46C0")]
			public void HDCGJJMHCIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3CA4950", Offset = "0x3CA3B50", VA = "0x183CA4950")]
			private void LCMOCPHACPJ(IReadOnlyList<KINBMDNMJJI> MKEGHJCHPGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3CA3D40", Offset = "0x3CA2F40", VA = "0x183CA3D40")]
			public void AFCGCHJMMAP(KINBMDNMJJI EMOEBNMDKJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3CA46D0", Offset = "0x3CA38D0", VA = "0x183CA46D0")]
			public void KJDBAPKPLFM(IList<KINBMDNMJJI> OCOGPADMILO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3CA4A70", Offset = "0x3CA3C70", VA = "0x183CA4A70")]
			public void LPAEEEFLACH(IList<KINBMDNMJJI> OCOGPADMILO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3CA3FC0", Offset = "0x3CA31C0", VA = "0x183CA3FC0")]
			private void BHCOPJJAION(KINBMDNMJJI EMOEBNMDKJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3CA40B0", Offset = "0x3CA32B0", VA = "0x183CA40B0")]
			private void CIHLKMFPHHL(IList<KINBMDNMJJI> OCOGPADMILO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3CA3E40", Offset = "0x3CA3040", VA = "0x183CA3E40")]
			private GPJHCCKHPHE ANLOFGKHDJE(KINBMDNMJJI EMOEBNMDKJF)
			{
				return default(GPJHCCKHPHE);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3CA5010", Offset = "0x3CA4210", VA = "0x183CA5010")]
			public void PLPDAPDFNAC(float LPBHNPNCPAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x3CA4CF0", Offset = "0x3CA3EF0", VA = "0x183CA4CF0")]
			public void MKJLDBONJDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3CA44D0", Offset = "0x3CA36D0", VA = "0x183CA44D0")]
			private void GBLKLOLDOGO(List<KINBMDNMJJI> OCOGPADMILO, Stack<int> EEPLBMMICCH, bool AADADFFFBGK, float EMGAEJPOAHH = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3CA4390", Offset = "0x3CA3590", VA = "0x183CA4390", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3CA4EF0", Offset = "0x3CA40F0", VA = "0x183CA4EF0")]
			private void NKGKDIONKPK(List<KINBMDNMJJI> OCOGPADMILO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum ONIIJMBHEMB : byte
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
		private sealed class BGIMBIHAKCG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6000D0", Offset = "0x5FF2D0", VA = "0x1806000D0")]
			[DebuggerHidden]
			public BGIMBIHAKCG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3C95F70", Offset = "0x3C95170", VA = "0x183C95F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3C95FF0", Offset = "0x3C951F0", VA = "0x183C95FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const ONIIJMBHEMB NKHLGBCHJHE = ONIIJMBHEMB.Cancelled | ONIIJMBHEMB.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly GFIGKKNJOIH.OAGKLGIDJML[] CPAJFJDFANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private PPAECICDEMD[] GGJNEMKPKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private EMCLFGGAMJO[] NIDBPDHBCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine OJCPLCBPKPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame KJGOHMLIDMD;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public GFIGKKNJOIH.OAGKLGIDJML JMBDEMEBKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4F30A0", Offset = "0x4F22A0", VA = "0x1804F30A0")]
			[CompilerGenerated]
			get
			{
				return default(GFIGKKNJOIH.OAGKLGIDJML);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x549060", Offset = "0x548260", VA = "0x180549060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GBMMBPDKDLC
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x63DD10", Offset = "0x63CF10", VA = "0x18063DD10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x1A0B030", Offset = "0x1A0A230", VA = "0x181A0B030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int PBCDCOGEFGC
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3CA6EC0", Offset = "0x3CA60C0", VA = "0x183CA6EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5B90", Offset = "0x3CA4D90", VA = "0x183CA5B90")]
		public static BLKCKFJNHGD GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5570", Offset = "0x3CA4770", VA = "0x183CA5570", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5E80", Offset = "0x3CA5080", VA = "0x183CA5E80", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5A20", Offset = "0x3CA4C20", VA = "0x183CA5A20")]
		private PPAECICDEMD EIOGMMKLNGJ(GFIGKKNJOIH.OAGKLGIDJML FPLGNMDKNAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x27C9FA0", Offset = "0x27C91A0", VA = "0x1827C9FA0")]
		private EMCLFGGAMJO CCNOIIEEDNH(GFIGKKNJOIH.OAGKLGIDJML FPLGNMDKNAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6310", Offset = "0x3CA5510", VA = "0x183CA6310")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CA62E0", Offset = "0x3CA54E0", VA = "0x183CA62E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6CB0", Offset = "0x3CA5EB0", VA = "0x183CA6CB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3CA59B0", Offset = "0x3CA4BB0", VA = "0x183CA59B0")]
		private void CCGBALHGOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5E00", Offset = "0x3CA5000", VA = "0x183CA5E00")]
		private void LJBDLDAIADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5B80", Offset = "0x3CA4D80", VA = "0x183CA5B80")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5E10", Offset = "0x3CA5010", VA = "0x183CA5E10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5DF0", Offset = "0x3CA4FF0", VA = "0x183CA5DF0")]
		private void JAEMBEPHGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5E20", Offset = "0x3CA5020", VA = "0x183CA5E20")]
		[IteratorStateMachine(typeof(BGIMBIHAKCG))]
		private IEnumerator MHECOJECLJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3CA67D0", Offset = "0x3CA59D0", VA = "0x183CA67D0", Slot = "7")]
		public BLKCKFJNHGD Run(IEnumerator<GAGJCGDODGC> LCDHEMAOHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3CA64B0", Offset = "0x3CA56B0", VA = "0x183CA64B0", Slot = "8")]
		public BLKCKFJNHGD Run(Behaviour MEFIPNMPAKF, IEnumerator<GAGJCGDODGC> LCDHEMAOHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6380", Offset = "0x3CA5580", VA = "0x183CA6380", Slot = "9")]
		public BLKCKFJNHGD RunJobbed(MBBEIFLIIKN MEFIPNMPAKF, IEnumerator<GAGJCGDODGC> LCDHEMAOHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3CA59C0", Offset = "0x3CA4BC0", VA = "0x183CA59C0", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA67E0", Offset = "0x3CA59E0", VA = "0x183CA67E0")]
		public void UpdateQueue(GFIGKKNJOIH.OAGKLGIDJML LKKMNIJNJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5C30", Offset = "0x3CA4E30", VA = "0x183CA5C30")]
		private void IFMMHHKANEE(PPAECICDEMD OCIEDFDLDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5A60", Offset = "0x3CA4C60", VA = "0x183CA5A60")]
		private void FOIPGBPPJLP(EMCLFGGAMJO OCIEDFDLDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6E60", Offset = "0x3CA6060", VA = "0x183CA6E60")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class KIAHADAJKJI
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3C9EAF0", Offset = "0x3C9DCF0", VA = "0x183C9EAF0")]
	[IIPIHIPANPJ]
	private static void GKJAAEEMOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class AHIMNPDPDID : BOGJPMPBIMP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float JPBHHHMNFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C95840", Offset = "0x3C94A40", VA = "0x183C95840", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float KADMIMMNGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C95880", Offset = "0x3C94A80", VA = "0x183C95880", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float DOONOIODDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C95870", Offset = "0x3C94A70", VA = "0x183C95870", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MBHEHAKOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C95890", Offset = "0x3C94A90", VA = "0x183C95890", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double BEGKFIINKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C95850", Offset = "0x3C94A50", VA = "0x183C95850", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	public AHIMNPDPDID()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PCNMAEEHMFA
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] JCMJECHILOC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int BNIACGCEGJA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int BOLEHDFPPKM;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger IJJDCIAOLCD;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	public PCNMAEEHMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2F60", Offset = "0x3CA2160", VA = "0x183CA2F60")]
	private static string MFCANKEIEIP(byte[] BECJLMJILAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3CA3060", Offset = "0x3CA2260", VA = "0x183CA3060")]
	public static string MMKAAAJKMHB(byte[] MNCFCOKJIPF, bool EGIHCEJJLCP)
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
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
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

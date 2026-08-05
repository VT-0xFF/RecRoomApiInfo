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
		private delegate List<PlayerLoopSystem> DOLGIMNEKLG(List<PlayerLoopSystem> LOKHBELLAEC, int MOCCBGOHDDH);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct DGMAOCPAKFM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct HEFAKPAAEEL
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static NNEOKDILPJM HDMPJIIPOAC;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x46BEA10", Offset = "0x46BD810", VA = "0x1846BEA10")]
				public static PlayerLoopSystem FFDGNMJJIKA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct DICLAFEABNM
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static NNEOKDILPJM FOCKDDEGANE;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x46BCA10", Offset = "0x46BB810", VA = "0x1846BCA10")]
				public static PlayerLoopSystem FFDGNMJJIKA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct GGAFGNKKABM
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static NNEOKDILPJM FFIGHFFBJBI;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x46BE160", Offset = "0x46BCF60", VA = "0x1846BE160")]
				public static PlayerLoopSystem FFDGNMJJIKA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct CMJELMCKGLM
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static NNEOKDILPJM KJACNKNHIGK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x46BA120", Offset = "0x46B8F20", VA = "0x1846BA120")]
				public static PlayerLoopSystem FFDGNMJJIKA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct IOGOKHMHNMF
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class DBGEJNAIHLK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public BDKCIGLFAEK.KAPODKAILKD key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
					public DBGEJNAIHLK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x46BBC60", Offset = "0x46BAA60", VA = "0x1846BBC60")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable OLGHCHBEENK;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x46BF9E0", Offset = "0x46BE7E0", VA = "0x1846BF9E0")]
				public static PlayerLoopSystem CGINBDNNNJK(BDKCIGLFAEK.KAPODKAILKD LHOJNLGGKDH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct BBAAHHLNPLD
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class CLIIIEPMNLM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public BDKCIGLFAEK.KAPODKAILKD key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
					public CLIIIEPMNLM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x46BA060", Offset = "0x46B8E60", VA = "0x1846BA060")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x46B9390", Offset = "0x46B8190", VA = "0x1846B9390")]
				public static PlayerLoopSystem CGINBDNNNJK(BDKCIGLFAEK.KAPODKAILKD LHOJNLGGKDH)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LKEICECEEHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public LKEICECEEHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x46C1970", Offset = "0x46C0770", VA = "0x1846C1970")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool MNFJAAINEGF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NKKDAKIJDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x46BB570", Offset = "0x46BA370", VA = "0x1846BB570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x46BB5B0", Offset = "0x46BA3B0", VA = "0x1846BB5B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46BA2F0", Offset = "0x46B90F0", VA = "0x1846BA2F0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46BBA90", Offset = "0x46BA890", VA = "0x1846BBA90")]
		private static void OHHFKDJPFLL(BDKCIGLFAEK.KAPODKAILKD LHOJNLGGKDH, ref PlayerLoopSystem JAHJJKDLDPP, Type PHJHOIMCCKP, Type EMHJMCPALCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x46BB5F0", Offset = "0x46BA3F0", VA = "0x1846BB5F0")]
		private static void LIFHKGPLIHD(ref PlayerLoopSystem JAHJJKDLDPP, Type PHJHOIMCCKP, Type EMHJMCPALCD, DOLGIMNEKLG CBJOFBJIMON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46BB970", Offset = "0x46BA770", VA = "0x1846BB970")]
		private static void MFKJIAFLOPO(ref PlayerLoopSystem JAHJJKDLDPP, Type PHJHOIMCCKP, Type EMHJMCPALCD, PlayerLoopSystem? DOJPMLLFLBL, PlayerLoopSystem? HBHBNDKBHNK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BDKCIGLFAEK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KAPODKAILKD
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
	public class EOKDAGNJBGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KAPODKAILKD EONDMNAFOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly EAHFKNPCBNC HIOPMGFEMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long IKLNEBEKHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long FEFFOMJNCFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long LMHILGKLKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int ACBPJLEJHEM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46BDB10", Offset = "0x46BC910", VA = "0x1846BDB10")]
		public EOKDAGNJBGA(KAPODKAILKD CEMLKFMLILC, int BHBDDGHDJHH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x46BDA80", Offset = "0x46BC880", VA = "0x1846BDA80")]
		public void GEJCIPMHEHH(int PBJKLJJMBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46BDAA0", Offset = "0x46BC8A0", VA = "0x1846BDAA0")]
		public void HLALPNNLHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46BDA20", Offset = "0x46BC820", VA = "0x1846BDA20")]
		public void GCBIBMAJKKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46BD7B0", Offset = "0x46BC5B0", VA = "0x1846BD7B0")]
		public void AICOMLAGPND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46BD980", Offset = "0x46BC780", VA = "0x1846BD980")]
		public double BMGOFGFELBI(int CGFKMBFABGJ)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int GEGJABFAGBK = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static KAPODKAILKD[] ACCJKAPEDAA;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static EOKDAGNJBGA[] NKIAIGOJFOC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46B9540", Offset = "0x46B8340", VA = "0x1846B9540")]
	public static EOKDAGNJBGA EIOMIOPNNEA(KAPODKAILKD LHOJNLGGKDH, int BHBDDGHDJHH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46B94B0", Offset = "0x46B82B0", VA = "0x1846B94B0")]
	public static EOKDAGNJBGA AGDDKBEEKPI(KAPODKAILKD LHOJNLGGKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46B96F0", Offset = "0x46B84F0", VA = "0x1846B96F0")]
	public static void GGBJDFJKDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EAHFKNPCBNC : NPEGLDEBNBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int NFGMPPNOKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> DMOLNADMACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double HBLINDDGOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double GAJLIJGLIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double FOMEMJDFJFL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GPDBGLPGAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46BCDE0", Offset = "0x46BBBE0", VA = "0x1846BCDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double NFBFGPPLBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x46BCE20", Offset = "0x46BBC20", VA = "0x1846BCE20", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FGOIKMEMMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE1B610", Offset = "0xE1A410", VA = "0x180E1B610", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double IMEDALOGBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x313BAD0", Offset = "0x313A8D0", VA = "0x18313BAD0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46BCE80", Offset = "0x46BBC80", VA = "0x1846BCE80")]
	public EAHFKNPCBNC(int IHNNIFAMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46BCC70", Offset = "0x46BBA70", VA = "0x1846BCC70", Slot = "4")]
	public void AODGECJMENA(double DPFKJHANDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46BCD70", Offset = "0x46BBB70", VA = "0x1846BCD70", Slot = "5")]
	public void CPCMAPIDJKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PHCGAGENONN : NPEGLDEBNBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long JPKOENICFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double AKMAAOBAONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double BPEMGAJGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double BDFNAHDHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double LEHNLLOACJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double HBLINDDGOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double GAJLIJGLIBP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long CPEMKADKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double FGOIKMEMMJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x358F880", Offset = "0x358E680", VA = "0x18358F880", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double IMEDALOGBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x967AC0", Offset = "0x9668C0", VA = "0x180967AC0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double CKNEKENPGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x313BAD0", Offset = "0x313A8D0", VA = "0x18313BAD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double NNKAPCCLKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x313BAC0", Offset = "0x313A8C0", VA = "0x18313BAC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double NFBFGPPLBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3451C90", Offset = "0x3450A90", VA = "0x183451C90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46C6A00", Offset = "0x46C5800", VA = "0x1846C6A00", Slot = "4")]
	public void AODGECJMENA(double DPFKJHANDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46C6B20", Offset = "0x46C5920", VA = "0x1846C6B20", Slot = "5")]
	public void CPCMAPIDJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x46C6B60", Offset = "0x46C5960", VA = "0x1846C6B60")]
	public PHCGAGENONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NPEGLDEBNBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double NFBFGPPLBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double FGOIKMEMMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double IMEDALOGBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AODGECJMENA(double DPFKJHANDFP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPCMAPIDJKD();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LMFHHNCCGDE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface BANEOGFFAID
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool GJAHCMIIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IANFCFBCFJO();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LKLAHJCEPCL();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class DNJKNJKHLNB<TPromise, TMainThreadPromise> : BANEOGFFAID where TPromise : EDDKJIPNMLB where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise CMNFLMCAEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise NJKMBEOHAMC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise BPLIDDLLGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1D8A180", Offset = "0x1D88F80", VA = "0x181D8A180")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GJAHCMIIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1D8A0D0", Offset = "0x1D88ED0", VA = "0x181D8A0D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A1E0", Offset = "0x1D88FE0", VA = "0x181D8A1E0")]
		protected DNJKNJKHLNB(TPromise CMNFLMCAEND, TMainThreadPromise BMENAGFCOLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A120", Offset = "0x1D88F20", VA = "0x181D8A120", Slot = "5")]
		public void IANFCFBCFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A150", Offset = "0x1D88F50", VA = "0x181D8A150", Slot = "6")]
		public void LKLAHJCEPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void PHBHFEACJDJ(TPromise CMNFLMCAEND);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void BLKKFDDMHMK();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class FHLBLHHCGOO<T> : DNJKNJKHLNB<global::BKHPMHDEEIP<T>, global::PJPEGAEJAFJ<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A500", Offset = "0x1D89300", VA = "0x181D8A500")]
		public FHLBLHHCGOO(global::BKHPMHDEEIP<T> CMNFLMCAEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A300", Offset = "0x1D89100", VA = "0x181D8A300", Slot = "7")]
		protected override void PHBHFEACJDJ(global::BKHPMHDEEIP<T> CMNFLMCAEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A240", Offset = "0x1D89040", VA = "0x181D8A240", Slot = "8")]
		protected override void BLKKFDDMHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A2D0", Offset = "0x1D890D0", VA = "0x181D8A2D0")]
		[CompilerGenerated]
		private void GILDMFFFHAL(T CFLKPKIKHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A2A0", Offset = "0x1D890A0", VA = "0x181D8A2A0")]
		[CompilerGenerated]
		private void FICFIININJE(string AGHNPABBPHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KKIBMGIEJGN : DNJKNJKHLNB<EDDKJIPNMLB, JMFCAGKBFOE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x46C0960", Offset = "0x46BF760", VA = "0x1846C0960")]
		public KKIBMGIEJGN(EDDKJIPNMLB CMNFLMCAEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x46C0890", Offset = "0x46BF690", VA = "0x1846C0890", Slot = "7")]
		protected override void PHBHFEACJDJ(EDDKJIPNMLB CMNFLMCAEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x46C0840", Offset = "0x46BF640", VA = "0x1846C0840", Slot = "8")]
		protected override void BLKKFDDMHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1161B70", Offset = "0x1160970", VA = "0x181161B70")]
		[CompilerGenerated]
		private void GILDMFFFHAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1963630", Offset = "0x1962430", VA = "0x181963630")]
		[CompilerGenerated]
		private void FICFIININJE(string AGHNPABBPHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class NOBGOFGMFPF : BANEOGFFAID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action JJOAKFFHFLE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GJAHCMIIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x51CFE0", Offset = "0x51BDE0", VA = "0x18051CFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x651320", Offset = "0x650120", VA = "0x180651320")]
		public NOBGOFGMFPF(Action JJOAKFFHFLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x10AB260", Offset = "0x10AA060", VA = "0x1810AB260", Slot = "5")]
		public void IANFCFBCFJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "6")]
		public void LKLAHJCEPCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<BANEOGFFAID> FGHJGNAIPHC;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1D317B0", Offset = "0x1D305B0", VA = "0x181D317B0")]
	public static global::BKHPMHDEEIP<T> HAFJICNLPAF<T>(this global::BKHPMHDEEIP<T> CMNFLMCAEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46C1CF0", Offset = "0x46C0AF0", VA = "0x1846C1CF0")]
	public static EDDKJIPNMLB HAFJICNLPAF(this EDDKJIPNMLB CMNFLMCAEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46C1E00", Offset = "0x46C0C00", VA = "0x1846C1E00")]
	public static void HAFJICNLPAF(Action JJOAKFFHFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1D316F0", Offset = "0x1D304F0", VA = "0x181D316F0")]
	private static global::BKHPMHDEEIP<T> DEHFMODHFCK<T>(global::BKHPMHDEEIP<T> CMNFLMCAEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46C1C10", Offset = "0x46C0A10", VA = "0x1846C1C10")]
	private static EDDKJIPNMLB DEHFMODHFCK(EDDKJIPNMLB CMNFLMCAEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46C2260", Offset = "0x46C1060", VA = "0x1846C2260")]
	private static void LGFMKMGMMFA(BANEOGFFAID NONNBHMEJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46C1E90", Offset = "0x46C0C90", VA = "0x1846C1E90")]
	private static void HDFLGOJAKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46C1B40", Offset = "0x46C0940", VA = "0x1846C1B40")]
	private static void AGFICMDKLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46C21B0", Offset = "0x46C0FB0", VA = "0x1846C21B0")]
	private static void KHMNMEHNHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class OMNKDDNIAFN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PLLJFIFKJCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public JMFCAGKBFOE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public PLLJFIFKJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46C6BA0", Offset = "0x46C59A0", VA = "0x1846C6BA0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x46C6B90", Offset = "0x46C5990", VA = "0x1846C6B90")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AEDLGACNDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public AEDLGACNDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x46B6EF0", Offset = "0x46B5CF0", VA = "0x1846B6EF0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OEAKPCJAFMP : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public JMFCAGKBFOE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public OEAKPCJAFMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x46C6010", Offset = "0x46C4E10", VA = "0x1846C6010", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46C5CF0", Offset = "0x46C4AF0", VA = "0x1846C5CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x46C60C0", Offset = "0x46C4EC0", VA = "0x1846C60C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x46C5FC0", Offset = "0x46C4DC0", VA = "0x1846C5FC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KIOPJKGOEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public JMFCAGKBFOE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public KIOPJKGOEKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JLIOLEOCOPN : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JMFCAGKBFOE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private KIOPJKGOEKC <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public JLIOLEOCOPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x46BFD20", Offset = "0x46BEB20", VA = "0x1846BFD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x46C00B0", Offset = "0x46BEEB0", VA = "0x1846C00B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string FAGFOOCHJOA = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string ENPEJNBEMOK = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string COCEAIOGGIJ = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string HIOLHHNHFOG = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string OOCHHCFGDPN = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float FLJGDGHPOBD = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static EDDKJIPNMLB IDGBHMPNHAK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation NFMEMCNABEE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EDDKJIPNMLB EFFOLPPNFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string LFMDKHOGKLB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority MICGEOFAAGB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool HJJNEHDELOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x46C6870", Offset = "0x46C5670", VA = "0x1846C6870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool IDLKNMDBDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x46C6150", Offset = "0x46C4F50", VA = "0x1846C6150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool GNBKKEHOHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x46C6910", Offset = "0x46C5710", VA = "0x1846C6910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ONPNEIHAGML
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x46C6380", Offset = "0x46C5180", VA = "0x1846C6380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x46C6240", Offset = "0x46C5040", VA = "0x1846C6240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x46C6660", Offset = "0x46C5460", VA = "0x1846C6660")]
	[OENDEPLIANP(AJFNGMOAHIK.EnteredEditModeNextFrame, 0)]
	private static void KDOFPJGEELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x46C6710", Offset = "0x46C5510", VA = "0x1846C6710")]
	public static EDDKJIPNMLB NPHLCAOGDPF(string ADEDBJKGNMM, LoadSceneMode CHFHBLOIDMG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x46C6430", Offset = "0x46C5230", VA = "0x1846C6430")]
	public static EDDKJIPNMLB FHCMHFFHMHP(string ADEDBJKGNMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x46C62F0", Offset = "0x46C50F0", VA = "0x1846C62F0")]
	[IteratorStateMachine(typeof(OEAKPCJAFMP))]
	private static IEnumerator<DOOLAEBGDFI> EKONBBFPJID(string ADEDBJKGNMM, JMFCAGKBFOE NDHBFMADFKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x46C61B0", Offset = "0x46C4FB0", VA = "0x1846C61B0")]
	[IteratorStateMachine(typeof(JLIOLEOCOPN))]
	private static IEnumerator<DOOLAEBGDFI> BMBMCOEHIGP(string ADEDBJKGNMM, LoadSceneMode CHFHBLOIDMG, JMFCAGKBFOE NDHBFMADFKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NEGLFAEMEOL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46C31B0", Offset = "0x46C1FB0", VA = "0x1846C31B0")]
	public static IDisposable JEAGCDCELFK(this MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46C3230", Offset = "0x46C2030", VA = "0x1846C3230")]
	public static IDisposable JEAGCDCELFK(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46C2FA0", Offset = "0x46C1DA0", VA = "0x1846C2FA0")]
	public static IDisposable ICGBNLCPFLN(this MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x46C2C60", Offset = "0x46C1A60", VA = "0x1846C2C60")]
	public static IDisposable CJLGHHGJHIF(this MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x46C2CD0", Offset = "0x46C1AD0", VA = "0x1846C2CD0")]
	public static IDisposable DBNOFBBCGBH(this MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46C2DC0", Offset = "0x46C1BC0", VA = "0x1846C2DC0")]
	public static IDisposable DMBNKHOKDMH(this MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x46C2F30", Offset = "0x46C1D30", VA = "0x1846C2F30")]
	public static IDisposable GCDJANKBCKD(this MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x46C3090", Offset = "0x46C1E90", VA = "0x1846C3090")]
	public static IDisposable IPEMPIFFIMK(this MCGPHHKEIOB BKOJMLFMNLI, float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x46C2BE0", Offset = "0x46C19E0", VA = "0x1846C2BE0")]
	public static IDisposable BPCEHBCDELJ(this MCGPHHKEIOB BKOJMLFMNLI, float AEENDACOCBC, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x46C34C0", Offset = "0x46C22C0", VA = "0x1846C34C0")]
	public static IDisposable OGOFBNNBBLB(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x46C2D40", Offset = "0x46C1B40", VA = "0x1846C2D40")]
	public static IDisposable DHDJBDHBPDK(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46C3440", Offset = "0x46C2240", VA = "0x1846C3440")]
	public static IDisposable MDFGEAHMMCL(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46C3330", Offset = "0x46C2130", VA = "0x1846C3330")]
	public static IDisposable KEAHPNFFAJF(this MCGPHHKEIOB BKOJMLFMNLI, float AEENDACOCBC, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x46C2E30", Offset = "0x46C1C30", VA = "0x1846C2E30")]
	public static IDisposable ECMLJFBINOF(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46C3010", Offset = "0x46C1E10", VA = "0x1846C3010")]
	public static IDisposable IMHMEMFGKCA(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x46C2EB0", Offset = "0x46C1CB0", VA = "0x1846C2EB0")]
	public static IDisposable EGDAMACGDMO(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46C3120", Offset = "0x46C1F20", VA = "0x1846C3120")]
	public static IDisposable JBKEGGFGKDG(this MCGPHHKEIOB BKOJMLFMNLI, float AEENDACOCBC, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x46C3540", Offset = "0x46C2340", VA = "0x1846C3540")]
	public static IDisposable PKDLDCLBAKK(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46C32B0", Offset = "0x46C20B0", VA = "0x1846C32B0")]
	public static IDisposable JEGEBPADKOG(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x46C33C0", Offset = "0x46C21C0", VA = "0x1846C33C0")]
	public static IDisposable LJHIEIIHFAO(this MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class ABDNLMAFBFO
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x46B68A0", Offset = "0x46B56A0", VA = "0x1846B68A0")]
	public static IDisposable JEEBCONMJDM(this MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x46B6920", Offset = "0x46B5720", VA = "0x1846B6920")]
	public static IDisposable JEEBCONMJDM(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x46B6E80", Offset = "0x46B5C80", VA = "0x1846B6E80")]
	public static IDisposable OLEACKIIGIG(this MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46B6320", Offset = "0x46B5120", VA = "0x1846B6320")]
	public static IDisposable BBFMMNCNLLK(this MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x46B6AC0", Offset = "0x46B58C0", VA = "0x1846B6AC0")]
	public static IDisposable LEEBBOBMBMB(this MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x46B6390", Offset = "0x46B5190", VA = "0x1846B6390")]
	public static IDisposable CHGNMCEPBKD(this MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46B6BC0", Offset = "0x46B59C0", VA = "0x1846B6BC0")]
	public static IDisposable MELGBBEBKFP(this MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46B6DE0", Offset = "0x46B5BE0", VA = "0x1846B6DE0")]
	public static IDisposable OLAKELCGDLF(this MonoBehaviour EKFCFOFGPMJ, float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46B6530", Offset = "0x46B5330", VA = "0x1846B6530")]
	public static IDisposable FNIALAOGDIP(this MonoBehaviour EKFCFOFGPMJ, float AEENDACOCBC, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x46B69A0", Offset = "0x46B57A0", VA = "0x1846B69A0")]
	public static IDisposable JJCAFJCJJDM(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x46B6660", Offset = "0x46B5460", VA = "0x1846B6660")]
	public static IDisposable GJLJCLADJPF(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x46B6290", Offset = "0x46B5090", VA = "0x1846B6290")]
	public static IDisposable AIOLOBKBEJF(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x46B6A30", Offset = "0x46B5830", VA = "0x1846B6A30")]
	public static IDisposable KFGGPEBCBNK(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46B6D50", Offset = "0x46B5B50", VA = "0x1846B6D50")]
	public static IDisposable OIHMFONMEAI(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46B6810", Offset = "0x46B5610", VA = "0x1846B6810")]
	public static IDisposable IFALFPOKIDO(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46B6400", Offset = "0x46B5200", VA = "0x1846B6400")]
	public static IDisposable DMMMELDELCB(this MonoBehaviour EKFCFOFGPMJ, float AEENDACOCBC, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x46B6C30", Offset = "0x46B5A30", VA = "0x1846B6C30")]
	public static IDisposable NDPGBBOKEIE(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46B6CC0", Offset = "0x46B5AC0", VA = "0x1846B6CC0")]
	public static IDisposable NNJGMIAODAN(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46B64A0", Offset = "0x46B52A0", VA = "0x1846B64A0")]
	public static IDisposable FKBDAKCKDLD(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46B65C0", Offset = "0x46B53C0", VA = "0x1846B65C0")]
	public static IDisposable GILJKHADCGE(this MonoBehaviour EKFCFOFGPMJ, float AEENDACOCBC, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46B66F0", Offset = "0x46B54F0", VA = "0x1846B66F0")]
	public static IDisposable GNHKOIEEKLO(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46B6B30", Offset = "0x46B5930", VA = "0x1846B6B30")]
	public static IDisposable LNOHAELNENH(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46B6780", Offset = "0x46B5580", VA = "0x1846B6780")]
	public static IDisposable HCIJBAHAKDC(this MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DCBBHBIFHKC
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HNBHBBGKOHC : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public OBPCDNFPNDJ.PPKDFONAFGO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private PHIBBFCKCHI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public HNBHBBGKOHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x46BEBE0", Offset = "0x46BD9E0", VA = "0x1846BEBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x46BECA0", Offset = "0x46BDAA0", VA = "0x1846BECA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ODHFOEEDGPE : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public OBPCDNFPNDJ.PPKDFONAFGO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private PHIBBFCKCHI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public ODHFOEEDGPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x46C5BC0", Offset = "0x46C49C0", VA = "0x1846C5BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x46C5CA0", Offset = "0x46C4AA0", VA = "0x1846C5CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46BC1E0", Offset = "0x46BAFE0", VA = "0x1846BC1E0")]
	public static HOAOHLFJCKG JEEBCONMJDM(Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46BC2D0", Offset = "0x46BB0D0", VA = "0x1846BC2D0")]
	public static HOAOHLFJCKG JEEBCONMJDM(Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x46BC0D0", Offset = "0x46BAED0", VA = "0x1846BC0D0")]
	public static HOAOHLFJCKG JEEBCONMJDM(Behaviour BKOJMLFMNLI, Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46BBFC0", Offset = "0x46BADC0", VA = "0x1846BBFC0")]
	public static HOAOHLFJCKG JEEBCONMJDM(Behaviour BKOJMLFMNLI, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46BBDA0", Offset = "0x46BABA0", VA = "0x1846BBDA0")]
	public static HOAOHLFJCKG JEAGCDCELFK(MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46BBEB0", Offset = "0x46BACB0", VA = "0x1846BBEB0")]
	public static HOAOHLFJCKG JEAGCDCELFK(MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46BC3C0", Offset = "0x46BB1C0", VA = "0x1846BC3C0")]
	[IteratorStateMachine(typeof(HNBHBBGKOHC))]
	private static IEnumerator<DOOLAEBGDFI> NOHALPGPAEO(OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF, Action CNBJKIHJDDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x46BC440", Offset = "0x46BB240", VA = "0x1846BC440")]
	[IteratorStateMachine(typeof(ODHFOEEDGPE))]
	private static IEnumerator<DOOLAEBGDFI> NOHALPGPAEO(OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF, Action<float> CNBJKIHJDDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FEEBGLKDKOG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CEGJHMKHFFH : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public OBPCDNFPNDJ.PPKDFONAFGO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LEMOOIFGPJM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public CEGJHMKHFFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x46B9DF0", Offset = "0x46B8BF0", VA = "0x1846B9DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x46B9F00", Offset = "0x46B8D00", VA = "0x1846B9F00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46BDE40", Offset = "0x46BCC40", VA = "0x1846BDE40")]
	public static HOAOHLFJCKG JEEBCONMJDM(float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46BDF00", Offset = "0x46BCD00", VA = "0x1846BDF00")]
	public static HOAOHLFJCKG JEEBCONMJDM(MonoBehaviour EKFCFOFGPMJ, float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46BDD80", Offset = "0x46BCB80", VA = "0x1846BDD80")]
	public static HOAOHLFJCKG HFODBPCAEHI(MCGPHHKEIOB BKOJMLFMNLI, float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, bool CLHJMCOOGII = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46BDFC0", Offset = "0x46BCDC0", VA = "0x1846BDFC0")]
	[IteratorStateMachine(typeof(CEGJHMKHFFH))]
	private static IEnumerator<DOOLAEBGDFI> NOHALPGPAEO(float AEENDACOCBC, OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF, Action<float> CNBJKIHJDDD, bool CLHJMCOOGII = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EKDCHMMKLGM
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class GFBILMAFPGE : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public OBPCDNFPNDJ.PPKDFONAFGO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public GFBILMAFPGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x46BE060", Offset = "0x46BCE60", VA = "0x1846BE060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x46BE110", Offset = "0x46BCF10", VA = "0x1846BE110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x46BCF20", Offset = "0x46BBD20", VA = "0x1846BCF20")]
	[IteratorStateMachine(typeof(GFBILMAFPGE))]
	private static IEnumerator<DOOLAEBGDFI> HAPKDMDEBLN(OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, Func<bool> PHNEOBLDPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x46BCFA0", Offset = "0x46BBDA0", VA = "0x1846BCFA0")]
	public static HOAOHLFJCKG KJKCHPNBLPA(this MonoBehaviour EKFCFOFGPMJ, Func<bool> PHNEOBLDPHG, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA = OBPCDNFPNDJ.PPKDFONAFGO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LFCHHLBOKND
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CHLFPKPIMAH : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OBPCDNFPNDJ.PPKDFONAFGO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public CHLFPKPIMAH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x46B9F50", Offset = "0x46B8D50", VA = "0x1846B9F50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x46BA010", Offset = "0x46B8E10", VA = "0x1846BA010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BGAHEPDGGDO : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public OBPCDNFPNDJ.PPKDFONAFGO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private DOOLAEBGDFI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public BGAHEPDGGDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x46B98C0", Offset = "0x46B86C0", VA = "0x1846B98C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x46B9990", Offset = "0x46B8790", VA = "0x1846B9990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x46C1030", Offset = "0x46BFE30", VA = "0x1846C1030")]
	[IteratorStateMachine(typeof(CHLFPKPIMAH))]
	private static IEnumerator<DOOLAEBGDFI> EPBGEFGNPLM(float LNMECBMCIPH, OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x46C16B0", Offset = "0x46C04B0", VA = "0x1846C16B0")]
	[IteratorStateMachine(typeof(BGAHEPDGGDO))]
	private static IEnumerator<DOOLAEBGDFI> JPHJGOEODGL(float LNMECBMCIPH, OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x46C1330", Offset = "0x46C0130", VA = "0x1846C1330")]
	public static IDisposable GKALALILBMF(this MonoBehaviour EKFCFOFGPMJ, float LNMECBMCIPH, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x46C10D0", Offset = "0x46BFED0", VA = "0x1846C10D0")]
	public static HOAOHLFJCKG GGBOCNNKOAH(this MonoBehaviour EKFCFOFGPMJ, float LNMECBMCIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x46C11D0", Offset = "0x46BFFD0", VA = "0x1846C11D0")]
	public static HOAOHLFJCKG GKALALILBMF(this MonoBehaviour EKFCFOFGPMJ, float LNMECBMCIPH, OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x46C10C0", Offset = "0x46BFEC0", VA = "0x1846C10C0")]
	public static HOAOHLFJCKG EPFCGJEDBAD(this MonoBehaviour EKFCFOFGPMJ, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x46C0DF0", Offset = "0x46BFBF0", VA = "0x1846C0DF0")]
	public static HOAOHLFJCKG ADAEIMNMHPC(this MonoBehaviour EKFCFOFGPMJ, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x46C1850", Offset = "0x46C0650", VA = "0x1846C1850")]
	public static HOAOHLFJCKG MCCABGCGALJ(this MonoBehaviour EKFCFOFGPMJ, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x46C0F10", Offset = "0x46BFD10", VA = "0x1846C0F10")]
	public static HOAOHLFJCKG BEKFMFLNIHC(this MonoBehaviour EKFCFOFGPMJ, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46C16A0", Offset = "0x46C04A0", VA = "0x1846C16A0")]
	public static HOAOHLFJCKG JBFHPGIJGKC(this MonoBehaviour EKFCFOFGPMJ, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x46C0F20", Offset = "0x46BFD20", VA = "0x1846C0F20")]
	private static HOAOHLFJCKG DCKKJOLBMHJ(MonoBehaviour EKFCFOFGPMJ, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x46C1740", Offset = "0x46C0540", VA = "0x1846C1740")]
	public static HOAOHLFJCKG KPAOLJBENFK(this MonoBehaviour EKFCFOFGPMJ, float JDNAAFJKMKF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x46C1590", Offset = "0x46C0390", VA = "0x1846C1590")]
	public static HOAOHLFJCKG HIDIFFONOME(this MonoBehaviour EKFCFOFGPMJ, float JDNAAFJKMKF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46C1480", Offset = "0x46C0280", VA = "0x1846C1480")]
	public static HOAOHLFJCKG HDGOIJEIMOM(this MonoBehaviour EKFCFOFGPMJ, float JDNAAFJKMKF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x46C0E00", Offset = "0x46BFC00", VA = "0x1846C0E00")]
	public static HOAOHLFJCKG ANJBCBLHAMK(this MonoBehaviour EKFCFOFGPMJ, float JDNAAFJKMKF, Action AHJLOJELGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x46C1860", Offset = "0x46C0660", VA = "0x1846C1860")]
	public static HOAOHLFJCKG ODCDLPBMKDG(this MonoBehaviour EKFCFOFGPMJ, float JDNAAFJKMKF, Action AHJLOJELGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class IPBPLGBOFEL : DHACJGJBCDA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GJPGEIADNAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IPBPLGBOFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public GJPGEIADNAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC60", Offset = "0x46BCA60", VA = "0x1846BDC60")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FAKIOKJFLHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public IPBPLGBOFEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
		public FAKIOKJFLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC60", Offset = "0x46BCA60", VA = "0x1846BDC60")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float HPIGGBHOANJ;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x46BFCC0", Offset = "0x46BEAC0", VA = "0x1846BFCC0")]
	public IPBPLGBOFEL(Behaviour BKOJMLFMNLI, float HPIGGBHOANJ, [Optional] Action GLDKOKHJHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x46BFB00", Offset = "0x46BE900", VA = "0x1846BFB00", Slot = "9")]
	protected override bool LECBBHLJLEJ(Action JJOAKFFHFLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x46BFBE0", Offset = "0x46BE9E0", VA = "0x1846BFBE0", Slot = "10")]
	protected override bool ODEIANAAIEP(Action JJOAKFFHFLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MBPCNJAEJAN
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool MAIIBDIBBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DHEIJBFNBMM;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HILPFNHICLD(bool CHKACKLAPHG = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HILPFNHICLD(Action JJOAKFFHFLE, bool CHKACKLAPHG = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class DHACJGJBCDA : MBPCNJAEJAN
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class FBKKPEGMNEE : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public FBKKPEGMNEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC90", Offset = "0x46BCA90", VA = "0x1846BDC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x46BDD30", Offset = "0x46BCB30", VA = "0x1846BDD30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour BKOJMLFMNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action GLDKOKHJHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private GIFAJKNOCHE NHOFLKBGPEF;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MAIIBDIBBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x765CB0", Offset = "0x764AB0", VA = "0x180765CB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DHEIJBFNBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x46BC900", Offset = "0x46BB700", VA = "0x1846BC900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x46BC610", Offset = "0x46BB410", VA = "0x1846BC610", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x46BC9C0", Offset = "0x46BB7C0", VA = "0x1846BC9C0")]
	protected DHACJGJBCDA(Behaviour BKOJMLFMNLI, [Optional] Action GLDKOKHJHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x46BC550", Offset = "0x46BB350", VA = "0x1846BC550", Slot = "7")]
	public bool HILPFNHICLD(bool CHKACKLAPHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x46BC500", Offset = "0x46BB300", VA = "0x1846BC500", Slot = "8")]
	public bool HILPFNHICLD(Action JJOAKFFHFLE, bool CHKACKLAPHG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LECBBHLJLEJ(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool ODEIANAAIEP(Action JJOAKFFHFLE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x46BC9A0", Offset = "0x46BB7A0", VA = "0x1846BC9A0")]
	protected void POCEPOFAOAO(Action JJOAKFFHFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x46BC720", Offset = "0x46BB520", VA = "0x1846BC720")]
	protected EDDKJIPNMLB ODGLJENKFBI(float FFOKOBLLBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x46BC6B0", Offset = "0x46BB4B0", VA = "0x1846BC6B0")]
	private void LFJAOINDPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x46BC5B0", Offset = "0x46BB3B0", VA = "0x1846BC5B0")]
	[IteratorStateMachine(typeof(FBKKPEGMNEE))]
	private static IEnumerator<DOOLAEBGDFI> HNGIGLPFDEE(float FFOKOBLLBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x46BC4C0", Offset = "0x46BB2C0", VA = "0x1846BC4C0")]
	[CompilerGenerated]
	private void EJBIOIJICHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KOJCMJMJLOG : DHACJGJBCDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float MNKCPGINEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int CMJFHGBMHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float NDJBAFAANIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] MJHDMJLCIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int KMLFIPIPPNB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NOGOMKAGHHC LLHKFJAMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x544A30", Offset = "0x543830", VA = "0x180544A30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x654540", Offset = "0x653340", VA = "0x180654540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x46C0CC0", Offset = "0x46BFAC0", VA = "0x1846C0CC0")]
	public KOJCMJMJLOG(Behaviour BKOJMLFMNLI, float IAEKMICNHOE, int CMJFHGBMHEN, [Optional] Action GLDKOKHJHMD, float NDJBAFAANIA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x51CEC0", Offset = "0x51BCC0", VA = "0x18051CEC0", Slot = "9")]
	protected override bool LECBBHLJLEJ(Action JJOAKFFHFLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x46C0A10", Offset = "0x46BF810", VA = "0x1846C0A10", Slot = "10")]
	protected override bool ODEIANAAIEP(Action JJOAKFFHFLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x46C0C30", Offset = "0x46BFA30", VA = "0x1846C0C30")]
	private void OLHEKNDCNPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OELMLEBHFGB : DHACJGJBCDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float HPIGGBHOANJ;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x46BFCC0", Offset = "0x46BEAC0", VA = "0x1846BFCC0")]
	public OELMLEBHFGB(Behaviour BKOJMLFMNLI, float HPIGGBHOANJ, [Optional] Action GLDKOKHJHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x51CEC0", Offset = "0x51BCC0", VA = "0x18051CEC0", Slot = "9")]
	protected override bool LECBBHLJLEJ(Action JJOAKFFHFLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x46C6110", Offset = "0x46C4F10", VA = "0x1846C6110", Slot = "10")]
	protected override bool ODEIANAAIEP(Action JJOAKFFHFLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IHICNPJHLHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AGGOLOEIMEK : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public AGGOLOEIMEK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x46B6F20", Offset = "0x46B5D20", VA = "0x1846B6F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x46B7020", Offset = "0x46B5E20", VA = "0x1846B7020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private HOAOHLFJCKG MDPBDAPCDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private MCGPHHKEIOB BKOJMLFMNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action CNBJKIHJDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> BICOAHAKAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float CMOEFAEGECP;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x46BF4E0", Offset = "0x46BE2E0", VA = "0x1846BF4E0")]
	public IHICNPJHLHB(MCGPHHKEIOB BKOJMLFMNLI, Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x46BF6A0", Offset = "0x46BE4A0", VA = "0x1846BF6A0")]
	public IHICNPJHLHB(MCGPHHKEIOB BKOJMLFMNLI, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x46BF860", Offset = "0x46BE660", VA = "0x1846BF860")]
	public IHICNPJHLHB(MCGPHHKEIOB BKOJMLFMNLI, float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x46BF070", Offset = "0x46BDE70", VA = "0x1846BF070")]
	private void JEEBCONMJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x46BF350", Offset = "0x46BE150", VA = "0x1846BF350")]
	private void LBOBBGBALJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x46BF200", Offset = "0x46BE000", VA = "0x1846BF200")]
	private void KPFPDIDHOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x46BEDE0", Offset = "0x46BDBE0", VA = "0x1846BEDE0")]
	private void CPHPENELFOH(string AGHNPABBPHD, Action LBDIDAJANIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x46BECF0", Offset = "0x46BDAF0", VA = "0x1846BECF0")]
	[IteratorStateMachine(typeof(AGGOLOEIMEK))]
	private IEnumerator<DOOLAEBGDFI> AFHPHAEBMHF(Action LBDIDAJANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x46BEF10", Offset = "0x46BDD10", VA = "0x1846BEF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x46BEF70", Offset = "0x46BDD70", VA = "0x1846BEF70")]
	[CompilerGenerated]
	private void FJJECCCMFND(string OGCHFBMNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x46BEFF0", Offset = "0x46BDDF0", VA = "0x1846BEFF0")]
	[CompilerGenerated]
	private void IENGFNKIMPE(string OGCHFBMNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x46BED60", Offset = "0x46BDB60", VA = "0x1846BED60")]
	[CompilerGenerated]
	private void BDHKDOGGECA(string OGCHFBMNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class OAPDPKNCBFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HBDHNJNMEFG : IEnumerator<DOOLAEBGDFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private DOOLAEBGDFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private DOOLAEBGDFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
		[DebuggerHidden]
		public HBDHNJNMEFG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x46BE8C0", Offset = "0x46BD6C0", VA = "0x1846BE8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x46BE9C0", Offset = "0x46BD7C0", VA = "0x1846BE9C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private HOAOHLFJCKG MDPBDAPCDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour EKFCFOFGPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action CNBJKIHJDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> BICOAHAKAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float CMOEFAEGECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool CLHJMCOOGII;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x46C56A0", Offset = "0x46C44A0", VA = "0x1846C56A0")]
	public OAPDPKNCBFJ(MonoBehaviour EKFCFOFGPMJ, Action CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x46C5A00", Offset = "0x46C4800", VA = "0x1846C5A00")]
	public OAPDPKNCBFJ(MonoBehaviour EKFCFOFGPMJ, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x46C5860", Offset = "0x46C4660", VA = "0x1846C5860")]
	public OAPDPKNCBFJ(MonoBehaviour EKFCFOFGPMJ, float AEENDACOCBC, Action<float> CNBJKIHJDDD, OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA, bool CLHJMCOOGII = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x46C5130", Offset = "0x46C3F30", VA = "0x1846C5130")]
	private void JEEBCONMJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x46C5490", Offset = "0x46C4290", VA = "0x1846C5490")]
	private void LBOBBGBALJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x46C5340", Offset = "0x46C4140", VA = "0x1846C5340")]
	private void KPFPDIDHOGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x46C4FA0", Offset = "0x46C3DA0", VA = "0x1846C4FA0")]
	private void CPHPENELFOH(string AGHNPABBPHD, Action LBDIDAJANIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x46C4EB0", Offset = "0x46C3CB0", VA = "0x1846C4EB0")]
	[IteratorStateMachine(typeof(HBDHNJNMEFG))]
	private IEnumerator<DOOLAEBGDFI> AFHPHAEBMHF(Action LBDIDAJANIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x46C50D0", Offset = "0x46C3ED0", VA = "0x1846C50D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x46C5620", Offset = "0x46C4420", VA = "0x1846C5620")]
	[CompilerGenerated]
	private void LDNHEHHJDCL(string OGCHFBMNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x46C4F20", Offset = "0x46C3D20", VA = "0x1846C4F20")]
	[CompilerGenerated]
	private void BAHLIMAFJMI(string OGCHFBMNBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x46C52C0", Offset = "0x46C40C0", VA = "0x1846C52C0")]
	[CompilerGenerated]
	private void JNPDBPJMJFJ(string OGCHFBMNBDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KFHPFKIIGNA
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int FOJANJPFBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class MEOABCHNENL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly MEOABCHNENL PJPMIMBNOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action ANEAKNAIPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool BKKHGGNPMMA;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x651320", Offset = "0x650120", VA = "0x180651320")]
	public MEOABCHNENL(Action ANEAKNAIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x46C24B0", Offset = "0x46C12B0", VA = "0x1846C24B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface MOICEBOEHKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T MKDOFJMDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CENMMFJEIOF(Action<T> POCHCJBCLGJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable CENMMFJEIOF(UnityEngine.Object BKOJMLFMNLI, Action<T> POCHCJBCLGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IKGGFCEOKDP<T> : global::MOICEBOEHKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T MKDOFJMDMOL
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
public class DGCAJFFHKIF<T> : global::IKGGFCEOKDP<T>, global::MOICEBOEHKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MABBAOFAIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::DGCAJFFHKIF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::GNGECOGIHFJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1B58430", Offset = "0x1B57230", VA = "0x181B58430")]
		public MABBAOFAIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x36EFC30", Offset = "0x36EEA30", VA = "0x1836EFC30")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject EOJGPIBKHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::GNGECOGIHFJ<UnityEngine.Object, Action<T>>> JNJOHBOPDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T LBHOCDOGALN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object ELNCKJMHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x36DCFD0", Offset = "0x36DBDD0", VA = "0x1836DCFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T MKDOFJMDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x64ABA0", Offset = "0x6499A0", VA = "0x18064ABA0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x36DCC60", Offset = "0x36DBA60", VA = "0x1836DCC60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x36DCD50", Offset = "0x36DBB50", VA = "0x1836DCD50")]
	private static bool JJNCODCDNMB(T OCLDIKFJHHO, T KBBKPHEOPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x33494D0", Offset = "0x33482D0", VA = "0x1833494D0")]
	public DGCAJFFHKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x36DD1E0", Offset = "0x36DBFE0", VA = "0x1836DD1E0")]
	public DGCAJFFHKIF(T DGIADLLCIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36DCCC0", Offset = "0x36DBAC0", VA = "0x1836DCCC0")]
	public void ICJJGGPECAB(T HAHNIPPEOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x36DC8B0", Offset = "0x36DB6B0", VA = "0x1836DC8B0", Slot = "7")]
	public IDisposable CENMMFJEIOF(Action<T> POCHCJBCLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x36DC920", Offset = "0x36DB720", VA = "0x1836DC920", Slot = "8")]
	public IDisposable CENMMFJEIOF(UnityEngine.Object BKOJMLFMNLI, Action<T> POCHCJBCLGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x36DC580", Offset = "0x36DB380", VA = "0x1836DC580")]
	private void CAGKBGFCKIB()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<KINEGGONFKL, Scheduler>, KINEGGONFKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class BLECBGGAJDL : KFHPFKIIGNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public APIIKNLIOEI POKBGOELPMH;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int FOJANJPFBDA
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x51CED0", Offset = "0x51BCD0", VA = "0x18051CED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x51CEE0", Offset = "0x51BCE0", VA = "0x18051CEE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x46B9C90", Offset = "0x46B8A90", VA = "0x1846B9C90")]
			public static DOOLAEBGDFI PDLOPMPMNJF(IEnumerator<DOOLAEBGDFI> LCLABOOPDIK, DBMMILHLGJM GDJKJKEPKOD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x46B9BB0", Offset = "0x46B89B0", VA = "0x1846B9BB0")]
			public DOOLAEBGDFI PDLOPMPMNJF(DBMMILHLGJM[] IHKNKDPAJHA, IEnumerator<DOOLAEBGDFI>[] JMFDPNMMDLM, DOOLAEBGDFI[] HFCFJEPMLIL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x46B99E0", Offset = "0x46B87E0", VA = "0x1846B99E0")]
			public void JPJIADOCOCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x46B9AE0", Offset = "0x46B88E0", VA = "0x1846B9AE0")]
			public void NEGDIJCNCMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x46B9A10", Offset = "0x46B8810", VA = "0x1846B9A10")]
			public void LKMBHADLKDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x46B99E0", Offset = "0x46B87E0", VA = "0x1846B99E0")]
			public void LKLAHJCEPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public BLECBGGAJDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class APIIKNLIOEI
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct JHOHKACMDJP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public BLECBGGAJDL LAOAKPHIDNP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public MCGPHHKEIOB FDODGMDGJGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public DBMMILHLGJM LFIAEJIFAJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<DOOLAEBGDFI> DGJBDMMBEPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public DOOLAEBGDFI GHDMKKEKBLI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public JKPEMGCCLHG BDNGHGCDIGC;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct GNBEMMFFAJI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public OBPCDNFPNDJ.PPKDFONAFGO BGIILGNFILG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<JHOHKACMDJP> LGKEFBLGAPM;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class EKKJINACHEE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public APIIKNLIOEI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public MCGPHHKEIOB context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public BLECBGGAJDL routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public JKPEMGCCLHG coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public DBMMILHLGJM promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public DOOLAEBGDFI currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<DOOLAEBGDFI> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
				public EKKJINACHEE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x46BD100", Offset = "0x46BBF00", VA = "0x1846BD100")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class NLPEIIIPFFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public BLECBGGAJDL schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public APIIKNLIOEI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
				public NLPEIIIPFFP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x46C35C0", Offset = "0x46C23C0", VA = "0x1846C35C0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class KOCEPGPMPFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public BLECBGGAJDL schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public APIIKNLIOEI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
				public KOCEPGPMPFI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x46C09D0", Offset = "0x46BF7D0", VA = "0x1846C09D0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class MNDIMLINPIO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public BLECBGGAJDL schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public APIIKNLIOEI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
				public MNDIMLINPIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x46C2BA0", Offset = "0x46C19A0", VA = "0x1846C2BA0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] GDHOICMMMMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<JKPEMGCCLHG> OINFOPKDIAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> BIJLLAOIHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> LLGHPKDPAAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> EJCMCAGFLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> JIFPBABEIBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> OCEOGIIFFNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> KHBIININJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private BLECBGGAJDL[] OHFEMAMCKBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private DBMMILHLGJM[] IHKNKDPAJHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private MCGPHHKEIOB[] GNAOHNLEJPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<DOOLAEBGDFI>[] ENPACGDMJKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private DOOLAEBGDFI[] MOPKIIBFNHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int IJMKNNCILKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int OIICMJBLBOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int JDCIMALCGLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float EHOIFICEGGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private GOEJGHBICHC EHFAEMNODON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle GAJIJCEJMKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<BLECBGGAJDL> NGMOLFHPCCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool HOOLIMIOLOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> NHAPIHOPMEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> HCBHJNGHBNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool GANENMNDKIP;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public GNBEMMFFAJI[] PJFONDEJKIM
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x8C6130", Offset = "0x8C4F30", VA = "0x1808C6130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int KGICKEDEEFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0xB1DC10", Offset = "0xB1CA10", VA = "0x180B1DC10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x46B71B0", Offset = "0x46B5FB0", VA = "0x1846B71B0")]
			private static int AFCKAFFPFBC(OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x46B8E40", Offset = "0x46B7C40", VA = "0x1846B8E40")]
			public APIIKNLIOEI(OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x46B71E0", Offset = "0x46B5FE0", VA = "0x1846B71E0")]
			private void AGJPKJLJLED(ref int CDPECLKPCMG, int ENGEMHLLFJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x46B7760", Offset = "0x46B6560", VA = "0x1846B7760")]
			public void DOCMKELHJEC(MCGPHHKEIOB BKOJMLFMNLI, DOOLAEBGDFI MJGGMIPMJCE, IEnumerator<DOOLAEBGDFI> LCLABOOPDIK, DBMMILHLGJM GDJKJKEPKOD, [Optional] BLECBGGAJDL PFGABEBGOAM, JKPEMGCCLHG ONJKBBKHJDG = JKPEMGCCLHG.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x46B8C50", Offset = "0x46B7A50", VA = "0x1846B8C50")]
			public void NOPLFDDKELG(IEnumerable<JHOHKACMDJP> GHIDPIJCOIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x46B78C0", Offset = "0x46B66C0", VA = "0x1846B78C0")]
			private JHOHKACMDJP HHCGPOMKBDA(int OFFFKGHBELG)
			{
				return default(JHOHKACMDJP);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x46B73F0", Offset = "0x46B61F0", VA = "0x1846B73F0")]
			private void CNKJHFGPFLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1C3E590", Offset = "0x1C3D390", VA = "0x181C3E590")]
			private static void JEGLOMPBAHD<T>(int OFFFKGHBELG, T[] FACNNGOOMDP, int DPKPMBGBJLN, [Optional] T KMAOFDDCAGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1C3E570", Offset = "0x1C3D370", VA = "0x181C3E570")]
			private static void JEGLOMPBAHD<T>(int OFFFKGHBELG, NativeArray<T> FACNNGOOMDP, int DPKPMBGBJLN, [Optional] T KMAOFDDCAGN) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x46B80D0", Offset = "0x46B6ED0", VA = "0x1846B80D0")]
			private void LINBPPNELHH(IEnumerable<JHOHKACMDJP> GHIDPIJCOIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x46B7F30", Offset = "0x46B6D30", VA = "0x1846B7F30")]
			private void IPHMAKPABKH(JHOHKACMDJP AJNGPNJNCMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x46B8430", Offset = "0x46B7230", VA = "0x1846B8430")]
			private FIAFOGBBHLJ MDCNDIKJJLI(int KBABCFCPFCO)
			{
				return default(FIAFOGBBHLJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x46B7D40", Offset = "0x46B6B40", VA = "0x1846B7D40")]
			public void IKNCLGLJNIL(float GCAFEIGFHPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x46B7070", Offset = "0x46B5E70", VA = "0x1846B7070")]
			private void AAEAIHKLOKE(Action OCLDIKFJHHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x46B7370", Offset = "0x46B6170", VA = "0x1846B7370")]
			private void BKBOICLMJGA(Action OCLDIKFJHHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x46B87B0", Offset = "0x46B75B0", VA = "0x1846B87B0")]
			public void NDEFGDKHPNK(float GCAFEIGFHPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x46B7FF0", Offset = "0x46B6DF0", VA = "0x1846B7FF0")]
			public void JCPBCAEBHJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x46B8370", Offset = "0x46B7170", VA = "0x1846B8370")]
			public void LKLAHJCEPCL(BLECBGGAJDL NGACNEBGENO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x46B86F0", Offset = "0x46B74F0", VA = "0x1846B86F0")]
			public void MDFDBFEKOIH(BLECBGGAJDL NGACNEBGENO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x46B70F0", Offset = "0x46B5EF0", VA = "0x1846B70F0")]
			public void ABHGFEODJGF(BLECBGGAJDL NGACNEBGENO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct GOEJGHBICHC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float GBACKOCONGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int LIDGAFCCOMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> CCAJIMNGONJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> HEADLBJGPIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> LBKCGKPDLLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<JKPEMGCCLHG> PKAPOKOCNCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> EANEFPPBNPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> JIFPBABEIBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> LLGHPKDPAAF;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x46BE7F0", Offset = "0x46BD5F0", VA = "0x1846BE7F0")]
			public static GOEJGHBICHC PEDPEIEILOF(int OIAMMMIIIHP, float GCAFEIGFHPA, NativeArray<JKPEMGCCLHG> ENAPKKAGJGP, NativeArray<float> EFDCLKPKMJB, NativeArray<int> KONHFCIBHPJ, NativeArray<int> PAKKPNJGHEL, NativeArray<int> NOCOBKICFAA, NativeArray<int> HEADLBJGPIN, NativeArray<int> LBKCGKPDLLO)
			{
				return default(GOEJGHBICHC);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x46BE360", Offset = "0x46BD160", VA = "0x1846BE360", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x46BE510", Offset = "0x46BD310", VA = "0x1846BE510")]
			private bool IFFEMCFBPKH(int CKPFCCCIOFE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x46BE330", Offset = "0x46BD130", VA = "0x1846BE330")]
			private void AGCGIAFGNGE(NativeArray<int> BAOFNAKJCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x46BE550", Offset = "0x46BD350", VA = "0x1846BE550")]
			private int KLEJFKJGENE(int OHPECNKCMHC, int ENHLFPMKFKM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x46BE440", Offset = "0x46BD240", VA = "0x1846BE440")]
			private void FBGODFHMGMG(NativeArray<int> BAOFNAKJCMF, int KCMLEODAEEO, int JMAPFIANOAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x46BE5C0", Offset = "0x46BD3C0", VA = "0x1846BE5C0")]
			private void NOEHGHCGILA(NativeArray<int> BAOFNAKJCMF, int IPNEPLIIJJE, int GOFDOAGFBIP, int ICACEDMFKJO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class KAFNPCNCLAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly DBMMILHLGJM GDJKJKEPKOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour BKOJMLFMNLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool OEMGEEBAILI;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<DOOLAEBGDFI> DGJBDMMBEPB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x51C1D0", Offset = "0x51AFD0", VA = "0x18051C1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x51C490", Offset = "0x51B290", VA = "0x18051C490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public DOOLAEBGDFI GHDMKKEKBLI
			{
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x51C4A0", Offset = "0x51B2A0", VA = "0x18051C4A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool FCLEAPCNOPH
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x46C0100", Offset = "0x46BEF00", VA = "0x1846C0100")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool OEGAOGAJONE
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x7D6B80", Offset = "0x7D5980", VA = "0x1807D6B80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x122A0A0", Offset = "0x1228EA0", VA = "0x18122A0A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string IAPKIIHBPPO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x51D010", Offset = "0x51BE10", VA = "0x18051D010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x51D020", Offset = "0x51BE20", VA = "0x18051D020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float NFDIKHPCHPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x10372D0", Offset = "0x10360D0", VA = "0x1810372D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x10371F0", Offset = "0x1035FF0", VA = "0x1810371F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x46C0550", Offset = "0x46BF350", VA = "0x1846C0550")]
			public KAFNPCNCLAM(IEnumerator<DOOLAEBGDFI> LCLABOOPDIK, Behaviour BKOJMLFMNLI, DBMMILHLGJM GDJKJKEPKOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x46C02B0", Offset = "0x46BF0B0", VA = "0x1846C02B0")]
			public DOOLAEBGDFI PDLOPMPMNJF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x46C0220", Offset = "0x46BF020", VA = "0x1846C0220")]
			public bool NALKMIJPEFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x46C0190", Offset = "0x46BEF90", VA = "0x1846C0190")]
			public void LKLAHJCEPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x46C04C0", Offset = "0x46BF2C0", VA = "0x1846C04C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1280410", Offset = "0x127F210", VA = "0x181280410")]
			[CompilerGenerated]
			private void EANHNKOMCLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class DBMMILHLGJM : FGGLCNPBIDO, HOAOHLFJCKG, GIFAJKNOCHE, EDDKJIPNMLB, IEnumerator, DOOLAEBGDFI, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private OBPCDNFPNDJ.PPKDFONAFGO KBMNGNHCIIF;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private OBPCDNFPNDJ.PPKDFONAFGO EEMAFMOGMPG
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x541180", Offset = "0x53FF80", VA = "0x180541180", Slot = "23")]
				get
				{
					return default(OBPCDNFPNDJ.PPKDFONAFGO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public OBPCDNFPNDJ.PPKDFONAFGO POKBGOELPMH
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x541180", Offset = "0x53FF80", VA = "0x180541180")]
				get
				{
					return default(OBPCDNFPNDJ.PPKDFONAFGO);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x6B71C0", Offset = "0x6B5FC0", VA = "0x1806B71C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float HGCAFFDDBJE
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xECAFD0", Offset = "0xEC9DD0", VA = "0x180ECAFD0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x46BBD20", Offset = "0x46BAB20", VA = "0x1846BBD20", Slot = "24")]
			private bool NPKAGNOBJGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x46BBD10", Offset = "0x46BAB10", VA = "0x1846BBD10", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x46BBD40", Offset = "0x46BAB40", VA = "0x1846BBD40")]
			public DBMMILHLGJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum FIAFOGBBHLJ : byte
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
		private sealed class NOCHIDGMNHD : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum KCICJCEOFME
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct KBNGIIAOLPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public OBPCDNFPNDJ.PPKDFONAFGO BGIILGNFILG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public KCICJCEOFME CECFIHLAKKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<KAFNPCNCLAM> MGBFOHMOKOF;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly KCICJCEOFME[] KEBCANECEGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly OBPCDNFPNDJ.PPKDFONAFGO GHIBGFBBGFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool LNNKFCBOHEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly KAFNPCNCLAM[] MJLMKDHILMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<KAFNPCNCLAM> NEPCKFMDBLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> DICEGMBMJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<KAFNPCNCLAM> PKCEMCCEMPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> HBKOECLKBEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool GANENMNDKIP;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public KBNGIIAOLPO[,] OEMFEMOCCJL
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x52FD70", Offset = "0x52EB70", VA = "0x18052FD70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int KGICKEDEEFA
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x46C4810", Offset = "0x46C3610", VA = "0x1846C4810")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x46C4A60", Offset = "0x46C3860", VA = "0x1846C4A60")]
			public NOCHIDGMNHD(OBPCDNFPNDJ.PPKDFONAFGO IONPBNENEGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x46C4800", Offset = "0x46C3600", VA = "0x1846C4800")]
			public void ONGHGLEECLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x46C3720", Offset = "0x46C2520", VA = "0x1846C3720")]
			public void DGDBDCMNCIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x46C42F0", Offset = "0x46C30F0", VA = "0x1846C42F0")]
			private void KEPKDDEDNFI(IReadOnlyList<KAFNPCNCLAM> BLHGAFJLKJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x46C3600", Offset = "0x46C2400", VA = "0x1846C3600")]
			public void BCBFCAFOILN(KAFNPCNCLAM LCLABOOPDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x46C3C60", Offset = "0x46C2A60", VA = "0x1846C3C60")]
			public void GBDFHAELMCL(IList<KAFNPCNCLAM> JMFDPNMMDLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x46C39E0", Offset = "0x46C27E0", VA = "0x1846C39E0")]
			public void EGFJKJPGAAE(IList<KAFNPCNCLAM> JMFDPNMMDLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x46C4000", Offset = "0x46C2E00", VA = "0x1846C4000")]
			private void JCIFFEHNDCJ(KAFNPCNCLAM LCLABOOPDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x46C3870", Offset = "0x46C2670", VA = "0x1846C3870")]
			private void EBCOPJMHLGG(IList<KAFNPCNCLAM> JMFDPNMMDLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x46C4600", Offset = "0x46C3400", VA = "0x1846C4600")]
			private FIAFOGBBHLJ NHGKHNHLMHL(KAFNPCNCLAM LCLABOOPDIK)
			{
				return default(FIAFOGBBHLJ);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x46C4750", Offset = "0x46C3550", VA = "0x1846C4750")]
			public void OLEACKIIGIG(float GCAFEIGFHPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x46C40F0", Offset = "0x46C2EF0", VA = "0x1846C40F0")]
			public void JOLNEJACOCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x46C4420", Offset = "0x46C3220", VA = "0x1846C4420")]
			private void LPNNBMPACIO(List<KAFNPCNCLAM> JMFDPNMMDLM, Stack<int> NGCMDDEEDAM, bool NOKLKAKDHLF, float CKAGCIPMPGK = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x46C3730", Offset = "0x46C2530", VA = "0x1846C3730", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x46C3EE0", Offset = "0x46C2CE0", VA = "0x1846C3EE0")]
			private void GPHFEDMFNKA(List<KAFNPCNCLAM> JMFDPNMMDLM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum JKPEMGCCLHG : byte
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
		private sealed class LLDNJIBEPAA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x51C1C0", Offset = "0x51AFC0", VA = "0x18051C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x62D7D0", Offset = "0x62C5D0", VA = "0x18062D7D0")]
			[DebuggerHidden]
			public LLDNJIBEPAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x46C1A70", Offset = "0x46C0870", VA = "0x1846C1A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x46C1AF0", Offset = "0x46C08F0", VA = "0x1846C1AF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const JKPEMGCCLHG LBJFICPFLIM = JKPEMGCCLHG.Cancelled | JKPEMGCCLHG.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly OBPCDNFPNDJ.PPKDFONAFGO[] FJHHFFOBKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NOCHIDGMNHD[] LBDJJENLHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private APIIKNLIOEI[] MPHFEIJJHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine OEOJGENEOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame MDHBECJFPCE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public OBPCDNFPNDJ.PPKDFONAFGO IOIDBGBBBDB
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5A8670", Offset = "0x5A7470", VA = "0x1805A8670")]
			[CompilerGenerated]
			get
			{
				return default(OBPCDNFPNDJ.PPKDFONAFGO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x66E5D0", Offset = "0x66D3D0", VA = "0x18066E5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FIMOFOMFJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7D6880", Offset = "0x7D5680", VA = "0x1807D6880", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1B5FDC0", Offset = "0x1B5EBC0", VA = "0x181B5FDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int KGICKEDEEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x46C86D0", Offset = "0x46C74D0", VA = "0x1846C86D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x46C72D0", Offset = "0x46C60D0", VA = "0x1846C72D0")]
		public static HOAOHLFJCKG GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x46C6DA0", Offset = "0x46C5BA0", VA = "0x1846C6DA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x46C7720", Offset = "0x46C6520", VA = "0x1846C7720", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x46C75B0", Offset = "0x46C63B0", VA = "0x1846C75B0")]
		private NOCHIDGMNHD JHOGEIJCOIG(OBPCDNFPNDJ.PPKDFONAFGO IDPNMFPNBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x90BF70", Offset = "0x90AD70", VA = "0x18090BF70")]
		private APIIKNLIOEI JPJINFDKDOA(OBPCDNFPNDJ.PPKDFONAFGO IDPNMFPNBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x46C7BE0", Offset = "0x46C69E0", VA = "0x1846C7BE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x46C7BA0", Offset = "0x46C69A0", VA = "0x1846C7BA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x46C84A0", Offset = "0x46C72A0", VA = "0x1846C84A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x46C7370", Offset = "0x46C6170", VA = "0x1846C7370")]
		private void HDMPJIIPOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x46C72B0", Offset = "0x46C60B0", VA = "0x1846C72B0")]
		private void FOCKDDEGANE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x46C72C0", Offset = "0x46C60C0", VA = "0x1846C72C0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x46C75F0", Offset = "0x46C63F0", VA = "0x1846C75F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x46C72A0", Offset = "0x46C60A0", VA = "0x1846C72A0")]
		private void FFIGHFFBJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x46C7540", Offset = "0x46C6340", VA = "0x1846C7540")]
		[IteratorStateMachine(typeof(LLDNJIBEPAA))]
		private IEnumerator ILCILLECGND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x46C7D90", Offset = "0x46C6B90", VA = "0x1846C7D90", Slot = "7")]
		public HOAOHLFJCKG Run(IEnumerator<DOOLAEBGDFI> HPHEAAIDBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x46C7DA0", Offset = "0x46C6BA0", VA = "0x1846C7DA0", Slot = "8")]
		public HOAOHLFJCKG Run(Behaviour BKOJMLFMNLI, IEnumerator<DOOLAEBGDFI> HPHEAAIDBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x46C7C60", Offset = "0x46C6A60", VA = "0x1846C7C60", Slot = "9")]
		public HOAOHLFJCKG RunJobbed(MCGPHHKEIOB BKOJMLFMNLI, IEnumerator<DOOLAEBGDFI> HPHEAAIDBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x46C7240", Offset = "0x46C6040", VA = "0x1846C7240", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x46C7FD0", Offset = "0x46C6DD0", VA = "0x1846C7FD0")]
		public void UpdateQueue(OBPCDNFPNDJ.PPKDFONAFGO BJBBGIMECCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x46C7380", Offset = "0x46C6180", VA = "0x1846C7380")]
		private void IIAIBCOLMEI(NOCHIDGMNHD FBDOIKCGFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x46C7600", Offset = "0x46C6400", VA = "0x1846C7600")]
		private void MJOMOLNNKJB(APIIKNLIOEI FBDOIKCGFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x46C8660", Offset = "0x46C7460", VA = "0x1846C8660")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class PBNFCJBOGOA
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x46C6970", Offset = "0x46C5770", VA = "0x1846C6970")]
	[PFGPCENLGFP]
	private static void KMENDFCINBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class EOPDDIBCDLI : NOGOMKAGHHC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float GAHDDMNJNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC00", Offset = "0x46BCA00", VA = "0x1846BDC00", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float IHNKGLPMINB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC40", Offset = "0x46BCA40", VA = "0x1846BDC40", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float HNOCBENCBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC50", Offset = "0x46BCA50", VA = "0x1846BDC50", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int JOHHIJAPINF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC30", Offset = "0x46BCA30", VA = "0x1846BDC30", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double PDNGKOLAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x46BDC10", Offset = "0x46BCA10", VA = "0x1846BDC10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public EOPDDIBCDLI()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MLACDHJHDFG
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] PCFDJLIAIEK;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int CNEHBAAIPJM;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int NEIKIABHABD;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger NOAFCEFHHAN;

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MLACDHJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x46C25B0", Offset = "0x46C13B0", VA = "0x1846C25B0")]
	private static string JLOFJIHEBDA(byte[] KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x46C26B0", Offset = "0x46C14B0", VA = "0x1846C26B0")]
	public static string NCFNLEDFEPP(byte[] NBHAFAAIDII, bool IGLBINIMLIE)
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
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
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

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
		private delegate List<PlayerLoopSystem> ELMKALDEFHJ(List<PlayerLoopSystem> FJEFHMHNKGM, int PIPLKOOJFNM);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct DEDJHLEADJA
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct AGKGGAEGDNL
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static OIHPFCMDIMH JAKMDBNHHGA;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x46D8010", Offset = "0x46D6610", VA = "0x1846D8010")]
				public static PlayerLoopSystem LGPLLLCEHJM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct JFEDKBKLDCI
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static OIHPFCMDIMH KKAFKEANFJJ;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x46E23C0", Offset = "0x46E09C0", VA = "0x1846E23C0")]
				public static PlayerLoopSystem LGPLLLCEHJM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct IHGDNBOFDFL
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static OIHPFCMDIMH CPENDGFHMIL;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x46E20F0", Offset = "0x46E06F0", VA = "0x1846E20F0")]
				public static PlayerLoopSystem LGPLLLCEHJM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct AGLBEOBGBIP
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static OIHPFCMDIMH AIGNHEJBPJF;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x46D81E0", Offset = "0x46D67E0", VA = "0x1846D81E0")]
				public static PlayerLoopSystem LGPLLLCEHJM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct ECFFHEKEIFK
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class BFFHEIKMPOH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public OMICPEBJLPH.CLAFLDJENHE key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
					public BFFHEIKMPOH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x46D8DD0", Offset = "0x46D73D0", VA = "0x1846D8DD0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable PJJIGPNAPEG;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x46DE140", Offset = "0x46DC740", VA = "0x1846DE140")]
				public static PlayerLoopSystem MPKKDKNFNBO(OMICPEBJLPH.CLAFLDJENHE DHLOMKIAOHC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct CLPOEBHMJHB
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class AIHPHDAIHAL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public OMICPEBJLPH.CLAFLDJENHE key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
					public AIHPHDAIHAL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x46D83B0", Offset = "0x46D69B0", VA = "0x1846D83B0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x46DB990", Offset = "0x46D9F90", VA = "0x1846DB990")]
				public static PlayerLoopSystem MPKKDKNFNBO(OMICPEBJLPH.CLAFLDJENHE DHLOMKIAOHC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FJIAJMIPCIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public FJIAJMIPCIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x46E0110", Offset = "0x46DE710", VA = "0x1846E0110")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool LIBGJHLJLNG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool KMHINDCNAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x46DD020", Offset = "0x46DB620", VA = "0x1846DD020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x46DD060", Offset = "0x46DB660", VA = "0x1846DD060")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46DBBD0", Offset = "0x46DA1D0", VA = "0x1846DBBD0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46DCE50", Offset = "0x46DB450", VA = "0x1846DCE50")]
		private static void IOFMFPLJPHH(OMICPEBJLPH.CLAFLDJENHE DHLOMKIAOHC, ref PlayerLoopSystem ALMLMKFHEKK, Type EADGEJBLBMM, Type DILMFPHEGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x46DD0A0", Offset = "0x46DB6A0", VA = "0x1846DD0A0")]
		private static void NNBHEAIDBGJ(ref PlayerLoopSystem ALMLMKFHEKK, Type EADGEJBLBMM, Type DILMFPHEGCO, ELMKALDEFHJ HNNFLBFBOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46DBAB0", Offset = "0x46DA0B0", VA = "0x1846DBAB0")]
		private static void ADDLCPFIBNF(ref PlayerLoopSystem ALMLMKFHEKK, Type EADGEJBLBMM, Type DILMFPHEGCO, PlayerLoopSystem? IOOGDFACPFF, PlayerLoopSystem? LGOMKNOAJNK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OMICPEBJLPH
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum CLAFLDJENHE
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
	public class CLAEDIALEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly CLAFLDJENHE NEPEOEDOLGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly ONCNFDNAGIM DDDCEOGLEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long KMMKOFEIKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long PEFEPEBIAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long ONKLFFGOBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int GJLLAKJGCFI;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46DB8A0", Offset = "0x46D9EA0", VA = "0x1846DB8A0")]
		public CLAEDIALEPJ(CLAFLDJENHE BMADDONAILJ, int JONLKNPNJMI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x46DB880", Offset = "0x46D9E80", VA = "0x1846DB880")]
		public void KFAJDBPIMCF(int ELMEGFPEEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46DB540", Offset = "0x46D9B40", VA = "0x1846DB540")]
		public void CLADKNBNBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46DB820", Offset = "0x46D9E20", VA = "0x1846DB820")]
		public void JPMPIFPPMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46DB5B0", Offset = "0x46D9BB0", VA = "0x1846DB5B0")]
		public void GOAGKGHHLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46DB780", Offset = "0x46D9D80", VA = "0x1846DB780")]
		public double IANMMGANPGJ(int LDGAPOMLNEJ)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int PAHCDKOKEKD = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static CLAFLDJENHE[] GJHKMLGBGCF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static CLAEDIALEPJ[] KFGFMGAHPJL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46E7F30", Offset = "0x46E6530", VA = "0x1846E7F30")]
	public static CLAEDIALEPJ AKLEFPDGEDH(CLAFLDJENHE DHLOMKIAOHC, int JONLKNPNJMI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46E8190", Offset = "0x46E6790", VA = "0x1846E8190")]
	public static CLAEDIALEPJ IOFMPAOFILF(CLAFLDJENHE DHLOMKIAOHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46E80E0", Offset = "0x46E66E0", VA = "0x1846E80E0")]
	public static void IBLFOKNBGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ONCNFDNAGIM : PNGMKIKGEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int CPICHPFICON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> HAGIHJEHIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double LIGMIPBMNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double JGHLGFPKNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double PJBNBOFNJPG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OAGNBLMKNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46E8440", Offset = "0x46E6A40", VA = "0x1846E8440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LMBNLIOALHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x46E84F0", Offset = "0x46E6AF0", VA = "0x1846E84F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double LENMBDHNBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE21460", Offset = "0xE1FA60", VA = "0x180E21460", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double DNDIPICCKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3040180", Offset = "0x303E780", VA = "0x183040180", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46E8550", Offset = "0x46E6B50", VA = "0x1846E8550")]
	public ONCNFDNAGIM(int NOKCBJONKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46E8340", Offset = "0x46E6940", VA = "0x1846E8340", Slot = "4")]
	public void BNMDGMDMFEF(double BOLPPEKOGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46E8480", Offset = "0x46E6A80", VA = "0x1846E8480", Slot = "5")]
	public void NPICCIOOEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JKCEIANJCPN : PNGMKIKGEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long IJIIKIBCCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double GEBHIDOBJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double MOPEINCKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double DHBJBOFAOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double KCIHMNOHGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double LIGMIPBMNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double JGHLGFPKNEN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DNNBIECLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double LENMBDHNBID
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3484580", Offset = "0x3482B80", VA = "0x183484580", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double DNDIPICCKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7360", Offset = "0x7B5960", VA = "0x1807B7360", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double KFDFDOHKLDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3040180", Offset = "0x303E780", VA = "0x183040180")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double KOIDHEELJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3040170", Offset = "0x303E770", VA = "0x183040170")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double LMBNLIOALHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x34844B0", Offset = "0x3482AB0", VA = "0x1834844B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46E2590", Offset = "0x46E0B90", VA = "0x1846E2590", Slot = "4")]
	public void BNMDGMDMFEF(double BOLPPEKOGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46E26B0", Offset = "0x46E0CB0", VA = "0x1846E26B0", Slot = "5")]
	public void NPICCIOOEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x46E26F0", Offset = "0x46E0CF0", VA = "0x1846E26F0")]
	public JKCEIANJCPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PNGMKIKGEAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LMBNLIOALHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double LENMBDHNBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double DNDIPICCKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNMDGMDMFEF(double BOLPPEKOGED);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPICCIOOEHF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ENOKJCHKLLF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface KPNMBCHJMOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool LCNOHGPBJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BJNNNCFMPEM();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DHLAFEDNNGI();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class ONFGBFMDNPA<TPromise, TMainThreadPromise> : KPNMBCHJMOG where TPromise : HAMIGNOLDMC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise PLEOILCHHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise KKFHBJFHKED;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise DBPDCPNLLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x26AB080", Offset = "0x26A9680", VA = "0x1826AB080")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LCNOHGPBJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x26AB030", Offset = "0x26A9630", VA = "0x1826AB030", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x26AB0E0", Offset = "0x26A96E0", VA = "0x1826AB0E0")]
		protected ONFGBFMDNPA(TPromise PLEOILCHHDJ, TMainThreadPromise NKBMCDEMOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x26AB000", Offset = "0x26A9600", VA = "0x1826AB000", Slot = "5")]
		public void BJNNNCFMPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2103F40", Offset = "0x2102540", VA = "0x182103F40", Slot = "6")]
		public void DHLAFEDNNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void HODHLAKLLIL(TPromise PLEOILCHHDJ);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void BOKIBKGFIME();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class KLENACPOHMN<T> : ONFGBFMDNPA<global::OGKKIDEDJHF<T>, global::CHOLDODOGCF<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x26AABF0", Offset = "0x26A91F0", VA = "0x1826AABF0")]
		public KLENACPOHMN(global::OGKKIDEDJHF<T> PLEOILCHHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x26AAA40", Offset = "0x26A9040", VA = "0x1826AAA40", Slot = "7")]
		protected override void HODHLAKLLIL(global::OGKKIDEDJHF<T> PLEOILCHHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x26AA9E0", Offset = "0x26A8FE0", VA = "0x1826AA9E0", Slot = "8")]
		protected override void BOKIBKGFIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x26AABC0", Offset = "0x26A91C0", VA = "0x1826AABC0")]
		[CompilerGenerated]
		private void KGCCNICABLO(T LOOEHOMEKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x26AAB90", Offset = "0x26A9190", VA = "0x1826AAB90")]
		[CompilerGenerated]
		private void JJJGBEHKMEJ(string BOAFMINDOEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class CECDCANEIOB : ONFGBFMDNPA<HAMIGNOLDMC, CANEJGJNLDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x46DB3E0", Offset = "0x46D99E0", VA = "0x1846DB3E0")]
		public CECDCANEIOB(HAMIGNOLDMC PLEOILCHHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x46DB310", Offset = "0x46D9910", VA = "0x1846DB310", Slot = "7")]
		protected override void HODHLAKLLIL(HAMIGNOLDMC PLEOILCHHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x46DB2C0", Offset = "0x46D98C0", VA = "0x1846DB2C0", Slot = "8")]
		protected override void BOKIBKGFIME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xD7EF70", Offset = "0xD7D570", VA = "0x180D7EF70")]
		[CompilerGenerated]
		private void KGCCNICABLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD63940", Offset = "0xD61F40", VA = "0x180D63940")]
		[CompilerGenerated]
		private void JJJGBEHKMEJ(string BOAFMINDOEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JBPEBEKIMLG : KPNMBCHJMOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action JLOPFCBGFOB;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LCNOHGPBJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x520FE0", Offset = "0x51F5E0", VA = "0x180520FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5DD330", Offset = "0x5DB930", VA = "0x1805DD330")]
		public JBPEBEKIMLG(Action JLOPFCBGFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xE0FC80", Offset = "0xE0E280", VA = "0x180E0FC80", Slot = "5")]
		public void BJNNNCFMPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "6")]
		public void DHLAFEDNNGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<KPNMBCHJMOG> LOIOAMJCMHO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x18AC380", Offset = "0x18AA980", VA = "0x1818AC380")]
	public static global::OGKKIDEDJHF<T> ILEKDPBHMCP<T>(this global::OGKKIDEDJHF<T> PLEOILCHHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46DEEC0", Offset = "0x46DD4C0", VA = "0x1846DEEC0")]
	public static HAMIGNOLDMC ILEKDPBHMCP(this HAMIGNOLDMC PLEOILCHHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46DEE30", Offset = "0x46DD430", VA = "0x1846DEE30")]
	public static void ILEKDPBHMCP(Action JLOPFCBGFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x18AC2C0", Offset = "0x18AA8C0", VA = "0x1818AC2C0")]
	private static global::OGKKIDEDJHF<T> EGFENJIBGIG<T>(global::OGKKIDEDJHF<T> PLEOILCHHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46DEA30", Offset = "0x46DD030", VA = "0x1846DEA30")]
	private static HAMIGNOLDMC EGFENJIBGIG(HAMIGNOLDMC PLEOILCHHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46DEFD0", Offset = "0x46DD5D0", VA = "0x1846DEFD0")]
	private static void PBCLKEBLGMK(KPNMBCHJMOG PIODPPNCJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46DEB10", Offset = "0x46DD110", VA = "0x1846DEB10")]
	private static void GKCKBAFJEDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46DF1C0", Offset = "0x46DD7C0", VA = "0x1846DF1C0")]
	private static void PJEHDEMEFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46DE980", Offset = "0x46DCF80", VA = "0x1846DE980")]
	private static void DKFHCCIKHDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CEBCELMPJJI
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KAKMOFGDIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CANEJGJNLDJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public KAKMOFGDIGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46E2730", Offset = "0x46E0D30", VA = "0x1846E2730")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x46E2720", Offset = "0x46E0D20", VA = "0x1846E2720")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DJCPOIBJPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public DJCPOIBJPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x46DD420", Offset = "0x46DBA20", VA = "0x1846DD420")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FMEOEFIANPN : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CANEJGJNLDJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public FMEOEFIANPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x46E0530", Offset = "0x46DEB30", VA = "0x1846E0530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46E0210", Offset = "0x46DE810", VA = "0x1846E0210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x46E05E0", Offset = "0x46DEBE0", VA = "0x1846E05E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x46E04E0", Offset = "0x46DEAE0", VA = "0x1846E04E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PNNGBDIJJIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CANEJGJNLDJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public PNNGBDIJJIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MKMGDLFGBLG : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CANEJGJNLDJ onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private PNNGBDIJJIG <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public MKMGDLFGBLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x46E56C0", Offset = "0x46E3CC0", VA = "0x1846E56C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x46E5A50", Offset = "0x46E4050", VA = "0x1846E5A50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string LKMEIGMDEAB = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string FDPOPKAADNJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string LHODEKCPJEA = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string LODCFELEICL = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string JKFEJIAKIMD = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float OEOKLFNHDLO = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static HAMIGNOLDMC HBLIAIIBOIK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation JCCDNBNBHHP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static HAMIGNOLDMC HGFFBLKCOPE;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string PMFFDPBKFHN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority EEEDCGFLALI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool FGLCGAKKOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x46DAE50", Offset = "0x46D9450", VA = "0x1846DAE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool FOIOGOGKFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x46DB260", Offset = "0x46D9860", VA = "0x1846DB260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool AOMHIKIMKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x46DAD60", Offset = "0x46D9360", VA = "0x1846DAD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MEODGCFMAND
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x46DB1B0", Offset = "0x46D97B0", VA = "0x1846DB1B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x46DB100", Offset = "0x46D9700", VA = "0x1846DB100")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x46DAEF0", Offset = "0x46D94F0", VA = "0x1846DAEF0")]
	[BFFCGBPBDIO(MHIIHFJKCKA.EnteredEditModeNextFrame, 0)]
	private static void DNJOEEEMBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x46DAFA0", Offset = "0x46D95A0", VA = "0x1846DAFA0")]
	public static HAMIGNOLDMC MLGNMNJIMEG(string ALEBKBBAMAB, LoadSceneMode NPDMJFJLLHH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x46DAB30", Offset = "0x46D9130", VA = "0x1846DAB30")]
	public static HAMIGNOLDMC BMILGHMKBFA(string ALEBKBBAMAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x46DAAA0", Offset = "0x46D90A0", VA = "0x1846DAAA0")]
	[IteratorStateMachine(typeof(FMEOEFIANPN))]
	private static IEnumerator<KBDFKOBHGAA> BJEHCEHDDAP(string ALEBKBBAMAB, CANEJGJNLDJ HLBKNKFKOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x46DADC0", Offset = "0x46D93C0", VA = "0x1846DADC0")]
	[IteratorStateMachine(typeof(MKMGDLFGBLG))]
	private static IEnumerator<KBDFKOBHGAA> CJBNJIFDOCA(string ALEBKBBAMAB, LoadSceneMode NPDMJFJLLHH, CANEJGJNLDJ HLBKNKFKOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class IBOBEJICMAB
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46E1AA0", Offset = "0x46E00A0", VA = "0x1846E1AA0")]
	public static IDisposable GJLFNNGAMDD(this LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46E1B20", Offset = "0x46E0120", VA = "0x1846E1B20")]
	public static IDisposable GJLFNNGAMDD(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46E1A30", Offset = "0x46E0030", VA = "0x1846E1A30")]
	public static IDisposable GGHPLHDBDPK(this LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x46E1CB0", Offset = "0x46E02B0", VA = "0x1846E1CB0")]
	public static IDisposable JJFJPEGJMLI(this LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x46E1E90", Offset = "0x46E0490", VA = "0x1846E1E90")]
	public static IDisposable MJODDAINJJK(this LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46E2000", Offset = "0x46E0600", VA = "0x1846E2000")]
	public static IDisposable OALCGANFIDH(this LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x46E1E20", Offset = "0x46E0420", VA = "0x1846E1E20")]
	public static IDisposable MEEJKAINLEO(this LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x46E1810", Offset = "0x46DFE10", VA = "0x1846E1810")]
	public static IDisposable CDHGLABNGOK(this LELHKPJPEMH POJPEFNIBPF, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x46E1D20", Offset = "0x46E0320", VA = "0x1846E1D20")]
	public static IDisposable LHCMDDOMFFB(this LELHKPJPEMH POJPEFNIBPF, float AFHBMPHLNHL, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x46E1790", Offset = "0x46DFD90", VA = "0x1846E1790")]
	public static IDisposable BCINMLJLLAH(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x46E1C30", Offset = "0x46E0230", VA = "0x1846E1C30")]
	public static IDisposable JDMOADPLAHH(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46E2070", Offset = "0x46E0670", VA = "0x1846E2070")]
	public static IDisposable OEIGNKEFGJD(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46E18A0", Offset = "0x46DFEA0", VA = "0x1846E18A0")]
	public static IDisposable CLBJOCJLNFF(this LELHKPJPEMH POJPEFNIBPF, float AFHBMPHLNHL, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x46E19B0", Offset = "0x46DFFB0", VA = "0x1846E19B0")]
	public static IDisposable FHPOIOAICBO(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46E1F80", Offset = "0x46E0580", VA = "0x1846E1F80")]
	public static IDisposable NIMDECNHHBO(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x46E1930", Offset = "0x46DFF30", VA = "0x1846E1930")]
	public static IDisposable CMCKODCBNJD(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46E1BA0", Offset = "0x46E01A0", VA = "0x1846E1BA0")]
	public static IDisposable GJLOJHAEIBI(this LELHKPJPEMH POJPEFNIBPF, float AFHBMPHLNHL, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x46E1F00", Offset = "0x46E0500", VA = "0x1846E1F00")]
	public static IDisposable MLLFGLJKAJB(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46E1DA0", Offset = "0x46E03A0", VA = "0x1846E1DA0")]
	public static IDisposable LIMHHJJKJLP(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x46E1710", Offset = "0x46DFD10", VA = "0x1846E1710")]
	public static IDisposable AJDCOOAPKGJ(this LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OCIPENMFNBE
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x46E7230", Offset = "0x46E5830", VA = "0x1846E7230")]
	public static IDisposable APJPCFJAHCK(this MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x46E71B0", Offset = "0x46E57B0", VA = "0x1846E71B0")]
	public static IDisposable APJPCFJAHCK(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x46E75D0", Offset = "0x46E5BD0", VA = "0x1846E75D0")]
	public static IDisposable ELGGEIDNLDL(this MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46E7340", Offset = "0x46E5940", VA = "0x1846E7340")]
	public static IDisposable BLNKGCOINBG(this MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x46E7B40", Offset = "0x46E6140", VA = "0x1846E7B40")]
	public static IDisposable KJFFMDOBFDP(this MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x46E7560", Offset = "0x46E5B60", VA = "0x1846E7560")]
	public static IDisposable DELBCKMGEEL(this MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46E7A40", Offset = "0x46E6040", VA = "0x1846E7A40")]
	public static IDisposable IELAMIKDFFJ(this MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46E7640", Offset = "0x46E5C40", VA = "0x1846E7640")]
	public static IDisposable FDLKMLBICJC(this MonoBehaviour LAHOEEHIIOK, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46E7AB0", Offset = "0x46E60B0", VA = "0x1846E7AB0")]
	public static IDisposable KIMMGHMCGIG(this MonoBehaviour LAHOEEHIIOK, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x46E7920", Offset = "0x46E5F20", VA = "0x1846E7920")]
	public static IDisposable HPFNLCMNDOC(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x46E7440", Offset = "0x46E5A40", VA = "0x1846E7440")]
	public static IDisposable CIMKOHPINCB(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x46E7D80", Offset = "0x46E6380", VA = "0x1846E7D80")]
	public static IDisposable NNAHLOKHDDF(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x46E73B0", Offset = "0x46E59B0", VA = "0x1846E73B0")]
	public static IDisposable CCNAHOJJFLD(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46E76E0", Offset = "0x46E5CE0", VA = "0x1846E76E0")]
	public static IDisposable FOLGFEMANIN(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46E7800", Offset = "0x46E5E00", VA = "0x1846E7800")]
	public static IDisposable GFJHGOMAADG(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46E7C50", Offset = "0x46E6250", VA = "0x1846E7C50")]
	public static IDisposable MPJCLBNNMFN(this MonoBehaviour LAHOEEHIIOK, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x46E74D0", Offset = "0x46E5AD0", VA = "0x1846E74D0")]
	public static IDisposable CLOKEGHLMIE(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46E7890", Offset = "0x46E5E90", VA = "0x1846E7890")]
	public static IDisposable HHBDCMPDBAG(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46E79B0", Offset = "0x46E5FB0", VA = "0x1846E79B0")]
	public static IDisposable IAPPDJLDLDE(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46E7BB0", Offset = "0x46E61B0", VA = "0x1846E7BB0")]
	public static IDisposable MHDENNMDODP(this MonoBehaviour LAHOEEHIIOK, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46E72B0", Offset = "0x46E58B0", VA = "0x1846E72B0")]
	public static IDisposable BIFFNCJKDDA(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46E7CF0", Offset = "0x46E62F0", VA = "0x1846E7CF0")]
	public static IDisposable NMLDDKPEDKP(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46E7770", Offset = "0x46E5D70", VA = "0x1846E7770")]
	public static IDisposable GAFPHCBFAKC(this MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BEFJNMMEHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BDGAOGGOPCP : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FFDEBDDLCFI.FHDHOFKEFAO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private MHHGEAGGCCJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public BDGAOGGOPCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x46D85A0", Offset = "0x46D6BA0", VA = "0x1846D85A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x46D8660", Offset = "0x46D6C60", VA = "0x1846D8660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class AMHPJDPLIPE : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FFDEBDDLCFI.FHDHOFKEFAO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private MHHGEAGGCCJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public AMHPJDPLIPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x46D8470", Offset = "0x46D6A70", VA = "0x1846D8470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x46D8550", Offset = "0x46D6B50", VA = "0x1846D8550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46D86B0", Offset = "0x46D6CB0", VA = "0x1846D86B0")]
	public static JHKLLFHDHJL APJPCFJAHCK(Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46D88B0", Offset = "0x46D6EB0", VA = "0x1846D88B0")]
	public static JHKLLFHDHJL APJPCFJAHCK(Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x46D89A0", Offset = "0x46D6FA0", VA = "0x1846D89A0")]
	public static JHKLLFHDHJL APJPCFJAHCK(Behaviour POJPEFNIBPF, Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46D87A0", Offset = "0x46D6DA0", VA = "0x1846D87A0")]
	public static JHKLLFHDHJL APJPCFJAHCK(Behaviour POJPEFNIBPF, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46D8CC0", Offset = "0x46D72C0", VA = "0x1846D8CC0")]
	public static JHKLLFHDHJL GJLFNNGAMDD(LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46D8BB0", Offset = "0x46D71B0", VA = "0x1846D8BB0")]
	public static JHKLLFHDHJL GJLFNNGAMDD(LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46D8AB0", Offset = "0x46D70B0", VA = "0x1846D8AB0")]
	[IteratorStateMachine(typeof(BDGAOGGOPCP))]
	private static IEnumerator<KBDFKOBHGAA> CJPNAMENPKB(FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH, Action GFJDANJBBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x46D8B30", Offset = "0x46D7130", VA = "0x1846D8B30")]
	[IteratorStateMachine(typeof(AMHPJDPLIPE))]
	private static IEnumerator<KBDFKOBHGAA> CJPNAMENPKB(FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH, Action<float> GFJDANJBBJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class BOGFENAMNCI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class HBFFEGDIDEJ : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public FFDEBDDLCFI.FHDHOFKEFAO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NIHJJLOPNKK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public HBFFEGDIDEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x46E09C0", Offset = "0x46DEFC0", VA = "0x1846E09C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x46E0AD0", Offset = "0x46DF0D0", VA = "0x1846E0AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46DA7F0", Offset = "0x46D8DF0", VA = "0x1846DA7F0")]
	public static JHKLLFHDHJL APJPCFJAHCK(float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46DA730", Offset = "0x46D8D30", VA = "0x1846DA730")]
	public static JHKLLFHDHJL APJPCFJAHCK(MonoBehaviour LAHOEEHIIOK, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46DA950", Offset = "0x46D8F50", VA = "0x1846DA950")]
	public static JHKLLFHDHJL HGDAJMEMADP(LELHKPJPEMH POJPEFNIBPF, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, bool PNBMLBLLDDO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46DA8B0", Offset = "0x46D8EB0", VA = "0x1846DA8B0")]
	[IteratorStateMachine(typeof(HBFFEGDIDEJ))]
	private static IEnumerator<KBDFKOBHGAA> CJPNAMENPKB(float AFHBMPHLNHL, FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH, Action<float> GFJDANJBBJD, bool PNBMLBLLDDO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GPFHCCOAMGC
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LPHICONKMGB : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FFDEBDDLCFI.FHDHOFKEFAO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public LPHICONKMGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x46E4FA0", Offset = "0x46E35A0", VA = "0x1846E4FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x46E5050", Offset = "0x46E3650", VA = "0x1846E5050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x46E0940", Offset = "0x46DEF40", VA = "0x1846E0940")]
	[IteratorStateMachine(typeof(LPHICONKMGB))]
	private static IEnumerator<KBDFKOBHGAA> JIOJDFLGDDE(FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, Func<bool> OKBKPNJGBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x46E07E0", Offset = "0x46DEDE0", VA = "0x1846E07E0")]
	public static JHKLLFHDHJL IJIDPOKOAOL(this MonoBehaviour LAHOEEHIIOK, Func<bool> OKBKPNJGBAE, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA = FFDEBDDLCFI.FHDHOFKEFAO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HGFIGFAEBHP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MPOOMFEKEOG : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public FFDEBDDLCFI.FHDHOFKEFAO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public MPOOMFEKEOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x46E5AA0", Offset = "0x46E40A0", VA = "0x1846E5AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x46E5B60", Offset = "0x46E4160", VA = "0x1846E5B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OJODCLECFMM : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FFDEBDDLCFI.FHDHOFKEFAO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private KBDFKOBHGAA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public OJODCLECFMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x46E7E10", Offset = "0x46E6410", VA = "0x1846E7E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x46E7EE0", Offset = "0x46E64E0", VA = "0x1846E7EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x46E0DA0", Offset = "0x46DF3A0", VA = "0x1846E0DA0")]
	[IteratorStateMachine(typeof(MPOOMFEKEOG))]
	private static IEnumerator<KBDFKOBHGAA> EHOBCCDIDPO(float CNCOADFHGCC, FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x46E1540", Offset = "0x46DFB40", VA = "0x1846E1540")]
	[IteratorStateMachine(typeof(OJODCLECFMM))]
	private static IEnumerator<KBDFKOBHGAA> MCKFGKBLAOB(float CNCOADFHGCC, FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x46E1060", Offset = "0x46DF660", VA = "0x1846E1060")]
	public static IDisposable IAFBCBANDFM(this MonoBehaviour LAHOEEHIIOK, float CNCOADFHGCC, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x46E15D0", Offset = "0x46DFBD0", VA = "0x1846E15D0")]
	public static JHKLLFHDHJL MCOBGLDDEAC(this MonoBehaviour LAHOEEHIIOK, float CNCOADFHGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x46E11B0", Offset = "0x46DF7B0", VA = "0x1846E11B0")]
	public static JHKLLFHDHJL IAFBCBANDFM(this MonoBehaviour LAHOEEHIIOK, float CNCOADFHGCC, FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x46E1310", Offset = "0x46DF910", VA = "0x1846E1310")]
	public static JHKLLFHDHJL IOBPGPJGJAH(this MonoBehaviour LAHOEEHIIOK, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x46E0B70", Offset = "0x46DF170", VA = "0x1846E0B70")]
	public static JHKLLFHDHJL CNPIAIFOHJP(this MonoBehaviour LAHOEEHIIOK, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x46E0F40", Offset = "0x46DF540", VA = "0x1846E0F40")]
	public static JHKLLFHDHJL GKBOCLCMENO(this MonoBehaviour LAHOEEHIIOK, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x46E16D0", Offset = "0x46DFCD0", VA = "0x1846E16D0")]
	public static JHKLLFHDHJL POCHCOKOHJO(this MonoBehaviour LAHOEEHIIOK, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46E0B60", Offset = "0x46DF160", VA = "0x1846E0B60")]
	public static JHKLLFHDHJL CBALNNLKMMM(this MonoBehaviour LAHOEEHIIOK, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x46E0F50", Offset = "0x46DF550", VA = "0x1846E0F50")]
	private static JHKLLFHDHJL HBKFPBGJMHC(MonoBehaviour LAHOEEHIIOK, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x46E1320", Offset = "0x46DF920", VA = "0x1846E1320")]
	public static JHKLLFHDHJL JBMNOFPIGLG(this MonoBehaviour LAHOEEHIIOK, float PBMCNFCAFAL, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x46E0E30", Offset = "0x46DF430", VA = "0x1846E0E30")]
	public static JHKLLFHDHJL FMJLFGHMKLN(this MonoBehaviour LAHOEEHIIOK, float PBMCNFCAFAL, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46E0C90", Offset = "0x46DF290", VA = "0x1846E0C90")]
	public static JHKLLFHDHJL DMICBJEICCE(this MonoBehaviour LAHOEEHIIOK, float PBMCNFCAFAL, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x46E1430", Offset = "0x46DFA30", VA = "0x1846E1430")]
	public static JHKLLFHDHJL KFLHKAJBIPA(this MonoBehaviour LAHOEEHIIOK, float PBMCNFCAFAL, Action GGNAIHCMNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x46E0B80", Offset = "0x46DF180", VA = "0x1846E0B80")]
	public static JHKLLFHDHJL DAFNEBPNDKA(this MonoBehaviour LAHOEEHIIOK, float PBMCNFCAFAL, Action GGNAIHCMNKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KMKCCACEBLC : NKFOBLKIMIK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NDGHJKFNLLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public KMKCCACEBLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public NDGHJKFNLLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x46E16E0", Offset = "0x46DFCE0", VA = "0x1846E16E0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HKPAFEAJNMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public KMKCCACEBLC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
		public HKPAFEAJNMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x46E16E0", Offset = "0x46DFCE0", VA = "0x1846E16E0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float IABOKAIMNNC;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x46DE890", Offset = "0x46DCE90", VA = "0x1846DE890")]
	public KMKCCACEBLC(Behaviour POJPEFNIBPF, float IABOKAIMNNC, [Optional] Action AADGPHGOIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x46E4C50", Offset = "0x46E3250", VA = "0x1846E4C50", Slot = "9")]
	protected override bool APDMHEHLHCJ(Action JLOPFCBGFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x46E4D30", Offset = "0x46E3330", VA = "0x1846E4D30", Slot = "10")]
	protected override bool EPIEEACKANL(Action JLOPFCBGFOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ICPCCAAMHKP
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool IGHAFNPEFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JNAIKKHMJOB;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIDHIJFNGDG(bool LKEANPIHPFE = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BIDHIJFNGDG(Action JLOPFCBGFOB, bool LKEANPIHPFE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class NKFOBLKIMIK : ICPCCAAMHKP
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class CHDBCAEKNBP : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public CHDBCAEKNBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x46DB450", Offset = "0x46D9A50", VA = "0x1846DB450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x46DB4F0", Offset = "0x46D9AF0", VA = "0x1846DB4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour POJPEFNIBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action AADGPHGOIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private IDAIALKIMHE LGFHCFLPOKC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IGHAFNPEFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x63C350", Offset = "0x63A950", VA = "0x18063C350", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JNAIKKHMJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x46E6420", Offset = "0x46E4A20", VA = "0x1846E6420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x46E62D0", Offset = "0x46E48D0", VA = "0x1846E62D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x46E66A0", Offset = "0x46E4CA0", VA = "0x1846E66A0")]
	protected NKFOBLKIMIK(Behaviour POJPEFNIBPF, [Optional] Action AADGPHGOIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x46E61A0", Offset = "0x46E47A0", VA = "0x1846E61A0", Slot = "7")]
	public bool BIDHIJFNGDG(bool LKEANPIHPFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x46E6200", Offset = "0x46E4800", VA = "0x1846E6200", Slot = "8")]
	public bool BIDHIJFNGDG(Action JLOPFCBGFOB, bool LKEANPIHPFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool APDMHEHLHCJ(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EPIEEACKANL(Action JLOPFCBGFOB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x46E6250", Offset = "0x46E4850", VA = "0x1846E6250")]
	protected void FAFPPJPJALD(Action JLOPFCBGFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x46E64C0", Offset = "0x46E4AC0", VA = "0x1846E64C0")]
	protected HAMIGNOLDMC PMLODIMGCFB(float PHDIOLHJCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x46E6370", Offset = "0x46E4970", VA = "0x1846E6370")]
	private void LGFILCBILMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x46E6270", Offset = "0x46E4870", VA = "0x1846E6270")]
	[IteratorStateMachine(typeof(CHDBCAEKNBP))]
	private static IEnumerator<KBDFKOBHGAA> FOEIGLBGHDN(float PHDIOLHJCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x46E63E0", Offset = "0x46E49E0", VA = "0x1846E63E0")]
	[CompilerGenerated]
	private void MEENHIGIKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ADNICPHMGLA : NKFOBLKIMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float FOFBAJJHMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int FLCDDIJBNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float MEDPJHKBBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] GGMPEAJPHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int DENFLAKGBKB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BGMLMBKNDAC KOMCCMEIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x54C380", Offset = "0x54A980", VA = "0x18054C380")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5E0570", Offset = "0x5DEB70", VA = "0x1805E0570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x46D7EE0", Offset = "0x46D64E0", VA = "0x1846D7EE0")]
	public ADNICPHMGLA(Behaviour POJPEFNIBPF, float MMGKEMFPFBN, int FLCDDIJBNLJ, [Optional] Action AADGPHGOIIL, float MEDPJHKBBBM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x520EC0", Offset = "0x51F4C0", VA = "0x180520EC0", Slot = "9")]
	protected override bool APDMHEHLHCJ(Action JLOPFCBGFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x46D7C30", Offset = "0x46D6230", VA = "0x1846D7C30", Slot = "10")]
	protected override bool EPIEEACKANL(Action JLOPFCBGFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x46D7E50", Offset = "0x46D6450", VA = "0x1846D7E50")]
	private void MBGPGEJDPEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EIAHFHCBJHK : NKFOBLKIMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float IABOKAIMNNC;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x46DE890", Offset = "0x46DCE90", VA = "0x1846DE890")]
	public EIAHFHCBJHK(Behaviour POJPEFNIBPF, float IABOKAIMNNC, [Optional] Action AADGPHGOIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x520EC0", Offset = "0x51F4C0", VA = "0x180520EC0", Slot = "9")]
	protected override bool APDMHEHLHCJ(Action JLOPFCBGFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x46DE850", Offset = "0x46DCE50", VA = "0x1846DE850", Slot = "10")]
	protected override bool EPIEEACKANL(Action JLOPFCBGFOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class DLIDCHNBKEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GDKCDGMLHEF : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public GDKCDGMLHEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x46E0690", Offset = "0x46DEC90", VA = "0x1846E0690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x46E0790", Offset = "0x46DED90", VA = "0x1846E0790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JHKLLFHDHJL AOFPCHFALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private LELHKPJPEMH POJPEFNIBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action GFJDANJBBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> DKOHIBPGOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float PHFNILKBCFK;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x46DDDC0", Offset = "0x46DC3C0", VA = "0x1846DDDC0")]
	public DLIDCHNBKEO(LELHKPJPEMH POJPEFNIBPF, Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x46DDF80", Offset = "0x46DC580", VA = "0x1846DDF80")]
	public DLIDCHNBKEO(LELHKPJPEMH POJPEFNIBPF, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x46DDC40", Offset = "0x46DC240", VA = "0x1846DDC40")]
	public DLIDCHNBKEO(LELHKPJPEMH POJPEFNIBPF, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x46DD450", Offset = "0x46DBA50", VA = "0x1846DD450")]
	private void APJPCFJAHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x46DD790", Offset = "0x46DBD90", VA = "0x1846DD790")]
	private void ECMOCBNLCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x46DD5E0", Offset = "0x46DBBE0", VA = "0x1846DD5E0")]
	private void CGFPAIJGONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x46DDB10", Offset = "0x46DC110", VA = "0x1846DDB10")]
	private void PHPDDFBMKLH(string BOAFMINDOEO, Action KHGEFCDNMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x46DDA20", Offset = "0x46DC020", VA = "0x1846DDA20")]
	[IteratorStateMachine(typeof(GDKCDGMLHEF))]
	private IEnumerator<KBDFKOBHGAA> JEMJKLFLHIJ(Action KHGEFCDNMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x46DD730", Offset = "0x46DBD30", VA = "0x1846DD730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x46DDA90", Offset = "0x46DC090", VA = "0x1846DDA90")]
	[CompilerGenerated]
	private void NAIEILJNHEN(string JBAJFCDPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x46DD9A0", Offset = "0x46DBFA0", VA = "0x1846DD9A0")]
	[CompilerGenerated]
	private void HPJPCKOOEIA(string JBAJFCDPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x46DD920", Offset = "0x46DBF20", VA = "0x1846DD920")]
	[CompilerGenerated]
	private void HCFBBHJKBAI(string JBAJFCDPKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class FCDHDLBCCHL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class KPJOINABFJM : IEnumerator<KBDFKOBHGAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private KBDFKOBHGAA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private KBDFKOBHGAA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
		[DebuggerHidden]
		public KPJOINABFJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x46E4E10", Offset = "0x46E3410", VA = "0x1846E4E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x46E4F10", Offset = "0x46E3510", VA = "0x1846E4F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private JHKLLFHDHJL AOFPCHFALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour LAHOEEHIIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action GFJDANJBBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> DKOHIBPGOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float PHFNILKBCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool PNBMLBLLDDO;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x46DFBB0", Offset = "0x46DE1B0", VA = "0x1846DFBB0")]
	public FCDHDLBCCHL(MonoBehaviour LAHOEEHIIOK, Action GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x46DFD70", Offset = "0x46DE370", VA = "0x1846DFD70")]
	public FCDHDLBCCHL(MonoBehaviour LAHOEEHIIOK, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x46DFF30", Offset = "0x46DE530", VA = "0x1846DFF30")]
	public FCDHDLBCCHL(MonoBehaviour LAHOEEHIIOK, float AFHBMPHLNHL, Action<float> GFJDANJBBJD, FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA, bool PNBMLBLLDDO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x46DF440", Offset = "0x46DDA40", VA = "0x1846DF440")]
	private void APJPCFJAHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x46DF800", Offset = "0x46DDE00", VA = "0x1846DF800")]
	private void ECMOCBNLCBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x46DF650", Offset = "0x46DDC50", VA = "0x1846DF650")]
	private void CGFPAIJGONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x46DFA80", Offset = "0x46DE080", VA = "0x1846DFA80")]
	private void PHPDDFBMKLH(string BOAFMINDOEO, Action KHGEFCDNMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x46DF990", Offset = "0x46DDF90", VA = "0x1846DF990")]
	[IteratorStateMachine(typeof(KPJOINABFJM))]
	private IEnumerator<KBDFKOBHGAA> JEMJKLFLHIJ(Action KHGEFCDNMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x46DF7A0", Offset = "0x46DDDA0", VA = "0x1846DF7A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x46DF3C0", Offset = "0x46DD9C0", VA = "0x1846DF3C0")]
	[CompilerGenerated]
	private void ANMCBFENABF(string JBAJFCDPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x46DF5D0", Offset = "0x46DDBD0", VA = "0x1846DF5D0")]
	[CompilerGenerated]
	private void BIINMCNAJPH(string JBAJFCDPKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x46DFA00", Offset = "0x46DE000", VA = "0x1846DFA00")]
	[CompilerGenerated]
	private void LIEHBHLLAIC(string JBAJFCDPKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface OIFIEDFGCDN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int NFBJLKNIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IJBKGJABKNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IJBKGJABKNP EKACNINBPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action IDCNMGFPNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool AKLNNMMMAKB;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DD330", Offset = "0x5DB930", VA = "0x1805DD330")]
	public IJBKGJABKNP(Action IDCNMGFPNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x46E22C0", Offset = "0x46E08C0", VA = "0x1846E22C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OFIFPPCINHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T KBCFGEEMGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JKHNKNHCAII(Action<T> CKMFCPDGPIN);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable JKHNKNHCAII(UnityEngine.Object POJPEFNIBPF, Action<T> CKMFCPDGPIN);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FBLNIODEODP<T> : global::OFIFPPCINHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T KBCFGEEMGKN
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
public class PFBNIKHNEGJ<T> : global::FBLNIODEODP<T>, global::OFIFPPCINHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EGFIPAPPOPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::PFBNIKHNEGJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::GCDFBPJEDJL<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x184D800", Offset = "0x184BE00", VA = "0x18184D800")]
		public EGFIPAPPOPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C68C10", Offset = "0x3C67210", VA = "0x183C68C10")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject HBBNJICAIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::GCDFBPJEDJL<UnityEngine.Object, Action<T>>> NMDIHHKIICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T EJJKFHGADBB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object KLKIJAGHIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3C72D80", Offset = "0x3C71380", VA = "0x183C72D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T KBCFGEEMGKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x643F70", Offset = "0x642570", VA = "0x180643F70", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C73010", Offset = "0x3C71610", VA = "0x183C73010", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3C73730", Offset = "0x3C71D30", VA = "0x183C73730")]
	private static bool FPGNEDFDIOG(T CPNCDDHAPNF, T KFLJJIMMFKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x336E470", Offset = "0x336CA70", VA = "0x18336E470")]
	public PFBNIKHNEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3C73B00", Offset = "0x3C72100", VA = "0x183C73B00")]
	public PFBNIKHNEGJ(T ODAKLCDPGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3C73710", Offset = "0x3C71D10", VA = "0x183C73710")]
	public void FKADKAPABON(T NBHLAMFDLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3C737D0", Offset = "0x3C71DD0", VA = "0x183C737D0", Slot = "7")]
	public IDisposable JKHNKNHCAII(Action<T> CKMFCPDGPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3C73840", Offset = "0x3C71E40", VA = "0x183C73840", Slot = "8")]
	public IDisposable JKHNKNHCAII(UnityEngine.Object POJPEFNIBPF, Action<T> CKMFCPDGPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3C73070", Offset = "0x3C71670", VA = "0x183C73070")]
	private void CGDHDAEJLCL()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<MEIEDPJCKCH, Scheduler>, MEIEDPJCKCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class NPDENHLMFPM : OIFIEDFGCDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public KMCEFFPNMNF AMGKGKAGHGP;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int NFBJLKNIIFF
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x520ED0", Offset = "0x51F4D0", VA = "0x180520ED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x520EE0", Offset = "0x51F4E0", VA = "0x180520EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x46E6E80", Offset = "0x46E5480", VA = "0x1846E6E80")]
			public static KBDFKOBHGAA CLIEIAALPAD(IEnumerator<KBDFKOBHGAA> BMJCNMPCDFF, MGEMNCGONEK IKPCHBIFCLH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x46E6DA0", Offset = "0x46E53A0", VA = "0x1846E6DA0")]
			public KBDFKOBHGAA CLIEIAALPAD(MGEMNCGONEK[] EEPPHENEFAL, IEnumerator<KBDFKOBHGAA>[] KCMLNLJGACH, KBDFKOBHGAA[] GMGNABOIAEG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x46E6FE0", Offset = "0x46E55E0", VA = "0x1846E6FE0")]
			public void MAPIAFLLHJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x46E70E0", Offset = "0x46E56E0", VA = "0x1846E70E0")]
			public void LHLMPCONJFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x46E7010", Offset = "0x46E5610", VA = "0x1846E7010")]
			public void HOMHEMMJEJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x46E6FE0", Offset = "0x46E55E0", VA = "0x1846E6FE0")]
			public void DHLAFEDNNGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public NPDENHLMFPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class KMCEFFPNMNF
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct DDIGFOIPBNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public NPDENHLMFPM ANCEDKIPADK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public LELHKPJPEMH JPHFENPKJAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public MGEMNCGONEK IDNLEEMOIOH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<KBDFKOBHGAA> KABFOGLLOGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public KBDFKOBHGAA OKOJOKOGKNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public LGAEPPCBIFM MAPJAOBMDJL;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct GMLFECCMPKB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public FFDEBDDLCFI.FHDHOFKEFAO CPNPAFAEBHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<DDIGFOIPBNK> PECKIFJMEPI;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class NNGHHNOKFDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KMCEFFPNMNF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public LELHKPJPEMH context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public NPDENHLMFPM routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public LGAEPPCBIFM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public MGEMNCGONEK promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public KBDFKOBHGAA currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<KBDFKOBHGAA> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
				public NNGHHNOKFDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x46E66F0", Offset = "0x46E4CF0", VA = "0x1846E66F0")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class LGBAJKFHIEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public NPDENHLMFPM schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public KMCEFFPNMNF <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
				public LGBAJKFHIEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x46E4F60", Offset = "0x46E3560", VA = "0x1846E4F60")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class FIEAHKLPHGN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public NPDENHLMFPM schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public KMCEFFPNMNF <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
				public FIEAHKLPHGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x46E00D0", Offset = "0x46DE6D0", VA = "0x1846E00D0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class HDMJMMMOMMB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public NPDENHLMFPM schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public KMCEFFPNMNF <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
				public HDMJMMMOMMB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x46E0B20", Offset = "0x46DF120", VA = "0x1846E0B20")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] ILLNDPEMBKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<LGAEPPCBIFM> JKHNJCLINPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> GEMHMJEKDJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> FNBGHDFPOOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> KIEIBPINAON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> LKDFOEDNGJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> AFCJCDAMJND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> FDGHNBMHNIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private NPDENHLMFPM[] HPHCNHPHHNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private MGEMNCGONEK[] EEPPHENEFAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private LELHKPJPEMH[] FCMDABGIBAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<KBDFKOBHGAA>[] IMOJPLGOCKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private KBDFKOBHGAA[] NLFGADPBFOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int KPDKBFJLKFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int FMHNJGMGKLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int BFCPKGIHEIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float ADFCOONEMBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private MBENEFCLJCO BFFGADJKLGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle JJEGJBFJADO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<NPDENHLMFPM> OCEIGPDOPLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool HHPDBBHFHIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> GHGOLDIJODM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> MPNCOAACEGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool OGEBOHOAPHD;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public GMLFECCMPKB[] LMPHJDMCKNN
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xB2E880", Offset = "0xB2CE80", VA = "0x180B2E880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int FOHENPEEPCN
			{
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x89F2B0", Offset = "0x89D8B0", VA = "0x18089F2B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x46E3A20", Offset = "0x46E2020", VA = "0x1846E3A20")]
			private static int IJJBLKNDHLJ(FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x46E4700", Offset = "0x46E2D00", VA = "0x1846E4700")]
			public KMCEFFPNMNF(FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x46E3A50", Offset = "0x46E2050", VA = "0x1846E3A50")]
			private void KFFNEJKCBOM(ref int HAAJGKNHFCC, int OOLCBHKGBMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x46E3800", Offset = "0x46E1E00", VA = "0x1846E3800")]
			public void GKPMCIIACOD(LELHKPJPEMH POJPEFNIBPF, KBDFKOBHGAA APEENPNFJKO, IEnumerator<KBDFKOBHGAA> BMJCNMPCDFF, MGEMNCGONEK IKPCHBIFCLH, [Optional] NPDENHLMFPM OOJICDPEPDD, LGAEPPCBIFM MAAMBBMJNJC = LGAEPPCBIFM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x46E4090", Offset = "0x46E2690", VA = "0x1846E4090")]
			public void PDNKMCNCONN(IEnumerable<DDIGFOIPBNK> EJMIKFLLMDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x46E4280", Offset = "0x46E2880", VA = "0x1846E4280")]
			private DDIGFOIPBNK PMLLBLFPIOG(int NHAIMJPCGHK)
			{
				return default(DDIGFOIPBNK);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x46E3CA0", Offset = "0x46E22A0", VA = "0x1846E3CA0")]
			private void NGGAAGLDDKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x18FA480", Offset = "0x18F8A80", VA = "0x1818FA480")]
			private static void GAKAFDJDLDI<T>(int NHAIMJPCGHK, T[] BCHBPIADJGK, int IFBIFKFKIDI, [Optional] T HLKGDPFOMMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x18FA460", Offset = "0x18F8A60", VA = "0x1818FA460")]
			private static void GAKAFDJDLDI<T>(int NHAIMJPCGHK, NativeArray<T> BCHBPIADJGK, int IFBIFKFKIDI, [Optional] T HLKGDPFOMMA) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x46E2C80", Offset = "0x46E1280", VA = "0x1846E2C80")]
			private void DFDBIOIDMNL(IEnumerable<DDIGFOIPBNK> EJMIKFLLMDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x46E3BE0", Offset = "0x46E21E0", VA = "0x1846E3BE0")]
			private void MLBJKOOCEJN(DDIGFOIPBNK ACNCKENBDIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x46E2F20", Offset = "0x46E1520", VA = "0x1846E2F20")]
			private FBAGLKNHFLJ DFFIDNPAAOP(int OMCCDHKCKPI)
			{
				return default(FBAGLKNHFLJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x46E2A90", Offset = "0x46E1090", VA = "0x1846E2A90")]
			public void BPFFMDAANBP(float MMKDNNGEBON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x46E4010", Offset = "0x46E2610", VA = "0x1846E4010")]
			private void OLJENHJOEGF(Action CPNCDDHAPNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x46E2930", Offset = "0x46E0F30", VA = "0x1846E2930")]
			private void BLDAMNGBCHD(Action CPNCDDHAPNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x46E3360", Offset = "0x46E1960", VA = "0x1846E3360")]
			public void GHJPCNCLGMC(float MMKDNNGEBON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x46E29B0", Offset = "0x46E0FB0", VA = "0x1846E29B0")]
			public void BOLNPHFANNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x46E31E0", Offset = "0x46E17E0", VA = "0x1846E31E0")]
			public void DHLAFEDNNGI(NPDENHLMFPM OINLHHIBMNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x46E32A0", Offset = "0x46E18A0", VA = "0x1846E32A0")]
			public void EFNHDAJCHAH(NPDENHLMFPM OINLHHIBMNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x46E3960", Offset = "0x46E1F60", VA = "0x1846E3960")]
			public void HPNMEKIGOJH(NPDENHLMFPM OINLHHIBMNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct MBENEFCLJCO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float AJMMHGDOHIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int CGKCKIMHMGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> MBKOKCIPAEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> EPAJGAADNGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> MHKCHBFIDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<LGAEPPCBIFM> LELKKBFGCNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> EMJENDLOEPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> LKDFOEDNGJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> FNBGHDFPOOK;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x46E5110", Offset = "0x46E3710", VA = "0x1846E5110")]
			public static MBENEFCLJCO DBFOOEAJHCK(int AMOAHOKGKHK, float MMKDNNGEBON, NativeArray<LGAEPPCBIFM> CEJLOACGCLK, NativeArray<float> NFLLIMPFNIJ, NativeArray<int> MJFGIADJJBM, NativeArray<int> OCEINICFIOC, NativeArray<int> HFLNBCMBDJG, NativeArray<int> EPAJGAADNGF, NativeArray<int> MHKCHBFIDNP)
			{
				return default(MBENEFCLJCO);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x46E5410", Offset = "0x46E3A10", VA = "0x1846E5410", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x46E55C0", Offset = "0x46E3BC0", VA = "0x1846E55C0")]
			private bool MDBLMPOJNIB(int ACNPMFDBMJN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x46E5600", Offset = "0x46E3C00", VA = "0x1846E5600")]
			private void NLMAJKNPIGE(NativeArray<int> MGHGONAAJHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x46E50A0", Offset = "0x46E36A0", VA = "0x1846E50A0")]
			private int COFHPLDKIDD(int CGKAPNLOFHO, int OOBOLLFMDPC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x46E54F0", Offset = "0x46E3AF0", VA = "0x1846E54F0")]
			private void KHBNFBNFLGB(NativeArray<int> MGHGONAAJHC, int BFOBCLPEAFB, int FMBNAJCEBOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x46E51E0", Offset = "0x46E37E0", VA = "0x1846E51E0")]
			private void EHNIFEIMNEI(NativeArray<int> MGHGONAAJHC, int DAMKHAJGIKL, int MKKBMDPFIGI, int POKJPGFLDIH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class NJBEMHNGIJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly MGEMNCGONEK IKPCHBIFCLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour POJPEFNIBPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool KBKFBFFGKLD;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<KBDFKOBHGAA> KABFOGLLOGK
			{
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5201D0", Offset = "0x51E7D0", VA = "0x1805201D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public KBDFKOBHGAA OKOJOKOGKNK
			{
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5204A0", Offset = "0x51EAA0", VA = "0x1805204A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool CONDFFKPIIC
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x46E5E50", Offset = "0x46E4450", VA = "0x1846E5E50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool COJKMIJBKNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x6AE5E0", Offset = "0x6ACBE0", VA = "0x1806AE5E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x10BC9B0", Offset = "0x10BAFB0", VA = "0x1810BC9B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string DHAKHKDENDC
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x521010", Offset = "0x51F610", VA = "0x180521010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x521020", Offset = "0x51F620", VA = "0x180521020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float PHGAHDJPKMC
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0xD07950", Offset = "0xD05F50", VA = "0x180D07950")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0xD115C0", Offset = "0xD0FBC0", VA = "0x180D115C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x46E6000", Offset = "0x46E4600", VA = "0x1846E6000")]
			public NJBEMHNGIJF(IEnumerator<KBDFKOBHGAA> BMJCNMPCDFF, Behaviour POJPEFNIBPF, MGEMNCGONEK IKPCHBIFCLH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x46E5BB0", Offset = "0x46E41B0", VA = "0x1846E5BB0")]
			public KBDFKOBHGAA CLIEIAALPAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x46E5EE0", Offset = "0x46E44E0", VA = "0x1846E5EE0")]
			public bool PFCKCFBFALE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x46E5DC0", Offset = "0x46E43C0", VA = "0x1846E5DC0")]
			public void DHLAFEDNNGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x46E5F70", Offset = "0x46E4570", VA = "0x1846E5F70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1014880", Offset = "0x1012E80", VA = "0x181014880")]
			[CompilerGenerated]
			private void LEEFMDGEAIM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class MGEMNCGONEK : PBCLDLPLJNC, JHKLLFHDHJL, IDAIALKIMHE, HAMIGNOLDMC, IEnumerator, KBDFKOBHGAA, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private FFDEBDDLCFI.FHDHOFKEFAO EGFKAGOMJMB;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private FFDEBDDLCFI.FHDHOFKEFAO INNKPAIFGPE
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x6605C0", Offset = "0x65EBC0", VA = "0x1806605C0", Slot = "23")]
				get
				{
					return default(FFDEBDDLCFI.FHDHOFKEFAO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public FFDEBDDLCFI.FHDHOFKEFAO AMGKGKAGHGP
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x6605C0", Offset = "0x65EBC0", VA = "0x1806605C0")]
				get
				{
					return default(FFDEBDDLCFI.FHDHOFKEFAO);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x6605D0", Offset = "0x65EBD0", VA = "0x1806605D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float FMBGLOLFGAK
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xB77FD0", Offset = "0xB765D0", VA = "0x180B77FD0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x46E5640", Offset = "0x46E3C40", VA = "0x1846E5640", Slot = "24")]
			private bool OPKFJEIABGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x46E5630", Offset = "0x46E3C30", VA = "0x1846E5630", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x46E5660", Offset = "0x46E3C60", VA = "0x1846E5660")]
			public MGEMNCGONEK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum FBAGLKNHFLJ : byte
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
		private sealed class BMBDPAHJAFL : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum KHAIIMMLICF
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct OHDJKNPFHIB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public FFDEBDDLCFI.FHDHOFKEFAO CPNPAFAEBHH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public KHAIIMMLICF HGAEHMPCCKO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<NJBEMHNGIJF> MPHIFBLIBFF;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly KHAIIMMLICF[] IMABAMHHIBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly FFDEBDDLCFI.FHDHOFKEFAO OMCACPPOOJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool EOMCNJBKDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly NJBEMHNGIJF[] DMMAEHBOOBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<NJBEMHNGIJF> CMOLCFGEHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> FGOEFBLBHGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<NJBEMHNGIJF> NJGLPEOKGKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> OFNFGFDLPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool OGEBOHOAPHD;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public OHDJKNPFHIB[,] AINDJEGJCFO
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x533D70", Offset = "0x532370", VA = "0x180533D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int FOHENPEEPCN
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x46DA090", Offset = "0x46D8690", VA = "0x1846DA090")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x46DA2E0", Offset = "0x46D88E0", VA = "0x1846DA2E0")]
			public BMBDPAHJAFL(FFDEBDDLCFI.FHDHOFKEFAO JOBBNEMILCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x46D97C0", Offset = "0x46D7DC0", VA = "0x1846D97C0")]
			public void FACLHDOEKOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x46DA080", Offset = "0x46D8680", VA = "0x1846DA080")]
			public void PGBBJJECGDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x46D9A90", Offset = "0x46D8090", VA = "0x1846D9A90")]
			private void JDBPLIFBBKP(IReadOnlyList<NJBEMHNGIJF> JDLJLBILIOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x46D9F60", Offset = "0x46D8560", VA = "0x1846D9F60")]
			public void MKKMIPCMFDA(NJBEMHNGIJF BMJCNMPCDFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x46D9CE0", Offset = "0x46D82E0", VA = "0x1846D9CE0")]
			public void MBNIPHBODID(IList<NJBEMHNGIJF> KCMLNLJGACH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x46D8E80", Offset = "0x46D7480", VA = "0x1846D8E80")]
			public void BJNDPNKEDJB(IList<NJBEMHNGIJF> KCMLNLJGACH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x46D9300", Offset = "0x46D7900", VA = "0x1846D9300")]
			private void COHMBOFMKPC(NJBEMHNGIJF BMJCNMPCDFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x46D9920", Offset = "0x46D7F20", VA = "0x1846D9920")]
			private void IGBKKPKGHFC(IList<NJBEMHNGIJF> KCMLNLJGACH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x46D97D0", Offset = "0x46D7DD0", VA = "0x1846D97D0")]
			private FBAGLKNHFLJ HPDBHGAPLKF(NJBEMHNGIJF BMJCNMPCDFF)
			{
				return default(FBAGLKNHFLJ);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x46D9710", Offset = "0x46D7D10", VA = "0x1846D9710")]
			public void ELGGEIDNLDL(float MMKDNNGEBON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x46D9100", Offset = "0x46D7700", VA = "0x1846D9100")]
			public void BKLDBDPBEMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x46D9530", Offset = "0x46D7B30", VA = "0x1846D9530")]
			private void EFHHAEFHMID(List<NJBEMHNGIJF> KCMLNLJGACH, Stack<int> HNGEANJGAFO, bool KKFKBJBECFO, float IDMODOBKPIL = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x46D93F0", Offset = "0x46D79F0", VA = "0x1846D93F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x46D9BC0", Offset = "0x46D81C0", VA = "0x1846D9BC0")]
			private void LFHLENJNDGG(List<NJBEMHNGIJF> KCMLNLJGACH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum LGAEPPCBIFM : byte
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
		private sealed class FAHDINMDOGA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5201C0", Offset = "0x51E7C0", VA = "0x1805201C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x5DC2D0", Offset = "0x5DA8D0", VA = "0x1805DC2D0")]
			[DebuggerHidden]
			public FAHDINMDOGA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x46DF2F0", Offset = "0x46DD8F0", VA = "0x1846DF2F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x46DF370", Offset = "0x46DD970", VA = "0x1846DF370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const LGAEPPCBIFM JBIGDBLDEMG = LGAEPPCBIFM.Cancelled | LGAEPPCBIFM.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly FFDEBDDLCFI.FHDHOFKEFAO[] DHPDFIDEHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private BMBDPAHJAFL[] LHLLHGHKOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KMCEFFPNMNF[] GONKALELEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine MOIDALIMOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame DOINDGIHFKG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FFDEBDDLCFI.FHDHOFKEFAO KKCDHHJKBFF
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x557080", Offset = "0x555680", VA = "0x180557080")]
			[CompilerGenerated]
			get
			{
				return default(FFDEBDDLCFI.FHDHOFKEFAO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5FA740", Offset = "0x5F8D40", VA = "0x1805FA740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PFENBKHLJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x6AE2E0", Offset = "0x6AC8E0", VA = "0x1806AE2E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1C749A0", Offset = "0x1C72FA0", VA = "0x181C749A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int FOHENPEEPCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x46EA070", Offset = "0x46E8670", VA = "0x1846EA070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x46E8FB0", Offset = "0x46E75B0", VA = "0x1846E8FB0")]
		public static JHKLLFHDHJL GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x46E8900", Offset = "0x46E6F00", VA = "0x1846E8900", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x46E90C0", Offset = "0x46E76C0", VA = "0x1846E90C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x46E9050", Offset = "0x46E7650", VA = "0x1846E9050")]
		private BMBDPAHJAFL IIGPDILDPGP(FFDEBDDLCFI.FHDHOFKEFAO IPLFCJCEGLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2DA3990", Offset = "0x2DA1F90", VA = "0x182DA3990")]
		private KMCEFFPNMNF MOAPCCHAFFE(FFDEBDDLCFI.FHDHOFKEFAO IPLFCJCEGLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x46E9580", Offset = "0x46E7B80", VA = "0x1846E9580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x46E9540", Offset = "0x46E7B40", VA = "0x1846E9540")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x46E9E40", Offset = "0x46E8440", VA = "0x1846E9E40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x46E9090", Offset = "0x46E7690", VA = "0x1846E9090")]
		private void JAKMDBNHHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x46E90A0", Offset = "0x46E76A0", VA = "0x1846E90A0")]
		private void KKAFKEANFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x46E8FA0", Offset = "0x46E75A0", VA = "0x1846E8FA0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x46E90B0", Offset = "0x46E76B0", VA = "0x1846E90B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x46E8EC0", Offset = "0x46E74C0", VA = "0x1846E8EC0")]
		private void CPENDGFHMIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x46E8F30", Offset = "0x46E7530", VA = "0x1846E8F30")]
		[IteratorStateMachine(typeof(FAHDINMDOGA))]
		private IEnumerator FHJMLBKCBDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x46E9730", Offset = "0x46E7D30", VA = "0x1846E9730", Slot = "7")]
		public JHKLLFHDHJL Run(IEnumerator<KBDFKOBHGAA> MOMJKFOCMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x46E9740", Offset = "0x46E7D40", VA = "0x1846E9740", Slot = "8")]
		public JHKLLFHDHJL Run(Behaviour POJPEFNIBPF, IEnumerator<KBDFKOBHGAA> MOMJKFOCMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x46E9600", Offset = "0x46E7C00", VA = "0x1846E9600", Slot = "9")]
		public JHKLLFHDHJL RunJobbed(LELHKPJPEMH POJPEFNIBPF, IEnumerator<KBDFKOBHGAA> MOMJKFOCMHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x46E8ED0", Offset = "0x46E74D0", VA = "0x1846E8ED0", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x46E9970", Offset = "0x46E7F70", VA = "0x1846E9970")]
		public void UpdateQueue(FFDEBDDLCFI.FHDHOFKEFAO MLFHKMIOBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x46E8740", Offset = "0x46E6D40", VA = "0x1846E8740")]
		private void AAAABJFJPJN(BMBDPAHJAFL AGOFIPICCGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x46E8DA0", Offset = "0x46E73A0", VA = "0x1846E8DA0")]
		private void CFDDOONOJBB(KMCEFFPNMNF AGOFIPICCGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x46EA000", Offset = "0x46E8600", VA = "0x1846EA000")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class CANFMJOJPKN
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x46DAA10", Offset = "0x46D9010", VA = "0x1846DAA10")]
	[FFEDPJMKNFO]
	private static void LBKBKLEKILK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class FOOCKAAFGGF : BGMLMBKNDAC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float ANLKFIPPOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x46E0660", Offset = "0x46DEC60", VA = "0x1846E0660", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float IOCKOHIGPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x46E0680", Offset = "0x46DEC80", VA = "0x1846E0680", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float LBPOIBICLIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x46E0630", Offset = "0x46DEC30", VA = "0x1846E0630", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int OCLPAEAOGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x46E0670", Offset = "0x46DEC70", VA = "0x1846E0670", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double BAPHKLKAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x46E0640", Offset = "0x46DEC40", VA = "0x1846E0640", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public FOOCKAAFGGF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EEDIADJHOAL
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] GGHPKOFMNIO;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int KCKCMMJGOCO;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int BOFMOMDGGBC;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger PJEPEPBBIPN;

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public EEDIADJHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x46DE590", Offset = "0x46DCB90", VA = "0x1846DE590")]
	private static string IAEECNCONGN(byte[] KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x46DE260", Offset = "0x46DC860", VA = "0x1846DE260")]
	public static string AGDFJGHALKO(byte[] MOPADMGKCOG, bool CNBJECBCBOC)
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
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
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

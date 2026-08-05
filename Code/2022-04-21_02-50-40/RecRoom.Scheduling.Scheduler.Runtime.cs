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
		private delegate List<PlayerLoopSystem> AILIIKDDFHO(List<PlayerLoopSystem> PEDHPBMJELI, int JMKGLHBAEJD);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct NJFJKDBDNGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct LBKIDOBCLBK
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EKMBLIFIIOC JCPJLCLOIDJ;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x47418A0", Offset = "0x47408A0", VA = "0x1847418A0")]
				public static PlayerLoopSystem EOAGDFHBNBG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct MKCAIHJLOMI
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EKMBLIFIIOC ELMJJKOCLJL;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4744B10", Offset = "0x4743B10", VA = "0x184744B10")]
				public static PlayerLoopSystem EOAGDFHBNBG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct MMHPPPKNGGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EKMBLIFIIOC PLPNBBDDHPD;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4744CE0", Offset = "0x4743CE0", VA = "0x184744CE0")]
				public static PlayerLoopSystem EOAGDFHBNBG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct PMMCBBDAFGG
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static EKMBLIFIIOC HBFHOBGJHAP;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4746DF0", Offset = "0x4745DF0", VA = "0x184746DF0")]
				public static PlayerLoopSystem EOAGDFHBNBG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct DKJJOKNDLAE
			{
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static EKMBLIFIIOC IPJDAAKCCNP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x473BCF0", Offset = "0x473ACF0", VA = "0x18473BCF0")]
				public static PlayerLoopSystem EOAGDFHBNBG()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct CLFMKKGHBEC
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class KOJFFNIGIPK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000012")]
					public DFEENEDCIEE.LJKNELKBOIE key;

					[Cpp2IlInjected.Token(Token = "0x6000025")]
					[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
					public KOJFFNIGIPK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000026")]
					[Cpp2IlInjected.Address(RVA = "0x4741410", Offset = "0x4740410", VA = "0x184741410")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static IDisposable NJODMOACCDC;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4737A10", Offset = "0x4736A10", VA = "0x184737A10")]
				public static PlayerLoopSystem PCDKCINIAEN(DFEENEDCIEE.LJKNELKBOIE ACPAGAEJCEC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			internal struct BPIDLIHEPKF
			{
				[Cpp2IlInjected.Token(Token = "0x2000012")]
				[CompilerGenerated]
				private sealed class AKLEHADCGJG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public DFEENEDCIEE.LJKNELKBOIE key;

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
					public AKLEHADCGJG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000029")]
					[Cpp2IlInjected.Address(RVA = "0x4736BA0", Offset = "0x4735BA0", VA = "0x184736BA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x47378C0", Offset = "0x47368C0", VA = "0x1847378C0")]
				public static PlayerLoopSystem PCDKCINIAEN(DFEENEDCIEE.LJKNELKBOIE ACPAGAEJCEC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ENHPAJLLECL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public ENHPAJLLECL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x473C890", Offset = "0x473B890", VA = "0x18473C890")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool LGDCPCHHDMP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IBDIJCONHJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x473B150", Offset = "0x473A150", VA = "0x18473B150")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x473B190", Offset = "0x473A190", VA = "0x18473B190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4739980", Offset = "0x4738980", VA = "0x184739980")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x47397B0", Offset = "0x47387B0", VA = "0x1847397B0")]
		private static void AGLGPDHFKOJ(DFEENEDCIEE.LJKNELKBOIE ACPAGAEJCEC, ref PlayerLoopSystem LJLNJELGLHM, Type EKMGAJPBNJJ, Type BAKKKBDIIGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x473ADD0", Offset = "0x4739DD0", VA = "0x18473ADD0")]
		private static void FDFABKOIFMA(ref PlayerLoopSystem LJLNJELGLHM, Type EKMGAJPBNJJ, Type BAKKKBDIIGE, AILIIKDDFHO NKCIIJNMBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x473B1D0", Offset = "0x473A1D0", VA = "0x18473B1D0")]
		private static void LIPMAFEJMJF(ref PlayerLoopSystem LJLNJELGLHM, Type EKMGAJPBNJJ, Type BAKKKBDIIGE, PlayerLoopSystem? IJJGICCMINI, PlayerLoopSystem? NFIEMEAIKEI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DFEENEDCIEE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum LJKNELKBOIE
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class OLPNDNINDCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly LJKNELKBOIE KJFIIKAKLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly IKIGLNPCGGO MKCPDNKNGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long BEINBAHICCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long HLJGFAHLNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long LDEIAGJLGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int DHHMEGLDAIE;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4746640", Offset = "0x4745640", VA = "0x184746640")]
		public OLPNDNINDCI(LJKNELKBOIE DEPPGNHEHEP, int PEHDAFMOMPJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4746380", Offset = "0x4745380", VA = "0x184746380")]
		public void IOKONIEEFDC(int EADALKNPDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x47463A0", Offset = "0x47453A0", VA = "0x1847463A0")]
		public void NKEMLCEIICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4746410", Offset = "0x4745410", VA = "0x184746410")]
		public void NPDOBBFCGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4746470", Offset = "0x4745470", VA = "0x184746470")]
		public void ONLJALCOLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x47462E0", Offset = "0x47452E0", VA = "0x1847462E0")]
		public double CHAFJKCFCGD(int NNBAIPEBHLD)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const int MLBCNMIFEGL = 90;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static LJKNELKBOIE[] ONHDBHGPLOO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static OLPNDNINDCI[] HPOFEFCLOCM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x473B430", Offset = "0x473A430", VA = "0x18473B430")]
	public static OLPNDNINDCI ONBHKMJMEGD(LJKNELKBOIE ACPAGAEJCEC, int PEHDAFMOMPJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x473B2F0", Offset = "0x473A2F0", VA = "0x18473B2F0")]
	public static OLPNDNINDCI GGMDBEOPHAA(LJKNELKBOIE ACPAGAEJCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x473B380", Offset = "0x473A380", VA = "0x18473B380")]
	public static void OHDDIMONGIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IKIGLNPCGGO : MNHEDAIFKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int CDIDACDANPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> JIPBICDCNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double AIGBMIKHPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double DHPKJINMPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double OEDGNDJNMAJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CMJONLILADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4740310", Offset = "0x473F310", VA = "0x184740310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double DICPDGFCKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x47403C0", Offset = "0x473F3C0", VA = "0x1847403C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PPDLEPGEMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x13FC450", Offset = "0x13FB450", VA = "0x1813FC450", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double BKNEHBDNBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x326E1C0", Offset = "0x326D1C0", VA = "0x18326E1C0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4740520", Offset = "0x473F520", VA = "0x184740520")]
	public IKIGLNPCGGO(int PIDAKGFCFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4740420", Offset = "0x473F420", VA = "0x184740420", Slot = "4")]
	public void LOMPNHOJDGO(double CDHAGALPBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4740350", Offset = "0x473F350", VA = "0x184740350", Slot = "5")]
	public void GFAAAEIMPBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LPDMDFMGLBH : MNHEDAIFKDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long EGFLDBNNFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double KCHGLINEHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double BAEFNJHLGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double GBFMGAPADAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double EBLCCNGANKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double AIGBMIKHPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double DHPKJINMPEP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PHEEIFDPPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double PPDLEPGEMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3697E60", Offset = "0x3696E60", VA = "0x183697E60", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BKNEHBDNBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x96F390", Offset = "0x96E390", VA = "0x18096F390", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JKLEOALAMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x326E1C0", Offset = "0x326D1C0", VA = "0x18326E1C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double AGNOBKNKAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x326E1B0", Offset = "0x326D1B0", VA = "0x18326E1B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double DICPDGFCKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3697D90", Offset = "0x3696D90", VA = "0x183697D90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x47444E0", Offset = "0x47434E0", VA = "0x1847444E0", Slot = "4")]
	public void LOMPNHOJDGO(double CDHAGALPBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x47444A0", Offset = "0x47434A0", VA = "0x1847444A0", Slot = "5")]
	public void GFAAAEIMPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4744600", Offset = "0x4743600", VA = "0x184744600")]
	public LPDMDFMGLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MNHEDAIFKDI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double DICPDGFCKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double PPDLEPGEMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double BKNEHBDNBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOMPNHOJDGO(double CDHAGALPBAP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFAAAEIMPBI();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FGKFEPJAKIJ
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface KIGHEJNKOLO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool MIMGAPMCELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GJKAPAPOEHI();

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LIPMGAILBGM();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class KBPIHEOCNEC<TPromise, TMainThreadPromise> : KIGHEJNKOLO where TPromise : FPHLJBABNHP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise HDCKKALJIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise GJEEPGNLJMH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise IFAAKJFCHCP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7C10", Offset = "0x2AE6C10", VA = "0x182AE7C10")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MIMGAPMCELG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2AE7B30", Offset = "0x2AE6B30", VA = "0x182AE7B30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7C70", Offset = "0x2AE6C70", VA = "0x182AE7C70")]
		protected KBPIHEOCNEC(TPromise HDCKKALJIIK, TMainThreadPromise JAIOMAFKJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7BE0", Offset = "0x2AE6BE0", VA = "0x182AE7BE0", Slot = "5")]
		public void GJKAPAPOEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1F2C350", Offset = "0x1F2B350", VA = "0x181F2C350", Slot = "6")]
		public void LIPMGAILBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void BDKGNMJLMHG(TPromise HDCKKALJIIK);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void HMCBAOHFBKH();
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class BKBAAMECKHB<T> : KBPIHEOCNEC<global::GIFPPDKJJDK<T>, global::NJDHBAAKDND<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2AD80D0", Offset = "0x2AD70D0", VA = "0x182AD80D0")]
		public BKBAAMECKHB(global::GIFPPDKJJDK<T> HDCKKALJIIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7E10", Offset = "0x2AD6E10", VA = "0x182AD7E10", Slot = "7")]
		protected override void BDKGNMJLMHG(global::GIFPPDKJJDK<T> HDCKKALJIIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8040", Offset = "0x2AD7040", VA = "0x182AD8040", Slot = "8")]
		protected override void HMCBAOHFBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2AD80A0", Offset = "0x2AD70A0", VA = "0x182AD80A0")]
		[CompilerGenerated]
		private void OLOBHEGPCKI(T FBLFMDDMFKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8010", Offset = "0x2AD7010", VA = "0x182AD8010")]
		[CompilerGenerated]
		private void FKGANGCFCCP(string BKDCGOBDEFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class IEIOJOOFCGK : KBPIHEOCNEC<FPHLJBABNHP, OGFJMEAGPLD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x47402A0", Offset = "0x473F2A0", VA = "0x1847402A0")]
		public IEIOJOOFCGK(FPHLJBABNHP HDCKKALJIIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4740180", Offset = "0x473F180", VA = "0x184740180", Slot = "7")]
		protected override void BDKGNMJLMHG(FPHLJBABNHP HDCKKALJIIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4740250", Offset = "0x473F250", VA = "0x184740250", Slot = "8")]
		protected override void HMCBAOHFBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x130E750", Offset = "0x130D750", VA = "0x18130E750")]
		[CompilerGenerated]
		private void OLOBHEGPCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x19EA630", Offset = "0x19E9630", VA = "0x1819EA630")]
		[CompilerGenerated]
		private void FKGANGCFCCP(string BKDCGOBDEFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class IALMFBKJGMO : KIGHEJNKOLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action HCODLMJPEMJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MIMGAPMCELG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x523FE0", Offset = "0x522FE0", VA = "0x180523FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x684A70", Offset = "0x683A70", VA = "0x180684A70")]
		public IALMFBKJGMO(Action HCODLMJPEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x114D950", Offset = "0x114C950", VA = "0x18114D950", Slot = "5")]
		public void GJKAPAPOEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "6")]
		public void LIPMGAILBGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<KIGHEJNKOLO> DCAKONOEONE;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1D43E50", Offset = "0x1D42E50", VA = "0x181D43E50")]
	public static global::GIFPPDKJJDK<T> FHOGLLENGEA<T>(this global::GIFPPDKJJDK<T> HDCKKALJIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x473D160", Offset = "0x473C160", VA = "0x18473D160")]
	public static FPHLJBABNHP FHOGLLENGEA(this FPHLJBABNHP HDCKKALJIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x473D270", Offset = "0x473C270", VA = "0x18473D270")]
	public static void FHOGLLENGEA(Action HCODLMJPEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1D43EC0", Offset = "0x1D42EC0", VA = "0x181D43EC0")]
	private static global::GIFPPDKJJDK<T> MECJLPMFPBG<T>(global::GIFPPDKJJDK<T> HDCKKALJIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x473D6F0", Offset = "0x473C6F0", VA = "0x18473D6F0")]
	private static FPHLJBABNHP MECJLPMFPBG(FPHLJBABNHP HDCKKALJIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x473D7D0", Offset = "0x473C7D0", VA = "0x18473D7D0")]
	private static void PEJECIGNMJO(KIGHEJNKOLO KOODBFJGCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x473D3D0", Offset = "0x473C3D0", VA = "0x18473D3D0")]
	private static void JFLIFGLGGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x473D300", Offset = "0x473C300", VA = "0x18473D300")]
	private static void GLIOMOGNJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x473D0B0", Offset = "0x473C0B0", VA = "0x18473D0B0")]
	private static void EODCLMANMCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class AKFKFCGDJEC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MOFGNGOLIKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public OGFJMEAGPLD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public MOFGNGOLIKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4744EC0", Offset = "0x4743EC0", VA = "0x184744EC0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4744EB0", Offset = "0x4743EB0", VA = "0x184744EB0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LKHGLBOCFLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public LKHGLBOCFLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4743EE0", Offset = "0x4742EE0", VA = "0x184743EE0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class INHELIGHEMP : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public OGFJMEAGPLD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public INHELIGHEMP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x47408E0", Offset = "0x473F8E0", VA = "0x1847408E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x47405C0", Offset = "0x473F5C0", VA = "0x1847405C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4740990", Offset = "0x473F990", VA = "0x184740990")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4740890", Offset = "0x473F890", VA = "0x184740890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NKHADBMLAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public OGFJMEAGPLD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public NKHADBMLAHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LAOHJMALNDL : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public OGFJMEAGPLD onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private NKHADBMLAHF <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public LAOHJMALNDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x47414C0", Offset = "0x47404C0", VA = "0x1847414C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4741850", Offset = "0x4740850", VA = "0x184741850", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string OFBNDGGDBNG = "empty";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string HOFJBIFMPLC = "moderator";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public const string DMNPPGKGCHC = "main_root";

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string CEMICACHMOJ = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public const string KDHPEDJBLHI = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private const float OLFFCFOPEBF = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static FPHLJBABNHP CODDKAIHDLM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static AsyncOperation MABIAJBCGJF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static FPHLJBABNHP OEKPFKPMHJE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static string IKKKCAKEPFP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static ThreadPriority DGMICAAGDIO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool LIOBPOGGFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4736570", Offset = "0x4735570", VA = "0x184736570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool NOGHMEAHJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4736610", Offset = "0x4735610", VA = "0x184736610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool IEHEDKEHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4736880", Offset = "0x4735880", VA = "0x184736880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FANBEBAKLGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4736430", Offset = "0x4735430", VA = "0x184736430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4736380", Offset = "0x4735380", VA = "0x184736380")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x47367D0", Offset = "0x47357D0", VA = "0x1847367D0")]
	[HNDGNKOOMOO(MBIOIPKMLMP.EnteredEditModeNextFrame, 0)]
	private static void LGNMKDEIHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4736670", Offset = "0x4735670", VA = "0x184736670")]
	public static FPHLJBABNHP JHKNHNOOCAI(string JMBELKJNJDN, LoadSceneMode AFABHBHEHII = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x47368E0", Offset = "0x47358E0", VA = "0x1847368E0")]
	public static FPHLJBABNHP MNNEAFOPBKH(string JMBELKJNJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x47364E0", Offset = "0x47354E0", VA = "0x1847364E0")]
	[IteratorStateMachine(typeof(INHELIGHEMP))]
	private static IEnumerator<OKFJJPCKHDN> DJGCLMNAHOJ(string JMBELKJNJDN, OGFJMEAGPLD GJKNHMPEAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4736B10", Offset = "0x4735B10", VA = "0x184736B10")]
	[IteratorStateMachine(typeof(LAOHJMALNDL))]
	private static IEnumerator<OKFJJPCKHDN> OAKFMHPMEKL(string JMBELKJNJDN, LoadSceneMode AFABHBHEHII, OGFJMEAGPLD GJKNHMPEAJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GADJFBBCIDB
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x473DE80", Offset = "0x473CE80", VA = "0x18473DE80")]
	public static IDisposable DNPMCJKODNL(this IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x473DF00", Offset = "0x473CF00", VA = "0x18473DF00")]
	public static IDisposable DNPMCJKODNL(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x473E0F0", Offset = "0x473D0F0", VA = "0x18473E0F0")]
	public static IDisposable FKLJHKPOJIH(this IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x473E490", Offset = "0x473D490", VA = "0x18473E490")]
	public static IDisposable JKNPJHBDIDM(this IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x473E080", Offset = "0x473D080", VA = "0x18473E080")]
	public static IDisposable ELJFAIELAEK(this IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x473DD10", Offset = "0x473CD10", VA = "0x18473DD10")]
	public static IDisposable CFHOMAMAODK(this IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x473DCA0", Offset = "0x473CCA0", VA = "0x18473DCA0")]
	public static IDisposable ALKKLJJMPBN(this IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x473E160", Offset = "0x473D160", VA = "0x18473E160")]
	public static IDisposable GDAOBAIFLMF(this IOCAABDHIFD JBPOCMHHIBO, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x473DF80", Offset = "0x473CF80", VA = "0x18473DF80")]
	public static IDisposable DONKJFLGFAB(this IOCAABDHIFD JBPOCMHHIBO, float ACLMAOOFNHJ, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x473DE00", Offset = "0x473CE00", VA = "0x18473DE00")]
	public static IDisposable DJEAGKLJHGK(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x473E410", Offset = "0x473D410", VA = "0x18473E410")]
	public static IDisposable JANKJHLGNMF(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x473E300", Offset = "0x473D300", VA = "0x18473E300")]
	public static IDisposable HPKIAMCNPMC(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x473E380", Offset = "0x473D380", VA = "0x18473E380")]
	public static IDisposable IDJNPBCEFNM(this IOCAABDHIFD JBPOCMHHIBO, float ACLMAOOFNHJ, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x473DC20", Offset = "0x473CC20", VA = "0x18473DC20")]
	public static IDisposable AKHKPJHJFFC(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x473E580", Offset = "0x473D580", VA = "0x18473E580")]
	public static IDisposable PDNCCCHHKKK(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x473E000", Offset = "0x473D000", VA = "0x18473E000")]
	public static IDisposable ECKNPLLBCJL(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x473E270", Offset = "0x473D270", VA = "0x18473E270")]
	public static IDisposable HAGIALLNKLA(this IOCAABDHIFD JBPOCMHHIBO, float ACLMAOOFNHJ, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x473E500", Offset = "0x473D500", VA = "0x18473E500")]
	public static IDisposable MOEDAKHFIOP(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x473DD80", Offset = "0x473CD80", VA = "0x18473DD80")]
	public static IDisposable DHKGAGEJNHG(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x473E1F0", Offset = "0x473D1F0", VA = "0x18473E1F0")]
	public static IDisposable GNIIOEOKIDK(this IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BOAIEFMJGDL
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4737650", Offset = "0x4736650", VA = "0x184737650")]
	public static IDisposable NHFJAHHOFKJ(this MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x47376D0", Offset = "0x47366D0", VA = "0x1847376D0")]
	public static IDisposable NHFJAHHOFKJ(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x47377E0", Offset = "0x47367E0", VA = "0x1847377E0")]
	public static IDisposable OKEBEOJEDHO(this MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4736E10", Offset = "0x4735E10", VA = "0x184736E10")]
	public static IDisposable CECIDCLGBID(this MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x47372F0", Offset = "0x47362F0", VA = "0x1847372F0")]
	public static IDisposable KPANLENGPEI(this MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4736FB0", Offset = "0x4735FB0", VA = "0x184736FB0")]
	public static IDisposable EHMENNKJIMF(this MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4737850", Offset = "0x4736850", VA = "0x184737850")]
	public static IDisposable PLEFFOLHMJP(this MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4736E80", Offset = "0x4735E80", VA = "0x184736E80")]
	public static IDisposable CLGHGCBKNIE(this MonoBehaviour IHHOBPGEDOB, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4736F20", Offset = "0x4735F20", VA = "0x184736F20")]
	public static IDisposable DEMBLFKEKOC(this MonoBehaviour IHHOBPGEDOB, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4737140", Offset = "0x4736140", VA = "0x184737140")]
	public static IDisposable GBADDBLEIAF(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4736CF0", Offset = "0x4735CF0", VA = "0x184736CF0")]
	public static IDisposable BAMIHBNHCGL(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x47371D0", Offset = "0x47361D0", VA = "0x1847371D0")]
	public static IDisposable GLMNJKJIGNN(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4737020", Offset = "0x4736020", VA = "0x184737020")]
	public static IDisposable EOHNIDEFNMB(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4737750", Offset = "0x4736750", VA = "0x184737750")]
	public static IDisposable OIMHGJFPBJG(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4736C60", Offset = "0x4735C60", VA = "0x184736C60")]
	public static IDisposable ALCHBLKFMBP(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4737510", Offset = "0x4736510", VA = "0x184737510")]
	public static IDisposable MOIMPOOOHED(this MonoBehaviour IHHOBPGEDOB, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4737480", Offset = "0x4736480", VA = "0x184737480")]
	public static IDisposable MJBMKJCPEGF(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x47373F0", Offset = "0x47363F0", VA = "0x1847373F0")]
	public static IDisposable MDPMAPIHALN(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4737260", Offset = "0x4736260", VA = "0x184737260")]
	public static IDisposable JHFPCHAADFG(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x47375B0", Offset = "0x47365B0", VA = "0x1847375B0")]
	public static IDisposable NDBEMPMMLMO(this MonoBehaviour IHHOBPGEDOB, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4736D80", Offset = "0x4735D80", VA = "0x184736D80")]
	public static IDisposable BMALKEICBBD(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4737360", Offset = "0x4736360", VA = "0x184737360")]
	public static IDisposable LDGPGBNADBN(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x47370B0", Offset = "0x47360B0", VA = "0x1847370B0")]
	public static IDisposable FLBOHOLLFLP(this MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FDDCDIGFBMC
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NAIGIGGNLOO : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CBMBJKAIKNP.EBEPLJKMFIO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private LDKMFGMLECO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public NAIGIGGNLOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x47450C0", Offset = "0x47440C0", VA = "0x1847450C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4745180", Offset = "0x4744180", VA = "0x184745180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JOPHHIEJBEH : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CBMBJKAIKNP.EBEPLJKMFIO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private LDKMFGMLECO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public JOPHHIEJBEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x47412E0", Offset = "0x47402E0", VA = "0x1847412E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x47413C0", Offset = "0x47403C0", VA = "0x1847413C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x473CFC0", Offset = "0x473BFC0", VA = "0x18473CFC0")]
	public static PHEIIEMLJCG NHFJAHHOFKJ(Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x473CDC0", Offset = "0x473BDC0", VA = "0x18473CDC0")]
	public static PHEIIEMLJCG NHFJAHHOFKJ(Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x473CCB0", Offset = "0x473BCB0", VA = "0x18473CCB0")]
	public static PHEIIEMLJCG NHFJAHHOFKJ(Behaviour JBPOCMHHIBO, Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x473CEB0", Offset = "0x473BEB0", VA = "0x18473CEB0")]
	public static PHEIIEMLJCG NHFJAHHOFKJ(Behaviour JBPOCMHHIBO, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x473CAA0", Offset = "0x473BAA0", VA = "0x18473CAA0")]
	public static PHEIIEMLJCG DNPMCJKODNL(IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x473C990", Offset = "0x473B990", VA = "0x18473C990")]
	public static PHEIIEMLJCG DNPMCJKODNL(IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x473CC30", Offset = "0x473BC30", VA = "0x18473CC30")]
	[IteratorStateMachine(typeof(NAIGIGGNLOO))]
	private static IEnumerator<OKFJJPCKHDN> IKDCMAJCHKH(CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC, Action HELALDPMEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x473CBB0", Offset = "0x473BBB0", VA = "0x18473CBB0")]
	[IteratorStateMachine(typeof(JOPHHIEJBEH))]
	private static IEnumerator<OKFJJPCKHDN> IKDCMAJCHKH(CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC, Action<float> HELALDPMEKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EFDICEGBBCM
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FKICDGJCLDJ : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CBMBJKAIKNP.EBEPLJKMFIO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CBFNIPMOJMG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public FKICDGJCLDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x473DA20", Offset = "0x473CA20", VA = "0x18473DA20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x473DB30", Offset = "0x473CB30", VA = "0x18473DB30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x473C0E0", Offset = "0x473B0E0", VA = "0x18473C0E0")]
	public static PHEIIEMLJCG NHFJAHHOFKJ(float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x473C020", Offset = "0x473B020", VA = "0x18473C020")]
	public static PHEIIEMLJCG NHFJAHHOFKJ(MonoBehaviour IHHOBPGEDOB, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x473BEC0", Offset = "0x473AEC0", VA = "0x18473BEC0")]
	public static PHEIIEMLJCG GMABAMIAHJO(IOCAABDHIFD JBPOCMHHIBO, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, bool DBLHINMCIFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x473BF80", Offset = "0x473AF80", VA = "0x18473BF80")]
	[IteratorStateMachine(typeof(FKICDGJCLDJ))]
	private static IEnumerator<OKFJJPCKHDN> IKDCMAJCHKH(float ACLMAOOFNHJ, CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC, Action<float> HELALDPMEKB, bool DBLHINMCIFJ = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class AHAPIDFALHE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MJLOIAODNBM : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CBMBJKAIKNP.EBEPLJKMFIO queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public MJLOIAODNBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4744A10", Offset = "0x4743A10", VA = "0x184744A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4744AC0", Offset = "0x4743AC0", VA = "0x184744AC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4736110", Offset = "0x4735110", VA = "0x184736110")]
	[IteratorStateMachine(typeof(MJLOIAODNBM))]
	private static IEnumerator<OKFJJPCKHDN> ALMPKIGOILM(CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, Func<bool> EHLHCGPEFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4736190", Offset = "0x4735190", VA = "0x184736190")]
	public static PHEIIEMLJCG IDDLAKMDCHJ(this MonoBehaviour IHHOBPGEDOB, Func<bool> EHLHCGPEFKO, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE = CBMBJKAIKNP.EBEPLJKMFIO.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CMHMENFJCBB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HHIMLBAHNHD : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CBMBJKAIKNP.EBEPLJKMFIO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public HHIMLBAHNHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x473E690", Offset = "0x473D690", VA = "0x18473E690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x473E750", Offset = "0x473D750", VA = "0x18473E750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OHBIOBNJIIM : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CBMBJKAIKNP.EBEPLJKMFIO queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private OKFJJPCKHDN <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public OHBIOBNJIIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4746070", Offset = "0x4745070", VA = "0x184746070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4746140", Offset = "0x4745140", VA = "0x184746140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4738500", Offset = "0x4737500", VA = "0x184738500")]
	[IteratorStateMachine(typeof(HHIMLBAHNHD))]
	private static IEnumerator<OKFJJPCKHDN> KDDNDGFEJMA(float CBMIPCMFOCE, CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4738250", Offset = "0x4737250", VA = "0x184738250")]
	[IteratorStateMachine(typeof(OHBIOBNJIIM))]
	private static IEnumerator<OKFJJPCKHDN> IMLMLFBOEHM(float CBMIPCMFOCE, CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4737C90", Offset = "0x4736C90", VA = "0x184737C90")]
	public static IDisposable ALOGJEGKIDK(this MonoBehaviour IHHOBPGEDOB, float CBMIPCMFOCE, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47385B0", Offset = "0x47375B0", VA = "0x1847385B0")]
	public static PHEIIEMLJCG OKGCMHIMILG(this MonoBehaviour IHHOBPGEDOB, float CBMIPCMFOCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4737B30", Offset = "0x4736B30", VA = "0x184737B30")]
	public static PHEIIEMLJCG ALOGJEGKIDK(this MonoBehaviour IHHOBPGEDOB, float CBMIPCMFOCE, CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4738130", Offset = "0x4737130", VA = "0x184738130")]
	public static PHEIIEMLJCG HDHMFEGPCAG(this MonoBehaviour IHHOBPGEDOB, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4738010", Offset = "0x4737010", VA = "0x184738010")]
	public static PHEIIEMLJCG GIIEIFGHPJG(this MonoBehaviour IHHOBPGEDOB, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x47385A0", Offset = "0x47375A0", VA = "0x1847385A0")]
	public static PHEIIEMLJCG MGHDNJIEDDN(this MonoBehaviour IHHOBPGEDOB, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4738000", Offset = "0x4737000", VA = "0x184738000")]
	public static PHEIIEMLJCG FICGOFKJGBB(this MonoBehaviour IHHOBPGEDOB, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4738590", Offset = "0x4737590", VA = "0x184738590")]
	public static PHEIIEMLJCG KEALPAOLIAL(this MonoBehaviour IHHOBPGEDOB, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x47383F0", Offset = "0x47373F0", VA = "0x1847383F0")]
	private static PHEIIEMLJCG JMKAEGJHIFI(MonoBehaviour IHHOBPGEDOB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4738140", Offset = "0x4737140", VA = "0x184738140")]
	public static PHEIIEMLJCG IHDKBAHMPDG(this MonoBehaviour IHHOBPGEDOB, float PPOMCIEAFNO, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x47382E0", Offset = "0x47372E0", VA = "0x1847382E0")]
	public static PHEIIEMLJCG JAPJMJGNAAL(this MonoBehaviour IHHOBPGEDOB, float PPOMCIEAFNO, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4737EF0", Offset = "0x4736EF0", VA = "0x184737EF0")]
	public static PHEIIEMLJCG FGABGLFBBPA(this MonoBehaviour IHHOBPGEDOB, float PPOMCIEAFNO, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4737DE0", Offset = "0x4736DE0", VA = "0x184737DE0")]
	public static PHEIIEMLJCG FDEGJDJDINE(this MonoBehaviour IHHOBPGEDOB, float PPOMCIEAFNO, Action MBEMGGEGPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4738020", Offset = "0x4737020", VA = "0x184738020")]
	public static PHEIIEMLJCG GOMMBNFMKLF(this MonoBehaviour IHHOBPGEDOB, float PPOMCIEAFNO, Action MBEMGGEGPFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class INNKOEBNEJH : PLPOENCGAEP
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CAFAGKPNIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public INNKOEBNEJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public CAFAGKPNIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x47379E0", Offset = "0x47369E0", VA = "0x1847379E0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JCIMCCOPNNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public INNKOEBNEJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public JCIMCCOPNNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x47379E0", Offset = "0x47369E0", VA = "0x1847379E0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly float HCJMOOEDBAE;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x473DBC0", Offset = "0x473CBC0", VA = "0x18473DBC0")]
	public INNKOEBNEJH(Behaviour JBPOCMHHIBO, float HCJMOOEDBAE, [Optional] Action AOMBMFKOPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4740A70", Offset = "0x473FA70", VA = "0x184740A70", Slot = "9")]
	protected override bool GGCLGBIHPNO(Action HCODLMJPEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4740B50", Offset = "0x473FB50", VA = "0x184740B50", Slot = "10")]
	protected override bool GKLMLHOFIPC(Action HCODLMJPEMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DKLGENMIBFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PHCPHEPKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action OFHCPHMAIPG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NMDNCBECKBB(bool DGDLOMNBBNJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NMDNCBECKBB(Action HCODLMJPEMJ, bool DGDLOMNBBNJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class PLPOENCGAEP : DKLGENMIBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IADENHLEFMF : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public IADENHLEFMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x473E7E0", Offset = "0x473D7E0", VA = "0x18473E7E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x473E880", Offset = "0x473D880", VA = "0x18473E880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Behaviour JBPOCMHHIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Action AOMBMFKOPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private JOJICMOJBFA DIMLDGPONNB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PHCPHEPKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x755EE0", Offset = "0x754EE0", VA = "0x180755EE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OFHCPHMAIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x47469A0", Offset = "0x47459A0", VA = "0x1847469A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4746900", Offset = "0x4745900", VA = "0x184746900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4746DA0", Offset = "0x4745DA0", VA = "0x184746DA0")]
	protected PLPOENCGAEP(Behaviour JBPOCMHHIBO, [Optional] Action AOMBMFKOPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4746B00", Offset = "0x4745B00", VA = "0x184746B00", Slot = "7")]
	public bool NMDNCBECKBB(bool DGDLOMNBBNJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4746AB0", Offset = "0x4745AB0", VA = "0x184746AB0", Slot = "8")]
	public bool NMDNCBECKBB(Action HCODLMJPEMJ, bool DGDLOMNBBNJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GGCLGBIHPNO(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GKLMLHOFIPC(Action HCODLMJPEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4746D40", Offset = "0x4745D40", VA = "0x184746D40")]
	protected void PKCPCPAOMHO(Action HCODLMJPEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4746B60", Offset = "0x4745B60", VA = "0x184746B60")]
	protected FPHLJBABNHP PBPJPLNGDBK(float LFBHIAPHLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4746A40", Offset = "0x4745A40", VA = "0x184746A40")]
	private void NKFFLDHGPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x47468A0", Offset = "0x47458A0", VA = "0x1847468A0")]
	[IteratorStateMachine(typeof(IADENHLEFMF))]
	private static IEnumerator<OKFJJPCKHDN> DACPPMBPOGO(float LFBHIAPHLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4746D60", Offset = "0x4745D60", VA = "0x184746D60")]
	[CompilerGenerated]
	private void PONAAPIOKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class LPJLHCDELIG : PLPOENCGAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float KGAIKGNBIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly int EMGNPHPGOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float KHDOAHNLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly float[] JPIKEPLCCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private int DEGNBHLKECD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EPPLDEKGEEK PMIOGNKJPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x54BA30", Offset = "0x54AA30", VA = "0x18054BA30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6673A0", Offset = "0x6663A0", VA = "0x1806673A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x47448E0", Offset = "0x47438E0", VA = "0x1847448E0")]
	public LPJLHCDELIG(Behaviour JBPOCMHHIBO, float ADNJONPLBIH, int EMGNPHPGOMB, [Optional] Action AOMBMFKOPBK, float KHDOAHNLHFN = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x523EC0", Offset = "0x522EC0", VA = "0x180523EC0", Slot = "9")]
	protected override bool GGCLGBIHPNO(Action HCODLMJPEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4744630", Offset = "0x4743630", VA = "0x184744630", Slot = "10")]
	protected override bool GKLMLHOFIPC(Action HCODLMJPEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4744850", Offset = "0x4743850", VA = "0x184744850")]
	private void IDJAGONGDJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FLADFHIBLFH : PLPOENCGAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly float HCJMOOEDBAE;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x473DBC0", Offset = "0x473CBC0", VA = "0x18473DBC0")]
	public FLADFHIBLFH(Behaviour JBPOCMHHIBO, float HCJMOOEDBAE, [Optional] Action AOMBMFKOPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x523EC0", Offset = "0x522EC0", VA = "0x180523EC0", Slot = "9")]
	protected override bool GGCLGBIHPNO(Action HCODLMJPEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x473DB80", Offset = "0x473CB80", VA = "0x18473DB80", Slot = "10")]
	protected override bool GKLMLHOFIPC(Action HCODLMJPEMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class CNLDJLFMOGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class OIGLNCDJKHE : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public OIGLNCDJKHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4746190", Offset = "0x4745190", VA = "0x184746190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4746290", Offset = "0x4745290", VA = "0x184746290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private PHEIIEMLJCG PKAOEJIICMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IOCAABDHIFD JBPOCMHHIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Action HELALDPMEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Action<float> GFAKPNCCKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float FPIMBOCGFLA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x47391E0", Offset = "0x47381E0", VA = "0x1847391E0")]
	public CNLDJLFMOGM(IOCAABDHIFD JBPOCMHHIBO, Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4739020", Offset = "0x4738020", VA = "0x184739020")]
	public CNLDJLFMOGM(IOCAABDHIFD JBPOCMHHIBO, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4738EA0", Offset = "0x4737EA0", VA = "0x184738EA0")]
	public CNLDJLFMOGM(IOCAABDHIFD JBPOCMHHIBO, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4738C10", Offset = "0x4737C10", VA = "0x184738C10")]
	private void NHFJAHHOFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4738A10", Offset = "0x4737A10", VA = "0x184738A10")]
	private void MEIBJKOJJPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4738840", Offset = "0x4737840", VA = "0x184738840")]
	private void FHPDIFGJIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x47386B0", Offset = "0x47376B0", VA = "0x1847386B0")]
	private void DHFODKHLJIA(string BKDCGOBDEFO, Action KEDKCCPHKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4738BA0", Offset = "0x4737BA0", VA = "0x184738BA0")]
	[IteratorStateMachine(typeof(OIGLNCDJKHE))]
	private IEnumerator<OKFJJPCKHDN> NHBAADBPDIB(Action KEDKCCPHKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x47387E0", Offset = "0x47377E0", VA = "0x1847387E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4738E20", Offset = "0x4737E20", VA = "0x184738E20")]
	[CompilerGenerated]
	private void PAGIPELNABJ(string KECOEODIMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4738990", Offset = "0x4737990", VA = "0x184738990")]
	[CompilerGenerated]
	private void LKBMFKNBOCA(string KECOEODIMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4738DA0", Offset = "0x4737DA0", VA = "0x184738DA0")]
	[CompilerGenerated]
	private void OLJLJOMBECB(string KECOEODIMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class NNDFMOLPBIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LDFBDCHLEIG : IEnumerator<OKFJJPCKHDN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private OKFJJPCKHDN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private OKFJJPCKHDN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
		[DebuggerHidden]
		public LDFBDCHLEIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4741A70", Offset = "0x4740A70", VA = "0x184741A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4741B70", Offset = "0x4740B70", VA = "0x184741B70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private PHEIIEMLJCG PKAOEJIICMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private MonoBehaviour IHHOBPGEDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Action HELALDPMEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Action<float> GFAKPNCCKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private float FPIMBOCGFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool DBLHINMCIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4745CB0", Offset = "0x4744CB0", VA = "0x184745CB0")]
	public NNDFMOLPBIP(MonoBehaviour IHHOBPGEDOB, Action HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4745E70", Offset = "0x4744E70", VA = "0x184745E70")]
	public NNDFMOLPBIP(MonoBehaviour IHHOBPGEDOB, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4745B10", Offset = "0x4744B10", VA = "0x184745B10")]
	public NNDFMOLPBIP(MonoBehaviour IHHOBPGEDOB, float ACLMAOOFNHJ, Action<float> HELALDPMEKB, CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE, bool DBLHINMCIFJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4745900", Offset = "0x4744900", VA = "0x184745900")]
	private void NHFJAHHOFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4745680", Offset = "0x4744680", VA = "0x184745680")]
	private void MEIBJKOJJPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x47454B0", Offset = "0x47444B0", VA = "0x1847454B0")]
	private void FHPDIFGJIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4745320", Offset = "0x4744320", VA = "0x184745320")]
	private void DHFODKHLJIA(string BKDCGOBDEFO, Action KEDKCCPHKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4745890", Offset = "0x4744890", VA = "0x184745890")]
	[IteratorStateMachine(typeof(LDFBDCHLEIG))]
	private IEnumerator<OKFJJPCKHDN> NHBAADBPDIB(Action KEDKCCPHKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4745450", Offset = "0x4744450", VA = "0x184745450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4745600", Offset = "0x4744600", VA = "0x184745600")]
	[CompilerGenerated]
	private void LINMJANLMEC(string KECOEODIMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4745A90", Offset = "0x4744A90", VA = "0x184745A90")]
	[CompilerGenerated]
	private void PAJIILPIBNM(string KECOEODIMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4745810", Offset = "0x4744810", VA = "0x184745810")]
	[CompilerGenerated]
	private void NBGMJNDLDFM(string KECOEODIMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface KAHBJOENOGC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int LNGEFDKGBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class EKBDHHMBHOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static readonly EKBDHHMBHOE ACKJGANEAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly Action AILKNMINMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool BMBDJGBFCFJ;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x684A70", Offset = "0x683A70", VA = "0x180684A70")]
	public EKBDHHMBHOE(Action AILKNMINMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x473C1A0", Offset = "0x473B1A0", VA = "0x18473C1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface MMIPHMEFONG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T OGNMMFGGOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FEDLBHFHBOP(Action<T> BDDIDFPAAKG);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable FEDLBHFHBOP(UnityEngine.Object JBPOCMHHIBO, Action<T> BDDIDFPAAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface KNFPKNLCPEA<T> : global::MMIPHMEFONG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T OGNMMFGGOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class FNPAHKDODBA<T> : global::KNFPKNLCPEA<T>, global::MMIPHMEFONG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EPPIFEIGHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::FNPAHKDODBA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public global::KNHNPGHCLLP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1C193A0", Offset = "0x1C183A0", VA = "0x181C193A0")]
		public EPPIFEIGHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x352E640", Offset = "0x352D640", VA = "0x18352E640")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static GameObject JBPKDKJDJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<global::KNHNPGHCLLP<UnityEngine.Object, Action<T>>> CBLBLMHFGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private T AADGMNPHFBO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object LHAOILINEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x35303A0", Offset = "0x352F3A0", VA = "0x1835303A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T OGNMMFGGOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x651BA0", Offset = "0x650BA0", VA = "0x180651BA0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3530C90", Offset = "0x352FC90", VA = "0x183530C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x352FD90", Offset = "0x352ED90", VA = "0x18352FD90")]
	private static bool CKNJEOPCHKJ(T HGNFJBMPOBI, T EJCAMPCKMFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3530E30", Offset = "0x352FE30", VA = "0x183530E30")]
	public FNPAHKDODBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3530D90", Offset = "0x352FD90", VA = "0x183530D90")]
	public FNPAHKDODBA(T LKKCMCGEAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3530170", Offset = "0x352F170", VA = "0x183530170")]
	public void KFEAEGECGAA(T FHADNJDAGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x352FE00", Offset = "0x352EE00", VA = "0x18352FE00", Slot = "7")]
	public IDisposable FEDLBHFHBOP(Action<T> BDDIDFPAAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x352FFD0", Offset = "0x352EFD0", VA = "0x18352FFD0", Slot = "8")]
	public IDisposable FEDLBHFHBOP(UnityEngine.Object JBPOCMHHIBO, Action<T> BDDIDFPAAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x35305B0", Offset = "0x352F5B0", VA = "0x1835305B0")]
	private void KPENNOOEGOB()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<FJBOGPOIKDI, Scheduler>, FJBOGPOIKDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private class CODOOEPNFNH : KAHBJOENOGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public LGPCMEMPADD OEFKEIOOICB;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int LNGEFDKGBOK
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x523ED0", Offset = "0x522ED0", VA = "0x180523ED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x523EE0", Offset = "0x522EE0", VA = "0x180523EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4739650", Offset = "0x4738650", VA = "0x184739650")]
			public static OKFJJPCKHDN NNBGECPAOCL(IEnumerator<OKFJJPCKHDN> ILNPLKMPOAE, INIEOBJFBFA OEPJIAOCMFO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4739570", Offset = "0x4738570", VA = "0x184739570")]
			public OKFJJPCKHDN NNBGECPAOCL(INIEOBJFBFA[] DFHBDIIGBAJ, IEnumerator<OKFJJPCKHDN>[] BCLGGMPOJIK, OKFJJPCKHDN[] GMEEMOAMJOB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x47393A0", Offset = "0x47383A0", VA = "0x1847393A0")]
			public void EKOOOBGJPFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x47393D0", Offset = "0x47383D0", VA = "0x1847393D0")]
			public void ELLGMJDEPEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x47394A0", Offset = "0x47384A0", VA = "0x1847394A0")]
			public void FPLMAMNHAEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x47393A0", Offset = "0x47383A0", VA = "0x1847393A0")]
			public void LIPMGAILBGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
			public CODOOEPNFNH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private sealed class LGPCMEMPADD
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct BKOEGLDJBEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public CODOOEPNFNH IDIIPHMNACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public IOCAABDHIFD GJANMEIAIGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public INIEOBJFBFA EAHLFLFHLAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public IEnumerator<OKFJJPCKHDN> DJIIJGNLKIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public OKFJJPCKHDN BLFLPCKONGD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public JIDGKFLHICB COMIOINGDDH;
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct EIJNAMHCFGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public CBMBJKAIKNP.EBEPLJKMFIO NKDBDMAOOGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public List<BKOEGLDJBEO> BIEIGNACCLL;
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class JBJHBCAFIEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public LGPCMEMPADD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public IOCAABDHIFD context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public CODOOEPNFNH routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public JIDGKFLHICB coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public INIEOBJFBFA promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public OKFJJPCKHDN currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public IEnumerator<OKFJJPCKHDN> coroutine;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
				public JBJHBCAFIEG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x4740C30", Offset = "0x473FC30", VA = "0x184740C30")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class HINALKAKLBM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public CODOOEPNFNH schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public LGPCMEMPADD <>4__this;

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
				public HINALKAKLBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x473E7A0", Offset = "0x473D7A0", VA = "0x18473E7A0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004E")]
			[CompilerGenerated]
			private sealed class OEDLCBCLMIB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public CODOOEPNFNH schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public LGPCMEMPADD <>4__this;

				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
				public OEDLCBCLMIB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x4746030", Offset = "0x4745030", VA = "0x184746030")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004F")]
			[CompilerGenerated]
			private sealed class PFHKIGJJNDD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public CODOOEPNFNH schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public LGPCMEMPADD <>4__this;

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
				public PFHKIGJJNDD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x4746800", Offset = "0x4745800", VA = "0x184746800")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private readonly CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private bool[] FGAPLJIPBEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<JIDGKFLHICB> ANMMMHBGBLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<float> JPKKMHEAMMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> BICBBHFJOKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> FPCBBAHDFMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private NativeArray<int> LBPHIJBHKPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private NativeArray<int> FAKNJJEMBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private NativeArray<int> LKPFDJLELMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private CODOOEPNFNH[] LPEFHCPIFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private INIEOBJFBFA[] DFHBDIIGBAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private IOCAABDHIFD[] NBBNHFOEKAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private IEnumerator<OKFJJPCKHDN>[] AFODCFHPFOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private OKFJJPCKHDN[] NMDCLJIIDFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private int IPHCKPDFKLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int EOFEALDJCNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private readonly int OPJAJIDBHAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private float PBFEALJKMLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private LNKFGCDMPJB GCIBGIGAODE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private JobHandle LIIKCJPBEHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<CODOOEPNFNH> BFADMHOPPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool MLIMHAHLPCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private List<Action> EMNFAOHEGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private List<Action> GNDNEPJOOGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private bool KCLCJHGBFJG;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public EIJNAMHCFGO[] GLBEKGAMNCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x8CDA00", Offset = "0x8CCA00", VA = "0x1808CDA00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int KPDJMGFFABL
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0xB25500", Offset = "0xB24500", VA = "0x180B25500")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x47432B0", Offset = "0x47422B0", VA = "0x1847432B0")]
			private static int LGOAPNGDHAB(CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4743990", Offset = "0x4742990", VA = "0x184743990")]
			public LGPCMEMPADD(CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4743800", Offset = "0x4742800", VA = "0x184743800")]
			private void PHBPMHMALEI(ref int KFMDKPIDGBJ, int AOKOLINBNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4741BC0", Offset = "0x4740BC0", VA = "0x184741BC0")]
			public void AFDLNAKBBHO(IOCAABDHIFD JBPOCMHHIBO, OKFJJPCKHDN JKLDHNNLCNE, IEnumerator<OKFJJPCKHDN> ILNPLKMPOAE, INIEOBJFBFA OEPJIAOCMFO, [Optional] CODOOEPNFNH CKFNFGOBAPO, JIDGKFLHICB FBGPGOKBJGH = JIDGKFLHICB.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x47430C0", Offset = "0x47420C0", VA = "0x1847430C0")]
			public void KODJDEOAIHJ(IEnumerable<BKOEGLDJBEO> EJHFJPGFIMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4742920", Offset = "0x4741920", VA = "0x184742920")]
			private BKOEGLDJBEO HNKPFOFFBGJ(int MHFNJGHFIDG)
			{
				return default(BKOEGLDJBEO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x47424F0", Offset = "0x47414F0", VA = "0x1847424F0")]
			private void GOGPLGAFHBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1BB6810", Offset = "0x1BB5810", VA = "0x181BB6810")]
			private static void NNBHNBCAPCO<T>(int MHFNJGHFIDG, T[] CCKGLNCGFID, int BGJKLECOEBO, [Optional] T BHIIGGKKMGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x1BB67F0", Offset = "0x1BB57F0", VA = "0x181BB67F0")]
			private static void NNBHNBCAPCO<T>(int MHFNJGHFIDG, NativeArray<T> CCKGLNCGFID, int BGJKLECOEBO, [Optional] T BHIIGGKKMGD) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x4742E20", Offset = "0x4741E20", VA = "0x184742E20")]
			private void KIHCEADINBF(IEnumerable<BKOEGLDJBEO> EJHFJPGFIMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x47433A0", Offset = "0x47423A0", VA = "0x1847433A0")]
			private void MEHEODFODOE(BKOEGLDJBEO JHAPAGHLNPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4743540", Offset = "0x4742540", VA = "0x184743540")]
			private LOCENPOBNPO OBALEOANBLP(int FJKOPLDBNNF)
			{
				return default(LOCENPOBNPO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4742300", Offset = "0x4741300", VA = "0x184742300")]
			public void ELFDCCBCLPA(float OPJNLELKKJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4742DA0", Offset = "0x4741DA0", VA = "0x184742DA0")]
			private void KCFEAGNAKNH(Action HGNFJBMPOBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x4741D20", Offset = "0x4740D20", VA = "0x184741D20")]
			private void AMAEBHLGBFM(Action HGNFJBMPOBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x4741DA0", Offset = "0x4740DA0", VA = "0x184741DA0")]
			public void ANKBKFDBFGG(float OPJNLELKKJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4743460", Offset = "0x4742460", VA = "0x184743460")]
			public void NIICFFGCHPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x47432E0", Offset = "0x47422E0", VA = "0x1847432E0")]
			public void LIPMGAILBGM(CODOOEPNFNH FMNMEBFFGDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x4742860", Offset = "0x4741860", VA = "0x184742860")]
			public void HMFHGPANMHM(CODOOEPNFNH FMNMEBFFGDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4742240", Offset = "0x4741240", VA = "0x184742240")]
			public void CAPFILHPGKO(CODOOEPNFNH FMNMEBFFGDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[BurstCompile]
		public struct LNKFGCDMPJB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[ReadOnly]
			public float NNGMNADMHJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			[ReadOnly]
			public int POKAHPNGBNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private NativeArray<int> BFOBLBFEMIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private NativeArray<int> FKLHJCHKBNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private NativeArray<int> FBENPMPNBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[ReadOnly]
			public NativeArray<JIDGKFLHICB> FIHFMCDHMDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[ReadOnly]
			public NativeArray<float> MKNLFEDMNPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			[WriteOnly]
			public NativeArray<int> LBPHIJBHKPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			[WriteOnly]
			public NativeArray<int> BICBBHFJOKC;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4743F10", Offset = "0x4742F10", VA = "0x184743F10")]
			public static LNKFGCDMPJB ANENLEADNCN(int LACMJNDLLPE, float OPJNLELKKJK, NativeArray<JIDGKFLHICB> JOEGLCFBPHI, NativeArray<float> KHLFAIBFKKE, NativeArray<int> OPLDJJOKJMG, NativeArray<int> NIOCGKGJHKM, NativeArray<int> HJCNFKCPKFF, NativeArray<int> FKLHJCHKBNI, NativeArray<int> FBENPMPNBDM)
			{
				return default(LNKFGCDMPJB);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4744210", Offset = "0x4743210", VA = "0x184744210", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x47442F0", Offset = "0x47432F0", VA = "0x1847442F0")]
			private bool JCFJELFDNPG(int EKKABPEEACK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x4744400", Offset = "0x4743400", VA = "0x184744400")]
			private void NJGELHEJLDD(NativeArray<int> GHIBHLAGFOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4744430", Offset = "0x4743430", VA = "0x184744430")]
			private int NOKJDLKJOPN(int IGHKMJDKOMO, int BOCIKKFOLHC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4744330", Offset = "0x4743330", VA = "0x184744330")]
			private void KLPLHADPLPJ(NativeArray<int> GHIBHLAGFOL, int IBPOLIAADBO, int HMACIAPLGOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x4743FE0", Offset = "0x4742FE0", VA = "0x184743FE0")]
			private void EMMMPIJDEGJ(NativeArray<int> GHIBHLAGFOL, int DOGPNLCJGCL, int ALGEDLNJJHM, int OALKJKDDGHJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private sealed class DHJGHPFOIGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private readonly INIEOBJFBFA OEPJIAOCMFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private readonly Behaviour JBPOCMHHIBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private readonly bool DJOJPDGCENJ;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<OKFJJPCKHDN> DJIIJGNLKIP
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x5231D0", Offset = "0x5221D0", VA = "0x1805231D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x523490", Offset = "0x522490", VA = "0x180523490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public OKFJJPCKHDN BLFLPCKONGD
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5234A0", Offset = "0x5224A0", VA = "0x1805234A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool KDCBEIOFKCK
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x473B700", Offset = "0x473A700", VA = "0x18473B700")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool JFJECANIJNP
			{
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x7C6DC0", Offset = "0x7C5DC0", VA = "0x1807C6DC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0xF32E00", Offset = "0xF31E00", VA = "0x180F32E00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string FIMOCMKAMPO
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x524010", Offset = "0x523010", VA = "0x180524010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x524020", Offset = "0x523020", VA = "0x180524020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float KHCFBMGMGHN
			{
				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x116CE80", Offset = "0x116BE80", VA = "0x18116CE80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x116CDC0", Offset = "0x116BDC0", VA = "0x18116CDC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x473BB50", Offset = "0x473AB50", VA = "0x18473BB50")]
			public DHJGHPFOIGB(IEnumerator<OKFJJPCKHDN> ILNPLKMPOAE, Behaviour JBPOCMHHIBO, INIEOBJFBFA OEPJIAOCMFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x473B820", Offset = "0x473A820", VA = "0x18473B820")]
			public OKFJJPCKHDN NNBGECPAOCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x473BA30", Offset = "0x473AA30", VA = "0x18473BA30")]
			public bool PALIGAAGIIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x473B790", Offset = "0x473A790", VA = "0x18473B790")]
			public void LIPMGAILBGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x473BAC0", Offset = "0x473AAC0", VA = "0x18473BAC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x16801F0", Offset = "0x167F1F0", VA = "0x1816801F0")]
			[CompilerGenerated]
			private void OMGIPKBPJOH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class INIEOBJFBFA : MOIAHMEJAAB, PHEIIEMLJCG, JOJICMOJBFA, FPHLJBABNHP, IEnumerator, OKFJJPCKHDN, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private CBMBJKAIKNP.EBEPLJKMFIO BCIMMHIDAHD;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private CBMBJKAIKNP.EBEPLJKMFIO DBMFHCKAEGA
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x548180", Offset = "0x547180", VA = "0x180548180", Slot = "23")]
				get
				{
					return default(CBMBJKAIKNP.EBEPLJKMFIO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public CBMBJKAIKNP.EBEPLJKMFIO OEFKEIOOICB
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x548180", Offset = "0x547180", VA = "0x180548180")]
				get
				{
					return default(CBMBJKAIKNP.EBEPLJKMFIO);
				}
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x6EA8E0", Offset = "0x6E98E0", VA = "0x1806EA8E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float BFCJHKGGNHI
			{
				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0xE53A90", Offset = "0xE52A90", VA = "0x180E53A90", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x47409F0", Offset = "0x473F9F0", VA = "0x1847409F0", Slot = "24")]
			private bool LPBLEEPGCEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x47409E0", Offset = "0x473F9E0", VA = "0x1847409E0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4740A10", Offset = "0x473FA10", VA = "0x184740A10")]
			public INIEOBJFBFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private enum LOCENPOBNPO : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class ICNDNEIMEGE : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			public enum NNFPCDOOKLO
			{
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000056")]
			public struct LBBMELHABFM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public CBMBJKAIKNP.EBEPLJKMFIO NKDBDMAOOGE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public NNFPCDOOKLO CDNLHNPBAJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public List<DHJGHPFOIGB> IHDGHPPICMP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private static readonly NNFPCDOOKLO[] OMOPIBLFPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly CBMBJKAIKNP.EBEPLJKMFIO BAIJEPJLIHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private bool DCOCGEJKDLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly DHJGHPFOIGB[] MCJFODFNNHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly List<DHJGHPFOIGB> BLNFOEPIPGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly Stack<int> JHLJEKJPGLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private readonly List<DHJGHPFOIGB> DGFCGFLMACO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private readonly Stack<int> DMHFOBNDALI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private bool KCLCJHGBFJG;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public LBBMELHABFM[,] ODGOJFLIGND
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0x536D70", Offset = "0x535D70", VA = "0x180536D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int KPDJMGFFABL
			{
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0x473F520", Offset = "0x473E520", VA = "0x18473F520")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x473FD30", Offset = "0x473ED30", VA = "0x18473FD30")]
			public ICNDNEIMEGE(CBMBJKAIKNP.EBEPLJKMFIO AJHLNLNFPBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x473E8D0", Offset = "0x473D8D0", VA = "0x18473E8D0")]
			public void AGLCNFCPMAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x473F690", Offset = "0x473E690", VA = "0x18473F690")]
			public void NHANNOKCEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x473EEC0", Offset = "0x473DEC0", VA = "0x18473EEC0")]
			private void CJCCKGJMBPH(IReadOnlyList<DHJGHPFOIGB> NKMFGNDIANK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x473ECB0", Offset = "0x473DCB0", VA = "0x18473ECB0")]
			public void BBGHENJFJOI(DHJGHPFOIGB ILNPLKMPOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x473E8E0", Offset = "0x473D8E0", VA = "0x18473E8E0")]
			public void AKIHDAIDMJH(IList<DHJGHPFOIGB> BCLGGMPOJIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x473F130", Offset = "0x473E130", VA = "0x18473F130")]
			public void GPHHJHCODHE(IList<DHJGHPFOIGB> BCLGGMPOJIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x473EDD0", Offset = "0x473DDD0", VA = "0x18473EDD0")]
			private void BLPBLMODGNO(DHJGHPFOIGB ILNPLKMPOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x473F3B0", Offset = "0x473E3B0", VA = "0x18473F3B0")]
			private void LBNANMPEFGJ(IList<DHJGHPFOIGB> BCLGGMPOJIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x473EB60", Offset = "0x473DB60", VA = "0x18473EB60")]
			private LOCENPOBNPO ANNCLKCFMML(DHJGHPFOIGB ILNPLKMPOAE)
			{
				return default(LOCENPOBNPO);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x473F6A0", Offset = "0x473E6A0", VA = "0x18473F6A0")]
			public void OKEBEOJEDHO(float OPJNLELKKJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x473F870", Offset = "0x473E870", VA = "0x18473F870")]
			public void PFBKBEEKGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x473FA70", Offset = "0x473EA70", VA = "0x18473FA70")]
			private void PMAPGAPDFIJ(List<DHJGHPFOIGB> BCLGGMPOJIK, Stack<int> EGCGIPCEBOO, bool KMLGINILKPD, float FCKAFNFMMFC = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x473EFF0", Offset = "0x473DFF0", VA = "0x18473EFF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x473F750", Offset = "0x473E750", VA = "0x18473F750")]
			private void ONHLNDOFIHN(List<DHJGHPFOIGB> BCLGGMPOJIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[Flags]
		public enum JIDGKFLHICB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class OMHBEAONMEC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x5231C0", Offset = "0x5221C0", VA = "0x1805231C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6347D0", Offset = "0x6337D0", VA = "0x1806347D0")]
			[DebuggerHidden]
			public OMHBEAONMEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x4746730", Offset = "0x4745730", VA = "0x184746730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x47467B0", Offset = "0x47457B0", VA = "0x1847467B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private const JIDGKFLHICB OMGOGIKLEHN = JIDGKFLHICB.Cancelled | JIDGKFLHICB.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static readonly CBMBJKAIKNP.EBEPLJKMFIO[] LBPAALGNGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private ICNDNEIMEGE[] MJANOEONLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private LGPCMEMPADD[] GPPBANIPKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private Coroutine GFBGJAJGEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private WaitForEndOfFrame EBHLGAGCKMB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public CBMBJKAIKNP.EBEPLJKMFIO FLFBBKLKEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x5AF670", Offset = "0x5AE670", VA = "0x1805AF670")]
			[CompilerGenerated]
			get
			{
				return default(CBMBJKAIKNP.EBEPLJKMFIO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x6A1CF0", Offset = "0x6A0CF0", VA = "0x1806A1CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OOCPJDDBFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x7C6AC0", Offset = "0x7C5AC0", VA = "0x1807C6AC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x1F38E80", Offset = "0x1F37E80", VA = "0x181F38E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int KPDJMGFFABL
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x47488F0", Offset = "0x47478F0", VA = "0x1847488F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4747600", Offset = "0x4746600", VA = "0x184747600")]
		public static PHEIIEMLJCG GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47470E0", Offset = "0x47460E0", VA = "0x1847470E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4747770", Offset = "0x4746770", VA = "0x184747770", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4747730", Offset = "0x4746730", VA = "0x184747730")]
		private ICNDNEIMEGE OCOHKCPPIKG(CBMBJKAIKNP.EBEPLJKMFIO LDJDMLKKJPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x913840", Offset = "0x912840", VA = "0x180913840")]
		private LGPCMEMPADD PHPELIPDIKD(CBMBJKAIKNP.EBEPLJKMFIO LDJDMLKKJPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4747C30", Offset = "0x4746C30", VA = "0x184747C30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4747BF0", Offset = "0x4746BF0", VA = "0x184747BF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x47486C0", Offset = "0x47476C0", VA = "0x1847486C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x47476A0", Offset = "0x47466A0", VA = "0x1847476A0")]
		private void JCPJLCLOIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x47475E0", Offset = "0x47465E0", VA = "0x1847475E0")]
		private void ELMJJKOCLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x47475F0", Offset = "0x47465F0", VA = "0x1847475F0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4747720", Offset = "0x4746720", VA = "0x184747720")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4747E70", Offset = "0x4746E70", VA = "0x184747E70")]
		private void PLPNBBDDHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x47476B0", Offset = "0x47466B0", VA = "0x1847476B0")]
		[IteratorStateMachine(typeof(OMHBEAONMEC))]
		private IEnumerator LNKDGADBEPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4747FB0", Offset = "0x4746FB0", VA = "0x184747FB0", Slot = "7")]
		public PHEIIEMLJCG Run(IEnumerator<OKFJJPCKHDN> AADCFPPBCFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4747FC0", Offset = "0x4746FC0", VA = "0x184747FC0", Slot = "8")]
		public PHEIIEMLJCG Run(Behaviour JBPOCMHHIBO, IEnumerator<OKFJJPCKHDN> AADCFPPBCFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4747E80", Offset = "0x4746E80", VA = "0x184747E80", Slot = "9")]
		public PHEIIEMLJCG RunJobbed(IOCAABDHIFD JBPOCMHHIBO, IEnumerator<OKFJJPCKHDN> AADCFPPBCFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4747580", Offset = "0x4746580", VA = "0x184747580", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x47481F0", Offset = "0x47471F0", VA = "0x1847481F0")]
		public void UpdateQueue(CBMBJKAIKNP.EBEPLJKMFIO IHNABJFNMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4747CB0", Offset = "0x4746CB0", VA = "0x184747CB0")]
		private void PJMCFJLPLDD(ICNDNEIMEGE MBCIGJLOPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4746FC0", Offset = "0x4745FC0", VA = "0x184746FC0")]
		private void AEMLDFOIBHE(LGPCMEMPADD MBCIGJLOPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4748880", Offset = "0x4747880", VA = "0x184748880")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal static class HGOJENLMPPP
{
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x473E600", Offset = "0x473D600", VA = "0x18473E600")]
	[OGFMMECDAHJ]
	private static void AMFLIFGPNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public sealed class PHFGPDCLLMD : EPPLDEKGEEK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float JGHPALMECCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4746840", Offset = "0x4745840", VA = "0x184746840", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float EOKHAMDNKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4746850", Offset = "0x4745850", VA = "0x184746850", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float ABJEGHHPLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4746870", Offset = "0x4745870", VA = "0x184746870", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int FAGBOGEGBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4746860", Offset = "0x4745860", VA = "0x184746860", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double EKHAANLGPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4746880", Offset = "0x4745880", VA = "0x184746880", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public PHFGPDCLLMD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class EMILBIDIJON
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static byte[] MHCBODEMNDA;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static int DAIOMNBGJFA;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static int DDGCDEKJNBF;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static BigInteger CONMBDBFJHL;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public EMILBIDIJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x473C5D0", Offset = "0x473B5D0", VA = "0x18473C5D0")]
	private static string PDOGHHMIGDK(byte[] EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x473C2A0", Offset = "0x473B2A0", VA = "0x18473C2A0")]
	public static string KPIGCAGDHMH(byte[] BGILCKNBLBG, bool LCPNKOKDLIC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
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

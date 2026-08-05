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
		private delegate List<PlayerLoopSystem> AGMAJOLPIJO(List<PlayerLoopSystem> HCJLDOOPPLJ, int GBNOIMCPDEF);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct PCIHFNEANFJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct HFKNHCNFNDA
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static KNOFHMGDNMF LLGLLADJCCN;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x42D02D0", Offset = "0x42CF2D0", VA = "0x1842D02D0")]
				public static PlayerLoopSystem CNIKKALLKFP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct MKGIBFKBBPD
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static KNOFHMGDNMF EEMIHCOECNH;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x42D6850", Offset = "0x42D5850", VA = "0x1842D6850")]
				public static PlayerLoopSystem CNIKKALLKFP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct JNHEAJNBFKI
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static KNOFHMGDNMF DCLNFKFIHIC;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x42D2D80", Offset = "0x42D1D80", VA = "0x1842D2D80")]
				public static PlayerLoopSystem CNIKKALLKFP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct BGIOBOOKPPM
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static KNOFHMGDNMF ENLFHOPGFEP;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x42CB700", Offset = "0x42CA700", VA = "0x1842CB700")]
				public static PlayerLoopSystem CNIKKALLKFP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct DDJJFAHGPDD
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class PHNPIHGLCDD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public NAGCJGKPANM.NJAHIOPBCJC key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
					public PHNPIHGLCDD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x42DA2D0", Offset = "0x42D92D0", VA = "0x1842DA2D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable GHHGHMBDFIM;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x42CDC10", Offset = "0x42CCC10", VA = "0x1842CDC10")]
				public static PlayerLoopSystem MIOMBMNBGMI(NAGCJGKPANM.NJAHIOPBCJC GOLKIAIKMMJ)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct DBICCPKDMJP
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class OMKMMCMJMLL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public NAGCJGKPANM.NJAHIOPBCJC key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
					public OMKMMCMJMLL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x42D9BE0", Offset = "0x42D8BE0", VA = "0x1842D9BE0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x42CDAF0", Offset = "0x42CCAF0", VA = "0x1842CDAF0")]
				public static PlayerLoopSystem MIOMBMNBGMI(NAGCJGKPANM.NJAHIOPBCJC GOLKIAIKMMJ)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MPDHJJBANLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public MPDHJJBANLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x42D6A20", Offset = "0x42D5A20", VA = "0x1842D6A20")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool ABAFKMIGDLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool PMLPOMCCOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x42CD560", Offset = "0x42CC560", VA = "0x1842CD560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x42CD520", Offset = "0x42CC520", VA = "0x1842CD520")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x42CC2A0", Offset = "0x42CB2A0", VA = "0x1842CC2A0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x42CD920", Offset = "0x42CC920", VA = "0x1842CD920")]
		private static void PGKHFEIDNGG(NAGCJGKPANM.NJAHIOPBCJC GOLKIAIKMMJ, ref PlayerLoopSystem IJOPOBKNDJN, Type KPLPHNKPNCO, Type PBMGMGNFNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x42CD5A0", Offset = "0x42CC5A0", VA = "0x1842CD5A0")]
		private static void NKMKLCJJEKG(ref PlayerLoopSystem IJOPOBKNDJN, Type KPLPHNKPNCO, Type PBMGMGNFNAI, AGMAJOLPIJO MADCNEMKFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x42CC180", Offset = "0x42CB180", VA = "0x1842CC180")]
		private static void AJJKMOLLLNO(ref PlayerLoopSystem IJOPOBKNDJN, Type KPLPHNKPNCO, Type PBMGMGNFNAI, PlayerLoopSystem? EEBAJPCGMBF, PlayerLoopSystem? DJNINFGLAPI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NAGCJGKPANM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum NJAHIOPBCJC
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
	public class IKAMJDFGCCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly NJAHIOPBCJC NOEDLMNIMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly ANAGDJDPPCO PEOOHAJCHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long BDDFJGFJKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long BHFEJKKIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long BBKDMHFDNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int OKKBNNLACEA;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x42D1BA0", Offset = "0x42D0BA0", VA = "0x1842D1BA0")]
		public IKAMJDFGCCI(NJAHIOPBCJC PJLDPBILJBB, int MNCAEIHGAJP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x42D1840", Offset = "0x42D0840", VA = "0x1842D1840")]
		public void BIKLMKANMPL(int NDBMGCECBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x42D1860", Offset = "0x42D0860", VA = "0x1842D1860")]
		public void BKFACAGBAIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x42D1AA0", Offset = "0x42D0AA0", VA = "0x1842D1AA0")]
		public void NCBAPDFENMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42D18D0", Offset = "0x42D08D0", VA = "0x1842D18D0")]
		public void FCGGENENIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x42D1B00", Offset = "0x42D0B00", VA = "0x1842D1B00")]
		public double OIGJKFHDABL(int IFMOFDLMPHH)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int EIDPJEKMKPM = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static NJAHIOPBCJC[] PJLIJNDKPON;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static IKAMJDFGCCI[] CKEDHFIPAHF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x42D6B20", Offset = "0x42D5B20", VA = "0x1842D6B20")]
	public static IKAMJDFGCCI AFHKPBHBJFD(NJAHIOPBCJC GOLKIAIKMMJ, int MNCAEIHGAJP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x42D6D80", Offset = "0x42D5D80", VA = "0x1842D6D80")]
	public static IKAMJDFGCCI GOJDPGJBAGK(NJAHIOPBCJC GOLKIAIKMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x42D6CD0", Offset = "0x42D5CD0", VA = "0x1842D6CD0")]
	public static void FDGBNNBBBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ANAGDJDPPCO : MGENDBCALGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int BDKHLGONBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> DCFBFPNLMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double PABKDOMHIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double GDLKCENOMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double KNOCBLKAELA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OAADMOHPEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x42C9D70", Offset = "0x42C8D70", VA = "0x1842C9D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LKJOFAKBPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x42C9EB0", Offset = "0x42C8EB0", VA = "0x1842C9EB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EAKLCKLMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x11C19E0", Offset = "0x11C09E0", VA = "0x1811C19E0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MAIKMGICFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3030B90", Offset = "0x302FB90", VA = "0x183030B90", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x42C9F80", Offset = "0x42C8F80", VA = "0x1842C9F80")]
	public ANAGDJDPPCO(int AEFEHLGHNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42C9DB0", Offset = "0x42C8DB0", VA = "0x1842C9DB0", Slot = "4")]
	public void GLLCGCBPOAP(double PGEGNPPIILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42C9F10", Offset = "0x42C8F10", VA = "0x1842C9F10", Slot = "5")]
	public void GPFNGKKPKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ICDPIPDILOA : MGENDBCALGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long PDCIKKOCPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double JFOFKNFFBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double NPNFAPAALKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double BLJIMBBBFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double MCGPKAGBNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double PABKDOMHIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double GDLKCENOMFN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long NKNPCMBDPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EAKLCKLMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3334ED0", Offset = "0x3333ED0", VA = "0x183334ED0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MAIKMGICFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x888710", Offset = "0x887710", VA = "0x180888710", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JKGEAHNPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3030B90", Offset = "0x302FB90", VA = "0x183030B90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ELENALCBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3030B80", Offset = "0x302FB80", VA = "0x183030B80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double LKJOFAKBPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3334E00", Offset = "0x3333E00", VA = "0x183334E00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x42D1560", Offset = "0x42D0560", VA = "0x1842D1560", Slot = "4")]
	public void GLLCGCBPOAP(double PGEGNPPIILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x42D1680", Offset = "0x42D0680", VA = "0x1842D1680", Slot = "5")]
	public void GPFNGKKPKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x42D16C0", Offset = "0x42D06C0", VA = "0x1842D16C0")]
	public ICDPIPDILOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MGENDBCALGG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LKJOFAKBPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double EAKLCKLMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double MAIKMGICFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLLCGCBPOAP(double PGEGNPPIILP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPFNGKKPKEA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HOJPGJGIEIE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface OFKFEFKFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool BLFLMEFAPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BCGFEGFKBJH();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void APPKIGJKKOB();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class PCFGEDEHIEL<TPromise, TMainThreadPromise> : OFKFEFKFCOM where TPromise : BKMNEANDFIL where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise JLCKOKPHOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise IOKOLFDFGIJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise EEBBNBOJJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x24DB190", Offset = "0x24DA190", VA = "0x1824DB190")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool BLFLMEFAPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x24DB140", Offset = "0x24DA140", VA = "0x1824DB140", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x203A9A0", Offset = "0x20399A0", VA = "0x18203A9A0")]
		protected PCFGEDEHIEL(TPromise JLCKOKPHOOC, TMainThreadPromise ADEHFEOIDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x24DB110", Offset = "0x24DA110", VA = "0x1824DB110", Slot = "5")]
		public void BCGFEGFKBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D80FC0", Offset = "0x1D7FFC0", VA = "0x181D80FC0", Slot = "6")]
		public void APPKIGJKKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void BPKNMBAGLHI(TPromise JLCKOKPHOOC);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void HKIDOIDFBKJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class PGLDKPNMJGG<T> : PCFGEDEHIEL<global::IDCJFNACHEM<T>, global::NAIPFLHHPNG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x24DB400", Offset = "0x24DA400", VA = "0x1824DB400")]
		public PGLDKPNMJGG(global::IDCJFNACHEM<T> JLCKOKPHOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x24DB1F0", Offset = "0x24DA1F0", VA = "0x1824DB1F0", Slot = "7")]
		protected override void BPKNMBAGLHI(global::IDCJFNACHEM<T> JLCKOKPHOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x24DB340", Offset = "0x24DA340", VA = "0x1824DB340", Slot = "8")]
		protected override void HKIDOIDFBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x24DB3A0", Offset = "0x24DA3A0", VA = "0x1824DB3A0")]
		[CompilerGenerated]
		private void NDPCHPJKFCK(T NCHHACLBALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x24DB3D0", Offset = "0x24DA3D0", VA = "0x1824DB3D0")]
		[CompilerGenerated]
		private void PBBBNNDGONN(string GEJGBLPCCME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class IBPJLBDEMPD : PCFGEDEHIEL<BKMNEANDFIL, GMDJOGAHHIL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x42D14F0", Offset = "0x42D04F0", VA = "0x1842D14F0")]
		public IBPJLBDEMPD(BKMNEANDFIL JLCKOKPHOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x42D13D0", Offset = "0x42D03D0", VA = "0x1842D13D0", Slot = "7")]
		protected override void BPKNMBAGLHI(BKMNEANDFIL JLCKOKPHOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x42D14A0", Offset = "0x42D04A0", VA = "0x1842D14A0", Slot = "8")]
		protected override void HKIDOIDFBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCA31E0", Offset = "0xCA21E0", VA = "0x180CA31E0")]
		[CompilerGenerated]
		private void NDPCHPJKFCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x18D90D0", Offset = "0x18D80D0", VA = "0x1818D90D0")]
		[CompilerGenerated]
		private void PBBBNNDGONN(string GEJGBLPCCME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class HGHBCFEJAOP : OFKFEFKFCOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action PGICAAEJFJD;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BLFLMEFAPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4E3FE0", Offset = "0x4E2FE0", VA = "0x1804E3FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5C53C0", Offset = "0x5C43C0", VA = "0x1805C53C0")]
		public HGHBCFEJAOP(Action PGICAAEJFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x14CEF40", Offset = "0x14CDF40", VA = "0x1814CEF40", Slot = "5")]
		public void BCGFEGFKBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "6")]
		public void APPKIGJKKOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<OFKFEFKFCOM> PJNCCLIJPDF;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E54340", Offset = "0x1E53340", VA = "0x181E54340")]
	public static global::IDCJFNACHEM<T> FFCBLHPPJDG<T>(this global::IDCJFNACHEM<T> JLCKOKPHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x42D0F10", Offset = "0x42CFF10", VA = "0x1842D0F10")]
	public static BKMNEANDFIL FFCBLHPPJDG(this BKMNEANDFIL JLCKOKPHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42D1020", Offset = "0x42D0020", VA = "0x1842D1020")]
	public static void FFCBLHPPJDG(Action PGICAAEJFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E54280", Offset = "0x1E53280", VA = "0x181E54280")]
	private static global::IDCJFNACHEM<T> EDLDDNCKHCE<T>(global::IDCJFNACHEM<T> JLCKOKPHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42D0B10", Offset = "0x42CFB10", VA = "0x1842D0B10")]
	private static BKMNEANDFIL EDLDDNCKHCE(BKMNEANDFIL JLCKOKPHOOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x42D1180", Offset = "0x42D0180", VA = "0x1842D1180")]
	private static void GELKPODEKBM(OFKFEFKFCOM LOHHMIHGLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x42D0BF0", Offset = "0x42CFBF0", VA = "0x1842D0BF0")]
	private static void FADEMIMGACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x42D10B0", Offset = "0x42D00B0", VA = "0x1842D10B0")]
	private static void FMKHAADDJIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x42D0A60", Offset = "0x42CFA60", VA = "0x1842D0A60")]
	private static void CPDPGACPAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class GECJDHCOFOA
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ENOFNFOLNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GMDJOGAHHIL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public ENOFNFOLNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x42CE7B0", Offset = "0x42CD7B0", VA = "0x1842CE7B0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x42CE7A0", Offset = "0x42CD7A0", VA = "0x1842CE7A0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NOCABLNDOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public NOCABLNDOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x42D9B70", Offset = "0x42D8B70", VA = "0x1842D9B70")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LEBHKHGICKM : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GMDJOGAHHIL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public LEBHKHGICKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x42D3EA0", Offset = "0x42D2EA0", VA = "0x1842D3EA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x42D3B80", Offset = "0x42D2B80", VA = "0x1842D3B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x42D3F50", Offset = "0x42D2F50", VA = "0x1842D3F50")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x42D3E50", Offset = "0x42D2E50", VA = "0x1842D3E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DDOHGIOKBBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GMDJOGAHHIL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public DDOHGIOKBBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GDIOKIPEPFJ : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GMDJOGAHHIL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DDOHGIOKBBD <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public GDIOKIPEPFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x42CF6F0", Offset = "0x42CE6F0", VA = "0x1842CF6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x42CFA80", Offset = "0x42CEA80", VA = "0x1842CFA80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string LPBPLJJPBFJ = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string BHMEKOJLJDJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string PPGPJPFGBMH = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string PGACHLCILJM = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string OMCOIOEKNIC = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float NFCFPLMIMLK = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BKMNEANDFIL CAEBBFGKALD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation CINGHNNJHOC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static BKMNEANDFIL NLFNPMBIEIM;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string KLHCLDPOEDD;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority NKIIKJHHDAA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool KDLHDPDKMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x42CFF80", Offset = "0x42CEF80", VA = "0x1842CFF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool OCOHEOMHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x42D0180", Offset = "0x42CF180", VA = "0x1842D0180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool FIAJNFAMKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x42D01E0", Offset = "0x42CF1E0", VA = "0x1842D01E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IAPNILEHEHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x42D00D0", Offset = "0x42CF0D0", VA = "0x1842D00D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x42D0020", Offset = "0x42CF020", VA = "0x1842D0020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42CFD90", Offset = "0x42CED90", VA = "0x1842CFD90")]
	public static BKMNEANDFIL CNCMLDKOGGF(string EPJNPPGENFD, LoadSceneMode DOKFNNACAHH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x42CFB60", Offset = "0x42CEB60", VA = "0x1842CFB60")]
	public static BKMNEANDFIL CGPIEMILNCG(string EPJNPPGENFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x42CFEF0", Offset = "0x42CEEF0", VA = "0x1842CFEF0")]
	[IteratorStateMachine(typeof(LEBHKHGICKM))]
	private static IEnumerator<MFENADOJIIE> FPDJFMPHAKD(string EPJNPPGENFD, GMDJOGAHHIL BCDHFEINODO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42CFAD0", Offset = "0x42CEAD0", VA = "0x1842CFAD0")]
	[IteratorStateMachine(typeof(GDIOKIPEPFJ))]
	private static IEnumerator<MFENADOJIIE> ALKFKJIDKNC(string EPJNPPGENFD, LoadSceneMode DOKFNNACAHH, GMDJOGAHHIL BCDHFEINODO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KLKOAFGLPDA
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x42D3880", Offset = "0x42D2880", VA = "0x1842D3880")]
	public static IDisposable LFAKIOHNABC(this HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42D3800", Offset = "0x42D2800", VA = "0x1842D3800")]
	public static IDisposable LFAKIOHNABC(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42D3290", Offset = "0x42D2290", VA = "0x1842D3290")]
	public static IDisposable FAJOBCHGENL(this HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x42D3510", Offset = "0x42D2510", VA = "0x1842D3510")]
	public static IDisposable GKCDBDMGENH(this HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x42D3410", Offset = "0x42D2410", VA = "0x1842D3410")]
	public static IDisposable FOGNFCMNCJK(this HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x42D3710", Offset = "0x42D2710", VA = "0x1842D3710")]
	public static IDisposable ICBBMECEELP(this HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x42D3220", Offset = "0x42D2220", VA = "0x1842D3220")]
	public static IDisposable DNKGAFDPIEI(this HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x42D3480", Offset = "0x42D2480", VA = "0x1842D3480")]
	public static IDisposable GDFCENIIMJF(this HAIIDENMEJD EEECBNNPKOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x42D3980", Offset = "0x42D2980", VA = "0x1842D3980")]
	public static IDisposable NCGJOPGNCFE(this HAIIDENMEJD EEECBNNPKOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x42D3900", Offset = "0x42D2900", VA = "0x1842D3900")]
	public static IDisposable MDJLPLAPBPE(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x42D3120", Offset = "0x42D2120", VA = "0x1842D3120")]
	public static IDisposable BADFMKNCJKJ(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x42D3300", Offset = "0x42D2300", VA = "0x1842D3300")]
	public static IDisposable FDHIMHHJBIM(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x42D3380", Offset = "0x42D2380", VA = "0x1842D3380")]
	public static IDisposable FGMJAGHHLGE(this HAIIDENMEJD EEECBNNPKOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x42D3600", Offset = "0x42D2600", VA = "0x1842D3600")]
	public static IDisposable HADENGFLGHH(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x42D3A00", Offset = "0x42D2A00", VA = "0x1842D3A00")]
	public static IDisposable NFDKMOMAAOO(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x42D30A0", Offset = "0x42D20A0", VA = "0x1842D30A0")]
	public static IDisposable AGMFFIFOIDI(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x42D3680", Offset = "0x42D2680", VA = "0x1842D3680")]
	public static IDisposable HHAABOBGADO(this HAIIDENMEJD EEECBNNPKOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x42D31A0", Offset = "0x42D21A0", VA = "0x1842D31A0")]
	public static IDisposable CDEHFCHPEML(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x42D3780", Offset = "0x42D2780", VA = "0x1842D3780")]
	public static IDisposable JFGIHGENEHO(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x42D3580", Offset = "0x42D2580", VA = "0x1842D3580")]
	public static IDisposable GLMBDCDJPKD(this HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class BGFAKAGAGHM
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42CB230", Offset = "0x42CA230", VA = "0x1842CB230")]
	public static IDisposable KAJPLBHMFKC(this MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x42CB2B0", Offset = "0x42CA2B0", VA = "0x1842CB2B0")]
	public static IDisposable KAJPLBHMFKC(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x42CAC30", Offset = "0x42C9C30", VA = "0x1842CAC30")]
	public static IDisposable ANEHKFACJGN(this MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x42CB1C0", Offset = "0x42CA1C0", VA = "0x1842CB1C0")]
	public static IDisposable JLJJLNFFMJA(this MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x42CB520", Offset = "0x42CA520", VA = "0x1842CB520")]
	public static IDisposable OJLOPLLLICG(this MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x42CB430", Offset = "0x42CA430", VA = "0x1842CB430")]
	public static IDisposable MJILFOFPLLN(this MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x42CB610", Offset = "0x42CA610", VA = "0x1842CB610")]
	public static IDisposable PJJNFOJLDAJ(this MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42CADA0", Offset = "0x42C9DA0", VA = "0x1842CADA0")]
	public static IDisposable EAMDOMGFJNO(this MonoBehaviour JJNNMMLLFOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42CAEB0", Offset = "0x42C9EB0", VA = "0x1842CAEB0")]
	public static IDisposable FCDGJFANJNN(this MonoBehaviour JJNNMMLLFOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x42CACA0", Offset = "0x42C9CA0", VA = "0x1842CACA0")]
	public static IDisposable CCGAFPILLBN(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x42CAFB0", Offset = "0x42C9FB0", VA = "0x1842CAFB0")]
	public static IDisposable FNLBNNGCOGC(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x42CB030", Offset = "0x42CA030", VA = "0x1842CB030")]
	public static IDisposable HPLPDMAFEGL(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42CB680", Offset = "0x42CA680", VA = "0x1842CB680")]
	public static IDisposable POEPJCJBLLJ(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x42CB3B0", Offset = "0x42CA3B0", VA = "0x1842CB3B0")]
	public static IDisposable KKHGMHNIBFK(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42CB0B0", Offset = "0x42CA0B0", VA = "0x1842CB0B0")]
	public static IDisposable IJPBEJHLFGM(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x42CABA0", Offset = "0x42C9BA0", VA = "0x1842CABA0")]
	public static IDisposable AIIDKMMIJON(this MonoBehaviour JJNNMMLLFOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x42CAE30", Offset = "0x42C9E30", VA = "0x1842CAE30")]
	public static IDisposable ENHADLIPHON(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x42CB330", Offset = "0x42CA330", VA = "0x1842CB330")]
	public static IDisposable KGIEPDCHBKO(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x42CB4A0", Offset = "0x42CA4A0", VA = "0x1842CB4A0")]
	public static IDisposable NBIIDJIALAH(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42CB130", Offset = "0x42CA130", VA = "0x1842CB130")]
	public static IDisposable IMFEONFOMIA(this MonoBehaviour JJNNMMLLFOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42CB590", Offset = "0x42CA590", VA = "0x1842CB590")]
	public static IDisposable OMHIJFNIHEB(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42CAF30", Offset = "0x42C9F30", VA = "0x1842CAF30")]
	public static IDisposable FJLLJIEEJBA(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x42CAD20", Offset = "0x42C9D20", VA = "0x1842CAD20")]
	public static IDisposable DMOEBIMPDFH(this MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class INKFKOHEMIE
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class IFGNGNHMGME : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public MHPFPCBFNCA.INHNCHELJFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private MELJAKLAAEB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public IFGNGNHMGME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x42D16F0", Offset = "0x42D06F0", VA = "0x1842D16F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x42D17B0", Offset = "0x42D07B0", VA = "0x1842D17B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DEGIDDAMNHL : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public MHPFPCBFNCA.INHNCHELJFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private MELJAKLAAEB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public DEGIDDAMNHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x42CDE80", Offset = "0x42CCE80", VA = "0x1842CDE80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x42CDF60", Offset = "0x42CCF60", VA = "0x1842CDF60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x42D20A0", Offset = "0x42D10A0", VA = "0x1842D20A0")]
	public static LBEACJDEKDN KAJPLBHMFKC(Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x42D1FB0", Offset = "0x42D0FB0", VA = "0x1842D1FB0")]
	public static LBEACJDEKDN KAJPLBHMFKC(Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42D1EA0", Offset = "0x42D0EA0", VA = "0x1842D1EA0")]
	public static LBEACJDEKDN KAJPLBHMFKC(Behaviour EEECBNNPKOA, Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x42D1D90", Offset = "0x42D0D90", VA = "0x1842D1D90")]
	public static LBEACJDEKDN KAJPLBHMFKC(Behaviour EEECBNNPKOA, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x42D22A0", Offset = "0x42D12A0", VA = "0x1842D22A0")]
	public static LBEACJDEKDN LFAKIOHNABC(HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x42D2190", Offset = "0x42D1190", VA = "0x1842D2190")]
	public static LBEACJDEKDN LFAKIOHNABC(HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x42D1D10", Offset = "0x42D0D10", VA = "0x1842D1D10")]
	[IteratorStateMachine(typeof(IFGNGNHMGME))]
	private static IEnumerator<MFENADOJIIE> EEPMGEAJOPK(MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC, Action PHJHELNLMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x42D1C90", Offset = "0x42D0C90", VA = "0x1842D1C90")]
	[IteratorStateMachine(typeof(DEGIDDAMNHL))]
	private static IEnumerator<MFENADOJIIE> EEPMGEAJOPK(MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC, Action<float> PHJHELNLMDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CLHNDCPJCMN
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PKPBCDOAICH : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public MHPFPCBFNCA.INHNCHELJFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private KGJJFHOELEH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public PKPBCDOAICH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x42DA380", Offset = "0x42D9380", VA = "0x1842DA380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x42DA470", Offset = "0x42D9470", VA = "0x1842DA470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x42CBFB0", Offset = "0x42CAFB0", VA = "0x1842CBFB0")]
	public static LBEACJDEKDN KAJPLBHMFKC(float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x42CBEF0", Offset = "0x42CAEF0", VA = "0x1842CBEF0")]
	public static LBEACJDEKDN KAJPLBHMFKC(MonoBehaviour JJNNMMLLFOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x42CBDA0", Offset = "0x42CADA0", VA = "0x1842CBDA0")]
	public static LBEACJDEKDN AGKAMDKGKFC(HAIIDENMEJD EEECBNNPKOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x42CBE60", Offset = "0x42CAE60", VA = "0x1842CBE60")]
	[IteratorStateMachine(typeof(PKPBCDOAICH))]
	private static IEnumerator<MFENADOJIIE> EEPMGEAJOPK(float CHJJGFMAHOO, MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC, Action<float> PHJHELNLMDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OPIGOILEPGO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class KOFBENAAMJJ : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public MHPFPCBFNCA.INHNCHELJFB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public KOFBENAAMJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x42D3A80", Offset = "0x42D2A80", VA = "0x1842D3A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x42D3B30", Offset = "0x42D2B30", VA = "0x1842D3B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x42D9CE0", Offset = "0x42D8CE0", VA = "0x1842D9CE0")]
	[IteratorStateMachine(typeof(KOFBENAAMJJ))]
	private static IEnumerator<MFENADOJIIE> EOLBHOFFCEB(MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO, Func<bool> FOPIJABADPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x42D9D60", Offset = "0x42D8D60", VA = "0x1842D9D60")]
	public static LBEACJDEKDN OLEMNFKBFDI(this MonoBehaviour JJNNMMLLFOA, Func<bool> FOPIJABADPP, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO = MHPFPCBFNCA.INHNCHELJFB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BAFKBKDKFDN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DOBJJMNFAAD : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public MHPFPCBFNCA.INHNCHELJFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public DOBJJMNFAAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x42CE690", Offset = "0x42CD690", VA = "0x1842CE690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x42CE750", Offset = "0x42CD750", VA = "0x1842CE750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CMGHIGCLAKD : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public MHPFPCBFNCA.INHNCHELJFB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private MFENADOJIIE <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public CMGHIGCLAKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x42CC060", Offset = "0x42CB060", VA = "0x1842CC060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x42CC130", Offset = "0x42CB130", VA = "0x1842CC130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x42CA460", Offset = "0x42C9460", VA = "0x1842CA460")]
	[IteratorStateMachine(typeof(DOBJJMNFAAD))]
	private static IEnumerator<MFENADOJIIE> IKJBLLDPPPO(float AMBGGNMBPEC, MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x42CA620", Offset = "0x42C9620", VA = "0x1842CA620")]
	[IteratorStateMachine(typeof(CMGHIGCLAKD))]
	private static IEnumerator<MFENADOJIIE> NACLOBLOCIB(float AMBGGNMBPEC, MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x42CA820", Offset = "0x42C9820", VA = "0x1842CA820")]
	public static IDisposable NMHGKOAFCKM(this MonoBehaviour JJNNMMLLFOA, float AMBGGNMBPEC, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x42CA360", Offset = "0x42C9360", VA = "0x1842CA360")]
	public static LBEACJDEKDN EGCJPACIDBD(this MonoBehaviour JJNNMMLLFOA, float AMBGGNMBPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x42CA6C0", Offset = "0x42C96C0", VA = "0x1842CA6C0")]
	public static LBEACJDEKDN NMHGKOAFCKM(this MonoBehaviour JJNNMMLLFOA, float AMBGGNMBPEC, MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x42CA350", Offset = "0x42C9350", VA = "0x1842CA350")]
	public static LBEACJDEKDN DJBFDALHMPI(this MonoBehaviour JJNNMMLLFOA, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x42CA4F0", Offset = "0x42C94F0", VA = "0x1842CA4F0")]
	public static LBEACJDEKDN INJPOOHBOJF(this MonoBehaviour JJNNMMLLFOA, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x42CAA80", Offset = "0x42C9A80", VA = "0x1842CAA80")]
	public static LBEACJDEKDN PKDCAPCDOPL(this MonoBehaviour JJNNMMLLFOA, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x42CA6B0", Offset = "0x42C96B0", VA = "0x1842CA6B0")]
	public static LBEACJDEKDN NGCMPPHCIPF(this MonoBehaviour JJNNMMLLFOA, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x42CA500", Offset = "0x42C9500", VA = "0x1842CA500")]
	public static LBEACJDEKDN KMKGPAEEOGK(this MonoBehaviour JJNNMMLLFOA, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x42CAA90", Offset = "0x42C9A90", VA = "0x1842CAA90")]
	private static LBEACJDEKDN PNOMCDJJBIC(MonoBehaviour JJNNMMLLFOA, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x42CA970", Offset = "0x42C9970", VA = "0x1842CA970")]
	public static LBEACJDEKDN OADGKCHHHDI(this MonoBehaviour JJNNMMLLFOA, float EJBLNNIBFFE, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x42CA240", Offset = "0x42C9240", VA = "0x1842CA240")]
	public static LBEACJDEKDN DEDKKENCGGN(this MonoBehaviour JJNNMMLLFOA, float EJBLNNIBFFE, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x42CA020", Offset = "0x42C9020", VA = "0x1842CA020")]
	public static LBEACJDEKDN BDDNEMGHCLN(this MonoBehaviour JJNNMMLLFOA, float EJBLNNIBFFE, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x42CA510", Offset = "0x42C9510", VA = "0x1842CA510")]
	public static LBEACJDEKDN LGPCDCGICMH(this MonoBehaviour JJNNMMLLFOA, float EJBLNNIBFFE, Action DCEAJPFMAKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x42CA130", Offset = "0x42C9130", VA = "0x1842CA130")]
	public static LBEACJDEKDN BEDHFGBDBNF(this MonoBehaviour JJNNMMLLFOA, float EJBLNNIBFFE, Action DCEAJPFMAKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CBNIAIMJAKM : HKEOCOLGPAB
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LGBICFPMJPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CBNIAIMJAKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public LGBICFPMJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x42D04A0", Offset = "0x42CF4A0", VA = "0x1842D04A0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HGKDFLAKDPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CBNIAIMJAKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
		public HGKDFLAKDPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x42D04A0", Offset = "0x42CF4A0", VA = "0x1842D04A0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly float BLCHLMNJKPJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x42CBC70", Offset = "0x42CAC70", VA = "0x1842CBC70")]
	public CBNIAIMJAKM(Behaviour EEECBNNPKOA, float BLCHLMNJKPJ, [Optional] Action IICLOLMLJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x42CBAB0", Offset = "0x42CAAB0", VA = "0x1842CBAB0", Slot = "9")]
	protected override bool GDLKGFDAGJO(Action PGICAAEJFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x42CBB90", Offset = "0x42CAB90", VA = "0x1842CBB90", Slot = "10")]
	protected override bool OJELJBAAGFC(Action PGICAAEJFJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MKBINIJPOJL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool KPIANKGLCOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IKMJJCEIFII;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GILHEELDCLK(bool LHOIPIGNODN = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GILHEELDCLK(Action PGICAAEJFJD, bool LHOIPIGNODN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class HKEOCOLGPAB : MKBINIJPOJL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DMAHLJHKELJ : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public DMAHLJHKELJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x42CE5A0", Offset = "0x42CD5A0", VA = "0x1842CE5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x42CE640", Offset = "0x42CD640", VA = "0x1842CE640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Behaviour EEECBNNPKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Action IICLOLMLJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private BBPJLDGJKMK CNFPEBEJGNA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KPIANKGLCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69FBB0", Offset = "0x69EBB0", VA = "0x18069FBB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IKMJJCEIFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x42D0710", Offset = "0x42CF710", VA = "0x1842D0710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x42D08C0", Offset = "0x42CF8C0", VA = "0x1842D08C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x42D0A10", Offset = "0x42CFA10", VA = "0x1842D0A10")]
	protected HKEOCOLGPAB(Behaviour EEECBNNPKOA, [Optional] Action IICLOLMLJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x42D07B0", Offset = "0x42CF7B0", VA = "0x1842D07B0", Slot = "7")]
	public bool GILHEELDCLK(bool LHOIPIGNODN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x42D0810", Offset = "0x42CF810", VA = "0x1842D0810", Slot = "8")]
	public bool GILHEELDCLK(Action PGICAAEJFJD, bool LHOIPIGNODN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GDLKGFDAGJO(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OJELJBAAGFC(Action PGICAAEJFJD);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x42D06F0", Offset = "0x42CF6F0", VA = "0x1842D06F0")]
	protected void BGKOMPJMJAN(Action PGICAAEJFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x42D0510", Offset = "0x42CF510", VA = "0x1842D0510")]
	protected BKMNEANDFIL AKMDHMMANND(float KIEMEGLLNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x42D0960", Offset = "0x42CF960", VA = "0x1842D0960")]
	private void OJDFABFPMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x42D0860", Offset = "0x42CF860", VA = "0x1842D0860")]
	[IteratorStateMachine(typeof(DMAHLJHKELJ))]
	private static IEnumerator<MFENADOJIIE> IIIHJIAIKNF(float KIEMEGLLNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x42D09D0", Offset = "0x42CF9D0", VA = "0x1842D09D0")]
	[CompilerGenerated]
	private void PBBBFJKPHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JFJOPNFCJKE : HKEOCOLGPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float PIGNPFFCJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int BBOGONCFLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float BNCGPILBMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float[] EENGIAFOOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int NNMNPGCNEFD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BONBGPCGLJB JMLEOGNDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x50BA30", Offset = "0x50AA30", VA = "0x18050BA30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5C85E0", Offset = "0x5C75E0", VA = "0x1805C85E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x42D2C50", Offset = "0x42D1C50", VA = "0x1842D2C50")]
	public JFJOPNFCJKE(Behaviour EEECBNNPKOA, float HMMOBBLEOLD, int BBOGONCFLJK, [Optional] Action IICLOLMLJJM, float BNCGPILBMBB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4E3EC0", Offset = "0x4E2EC0", VA = "0x1804E3EC0", Slot = "9")]
	protected override bool GDLKGFDAGJO(Action PGICAAEJFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x42D2A30", Offset = "0x42D1A30", VA = "0x1842D2A30", Slot = "10")]
	protected override bool OJELJBAAGFC(Action PGICAAEJFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x42D29A0", Offset = "0x42D19A0", VA = "0x1842D29A0")]
	private void FPCNLCHFCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class IFKEOFCCKBP : HKEOCOLGPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float BLCHLMNJKPJ;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x42CBC70", Offset = "0x42CAC70", VA = "0x1842CBC70")]
	public IFKEOFCCKBP(Behaviour EEECBNNPKOA, float BLCHLMNJKPJ, [Optional] Action IICLOLMLJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3EC0", Offset = "0x4E2EC0", VA = "0x1804E3EC0", Slot = "9")]
	protected override bool GDLKGFDAGJO(Action PGICAAEJFJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x42D1800", Offset = "0x42D0800", VA = "0x1842D1800", Slot = "10")]
	protected override bool OJELJBAAGFC(Action PGICAAEJFJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FOILJMEGBOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BIBPEDLODOL : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public BIBPEDLODOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x42CB8D0", Offset = "0x42CA8D0", VA = "0x1842CB8D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x42CB9D0", Offset = "0x42CA9D0", VA = "0x1842CB9D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LBEACJDEKDN NDNHBICPIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private HAIIDENMEJD EEECBNNPKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action PHJHELNLMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action<float> DPDLPBHALAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float EJBCCHENLBF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x42CF1F0", Offset = "0x42CE1F0", VA = "0x1842CF1F0")]
	public FOILJMEGBOE(HAIIDENMEJD EEECBNNPKOA, Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x42CF3B0", Offset = "0x42CE3B0", VA = "0x1842CF3B0")]
	public FOILJMEGBOE(HAIIDENMEJD EEECBNNPKOA, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x42CF570", Offset = "0x42CE570", VA = "0x1842CF570")]
	public FOILJMEGBOE(HAIIDENMEJD EEECBNNPKOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x42CED60", Offset = "0x42CDD60", VA = "0x1842CED60")]
	private void KAJPLBHMFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x42CEEF0", Offset = "0x42CDEF0", VA = "0x1842CEEF0")]
	private void LKFKDEHDPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x42CEA10", Offset = "0x42CDA10", VA = "0x1842CEA10")]
	private void BAIFCBLADKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x42CEBB0", Offset = "0x42CDBB0", VA = "0x1842CEBB0")]
	private void IEDKKIJPPJF(string GEJGBLPCCME, Action PEBIIDNJGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x42CF080", Offset = "0x42CE080", VA = "0x1842CF080")]
	[IteratorStateMachine(typeof(BIBPEDLODOL))]
	private IEnumerator<MFENADOJIIE> NDKFBGNBLIE(Action PEBIIDNJGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x42CEB50", Offset = "0x42CDB50", VA = "0x1842CEB50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x42CF170", Offset = "0x42CE170", VA = "0x1842CF170")]
	[CompilerGenerated]
	private void PLHGLPBCACP(string FLCLFKPPOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x42CF0F0", Offset = "0x42CE0F0", VA = "0x1842CF0F0")]
	[CompilerGenerated]
	private void NDOPIFGMEGJ(string FLCLFKPPOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x42CECE0", Offset = "0x42CDCE0", VA = "0x1842CECE0")]
	[CompilerGenerated]
	private void IFHAIJGLNOA(string FLCLFKPPOLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class NJJHICBJLCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class KHDBBBLANMB : IEnumerator<MFENADOJIIE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MFENADOJIIE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private MFENADOJIIE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
		[DebuggerHidden]
		public KHDBBBLANMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x42D2F50", Offset = "0x42D1F50", VA = "0x1842D2F50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x42D3050", Offset = "0x42D2050", VA = "0x1842D3050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private LBEACJDEKDN NDNHBICPIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private MonoBehaviour JJNNMMLLFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Action PHJHELNLMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action<float> DPDLPBHALAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float EJBCCHENLBF;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x42D9830", Offset = "0x42D8830", VA = "0x1842D9830")]
	public NJJHICBJLCJ(MonoBehaviour JJNNMMLLFOA, Action PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x42D9670", Offset = "0x42D8670", VA = "0x1842D9670")]
	public NJJHICBJLCJ(MonoBehaviour JJNNMMLLFOA, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x42D99F0", Offset = "0x42D89F0", VA = "0x1842D99F0")]
	public NJJHICBJLCJ(MonoBehaviour JJNNMMLLFOA, float CHJJGFMAHOO, Action<float> PHJHELNLMDL, MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x42D91E0", Offset = "0x42D81E0", VA = "0x1842D91E0")]
	private void KAJPLBHMFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x42D9370", Offset = "0x42D8370", VA = "0x1842D9370")]
	private void LKFKDEHDPGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x42D8E90", Offset = "0x42D7E90", VA = "0x1842D8E90")]
	private void BAIFCBLADKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x42D9030", Offset = "0x42D8030", VA = "0x1842D9030")]
	private void IEDKKIJPPJF(string GEJGBLPCCME, Action PEBIIDNJGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x42D9500", Offset = "0x42D8500", VA = "0x1842D9500")]
	[IteratorStateMachine(typeof(KHDBBBLANMB))]
	private IEnumerator<MFENADOJIIE> NDKFBGNBLIE(Action PEBIIDNJGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x42D8FD0", Offset = "0x42D7FD0", VA = "0x1842D8FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x42D95F0", Offset = "0x42D85F0", VA = "0x1842D95F0")]
	[CompilerGenerated]
	private void PLHGLPBCACP(string FLCLFKPPOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x42D9570", Offset = "0x42D8570", VA = "0x1842D9570")]
	[CompilerGenerated]
	private void NDOPIFGMEGJ(string FLCLFKPPOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x42D9160", Offset = "0x42D8160", VA = "0x1842D9160")]
	[CompilerGenerated]
	private void IFHAIJGLNOA(string FLCLFKPPOLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EJDFFOBCFIH
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int IEDFNJKLIKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PLDKBIIODJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static readonly PLDKBIIODJJ OLPOHJONBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Action LOMDMCILCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool GOOBEBDGAIC;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5C53C0", Offset = "0x5C43C0", VA = "0x1805C53C0")]
	public PLDKBIIODJJ(Action LOMDMCILCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x42DA4C0", Offset = "0x42D94C0", VA = "0x1842DA4C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NIOIIELPACL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T AGMOAIIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PMBFOAKABLD(Action<T> EGPCJNFBMHL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable PMBFOAKABLD(UnityEngine.Object EEECBNNPKOA, Action<T> EGPCJNFBMHL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FFFOFHNPAOG<T> : global::NIOIIELPACL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T AGMOAIIIIJB
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
public class EHFKCBPEJJI<T> : global::FFFOFHNPAOG<T>, global::NIOIIELPACL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FNIGDOFNLKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public global::EHFKCBPEJJI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::IGFGKCCAEIB<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1A526F0", Offset = "0x1A516F0", VA = "0x181A526F0")]
		public FNIGDOFNLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2613D50", Offset = "0x2612D50", VA = "0x182613D50")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static GameObject NBGDAIMBOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly List<global::IGFGKCCAEIB<UnityEngine.Object, Action<T>>> FBIIJJLJHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T GOONFBFHHIM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object AEBFMGDFOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x260E410", Offset = "0x260D410", VA = "0x18260E410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T AGMOAIIIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x668DA0", Offset = "0x667DA0", VA = "0x180668DA0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x260ED00", Offset = "0x260DD00", VA = "0x18260ED00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x260E160", Offset = "0x260D160", VA = "0x18260E160")]
	private static bool HICBDPPNALK(T DKINGKHLBJL, T DJHKGFLFIEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x260F090", Offset = "0x260E090", VA = "0x18260F090")]
	public EHFKCBPEJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x260F160", Offset = "0x260E160", VA = "0x18260F160")]
	public EHFKCBPEJJI(T PEDHAGLLFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x260E100", Offset = "0x260D100", VA = "0x18260E100")]
	public void GNKMJAGANIH(T LLIKEJCGBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x260EEC0", Offset = "0x260DEC0", VA = "0x18260EEC0", Slot = "7")]
	public IDisposable PMBFOAKABLD(Action<T> EGPCJNFBMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x260EF30", Offset = "0x260DF30", VA = "0x18260EF30", Slot = "8")]
	public IDisposable PMBFOAKABLD(UnityEngine.Object EEECBNNPKOA, Action<T> EGPCJNFBMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x260E620", Offset = "0x260D620", VA = "0x18260E620")]
	private void LOAHOMAIKLM()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<KMEALFGBPPA, Scheduler>, KMEALFGBPPA
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class PADLMNPJKGJ : EJDFFOBCFIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public LNKLGFONFGE BJCNPCBBONM;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int IEDFNJKLIKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x4E3ED0", Offset = "0x4E2ED0", VA = "0x1804E3ED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x4E3EE0", Offset = "0x4E2EE0", VA = "0x1804E3EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x42D9EF0", Offset = "0x42D8EF0", VA = "0x1842D9EF0")]
			public static MFENADOJIIE EPBOMAIADHE(IEnumerator<MFENADOJIIE> LCMJPIGEKKA, CBLKBNOMEOK HGCBPPKJKJF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x42DA050", Offset = "0x42D9050", VA = "0x1842DA050")]
			public MFENADOJIIE EPBOMAIADHE(CBLKBNOMEOK[] AKLHONKAOCO, IEnumerator<MFENADOJIIE>[] LFNOLPDADJK, MFENADOJIIE[] OFBLABHOCKP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x42D9EC0", Offset = "0x42D8EC0", VA = "0x1842D9EC0")]
			public void IOHANIAOAGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x42DA130", Offset = "0x42D9130", VA = "0x1842DA130")]
			public void MLJMOPLJBCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x42DA200", Offset = "0x42D9200", VA = "0x1842DA200")]
			public void PHFOHILAOOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x42D9EC0", Offset = "0x42D8EC0", VA = "0x1842D9EC0")]
			public void APPKIGJKKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
			public PADLMNPJKGJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class LNKLGFONFGE
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct BNHCPKEBOEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public PADLMNPJKGJ LKLNMOFGHBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public HAIIDENMEJD FBHDOCOEDFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public CBLKBNOMEOK CKMBGACJOCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public IEnumerator<MFENADOJIIE> EPCGAPEFBPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public MFENADOJIIE INBGNEAMCCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public EIGPENCHJNC MEIAAOJFFPA;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct NGAIHCBAMIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public MHPFPCBFNCA.INHNCHELJFB IFMFBEBOABE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public List<BNHCPKEBOEA> CCBGJJGHOGP;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class NEHPPPGGNPG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public LNKLGFONFGE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public HAIIDENMEJD context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public PADLMNPJKGJ routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public EIGPENCHJNC coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public CBLKBNOMEOK promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public MFENADOJIIE currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public IEnumerator<MFENADOJIIE> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public NEHPPPGGNPG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x42D6F30", Offset = "0x42D5F30", VA = "0x1842D6F30")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class OONCLODLKLB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public PADLMNPJKGJ schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public LNKLGFONFGE <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public OONCLODLKLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x42D9CA0", Offset = "0x42D8CA0", VA = "0x1842D9CA0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class OFEPOHIPKNJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public PADLMNPJKGJ schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public LNKLGFONFGE <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public OFEPOHIPKNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x42D9BA0", Offset = "0x42D8BA0", VA = "0x1842D9BA0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class HGLMEFMIDEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public PADLMNPJKGJ schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public LNKLGFONFGE <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
				public HGLMEFMIDEH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x42D04D0", Offset = "0x42CF4D0", VA = "0x1842D04D0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private readonly MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool[] LBCOIGANFIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<EIGPENCHJNC> FDEACACCNKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<float> HLNCKIIKIMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> FNFGCNFNJJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> LKHMFICFKPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> NHBGNNDEBHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> MDELLFBOABN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> EKPOKIKJNAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private PADLMNPJKGJ[] JANOKGBOOEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private CBLKBNOMEOK[] AKLHONKAOCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private HAIIDENMEJD[] JMPBAHKGCGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private IEnumerator<MFENADOJIIE>[] GKHGNAPEDAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private MFENADOJIIE[] ALJICGPBICA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int AOFNKCPOJCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private int CEIHLDFNAFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private readonly int FPKKPFDJIBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private float GGDEMJDPHMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private MJBNDGKBONE BJJAICOCJMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private JobHandle PCMOKBKFHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<PADLMNPJKGJ> GPHECBFNMPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool MMGJPAAKOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<Action> AACBDFPDDOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private List<Action> ANBKODLGFAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private bool AHCMCOMPDKJ;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public NGAIHCBAMIJ[] DDBKHEJOOIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x7E7C30", Offset = "0x7E6C30", VA = "0x1807E7C30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int CHNOHPBKEMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xA40A20", Offset = "0xA3FA20", VA = "0x180A40A20")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x42D4F30", Offset = "0x42D3F30", VA = "0x1842D4F30")]
			private static int GODFEKLPLAI(MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x42D5D70", Offset = "0x42D4D70", VA = "0x1842D5D70")]
			public LNKLGFONFGE(MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x42D5020", Offset = "0x42D4020", VA = "0x1842D5020")]
			private void HOPAHJMAEML(ref int DMPLBAPCGOG, int MHOCJPFDGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x42D58A0", Offset = "0x42D48A0", VA = "0x1842D58A0")]
			public void ODFCFOJBKCP(HAIIDENMEJD EEECBNNPKOA, MFENADOJIIE AEDBMHNLJPB, IEnumerator<MFENADOJIIE> LCMJPIGEKKA, CBLKBNOMEOK HGCBPPKJKJF, [Optional] PADLMNPJKGJ FCCJMKKGILA, EIGPENCHJNC LPHHEFADPID = EIGPENCHJNC.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x42D5AC0", Offset = "0x42D4AC0", VA = "0x1842D5AC0")]
			public void PHKIFKFHEHK(IEnumerable<BNHCPKEBOEA> ALBDDNIEJGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x42D4320", Offset = "0x42D3320", VA = "0x1842D4320")]
			private BNHCPKEBOEA CEBLPJNAHAE(int LLKACICAOBL)
			{
				return default(BNHCPKEBOEA);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x42D5530", Offset = "0x42D4530", VA = "0x1842D5530")]
			private void LPALFPNEOKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE660", Offset = "0x1CED660", VA = "0x181CEE660")]
			private static void BEJCOFCKDJB<T>(int LLKACICAOBL, T[] KFGEPOGFAKD, int MMNEHHBHOKO, [Optional] T DEAHIPHLBOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE640", Offset = "0x1CED640", VA = "0x181CEE640")]
			private static void BEJCOFCKDJB<T>(int LLKACICAOBL, NativeArray<T> KFGEPOGFAKD, int MMNEHHBHOKO, [Optional] T DEAHIPHLBOP) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x42D5290", Offset = "0x42D4290", VA = "0x1842D5290")]
			private void LIHABIMEAPO(IEnumerable<BNHCPKEBOEA> ALBDDNIEJGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x42D5CB0", Offset = "0x42D4CB0", VA = "0x1842D5CB0")]
			private void PJDNNMICPCG(BNHCPKEBOEA LOOFIMNCJBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x42D4060", Offset = "0x42D3060", VA = "0x1842D4060")]
			private CMKBPAFAJPA BJCCECHBKIJ(int KDJDICKDIMP)
			{
				return default(CMKBPAFAJPA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x42D4CC0", Offset = "0x42D3CC0", VA = "0x1842D4CC0")]
			public void FMPPEPAGOAM(float LNEGILPDKPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x42D4EB0", Offset = "0x42D3EB0", VA = "0x1842D4EB0")]
			private void FNGOIDFPCDN(Action DKINGKHLBJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x42D47A0", Offset = "0x42D37A0", VA = "0x1842D47A0")]
			private void CNGFDOPECBP(Action DKINGKHLBJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x42D4820", Offset = "0x42D3820", VA = "0x1842D4820")]
			public void DGPJLMBAGNO(float LNEGILPDKPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x42D51B0", Offset = "0x42D41B0", VA = "0x1842D51B0")]
			public void JAHIHIBCNCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x42D3FA0", Offset = "0x42D2FA0", VA = "0x1842D3FA0")]
			public void APPKIGJKKOB(PADLMNPJKGJ EOAGIFPPKMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x42D5A00", Offset = "0x42D4A00", VA = "0x1842D5A00")]
			public void PBGOHAGFFJP(PADLMNPJKGJ EOAGIFPPKMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x42D4F60", Offset = "0x42D3F60", VA = "0x1842D4F60")]
			public void HOAOLKGDEAE(PADLMNPJKGJ EOAGIFPPKMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct MJBNDGKBONE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			[ReadOnly]
			public float NKGDDLCKGKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			[ReadOnly]
			public int LABFJGNJMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private NativeArray<int> NOFINJDBBKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private NativeArray<int> CFKBGFBKIEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> IIMECJEGKKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[ReadOnly]
			public NativeArray<EIGPENCHJNC> HMAEMLGIEOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			[ReadOnly]
			public NativeArray<float> BGLKHDGPKHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[WriteOnly]
			public NativeArray<int> NHBGNNDEBHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[WriteOnly]
			public NativeArray<int> FNFGCNFNJJB;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x42D6710", Offset = "0x42D5710", VA = "0x1842D6710")]
			public static MJBNDGKBONE OHLBCBNLJLB(int DCJLDPOPPKI, float LNEGILPDKPI, NativeArray<EIGPENCHJNC> OIIBLAODKEF, NativeArray<float> IOCIMOEHDGC, NativeArray<int> HFFEAFKALNG, NativeArray<int> OAOHIEJDPHA, NativeArray<int> FAFHKAHCIGB, NativeArray<int> CFKBGFBKIEK, NativeArray<int> IIMECJEGKKI)
			{
				return default(MJBNDGKBONE);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x42D62F0", Offset = "0x42D52F0", VA = "0x1842D62F0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x42D6600", Offset = "0x42D5600", VA = "0x1842D6600")]
			private bool KJEJOKDOIHJ(int ODKCMELFFGF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x42D62C0", Offset = "0x42D52C0", VA = "0x1842D62C0")]
			private void BOFGCEHGOPP(NativeArray<int> KKGGPHHBIPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x42D67E0", Offset = "0x42D57E0", VA = "0x1842D67E0")]
			private int PPPIOMODPOP(int BIODHLCMFJK, int AHEOFIFOPOH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x42D6640", Offset = "0x42D5640", VA = "0x1842D6640")]
			private void MLOEDOEAMLH(NativeArray<int> KKGGPHHBIPM, int HKCOEFDGEBC, int MPDJKGFLDBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x42D63D0", Offset = "0x42D53D0", VA = "0x1842D63D0")]
			private void KEGBFABHCKO(NativeArray<int> KKGGPHHBIPM, int MGNNMBADLNO, int KKIKMCJFBHB, int PPNEGNLJIJF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class JBIEKAJPJEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private readonly CBLKBNOMEOK HGCBPPKJKJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private readonly Behaviour EEECBNNPKOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly bool AOIJLABIGJO;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<MFENADOJIIE> EPCGAPEFBPH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x4E31D0", Offset = "0x4E21D0", VA = "0x1804E31D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x4E3490", Offset = "0x4E2490", VA = "0x1804E3490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public MFENADOJIIE INBGNEAMCCL
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4E34A0", Offset = "0x4E24A0", VA = "0x1804E34A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool FHDDAJONKDK
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x42D2650", Offset = "0x42D1650", VA = "0x1842D2650")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool GPGLEKPELBK
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x72C0D0", Offset = "0x72B0D0", VA = "0x18072C0D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x22E59E0", Offset = "0x22E49E0", VA = "0x1822E59E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string MPKICLFKBCP
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x4E4010", Offset = "0x4E3010", VA = "0x1804E4010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x4E4020", Offset = "0x4E3020", VA = "0x1804E4020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float OLHKAPFOEBM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x100AE40", Offset = "0x1009E40", VA = "0x18100AE40")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x100ABD0", Offset = "0x1009BD0", VA = "0x18100ABD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x42D2800", Offset = "0x42D1800", VA = "0x1842D2800")]
			public JBIEKAJPJEM(IEnumerator<MFENADOJIIE> LCMJPIGEKKA, Behaviour EEECBNNPKOA, CBLKBNOMEOK HGCBPPKJKJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x42D2440", Offset = "0x42D1440", VA = "0x1842D2440")]
			public MFENADOJIIE EPBOMAIADHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x42D26E0", Offset = "0x42D16E0", VA = "0x1842D26E0")]
			public bool KMFFIDFOEJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x42D23B0", Offset = "0x42D13B0", VA = "0x1842D23B0")]
			public void APPKIGJKKOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x42D2770", Offset = "0x42D1770", VA = "0x1842D2770", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1316FD0", Offset = "0x1315FD0", VA = "0x181316FD0")]
			[CompilerGenerated]
			private void IJDEFGCPMKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class CBLKBNOMEOK : PIAADCHENPK, LBEACJDEKDN, BBPJLDGJKMK, BKMNEANDFIL, IEnumerator, MFENADOJIIE, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private MHPFPCBFNCA.INHNCHELJFB CALEJECKBKE;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private MHPFPCBFNCA.INHNCHELJFB JKLDFOBAHBM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x508180", Offset = "0x507180", VA = "0x180508180", Slot = "23")]
				get
				{
					return default(MHPFPCBFNCA.INHNCHELJFB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public MHPFPCBFNCA.INHNCHELJFB BJCNPCBBONM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x508180", Offset = "0x507180", VA = "0x180508180")]
				get
				{
					return default(MHPFPCBFNCA.INHNCHELJFB);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x6C3D60", Offset = "0x6C2D60", VA = "0x1806C3D60")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float JLCELFFGEND
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0xE9E0A0", Offset = "0xE9D0A0", VA = "0x180E9E0A0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x42CBA30", Offset = "0x42CAA30", VA = "0x1842CBA30", Slot = "24")]
			private bool KAPJBBPJIEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x42CBA20", Offset = "0x42CAA20", VA = "0x1842CBA20", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x42CBA50", Offset = "0x42CAA50", VA = "0x1842CBA50")]
			public CBLKBNOMEOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum CMKBPAFAJPA : byte
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
		private sealed class NHJMAOEPDFN : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum EEIGALDNGHE
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct CGDIGAMBHCM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public MHPFPCBFNCA.INHNCHELJFB IFMFBEBOABE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public EEIGALDNGHE BINJBBPDLOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public List<JBIEKAJPJEM> GOMHNCOPBBC;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private static readonly EEIGALDNGHE[] NEKLFMDEIDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly MHPFPCBFNCA.INHNCHELJFB DEDCDGJIPOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private bool KACBNAIGAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly JBIEKAJPJEM[] KBEJLIBLCIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly List<JBIEKAJPJEM> CINEOMKMKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly Stack<int> BLDDLHHJFJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<JBIEKAJPJEM> KIDLCNNDKBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> APNCHKAAOBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private bool AHCMCOMPDKJ;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public CGDIGAMBHCM[,] OKDPDKBIFAA
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x4F6D70", Offset = "0x4F5D70", VA = "0x1804F6D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int CHNOHPBKEMM
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x42D8030", Offset = "0x42D7030", VA = "0x1842D8030")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x42D8A40", Offset = "0x42D7A40", VA = "0x1842D8A40")]
			public NHJMAOEPDFN(MHPFPCBFNCA.INHNCHELJFB JLLGINJLFDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x42D7C60", Offset = "0x42D6C60", VA = "0x1842D7C60")]
			public void EDJFGNOHIBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x42D7EF0", Offset = "0x42D6EF0", VA = "0x1842D7EF0")]
			public void EOGEOJPACHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x42D7F00", Offset = "0x42D6F00", VA = "0x1842D7F00")]
			private void EPDHGNOOLEC(IReadOnlyList<JBIEKAJPJEM> GKCPGEEDLNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x42D75E0", Offset = "0x42D65E0", VA = "0x1842D75E0")]
			public void ADMEHHJMPJC(JBIEKAJPJEM LCMJPIGEKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x42D8380", Offset = "0x42D7380", VA = "0x1842D8380")]
			public void KIHNIMAFBDI(IList<JBIEKAJPJEM> LFNOLPDADJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x42D7C70", Offset = "0x42D6C70", VA = "0x1842D7C70")]
			public void ENMNBGCDPLA(IList<JBIEKAJPJEM> LFNOLPDADJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x42D8870", Offset = "0x42D7870", VA = "0x1842D8870")]
			private void PJINBEKEGKF(JBIEKAJPJEM LCMJPIGEKKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x42D77B0", Offset = "0x42D67B0", VA = "0x1842D77B0")]
			private void BAKHOIGIPLF(IList<JBIEKAJPJEM> LFNOLPDADJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x42D8600", Offset = "0x42D7600", VA = "0x1842D8600")]
			private CMKBPAFAJPA KOOJDHKICNG(JBIEKAJPJEM LCMJPIGEKKA)
			{
				return default(CMKBPAFAJPA);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x42D7700", Offset = "0x42D6700", VA = "0x1842D7700")]
			public void ANEHKFACJGN(float LNEGILPDKPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x42D7920", Offset = "0x42D6920", VA = "0x1842D7920")]
			public void CEHBHBELNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x42D81A0", Offset = "0x42D71A0", VA = "0x1842D81A0")]
			private void INKKHOFBGII(List<JBIEKAJPJEM> LFNOLPDADJK, Stack<int> FBBJOFAIDEE, bool GCFIGILNLFK, float PHELDMEHKOA = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x42D7B20", Offset = "0x42D6B20", VA = "0x1842D7B20", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x42D8750", Offset = "0x42D7750", VA = "0x1842D8750")]
			private void NGPBBCDPHAB(List<JBIEKAJPJEM> LFNOLPDADJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum EIGPENCHJNC : byte
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
		private sealed class CIONMKKKEAG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E31C0", Offset = "0x4E21C0", VA = "0x1804E31C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6D3770", Offset = "0x6D2770", VA = "0x1806D3770")]
			[DebuggerHidden]
			public CIONMKKKEAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x4E3E80", Offset = "0x4E2E80", VA = "0x1804E3E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x42CBCD0", Offset = "0x42CACD0", VA = "0x1842CBCD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x42CBD50", Offset = "0x42CAD50", VA = "0x1842CBD50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private const EIGPENCHJNC EKDDDHFLGKL = EIGPENCHJNC.Cancelled | EIGPENCHJNC.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly MHPFPCBFNCA.INHNCHELJFB[] CEKMKHLPGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private NHJMAOEPDFN[] EOAMLNBHPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private LNKLGFONFGE[] FLMOLBLLPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private Coroutine NBFNOAAMHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private WaitForEndOfFrame AHCFCOBNGPB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public MHPFPCBFNCA.INHNCHELJFB PINMPANHPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x56ABE0", Offset = "0x569BE0", VA = "0x18056ABE0")]
			[CompilerGenerated]
			get
			{
				return default(MHPFPCBFNCA.INHNCHELJFB);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5E26E0", Offset = "0x5E16E0", VA = "0x1805E26E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BNBILNPPKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x72BDD0", Offset = "0x72ADD0", VA = "0x18072BDD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E070", Offset = "0x1A5D070", VA = "0x181A5E070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int CHNOHPBKEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x42DBEF0", Offset = "0x42DAEF0", VA = "0x1842DBEF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x42DABA0", Offset = "0x42D9BA0", VA = "0x1842DABA0")]
		public static LBEACJDEKDN GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x42DA5C0", Offset = "0x42D95C0", VA = "0x1842DA5C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x42DAF40", Offset = "0x42D9F40", VA = "0x1842DAF40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x42DAA60", Offset = "0x42D9A60", VA = "0x1842DAA60")]
		private NHJMAOEPDFN BGEEJNFBKHL(MHPFPCBFNCA.INHNCHELJFB ELMEHHJGGCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2E19370", Offset = "0x2E18370", VA = "0x182E19370")]
		private LNKLGFONFGE JMIBLDFLOFO(MHPFPCBFNCA.INHNCHELJFB ELMEHHJGGCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x42DB400", Offset = "0x42DA400", VA = "0x1842DB400")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x42DB3C0", Offset = "0x42DA3C0", VA = "0x1842DB3C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x42DBCC0", Offset = "0x42DACC0", VA = "0x1842DBCC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x42DAC40", Offset = "0x42D9C40", VA = "0x1842DAC40")]
		private void LLGLLADJCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x42DAB10", Offset = "0x42D9B10", VA = "0x1842DAB10")]
		private void EEMIHCOECNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x42DAB90", Offset = "0x42D9B90", VA = "0x1842DAB90")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x42DAC50", Offset = "0x42D9C50", VA = "0x1842DAC50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x42DAB00", Offset = "0x42D9B00", VA = "0x1842DAB00")]
		private void DCLNFKFIHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x42DAB20", Offset = "0x42D9B20", VA = "0x1842DAB20")]
		[IteratorStateMachine(typeof(CIONMKKKEAG))]
		private IEnumerator FFJKJJOFGHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x42DB5B0", Offset = "0x42DA5B0", VA = "0x1842DB5B0", Slot = "7")]
		public LBEACJDEKDN Run(IEnumerator<MFENADOJIIE> CAOCBDKDKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x42DB5C0", Offset = "0x42DA5C0", VA = "0x1842DB5C0", Slot = "8")]
		public LBEACJDEKDN Run(Behaviour EEECBNNPKOA, IEnumerator<MFENADOJIIE> CAOCBDKDKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x42DB480", Offset = "0x42DA480", VA = "0x1842DB480", Slot = "9")]
		public LBEACJDEKDN RunJobbed(HAIIDENMEJD EEECBNNPKOA, IEnumerator<MFENADOJIIE> CAOCBDKDKNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x42DAAA0", Offset = "0x42D9AA0", VA = "0x1842DAAA0", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x42DB7F0", Offset = "0x42DA7F0", VA = "0x1842DB7F0")]
		public void UpdateQueue(MHPFPCBFNCA.INHNCHELJFB LAHCOKLIHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x42DAD80", Offset = "0x42D9D80", VA = "0x1842DAD80")]
		private void OEANNBOMEDB(NHJMAOEPDFN JADBALEIPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x42DAC60", Offset = "0x42D9C60", VA = "0x1842DAC60")]
		private void NEDLEIBDFBD(LNKLGFONFGE JADBALEIPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x42DBE80", Offset = "0x42DAE80", VA = "0x1842DBE80")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class HCHJFLOJPMA
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x42D0240", Offset = "0x42CF240", VA = "0x1842D0240")]
	[CCDNIMICDFI]
	private static void JJACNFBHGAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class FGCFLLCKOLL : BONBGPCGLJB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float LGJPEAJFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x42CEA00", Offset = "0x42CDA00", VA = "0x1842CEA00", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float JADBKCNPDPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x42CE9D0", Offset = "0x42CD9D0", VA = "0x1842CE9D0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float COIBBFIGAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x42CE9E0", Offset = "0x42CD9E0", VA = "0x1842CE9E0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int NOEIMGLJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x42CE9F0", Offset = "0x42CD9F0", VA = "0x1842CE9F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double NLLPMDIPBIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x42CE9B0", Offset = "0x42CD9B0", VA = "0x1842CE9B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public FGCFLLCKOLL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DFIKEAFJCGD
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static byte[] FPMGPNDCJGI;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int HLAPLPHEDOF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int DIHDAAMIHIE;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static BigInteger CBFIPIFMBJA;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
	public DFIKEAFJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x42CDFB0", Offset = "0x42CCFB0", VA = "0x1842CDFB0")]
	private static string FCGBJJFHIPJ(byte[] DJHKGFLFIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x42CE0B0", Offset = "0x42CD0B0", VA = "0x1842CE0B0")]
	public static string JDIAMALCPMN(byte[] ONAFAFJGCAI, bool NMLDFLAABOD)
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
		[Cpp2IlInjected.Address(RVA = "0x4E5AB0", Offset = "0x4E4AB0", VA = "0x1804E5AB0")]
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

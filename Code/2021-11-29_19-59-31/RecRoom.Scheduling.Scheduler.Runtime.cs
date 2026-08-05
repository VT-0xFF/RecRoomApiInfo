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
		private delegate List<PlayerLoopSystem> EKCJMIJCDNO(List<PlayerLoopSystem> FOMJMIPPEMH, int HBHCAJLFBDO);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct DNGOEPELNED
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct OJPNCGPNMDE
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static EMHINGNNCEH IPAIENNNKLA;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x3B02CE0", Offset = "0x3B016E0", VA = "0x183B02CE0")]
				public static PlayerLoopSystem PMGODOBEAEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct AHPPIFOKMKC
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static EMHINGNNCEH JMAGOLGMFKH;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3AF6050", Offset = "0x3AF4A50", VA = "0x183AF6050")]
				public static PlayerLoopSystem PMGODOBEAEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct JGNCOKCBIOB
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static EMHINGNNCEH AJNFKNLPDGD;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3AFCE10", Offset = "0x3AFB810", VA = "0x183AFCE10")]
				public static PlayerLoopSystem PMGODOBEAEE()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct IONJPFANENF
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class EPFGLNFMILO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public LEDDDABCLCH.FAAOMGJNMJL key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
					public EPFGLNFMILO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x3AF9090", Offset = "0x3AF7A90", VA = "0x183AF9090")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable LHCOOLMGDEJ;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3AFCD10", Offset = "0x3AFB710", VA = "0x183AFCD10")]
				public static PlayerLoopSystem FLFOPDODJPH(LEDDDABCLCH.FAAOMGJNMJL AOLPFBNJMEA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct FFNDHDMHAAK
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class KNNELPGEJGG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public LEDDDABCLCH.FAAOMGJNMJL key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
					public KNNELPGEJGG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x3AFFD60", Offset = "0x3AFE760", VA = "0x183AFFD60")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3AF93A0", Offset = "0x3AF7DA0", VA = "0x183AF93A0")]
				public static PlayerLoopSystem FLFOPDODJPH(LEDDDABCLCH.FAAOMGJNMJL AOLPFBNJMEA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LMPKGGIHPDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public LMPKGGIHPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3B007E0", Offset = "0x3AFF1E0", VA = "0x183B007E0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool NKNBFOCOJBE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool DNIBADCGECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8650", Offset = "0x3AF7050", VA = "0x183AF8650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7F40", Offset = "0x3AF6940", VA = "0x183AF7F40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3AF70F0", Offset = "0x3AF5AF0", VA = "0x183AF70F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7F80", Offset = "0x3AF6980", VA = "0x183AF7F80")]
		private static void DHMPPFNFNPD(LEDDDABCLCH.FAAOMGJNMJL AOLPFBNJMEA, ref PlayerLoopSystem HDDHDHDBAJE, Type HKDDLKMECEN, Type KNCPEGGMEPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AF81E0", Offset = "0x3AF6BE0", VA = "0x183AF81E0")]
		private static void MIPMFAAFIEG(ref PlayerLoopSystem HDDHDHDBAJE, Type HKDDLKMECEN, Type KNCPEGGMEPN, EKCJMIJCDNO NAPMDIFDAFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8550", Offset = "0x3AF6F50", VA = "0x183AF8550")]
		private static void NBMLJBIEIHO(ref PlayerLoopSystem HDDHDHDBAJE, Type HKDDLKMECEN, Type KNCPEGGMEPN, PlayerLoopSystem? ILLGGNNGCFD, PlayerLoopSystem? MCALIPCEBKH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LEDDDABCLCH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum FAAOMGJNMJL
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
	public class KPHLJHKCAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly FAAOMGJNMJL ONCFBGBJMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly OIKNCOLOGLI GDLPCOBFADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long HGOOMMAEBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long GFLLLDDAGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long OAJMGBCMFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int JPIFNHPCHKG;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3B00180", Offset = "0x3AFEB80", VA = "0x183B00180")]
		public KPHLJHKCAAE(FAAOMGJNMJL IIHEJDBGGKG, int KBKPBMGNLNB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFE20", Offset = "0x3AFE820", VA = "0x183AFFE20")]
		public void JMMGIFLOOAB(int PKCCAGOICGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFEA0", Offset = "0x3AFE8A0", VA = "0x183AFFEA0")]
		public void LMGJKIPMLOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFE40", Offset = "0x3AFE840", VA = "0x183AFFE40")]
		public void KAOIKDCCCPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFF10", Offset = "0x3AFE910", VA = "0x183AFFF10")]
		public void OLAMLNKCFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3B000E0", Offset = "0x3AFEAE0", VA = "0x183B000E0")]
		public double PBLHHBHFKAG(int MFALFCAJHIB)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int KBBJKLHDAOK = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static FAAOMGJNMJL[] HOPJJLEFDEO;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static KPHLJHKCAAE[] GEMBEANAKKE;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B003A0", Offset = "0x3AFEDA0", VA = "0x183B003A0")]
	public static KPHLJHKCAAE MBMCGEPBIFI(FAAOMGJNMJL AOLPFBNJMEA, int KBKPBMGNLNB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3B00260", Offset = "0x3AFEC60", VA = "0x183B00260")]
	public static KPHLJHKCAAE GPNFGAFIENF(FAAOMGJNMJL AOLPFBNJMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3B002F0", Offset = "0x3AFECF0", VA = "0x183B002F0")]
	public static void HODFMBJFJAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OIKNCOLOGLI : AKELBJPBCJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MOAPPNINJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> HDEBDNDHCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double OKHMJOFAOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double CEAMMMGKAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double MNOJKNFLPIM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MIAEDNKBGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B02B10", Offset = "0x3B01510", VA = "0x183B02B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double IGDJHIHBKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B02AB0", Offset = "0x3B014B0", VA = "0x183B02AB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GNLFJJLIFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xBA2E00", Offset = "0xBA1800", VA = "0x180BA2E00", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double NJGFJNLFEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBA2DE0", Offset = "0xBA17E0", VA = "0x180BA2DE0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B02C50", Offset = "0x3B01650", VA = "0x183B02C50")]
	public OIKNCOLOGLI(int BAJAKPCJKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B02B50", Offset = "0x3B01550", VA = "0x183B02B50", Slot = "4")]
	public void MKNNKBIBBHB(double HODMGEEDEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B02A40", Offset = "0x3B01440", VA = "0x183B02A40", Slot = "5")]
	public void AKCCMDHJJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GKNJHJMBHMD : AKELBJPBCJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long OLGKPPPGOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double HDDGIEPJOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double JIDFHMMGMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double DFGIIBJBHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double DIKBEDHNLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double OKHMJOFAOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double CEAMMMGKAIH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JCPPMPGPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GNLFJJLIFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xBA2DF0", Offset = "0xBA17F0", VA = "0x180BA2DF0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double NJGFJNLFEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9850A0", Offset = "0x983AA0", VA = "0x1809850A0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MCIKDHFHCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xBA2DE0", Offset = "0xBA17E0", VA = "0x180BA2DE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double JPMGFOAAHGB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3611400", Offset = "0x360FE00", VA = "0x183611400")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double IGDJHIHBKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xBA2D00", Offset = "0xBA1700", VA = "0x180BA2D00", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB900", Offset = "0x3AFA300", VA = "0x183AFB900", Slot = "4")]
	public void MKNNKBIBBHB(double HODMGEEDEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB8C0", Offset = "0x3AFA2C0", VA = "0x183AFB8C0", Slot = "5")]
	public void AKCCMDHJJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFBA20", Offset = "0x3AFA420", VA = "0x183AFBA20")]
	public GKNJHJMBHMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AKELBJPBCJC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double IGDJHIHBKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double GNLFJJLIFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double NJGFJNLFEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKNNKBIBBHB(double HODMGEEDEKD);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKCCMDHJJJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OLOLJCIKGKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface HNHAPJGOJFO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool GPEPPPOFKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GJDDIHEAKNL();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FPPOIFHHJJG();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class GIIGIJCBPEK<TPromise, TMainThreadPromise> : HNHAPJGOJFO where TPromise : OJNMJAKAOEK where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise BEGFKBCBFFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise EOJPAAKFLKE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise OBDLNGGGBCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3352CC0", Offset = "0x33516C0", VA = "0x183352CC0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GPEPPPOFKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3352D20", Offset = "0x3351720", VA = "0x183352D20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8F00", Offset = "0x2DA7900", VA = "0x182DA8F00")]
		protected GIIGIJCBPEK(TPromise BEGFKBCBFFJ, TMainThreadPromise LDLFADHHKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3352C90", Offset = "0x3351690", VA = "0x183352C90", Slot = "5")]
		public void GJDDIHEAKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7757C0", Offset = "0x7741C0", VA = "0x1807757C0", Slot = "6")]
		public void FPPOIFHHJJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void IFHFODMGLDD(TPromise BEGFKBCBFFJ);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void JKGBHKFKNPO();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class OFNMPGINNFD<T> : GIIGIJCBPEK<global::GDHDNGFJPDI<T>, global::AILNGNLEFKP<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3356010", Offset = "0x3354A10", VA = "0x183356010")]
		public OFNMPGINNFD(global::GDHDNGFJPDI<T> BEGFKBCBFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3355D80", Offset = "0x3354780", VA = "0x183355D80", Slot = "7")]
		protected override void IFHFODMGLDD(global::GDHDNGFJPDI<T> BEGFKBCBFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3355F80", Offset = "0x3354980", VA = "0x183355F80", Slot = "8")]
		protected override void JKGBHKFKNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2F104F0", Offset = "0x2F0EEF0", VA = "0x182F104F0")]
		[CompilerGenerated]
		private void MKLMCMCBEEJ(T ANEPELFNGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3355FE0", Offset = "0x33549E0", VA = "0x183355FE0")]
		[CompilerGenerated]
		private void KMDJOENOJEF(string PFPOFNKJBMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class BHOBCHMNOKA : GIIGIJCBPEK<OJNMJAKAOEK, BBHGGOLAFNL>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6310", Offset = "0x3AF4D10", VA = "0x183AF6310")]
		public BHOBCHMNOKA(OJNMJAKAOEK BEGFKBCBFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF61F0", Offset = "0x3AF4BF0", VA = "0x183AF61F0", Slot = "7")]
		protected override void IFHFODMGLDD(OJNMJAKAOEK BEGFKBCBFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF62C0", Offset = "0x3AF4CC0", VA = "0x183AF62C0", Slot = "8")]
		protected override void JKGBHKFKNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA48420", Offset = "0xA46E20", VA = "0x180A48420")]
		[CompilerGenerated]
		private void MKLMCMCBEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA48400", Offset = "0xA46E00", VA = "0x180A48400")]
		[CompilerGenerated]
		private void KMDJOENOJEF(string PFPOFNKJBMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class DFCKAIHLPBD : HNHAPJGOJFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action OOLHPCIPCBL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GPEPPPOFKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x427F60", Offset = "0x426960", VA = "0x180427F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x558960", Offset = "0x557360", VA = "0x180558960")]
		public DFCKAIHLPBD(Action OOLHPCIPCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBB2500", Offset = "0xBB0F00", VA = "0x180BB2500", Slot = "5")]
		public void GJDDIHEAKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "6")]
		public void FPPOIFHHJJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<HNHAPJGOJFO> GNDIKIBECFA;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x24D7680", Offset = "0x24D6080", VA = "0x1824D7680")]
	public static global::GDHDNGFJPDI<T> DLBAAOPALCE<T>(this global::GDHDNGFJPDI<T> BEGFKBCBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B03090", Offset = "0x3B01A90", VA = "0x183B03090")]
	public static OJNMJAKAOEK DLBAAOPALCE(this OJNMJAKAOEK BEGFKBCBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B03010", Offset = "0x3B01A10", VA = "0x183B03010")]
	public static void DLBAAOPALCE(Action OOLHPCIPCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24D75C0", Offset = "0x24D5FC0", VA = "0x1824D75C0")]
	private static global::GDHDNGFJPDI<T> CIJGLKLCDEP<T>(global::GDHDNGFJPDI<T> BEGFKBCBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B02F30", Offset = "0x3B01930", VA = "0x183B02F30")]
	private static OJNMJAKAOEK CIJGLKLCDEP(OJNMJAKAOEK BEGFKBCBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B031A0", Offset = "0x3B01BA0", VA = "0x183B031A0")]
	private static void GEPLLPHGGKM(HNHAPJGOJFO ACAACIJMEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B03380", Offset = "0x3B01D80", VA = "0x183B03380")]
	private static void JEKDBCAKPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B036A0", Offset = "0x3B020A0", VA = "0x183B036A0")]
	private static void MHOFIMDLCHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B02E80", Offset = "0x3B01880", VA = "0x183B02E80")]
	private static void BJBDFFDNJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ACNFIHEKOOI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HDLGICNFJLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BBHGGOLAFNL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public HDLGICNFJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBEA0", Offset = "0x3AFA8A0", VA = "0x183AFBEA0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBE90", Offset = "0x3AFA890", VA = "0x183AFBE90")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MFCEANFOBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public MFCEANFOBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3B00FE0", Offset = "0x3AFF9E0", VA = "0x183B00FE0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PKAJLFENEBJ : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public BBHGGOLAFNL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public PKAJLFENEBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3B03B70", Offset = "0x3B02570", VA = "0x183B03B70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3B038A0", Offset = "0x3B022A0", VA = "0x183B038A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3B03C20", Offset = "0x3B02620", VA = "0x183B03C20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3B03B20", Offset = "0x3B02520", VA = "0x183B03B20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MPMHFBBFLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BBHGGOLAFNL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public MPMHFBBFLNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HBMNNAMPNLB : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public BBHGGOLAFNL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private MPMHFBBFLNH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public HBMNNAMPNLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBAB0", Offset = "0x3AFA4B0", VA = "0x183AFBAB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBE00", Offset = "0x3AFA800", VA = "0x183AFBE00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string BMJEIBFJLED = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string LDFLDDBILHK = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string OBMHNBPFNLL = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string PDGKHIEAGNF = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string MFOPFCENEOE = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float DOLPAHAKHDA = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static OJNMJAKAOEK HJDNKLFBGJK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation FFOHNLHKAFC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static OJNMJAKAOEK LDELHGMECGA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string BCCMGDCFLCP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority LENPDGCKIIP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool OMDBPIEPOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5D90", Offset = "0x3AF4790", VA = "0x183AF5D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BEMILEFKIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5E30", Offset = "0x3AF4830", VA = "0x183AF5E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool OEFCKCPLIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5FF0", Offset = "0x3AF49F0", VA = "0x183AF5FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> BBCPHNADMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5E90", Offset = "0x3AF4890", VA = "0x183AF5E90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5F40", Offset = "0x3AF4940", VA = "0x183AF5F40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5BD0", Offset = "0x3AF45D0", VA = "0x183AF5BD0")]
	public static OJNMJAKAOEK CLDNCKEGCON(string BDCKOMGGDBH, LoadSceneMode FFEKEOEODHP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF59C0", Offset = "0x3AF43C0", VA = "0x183AF59C0")]
	public static OJNMJAKAOEK CCELIGAIKKK(string BDCKOMGGDBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5950", Offset = "0x3AF4350", VA = "0x183AF5950")]
	[IteratorStateMachine(typeof(PKAJLFENEBJ))]
	private static IEnumerator<EIDNADAHLNE> BAFCAMMJFPH(string BDCKOMGGDBH, BBHGGOLAFNL CDOHDDJCPFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5D10", Offset = "0x3AF4710", VA = "0x183AF5D10")]
	[IteratorStateMachine(typeof(HBMNNAMPNLB))]
	private static IEnumerator<EIDNADAHLNE> EJDDOHNBJNL(string BDCKOMGGDBH, LoadSceneMode FFEKEOEODHP, BBHGGOLAFNL CDOHDDJCPFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JOBJLHAPCEI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD790", Offset = "0x3AFC190", VA = "0x183AFD790")]
	public static IDisposable KNHHFICLLJD(this DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD810", Offset = "0x3AFC210", VA = "0x183AFD810")]
	public static IDisposable KNHHFICLLJD(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD1C0", Offset = "0x3AFBBC0", VA = "0x183AFD1C0")]
	public static IDisposable BFKHFEKJEDA(this DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD2C0", Offset = "0x3AFBCC0", VA = "0x183AFD2C0")]
	public static IDisposable BGIDCEPOCHD(this DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD6A0", Offset = "0x3AFC0A0", VA = "0x183AFD6A0")]
	public static IDisposable JIBHGGHCJPJ(this DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDB60", Offset = "0x3AFC560", VA = "0x183AFDB60")]
	public static IDisposable PODHLMBGFIB(this DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD430", Offset = "0x3AFBE30", VA = "0x183AFD430")]
	public static IDisposable DOJJBAPGHHC(this DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD9D0", Offset = "0x3AFC3D0", VA = "0x183AFD9D0")]
	public static IDisposable MDEDHBEFBCI(this DHFNMJKMPFO NJEMLNPONME, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD4A0", Offset = "0x3AFBEA0", VA = "0x183AFD4A0")]
	public static IDisposable FHGHGOOFIGA(this DHFNMJKMPFO NJEMLNPONME, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD710", Offset = "0x3AFC110", VA = "0x183AFD710")]
	public static IDisposable KFFPPCAKEMN(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD140", Offset = "0x3AFBB40", VA = "0x183AFD140")]
	public static IDisposable AMGAHJHHFJI(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDAE0", Offset = "0x3AFC4E0", VA = "0x183AFDAE0")]
	public static IDisposable PFEHGEDHKAN(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD230", Offset = "0x3AFBC30", VA = "0x183AFD230")]
	public static IDisposable BGHJLHHKKIL(this DHFNMJKMPFO NJEMLNPONME, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD620", Offset = "0x3AFC020", VA = "0x183AFD620")]
	public static IDisposable IEOGLGJNFDB(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD3B0", Offset = "0x3AFBDB0", VA = "0x183AFD3B0")]
	public static IDisposable CDGNAGLPGEB(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD330", Offset = "0x3AFBD30", VA = "0x183AFD330")]
	public static IDisposable BKIBMMMNNOB(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD0B0", Offset = "0x3AFBAB0", VA = "0x183AFD0B0")]
	public static IDisposable AGLKEIEPOAF(this DHFNMJKMPFO NJEMLNPONME, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDA60", Offset = "0x3AFC460", VA = "0x183AFDA60")]
	public static IDisposable OLJEHELGFPN(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD520", Offset = "0x3AFBF20", VA = "0x183AFD520")]
	public static IDisposable GGGOAOOLDEJ(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD5A0", Offset = "0x3AFBFA0", VA = "0x183AFD5A0")]
	public static IDisposable HOJALMKOMMI(this DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class PNIELLBGLAE
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B03EC0", Offset = "0x3B028C0", VA = "0x183B03EC0")]
	public static IDisposable ABFKFJLCDDM(this MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B03D00", Offset = "0x3B02700", VA = "0x183B03D00")]
	public static IDisposable ABFKFJLCDDM(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B04540", Offset = "0x3B02F40", VA = "0x183B04540")]
	public static IDisposable HHCOOIBBPDK(this MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B045B0", Offset = "0x3B02FB0", VA = "0x183B045B0")]
	public static IDisposable IDJEEJFMEDM(this MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B04150", Offset = "0x3B02B50", VA = "0x183B04150")]
	public static IDisposable BNHOCGIJFPD(this MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3B04730", Offset = "0x3B03130", VA = "0x183B04730")]
	public static IDisposable MFIJJAAADDA(this MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3B047A0", Offset = "0x3B031A0", VA = "0x183B047A0")]
	public static IDisposable NEFBDKLLIAD(this MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3B046A0", Offset = "0x3B030A0", VA = "0x183B046A0")]
	public static IDisposable LLCPHHIBFLA(this MonoBehaviour ODBIGLNCAFE, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B04440", Offset = "0x3B02E40", VA = "0x183B04440")]
	public static IDisposable GDGBNDNLIPK(this MonoBehaviour ODBIGLNCAFE, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B04890", Offset = "0x3B03290", VA = "0x183B04890")]
	public static IDisposable OPGBCGFKEAN(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B041C0", Offset = "0x3B02BC0", VA = "0x183B041C0")]
	public static IDisposable CGINLMCPEHI(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B04810", Offset = "0x3B03210", VA = "0x183B04810")]
	public static IDisposable NIDNGAOCOAO(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B04340", Offset = "0x3B02D40", VA = "0x183B04340")]
	public static IDisposable FINAJCNMPOF(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B040D0", Offset = "0x3B02AD0", VA = "0x183B040D0")]
	public static IDisposable BJIDOPOGGMC(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B044C0", Offset = "0x3B02EC0", VA = "0x183B044C0")]
	public static IDisposable HCNMBMFNICF(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B04910", Offset = "0x3B03310", VA = "0x183B04910")]
	public static IDisposable PGFFJNFLFAL(this MonoBehaviour ODBIGLNCAFE, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B04240", Offset = "0x3B02C40", VA = "0x183B04240")]
	public static IDisposable DAFMEJFKGEP(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3B043C0", Offset = "0x3B02DC0", VA = "0x183B043C0")]
	public static IDisposable GBHDHFFGJKH(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B03F40", Offset = "0x3B02940", VA = "0x183B03F40")]
	public static IDisposable ADILOJKDDDN(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B04040", Offset = "0x3B02A40", VA = "0x183B04040")]
	public static IDisposable BCNMLIBKMPJ(this MonoBehaviour ODBIGLNCAFE, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B03FC0", Offset = "0x3B029C0", VA = "0x183B03FC0")]
	public static IDisposable ANFHBFOGHOC(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B042C0", Offset = "0x3B02CC0", VA = "0x183B042C0")]
	public static IDisposable DGDKEFKIICJ(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B04620", Offset = "0x3B03020", VA = "0x183B04620")]
	public static IDisposable IEMNOAHAGNC(this MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LPDGBNLMBBI
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class FBNIHPNPIIK : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LBAOFFOBDIC.MEBFJMMLIOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private DINMIAGNIAN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public FBNIHPNPIIK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9140", Offset = "0x3AF7B40", VA = "0x183AF9140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9210", Offset = "0x3AF7C10", VA = "0x183AF9210", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OBOGJMHACLB : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public LBAOFFOBDIC.MEBFJMMLIOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private DINMIAGNIAN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public OBOGJMHACLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3B02900", Offset = "0x3B01300", VA = "0x183B02900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3B029F0", Offset = "0x3B013F0", VA = "0x183B029F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B00BF0", Offset = "0x3AFF5F0", VA = "0x183B00BF0")]
	public static CGNOFOAADKJ ABFKFJLCDDM(Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B00B00", Offset = "0x3AFF500", VA = "0x183B00B00")]
	public static CGNOFOAADKJ ABFKFJLCDDM(Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3B008E0", Offset = "0x3AFF2E0", VA = "0x183B008E0")]
	public static CGNOFOAADKJ ABFKFJLCDDM(Behaviour NJEMLNPONME, Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B009F0", Offset = "0x3AFF3F0", VA = "0x183B009F0")]
	public static CGNOFOAADKJ ABFKFJLCDDM(Behaviour NJEMLNPONME, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B00DC0", Offset = "0x3AFF7C0", VA = "0x183B00DC0")]
	public static CGNOFOAADKJ KNHHFICLLJD(DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B00ED0", Offset = "0x3AFF8D0", VA = "0x183B00ED0")]
	public static CGNOFOAADKJ KNHHFICLLJD(DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B00CE0", Offset = "0x3AFF6E0", VA = "0x183B00CE0")]
	[IteratorStateMachine(typeof(FBNIHPNPIIK))]
	private static IEnumerator<EIDNADAHLNE> KDHDIBHJFKN(LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB, Action CHNEGDBDNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B00D50", Offset = "0x3AFF750", VA = "0x183B00D50")]
	[IteratorStateMachine(typeof(OBOGJMHACLB))]
	private static IEnumerator<EIDNADAHLNE> KDHDIBHJFKN(LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB, Action<float> CHNEGDBDNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NMOGCNFPICM
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FCAMOMCLMMK : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LBAOFFOBDIC.MEBFJMMLIOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private OMMOMMDLJBG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public FCAMOMCLMMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9260", Offset = "0x3AF7C60", VA = "0x183AF9260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9350", Offset = "0x3AF7D50", VA = "0x183AF9350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3B02710", Offset = "0x3B01110", VA = "0x183B02710")]
	public static CGNOFOAADKJ ABFKFJLCDDM(float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3B02650", Offset = "0x3B01050", VA = "0x183B02650")]
	public static CGNOFOAADKJ ABFKFJLCDDM(MonoBehaviour ODBIGLNCAFE, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3B027C0", Offset = "0x3B011C0", VA = "0x183B027C0")]
	public static CGNOFOAADKJ DBNAJPJBPNG(DHFNMJKMPFO NJEMLNPONME, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B02880", Offset = "0x3B01280", VA = "0x183B02880")]
	[IteratorStateMachine(typeof(FCAMOMCLMMK))]
	private static IEnumerator<EIDNADAHLNE> KDHDIBHJFKN(float NJAFDJAFCHE, LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB, Action<float> CHNEGDBDNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GBCBMAEBMPE
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IKDIKMHLDFL : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public LBAOFFOBDIC.MEBFJMMLIOC queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public IKDIKMHLDFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCC20", Offset = "0x3AFB620", VA = "0x183AFCC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCCC0", Offset = "0x3AFB6C0", VA = "0x183AFCCC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB850", Offset = "0x3AFA250", VA = "0x183AFB850")]
	[IteratorStateMachine(typeof(IKDIKMHLDFL))]
	private static IEnumerator<EIDNADAHLNE> JPAMJMMFNEM(LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ, Func<bool> FHMCKHFCCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AFB700", Offset = "0x3AFA100", VA = "0x183AFB700")]
	public static CGNOFOAADKJ GCDGJOMAONG(this MonoBehaviour ODBIGLNCAFE, Func<bool> FHMCKHFCCEA, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ = LBAOFFOBDIC.MEBFJMMLIOC.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NMJEAPEEPAB
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JMFMLOOHHBE : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LBAOFFOBDIC.MEBFJMMLIOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public JMFMLOOHHBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCFB0", Offset = "0x3AFB9B0", VA = "0x183AFCFB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AFD060", Offset = "0x3AFBA60", VA = "0x183AFD060", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DBODDAMIGMM : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LBAOFFOBDIC.MEBFJMMLIOC queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private EIDNADAHLNE <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public DBODDAMIGMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3AF86C0", Offset = "0x3AF70C0", VA = "0x183AF86C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8780", Offset = "0x3AF7180", VA = "0x183AF8780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B02420", Offset = "0x3B00E20", VA = "0x183B02420")]
	[IteratorStateMachine(typeof(JMFMLOOHHBE))]
	private static IEnumerator<EIDNADAHLNE> LNCJHFMIIIJ(float GHMCIHBEFMJ, LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B024B0", Offset = "0x3B00EB0", VA = "0x183B024B0")]
	[IteratorStateMachine(typeof(DBODDAMIGMM))]
	private static IEnumerator<EIDNADAHLNE> OFNINCILPJP(float GHMCIHBEFMJ, LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B021D0", Offset = "0x3B00BD0", VA = "0x183B021D0")]
	public static IDisposable KDLHFLICNCN(this MonoBehaviour ODBIGLNCAFE, float GHMCIHBEFMJ, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B01D20", Offset = "0x3B00720", VA = "0x183B01D20")]
	public static CGNOFOAADKJ IPBEFPDBHOH(this MonoBehaviour ODBIGLNCAFE, float GHMCIHBEFMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B02080", Offset = "0x3B00A80", VA = "0x183B02080")]
	public static CGNOFOAADKJ KDLHFLICNCN(this MonoBehaviour ODBIGLNCAFE, float GHMCIHBEFMJ, LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B01BF0", Offset = "0x3B005F0", VA = "0x183B01BF0")]
	public static CGNOFOAADKJ DBJKBIHHJIN(this MonoBehaviour ODBIGLNCAFE, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B01C00", Offset = "0x3B00600", VA = "0x183B01C00")]
	public static CGNOFOAADKJ FEGENOKPFOL(this MonoBehaviour ODBIGLNCAFE, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B02530", Offset = "0x3B00F30", VA = "0x183B02530")]
	public static CGNOFOAADKJ PKNBKCFJEBB(this MonoBehaviour ODBIGLNCAFE, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B024A0", Offset = "0x3B00EA0", VA = "0x183B024A0")]
	public static CGNOFOAADKJ MGLENIDEMNL(this MonoBehaviour ODBIGLNCAFE, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B01AD0", Offset = "0x3B004D0", VA = "0x183B01AD0")]
	public static CGNOFOAADKJ AOPBCMFMGPN(this MonoBehaviour ODBIGLNCAFE, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B01AE0", Offset = "0x3B004E0", VA = "0x183B01AE0")]
	private static CGNOFOAADKJ CJMIKLKDAJK(MonoBehaviour ODBIGLNCAFE, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B01E60", Offset = "0x3B00860", VA = "0x183B01E60")]
	public static CGNOFOAADKJ JLAFGNCEECM(this MonoBehaviour ODBIGLNCAFE, float HOMLHKFDNEA, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3B02310", Offset = "0x3B00D10", VA = "0x183B02310")]
	public static CGNOFOAADKJ LMCNJHBKJCF(this MonoBehaviour ODBIGLNCAFE, float HOMLHKFDNEA, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B02540", Offset = "0x3B00F40", VA = "0x183B02540")]
	public static CGNOFOAADKJ PMJENOMKOLA(this MonoBehaviour ODBIGLNCAFE, float HOMLHKFDNEA, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3B01F70", Offset = "0x3B00970", VA = "0x183B01F70")]
	public static CGNOFOAADKJ JLFGPHDAHEF(this MonoBehaviour ODBIGLNCAFE, float HOMLHKFDNEA, Action NBGBFEMKBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3B01C10", Offset = "0x3B00610", VA = "0x183B01C10")]
	public static CGNOFOAADKJ FOKNAODAEKP(this MonoBehaviour ODBIGLNCAFE, float HOMLHKFDNEA, Action NBGBFEMKBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LIOILNIEJHJ : HKGPHOFMLFC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OAHLGPJHBJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public LIOILNIEJHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public OAHLGPJHBJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8690", Offset = "0x3AF7090", VA = "0x183AF8690")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DBEKFFKCPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LIOILNIEJHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
		public DBEKFFKCPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8690", Offset = "0x3AF7090", VA = "0x183AF8690")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float JCMAGJJHKMC;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8FB0", Offset = "0x3AF79B0", VA = "0x183AF8FB0")]
	public LIOILNIEJHJ(Behaviour NJEMLNPONME, float JCMAGJJHKMC, [Optional] Action APEMPOAHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3B00640", Offset = "0x3AFF040", VA = "0x183B00640", Slot = "9")]
	protected override bool DFIGGMAEAIN(Action OOLHPCIPCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3B00710", Offset = "0x3AFF110", VA = "0x183B00710", Slot = "10")]
	protected override bool NEIOCBKEKCI(Action OOLHPCIPCBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EPOEEKMDMPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ALLCMMOAKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GFHJJBEJJOH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FPPCGFGMIFB(bool KCBJBHPKAGL = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FPPCGFGMIFB(Action OOLHPCIPCBL, bool KCBJBHPKAGL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class HKGPHOFMLFC : EPOEEKMDMPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class IBHGACEHGML : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public IBHGACEHGML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC550", Offset = "0x3AFAF50", VA = "0x183AFC550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC5F0", Offset = "0x3AFAFF0", VA = "0x183AFC5F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour NJEMLNPONME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action APEMPOAHPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private HFJGPNNFFKA NKBCHHMNNAI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ALLCMMOAKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xB4DB30", Offset = "0xB4C530", VA = "0x180B4DB30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GFHJJBEJJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC2E0", Offset = "0x3AFACE0", VA = "0x183AFC2E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC220", Offset = "0x3AFAC20", VA = "0x183AFC220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x25922C0", Offset = "0x2590CC0", VA = "0x1825922C0")]
	protected HKGPHOFMLFC(Behaviour NJEMLNPONME, [Optional] Action APEMPOAHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC160", Offset = "0x3AFAB60", VA = "0x183AFC160", Slot = "7")]
	public bool FPPCGFGMIFB(bool KCBJBHPKAGL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC110", Offset = "0x3AFAB10", VA = "0x183AFC110", Slot = "8")]
	public bool FPPCGFGMIFB(Action OOLHPCIPCBL, bool KCBJBHPKAGL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool DFIGGMAEAIN(Action OOLHPCIPCBL);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NEIOCBKEKCI(Action OOLHPCIPCBL);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC0F0", Offset = "0x3AFAAF0", VA = "0x183AFC0F0")]
	protected void EOPAEKMDHMC(Action OOLHPCIPCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC380", Offset = "0x3AFAD80", VA = "0x183AFC380")]
	protected OJNMJAKAOEK ODDKHPLHAGP(float MMJKEPHGEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC080", Offset = "0x3AFAA80", VA = "0x183AFC080")]
	private void BMAILMEPJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC1C0", Offset = "0x3AFABC0", VA = "0x183AFC1C0")]
	[IteratorStateMachine(typeof(IBHGACEHGML))]
	private static IEnumerator<EIDNADAHLNE> HPCBIELFKCD(float MMJKEPHGEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC2C0", Offset = "0x3AFACC0", VA = "0x183AFC2C0")]
	[CompilerGenerated]
	private void NDPACNOCNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NIDINNJLPBN : HKGPHOFMLFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float EIGDBNIDCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int MIMOMGAKOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float AGJKNJDHHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] BFNJMBDFNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int IEIMNAANJBJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DNLNADNGJFN HLNBIADJMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x44E670", Offset = "0x44D070", VA = "0x18044E670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4C2130", Offset = "0x4C0B30", VA = "0x1804C2130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3B019C0", Offset = "0x3B003C0", VA = "0x183B019C0")]
	public NIDINNJLPBN(Behaviour NJEMLNPONME, float CCBACHNJEHB, int MIMOMGAKOHG, [Optional] Action APEMPOAHPIP, float AGJKNJDHHGA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x427E40", Offset = "0x426840", VA = "0x180427E40", Slot = "9")]
	protected override bool DFIGGMAEAIN(Action OOLHPCIPCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B017A0", Offset = "0x3B001A0", VA = "0x183B017A0", Slot = "10")]
	protected override bool NEIOCBKEKCI(Action OOLHPCIPCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B01710", Offset = "0x3B00110", VA = "0x183B01710")]
	private void LFDIIDKLCFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class EFHKKBGCCMK : HKGPHOFMLFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float JCMAGJJHKMC;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8FB0", Offset = "0x3AF79B0", VA = "0x183AF8FB0")]
	public EFHKKBGCCMK(Behaviour NJEMLNPONME, float JCMAGJJHKMC, [Optional] Action APEMPOAHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x427E40", Offset = "0x426840", VA = "0x180427E40", Slot = "9")]
	protected override bool DFIGGMAEAIN(Action OOLHPCIPCBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3AF8F70", Offset = "0x3AF7970", VA = "0x183AF8F70", Slot = "10")]
	protected override bool NEIOCBKEKCI(Action OOLHPCIPCBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class CNDNFBMFFHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class CDOAMGOCEMC : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public CDOAMGOCEMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3AF63C0", Offset = "0x3AF4DC0", VA = "0x183AF63C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3AF64B0", Offset = "0x3AF4EB0", VA = "0x183AF64B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CGNOFOAADKJ OFIOEDOAMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private DHFNMJKMPFO NJEMLNPONME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action CHNEGDBDNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> OIEMKDPKIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float JKJOLPNOBHI;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6F60", Offset = "0x3AF5960", VA = "0x183AF6F60")]
	public CNDNFBMFFHP(DHFNMJKMPFO NJEMLNPONME, Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6DD0", Offset = "0x3AF57D0", VA = "0x183AF6DD0")]
	public CNDNFBMFFHP(DHFNMJKMPFO NJEMLNPONME, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6C80", Offset = "0x3AF5680", VA = "0x183AF6C80")]
	public CNDNFBMFFHP(DHFNMJKMPFO NJEMLNPONME, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6500", Offset = "0x3AF4F00", VA = "0x183AF6500")]
	private void ABFKFJLCDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF69E0", Offset = "0x3AF53E0", VA = "0x183AF69E0")]
	private void OIIKPNJFLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6850", Offset = "0x3AF5250", VA = "0x183AF6850")]
	private void KGEMNHODOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6B60", Offset = "0x3AF5560", VA = "0x183AF6B60")]
	private void PMIINJCNLKK(string PFPOFNKJBMD, Action MPNNDGNCCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6980", Offset = "0x3AF5380", VA = "0x183AF6980")]
	[IteratorStateMachine(typeof(CDOAMGOCEMC))]
	private IEnumerator<EIDNADAHLNE> KIOFJKHJLKI(Action MPNNDGNCCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6780", Offset = "0x3AF5180", VA = "0x183AF6780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6700", Offset = "0x3AF5100", VA = "0x183AF6700")]
	[CompilerGenerated]
	private void CEKDLFHNOGG(string HIHCHEKBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6680", Offset = "0x3AF5080", VA = "0x183AF6680")]
	[CompilerGenerated]
	private void AMOOCDKFILB(string HIHCHEKBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3AF67D0", Offset = "0x3AF51D0", VA = "0x183AF67D0")]
	[CompilerGenerated]
	private void JDGNDLINAGG(string HIHCHEKBDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class AAGCLMDDDIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ECFMPLNDBEH : IEnumerator<EIDNADAHLNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EIDNADAHLNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private EIDNADAHLNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
		[DebuggerHidden]
		public ECFMPLNDBEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8E30", Offset = "0x3AF7830", VA = "0x183AF8E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8F20", Offset = "0x3AF7920", VA = "0x183AF8F20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private CGNOFOAADKJ OFIOEDOAMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour ODBIGLNCAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action CHNEGDBDNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> OIEMKDPKIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float JKJOLPNOBHI;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5670", Offset = "0x3AF4070", VA = "0x183AF5670")]
	public AAGCLMDDDIA(MonoBehaviour ODBIGLNCAFE, Action CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF54E0", Offset = "0x3AF3EE0", VA = "0x183AF54E0")]
	public AAGCLMDDDIA(MonoBehaviour ODBIGLNCAFE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5800", Offset = "0x3AF4200", VA = "0x183AF5800")]
	public AAGCLMDDDIA(MonoBehaviour ODBIGLNCAFE, float NJAFDJAFCHE, Action<float> CHNEGDBDNHO, LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4D60", Offset = "0x3AF3760", VA = "0x183AF4D60")]
	private void ABFKFJLCDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5240", Offset = "0x3AF3C40", VA = "0x183AF5240")]
	private void OIIKPNJFLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3AF50B0", Offset = "0x3AF3AB0", VA = "0x183AF50B0")]
	private void KGEMNHODOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3AF53C0", Offset = "0x3AF3DC0", VA = "0x183AF53C0")]
	private void PMIINJCNLKK(string PFPOFNKJBMD, Action MPNNDGNCCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3AF51E0", Offset = "0x3AF3BE0", VA = "0x183AF51E0")]
	[IteratorStateMachine(typeof(ECFMPLNDBEH))]
	private IEnumerator<EIDNADAHLNE> KIOFJKHJLKI(Action MPNNDGNCCNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4FE0", Offset = "0x3AF39E0", VA = "0x183AF4FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4F60", Offset = "0x3AF3960", VA = "0x183AF4F60")]
	[CompilerGenerated]
	private void CEKDLFHNOGG(string HIHCHEKBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4EE0", Offset = "0x3AF38E0", VA = "0x183AF4EE0")]
	[CompilerGenerated]
	private void AMOOCDKFILB(string HIHCHEKBDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5030", Offset = "0x3AF3A30", VA = "0x183AF5030")]
	[CompilerGenerated]
	private void JDGNDLINAGG(string HIHCHEKBDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FDBEIEOFADL
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int AHACDFHOHML
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class PPEIDNFFAHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly PPEIDNFFAHB DIOOADNMAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action BNFAAKEEKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool DKOHABBPODM;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x558960", Offset = "0x557360", VA = "0x180558960")]
	public PPEIDNFFAHB(Action BNFAAKEEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3B049A0", Offset = "0x3B033A0", VA = "0x183B049A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HMBJDINEPCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T KJIPGBPKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PJMGAODNGCF(Action<T> NPHNEIDOCNL);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable PJMGAODNGCF(UnityEngine.Object NJEMLNPONME, Action<T> NPHNEIDOCNL);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GGLOBNNABJD<T> : global::HMBJDINEPCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T KJIPGBPKLDI
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
public class DEHGKJBIDDO<T> : global::GGLOBNNABJD<T>, global::HMBJDINEPCI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NNBANDEPDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::DEHGKJBIDDO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::EEKMHDNGEFB<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA48440", Offset = "0xA46E40", VA = "0x180A48440")]
		public NNBANDEPDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x352E8C0", Offset = "0x352D2C0", VA = "0x18352E8C0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject AEIKJDIMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::EEKMHDNGEFB<UnityEngine.Object, Action<T>>> JOFBIJMDGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T FDIBDDPPNCH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object BDEIIGMMOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x351FB20", Offset = "0x351E520", VA = "0x18351FB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T KJIPGBPKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE4C0", Offset = "0x5BCEC0", VA = "0x1805BE4C0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x351FF80", Offset = "0x351E980", VA = "0x18351FF80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x351FA80", Offset = "0x351E480", VA = "0x18351FA80")]
	private static bool CJFEEBANAFO(T CBEJOACJMFA, T MAKIBMGFDDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2E719A0", Offset = "0x2E703A0", VA = "0x182E719A0")]
	public DEHGKJBIDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x35203C0", Offset = "0x351EDC0", VA = "0x1835203C0")]
	public DEHGKJBIDDO(T JFINBMPBHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x351FF40", Offset = "0x351E940", VA = "0x18351FF40")]
	public void HMCMPKJHAJB(T LNKMEGOAEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3520040", Offset = "0x351EA40", VA = "0x183520040", Slot = "7")]
	public IDisposable PJMGAODNGCF(Action<T> NPHNEIDOCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x35200B0", Offset = "0x351EAB0", VA = "0x1835200B0", Slot = "8")]
	public IDisposable PJMGAODNGCF(UnityEngine.Object NJEMLNPONME, Action<T> NPHNEIDOCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x351F760", Offset = "0x351E160", VA = "0x18351F760")]
	private void CBLACABFKKI()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<CBCAOMNIMGK, Scheduler>, CBCAOMNIMGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class FLMNDLPABJA : FDBEIEOFADL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public KEGKBDEOPDL JOKCNJKAKCD;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int AHACDFHOHML
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x427E50", Offset = "0x426850", VA = "0x180427E50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x427E60", Offset = "0x426860", VA = "0x180427E60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB5A0", Offset = "0x3AF9FA0", VA = "0x183AFB5A0")]
			public static EIDNADAHLNE GCMDFFCCJOL(IEnumerator<EIDNADAHLNE> LAFJEGDHPBF, DFHCLLDMCJB JHPNEFHMIMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB4D0", Offset = "0x3AF9ED0", VA = "0x183AFB4D0")]
			public EIDNADAHLNE GCMDFFCCJOL(DFHCLLDMCJB[] BOKKANFPODF, IEnumerator<EIDNADAHLNE>[] AACIMBPJKBF, EIDNADAHLNE[] GKKGILMIBNL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB4A0", Offset = "0x3AF9EA0", VA = "0x183AFB4A0")]
			public void BONIHMNKKCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB320", Offset = "0x3AF9D20", VA = "0x183AFB320")]
			public void AEFMFOMBMPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB3E0", Offset = "0x3AF9DE0", VA = "0x183AFB3E0")]
			public void BJKFEALLHGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB4A0", Offset = "0x3AF9EA0", VA = "0x183AFB4A0")]
			public void FPPOIFHHJJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public FLMNDLPABJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class KEGKBDEOPDL
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct LEMLGPAKFAI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public FLMNDLPABJA MFHFNCBFJGN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public DHFNMJKMPFO PGKCKPBMLAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public DFHCLLDMCJB PJIGJNPPIJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<EIDNADAHLNE> KPIEFHALOHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public EIDNADAHLNE CCBCIENEGAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public MHMJJNGHFKD KDFBLHDGPHP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct JJCABMGEEGM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public LBAOFFOBDIC.MEBFJMMLIOC PELGGHNMCCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<LEMLGPAKFAI> NLEMKEHMNMG;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class FIMDMINDEPD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public KEGKBDEOPDL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public DHFNMJKMPFO context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public FLMNDLPABJA routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public MHMJJNGHFKD coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public DFHCLLDMCJB promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public EIDNADAHLNE currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<EIDNADAHLNE> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
				public FIMDMINDEPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x3AFACD0", Offset = "0x3AF96D0", VA = "0x183AFACD0")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class DNOIJKGAAIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public FLMNDLPABJA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public KEGKBDEOPDL <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
				public DNOIJKGAAIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x3AF8860", Offset = "0x3AF7260", VA = "0x183AF8860")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class HCBHPNKINNL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public FLMNDLPABJA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public KEGKBDEOPDL <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
				public HCBHPNKINNL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x3AFBE50", Offset = "0x3AFA850", VA = "0x183AFBE50")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class CDDHFBGOICD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public FLMNDLPABJA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public KEGKBDEOPDL <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
				public CDDHFBGOICD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x3AF6380", Offset = "0x3AF4D80", VA = "0x183AF6380")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] FJLJLLNPCJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<MHMJJNGHFKD> PDKPPDCNEGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> JIHOEBDKMFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> CPIIPPMDMML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> MOEOFMMJOLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> EFCLCGBJGKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> KEIHNCPELNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> LMGIMPACOAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private FLMNDLPABJA[] GKPHIPIPEKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private DFHCLLDMCJB[] BOKKANFPODF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private DHFNMJKMPFO[] BCCPIEFFHCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<EIDNADAHLNE>[] NOGPIICLKGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private EIDNADAHLNE[] BDFKIICNPLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int GONJAPIINBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int JNKPDCKMDII;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int GAJAMDIGLFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float COOFBDIJANP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private DPEFFCCIMEP HIFMLPJFKGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle FAHOMLHELHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<FLMNDLPABJA> KCGIIOGCOEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool MDDHEEEDLLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> IBPFCHMCJBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> LGJNLLOPNNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool CMPOKBEINIP;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public JJCABMGEEGM[] FGOMMBBAACE
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x8B0CE0", Offset = "0x8AF6E0", VA = "0x1808B0CE0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int BOPNFLGEEDH
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x7E6FA0", Offset = "0x7E59A0", VA = "0x1807E6FA0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3AFE170", Offset = "0x3AFCB70", VA = "0x183AFE170")]
			private static int CALDFNCBIDG(LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF890", Offset = "0x3AFE290", VA = "0x183AFF890")]
			public KEGKBDEOPDL(LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3AFDFE0", Offset = "0x3AFC9E0", VA = "0x183AFDFE0")]
			private void BBPNIBIDHGF(ref int OINBCBBIMFO, int GKHKMMEOOAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3AFEEA0", Offset = "0x3AFD8A0", VA = "0x183AFEEA0")]
			public void KBOCDANLDLF(DHFNMJKMPFO NJEMLNPONME, EIDNADAHLNE AONEICJKNMN, IEnumerator<EIDNADAHLNE> LAFJEGDHPBF, DFHCLLDMCJB JHPNEFHMIMF, [Optional] FLMNDLPABJA JCOEOJBHFBN, MHMJJNGHFKD NKONCILKBMI = MHMJJNGHFKD.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF620", Offset = "0x3AFE020", VA = "0x183AFF620")]
			public void OEOJKBOKGOF(IEnumerable<LEMLGPAKFAI> EJPJNJCAFDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3AFE1A0", Offset = "0x3AFCBA0", VA = "0x183AFE1A0")]
			private LEMLGPAKFAI DLIFGKAEAIL(int AFHLEDGHDJB)
			{
				return default(LEMLGPAKFAI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3AFEFD0", Offset = "0x3AFD9D0", VA = "0x183AFEFD0")]
			private void KHNDNJMPHIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1FA6D10", Offset = "0x1FA5710", VA = "0x181FA6D10")]
			private static void IHINOGDFCOK<T>(int AFHLEDGHDJB, T[] IMPIEFJKNHO, int OOJNMIFKLKI, [Optional] T HOIAAFJIHDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1FA6CF0", Offset = "0x1FA56F0", VA = "0x181FA6CF0")]
			private static void IHINOGDFCOK<T>(int AFHLEDGHDJB, NativeArray<T> IMPIEFJKNHO, int OOJNMIFKLKI, [Optional] T HOIAAFJIHDI) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3AFEC00", Offset = "0x3AFD600", VA = "0x183AFEC00")]
			private void JDMELIJDBOI(IEnumerable<LEMLGPAKFAI> EJPJNJCAFDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3AFDF20", Offset = "0x3AFC920", VA = "0x183AFDF20")]
			private void BBPAOPNANPK(LEMLGPAKFAI GNMDADCNNBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3AFDC80", Offset = "0x3AFC680", VA = "0x183AFDC80")]
			private NKIFCGLIKOG APJBOIPBLFM(int ACJJAEAAIOI)
			{
				return default(NKIFCGLIKOG);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF380", Offset = "0x3AFDD80", VA = "0x183AFF380")]
			public void NILABEMIHDO(float NFAOKNFGIBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF300", Offset = "0x3AFDD00", VA = "0x183AFF300")]
			private void MHEPMCCDANM(Action CBEJOACJMFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF810", Offset = "0x3AFE210", VA = "0x183AFF810")]
			private void PABGAPNDMMA(Action CBEJOACJMFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x3AFE680", Offset = "0x3AFD080", VA = "0x183AFE680")]
			public void HDKJCPOGLIN(float NFAOKNFGIBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x3AFEB20", Offset = "0x3AFD520", VA = "0x183AFEB20")]
			public void IECPGPMNMCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3AFE5D0", Offset = "0x3AFCFD0", VA = "0x183AFE5D0")]
			public void FPPOIFHHJJG(FLMNDLPABJA KDCFMIKNMLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3AFDBD0", Offset = "0x3AFC5D0", VA = "0x183AFDBD0")]
			public void ALKINJCFPHM(FLMNDLPABJA KDCFMIKNMLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF570", Offset = "0x3AFDF70", VA = "0x183AFF570")]
			public void NJOGLNGCIBL(FLMNDLPABJA KDCFMIKNMLM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct DPEFFCCIMEP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float JDHAOJJHHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int EDPNJLHMIAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> BHPEMPLNLMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> OAPGFLADOOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> LDKGBICBDDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<MHMJJNGHFKD> CDMICKOHFJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> IPJPOIBCDOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> EFCLCGBJGKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> CPIIPPMDMML;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8BB0", Offset = "0x3AF75B0", VA = "0x183AF8BB0")]
			public static DPEFFCCIMEP KNEDIEMGNBJ(int MDKPFDINMEH, float NFAOKNFGIBN, NativeArray<MHMJJNGHFKD> BOKFHFPDDBM, NativeArray<float> OMMJADEIALP, NativeArray<int> AMGOFFFIBDN, NativeArray<int> EDGJJMNFCKC, NativeArray<int> NEGEBHEFJCJ, NativeArray<int> OAPGFLADOOG, NativeArray<int> LDKGBICBDDL)
			{
				return default(DPEFFCCIMEP);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8AD0", Offset = "0x3AF74D0", VA = "0x183AF8AD0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8CB0", Offset = "0x3AF76B0", VA = "0x183AF8CB0")]
			private bool NGOPIOAMKGH(int EIKINLJPKBL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8C80", Offset = "0x3AF7680", VA = "0x183AF8C80")]
			private void LNJDKPIOAKM(NativeArray<int> MOIJFPCMHIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8CF0", Offset = "0x3AF76F0", VA = "0x183AF8CF0")]
			private int ODMAAMFLONA(int FKAKBLACCCM, int AOIJEPANGIC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8D60", Offset = "0x3AF7760", VA = "0x183AF8D60")]
			private void PCBLHPKAJDP(NativeArray<int> MOIJFPCMHIO, int IAAACNFHMDM, int NIPLIPJLAFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3AF88A0", Offset = "0x3AF72A0", VA = "0x183AF88A0")]
			private void ECGLGJJGIFL(NativeArray<int> MOIJFPCMHIO, int FBELEENAMDL, int FFLONKNOGCB, int LNPFINGOGOP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class NGLMCKJGCKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly DFHCLLDMCJB JHPNEFHMIMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour NJEMLNPONME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool OLEDOKPKPLM;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<EIDNADAHLNE> KPIEFHALOHI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4271A0", Offset = "0x425BA0", VA = "0x1804271A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x427440", Offset = "0x425E40", VA = "0x180427440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public EIDNADAHLNE CCBCIENEGAB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x427450", Offset = "0x425E50", VA = "0x180427450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool JDCDBEBDCAH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x3B01470", Offset = "0x3AFFE70", VA = "0x183B01470")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool FMCDPKDPADD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x7BEA60", Offset = "0x7BD460", VA = "0x1807BEA60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0xA88A80", Offset = "0xA87480", VA = "0x180A88A80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string BAGLDJIDHDC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x427F90", Offset = "0x426990", VA = "0x180427F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x427FA0", Offset = "0x4269A0", VA = "0x180427FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float FKIBAKMAKMB
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x730ED0", Offset = "0x72F8D0", VA = "0x180730ED0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x730F90", Offset = "0x72F990", VA = "0x180730F90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3B01590", Offset = "0x3AFFF90", VA = "0x183B01590")]
			public NGLMCKJGCKH(IEnumerator<EIDNADAHLNE> LAFJEGDHPBF, Behaviour NJEMLNPONME, DFHCLLDMCJB JHPNEFHMIMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3B011D0", Offset = "0x3AFFBD0", VA = "0x183B011D0")]
			public EIDNADAHLNE GCMDFFCCJOL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3B013E0", Offset = "0x3AFFDE0", VA = "0x183B013E0")]
			public bool OENPIKILOOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3B01140", Offset = "0x3AFFB40", VA = "0x183B01140")]
			public void FPPOIFHHJJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3B01500", Offset = "0x3AFFF00", VA = "0x183B01500", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x172FC40", Offset = "0x172E640", VA = "0x18172FC40")]
			[CompilerGenerated]
			private void AEFLANOMFPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class DFHCLLDMCJB : KNMMHKNIJJJ, CGNOFOAADKJ, HFJGPNNFFKA, OJNMJAKAOEK, IEnumerator, EIDNADAHLNE, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private LBAOFFOBDIC.MEBFJMMLIOC BBGOBCLGDBL;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private LBAOFFOBDIC.MEBFJMMLIOC APGPJLNOPMI
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x44B290", Offset = "0x449C90", VA = "0x18044B290", Slot = "23")]
				get
				{
					return default(LBAOFFOBDIC.MEBFJMMLIOC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public LBAOFFOBDIC.MEBFJMMLIOC JOKCNJKAKCD
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x44B290", Offset = "0x449C90", VA = "0x18044B290")]
				get
				{
					return default(LBAOFFOBDIC.MEBFJMMLIOC);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x757BE0", Offset = "0x7565E0", VA = "0x180757BE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float LAIAIENJEOC
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x680430", Offset = "0x67EE30", VA = "0x180680430", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3AF87E0", Offset = "0x3AF71E0", VA = "0x183AF87E0", Slot = "24")]
			private bool HMPOKJPABJJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3AF87D0", Offset = "0x3AF71D0", VA = "0x183AF87D0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8800", Offset = "0x3AF7200", VA = "0x183AF8800")]
			public DFHCLLDMCJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum NKIFCGLIKOG : byte
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
		private sealed class FHHIKFBCEFC : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum KHDLEAPDPLD
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct GCEODKJFFKN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public LBAOFFOBDIC.MEBFJMMLIOC PELGGHNMCCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public KHDLEAPDPLD GAAMKAGLDHE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<NGLMCKJGCKH> MDIBAGJPJIH;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly KHDLEAPDPLD[] EPJJCBCOFCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly LBAOFFOBDIC.MEBFJMMLIOC CDBGAMAELGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool MILKJFLKOAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly NGLMCKJGCKH[] NEGGHDNFLFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<NGLMCKJGCKH> CBBAFENMAPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> CLDLLCNEPCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<NGLMCKJGCKH> LCBDFKJEEGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> FPDKMAEMOOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool CMPOKBEINIP;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public GCEODKJFFKN[,] BFBFAMEMING
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x43A470", Offset = "0x438E70", VA = "0x18043A470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int BOPNFLGEEDH
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x3AF9E50", Offset = "0x3AF8850", VA = "0x183AF9E50")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA8F0", Offset = "0x3AF92F0", VA = "0x183AFA8F0")]
			public FHHIKFBCEFC(LBAOFFOBDIC.MEBFJMMLIOC JKFOFAFPGIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA290", Offset = "0x3AF8C90", VA = "0x183AFA290")]
			public void JOHJLFLBCBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA420", Offset = "0x3AF8E20", VA = "0x183AFA420")]
			public void KEDCLDIKDIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA170", Offset = "0x3AF8B70", VA = "0x183AFA170")]
			private void IBMEGFAPFPN(IReadOnlyList<NGLMCKJGCKH> GEDAAHNDBBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3AF9FC0", Offset = "0x3AF89C0", VA = "0x183AF9FC0")]
			public void HFJFMKGDFAD(NGLMCKJGCKH LAFJEGDHPBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3AF96A0", Offset = "0x3AF80A0", VA = "0x183AF96A0")]
			public void BJDCNFDHDID(IList<NGLMCKJGCKH> AACIMBPJKBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA430", Offset = "0x3AF8E30", VA = "0x183AFA430")]
			public void ODCKPCGLHEC(IList<NGLMCKJGCKH> AACIMBPJKBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3AF9B00", Offset = "0x3AF8500", VA = "0x183AF9B00")]
			private void DNBNLLNJLGM(NGLMCKJGCKH LAFJEGDHPBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA6B0", Offset = "0x3AF90B0", VA = "0x183AFA6B0")]
			private void PBBLCOGMPEB(IList<NGLMCKJGCKH> AACIMBPJKBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA2A0", Offset = "0x3AF8CA0", VA = "0x183AFA2A0")]
			private NKIFCGLIKOG JPIJOLODMPE(NGLMCKJGCKH LAFJEGDHPBF)
			{
				return default(NKIFCGLIKOG);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3AFA0C0", Offset = "0x3AF8AC0", VA = "0x183AFA0C0")]
			public void HHCOOIBBPDK(float NFAOKNFGIBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x3AF94A0", Offset = "0x3AF7EA0", VA = "0x183AF94A0")]
			public void AIIFGACAHLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3AF9920", Offset = "0x3AF8320", VA = "0x183AF9920")]
			private void DBEPJLNAEAG(List<NGLMCKJGCKH> AACIMBPJKBF, Stack<int> AGFMMJKCHED, bool FHDNPFJEAPC, float IMFEIOIEHEH = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3AF9BF0", Offset = "0x3AF85F0", VA = "0x183AF9BF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3AF9D30", Offset = "0x3AF8730", VA = "0x183AF9D30")]
			private void EGBGCLIEAAB(List<NGLMCKJGCKH> AACIMBPJKBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum MHMJJNGHFKD : byte
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
		private sealed class PFOJBHCNDBJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x427190", Offset = "0x425B90", VA = "0x180427190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x488CF0", Offset = "0x4876F0", VA = "0x180488CF0")]
			[DebuggerHidden]
			public PFOJBHCNDBJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3B037D0", Offset = "0x3B021D0", VA = "0x183B037D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3B03850", Offset = "0x3B02250", VA = "0x183B03850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const MHMJJNGHFKD OCODPFOBKBF = MHMJJNGHFKD.Cancelled | MHMJJNGHFKD.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly LBAOFFOBDIC.MEBFJMMLIOC[] PFLOGDMGDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private FHHIKFBCEFC[] GNFHPIPPCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private KEGKBDEOPDL[] MPEKODONOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine HGHLCLCKPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame JGFPAIBKENC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public LBAOFFOBDIC.MEBFJMMLIOC PPHIFAFODPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x480640", Offset = "0x47F040", VA = "0x180480640")]
			[CompilerGenerated]
			get
			{
				return default(LBAOFFOBDIC.MEBFJMMLIOC);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x56F900", Offset = "0x56E300", VA = "0x18056F900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool JCFJEGOEOFA
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7BE760", Offset = "0x7BD160", VA = "0x1807BE760", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x56F910", Offset = "0x56E310", VA = "0x18056F910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int BOPNFLGEEDH
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3B063E0", Offset = "0x3B04DE0", VA = "0x183B063E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3B050B0", Offset = "0x3B03AB0", VA = "0x183B050B0")]
		public static CGNOFOAADKJ GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3B04AA0", Offset = "0x3B034A0", VA = "0x183B04AA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3B053A0", Offset = "0x3B03DA0", VA = "0x183B053A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3B05060", Offset = "0x3B03A60", VA = "0x183B05060")]
		private FHHIKFBCEFC EBHOJFLEHEI(LBAOFFOBDIC.MEBFJMMLIOC DIJOHCCOMIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2A98D70", Offset = "0x2A97770", VA = "0x182A98D70")]
		private KEGKBDEOPDL CPDKFEMPPFN(LBAOFFOBDIC.MEBFJMMLIOC DIJOHCCOMIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3B05830", Offset = "0x3B04230", VA = "0x183B05830")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3B05800", Offset = "0x3B04200", VA = "0x183B05800")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3B061D0", Offset = "0x3B04BD0", VA = "0x183B061D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3B05150", Offset = "0x3B03B50", VA = "0x183B05150")]
		private void IPAIENNNKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3B05160", Offset = "0x3B03B60", VA = "0x183B05160")]
		private void JMAGOLGMFKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3B050A0", Offset = "0x3B03AA0", VA = "0x183B050A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3B05170", Offset = "0x3B03B70", VA = "0x183B05170")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3B04A90", Offset = "0x3B03490", VA = "0x183B04A90")]
		private void AJNFKNLPDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3B05340", Offset = "0x3B03D40", VA = "0x183B05340")]
		[IteratorStateMachine(typeof(PFOJBHCNDBJ))]
		private IEnumerator OFPIAMDFOEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3B059D0", Offset = "0x3B043D0", VA = "0x183B059D0", Slot = "7")]
		public CGNOFOAADKJ Run(IEnumerator<EIDNADAHLNE> IHDKHDDPKLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3B059E0", Offset = "0x3B043E0", VA = "0x183B059E0", Slot = "8")]
		public CGNOFOAADKJ Run(Behaviour NJEMLNPONME, IEnumerator<EIDNADAHLNE> IHDKHDDPKLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3B058A0", Offset = "0x3B042A0", VA = "0x183B058A0", Slot = "9")]
		public CGNOFOAADKJ RunJobbed(DHFNMJKMPFO NJEMLNPONME, IEnumerator<EIDNADAHLNE> IHDKHDDPKLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3B05000", Offset = "0x3B03A00", VA = "0x183B05000", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3B05D00", Offset = "0x3B04700", VA = "0x183B05D00")]
		public void UpdateQueue(LBAOFFOBDIC.MEBFJMMLIOC DINHDCFKCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3B05180", Offset = "0x3B03B80", VA = "0x183B05180")]
		private void MHFALMFACKO(FHHIKFBCEFC HCNPEPEPFNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3B04EE0", Offset = "0x3B038E0", VA = "0x183B04EE0")]
		private void BFKJANKPJEN(KEGKBDEOPDL HCNPEPEPFNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3B06380", Offset = "0x3B04D80", VA = "0x183B06380")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class PMDODAIFIEI
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B03C70", Offset = "0x3B02670", VA = "0x183B03C70")]
	[GHFEGDOPPNP]
	private static void OFPKKKHDKOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class GMAPMKFMIHH : DNLNADNGJFN
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float LKGGGDFEKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBAA0", Offset = "0x3AFA4A0", VA = "0x183AFBAA0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float AHBMLFHEIJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBA90", Offset = "0x3AFA490", VA = "0x183AFBA90", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float OPAJOLCIAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBA80", Offset = "0x3AFA480", VA = "0x183AFBA80", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BFLFBCBFEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBA70", Offset = "0x3AFA470", VA = "0x183AFBA70", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double KBBPOEOHCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3AFBA50", Offset = "0x3AFA450", VA = "0x183AFBA50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	public GMAPMKFMIHH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class IKAEKDPBOKM
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] PLMALFKJJFH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int MNKELEMMCIP;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int JAADIHNAGCD;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger HGHHBJPNHEH;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
	public IKAEKDPBOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC640", Offset = "0x3AFB040", VA = "0x183AFC640")]
	private static string GHHLIKAFOCC(byte[] MAKIBMGFDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC740", Offset = "0x3AFB140", VA = "0x183AFC740")]
	public static string NADJMKIAKML(byte[] LKPHIKGCGGC, bool BILKIJDICLE)
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
		[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
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

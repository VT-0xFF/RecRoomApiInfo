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
		private delegate List<PlayerLoopSystem> BLEHFHNHJAD(List<PlayerLoopSystem> LBMAOGKLLPI, int DBPPDANDKJK);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct JKGIBHAKEME
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct JKJADOIHKIN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static CNEELAKGHKO MALCBFHCGDD;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x466D530", Offset = "0x466C530", VA = "0x18466D530")]
				public static PlayerLoopSystem NGJPDAKPDIK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct POJNFCAKAGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static CNEELAKGHKO OEIBNBOHPAL;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x46763E0", Offset = "0x46753E0", VA = "0x1846763E0")]
				public static PlayerLoopSystem NGJPDAKPDIK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct HGELBMJFDKE
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static CNEELAKGHKO LEMJIKDNLMI;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x466C6C0", Offset = "0x466B6C0", VA = "0x18466C6C0")]
				public static PlayerLoopSystem NGJPDAKPDIK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct OPPADIKNJHF
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static CNEELAKGHKO EMCLKNOBKNO;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4675AD0", Offset = "0x4674AD0", VA = "0x184675AD0")]
				public static PlayerLoopSystem NGJPDAKPDIK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct LBAEPILIGEB
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class IDBLGDPLBDF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public JFOIIIAKGGF.JCLKFGLPGBB key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
					public IDBLGDPLBDF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x466C890", Offset = "0x466B890", VA = "0x18466C890")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable BCIOIDHIAKG;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x466F180", Offset = "0x466E180", VA = "0x18466F180")]
				public static PlayerLoopSystem AFFHKECNBGL(JFOIIIAKGGF.JCLKFGLPGBB MNGGKJHHPNI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct EDHLFKIFKIF
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class JHBGJJIMLAJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public JFOIIIAKGGF.JCLKFGLPGBB key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
					public JHBGJJIMLAJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x466CFE0", Offset = "0x466BFE0", VA = "0x18466CFE0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x466B250", Offset = "0x466A250", VA = "0x18466B250")]
				public static PlayerLoopSystem AFFHKECNBGL(JFOIIIAKGGF.JCLKFGLPGBB MNGGKJHHPNI)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GEDBGJNPGNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public GEDBGJNPGNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x466B6B0", Offset = "0x466A6B0", VA = "0x18466B6B0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool OPDMAFDBAJN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ABLFBNGANCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x46694A0", Offset = "0x46684A0", VA = "0x1846694A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x46694E0", Offset = "0x46684E0", VA = "0x1846694E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4667F30", Offset = "0x4666F30", VA = "0x184667F30")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46691B0", Offset = "0x46681B0", VA = "0x1846691B0")]
		private static void CKMBBLDPJLN(JFOIIIAKGGF.JCLKFGLPGBB MNGGKJHHPNI, ref PlayerLoopSystem MMFMFDDILGO, Type JMOFOOCHDGE, Type NBPCEJNPKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4669520", Offset = "0x4668520", VA = "0x184669520")]
		private static void OMEKEPLDHED(ref PlayerLoopSystem MMFMFDDILGO, Type JMOFOOCHDGE, Type NBPCEJNPKMB, BLEHFHNHJAD LPGGCFCACGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4669380", Offset = "0x4668380", VA = "0x184669380")]
		private static void LIOEIODLEHM(ref PlayerLoopSystem MMFMFDDILGO, Type JMOFOOCHDGE, Type NBPCEJNPKMB, PlayerLoopSystem? COILMPMMNFO, PlayerLoopSystem? DBFHCALKKMB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JFOIIIAKGGF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum JCLKFGLPGBB
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
	public class JIJFPAMCKFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly JCLKFGLPGBB CDLEGBIEJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly MKMLEDPHGGF DLPPOMCPPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long GNNLMOPLFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long BMFIJDGJPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long OEHMLDLFDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int KAFENFAAHCM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x466D440", Offset = "0x466C440", VA = "0x18466D440")]
		public JIJFPAMCKFA(JCLKFGLPGBB KCOIAAHOAOD, int OBKGHMEBMOG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x466D420", Offset = "0x466C420", VA = "0x18466D420")]
		public void PBJCFGOJBFG(int CODCABKBIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x466D3B0", Offset = "0x466C3B0", VA = "0x18466D3B0")]
		public void NKEEJBDNAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x466D2B0", Offset = "0x466C2B0", VA = "0x18466D2B0")]
		public void KIEGAKAHCKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x466D0E0", Offset = "0x466C0E0", VA = "0x18466D0E0")]
		public void GPKLAOIHNEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x466D310", Offset = "0x466C310", VA = "0x18466D310")]
		public double KNANLLAAEOH(int ONHOLLNDAEB)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int MAAFLAMANHI = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static JCLKFGLPGBB[] PFCIBGPMGLN;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static JIJFPAMCKFA[] KGGLOJFMEPG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x466CD10", Offset = "0x466BD10", VA = "0x18466CD10")]
	public static JIJFPAMCKFA MACMNDDGBAC(JCLKFGLPGBB MNGGKJHHPNI, int OBKGHMEBMOG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x466CBD0", Offset = "0x466BBD0", VA = "0x18466CBD0")]
	public static JIJFPAMCKFA EDIFBBMALJB(JCLKFGLPGBB MNGGKJHHPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x466CC60", Offset = "0x466BC60", VA = "0x18466CC60")]
	public static void KKONBENEAMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MKMLEDPHGGF : BGJNCJLHGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int MEGKNMIBMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> DCGLGNFEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double LMLCFNGPGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double OECPNENFJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double IPPCDNPGAHE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KMFCAPNDFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46724A0", Offset = "0x46714A0", VA = "0x1846724A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KNEPOLCOOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x46723D0", Offset = "0x46713D0", VA = "0x1846723D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OBENHGFJDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xEF2EE0", Offset = "0xEF1EE0", VA = "0x180EF2EE0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double JELFDDMHCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD3AEE0", Offset = "0xD39EE0", VA = "0x180D3AEE0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46724E0", Offset = "0x46714E0", VA = "0x1846724E0")]
	public MKMLEDPHGGF(int OEOFNOHEJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46722D0", Offset = "0x46712D0", VA = "0x1846722D0", Slot = "4")]
	public void BLICJJFOBPN(double IKMEOANGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4672430", Offset = "0x4671430", VA = "0x184672430", Slot = "5")]
	public void ILOGKMIJNPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DBICOCIIPAD : BGJNCJLHGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long MODLAKNNNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double NMDKGKOOPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double LHCEHENJMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double JLADABFHECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double KKKALKAKNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double LMLCFNGPGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double OECPNENFJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LPNJCDLGCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OBENHGFJDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xEF2ED0", Offset = "0xEF1ED0", VA = "0x180EF2ED0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double JELFDDMHCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC7EBD0", Offset = "0xC7DBD0", VA = "0x180C7EBD0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FFEAKMCDJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD3AEE0", Offset = "0xD39EE0", VA = "0x180D3AEE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HOFKJGINGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD3AED0", Offset = "0xD39ED0", VA = "0x180D3AED0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double KNEPOLCOOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEF2DF0", Offset = "0xEF1DF0", VA = "0x180EF2DF0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46698A0", Offset = "0x46688A0", VA = "0x1846698A0", Slot = "4")]
	public void BLICJJFOBPN(double IKMEOANGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46699C0", Offset = "0x46689C0", VA = "0x1846699C0", Slot = "5")]
	public void ILOGKMIJNPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4669A00", Offset = "0x4668A00", VA = "0x184669A00")]
	public DBICOCIIPAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BGJNCJLHGCM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KNEPOLCOOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double OBENHGFJDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double JELFDDMHCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLICJJFOBPN(double IKMEOANGHEH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILOGKMIJNPI();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BDNGCKHIOHP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface OHDPNIKCNDF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool HPPGDDAECMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FAMKCJJIIKA();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LIIDPMHCENE();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class DMIJNBDAELD<TPromise, TMainThreadPromise> : OHDPNIKCNDF where TPromise : EJLKCPFELBD where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise DKNIPEEODHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise BNAMCCDEKDH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise LNLPCAKGDFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x33F4110", Offset = "0x33F3110", VA = "0x1833F4110")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HPPGDDAECMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x33F41A0", Offset = "0x33F31A0", VA = "0x1833F41A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x250C670", Offset = "0x250B670", VA = "0x18250C670")]
		protected DMIJNBDAELD(TPromise DKNIPEEODHE, TMainThreadPromise GCINPOJNNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x33F4170", Offset = "0x33F3170", VA = "0x1833F4170", Slot = "5")]
		public void FAMKCJJIIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x27D4C10", Offset = "0x27D3C10", VA = "0x1827D4C10", Slot = "6")]
		public void LIIDPMHCENE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void PLEMIGMAOHC(TPromise DKNIPEEODHE);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void BHMNALHGNHL();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class NNDGABELAPP<T> : DMIJNBDAELD<global::HMPJDJAALAE<T>, global::IMHPNJHAAJB<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x33F7600", Offset = "0x33F6600", VA = "0x1833F7600")]
		public NNDGABELAPP(global::HMPJDJAALAE<T> DKNIPEEODHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x33F7400", Offset = "0x33F6400", VA = "0x1833F7400", Slot = "7")]
		protected override void PLEMIGMAOHC(global::HMPJDJAALAE<T> DKNIPEEODHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x33F7370", Offset = "0x33F6370", VA = "0x1833F7370", Slot = "8")]
		protected override void BHMNALHGNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x25AC940", Offset = "0x25AB940", VA = "0x1825AC940")]
		[CompilerGenerated]
		private void KNJACPLEJIK(T EJBMJHIBKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x33F73D0", Offset = "0x33F63D0", VA = "0x1833F73D0")]
		[CompilerGenerated]
		private void PDDBAFMDJPL(string ILMCLHHHHPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class HFKKEMPIBAM : DMIJNBDAELD<EJLKCPFELBD, MNDNBPKLGEA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x466C650", Offset = "0x466B650", VA = "0x18466C650")]
		public HFKKEMPIBAM(EJLKCPFELBD DKNIPEEODHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x466C580", Offset = "0x466B580", VA = "0x18466C580", Slot = "7")]
		protected override void PLEMIGMAOHC(EJLKCPFELBD DKNIPEEODHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x466C530", Offset = "0x466B530", VA = "0x18466C530", Slot = "8")]
		protected override void BHMNALHGNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1498710", Offset = "0x1497710", VA = "0x181498710")]
		[CompilerGenerated]
		private void KNJACPLEJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1F158E0", Offset = "0x1F148E0", VA = "0x181F158E0")]
		[CompilerGenerated]
		private void PDDBAFMDJPL(string ILMCLHHHHPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class ILLHAHANCGB : OHDPNIKCNDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action EDHAOFHJENI;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HPPGDDAECMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5359B0", Offset = "0x5349B0", VA = "0x1805359B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A2810", Offset = "0x6A1810", VA = "0x1806A2810")]
		public ILLHAHANCGB(Action EDHAOFHJENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xF02E50", Offset = "0xF01E50", VA = "0x180F02E50", Slot = "5")]
		public void FAMKCJJIIKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "6")]
		public void LIIDPMHCENE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<OHDPNIKCNDF> CGCBIKLALOA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2259870", Offset = "0x2258870", VA = "0x182259870")]
	public static global::HMPJDJAALAE<T> DPLCIKPLADA<T>(this global::HMPJDJAALAE<T> DKNIPEEODHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4666610", Offset = "0x4665610", VA = "0x184666610")]
	public static EJLKCPFELBD DPLCIKPLADA(this EJLKCPFELBD DKNIPEEODHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4666720", Offset = "0x4665720", VA = "0x184666720")]
	public static void DPLCIKPLADA(Action EDHAOFHJENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x22598E0", Offset = "0x22588E0", VA = "0x1822598E0")]
	private static global::HMPJDJAALAE<T> EDMAFOBOPDB<T>(global::HMPJDJAALAE<T> DKNIPEEODHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46667B0", Offset = "0x46657B0", VA = "0x1846667B0")]
	private static EJLKCPFELBD EDMAFOBOPDB(EJLKCPFELBD DKNIPEEODHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4666100", Offset = "0x4665100", VA = "0x184666100")]
	private static void BAKLPLBKAGD(OHDPNIKCNDF AHDOEABGCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46662F0", Offset = "0x46652F0", VA = "0x1846662F0")]
	private static void CBOGCDNFNNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4666890", Offset = "0x4665890", VA = "0x184666890")]
	private static void FHIMODDPCEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4666050", Offset = "0x4665050", VA = "0x184666050")]
	private static void APNEAPMBCEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class DCHDEJJMHML
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DJFPDDANJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MNDNBPKLGEA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public DJFPDDANJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x466A1B0", Offset = "0x46691B0", VA = "0x18466A1B0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x466A1A0", Offset = "0x46691A0", VA = "0x18466A1A0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JFEFFNMMHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public JFEFFNMMHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x466CBA0", Offset = "0x466BBA0", VA = "0x18466CBA0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GJEAIOAICDB : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MNDNBPKLGEA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public GJEAIOAICDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x466C020", Offset = "0x466B020", VA = "0x18466C020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x466BD00", Offset = "0x466AD00", VA = "0x18466BD00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x466C0D0", Offset = "0x466B0D0", VA = "0x18466C0D0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x466BFD0", Offset = "0x466AFD0", VA = "0x18466BFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NKPDPDIJMGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MNDNBPKLGEA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public NKPDPDIJMGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MPMBKFBGBAA : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MNDNBPKLGEA onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private NKPDPDIJMGA <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public MPMBKFBGBAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4672580", Offset = "0x4671580", VA = "0x184672580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4672910", Offset = "0x4671910", VA = "0x184672910", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string GJHLIKNKKLP = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string HDMDCFPOHMC = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string JMFMFKLPCNP = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string AAAGKJPFCBI = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string EACOJJNENLB = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float FDEJAPIGNJN = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static EJLKCPFELBD HPOFAJJOIKO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation ILIJBPHHJCB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static EJLKCPFELBD GGEAJJLGLNC;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string BNIALBKLAON;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority ODGICNACOMO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool AGCLPFLLGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4669E50", Offset = "0x4668E50", VA = "0x184669E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool LOJKNEJIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4669EF0", Offset = "0x4668EF0", VA = "0x184669EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool EFDKMJALIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4669F50", Offset = "0x4668F50", VA = "0x184669F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MKMHDLKAKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4669FB0", Offset = "0x4668FB0", VA = "0x184669FB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x466A0F0", Offset = "0x46690F0", VA = "0x18466A0F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4669C60", Offset = "0x4668C60", VA = "0x184669C60")]
	public static EJLKCPFELBD CIJMGNBFALL(string GMJJKEADJIE, LoadSceneMode CPJBAHNFLMD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4669A30", Offset = "0x4668A30", VA = "0x184669A30")]
	public static EJLKCPFELBD BGKFJAPIPBJ(string GMJJKEADJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x466A060", Offset = "0x4669060", VA = "0x18466A060")]
	[IteratorStateMachine(typeof(GJEAIOAICDB))]
	private static IEnumerator<JFAHKOGHLOL> OGCEOKPHACO(string GMJJKEADJIE, MNDNBPKLGEA IHBKBIBHHCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4669DC0", Offset = "0x4668DC0", VA = "0x184669DC0")]
	[IteratorStateMachine(typeof(MPMBKFBGBAA))]
	private static IEnumerator<JFAHKOGHLOL> GFLAAIAHHOP(string GMJJKEADJIE, LoadSceneMode CPJBAHNFLMD, MNDNBPKLGEA IHBKBIBHHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LELGMKLPPIC
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x466F440", Offset = "0x466E440", VA = "0x18466F440")]
	public static IDisposable BMOHNCJEHKI(this AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x466F4C0", Offset = "0x466E4C0", VA = "0x18466F4C0")]
	public static IDisposable BMOHNCJEHKI(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x466F830", Offset = "0x466E830", VA = "0x18466F830")]
	public static IDisposable HMHKICIBPHG(this AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x466FAA0", Offset = "0x466EAA0", VA = "0x18466FAA0")]
	public static IDisposable LKMFIJMPBEI(this AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x466F6B0", Offset = "0x466E6B0", VA = "0x18466F6B0")]
	public static IDisposable EDBOGCJFMOM(this AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x466FC10", Offset = "0x466EC10", VA = "0x18466FC10")]
	public static IDisposable OCHLPGBJLPH(this AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x466F640", Offset = "0x466E640", VA = "0x18466F640")]
	public static IDisposable DKOBGLMEOHA(this AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x466F320", Offset = "0x466E320", VA = "0x18466F320")]
	public static IDisposable AKDBDJMENBF(this AFIOHBDIBFE JJNBJBEMAKH, float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x466F2A0", Offset = "0x466E2A0", VA = "0x18466F2A0")]
	public static IDisposable AFCOLEIAHPK(this AFIOHBDIBFE JJNBJBEMAKH, float HAIIAOBELKB, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x466FA20", Offset = "0x466EA20", VA = "0x18466FA20")]
	public static IDisposable LKAEGAMFNPO(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x466F920", Offset = "0x466E920", VA = "0x18466F920")]
	public static IDisposable JDBDNAJDIKN(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x466FB10", Offset = "0x466EB10", VA = "0x18466FB10")]
	public static IDisposable NJDFKMMPOML(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x466F3B0", Offset = "0x466E3B0", VA = "0x18466F3B0")]
	public static IDisposable ALPBJMDCPLH(this AFIOHBDIBFE JJNBJBEMAKH, float HAIIAOBELKB, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x466F720", Offset = "0x466E720", VA = "0x18466F720")]
	public static IDisposable EFODNONGLBK(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x466F5C0", Offset = "0x466E5C0", VA = "0x18466F5C0")]
	public static IDisposable DGOEPCBNOLI(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x466F9A0", Offset = "0x466E9A0", VA = "0x18466F9A0")]
	public static IDisposable KDBEIKFNBEF(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x466F7A0", Offset = "0x466E7A0", VA = "0x18466F7A0")]
	public static IDisposable FGMIEHDIDHJ(this AFIOHBDIBFE JJNBJBEMAKH, float HAIIAOBELKB, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x466F540", Offset = "0x466E540", VA = "0x18466F540")]
	public static IDisposable COCIOKPKPIC(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x466F8A0", Offset = "0x466E8A0", VA = "0x18466F8A0")]
	public static IDisposable IELILJBBPPC(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x466FB90", Offset = "0x466EB90", VA = "0x18466FB90")]
	public static IDisposable NKPFCKDABOJ(this AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OCEBBMNPMPI
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4674FE0", Offset = "0x4673FE0", VA = "0x184674FE0")]
	public static IDisposable KMIIOJDBKJA(this MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4674F60", Offset = "0x4673F60", VA = "0x184674F60")]
	public static IDisposable KMIIOJDBKJA(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4674990", Offset = "0x4673990", VA = "0x184674990")]
	public static IDisposable EBPLJKLJNDI(this MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4674E60", Offset = "0x4673E60", VA = "0x184674E60")]
	public static IDisposable ILBJLJABECB(this MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46752A0", Offset = "0x46742A0", VA = "0x1846752A0")]
	public static IDisposable OLMPLLBMPEP(this MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4674D60", Offset = "0x4673D60", VA = "0x184674D60")]
	public static IDisposable ICBJINDEHMC(this MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4675100", Offset = "0x4674100", VA = "0x184675100")]
	public static IDisposable LGJPMGBNFPM(this MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4675060", Offset = "0x4674060", VA = "0x184675060")]
	public static IDisposable KNBPHFLJJFO(this MonoBehaviour COFAHBEKNDD, float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4674A90", Offset = "0x4673A90", VA = "0x184674A90")]
	public static IDisposable FNEFMHKCPMO(this MonoBehaviour COFAHBEKNDD, float HAIIAOBELKB, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4674BB0", Offset = "0x4673BB0", VA = "0x184674BB0")]
	public static IDisposable GHLINCEPIEO(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4674ED0", Offset = "0x4673ED0", VA = "0x184674ED0")]
	public static IDisposable JIBLOJKDGAH(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4674900", Offset = "0x4673900", VA = "0x184674900")]
	public static IDisposable BPKKEDIOGIB(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4674A00", Offset = "0x4673A00", VA = "0x184674A00")]
	public static IDisposable ENDCBIGNBNN(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4675310", Offset = "0x4674310", VA = "0x184675310")]
	public static IDisposable PLJCFNOELHH(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4674B20", Offset = "0x4673B20", VA = "0x184674B20")]
	public static IDisposable GCOPEMLDIJG(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4675200", Offset = "0x4674200", VA = "0x184675200")]
	public static IDisposable MBHDGPOAGDB(this MonoBehaviour COFAHBEKNDD, float HAIIAOBELKB, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4675170", Offset = "0x4674170", VA = "0x184675170")]
	public static IDisposable LONHDDJNLOL(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4674C40", Offset = "0x4673C40", VA = "0x184674C40")]
	public static IDisposable HPAJLCAEJKO(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4674DD0", Offset = "0x4673DD0", VA = "0x184674DD0")]
	public static IDisposable IHMELJHKGKD(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4674860", Offset = "0x4673860", VA = "0x184674860")]
	public static IDisposable BLIAOGNINKP(this MonoBehaviour COFAHBEKNDD, float HAIIAOBELKB, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46747D0", Offset = "0x46737D0", VA = "0x1846747D0")]
	public static IDisposable AHCOPAHKPIJ(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4674740", Offset = "0x4673740", VA = "0x184674740")]
	public static IDisposable AGGHEOAJLON(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4674CD0", Offset = "0x4673CD0", VA = "0x184674CD0")]
	public static IDisposable IABPOPOMGCI(this MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class EDBKLHFDDEO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LIIBDNGJMNB : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public DJHOLNLKCOK.LCFMLIFMCLP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NDBOFOKACGB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public LIIBDNGJMNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4671FE0", Offset = "0x4670FE0", VA = "0x184671FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x46720A0", Offset = "0x46710A0", VA = "0x1846720A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FMMKGANLGKN : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public DJHOLNLKCOK.LCFMLIFMCLP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private NDBOFOKACGB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public FMMKGANLGKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x466B4F0", Offset = "0x466A4F0", VA = "0x18466B4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x466B5D0", Offset = "0x466A5D0", VA = "0x18466B5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x466B160", Offset = "0x466A160", VA = "0x18466B160")]
	public static OBBEAJINNHP KMIIOJDBKJA(Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x466AE50", Offset = "0x4669E50", VA = "0x18466AE50")]
	public static OBBEAJINNHP KMIIOJDBKJA(Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x466AF40", Offset = "0x4669F40", VA = "0x18466AF40")]
	public static OBBEAJINNHP KMIIOJDBKJA(Behaviour JJNBJBEMAKH, Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x466B050", Offset = "0x466A050", VA = "0x18466B050")]
	public static OBBEAJINNHP KMIIOJDBKJA(Behaviour JJNBJBEMAKH, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x466AC30", Offset = "0x4669C30", VA = "0x18466AC30")]
	public static OBBEAJINNHP BMOHNCJEHKI(AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x466AD40", Offset = "0x4669D40", VA = "0x18466AD40")]
	public static OBBEAJINNHP BMOHNCJEHKI(AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x466AB30", Offset = "0x4669B30", VA = "0x18466AB30")]
	[IteratorStateMachine(typeof(LIIBDNGJMNB))]
	private static IEnumerator<JFAHKOGHLOL> AJFLIKAJKLP(DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH, Action DFPEMANILHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x466ABB0", Offset = "0x4669BB0", VA = "0x18466ABB0")]
	[IteratorStateMachine(typeof(FMMKGANLGKN))]
	private static IEnumerator<JFAHKOGHLOL> AJFLIKAJKLP(DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH, Action<float> DFPEMANILHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class AIHLBKAKPHG
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OIABNOOIOAC : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public DJHOLNLKCOK.LCFMLIFMCLP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private DFNLOIOHDAO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public OIABNOOIOAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x46753A0", Offset = "0x46743A0", VA = "0x1846753A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x46754B0", Offset = "0x46744B0", VA = "0x1846754B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4665D40", Offset = "0x4664D40", VA = "0x184665D40")]
	public static OBBEAJINNHP KMIIOJDBKJA(float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4665E00", Offset = "0x4664E00", VA = "0x184665E00")]
	public static OBBEAJINNHP KMIIOJDBKJA(MonoBehaviour COFAHBEKNDD, float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4665EC0", Offset = "0x4664EC0", VA = "0x184665EC0")]
	public static OBBEAJINNHP OKLILMCGHLA(AFIOHBDIBFE JJNBJBEMAKH, float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, bool EBBFMKAKEIF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4665CA0", Offset = "0x4664CA0", VA = "0x184665CA0")]
	[IteratorStateMachine(typeof(OIABNOOIOAC))]
	private static IEnumerator<JFAHKOGHLOL> AJFLIKAJKLP(float HAIIAOBELKB, DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH, Action<float> DFPEMANILHA, bool EBBFMKAKEIF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LKIEKMICHPK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DPPJDNMJMKC : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DJHOLNLKCOK.LCFMLIFMCLP queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public DPPJDNMJMKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x466AA30", Offset = "0x4669A30", VA = "0x18466AA30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x466AAE0", Offset = "0x4669AE0", VA = "0x18466AAE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x46720F0", Offset = "0x46710F0", VA = "0x1846720F0")]
	[IteratorStateMachine(typeof(DPPJDNMJMKC))]
	private static IEnumerator<JFAHKOGHLOL> LHMHAAGDFOO(DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, Func<bool> BPDAEPFBCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4672170", Offset = "0x4671170", VA = "0x184672170")]
	public static OBBEAJINNHP MGDKACHIBOD(this MonoBehaviour COFAHBEKNDD, Func<bool> BPDAEPFBCIH, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP = DJHOLNLKCOK.LCFMLIFMCLP.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KKJMGGLNOGK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class BLNBIFKKGAJ : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DJHOLNLKCOK.LCFMLIFMCLP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public BLNBIFKKGAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4667740", Offset = "0x4666740", VA = "0x184667740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4667800", Offset = "0x4666800", VA = "0x184667800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FJKHLBJFFHO : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DJHOLNLKCOK.LCFMLIFMCLP queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private JFAHKOGHLOL <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public FJKHLBJFFHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x466B3D0", Offset = "0x466A3D0", VA = "0x18466B3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x466B4A0", Offset = "0x466A4A0", VA = "0x18466B4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x466E1C0", Offset = "0x466D1C0", VA = "0x18466E1C0")]
	[IteratorStateMachine(typeof(BLNBIFKKGAJ))]
	private static IEnumerator<JFAHKOGHLOL> JOOPOKCHFIN(float PNCPGCPDHGE, DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x466E020", Offset = "0x466D020", VA = "0x18466E020")]
	[IteratorStateMachine(typeof(FJKHLBJFFHO))]
	private static IEnumerator<JFAHKOGHLOL> IKBIKEIJFIG(float PNCPGCPDHGE, DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x466D900", Offset = "0x466C900", VA = "0x18466D900")]
	public static IDisposable BIJPAFAJMPB(this MonoBehaviour COFAHBEKNDD, float PNCPGCPDHGE, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x466DF20", Offset = "0x466CF20", VA = "0x18466DF20")]
	public static OBBEAJINNHP IBKMHKCPLIF(this MonoBehaviour COFAHBEKNDD, float PNCPGCPDHGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x466DA50", Offset = "0x466CA50", VA = "0x18466DA50")]
	public static OBBEAJINNHP BIJPAFAJMPB(this MonoBehaviour COFAHBEKNDD, float PNCPGCPDHGE, DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x466DDF0", Offset = "0x466CDF0", VA = "0x18466DDF0")]
	public static OBBEAJINNHP HJGLGPNEOIL(this MonoBehaviour COFAHBEKNDD, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x466E360", Offset = "0x466D360", VA = "0x18466E360")]
	public static OBBEAJINNHP MMCFKLIMIMO(this MonoBehaviour COFAHBEKNDD, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x466DCD0", Offset = "0x466CCD0", VA = "0x18466DCD0")]
	public static OBBEAJINNHP HEHNAAKGKDB(this MonoBehaviour COFAHBEKNDD, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x466DBB0", Offset = "0x466CBB0", VA = "0x18466DBB0")]
	public static OBBEAJINNHP EDJGILHFNAO(this MonoBehaviour COFAHBEKNDD, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x466DF10", Offset = "0x466CF10", VA = "0x18466DF10")]
	public static OBBEAJINNHP HMOGOKHECBB(this MonoBehaviour COFAHBEKNDD, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x466DE00", Offset = "0x466CE00", VA = "0x18466DE00")]
	private static OBBEAJINNHP HMIDOGFBINB(MonoBehaviour COFAHBEKNDD, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x466D7F0", Offset = "0x466C7F0", VA = "0x18466D7F0")]
	public static OBBEAJINNHP AIBBPFCGCDJ(this MonoBehaviour COFAHBEKNDD, float OEHDLCNHPOA, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x466E250", Offset = "0x466D250", VA = "0x18466E250")]
	public static OBBEAJINNHP MHLMEPDCPFA(this MonoBehaviour COFAHBEKNDD, float OEHDLCNHPOA, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x466DCE0", Offset = "0x466CCE0", VA = "0x18466DCE0")]
	public static OBBEAJINNHP HHDEPGJPMFN(this MonoBehaviour COFAHBEKNDD, float OEHDLCNHPOA, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x466DBC0", Offset = "0x466CBC0", VA = "0x18466DBC0")]
	public static OBBEAJINNHP GECNDPMFBGF(this MonoBehaviour COFAHBEKNDD, float OEHDLCNHPOA, Action KBHGLOOKIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x466E0B0", Offset = "0x466D0B0", VA = "0x18466E0B0")]
	public static OBBEAJINNHP IMKGIMJHBGN(this MonoBehaviour COFAHBEKNDD, float OEHDLCNHPOA, Action KBHGLOOKIGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class IKKEOCDPCBD : GEENKDBFKDF
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class EFDAMIBFADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public IKKEOCDPCBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public EFDAMIBFADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4667850", Offset = "0x4666850", VA = "0x184667850")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class CBAGBMGGACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public IKKEOCDPCBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
		public CBAGBMGGACN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4667850", Offset = "0x4666850", VA = "0x184667850")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float CLLPGEELNLO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x466CB00", Offset = "0x466BB00", VA = "0x18466CB00")]
	public IKKEOCDPCBD(Behaviour JJNBJBEMAKH, float CLLPGEELNLO, [Optional] Action EBKBBKDBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x466CA20", Offset = "0x466BA20", VA = "0x18466CA20", Slot = "9")]
	protected override bool OLMAANEHFIF(Action EDHAOFHJENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x466C940", Offset = "0x466B940", VA = "0x18466C940", Slot = "10")]
	protected override bool JFMPBMFADMG(Action EDHAOFHJENI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GEJEOLNPJII
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool DLIHNJBCEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ALMLODADHOO;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FIPPEKNFHMA(bool KCLNEKGCOGO = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FIPPEKNFHMA(Action EDHAOFHJENI, bool KCLNEKGCOGO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class GEENKDBFKDF : GEJEOLNPJII
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KJDFDBBNHFK : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public KJDFDBBNHFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x466D700", Offset = "0x466C700", VA = "0x18466D700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x466D7A0", Offset = "0x466C7A0", VA = "0x18466D7A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour JJNBJBEMAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action EBKBBKDBKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private LELMHOFHHKK DBGPHCGKCDF;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DLIHNJBCEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE00", Offset = "0x8B9E00", VA = "0x1808BAE00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ALMLODADHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x466BA70", Offset = "0x466AA70", VA = "0x18466BA70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x466B9D0", Offset = "0x466A9D0", VA = "0x18466B9D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x466BCB0", Offset = "0x466ACB0", VA = "0x18466BCB0")]
	protected GEENKDBFKDF(Behaviour JJNBJBEMAKH, [Optional] Action EBKBBKDBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x466BB10", Offset = "0x466AB10", VA = "0x18466BB10", Slot = "7")]
	public bool FIPPEKNFHMA(bool KCLNEKGCOGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x466BB70", Offset = "0x466AB70", VA = "0x18466BB70", Slot = "8")]
	public bool FIPPEKNFHMA(Action EDHAOFHJENI, bool KCLNEKGCOGO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OLMAANEHFIF(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JFMPBMFADMG(Action EDHAOFHJENI);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x466BC90", Offset = "0x466AC90", VA = "0x18466BC90")]
	protected void MLNKOAABJOP(Action EDHAOFHJENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x466B7B0", Offset = "0x466A7B0", VA = "0x18466B7B0")]
	protected EJLKCPFELBD CBMJBGAHGGD(float IECPELDBBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x466BC20", Offset = "0x466AC20", VA = "0x18466BC20")]
	private void MFBEPMFBPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x466BBC0", Offset = "0x466ABC0", VA = "0x18466BBC0")]
	[IteratorStateMachine(typeof(KJDFDBBNHFK))]
	private static IEnumerator<JFAHKOGHLOL> IGJHFNJLGIJ(float IECPELDBBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x466B990", Offset = "0x466A990", VA = "0x18466B990")]
	[CompilerGenerated]
	private void COBCEDNJNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NMPMNFOAMDA : GEENKDBFKDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float IEOOAGKMLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int AFPKHPHAPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float JEBHKIKMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] INELCGHPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int DNNCOMBMOFJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KBGIOJEMIMH PKFHDCNIAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5109E0", Offset = "0x50F9E0", VA = "0x1805109E0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5C9390", Offset = "0x5C8390", VA = "0x1805C9390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4674610", Offset = "0x4673610", VA = "0x184674610")]
	public NMPMNFOAMDA(Behaviour JJNBJBEMAKH, float JMDDAMPAABN, int AFPKHPHAPCL, [Optional] Action EBKBBKDBKKK, float JEBHKIKMFFJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5358A0", Offset = "0x5348A0", VA = "0x1805358A0", Slot = "9")]
	protected override bool OLMAANEHFIF(Action EDHAOFHJENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x46743F0", Offset = "0x46733F0", VA = "0x1846743F0", Slot = "10")]
	protected override bool JFMPBMFADMG(Action EDHAOFHJENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4674360", Offset = "0x4673360", VA = "0x184674360")]
	private void GDLBENIJOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JDAOBDHNAJE : GEENKDBFKDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float CLLPGEELNLO;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x466CB00", Offset = "0x466BB00", VA = "0x18466CB00")]
	public JDAOBDHNAJE(Behaviour JJNBJBEMAKH, float CLLPGEELNLO, [Optional] Action EBKBBKDBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5358A0", Offset = "0x5348A0", VA = "0x1805358A0", Slot = "9")]
	protected override bool OLMAANEHFIF(Action EDHAOFHJENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x466CB60", Offset = "0x466BB60", VA = "0x18466CB60", Slot = "10")]
	protected override bool JFMPBMFADMG(Action EDHAOFHJENI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BLDIKBFPACN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class PCDDFKBMACC : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public PCDDFKBMACC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4675CA0", Offset = "0x4674CA0", VA = "0x184675CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4675DA0", Offset = "0x4674DA0", VA = "0x184675DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private OBBEAJINNHP GBCNJLHPFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private AFIOHBDIBFE JJNBJBEMAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action DFPEMANILHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> BLIHIMKJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float FPBCEHPIMDF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4667370", Offset = "0x4666370", VA = "0x184667370")]
	public BLDIKBFPACN(AFIOHBDIBFE JJNBJBEMAKH, Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x46671B0", Offset = "0x46661B0", VA = "0x1846671B0")]
	public BLDIKBFPACN(AFIOHBDIBFE JJNBJBEMAKH, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4667530", Offset = "0x4666530", VA = "0x184667530")]
	public BLDIKBFPACN(AFIOHBDIBFE JJNBJBEMAKH, float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4667020", Offset = "0x4666020", VA = "0x184667020")]
	private void KMIIOJDBKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x46669C0", Offset = "0x46659C0", VA = "0x1846669C0")]
	private void ACMGNEMNPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4666B50", Offset = "0x4665B50", VA = "0x184666B50")]
	private void AJDMHEOFBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4666D20", Offset = "0x4665D20", VA = "0x184666D20")]
	private void BKKGPGOMMKC(string ILMCLHHHHPK, Action JFKODKEPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4666FB0", Offset = "0x4665FB0", VA = "0x184666FB0")]
	[IteratorStateMachine(typeof(PCDDFKBMACC))]
	private IEnumerator<JFAHKOGHLOL> HPJFPCCLFLD(Action JFKODKEPLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4666ED0", Offset = "0x4665ED0", VA = "0x184666ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4666CA0", Offset = "0x4665CA0", VA = "0x184666CA0")]
	[CompilerGenerated]
	private void APKADBKJDMA(string KFHJIBPHHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4666F30", Offset = "0x4665F30", VA = "0x184666F30")]
	[CompilerGenerated]
	private void GECHCNBLEIF(string KFHJIBPHHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4666E50", Offset = "0x4665E50", VA = "0x184666E50")]
	[CompilerGenerated]
	private void DKBCLJMBCLN(string KFHJIBPHHGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class LAKNLCEDOPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class POJOKBPKFPO : IEnumerator<JFAHKOGHLOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private JFAHKOGHLOL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private JFAHKOGHLOL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
		[DebuggerHidden]
		public POJOKBPKFPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x46765B0", Offset = "0x46755B0", VA = "0x1846765B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x46766B0", Offset = "0x46756B0", VA = "0x1846766B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private OBBEAJINNHP GBCNJLHPFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour COFAHBEKNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action DFPEMANILHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> BLIHIMKJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float FPBCEHPIMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool EBBFMKAKEIF;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x466EEC0", Offset = "0x466DEC0", VA = "0x18466EEC0")]
	public LAKNLCEDOPB(MonoBehaviour COFAHBEKNDD, Action DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x466ED00", Offset = "0x466DD00", VA = "0x18466ED00")]
	public LAKNLCEDOPB(MonoBehaviour COFAHBEKNDD, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x466EB60", Offset = "0x466DB60", VA = "0x18466EB60")]
	public LAKNLCEDOPB(MonoBehaviour COFAHBEKNDD, float HAIIAOBELKB, Action<float> DFPEMANILHA, DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP, bool EBBFMKAKEIF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x466E9D0", Offset = "0x466D9D0", VA = "0x18466E9D0")]
	private void KMIIOJDBKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x466E370", Offset = "0x466D370", VA = "0x18466E370")]
	private void ACMGNEMNPFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x466E500", Offset = "0x466D500", VA = "0x18466E500")]
	private void AJDMHEOFBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x466E650", Offset = "0x466D650", VA = "0x18466E650")]
	private void BKKGPGOMMKC(string ILMCLHHHHPK, Action JFKODKEPLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x466E960", Offset = "0x466D960", VA = "0x18466E960")]
	[IteratorStateMachine(typeof(POJOKBPKFPO))]
	private IEnumerator<JFAHKOGHLOL> HPJFPCCLFLD(Action JFKODKEPLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x466E800", Offset = "0x466D800", VA = "0x18466E800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x466E8E0", Offset = "0x466D8E0", VA = "0x18466E8E0")]
	[CompilerGenerated]
	private void GIKGJPELJIL(string KFHJIBPHHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x466E860", Offset = "0x466D860", VA = "0x18466E860")]
	[CompilerGenerated]
	private void FAFIBNDJJGM(string KFHJIBPHHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x466E780", Offset = "0x466D780", VA = "0x18466E780")]
	[CompilerGenerated]
	private void CFPFDAMHAKB(string KFHJIBPHHGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PKCFCAFCMJF
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int NPIAMHGLOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LAODKFCPFKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly LAODKFCPFKH KNCANGKPIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action NFOOFNPBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool CGMMHFJBPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6A2810", Offset = "0x6A1810", VA = "0x1806A2810")]
	public LAODKFCPFKH(Action NFOOFNPBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x466F080", Offset = "0x466E080", VA = "0x18466F080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NDPLIBICOAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T DPFBMCEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HBBFFGCNBHI(Action<T> PMIIKPBNEOA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable HBBFFGCNBHI(UnityEngine.Object JJNBJBEMAKH, Action<T> PMIIKPBNEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GPCDEEHCOGO<T> : global::NDPLIBICOAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T DPFBMCEIHFE
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
public class LPBPFONIIMB<T> : global::GPCDEEHCOGO<T>, global::NDPLIBICOAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GEFBPNOCGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::LPBPFONIIMB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::JOGNBEOKOPD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2244BD0", Offset = "0x2243BD0", VA = "0x182244BD0")]
		public GEFBPNOCGHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3D74220", Offset = "0x3D73220", VA = "0x183D74220")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject GIDPOEJBONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::JOGNBEOKOPD<UnityEngine.Object, Action<T>>> HJGABBKPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T DGNIGGPBKJJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object HCFEFJNPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3D85E10", Offset = "0x3D84E10", VA = "0x183D85E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T DPFBMCEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7466B0", Offset = "0x7456B0", VA = "0x1807466B0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3D856F0", Offset = "0x3D846F0", VA = "0x183D856F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3D85B60", Offset = "0x3D84B60", VA = "0x183D85B60")]
	private static bool HLPPLHCJGKA(T MGMKOCNNKKD, T FFKAJGPOGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x35B5FF0", Offset = "0x35B4FF0", VA = "0x1835B5FF0")]
	public LPBPFONIIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3D86020", Offset = "0x3D85020", VA = "0x183D86020")]
	public LPBPFONIIMB(T OLJAIGPKOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3D85810", Offset = "0x3D84810", VA = "0x183D85810")]
	public void GMIHHIDBIFE(T FOMAGDONKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3D85990", Offset = "0x3D84990", VA = "0x183D85990", Slot = "7")]
	public IDisposable HBBFFGCNBHI(Action<T> PMIIKPBNEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3D85830", Offset = "0x3D84830", VA = "0x183D85830", Slot = "8")]
	public IDisposable HBBFFGCNBHI(UnityEngine.Object JJNBJBEMAKH, Action<T> PMIIKPBNEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3D85090", Offset = "0x3D84090", VA = "0x183D85090")]
	private void EKJMMNDJKCE()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<INDIAJPIODF, Scheduler>, INDIAJPIODF
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class GMAPDAIHJHC : PKCFCAFCMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public LGEOLAJFEKN CPOKGCKGNJJ;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int NPIAMHGLOAM
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x50D010", Offset = "0x50C010", VA = "0x18050D010", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x5358B0", Offset = "0x5348B0", VA = "0x1805358B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x466C2D0", Offset = "0x466B2D0", VA = "0x18466C2D0")]
			public static JFAHKOGHLOL ICOMINIELFN(IEnumerator<JFAHKOGHLOL> OALDELKNBJD, GAFDMFNIOCO BONEIOHHFOL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x466C1F0", Offset = "0x466B1F0", VA = "0x18466C1F0")]
			public JFAHKOGHLOL ICOMINIELFN(GAFDMFNIOCO[] AIKGAPLOKJI, IEnumerator<JFAHKOGHLOL>[] PGDFFKLPEGN, JFAHKOGHLOL[] DMAKLOEMHAH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x466C500", Offset = "0x466B500", VA = "0x18466C500")]
			public void PANNHFNMJIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x466C120", Offset = "0x466B120", VA = "0x18466C120")]
			public void GGBJEPMIGDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x466C430", Offset = "0x466B430", VA = "0x18466C430")]
			public void KMJMIGCCDMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x466C500", Offset = "0x466B500", VA = "0x18466C500")]
			public void LIIDPMHCENE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public GMAPDAIHJHC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class LGEOLAJFEKN
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct IGNONLNBPGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public GMAPDAIHJHC FFNGEHPMIMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public AFIOHBDIBFE KAODCMABKOA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public GAFDMFNIOCO PNJPFEEPODJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<JFAHKOGHLOL> DELNLNMAAGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public JFAHKOGHLOL NFHKFOBLECG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public FLEPDBOLAJH LDOFGCKPIJO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct AMFOKMIFJKO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public DJHOLNLKCOK.LCFMLIFMCLP PFBEGMHIECJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<IGNONLNBPGE> PKOKDFNIJNF;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class CFFMIGOLNAJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public LGEOLAJFEKN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public AFIOHBDIBFE context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public GMAPDAIHJHC routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public FLEPDBOLAJH coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public GAFDMFNIOCO promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public JFAHKOGHLOL currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<JFAHKOGHLOL> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
				public CFFMIGOLNAJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4667880", Offset = "0x4666880", VA = "0x184667880")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class JIBAJANCOOK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public GMAPDAIHJHC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public LGEOLAJFEKN <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
				public JIBAJANCOOK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x466D0A0", Offset = "0x466C0A0", VA = "0x18466D0A0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class ONMBNFHNHGP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public GMAPDAIHJHC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public LGEOLAJFEKN <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
				public ONMBNFHNHGP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4675A90", Offset = "0x4674A90", VA = "0x184675A90")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class LHNKBBIIDLH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public GMAPDAIHJHC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public LGEOLAJFEKN <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
				public LHNKBBIIDLH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x4671FA0", Offset = "0x4670FA0", VA = "0x184671FA0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] DKKLMJNJMFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<FLEPDBOLAJH> APABHBKGPLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> CKNJEFDPEAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> NKJLNFAPCLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> MDOANOHPNCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> MGLBIHPMFHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> OIKHIDJFEEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> IAJHPPIDNBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private GMAPDAIHJHC[] OIBMAJKKAHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private GAFDMFNIOCO[] AIKGAPLOKJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private AFIOHBDIBFE[] AJHICNLFPHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<JFAHKOGHLOL>[] LGJFKOPBBCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private JFAHKOGHLOL[] DCAMIBFCJLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int DOINNDAGFKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int NBDFKNGGAPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int PHMLGCDPFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float CNLKKHAMGDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private OMAKLLLAPNO NHEFLOPPJBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle JDKLIIOFBDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<GMAPDAIHJHC> AODMADGDECA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool PIODNAFHKJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> LJHPFCAFIJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> NMCCNDODJFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool JBENDEMBGND;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public AMFOKMIFJKO[] EPAGJBKNEMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x5C84B0", Offset = "0x5C74B0", VA = "0x1805C84B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int NPBGLKPBEFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x9555E0", Offset = "0x9545E0", VA = "0x1809555E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4671A20", Offset = "0x4670A20", VA = "0x184671A20")]
			private static int PNLOEMIIKDC(DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4671A50", Offset = "0x4670A50", VA = "0x184671A50")]
			public LGEOLAJFEKN(DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4671890", Offset = "0x4670890", VA = "0x184671890")]
			private void PFBIFMGFAAB(ref int MBIALAPOHFF, int GCGHGOHPBFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x46706F0", Offset = "0x466F6F0", VA = "0x1846706F0")]
			public void FCLLCAJGANA(AFIOHBDIBFE JJNBJBEMAKH, JFAHKOGHLOL EHOMOBJILHC, IEnumerator<JFAHKOGHLOL> OALDELKNBJD, GAFDMFNIOCO BONEIOHHFOL, [Optional] GMAPDAIHJHC FLMPKPJDJDH, FLEPDBOLAJH KMPBDJLGNJN = FLEPDBOLAJH.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4671240", Offset = "0x4670240", VA = "0x184671240")]
			public void KLCCPDHLJCL(IEnumerable<IGNONLNBPGE> JNFIGJDDGBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4670850", Offset = "0x466F850", VA = "0x184670850")]
			private IGNONLNBPGE HHBBCDBJMJE(int MKKPJEJBBAP)
			{
				return default(IGNONLNBPGE);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x46702A0", Offset = "0x466F2A0", VA = "0x1846702A0")]
			private void EKFFAEEHIFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x2090370", Offset = "0x208F370", VA = "0x182090370")]
			private static void CMANJJMNHNC<T>(int MKKPJEJBBAP, T[] POGAFCPBOCO, int ACFAACNMEBO, [Optional] T BOEPFAOHNJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2090350", Offset = "0x208F350", VA = "0x182090350")]
			private static void CMANJJMNHNC<T>(int MKKPJEJBBAP, NativeArray<T> POGAFCPBOCO, int ACFAACNMEBO, [Optional] T BOEPFAOHNJL) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x46714F0", Offset = "0x46704F0", VA = "0x1846714F0")]
			private void NBLBDKHHFLB(IEnumerable<IGNONLNBPGE> JNFIGJDDGBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x466FC80", Offset = "0x466EC80", VA = "0x18466FC80")]
			private void BIFNAADHMML(IGNONLNBPGE FCLEBBPONHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4670CD0", Offset = "0x466FCD0", VA = "0x184670CD0")]
			private KLEIHBGNHKG HINMAKJLCNI(int GKFDPFEBION)
			{
				return default(KLEIHBGNHKG);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4670F90", Offset = "0x466FF90", VA = "0x184670F90")]
			public void IBMCIFFJLIB(float EDGICJAFMNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4671790", Offset = "0x4670790", VA = "0x184671790")]
			private void OELEEDDGBCI(Action MGMKOCNNKKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4671810", Offset = "0x4670810", VA = "0x184671810")]
			private void PDIFEBOFPAC(Action MGMKOCNNKKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x466FD40", Offset = "0x466ED40", VA = "0x18466FD40")]
			public void ECGDDFJFGEH(float EDGICJAFMNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x4670610", Offset = "0x466F610", VA = "0x184670610")]
			public void ELGBEGHMCDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4671430", Offset = "0x4670430", VA = "0x184671430")]
			public void LIIDPMHCENE(GMAPDAIHJHC HBLLOKJGEGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x46701E0", Offset = "0x466F1E0", VA = "0x1846701E0")]
			public void EHALPHFFLEE(GMAPDAIHJHC HBLLOKJGEGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4671180", Offset = "0x4670180", VA = "0x184671180")]
			public void IOLLHCPPKNH(GMAPDAIHJHC HBLLOKJGEGM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct OMAKLLLAPNO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float COAELFCPBBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int PNPKAGNOLFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> PKIBMCPMHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> HCLDMNFFHAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> NGEEBDEAELN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<FLEPDBOLAJH> MHLHDEGLEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> KJOLBICNIGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> MGLBIHPMFHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> NKJLNFAPCLH;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4675500", Offset = "0x4674500", VA = "0x184675500")]
			public static OMAKLLLAPNO DMLCAMHGJAD(int NKAGKJNKJHK, float EDGICJAFMNK, NativeArray<FLEPDBOLAJH> HNNCJOFMBAD, NativeArray<float> KJBBHHMEODK, NativeArray<int> IBLELLKEAPN, NativeArray<int> GBHMGGMAKCK, NativeArray<int> FPLNDAOADFN, NativeArray<int> HCLDMNFFHAO, NativeArray<int> NGEEBDEAELN)
			{
				return default(OMAKLLLAPNO);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x46756A0", Offset = "0x46746A0", VA = "0x1846756A0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4675780", Offset = "0x4674780", VA = "0x184675780")]
			private bool HDDFNJEECBC(int IDCLMAKCIEP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4675830", Offset = "0x4674830", VA = "0x184675830")]
			private void OADMDOCBIJA(NativeArray<int> ONCIGBFEMKC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x46757C0", Offset = "0x46747C0", VA = "0x1846757C0")]
			private int NCMKDJOJHDH(int LKLLGHIFCNM, int LNDGEHOIBJG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x46755D0", Offset = "0x46745D0", VA = "0x1846755D0")]
			private void ELPANOHBPBD(NativeArray<int> ONCIGBFEMKC, int DJJNCHOCFCO, int CMKPNNMPIHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4675860", Offset = "0x4674860", VA = "0x184675860")]
			private void OKEBMBBNADF(NativeArray<int> ONCIGBFEMKC, int DKIDKANAJAH, int JIGOJALNGGA, int LEHOBEIIMNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class PIMEMJENMNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly GAFDMFNIOCO BONEIOHHFOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour JJNBJBEMAKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool AAGIDCCKJFI;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<JFAHKOGHLOL> DELNLNMAAGC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x511450", Offset = "0x510450", VA = "0x180511450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x534E90", Offset = "0x533E90", VA = "0x180534E90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public JFAHKOGHLOL NFHKFOBLECG
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x514430", Offset = "0x513430", VA = "0x180514430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool FPBPJHGMBBN
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x4675DF0", Offset = "0x4674DF0", VA = "0x184675DF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool IONINAPCNPL
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x92BC60", Offset = "0x92AC60", VA = "0x18092BC60")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x96D810", Offset = "0x96C810", VA = "0x18096D810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string BILCIOOICBK
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x511470", Offset = "0x510470", VA = "0x180511470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5359E0", Offset = "0x5349E0", VA = "0x1805359E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float MIPPOLDIHPH
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x8290B0", VA = "0x18082A0B0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0xAC2080", Offset = "0xAC1080", VA = "0x180AC2080")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x4676240", Offset = "0x4675240", VA = "0x184676240")]
			public PIMEMJENMNO(IEnumerator<JFAHKOGHLOL> OALDELKNBJD, Behaviour JJNBJBEMAKH, GAFDMFNIOCO BONEIOHHFOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4675E80", Offset = "0x4674E80", VA = "0x184675E80")]
			public JFAHKOGHLOL ICOMINIELFN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4676120", Offset = "0x4675120", VA = "0x184676120")]
			public bool PNGALFJFPDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4676090", Offset = "0x4675090", VA = "0x184676090")]
			public void LIIDPMHCENE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x46761B0", Offset = "0x46751B0", VA = "0x1846761B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x192A000", Offset = "0x1929000", VA = "0x18192A000")]
			[CompilerGenerated]
			private void LDLMAODGJLA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class GAFDMFNIOCO : FGCJNBAHHGO, OBBEAJINNHP, LELMHOFHHKK, EJLKCPFELBD, IEnumerator, JFAHKOGHLOL, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private DJHOLNLKCOK.LCFMLIFMCLP CMOAINJCLLN;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private DJHOLNLKCOK.LCFMLIFMCLP AMPFNDFGCME
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x559AF0", Offset = "0x558AF0", VA = "0x180559AF0", Slot = "23")]
				get
				{
					return default(DJHOLNLKCOK.LCFMLIFMCLP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public DJHOLNLKCOK.LCFMLIFMCLP CPOKGCKGNJJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x559AF0", Offset = "0x558AF0", VA = "0x180559AF0")]
				get
				{
					return default(DJHOLNLKCOK.LCFMLIFMCLP);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x6B3F00", Offset = "0x6B2F00", VA = "0x1806B3F00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float LDGAMNAFFHL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x695B80", Offset = "0x694B80", VA = "0x180695B80", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x466B630", Offset = "0x466A630", VA = "0x18466B630", Slot = "24")]
			private bool KLKKIKKNPCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x466B620", Offset = "0x466A620", VA = "0x18466B620", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x466B650", Offset = "0x466A650", VA = "0x18466B650")]
			public GAFDMFNIOCO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum KLEIHBGNHKG : byte
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
		private sealed class NJIFGGICJJI : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum DBPDEIKGBGB
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct CBEIJHBGFLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public DJHOLNLKCOK.LCFMLIFMCLP PFBEGMHIECJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public DBPDEIKGBGB ODBLOKOFBPB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<PIMEMJENMNO> JNKAPJGKLHA;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly DBPDEIKGBGB[] PMCHLELMGOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly DJHOLNLKCOK.LCFMLIFMCLP CMJHKBPCFDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool NKKDIOOLAPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly PIMEMJENMNO[] DLAEKOAFJJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<PIMEMJENMNO> HKOLLLLPCPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> KOFNPDPMMMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<PIMEMJENMNO> ECGMCKOJMAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> KOLLLADGOBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool JBENDEMBGND;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public CBEIJHBGFLD[,] AINPKIKPOKH
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x5107D0", Offset = "0x50F7D0", VA = "0x1805107D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int NPBGLKPBEFA
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x4672A90", Offset = "0x4671A90", VA = "0x184672A90")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x4673DC0", Offset = "0x4672DC0", VA = "0x184673DC0")]
			public NJIFGGICJJI(DJHOLNLKCOK.LCFMLIFMCLP PGLGKDNEJFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x4672EB0", Offset = "0x4671EB0", VA = "0x184672EB0")]
			public void EBHOMENLGLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x4673CD0", Offset = "0x4672CD0", VA = "0x184673CD0")]
			public void PJMIBONNGEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x4672960", Offset = "0x4671960", VA = "0x184672960")]
			private void BELAAJPAKFP(IReadOnlyList<PIMEMJENMNO> CLHDPDBDPHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x4672F70", Offset = "0x4671F70", VA = "0x184672F70")]
			public void EGHJJCIMLBL(PIMEMJENMNO OALDELKNBJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4673470", Offset = "0x4672470", VA = "0x184673470")]
			public void ILKDAFAMHKB(IList<PIMEMJENMNO> PGDFFKLPEGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x4673900", Offset = "0x4672900", VA = "0x184673900")]
			public void LPHPBPPPNHI(IList<PIMEMJENMNO> PGDFFKLPEGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x4673810", Offset = "0x4672810", VA = "0x184673810")]
			private void KMBMGAPNHKN(PIMEMJENMNO OALDELKNBJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x4672C00", Offset = "0x4671C00", VA = "0x184672C00")]
			private void DALEJBDAAIG(IList<PIMEMJENMNO> PGDFFKLPEGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4673B80", Offset = "0x4672B80", VA = "0x184673B80")]
			private KLEIHBGNHKG OOKHNJABMJH(PIMEMJENMNO OALDELKNBJD)
			{
				return default(KLEIHBGNHKG);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x4672EC0", Offset = "0x4671EC0", VA = "0x184672EC0")]
			public void EBPLJKLJNDI(float EDGICJAFMNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x4673270", Offset = "0x4672270", VA = "0x184673270")]
			public void IBHDHPAAPKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x4673090", Offset = "0x4672090", VA = "0x184673090")]
			private void EGOCHNHKKKN(List<PIMEMJENMNO> PGDFFKLPEGN, Stack<int> FJPNCLPPLHL, bool ADLJMDGIEMD, float NLKHMIOIADC = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x4672D70", Offset = "0x4671D70", VA = "0x184672D70", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x46736F0", Offset = "0x46726F0", VA = "0x1846736F0")]
			private void JCCNMGBMEEL(List<PIMEMJENMNO> PGDFFKLPEGN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum FLEPDBOLAJH : byte
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
		private sealed class ALELHLHMAJD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x511050", Offset = "0x510050", VA = "0x180511050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x534960", Offset = "0x533960", VA = "0x180534960")]
			[DebuggerHidden]
			public ALELHLHMAJD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4665F80", Offset = "0x4664F80", VA = "0x184665F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4666000", Offset = "0x4665000", VA = "0x184666000", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const FLEPDBOLAJH JDFDFKKEKBD = FLEPDBOLAJH.Cancelled | FLEPDBOLAJH.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly DJHOLNLKCOK.LCFMLIFMCLP[] JNPOKCMNPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NJIFGGICJJI[] ONGFLIMEPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LGEOLAJFEKN[] OJGBGFCNJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine CDLGBJGLMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame BBOAIFMEMAC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public DJHOLNLKCOK.LCFMLIFMCLP MNLACIIAHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x511440", Offset = "0x510440", VA = "0x180511440")]
			[CompilerGenerated]
			get
			{
				return default(DJHOLNLKCOK.LCFMLIFMCLP);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5CD1A0", Offset = "0x5CC1A0", VA = "0x1805CD1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OFLJOBGFHLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x92B960", Offset = "0x92A960", VA = "0x18092B960", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x22514E0", Offset = "0x22504E0", VA = "0x1822514E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int NPBGLKPBEFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4678030", Offset = "0x4677030", VA = "0x184678030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4676C80", Offset = "0x4675C80", VA = "0x184676C80")]
		public static OBBEAJINNHP GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4676700", Offset = "0x4675700", VA = "0x184676700", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4677080", Offset = "0x4676080", VA = "0x184677080", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4676D20", Offset = "0x4675D20", VA = "0x184676D20")]
		private NJIFGGICJJI JPCJEPCOLKO(DJHOLNLKCOK.LCFMLIFMCLP CIMKNKPILIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xB994A0", Offset = "0xB984A0", VA = "0x180B994A0")]
		private LGEOLAJFEKN GOEEJNKNKML(DJHOLNLKCOK.LCFMLIFMCLP CIMKNKPILIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4677540", Offset = "0x4676540", VA = "0x184677540")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4677500", Offset = "0x4676500", VA = "0x184677500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4677E00", Offset = "0x4676E00", VA = "0x184677E00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4676F40", Offset = "0x4675F40", VA = "0x184676F40")]
		private void MALCBFHCGDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4677070", Offset = "0x4676070", VA = "0x184677070")]
		private void OEIBNBOHPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4676C70", Offset = "0x4675C70", VA = "0x184676C70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4676F30", Offset = "0x4675F30", VA = "0x184676F30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4676F20", Offset = "0x4675F20", VA = "0x184676F20")]
		private void LEMJIKDNLMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4676BA0", Offset = "0x4675BA0", VA = "0x184676BA0")]
		[IteratorStateMachine(typeof(ALELHLHMAJD))]
		private IEnumerator BHCIGAJGGBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x46776F0", Offset = "0x46766F0", VA = "0x1846776F0", Slot = "7")]
		public OBBEAJINNHP Run(IEnumerator<JFAHKOGHLOL> GLFMBPCPFFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4677700", Offset = "0x4676700", VA = "0x184677700", Slot = "8")]
		public OBBEAJINNHP Run(Behaviour JJNBJBEMAKH, IEnumerator<JFAHKOGHLOL> GLFMBPCPFFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x46775C0", Offset = "0x46765C0", VA = "0x1846775C0", Slot = "9")]
		public OBBEAJINNHP RunJobbed(AFIOHBDIBFE JJNBJBEMAKH, IEnumerator<JFAHKOGHLOL> GLFMBPCPFFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4676C10", Offset = "0x4675C10", VA = "0x184676C10", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4677930", Offset = "0x4676930", VA = "0x184677930")]
		public void UpdateQueue(DJHOLNLKCOK.LCFMLIFMCLP GOBCPJHCPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4676D60", Offset = "0x4675D60", VA = "0x184676D60")]
		private void KNPNNCGNCMB(NJIFGGICJJI CLDLCJOKKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4676F50", Offset = "0x4675F50", VA = "0x184676F50")]
		private void MONNPLNMMAE(LGEOLAJFEKN CLDLCJOKKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4677FC0", Offset = "0x4676FC0", VA = "0x184677FC0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class DKKDCCPANOG
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x466A3B0", Offset = "0x46693B0", VA = "0x18466A3B0")]
	[OMADDHCKKDI]
	private static void FHOGAAHHIBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class FEDBGGGNAPL : KBGIOJEMIMH
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float KIIPAEICGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x466B380", Offset = "0x466A380", VA = "0x18466B380", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float ICNAFLMCLPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x466B370", Offset = "0x466A370", VA = "0x18466B370", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float BCLIBECLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x466B3C0", Offset = "0x466A3C0", VA = "0x18466B3C0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int MJKFHFKBKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x466B390", Offset = "0x466A390", VA = "0x18466B390", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double HBLIIPOMEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x466B3A0", Offset = "0x466A3A0", VA = "0x18466B3A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public FEDBGGGNAPL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DLAOCNHHHPI
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] HDGCOIJLNAH;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int OFJBPIBPJGA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int DJDAKEIMIDA;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger JAEJMLKAHIB;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLAOCNHHHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x466A770", Offset = "0x4669770", VA = "0x18466A770")]
	private static string MKDMGNIMLKE(byte[] FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x466A440", Offset = "0x4669440", VA = "0x18466A440")]
	public static string KDCKFNHEIFO(byte[] CPFFKFOFBAE, bool FPKNOKKBPNA)
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

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
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

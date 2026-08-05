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
		private delegate List<PlayerLoopSystem> OFPBOLIGHEM(List<PlayerLoopSystem> DNIDMFLBJNP, int HGFEIKKFFEN);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct OJHNNILENKN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct LMIPGPJLLHO
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static GNKFNHJJKGC EKCAIDBNJPE;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x3ABAA20", Offset = "0x3AB9C20", VA = "0x183ABAA20")]
				public static PlayerLoopSystem PMGBFFMDNJP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct HBMPFDKNEEC
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static GNKFNHJJKGC DNINOBJBFKB;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x3AB54A0", Offset = "0x3AB46A0", VA = "0x183AB54A0")]
				public static PlayerLoopSystem PMGBFFMDNJP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct LFJFAMDMJEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static GNKFNHJJKGC MPCBEBIDDNG;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x3AB9750", Offset = "0x3AB8950", VA = "0x183AB9750")]
				public static PlayerLoopSystem PMGBFFMDNJP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct KEKFKOAHMMJ
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class EHMNMAJMCHO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public AEJGFGLIEOA.LOEOFIDOJKE key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
					public EHMNMAJMCHO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x3AB1BA0", Offset = "0x3AB0DA0", VA = "0x183AB1BA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable BHAJBADILJL;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x3AB8DF0", Offset = "0x3AB7FF0", VA = "0x183AB8DF0")]
				public static PlayerLoopSystem JNNKMOINPFD(AEJGFGLIEOA.LOEOFIDOJKE BGJKOMDILFD)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct JEGFFAPEJEL
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class OBLOENKDHFK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public AEJGFGLIEOA.LOEOFIDOJKE key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
					public OBLOENKDHFK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x3ABBC00", Offset = "0x3ABAE00", VA = "0x183ABBC00")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3AB87E0", Offset = "0x3AB79E0", VA = "0x183AB87E0")]
				public static PlayerLoopSystem JNNKMOINPFD(AEJGFGLIEOA.LOEOFIDOJKE BGJKOMDILFD)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LLEIAMIPLIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public LLEIAMIPLIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3ABA920", Offset = "0x3AB9B20", VA = "0x183ABA920")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool BIFMJEEMBNN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool ABMCDLPIEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x3AB05A0", Offset = "0x3AAF7A0", VA = "0x183AB05A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0460", Offset = "0x3AAF660", VA = "0x183AB0460")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF3B0", Offset = "0x3AAE5B0", VA = "0x183AAF3B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0200", Offset = "0x3AAF400", VA = "0x183AB0200")]
		private static void HDNIIIACGEE(AEJGFGLIEOA.LOEOFIDOJKE BGJKOMDILFD, ref PlayerLoopSystem AOBNICJLAMI, Type DIOANJELODD, Type BAFMJJLIBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3AB05E0", Offset = "0x3AAF7E0", VA = "0x183AB05E0")]
		private static void PDHBJCBIGHL(ref PlayerLoopSystem AOBNICJLAMI, Type DIOANJELODD, Type BAFMJJLIBNF, OFPBOLIGHEM HBCFGNLAIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3AB04A0", Offset = "0x3AAF6A0", VA = "0x183AB04A0")]
		private static void NJDBNOJFGNI(ref PlayerLoopSystem AOBNICJLAMI, Type DIOANJELODD, Type BAFMJJLIBNF, PlayerLoopSystem? MLHNDPHMECL, PlayerLoopSystem? OKBAKOANJKH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AEJGFGLIEOA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LOEOFIDOJKE
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
	public class LJDCBMHAICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly LOEOFIDOJKE DFFHFHMEIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IBOJADDFAAH IINJKIFIKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long LILPHANBNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long FIONHJDMANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long JIINPNAOKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int DLLEJAOMBEM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA840", Offset = "0x3AB9A40", VA = "0x183ABA840")]
		public LJDCBMHAICG(LOEOFIDOJKE OHGPLEPKCII, int MCGINDFHJOI = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA710", Offset = "0x3AB9910", VA = "0x183ABA710")]
		public void JPKJHILBGLA(int ANKNLDMEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA7D0", Offset = "0x3AB99D0", VA = "0x183ABA7D0")]
		public void OHIKDCDOIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA6B0", Offset = "0x3AB98B0", VA = "0x183ABA6B0")]
		public void DPLJCPOJDLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA4E0", Offset = "0x3AB96E0", VA = "0x183ABA4E0")]
		public void CHCKKINCAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABA730", Offset = "0x3AB9930", VA = "0x183ABA730")]
		public double MHGFLNNHDKL(int DBLEDODDNNI)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int FADEDEJPINB = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static LOEOFIDOJKE[] BDLABDIJOEA;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static LJDCBMHAICG[] HGEHLMHLMGO;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3AACC60", Offset = "0x3AABE60", VA = "0x183AACC60")]
	public static LJDCBMHAICG ADLEIOJHNBK(LOEOFIDOJKE BGJKOMDILFD, int MCGINDFHJOI = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3AACEA0", Offset = "0x3AAC0A0", VA = "0x183AACEA0")]
	public static LJDCBMHAICG DILNOBDFAOL(LOEOFIDOJKE BGJKOMDILFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3AACDF0", Offset = "0x3AABFF0", VA = "0x183AACDF0")]
	public static void CMFNODAGMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IBOJADDFAAH : HOHPFHINGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int JGEOHKONGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> DKMEKKMNJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double BEAEBLPAPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double NDBJFAAAAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double BOKLFAIKLMN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JLCGIKPKMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7B00", Offset = "0x3AB6D00", VA = "0x183AB7B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double GNOMIDGBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7B40", Offset = "0x3AB6D40", VA = "0x183AB7B40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HFGJODKGCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xF34FC0", Offset = "0xF341C0", VA = "0x180F34FC0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double PFHGFOKMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8F70", Offset = "0x2DA8170", VA = "0x182DA8F70", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7BA0", Offset = "0x3AB6DA0", VA = "0x183AB7BA0")]
	public IBOJADDFAAH(int DALLMOMIEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7990", Offset = "0x3AB6B90", VA = "0x183AB7990", Slot = "4")]
	public void AAJDCJOGPOK(double KGNCHGHEBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7A90", Offset = "0x3AB6C90", VA = "0x183AB7A90", Slot = "5")]
	public void BFEJDDJAFFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NGBCHBKNFBL : HOHPFHINGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long KIAPCNBNHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double OJEOIIKDOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double BPONKEAGMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double LGAMMBNLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double EKJJLCGBFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double BEAEBLPAPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double NDBJFAAAAGL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JNHNEJAPHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HFGJODKGCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x252BB90", Offset = "0x252AD90", VA = "0x18252BB90", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double PFHGFOKMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x720860", Offset = "0x71FA60", VA = "0x180720860", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double IMAFJLBIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8F70", Offset = "0x2DA8170", VA = "0x182DA8F70")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double ABHNBILIMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x354C470", Offset = "0x354B670", VA = "0x18354C470")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double GNOMIDGBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2DA8EA0", Offset = "0x2DA80A0", VA = "0x182DA8EA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB9E0", Offset = "0x3ABABE0", VA = "0x183ABB9E0", Slot = "4")]
	public void AAJDCJOGPOK(double KGNCHGHEBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBB00", Offset = "0x3ABAD00", VA = "0x183ABBB00", Slot = "5")]
	public void BFEJDDJAFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBB40", Offset = "0x3ABAD40", VA = "0x183ABBB40")]
	public NGBCHBKNFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HOHPFHINGDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double GNOMIDGBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HFGJODKGCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double PFHGFOKMLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAJDCJOGPOK(double KGNCHGHEBOO);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFEJDDJAFFF();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CHDNPBALALN
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface EDONAFGLPED
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool EELHDEHIMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HCCLPADGFMA();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JAOLKNKLKKF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class IBJNDLABGML<TPromise, TMainThreadPromise> : EDONAFGLPED where TPromise : FIIDGPMBKPK where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise FFPHHCCGCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise NDOPCPIMLGP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise EFKHBOJOJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2194B90", Offset = "0x2193D90", VA = "0x182194B90")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EELHDEHIMIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2194C20", Offset = "0x2193E20", VA = "0x182194C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x20F9860", Offset = "0x20F8A60", VA = "0x1820F9860")]
		protected IBJNDLABGML(TPromise FFPHHCCGCOF, TMainThreadPromise JJONIJHNLHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2194BF0", Offset = "0x2193DF0", VA = "0x182194BF0", Slot = "5")]
		public void HCCLPADGFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2142AD0", Offset = "0x2141CD0", VA = "0x182142AD0", Slot = "6")]
		public void JAOLKNKLKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void FEBBLPGLLMO(TPromise FFPHHCCGCOF);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void LMHCKMKPADI();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class EFEEILOAAJI<T> : IBJNDLABGML<global::MGLHMIMFOOP<T>, global::IBEPJEMMAFD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2193940", Offset = "0x2192B40", VA = "0x182193940")]
		public EFEEILOAAJI(global::MGLHMIMFOOP<T> FFPHHCCGCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2193760", Offset = "0x2192960", VA = "0x182193760", Slot = "7")]
		protected override void FEBBLPGLLMO(global::MGLHMIMFOOP<T> FFPHHCCGCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x21938B0", Offset = "0x2192AB0", VA = "0x1821938B0", Slot = "8")]
		protected override void LMHCKMKPADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1C88030", Offset = "0x1C87230", VA = "0x181C88030")]
		[CompilerGenerated]
		private void PCFHCMIJMHD(T KLEOEPAEIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2193910", Offset = "0x2192B10", VA = "0x182193910")]
		[CompilerGenerated]
		private void OMGIMAIKBPO(string CJNIHHAKCLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GIANELHHHJO : IBJNDLABGML<FIIDGPMBKPK, LBOFBPOGAAB>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB50B0", Offset = "0x3AB42B0", VA = "0x183AB50B0")]
		public GIANELHHHJO(FIIDGPMBKPK FFPHHCCGCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4F90", Offset = "0x3AB4190", VA = "0x183AB4F90", Slot = "7")]
		protected override void FEBBLPGLLMO(FIIDGPMBKPK FFPHHCCGCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5060", Offset = "0x3AB4260", VA = "0x183AB5060", Slot = "8")]
		protected override void LMHCKMKPADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1146F00", Offset = "0x1146100", VA = "0x181146F00")]
		[CompilerGenerated]
		private void PCFHCMIJMHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16322E0", Offset = "0x16314E0", VA = "0x1816322E0")]
		[CompilerGenerated]
		private void OMGIMAIKBPO(string CJNIHHAKCLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class PAOICANMDJA : EDONAFGLPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action EPNGAEBBFEF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EELHDEHIMIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x425F60", Offset = "0x425160", VA = "0x180425F60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x511D10", Offset = "0x510F10", VA = "0x180511D10")]
		public PAOICANMDJA(Action EPNGAEBBFEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x146E120", Offset = "0x146D320", VA = "0x18146E120", Slot = "5")]
		public void HCCLPADGFMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "6")]
		public void JAOLKNKLKKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<EDONAFGLPED> ALKCOKABIBB;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE960", Offset = "0x1FEDB60", VA = "0x181FEE960")]
	public static global::MGLHMIMFOOP<T> NIJLFCHAFDI<T>(this global::MGLHMIMFOOP<T> FFPHHCCGCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF0E0", Offset = "0x3AAE2E0", VA = "0x183AAF0E0")]
	public static FIIDGPMBKPK NIJLFCHAFDI(this FIIDGPMBKPK FFPHHCCGCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF1F0", Offset = "0x3AAE3F0", VA = "0x183AAF1F0")]
	public static void NIJLFCHAFDI(Action EPNGAEBBFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE9D0", Offset = "0x1FEDBD0", VA = "0x181FEE9D0")]
	private static global::MGLHMIMFOOP<T> PJGNHIBIADD<T>(global::MGLHMIMFOOP<T> FFPHHCCGCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF270", Offset = "0x3AAE470", VA = "0x183AAF270")]
	private static FIIDGPMBKPK PJGNHIBIADD(FIIDGPMBKPK FFPHHCCGCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3AAED80", Offset = "0x3AADF80", VA = "0x183AAED80")]
	private static void DFHGNFIOALM(EDONAFGLPED ILIAIFKHHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEA60", Offset = "0x3AADC60", VA = "0x183AAEA60")]
	private static void BDIGCKALBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEF60", Offset = "0x3AAE160", VA = "0x183AAEF60")]
	private static void FPNJOACGKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAF030", Offset = "0x3AAE230", VA = "0x183AAF030")]
	private static void IIHNHAAFKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BGBFOFCGEAN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GHFMBCJJMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LBOFBPOGAAB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public GHFMBCJJMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4DB0", Offset = "0x3AB3FB0", VA = "0x183AB4DB0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4DA0", Offset = "0x3AB3FA0", VA = "0x183AB4DA0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IHJLGBPEPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public IHJLGBPEPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3AB87B0", Offset = "0x3AB79B0", VA = "0x183AB87B0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CAAJKCECAMJ : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LBOFBPOGAAB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public CAAJKCECAMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE310", Offset = "0x3AAD510", VA = "0x183AAE310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE040", Offset = "0x3AAD240", VA = "0x183AAE040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE3C0", Offset = "0x3AAD5C0", VA = "0x183AAE3C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE2C0", Offset = "0x3AAD4C0", VA = "0x183AAE2C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GOFBGIKLNMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LBOFBPOGAAB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public GOFBGIKLNMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HNFMMILMLIE : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LBOFBPOGAAB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private GOFBGIKLNMH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public HNFMMILMLIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6E70", Offset = "0x3AB6070", VA = "0x183AB6E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3AB71C0", Offset = "0x3AB63C0", VA = "0x183AB71C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string HAFENMBJAPK = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string FPGOHJOCEDM = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string IAEBHBMJIFC = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string OEIFPLBBNHA = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string OPIMDMEJKPD = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float ODCEOFAEBKI = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static FIIDGPMBKPK ALOPBPBGHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation GCJHGDHCJOD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static FIIDGPMBKPK MKDAHLMGMEK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string KNKOFOGDMKA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority BNDCDIDLILP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool ACIHAAABPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD950", Offset = "0x3AACB50", VA = "0x183AAD950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HHCMCDKHIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3AADDD0", Offset = "0x3AACFD0", VA = "0x183AADDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool KBBJJAHEJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD7B0", Offset = "0x3AAC9B0", VA = "0x183AAD7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MNHABDCDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD9F0", Offset = "0x3AACBF0", VA = "0x183AAD9F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3AADAA0", Offset = "0x3AACCA0", VA = "0x183AADAA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD810", Offset = "0x3AACA10", VA = "0x183AAD810")]
	public static FIIDGPMBKPK BJDIPKFMALD(string BOELLPLKOBB, LoadSceneMode LMDNGNHMKPH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3AADBC0", Offset = "0x3AACDC0", VA = "0x183AADBC0")]
	public static FIIDGPMBKPK NMEAOCPFNAG(string BOELLPLKOBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3AADB50", Offset = "0x3AACD50", VA = "0x183AADB50")]
	[IteratorStateMachine(typeof(CAAJKCECAMJ))]
	private static IEnumerator<EJFBNPFIIDA> LLNLPNMJGHB(string BOELLPLKOBB, LBOFBPOGAAB JLJCKJFNINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD730", Offset = "0x3AAC930", VA = "0x183AAD730")]
	[IteratorStateMachine(typeof(HNFMMILMLIE))]
	private static IEnumerator<EJFBNPFIIDA> BGBNHOODPNL(string BOELLPLKOBB, LoadSceneMode LMDNGNHMKPH, LBOFBPOGAAB JLJCKJFNINO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FDGHBAFDDKE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2470", Offset = "0x3AB1670", VA = "0x183AB2470")]
	public static IDisposable LKLNEDCHAIE(this LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AB22B0", Offset = "0x3AB14B0", VA = "0x183AB22B0")]
	public static IDisposable LKLNEDCHAIE(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1D70", Offset = "0x3AB0F70", VA = "0x183AB1D70")]
	public static IDisposable DJELNKOEPNM(this LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3AB21C0", Offset = "0x3AB13C0", VA = "0x183AB21C0")]
	public static IDisposable JNOGDEMIEFC(this LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2040", Offset = "0x3AB1240", VA = "0x183AB2040")]
	public static IDisposable IJHALHJFHPD(this LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1E60", Offset = "0x3AB1060", VA = "0x183AB1E60")]
	public static IDisposable FMEGPIFKNGC(this LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1FD0", Offset = "0x3AB11D0", VA = "0x183AB1FD0")]
	public static IDisposable IINMFFHOPPK(this LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2800", Offset = "0x3AB1A00", VA = "0x183AB2800")]
	public static IDisposable OIHCKLMPBHE(this LAKFLIJDBCL OEIFFOBMIEM, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1F50", Offset = "0x3AB1150", VA = "0x183AB1F50")]
	public static IDisposable IENMMLDMHFI(this LAKFLIJDBCL OEIFFOBMIEM, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2570", Offset = "0x3AB1770", VA = "0x183AB2570")]
	public static IDisposable MJGMDDILCND(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1ED0", Offset = "0x3AB10D0", VA = "0x183AB1ED0")]
	public static IDisposable HLKFPFPFCLE(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB25F0", Offset = "0x3AB17F0", VA = "0x183AB25F0")]
	public static IDisposable MPIFMLJIDIG(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2670", Offset = "0x3AB1870", VA = "0x183AB2670")]
	public static IDisposable NOADOIHGALF(this LAKFLIJDBCL OEIFFOBMIEM, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1DE0", Offset = "0x3AB0FE0", VA = "0x183AB1DE0")]
	public static IDisposable FLCIOEFNGBG(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3AB20B0", Offset = "0x3AB12B0", VA = "0x183AB20B0")]
	public static IDisposable INMEBDKDIGI(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3AB24F0", Offset = "0x3AB16F0", VA = "0x183AB24F0")]
	public static IDisposable MGLIAFDFOAM(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2130", Offset = "0x3AB1330", VA = "0x183AB2130")]
	public static IDisposable JDMGJAODLHO(this LAKFLIJDBCL OEIFFOBMIEM, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2700", Offset = "0x3AB1900", VA = "0x183AB2700")]
	public static IDisposable OEAMJOLKKBI(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2230", Offset = "0x3AB1430", VA = "0x183AB2230")]
	public static IDisposable LEIKGGDOHHE(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2780", Offset = "0x3AB1980", VA = "0x183AB2780")]
	public static IDisposable OGIODHPBIMO(this LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MNJBLCAMFKD
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB4D0", Offset = "0x3ABA6D0", VA = "0x183ABB4D0")]
	public static IDisposable KFMNGOEOFAB(this MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB550", Offset = "0x3ABA750", VA = "0x183ABB550")]
	public static IDisposable KFMNGOEOFAB(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB820", Offset = "0x3ABAA20", VA = "0x183ABB820")]
	public static IDisposable NHLFONOIJFI(this MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAD90", Offset = "0x3AB9F90", VA = "0x183ABAD90")]
	public static IDisposable AGNPJNAHNKC(this MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB460", Offset = "0x3ABA660", VA = "0x183ABB460")]
	public static IDisposable IMGFDLAMHOF(this MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAE80", Offset = "0x3ABA080", VA = "0x183ABAE80")]
	public static IDisposable BBEGKCBPGEI(this MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAEF0", Offset = "0x3ABA0F0", VA = "0x183ABAEF0")]
	public static IDisposable BLIGOKBOMFE(this MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB790", Offset = "0x3ABA990", VA = "0x183ABB790")]
	public static IDisposable MLGELCJHAJN(this MonoBehaviour ENJHMGAPNOH, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB2E0", Offset = "0x3ABA4E0", VA = "0x183ABB2E0")]
	public static IDisposable GPLHODFPKOF(this MonoBehaviour ENJHMGAPNOH, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAF60", Offset = "0x3ABA160", VA = "0x183ABAF60")]
	public static IDisposable CBNHNGKDPKG(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB3E0", Offset = "0x3ABA5E0", VA = "0x183ABB3E0")]
	public static IDisposable IGHNIIFGPHA(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB060", Offset = "0x3ABA260", VA = "0x183ABB060")]
	public static IDisposable CNLBDCEDBMP(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB160", Offset = "0x3ABA360", VA = "0x183ABB160")]
	public static IDisposable ECIPJBIEBAB(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAFE0", Offset = "0x3ABA1E0", VA = "0x183ABAFE0")]
	public static IDisposable CJMMLCLKJLM(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB360", Offset = "0x3ABA560", VA = "0x183ABB360")]
	public static IDisposable IENAAFKHIEO(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAD00", Offset = "0x3AB9F00", VA = "0x183ABAD00")]
	public static IDisposable AANFCJCJEEL(this MonoBehaviour ENJHMGAPNOH, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB710", Offset = "0x3ABA910", VA = "0x183ABB710")]
	public static IDisposable MBOODJNANAH(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB0E0", Offset = "0x3ABA2E0", VA = "0x183ABB0E0")]
	public static IDisposable DCLEOIBAHFP(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAE00", Offset = "0x3ABA000", VA = "0x183ABAE00")]
	public static IDisposable AMCCNNIOOOF(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB890", Offset = "0x3ABAA90", VA = "0x183ABB890")]
	public static IDisposable ONKADICCJOO(this MonoBehaviour ENJHMGAPNOH, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB920", Offset = "0x3ABAB20", VA = "0x183ABB920")]
	public static IDisposable PAHJIADPOMB(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB260", Offset = "0x3ABA460", VA = "0x183ABB260")]
	public static IDisposable ELBOJCAMFLD(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB1E0", Offset = "0x3ABA3E0", VA = "0x183ABB1E0")]
	public static IDisposable EIKJFKIIMNL(this MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OOPINCKFLDM
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EKBMNGIIFFB : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public LGLLNDHNEFG.JPHGAKGBNOB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private FJKKOIGIDJM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public EKBMNGIIFFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1C50", Offset = "0x3AB0E50", VA = "0x183AB1C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1D20", Offset = "0x3AB0F20", VA = "0x183AB1D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class GBJANMEHJFH : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public LGLLNDHNEFG.JPHGAKGBNOB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private FJKKOIGIDJM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public GBJANMEHJFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4B20", Offset = "0x3AB3D20", VA = "0x183AB4B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4C10", Offset = "0x3AB3E10", VA = "0x183AB4C10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC060", Offset = "0x3ABB260", VA = "0x183ABC060")]
	public static PCKAMDGBNHA KFMNGOEOFAB(Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBF70", Offset = "0x3ABB170", VA = "0x183ABBF70")]
	public static PCKAMDGBNHA KFMNGOEOFAB(Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC150", Offset = "0x3ABB350", VA = "0x183ABC150")]
	public static PCKAMDGBNHA KFMNGOEOFAB(Behaviour OEIFFOBMIEM, Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC260", Offset = "0x3ABB460", VA = "0x183ABC260")]
	public static PCKAMDGBNHA KFMNGOEOFAB(Behaviour OEIFFOBMIEM, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC370", Offset = "0x3ABB570", VA = "0x183ABC370")]
	public static PCKAMDGBNHA LKLNEDCHAIE(LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC480", Offset = "0x3ABB680", VA = "0x183ABC480")]
	public static PCKAMDGBNHA LKLNEDCHAIE(LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBF00", Offset = "0x3ABB100", VA = "0x183ABBF00")]
	[IteratorStateMachine(typeof(EKBMNGIIFFB))]
	private static IEnumerator<EJFBNPFIIDA> AMIJKEPCEHM(LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC, Action BCFKOFKMLOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBE90", Offset = "0x3ABB090", VA = "0x183ABBE90")]
	[IteratorStateMachine(typeof(GBJANMEHJFH))]
	private static IEnumerator<EJFBNPFIIDA> AMIJKEPCEHM(LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC, Action<float> BCFKOFKMLOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class IBBIFIJAODC
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class MCNABDPMPKN : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public LGLLNDHNEFG.JPHGAKGBNOB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private ELFJOEKOCJP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public MCNABDPMPKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3ABABC0", Offset = "0x3AB9DC0", VA = "0x183ABABC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3ABACB0", Offset = "0x3AB9EB0", VA = "0x183ABACB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB78E0", Offset = "0x3AB6AE0", VA = "0x183AB78E0")]
	public static PCKAMDGBNHA KFMNGOEOFAB(float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7820", Offset = "0x3AB6A20", VA = "0x183AB7820")]
	public static PCKAMDGBNHA KFMNGOEOFAB(MonoBehaviour ENJHMGAPNOH, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7760", Offset = "0x3AB6960", VA = "0x183AB7760")]
	public static PCKAMDGBNHA JEBJHDHIPJD(LAKFLIJDBCL OEIFFOBMIEM, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB76E0", Offset = "0x3AB68E0", VA = "0x183AB76E0")]
	[IteratorStateMachine(typeof(MCNABDPMPKN))]
	private static IEnumerator<EJFBNPFIIDA> AMIJKEPCEHM(float EABCGAPJPIJ, LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC, Action<float> BCFKOFKMLOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KLANADDMBEB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JFJOENAELFC : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public LGLLNDHNEFG.JPHGAKGBNOB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public JFJOENAELFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3AB88E0", Offset = "0x3AB7AE0", VA = "0x183AB88E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8980", Offset = "0x3AB7B80", VA = "0x183AB8980", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8F80", Offset = "0x3AB8180", VA = "0x183AB8F80")]
	[IteratorStateMachine(typeof(JFJOENAELFC))]
	private static IEnumerator<EJFBNPFIIDA> EPFLBNOOLEO(LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM, Func<bool> DAGMGEMNINN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8FF0", Offset = "0x3AB81F0", VA = "0x183AB8FF0")]
	public static PCKAMDGBNHA HPFPGNGKOFH(this MonoBehaviour ENJHMGAPNOH, Func<bool> DAGMGEMNINN, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM = LGLLNDHNEFG.JPHGAKGBNOB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IEKDEIFLBFN
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class FGGBNGGLABC : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LGLLNDHNEFG.JPHGAKGBNOB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public FGGBNGGLABC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2890", Offset = "0x3AB1A90", VA = "0x183AB2890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2940", Offset = "0x3AB1B40", VA = "0x183AB2940", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BCKBINKJFNC : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LGLLNDHNEFG.JPHGAKGBNOB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private EJFBNPFIIDA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public BCKBINKJFNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD620", Offset = "0x3AAC820", VA = "0x183AAD620", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD6E0", Offset = "0x3AAC8E0", VA = "0x183AAD6E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8480", Offset = "0x3AB7680", VA = "0x183AB8480")]
	[IteratorStateMachine(typeof(FGGBNGGLABC))]
	private static IEnumerator<EJFBNPFIIDA> LPJGEJFJGJA(float PNMIPKLLCIL, LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8620", Offset = "0x3AB7820", VA = "0x183AB8620")]
	[IteratorStateMachine(typeof(BCKBINKJFNC))]
	private static IEnumerator<EJFBNPFIIDA> MKEIJNCJMJH(float PNMIPKLLCIL, LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7DA0", Offset = "0x3AB6FA0", VA = "0x183AB7DA0")]
	public static IDisposable COKJGGCJIAF(this MonoBehaviour ENJHMGAPNOH, float PNMIPKLLCIL, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7EE0", Offset = "0x3AB70E0", VA = "0x183AB7EE0")]
	public static PCKAMDGBNHA DDOKHDDDDFH(this MonoBehaviour ENJHMGAPNOH, float PNMIPKLLCIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7C50", Offset = "0x3AB6E50", VA = "0x183AB7C50")]
	public static PCKAMDGBNHA COKJGGCJIAF(this MonoBehaviour ENJHMGAPNOH, float PNMIPKLLCIL, LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8500", Offset = "0x3AB7700", VA = "0x183AB8500")]
	public static PCKAMDGBNHA LPMILNOEOPB(this MonoBehaviour ENJHMGAPNOH, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8020", Offset = "0x3AB7220", VA = "0x183AB8020")]
	public static PCKAMDGBNHA DHPDGMCBHGC(this MonoBehaviour ENJHMGAPNOH, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7C30", Offset = "0x3AB6E30", VA = "0x183AB7C30")]
	public static PCKAMDGBNHA BAJJLDOCONA(this MonoBehaviour ENJHMGAPNOH, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7C40", Offset = "0x3AB6E40", VA = "0x183AB7C40")]
	public static PCKAMDGBNHA BLCFEDJAHBI(this MonoBehaviour ENJHMGAPNOH, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8470", Offset = "0x3AB7670", VA = "0x183AB8470")]
	public static PCKAMDGBNHA KHKDGDMDCIP(this MonoBehaviour ENJHMGAPNOH, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8510", Offset = "0x3AB7710", VA = "0x183AB8510")]
	private static PCKAMDGBNHA MHEABJGIFGL(MonoBehaviour ENJHMGAPNOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8250", Offset = "0x3AB7450", VA = "0x183AB8250")]
	public static PCKAMDGBNHA GPPNJINOKAO(this MonoBehaviour ENJHMGAPNOH, float DJJEPPNMKNA, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8140", Offset = "0x3AB7340", VA = "0x183AB8140")]
	public static PCKAMDGBNHA EIOJBEDBNCD(this MonoBehaviour ENJHMGAPNOH, float DJJEPPNMKNA, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8030", Offset = "0x3AB7230", VA = "0x183AB8030")]
	public static PCKAMDGBNHA DPOOGNAOCCL(this MonoBehaviour ENJHMGAPNOH, float DJJEPPNMKNA, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8360", Offset = "0x3AB7560", VA = "0x183AB8360")]
	public static PCKAMDGBNHA HEILNAEBBLB(this MonoBehaviour ENJHMGAPNOH, float DJJEPPNMKNA, Action MFMMHKIFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3AB86A0", Offset = "0x3AB78A0", VA = "0x183AB86A0")]
	public static PCKAMDGBNHA PMCDELAIBEN(this MonoBehaviour ENJHMGAPNOH, float DJJEPPNMKNA, Action MFMMHKIFPMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HAAOBALIMBJ : IAAHFIOGLGH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BNMHLBBKNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HAAOBALIMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public BNMHLBBKNJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE010", Offset = "0x3AAD210", VA = "0x183AAE010")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FDMBDJHADFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HAAOBALIMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
		public FDMBDJHADFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE010", Offset = "0x3AAD210", VA = "0x183AAE010")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float EPPKJKLNCGD;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5450", Offset = "0x3AB4650", VA = "0x183AB5450")]
	public HAAOBALIMBJ(Behaviour OEIFFOBMIEM, float EPPKJKLNCGD, [Optional] Action IFMPBLGJHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5380", Offset = "0x3AB4580", VA = "0x183AB5380", Slot = "9")]
	protected override bool PBFDLFFELJN(Action EPNGAEBBFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB52B0", Offset = "0x3AB44B0", VA = "0x183AB52B0", Slot = "10")]
	protected override bool OAINHIEHLBN(Action EPNGAEBBFEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ALNBMKCFLBN
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool DLPHMDPJOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CHKAIHOOCDA;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNJBJPCDHMD(bool MHAEGJDNDMO = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DNJBJPCDHMD(Action EPNGAEBBFEF, bool MHAEGJDNDMO = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class IAAHFIOGLGH : ALNBMKCFLBN
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class BLADDBDBGAG : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public BLADDBDBGAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3AADE30", Offset = "0x3AAD030", VA = "0x183AADE30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3AADED0", Offset = "0x3AAD0D0", VA = "0x183AADED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour OEIFFOBMIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action IFMPBLGJHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private CFDBJADAECP FBIGOCFHJFP;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool DLPHMDPJOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x820810", Offset = "0x81FA10", VA = "0x180820810", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CHKAIHOOCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3AB7640", Offset = "0x3AB6840", VA = "0x183AB7640", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AB74B0", Offset = "0x3AB66B0", VA = "0x183AB74B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2156D60", Offset = "0x2155F60", VA = "0x182156D60")]
	protected IAAHFIOGLGH(Behaviour OEIFFOBMIEM, [Optional] Action IFMPBLGJHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7280", Offset = "0x3AB6480", VA = "0x183AB7280", Slot = "7")]
	public bool DNJBJPCDHMD(bool MHAEGJDNDMO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7230", Offset = "0x3AB6430", VA = "0x183AB7230", Slot = "8")]
	public bool DNJBJPCDHMD(Action EPNGAEBBFEF, bool MHAEGJDNDMO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool PBFDLFFELJN(Action EPNGAEBBFEF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool OAINHIEHLBN(Action EPNGAEBBFEF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7550", Offset = "0x3AB6750", VA = "0x183AB7550")]
	protected void GHHFONEHGDG(Action EPNGAEBBFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AB72E0", Offset = "0x3AB64E0", VA = "0x183AB72E0")]
	protected FIIDGPMBKPK DNPGLBEOJAA(float GKDEEFGNLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3AB75D0", Offset = "0x3AB67D0", VA = "0x183AB75D0")]
	private void NLACEMGPIFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7570", Offset = "0x3AB6770", VA = "0x183AB7570")]
	[IteratorStateMachine(typeof(BLADDBDBGAG))]
	private static IEnumerator<EJFBNPFIIDA> KMBHLIJCKNH(float GKDEEFGNLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7210", Offset = "0x3AB6410", VA = "0x183AB7210")]
	[CompilerGenerated]
	private void AAEFIPGOMGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class PNMJADOLPPB : IAAHFIOGLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float EIGGDKJFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int CEKDDEMICGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float DOMBNAMGEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] HGKBJIHGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int EOLHPDMILHN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ACLGOBNDAKI DALAOGJMEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x44C670", Offset = "0x44B870", VA = "0x18044C670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x514DD0", Offset = "0x513FD0", VA = "0x180514DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC880", Offset = "0x3ABBA80", VA = "0x183ABC880")]
	public PNMJADOLPPB(Behaviour OEIFFOBMIEM, float GALJBKDIFAK, int CEKDDEMICGG, [Optional] Action IFMPBLGJHAJ, float DOMBNAMGEPF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x425E40", Offset = "0x425040", VA = "0x180425E40", Slot = "9")]
	protected override bool PBFDLFFELJN(Action EPNGAEBBFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC660", Offset = "0x3ABB860", VA = "0x183ABC660", Slot = "10")]
	protected override bool OAINHIEHLBN(Action EPNGAEBBFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC5D0", Offset = "0x3ABB7D0", VA = "0x183ABC5D0")]
	private void DFDEBAAFHCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PCNDPJEGAIC : IAAHFIOGLGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float EPPKJKLNCGD;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3AB5450", Offset = "0x3AB4650", VA = "0x183AB5450")]
	public PCNDPJEGAIC(Behaviour OEIFFOBMIEM, float EPPKJKLNCGD, [Optional] Action IFMPBLGJHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x425E40", Offset = "0x425040", VA = "0x180425E40", Slot = "9")]
	protected override bool PBFDLFFELJN(Action EPNGAEBBFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC590", Offset = "0x3ABB790", VA = "0x183ABC590", Slot = "10")]
	protected override bool OAINHIEHLBN(Action EPNGAEBBFEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class DJBBEBAHHBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GGAHANNPAHE : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public GGAHANNPAHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4C60", Offset = "0x3AB3E60", VA = "0x183AB4C60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3AB4D50", Offset = "0x3AB3F50", VA = "0x183AB4D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private PCKAMDGBNHA KIEPAEALOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private LAKFLIJDBCL OEIFFOBMIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action BCFKOFKMLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> OMPCFLCHOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float JFMPLEMMMOE;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3AB17B0", Offset = "0x3AB09B0", VA = "0x183AB17B0")]
	public DJBBEBAHHBO(LAKFLIJDBCL OEIFFOBMIEM, Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1940", Offset = "0x3AB0B40", VA = "0x183AB1940")]
	public DJBBEBAHHBO(LAKFLIJDBCL OEIFFOBMIEM, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1660", Offset = "0x3AB0860", VA = "0x183AB1660")]
	public DJBBEBAHHBO(LAKFLIJDBCL OEIFFOBMIEM, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB12E0", Offset = "0x3AB04E0", VA = "0x183AB12E0")]
	private void KFMNGOEOFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1160", Offset = "0x3AB0360", VA = "0x183AB1160")]
	private void HOGEHDBGCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1030", Offset = "0x3AB0230", VA = "0x183AB1030")]
	private void FJPDJOEIBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1460", Offset = "0x3AB0660", VA = "0x183AB1460")]
	private void LAGIACAIAGD(string CJNIHHAKCLL, Action DDAMJEOBFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1580", Offset = "0x3AB0780", VA = "0x183AB1580")]
	[IteratorStateMachine(typeof(GGAHANNPAHE))]
	private IEnumerator<EJFBNPFIIDA> LFPGEFBALEF(Action DDAMJEOBFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0FE0", Offset = "0x3AB01E0", VA = "0x183AB0FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0F60", Offset = "0x3AB0160", VA = "0x183AB0F60")]
	[CompilerGenerated]
	private void DNLPIHFMIBJ(string MELPNJNHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3AB0EE0", Offset = "0x3AB00E0", VA = "0x183AB0EE0")]
	[CompilerGenerated]
	private void CIJBFOCJOFJ(string MELPNJNHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3AB15E0", Offset = "0x3AB07E0", VA = "0x183AB15E0")]
	[CompilerGenerated]
	private void NOOGHOLAPPK(string MELPNJNHLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class LIAOACGPNBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class OLFKKEDMPPK : IEnumerator<EJFBNPFIIDA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EJFBNPFIIDA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private EJFBNPFIIDA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
		[DebuggerHidden]
		public OLFKKEDMPPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3ABBD50", Offset = "0x3ABAF50", VA = "0x183ABBD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x3ABBE40", Offset = "0x3ABB040", VA = "0x183ABBE40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private PCKAMDGBNHA KIEPAEALOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour ENJHMGAPNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action BCFKOFKMLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> OMPCFLCHOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float JFMPLEMMMOE;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA070", Offset = "0x3AB9270", VA = "0x183ABA070")]
	public LIAOACGPNBN(MonoBehaviour ENJHMGAPNOH, Action BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA200", Offset = "0x3AB9400", VA = "0x183ABA200")]
	public LIAOACGPNBN(MonoBehaviour ENJHMGAPNOH, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3ABA390", Offset = "0x3AB9590", VA = "0x183ABA390")]
	public LIAOACGPNBN(MonoBehaviour ENJHMGAPNOH, float EABCGAPJPIJ, Action<float> BCFKOFKMLOH, LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9CF0", Offset = "0x3AB8EF0", VA = "0x183AB9CF0")]
	private void KFMNGOEOFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9B70", Offset = "0x3AB8D70", VA = "0x183AB9B70")]
	private void HOGEHDBGCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9A40", Offset = "0x3AB8C40", VA = "0x183AB9A40")]
	private void FJPDJOEIBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9E70", Offset = "0x3AB9070", VA = "0x183AB9E70")]
	private void LAGIACAIAGD(string CJNIHHAKCLL, Action DDAMJEOBFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9F90", Offset = "0x3AB9190", VA = "0x183AB9F90")]
	[IteratorStateMachine(typeof(OLFKKEDMPPK))]
	private IEnumerator<EJFBNPFIIDA> LFPGEFBALEF(Action DDAMJEOBFHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3AB99F0", Offset = "0x3AB8BF0", VA = "0x183AB99F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9970", Offset = "0x3AB8B70", VA = "0x183AB9970")]
	[CompilerGenerated]
	private void DNLPIHFMIBJ(string MELPNJNHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3AB98F0", Offset = "0x3AB8AF0", VA = "0x183AB98F0")]
	[CompilerGenerated]
	private void CIJBFOCJOFJ(string MELPNJNHLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9FF0", Offset = "0x3AB91F0", VA = "0x183AB9FF0")]
	[CompilerGenerated]
	private void NOOGHOLAPPK(string MELPNJNHLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ECACBDEGNGL
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int JHPFAKNNOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BNBOAFIPPBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly BNBOAFIPPBL IIPKFNJAKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action EIOHKDLPCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool NLJOHDMIPJO;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x511D10", Offset = "0x510F10", VA = "0x180511D10")]
	public BNBOAFIPPBL(Action EIOHKDLPCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3AADF20", Offset = "0x3AAD120", VA = "0x183AADF20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GAICJKKAOMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T NBLACJEKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LNKDNEKJAIA(Action<T> CPAMGMKIGHJ);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable LNKDNEKJAIA(UnityEngine.Object OEIFFOBMIEM, Action<T> CPAMGMKIGHJ);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EAHICFOHMGP<T> : global::GAICJKKAOMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T NBLACJEKEDC
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
public class JEMBCFAADEC<T> : global::EAHICFOHMGP<T>, global::GAICJKKAOMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NOFFGPKCKHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::JEMBCFAADEC<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::CIGAGOPKJGJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x179F430", Offset = "0x179E630", VA = "0x18179F430")]
		public NOFFGPKCKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x24A9280", Offset = "0x24A8480", VA = "0x1824A9280")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject HHJKDIKKIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::CIGAGOPKJGJ<UnityEngine.Object, Action<T>>> IIEDELNOLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T OGLCHKPKKHG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object FKIFDOFEDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x249DF50", Offset = "0x249D150", VA = "0x18249DF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T NBLACJEKEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5B1F60", Offset = "0x5B1160", VA = "0x1805B1F60", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x249E200", Offset = "0x249D400", VA = "0x18249E200", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x249E8D0", Offset = "0x249DAD0", VA = "0x18249E8D0")]
	private static bool KPEFEMNKLCL(T MNGFDMNFCAK, T EELHLJKEFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x249ECC0", Offset = "0x249DEC0", VA = "0x18249ECC0")]
	public JEMBCFAADEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x249ECF0", Offset = "0x249DEF0", VA = "0x18249ECF0")]
	public JEMBCFAADEC(T KCLDEMEKKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x249E160", Offset = "0x249D360", VA = "0x18249E160")]
	public void CFJOKEJKKCJ(T MJFLDBGDCNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x249EA80", Offset = "0x249DC80", VA = "0x18249EA80", Slot = "7")]
	public IDisposable LNKDNEKJAIA(Action<T> CPAMGMKIGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x249EAF0", Offset = "0x249DCF0", VA = "0x18249EAF0", Slot = "8")]
	public IDisposable LNKDNEKJAIA(UnityEngine.Object OEIFFOBMIEM, Action<T> CPAMGMKIGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x249E580", Offset = "0x249D780", VA = "0x18249E580")]
	private void IFDALHGCOKF()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<LBKAFKFLEKF, Scheduler>, LBKAFKFLEKF
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class JLIDICHGDNC : ECACBDEGNGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public FHBENNEFGCO EMPFAFLONLN;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int JHPFAKNNOMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x425E50", Offset = "0x425050", VA = "0x180425E50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x425E60", Offset = "0x425060", VA = "0x180425E60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8A90", Offset = "0x3AB7C90", VA = "0x183AB8A90")]
			public static EJFBNPFIIDA FPGIFMFKJCC(IEnumerator<EJFBNPFIIDA> JGNPBDAPHAC, OAPNMAHHJHM IHBPKCCLLJG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8BF0", Offset = "0x3AB7DF0", VA = "0x183AB8BF0")]
			public EJFBNPFIIDA FPGIFMFKJCC(OAPNMAHHJHM[] CKCGOABKINO, IEnumerator<EJFBNPFIIDA>[] LIKKEBBGAND, EJFBNPFIIDA[] MHLFHAGPFPB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8CC0", Offset = "0x3AB7EC0", VA = "0x183AB8CC0")]
			public void OPCHFINLJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8CF0", Offset = "0x3AB7EF0", VA = "0x183AB8CF0")]
			public void MGGOJJIBJDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3AB89D0", Offset = "0x3AB7BD0", VA = "0x183AB89D0")]
			public void DBIKFOBHLPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8CC0", Offset = "0x3AB7EC0", VA = "0x183AB8CC0")]
			public void JAOLKNKLKKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
			public JLIDICHGDNC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class FHBENNEFGCO
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct IMIJEGDBMDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public JLIDICHGDNC EPMCEPPGFNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public LAKFLIJDBCL CJBJGEMIPHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public OAPNMAHHJHM EKAHKONEBMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<EJFBNPFIIDA> JDBBKNEOJPC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public EJFBNPFIIDA MCJLHLACOBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public PAKGIJNGIDP MDLAODJKAHI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct HMLPNFEDOGJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public LGLLNDHNEFG.JPHGAKGBNOB GMLHNOBOCAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<IMIJEGDBMDN> MKCJHAPDEDN;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class CBNGOOCIJJO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public FHBENNEFGCO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public LAKFLIJDBCL context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public JLIDICHGDNC routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public PAKGIJNGIDP coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public OAPNMAHHJHM promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public EJFBNPFIIDA currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<EJFBNPFIIDA> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
				public CBNGOOCIJJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x3AAE410", Offset = "0x3AAD610", VA = "0x183AAE410")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class NBHBJLBKLED
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public JLIDICHGDNC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public FHBENNEFGCO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
				public NBHBJLBKLED()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x3ABB9A0", Offset = "0x3ABABA0", VA = "0x183ABB9A0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class LEKCNEJIHCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public JLIDICHGDNC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public FHBENNEFGCO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
				public LEKCNEJIHCB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x3AB9710", Offset = "0x3AB8910", VA = "0x183AB9710")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class KEDMDJFAIKG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public JLIDICHGDNC schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public FHBENNEFGCO <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
				public KEDMDJFAIKG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x3AB8DB0", Offset = "0x3AB7FB0", VA = "0x183AB8DB0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] HPLDOJKHALA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<PAKGIJNGIDP> HKLMOENLOGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> GLIFFJFEBHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> LJMGKJKHHCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> DDNEEINJDAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> PLDJMIKOPEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> EJGBHNIOFPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> HHNKGMIIOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private JLIDICHGDNC[] HJKIOPHCOND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private OAPNMAHHJHM[] CKCGOABKINO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private LAKFLIJDBCL[] GKIGKPJGJJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<EJFBNPFIIDA>[] NBEKNPDIPNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private EJFBNPFIIDA[] PLJEOKPGBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int FBKDPPNKOCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int CENKHLNGHOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int IGLPHKDKHAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float OCHCMHKFBOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private DDPIKBBBBNM FNKIKNMDCPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle IMGELKFOCEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<JLIDICHGDNC> HHDMPMGHPKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool AEKCOJBFGBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> AOJGFBPGHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> IAJOJAGEOPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool FKLLOGGIEPH;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public HMLPNFEDOGJ[] LHHMIOOMFFE
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x6A28C0", Offset = "0x6A1AC0", VA = "0x1806A28C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int JJHIACFMEIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x8B49B0", Offset = "0x8B3BB0", VA = "0x1808B49B0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3ED0", Offset = "0x3AB30D0", VA = "0x183AB3ED0")]
			private static int LLDKOHKAMPO(LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4650", Offset = "0x3AB3850", VA = "0x183AB4650")]
			public FHBENNEFGCO(LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3D40", Offset = "0x3AB2F40", VA = "0x183AB3D40")]
			private void LJAJABJOJGI(ref int NHPNPBONDHP, int HOJPMALKJGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3330", Offset = "0x3AB2530", VA = "0x183AB3330")]
			public void EPBAJOIEFLN(LAKFLIJDBCL OEIFFOBMIEM, EJFBNPFIIDA IGOBGPJPOLK, IEnumerator<EJFBNPFIIDA> JGNPBDAPHAC, OAPNMAHHJHM IHBPKCCLLJG, [Optional] JLIDICHGDNC JLCPAJCPCOK, PAKGIJNGIDP JNMCKGMGDFP = PAKGIJNGIDP.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3F00", Offset = "0x3AB3100", VA = "0x183AB3F00")]
			public void MPDCAGOLBKA(IEnumerable<IMIJEGDBMDN> HABNKFJLGIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3AB34E0", Offset = "0x3AB26E0", VA = "0x183AB34E0")]
			private IMIJEGDBMDN GLIJPIOIMMK(int LIFMMCLOBAP)
			{
				return default(IMIJEGDBMDN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x3AB2ED0", Offset = "0x3AB20D0", VA = "0x183AB2ED0")]
			private void BNFINEJKFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1995A50", Offset = "0x1994C50", VA = "0x181995A50")]
			private static void HPBNPJJCDCH<T>(int LIFMMCLOBAP, T[] NMMAMOEMLOA, int GINDFGEIJMJ, [Optional] T KGAHDAEGEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1995A30", Offset = "0x1994C30", VA = "0x181995A30")]
			private static void HPBNPJJCDCH<T>(int LIFMMCLOBAP, NativeArray<T> NMMAMOEMLOA, int GINDFGEIJMJ, [Optional] T KGAHDAEGEHN) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3AA0", Offset = "0x3AB2CA0", VA = "0x183AB3AA0")]
			private void KJHALDHFDJF(IEnumerable<IMIJEGDBMDN> HABNKFJLGIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3AB4590", Offset = "0x3AB3790", VA = "0x183AB4590")]
			private void PLNCJPFAIPH(IMIJEGDBMDN MEDLAIGMJKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x3AB2C30", Offset = "0x3AB1E30", VA = "0x183AB2C30")]
			private GCENPLPPOOM BKJJGJFJOON(int MHELICFAMDK)
			{
				return default(GCENPLPPOOM);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x3AB2990", Offset = "0x3AB1B90", VA = "0x183AB2990")]
			public void AEMLPLCGFIA(float EKGBCMAPMGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3460", Offset = "0x3AB2660", VA = "0x183AB3460")]
			private void FFIPKKCLCMG(Action MNGFDMNFCAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3200", Offset = "0x3AB2400", VA = "0x183AB3200")]
			private void CHBHKOHJCJG(Action MNGFDMNFCAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x3AB40F0", Offset = "0x3AB32F0", VA = "0x183AB40F0")]
			public void OJGBAGIMPAE(float EKGBCMAPMGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3910", Offset = "0x3AB2B10", VA = "0x183AB3910")]
			public void IILOAGJDJIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x3AB39F0", Offset = "0x3AB2BF0", VA = "0x183AB39F0")]
			public void JAOLKNKLKKF(JLIDICHGDNC GMMKJODGLPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x3AB3280", Offset = "0x3AB2480", VA = "0x183AB3280")]
			public void ELBNNJPMEDF(JLIDICHGDNC GMMKJODGLPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x3AB2B80", Offset = "0x3AB1D80", VA = "0x183AB2B80")]
			public void AENNLFEPINP(JLIDICHGDNC GMMKJODGLPG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct DDPIKBBBBNM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float JLGPOAHJMAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int MBDOPJDPNHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> FMANLGJDKJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> FLCKFEDEJFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> NPENMEICGCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<PAKGIJNGIDP> OAEAADHMLPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> PCAJHKMAFJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> PLDJMIKOPEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> LJMGKJKHHCC;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0950", Offset = "0x3AAFB50", VA = "0x183AB0950")]
			public static DDPIKBBBBNM AEKPMIMCBBN(int EJEPBLBOBMC, float EKGBCMAPMGJ, NativeArray<PAKGIJNGIDP> JKCDKFNDKFD, NativeArray<float> DPDCDIHBOJM, NativeArray<int> DJKEAOKJBIO, NativeArray<int> PIJJACFCMMA, NativeArray<int> DOAALMBCCIB, NativeArray<int> FLCKFEDEJFD, NativeArray<int> NPENMEICGCF)
			{
				return default(DDPIKBBBBNM);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0CC0", Offset = "0x3AAFEC0", VA = "0x183AB0CC0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0A20", Offset = "0x3AAFC20", VA = "0x183AB0A20")]
			private bool AEOEMNMFPOE(int GKLPGEBNHCO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0C90", Offset = "0x3AAFE90", VA = "0x183AB0C90")]
			private void DIBHAOHKOMG(NativeArray<int> GOGCAGMDACF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0DA0", Offset = "0x3AAFFA0", VA = "0x183AB0DA0")]
			private int FBNCKKOBJIF(int NKHDHLINDJF, int HNAPFLMMAKA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0E10", Offset = "0x3AB0010", VA = "0x183AB0E10")]
			private void HHFMOJGGOCB(NativeArray<int> GOGCAGMDACF, int ENHDBGOLKEI, int IILNJJCOHOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0A60", Offset = "0x3AAFC60", VA = "0x183AB0A60")]
			private void BGMLHKMDOFL(NativeArray<int> GOGCAGMDACF, int KMOFGIIDDLF, int GKGLCEHEBAA, int DLMNJNCHOIL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class KOEJIKPPIKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly OAPNMAHHJHM IHBPKCCLLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour OEIFFOBMIEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool MNECADOGFBP;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<EJFBNPFIIDA> JDBBKNEOJPC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4251A0", Offset = "0x4243A0", VA = "0x1804251A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x425440", Offset = "0x424640", VA = "0x180425440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public EJFBNPFIIDA MCJLHLACOBD
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x425450", Offset = "0x424650", VA = "0x180425450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool IAEMDNMILNC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x3AB9350", Offset = "0x3AB8550", VA = "0x183AB9350")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool PMEGDCJDLBI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x6236B0", Offset = "0x6228B0", VA = "0x1806236B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1BE4250", Offset = "0x1BE3450", VA = "0x181BE4250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string NIGNPLIEFKI
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x425F90", Offset = "0x425190", VA = "0x180425F90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x425FA0", Offset = "0x4251A0", VA = "0x180425FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float DOMJJFGEFLI
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xEF4A20", Offset = "0xEF3C20", VA = "0x180EF4A20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xEF4CF0", Offset = "0xEF3EF0", VA = "0x180EF4CF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9590", Offset = "0x3AB8790", VA = "0x183AB9590")]
			public KOEJIKPPIKB(IEnumerator<EJFBNPFIIDA> JGNPBDAPHAC, Behaviour OEIFFOBMIEM, OAPNMAHHJHM IHBPKCCLLJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9140", Offset = "0x3AB8340", VA = "0x183AB9140")]
			public EJFBNPFIIDA FPGIFMFKJCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3AB93E0", Offset = "0x3AB85E0", VA = "0x183AB93E0")]
			public bool IIDJIHLAFJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9470", Offset = "0x3AB8670", VA = "0x183AB9470")]
			public void JAOLKNKLKKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB9500", Offset = "0x3AB8700", VA = "0x183AB9500", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x14B3B30", Offset = "0x14B2D30", VA = "0x1814B3B30")]
			[CompilerGenerated]
			private void BKIKMOEIPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class OAPNMAHHJHM : GMFMPCJHACA, PCKAMDGBNHA, CFDBJADAECP, FIIDGPMBKPK, IEnumerator, EJFBNPFIIDA, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private LGLLNDHNEFG.JPHGAKGBNOB ELPMOKMJAEG;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private LGLLNDHNEFG.JPHGAKGBNOB NDCKLDCOEMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x449290", Offset = "0x448490", VA = "0x180449290", Slot = "23")]
				get
				{
					return default(LGLLNDHNEFG.JPHGAKGBNOB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public LGLLNDHNEFG.JPHGAKGBNOB EMPFAFLONLN
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x449290", Offset = "0x448490", VA = "0x180449290")]
				get
				{
					return default(LGLLNDHNEFG.JPHGAKGBNOB);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x5D65B0", Offset = "0x5D57B0", VA = "0x1805D65B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float NMHACIBOKDB
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xBA1340", Offset = "0xBA0540", VA = "0x180BA1340", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x3ABBB70", Offset = "0x3ABAD70", VA = "0x183ABBB70", Slot = "24")]
			private bool BLAEEOOCGAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3ABBB90", Offset = "0x3ABAD90", VA = "0x183ABBB90", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3ABBBA0", Offset = "0x3ABADA0", VA = "0x183ABBBA0")]
			public OAPNMAHHJHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum GCENPLPPOOM : byte
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
		private sealed class HIHFAAOCNGM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum KAHMKLBMEOB
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct DHLNPKPFKEK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public LGLLNDHNEFG.JPHGAKGBNOB GMLHNOBOCAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public KAHMKLBMEOB DLMGLLLCDDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<KOEJIKPPIKB> FGJIIMLCPNE;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly KAHMKLBMEOB[] HLDCJBCKBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly LGLLNDHNEFG.JPHGAKGBNOB DJKIPFBMEFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool JCPOFCGGDJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly KOEJIKPPIKB[] BLOGBKMMEHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<KOEJIKPPIKB> PEBLKNJMPLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> PPBKDNMDPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<KOEJIKPPIKB> DLBFHNEPLIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> CIEEBPOOKMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool FKLLOGGIEPH;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public DHLNPKPFKEK[,] KPMKEICDIBI
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x438470", Offset = "0x437670", VA = "0x180438470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int JJHIACFMEIJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x3AB6570", Offset = "0x3AB5770", VA = "0x183AB6570")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3AB6A90", Offset = "0x3AB5C90", VA = "0x183AB6A90")]
			public HIHFAAOCNGM(LGLLNDHNEFG.JPHGAKGBNOB MCPHJACDEHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5FA0", Offset = "0x3AB51A0", VA = "0x183AB5FA0")]
			public void EKKPEJPKKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5640", Offset = "0x3AB4840", VA = "0x183AB5640")]
			public void AFKEHDJGPID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5650", Offset = "0x3AB4850", VA = "0x183AB5650")]
			private void AHEGBLPNACA(IReadOnlyList<KOEJIKPPIKB> LKKFEAOEJOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x3AB68C0", Offset = "0x3AB5AC0", VA = "0x183AB68C0")]
			public void PFBEMLLNGPC(KOEJIKPPIKB JGNPBDAPHAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5AF0", Offset = "0x3AB4CF0", VA = "0x183AB5AF0")]
			public void DGKHFEAKGIM(IList<KOEJIKPPIKB> LIKKEBBGAND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x3AB6240", Offset = "0x3AB5440", VA = "0x183AB6240")]
			public void GOGPIFJDMJB(IList<KOEJIKPPIKB> LIKKEBBGAND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5EB0", Offset = "0x3AB50B0", VA = "0x183AB5EB0")]
			private void EJLJGHEPKKC(KOEJIKPPIKB JGNPBDAPHAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5FB0", Offset = "0x3AB51B0", VA = "0x183AB5FB0")]
			private void ELNNCKJCECM(IList<KOEJIKPPIKB> LIKKEBBGAND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5970", Offset = "0x3AB4B70", VA = "0x183AB5970")]
			private GCENPLPPOOM CJELNAGJGFP(KOEJIKPPIKB JGNPBDAPHAC)
			{
				return default(GCENPLPPOOM);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3AB64C0", Offset = "0x3AB56C0", VA = "0x183AB64C0")]
			public void NHLFONOIJFI(float EKGBCMAPMGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5770", Offset = "0x3AB4970", VA = "0x183AB5770")]
			public void CGJDBBHOLFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x3AB66E0", Offset = "0x3AB58E0", VA = "0x183AB66E0")]
			private void OFJKLKOIDOL(List<KOEJIKPPIKB> LIKKEBBGAND, Stack<int> IHGFEGJDGGF, bool OKFKCGGNCKJ, float BCGAONIDBNH = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x3AB5D70", Offset = "0x3AB4F70", VA = "0x183AB5D70", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x3AB6120", Offset = "0x3AB5320", VA = "0x183AB6120")]
			private void GIILMPAILAF(List<KOEJIKPPIKB> LIKKEBBGAND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum PAKGIJNGIDP : byte
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
		private sealed class EGLOCNJADKN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x425190", Offset = "0x424390", VA = "0x180425190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x510CF0", Offset = "0x50FEF0", VA = "0x180510CF0")]
			[DebuggerHidden]
			public EGLOCNJADKN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x425E00", Offset = "0x425000", VA = "0x180425E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x3AB1AD0", Offset = "0x3AB0CD0", VA = "0x183AB1AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3AB1B50", Offset = "0x3AB0D50", VA = "0x183AB1B50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const PAKGIJNGIDP ELOEMLGGHPD = PAKGIJNGIDP.Cancelled | PAKGIJNGIDP.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly LGLLNDHNEFG.JPHGAKGBNOB[] CNBBHIGAOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HIHFAAOCNGM[] HNGICPLCCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private FHBENNEFGCO[] DEAGJLHKMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine DFOAINCLLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame JAMFFMDJPJN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public LGLLNDHNEFG.JPHGAKGBNOB BFLLFKBPLHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4A90A0", Offset = "0x4A82A0", VA = "0x1804A90A0")]
			[CompilerGenerated]
			get
			{
				return default(LGLLNDHNEFG.JPHGAKGBNOB);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x52E770", Offset = "0x52D970", VA = "0x18052E770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GIDDCICOPKG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x6233B0", Offset = "0x6225B0", VA = "0x1806233B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x183B580", Offset = "0x183A780", VA = "0x18183B580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int JJHIACFMEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3ABE2E0", Offset = "0x3ABD4E0", VA = "0x183ABE2E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3ABCF80", Offset = "0x3ABC180", VA = "0x183ABCF80")]
		public static PCKAMDGBNHA GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABCAB0", Offset = "0x3ABBCB0", VA = "0x183ABCAB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD0E0", Offset = "0x3ABC2E0", VA = "0x183ABD0E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD0A0", Offset = "0x3ABC2A0", VA = "0x183ABD0A0")]
		private HIHFAAOCNGM ONJIDGCNAKN(LGLLNDHNEFG.JPHGAKGBNOB NBODGAKLJFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x66FF00", VA = "0x180670D00")]
		private FHBENNEFGCO HBKCMLECFCH(LGLLNDHNEFG.JPHGAKGBNOB NBODGAKLJFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD570", Offset = "0x3ABC770", VA = "0x183ABD570")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD540", Offset = "0x3ABC740", VA = "0x183ABD540")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE0D0", Offset = "0x3ABD2D0", VA = "0x183ABE0D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3ABCF60", Offset = "0x3ABC160", VA = "0x183ABCF60")]
		private void EKCAIDBNJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3ABCF50", Offset = "0x3ABC150", VA = "0x183ABCF50")]
		private void DNINOBJBFKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3ABCF70", Offset = "0x3ABC170", VA = "0x183ABCF70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD080", Offset = "0x3ABC280", VA = "0x183ABD080")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD090", Offset = "0x3ABC290", VA = "0x183ABD090")]
		private void MPCBEBIDDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD020", Offset = "0x3ABC220", VA = "0x183ABD020")]
		[IteratorStateMachine(typeof(EGLOCNJADKN))]
		private IEnumerator HDLOAODDEBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDBF0", Offset = "0x3ABCDF0", VA = "0x183ABDBF0", Slot = "7")]
		public PCKAMDGBNHA Run(IEnumerator<EJFBNPFIIDA> MKBJLJDLNIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD8D0", Offset = "0x3ABCAD0", VA = "0x183ABD8D0", Slot = "8")]
		public PCKAMDGBNHA Run(Behaviour OEIFFOBMIEM, IEnumerator<EJFBNPFIIDA> MKBJLJDLNIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD7A0", Offset = "0x3ABC9A0", VA = "0x183ABD7A0", Slot = "9")]
		public PCKAMDGBNHA RunJobbed(LAKFLIJDBCL OEIFFOBMIEM, IEnumerator<EJFBNPFIIDA> MKBJLJDLNIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABCEF0", Offset = "0x3ABC0F0", VA = "0x183ABCEF0", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABDC00", Offset = "0x3ABCE00", VA = "0x183ABDC00")]
		public void UpdateQueue(LGLLNDHNEFG.JPHGAKGBNOB JMBNPCINJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3ABD5E0", Offset = "0x3ABC7E0", VA = "0x183ABD5E0")]
		private void PIMFKLAJDFA(HIHFAAOCNGM MJEBEAHNIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC990", Offset = "0x3ABBB90", VA = "0x183ABC990")]
		private void AOAPFFDPDDD(FHBENNEFGCO MJEBEAHNIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE280", Offset = "0x3ABD480", VA = "0x183ABE280")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class KHPJFLNLBGG
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB8EF0", Offset = "0x3AB80F0", VA = "0x183AB8EF0")]
	[LKJOPOLGDDD]
	private static void BKKFKNMFHPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class GNNLPLMLBIP : ACLGOBNDAKI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float FGGBNLMKPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5160", Offset = "0x3AB4360", VA = "0x183AB5160", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float OEBGNOMHEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5120", Offset = "0x3AB4320", VA = "0x183AB5120", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float PCHMAEPHBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5170", Offset = "0x3AB4370", VA = "0x183AB5170", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int ALIPLNKABOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5150", Offset = "0x3AB4350", VA = "0x183AB5150", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double CBFKMBIJDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3AB5130", Offset = "0x3AB4330", VA = "0x183AB5130", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	public GNNLPLMLBIP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BCKBGMPBOEN
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] IIKLKCCNJOK;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int EFALHOKMJDD;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int EIOLKOFHOIE;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger DCNHKPLAFAO;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
	public BCKBGMPBOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD040", Offset = "0x3AAC240", VA = "0x183AAD040")]
	private static string JACOKJKBDNF(byte[] EELHLJKEFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AAD140", Offset = "0x3AAC340", VA = "0x183AAD140")]
	public static string MIOPHHLBAMI(byte[] DNMICDHPJHJ, bool AFHNMHOEHHN)
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
		[Cpp2IlInjected.Address(RVA = "0x4279D0", Offset = "0x426BD0", VA = "0x1804279D0")]
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

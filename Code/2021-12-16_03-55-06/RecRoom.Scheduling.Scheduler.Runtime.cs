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
		private delegate List<PlayerLoopSystem> KIEJGBFAAOM(List<PlayerLoopSystem> FONGCPNAJJD, int NPJCPMCCENP);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct ICJPMOBMGGP
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct LEJKGEGEKAC
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static LGMCBKMFAFH EIMKIHFOKAI;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x40B3160", Offset = "0x40B2560", VA = "0x1840B3160")]
				public static PlayerLoopSystem ILOMNBCAMEM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct ILBDEONCMHN
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static LGMCBKMFAFH CDFFBMENNBA;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x40AFA00", Offset = "0x40AEE00", VA = "0x1840AFA00")]
				public static PlayerLoopSystem ILOMNBCAMEM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct BGFEOOHCJGJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static LGMCBKMFAFH LNOPEHDLMCK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x40A86A0", Offset = "0x40A7AA0", VA = "0x1840A86A0")]
				public static PlayerLoopSystem ILOMNBCAMEM()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			internal struct KIELHDGMGCK
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				[CompilerGenerated]
				private sealed class LBCGFHOPMIK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000C")]
					public MCBKFGKMGDL.DMNBFGIIAPL key;

					[Cpp2IlInjected.Token(Token = "0x600001B")]
					[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
					public LBCGFHOPMIK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001C")]
					[Cpp2IlInjected.Address(RVA = "0x40B2350", Offset = "0x40B1750", VA = "0x1840B2350")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDisposable KOIBLDHKEKK;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x40B1A70", Offset = "0x40B0E70", VA = "0x1840B1A70")]
				public static PlayerLoopSystem BJDMFNNMEOB(MCBKFGKMGDL.DMNBFGIIAPL KFLAFLPOCPA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct LMGMAOMMNGM
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class LDFLKOPIKLB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000D")]
					public MCBKFGKMGDL.DMNBFGIIAPL key;

					[Cpp2IlInjected.Token(Token = "0x600001E")]
					[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
					public LDFLKOPIKLB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600001F")]
					[Cpp2IlInjected.Address(RVA = "0x40B30A0", Offset = "0x40B24A0", VA = "0x1840B30A0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x40B39E0", Offset = "0x40B2DE0", VA = "0x1840B39E0")]
				public static PlayerLoopSystem BJDMFNNMEOB(MCBKFGKMGDL.DMNBFGIIAPL KFLAFLPOCPA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MNOADJNKMMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public MNOADJNKMMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40B5B20", Offset = "0x40B4F20", VA = "0x1840B5B20")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool CIGDAEGNDJD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool AEDGBCEEGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x40A9360", Offset = "0x40A8760", VA = "0x1840A9360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x40AA1F0", Offset = "0x40A95F0", VA = "0x1840AA1F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x40A93A0", Offset = "0x40A87A0", VA = "0x1840A93A0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x40AA230", Offset = "0x40A9630", VA = "0x1840AA230")]
		private static void FIJFOHFIAID(MCBKFGKMGDL.DMNBFGIIAPL KFLAFLPOCPA, ref PlayerLoopSystem HAIBNLHPFMN, Type BMIJDFLHGNF, Type ICKNLOHNHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x40AA590", Offset = "0x40A9990", VA = "0x1840AA590")]
		private static void OEBNBCNIJID(ref PlayerLoopSystem HAIBNLHPFMN, Type BMIJDFLHGNF, Type ICKNLOHNHEO, KIEJGBFAAOM AOGGCMMLDJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40AA490", Offset = "0x40A9890", VA = "0x1840AA490")]
		private static void NMNBNPJPCNE(ref PlayerLoopSystem HAIBNLHPFMN, Type BMIJDFLHGNF, Type ICKNLOHNHEO, PlayerLoopSystem? KNGJLDEGPIE, PlayerLoopSystem? BPEDHJBDBOM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MCBKFGKMGDL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum DMNBFGIIAPL
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
	public class GODAPOAKCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly DMNBFGIIAPL JFGJFONMBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly EJMCPIFLOMB AIAAJHECCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long PLCKHECOLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long ANANFEHLCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public long ICJEABMJOKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int PEMHPAEKMEL;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x40ACB00", Offset = "0x40ABF00", VA = "0x1840ACB00")]
		public GODAPOAKCOP(DMNBFGIIAPL PMFIPJBMKKA, int LODACNOPNKJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x40AC910", Offset = "0x40ABD10", VA = "0x1840AC910")]
		public void CLFBCIDAIDO(int NFHFCFGGJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x40AC8A0", Offset = "0x40ABCA0", VA = "0x1840AC8A0")]
		public void CGAEBKPBDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x40AC7A0", Offset = "0x40ABBA0", VA = "0x1840AC7A0")]
		public void BBHHPAMNJGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x40AC930", Offset = "0x40ABD30", VA = "0x1840AC930")]
		public void OBKGCKGOACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x40AC800", Offset = "0x40ABC00", VA = "0x1840AC800")]
		public double CFDGKHCLCEN(int KGNBAKAPGLD)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int ECDJOAHMJIB = 90;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static DMNBFGIIAPL[] PKGMCPFAFHI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GODAPOAKCOP[] KCEGINNLNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x40B3B70", Offset = "0x40B2F70", VA = "0x1840B3B70")]
	public static GODAPOAKCOP FGKMJNKBEBM(DMNBFGIIAPL KFLAFLPOCPA, int LODACNOPNKJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x40B3D00", Offset = "0x40B3100", VA = "0x1840B3D00")]
	public static GODAPOAKCOP MNGOGMPJCEN(DMNBFGIIAPL KFLAFLPOCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40B3D90", Offset = "0x40B3190", VA = "0x1840B3D90")]
	public static void PNMCKFOPMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EJMCPIFLOMB : EPOINHNBDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int OHMDDPJIDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Queue<double> KPJBIALILGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private double MEBPEIOHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private double DJDCLFBAFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private double NDPLJGANBBM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PAEOCDCEOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x40AB110", Offset = "0x40AA510", VA = "0x1840AB110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double NAJHALECHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x40AB0B0", Offset = "0x40AA4B0", VA = "0x1840AB0B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double NLJBJCMABHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x130E4A0", Offset = "0x130D8A0", VA = "0x18130E4A0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double LMCGOBMPECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2E2A010", Offset = "0x2E29410", VA = "0x182E2A010", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40AB2C0", Offset = "0x40AA6C0", VA = "0x1840AB2C0")]
	public EJMCPIFLOMB(int BEOANBIBKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40AB1C0", Offset = "0x40AA5C0", VA = "0x1840AB1C0", Slot = "4")]
	public void PDHJGJJFAFM(double NHMLFAJFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x40AB150", Offset = "0x40AA550", VA = "0x1840AB150", Slot = "5")]
	public void OJEHMGCEIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KNNGABBIFGC : EPOINHNBDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private long LLIBIDENMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double PMAOJIPKCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double GMMHDFAEHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double CDOHABFEDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double JLPMGFCJLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double MEBPEIOHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double DJDCLFBAFBK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double NLJBJCMABHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3162240", Offset = "0x3161640", VA = "0x183162240", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double LMCGOBMPECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7670D0", Offset = "0x7664D0", VA = "0x1807670D0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FOOLHANJIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E2A010", Offset = "0x2E29410", VA = "0x182E2A010")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double GINDFIKFCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2E2A000", Offset = "0x2E29400", VA = "0x182E2A000")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double NAJHALECHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3162170", Offset = "0x3161570", VA = "0x183162170", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x40B2200", Offset = "0x40B1600", VA = "0x1840B2200", Slot = "4")]
	public void PDHJGJJFAFM(double NHMLFAJFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x40B21C0", Offset = "0x40B15C0", VA = "0x1840B21C0", Slot = "5")]
	public void OJEHMGCEIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x40B2320", Offset = "0x40B1720", VA = "0x1840B2320")]
	public KNNGABBIFGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EPOINHNBDBN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double NAJHALECHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double NLJBJCMABHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double LMCGOBMPECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDHJGJJFAFM(double NHMLFAJFKPB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJEHMGCEIIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JPKOGKNPIEO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private interface IJBNCPKIHND
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool OAPCEADEOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BDDIEILDFEN();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GHIPHAPLKEH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class KPJMNFBFBAD<TPromise, TMainThreadPromise> : IJBNCPKIHND where TPromise : BJPFHFGNMKO where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TPromise CBOBJOIGILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected readonly TMainThreadPromise PKKCEPFDAEC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise NPPJHNDGCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3228210", Offset = "0x3227610", VA = "0x183228210")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OAPCEADEOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x32281C0", Offset = "0x32275C0", VA = "0x1832281C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1F7B210", Offset = "0x1F7A610", VA = "0x181F7B210")]
		protected KPJMNFBFBAD(TPromise CBOBJOIGILG, TMainThreadPromise HPJLMPPCHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3228190", Offset = "0x3227590", VA = "0x183228190", Slot = "5")]
		public void BDDIEILDFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x22B5C50", Offset = "0x22B5050", VA = "0x1822B5C50", Slot = "6")]
		public void GHIPHAPLKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void NLKAHLAKPDO(TPromise CBOBJOIGILG);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void NAMGCKEPIPP();
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class CMJHBCDDCJK<T> : KPJMNFBFBAD<global::GMNMGKEAFFO<T>, global::EDILJINBHIG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x321CA60", Offset = "0x321BE60", VA = "0x18321CA60")]
		public CMJHBCDDCJK(global::GMNMGKEAFFO<T> CBOBJOIGILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x321C860", Offset = "0x321BC60", VA = "0x18321C860", Slot = "7")]
		protected override void NLKAHLAKPDO(global::GMNMGKEAFFO<T> CBOBJOIGILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x321C7D0", Offset = "0x321BBD0", VA = "0x18321C7D0", Slot = "8")]
		protected override void NAMGCKEPIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x273E970", Offset = "0x273DD70", VA = "0x18273E970")]
		[CompilerGenerated]
		private void HAMHHFCLNBE(T LLLNMLKNOCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x321C830", Offset = "0x321BC30", VA = "0x18321C830")]
		[CompilerGenerated]
		private void NJGLBDEIBLC(string NMLBEMGFEKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class JPHOCBGFOGD : KPJMNFBFBAD<BJPFHFGNMKO, LCJLLILPNOL>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x40B0920", Offset = "0x40AFD20", VA = "0x1840B0920")]
		public JPHOCBGFOGD(BJPFHFGNMKO CBOBJOIGILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x40B0850", Offset = "0x40AFC50", VA = "0x1840B0850", Slot = "7")]
		protected override void NLKAHLAKPDO(BJPFHFGNMKO CBOBJOIGILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x40B0800", Offset = "0x40AFC00", VA = "0x1840B0800", Slot = "8")]
		protected override void NAMGCKEPIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xBBFE20", Offset = "0xBBF220", VA = "0x180BBFE20")]
		[CompilerGenerated]
		private void HAMHHFCLNBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1623B70", Offset = "0x1622F70", VA = "0x181623B70")]
		[CompilerGenerated]
		private void NJGLBDEIBLC(string NMLBEMGFEKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class HEPCPKOHJOJ : IJBNCPKIHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Action AHNIOOAKOAF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OAPCEADEOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4BFF60", Offset = "0x4BF360", VA = "0x1804BFF60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD10", Offset = "0x5AB110", VA = "0x1805ABD10")]
		public HEPCPKOHJOJ(Action AHNIOOAKOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1441D60", Offset = "0x1441160", VA = "0x181441D60", Slot = "5")]
		public void BDDIEILDFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "6")]
		public void GHIPHAPLKEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly List<IJBNCPKIHND> HOBOOJNEHON;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2132E60", Offset = "0x2132260", VA = "0x182132E60")]
	public static global::GMNMGKEAFFO<T> FHJIKMHCIMO<T>(this global::GMNMGKEAFFO<T> CBOBJOIGILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x40B0DE0", Offset = "0x40B01E0", VA = "0x1840B0DE0")]
	public static BJPFHFGNMKO FHJIKMHCIMO(this BJPFHFGNMKO CBOBJOIGILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x40B0D60", Offset = "0x40B0160", VA = "0x1840B0D60")]
	public static void FHJIKMHCIMO(Action AHNIOOAKOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2132ED0", Offset = "0x21322D0", VA = "0x182132ED0")]
	private static global::GMNMGKEAFFO<T> MDKLFMCOOBE<T>(global::GMNMGKEAFFO<T> CBOBJOIGILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x40B0EF0", Offset = "0x40B02F0", VA = "0x1840B0EF0")]
	private static BJPFHFGNMKO MDKLFMCOOBE(BJPFHFGNMKO CBOBJOIGILG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x40B10A0", Offset = "0x40B04A0", VA = "0x1840B10A0")]
	private static void OCBPJNPPHNE(IJBNCPKIHND DDNFCIEDAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x40B0A40", Offset = "0x40AFE40", VA = "0x1840B0A40")]
	private static void DOMBODDOJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x40B0FD0", Offset = "0x40B03D0", VA = "0x1840B0FD0")]
	private static void MPGGMKAIIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40B0990", Offset = "0x40AFD90", VA = "0x1840B0990")]
	private static void DMPOMJHEEDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KAAIIOBJEFA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NOFDAJGBIOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LCJLLILPNOL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public NOFDAJGBIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x40B67B0", Offset = "0x40B5BB0", VA = "0x1840B67B0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x40B67A0", Offset = "0x40B5BA0", VA = "0x1840B67A0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MNEMKPNPDIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public MNEMKPNPDIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x40B5AF0", Offset = "0x40B4EF0", VA = "0x1840B5AF0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KKEEPELNODD : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public LCJLLILPNOL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public KKEEPELNODD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x40B1F80", Offset = "0x40B1380", VA = "0x1840B1F80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x40B1CB0", Offset = "0x40B10B0", VA = "0x1840B1CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x40B2030", Offset = "0x40B1430", VA = "0x1840B2030")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x40B1F30", Offset = "0x40B1330", VA = "0x1840B1F30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JIBILGFBEFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LCJLLILPNOL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public JIBILGFBEFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PNJBOBIGLBI : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LCJLLILPNOL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JIBILGFBEFI <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public PNJBOBIGLBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x40B6C80", Offset = "0x40B6080", VA = "0x1840B6C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x40B6FD0", Offset = "0x40B63D0", VA = "0x1840B6FD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string AHFHIFPPKJP = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string NCPFENDDKFJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string PJDMDNIHACN = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string LKPFEGHBENH = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string JHHHMDBJMMN = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AHMMNNFLBDB = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static BJPFHFGNMKO MDAFFFHAJHF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation KENJLIKPLEP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BJPFHFGNMKO HMLPADLLALH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string OPECLDAMHFC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority EGMCDCLFIDB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool KBINHIHJLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x40B1760", Offset = "0x40B0B60", VA = "0x1840B1760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool BPBECGPDICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x40B1350", Offset = "0x40B0750", VA = "0x1840B1350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MGCNIIGMBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x40B13B0", Offset = "0x40B07B0", VA = "0x1840B13B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NIBFGMPIJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x40B1930", Offset = "0x40B0D30", VA = "0x1840B1930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x40B1800", Offset = "0x40B0C00", VA = "0x1840B1800")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x40B1410", Offset = "0x40B0810", VA = "0x1840B1410")]
	public static BJPFHFGNMKO COKKPPHNGKM(string OEEDHEKLAOE, LoadSceneMode MLOGCMHNPJM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x40B1550", Offset = "0x40B0950", VA = "0x1840B1550")]
	public static BJPFHFGNMKO ILONHMAGOEH(string OEEDHEKLAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x40B12E0", Offset = "0x40B06E0", VA = "0x1840B12E0")]
	[IteratorStateMachine(typeof(KKEEPELNODD))]
	private static IEnumerator<KDLPPIDBMCA> BJODOCEDDKI(string OEEDHEKLAOE, LCJLLILPNOL LGGLNEMLHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40B18B0", Offset = "0x40B0CB0", VA = "0x1840B18B0")]
	[IteratorStateMachine(typeof(PNJBOBIGLBI))]
	private static IEnumerator<KDLPPIDBMCA> LMFNJPDNIOP(string OEEDHEKLAOE, LoadSceneMode MLOGCMHNPJM, LCJLLILPNOL LGGLNEMLHMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HEGJDMNHAAI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x40AD0D0", Offset = "0x40AC4D0", VA = "0x1840AD0D0")]
	public static IDisposable IBLBBMOOACE(this GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x40AD150", Offset = "0x40AC550", VA = "0x1840AD150")]
	public static IDisposable IBLBBMOOACE(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x40ACF60", Offset = "0x40AC360", VA = "0x1840ACF60")]
	public static IDisposable GAMKOODKNPK(this GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x40AD4A0", Offset = "0x40AC8A0", VA = "0x1840AD4A0")]
	public static IDisposable MNODLKDMPLN(this GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x40AD590", Offset = "0x40AC990", VA = "0x1840AD590")]
	public static IDisposable NMMDDLINEEH(this GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x40ACC60", Offset = "0x40AC060", VA = "0x1840ACC60")]
	public static IDisposable AEDEFDMDCGF(this GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x40ACD50", Offset = "0x40AC150", VA = "0x1840ACD50")]
	public static IDisposable DAPFGMLCNBP(this GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40ACDC0", Offset = "0x40AC1C0", VA = "0x1840ACDC0")]
	public static IDisposable FCGMFGPILKM(this GBOIEHAOIPJ FEHFBAFOKDE, float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x40ACFD0", Offset = "0x40AC3D0", VA = "0x1840ACFD0")]
	public static IDisposable GFGNIMKHNDB(this GBOIEHAOIPJ FEHFBAFOKDE, float HFIPCDOGJHI, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x40AD510", Offset = "0x40AC910", VA = "0x1840AD510")]
	public static IDisposable MPKLOPBEHHN(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x40AD420", Offset = "0x40AC820", VA = "0x1840AD420")]
	public static IDisposable MNBLKDENHFM(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x40ACE50", Offset = "0x40AC250", VA = "0x1840ACE50")]
	public static IDisposable FLHJPGEMGCL(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x40ACED0", Offset = "0x40AC2D0", VA = "0x1840ACED0")]
	public static IDisposable GAGODINPJAC(this GBOIEHAOIPJ FEHFBAFOKDE, float HFIPCDOGJHI, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x40ACBE0", Offset = "0x40ABFE0", VA = "0x1840ACBE0")]
	public static IDisposable AEAMONDJABO(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x40AD600", Offset = "0x40ACA00", VA = "0x1840AD600")]
	public static IDisposable OFNPFMBHEAH(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40AD680", Offset = "0x40ACA80", VA = "0x1840AD680")]
	public static IDisposable ONNKAPCOFJI(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x40AD310", Offset = "0x40AC710", VA = "0x1840AD310")]
	public static IDisposable KDPLBECDOKP(this GBOIEHAOIPJ FEHFBAFOKDE, float HFIPCDOGJHI, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x40ACCD0", Offset = "0x40AC0D0", VA = "0x1840ACCD0")]
	public static IDisposable AIICNDLEMOI(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x40AD3A0", Offset = "0x40AC7A0", VA = "0x1840AD3A0")]
	public static IDisposable MNANPFGGDEJ(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x40AD050", Offset = "0x40AC450", VA = "0x1840AD050")]
	public static IDisposable HLEMGNMEEKM(this GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LCAPBHMLAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x40B2CB0", Offset = "0x40B20B0", VA = "0x1840B2CB0")]
	public static IDisposable KCBLFPCOPBE(this MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x40B2AF0", Offset = "0x40B1EF0", VA = "0x1840B2AF0")]
	public static IDisposable KCBLFPCOPBE(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x40B2820", Offset = "0x40B1C20", VA = "0x1840B2820")]
	public static IDisposable ENFJEMPLBDL(this MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x40B2EB0", Offset = "0x40B22B0", VA = "0x1840B2EB0")]
	public static IDisposable NDJDIOPBGEM(this MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x40B2980", Offset = "0x40B1D80", VA = "0x1840B2980")]
	public static IDisposable ILMLOPMCIBC(this MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x40B29F0", Offset = "0x40B1DF0", VA = "0x1840B29F0")]
	public static IDisposable IPKEKMAFMFE(this MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x40B2910", Offset = "0x40B1D10", VA = "0x1840B2910")]
	public static IDisposable FPILEAEIHHA(this MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x40B2500", Offset = "0x40B1900", VA = "0x1840B2500")]
	public static IDisposable BFBKADAJOKN(this MonoBehaviour LFBFBIPFJOD, float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x40B2E30", Offset = "0x40B2230", VA = "0x1840B2E30")]
	public static IDisposable NBJNMKNLEBM(this MonoBehaviour LFBFBIPFJOD, float HFIPCDOGJHI, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x40B2690", Offset = "0x40B1A90", VA = "0x1840B2690")]
	public static IDisposable DJCLHGCJDOM(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x40B2590", Offset = "0x40B1990", VA = "0x1840B2590")]
	public static IDisposable BGFLDKOJGPD(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x40B3020", Offset = "0x40B2420", VA = "0x1840B3020")]
	public static IDisposable PMPLBICLEOP(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x40B2F20", Offset = "0x40B2320", VA = "0x1840B2F20")]
	public static IDisposable NMEDDMMCDOH(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x40B2610", Offset = "0x40B1A10", VA = "0x1840B2610")]
	public static IDisposable BMJIMENJCBB(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x40B2480", Offset = "0x40B1880", VA = "0x1840B2480")]
	public static IDisposable APLAAHGMMAK(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x40B2790", Offset = "0x40B1B90", VA = "0x1840B2790")]
	public static IDisposable EMCAPJMPFMK(this MonoBehaviour LFBFBIPFJOD, float HFIPCDOGJHI, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x40B2FA0", Offset = "0x40B23A0", VA = "0x1840B2FA0")]
	public static IDisposable PEKOAANGIJO(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x40B2890", Offset = "0x40B1C90", VA = "0x1840B2890")]
	public static IDisposable FNGJEIMEMAO(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x40B2400", Offset = "0x40B1800", VA = "0x1840B2400")]
	public static IDisposable APJACEEOLGF(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x40B2A60", Offset = "0x40B1E60", VA = "0x1840B2A60")]
	public static IDisposable KBPNOOEFDFD(this MonoBehaviour LFBFBIPFJOD, float HFIPCDOGJHI, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x40B2D30", Offset = "0x40B2130", VA = "0x1840B2D30")]
	public static IDisposable MAMFBGINLBB(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x40B2710", Offset = "0x40B1B10", VA = "0x1840B2710")]
	public static IDisposable EDCFBIMEJAL(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x40B2DB0", Offset = "0x40B21B0", VA = "0x1840B2DB0")]
	public static IDisposable NALMGDMKHNG(this MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FMAOFCMLNJM
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class CBNCFHDMJDK : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public KKHGNODELBK.DDIFOGHFLLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private NBDBEKLNJFD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public CBNCFHDMJDK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x40A8CB0", Offset = "0x40A80B0", VA = "0x1840A8CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x40A8D80", Offset = "0x40A8180", VA = "0x1840A8D80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MHMALPKPHIB : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KKHGNODELBK.DDIFOGHFLLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NBDBEKLNJFD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public MHMALPKPHIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x40B4180", Offset = "0x40B3580", VA = "0x1840B4180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x40B4270", Offset = "0x40B3670", VA = "0x1840B4270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x40AB9F0", Offset = "0x40AADF0", VA = "0x1840AB9F0")]
	public static HNAKCFLNFIA KCBLFPCOPBE(Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x40AB6E0", Offset = "0x40AAAE0", VA = "0x1840AB6E0")]
	public static HNAKCFLNFIA KCBLFPCOPBE(Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x40AB8E0", Offset = "0x40AACE0", VA = "0x1840AB8E0")]
	public static HNAKCFLNFIA KCBLFPCOPBE(Behaviour FEHFBAFOKDE, Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x40AB7D0", Offset = "0x40AABD0", VA = "0x1840AB7D0")]
	public static HNAKCFLNFIA KCBLFPCOPBE(Behaviour FEHFBAFOKDE, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x40AB3E0", Offset = "0x40AA7E0", VA = "0x1840AB3E0")]
	public static HNAKCFLNFIA IBLBBMOOACE(GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x40AB4F0", Offset = "0x40AA8F0", VA = "0x1840AB4F0")]
	public static HNAKCFLNFIA IBLBBMOOACE(GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x40AB600", Offset = "0x40AAA00", VA = "0x1840AB600")]
	[IteratorStateMachine(typeof(CBNCFHDMJDK))]
	private static IEnumerator<KDLPPIDBMCA> IMHBOOMJFGP(KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP, Action AJMDLENIHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x40AB670", Offset = "0x40AAA70", VA = "0x1840AB670")]
	[IteratorStateMachine(typeof(MHMALPKPHIB))]
	private static IEnumerator<KDLPPIDBMCA> IMHBOOMJFGP(KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP, Action<float> AJMDLENIHFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class AFNPNMLJBJP
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KMHGLBFPNEO : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KKHGNODELBK.DDIFOGHFLLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private JABMDKNMPHC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public KMHGLBFPNEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40B2080", Offset = "0x40B1480", VA = "0x1840B2080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40B2170", Offset = "0x40B1570", VA = "0x1840B2170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x40A8020", Offset = "0x40A7420", VA = "0x1840A8020")]
	public static HNAKCFLNFIA KCBLFPCOPBE(float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x40A80D0", Offset = "0x40A74D0", VA = "0x1840A80D0")]
	public static HNAKCFLNFIA KCBLFPCOPBE(MonoBehaviour LFBFBIPFJOD, float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x40A7F60", Offset = "0x40A7360", VA = "0x1840A7F60")]
	public static HNAKCFLNFIA JDNOEFKGLGE(GBOIEHAOIPJ FEHFBAFOKDE, float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x40A7EE0", Offset = "0x40A72E0", VA = "0x1840A7EE0")]
	[IteratorStateMachine(typeof(KMHGLBFPNEO))]
	private static IEnumerator<KDLPPIDBMCA> IMHBOOMJFGP(float HFIPCDOGJHI, KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP, Action<float> AJMDLENIHFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PEIJICBLKKB
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JIPAKHBJFNE : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KKHGNODELBK.DDIFOGHFLLJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public JIPAKHBJFNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40B0350", Offset = "0x40AF750", VA = "0x1840B0350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x40B03F0", Offset = "0x40AF7F0", VA = "0x1840B03F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x40B6C10", Offset = "0x40B6010", VA = "0x1840B6C10")]
	[IteratorStateMachine(typeof(JIPAKHBJFNE))]
	private static IEnumerator<KDLPPIDBMCA> OPHDAAGHPJJ(KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP, Func<bool> JEOAHEFPBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x40B6AC0", Offset = "0x40B5EC0", VA = "0x1840B6AC0")]
	public static HNAKCFLNFIA MDLDBIEAMPL(this MonoBehaviour LFBFBIPFJOD, Func<bool> JEOAHEFPBHD, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP = KKHGNODELBK.DDIFOGHFLLJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NKOICEDOLOM
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class LLKOAFBDNGN : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KKHGNODELBK.DDIFOGHFLLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public LLKOAFBDNGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x40B38E0", Offset = "0x40B2CE0", VA = "0x1840B38E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x40B3990", Offset = "0x40B2D90", VA = "0x1840B3990", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HOMAEKKNGAF : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public KKHGNODELBK.DDIFOGHFLLJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private KDLPPIDBMCA <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public HOMAEKKNGAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x40AF8F0", Offset = "0x40AECF0", VA = "0x1840AF8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x40AF9B0", Offset = "0x40AEDB0", VA = "0x1840AF9B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x40B6700", Offset = "0x40B5B00", VA = "0x1840B6700")]
	[IteratorStateMachine(typeof(LLKOAFBDNGN))]
	private static IEnumerator<KDLPPIDBMCA> LNCIJAKNKBA(float PLKFKGOGHOD, KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x40B5E40", Offset = "0x40B5240", VA = "0x1840B5E40")]
	[IteratorStateMachine(typeof(HOMAEKKNGAF))]
	private static IEnumerator<KDLPPIDBMCA> CECHLPNCBEO(float PLKFKGOGHOD, KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x40B6130", Offset = "0x40B5530", VA = "0x1840B6130")]
	public static IDisposable FDCPHONKDKL(this MonoBehaviour LFBFBIPFJOD, float PLKFKGOGHOD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x40B65C0", Offset = "0x40B59C0", VA = "0x1840B65C0")]
	public static HNAKCFLNFIA KJMGNEABAGO(this MonoBehaviour LFBFBIPFJOD, float PLKFKGOGHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x40B5FE0", Offset = "0x40B53E0", VA = "0x1840B5FE0")]
	public static HNAKCFLNFIA FDCPHONKDKL(this MonoBehaviour LFBFBIPFJOD, float PLKFKGOGHOD, KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x40B64A0", Offset = "0x40B58A0", VA = "0x1840B64A0")]
	public static HNAKCFLNFIA KBOAFEFHMAO(this MonoBehaviour LFBFBIPFJOD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x40B5FD0", Offset = "0x40B53D0", VA = "0x1840B5FD0")]
	public static HNAKCFLNFIA EBGLPLBMAGK(this MonoBehaviour LFBFBIPFJOD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x40B6780", Offset = "0x40B5B80", VA = "0x1840B6780")]
	public static HNAKCFLNFIA MAJIPJKNJPE(this MonoBehaviour LFBFBIPFJOD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x40B6490", Offset = "0x40B5890", VA = "0x1840B6490")]
	public static HNAKCFLNFIA KBNECGIJHIA(this MonoBehaviour LFBFBIPFJOD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x40B6790", Offset = "0x40B5B90", VA = "0x1840B6790")]
	public static HNAKCFLNFIA MLJNFPPMBEI(this MonoBehaviour LFBFBIPFJOD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x40B6380", Offset = "0x40B5780", VA = "0x1840B6380")]
	private static HNAKCFLNFIA JIJPNMEAMOE(MonoBehaviour LFBFBIPFJOD, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x40B5C20", Offset = "0x40B5020", VA = "0x1840B5C20")]
	public static HNAKCFLNFIA BCFDNOJJAPD(this MonoBehaviour LFBFBIPFJOD, float KIEJLCKHLPD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x40B5D30", Offset = "0x40B5130", VA = "0x1840B5D30")]
	public static HNAKCFLNFIA BDDLKEKKHKN(this MonoBehaviour LFBFBIPFJOD, float KIEJLCKHLPD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x40B64B0", Offset = "0x40B58B0", VA = "0x1840B64B0")]
	public static HNAKCFLNFIA KDBGHGOBDGM(this MonoBehaviour LFBFBIPFJOD, float KIEJLCKHLPD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x40B5EC0", Offset = "0x40B52C0", VA = "0x1840B5EC0")]
	public static HNAKCFLNFIA DJKMJNLGPGO(this MonoBehaviour LFBFBIPFJOD, float KIEJLCKHLPD, Action CPJGPPKOLLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x40B6270", Offset = "0x40B5670", VA = "0x1840B6270")]
	public static HNAKCFLNFIA ICABJIENIKN(this MonoBehaviour LFBFBIPFJOD, float KIEJLCKHLPD, Action CPJGPPKOLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DGEHBOMAFJN : AGGHPIJPAAM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JCJCNOKNKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DGEHBOMAFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public JCJCNOKNKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x40AFBA0", Offset = "0x40AEFA0", VA = "0x1840AFBA0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LGDMGCHOMHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public DGEHBOMAFJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public LGDMGCHOMHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x40AFBA0", Offset = "0x40AEFA0", VA = "0x1840AFBA0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly float KBLBFNJAGCD;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x40A8C60", Offset = "0x40A8060", VA = "0x1840A8C60")]
	public DGEHBOMAFJN(Behaviour FEHFBAFOKDE, float KBLBFNJAGCD, [Optional] Action NFAMOEOOEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x40AAED0", Offset = "0x40AA2D0", VA = "0x1840AAED0", Slot = "9")]
	protected override bool HDHGIDEOCOB(Action AHNIOOAKOAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x40AAFA0", Offset = "0x40AA3A0", VA = "0x1840AAFA0", Slot = "10")]
	protected override bool JOCJICPJKLC(Action AHNIOOAKOAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OLJLBDOKBEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GOGDBPCFKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GJNKAAOOEPG;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PBNDMFDCFHM(bool GPNOPPGDJFN = false);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PBNDMFDCFHM(Action AHNIOOAKOAF, bool GPNOPPGDJFN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class AGGHPIJPAAM : OLJLBDOKBEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class OBOBAKDPIAG : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public OBOBAKDPIAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x40B6990", Offset = "0x40B5D90", VA = "0x1840B6990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x40B6A30", Offset = "0x40B5E30", VA = "0x1840B6A30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Behaviour FEHFBAFOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action NFAMOEOOEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NFPFIMOODJO NNOHIBIKCPJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GOGDBPCFKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x835B00", Offset = "0x834F00", VA = "0x180835B00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GJNKAAOOEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x40A8360", Offset = "0x40A7760", VA = "0x1840A8360", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x40A8510", Offset = "0x40A7910", VA = "0x1840A8510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x25B1060", Offset = "0x25B0460", VA = "0x1825B1060")]
	protected AGGHPIJPAAM(Behaviour FEHFBAFOKDE, [Optional] Action NFAMOEOOEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x40A8600", Offset = "0x40A7A00", VA = "0x1840A8600", Slot = "7")]
	public bool PBNDMFDCFHM(bool GPNOPPGDJFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x40A85B0", Offset = "0x40A79B0", VA = "0x1840A85B0", Slot = "8")]
	public bool PBNDMFDCFHM(Action AHNIOOAKOAF, bool GPNOPPGDJFN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HDHGIDEOCOB(Action AHNIOOAKOAF);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JOCJICPJKLC(Action AHNIOOAKOAF);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x40A84F0", Offset = "0x40A78F0", VA = "0x1840A84F0")]
	protected void MOAAMHKOFLO(Action AHNIOOAKOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x40A8190", Offset = "0x40A7590", VA = "0x1840A8190")]
	protected BJPFHFGNMKO BPPPBGMIJCC(float PMPAHILEBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x40A8400", Offset = "0x40A7800", VA = "0x1840A8400")]
	private void KPCAMCJOMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x40A8470", Offset = "0x40A7870", VA = "0x1840A8470")]
	[IteratorStateMachine(typeof(OBOBAKDPIAG))]
	private static IEnumerator<KDLPPIDBMCA> LIEJKMGKMAB(float PMPAHILEBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x40A84D0", Offset = "0x40A78D0", VA = "0x1840A84D0")]
	[CompilerGenerated]
	private void MHGOLBKNHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JMJMIMCBMJG : AGGHPIJPAAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly float DIIKKHKMEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int BJCKJFDCPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly float OHLCAJOGKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float[] IBHDLPGIPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int CCLMILIGOEH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ELJNHDJAIEJ CGOIHLPLNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4E6670", Offset = "0x4E5A70", VA = "0x1804E6670")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDD0", Offset = "0x5AE1D0", VA = "0x1805AEDD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x40B06F0", Offset = "0x40AFAF0", VA = "0x1840B06F0")]
	public JMJMIMCBMJG(Behaviour FEHFBAFOKDE, float BABPLLMOKFO, int BJCKJFDCPGM, [Optional] Action NFAMOEOOEJA, float OHLCAJOGKIP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40", Slot = "9")]
	protected override bool HDHGIDEOCOB(Action AHNIOOAKOAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x40B04D0", Offset = "0x40AF8D0", VA = "0x1840B04D0", Slot = "10")]
	protected override bool JOCJICPJKLC(Action AHNIOOAKOAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x40B0440", Offset = "0x40AF840", VA = "0x1840B0440")]
	private void JFCMMIGADKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class BOOGEHOMOKM : AGGHPIJPAAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float KBLBFNJAGCD;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x40A8C60", Offset = "0x40A8060", VA = "0x1840A8C60")]
	public BOOGEHOMOKM(Behaviour FEHFBAFOKDE, float KBLBFNJAGCD, [Optional] Action NFAMOEOOEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40", Slot = "9")]
	protected override bool HDHGIDEOCOB(Action AHNIOOAKOAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x40A8C20", Offset = "0x40A8020", VA = "0x1840A8C20", Slot = "10")]
	protected override bool JOCJICPJKLC(Action AHNIOOAKOAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class GAPFEDDMGDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class KIODCEHMOLC : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public KIODCEHMOLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x40B1B70", Offset = "0x40B0F70", VA = "0x1840B1B70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x40B1C60", Offset = "0x40B1060", VA = "0x1840B1C60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private HNAKCFLNFIA OAJOBHGAELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GBOIEHAOIPJ FEHFBAFOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Action AJMDLENIHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Action<float> HIFBFCPAPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private float GNGOFAHOOAB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x40AC260", Offset = "0x40AB660", VA = "0x1840AC260")]
	public GAPFEDDMGDG(GBOIEHAOIPJ FEHFBAFOKDE, Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x40AC3F0", Offset = "0x40AB7F0", VA = "0x1840AC3F0")]
	public GAPFEDDMGDG(GBOIEHAOIPJ FEHFBAFOKDE, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x40AC580", Offset = "0x40AB980", VA = "0x1840AC580")]
	public GAPFEDDMGDG(GBOIEHAOIPJ FEHFBAFOKDE, float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x40AC080", Offset = "0x40AB480", VA = "0x1840AC080")]
	private void KCBLFPCOPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x40ABE00", Offset = "0x40AB200", VA = "0x1840ABE00")]
	private void HDEOPFECALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x40ABAE0", Offset = "0x40AAEE0", VA = "0x1840ABAE0")]
	private void AJDPCNBHBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x40ABC10", Offset = "0x40AB010", VA = "0x1840ABC10")]
	private void CNAPLGPDHDF(string NMLBEMGFEKP, Action HANBMDIKDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x40AC200", Offset = "0x40AB600", VA = "0x1840AC200")]
	[IteratorStateMachine(typeof(KIODCEHMOLC))]
	private IEnumerator<KDLPPIDBMCA> MHNMLNDJPHD(Action HANBMDIKDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x40ABD30", Offset = "0x40AB130", VA = "0x1840ABD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x40ABF80", Offset = "0x40AB380", VA = "0x1840ABF80")]
	[CompilerGenerated]
	private void IEFDOKLIIIE(string MGJAPINLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x40AC000", Offset = "0x40AB400", VA = "0x1840AC000")]
	[CompilerGenerated]
	private void JPHNHJAOFFA(string MGJAPINLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x40ABD80", Offset = "0x40AB180", VA = "0x1840ABD80")]
	[CompilerGenerated]
	private void FJPGCICGOEH(string MGJAPINLAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class AFCCEKOPCAC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MEPKJGCLNMF : IEnumerator<KDLPPIDBMCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KDLPPIDBMCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private KDLPPIDBMCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
		[DebuggerHidden]
		public MEPKJGCLNMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x40B4040", Offset = "0x40B3440", VA = "0x1840B4040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x40B4130", Offset = "0x40B3530", VA = "0x1840B4130", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private HNAKCFLNFIA OAJOBHGAELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private MonoBehaviour LFBFBIPFJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Action AJMDLENIHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Action<float> HIFBFCPAPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private float GNGOFAHOOAB;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x40A7D50", Offset = "0x40A7150", VA = "0x1840A7D50")]
	public AFCCEKOPCAC(MonoBehaviour LFBFBIPFJOD, Action AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x40A7BC0", Offset = "0x40A6FC0", VA = "0x1840A7BC0")]
	public AFCCEKOPCAC(MonoBehaviour LFBFBIPFJOD, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x40A7A70", Offset = "0x40A6E70", VA = "0x1840A7A70")]
	public AFCCEKOPCAC(MonoBehaviour LFBFBIPFJOD, float HFIPCDOGJHI, Action<float> AJMDLENIHFI, KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x40A7890", Offset = "0x40A6C90", VA = "0x1840A7890")]
	private void KCBLFPCOPBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x40A7610", Offset = "0x40A6A10", VA = "0x1840A7610")]
	private void HDEOPFECALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x40A72F0", Offset = "0x40A66F0", VA = "0x1840A72F0")]
	private void AJDPCNBHBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x40A7420", Offset = "0x40A6820", VA = "0x1840A7420")]
	private void CNAPLGPDHDF(string NMLBEMGFEKP, Action HANBMDIKDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x40A7A10", Offset = "0x40A6E10", VA = "0x1840A7A10")]
	[IteratorStateMachine(typeof(MEPKJGCLNMF))]
	private IEnumerator<KDLPPIDBMCA> MHNMLNDJPHD(Action HANBMDIKDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x40A7540", Offset = "0x40A6940", VA = "0x1840A7540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x40A7790", Offset = "0x40A6B90", VA = "0x1840A7790")]
	[CompilerGenerated]
	private void IEFDOKLIIIE(string MGJAPINLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x40A7810", Offset = "0x40A6C10", VA = "0x1840A7810")]
	[CompilerGenerated]
	private void JPHNHJAOFFA(string MGJAPINLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x40A7590", Offset = "0x40A6990", VA = "0x1840A7590")]
	[CompilerGenerated]
	private void FJPGCICGOEH(string MGJAPINLAFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DEGCMNENPEE
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int IHGBDOAJDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MEDPPDGBMMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly MEDPPDGBMMP JGOGGHDNHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly Action FOJNHBHMMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool AGCPBGAIDFF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD10", Offset = "0x5AB110", VA = "0x1805ABD10")]
	public MEDPPDGBMMP(Action FOJNHBHMMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x40B3F50", Offset = "0x40B3350", VA = "0x1840B3F50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface JNEBABMKAEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T HDOIMHJBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MMLOCPGAEJF(Action<T> NPHJJPMCAAN);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable MMLOCPGAEJF(UnityEngine.Object FEHFBAFOKDE, Action<T> NPHJJPMCAAN);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EACCCFIPLNH<T> : global::JNEBABMKAEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T HDOIMHJBCMH
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
public class DBJEEIOBJMM<T> : global::EACCCFIPLNH<T>, global::JNEBABMKAEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AGALLIDNKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public global::DBJEEIOBJMM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::OGBIKIGLBLP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public AGALLIDNKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9270", Offset = "0x2DF8670", VA = "0x182DF9270")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static GameObject KPPFNBPEGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly List<global::OGBIKIGLBLP<UnityEngine.Object, Action<T>>> NFFMIOHBGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T DMOLJLCHEJA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object CIIDNOKLLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBA00", Offset = "0x2DFAE00", VA = "0x182DFBA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T HDOIMHJBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x64BF70", Offset = "0x64B370", VA = "0x18064BF70", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB6B0", Offset = "0x2DFAAB0", VA = "0x182DFB6B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB750", Offset = "0x2DFAB50", VA = "0x182DFB750")]
	private static bool JOCKBKGBJLH(T CFAJBDLFFFN, T DOIHHFGBAEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBF90", Offset = "0x2DFB390", VA = "0x182DFBF90")]
	public DBJEEIOBJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBFC0", Offset = "0x2DFB3C0", VA = "0x182DFBFC0")]
	public DBJEEIOBJMM(T JNCJBIKPKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB730", Offset = "0x2DFAB30", VA = "0x182DFB730")]
	public void JALILFCNKCK(T KHKCPMEMGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBC10", Offset = "0x2DFB010", VA = "0x182DFBC10", Slot = "7")]
	public IDisposable MMLOCPGAEJF(Action<T> NPHJJPMCAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBDC0", Offset = "0x2DFB1C0", VA = "0x182DFBDC0", Slot = "8")]
	public IDisposable MMLOCPGAEJF(UnityEngine.Object FEHFBAFOKDE, Action<T> NPHJJPMCAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB010", Offset = "0x2DFA410", VA = "0x182DFB010")]
	private void ELBAACLFAOB()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<NJBPIFCCCNI, Scheduler>, NJBPIFCCCNI
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class BHKKDHHOFLO : DEGCMNENPEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public HNKJKJIINJM JENDMOJGOEM;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int IHGBDOAJDEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x4BFE50", Offset = "0x4BF250", VA = "0x1804BFE50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0x4BFE60", Offset = "0x4BF260", VA = "0x1804BFE60")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x40A8910", Offset = "0x40A7D10", VA = "0x1840A8910")]
			public static KDLPPIDBMCA EMOMNOKMPHJ(IEnumerator<KDLPPIDBMCA> GMKGACFAFBM, EKLAHBAJLMJ DNJEDGDMLBC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x40A8840", Offset = "0x40A7C40", VA = "0x1840A8840")]
			public KDLPPIDBMCA EMOMNOKMPHJ(EKLAHBAJLMJ[] MAAKFBPGGPF, IEnumerator<KDLPPIDBMCA>[] BACMHMFDPHM, KDLPPIDBMCA[] FFAFPFBBBIP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x40A8B30", Offset = "0x40A7F30", VA = "0x1840A8B30")]
			public void FOIJNNHPCCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x40A8B60", Offset = "0x40A7F60", VA = "0x1840A8B60")]
			public void PHBPLMJAGPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x40A8A70", Offset = "0x40A7E70", VA = "0x1840A8A70")]
			public void FKNOEENEFJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x40A8B30", Offset = "0x40A7F30", VA = "0x1840A8B30")]
			public void GHIPHAPLKEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public BHKKDHHOFLO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class HNKJKJIINJM
		{
			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct OFMGMKIEANL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public BHKKDHHOFLO HMBPMALHLKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public GBOIEHAOIPJ LIFINCIKNPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public EKLAHBAJLMJ OEICOCMFFME;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public IEnumerator<KDLPPIDBMCA> PIGPAPAJEIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public KDLPPIDBMCA JHGMHCALNCJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public OMMLBLFEBMN PGOJDHPCFII;
			}

			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct OBIIBECAPAN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public KKHGNODELBK.DDIFOGHFLLJ EBBFPOHKIPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public List<OFMGMKIEANL> FBBDKMGFGAH;
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class JEELKOIKKJJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public HNKJKJIINJM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public GBOIEHAOIPJ context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public BHKKDHHOFLO routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public OMMLBLFEBMN coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public EKLAHBAJLMJ promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KDLPPIDBMCA currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public IEnumerator<KDLPPIDBMCA> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
				public JEELKOIKKJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x40AFBD0", Offset = "0x40AEFD0", VA = "0x1840AFBD0")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class EFBHIODBPAE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public BHKKDHHOFLO schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public HNKJKJIINJM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
				public EFBHIODBPAE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x40AB070", Offset = "0x40AA470", VA = "0x1840AB070")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class BEGFPCCFNLE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public BHKKDHHOFLO schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public HNKJKJIINJM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
				public BEGFPCCFNLE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x40A8660", Offset = "0x40A7A60", VA = "0x1840A8660")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class PAKJDJNJACJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public BHKKDHHOFLO schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public HNKJKJIINJM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
				public PAKJDJNJACJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x40B6A80", Offset = "0x40B5E80", VA = "0x1840B6A80")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private readonly KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool[] MEFCDIABHKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<OMMLBLFEBMN> IIEEIPFABGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<float> NGHKEFDMDLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private NativeArray<int> PBALHBLKPHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private NativeArray<int> GCMKNKNLCJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private NativeArray<int> GPHEGCECBIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<int> EDCJEHDHDGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<int> PAGJADADLGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private BHKKDHHOFLO[] BLPKMELGJCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private EKLAHBAJLMJ[] MAAKFBPGGPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private GBOIEHAOIPJ[] NIBIGEBJFLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<KDLPPIDBMCA>[] PNMKGEONHIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private KDLPPIDBMCA[] CIOEPELLEJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int BKCFGGCBDIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private int DGFCMKBONEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private readonly int HKIGGLAJCNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private float GKEJDNNDLMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private CJBAJBILEOB AOKCANBCMAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private JobHandle GPKPPKLLFBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private List<BHKKDHHOFLO> POMDEOMHPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private bool LOKNJNBOMIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private List<Action> NNBBLJICKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private List<Action> FBDKGLJNAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private bool KNKEILAEJLB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public OBIIBECAPAN[] BHDEINEGMGL
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x7040A0", Offset = "0x7034A0", VA = "0x1807040A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int BNJMACNNOJL
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x8C9CF0", Offset = "0x8C90F0", VA = "0x1808C9CF0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x40ADE00", Offset = "0x40AD200", VA = "0x1840ADE00")]
			private static int FANPBOGMFGH(KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x40AF420", Offset = "0x40AE820", VA = "0x1840AF420")]
			public HNKJKJIINJM(KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x40AE200", Offset = "0x40AD600", VA = "0x1840AE200")]
			private void GMDBFLMECHN(ref int IIDONCBLAIA, int CIBMOHIMNON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x40ADA30", Offset = "0x40ACE30", VA = "0x1840ADA30")]
			public void DDJHKBFENAB(GBOIEHAOIPJ FEHFBAFOKDE, KDLPPIDBMCA BHLPLDBMFAK, IEnumerator<KDLPPIDBMCA> GMKGACFAFBM, EKLAHBAJLMJ DNJEDGDMLBC, [Optional] BHKKDHHOFLO LJJKNKODGOE, OMMLBLFEBMN JKENFGDDNKM = OMMLBLFEBMN.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x40AE770", Offset = "0x40ADB70", VA = "0x1840AE770")]
			public void KKHJHPKNKDO(IEnumerable<OFMGMKIEANL> PGIEPFEFDDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x40AE960", Offset = "0x40ADD60", VA = "0x1840AE960")]
			private OFMGMKIEANL LFDNLGLAONA(int OEOELLGDHCP)
			{
				return default(OFMGMKIEANL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x40AE390", Offset = "0x40AD790", VA = "0x1840AE390")]
			private void JGAJFEMENNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1A57CF0", Offset = "0x1A570F0", VA = "0x181A57CF0")]
			private static void DLGBPENIFJC<T>(int OEOELLGDHCP, T[] EJNJPPEBODE, int BLFDIIPJAOG, [Optional] T JBLHECDKPOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1A57CD0", Offset = "0x1A570D0", VA = "0x181A57CD0")]
			private static void DLGBPENIFJC<T>(int OEOELLGDHCP, NativeArray<T> EJNJPPEBODE, int BLFDIIPJAOG, [Optional] T JBLHECDKPOJ) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x40ADE30", Offset = "0x40AD230", VA = "0x1840ADE30")]
			private void FHBLBACILDN(IEnumerable<OFMGMKIEANL> PGIEPFEFDDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x40AED90", Offset = "0x40AE190", VA = "0x1840AED90")]
			private void LGLIMNBKICL(OFMGMKIEANL ELOGOJKKDHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x40ADB60", Offset = "0x40ACF60", VA = "0x1840ADB60")]
			private AEDDKCADLGL EGOPLBBDPGD(int GCDBOBMMDDI)
			{
				return default(AEDDKCADLGL);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x40AD840", Offset = "0x40ACC40", VA = "0x1840AD840")]
			public void BLKHDBIAOHN(float FFDBEAKGHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x40AE0D0", Offset = "0x40AD4D0", VA = "0x1840AE0D0")]
			private void FLABGMGNFJF(Action CFAJBDLFFFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x40AEE50", Offset = "0x40AE250", VA = "0x1840AEE50")]
			private void MLEOCBOJNKP(Action CFAJBDLFFFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x40AEED0", Offset = "0x40AE2D0", VA = "0x1840AEED0")]
			public void NBCKMADCLHD(float FFDBEAKGHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x40AD760", Offset = "0x40ACB60", VA = "0x1840AD760")]
			public void BBBKNPPFDNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x40AE150", Offset = "0x40AD550", VA = "0x1840AE150")]
			public void GHIPHAPLKEH(BHKKDHHOFLO AFFFDCHFIMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x40AE6C0", Offset = "0x40ADAC0", VA = "0x1840AE6C0")]
			public void JJCCILENLCD(BHKKDHHOFLO AFFFDCHFIMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x40AF370", Offset = "0x40AE770", VA = "0x1840AF370")]
			public void OKLBNOKIMEN(BHKKDHHOFLO AFFFDCHFIMM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[BurstCompile]
		public struct CJBAJBILEOB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			[ReadOnly]
			public float FKLKMEOEPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			[ReadOnly]
			public int ILGMFDPKCNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private NativeArray<int> KOFINHHEJLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private NativeArray<int> JLNINKDOGKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private NativeArray<int> ECOMOBDIFPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public NativeArray<OMMLBLFEBMN> EJOPDEEKFBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public NativeArray<float> MDNKGIMDEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			[WriteOnly]
			public NativeArray<int> GPHEGCECBIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			[WriteOnly]
			public NativeArray<int> PBALHBLKPHE;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x40A9290", Offset = "0x40A8690", VA = "0x1840A9290")]
			public static CJBAJBILEOB PPKMIALMIPA(int OBGENJOCPNB, float FFDBEAKGHAA, NativeArray<OMMLBLFEBMN> MIAEPOBNLCK, NativeArray<float> JKICOEOOJPK, NativeArray<int> GFIGPJKFGBI, NativeArray<int> PMDNDGLLJIC, NativeArray<int> DNNBKOHEPCB, NativeArray<int> JLNINKDOGKH, NativeArray<int> ECOMOBDIFPO)
			{
				return default(CJBAJBILEOB);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x40A8EA0", Offset = "0x40A82A0", VA = "0x1840A8EA0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x40A91B0", Offset = "0x40A85B0", VA = "0x1840A91B0")]
			private bool HCPCKCOCIMB(int LDIPPAHPHBL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x40A9260", Offset = "0x40A8660", VA = "0x1840A9260")]
			private void IDOPFFAABFH(NativeArray<int> KBOHOEOKJFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x40A91F0", Offset = "0x40A85F0", VA = "0x1840A91F0")]
			private int ICGFMJBLADH(int FLCLBMBNPPK, int GFBLEJLHICP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x40A8DD0", Offset = "0x40A81D0", VA = "0x1840A8DD0")]
			private void ABGNNODHIMK(NativeArray<int> KBOHOEOKJFM, int MAIDOKMAEOH, int IKKOEAGAHGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x40A8F80", Offset = "0x40A8380", VA = "0x1840A8F80")]
			private void GEKMGJKHMJK(NativeArray<int> KBOHOEOKJFM, int EEJDFPCHLMA, int DDMBOAEMFIG, int NOGNIKLOMMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private sealed class DFLLLCACGBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly EKLAHBAJLMJ DNJEDGDMLBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly Behaviour FEHFBAFOKDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool LHBODOGOIIK;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<KDLPPIDBMCA> PIGPAPAJEIM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x4BF440", Offset = "0x4BE840", VA = "0x1804BF440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public KDLPPIDBMCA JHGMHCALNCJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x4BF450", Offset = "0x4BE850", VA = "0x1804BF450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NJOHODLDJKB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x40AA900", Offset = "0x40A9D00", VA = "0x1840AA900")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool MAOGBLIFAKA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x6BD6C0", Offset = "0x6BCAC0", VA = "0x1806BD6C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x1D944D0", Offset = "0x1D938D0", VA = "0x181D944D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string BJPLMHBJMFB
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x4BFF90", Offset = "0x4BF390", VA = "0x1804BFF90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x4BFFA0", Offset = "0x4BF3A0", VA = "0x1804BFFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float PFACNNMLOLI
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xE5B3E0", Offset = "0xE5A7E0", VA = "0x180E5B3E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xE62A80", Offset = "0xE61E80", VA = "0x180E62A80")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x40AAD50", Offset = "0x40AA150", VA = "0x1840AAD50")]
			public DFLLLCACGBH(IEnumerator<KDLPPIDBMCA> GMKGACFAFBM, Behaviour FEHFBAFOKDE, EKLAHBAJLMJ DNJEDGDMLBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x40AA990", Offset = "0x40A9D90", VA = "0x1840AA990")]
			public KDLPPIDBMCA EMOMNOKMPHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x40AAC30", Offset = "0x40AA030", VA = "0x1840AAC30")]
			public bool MEMBKLECGHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x40AABA0", Offset = "0x40A9FA0", VA = "0x1840AABA0")]
			public void GHIPHAPLKEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x40AACC0", Offset = "0x40AA0C0", VA = "0x1840AACC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x112E640", Offset = "0x112DA40", VA = "0x18112E640")]
			[CompilerGenerated]
			private void LPKOMLHDGFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		private sealed class EKLAHBAJLMJ : OHDKHHGCNEP, HNAKCFLNFIA, NFPFIMOODJO, BJPFHFGNMKO, IEnumerator, KDLPPIDBMCA, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private KKHGNODELBK.DDIFOGHFLLJ GBBGIHBOPJA;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private KKHGNODELBK.DDIFOGHFLLJ MIIFBGPMAMI
			{
				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x4E3290", Offset = "0x4E2690", VA = "0x1804E3290", Slot = "23")]
				get
				{
					return default(KKHGNODELBK.DDIFOGHFLLJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public KKHGNODELBK.DDIFOGHFLLJ JENDMOJGOEM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x4E3290", Offset = "0x4E2690", VA = "0x1804E3290")]
				get
				{
					return default(KKHGNODELBK.DDIFOGHFLLJ);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x6705C0", Offset = "0x66F9C0", VA = "0x1806705C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float FCIEAKHNION
			{
				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0xBB5F70", Offset = "0xBB5370", VA = "0x180BB5F70", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x40AB360", Offset = "0x40AA760", VA = "0x1840AB360", Slot = "24")]
			private bool IMEGOMGNNPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x40AB350", Offset = "0x40AA750", VA = "0x1840AB350", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x40AB380", Offset = "0x40AA780", VA = "0x1840AB380")]
			public EKLAHBAJLMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private enum AEDDKCADLGL : byte
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
		private sealed class MJBJMLAHEGF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public enum EPJEAKGPOND
			{
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			public struct ILLGJKNGPNO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public KKHGNODELBK.DDIFOGHFLLJ EBBFPOHKIPH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public EPJEAKGPOND FFBEMAJALKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public List<DFLLLCACGBH> GKGMEPJHFLC;
			}

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly EPJEAKGPOND[] GIGOLENHHKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly KKHGNODELBK.DDIFOGHFLLJ KBLEINKNKDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private bool AKBMKGJEFOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly DFLLLCACGBH[] KFHDGLLBLHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<DFLLLCACGBH> IBLJCHKODLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly Stack<int> JLEBLKIOACD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<DFLLLCACGBH> OJBJONNGJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly Stack<int> AOMAKFOMMOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private bool KNKEILAEJLB;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public ILLGJKNGPNO[,] BMJOBAJLFKL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x4D2470", Offset = "0x4D1870", VA = "0x1804D2470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int BNJMACNNOJL
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x40B4950", Offset = "0x40B3D50", VA = "0x1840B4950")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x40B5710", Offset = "0x40B4B10", VA = "0x1840B5710")]
			public MJBJMLAHEGF(KKHGNODELBK.DDIFOGHFLLJ OLPGAJOLKFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x40B5230", Offset = "0x40B4630", VA = "0x1840B5230")]
			public void ODHDJMBFHNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x40B5240", Offset = "0x40B4640", VA = "0x1840B5240")]
			public void OPCFKDDHNFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x40B5110", Offset = "0x40B4510", VA = "0x1840B5110")]
			private void OBKPIGLAOPP(IReadOnlyList<DFLLLCACGBH> DPJCPKELAGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x40B5010", Offset = "0x40B4410", VA = "0x1840B5010")]
			public void NFLIAPCHJEI(DFLLLCACGBH GMKGACFAFBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x40B4D90", Offset = "0x40B4190", VA = "0x1840B4D90")]
			public void MAGOHDJPEMG(IList<DFLLLCACGBH> BACMHMFDPHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x40B5250", Offset = "0x40B4650", VA = "0x1840B5250")]
			public void PJPGJNADOPN(IList<DFLLLCACGBH> BACMHMFDPHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x40B4AC0", Offset = "0x40B3EC0", VA = "0x1840B4AC0")]
			private void IAIMNJHIILA(DFLLLCACGBH GMKGACFAFBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x40B54D0", Offset = "0x40B48D0", VA = "0x1840B54D0")]
			private void PLOAOIAKJNG(IList<DFLLLCACGBH> BACMHMFDPHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x40B44C0", Offset = "0x40B38C0", VA = "0x1840B44C0")]
			private AEDDKCADLGL DAAAGIJPGKL(DFLLLCACGBH GMKGACFAFBM)
			{
				return default(AEDDKCADLGL);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x40B48A0", Offset = "0x40B3CA0", VA = "0x1840B48A0")]
			public void ENFJEMPLBDL(float FFDBEAKGHAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x40B42C0", Offset = "0x40B36C0", VA = "0x1840B42C0")]
			public void APMMJPDKGJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x40B4BB0", Offset = "0x40B3FB0", VA = "0x1840B4BB0")]
			private void KDMGCBBEEIC(List<DFLLLCACGBH> BACMHMFDPHM, Stack<int> IPMAKJIMENN, bool FCLBHBFNEPM, float FFEJFEOMIOA = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x40B4640", Offset = "0x40B3A40", VA = "0x1840B4640", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x40B4780", Offset = "0x40B3B80", VA = "0x1840B4780")]
			private void EKBFNHAMJCG(List<DFLLLCACGBH> BACMHMFDPHM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[Flags]
		public enum OMMLBLFEBMN : byte
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
		private sealed class GCPAKMCMNNA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5AACF0", Offset = "0x5AA0F0", VA = "0x1805AACF0")]
			[DebuggerHidden]
			public GCPAKMCMNNA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x40AC6D0", Offset = "0x40ABAD0", VA = "0x1840AC6D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x40AC750", Offset = "0x40ABB50", VA = "0x1840AC750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private const OMMLBLFEBMN HJFELKLJOGN = OMMLBLFEBMN.Cancelled | OMMLBLFEBMN.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly KKHGNODELBK.DDIFOGHFLLJ[] BFCPNMDAFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private MJBJMLAHEGF[] EKJIFPEABKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private HNKJKJIINJM[] DCHHHAJNJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Coroutine BKLFGCLHGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private WaitForEndOfFrame HBAEHCKHOFK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public KKHGNODELBK.DDIFOGHFLLJ NAPHFMMEPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x5430A0", Offset = "0x5424A0", VA = "0x1805430A0")]
			[CompilerGenerated]
			get
			{
				return default(KKHGNODELBK.DDIFOGHFLLJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x5C8770", Offset = "0x5C7B70", VA = "0x1805C8770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KNJODHEFPGH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x6BD3C0", Offset = "0x6BC7C0", VA = "0x1806BD3C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x18765B0", Offset = "0x18759B0", VA = "0x1818765B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int BNJMACNNOJL
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x40B8970", Offset = "0x40B7D70", VA = "0x1840B8970")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x40B76B0", Offset = "0x40B6AB0", VA = "0x1840B76B0")]
		public static HNAKCFLNFIA GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x40B7020", Offset = "0x40B6420", VA = "0x1840B7020", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x40B7930", Offset = "0x40B6D30", VA = "0x1840B7930", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x40B7460", Offset = "0x40B6860", VA = "0x1840B7460")]
		private MJBJMLAHEGF BPBGAAONMFD(KKHGNODELBK.DDIFOGHFLLJ KIIMCIKBPKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2B77780", Offset = "0x2B76B80", VA = "0x182B77780")]
		private HNKJKJIINJM IFILMPHMGMI(KKHGNODELBK.DDIFOGHFLLJ KIIMCIKBPKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x40B7DC0", Offset = "0x40B71C0", VA = "0x1840B7DC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x40B7D90", Offset = "0x40B7190", VA = "0x1840B7D90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x40B8760", Offset = "0x40B7B60", VA = "0x1840B8760")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x40B7570", Offset = "0x40B6970", VA = "0x1840B7570")]
		private void EIMKIHFOKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x40B7500", Offset = "0x40B6900", VA = "0x1840B7500")]
		private void CDFFBMENNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x40B7580", Offset = "0x40B6980", VA = "0x1840B7580")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x40B7760", Offset = "0x40B6B60", VA = "0x1840B7760")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x40B7750", Offset = "0x40B6B50", VA = "0x1840B7750")]
		private void LNOPEHDLMCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x40B74A0", Offset = "0x40B68A0", VA = "0x1840B74A0")]
		[IteratorStateMachine(typeof(GCPAKMCMNNA))]
		private IEnumerator BPPLDCFOOLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x40B8280", Offset = "0x40B7680", VA = "0x1840B8280", Slot = "7")]
		public HNAKCFLNFIA Run(IEnumerator<KDLPPIDBMCA> DHAIKBDOKCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x40B7F60", Offset = "0x40B7360", VA = "0x1840B7F60", Slot = "8")]
		public HNAKCFLNFIA Run(Behaviour FEHFBAFOKDE, IEnumerator<KDLPPIDBMCA> DHAIKBDOKCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x40B7E30", Offset = "0x40B7230", VA = "0x1840B7E30", Slot = "9")]
		public HNAKCFLNFIA RunJobbed(GBOIEHAOIPJ FEHFBAFOKDE, IEnumerator<KDLPPIDBMCA> DHAIKBDOKCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x40B7510", Offset = "0x40B6910", VA = "0x1840B7510", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x40B8290", Offset = "0x40B7690", VA = "0x1840B8290")]
		public void UpdateQueue(KKHGNODELBK.DDIFOGHFLLJ FCIEIFFPFML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x40B7770", Offset = "0x40B6B70", VA = "0x1840B7770")]
		private void OFAAPPOAOIN(MJBJMLAHEGF MHPBLDMKNCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x40B7590", Offset = "0x40B6990", VA = "0x1840B7590")]
		private void GCLFGCDDHKI(HNKJKJIINJM MHPBLDMKNCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x40B8910", Offset = "0x40B7D10", VA = "0x1840B8910")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class LPPOFLKDNDJ
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x40B3AE0", Offset = "0x40B2EE0", VA = "0x1840B3AE0")]
	[ANMKAJMONDH]
	private static void CKCBJFDIGHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class HMAFALJJEOP : ELJNHDJAIEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float IJODHMBEPOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x40AD700", Offset = "0x40ACB00", VA = "0x1840AD700", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float EHBNJPAJEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x40AD710", Offset = "0x40ACB10", VA = "0x1840AD710", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float CADEAEJFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x40AD750", Offset = "0x40ACB50", VA = "0x1840AD750", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HKMGFAPLBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x40AD740", Offset = "0x40ACB40", VA = "0x1840AD740", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double FJHFFJNABNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x40AD720", Offset = "0x40ACB20", VA = "0x1840AD720", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	public HMAFALJJEOP()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class LFOOCLJBDKO
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static byte[] MMIGALFGEBH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static int KKBDIGGLOKN;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int BKPLPABKLDE;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static BigInteger NPDKPCMPDOD;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	public LFOOCLJBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x40B3300", Offset = "0x40B2700", VA = "0x1840B3300")]
	private static string ELDABPJJLIE(byte[] DOIHHFGBAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x40B3400", Offset = "0x40B2800", VA = "0x1840B3400")]
	public static string OCONCCINMFA(byte[] KLJMCJLFPAA, bool NGPDKIFLJKL)
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
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
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

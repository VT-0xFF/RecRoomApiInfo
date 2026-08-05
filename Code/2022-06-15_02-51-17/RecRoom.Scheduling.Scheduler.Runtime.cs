using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> IDEIPOEHEEK(List<PlayerLoopSystem> FMNINNDOGGF, int ODIGOAFCPJL);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct DCIOJKHDCIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct DLNIIHKONNJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static APEBICLOKNP BLHILDIILKH;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4D12C20", Offset = "0x4D11820", VA = "0x184D12C20")]
				public static PlayerLoopSystem BFEGCIHCEJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct LFHCHCEICCM
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static APEBICLOKNP DGKJOPFDLLG;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4D19A80", Offset = "0x4D18680", VA = "0x184D19A80")]
				public static PlayerLoopSystem BFEGCIHCEJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct LPCKLOPFDEC
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static APEBICLOKNP DGJGOAKNHKC;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4D19F10", Offset = "0x4D18B10", VA = "0x184D19F10")]
				public static PlayerLoopSystem BFEGCIHCEJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct NPNJCCEHEME
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static APEBICLOKNP DMBNCEHHHIC;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4D1C6E0", Offset = "0x4D1B2E0", VA = "0x184D1C6E0")]
				public static PlayerLoopSystem BFEGCIHCEJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct LGDDEIFMMEO
			{
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static APEBICLOKNP NCOOEDOKLPB;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4D19C50", Offset = "0x4D18850", VA = "0x184D19C50")]
				public static PlayerLoopSystem BFEGCIHCEJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct EAOBKLKINDA
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class PELEFDPGDEJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000012")]
					public EPPDFNEPEFI.KIEIIHMBKGK key;

					[Cpp2IlInjected.Token(Token = "0x6000025")]
					[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
					public PELEFDPGDEJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000026")]
					[Cpp2IlInjected.Address(RVA = "0x4D1D0F0", Offset = "0x4D1BCF0", VA = "0x184D1D0F0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static IDisposable IFDNAPPNDKL;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4D13370", Offset = "0x4D11F70", VA = "0x184D13370")]
				public static PlayerLoopSystem OEHOECOHEDH(EPPDFNEPEFI.KIEIIHMBKGK OMAJLLKKGPH)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			internal struct OALEBAMIFFG
			{
				[Cpp2IlInjected.Token(Token = "0x2000012")]
				[CompilerGenerated]
				private sealed class PLEKIFOBEKK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public EPPDFNEPEFI.KIEIIHMBKGK key;

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
					public PLEKIFOBEKK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000029")]
					[Cpp2IlInjected.Address(RVA = "0x4D1D1A0", Offset = "0x4D1BDA0", VA = "0x184D1D1A0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x4D1C8B0", Offset = "0x4D1B4B0", VA = "0x184D1C8B0")]
				public static PlayerLoopSystem OEHOECOHEDH(EPPDFNEPEFI.KIEIIHMBKGK OMAJLLKKGPH)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HIEKADOAGNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public HIEKADOAGNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4D15510", Offset = "0x4D14110", VA = "0x184D15510")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GFBELABIIKI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool BNHGFLGNECL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4D0FFE0", Offset = "0x4D0EBE0", VA = "0x184D0FFE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4D11910", Offset = "0x4D10510", VA = "0x184D11910")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4D10020", Offset = "0x4D0EC20", VA = "0x184D10020")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4D11950", Offset = "0x4D10550", VA = "0x184D11950")]
		private static void PBJGKNPNDOO(EPPDFNEPEFI.KIEIIHMBKGK OMAJLLKKGPH, ref PlayerLoopSystem GFPEFPNGBOF, Type CHLDPPOLPLA, Type DCBAEGDNOLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4D11590", Offset = "0x4D10190", VA = "0x184D11590")]
		private static void GINGKKIPLOI(ref PlayerLoopSystem GFPEFPNGBOF, Type CHLDPPOLPLA, Type DCBAEGDNOLH, IDEIPOEHEEK ENKBEMKGAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D11470", Offset = "0x4D10070", VA = "0x184D11470")]
		private static void BIOMAHGCNOB(ref PlayerLoopSystem GFPEFPNGBOF, Type CHLDPPOLPLA, Type DCBAEGDNOLH, PlayerLoopSystem? MPFFGFIDJCG, PlayerLoopSystem? PBAIHKFIOBG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EPPDFNEPEFI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum KIEIIHMBKGK
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class JIBIJNBIBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly KIEIIHMBKGK CGKEIMBMKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly CMIMPGHKLLH EAJKDGOAANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private long JFALLBHDMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long MOHCCHLEGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public long NKMMLHCLOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int NJIFDGEDPOD;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D18D90", Offset = "0x4D17990", VA = "0x184D18D90")]
		public JIBIJNBIBMF(KIEIIHMBKGK FEAFNCFOAGM, int DGLKPGHBJFH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D18AF0", Offset = "0x4D176F0", VA = "0x184D18AF0")]
		public void JFOGBAPPENK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D18B60", Offset = "0x4D17760", VA = "0x184D18B60")]
		public void MKNBLCNBBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D18BC0", Offset = "0x4D177C0", VA = "0x184D18BC0")]
		public void PPOGAKEIGFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static KIEIIHMBKGK[] BCLCEBBDCNH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static JIBIJNBIBMF[] OPOKJCDBOBN;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D14690", Offset = "0x4D13290", VA = "0x184D14690")]
	public static JIBIJNBIBMF DMHNBFLKFKF(KIEIIHMBKGK OMAJLLKKGPH, int DGLKPGHBJFH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D14840", Offset = "0x4D13440", VA = "0x184D14840")]
	public static JIBIJNBIBMF GKNCMBBNJHB(KIEIIHMBKGK OMAJLLKKGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D148D0", Offset = "0x4D134D0", VA = "0x184D148D0")]
	public static void OIOPJBHMLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CMIMPGHKLLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int LMPEBBFGNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Queue<double> IAIGAOAAEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double OCAJMDJLGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double DOMFGMBOICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double FMDDHOIGDIN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double OFKBFEOGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F700", Offset = "0x4D0E300", VA = "0x184D0F700", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F860", Offset = "0x4D0E460", VA = "0x184D0F860")]
	public CMIMPGHKLLH(int GODPLCPNHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F760", Offset = "0x4D0E360", VA = "0x184D0F760", Slot = "4")]
	public void ONBCBDAEBGJ(double IFJECFHDAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F690", Offset = "0x4D0E290", VA = "0x184D0F690", Slot = "5")]
	public void EELNFKPNBAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KIAPJENMPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private long MAKGNGIINDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double DJNBOAMBBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double NBKLGAOJIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double AEOIDLBELBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double PPAHAHOANAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double OCAJMDJLGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double DOMFGMBOICJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long BPKHNEOEKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double OCIOJPHAFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37BD840", Offset = "0x37BC440", VA = "0x1837BD840", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double GBDFABLPOID
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x90CDB0", Offset = "0x90B9B0", VA = "0x18090CDB0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double GKMNLPIFAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x33A4CB0", Offset = "0x33A38B0", VA = "0x1833A4CB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OFKBFEOGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x379B820", Offset = "0x379A420", VA = "0x18379B820", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4D19010", Offset = "0x4D17C10", VA = "0x184D19010", Slot = "7")]
	public void ONBCBDAEBGJ(double IFJECFHDAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4D18FD0", Offset = "0x4D17BD0", VA = "0x184D18FD0", Slot = "8")]
	public void EELNFKPNBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4D19130", Offset = "0x4D17D30", VA = "0x184D19130")]
	public KIAPJENMPJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class AMAJCMFNPKM
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private interface GAIGPGPNBAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool IABGACEDIEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DPCLEGEILBJ();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class OOJPADFJIPN<TPromise, TMainThreadPromise> : GAIGPGPNBAH where TPromise : OBKKHCFLPCB where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly TPromise LCMFACDGLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected readonly TMainThreadPromise JADMLPBPOCI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise BAJOGENCGLO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB060", Offset = "0x2AC9C60", VA = "0x182ACB060")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IABGACEDIEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2ACB0F0", Offset = "0x2AC9CF0", VA = "0x182ACB0F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB140", Offset = "0x2AC9D40", VA = "0x182ACB140")]
		protected OOJPADFJIPN(TPromise LCMFACDGLKC, TMainThreadPromise AHKLBNBMPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB0C0", Offset = "0x2AC9CC0", VA = "0x182ACB0C0", Slot = "5")]
		public void DPCLEGEILBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void GJICELLPNFN(TPromise LCMFACDGLKC);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class HIIKIAILCHL<T> : OOJPADFJIPN<global::KKLFNGHEAIK<T>, global::KHAMONFGMCC<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x404C700", Offset = "0x404B300", VA = "0x18404C700")]
		public HIIKIAILCHL(global::KKLFNGHEAIK<T> LCMFACDGLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x404C4D0", Offset = "0x404B0D0", VA = "0x18404C4D0", Slot = "6")]
		protected override void GJICELLPNFN(global::KKLFNGHEAIK<T> LCMFACDGLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x404C6D0", Offset = "0x404B2D0", VA = "0x18404C6D0")]
		[CompilerGenerated]
		private void MLAHKOMEOCB(T FNMKBJFEJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3298F00", Offset = "0x3297B00", VA = "0x183298F00")]
		[CompilerGenerated]
		private void PKOHCGEFGKL(string FPIPAPLJOPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class BDCNGKKPNAM : GAIGPGPNBAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Action EMKOBNDJJHF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IABGACEDIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x55CFE0", Offset = "0x55BBE0", VA = "0x18055CFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66E830", Offset = "0x66D430", VA = "0x18066E830")]
		public BDCNGKKPNAM(Action EMKOBNDJJHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x109FC30", Offset = "0x109E830", VA = "0x18109FC30", Slot = "5")]
		public void DPCLEGEILBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly List<GAIGPGPNBAH> AMGJCEKACCO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1CCABC0", Offset = "0x1CC97C0", VA = "0x181CCABC0")]
	public static global::KKLFNGHEAIK<T> LDBOHIAAOHM<T>(this global::KKLFNGHEAIK<T> LCMFACDGLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D0EC50", Offset = "0x4D0D850", VA = "0x184D0EC50")]
	public static void LDBOHIAAOHM(Action EMKOBNDJJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1CCAB00", Offset = "0x1CC9700", VA = "0x181CCAB00")]
	private static global::KKLFNGHEAIK<T> HPKGKBMACHM<T>(global::KKLFNGHEAIK<T> LCMFACDGLKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E690", Offset = "0x4D0D290", VA = "0x184D0E690")]
	private static void BMOHGOIJLPN(GAIGPGPNBAH KMIDMEHIIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E880", Offset = "0x4D0D480", VA = "0x184D0E880")]
	private static void DFAKCLBNIIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4D0ECE0", Offset = "0x4D0D8E0", VA = "0x184D0ECE0")]
	private static void NNIIMEKFOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4D0EBA0", Offset = "0x4D0D7A0", VA = "0x184D0EBA0")]
	private static void KAOEFJDPAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class AKILPDIFHHK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GDGOEGFOIBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KOCFEPMOONC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public GDGOEGFOIBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4D14AB0", Offset = "0x4D136B0", VA = "0x184D14AB0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4D14AA0", Offset = "0x4D136A0", VA = "0x184D14AA0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class HHFCPKPMGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public HHFCPKPMGGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4D154E0", Offset = "0x4D140E0", VA = "0x184D154E0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DMILBBJKHBL : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public KOCFEPMOONC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public DMILBBJKHBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4D13110", Offset = "0x4D11D10", VA = "0x184D13110", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4D12DF0", Offset = "0x4D119F0", VA = "0x184D12DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4D131C0", Offset = "0x4D11DC0", VA = "0x184D131C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4D130C0", Offset = "0x4D11CC0", VA = "0x184D130C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KHOFNMGLJHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KOCFEPMOONC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public KHOFNMGLJHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OJGDNCNOAMC : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KOCFEPMOONC onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private KHOFNMGLJHP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public OJGDNCNOAMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4D1C9D0", Offset = "0x4D1B5D0", VA = "0x184D1C9D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4D1CD10", Offset = "0x4D1B910", VA = "0x184D1CD10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static OBKKHCFLPCB EMFCMFBDNIE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static AsyncOperation EMPGGNFKLNP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static OBKKHCFLPCB GCBIGDKPHNK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static string MMJLHLMJKFA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static ThreadPriority NCAHHNIACLO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool PINMCKGAPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E330", Offset = "0x4D0CF30", VA = "0x184D0E330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool MHMLFKPNMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E1E0", Offset = "0x4D0CDE0", VA = "0x184D0E1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool CAELFONGOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E2D0", Offset = "0x4D0CED0", VA = "0x184D0E2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MLMEEJBCJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E130", Offset = "0x4D0CD30", VA = "0x184D0E130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4D0E3D0", Offset = "0x4D0CFD0", VA = "0x184D0E3D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E480", Offset = "0x4D0D080", VA = "0x184D0E480")]
	[ACEHNGBCINE(FAJKELLEMII.EnteredEditModeNextFrame, 0)]
	private static void KFIFABGFHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E530", Offset = "0x4D0D130", VA = "0x184D0E530")]
	public static OBKKHCFLPCB MPINMAELOAM(string JAFDAEOIMII, LoadSceneMode FAIDDNMPNGN = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4D0DE90", Offset = "0x4D0CA90", VA = "0x184D0DE90")]
	public static OBKKHCFLPCB ABDCPGPIJGC(string JAFDAEOIMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E240", Offset = "0x4D0CE40", VA = "0x184D0E240")]
	[IteratorStateMachine(typeof(DMILBBJKHBL))]
	private static IEnumerator<EPJBAFONDLI> CJPEAILLGOG(string JAFDAEOIMII, KOCFEPMOONC EIDFINLLADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E0A0", Offset = "0x4D0CCA0", VA = "0x184D0E0A0")]
	[IteratorStateMachine(typeof(OJGDNCNOAMC))]
	private static IEnumerator<EPJBAFONDLI> BBINLCKJDMI(string JAFDAEOIMII, LoadSceneMode FAIDDNMPNGN, KOCFEPMOONC EIDFINLLADB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class AILIODLKCGE
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CDC0", Offset = "0x4D0B9C0", VA = "0x184D0CDC0")]
	public static IDisposable NFAGAFBEPNI(this PDMOEEOGDEJ MODEPFIKGLJ, float ECLLLLPLAGD, Action<float> AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CD40", Offset = "0x4D0B940", VA = "0x184D0CD40")]
	public static IDisposable EMNNBFMEFMF(this PDMOEEOGDEJ MODEPFIKGLJ, Action<float> AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CE40", Offset = "0x4D0BA40", VA = "0x184D0CE40")]
	public static IDisposable NLHGICEFANF(this PDMOEEOGDEJ MODEPFIKGLJ, Action<float> AILHBGEMHJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class DABMCLFKOCJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4D12040", Offset = "0x4D10C40", VA = "0x184D12040")]
	public static IDisposable KDOKAKJLPPL(this MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4D120C0", Offset = "0x4D10CC0", VA = "0x184D120C0")]
	public static IDisposable KDOKAKJLPPL(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4D11E60", Offset = "0x4D10A60", VA = "0x184D11E60")]
	public static IDisposable JCFJPEDKEOM(this MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4D12440", Offset = "0x4D11040", VA = "0x184D12440")]
	public static IDisposable NEJGJHFJIDB(this MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D11ED0", Offset = "0x4D10AD0", VA = "0x184D11ED0")]
	public static IDisposable KAHMJCMBDPH(this MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D11BB0", Offset = "0x4D107B0", VA = "0x184D11BB0")]
	public static IDisposable CADBGMMEHJA(this MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4D11F40", Offset = "0x4D10B40", VA = "0x184D11F40")]
	public static IDisposable KANKJMEGBKA(this MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4D12300", Offset = "0x4D10F00", VA = "0x184D12300")]
	public static IDisposable LCPIMCKCKMO(this MonoBehaviour GCOFODPNBOA, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4D12540", Offset = "0x4D11140", VA = "0x184D12540")]
	public static IDisposable OELEFHNECIO(this MonoBehaviour GCOFODPNBOA, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4D12270", Offset = "0x4D10E70", VA = "0x184D12270")]
	public static IDisposable KJMLKHFMJGC(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4D124B0", Offset = "0x4D110B0", VA = "0x184D124B0")]
	public static IDisposable NKPGGMMGNNN(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4D11DD0", Offset = "0x4D109D0", VA = "0x184D11DD0")]
	public static IDisposable IOFMJHOGDLG(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4D11C20", Offset = "0x4D10820", VA = "0x184D11C20")]
	public static IDisposable GHMPIJCMGDE(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D11D40", Offset = "0x4D10940", VA = "0x184D11D40")]
	public static IDisposable IBFADCOBPNK(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D11CB0", Offset = "0x4D108B0", VA = "0x184D11CB0")]
	public static IDisposable HIMMBJKKJHM(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4D11FB0", Offset = "0x4D10BB0", VA = "0x184D11FB0")]
	public static IDisposable KCCDFDABJHK(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4D123A0", Offset = "0x4D10FA0", VA = "0x184D123A0")]
	public static IDisposable MJOIAKPOJOD(this MonoBehaviour GCOFODPNBOA, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4D11B20", Offset = "0x4D10720", VA = "0x184D11B20")]
	public static IDisposable BIAIFMDIPMM(this MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LEFAOJLNMKM
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HFKGJLNHIEP : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FPPLBHCJBED.IPEMKCAKNKL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private GAFFDKOHBCP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public HFKGJLNHIEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4D153D0", Offset = "0x4D13FD0", VA = "0x184D153D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4D15490", Offset = "0x4D14090", VA = "0x184D15490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IDFAENHNBFL : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public FPPLBHCJBED.IPEMKCAKNKL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private GAFFDKOHBCP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public IDFAENHNBFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4D15C80", Offset = "0x4D14880", VA = "0x184D15C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4D15D60", Offset = "0x4D14960", VA = "0x184D15D60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D197C0", Offset = "0x4D183C0", VA = "0x184D197C0")]
	public static HGNPLDPHFIE KDOKAKJLPPL(Action AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4D19730", Offset = "0x4D18330", VA = "0x184D19730")]
	public static HGNPLDPHFIE KDOKAKJLPPL(Behaviour MODEPFIKGLJ, Action AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4D198A0", Offset = "0x4D184A0", VA = "0x184D198A0")]
	public static HGNPLDPHFIE KDOKAKJLPPL(Behaviour MODEPFIKGLJ, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4D19980", Offset = "0x4D18580", VA = "0x184D19980")]
	[IteratorStateMachine(typeof(HFKGJLNHIEP))]
	private static IEnumerator<EPJBAFONDLI> MHHIKHAPIEI(FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, Action AILHBGEMHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4D19A00", Offset = "0x4D18600", VA = "0x184D19A00")]
	[IteratorStateMachine(typeof(IDFAENHNBFL))]
	private static IEnumerator<EPJBAFONDLI> MHHIKHAPIEI(FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, Action<float> AILHBGEMHJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PAGCFOPDMNF
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CGAHMGEMAFA : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IPNLILJJKBG schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FPPLBHCJBED.IPEMKCAKNKL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private KOHCNJCHIOK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public CGAHMGEMAFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4D0EEA0", Offset = "0x4D0DAA0", VA = "0x184D0EEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4D0EFD0", Offset = "0x4D0DBD0", VA = "0x184D0EFD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1CE70", Offset = "0x4D1BA70", VA = "0x184D1CE70")]
	public static HGNPLDPHFIE KDOKAKJLPPL(MonoBehaviour GCOFODPNBOA, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1CDA0", Offset = "0x4D1B9A0", VA = "0x184D1CDA0")]
	public static HGNPLDPHFIE JHNEBHGMNMA(PDMOEEOGDEJ MODEPFIKGLJ, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF, bool KGFENHBGCFH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D1CF40", Offset = "0x4D1BB40", VA = "0x184D1CF40")]
	[IteratorStateMachine(typeof(CGAHMGEMAFA))]
	private static IEnumerator<EPJBAFONDLI> MHHIKHAPIEI(IPNLILJJKBG HGKFBMOKPOE, float ECLLLLPLAGD, FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, Action<float> AILHBGEMHJB, bool KGFENHBGCFH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EACMCFLHJCO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PBAINEABJFM : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public FPPLBHCJBED.IPEMKCAKNKL queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public PBAINEABJFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4D1CFF0", Offset = "0x4D1BBF0", VA = "0x184D1CFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D0A0", Offset = "0x4D1BCA0", VA = "0x184D1D0A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4D13210", Offset = "0x4D11E10", VA = "0x184D13210")]
	[IteratorStateMachine(typeof(PBAINEABJFM))]
	private static IEnumerator<EPJBAFONDLI> GIFPKKFFACB(FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF, Func<bool> ANJNLLEMOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4D13290", Offset = "0x4D11E90", VA = "0x184D13290")]
	public static HGNPLDPHFIE KDKANAAAKEJ(this MonoBehaviour GCOFODPNBOA, Func<bool> ANJNLLEMOOJ, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF = FPPLBHCJBED.IPEMKCAKNKL.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JAGMAOBOGKF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class GJBGNDADNMC : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FPPLBHCJBED.IPEMKCAKNKL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public GJBGNDADNMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4D151A0", Offset = "0x4D13DA0", VA = "0x184D151A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4D15260", Offset = "0x4D13E60", VA = "0x184D15260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HNMCIDEHIGG : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public FPPLBHCJBED.IPEMKCAKNKL queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private EPJBAFONDLI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public HNMCIDEHIGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4D15AD0", Offset = "0x4D146D0", VA = "0x184D15AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4D15BA0", Offset = "0x4D147A0", VA = "0x184D15BA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D17B80", Offset = "0x4D16780", VA = "0x184D17B80")]
	[IteratorStateMachine(typeof(GJBGNDADNMC))]
	private static IEnumerator<EPJBAFONDLI> IGCEBGCOOPP(float CLABBBOEICO, FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D17800", Offset = "0x4D16400", VA = "0x184D17800")]
	[IteratorStateMachine(typeof(HNMCIDEHIGG))]
	private static IEnumerator<EPJBAFONDLI> GBAHHEAELMD(float CLABBBOEICO, FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D17980", Offset = "0x4D16580", VA = "0x184D17980")]
	public static IDisposable GMFNJMJFIAG(this MonoBehaviour GCOFODPNBOA, float CLABBBOEICO, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D17C40", Offset = "0x4D16840", VA = "0x184D17C40")]
	public static HGNPLDPHFIE KBLGHDBELHL(this MonoBehaviour GCOFODPNBOA, float CLABBBOEICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D17890", Offset = "0x4D16490", VA = "0x184D17890")]
	public static HGNPLDPHFIE GMFNJMJFIAG(this MonoBehaviour GCOFODPNBOA, float CLABBBOEICO, FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D17CD0", Offset = "0x4D168D0", VA = "0x184D17CD0")]
	public static HGNPLDPHFIE NMEBFOJEBPN(this MonoBehaviour GCOFODPNBOA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4D17E10", Offset = "0x4D16A10", VA = "0x184D17E10")]
	public static HGNPLDPHFIE OJJNEPOEHOJ(this MonoBehaviour GCOFODPNBOA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4D17C10", Offset = "0x4D16810", VA = "0x184D17C10")]
	public static HGNPLDPHFIE JGEPAMEDKPN(this MonoBehaviour GCOFODPNBOA, Action AMKICDJHNKD, [Optional] FINEIBALEHA FDIAJAEBAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4D17760", Offset = "0x4D16360", VA = "0x184D17760")]
	public static HGNPLDPHFIE FJDJKEFPOLL(this MonoBehaviour GCOFODPNBOA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4D175A0", Offset = "0x4D161A0", VA = "0x184D175A0")]
	public static HGNPLDPHFIE APNFFEJJMKE(this MonoBehaviour GCOFODPNBOA, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4D17D70", Offset = "0x4D16970", VA = "0x184D17D70")]
	private static HGNPLDPHFIE NNEKAGPNCOH(MonoBehaviour GCOFODPNBOA, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF, Action AMKICDJHNKD, [Optional] FINEIBALEHA FDIAJAEBAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4D17AF0", Offset = "0x4D166F0", VA = "0x184D17AF0")]
	public static HGNPLDPHFIE HMDLNFLIEOC(this MonoBehaviour GCOFODPNBOA, float AOGOBCHOIEC, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4D17640", Offset = "0x4D16240", VA = "0x184D17640")]
	public static HGNPLDPHFIE BJNLDGMHILC(this MonoBehaviour GCOFODPNBOA, float AOGOBCHOIEC, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4D17A60", Offset = "0x4D16660", VA = "0x184D17A60")]
	public static HGNPLDPHFIE HDAOBDCMFBN(this MonoBehaviour GCOFODPNBOA, float AOGOBCHOIEC, Action AMKICDJHNKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4D176D0", Offset = "0x4D162D0", VA = "0x184D176D0")]
	public static HGNPLDPHFIE DHOAIBHMBII(this MonoBehaviour GCOFODPNBOA, float AOGOBCHOIEC, Action AMKICDJHNKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MKAPCCBGHJL : CNFBGMKFIBN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class MIBLICPICAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public MKAPCCBGHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public MIBLICPICAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4D13FB0", Offset = "0x4D12BB0", VA = "0x184D13FB0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class ENIJPPNDHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public MKAPCCBGHJL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public ENIJPPNDHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4D13FB0", Offset = "0x4D12BB0", VA = "0x184D13FB0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly float NPFBDJCEGLH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D18AA0", Offset = "0x4D176A0", VA = "0x184D18AA0")]
	public MKAPCCBGHJL(Behaviour MODEPFIKGLJ, float NPFBDJCEGLH, [Optional] Action HBKKDNEOGNO, [Optional] FINEIBALEHA FDIAJAEBAPA, [Optional] IPNLILJJKBG HGKFBMOKPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A0E0", Offset = "0x4D18CE0", VA = "0x184D1A0E0", Slot = "9")]
	protected override bool MPMHJHNDIED(Action EMKOBNDJJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A1C0", Offset = "0x4D18DC0", VA = "0x184D1A1C0", Slot = "10")]
	protected override bool NFDDKEHOJBK(Action EMKOBNDJJHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JBOGJFAKOMB
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KLPNPGPAFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IGFBBCHDLJO;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BKGODECFOON(bool IONCMNCHLOC = false);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BKGODECFOON(Action EMKOBNDJJHF, bool IONCMNCHLOC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CNFBGMKFIBN : JBOGJFAKOMB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class GLGOKAMBCBN : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CNFBGMKFIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public GLGOKAMBCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4D152B0", Offset = "0x4D13EB0", VA = "0x184D152B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4D15380", Offset = "0x4D13F80", VA = "0x184D15380", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Behaviour MODEPFIKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Action HBKKDNEOGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private KDNPGCAEIBF CENLBNPIKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly FINEIBALEHA FDIAJAEBAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly IPNLILJJKBG HGKFBMOKPOE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KLPNPGPAFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7559F0", Offset = "0x7545F0", VA = "0x1807559F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IGFBBCHDLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F9D0", Offset = "0x4D0E5D0", VA = "0x184D0F9D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4D0FCF0", Offset = "0x4D0E8F0", VA = "0x184D0FCF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FE10", Offset = "0x4D0EA10", VA = "0x184D0FE10")]
	protected CNFBGMKFIBN(Behaviour MODEPFIKGLJ, [Optional] Action HBKKDNEOGNO, [Optional] FINEIBALEHA FDIAJAEBAPA, [Optional] IPNLILJJKBG HGKFBMOKPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F950", Offset = "0x4D0E550", VA = "0x184D0F950", Slot = "7")]
	public bool BKGODECFOON(bool IONCMNCHLOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F900", Offset = "0x4D0E500", VA = "0x184D0F900", Slot = "8")]
	public bool BKGODECFOON(Action EMKOBNDJJHF, bool IONCMNCHLOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool MPMHJHNDIED(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NFDDKEHOJBK(Action EMKOBNDJJHF);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F9B0", Offset = "0x4D0E5B0", VA = "0x184D0F9B0")]
	protected void FBNMBOJDHKP(Action EMKOBNDJJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FAE0", Offset = "0x4D0E6E0", VA = "0x184D0FAE0")]
	protected OBKKHCFLPCB IEIHFIEMBKF(float CIFILOGOPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FA70", Offset = "0x4D0E670", VA = "0x184D0FA70")]
	private void FOJDIDCPMCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FD90", Offset = "0x4D0E990", VA = "0x184D0FD90")]
	[IteratorStateMachine(typeof(GLGOKAMBCBN))]
	private IEnumerator<EPJBAFONDLI> OPNOJBHIMKB(float CIFILOGOPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4D0FCB0", Offset = "0x4D0E8B0", VA = "0x184D0FCB0")]
	[CompilerGenerated]
	private void NKGAHNGFIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HKDGKALHKAD : CNFBGMKFIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float PLLFGEPOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int AMILPHAADMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float DPPGNILFJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float[] HFPMLDDHJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int FFODKJNAHMO;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4D158C0", Offset = "0x4D144C0", VA = "0x184D158C0")]
	public HKDGKALHKAD(Behaviour MODEPFIKGLJ, float NEIHJOCNACA, int AMILPHAADMK, [Optional] Action HBKKDNEOGNO, float DPPGNILFJOJ = 0f, [Optional] FINEIBALEHA FDIAJAEBAPA, [Optional] IPNLILJJKBG HGKFBMOKPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55CEC0", Offset = "0x55BAC0", VA = "0x18055CEC0", Slot = "9")]
	protected override bool MPMHJHNDIED(Action EMKOBNDJJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D156A0", Offset = "0x4D142A0", VA = "0x184D156A0", Slot = "10")]
	protected override bool NFDDKEHOJBK(Action EMKOBNDJJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D15610", Offset = "0x4D14210", VA = "0x184D15610")]
	private void EEFGPKDCOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JBJDJGJDGIF : CNFBGMKFIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float NPFBDJCEGLH;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D18AA0", Offset = "0x4D176A0", VA = "0x184D18AA0")]
	public JBJDJGJDGIF(Behaviour MODEPFIKGLJ, float NPFBDJCEGLH, [Optional] Action HBKKDNEOGNO, [Optional] FINEIBALEHA FDIAJAEBAPA, [Optional] IPNLILJJKBG HGKFBMOKPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x55CEC0", Offset = "0x55BAC0", VA = "0x18055CEC0", Slot = "9")]
	protected override bool MPMHJHNDIED(Action EMKOBNDJJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D18A60", Offset = "0x4D17660", VA = "0x184D18A60", Slot = "10")]
	protected override bool NFDDKEHOJBK(Action EMKOBNDJJHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class DLAGEOEKOOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GEIJCOBIEAO : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public GEIJCOBIEAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4D14CA0", Offset = "0x4D138A0", VA = "0x184D14CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4D14D40", Offset = "0x4D13940", VA = "0x184D14D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private HGNPLDPHFIE IOEBDGJHGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private PDMOEEOGDEJ MODEPFIKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action<float> DHEAMHPECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private float OIKAOEGHJDN;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4D12A90", Offset = "0x4D11690", VA = "0x184D12A90")]
	public DLAGEOEKOOJ(PDMOEEOGDEJ MODEPFIKGLJ, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4D12940", Offset = "0x4D11540", VA = "0x184D12940")]
	private void OJCFHNFPGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D127C0", Offset = "0x4D113C0", VA = "0x184D127C0")]
	private void JAAOGICCNGI(string FPIPAPLJOPB, Action BMMKJMAEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4D128D0", Offset = "0x4D114D0", VA = "0x184D128D0")]
	[IteratorStateMachine(typeof(GEIJCOBIEAO))]
	private IEnumerator<EPJBAFONDLI> NAOPNKPJDHG(Action BMMKJMAEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D12760", Offset = "0x4D11360", VA = "0x184D12760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D12610", Offset = "0x4D11210", VA = "0x184D12610")]
	[CompilerGenerated]
	private void DGNMCNLAHGK(string GBDFGDELJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class JBIMCGBNPKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class LMGBDCAGMKM : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private EPJBAFONDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
		[DebuggerHidden]
		public LMGBDCAGMKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4D19E20", Offset = "0x4D18A20", VA = "0x184D19E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4D19EC0", Offset = "0x4D18AC0", VA = "0x184D19EC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private HGNPLDPHFIE IOEBDGJHGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private MonoBehaviour GCOFODPNBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Action AILHBGEMHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Action<float> DHEAMHPECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private float OIKAOEGHJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool KGFENHBGCFH;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4D18770", Offset = "0x4D17370", VA = "0x184D18770")]
	public JBIMCGBNPKG(MonoBehaviour GCOFODPNBOA, Action AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4D185E0", Offset = "0x4D171E0", VA = "0x184D185E0")]
	public JBIMCGBNPKG(MonoBehaviour GCOFODPNBOA, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D188C0", Offset = "0x4D174C0", VA = "0x184D188C0")]
	public JBIMCGBNPKG(MonoBehaviour GCOFODPNBOA, float ECLLLLPLAGD, Action<float> AILHBGEMHJB, FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF, bool KGFENHBGCFH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4D181B0", Offset = "0x4D16DB0", VA = "0x184D181B0")]
	private void KDOKAKJLPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4D182D0", Offset = "0x4D16ED0", VA = "0x184D182D0")]
	private void MFGOMFJKDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4D18490", Offset = "0x4D17090", VA = "0x184D18490")]
	private void OJCFHNFPGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4D18090", Offset = "0x4D16C90", VA = "0x184D18090")]
	private void JAAOGICCNGI(string FPIPAPLJOPB, Action BMMKJMAEHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4D18420", Offset = "0x4D17020", VA = "0x184D18420")]
	[IteratorStateMachine(typeof(LMGBDCAGMKM))]
	private IEnumerator<EPJBAFONDLI> NAOPNKPJDHG(Action BMMKJMAEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4D17F30", Offset = "0x4D16B30", VA = "0x184D17F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4D18010", Offset = "0x4D16C10", VA = "0x184D18010")]
	[CompilerGenerated]
	private void HDEEJCNEGJM(string GBDFGDELJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4D17F90", Offset = "0x4D16B90", VA = "0x184D17F90")]
	[CompilerGenerated]
	private void FCOFGAHILJB(string GBDFGDELJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4D17EB0", Offset = "0x4D16AB0", VA = "0x184D17EB0")]
	[CompilerGenerated]
	private void AKNLGHBECKI(string GBDFGDELJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Flags]
internal enum IIKBDDKADOH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class NEEGDMNPMPI : IPNLILJJKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float DJLINMBFCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4D1A3A0", Offset = "0x4D18FA0", VA = "0x184D1A3A0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float ALGFPPCDDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4D1A2A0", Offset = "0x4D18EA0", VA = "0x184D1A2A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double IFMBJGMEEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4D1A2B0", Offset = "0x4D18EB0", VA = "0x184D1A2B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A2D0", Offset = "0x4D18ED0", VA = "0x184D1A2D0")]
	[OBNHMGHBLAL]
	private static void HAHCOHFGDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	[Preserve]
	internal NEEGDMNPMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal interface LMOAHKMJMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIBDLBMPPLL(string HBGNDBNJDEC);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKHAOJNHHAO();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal interface DMKIPGEMDOC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	string GBBNAEGPONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LGAGHLEMPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool DEBNALHGLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal class GGMKNPKNDHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public NLNADCKDMFB HGKJEHMKAIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int LCGDBDLDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x55CED0", Offset = "0x55BAD0", VA = "0x18055CED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x55CEE0", Offset = "0x55BAE0", VA = "0x18055CEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4D14E90", Offset = "0x4D13A90", VA = "0x184D14E90")]
	public static EPJBAFONDLI LEFCKIOMNOB(IEnumerator<EPJBAFONDLI> EDDNKHPOIOE, BLKPPGEBPAA PKLMFFLCDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4D14FF0", Offset = "0x4D13BF0", VA = "0x184D14FF0")]
	public EPJBAFONDLI LEFCKIOMNOB(BLKPPGEBPAA[] GPIBPJELAOB, IEnumerator<EPJBAFONDLI>[] DBCIKPFNPDP, EPJBAFONDLI[] IFLHMLLNNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4D14D90", Offset = "0x4D13990", VA = "0x184D14D90")]
	public void AJBBDKMHJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4D14DC0", Offset = "0x4D139C0", VA = "0x184D14DC0")]
	public void DGBIJIGLEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4D150D0", Offset = "0x4D13CD0", VA = "0x184D150D0")]
	public void OGJBCLPGNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4D14D90", Offset = "0x4D13990", VA = "0x184D14D90")]
	public void PJLIABPEHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public GGMKNPKNDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NLNADCKDMFB
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BFLEJOGNAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public GGMKNPKNDHF ICHBCLMIEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public PDMOEEOGDEJ LLFCMFKGKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BLKPPGEBPAA FOALNDEPENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public IEnumerator<EPJBAFONDLI> JFKPPMLDFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public EPJBAFONDLI KPFFOKHHIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public IIKBDDKADOH OJODGEOGOEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct FPCONCHADGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public FPPLBHCJBED.IPEMKCAKNKL PDHKFCKONBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public List<BFLEJOGNAIK> PJMDEPBNIMO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EOOCKKONHOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public NLNADCKDMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public PDMOEEOGDEJ context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GGMKNPKNDHF routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public IIKBDDKADOH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public BLKPPGEBPAA promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public EPJBAFONDLI currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public IEnumerator<EPJBAFONDLI> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public EOOCKKONHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4D13FE0", Offset = "0x4D12BE0", VA = "0x184D13FE0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OMOBCANEKLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public GGMKNPKNDHF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NLNADCKDMFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public OMOBCANEKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4D1CD60", Offset = "0x4D1B960", VA = "0x184D1CD60")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class KOHLIPBOBGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public GGMKNPKNDHF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public NLNADCKDMFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public KOHLIPBOBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4D19160", Offset = "0x4D17D60", VA = "0x184D19160")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DCNMMDCGDGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GGMKNPKNDHF schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NLNADCKDMFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
		public DCNMMDCGDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4D125D0", Offset = "0x4D111D0", VA = "0x184D125D0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private const IIKBDDKADOH OMKKFENBHDI = IIKBDDKADOH.Cancelled | IIKBDDKADOH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool[] MOHDFLHKLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private NativeArray<IIKBDDKADOH> KHFOGCFCPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private NativeArray<float> PLEFJIMLKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NativeArray<int> GKDODKKENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private NativeArray<int> HOHOACLBCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private NativeArray<int> GDCGJDLGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private NativeArray<int> MFIICJGAOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private NativeArray<int> DEIDPDLPMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private GGMKNPKNDHF[] HHIADNLMCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private BLKPPGEBPAA[] GPIBPJELAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private PDMOEEOGDEJ[] EEOIBEMNDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private IEnumerator<EPJBAFONDLI>[] CDGNHEAKGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private EPJBAFONDLI[] ELHJBAIEAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int FPCEGOBOGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int HNBFBADKDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly int FPNIFIMMJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float LGFKFCLNBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private LBLJCHDHFHN MDNMPLIPKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private JobHandle NPAKPGAIIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private List<GGMKNPKNDHF> JOFMOEFGOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool ODAMMFOPNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private List<Action> PEAKALGGALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private List<Action> EBNAEMLIGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool KAMCMJGIEND;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FPCONCHADGJ[] NMCAGCAHPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86B420", Offset = "0x86A020", VA = "0x18086B420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BE70", Offset = "0x4D1AA70", VA = "0x184D1BE70")]
	private static int OOAFFENDCCE(FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C180", Offset = "0x4D1AD80", VA = "0x184D1C180")]
	public NLNADCKDMFB(FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B520", Offset = "0x4D1A120", VA = "0x184D1B520")]
	private void JCHMKANODBH(ref int IHFOJJIBALC, int LOAGEOFDMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4D1C020", Offset = "0x4D1AC20", VA = "0x184D1C020")]
	public void PNFJADOGPGJ(PDMOEEOGDEJ MODEPFIKGLJ, EPJBAFONDLI JMKMAOLCGKG, IEnumerator<EPJBAFONDLI> EDDNKHPOIOE, BLKPPGEBPAA PKLMFFLCDAI, [Optional] GGMKNPKNDHF EPGELHBLELD, IIKBDDKADOH BBIGLNHJBIE = IIKBDDKADOH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4D1AEB0", Offset = "0x4D19AB0", VA = "0x184D1AEB0")]
	public void GPAHMPBLPOK(IEnumerable<BFLEJOGNAIK> NAFNAKFLLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B0A0", Offset = "0x4D19CA0", VA = "0x184D1B0A0")]
	private BFLEJOGNAIK HLAMGKCLJCK(int AGHLOHEICMA)
	{
		return default(BFLEJOGNAIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A9A0", Offset = "0x4D195A0", VA = "0x184D1A9A0")]
	private void DJOFFPAPJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x311ED30", Offset = "0x311D930", VA = "0x18311ED30")]
	private static void KNCFDMNGPOK<T>(int AGHLOHEICMA, T[] FHGDGLBOFPP, int BNLHOMCBDLM, [Optional] T FIAGPGNDNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x311ED10", Offset = "0x311D910", VA = "0x18311ED10")]
	private static void KNCFDMNGPOK<T>(int AGHLOHEICMA, NativeArray<T> FHGDGLBOFPP, int BNLHOMCBDLM, [Optional] T FIAGPGNDNEK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BB50", Offset = "0x4D1A750", VA = "0x184D1BB50")]
	private void MALAJDLMEHH(IEnumerable<BFLEJOGNAIK> NAFNAKFLLGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BEA0", Offset = "0x4D1AAA0", VA = "0x184D1BEA0")]
	private void PAOLBPDKHKE(BFLEJOGNAIK ABIHAGLFKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A6E0", Offset = "0x4D192E0", VA = "0x184D1A6E0")]
	private MNCBGCHIFGA DFOMHFBCEEC(int DGPJKPNHJAH)
	{
		return default(MNCBGCHIFGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A4F0", Offset = "0x4D190F0", VA = "0x184D1A4F0")]
	public void CIEBFHLJAAA(float INBGBNHMBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A3B0", Offset = "0x4D18FB0", VA = "0x184D1A3B0")]
	private void ADLPOGOCENA(Action BDJKEBGEAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BDF0", Offset = "0x4D1A9F0", VA = "0x184D1BDF0")]
	private void ODAGGLHKMDI(Action BDJKEBGEAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B6B0", Offset = "0x4D1A2B0", VA = "0x184D1B6B0")]
	public void LBEEPCFMBFB(float INBGBNHMBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4D1AD10", Offset = "0x4D19910", VA = "0x184D1AD10")]
	public void GGKDCAFHFBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4D1BF60", Offset = "0x4D1AB60", VA = "0x184D1BF60")]
	public void PJLIABPEHIL(GGMKNPKNDHF JODODLINENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4D1ADF0", Offset = "0x4D199F0", VA = "0x184D1ADF0")]
	public void GOOIIPOPHPA(GGMKNPKNDHF JODODLINENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A430", Offset = "0x4D19030", VA = "0x184D1A430")]
	public void BPHELCHBJNP(GGMKNPKNDHF JODODLINENP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HNEBBCIKGPB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static readonly HNEBBCIKGPB PGBMEHBJKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Action HKOLKJEOADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool ECJKNINNBDC;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x66E830", Offset = "0x66D430", VA = "0x18066E830")]
	public HNEBBCIKGPB(Action HKOLKJEOADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4D159D0", Offset = "0x4D145D0", VA = "0x184D159D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface AAICKOPABAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable CPDOEHOAMOL(UnityEngine.Object MODEPFIKGLJ, Action<T> EAENFIKPIJK);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KDGANKPJEHG<T> : global::AAICKOPABAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	new T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JDENILKAOCL<T> : global::KDGANKPJEHG<T>, global::AAICKOPABAH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class KJGMLGKPENH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public global::JDENILKAOCL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public global::GKDODOGLPIN<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
		public KJGMLGKPENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x33E5ED0", Offset = "0x33E4AD0", VA = "0x1833E5ED0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static GameObject KNAELDPBEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<global::GKDODOGLPIN<UnityEngine.Object, Action<T>>> BFCBMFKAAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private T NBEFAHPHHJH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T HNBDKKLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6CE8C0", Offset = "0x6CD4C0", VA = "0x1806CE8C0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x33E2170", Offset = "0x33E0D70", VA = "0x1833E2170", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x33E2110", Offset = "0x33E0D10", VA = "0x1833E2110")]
	private static bool GFMICOCIMOO(T BDJKEBGEAJO, T GONCOEMNHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x33E2250", Offset = "0x33E0E50", VA = "0x1833E2250")]
	public JDENILKAOCL(T MEALACMCKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x33E1E20", Offset = "0x33E0A20", VA = "0x1833E1E20", Slot = "6")]
	public IDisposable CPDOEHOAMOL(UnityEngine.Object MODEPFIKGLJ, Action<T> EAENFIKPIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x33E1B00", Offset = "0x33E0700", VA = "0x1833E1B00")]
	private void CNBEFOEJDED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[BurstCompile]
internal struct LBLJCHDHFHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	public float CKOPJCIMGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[ReadOnly]
	public int AHFCGJKNNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NativeArray<int> MOKOHIMGDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private NativeArray<int> HJOGLJOFOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NativeArray<int> AIICOKIMKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<IIKBDDKADOH> LJKHDKKPEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[ReadOnly]
	public NativeArray<float> DJFACHJNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[WriteOnly]
	public NativeArray<int> GDCGJDLGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[WriteOnly]
	public NativeArray<int> GKDODKKENMC;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4D19430", Offset = "0x4D18030", VA = "0x184D19430")]
	public static LBLJCHDHFHN KGHLJHHMDNN(int GOFBFDCLNIF, float INBGBNHMBED, NativeArray<IIKBDDKADOH> ELDGPPJIHMD, NativeArray<float> HLLOKKHPLMI, NativeArray<int> NMAHBKEMPMO, NativeArray<int> GDOONJGOIMF, NativeArray<int> CNFGANLMNAC, NativeArray<int> HJOGLJOFOLH, NativeArray<int> AIICOKIMKJF)
	{
		return default(LBLJCHDHFHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4D19210", Offset = "0x4D17E10", VA = "0x184D19210", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4D191D0", Offset = "0x4D17DD0", VA = "0x184D191D0")]
	private bool DNKJLBDJOGN(int PMMFOLCEJEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4D191A0", Offset = "0x4D17DA0", VA = "0x184D191A0")]
	private void DLPNEIDKDKA(NativeArray<int> IBOIIFMFFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4D193C0", Offset = "0x4D17FC0", VA = "0x184D193C0")]
	private int GNFHKPBLJAK(int IDPICBCGFEO, int EONCPEEHHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4D192F0", Offset = "0x4D17EF0", VA = "0x184D192F0")]
	private void GDBLENDLAIJ(NativeArray<int> IBOIIFMFFDC, int HOJGIKMLMGG, int FCEMJGPANOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4D19500", Offset = "0x4D18100", VA = "0x184D19500")]
	private void OJIODMGPDPJ(NativeArray<int> IBOIIFMFFDC, int OCCADDBNMDI, int HHFHIGJPGPP, int CIDCFECGBLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EICCBOLJANE : AJGIFMIGMFL, FINEIBALEHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NLNADCKDMFB[] DLAEBKANHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private LMOAHKMJMHD JBBEFHENEAB;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4D13930", Offset = "0x4D12530", VA = "0x184D13930")]
	[OBNHMGHBLAL]
	private static void HAHCOHFGDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4D13EF0", Offset = "0x4D12AF0", VA = "0x184D13EF0")]
	[Preserve]
	public EICCBOLJANE([MOCCILPMCBP(null)] GMAIBHECFBP NIOPECJAELO, [MOCCILPMCBP(null)] IPNLILJJKBG HGKFBMOKPOE, [MOCCILPMCBP(null)] CFFEJKEPGPE BOFOMKLHGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4D13490", Offset = "0x4D12090", VA = "0x184D13490", Slot = "12")]
	public override HGNPLDPHFIE AHMGNJGHBPN(PDMOEEOGDEJ MODEPFIKGLJ, IEnumerator<EPJBAFONDLI> EDHGLCFFCCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4D13670", Offset = "0x4D12270", VA = "0x184D13670", Slot = "13")]
	public override void EELNFKPNBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4D13B90", Offset = "0x4D12790", VA = "0x184D13B90", Slot = "15")]
	public override void MOEBOINPIME(FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4D13AB0", Offset = "0x4D126B0", VA = "0x184D13AB0", Slot = "14")]
	protected override void JCFJPEDKEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4D135C0", Offset = "0x4D121C0", VA = "0x184D135C0")]
	private NLNADCKDMFB APNLCNKCLBC(FPPLBHCJBED.IPEMKCAKNKL CEEEOOFNMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4D13A00", Offset = "0x4D12600", VA = "0x184D13A00", Slot = "16")]
	internal override CGJOOPCBBPH IOJKALKGNDK(IEnumerator<EPJBAFONDLI> EDHGLCFFCCL, Behaviour MODEPFIKGLJ, BLKPPGEBPAA PKLMFFLCDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4D13E80", Offset = "0x4D12A80", VA = "0x184D13E80", Slot = "17")]
	internal override IEFBNELEDHC PMGKIBEDCDK(FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4D13D60", Offset = "0x4D12960", VA = "0x184D13D60")]
	private void OBFJPDOGGPM(NLNADCKDMFB BCEKEOJJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4D13600", Offset = "0x4D12200", VA = "0x184D13600", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class AJGIFMIGMFL : FINEIBALEHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly GMAIBHECFBP NIOPECJAELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly IPNLILJJKBG HGKFBMOKPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly CFFEJKEPGPE BOFOMKLHGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private IEFBNELEDHC[] LHEGIBMDIIC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static FINEIBALEHA PMDDBIJFNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4D0D610", Offset = "0x4D0C210", VA = "0x184D0D610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static bool LBIJBKHNALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x55CFE0", Offset = "0x55BBE0", VA = "0x18055CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FPPLBHCJBED.IPEMKCAKNKL BHKJBFKIMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x55CED0", Offset = "0x55BAD0", VA = "0x18055CED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FPPLBHCJBED.IPEMKCAKNKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x55CEE0", Offset = "0x55BAE0", VA = "0x18055CEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IPNLILJJKBG KNKCKHOHFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF0", Offset = "0x55D9F0", VA = "0x18055EDF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4D0DB40", Offset = "0x4D0C740", VA = "0x184D0DB40")]
	public static HGNPLDPHFIE NKIEJMJIMGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0DBE0", Offset = "0x4D0C7E0", VA = "0x184D0DBE0")]
	[Preserve]
	protected AJGIFMIGMFL([MOCCILPMCBP(null)] GMAIBHECFBP NIOPECJAELO, [MOCCILPMCBP(null)] IPNLILJJKBG HGKFBMOKPOE, [MOCCILPMCBP(null)] CFFEJKEPGPE BOFOMKLHGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D100", Offset = "0x4D0BD00", VA = "0x184D0D100", Slot = "6")]
	public HGNPLDPHFIE BMAAMPIADME(IEnumerator<EPJBAFONDLI> EDHGLCFFCCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CEE0", Offset = "0x4D0BAE0", VA = "0x184D0CEE0", Slot = "7")]
	public HGNPLDPHFIE BMAAMPIADME(Behaviour MODEPFIKGLJ, IEnumerator<EPJBAFONDLI> EDHGLCFFCCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract HGNPLDPHFIE AHMGNJGHBPN(PDMOEEOGDEJ MODEPFIKGLJ, IEnumerator<EPJBAFONDLI> EDHGLCFFCCL);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D430", Offset = "0x4D0C030", VA = "0x184D0D430", Slot = "13")]
	public virtual void EELNFKPNBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D110", Offset = "0x4D0BD10", VA = "0x184D0D110", Slot = "9")]
	public void CINBNLEHDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D8B0", Offset = "0x4D0C4B0", VA = "0x184D0D8B0", Slot = "14")]
	protected virtual void JCFJPEDKEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4D0CEC0", Offset = "0x4D0BAC0", VA = "0x184D0CEC0")]
	private void BLHILDIILKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D190", Offset = "0x4D0BD90", VA = "0x184D0D190")]
	private void DGKJOPFDLLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4D0DB20", Offset = "0x4D0C720", VA = "0x184D0DB20")]
	private void NEJGJHFJIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D8D0", Offset = "0x4D0C4D0", VA = "0x184D0D8D0")]
	private void KAHMJCMBDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D170", Offset = "0x4D0BD70", VA = "0x184D0D170")]
	private void DGJGOAKNHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D890", Offset = "0x4D0C490", VA = "0x184D0D890")]
	private void IKLBPMMINBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D8F0", Offset = "0x4D0C4F0", VA = "0x184D0D8F0", Slot = "15")]
	public virtual void MOEBOINPIME(FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D6D0", Offset = "0x4D0C2D0", VA = "0x184D0D6D0")]
	private void IBIDJJLLLEO(IEFBNELEDHC BCEKEOJJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x744140", Offset = "0x742D40", VA = "0x180744140")]
	private IEFBNELEDHC FKFPLCNDAEH(FPPLBHCJBED.IPEMKCAKNKL CEEEOOFNMPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract CGJOOPCBBPH IOJKALKGNDK(IEnumerator<EPJBAFONDLI> EDHGLCFFCCL, Behaviour GCOFODPNBOA, BLKPPGEBPAA MNPKNCJBABI);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract IEFBNELEDHC PMGKIBEDCDK(FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0D1B0", Offset = "0x4D0BDB0", VA = "0x184D0D1B0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class CGJOOPCBBPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly BLKPPGEBPAA PKLMFFLCDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly DMKIPGEMDOC MODEPFIKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly bool DIGHHMBOCJF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEnumerator<EPJBAFONDLI> JFKPPMLDFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EPJBAFONDLI KPFFOKHHIPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x55C4A0", Offset = "0x55B0A0", VA = "0x18055C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OFLNDKCMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4D0F300", Offset = "0x4D0DF00", VA = "0x184D0F300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BICKEFLIGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x77BDE0", Offset = "0x77A9E0", VA = "0x18077BDE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2206260", Offset = "0x2204E60", VA = "0x182206260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string GBBNAEGPONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x55D010", Offset = "0x55BC10", VA = "0x18055D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x55D020", Offset = "0x55BC20", VA = "0x18055D020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float CGDPFGGHCOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x10E6DE0", Offset = "0x10E59E0", VA = "0x1810E6DE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x10F1440", Offset = "0x10F0040", VA = "0x1810F1440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F4A0", Offset = "0x4D0E0A0", VA = "0x184D0F4A0")]
	public CGJOOPCBBPH(IEnumerator<EPJBAFONDLI> EDDNKHPOIOE, DMKIPGEMDOC MODEPFIKGLJ, BLKPPGEBPAA PKLMFFLCDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F090", Offset = "0x4D0DC90", VA = "0x184D0F090")]
	public EPJBAFONDLI LEFCKIOMNOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F020", Offset = "0x4D0DC20", VA = "0x184D0F020")]
	public bool AOFGJFDANLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F380", Offset = "0x4D0DF80", VA = "0x184D0F380")]
	public void PJLIABPEHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4D0F410", Offset = "0x4D0E010", VA = "0x184D0F410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xF00680", Offset = "0xEFF280", VA = "0x180F00680")]
	[CompilerGenerated]
	private void GCJNJJNAHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class BLKPPGEBPAA : KNEKLCAGMIH, HGNPLDPHFIE, KDNPGCAEIBF, OBKKHCFLPCB, IEnumerator, EPJBAFONDLI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private FPPLBHCJBED.IPEMKCAKNKL ACKGFBJEEBO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private FPPLBHCJBED.IPEMKCAKNKL EMFLNKPLOLI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x581180", Offset = "0x57FD80", VA = "0x180581180", Slot = "23")]
		get
		{
			return default(FPPLBHCJBED.IPEMKCAKNKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FPPLBHCJBED.IPEMKCAKNKL HGKJEHMKAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6D46F0", Offset = "0x6D32F0", VA = "0x1806D46F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private float JMLPDKEEIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xD72BC0", Offset = "0xD717C0", VA = "0x180D72BC0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4D0EE20", Offset = "0x4D0DA20", VA = "0x184D0EE20", Slot = "24")]
	private bool HEGOAIPINJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4D0EE10", Offset = "0x4D0DA10", VA = "0x184D0EE10", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4D0EE40", Offset = "0x4D0DA40", VA = "0x184D0EE40")]
	public BLKPPGEBPAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal enum MNCBGCHIFGA : byte
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
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class IEFBNELEDHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum LEGCKLFOELJ
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct CJEEMJPMGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public FPPLBHCJBED.IPEMKCAKNKL PDHKFCKONBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public LEGCKLFOELJ BFGPMBGAIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<CGJOOPCBBPH> CFBHFMNDGBO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly LEGCKLFOELJ[] FNGJMOKPGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly FPPLBHCJBED.IPEMKCAKNKL FEOJJMLLDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool MPOIJGDEELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly CGJOOPCBBPH[] MODHJAPEGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<CGJOOPCBBPH> DNNKOJIMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly Stack<int> EDANDBCPEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly List<CGJOOPCBBPH> BIGHIJLMCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly Stack<int> PAAAICIBPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly LMOAHKMJMHD LBPGINFPONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private bool KAMCMJGIEND;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CJEEMJPMGDF[,] KPFOEKJCKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5AF130", Offset = "0x5ADD30", VA = "0x1805AF130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4D17020", Offset = "0x4D15C20", VA = "0x184D17020")]
	public IEFBNELEDHC(FPPLBHCJBED.IPEMKCAKNKL OGJLAKCLDDA, LMOAHKMJMHD LBPGINFPONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4D16A20", Offset = "0x4D15620", VA = "0x184D16A20")]
	public void ODDLLDCMPDP(CGJOOPCBBPH EDDNKHPOIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4D16CC0", Offset = "0x4D158C0", VA = "0x184D16CC0")]
	public void ONDNGECCLBH(IList<CGJOOPCBBPH> DBCIKPFNPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4D167A0", Offset = "0x4D153A0", VA = "0x184D167A0")]
	public void NGOPIGCLCDG(IList<CGJOOPCBBPH> DBCIKPFNPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4D162D0", Offset = "0x4D14ED0", VA = "0x184D162D0")]
	private void IDODDMDMAOC(CGJOOPCBBPH EDDNKHPOIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4D16630", Offset = "0x4D15230", VA = "0x184D16630")]
	private void NDJCDGIDABI(IList<CGJOOPCBBPH> DBCIKPFNPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4D16B40", Offset = "0x4D15740", VA = "0x184D16B40")]
	private MNCBGCHIFGA OFNIJNAALAE(CGJOOPCBBPH EDDNKHPOIOE)
	{
		return default(MNCBGCHIFGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4D163C0", Offset = "0x4D14FC0", VA = "0x184D163C0")]
	public void JCFJPEDKEOM(float INBGBNHMBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4D15F90", Offset = "0x4D14B90", VA = "0x184D15F90")]
	public void CINBNLEHDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4D15DB0", Offset = "0x4D149B0", VA = "0x184D15DB0")]
	private void ADOCIPDMGGJ(List<CGJOOPCBBPH> DBCIKPFNPDP, Stack<int> PBBPMHMINPO, bool PHOONDIKCCF, float GBMJEJNCANH = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4D16190", Offset = "0x4D14D90", VA = "0x184D16190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4D16510", Offset = "0x4D15110", VA = "0x184D16510")]
	private void KHEJEDJACML(List<CGJOOPCBBPH> DBCIKPFNPDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class BOECIGAEECO : LMOAHKMJMHD
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "4")]
	public void EIBDLBMPPLL(string HBGNDBNJDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
	public void FKHAOJNHHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public BOECIGAEECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class IEGEAEFHHAD : DMKIPGEMDOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Behaviour GCOFODPNBOA;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string GBBNAEGPONH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4D17510", Offset = "0x4D16110", VA = "0x184D17510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool LGAGHLEMPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4D174B0", Offset = "0x4D160B0", VA = "0x184D174B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool DEBNALHGLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4D17490", Offset = "0x4D16090", VA = "0x184D17490", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x66E830", Offset = "0x66D430", VA = "0x18066E830")]
	public IEGEAEFHHAD(Behaviour GCOFODPNBOA)
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

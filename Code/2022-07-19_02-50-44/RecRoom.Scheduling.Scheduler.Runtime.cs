using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HBDKCNAHIIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority GKCEBAAEGOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4727F10", Offset = "0x4726F10", VA = "0x184727F10")]
	public HBDKCNAHIIA(ThreadPriority HNFDDAAMGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4727F00", Offset = "0x4726F00", VA = "0x184727F00", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> DPGLHEOLELJ(List<PlayerLoopSystem> LCJMLAKNLBL, int LJLIGCIAJEH);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct NJBHFMMDLJN
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PEFIPBCOECJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static IPAFKFONBKE LFDMFJNGNPN;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x47314A0", Offset = "0x47304A0", VA = "0x1847314A0")]
				public static PlayerLoopSystem LPCEKMCMCDD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GHBNBAFOHIC
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static IPAFKFONBKE AEBHKLEILFE;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4727C40", Offset = "0x4726C40", VA = "0x184727C40")]
				public static PlayerLoopSystem LPCEKMCMCDD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct HNACJOEJIHN
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static IPAFKFONBKE CMMFMKNJPII;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x47299F0", Offset = "0x47289F0", VA = "0x1847299F0")]
				public static PlayerLoopSystem LPCEKMCMCDD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct PJFMJCHCMML
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static IPAFKFONBKE MNECMCFJNMP;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x4731CE0", Offset = "0x4730CE0", VA = "0x184731CE0")]
				public static PlayerLoopSystem LPCEKMCMCDD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct LABKAOFOBJL
			{
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static IPAFKFONBKE FOLPHACDJJI;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x472BE60", Offset = "0x472AE60", VA = "0x18472BE60")]
				public static PlayerLoopSystem LPCEKMCMCDD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			internal struct DJGDPBOPHAO
			{
				[Cpp2IlInjected.Token(Token = "0x2000011")]
				[CompilerGenerated]
				private sealed class KKICLMCHGBM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public ONEOLIEPJKO.IGJFIGINLHG key;

					[Cpp2IlInjected.Token(Token = "0x6000027")]
					[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
					public KKICLMCHGBM()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x472B340", Offset = "0x472A340", VA = "0x18472B340")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IDisposable HLPBICGOGHC;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x4725640", Offset = "0x4724640", VA = "0x184725640")]
				public static PlayerLoopSystem BDDHDLPIOHN(ONEOLIEPJKO.IGJFIGINLHG DDFHJDPPNBF)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			internal struct HIGPEGOHMKM
			{
				[Cpp2IlInjected.Token(Token = "0x2000013")]
				[CompilerGenerated]
				private sealed class ICDLNKNEKAH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000014")]
					public ONEOLIEPJKO.IGJFIGINLHG key;

					[Cpp2IlInjected.Token(Token = "0x600002A")]
					[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
					public ICDLNKNEKAH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600002B")]
					[Cpp2IlInjected.Address(RVA = "0x4729BC0", Offset = "0x4728BC0", VA = "0x184729BC0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x47281D0", Offset = "0x47271D0", VA = "0x1847281D0")]
				public static PlayerLoopSystem BDDHDLPIOHN(ONEOLIEPJKO.IGJFIGINLHG DDFHJDPPNBF)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JEOPPCIKCEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
			public JEOPPCIKCEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x472B210", Offset = "0x472A210", VA = "0x18472B210")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OLILOAGIEIC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool DDKBJOHPKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4725060", Offset = "0x4724060", VA = "0x184725060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x47249B0", Offset = "0x47239B0", VA = "0x1847249B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4723560", Offset = "0x4722560", VA = "0x184723560")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4724D70", Offset = "0x4723D70", VA = "0x184724D70")]
		private static void FELKKGFMIKL(ONEOLIEPJKO.IGJFIGINLHG DDFHJDPPNBF, ref PlayerLoopSystem KFJINJGIJGM, Type HDBPEIJLFAH, Type MODGANHDLPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x47249F0", Offset = "0x47239F0", VA = "0x1847249F0")]
		private static void DOPJOKLOADH(ref PlayerLoopSystem KFJINJGIJGM, Type HDBPEIJLFAH, Type MODGANHDLPI, DPGLHEOLELJ EMBENGMAHND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4724F40", Offset = "0x4723F40", VA = "0x184724F40")]
		private static void HHHPNDNCKNF(ref PlayerLoopSystem KFJINJGIJGM, Type HDBPEIJLFAH, Type MODGANHDLPI, PlayerLoopSystem? GPIKNNIJBOA, PlayerLoopSystem? PLCAHENMBLF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ONEOLIEPJKO
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum IGJFIGINLHG
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

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AOJPIEDEJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly IGJFIGINLHG MBGHMKIJMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly MAILGMNAODH PPIMPKIFJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long MKKADDHGALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long DLCGCOOHKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long OMCOIANBJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int OFGJHAPEPIL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4720000", Offset = "0x471F000", VA = "0x184720000")]
		public AOJPIEDEJFA(IGJFIGINLHG KJOHINEFOGB, int ADBDLNJILND = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x471FD60", Offset = "0x471ED60", VA = "0x18471FD60")]
		public void JMAGONADANJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x471FDD0", Offset = "0x471EDD0", VA = "0x18471FDD0")]
		public void NAGIJOKMCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x471FE30", Offset = "0x471EE30", VA = "0x18471FE30")]
		public void OEKLHCAGFPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static IGJFIGINLHG[] BLMHIDJMIBL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static AOJPIEDEJFA[] JOBKCGHADPI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4731080", Offset = "0x4730080", VA = "0x184731080")]
	public static AOJPIEDEJFA NAIMMJFJJIA(IGJFIGINLHG DDFHJDPPNBF, int ADBDLNJILND = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4730FF0", Offset = "0x472FFF0", VA = "0x184730FF0")]
	public static AOJPIEDEJFA GDJAGBOMBOK(IGJFIGINLHG DDFHJDPPNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4730F40", Offset = "0x472FF40", VA = "0x184730F40")]
	public static void AJKFDAKKNMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MAILGMNAODH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int OPBINIKGLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> ALFFFIMMBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double JIPMMAPKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double KJMOBOIFGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double PAHPGBIHKEM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JHCDOKACDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x472C1B0", Offset = "0x472B1B0", VA = "0x18472C1B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x472C380", Offset = "0x472B380", VA = "0x18472C380")]
	public MAILGMNAODH(int DNHDFPBNOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x472C210", Offset = "0x472B210", VA = "0x18472C210", Slot = "4")]
	public void JJKBDOPFINH(double OOEOCFOBJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x472C310", Offset = "0x472B310", VA = "0x18472C310", Slot = "5")]
	public void MKJDECMAJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PJGCEJOHMDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long NGOMPCKMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double EBEILHIOAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double CDCIAJFKGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double BJHADIFMENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double FMFLBJOLPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double JIPMMAPKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double KJMOBOIFGBC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long AGNENIFEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double EKDKCPPIABM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3EB0", Offset = "0x3AC2EB0", VA = "0x183AC3EB0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double GNIIAFLHMJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D2380", Offset = "0x9D1380", VA = "0x1809D2380", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double NNENANDCJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35B0A40", Offset = "0x35AFA40", VA = "0x1835B0A40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JHCDOKACDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3AC3DE0", Offset = "0x3AC2DE0", VA = "0x183AC3DE0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4731EB0", Offset = "0x4730EB0", VA = "0x184731EB0", Slot = "7")]
	public void JJKBDOPFINH(double OOEOCFOBJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4731FD0", Offset = "0x4730FD0", VA = "0x184731FD0", Slot = "8")]
	public void MKJDECMAJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4732010", Offset = "0x4731010", VA = "0x184732010")]
	public PJGCEJOHMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KPMDCIHPCHB
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface MHFHOAPMOFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool NPFDLCCEIMK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NAFAAPPDJFF();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class DGPHBMEAJHP<TPromise, TMainThreadPromise> : MHFHOAPMOFB where TPromise : CFBFBBBFDFL where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise ONFAMMMOBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise MGFPIGEPKAP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise NOIHMCLMFDF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3184900", Offset = "0x3183900", VA = "0x183184900")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NPFDLCCEIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3184960", Offset = "0x3183960", VA = "0x183184960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x31849E0", Offset = "0x31839E0", VA = "0x1831849E0")]
		protected DGPHBMEAJHP(TPromise ONFAMMMOBKM, TMainThreadPromise ELEBNBFDLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x31849B0", Offset = "0x31839B0", VA = "0x1831849B0", Slot = "5")]
		public void NAFAAPPDJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LPHGCJPNBEO(TPromise ONFAMMMOBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class GKDCBOCNBMB<T> : DGPHBMEAJHP<global::IHDAFNHGAJF<T>, global::AADOKEPFDDG<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x31859D0", Offset = "0x31849D0", VA = "0x1831859D0")]
		public GKDCBOCNBMB(global::IHDAFNHGAJF<T> ONFAMMMOBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3185850", Offset = "0x3184850", VA = "0x183185850", Slot = "6")]
		protected override void LPHGCJPNBEO(global::IHDAFNHGAJF<T> ONFAMMMOBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x31859A0", Offset = "0x31849A0", VA = "0x1831859A0")]
		[CompilerGenerated]
		private void MNHODGAKEBK(T IMDEFJLGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3185820", Offset = "0x3184820", VA = "0x183185820")]
		[CompilerGenerated]
		private void HDPFHONAHAD(string JGBFMLFAGKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HAPKLDEGAEF : MHFHOAPMOFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action KAIJPPOLHDF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NPFDLCCEIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x58CFE0", Offset = "0x58BFE0", VA = "0x18058CFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C1360", Offset = "0x6C0360", VA = "0x1806C1360")]
		public HAPKLDEGAEF(Action KAIJPPOLHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x149C410", Offset = "0x149B410", VA = "0x18149C410", Slot = "5")]
		public void NAFAAPPDJFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<MHFHOAPMOFB> KMEMFJCPNNF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2E60", Offset = "0x2AA1E60", VA = "0x182AA2E60")]
	public static global::IHDAFNHGAJF<T> ILHKGPBCECM<T>(this global::IHDAFNHGAJF<T> ONFAMMMOBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x472BA50", Offset = "0x472AA50", VA = "0x18472BA50")]
	public static void ILHKGPBCECM(Action KAIJPPOLHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2AA2DA0", Offset = "0x2AA1DA0", VA = "0x182AA2DA0")]
	private static global::IHDAFNHGAJF<T> BHDKBKFINPC<T>(global::IHDAFNHGAJF<T> ONFAMMMOBKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x472B860", Offset = "0x472A860", VA = "0x18472B860")]
	private static void GLFMAGAOKCO(MHFHOAPMOFB MDCKBAJJAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x472BAE0", Offset = "0x472AAE0", VA = "0x18472BAE0")]
	private static void PECCKCLANPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x472B790", Offset = "0x472A790", VA = "0x18472B790")]
	private static void EHHPMOEGAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x472B6E0", Offset = "0x472A6E0", VA = "0x18472B6E0")]
	private static void BNOMEOCGNPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class BMBIJIHJFMM
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct HAMADBDCEDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<Scene> NKBNNADCDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly string EEEJHMHKOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly LoadSceneMode IPKCMMDJONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly bool IPIPCFBDJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly ECKKNIKHLKB JEKLJDDCDKJ;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4727EA0", Offset = "0x4726EA0", VA = "0x184727EA0")]
		public HAMADBDCEDM(TaskCompletionSource<Scene> EJFDKHGHKPD, string EEEJHMHKOMO, LoadSceneMode IPKCMMDJONB, bool IPIPCFBDJGN, ECKKNIKHLKB JEKLJDDCDKJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GBANPFPIJDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public ECKKNIKHLKB stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private global::JMCOHHGCFDO<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4727280", Offset = "0x4726280", VA = "0x184727280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x47277E0", Offset = "0x47267E0", VA = "0x1847277E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct KNCLLJILHDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x472B3F0", Offset = "0x472A3F0", VA = "0x18472B3F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct CPLJCEILHBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private HAMADBDCEDM <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4723250", Offset = "0x4722250", VA = "0x184723250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EDFE0", Offset = "0x7ECFE0", VA = "0x1807EDFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BFOPOHLNALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public global::AADOKEPFDDG<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public BFOPOHLNALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x47210C0", Offset = "0x47200C0", VA = "0x1847210C0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct FBNHNDKCPFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public ECKKNIKHLKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private BFOPOHLNALF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private ECKKNIKHLKB <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private ECKKNIKHLKB <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4726460", Offset = "0x4725460", VA = "0x184726460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4726C20", Offset = "0x4725C20", VA = "0x184726C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct CEHBLOHDNPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public ECKKNIKHLKB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private ECKKNIKHLKB <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private ECKKNIKHLKB <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4722610", Offset = "0x4721610", VA = "0x184722610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4722D10", Offset = "0x4721D10", VA = "0x184722D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class FKMEAKOKKCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public FKMEAKOKKCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4726F00", Offset = "0x4725F00", VA = "0x184726F00")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DGHCONEPHEL : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public FKDIGOMJOEO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public DGHCONEPHEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x47253E0", Offset = "0x47243E0", VA = "0x1847253E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47250A0", Offset = "0x47240A0", VA = "0x1847250A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4725490", Offset = "0x4724490", VA = "0x184725490")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4725390", Offset = "0x4724390", VA = "0x184725390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FDDHAKHJAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public global::AADOKEPFDDG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public FDDHAKHJAJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EKLMMLGGJBM : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public global::AADOKEPFDDG<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private FDDHAKHJAJL <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public EKLMMLGGJBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4726000", Offset = "0x4725000", VA = "0x184726000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4726410", Offset = "0x4725410", VA = "0x184726410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static CFBFBBBFDFL FCHJKEHPFDH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation IMHCMOOCGEN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static CFBFBBBFDFL IFJCLOPGJLG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string DADFCAHNLHL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority GGALFHDOCHP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static Task FOFELKGLJOG;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Queue<HAMADBDCEDM> CDLAIAFDEEJ;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static Task ALKFCDIMNPL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool EIKBODJHOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x47212E0", Offset = "0x47202E0", VA = "0x1847212E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool BOFKDOGOCPK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x47219E0", Offset = "0x47209E0", VA = "0x1847219E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool OLNMDCMBCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4721560", Offset = "0x4720560", VA = "0x184721560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HKPGOGANKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4721610", Offset = "0x4720610", VA = "0x184721610")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x47218E0", Offset = "0x47208E0", VA = "0x1847218E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4721490", Offset = "0x4720490", VA = "0x184721490")]
	[KMMCCHGHBPI(MCCKPBHNINP.EnteredEditModeNextFrame, 0)]
	private static void DJNNNFJIMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x47217A0", Offset = "0x47207A0", VA = "0x1847217A0")]
	[AsyncStateMachine(typeof(GBANPFPIJDL))]
	public static Task<Scene> IDJOPFLNEOM(string EEEJHMHKOMO, LoadSceneMode IPKCMMDJONB = LoadSceneMode.Single, bool IPIPCFBDJGN = false, [Optional] ECKKNIKHLKB DAAEMLBGBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4721A90", Offset = "0x4720A90", VA = "0x184721A90")]
	[AsyncStateMachine(typeof(KNCLLJILHDJ))]
	private static Task KKKGMIECHHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4722100", Offset = "0x4721100", VA = "0x184722100")]
	[AsyncStateMachine(typeof(CPLJCEILHBD))]
	private static Task MEHOJJINJKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4721110", Offset = "0x4720110", VA = "0x184721110")]
	[AsyncStateMachine(typeof(FBNHNDKCPFK))]
	private static Task<Scene> BLHLJCLKIAD(string EEEJHMHKOMO, LoadSceneMode IPKCMMDJONB, bool IPIPCFBDJGN, ECKKNIKHLKB JEKLJDDCDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x47221E0", Offset = "0x47211E0", VA = "0x1847221E0")]
	[AsyncStateMachine(typeof(CEHBLOHDNPK))]
	private static Task<Scene> NGFDIJOHNAB(ECKKNIKHLKB JEKLJDDCDKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4721B70", Offset = "0x4720B70", VA = "0x184721B70")]
	public static global::IHDAFNHGAJF<Scene> LAONPGBIPMO(string EEEJHMHKOMO, LoadSceneMode IPKCMMDJONB = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4721CE0", Offset = "0x4720CE0", VA = "0x184721CE0")]
	public static CFBFBBBFDFL LEPGCBFGGAE(string EEEJHMHKOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4721250", Offset = "0x4720250", VA = "0x184721250")]
	[IteratorStateMachine(typeof(DGHCONEPHEL))]
	private static IEnumerator<CNHILGIAPIF> BMMAJGKKOKO(string EEEJHMHKOMO, FKDIGOMJOEO HNMHNANPMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4721710", Offset = "0x4720710", VA = "0x184721710")]
	[IteratorStateMachine(typeof(EKLMMLGGJBM))]
	private static IEnumerator<CNHILGIAPIF> FHFLALKFLPD(string EEEJHMHKOMO, LoadSceneMode IPKCMMDJONB, global::AADOKEPFDDG<Scene> HNMHNANPMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4722300", Offset = "0x4721300", VA = "0x184722300")]
	public static bool NKAOHGDKHFF(out string FIEGKJIGMAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HDDMEOGOBGD
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4727FD0", Offset = "0x4726FD0", VA = "0x184727FD0")]
	public static IDisposable PCLPNDMEAIF(this NIEOJLEHPGM HHKNMJJDOAL, float OGOJDLAAAIA, Action<float> FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4727F50", Offset = "0x4726F50", VA = "0x184727F50")]
	public static IDisposable IJCHKDGMBPH(this NIEOJLEHPGM HHKNMJJDOAL, Action<float> FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4728050", Offset = "0x4727050", VA = "0x184728050")]
	public static IDisposable PHHEGABPFNP(this NIEOJLEHPGM HHKNMJJDOAL, Action<float> FHNJNLACCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HJFODILPJDP
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4728C10", Offset = "0x4727C10", VA = "0x184728C10")]
	public static IDisposable MHNCPPFLPHE(this MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4728A40", Offset = "0x4727A40", VA = "0x184728A40")]
	public static IDisposable MHNCPPFLPHE(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4728580", Offset = "0x4727580", VA = "0x184728580")]
	public static IDisposable FCLLPBMAPJJ(this MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4728510", Offset = "0x4727510", VA = "0x184728510")]
	public static IDisposable EPJKJEECOLI(this MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4728940", Offset = "0x4727940", VA = "0x184728940")]
	public static IDisposable MDLFJKEANEL(this MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4728410", Offset = "0x4727410", VA = "0x184728410")]
	public static IDisposable ECPHNMLBJDA(this MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4728720", Offset = "0x4727720", VA = "0x184728720")]
	public static IDisposable KKFNMENELJD(this MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4728C90", Offset = "0x4727C90", VA = "0x184728C90")]
	public static IDisposable MPIPDEPEPMH(this MonoBehaviour EGIJCCMEKBG, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4728D30", Offset = "0x4727D30", VA = "0x184728D30")]
	public static IDisposable OPLDJNKCDIJ(this MonoBehaviour EGIJCCMEKBG, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x47289B0", Offset = "0x47279B0", VA = "0x1847289B0")]
	public static IDisposable MHBNDCFCALC(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x47288B0", Offset = "0x47278B0", VA = "0x1847288B0")]
	public static IDisposable LOEHKKCDGHP(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4728480", Offset = "0x4727480", VA = "0x184728480")]
	public static IDisposable EEEHFDNIAFG(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4728690", Offset = "0x4727690", VA = "0x184728690")]
	public static IDisposable JIOCCMMMIGA(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4728380", Offset = "0x4727380", VA = "0x184728380")]
	public static IDisposable CPCKCLIGDJP(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x47282F0", Offset = "0x47272F0", VA = "0x1847282F0")]
	public static IDisposable AMIMGDBNDFA(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4728790", Offset = "0x4727790", VA = "0x184728790")]
	public static IDisposable KLMHDIPPEAG(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x47285F0", Offset = "0x47275F0", VA = "0x1847285F0")]
	public static IDisposable JELNDNAMABI(this MonoBehaviour EGIJCCMEKBG, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4728820", Offset = "0x4727820", VA = "0x184728820")]
	public static IDisposable LHEDMLDKEOK(this MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FNHOLLFJKCE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CCDAFAPNBMH : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public JFFOPHMIPKF.FLGEPOEDNJA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private AGDMOFGMMGC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public CCDAFAPNBMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4722500", Offset = "0x4721500", VA = "0x184722500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x47225C0", Offset = "0x47215C0", VA = "0x1847225C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CKBOKOPMKLC : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JFFOPHMIPKF.FLGEPOEDNJA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private AGDMOFGMMGC <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public CKBOKOPMKLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4722D60", Offset = "0x4721D60", VA = "0x184722D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4722E40", Offset = "0x4721E40", VA = "0x184722E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4727030", Offset = "0x4726030", VA = "0x184727030")]
	public static DMIEKLLPPEA MHNCPPFLPHE(Action FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4727110", Offset = "0x4726110", VA = "0x184727110")]
	public static DMIEKLLPPEA MHNCPPFLPHE(Behaviour HHKNMJJDOAL, Action FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x47271A0", Offset = "0x47261A0", VA = "0x1847271A0")]
	public static DMIEKLLPPEA MHNCPPFLPHE(Behaviour HHKNMJJDOAL, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4726FB0", Offset = "0x4725FB0", VA = "0x184726FB0")]
	[IteratorStateMachine(typeof(CCDAFAPNBMH))]
	private static IEnumerator<CNHILGIAPIF> KMLGPKFGHFP(JFFOPHMIPKF.FLGEPOEDNJA NBBCCNPIOBP, Action FHNJNLACCHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4726F30", Offset = "0x4725F30", VA = "0x184726F30")]
	[IteratorStateMachine(typeof(CKBOKOPMKLC))]
	private static IEnumerator<CNHILGIAPIF> KMLGPKFGHFP(JFFOPHMIPKF.FLGEPOEDNJA NBBCCNPIOBP, Action<float> FHNJNLACCHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class NLOPADPJANL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class LPHDNAKHNND : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EMAOHILHHHJ schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public JFFOPHMIPKF.FLGEPOEDNJA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private BBGPCCLFJBB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public LPHDNAKHNND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x472C030", Offset = "0x472B030", VA = "0x18472C030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x472C160", Offset = "0x472B160", VA = "0x18472C160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4730CF0", Offset = "0x472FCF0", VA = "0x184730CF0")]
	public static DMIEKLLPPEA MHNCPPFLPHE(MonoBehaviour EGIJCCMEKBG, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, bool BNKCDLCMAHI = true, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4730B60", Offset = "0x472FB60", VA = "0x184730B60")]
	public static DMIEKLLPPEA IBHDNLCIKKM(NIEOJLEHPGM HHKNMJJDOAL, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, bool BNKCDLCMAHI = true, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4730C40", Offset = "0x472FC40", VA = "0x184730C40")]
	[IteratorStateMachine(typeof(LPHDNAKHNND))]
	private static IEnumerator<CNHILGIAPIF> KMLGPKFGHFP(EMAOHILHHHJ MIGCCIKLBDG, float OGOJDLAAAIA, JFFOPHMIPKF.FLGEPOEDNJA NBBCCNPIOBP, Action<float> FHNJNLACCHD, bool BNKCDLCMAHI = true, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DHJJLIDCCHO
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class INGHFEFMJOG : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JFFOPHMIPKF.FLGEPOEDNJA queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public INGHFEFMJOG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4729D10", Offset = "0x4728D10", VA = "0x184729D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4729DC0", Offset = "0x4728DC0", VA = "0x184729DC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x47254E0", Offset = "0x47244E0", VA = "0x1847254E0")]
	[IteratorStateMachine(typeof(INGHFEFMJOG))]
	private static IEnumerator<CNHILGIAPIF> FDPENBGPCHA(JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, Func<bool> BBANFEOCBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4725560", Offset = "0x4724560", VA = "0x184725560")]
	public static DMIEKLLPPEA IPEDBICMOMB(this MonoBehaviour EGIJCCMEKBG, Func<bool> BBANFEOCBJK, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI = JFFOPHMIPKF.FLGEPOEDNJA.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NGCEJPPOCPK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DOBBFLJPGMB : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public JFFOPHMIPKF.FLGEPOEDNJA queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public DOBBFLJPGMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4725E60", Offset = "0x4724E60", VA = "0x184725E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4725F20", Offset = "0x4724F20", VA = "0x184725F20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x472F0D0", Offset = "0x472E0D0", VA = "0x18472F0D0")]
	[IteratorStateMachine(typeof(DOBBFLJPGMB))]
	private static IEnumerator<CNHILGIAPIF> IMFKLFEHDLB(float OFMBEJMFHDN, JFFOPHMIPKF.FLGEPOEDNJA NBBCCNPIOBP, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x472EE60", Offset = "0x472DE60", VA = "0x18472EE60")]
	public static DMIEKLLPPEA ANDCBJJGICL(this MonoBehaviour EGIJCCMEKBG, float OFMBEJMFHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x472F320", Offset = "0x472E320", VA = "0x18472F320")]
	public static DMIEKLLPPEA PBBAHFKKAGN(this MonoBehaviour EGIJCCMEKBG, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x472EEF0", Offset = "0x472DEF0", VA = "0x18472EEF0")]
	public static DMIEKLLPPEA FDFOMGJMGFK(this MonoBehaviour EGIJCCMEKBG, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x472F3C0", Offset = "0x472E3C0", VA = "0x18472F3C0")]
	public static DMIEKLLPPEA PGIKMFAKCAM(this MonoBehaviour EGIJCCMEKBG, Action CDPFCGNCMDM, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x472F280", Offset = "0x472E280", VA = "0x18472F280")]
	public static DMIEKLLPPEA OLJDKKIBAGL(this MonoBehaviour EGIJCCMEKBG, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x472EF90", Offset = "0x472DF90", VA = "0x18472EF90")]
	public static DMIEKLLPPEA FHHHADPCPFM(this MonoBehaviour EGIJCCMEKBG, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x472F030", Offset = "0x472E030", VA = "0x18472F030")]
	private static DMIEKLLPPEA FKHPEFPNMBG(MonoBehaviour EGIJCCMEKBG, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, Action CDPFCGNCMDM, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x472EDD0", Offset = "0x472DDD0", VA = "0x18472EDD0")]
	public static DMIEKLLPPEA ACEJBNODNIG(this MonoBehaviour EGIJCCMEKBG, float MAOHMPDFGKE, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x472F3F0", Offset = "0x472E3F0", VA = "0x18472F3F0")]
	public static DMIEKLLPPEA PKAEICAJOBC(this MonoBehaviour EGIJCCMEKBG, float MAOHMPDFGKE, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x472F1F0", Offset = "0x472E1F0", VA = "0x18472F1F0")]
	public static DMIEKLLPPEA LAEGKMIEBEG(this MonoBehaviour EGIJCCMEKBG, float MAOHMPDFGKE, Action CDPFCGNCMDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x472F160", Offset = "0x472E160", VA = "0x18472F160")]
	public static DMIEKLLPPEA JLPNIHAONBE(this MonoBehaviour EGIJCCMEKBG, float MAOHMPDFGKE, Action CDPFCGNCMDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JCELDACNOON : IPDBGAMLLLF
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class KEDNLJHPIIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JCELDACNOON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public KEDNLJHPIIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x472B310", Offset = "0x472A310", VA = "0x18472B310")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class OMKHHFLGOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public JCELDACNOON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public OMKHHFLGOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x472B310", Offset = "0x472A310", VA = "0x18472B310")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly float DNCNHDCMEGK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4729CC0", Offset = "0x4728CC0", VA = "0x184729CC0")]
	public JCELDACNOON(Behaviour HHKNMJJDOAL, float DNCNHDCMEGK, [Optional] Action MLPBDEHMMND, [Optional] EKHELOONFNE FNOIPDAAKBO, [Optional] EMAOHILHHHJ MIGCCIKLBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x472B050", Offset = "0x472A050", VA = "0x18472B050", Slot = "9")]
	protected override bool JMECLMNHOGG(Action KAIJPPOLHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x472B130", Offset = "0x472A130", VA = "0x18472B130", Slot = "10")]
	protected override bool PMFKBPKJAEC(Action KAIJPPOLHDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface CMMBKCMPJMH
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool FCKNABKLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GNJJBKCPHGC;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OGIADMNKLOD(bool PFGBAAJKACD = false);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OGIADMNKLOD(Action KAIJPPOLHDF, bool PFGBAAJKACD = false);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class IPDBGAMLLLF : CMMBKCMPJMH
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PNJMJIMNAEB : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IPDBGAMLLLF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public PNJMJIMNAEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4732040", Offset = "0x4731040", VA = "0x184732040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4732110", Offset = "0x4731110", VA = "0x184732110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Behaviour HHKNMJJDOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Action MLPBDEHMMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private EIFMJMILICM KLGKFPDECHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly EKHELOONFNE FNOIPDAAKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	protected readonly EMAOHILHHHJ MIGCCIKLBDG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FCKNABKLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x758DF0", Offset = "0x757DF0", VA = "0x180758DF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action GNJJBKCPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x472AA10", Offset = "0x4729A10", VA = "0x18472AA10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x472A970", Offset = "0x4729970", VA = "0x18472A970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x472AE80", Offset = "0x4729E80", VA = "0x18472AE80")]
	protected IPDBGAMLLLF(Behaviour HHKNMJJDOAL, [Optional] Action MLPBDEHMMND, [Optional] EKHELOONFNE FNOIPDAAKBO, [Optional] EMAOHILHHHJ MIGCCIKLBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x472ADD0", Offset = "0x4729DD0", VA = "0x18472ADD0", Slot = "7")]
	public bool OGIADMNKLOD(bool PFGBAAJKACD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x472AE30", Offset = "0x4729E30", VA = "0x18472AE30", Slot = "8")]
	public bool OGIADMNKLOD(Action KAIJPPOLHDF, bool PFGBAAJKACD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JMECLMNHOGG(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PMFKBPKJAEC(Action KAIJPPOLHDF);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x472AAF0", Offset = "0x4729AF0", VA = "0x18472AAF0")]
	protected void IFKBANFJFEN(Action KAIJPPOLHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x472AB10", Offset = "0x4729B10", VA = "0x18472AB10")]
	protected CFBFBBBFDFL KBEGMMCDLMO(float FJIIENLHOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x472ACE0", Offset = "0x4729CE0", VA = "0x18472ACE0")]
	private void MJFINCJDNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x472AD50", Offset = "0x4729D50", VA = "0x18472AD50")]
	[IteratorStateMachine(typeof(PNJMJIMNAEB))]
	private IEnumerator<CNHILGIAPIF> OADMONEJHHB(float FJIIENLHOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x472AAB0", Offset = "0x4729AB0", VA = "0x18472AAB0")]
	[CompilerGenerated]
	private void BNGPIIIEJFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CNHIKAOMEBP : IPDBGAMLLLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly float IEKLPDLNKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly int CGMMGCCOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float FGIAKHDAJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly float[] EHKHADPNKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int MODHIPKHMFD;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4723140", Offset = "0x4722140", VA = "0x184723140")]
	public CNHIKAOMEBP(Behaviour HHKNMJJDOAL, float FAMADBACBDO, int CGMMGCCOBOE, [Optional] Action MLPBDEHMMND, float FGIAKHDAJGC = 0f, [Optional] EKHELOONFNE FNOIPDAAKBO, [Optional] EMAOHILHHHJ MIGCCIKLBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0", Slot = "9")]
	protected override bool JMECLMNHOGG(Action KAIJPPOLHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4722F20", Offset = "0x4721F20", VA = "0x184722F20", Slot = "10")]
	protected override bool PMFKBPKJAEC(Action KAIJPPOLHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4722E90", Offset = "0x4721E90", VA = "0x184722E90")]
	private void MEJGGLENGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ILOEEDAIEBB : IPDBGAMLLLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly float DNCNHDCMEGK;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4729CC0", Offset = "0x4728CC0", VA = "0x184729CC0")]
	public ILOEEDAIEBB(Behaviour HHKNMJJDOAL, float DNCNHDCMEGK, [Optional] Action MLPBDEHMMND, [Optional] EKHELOONFNE FNOIPDAAKBO, [Optional] EMAOHILHHHJ MIGCCIKLBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x58CEC0", Offset = "0x58BEC0", VA = "0x18058CEC0", Slot = "9")]
	protected override bool JMECLMNHOGG(Action KAIJPPOLHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4729C80", Offset = "0x4728C80", VA = "0x184729C80", Slot = "10")]
	protected override bool PMFKBPKJAEC(Action KAIJPPOLHDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class DKHKEINAEFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NDNJFNNAGOO : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public NDNJFNNAGOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x472ECE0", Offset = "0x472DCE0", VA = "0x18472ECE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x472ED80", Offset = "0x472DD80", VA = "0x18472ED80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private DMIEKLLPPEA LKHLJHKKHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private NIEOJLEHPGM HHKNMJJDOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Action<float> MMMNIABFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private float FDLCPPJCOPC;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4725BE0", Offset = "0x4724BE0", VA = "0x184725BE0")]
	public DKHKEINAEFH(NIEOJLEHPGM HHKNMJJDOAL, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4725940", Offset = "0x4724940", VA = "0x184725940")]
	private void KLAINNAGCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4725760", Offset = "0x4724760", VA = "0x184725760")]
	private void AJPFNKBNGLG(string JGBFMLFAGKK, Action PMNHIEOAOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x47258D0", Offset = "0x47248D0", VA = "0x1847258D0")]
	[IteratorStateMachine(typeof(NDNJFNNAGOO))]
	private IEnumerator<CNHILGIAPIF> IOPEEDNNJPM(Action PMNHIEOAOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4725870", Offset = "0x4724870", VA = "0x184725870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4725A90", Offset = "0x4724A90", VA = "0x184725A90")]
	[CompilerGenerated]
	private void LDBCCCMKDFP(string OPNLBLDAFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class HJJMMIOPLFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DNKALCPAGIG : IEnumerator<CNHILGIAPIF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private CNHILGIAPIF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private CNHILGIAPIF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69D7D0", Offset = "0x69C7D0", VA = "0x18069D7D0")]
		[DebuggerHidden]
		public DNKALCPAGIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4725D70", Offset = "0x4724D70", VA = "0x184725D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4725E10", Offset = "0x4724E10", VA = "0x184725E10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private DMIEKLLPPEA LKHLJHKKHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private MonoBehaviour EGIJCCMEKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action FHNJNLACCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action<float> MMMNIABFJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private float FDLCPPJCOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool BNKCDLCMAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly EKHELOONFNE FNOIPDAAKBO;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4729500", Offset = "0x4728500", VA = "0x184729500")]
	public HJJMMIOPLFH(MonoBehaviour EGIJCCMEKBG, Action FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4729840", Offset = "0x4728840", VA = "0x184729840")]
	public HJJMMIOPLFH(MonoBehaviour EGIJCCMEKBG, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4729670", Offset = "0x4728670", VA = "0x184729670")]
	public HJJMMIOPLFH(MonoBehaviour EGIJCCMEKBG, float OGOJDLAAAIA, Action<float> FHNJNLACCHD, JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI, bool BNKCDLCMAHI = true, [Optional] EKHELOONFNE FNOIPDAAKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x47293E0", Offset = "0x47283E0", VA = "0x1847293E0")]
	private void MHNCPPFLPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4729130", Offset = "0x4728130", VA = "0x184729130")]
	private void JCDIOIHIILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4729280", Offset = "0x4728280", VA = "0x184729280")]
	private void KLAINNAGCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4728DD0", Offset = "0x4727DD0", VA = "0x184728DD0")]
	private void AJPFNKBNGLG(string JGBFMLFAGKK, Action PMNHIEOAOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x47290C0", Offset = "0x47280C0", VA = "0x1847290C0")]
	[IteratorStateMachine(typeof(DNKALCPAGIG))]
	private IEnumerator<CNHILGIAPIF> IOPEEDNNJPM(Action PMNHIEOAOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4728F60", Offset = "0x4727F60", VA = "0x184728F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4729040", Offset = "0x4728040", VA = "0x184729040")]
	[CompilerGenerated]
	private void IEABCKNCBPO(string OPNLBLDAFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4728FC0", Offset = "0x4727FC0", VA = "0x184728FC0")]
	[CompilerGenerated]
	private void FIMBNEDLFNO(string OPNLBLDAFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4728EE0", Offset = "0x4727EE0", VA = "0x184728EE0")]
	[CompilerGenerated]
	private void CMHNFNFANCN(string OPNLBLDAFKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
internal enum PLEHBHINLON : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class PCDLCOMKBFB : EMAOHILHHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float IFCIIMFDMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4731390", Offset = "0x4730390", VA = "0x184731390", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float CJNJDEOGMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x47313C0", Offset = "0x47303C0", VA = "0x1847313C0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double FMCNJLPAIJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x47313A0", Offset = "0x47303A0", VA = "0x1847313A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47313D0", Offset = "0x47303D0", VA = "0x1847313D0")]
	[NKCNCMJLPMH]
	private static void OPIFLPBIBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	[Preserve]
	internal PCDLCOMKBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface GCJLCKGLEIA
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJJHDFNAECG(string LDKPDNBIJND);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKMFIGAHOKO();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface IEDBFKNLOAD
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string BIEMFEFJPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool HOMAEAECIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HICNGEIPNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class GEFBCKDBMEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public MFCKCNJMNNH EOKLINLLNAH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int NBBAFHCPDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x58CED0", Offset = "0x58BED0", VA = "0x18058CED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x58CEE0", Offset = "0x58BEE0", VA = "0x18058CEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4727AE0", Offset = "0x4726AE0", VA = "0x184727AE0")]
	public static CNHILGIAPIF LPBBOGFENLA(IEnumerator<CNHILGIAPIF> AEDBMKKDHFE, GPPNFALDCIL OINEJGIHCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4727A00", Offset = "0x4726A00", VA = "0x184727A00")]
	public CNHILGIAPIF LPBBOGFENLA(GPPNFALDCIL[] OIAJNOBEOIP, IEnumerator<CNHILGIAPIF>[] BKKPACAMBEF, CNHILGIAPIF[] PAGIPOHCKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4727900", Offset = "0x4726900", VA = "0x184727900")]
	public void PLOGHCLNJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4727930", Offset = "0x4726930", VA = "0x184727930")]
	public void HNCMJKCOFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4727830", Offset = "0x4726830", VA = "0x184727830")]
	public void DIDKPPDPMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4727900", Offset = "0x4726900", VA = "0x184727900")]
	public void GPBNFABEKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public GEFBCKDBMEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class MFCKCNJMNNH
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CHHHANJEGBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public GEFBCKDBMEP HPKINEHFMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NIEOJLEHPGM DHJOJLFFCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public GPPNFALDCIL AKBDDHENEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IEnumerator<CNHILGIAPIF> MJOAALGAPHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public CNHILGIAPIF OJBLDEBMOKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public PLEHBHINLON NPAAPDCDOJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct EDMCMDHJBJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public JFFOPHMIPKF.FLGEPOEDNJA DLCDBJDNLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<CHHHANJEGBD> EENNMKMENEE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class ADJGHLDBEJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public MFCKCNJMNNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public NIEOJLEHPGM context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public GEFBCKDBMEP routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public PLEHBHINLON coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public GPPNFALDCIL promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public CNHILGIAPIF currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public IEnumerator<CNHILGIAPIF> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ADJGHLDBEJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x471F560", Offset = "0x471E560", VA = "0x18471F560")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class ANIPCDKKCPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GEFBCKDBMEP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public MFCKCNJMNNH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public ANIPCDKKCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x471FD20", Offset = "0x471ED20", VA = "0x18471FD20")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class IODICJJFCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GEFBCKDBMEP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public MFCKCNJMNNH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public IODICJJFCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x472A930", Offset = "0x4729930", VA = "0x18472A930")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class PAFNEEDOIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public GEFBCKDBMEP schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public MFCKCNJMNNH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
		public PAFNEEDOIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4731350", Offset = "0x4730350", VA = "0x184731350")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const PLEHBHINLON LFEEHFFHDJG = PLEHBHINLON.Cancelled | PLEHBHINLON.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool[] ECLKIAPMHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<PLEHBHINLON> KMLMIPPKNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<float> PGEAMGNBOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> CEELNLMNLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> IEHPGCEHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> NOOGHOEOGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> LPJDPIJCGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private NativeArray<int> FIOOPGEMOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private GEFBCKDBMEP[] JMNIECNNCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private GPPNFALDCIL[] OIAJNOBEOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NIEOJLEHPGM[] LCECPJLHIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private IEnumerator<CNHILGIAPIF>[] FOLBMNGMIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private CNHILGIAPIF[] MGMLLEGJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int DKIBEOBJJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int EHCFCNDLJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly int PKEDONBOCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private float NMKLDAKDAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private MDKCEHCEGAK LGNFLNMJCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private JobHandle FFELKEJKDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private List<GEFBCKDBMEP> PFKEDBCPJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool HDLKFMLBMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> LNIDKANFCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> HHIFBCPJKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool MPHBADMGEEH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public EDMCMDHJBJM[] OMDHJGDGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xE0AB50", Offset = "0xE09B50", VA = "0x180E0AB50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x472E670", Offset = "0x472D670", VA = "0x18472E670")]
	private static int PDPKBMCDEAJ(JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x472E780", Offset = "0x472D780", VA = "0x18472E780")]
	public MFCKCNJMNNH(JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x472DE60", Offset = "0x472CE60", VA = "0x18472DE60")]
	private void LIBKCOPIAMP(ref int JMNDKGIKGHK, int DJCDGCKGAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x472DFF0", Offset = "0x472CFF0", VA = "0x18472DFF0")]
	public void MICFKJJPLOH(NIEOJLEHPGM HHKNMJJDOAL, CNHILGIAPIF KADDJLHEPKK, IEnumerator<CNHILGIAPIF> AEDBMKKDHFE, GPPNFALDCIL OINEJGIHCPE, [Optional] GEFBCKDBMEP MKAAJGJMOBI, PLEHBHINLON AMCANOKACJD = PLEHBHINLON.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x472CFE0", Offset = "0x472BFE0", VA = "0x18472CFE0")]
	public void FAIPNHJAJID(IEnumerable<CHHHANJEGBD> CJODPKBPCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x472D9E0", Offset = "0x472C9E0", VA = "0x18472D9E0")]
	private CHHHANJEGBD KIGJAHPABMF(int LGPNCPNPLIN)
	{
		return default(CHHHANJEGBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x472D470", Offset = "0x472C470", VA = "0x18472D470")]
	private void GALGKEDEKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x38C4CA0", Offset = "0x38C3CA0", VA = "0x1838C4CA0")]
	private static void GGFAMNIMMBC<T>(int LGPNCPNPLIN, T[] JBIEECFPIAB, int MAAFLBOPOCI, [Optional] T EKICHFINOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x38C4C80", Offset = "0x38C3C80", VA = "0x1838C4C80")]
	private static void GGFAMNIMMBC<T>(int LGPNCPNPLIN, NativeArray<T> JBIEECFPIAB, int MAAFLBOPOCI, [Optional] T EKICHFINOAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x472D1D0", Offset = "0x472C1D0", VA = "0x18472D1D0")]
	private void FKLOLNIDOLF(IEnumerable<CHHHANJEGBD> CJODPKBPCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x472D7E0", Offset = "0x472C7E0", VA = "0x18472D7E0")]
	private void GCCINNGLCFC(CHHHANJEGBD AFEPKGKBDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x472CD20", Offset = "0x472BD20", VA = "0x18472CD20")]
	private IBOFPOFJFDD EHIAHJPBBKO(int KJLJLOHNLFC)
	{
		return default(IBOFPOFJFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x472CA70", Offset = "0x472BA70", VA = "0x18472CA70")]
	public void BJAJDGIPFIC(float MHDPOLFJNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x472D960", Offset = "0x472C960", VA = "0x18472D960")]
	private void ILLDAEPJINK(Action JAELLKEBFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x472E5F0", Offset = "0x472D5F0", VA = "0x18472E5F0")]
	private void NOBHLAGLGJM(Action JAELLKEBFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x472E150", Offset = "0x472D150", VA = "0x18472E150")]
	public void MKJDKMKDJHA(float MHDPOLFJNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x472E6A0", Offset = "0x472D6A0", VA = "0x18472E6A0")]
	public void PKDHKFNAFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x472D8A0", Offset = "0x472C8A0", VA = "0x18472D8A0")]
	public void GPBNFABEKFP(GEFBCKDBMEP ECFMJDELCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x472C9B0", Offset = "0x472B9B0", VA = "0x18472C9B0")]
	public void BDHKLBCGACP(GEFBCKDBMEP ECFMJDELCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x472CC60", Offset = "0x472BC60", VA = "0x18472CC60")]
	public void DLCNIOMMMID(GEFBCKDBMEP ECFMJDELCBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class HHEDCDKKOIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly HHEDCDKKOIJ HBKBNBICFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Action ILKLOFGNAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool KMDCHDFHKAG;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C1360", Offset = "0x6C0360", VA = "0x1806C1360")]
	public HHEDCDKKOIJ(Action ILKLOFGNAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x47280D0", Offset = "0x47270D0", VA = "0x1847280D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GABELLIAKDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable FCPDJNCBAIK(UnityEngine.Object HHKNMJJDOAL, Action<T> NOKGGPEKFCI);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface PKJFDABICOF<T> : global::GABELLIAKDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NPCBLEFIKEP<T> : global::PKJFDABICOF<T>, global::GABELLIAKDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class DNACODHCCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public global::NPCBLEFIKEP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public global::DOMIHEFCIHI<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1E42690", Offset = "0x1E41690", VA = "0x181E42690")]
		public DNACODHCCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4062910", Offset = "0x4061910", VA = "0x184062910")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject KONAFGJNDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<global::DOMIHEFCIHI<UnityEngine.Object, Action<T>>> BILJFOOKPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T HNCLCBHLACD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T MHLLNAFLMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC80", Offset = "0x6B9C80", VA = "0x1806BAC80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4076390", Offset = "0x4075390", VA = "0x184076390", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x40764A0", Offset = "0x40754A0", VA = "0x1840764A0")]
	private static bool NKGFAFKKPFC(T JAELLKEBFMM, T PEAHMNEGGIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x40765A0", Offset = "0x40755A0", VA = "0x1840765A0")]
	public NPCBLEFIKEP(T OFJJBEEKFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4076230", Offset = "0x4075230", VA = "0x184076230", Slot = "6")]
	public IDisposable FCPDJNCBAIK(UnityEngine.Object HHKNMJJDOAL, Action<T> NOKGGPEKFCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4075DB0", Offset = "0x4074DB0", VA = "0x184075DB0")]
	private void FCDKIBDAPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class OMPGNKOOENF : ELFDNHGPJOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly EKHELOONFNE FNOIPDAAKBO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4730DD0", Offset = "0x472FDD0", VA = "0x184730DD0")]
	[NKCNCMJLPMH]
	private static void OPIFLPBIBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1360", Offset = "0x6C0360", VA = "0x1806C1360")]
	[Preserve]
	internal OMPGNKOOENF([EEIPLMOCPEM(null)] EKHELOONFNE FNOIPDAAKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4730EA0", Offset = "0x472FEA0", VA = "0x184730EA0", Slot = "4")]
	public IDisposable OPLDJNKCDIJ(float OGOJDLAAAIA, Action<float> ACDPINKOGPO, bool BNKCDLCMAHI = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct MDKCEHCEGAK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[ReadOnly]
	public float OFCKIEEMAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[ReadOnly]
	public int JFOIOLHNACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NativeArray<int> NPKCHJGAPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<int> HMOLOEIFHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeArray<int> ELNODMHKAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[ReadOnly]
	public NativeArray<PLEHBHINLON> OPEOJKIHGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[ReadOnly]
	public NativeArray<float> MKHFMPJIHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[WriteOnly]
	public NativeArray<int> NOOGHOEOGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[WriteOnly]
	public NativeArray<int> CEELNLMNLLF;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x472C5A0", Offset = "0x472B5A0", VA = "0x18472C5A0")]
	public static MDKCEHCEGAK GJHMDGALCIL(int AEIJMBBGDBJ, float MHDPOLFJNHP, NativeArray<PLEHBHINLON> MJMGLFAGDBC, NativeArray<float> OJNHODDGCPG, NativeArray<int> CDMCDHCFKNG, NativeArray<int> HEGMHNDCGJK, NativeArray<int> CHDAOBNHFJI, NativeArray<int> HMOLOEIFHEF, NativeArray<int> ELNODMHKAOE)
	{
		return default(MDKCEHCEGAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x472C490", Offset = "0x472B490", VA = "0x18472C490", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x472C970", Offset = "0x472B970", VA = "0x18472C970")]
	private bool PBJLDAPCDIM(int FBOCJCCNMND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x472C570", Offset = "0x472B570", VA = "0x18472C570")]
	private void GDABOECOBOA(NativeArray<int> OGJHMBNPJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x472C420", Offset = "0x472B420", VA = "0x18472C420")]
	private int BPBBIBLLJLB(int JOPEPCBPICA, int KDGMKIMMLFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x472C670", Offset = "0x472B670", VA = "0x18472C670")]
	private void HICEOCGDMGA(NativeArray<int> OGJHMBNPJGE, int AKGIBLJHFGN, int EBJFCNBKMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x472C740", Offset = "0x472B740", VA = "0x18472C740")]
	private void KFFEMPGLPGO(NativeArray<int> OGJHMBNPJGE, int EGKBKEGIGOG, int KBGKAGLIHDE, int PCGONIHNAJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class INHIHAKOIMB : BENHKJLNNBP, EKHELOONFNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private MFCKCNJMNNH[] KILCKFINOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private GCJLCKGLEIA GIFLMLPNODJ;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x472A4B0", Offset = "0x47294B0", VA = "0x18472A4B0")]
	[NKCNCMJLPMH]
	private static void OPIFLPBIBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x472A870", Offset = "0x4729870", VA = "0x18472A870")]
	[Preserve]
	public INHIHAKOIMB([EEIPLMOCPEM(null)] EDKKGLBAGJK GFPPGLJHEIG, [EEIPLMOCPEM(null)] EMAOHILHHHJ MIGCCIKLBDG, [EEIPLMOCPEM(null)] BNGAMLHDIHM NLALEIGNEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4729FD0", Offset = "0x4728FD0", VA = "0x184729FD0", Slot = "12")]
	public override DMIEKLLPPEA GDEGHBPHLLG(NIEOJLEHPGM HHKNMJJDOAL, IEnumerator<CNHILGIAPIF> KIHAKKADDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x472A1F0", Offset = "0x47291F0", VA = "0x18472A1F0", Slot = "13")]
	public override void MKJDECMAJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x472A580", Offset = "0x4729580", VA = "0x18472A580", Slot = "15")]
	public override void PJANDKHJNPE(JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4729EF0", Offset = "0x4728EF0", VA = "0x184729EF0", Slot = "14")]
	protected override void FCLLPBMAPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x472A100", Offset = "0x4729100", VA = "0x18472A100")]
	private MFCKCNJMNNH KMDJLIJONDI(JFFOPHMIPKF.FLGEPOEDNJA GOKHKCCNGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x472A140", Offset = "0x4729140", VA = "0x18472A140", Slot = "16")]
	internal override PFMCOHOJCNH LHNMBOJPLCG(IEnumerator<CNHILGIAPIF> KIHAKKADDMP, Behaviour HHKNMJJDOAL, GPPNFALDCIL OINEJGIHCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4729E10", Offset = "0x4728E10", VA = "0x184729E10", Slot = "17")]
	internal override NHPBOOEFIDH ALLICEMHODM(JFFOPHMIPKF.FLGEPOEDNJA NBBCCNPIOBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x472A750", Offset = "0x4729750", VA = "0x18472A750")]
	private void PLONMNDACKN(MFCKCNJMNNH POHEFPLCHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4729E80", Offset = "0x4728E80", VA = "0x184729E80", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class BENHKJLNNBP : EKHELOONFNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly EDKKGLBAGJK GFPPGLJHEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	protected readonly EMAOHILHHHJ MIGCCIKLBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly BNGAMLHDIHM NLALEIGNEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NHPBOOEFIDH[] PPAHMKMEABO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static EKHELOONFNE LOBJDNDFAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4720B00", Offset = "0x471FB00", VA = "0x184720B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool NNPKNEDOGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x58CFE0", Offset = "0x58BFE0", VA = "0x18058CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JFFOPHMIPKF.FLGEPOEDNJA KBHJEFIKBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x58CED0", Offset = "0x58BED0", VA = "0x18058CED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(JFFOPHMIPKF.FLGEPOEDNJA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x58CEE0", Offset = "0x58BEE0", VA = "0x18058CEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EMAOHILHHHJ EGCDLKLJOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x58EDF0", Offset = "0x58DDF0", VA = "0x18058EDF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x47205B0", Offset = "0x471F5B0", VA = "0x1847205B0")]
	public static DMIEKLLPPEA HAAJNGKNFEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4720E10", Offset = "0x471FE10", VA = "0x184720E10")]
	[Preserve]
	protected BENHKJLNNBP([EEIPLMOCPEM(null)] EDKKGLBAGJK GFPPGLJHEIG, [EEIPLMOCPEM(null)] EMAOHILHHHJ MIGCCIKLBDG, [EEIPLMOCPEM(null)] BNGAMLHDIHM NLALEIGNEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x47208D0", Offset = "0x471F8D0", VA = "0x1847208D0", Slot = "6")]
	public DMIEKLLPPEA MOONNOKDBKF(IEnumerator<CNHILGIAPIF> KIHAKKADDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x47208E0", Offset = "0x471F8E0", VA = "0x1847208E0", Slot = "7")]
	public DMIEKLLPPEA MOONNOKDBKF(Behaviour HHKNMJJDOAL, IEnumerator<CNHILGIAPIF> KIHAKKADDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract DMIEKLLPPEA GDEGHBPHLLG(NIEOJLEHPGM HHKNMJJDOAL, IEnumerator<CNHILGIAPIF> KIHAKKADDMP);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x47206F0", Offset = "0x471F6F0", VA = "0x1847206F0", Slot = "13")]
	public virtual void MKJDECMAJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4720670", Offset = "0x471F670", VA = "0x184720670", Slot = "9")]
	public void LIEPEKCPDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4720590", Offset = "0x471F590", VA = "0x184720590", Slot = "14")]
	protected virtual void FCLLPBMAPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4720650", Offset = "0x471F650", VA = "0x184720650")]
	private void LFDMFJNGNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x47202B0", Offset = "0x471F2B0", VA = "0x1847202B0")]
	private void AEBHKLEILFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4720570", Offset = "0x471F570", VA = "0x184720570")]
	private void EPJKJEECOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x47206D0", Offset = "0x471F6D0", VA = "0x1847206D0")]
	private void MDLFJKEANEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x47202D0", Offset = "0x471F2D0", VA = "0x1847202D0")]
	private void CMMFMKNJPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4720BC0", Offset = "0x471FBC0", VA = "0x184720BC0")]
	private void PBCBCAOEMFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4720BE0", Offset = "0x471FBE0", VA = "0x184720BE0", Slot = "15")]
	public virtual void PJANDKHJNPE(JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x47200F0", Offset = "0x471F0F0", VA = "0x1847200F0")]
	private void ABICAGGDJGE(NHPBOOEFIDH POHEFPLCHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7D8E00", Offset = "0x7D7E00", VA = "0x1807D8E00")]
	private NHPBOOEFIDH DCJDAABHABD(JFFOPHMIPKF.FLGEPOEDNJA GOKHKCCNGMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract PFMCOHOJCNH LHNMBOJPLCG(IEnumerator<CNHILGIAPIF> KIHAKKADDMP, Behaviour EGIJCCMEKBG, GPPNFALDCIL IBDINFCALAG);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract NHPBOOEFIDH ALLICEMHODM(JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x47202F0", Offset = "0x471F2F0", VA = "0x1847202F0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class PFMCOHOJCNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly GPPNFALDCIL OINEJGIHCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly IEDBFKNLOAD HHKNMJJDOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly bool DMFHMMLJPID;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<CNHILGIAPIF> MJOAALGAPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x58C490", Offset = "0x58B490", VA = "0x18058C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CNHILGIAPIF OJBLDEBMOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x58C1C0", Offset = "0x58B1C0", VA = "0x18058C1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x58C4A0", Offset = "0x58B4A0", VA = "0x18058C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HAFHDPAJLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x47316E0", Offset = "0x47306E0", VA = "0x1847316E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IJOGLEOEGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x842AD0", Offset = "0x841AD0", VA = "0x180842AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2673560", Offset = "0x2672560", VA = "0x182673560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string BIEMFEFJPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x58D010", Offset = "0x58C010", VA = "0x18058D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58D020", Offset = "0x58C020", VA = "0x18058D020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float FBPBBAMACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x10EEF80", Offset = "0x10EDF80", VA = "0x1810EEF80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x15AAB90", Offset = "0x15A9B90", VA = "0x1815AAB90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4731AF0", Offset = "0x4730AF0", VA = "0x184731AF0")]
	public PFMCOHOJCNH(IEnumerator<CNHILGIAPIF> AEDBMKKDHFE, IEDBFKNLOAD HHKNMJJDOAL, GPPNFALDCIL OINEJGIHCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x47317F0", Offset = "0x47307F0", VA = "0x1847317F0")]
	public CNHILGIAPIF LPBBOGFENLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4731670", Offset = "0x4730670", VA = "0x184731670")]
	public bool EBBGOBADPFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4731760", Offset = "0x4730760", VA = "0x184731760")]
	public void GPBNFABEKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4731A60", Offset = "0x4730A60", VA = "0x184731A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x19CB3D0", Offset = "0x19CA3D0", VA = "0x1819CB3D0")]
	[CompilerGenerated]
	private void HABCOAINKMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class GPPNFALDCIL : ABJHIPOHOFM, DMIEKLLPPEA, EIFMJMILICM, CFBFBBBFDFL, IEnumerator, CNHILGIAPIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JFFOPHMIPKF.FLGEPOEDNJA KECCLEBGAFK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private JFFOPHMIPKF.FLGEPOEDNJA CCBHLLDDNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5B1180", Offset = "0x5B0180", VA = "0x1805B1180", Slot = "23")]
		get
		{
			return default(JFFOPHMIPKF.FLGEPOEDNJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public JFFOPHMIPKF.FLGEPOEDNJA EOKLINLLNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x77C5C0", Offset = "0x77B5C0", VA = "0x18077C5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float CBCHICNGECM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xED1A70", Offset = "0xED0A70", VA = "0x180ED1A70", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4727E20", Offset = "0x4726E20", VA = "0x184727E20", Slot = "24")]
	private bool NEPEGKDFJHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4727E10", Offset = "0x4726E10", VA = "0x184727E10", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4727E40", Offset = "0x4726E40", VA = "0x184727E40")]
	public GPPNFALDCIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal enum IBOFPOFJFDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NHPBOOEFIDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum DBMMAPPILOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct FPAAIKPJHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public JFFOPHMIPKF.FLGEPOEDNJA DLCDBJDNLDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public DBMMAPPILOD OECDPKOJAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<PFMCOHOJCNH> BOCKKKHMLJA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly DBMMAPPILOD[] NFEGANBAJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly JFFOPHMIPKF.FLGEPOEDNJA BDCMPNCAJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool JIEEHKCEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly PFMCOHOJCNH[] OGCEPPKFOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<PFMCOHOJCNH> FFJDJIPHJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Stack<int> ILPFHIEBPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly List<PFMCOHOJCNH> BMMMFBGFKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly Stack<int> KBOLHBNGALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly GCJLCKGLEIA CACCLLEOFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool MPHBADMGEEH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public FPAAIKPJHKN[,] OBPDDEEOCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DF130", Offset = "0x5DE130", VA = "0x1805DF130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x47306F0", Offset = "0x472F6F0", VA = "0x1847306F0")]
	public NHPBOOEFIDH(JFFOPHMIPKF.FLGEPOEDNJA NBBCCNPIOBP, GCJLCKGLEIA CACCLLEOFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x47302F0", Offset = "0x472F2F0", VA = "0x1847302F0")]
	public void HLOHEHBBGPB(PFMCOHOJCNH AEDBMKKDHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x472F6E0", Offset = "0x472E6E0", VA = "0x18472F6E0")]
	public void APANDLPAGHE(IList<PFMCOHOJCNH> BKKPACAMBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x472FAE0", Offset = "0x472EAE0", VA = "0x18472FAE0")]
	public void CBJFOBDANPJ(IList<PFMCOHOJCNH> BKKPACAMBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x472F480", Offset = "0x472E480", VA = "0x18472F480")]
	private void AAPOCEKJFEC(PFMCOHOJCNH AEDBMKKDHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x472F570", Offset = "0x472E570", VA = "0x18472F570")]
	private void AEJAJDLDGCI(IList<PFMCOHOJCNH> BKKPACAMBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x472F960", Offset = "0x472E960", VA = "0x18472F960")]
	private IBOFPOFJFDD BLNLPNIEION(PFMCOHOJCNH AEDBMKKDHFE)
	{
		return default(IBOFPOFJFDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x4730080", Offset = "0x472F080", VA = "0x184730080")]
	public void FCLLPBMAPJJ(float MHDPOLFJNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x4730410", Offset = "0x472F410", VA = "0x184730410")]
	public void LIEPEKCPDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x472FEA0", Offset = "0x472EEA0", VA = "0x18472FEA0")]
	private void EAPAFBDHNJO(List<PFMCOHOJCNH> BKKPACAMBEF, Stack<int> HFAABLEEKIK, bool MOLMPHJCNLO, float CLPDLGAKGLE = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x472FD60", Offset = "0x472ED60", VA = "0x18472FD60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x47301D0", Offset = "0x472F1D0", VA = "0x1847301D0")]
	private void GDMOBEDNOHN(List<PFMCOHOJCNH> BKKPACAMBEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class ENOPGOFNMBA : GCJLCKGLEIA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "4")]
	public void PJJHDFNAECG(string LDKPDNBIJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "5")]
	public void DKMFIGAHOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public ENOPGOFNMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AMIAHNMFEJP : IEDBFKNLOAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Behaviour EGIJCCMEKBG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string BIEMFEFJPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x471FC10", Offset = "0x471EC10", VA = "0x18471FC10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HOMAEAECIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x471FCC0", Offset = "0x471ECC0", VA = "0x18471FCC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HICNGEIPNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x471FCA0", Offset = "0x471ECA0", VA = "0x18471FCA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C1360", Offset = "0x6C0360", VA = "0x1806C1360")]
	public AMIAHNMFEJP(Behaviour EGIJCCMEKBG)
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

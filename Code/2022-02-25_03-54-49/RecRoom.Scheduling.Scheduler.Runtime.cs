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
		private delegate List<PlayerLoopSystem> MDGNJLDONIF(List<PlayerLoopSystem> MDIGJLJNHDA, int DJICAFEHBOH);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct AFPFMHDAJMG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct GEDEMOKNHJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static IDFFNOKDGGC MDGJFPDDNFL;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x2DC9960", Offset = "0x2DC7F60", VA = "0x182DC9960")]
				public static PlayerLoopSystem IIIEADABMNJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct HCNIKLJBEDB
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static IDFFNOKDGGC LLCJLFCCOCB;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x2DCB9C0", Offset = "0x2DC9FC0", VA = "0x182DCB9C0")]
				public static PlayerLoopSystem IIIEADABMNJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct GKKKLLOHNCO
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static IDFFNOKDGGC BPMOPIOOBPI;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x2DC9F40", Offset = "0x2DC8540", VA = "0x182DC9F40")]
				public static PlayerLoopSystem IIIEADABMNJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct LHIBNMIAJGE
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static IDFFNOKDGGC DLJLIEFKMKP;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x2DCE6E0", Offset = "0x2DCCCE0", VA = "0x182DCE6E0")]
				public static PlayerLoopSystem IIIEADABMNJ()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct BJPBPEKBDEP
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class IDHGALHJEON
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public GHIIOENNPIF.KMCAFPCONII key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
					public IDHGALHJEON()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x2DCC270", Offset = "0x2DCA870", VA = "0x182DCC270")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable BODGLIPJDON;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x2DC3240", Offset = "0x2DC1840", VA = "0x182DC3240")]
				public static PlayerLoopSystem HHBPJDMNEGO(GHIIOENNPIF.KMCAFPCONII CAOGILCCJKA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct KMENNJJEMMG
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class OJNCBFBJPEF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public GHIIOENNPIF.KMCAFPCONII key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
					public OJNCBFBJPEF()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x2DD1C50", Offset = "0x2DD0250", VA = "0x182DD1C50")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x2DCE3D0", Offset = "0x2DCC9D0", VA = "0x182DCE3D0")]
				public static PlayerLoopSystem HHBPJDMNEGO(GHIIOENNPIF.KMCAFPCONII CAOGILCCJKA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OKPOBEFDOEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public OKPOBEFDOEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1D10", Offset = "0x2DD0310", VA = "0x182DD1D10")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool AGFCHOELEAD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NKHFKBDKMLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5830", Offset = "0x2DC3E30", VA = "0x182DC5830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5620", Offset = "0x2DC3C20", VA = "0x182DC5620")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2DC43A0", Offset = "0x2DC29A0", VA = "0x182DC43A0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5660", Offset = "0x2DC3C60", VA = "0x182DC5660")]
		private static void IGHFABLJLNA(GHIIOENNPIF.KMCAFPCONII CAOGILCCJKA, ref PlayerLoopSystem KHNOOLLJIKK, Type GLDBGJAGDPN, Type KFCMIJCODPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5870", Offset = "0x2DC3E70", VA = "0x182DC5870")]
		private static void NLEFKHLABAH(ref PlayerLoopSystem KHNOOLLJIKK, Type GLDBGJAGDPN, Type KFCMIJCODPF, MDGNJLDONIF LIPMJKOKKJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2DC5BF0", Offset = "0x2DC41F0", VA = "0x182DC5BF0")]
		private static void OOAKBOHCMBK(ref PlayerLoopSystem KHNOOLLJIKK, Type GLDBGJAGDPN, Type KFCMIJCODPF, PlayerLoopSystem? FFNAMAFMBJC, PlayerLoopSystem? MOAOIMANDCB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GHIIOENNPIF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KMCAFPCONII
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
	public class FNFBAMLLFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KMCAFPCONII PMENAHPDEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly MELLAKNCKJA OJABIHIJKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long LCGFOFAOHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long DNIAANBDOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long LEDAFFHCGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int ABEBPIDIGEN;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC97E0", Offset = "0x2DC7DE0", VA = "0x182DC97E0")]
		public FNFBAMLLFOF(KMCAFPCONII ICMBPEFGFDA, int MBOKBBEJOPP = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC97C0", Offset = "0x2DC7DC0", VA = "0x182DC97C0")]
		public void JMANGNNIDIA(int KFEPIDLHAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9480", Offset = "0x2DC7A80", VA = "0x182DC9480")]
		public void DCCKENIAPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9590", Offset = "0x2DC7B90", VA = "0x182DC9590")]
		public void HGPBKCFECKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2DC95F0", Offset = "0x2DC7BF0", VA = "0x182DC95F0")]
		public void HLBPMJFHDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2DC94F0", Offset = "0x2DC7AF0", VA = "0x182DC94F0")]
		public double FACCNNIBPKE(int PKFBBJFDKFC)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int MJANOEPCIPI = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static KMCAFPCONII[] OCFDAEHIOGE;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static FNFBAMLLFOF[] JJPDNAFAKGL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2DC9C70", Offset = "0x2DC8270", VA = "0x182DC9C70")]
	public static FNFBAMLLFOF PCMBCNMLOCA(KMCAFPCONII CAOGILCCJKA, int MBOKBBEJOPP = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2DC9BE0", Offset = "0x2DC81E0", VA = "0x182DC9BE0")]
	public static FNFBAMLLFOF NKAEPLKDCLC(KMCAFPCONII CAOGILCCJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2DC9B30", Offset = "0x2DC8130", VA = "0x182DC9B30")]
	public static void JFCBGKBBFPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MELLAKNCKJA : KEJFJGBOGPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int OBDKBJKBOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> OAOOHGNMLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double GFBDCKFLKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double ENBPHMLENNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double AKLABGEEECC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FOCIEBKBDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFE80", Offset = "0x2DCE480", VA = "0x182DCFE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double KOPFOFGAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFF30", Offset = "0x2DCE530", VA = "0x182DCFF30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double HIKNGDBLGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC00", Offset = "0x7BA200", VA = "0x1807BBC00", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double HKIDAOCHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1867E90", Offset = "0x1866490", VA = "0x181867E90", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0090", Offset = "0x2DCE690", VA = "0x182DD0090")]
	public MELLAKNCKJA(int KPJCKFMJNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFF90", Offset = "0x2DCE590", VA = "0x182DCFF90", Slot = "4")]
	public void NNCLPBBBGCK(double JNJFNAOGKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFEC0", Offset = "0x2DCE4C0", VA = "0x182DCFEC0", Slot = "5")]
	public void ENDBOFMGBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BPPEKAIANJI : KEJFJGBOGPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long JKKHOEKMJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double FNEMDEBKFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double NNHDOHNJBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double EPIFFEBAEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double MBGCPNCIAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double GFBDCKFLKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double ENBPHMLENNM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JLOOKCACPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double HIKNGDBLGEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C36E30", Offset = "0x1C35430", VA = "0x181C36E30", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double HKIDAOCHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1752900", Offset = "0x1750F00", VA = "0x181752900", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double AGGELLCPFML
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1867E90", Offset = "0x1866490", VA = "0x181867E90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LKIHLADFPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1867E80", Offset = "0x1866480", VA = "0x181867E80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double KOPFOFGAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1C36D60", Offset = "0x1C35360", VA = "0x181C36D60", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DC33A0", Offset = "0x2DC19A0", VA = "0x182DC33A0", Slot = "4")]
	public void NNCLPBBBGCK(double JNJFNAOGKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3360", Offset = "0x2DC1960", VA = "0x182DC3360", Slot = "5")]
	public void ENDBOFMGBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2DC34C0", Offset = "0x2DC1AC0", VA = "0x182DC34C0")]
	public BPPEKAIANJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KEJFJGBOGPG
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double KOPFOFGAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double HIKNGDBLGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double HKIDAOCHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNCLPBBBGCK(double JNJFNAOGKKP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENDBOFMGBIC();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class POJKKHDMGDN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface EKADCEFOIDN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool PGGHFBKCPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JCIBKDPCAKO();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EHICJNGNPDC();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class OMFBAFPIANF<TPromise, TMainThreadPromise> : EKADCEFOIDN where TPromise : GDOLLDLAJJG where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise EDDAJFIOGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise DDMLOLFAJCB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise LMGFNKCJEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x48DC820", Offset = "0x48DAE20", VA = "0x1848DC820")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PGGHFBKCPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x48DC880", Offset = "0x48DAE80", VA = "0x1848DC880", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x21DB5B0", Offset = "0x21D9BB0", VA = "0x1821DB5B0")]
		protected OMFBAFPIANF(TPromise EDDAJFIOGPP, TMainThreadPromise KPPJPAHIPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x48DC7F0", Offset = "0x48DADF0", VA = "0x1848DC7F0", Slot = "5")]
		public void JCIBKDPCAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1348590", Offset = "0x1346B90", VA = "0x181348590", Slot = "6")]
		public void EHICJNGNPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void HALOJONOFII(TPromise EDDAJFIOGPP);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void BIBINECJMGE();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class FAHAFPMNCPP<T> : OMFBAFPIANF<global::FPCEKCNKAAO<T>, global::OHFKOJGDIOE<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x48D41D0", Offset = "0x48D27D0", VA = "0x1848D41D0")]
		public FAHAFPMNCPP(global::FPCEKCNKAAO<T> EDDAJFIOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x48D3FA0", Offset = "0x48D25A0", VA = "0x1848D3FA0", Slot = "7")]
		protected override void HALOJONOFII(global::FPCEKCNKAAO<T> EDDAJFIOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x48D3F40", Offset = "0x48D2540", VA = "0x1848D3F40", Slot = "8")]
		protected override void BIBINECJMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E55430", Offset = "0x1E53A30", VA = "0x181E55430")]
		[CompilerGenerated]
		private void IFCBAMNNKHG(T BGLDGHJKFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x48D41A0", Offset = "0x48D27A0", VA = "0x1848D41A0")]
		[CompilerGenerated]
		private void OHIGPBPJLGF(string DFNAEPAJNDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class MALCLLOACAF : OMFBAFPIANF<GDOLLDLAJJG, MNKIKGKHNHB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2DCF0F0", Offset = "0x2DCD6F0", VA = "0x182DCF0F0")]
		public MALCLLOACAF(GDOLLDLAJJG EDDAJFIOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2DCF020", Offset = "0x2DCD620", VA = "0x182DCF020", Slot = "7")]
		protected override void HALOJONOFII(GDOLLDLAJJG EDDAJFIOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2DCEFD0", Offset = "0x2DCD5D0", VA = "0x182DCEFD0", Slot = "8")]
		protected override void BIBINECJMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1B9EC30", Offset = "0x1B9D230", VA = "0x181B9EC30")]
		[CompilerGenerated]
		private void IFCBAMNNKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1B9EC10", Offset = "0x1B9D210", VA = "0x181B9EC10")]
		[CompilerGenerated]
		private void OHIGPBPJLGF(string DFNAEPAJNDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class GICIPIOPGGH : EKADCEFOIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action DAENONOLDPH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PGGHFBKCPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x50DF80", Offset = "0x50C580", VA = "0x18050DF80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x57F220", Offset = "0x57D820", VA = "0x18057F220")]
		public GICIPIOPGGH(Action DAENONOLDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1C46D40", Offset = "0x1C45340", VA = "0x181C46D40", Slot = "5")]
		public void JCIBKDPCAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "6")]
		public void EHICJNGNPDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<EKADCEFOIDN> NGKLKKAJAMI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3EC09C0", Offset = "0x3EBEFC0", VA = "0x183EC09C0")]
	public static global::FPCEKCNKAAO<T> GHJBFALFHBI<T>(this global::FPCEKCNKAAO<T> EDDAJFIOGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2DD20B0", Offset = "0x2DD06B0", VA = "0x182DD20B0")]
	public static GDOLLDLAJJG GHJBFALFHBI(this GDOLLDLAJJG EDDAJFIOGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2DD21C0", Offset = "0x2DD07C0", VA = "0x182DD21C0")]
	public static void GHJBFALFHBI(Action DAENONOLDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0900", Offset = "0x3EBEF00", VA = "0x183EC0900")]
	private static global::FPCEKCNKAAO<T> ELPGDGOADBM<T>(global::FPCEKCNKAAO<T> EDDAJFIOGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1FD0", Offset = "0x2DD05D0", VA = "0x182DD1FD0")]
	private static GDOLLDLAJJG ELPGDGOADBM(GDOLLDLAJJG EDDAJFIOGPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD2620", Offset = "0x2DD0C20", VA = "0x182DD2620")]
	private static void JJJKCEJOAKC(EKADCEFOIDN APNNPBBOFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD2300", Offset = "0x2DD0900", VA = "0x182DD2300")]
	private static void IHOAAKFGLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DD2810", Offset = "0x2DD0E10", VA = "0x182DD2810")]
	private static void JMOABPLPHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DD2250", Offset = "0x2DD0850", VA = "0x182DD2250")]
	private static void HBGFIODIOCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class ANKIJICBIFE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HKDGHEJHAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public MNKIKGKHNHB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public HKDGHEJHAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBF80", Offset = "0x2DCA580", VA = "0x182DCBF80")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2DCBF70", Offset = "0x2DCA570", VA = "0x182DCBF70")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PGLJJKKGOLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public PGLJJKKGOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1E10", Offset = "0x2DD0410", VA = "0x182DD1E10")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MHJEMCMOMLJ : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MNKIKGKHNHB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public MHJEMCMOMLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1140", Offset = "0x2DCF740", VA = "0x182DD1140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD0E20", Offset = "0x2DCF420", VA = "0x182DD0E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD11F0", Offset = "0x2DCF7F0", VA = "0x182DD11F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD10F0", Offset = "0x2DCF6F0", VA = "0x182DD10F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PNCGMIIHMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MNKIKGKHNHB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public PNCGMIIHMDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PPHFHPBLHIB : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MNKIKGKHNHB onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private PNCGMIIHMDM <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public PPHFHPBLHIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2940", Offset = "0x2DD0F40", VA = "0x182DD2940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2CD0", Offset = "0x2DD12D0", VA = "0x182DD2CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string MICJPJPBHPN = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string LHPIKCIHALA = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string NBHDNKBCHCJ = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string AJBJCDNAEHN = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string JPKNGNGIOKL = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float CNPADCHPOGB = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static GDOLLDLAJJG CPDCLKHDCCO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation LFBACNPDEHE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static GDOLLDLAJJG FEHBGGHMKAG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string BGLPLBAILGB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority GPPOGNKOGHA;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool KAONOPFPEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2AF0", Offset = "0x2DC10F0", VA = "0x182DC2AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool NKBLJPCLLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2B90", Offset = "0x2DC1190", VA = "0x182DC2B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool CFBCEPPHJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2BF0", Offset = "0x2DC11F0", VA = "0x182DC2BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MBGGHJKIHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC28E0", Offset = "0x2DC0EE0", VA = "0x182DC28E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC24E0", Offset = "0x2DC0AE0", VA = "0x182DC24E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2990", Offset = "0x2DC0F90", VA = "0x182DC2990")]
	public static GDOLLDLAJJG HMHNPOMNOBA(string KHIKPKNEMGO, LoadSceneMode OBOHNHAEKPF = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2590", Offset = "0x2DC0B90", VA = "0x182DC2590")]
	public static GDOLLDLAJJG BFIEDPDECLJ(string KHIKPKNEMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2850", Offset = "0x2DC0E50", VA = "0x182DC2850")]
	[IteratorStateMachine(typeof(MHJEMCMOMLJ))]
	private static IEnumerator<NHGKJABNDLI> ENCHIFEFDND(string KHIKPKNEMGO, MNKIKGKHNHB JFHFHACLDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2DC27C0", Offset = "0x2DC0DC0", VA = "0x182DC27C0")]
	[IteratorStateMachine(typeof(PPHFHPBLHIB))]
	private static IEnumerator<NHGKJABNDLI> BIHKLOMIBLD(string KHIKPKNEMGO, LoadSceneMode OBOHNHAEKPF, MNKIKGKHNHB JFHFHACLDOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class JJPKJINLKNC
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD870", Offset = "0x2DCBE70", VA = "0x182DCD870")]
	public static IDisposable KDIGOIOBFOH(this OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD7F0", Offset = "0x2DCBDF0", VA = "0x182DCD7F0")]
	public static IDisposable KDIGOIOBFOH(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD9F0", Offset = "0x2DCBFF0", VA = "0x182DCD9F0")]
	public static IDisposable NEBFDKEJGML(this OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDA60", Offset = "0x2DCC060", VA = "0x182DCDA60")]
	public static IDisposable NPKOGMFBGFN(this OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD780", Offset = "0x2DCBD80", VA = "0x182DCD780")]
	public static IDisposable JPOINNBPCLN(this OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD480", Offset = "0x2DCBA80", VA = "0x182DCD480")]
	public static IDisposable GIPJKNDNHJO(this OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD710", Offset = "0x2DCBD10", VA = "0x182DCD710")]
	public static IDisposable JNLEHABBNMN(this OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD680", Offset = "0x2DCBC80", VA = "0x182DCD680")]
	public static IDisposable JDBOPNDEMBG(this OMJOGKFDDGH NBOHPDEHCDB, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD300", Offset = "0x2DCB900", VA = "0x182DCD300")]
	public static IDisposable DEJJBKLIHCC(this OMJOGKFDDGH NBOHPDEHCDB, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD380", Offset = "0x2DCB980", VA = "0x182DCD380")]
	public static IDisposable ECCDBHABBNJ(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDAD0", Offset = "0x2DCC0D0", VA = "0x182DCDAD0")]
	public static IDisposable PJBBPHJBOCG(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD970", Offset = "0x2DCBF70", VA = "0x182DCD970")]
	public static IDisposable NCMMOEFGEMH(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD170", Offset = "0x2DCB770", VA = "0x182DCD170")]
	public static IDisposable AMLPEJOAFCF(this OMJOGKFDDGH NBOHPDEHCDB, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD600", Offset = "0x2DCBC00", VA = "0x182DCD600")]
	public static IDisposable IHAOMEBIGEL(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD280", Offset = "0x2DCB880", VA = "0x182DCD280")]
	public static IDisposable CJOFAPNPMKM(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD400", Offset = "0x2DCBA00", VA = "0x182DCD400")]
	public static IDisposable EGAINBBNDOL(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD4F0", Offset = "0x2DCBAF0", VA = "0x182DCD4F0")]
	public static IDisposable HAKFMLMMMCB(this OMJOGKFDDGH NBOHPDEHCDB, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD580", Offset = "0x2DCBB80", VA = "0x182DCD580")]
	public static IDisposable HOFANLFNEEL(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD200", Offset = "0x2DCB800", VA = "0x182DCD200")]
	public static IDisposable BMMOKOEFDOO(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2DCD8F0", Offset = "0x2DCBEF0", VA = "0x182DCD8F0")]
	public static IDisposable MFABIPOBHND(this OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CLFPBOLBIJE
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4050", Offset = "0x2DC2650", VA = "0x182DC4050")]
	public static IDisposable PAPAMFGKBPD(this MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2DC40D0", Offset = "0x2DC26D0", VA = "0x182DC40D0")]
	public static IDisposable PAPAMFGKBPD(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3B80", Offset = "0x2DC2180", VA = "0x182DC3B80")]
	public static IDisposable HLFBHDKMFNH(this MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3FE0", Offset = "0x2DC25E0", VA = "0x182DC3FE0")]
	public static IDisposable ONPCFDJBHBD(this MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3980", Offset = "0x2DC1F80", VA = "0x182DC3980")]
	public static IDisposable FBJKCCPLJPG(this MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2DC39F0", Offset = "0x2DC1FF0", VA = "0x182DC39F0")]
	public static IDisposable FCOBJJOLIJB(this MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3C80", Offset = "0x2DC2280", VA = "0x182DC3C80")]
	public static IDisposable KDBOKHECGDO(this MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3F40", Offset = "0x2DC2540", VA = "0x182DC3F40")]
	public static IDisposable ONHIMADCEGC(this MonoBehaviour HDKPCEPKPJK, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4270", Offset = "0x2DC2870", VA = "0x182DC4270")]
	public static IDisposable PLKKICDDAMC(this MonoBehaviour HDKPCEPKPJK, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3EB0", Offset = "0x2DC24B0", VA = "0x182DC3EB0")]
	public static IDisposable OMCIHOKBIJP(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3AF0", Offset = "0x2DC20F0", VA = "0x182DC3AF0")]
	public static IDisposable HCDFHNGHCNI(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3D90", Offset = "0x2DC2390", VA = "0x182DC3D90")]
	public static IDisposable OIJLICFIBBP(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3860", Offset = "0x2DC1E60", VA = "0x182DC3860")]
	public static IDisposable ECJFHLLAEBD(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3740", Offset = "0x2DC1D40", VA = "0x182DC3740")]
	public static IDisposable DDOCPNCHLLC(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2DC41E0", Offset = "0x2DC27E0", VA = "0x182DC41E0")]
	public static IDisposable PIIIPMGPNKI(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3CF0", Offset = "0x2DC22F0", VA = "0x182DC3CF0")]
	public static IDisposable MOCJFCKHNJD(this MonoBehaviour HDKPCEPKPJK, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3BF0", Offset = "0x2DC21F0", VA = "0x182DC3BF0")]
	public static IDisposable JMPMHIJOAML(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3A60", Offset = "0x2DC2060", VA = "0x182DC3A60")]
	public static IDisposable GPFDCJHGKAM(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3E20", Offset = "0x2DC2420", VA = "0x182DC3E20")]
	public static IDisposable OIMNFAJJBKH(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4300", Offset = "0x2DC2900", VA = "0x182DC4300")]
	public static IDisposable PMFMIPPBDBE(this MonoBehaviour HDKPCEPKPJK, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4150", Offset = "0x2DC2750", VA = "0x182DC4150")]
	public static IDisposable PGGHHGOCEDA(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2DC37D0", Offset = "0x2DC1DD0", VA = "0x182DC37D0")]
	public static IDisposable DEOEOFJDPDM(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2DC38F0", Offset = "0x2DC1EF0", VA = "0x182DC38F0")]
	public static IDisposable EKOJCPMIJJI(this MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LPJKMOLIDNO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MBLALCNJMBN : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public HPKCBBOAJAB.DGCEPOPAIEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private LCIHJEKOOIA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public MBLALCNJMBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2DCF160", Offset = "0x2DCD760", VA = "0x182DCF160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DCF220", Offset = "0x2DCD820", VA = "0x182DCF220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NIFCMIEHECP : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public HPKCBBOAJAB.DGCEPOPAIEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private LCIHJEKOOIA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public NIFCMIEHECP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1520", Offset = "0x2DCFB20", VA = "0x182DD1520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1600", Offset = "0x2DCFC00", VA = "0x182DD1600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEEE0", Offset = "0x2DCD4E0", VA = "0x182DCEEE0")]
	public static JEPECMMDIGN PAPAMFGKBPD(Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEBD0", Offset = "0x2DCD1D0", VA = "0x182DCEBD0")]
	public static JEPECMMDIGN PAPAMFGKBPD(Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2DCECC0", Offset = "0x2DCD2C0", VA = "0x182DCECC0")]
	public static JEPECMMDIGN PAPAMFGKBPD(Behaviour NBOHPDEHCDB, Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEDD0", Offset = "0x2DCD3D0", VA = "0x182DCEDD0")]
	public static JEPECMMDIGN PAPAMFGKBPD(Behaviour NBOHPDEHCDB, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE9B0", Offset = "0x2DCCFB0", VA = "0x182DCE9B0")]
	public static JEPECMMDIGN KDIGOIOBFOH(OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEAC0", Offset = "0x2DCD0C0", VA = "0x182DCEAC0")]
	public static JEPECMMDIGN KDIGOIOBFOH(OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE930", Offset = "0x2DCCF30", VA = "0x182DCE930")]
	[IteratorStateMachine(typeof(MBLALCNJMBN))]
	private static IEnumerator<NHGKJABNDLI> FKPPADMLFEN(HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB, Action LNHDNMHEJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE8B0", Offset = "0x2DCCEB0", VA = "0x182DCE8B0")]
	[IteratorStateMachine(typeof(NIFCMIEHECP))]
	private static IEnumerator<NHGKJABNDLI> FKPPADMLFEN(HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB, Action<float> LNHDNMHEJGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NHOLNCCDGOL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DDHLNCPBMFD : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public HPKCBBOAJAB.DGCEPOPAIEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private GGNIJBAPKEM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public DDHLNCPBMFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DC63C0", Offset = "0x2DC49C0", VA = "0x182DC63C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2DC64D0", Offset = "0x2DC4AD0", VA = "0x182DC64D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DD13A0", Offset = "0x2DCF9A0", VA = "0x182DD13A0")]
	public static JEPECMMDIGN PAPAMFGKBPD(float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1460", Offset = "0x2DCFA60", VA = "0x182DD1460")]
	public static JEPECMMDIGN PAPAMFGKBPD(MonoBehaviour HDKPCEPKPJK, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2DD12E0", Offset = "0x2DCF8E0", VA = "0x182DD12E0")]
	public static JEPECMMDIGN JGIKAKJNPNN(OMJOGKFDDGH NBOHPDEHCDB, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, bool LIPKAPLCFHN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2DD1240", Offset = "0x2DCF840", VA = "0x182DD1240")]
	[IteratorStateMachine(typeof(DDHLNCPBMFD))]
	private static IEnumerator<NHGKJABNDLI> FKPPADMLFEN(float HLLJEDLMCHL, HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB, Action<float> LNHDNMHEJGN, bool LIPKAPLCFHN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KJFFJGACFND
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ALLJGGDAAON : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HPKCBBOAJAB.DGCEPOPAIEE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public ALLJGGDAAON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2DC23E0", Offset = "0x2DC09E0", VA = "0x182DC23E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2490", Offset = "0x2DC0A90", VA = "0x182DC2490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE1F0", Offset = "0x2DCC7F0", VA = "0x182DCE1F0")]
	[IteratorStateMachine(typeof(ALLJGGDAAON))]
	private static IEnumerator<NHGKJABNDLI> NONEKNDKOFO(HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, Func<bool> EBBDNDEIBIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE270", Offset = "0x2DCC870", VA = "0x182DCE270")]
	public static JEPECMMDIGN PHEBGKDBKEF(this MonoBehaviour HDKPCEPKPJK, Func<bool> EBBDNDEIBIM, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN = HPKCBBOAJAB.DGCEPOPAIEE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class MCEAJOFAPAB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KDJICPDJGAC : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HPKCBBOAJAB.DGCEPOPAIEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public KDJICPDJGAC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DCDB90", Offset = "0x2DCC190", VA = "0x182DCDB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2DCDC50", Offset = "0x2DCC250", VA = "0x182DCDC50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LEOENJIKBIP : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HPKCBBOAJAB.DGCEPOPAIEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private NHGKJABNDLI <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public LEOENJIKBIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE5C0", Offset = "0x2DCCBC0", VA = "0x182DCE5C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE690", Offset = "0x2DCCC90", VA = "0x182DCE690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF970", Offset = "0x2DCDF70", VA = "0x182DCF970")]
	[IteratorStateMachine(typeof(KDJICPDJGAC))]
	private static IEnumerator<NHGKJABNDLI> GNDNLDFBPAK(float BJLBHCLGAFF, HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFB20", Offset = "0x2DCE120", VA = "0x182DCFB20")]
	[IteratorStateMachine(typeof(LEOENJIKBIP))]
	private static IEnumerator<NHGKJABNDLI> KKJFIHLEOPD(float BJLBHCLGAFF, HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF5F0", Offset = "0x2DCDBF0", VA = "0x182DCF5F0")]
	public static IDisposable EGFALABEJDO(this MonoBehaviour HDKPCEPKPJK, float BJLBHCLGAFF, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF270", Offset = "0x2DCD870", VA = "0x182DCF270")]
	public static JEPECMMDIGN EBFEOGEEAFG(this MonoBehaviour HDKPCEPKPJK, float BJLBHCLGAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF490", Offset = "0x2DCDA90", VA = "0x182DCF490")]
	public static JEPECMMDIGN EGFALABEJDO(this MonoBehaviour HDKPCEPKPJK, float BJLBHCLGAFF, HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF480", Offset = "0x2DCDA80", VA = "0x182DCF480")]
	public static JEPECMMDIGN EGEBAEIGCEG(this MonoBehaviour HDKPCEPKPJK, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFB10", Offset = "0x2DCE110", VA = "0x182DCFB10")]
	public static JEPECMMDIGN KFBDFDLGPDL(this MonoBehaviour HDKPCEPKPJK, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFCD0", Offset = "0x2DCE2D0", VA = "0x182DCFCD0")]
	public static JEPECMMDIGN OOIPICJCNJN(this MonoBehaviour HDKPCEPKPJK, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFBB0", Offset = "0x2DCE1B0", VA = "0x182DCFBB0")]
	public static JEPECMMDIGN MALBKMNPPML(this MonoBehaviour HDKPCEPKPJK, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF850", Offset = "0x2DCDE50", VA = "0x182DCF850")]
	public static JEPECMMDIGN FKFMPPNCDLB(this MonoBehaviour HDKPCEPKPJK, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF740", Offset = "0x2DCDD40", VA = "0x182DCF740")]
	private static JEPECMMDIGN FJJKNHDHDOG(MonoBehaviour HDKPCEPKPJK, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF370", Offset = "0x2DCD970", VA = "0x182DCF370")]
	public static JEPECMMDIGN ECAOKMEADEN(this MonoBehaviour HDKPCEPKPJK, float KMHOGOGIMDI, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2DCF860", Offset = "0x2DCDE60", VA = "0x182DCF860")]
	public static JEPECMMDIGN GCMNFPJIFBJ(this MonoBehaviour HDKPCEPKPJK, float KMHOGOGIMDI, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFCE0", Offset = "0x2DCE2E0", VA = "0x182DCFCE0")]
	public static JEPECMMDIGN PCHBCFGOLDI(this MonoBehaviour HDKPCEPKPJK, float KMHOGOGIMDI, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFBC0", Offset = "0x2DCE1C0", VA = "0x182DCFBC0")]
	public static JEPECMMDIGN OGCLMDPBNKO(this MonoBehaviour HDKPCEPKPJK, float KMHOGOGIMDI, Action LGHMJKFFDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2DCFA00", Offset = "0x2DCE000", VA = "0x182DCFA00")]
	public static JEPECMMDIGN JKPKFGBFPOM(this MonoBehaviour HDKPCEPKPJK, float KMHOGOGIMDI, Action LGHMJKFFDPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CEMJBLHEHFP : KEBIHGOGHIC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CKKPKPNFINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CEMJBLHEHFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public CKKPKPNFINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3710", Offset = "0x2DC1D10", VA = "0x182DC3710")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GINHMEDONKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CEMJBLHEHFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
		public GINHMEDONKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3710", Offset = "0x2DC1D10", VA = "0x182DC3710")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float KKNOFBFNFNP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2DC36B0", Offset = "0x2DC1CB0", VA = "0x182DC36B0")]
	public CEMJBLHEHFP(Behaviour NBOHPDEHCDB, float KKNOFBFNFNP, [Optional] Action EBAIBDGOBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2DC35D0", Offset = "0x2DC1BD0", VA = "0x182DC35D0", Slot = "9")]
	protected override bool KKHJPJMBMNC(Action DAENONOLDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2DC34F0", Offset = "0x2DC1AF0", VA = "0x182DC34F0", Slot = "10")]
	protected override bool GMGKKEMGEIC(Action DAENONOLDPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface MMBODAGHBKG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GJGALPPJFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NJAIEOMJNHJ;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KAJNOMLKOHK(bool KMCHJDBILIE = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KAJNOMLKOHK(Action DAENONOLDPH, bool KMCHJDBILIE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class KEBIHGOGHIC : MMBODAGHBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DLBMEJOJLBE : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public DLBMEJOJLBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2DC8840", Offset = "0x2DC6E40", VA = "0x182DC8840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2DC88E0", Offset = "0x2DC6EE0", VA = "0x182DC88E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour NBOHPDEHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action EBAIBDGOBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private POAJLJLELOL PCCMENDKAHD;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GJGALPPJFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1008650", Offset = "0x1006C50", VA = "0x181008650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NJAIEOMJNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE060", Offset = "0x2DCC660", VA = "0x182DCE060", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE100", Offset = "0x2DCC700", VA = "0x182DCE100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE1A0", Offset = "0x2DCC7A0", VA = "0x182DCE1A0")]
	protected KEBIHGOGHIC(Behaviour NBOHPDEHCDB, [Optional] Action EBAIBDGOBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDF00", Offset = "0x2DCC500", VA = "0x182DCDF00", Slot = "7")]
	public bool KAJNOMLKOHK(bool KMCHJDBILIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDF60", Offset = "0x2DCC560", VA = "0x182DCDF60", Slot = "8")]
	public bool KAJNOMLKOHK(Action DAENONOLDPH, bool KMCHJDBILIE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KKHJPJMBMNC(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GMGKKEMGEIC(Action DAENONOLDPH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDD00", Offset = "0x2DCC300", VA = "0x182DCDD00")]
	protected void EMEAAOMBPFH(Action DAENONOLDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDD20", Offset = "0x2DCC320", VA = "0x182DCDD20")]
	protected GDOLLDLAJJG FIAIJAPBAHG(float JBFBGEFDKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDFF0", Offset = "0x2DCC5F0", VA = "0x182DCDFF0")]
	private void NMAIEDJOGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDCA0", Offset = "0x2DCC2A0", VA = "0x182DCDCA0")]
	[IteratorStateMachine(typeof(DLBMEJOJLBE))]
	private static IEnumerator<NHGKJABNDLI> CGFEOAFBOBA(float JBFBGEFDKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDFB0", Offset = "0x2DCC5B0", VA = "0x182DCDFB0")]
	[CompilerGenerated]
	private void LGBAAPOMBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class HGHDIONFDNN : KEBIHGOGHIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float JHCGNLPPOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int LJPMNBFJKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float COIAFCANDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] FFIDAGGDLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int FOECLPBDJFG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public CMJOIFPAEIA CNDJECHBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x50DD80", Offset = "0x50C380", VA = "0x18050DD80")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x50DAE0", Offset = "0x50C0E0", VA = "0x18050DAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2DCBE40", Offset = "0x2DCA440", VA = "0x182DCBE40")]
	public HGHDIONFDNN(Behaviour NBOHPDEHCDB, float HKPNGFIEFJH, int LJPMNBFJKEN, [Optional] Action EBAIBDGOBKO, float COIAFCANDED = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x511400", Offset = "0x50FA00", VA = "0x180511400", Slot = "9")]
	protected override bool KKHJPJMBMNC(Action DAENONOLDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2DCBC20", Offset = "0x2DCA220", VA = "0x182DCBC20", Slot = "10")]
	protected override bool GMGKKEMGEIC(Action DAENONOLDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCBB90", Offset = "0x2DCA190", VA = "0x182DCBB90")]
	private void GJJNALEAFMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KCFLGLBFBBL : KEBIHGOGHIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float KKNOFBFNFNP;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2DC36B0", Offset = "0x2DC1CB0", VA = "0x182DC36B0")]
	public KCFLGLBFBBL(Behaviour NBOHPDEHCDB, float KKNOFBFNFNP, [Optional] Action EBAIBDGOBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x511400", Offset = "0x50FA00", VA = "0x180511400", Slot = "9")]
	protected override bool KKHJPJMBMNC(Action DAENONOLDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDB50", Offset = "0x2DCC150", VA = "0x182DCDB50", Slot = "10")]
	protected override bool GMGKKEMGEIC(Action DAENONOLDPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class MFLFILGGBPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class FKDCNMAMFIC : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public FKDCNMAMFIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9330", Offset = "0x2DC7930", VA = "0x182DC9330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC9430", Offset = "0x2DC7A30", VA = "0x182DC9430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JEPECMMDIGN LNOKBKIOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private OMJOGKFDDGH NBOHPDEHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action LNHDNMHEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> AEAEPLGKNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float MOCFJJKNCML;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0AA0", Offset = "0x2DCF0A0", VA = "0x182DD0AA0")]
	public MFLFILGGBPG(OMJOGKFDDGH NBOHPDEHCDB, Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0C60", Offset = "0x2DCF260", VA = "0x182DD0C60")]
	public MFLFILGGBPG(OMJOGKFDDGH NBOHPDEHCDB, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0920", Offset = "0x2DCEF20", VA = "0x182DD0920")]
	public MFLFILGGBPG(OMJOGKFDDGH NBOHPDEHCDB, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0790", Offset = "0x2DCED90", VA = "0x182DD0790")]
	private void PAPAMFGKBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2DD01A0", Offset = "0x2DCE7A0", VA = "0x182DD01A0")]
	private void COPDGIEDHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0390", Offset = "0x2DCE990", VA = "0x182DD0390")]
	private void FEMAEBBAHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0560", Offset = "0x2DCEB60", VA = "0x182DD0560")]
	private void FKDPELFAMPA(string DFNAEPAJNDG, Action JPHNGJANGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0130", Offset = "0x2DCE730", VA = "0x182DD0130")]
	[IteratorStateMachine(typeof(FKDCNMAMFIC))]
	private IEnumerator<NHGKJABNDLI> AIGDLJIELCF(Action JPHNGJANGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0330", Offset = "0x2DCE930", VA = "0x182DD0330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0710", Offset = "0x2DCED10", VA = "0x182DD0710")]
	[CompilerGenerated]
	private void NOHDMODFKCB(string KGONAAJAECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2DD04E0", Offset = "0x2DCEAE0", VA = "0x182DD04E0")]
	[CompilerGenerated]
	private void FFMOJDDBJIL(string KGONAAJAECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2DD0690", Offset = "0x2DCEC90", VA = "0x182DD0690")]
	[CompilerGenerated]
	private void GJBNIEOMHOM(string KGONAAJAECB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class IIPAOBKOGJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class ACGLOGGEFDE : IEnumerator<NHGKJABNDLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NHGKJABNDLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private NHGKJABNDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
		[DebuggerHidden]
		public ACGLOGGEFDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2250", Offset = "0x2DC0850", VA = "0x182DC2250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2350", Offset = "0x2DC0950", VA = "0x182DC2350", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private JEPECMMDIGN LNOKBKIOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour HDKPCEPKPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action LNHDNMHEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> AEAEPLGKNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float MOCFJJKNCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool LIPKAPLCFHN;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2DCCDB0", Offset = "0x2DCB3B0", VA = "0x182DCCDB0")]
	public IIPAOBKOGJA(MonoBehaviour HDKPCEPKPJK, Action LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2DCCF70", Offset = "0x2DCB570", VA = "0x182DCCF70")]
	public IIPAOBKOGJA(MonoBehaviour HDKPCEPKPJK, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2DCCC10", Offset = "0x2DCB210", VA = "0x182DCCC10")]
	public IIPAOBKOGJA(MonoBehaviour HDKPCEPKPJK, float HLLJEDLMCHL, Action<float> LNHDNMHEJGN, HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN, bool LIPKAPLCFHN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2DCCA80", Offset = "0x2DCB080", VA = "0x182DCCA80")]
	private void PAPAMFGKBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC510", Offset = "0x2DCAB10", VA = "0x182DCC510")]
	private void COPDGIEDHHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC700", Offset = "0x2DCAD00", VA = "0x182DCC700")]
	private void FEMAEBBAHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC850", Offset = "0x2DCAE50", VA = "0x182DCC850")]
	private void FKDPELFAMPA(string DFNAEPAJNDG, Action JPHNGJANGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC420", Offset = "0x2DCAA20", VA = "0x182DCC420")]
	[IteratorStateMachine(typeof(ACGLOGGEFDE))]
	private IEnumerator<NHGKJABNDLI> AIGDLJIELCF(Action JPHNGJANGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC6A0", Offset = "0x2DCACA0", VA = "0x182DCC6A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2DCCA00", Offset = "0x2DCB000", VA = "0x182DCCA00")]
	[CompilerGenerated]
	private void HOEKJELIJBC(string KGONAAJAECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC490", Offset = "0x2DCAA90", VA = "0x182DCC490")]
	[CompilerGenerated]
	private void AMAPIMGDHMH(string KGONAAJAECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC980", Offset = "0x2DCAF80", VA = "0x182DCC980")]
	[CompilerGenerated]
	private void HLJGCPCMJNH(string KGONAAJAECB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface HEFKOKGDCEP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int CMFKLGNBGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IEBEKKKMLOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IEBEKKKMLOK DLJKFDLMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action DIFCGKPBEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool MIIBLHFNHME;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x57F220", Offset = "0x57D820", VA = "0x18057F220")]
	public IEBEKKKMLOK(Action DIFCGKPBEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC320", Offset = "0x2DCA920", VA = "0x182DCC320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GBBPPCMMCJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T OFOOFEJCCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LGAOEGCCHLP(Action<T> ANKGMFDHPNM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable LGAOEGCCHLP(UnityEngine.Object NBOHPDEHCDB, Action<T> ANKGMFDHPNM);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BFCNBGMKDHA<T> : global::GBBPPCMMCJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T OFOOFEJCCGA
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
public class GIBBHEJFAOI<T> : global::BFCNBGMKDHA<T>, global::GBBPPCMMCJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DFKNFJCJBKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::GIBBHEJFAOI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::MDHOPCMDNJN<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B83E0", Offset = "0x7B69E0", VA = "0x1807B83E0")]
		public DFKNFJCJBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x47AF7B0", Offset = "0x47ADDB0", VA = "0x1847AF7B0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject FAIGIHNNJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::MDHOPCMDNJN<UnityEngine.Object, Action<T>>> NJHIEFAFIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T GJAKICCEMLD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object JACALIANFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x47BBB10", Offset = "0x47BA110", VA = "0x1847BBB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T OFOOFEJCCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5B1040", Offset = "0x5AF640", VA = "0x1805B1040", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x47BBA30", Offset = "0x47BA030", VA = "0x1847BBA30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x47BC2F0", Offset = "0x47BA8F0", VA = "0x1847BC2F0")]
	private static bool PKNOOIGMNPA(T LFCBLKFDHFN, T BFBDMMHDNGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x19D1040", Offset = "0x19CF640", VA = "0x1819D1040")]
	public GIBBHEJFAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x47BC360", Offset = "0x47BA960", VA = "0x1847BC360")]
	public GIBBHEJFAOI(T OLBHGMKAMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x47BBF70", Offset = "0x47BA570", VA = "0x1847BBF70")]
	public void IPCCMDNJAAA(T LGCPMIGECAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x47BBF90", Offset = "0x47BA590", VA = "0x1847BBF90", Slot = "7")]
	public IDisposable LGAOEGCCHLP(Action<T> ANKGMFDHPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x47BC160", Offset = "0x47BA760", VA = "0x1847BC160", Slot = "8")]
	public IDisposable LGAOEGCCHLP(UnityEngine.Object NBOHPDEHCDB, Action<T> ANKGMFDHPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x47BB3D0", Offset = "0x47B99D0", VA = "0x1847BB3D0")]
	private void AKCBADADJDP()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<GLKFPPHBCFI, Scheduler>, GLKFPPHBCFI
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class EEAHIAKKBFK : HEFKOKGDCEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public DICOLLCMMBM MCBGOABNICF;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int CMFKLGNBGGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x539130", Offset = "0x537730", VA = "0x180539130", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x58BD40", Offset = "0x58A340", VA = "0x18058BD40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8A30", Offset = "0x2DC7030", VA = "0x182DC8A30")]
			public static NHGKJABNDLI GOPGEKIDEID(IEnumerator<NHGKJABNDLI> DDJINGCACCB, GCOEKNBDHOA HMGDBPCOADP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8B90", Offset = "0x2DC7190", VA = "0x182DC8B90")]
			public NHGKJABNDLI GOPGEKIDEID(GCOEKNBDHOA[] PMEGKBPILGA, IEnumerator<NHGKJABNDLI>[] EEPBIJLJBJM, NHGKJABNDLI[] CFDGMKFFPJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8A00", Offset = "0x2DC7000", VA = "0x182DC8A00")]
			public void KJALIIOOLDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8930", Offset = "0x2DC6F30", VA = "0x182DC8930")]
			public void AODCIOMHILE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8C70", Offset = "0x2DC7270", VA = "0x182DC8C70")]
			public void JMKLMNDJIHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8A00", Offset = "0x2DC7000", VA = "0x182DC8A00")]
			public void EHICJNGNPDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
			public EEAHIAKKBFK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class DICOLLCMMBM
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct MGJNKMHBPDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public EEAHIAKKBFK FPOLKPGICMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public OMJOGKFDDGH GHBEHPKNIOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public GCOEKNBDHOA DJLBDLLCOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<NHGKJABNDLI> DEKKKMAFHCN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public NHGKJABNDLI AFKHNJEKBHM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public EGLADIECCOM HPGGEJOOPNF;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct DAODKKCPOLK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public HPKCBBOAJAB.DGCEPOPAIEE OPLNPKMJMCF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<MGJNKMHBPDE> IEMNIHPEHCD;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class DDEDHJEJMBD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public DICOLLCMMBM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public OMJOGKFDDGH context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public EEAHIAKKBFK routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public EGLADIECCOM coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public GCOEKNBDHOA promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public NHGKJABNDLI currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<NHGKJABNDLI> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
				public DDEDHJEJMBD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x2DC5D10", Offset = "0x2DC4310", VA = "0x182DC5D10")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class PJDDMDGPGJH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public EEAHIAKKBFK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public DICOLLCMMBM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
				public PJDDMDGPGJH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x2DD1E40", Offset = "0x2DD0440", VA = "0x182DD1E40")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class AEFPMMHLNJK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public EEAHIAKKBFK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public DICOLLCMMBM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
				public AEFPMMHLNJK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x2DC23A0", Offset = "0x2DC09A0", VA = "0x182DC23A0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class IOLKLHCOMLB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public EEAHIAKKBFK schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public DICOLLCMMBM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
				public IOLKLHCOMLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x2DCD130", Offset = "0x2DCB730", VA = "0x182DCD130")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] PJPLLALBCBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<EGLADIECCOM> EPMDMLHDIMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> MMEJJGFKCFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> HAIFIBHBGMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> AAMBKDIFKID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> PIGIPGNBLDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> FJCHGILFJNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> NIFNFNMEAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private EEAHIAKKBFK[] LHEIAHMKDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private GCOEKNBDHOA[] PMEGKBPILGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private OMJOGKFDDGH[] IMBKECBJLDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<NHGKJABNDLI>[] AGPMDOJPEAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private NHGKJABNDLI[] HGFJGJJGCLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int NNDAEOBFCMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int PNGOPGJMFFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int BIOBKBDKCEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float CHFOLELGAEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private BEEIGJAJNNC IEBFKNBDBLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle KFHIFDFICJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<EEAHIAKKBFK> GPHNPFOHAFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool INLMHNMAPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> DIAGAKEIDLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> HLEINAAOOPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool DMOLGAALALB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public DAODKKCPOLK[] KBAJLMDGMKG
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x908590", Offset = "0x906B90", VA = "0x180908590")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int OBKACAMJFOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0xC0A8E0", Offset = "0xC08EE0", VA = "0x180C0A8E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x2DC82C0", Offset = "0x2DC68C0", VA = "0x182DC82C0")]
			private static int NCCEAGEONGL(HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2DC82F0", Offset = "0x2DC68F0", VA = "0x182DC82F0")]
			public DICOLLCMMBM(HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x2DC7AD0", Offset = "0x2DC60D0", VA = "0x182DC7AD0")]
			private void JGCHJEIKLDF(ref int FKFMHKGEAKF, int GJEHJONALBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x2DC80E0", Offset = "0x2DC66E0", VA = "0x182DC80E0")]
			public void LAEBJHALODK(OMJOGKFDDGH NBOHPDEHCDB, NHGKJABNDLI PCGONMMNGMP, IEnumerator<NHGKJABNDLI> DDJINGCACCB, GCOEKNBDHOA HMGDBPCOADP, [Optional] EEAHIAKKBFK DIGGKGPGEEF, EGLADIECCOM CGHALICGNAA = EGLADIECCOM.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2DC72A0", Offset = "0x2DC58A0", VA = "0x182DC72A0")]
			public void FANEFMBOHHI(IEnumerable<MGJNKMHBPDE> FDCMCGDJBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2DC7C60", Offset = "0x2DC6260", VA = "0x182DC7C60")]
			private MGJNKMHBPDE JLDIAIAJDKB(int GMEFIILDDDC)
			{
				return default(MGJNKMHBPDE);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2DC7490", Offset = "0x2DC5A90", VA = "0x182DC7490")]
			private void FGEFJCGFAAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x419E520", Offset = "0x419CB20", VA = "0x18419E520")]
			private static void HNGAGPJDNKM<T>(int GMEFIILDDDC, T[] FLAKPNDJMHH, int OGHBEIMLJPA, [Optional] T PBGGEDOODMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x419E500", Offset = "0x419CB00", VA = "0x18419E500")]
			private static void HNGAGPJDNKM<T>(int GMEFIILDDDC, NativeArray<T> FLAKPNDJMHH, int OGHBEIMLJPA, [Optional] T PBGGEDOODMB) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2DC6A40", Offset = "0x2DC5040", VA = "0x182DC6A40")]
			private void BOMPPNFEDPG(IEnumerable<MGJNKMHBPDE> FDCMCGDJBEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x2DC6CE0", Offset = "0x2DC52E0", VA = "0x182DC6CE0")]
			private void CNABLGDFPPL(MGJNKMHBPDE AALGHKBAMME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x2DC6DA0", Offset = "0x2DC53A0", VA = "0x182DC6DA0")]
			private MCBKLEJFNDD DNLDIFHBIBO(int FDKMBGKAMIE)
			{
				return default(MCBKLEJFNDD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x2DC7800", Offset = "0x2DC5E00", VA = "0x182DC7800")]
			public void HAFLICJFGAD(float ANHKOPDIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x2DC8240", Offset = "0x2DC6840", VA = "0x182DC8240")]
			private void MFELJGJKBAI(Action LFCBLKFDHFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x2DC69C0", Offset = "0x2DC4FC0", VA = "0x182DC69C0")]
			private void BKFJFACDIPM(Action LFCBLKFDHFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2DC6520", Offset = "0x2DC4B20", VA = "0x182DC6520")]
			public void BHOJIOGLNMC(float ANHKOPDIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x2DC79F0", Offset = "0x2DC5FF0", VA = "0x182DC79F0")]
			public void HGJFGLHEDBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2DC7120", Offset = "0x2DC5720", VA = "0x182DC7120")]
			public void EHICJNGNPDC(EEAHIAKKBFK JCODLLHEAAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2DC71E0", Offset = "0x2DC57E0", VA = "0x182DC71E0")]
			public void EKEMNIBAKHC(EEAHIAKKBFK JCODLLHEAAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x2DC7060", Offset = "0x2DC5660", VA = "0x182DC7060")]
			public void EHDDDLHKCGJ(EEAHIAKKBFK JCODLLHEAAK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct BEEIGJAJNNC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float FCDCOPJHDBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int GJFFIMDGIPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> EBHDKOFLLJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> NOIEPAJILDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> EGPOHKCKGIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<EGLADIECCOM> BFDJMBIIMOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> OGJOILHJNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> PIGIPGNBLDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> HAIFIBHBGMK;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2E70", Offset = "0x2DC1470", VA = "0x182DC2E70")]
			public static BEEIGJAJNNC NIBKLGLBMIL(int IDKPFDIDBPO, float ANHKOPDIBAC, NativeArray<EGLADIECCOM> MKGEBMCALNP, NativeArray<float> LEBPCGFHJKL, NativeArray<int> OAFCMNHEDGK, NativeArray<int> LLIIPCNKHFO, NativeArray<int> NJPJEJMHOGK, NativeArray<int> NOIEPAJILDK, NativeArray<int> EGPOHKCKGIF)
			{
				return default(BEEIGJAJNNC);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2CB0", Offset = "0x2DC12B0", VA = "0x182DC2CB0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2E00", Offset = "0x2DC1400", VA = "0x182DC2E00")]
			private bool GMFCMDKFDOH(int OEELHFBMNBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2E40", Offset = "0x2DC1440", VA = "0x182DC2E40")]
			private void MNIGMGEHMBK(NativeArray<int> GKFPJEFODNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2D90", Offset = "0x2DC1390", VA = "0x182DC2D90")]
			private int FFMPGJALJIJ(int NOGALELJPEN, int IPGFIGKBFBL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2DC2F40", Offset = "0x2DC1540", VA = "0x182DC2F40")]
			private void OAEPLJDJPGP(NativeArray<int> GKFPJEFODNI, int PPMDEDJEJND, int DLEEOHNBLDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2DC3010", Offset = "0x2DC1610", VA = "0x182DC3010")]
			private void PJNGNFGAGNO(NativeArray<int> GKFPJEFODNI, int CKFGGNAAEAN, int HLAKOPGNFKK, int MACHDLBNPGD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class OCKBOFHEDNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly GCOEKNBDHOA HMGDBPCOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour NBOHPDEHCDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool JHDAHIAOPBB;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<NHGKJABNDLI> DEKKKMAFHCN
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x56C4A0", Offset = "0x56AAA0", VA = "0x18056C4A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x56C4B0", Offset = "0x56AAB0", VA = "0x18056C4B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public NHGKJABNDLI AFKHNJEKBHM
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x56B740", Offset = "0x569D40", VA = "0x18056B740")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool ENOJIDMMJBO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x2DD16E0", Offset = "0x2DCFCE0", VA = "0x182DD16E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool OFJLEOMBBMO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xA88F80", Offset = "0xA87580", VA = "0x180A88F80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA88F90", Offset = "0xA87590", VA = "0x180A88F90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string HJBLNLINMDO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x57F1A0", Offset = "0x57D7A0", VA = "0x18057F1A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x58A2A0", Offset = "0x5888A0", VA = "0x18058A2A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float LKOKMMMKFAB
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x5AA170", Offset = "0x5A8770", VA = "0x1805AA170")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x5AA210", Offset = "0x5A8810", VA = "0x1805AA210")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1AB0", Offset = "0x2DD00B0", VA = "0x182DD1AB0")]
			public OCKBOFHEDNO(IEnumerator<NHGKJABNDLI> DDJINGCACCB, Behaviour NBOHPDEHCDB, GCOEKNBDHOA HMGDBPCOADP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1800", Offset = "0x2DCFE00", VA = "0x182DD1800")]
			public NHGKJABNDLI GOPGEKIDEID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1650", Offset = "0x2DCFC50", VA = "0x182DD1650")]
			public bool BKFJEENMOFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1770", Offset = "0x2DCFD70", VA = "0x182DD1770")]
			public void EHICJNGNPDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1A20", Offset = "0x2DD0020", VA = "0x182DD1A20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2DD1A10", Offset = "0x2DD0010", VA = "0x182DD1A10")]
			[CompilerGenerated]
			private void HEFKEJFMOLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class GCOEKNBDHOA : FOKDHDDGLPP, JEPECMMDIGN, POAJLJLELOL, GDOLLDLAJJG, IEnumerator, NHGKJABNDLI, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private HPKCBBOAJAB.DGCEPOPAIEE PAPPEAODHPH;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private HPKCBBOAJAB.DGCEPOPAIEE IBEIDNMNAKC
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x5A3D40", Offset = "0x5A2340", VA = "0x1805A3D40", Slot = "23")]
				get
				{
					return default(HPKCBBOAJAB.DGCEPOPAIEE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public HPKCBBOAJAB.DGCEPOPAIEE MCBGOABNICF
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x5A3D40", Offset = "0x5A2340", VA = "0x1805A3D40")]
				get
				{
					return default(HPKCBBOAJAB.DGCEPOPAIEE);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x5A35C0", Offset = "0x5A1BC0", VA = "0x1805A35C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float AHLJFJKBMNN
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x6FD260", Offset = "0x6FB860", VA = "0x1806FD260", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2DC98E0", Offset = "0x2DC7EE0", VA = "0x182DC98E0", Slot = "24")]
			private bool KDANPHACKFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2DC98D0", Offset = "0x2DC7ED0", VA = "0x182DC98D0", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x2DC9900", Offset = "0x2DC7F00", VA = "0x182DC9900")]
			public GCOEKNBDHOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum MCBKLEJFNDD : byte
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
		private sealed class GLMJLCIEAJN : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum ECNNPDBADGF
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct EHJAHGDMEAC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public HPKCBBOAJAB.DGCEPOPAIEE OPLNPKMJMCF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public ECNNPDBADGF PBGNOOJCHEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<OCKBOFHEDNO> LOGBKIKDPAA;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly ECNNPDBADGF[] HAJOHNILDPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly HPKCBBOAJAB.DGCEPOPAIEE OKCPOHFFDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool CDPANIDFJKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly OCKBOFHEDNO[] EIHKFMHCPFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<OCKBOFHEDNO> AKPKMGEHINK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> KJLKFNFJPCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<OCKBOFHEDNO> JMENNMJMNCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> NBCNIGNPEMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool DMOLGAALALB;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public EHJAHGDMEAC[,] LOJBACECDLN
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x521D80", Offset = "0x520380", VA = "0x180521D80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int OBKACAMJFOP
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x2DCA110", Offset = "0x2DC8710", VA = "0x182DCA110")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2DCB570", Offset = "0x2DC9B70", VA = "0x182DCB570")]
			public GLMJLCIEAJN(HPKCBBOAJAB.DGCEPOPAIEE FFMFKENFGDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA480", Offset = "0x2DC8A80", VA = "0x182DCA480")]
			public void DLOEFCGABPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA740", Offset = "0x2DC8D40", VA = "0x182DCA740")]
			public void EDIMOFDAAFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2DCAB20", Offset = "0x2DC9120", VA = "0x182DCAB20")]
			private void GAKIBLLONOK(IReadOnlyList<OCKBOFHEDNO> GHEIPIHPGIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x2DCB190", Offset = "0x2DC9790", VA = "0x182DCB190")]
			public void NGNKECFBFPA(OCKBOFHEDNO DDJINGCACCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA8A0", Offset = "0x2DC8EA0", VA = "0x182DCA8A0")]
			public void FEMHEAJLHON(IList<OCKBOFHEDNO> EEPBIJLJBJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2DCAE20", Offset = "0x2DC9420", VA = "0x182DCAE20")]
			public void IPMBPOMEDIL(IList<OCKBOFHEDNO> EEPBIJLJBJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2DCB0A0", Offset = "0x2DC96A0", VA = "0x182DCB0A0")]
			private void NFMLAHHPAFF(OCKBOFHEDNO DDJINGCACCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA5D0", Offset = "0x2DC8BD0", VA = "0x182DCA5D0")]
			private void EABNOIFJAPO(IList<OCKBOFHEDNO> EEPBIJLJBJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA750", Offset = "0x2DC8D50", VA = "0x182DCA750")]
			private MCBKLEJFNDD EIBLONJECPK(OCKBOFHEDNO DDJINGCACCB)
			{
				return default(MCBKLEJFNDD);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2DCAD70", Offset = "0x2DC9370", VA = "0x182DCAD70")]
			public void HLFBHDKMFNH(float ANHKOPDIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA280", Offset = "0x2DC8880", VA = "0x182DCA280")]
			public void DFMPIJOFHEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DCB2B0", Offset = "0x2DC98B0", VA = "0x182DCB2B0")]
			private void PNMEMGGOBEN(List<OCKBOFHEDNO> EEPBIJLJBJM, Stack<int> CBJKIDINJCB, bool LAAMEIAHIEN, float BEBMJENKAKC = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2DCA490", Offset = "0x2DC8A90", VA = "0x182DCA490", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2DCAC50", Offset = "0x2DC9250", VA = "0x182DCAC50")]
			private void GKKBABEAHMA(List<OCKBOFHEDNO> EEPBIJLJBJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum EGLADIECCOM : byte
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
		private sealed class LEJEJGMHMKG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x50D610", Offset = "0x50BC10", VA = "0x18050D610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x532760", Offset = "0x530D60", VA = "0x180532760")]
			[DebuggerHidden]
			public LEJEJGMHMKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2DCE4F0", Offset = "0x2DCCAF0", VA = "0x182DCE4F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2DCE570", Offset = "0x2DCCB70", VA = "0x182DCE570", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const EGLADIECCOM KMJBMCLLCNO = EGLADIECCOM.Cancelled | EGLADIECCOM.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly HPKCBBOAJAB.DGCEPOPAIEE[] MNCCMMDNDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private GLMJLCIEAJN[] PNKIMEBMOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DICOLLCMMBM[] KFKMFGLJBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine BKPMNMPADHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame KGJBDBBPCJF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public HPKCBBOAJAB.DGCEPOPAIEE LFCGMIMAJAI
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x56D520", Offset = "0x56BB20", VA = "0x18056D520")]
			[CompilerGenerated]
			get
			{
				return default(HPKCBBOAJAB.DGCEPOPAIEE);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x56D480", Offset = "0x56BA80", VA = "0x18056D480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BHIEPNNEGEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x814620", Offset = "0x812C20", VA = "0x180814620", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x814610", Offset = "0x812C10", VA = "0x180814610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int OBKACAMJFOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2DD4650", Offset = "0x2DD2C50", VA = "0x182DD4650")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3470", Offset = "0x2DD1A70", VA = "0x182DD3470")]
		public static JEPECMMDIGN GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2F50", Offset = "0x2DD1550", VA = "0x182DD2F50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3580", Offset = "0x2DD1B80", VA = "0x182DD3580", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3510", Offset = "0x2DD1B10", VA = "0x182DD3510")]
		private GLMJLCIEAJN LGDJPEBELOK(HPKCBBOAJAB.DGCEPOPAIEE JOBKDGGGOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x15D9460", Offset = "0x15D7A60", VA = "0x1815D9460")]
		private DICOLLCMMBM CNIBIMDNPMF(HPKCBBOAJAB.DGCEPOPAIEE JOBKDGGGOHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3A40", Offset = "0x2DD2040", VA = "0x182DD3A40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3A00", Offset = "0x2DD2000", VA = "0x182DD3A00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4420", Offset = "0x2DD2A20", VA = "0x182DD4420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3570", Offset = "0x2DD1B70", VA = "0x182DD3570")]
		private void MDGJFPDDNFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3550", Offset = "0x2DD1B50", VA = "0x182DD3550")]
		private void LLCJLFCCOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3460", Offset = "0x2DD1A60", VA = "0x182DD3460")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3560", Offset = "0x2DD1B60", VA = "0x182DD3560")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD33F0", Offset = "0x2DD19F0", VA = "0x182DD33F0")]
		private void BPMOPIOOBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2D20", Offset = "0x2DD1320", VA = "0x182DD2D20")]
		[IteratorStateMachine(typeof(LEJEJGMHMKG))]
		private IEnumerator AKLOGCFAFNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3D10", Offset = "0x2DD2310", VA = "0x182DD3D10", Slot = "7")]
		public JEPECMMDIGN Run(IEnumerator<NHGKJABNDLI> OIDGAEIBAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3D20", Offset = "0x2DD2320", VA = "0x182DD3D20", Slot = "8")]
		public JEPECMMDIGN Run(Behaviour NBOHPDEHCDB, IEnumerator<NHGKJABNDLI> OIDGAEIBAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3BE0", Offset = "0x2DD21E0", VA = "0x182DD3BE0", Slot = "9")]
		public JEPECMMDIGN RunJobbed(OMJOGKFDDGH NBOHPDEHCDB, IEnumerator<NHGKJABNDLI> OIDGAEIBAOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3400", Offset = "0x2DD1A00", VA = "0x182DD3400", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3F50", Offset = "0x2DD2550", VA = "0x182DD3F50")]
		public void UpdateQueue(HPKCBBOAJAB.DGCEPOPAIEE JLKFGFOHAGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2D90", Offset = "0x2DD1390", VA = "0x182DD2D90")]
		private void ANEPPBOPLAI(GLMJLCIEAJN IMNIAMAPLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3AC0", Offset = "0x2DD20C0", VA = "0x182DD3AC0")]
		private void POIOOHFAIJN(DICOLLCMMBM IMNIAMAPLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2DD45E0", Offset = "0x2DD2BE0", VA = "0x182DD45E0")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class HLJHCOFFFDO
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC180", Offset = "0x2DCA780", VA = "0x182DCC180")]
	[IABMDIJNELF]
	private static void BMGFGFNKNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class BAGDMDGNCNL : CMJOIFPAEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float MCIEJPCKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2C70", Offset = "0x2DC1270", VA = "0x182DC2C70", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float BBKPACIDDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2C50", Offset = "0x2DC1250", VA = "0x182DC2C50", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float ACAGFOCHKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2C80", Offset = "0x2DC1280", VA = "0x182DC2C80", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int NCJOGCDMCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2C60", Offset = "0x2DC1260", VA = "0x182DC2C60", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double MPDKBNGHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2DC2C90", Offset = "0x2DC1290", VA = "0x182DC2C90", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public BAGDMDGNCNL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8D40", Offset = "0x2DC7340", VA = "0x182DC8D40")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2DC8E40", Offset = "0x2DC7440", VA = "0x182DC8E40")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
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
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
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

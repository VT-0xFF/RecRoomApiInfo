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
public class OAPAPFDLLPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority FLNAPIKACOH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5378520", Offset = "0x5377520", VA = "0x185378520")]
	public OAPAPFDLLPC(ThreadPriority MEGPKMNCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5378510", Offset = "0x5377510", VA = "0x185378510", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> MHHCHNBJEAP(List<PlayerLoopSystem> PLPMKPECLOE, int HNJMLDGLJJG);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct MJLFHNFCNJE
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct PMHOMAAEPKJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static CMOPDACJGKG FDFAGAHCHJI;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x53797A0", Offset = "0x53787A0", VA = "0x1853797A0")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct NLCBGLLLMOO
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static CMOPDACJGKG HDGOPGEIKHI;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5378250", Offset = "0x5377250", VA = "0x185378250")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PAIDNEIOLCO
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static CMOPDACJGKG GJLNFNEALIO;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x5378C10", Offset = "0x5377C10", VA = "0x185378C10")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct NIEHDIFGHAI
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static CMOPDACJGKG JLFEFNDJNEN;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static CMOPDACJGKG DLJEAKKONGD;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static CMOPDACJGKG FGKNDDBHDIH;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static CMOPDACJGKG NPLCDOGFNMI;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5376730", Offset = "0x5375730", VA = "0x185376730")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct PCBBHAHPADB
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static CMOPDACJGKG ICNENKJKDFO;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x53790F0", Offset = "0x53780F0", VA = "0x1853790F0")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PJELMICJIFE
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static CMOPDACJGKG JLFEFNDJNEN;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static CMOPDACJGKG DLJEAKKONGD;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static CMOPDACJGKG FGKNDDBHDIH;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static CMOPDACJGKG NPLCDOGFNMI;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x5379510", Offset = "0x5378510", VA = "0x185379510")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct NDHJMDDFNPH
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static CMOPDACJGKG JMNDLCKMAGO;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5376520", Offset = "0x5375520", VA = "0x185376520")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct EHMADAOMABA
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static CMOPDACJGKG NKIKPIPNDLN;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5369CA0", Offset = "0x5368CA0", VA = "0x185369CA0")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct EBICBEFOMBD
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static CMOPDACJGKG DDMHDKAPDPA;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x5369AC0", Offset = "0x5368AC0", VA = "0x185369AC0")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct HAHDKLFMHPA
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static CMOPDACJGKG FJOPFCKLONO;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x536B5D0", Offset = "0x536A5D0", VA = "0x18536B5D0")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct LHBBDGPGHPI
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static CMOPDACJGKG CEFOKELBMAP;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5370B20", Offset = "0x536FB20", VA = "0x185370B20")]
				public static PlayerLoopSystem NJNMHBHNKGK()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct ILMFCEDPLFK
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class PGMOEJFDNAC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public KBIOHFMCCOL.NHPFLHKIPJN key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
					public PGMOEJFDNAC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x53792D0", Offset = "0x53782D0", VA = "0x1853792D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable CIFDLDDDHMH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x536D380", Offset = "0x536C380", VA = "0x18536D380")]
				public static PlayerLoopSystem JJMFLPPJIGB(KBIOHFMCCOL.NHPFLHKIPJN AGPLDPOAAIC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			internal struct AGOPFFKAPNA
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				[CompilerGenerated]
				private sealed class NLCFCCAOLOP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002C")]
					public KBIOHFMCCOL.NHPFLHKIPJN key;

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
					public NLCFCCAOLOP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x5378430", Offset = "0x5377430", VA = "0x185378430")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x5364630", Offset = "0x5363630", VA = "0x185364630")]
				public static PlayerLoopSystem JJMFLPPJIGB(KBIOHFMCCOL.NHPFLHKIPJN AGPLDPOAAIC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class HNFDEHGHBOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public HNFDEHGHBOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x536BF80", Offset = "0x536AF80", VA = "0x18536BF80")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OMPJECLCLIK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NEBCBHIJFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5365FE0", Offset = "0x5364FE0", VA = "0x185365FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5366150", Offset = "0x5365150", VA = "0x185366150")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5367340", Offset = "0x5366340", VA = "0x185367340")]
		private static void PLDOBCMDIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5366190", Offset = "0x5365190", VA = "0x185366190")]
		private static void HDJHAKLLMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5366E50", Offset = "0x5365E50", VA = "0x185366E50")]
		private static void NBBCBMKDFGI(string CGBFALCJHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5365DB0", Offset = "0x5364DB0", VA = "0x185365DB0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5367180", Offset = "0x5366180", VA = "0x185367180")]
		private static void ODKEAKGHGGG(KBIOHFMCCOL.NHPFLHKIPJN AGPLDPOAAIC, ref PlayerLoopSystem MADOOMAHBED, Type EAAPFBKBLGA, Type MOHBNJJKJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5366A60", Offset = "0x5365A60", VA = "0x185366A60")]
		private static void JLIJEHBECAI(ref PlayerLoopSystem MADOOMAHBED, Type EAAPFBKBLGA, Type MOHBNJJKJGG, MHHCHNBJEAP EMDCEMGEMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5366020", Offset = "0x5365020", VA = "0x185366020")]
		private static void DAACDBIOGMF(ref PlayerLoopSystem MADOOMAHBED, Type EAAPFBKBLGA, Type MOHBNJJKJGG, PlayerLoopSystem? GJFPBDLFNFE, PlayerLoopSystem? FHKJFGDKIPK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KBIOHFMCCOL
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum NHPFLHKIPJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GNILMGEKHKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly NHPFLHKIPJN LMHGNAEODAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly FCNKEDKJDMK KIBNMFNKANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long EIAHNAFDEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private long FGIIAJGNNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public long PIKAGFBKCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int IIDGKCMFOBD;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x536B2D0", Offset = "0x536A2D0", VA = "0x18536B2D0")]
		public GNILMGEKHKO(NHPFLHKIPJN HBDFMOICEGC, int IMEFBPFHEBB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x536B000", Offset = "0x536A000", VA = "0x18536B000")]
		public void ANDAPDOHCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x536B270", Offset = "0x536A270", VA = "0x18536B270")]
		public void PPGMDNFAMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x536B070", Offset = "0x536A070", VA = "0x18536B070")]
		public void FFEDMJPMKNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static NHPFLHKIPJN[] ICDCNAPADLH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static GNILMGEKHKO[] MIOANOEIKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x536F490", Offset = "0x536E490", VA = "0x18536F490")]
	public static GNILMGEKHKO KHINJGHBJEP(NHPFLHKIPJN AGPLDPOAAIC, int IMEFBPFHEBB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x536F660", Offset = "0x536E660", VA = "0x18536F660")]
	public static GNILMGEKHKO MAGBHGDLIBF(NHPFLHKIPJN AGPLDPOAAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x536F6F0", Offset = "0x536E6F0", VA = "0x18536F6F0")]
	public static void OOIPAPNAGIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FCNKEDKJDMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public int NAFKADIKNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Queue<double> HFJNCJDGCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private double BNIGPLBPEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private double EJIIEDBELNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private double GACBIONHEPJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MEOOCGGNBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x536A010", Offset = "0x5369010", VA = "0x18536A010", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x536A0E0", Offset = "0x53690E0", VA = "0x18536A0E0")]
	public FCNKEDKJDMK(int LFLFBLKGDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5369EE0", Offset = "0x5368EE0", VA = "0x185369EE0", Slot = "4")]
	public void LKKAOHKNABB(double OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x536A070", Offset = "0x5369070", VA = "0x18536A070", Slot = "5")]
	public void PKLFPAMOGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GINKIGMOLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private long LGKBEOCJMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double KCGMFGPHCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double CPMBELHMCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double AAGFPPFGICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private double BDDJIMMLBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double BNIGPLBPEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double EJIIEDBELNE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double ENDFKHFGKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3534090", Offset = "0x3533090", VA = "0x183534090", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double BLGHHHHNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAABDE0", Offset = "0xAAADE0", VA = "0x180AABDE0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EFNFCHNIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x30DE620", Offset = "0x30DD620", VA = "0x1830DE620")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MEOOCGGNBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x34AB990", Offset = "0x34AA990", VA = "0x1834AB990", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x536AD50", Offset = "0x5369D50", VA = "0x18536AD50", Slot = "7")]
	public void LKKAOHKNABB(double OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x536AE80", Offset = "0x5369E80", VA = "0x18536AE80", Slot = "8")]
	public void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x536AEC0", Offset = "0x5369EC0", VA = "0x18536AEC0")]
	public GINKIGMOLCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DJEMEIDPAMN
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private interface MDIAIPFDAMK
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool OKLPCPLDDDE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ECFFKMLILHP();
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private abstract class JFNAACBNBFF<TPromise, TMainThreadPromise> : MDIAIPFDAMK where TPromise : MLEPGEJLFCO where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly TPromise HOJKBLAJFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		protected readonly TMainThreadPromise BLGNILDGBII;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise BKJHOLKEIJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x233DD40", Offset = "0x233CD40", VA = "0x18233DD40")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OKLPCPLDDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x233DC90", Offset = "0x233CC90", VA = "0x18233DC90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2057200", Offset = "0x2056200", VA = "0x182057200")]
		protected JFNAACBNBFF(TPromise HOJKBLAJFAL, TMainThreadPromise IADKMJNJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x233DDA0", Offset = "0x233CDA0", VA = "0x18233DDA0", Slot = "5")]
		public void ECFFKMLILHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void IMAGBLCMBAB(TPromise HOJKBLAJFAL);
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class LBODKFNIGFN<T> : JFNAACBNBFF<global::AGDEEHNAPKP<T>, global::MJBDKPPKHFK<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A900C0", Offset = "0x2A8F0C0", VA = "0x182A900C0")]
		public LBODKFNIGFN(global::AGDEEHNAPKP<T> HOJKBLAJFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2A8FF30", Offset = "0x2A8EF30", VA = "0x182A8FF30", Slot = "6")]
		protected override void IMAGBLCMBAB(global::AGDEEHNAPKP<T> HOJKBLAJFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A90090", Offset = "0x2A8F090", VA = "0x182A90090")]
		[CompilerGenerated]
		private void PNLJODBMAAP(T BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2064350", Offset = "0x2063350", VA = "0x182064350")]
		[CompilerGenerated]
		private void EKNNDFADIMJ(string OJDKKCJFMBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class MDOOLMLHOHE : MDIAIPFDAMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Action NCHNGIGODJK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OKLPCPLDDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
		public MDOOLMLHOHE(Action NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x11B46E0", Offset = "0x11B36E0", VA = "0x1811B46E0", Slot = "5")]
		public void ECFFKMLILHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly List<MDIAIPFDAMK> FIOKNDBAHPE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27B8A50", Offset = "0x27B7A50", VA = "0x1827B8A50")]
	public static global::AGDEEHNAPKP<T> EHMOHHCBFHA<T>(this global::AGDEEHNAPKP<T> HOJKBLAJFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x53696E0", Offset = "0x53686E0", VA = "0x1853696E0")]
	public static void EHMOHHCBFHA(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27B8AC0", Offset = "0x27B7AC0", VA = "0x1827B8AC0")]
	private static global::AGDEEHNAPKP<T> GIPOKKOOPIG<T>(global::AGDEEHNAPKP<T> HOJKBLAJFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5369770", Offset = "0x5368770", VA = "0x185369770")]
	private static void IDMMDLLFBHG(MDIAIPFDAMK EFPCPGJIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x53692F0", Offset = "0x53682F0", VA = "0x1853692F0")]
	private static void BBCJGGNFOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x53695E0", Offset = "0x53685E0", VA = "0x1853695E0")]
	private static void BHCJIKKFOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5369970", Offset = "0x5368970", VA = "0x185369970")]
	private static void MBALPDLLFAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JEJLNHIHLEN
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct EOIBDBALPHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TaskCompletionSource<Scene> JMOJGDCDCNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly string COMINAANPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly LoadSceneMode OOGMHCDEAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly bool FHJKEIFCOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly HKLBBGEFPMO NMGDNGMBHAG;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5369E80", Offset = "0x5368E80", VA = "0x185369E80")]
		public EOIBDBALPHI(TaskCompletionSource<Scene> JFGJIKHOIAH, string COMINAANPMI, LoadSceneMode OOGMHCDEAMP, bool FHJKEIFCOLE, HKLBBGEFPMO NMGDNGMBHAG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LOOBIFHOMFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HKLBBGEFPMO stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private global::BJNCMLEHIAG<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5373C10", Offset = "0x5372C10", VA = "0x185373C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5374280", Offset = "0x5373280", VA = "0x185374280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PALNPFLHLFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5378DF0", Offset = "0x5377DF0", VA = "0x185378DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct HGMAOKOHFIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private EOIBDBALPHI <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x536B7B0", Offset = "0x536A7B0", VA = "0x18536B7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OBMEIMKPDFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public global::MJBDKPPKHFK<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OBMEIMKPDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5378560", Offset = "0x5377560", VA = "0x185378560")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LEFJICLJICH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private OBMEIMKPDFK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private HKLBBGEFPMO <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private HKLBBGEFPMO <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5370150", Offset = "0x536F150", VA = "0x185370150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5370AD0", Offset = "0x536FAD0", VA = "0x185370AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IFCJMJIOECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public HKLBBGEFPMO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private HKLBBGEFPMO <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HKLBBGEFPMO <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x536CAF0", Offset = "0x536BAF0", VA = "0x18536CAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x536D330", Offset = "0x536C330", VA = "0x18536D330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class NIAPBEKEDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public NIAPBEKEDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5376700", Offset = "0x5375700", VA = "0x185376700")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HKIMMJOAHBF : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AMPMBAOHAPE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public HKIMMJOAHBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x536BEA0", Offset = "0x536AEA0", VA = "0x18536BEA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x536BB40", Offset = "0x536AB40", VA = "0x18536BB40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x536BF30", Offset = "0x536AF30", VA = "0x18536BF30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x536BE60", Offset = "0x536AE60", VA = "0x18536BE60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KCJPDLBJAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::MJBDKPPKHFK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KCJPDLBJAEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KCMIABGKLLL : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::MJBDKPPKHFK<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private KCJPDLBJAEL <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public KCMIABGKLLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x536FBD0", Offset = "0x536EBD0", VA = "0x18536FBD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5370020", Offset = "0x536F020", VA = "0x185370020", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static MLEPGEJLFCO IDCNGPLPCEH;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static AsyncOperation HIFKPBCANDN;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static MLEPGEJLFCO JBMHAODLHPP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static string PANAGJDHHNB;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static ThreadPriority CACAABBLGIA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Task NMJAKDJNGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Queue<EOIBDBALPHI> IKELKNBIBOO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Task NPNBJIIAHFM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool HGGCBMLHLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x536D4B0", Offset = "0x536C4B0", VA = "0x18536D4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool FLKEPABFOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x536E2F0", Offset = "0x536D2F0", VA = "0x18536E2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool DJHOFECBOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x536E020", Offset = "0x536D020", VA = "0x18536E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MONDFNKBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x536E3A0", Offset = "0x536D3A0", VA = "0x18536E3A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x536DB30", Offset = "0x536CB30", VA = "0x18536DB30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x536E0E0", Offset = "0x536D0E0", VA = "0x18536E0E0")]
	[DDDKNIGBKHH(ODNNAFCJNAG.EnteredEditModeNextFrame, 0)]
	private static void JLCEMALGGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x536D9D0", Offset = "0x536C9D0", VA = "0x18536D9D0")]
	[AsyncStateMachine(typeof(LOOBIFHOMFO))]
	public static Task<Scene> FCOJHHBKJFF(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP = LoadSceneMode.Single, bool FHJKEIFCOLE = false, [Optional] HKLBBGEFPMO FDGKFPMCJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x536DD20", Offset = "0x536CD20", VA = "0x18536DD20")]
	[AsyncStateMachine(typeof(PALNPFLHLFE))]
	private static Task HPKAMMGGJHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x536DC30", Offset = "0x536CC30", VA = "0x18536DC30")]
	[AsyncStateMachine(typeof(HGMAOKOHFIL))]
	private static Task HIGECIPLPLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x536D7D0", Offset = "0x536C7D0", VA = "0x18536D7D0")]
	[AsyncStateMachine(typeof(LEFJICLJICH))]
	private static Task<Scene> CPPMBMCNJEO(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP, bool FHJKEIFCOLE, HKLBBGEFPMO NMGDNGMBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x536E1B0", Offset = "0x536D1B0", VA = "0x18536E1B0")]
	[AsyncStateMachine(typeof(IFCJMJIOECB))]
	private static Task<Scene> JPCAELBKOIJ(HKLBBGEFPMO NMGDNGMBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x536DDF0", Offset = "0x536CDF0", VA = "0x18536DDF0")]
	public static global::AGDEEHNAPKP<Scene> IIOMDBDMDDP(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x536E4A0", Offset = "0x536D4A0", VA = "0x18536E4A0")]
	public static MLEPGEJLFCO MIMIOHOHNMA(string COMINAANPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x536DF90", Offset = "0x536CF90", VA = "0x18536DF90")]
	[IteratorStateMachine(typeof(HKIMMJOAHBF))]
	private static IEnumerator<KDCGDINMKGL> ILHKCBPLEOE(string COMINAANPMI, AMPMBAOHAPE NOJJDNNPGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x536D930", Offset = "0x536C930", VA = "0x18536D930")]
	[IteratorStateMachine(typeof(KCMIABGKLLL))]
	private static IEnumerator<KDCGDINMKGL> DBCJECHIFLH(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP, global::MJBDKPPKHFK<Scene> NOJJDNNPGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x536D670", Offset = "0x536C670", VA = "0x18536D670")]
	public static bool CJCNBLCBEDE(out string DKGKFLHBAFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AOGAMBNFHPG
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x53648B0", Offset = "0x53638B0", VA = "0x1853648B0")]
	public static IDisposable NFEEKNJJKEH(this JOLKFPIPKMP IGBOEABBEHO, float IHDKALKKCII, Action<float> MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5364930", Offset = "0x5363930", VA = "0x185364930")]
	public static IDisposable OMECKHIPEOO(this JOLKFPIPKMP IGBOEABBEHO, Action<float> MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5364830", Offset = "0x5363830", VA = "0x185364830")]
	public static IDisposable JPFHEENFPMC(this JOLKFPIPKMP IGBOEABBEHO, Action<float> MMDMJIGCAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CLFFMNFABEL
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5365A50", Offset = "0x5364A50", VA = "0x185365A50")]
	public static IDisposable MINDHKMGPKJ(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5365AD0", Offset = "0x5364AD0", VA = "0x185365AD0")]
	public static IDisposable MINDHKMGPKJ(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5365720", Offset = "0x5364720", VA = "0x185365720")]
	public static IDisposable FMPDGFOLIAO(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x53658B0", Offset = "0x53648B0", VA = "0x1853658B0")]
	public static IDisposable JDHHMNHLCML(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5365460", Offset = "0x5364460", VA = "0x185365460")]
	public static IDisposable BEBFDDBPGKF(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5365570", Offset = "0x5364570", VA = "0x185365570")]
	public static IDisposable DEACOEAMCDC(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x53653E0", Offset = "0x53643E0", VA = "0x1853653E0")]
	public static IDisposable AMFOIDAJGNL(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5365BE0", Offset = "0x5364BE0", VA = "0x185365BE0")]
	public static IDisposable NOOGNICHFAF(this MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5365680", Offset = "0x5364680", VA = "0x185365680")]
	public static IDisposable FHDBCIMFPMO(this MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5365820", Offset = "0x5364820", VA = "0x185365820")]
	public static IDisposable GFKGJCGMJMH(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x53659C0", Offset = "0x53649C0", VA = "0x1853659C0")]
	public static IDisposable LJCBJOCKIFH(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x53654E0", Offset = "0x53644E0", VA = "0x1853654E0")]
	public static IDisposable DBFKFBLJIPN(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5365B50", Offset = "0x5364B50", VA = "0x185365B50")]
	public static IDisposable NOGEAANFMON(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5365C80", Offset = "0x5364C80", VA = "0x185365C80")]
	public static IDisposable OLIPJOFHBJO(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5365930", Offset = "0x5364930", VA = "0x185365930")]
	public static IDisposable LHCHPLEAHBJ(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5365790", Offset = "0x5364790", VA = "0x185365790")]
	public static IDisposable GCNADGIKANN(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5365D10", Offset = "0x5364D10", VA = "0x185365D10")]
	public static IDisposable PFFKFEDKNDA(this MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x53655F0", Offset = "0x53645F0", VA = "0x1853655F0")]
	public static IDisposable ENPBDIPJHAK(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class OFMDMNODKLH
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BENJAMMNOJE : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public NNIHDAPLEEB.GCDGFJIIHGI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private DBEBFLBFDFE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public BENJAMMNOJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x53649B0", Offset = "0x53639B0", VA = "0x1853649B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5364A70", Offset = "0x5363A70", VA = "0x185364A70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class LJJAOIEFEFH : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public NNIHDAPLEEB.GCDGFJIIHGI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private DBEBFLBFDFE <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public LJJAOIEFEFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5370D00", Offset = "0x536FD00", VA = "0x185370D00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5370DF0", Offset = "0x536FDF0", VA = "0x185370DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5378890", Offset = "0x5377890", VA = "0x185378890")]
	public static PKIGMKLPPJG MINDHKMGPKJ(Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x53787D0", Offset = "0x53777D0", VA = "0x1853787D0")]
	public static PKIGMKLPPJG MINDHKMGPKJ(Behaviour IGBOEABBEHO, Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x53786C0", Offset = "0x53776C0", VA = "0x1853786C0")]
	public static PKIGMKLPPJG MINDHKMGPKJ(Behaviour IGBOEABBEHO, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5378640", Offset = "0x5377640", VA = "0x185378640")]
	[IteratorStateMachine(typeof(BENJAMMNOJE))]
	private static IEnumerator<KDCGDINMKGL> GCMAFBHHKKB(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x53785C0", Offset = "0x53775C0", VA = "0x1853785C0")]
	[IteratorStateMachine(typeof(LJJAOIEFEFH))]
	private static IEnumerator<KDCGDINMKGL> GCMAFBHHKKB(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, Action<float> MMDMJIGCAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JPNFLPNCMFN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class ACNPNAHLIBC : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public MFAOHGDBKLP schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public NNIHDAPLEEB.GCDGFJIIHGI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IDKEBDNMFIM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public ACNPNAHLIBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5363990", Offset = "0x5362990", VA = "0x185363990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5363AD0", Offset = "0x5362AD0", VA = "0x185363AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x536F160", Offset = "0x536E160", VA = "0x18536F160")]
	public static PKIGMKLPPJG MINDHKMGPKJ(MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x536F270", Offset = "0x536E270", VA = "0x18536F270")]
	public static PKIGMKLPPJG NKLHIDDDDDP(JOLKFPIPKMP IGBOEABBEHO, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x536F0B0", Offset = "0x536E0B0", VA = "0x18536F0B0")]
	[IteratorStateMachine(typeof(ACNPNAHLIBC))]
	private static IEnumerator<KDCGDINMKGL> GCMAFBHHKKB(MFAOHGDBKLP MJNCFJMFBMA, float IHDKALKKCII, NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PHHHJIFKGKA
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KHCHILOLNPK : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NNIHDAPLEEB.GCDGFJIIHGI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public KHCHILOLNPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5370060", Offset = "0x536F060", VA = "0x185370060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5370110", Offset = "0x536F110", VA = "0x185370110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5379490", Offset = "0x5378490", VA = "0x185379490")]
	[IteratorStateMachine(typeof(KHCHILOLNPK))]
	private static IEnumerator<KDCGDINMKGL> MMOAOKKLHOC(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, Func<bool> ELGFLDEBMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5379380", Offset = "0x5378380", VA = "0x185379380")]
	public static PKIGMKLPPJG GIEHLHHBDOJ(this MonoBehaviour FDEBBPLENLF, Func<bool> ELGFLDEBMNB, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB = NNIHDAPLEEB.GCDGFJIIHGI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class LLKAAPHDNNM
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class PABCMDAGGKO : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public NNIHDAPLEEB.GCDGFJIIHGI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public PABCMDAGGKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5378B10", Offset = "0x5377B10", VA = "0x185378B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5378BD0", Offset = "0x5377BD0", VA = "0x185378BD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5373A90", Offset = "0x5372A90", VA = "0x185373A90")]
	[IteratorStateMachine(typeof(PABCMDAGGKO))]
	private static IEnumerator<KDCGDINMKGL> MOMJBIONJNO(float MIJGLGOFPMF, NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5373B50", Offset = "0x5372B50", VA = "0x185373B50")]
	public static PKIGMKLPPJG NODLCGKBDNM(this MonoBehaviour FDEBBPLENLF, float MIJGLGOFPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53735F0", Offset = "0x53725F0", VA = "0x1853735F0")]
	public static PKIGMKLPPJG EILKFKBJJFB(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5373A60", Offset = "0x5372A60", VA = "0x185373A60")]
	public static PKIGMKLPPJG MIOPMCMIKHK(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x53736E0", Offset = "0x53726E0", VA = "0x1853736E0")]
	public static PKIGMKLPPJG FOGIIEHIDAG(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x53734F0", Offset = "0x53724F0", VA = "0x1853734F0")]
	public static PKIGMKLPPJG CAFBBJDLIPB(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5373B20", Offset = "0x5372B20", VA = "0x185373B20")]
	public static PKIGMKLPPJG NDNJBCMBPPH(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5373A30", Offset = "0x5372A30", VA = "0x185373A30")]
	public static PKIGMKLPPJG KEEPMEOHKAD(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5373890", Offset = "0x5372890", VA = "0x185373890")]
	private static PKIGMKLPPJG JMHMIKILBGE(MonoBehaviour FDEBBPLENLF, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, Action LILPACFFGKO, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5373610", Offset = "0x5372610", VA = "0x185373610")]
	public static PKIGMKLPPJG FIGJOEMMMLM(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5373960", Offset = "0x5372960", VA = "0x185373960")]
	public static PKIGMKLPPJG JPKEJKJEPOG(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5373520", Offset = "0x5372520", VA = "0x185373520")]
	public static PKIGMKLPPJG DOADPJPMPPG(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x53737C0", Offset = "0x53727C0", VA = "0x1853737C0")]
	public static PKIGMKLPPJG IELFILMPEON(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HAADDPPBOOG : ABIKPOONDKN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class FMPMCPODACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public HAADDPPBOOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FMPMCPODACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x536A190", Offset = "0x5369190", VA = "0x18536A190")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class JHKBEKOFNEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HAADDPPBOOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JHKBEKOFNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x536A190", Offset = "0x5369190", VA = "0x18536A190")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly float DKJMEEJHAOJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x53652E0", Offset = "0x53642E0", VA = "0x1853652E0")]
	public HAADDPPBOOG(Behaviour IGBOEABBEHO, float DKJMEEJHAOJ, [Optional] Action KOOFBOFGPIE, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x536B4D0", Offset = "0x536A4D0", VA = "0x18536B4D0", Slot = "9")]
	protected override bool LCDGBIOCBKC(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x536B3D0", Offset = "0x536A3D0", VA = "0x18536B3D0", Slot = "10")]
	protected override bool FJIEFNLNIOO(Action NCHNGIGODJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LJIPNBNBFGA
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IANEKCNNGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NHOCEMBCOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJLACBEFINM(bool MJJPNLBDKFE = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HJLACBEFINM(Action NCHNGIGODJK, bool MJJPNLBDKFE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class ABIKPOONDKN : LJIPNBNBFGA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class KBDHNDLFFLL : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public ABIKPOONDKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public KBDHNDLFFLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x536F380", Offset = "0x536E380", VA = "0x18536F380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x536F450", Offset = "0x536E450", VA = "0x18536F450", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Behaviour IGBOEABBEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action KOOFBOFGPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ECABBBEOAAH DBPHBACNJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly NAPIAOEEGEB OMHHFFBPJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	protected readonly MFAOHGDBKLP MJNCFJMFBMA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IANEKCNNGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x69B910", Offset = "0x69A910", VA = "0x18069B910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NHOCEMBCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5363340", Offset = "0x5362340", VA = "0x185363340", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x53637F0", Offset = "0x53627F0", VA = "0x1853637F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5363890", Offset = "0x5362890", VA = "0x185363890")]
	protected ABIKPOONDKN(Behaviour IGBOEABBEHO, [Optional] Action KOOFBOFGPIE, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5363640", Offset = "0x5362640", VA = "0x185363640", Slot = "7")]
	public bool HJLACBEFINM(bool MJJPNLBDKFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x53636A0", Offset = "0x53626A0", VA = "0x1853636A0", Slot = "8")]
	public bool HJLACBEFINM(Action NCHNGIGODJK, bool MJJPNLBDKFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool LCDGBIOCBKC(Action NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool FJIEFNLNIOO(Action NCHNGIGODJK);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x53633E0", Offset = "0x53623E0", VA = "0x1853633E0")]
	protected void CIFBBJODGAE(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5363400", Offset = "0x5362400", VA = "0x185363400")]
	protected MLEPGEJLFCO DHDIHHEMEGB(float LHKNOFOGOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x53636F0", Offset = "0x53626F0", VA = "0x1853636F0")]
	private void IJCOEOHJPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5363770", Offset = "0x5362770", VA = "0x185363770")]
	[IteratorStateMachine(typeof(KBDHNDLFFLL))]
	private IEnumerator<KDCGDINMKGL> LLPAKOPJBJJ(float LHKNOFOGOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5363600", Offset = "0x5362600", VA = "0x185363600")]
	[CompilerGenerated]
	private void GFMCGMANHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GAPLBLPLEBB : ABIKPOONDKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly float APMCILEDHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly int JCGIPPKFNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly float OAOPNPNBJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly float[] NKEIFAEBPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int KIBEKHEDGMP;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x536ABA0", Offset = "0x5369BA0", VA = "0x18536ABA0")]
	public GAPLBLPLEBB(Behaviour IGBOEABBEHO, float FDAEGEOGFBB, int JCGIPPKFNNE, [Optional] Action KOOFBOFGPIE, float OAOPNPNBJKG = 0f, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "9")]
	protected override bool LCDGBIOCBKC(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x536A8E0", Offset = "0x53698E0", VA = "0x18536A8E0", Slot = "10")]
	protected override bool FJIEFNLNIOO(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x536AB10", Offset = "0x5369B10", VA = "0x18536AB10")]
	private void KCLNGEFHMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CIPINIOHOAP : ABIKPOONDKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly float DKJMEEJHAOJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x53652E0", Offset = "0x53642E0", VA = "0x1853652E0")]
	public CIPINIOHOAP(Behaviour IGBOEABBEHO, float DKJMEEJHAOJ, [Optional] Action KOOFBOFGPIE, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "9")]
	protected override bool LCDGBIOCBKC(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x53652A0", Offset = "0x53642A0", VA = "0x1853652A0", Slot = "10")]
	protected override bool FJIEFNLNIOO(Action NCHNGIGODJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class JEMALGOLFLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class LPAFLAPBDOM : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public LPAFLAPBDOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x53742D0", Offset = "0x53732D0", VA = "0x1853742D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5374370", Offset = "0x5373370", VA = "0x185374370", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PKIGMKLPPJG FHNEMIPPALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private JOLKFPIPKMP IGBOEABBEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Action<float> EKBNJAKMODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float GHHNDOLBGOA;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x536EDD0", Offset = "0x536DDD0", VA = "0x18536EDD0")]
	public JEMALGOLFLL(JOLKFPIPKMP IGBOEABBEHO, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x536E8B0", Offset = "0x536D8B0", VA = "0x18536E8B0")]
	private void BHKHAHKBLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x536EC10", Offset = "0x536DC10", VA = "0x18536EC10")]
	private void DOMGPNDICKP(string OJDKKCJFMBB, Action JHBMOCHOLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x536E840", Offset = "0x536D840", VA = "0x18536E840")]
	[IteratorStateMachine(typeof(LPAFLAPBDOM))]
	private IEnumerator<KDCGDINMKGL> BGCDMBOOKOJ(Action JHBMOCHOLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x536ED70", Offset = "0x536DD70", VA = "0x18536ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x536EA60", Offset = "0x536DA60", VA = "0x18536EA60")]
	[CompilerGenerated]
	private void CKPCNAKMJNI(string GHAPGMJOMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class MGDMOOKABPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class CACGACBJEFI : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private KDCGDINMKGL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public CACGACBJEFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x53651C0", Offset = "0x53641C0", VA = "0x1853651C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5365260", Offset = "0x5364260", VA = "0x185365260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PKIGMKLPPJG FHNEMIPPALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private MonoBehaviour FDEBBPLENLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Action MMDMJIGCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Action<float> EKBNJAKMODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float GHHNDOLBGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool LJHEPNFCINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly NAPIAOEEGEB OMHHFFBPJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5374EA0", Offset = "0x5373EA0", VA = "0x185374EA0")]
	public MGDMOOKABPA(MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x53750A0", Offset = "0x53740A0", VA = "0x1853750A0")]
	public MGDMOOKABPA(MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5374C40", Offset = "0x5373C40", VA = "0x185374C40")]
	public MGDMOOKABPA(MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5374920", Offset = "0x5373920", VA = "0x185374920")]
	private void MINDHKMGPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5374A90", Offset = "0x5373A90", VA = "0x185374A90")]
	private void MPPDBPHCADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5374420", Offset = "0x5373420", VA = "0x185374420")]
	private void BHKHAHKBLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x53745E0", Offset = "0x53735E0", VA = "0x1853745E0")]
	private void DOMGPNDICKP(string OJDKKCJFMBB, Action JHBMOCHOLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53743B0", Offset = "0x53733B0", VA = "0x1853743B0")]
	[IteratorStateMachine(typeof(CACGACBJEFI))]
	private IEnumerator<KDCGDINMKGL> BGCDMBOOKOJ(Action JHBMOCHOLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5374710", Offset = "0x5373710", VA = "0x185374710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5374890", Offset = "0x5373890", VA = "0x185374890")]
	[CompilerGenerated]
	private void JDHGFPNJIDC(string GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5374770", Offset = "0x5373770", VA = "0x185374770")]
	[CompilerGenerated]
	private void GPGLDAFCPFO(string GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5374800", Offset = "0x5373800", VA = "0x185374800")]
	[CompilerGenerated]
	private void ILMGNBMEGKL(string GHAPGMJOMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Flags]
internal enum NMLGOMHGOLG : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class JIBMGPDOEGN : MFAOHGDBKLP
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float ACEDGKKBHCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x536F060", Offset = "0x536E060", VA = "0x18536F060", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float GOFIEFCPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x536EFE0", Offset = "0x536DFE0", VA = "0x18536EFE0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double LLKKFDLMBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x536EFC0", Offset = "0x536DFC0", VA = "0x18536EFC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x536EFF0", Offset = "0x536DFF0", VA = "0x18536EFF0")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void HKHPIAEGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	[Preserve]
	internal JIBMGPDOEGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface OAGAAMCHMGI
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNOCOEBBDFD(string FOGNBJMCDMG);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLLMEIOBABJ();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal interface MNAIEHBAGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MCIDMJPMKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OFOMNFICCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class IBFGJDIIELC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LLBPHHLDHFL NPDBPJKOACA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x66AF30", Offset = "0x669F30", VA = "0x18066AF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x536C350", Offset = "0x536B350", VA = "0x18536C350")]
	public static KDCGDINMKGL LJIHJCBHCBE(IEnumerator<KDCGDINMKGL> OFCPKPFIMAH, AJFAIIFPLLE FBOICHJLBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x536C500", Offset = "0x536B500", VA = "0x18536C500")]
	public KDCGDINMKGL LJIHJCBHCBE(AJFAIIFPLLE[] DBBGKLNPKJG, IEnumerator<KDCGDINMKGL>[] HJCJJJLPFHG, KDCGDINMKGL[] NGNJIBHOOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x536C1E0", Offset = "0x536B1E0", VA = "0x18536C1E0")]
	public void HLIDIAFNFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x536C0A0", Offset = "0x536B0A0", VA = "0x18536C0A0")]
	public void DHDACPMJKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x536C210", Offset = "0x536B210", VA = "0x18536C210")]
	public void JDEFNFFHHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x536C1E0", Offset = "0x536B1E0", VA = "0x18536C1E0")]
	public void MHCPGDEAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public IBFGJDIIELC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class LLBPHHLDHFL
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct CBPOAGELIAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public IBFGJDIIELC OPPDILMLGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public JOLKFPIPKMP LCLLNIAPACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AJFAIIFPLLE IFPFFGFEPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public IEnumerator<KDCGDINMKGL> HIMLCCEKLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public KDCGDINMKGL POLEOJGIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NMLGOMHGOLG HHLAKMBGBEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CKNOEEJIOAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NNIHDAPLEEB.GCDGFJIIHGI GCKMCCLNHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<CBPOAGELIAE> JKJKPGKFMMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FOKMABCNAMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public LLBPHHLDHFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public JOLKFPIPKMP context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public IBFGJDIIELC routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public NMLGOMHGOLG coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public AJFAIIFPLLE promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public KDCGDINMKGL currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public IEnumerator<KDCGDINMKGL> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FOKMABCNAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x536A1C0", Offset = "0x53691C0", VA = "0x18536A1C0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class JKFKFHNHHMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IBFGJDIIELC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public LLBPHHLDHFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JKFKFHNHHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x536F070", Offset = "0x536E070", VA = "0x18536F070")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class AHPDFJGOLDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IBFGJDIIELC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public LLBPHHLDHFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public AHPDFJGOLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5364760", Offset = "0x5363760", VA = "0x185364760")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class OHNBOMIFJDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public IBFGJDIIELC schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public LLBPHHLDHFL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OHNBOMIFJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x53789B0", Offset = "0x53779B0", VA = "0x1853789B0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const NMLGOMHGOLG PGIBNFFEFFJ = NMLGOMHGOLG.Cancelled | NMLGOMHGOLG.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool[] OPJDIFKAFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<NMLGOMHGOLG> KIJNJNHJFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float> DLMKIKGPCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<int> BFFDLBFCCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> MIDAJLKEONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> IDLMDLPFJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> BDNHFJABFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<int> NBGAOHHBPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private IBFGJDIIELC[] DBGFAMLGPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private AJFAIIFPLLE[] DBBGKLNPKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private JOLKFPIPKMP[] GAJNPHHACIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private IEnumerator<KDCGDINMKGL>[] DGCBMDADCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private KDCGDINMKGL[] EOKHMKBHLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int EOJNDLHKFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int JAFEKEGLGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly int EJADEEOGECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float FPMEEGCNOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private ICOCBIGONGG HANMDEDLEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JobHandle KLPCLLEHOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private List<IBFGJDIIELC> NFKMMMBFNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private bool PJLBGNBLDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private List<Action> MLEKGBAACLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private List<Action> DCCBEAKAGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool HDLMODLAKKJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public CKNOEEJIOAD[] ALEOBCPJFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xFCAA70", Offset = "0xFC9A70", VA = "0x180FCAA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5371D00", Offset = "0x5370D00", VA = "0x185371D00")]
	private static int IEDOPDOLLOB(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5372EF0", Offset = "0x5371EF0", VA = "0x185372EF0")]
	public LLBPHHLDHFL(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5371860", Offset = "0x5370860", VA = "0x185371860")]
	private void HEDIKDPNKKM(ref int HDEFGMMJNCC, int NGAAMGJNOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x53715B0", Offset = "0x53705B0", VA = "0x1853715B0")]
	public void GEFFMBCBFLC(JOLKFPIPKMP IGBOEABBEHO, KDCGDINMKGL NOPNNKLDKNM, IEnumerator<KDCGDINMKGL> OFCPKPFIMAH, AJFAIIFPLLE FBOICHJLBEO, [Optional] IBFGJDIIELC LIMKFMLBCAL, NMLGOMHGOLG ICIICMGBAFN = NMLGOMHGOLG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5371340", Offset = "0x5370340", VA = "0x185371340")]
	public void DIMDCAEDBIF(IEnumerable<CBPOAGELIAE> AEDEDDFJDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5370E30", Offset = "0x536FE30", VA = "0x185370E30")]
	private CBPOAGELIAE CMGLOAJIOHM(int PNFOGIEEBGF)
	{
		return default(CBPOAGELIAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5372580", Offset = "0x5371580", VA = "0x185372580")]
	private void OGJLCJFPDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x27EFBF0", Offset = "0x27EEBF0", VA = "0x1827EFBF0")]
	private static void GJDFDPAFAIF<T>(int PNFOGIEEBGF, T[] KBCGBFCFAKG, int FBPAKFCOLHM, [Optional] T MCIFPMMNEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x27EFBD0", Offset = "0x27EEBD0", VA = "0x1827EFBD0")]
	private static void GJDFDPAFAIF<T>(int PNFOGIEEBGF, NativeArray<T> KBCGBFCFAKG, int FBPAKFCOLHM, [Optional] T MCIFPMMNEBK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5371A50", Offset = "0x5370A50", VA = "0x185371A50")]
	private void HHCKJMAGPIC(IEnumerable<CBPOAGELIAE> AEDEDDFJDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x53722D0", Offset = "0x53712D0", VA = "0x1853722D0")]
	private void MLKFNKPAIDL(CBPOAGELIAE EEBJHPIKFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5371DB0", Offset = "0x5370DB0", VA = "0x185371DB0")]
	private PCLHMNMAAFJ JPEDLEDIALL(int JEFCPANLGCD)
	{
		return default(PCLHMNMAAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x53723A0", Offset = "0x53713A0", VA = "0x1853723A0")]
	public void NDCCMOJJKLB(float LAPDMGFFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5371D30", Offset = "0x5370D30", VA = "0x185371D30")]
	private void IJKEDOCCLCF(Action DOGOAAONBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5371530", Offset = "0x5370530", VA = "0x185371530")]
	private void EPOKNJECHLG(Action DOGOAAONBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5372A20", Offset = "0x5371A20", VA = "0x185372A20")]
	public void PLAPJNJMLDC(float LAPDMGFFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5372920", Offset = "0x5371920", VA = "0x185372920")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5372070", Offset = "0x5371070", VA = "0x185372070")]
	public void MHCPGDEAOOD(IBFGJDIIELC ILALCOOOPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5371730", Offset = "0x5370730", VA = "0x185371730")]
	public void GIIJFBPLAMN(IBFGJDIIELC ILALCOOOPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x53721A0", Offset = "0x53711A0", VA = "0x1853721A0")]
	public void MKOCEGEGGPD(IBFGJDIIELC ILALCOOOPOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class OIPIEPAHOLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static readonly OIPIEPAHOLN GFAFPPNCEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Action KLJHLBEGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool GPOGJJAECEL;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	public OIPIEPAHOLN(Action KLJHLBEGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x53789F0", Offset = "0x53779F0", VA = "0x1853789F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface HMDNKAGKGKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HDPDELIAHDJ(UnityEngine.Object IGBOEABBEHO, Action<T> GFLNOENPBOO);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface LIPCIPDNNPK<T> : global::HMDNKAGKGKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FPHOMACONCB<T> : global::LIPCIPDNNPK<T>, global::HMDNKAGKGKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class HAALGLGNMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public global::FPHOMACONCB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public global::PCDEGCOHKDJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public HAALGLGNMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x267A730", Offset = "0x2679730", VA = "0x18267A730")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static GameObject PEIHEGODJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly List<global::PCDEGCOHKDJ<UnityEngine.Object, Action<T>>> BKDNLLJDOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private T EDJCDEBNKFA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6648D0", Offset = "0x6638D0", VA = "0x1806648D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD830", Offset = "0x2ADC830", VA = "0x182ADD830", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD090", Offset = "0x2ADC090", VA = "0x182ADD090")]
	private static bool JJAPLADLOJP(T DOGOAAONBOH, T ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD890", Offset = "0x2ADC890", VA = "0x182ADD890")]
	public FPHOMACONCB(T MCHHPJOIEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCD80", Offset = "0x2ADBD80", VA = "0x182ADCD80", Slot = "6")]
	public IDisposable HDPDELIAHDJ(UnityEngine.Object IGBOEABBEHO, Action<T> GFLNOENPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD450", Offset = "0x2ADC450", VA = "0x182ADD450")]
	private void PHLAJGILMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class GLIJONKMJAJ : BPOFINAELIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly NAPIAOEEGEB OMHHFFBPJCJ;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x536AF90", Offset = "0x5369F90", VA = "0x18536AF90")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void HKHPIAEGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	[Preserve]
	internal GLIJONKMJAJ([NBLPGINBDGI(null)] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x536AEF0", Offset = "0x5369EF0", VA = "0x18536AEF0", Slot = "4")]
	public IDisposable FHDBCIMFPMO(float IHDKALKKCII, Action<float> FNAODFKKBJA, bool LJHEPNFCINA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[BurstCompile]
internal struct ICOCBIGONGG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[ReadOnly]
	public float OHMFFEMKPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[ReadOnly]
	public int ANFFJILENHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeArray<int> MJGONNNFINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private NativeArray<int> AHMCJIFCBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private NativeArray<int> LKFPFDBPEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[ReadOnly]
	public NativeArray<NMLGOMHGOLG> GDOEOOEDCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[ReadOnly]
	public NativeArray<float> OHKLJHCCLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[WriteOnly]
	public NativeArray<int> IDLMDLPFJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[WriteOnly]
	public NativeArray<int> BFFDLBFCCEP;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x536CA50", Offset = "0x536BA50", VA = "0x18536CA50")]
	public static ICOCBIGONGG MFNJFAEBAIM(int IKGLDDPADIP, float LAPDMGFFHLM, NativeArray<NMLGOMHGOLG> PIOKNCCJKDH, NativeArray<float> BKNJOJPOGCL, NativeArray<int> JDGMJLHEPMA, NativeArray<int> IGOMGICKBLO, NativeArray<int> LIHGFFNABEP, NativeArray<int> AHMCJIFCBMP, NativeArray<int> LKFPFDBPEMJ)
	{
		return default(ICOCBIGONGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x536C8A0", Offset = "0x536B8A0", VA = "0x18536C8A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x536CAB0", Offset = "0x536BAB0", VA = "0x18536CAB0")]
	private bool OENHHFILDIP(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x536C870", Offset = "0x536B870", VA = "0x18536C870")]
	private void ECAHBOEGDHJ(NativeArray<int> JGHOKMJBABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x536C810", Offset = "0x536B810", VA = "0x18536C810")]
	private int EAMIGCEAMLH(int JAJNFINBENE, int DLGGLLHKEPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x536C980", Offset = "0x536B980", VA = "0x18536C980")]
	private void HNPJHNMHOIE(NativeArray<int> JGHOKMJBABG, int LENMDADPBGE, int JNHJMFBGOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x536C5E0", Offset = "0x536B5E0", VA = "0x18536C5E0")]
	private void BBPMBOIBOGO(NativeArray<int> JGHOKMJBABG, int DOECKKMPPFF, int IFCAHNPAENO, int CLNPEOPNDLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AEHIILBFNOO : MKGOJFLMADG, NAPIAOEEGEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private LLBPHHLDHFL[] IJIMHBIIFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private OAGAAMCHMGI KAHKPFHIKDD;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5363FC0", Offset = "0x5362FC0", VA = "0x185363FC0")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void HKHPIAEGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5364560", Offset = "0x5363560", VA = "0x185364560")]
	[Preserve]
	public AEHIILBFNOO([NBLPGINBDGI(null)] ANAPHBJACBA PANKOECPCED, [NBLPGINBDGI(null)] MFAOHGDBKLP MJNCFJMFBMA, [NBLPGINBDGI(null)] PCIJIHBMIBP EKAENLMBGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5363B80", Offset = "0x5362B80", VA = "0x185363B80", Slot = "12")]
	public override PKIGMKLPPJG EFACGIHFBCE(JOLKFPIPKMP IGBOEABBEHO, IEnumerator<KDCGDINMKGL> BKBMBOCOKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5364280", Offset = "0x5363280", VA = "0x185364280", Slot = "13")]
	public override void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5363DE0", Offset = "0x5362DE0", VA = "0x185363DE0", Slot = "15")]
	public override void GMDJIFFDCIE(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5363D00", Offset = "0x5362D00", VA = "0x185363D00", Slot = "14")]
	protected override void FMPDGFOLIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5363CC0", Offset = "0x5362CC0", VA = "0x185363CC0")]
	private LLBPHHLDHFL FDBDOJADFEI(NNIHDAPLEEB.GCDGFJIIHGI BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5364030", Offset = "0x5363030", VA = "0x185364030", Slot = "16")]
	internal override BGLGLBJGDHB NIHMKOHALKD(IEnumerator<KDCGDINMKGL> BKBMBOCOKKP, Behaviour IGBOEABBEHO, AJFAIIFPLLE FBOICHJLBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5364210", Offset = "0x5363210", VA = "0x185364210", Slot = "17")]
	internal override NLAECECLOFD PFJKHMILOFO(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x53640E0", Offset = "0x53630E0", VA = "0x1853640E0")]
	private void NJEJDGJGKID(LLBPHHLDHFL LAFALEHGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5363B10", Offset = "0x5362B10", VA = "0x185363B10", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class MKGOJFLMADG : NAPIAOEEGEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly ANAPHBJACBA PANKOECPCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected readonly MFAOHGDBKLP MJNCFJMFBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly PCIJIHBMIBP EKAENLMBGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NLAECECLOFD[] DJGFMPMEDAB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static NAPIAOEEGEB KGCADEGMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5375F40", Offset = "0x5374F40", VA = "0x185375F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool ELDHHCEEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NNIHDAPLEEB.GCDGFJIIHGI LDLGMNAPEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NNIHDAPLEEB.GCDGFJIIHGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x66AF30", Offset = "0x669F30", VA = "0x18066AF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MFAOHGDBKLP CGDCGKHEHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5375390", Offset = "0x5374390", VA = "0x185375390")]
	public static PKIGMKLPPJG CEJAPPIKKIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5376170", Offset = "0x5375170", VA = "0x185376170")]
	[Preserve]
	protected MKGOJFLMADG([NBLPGINBDGI(null)] ANAPHBJACBA PANKOECPCED, [NBLPGINBDGI(null)] MFAOHGDBKLP MJNCFJMFBMA, [NBLPGINBDGI(null)] PCIJIHBMIBP EKAENLMBGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5375660", Offset = "0x5374660", VA = "0x185375660", Slot = "6")]
	public PKIGMKLPPJG CHCDHEIAFLI(IEnumerator<KDCGDINMKGL> BKBMBOCOKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5375430", Offset = "0x5374430", VA = "0x185375430", Slot = "7")]
	public PKIGMKLPPJG CHCDHEIAFLI(Behaviour IGBOEABBEHO, IEnumerator<KDCGDINMKGL> BKBMBOCOKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract PKIGMKLPPJG EFACGIHFBCE(JOLKFPIPKMP IGBOEABBEHO, IEnumerator<KDCGDINMKGL> BKBMBOCOKKP);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5375F90", Offset = "0x5374F90", VA = "0x185375F90", Slot = "13")]
	public virtual void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x53759F0", Offset = "0x53749F0", VA = "0x1853759F0", Slot = "9")]
	public void EEBGDOAMHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5375A50", Offset = "0x5374A50", VA = "0x185375A50", Slot = "14")]
	protected virtual void FMPDGFOLIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5375CD0", Offset = "0x5374CD0", VA = "0x185375CD0")]
	private void HDGOPGEIKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5375A70", Offset = "0x5374A70", VA = "0x185375A70")]
	private void GJLNFNEALIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5375CF0", Offset = "0x5374CF0", VA = "0x185375CF0")]
	private void JDHHMNHLCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5375370", Offset = "0x5374370", VA = "0x185375370")]
	private void BEBFDDBPGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5375D10", Offset = "0x5374D10", VA = "0x185375D10")]
	private void JMNDLCKMAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5375F20", Offset = "0x5374F20", VA = "0x185375F20")]
	private void NKIKPIPNDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5375F00", Offset = "0x5374F00", VA = "0x185375F00")]
	private void NAEPDMHOGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5375A90", Offset = "0x5374A90", VA = "0x185375A90", Slot = "15")]
	public virtual void GMDJIFFDCIE(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5375D30", Offset = "0x5374D30", VA = "0x185375D30")]
	private void MEPCJFCDOGE(NLAECECLOFD LAFALEHGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xC304A0", Offset = "0xC2F4A0", VA = "0x180C304A0")]
	private NLAECECLOFD AEKABKHEMFN(NNIHDAPLEEB.GCDGFJIIHGI BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract BGLGLBJGDHB NIHMKOHALKD(IEnumerator<KDCGDINMKGL> BKBMBOCOKKP, Behaviour FDEBBPLENLF, AJFAIIFPLLE FFICODJGIOM);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract NLAECECLOFD PFJKHMILOFO(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5375670", Offset = "0x5374670", VA = "0x185375670", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class BGLGLBJGDHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly AJFAIIFPLLE FBOICHJLBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly MNAIEHBAGCI IGBOEABBEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly bool PLJGKMIBFMB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<KDCGDINMKGL> HIMLCCEKLII
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KDCGDINMKGL POLEOJGIENF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OLGBKGHHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5364AB0", Offset = "0x5363AB0", VA = "0x185364AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BMALHDHFCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x860D50", Offset = "0x85FD50", VA = "0x180860D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x800200", Offset = "0x7FF200", VA = "0x180800200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float PKANHNFIBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1114B10", Offset = "0x1113B10", VA = "0x181114B10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1114F00", Offset = "0x1113F00", VA = "0x181114F00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5364FA0", Offset = "0x5363FA0", VA = "0x185364FA0")]
	public BGLGLBJGDHB(IEnumerator<KDCGDINMKGL> OFCPKPFIMAH, MNAIEHBAGCI IGBOEABBEHO, AJFAIIFPLLE FBOICHJLBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5364BA0", Offset = "0x5363BA0", VA = "0x185364BA0")]
	public KDCGDINMKGL LJIHJCBHCBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5364B30", Offset = "0x5363B30", VA = "0x185364B30")]
	public bool LHFIDINMGFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5364E60", Offset = "0x5363E60", VA = "0x185364E60")]
	public void MHCPGDEAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5364EE0", Offset = "0x5363EE0", VA = "0x185364EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A9FE10", Offset = "0x1A9EE10", VA = "0x181A9FE10")]
	[CompilerGenerated]
	private void CFICCIJAHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class AJFAIIFPLLE : BADFACFJIGL, PKIGMKLPPJG, ECABBBEOAAH, MLEPGEJLFCO, IEnumerator, KDCGDINMKGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NNIHDAPLEEB.GCDGFJIIHGI FNOGPNDJPBM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private NNIHDAPLEEB.GCDGFJIIHGI KEPCFLLEGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE510", Offset = "0x6ED510", VA = "0x1806EE510", Slot = "23")]
		get
		{
			return default(NNIHDAPLEEB.GCDGFJIIHGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NNIHDAPLEEB.GCDGFJIIHGI NPDBPJKOACA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x80A620", Offset = "0x809620", VA = "0x18080A620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float EFLACMGGLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xFD6970", Offset = "0xFD5970", VA = "0x180FD6970", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x53647B0", Offset = "0x53637B0", VA = "0x1853647B0", Slot = "24")]
	private bool JMEKHKPBKPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x53647A0", Offset = "0x53637A0", VA = "0x1853647A0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x53647D0", Offset = "0x53637D0", VA = "0x1853647D0")]
	public AJFAIIFPLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal enum PCLHMNMAAFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class NLAECECLOFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum CEADBMKCNIA
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct HOGPOHOFNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public NNIHDAPLEEB.GCDGFJIIHGI GCKMCCLNHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CEADBMKCNIA OHABKKKJOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<BGLGLBJGDHB> HFCBIBJNCOF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly CEADBMKCNIA[] PLDKFCOGCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool KICEHDBKIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly BGLGLBJGDHB[] LJKCKHCNCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<BGLGLBJGDHB> KNMJANBJOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Stack<int> OBEJGPPLANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<BGLGLBJGDHB> LMKOLPHDBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stack<int> JPDABAEIHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly OAGAAMCHMGI AOHDHEKJADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool HDLMODLAKKJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HOGPOHOFNKO[,] MCJPHGLDAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x64A0D0", Offset = "0x6490D0", VA = "0x18064A0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5377D80", Offset = "0x5376D80", VA = "0x185377D80")]
	public NLAECECLOFD(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, OAGAAMCHMGI AOHDHEKJADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5377790", Offset = "0x5376790", VA = "0x185377790")]
	public void IHDFDIHLDMI(BGLGLBJGDHB OFCPKPFIMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5376B40", Offset = "0x5375B40", VA = "0x185376B40")]
	public void DPLHFBDGHDE(IList<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x53774C0", Offset = "0x53764C0", VA = "0x1853774C0")]
	public void IHCEBFKJOEF(IList<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5377B70", Offset = "0x5376B70", VA = "0x185377B70")]
	private void PDJABOMAFAD(BGLGLBJGDHB OFCPKPFIMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x53769C0", Offset = "0x53759C0", VA = "0x1853769C0")]
	private void BDINNEBFJPO(IList<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x53779D0", Offset = "0x53769D0", VA = "0x1853779D0")]
	private PCLHMNMAAFJ NGMILNJLAPD(BGLGLBJGDHB OFCPKPFIMAH)
	{
		return default(PCLHMNMAAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5377380", Offset = "0x5376380", VA = "0x185377380")]
	public void FMPDGFOLIAO(float LAPDMGFFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5376F50", Offset = "0x5375F50", VA = "0x185376F50")]
	public void EEBGDOAMHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5377160", Offset = "0x5376160", VA = "0x185377160")]
	private void FFLICBDCOEC(List<BGLGLBJGDHB> HJCJJJLPFHG, Stack<int> EDKOBFEIEBL, bool ILGAHJHKKLP, float CKOLPFIDJGF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5376E10", Offset = "0x5375E10", VA = "0x185376E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x53778B0", Offset = "0x53768B0", VA = "0x1853778B0")]
	private void JCFCMJFBPHD(List<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class CNDKLLLAIBI : OAGAAMCHMGI
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
	public void MNOCOEBBDFD(string FOGNBJMCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
	public void CLLMEIOBABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CNDKLLLAIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class DDEFLJPACGO : MNAIEHBAGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Behaviour FDEBBPLENLF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5369240", Offset = "0x5368240", VA = "0x185369240", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MCIDMJPMKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x53691E0", Offset = "0x53681E0", VA = "0x1853691E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OFOMNFICCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x53692D0", Offset = "0x53682D0", VA = "0x1853692D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	public DDEFLJPACGO(Behaviour FDEBBPLENLF)
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

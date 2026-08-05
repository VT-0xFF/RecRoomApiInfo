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
	[Cpp2IlInjected.Address(RVA = "0x5583C30", Offset = "0x5582430", VA = "0x185583C30")]
	public OAPAPFDLLPC(ThreadPriority MEGPKMNCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5583C20", Offset = "0x5582420", VA = "0x185583C20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5584EB0", Offset = "0x55836B0", VA = "0x185584EB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5583960", Offset = "0x5582160", VA = "0x185583960")]
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
				[Cpp2IlInjected.Address(RVA = "0x5584320", Offset = "0x5582B20", VA = "0x185584320")]
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
				[Cpp2IlInjected.Address(RVA = "0x5581E40", Offset = "0x5580640", VA = "0x185581E40")]
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
				[Cpp2IlInjected.Address(RVA = "0x5584800", Offset = "0x5583000", VA = "0x185584800")]
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
				[Cpp2IlInjected.Address(RVA = "0x5584C20", Offset = "0x5583420", VA = "0x185584C20")]
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
				[Cpp2IlInjected.Address(RVA = "0x5581C30", Offset = "0x5580430", VA = "0x185581C30")]
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
				[Cpp2IlInjected.Address(RVA = "0x55753B0", Offset = "0x5573BB0", VA = "0x1855753B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x55751D0", Offset = "0x55739D0", VA = "0x1855751D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5576CE0", Offset = "0x55754E0", VA = "0x185576CE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x557C230", Offset = "0x557AA30", VA = "0x18557C230")]
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
					[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
					public PGMOEJFDNAC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x55849E0", Offset = "0x55831E0", VA = "0x1855849E0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable CIFDLDDDHMH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5578A90", Offset = "0x5577290", VA = "0x185578A90")]
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
					[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
					public NLCFCCAOLOP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x5583B40", Offset = "0x5582340", VA = "0x185583B40")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x556FD40", Offset = "0x556E540", VA = "0x18556FD40")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public HNFDEHGHBOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5577690", Offset = "0x5575E90", VA = "0x185577690")]
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
			[Cpp2IlInjected.Address(RVA = "0x55716F0", Offset = "0x556FEF0", VA = "0x1855716F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5571860", Offset = "0x5570060", VA = "0x185571860")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5572A50", Offset = "0x5571250", VA = "0x185572A50")]
		private static void PLDOBCMDIDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55718A0", Offset = "0x55700A0", VA = "0x1855718A0")]
		private static void HDJHAKLLMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5572560", Offset = "0x5570D60", VA = "0x185572560")]
		private static void NBBCBMKDFGI(string CGBFALCJHOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x55714C0", Offset = "0x556FCC0", VA = "0x1855714C0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5572890", Offset = "0x5571090", VA = "0x185572890")]
		private static void ODKEAKGHGGG(KBIOHFMCCOL.NHPFLHKIPJN AGPLDPOAAIC, ref PlayerLoopSystem MADOOMAHBED, Type EAAPFBKBLGA, Type MOHBNJJKJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5572170", Offset = "0x5570970", VA = "0x185572170")]
		private static void JLIJEHBECAI(ref PlayerLoopSystem MADOOMAHBED, Type EAAPFBKBLGA, Type MOHBNJJKJGG, MHHCHNBJEAP EMDCEMGEMIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5571730", Offset = "0x556FF30", VA = "0x185571730")]
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
		[Cpp2IlInjected.Address(RVA = "0x55769E0", Offset = "0x55751E0", VA = "0x1855769E0")]
		public GNILMGEKHKO(NHPFLHKIPJN HBDFMOICEGC, int IMEFBPFHEBB = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5576710", Offset = "0x5574F10", VA = "0x185576710")]
		public void ANDAPDOHCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5576980", Offset = "0x5575180", VA = "0x185576980")]
		public void PPGMDNFAMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5576780", Offset = "0x5574F80", VA = "0x185576780")]
		public void FFEDMJPMKNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static NHPFLHKIPJN[] ICDCNAPADLH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static GNILMGEKHKO[] MIOANOEIKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x557ABA0", Offset = "0x55793A0", VA = "0x18557ABA0")]
	public static GNILMGEKHKO KHINJGHBJEP(NHPFLHKIPJN AGPLDPOAAIC, int IMEFBPFHEBB = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x557AD70", Offset = "0x5579570", VA = "0x18557AD70")]
	public static GNILMGEKHKO MAGBHGDLIBF(NHPFLHKIPJN AGPLDPOAAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x557AE00", Offset = "0x5579600", VA = "0x18557AE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x5575720", Offset = "0x5573F20", VA = "0x185575720", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x55757F0", Offset = "0x5573FF0", VA = "0x1855757F0")]
	public FCNKEDKJDMK(int LFLFBLKGDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55755F0", Offset = "0x5573DF0", VA = "0x1855755F0", Slot = "4")]
	public void LKKAOHKNABB(double OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5575780", Offset = "0x5573F80", VA = "0x185575780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double ENDFKHFGKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACEDC0", VA = "0x180AD05C0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double BLGHHHHNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAD0640", Offset = "0xACEE40", VA = "0x180AD0640", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EFNFCHNIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8CD070", Offset = "0x8CB870", VA = "0x1808CD070")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MEOOCGGNBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1E0", Offset = "0xA6C9E0", VA = "0x180A6E1E0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5576460", Offset = "0x5574C60", VA = "0x185576460", Slot = "7")]
	public void LKKAOHKNABB(double OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5576590", Offset = "0x5574D90", VA = "0x185576590", Slot = "8")]
	public void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55765D0", Offset = "0x5574DD0", VA = "0x1855765D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32AFBD0", Offset = "0x32AE3D0", VA = "0x1832AFBD0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OKLPCPLDDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x32AFB20", Offset = "0x32AE320", VA = "0x1832AFB20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2FC9600", Offset = "0x2FC7E00", VA = "0x182FC9600")]
		protected JFNAACBNBFF(TPromise HOJKBLAJFAL, TMainThreadPromise IADKMJNJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x32AFC30", Offset = "0x32AE430", VA = "0x1832AFC30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x38F7C80", Offset = "0x38F6480", VA = "0x1838F7C80")]
		public LBODKFNIGFN(global::AGDEEHNAPKP<T> HOJKBLAJFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x38F7AF0", Offset = "0x38F62F0", VA = "0x1838F7AF0", Slot = "6")]
		protected override void IMAGBLCMBAB(global::AGDEEHNAPKP<T> HOJKBLAJFAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x38F7C50", Offset = "0x38F6450", VA = "0x1838F7C50")]
		[CompilerGenerated]
		private void PNLJODBMAAP(T BBELMPNHPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2FD6750", Offset = "0x2FD4F50", VA = "0x182FD6750")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
		public MDOOLMLHOHE(Action NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CBF0", Offset = "0x1E1B3F0", VA = "0x181E1CBF0", Slot = "5")]
		public void ECFFKMLILHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly List<MDIAIPFDAMK> FIOKNDBAHPE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36A6840", Offset = "0x36A5040", VA = "0x1836A6840")]
	public static global::AGDEEHNAPKP<T> EHMOHHCBFHA<T>(this global::AGDEEHNAPKP<T> HOJKBLAJFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5574DF0", Offset = "0x55735F0", VA = "0x185574DF0")]
	public static void EHMOHHCBFHA(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x36A68B0", Offset = "0x36A50B0", VA = "0x1836A68B0")]
	private static global::AGDEEHNAPKP<T> GIPOKKOOPIG<T>(global::AGDEEHNAPKP<T> HOJKBLAJFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5574E80", Offset = "0x5573680", VA = "0x185574E80")]
	private static void IDMMDLLFBHG(MDIAIPFDAMK EFPCPGJIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5574A00", Offset = "0x5573200", VA = "0x185574A00")]
	private static void BBCJGGNFOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5574CF0", Offset = "0x55734F0", VA = "0x185574CF0")]
	private static void BHCJIKKFOKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5575080", Offset = "0x5573880", VA = "0x185575080")]
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
		[Cpp2IlInjected.Address(RVA = "0x5575590", Offset = "0x5573D90", VA = "0x185575590")]
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
		[Cpp2IlInjected.Address(RVA = "0x557F320", Offset = "0x557DB20", VA = "0x18557F320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x557F990", Offset = "0x557E190", VA = "0x18557F990", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5584500", Offset = "0x5582D00", VA = "0x185584500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA0", Offset = "0x85E5A0", VA = "0x18085FDA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5576EC0", Offset = "0x55756C0", VA = "0x185576EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA0", Offset = "0x85E5A0", VA = "0x18085FDA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public OBMEIMKPDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5583C70", Offset = "0x5582470", VA = "0x185583C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x557B860", Offset = "0x557A060", VA = "0x18557B860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x557C1E0", Offset = "0x557A9E0", VA = "0x18557C1E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5578200", Offset = "0x5576A00", VA = "0x185578200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5578A40", Offset = "0x5577240", VA = "0x185578A40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public NIAPBEKEDHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5581E10", Offset = "0x5580610", VA = "0x185581E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public HKIMMJOAHBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x55775B0", Offset = "0x5575DB0", VA = "0x1855775B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5577250", Offset = "0x5575A50", VA = "0x185577250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5577640", Offset = "0x5575E40", VA = "0x185577640")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5577570", Offset = "0x5575D70", VA = "0x185577570", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public KCMIABGKLLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x557B2E0", Offset = "0x5579AE0", VA = "0x18557B2E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x557B730", Offset = "0x5579F30", VA = "0x18557B730", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5578BC0", Offset = "0x55773C0", VA = "0x185578BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool FLKEPABFOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5579A00", Offset = "0x5578200", VA = "0x185579A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool DJHOFECBOCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5579730", Offset = "0x5577F30", VA = "0x185579730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> MONDFNKBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5579AB0", Offset = "0x55782B0", VA = "0x185579AB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5579240", Offset = "0x5577A40", VA = "0x185579240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55797F0", Offset = "0x5577FF0", VA = "0x1855797F0")]
	[DDDKNIGBKHH(ODNNAFCJNAG.EnteredEditModeNextFrame, 0)]
	private static void JLCEMALGGCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55790E0", Offset = "0x55778E0", VA = "0x1855790E0")]
	[AsyncStateMachine(typeof(LOOBIFHOMFO))]
	public static Task<Scene> FCOJHHBKJFF(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP = LoadSceneMode.Single, bool FHJKEIFCOLE = false, [Optional] HKLBBGEFPMO FDGKFPMCJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5579430", Offset = "0x5577C30", VA = "0x185579430")]
	[AsyncStateMachine(typeof(PALNPFLHLFE))]
	private static Task HPKAMMGGJHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5579340", Offset = "0x5577B40", VA = "0x185579340")]
	[AsyncStateMachine(typeof(HGMAOKOHFIL))]
	private static Task HIGECIPLPLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5578EE0", Offset = "0x55776E0", VA = "0x185578EE0")]
	[AsyncStateMachine(typeof(LEFJICLJICH))]
	private static Task<Scene> CPPMBMCNJEO(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP, bool FHJKEIFCOLE, HKLBBGEFPMO NMGDNGMBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55798C0", Offset = "0x55780C0", VA = "0x1855798C0")]
	[AsyncStateMachine(typeof(IFCJMJIOECB))]
	private static Task<Scene> JPCAELBKOIJ(HKLBBGEFPMO NMGDNGMBHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5579500", Offset = "0x5577D00", VA = "0x185579500")]
	public static global::AGDEEHNAPKP<Scene> IIOMDBDMDDP(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5579BB0", Offset = "0x55783B0", VA = "0x185579BB0")]
	public static MLEPGEJLFCO MIMIOHOHNMA(string COMINAANPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55796A0", Offset = "0x5577EA0", VA = "0x1855796A0")]
	[IteratorStateMachine(typeof(HKIMMJOAHBF))]
	private static IEnumerator<KDCGDINMKGL> ILHKCBPLEOE(string COMINAANPMI, AMPMBAOHAPE NOJJDNNPGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5579040", Offset = "0x5577840", VA = "0x185579040")]
	[IteratorStateMachine(typeof(KCMIABGKLLL))]
	private static IEnumerator<KDCGDINMKGL> DBCJECHIFLH(string COMINAANPMI, LoadSceneMode OOGMHCDEAMP, global::MJBDKPPKHFK<Scene> NOJJDNNPGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5578D80", Offset = "0x5577580", VA = "0x185578D80")]
	public static bool CJCNBLCBEDE(out string DKGKFLHBAFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class AOGAMBNFHPG
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x556FFC0", Offset = "0x556E7C0", VA = "0x18556FFC0")]
	public static IDisposable NFEEKNJJKEH(this JOLKFPIPKMP IGBOEABBEHO, float IHDKALKKCII, Action<float> MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5570040", Offset = "0x556E840", VA = "0x185570040")]
	public static IDisposable OMECKHIPEOO(this JOLKFPIPKMP IGBOEABBEHO, Action<float> MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x556FF40", Offset = "0x556E740", VA = "0x18556FF40")]
	public static IDisposable JPFHEENFPMC(this JOLKFPIPKMP IGBOEABBEHO, Action<float> MMDMJIGCAOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class CLFFMNFABEL
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5571160", Offset = "0x556F960", VA = "0x185571160")]
	public static IDisposable MINDHKMGPKJ(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x55711E0", Offset = "0x556F9E0", VA = "0x1855711E0")]
	public static IDisposable MINDHKMGPKJ(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5570E30", Offset = "0x556F630", VA = "0x185570E30")]
	public static IDisposable FMPDGFOLIAO(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5570FC0", Offset = "0x556F7C0", VA = "0x185570FC0")]
	public static IDisposable JDHHMNHLCML(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5570B70", Offset = "0x556F370", VA = "0x185570B70")]
	public static IDisposable BEBFDDBPGKF(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5570C80", Offset = "0x556F480", VA = "0x185570C80")]
	public static IDisposable DEACOEAMCDC(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5570AF0", Offset = "0x556F2F0", VA = "0x185570AF0")]
	public static IDisposable AMFOIDAJGNL(this MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x55712F0", Offset = "0x556FAF0", VA = "0x1855712F0")]
	public static IDisposable NOOGNICHFAF(this MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5570D90", Offset = "0x556F590", VA = "0x185570D90")]
	public static IDisposable FHDBCIMFPMO(this MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5570F30", Offset = "0x556F730", VA = "0x185570F30")]
	public static IDisposable GFKGJCGMJMH(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55710D0", Offset = "0x556F8D0", VA = "0x1855710D0")]
	public static IDisposable LJCBJOCKIFH(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5570BF0", Offset = "0x556F3F0", VA = "0x185570BF0")]
	public static IDisposable DBFKFBLJIPN(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5571260", Offset = "0x556FA60", VA = "0x185571260")]
	public static IDisposable NOGEAANFMON(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5571390", Offset = "0x556FB90", VA = "0x185571390")]
	public static IDisposable OLIPJOFHBJO(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5571040", Offset = "0x556F840", VA = "0x185571040")]
	public static IDisposable LHCHPLEAHBJ(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5570EA0", Offset = "0x556F6A0", VA = "0x185570EA0")]
	public static IDisposable GCNADGIKANN(this MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5571420", Offset = "0x556FC20", VA = "0x185571420")]
	public static IDisposable PFFKFEDKNDA(this MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, bool LJHEPNFCINA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5570D00", Offset = "0x556F500", VA = "0x185570D00")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public BENJAMMNOJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x55700C0", Offset = "0x556E8C0", VA = "0x1855700C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5570180", Offset = "0x556E980", VA = "0x185570180", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public LJJAOIEFEFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x557C410", Offset = "0x557AC10", VA = "0x18557C410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x557C500", Offset = "0x557AD00", VA = "0x18557C500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5583FA0", Offset = "0x55827A0", VA = "0x185583FA0")]
	public static PKIGMKLPPJG MINDHKMGPKJ(Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5583EE0", Offset = "0x55826E0", VA = "0x185583EE0")]
	public static PKIGMKLPPJG MINDHKMGPKJ(Behaviour IGBOEABBEHO, Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5583DD0", Offset = "0x55825D0", VA = "0x185583DD0")]
	public static PKIGMKLPPJG MINDHKMGPKJ(Behaviour IGBOEABBEHO, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5583D50", Offset = "0x5582550", VA = "0x185583D50")]
	[IteratorStateMachine(typeof(BENJAMMNOJE))]
	private static IEnumerator<KDCGDINMKGL> GCMAFBHHKKB(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, Action MMDMJIGCAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5583CD0", Offset = "0x55824D0", VA = "0x185583CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public ACNPNAHLIBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x556F0A0", Offset = "0x556D8A0", VA = "0x18556F0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x556F1E0", Offset = "0x556D9E0", VA = "0x18556F1E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x557A870", Offset = "0x5579070", VA = "0x18557A870")]
	public static PKIGMKLPPJG MINDHKMGPKJ(MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x557A980", Offset = "0x5579180", VA = "0x18557A980")]
	public static PKIGMKLPPJG NKLHIDDDDDP(JOLKFPIPKMP IGBOEABBEHO, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x557A7C0", Offset = "0x5578FC0", VA = "0x18557A7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public KHCHILOLNPK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x557B770", Offset = "0x5579F70", VA = "0x18557B770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x557B820", Offset = "0x557A020", VA = "0x18557B820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5584BA0", Offset = "0x55833A0", VA = "0x185584BA0")]
	[IteratorStateMachine(typeof(KHCHILOLNPK))]
	private static IEnumerator<KDCGDINMKGL> MMOAOKKLHOC(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, Func<bool> ELGFLDEBMNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5584A90", Offset = "0x5583290", VA = "0x185584A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public PABCMDAGGKO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5584220", Offset = "0x5582A20", VA = "0x185584220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x55842E0", Offset = "0x5582AE0", VA = "0x1855842E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x557F1A0", Offset = "0x557D9A0", VA = "0x18557F1A0")]
	[IteratorStateMachine(typeof(PABCMDAGGKO))]
	private static IEnumerator<KDCGDINMKGL> MOMJBIONJNO(float MIJGLGOFPMF, NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x557F260", Offset = "0x557DA60", VA = "0x18557F260")]
	public static PKIGMKLPPJG NODLCGKBDNM(this MonoBehaviour FDEBBPLENLF, float MIJGLGOFPMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x557ED00", Offset = "0x557D500", VA = "0x18557ED00")]
	public static PKIGMKLPPJG EILKFKBJJFB(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x557F170", Offset = "0x557D970", VA = "0x18557F170")]
	public static PKIGMKLPPJG MIOPMCMIKHK(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x557EDF0", Offset = "0x557D5F0", VA = "0x18557EDF0")]
	public static PKIGMKLPPJG FOGIIEHIDAG(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x557EC00", Offset = "0x557D400", VA = "0x18557EC00")]
	public static PKIGMKLPPJG CAFBBJDLIPB(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x557F230", Offset = "0x557DA30", VA = "0x18557F230")]
	public static PKIGMKLPPJG NDNJBCMBPPH(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x557F140", Offset = "0x557D940", VA = "0x18557F140")]
	public static PKIGMKLPPJG KEEPMEOHKAD(this MonoBehaviour FDEBBPLENLF, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x557EFA0", Offset = "0x557D7A0", VA = "0x18557EFA0")]
	private static PKIGMKLPPJG JMHMIKILBGE(MonoBehaviour FDEBBPLENLF, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, Action LILPACFFGKO, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x557ED20", Offset = "0x557D520", VA = "0x18557ED20")]
	public static PKIGMKLPPJG FIGJOEMMMLM(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x557F070", Offset = "0x557D870", VA = "0x18557F070")]
	public static PKIGMKLPPJG JPKEJKJEPOG(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x557EC30", Offset = "0x557D430", VA = "0x18557EC30")]
	public static PKIGMKLPPJG DOADPJPMPPG(this MonoBehaviour FDEBBPLENLF, float MFFJNFKAHNL, Action LILPACFFGKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x557EED0", Offset = "0x557D6D0", VA = "0x18557EED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public FMPMCPODACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x55758A0", Offset = "0x55740A0", VA = "0x1855758A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public JHKBEKOFNEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x55758A0", Offset = "0x55740A0", VA = "0x1855758A0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly float DKJMEEJHAOJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55709F0", Offset = "0x556F1F0", VA = "0x1855709F0")]
	public HAADDPPBOOG(Behaviour IGBOEABBEHO, float DKJMEEJHAOJ, [Optional] Action KOOFBOFGPIE, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5576BE0", Offset = "0x55753E0", VA = "0x185576BE0", Slot = "9")]
	protected override bool LCDGBIOCBKC(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5576AE0", Offset = "0x55752E0", VA = "0x185576AE0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public KBDHNDLFFLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x557AA90", Offset = "0x5579290", VA = "0x18557AA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x557AB60", Offset = "0x5579360", VA = "0x18557AB60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C6770", Offset = "0x9C4F70", VA = "0x1809C6770", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NHOCEMBCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x556EA50", Offset = "0x556D250", VA = "0x18556EA50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x556EF00", Offset = "0x556D700", VA = "0x18556EF00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x556EFA0", Offset = "0x556D7A0", VA = "0x18556EFA0")]
	protected ABIKPOONDKN(Behaviour IGBOEABBEHO, [Optional] Action KOOFBOFGPIE, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x556ED50", Offset = "0x556D550", VA = "0x18556ED50", Slot = "7")]
	public bool HJLACBEFINM(bool MJJPNLBDKFE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x556EDB0", Offset = "0x556D5B0", VA = "0x18556EDB0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x556EAF0", Offset = "0x556D2F0", VA = "0x18556EAF0")]
	protected void CIFBBJODGAE(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x556EB10", Offset = "0x556D310", VA = "0x18556EB10")]
	protected MLEPGEJLFCO DHDIHHEMEGB(float LHKNOFOGOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x556EE00", Offset = "0x556D600", VA = "0x18556EE00")]
	private void IJCOEOHJPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x556EE80", Offset = "0x556D680", VA = "0x18556EE80")]
	[IteratorStateMachine(typeof(KBDHNDLFFLL))]
	private IEnumerator<KDCGDINMKGL> LLPAKOPJBJJ(float LHKNOFOGOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x556ED10", Offset = "0x556D510", VA = "0x18556ED10")]
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
	[Cpp2IlInjected.Address(RVA = "0x55762B0", Offset = "0x5574AB0", VA = "0x1855762B0")]
	public GAPLBLPLEBB(Behaviour IGBOEABBEHO, float FDAEGEOGFBB, int JCGIPPKFNNE, [Optional] Action KOOFBOFGPIE, float OAOPNPNBJKG = 0f, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "9")]
	protected override bool LCDGBIOCBKC(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5575FF0", Offset = "0x55747F0", VA = "0x185575FF0", Slot = "10")]
	protected override bool FJIEFNLNIOO(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5576220", Offset = "0x5574A20", VA = "0x185576220")]
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
	[Cpp2IlInjected.Address(RVA = "0x55709F0", Offset = "0x556F1F0", VA = "0x1855709F0")]
	public CIPINIOHOAP(Behaviour IGBOEABBEHO, float DKJMEEJHAOJ, [Optional] Action KOOFBOFGPIE, [Optional] NAPIAOEEGEB OMHHFFBPJCJ, [Optional] MFAOHGDBKLP MJNCFJMFBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "9")]
	protected override bool LCDGBIOCBKC(Action NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55709B0", Offset = "0x556F1B0", VA = "0x1855709B0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public LPAFLAPBDOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x557F9E0", Offset = "0x557E1E0", VA = "0x18557F9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x557FA80", Offset = "0x557E280", VA = "0x18557FA80", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x557A4E0", Offset = "0x5578CE0", VA = "0x18557A4E0")]
	public JEMALGOLFLL(JOLKFPIPKMP IGBOEABBEHO, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5579FC0", Offset = "0x55787C0", VA = "0x185579FC0")]
	private void BHKHAHKBLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x557A320", Offset = "0x5578B20", VA = "0x18557A320")]
	private void DOMGPNDICKP(string OJDKKCJFMBB, Action JHBMOCHOLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5579F50", Offset = "0x5578750", VA = "0x185579F50")]
	[IteratorStateMachine(typeof(LPAFLAPBDOM))]
	private IEnumerator<KDCGDINMKGL> BGCDMBOOKOJ(Action JHBMOCHOLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x557A480", Offset = "0x5578C80", VA = "0x18557A480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x557A170", Offset = "0x5578970", VA = "0x18557A170")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public CACGACBJEFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x55708D0", Offset = "0x556F0D0", VA = "0x1855708D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5570970", Offset = "0x556F170", VA = "0x185570970", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x55805B0", Offset = "0x557EDB0", VA = "0x1855805B0")]
	public MGDMOOKABPA(MonoBehaviour FDEBBPLENLF, Action MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55807B0", Offset = "0x557EFB0", VA = "0x1855807B0")]
	public MGDMOOKABPA(MonoBehaviour FDEBBPLENLF, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5580350", Offset = "0x557EB50", VA = "0x185580350")]
	public MGDMOOKABPA(MonoBehaviour FDEBBPLENLF, float IHDKALKKCII, Action<float> MMDMJIGCAOK, NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB, bool LJHEPNFCINA = true, [Optional] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5580030", Offset = "0x557E830", VA = "0x185580030")]
	private void MINDHKMGPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55801A0", Offset = "0x557E9A0", VA = "0x1855801A0")]
	private void MPPDBPHCADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x557FB30", Offset = "0x557E330", VA = "0x18557FB30")]
	private void BHKHAHKBLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x557FCF0", Offset = "0x557E4F0", VA = "0x18557FCF0")]
	private void DOMGPNDICKP(string OJDKKCJFMBB, Action JHBMOCHOLLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x557FAC0", Offset = "0x557E2C0", VA = "0x18557FAC0")]
	[IteratorStateMachine(typeof(CACGACBJEFI))]
	private IEnumerator<KDCGDINMKGL> BGCDMBOOKOJ(Action JHBMOCHOLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x557FE20", Offset = "0x557E620", VA = "0x18557FE20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x557FFA0", Offset = "0x557E7A0", VA = "0x18557FFA0")]
	[CompilerGenerated]
	private void JDHGFPNJIDC(string GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x557FE80", Offset = "0x557E680", VA = "0x18557FE80")]
	[CompilerGenerated]
	private void GPGLDAFCPFO(string GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x557FF10", Offset = "0x557E710", VA = "0x18557FF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x557A770", Offset = "0x5578F70", VA = "0x18557A770", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float GOFIEFCPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x557A6F0", Offset = "0x5578EF0", VA = "0x18557A6F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double LLKKFDLMBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x557A6D0", Offset = "0x5578ED0", VA = "0x18557A6D0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x557A700", Offset = "0x5578F00", VA = "0x18557A700")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void HKHPIAEGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C90", Offset = "0x6F3490", VA = "0x1806F4C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5577A60", Offset = "0x5576260", VA = "0x185577A60")]
	public static KDCGDINMKGL LJIHJCBHCBE(IEnumerator<KDCGDINMKGL> OFCPKPFIMAH, AJFAIIFPLLE FBOICHJLBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5577C10", Offset = "0x5576410", VA = "0x185577C10")]
	public KDCGDINMKGL LJIHJCBHCBE(AJFAIIFPLLE[] DBBGKLNPKJG, IEnumerator<KDCGDINMKGL>[] HJCJJJLPFHG, KDCGDINMKGL[] NGNJIBHOOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55778F0", Offset = "0x55760F0", VA = "0x1855778F0")]
	public void HLIDIAFNFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x55777B0", Offset = "0x5575FB0", VA = "0x1855777B0")]
	public void DHDACPMJKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5577920", Offset = "0x5576120", VA = "0x185577920")]
	public void JDEFNFFHHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x55778F0", Offset = "0x55760F0", VA = "0x1855778F0")]
	public void MHCPGDEAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public FOKMABCNAMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x55758D0", Offset = "0x55740D0", VA = "0x1855758D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public JKFKFHNHHMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x557A780", Offset = "0x5578F80", VA = "0x18557A780")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public AHPDFJGOLDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x556FE70", Offset = "0x556E670", VA = "0x18556FE70")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public OHNBOMIFJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x55840C0", Offset = "0x55828C0", VA = "0x1855840C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79EC30", Offset = "0x79D430", VA = "0x18079EC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x557D410", Offset = "0x557BC10", VA = "0x18557D410")]
	private static int IEDOPDOLLOB(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x557E600", Offset = "0x557CE00", VA = "0x18557E600")]
	public LLBPHHLDHFL(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x557CF70", Offset = "0x557B770", VA = "0x18557CF70")]
	private void HEDIKDPNKKM(ref int HDEFGMMJNCC, int NGAAMGJNOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x557CCC0", Offset = "0x557B4C0", VA = "0x18557CCC0")]
	public void GEFFMBCBFLC(JOLKFPIPKMP IGBOEABBEHO, KDCGDINMKGL NOPNNKLDKNM, IEnumerator<KDCGDINMKGL> OFCPKPFIMAH, AJFAIIFPLLE FBOICHJLBEO, [Optional] IBFGJDIIELC LIMKFMLBCAL, NMLGOMHGOLG ICIICMGBAFN = NMLGOMHGOLG.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x557CA50", Offset = "0x557B250", VA = "0x18557CA50")]
	public void DIMDCAEDBIF(IEnumerable<CBPOAGELIAE> AEDEDDFJDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x557C540", Offset = "0x557AD40", VA = "0x18557C540")]
	private CBPOAGELIAE CMGLOAJIOHM(int PNFOGIEEBGF)
	{
		return default(CBPOAGELIAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x557DC90", Offset = "0x557C490", VA = "0x18557DC90")]
	private void OGJLCJFPDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36B8B60", Offset = "0x36B7360", VA = "0x1836B8B60")]
	private static void GJDFDPAFAIF<T>(int PNFOGIEEBGF, T[] KBCGBFCFAKG, int FBPAKFCOLHM, [Optional] T MCIFPMMNEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x36B8B40", Offset = "0x36B7340", VA = "0x1836B8B40")]
	private static void GJDFDPAFAIF<T>(int PNFOGIEEBGF, NativeArray<T> KBCGBFCFAKG, int FBPAKFCOLHM, [Optional] T MCIFPMMNEBK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x557D160", Offset = "0x557B960", VA = "0x18557D160")]
	private void HHCKJMAGPIC(IEnumerable<CBPOAGELIAE> AEDEDDFJDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x557D9E0", Offset = "0x557C1E0", VA = "0x18557D9E0")]
	private void MLKFNKPAIDL(CBPOAGELIAE EEBJHPIKFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x557D4C0", Offset = "0x557BCC0", VA = "0x18557D4C0")]
	private PCLHMNMAAFJ JPEDLEDIALL(int JEFCPANLGCD)
	{
		return default(PCLHMNMAAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x557DAB0", Offset = "0x557C2B0", VA = "0x18557DAB0")]
	public void NDCCMOJJKLB(float LAPDMGFFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x557D440", Offset = "0x557BC40", VA = "0x18557D440")]
	private void IJKEDOCCLCF(Action DOGOAAONBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x557CC40", Offset = "0x557B440", VA = "0x18557CC40")]
	private void EPOKNJECHLG(Action DOGOAAONBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x557E130", Offset = "0x557C930", VA = "0x18557E130")]
	public void PLAPJNJMLDC(float LAPDMGFFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x557E030", Offset = "0x557C830", VA = "0x18557E030")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x557D780", Offset = "0x557BF80", VA = "0x18557D780")]
	public void MHCPGDEAOOD(IBFGJDIIELC ILALCOOOPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x557CE40", Offset = "0x557B640", VA = "0x18557CE40")]
	public void GIIJFBPLAMN(IBFGJDIIELC ILALCOOOPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x557D8B0", Offset = "0x557C0B0", VA = "0x18557D8B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
	public OIPIEPAHOLN(Action KLJHLBEGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5584100", Offset = "0x5582900", VA = "0x185584100", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public HAALGLGNMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3583DC0", Offset = "0x35825C0", VA = "0x183583DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FD700", Offset = "0x6FBF00", VA = "0x1806FD700", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3945390", Offset = "0x3943B90", VA = "0x183945390", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3944BF0", Offset = "0x39433F0", VA = "0x183944BF0")]
	private static bool JJAPLADLOJP(T DOGOAAONBOH, T ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x39453F0", Offset = "0x3943BF0", VA = "0x1839453F0")]
	public FPHOMACONCB(T MCHHPJOIEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x39448E0", Offset = "0x39430E0", VA = "0x1839448E0", Slot = "6")]
	public IDisposable HDPDELIAHDJ(UnityEngine.Object IGBOEABBEHO, Action<T> GFLNOENPBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3944FB0", Offset = "0x39437B0", VA = "0x183944FB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x55766A0", Offset = "0x5574EA0", VA = "0x1855766A0")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void HKHPIAEGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
	[Preserve]
	internal GLIJONKMJAJ([NBLPGINBDGI(null)] NAPIAOEEGEB OMHHFFBPJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5576600", Offset = "0x5574E00", VA = "0x185576600", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5578160", Offset = "0x5576960", VA = "0x185578160")]
	public static ICOCBIGONGG MFNJFAEBAIM(int IKGLDDPADIP, float LAPDMGFFHLM, NativeArray<NMLGOMHGOLG> PIOKNCCJKDH, NativeArray<float> BKNJOJPOGCL, NativeArray<int> JDGMJLHEPMA, NativeArray<int> IGOMGICKBLO, NativeArray<int> LIHGFFNABEP, NativeArray<int> AHMCJIFCBMP, NativeArray<int> LKFPFDBPEMJ)
	{
		return default(ICOCBIGONGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5577FB0", Offset = "0x55767B0", VA = "0x185577FB0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x55781C0", Offset = "0x55769C0", VA = "0x1855781C0")]
	private bool OENHHFILDIP(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5577F80", Offset = "0x5576780", VA = "0x185577F80")]
	private void ECAHBOEGDHJ(NativeArray<int> JGHOKMJBABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5577F20", Offset = "0x5576720", VA = "0x185577F20")]
	private int EAMIGCEAMLH(int JAJNFINBENE, int DLGGLLHKEPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5578090", Offset = "0x5576890", VA = "0x185578090")]
	private void HNPJHNMHOIE(NativeArray<int> JGHOKMJBABG, int LENMDADPBGE, int JNHJMFBGOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5577CF0", Offset = "0x55764F0", VA = "0x185577CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x556F6D0", Offset = "0x556DED0", VA = "0x18556F6D0")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	private static void HKHPIAEGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x556FC70", Offset = "0x556E470", VA = "0x18556FC70")]
	[Preserve]
	public AEHIILBFNOO([NBLPGINBDGI(null)] ANAPHBJACBA PANKOECPCED, [NBLPGINBDGI(null)] MFAOHGDBKLP MJNCFJMFBMA, [NBLPGINBDGI(null)] PCIJIHBMIBP EKAENLMBGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x556F290", Offset = "0x556DA90", VA = "0x18556F290", Slot = "12")]
	public override PKIGMKLPPJG EFACGIHFBCE(JOLKFPIPKMP IGBOEABBEHO, IEnumerator<KDCGDINMKGL> BKBMBOCOKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x556F990", Offset = "0x556E190", VA = "0x18556F990", Slot = "13")]
	public override void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x556F4F0", Offset = "0x556DCF0", VA = "0x18556F4F0", Slot = "15")]
	public override void GMDJIFFDCIE(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x556F410", Offset = "0x556DC10", VA = "0x18556F410", Slot = "14")]
	protected override void FMPDGFOLIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x556F3D0", Offset = "0x556DBD0", VA = "0x18556F3D0")]
	private LLBPHHLDHFL FDBDOJADFEI(NNIHDAPLEEB.GCDGFJIIHGI BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x556F740", Offset = "0x556DF40", VA = "0x18556F740", Slot = "16")]
	internal override BGLGLBJGDHB NIHMKOHALKD(IEnumerator<KDCGDINMKGL> BKBMBOCOKKP, Behaviour IGBOEABBEHO, AJFAIIFPLLE FBOICHJLBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x556F920", Offset = "0x556E120", VA = "0x18556F920", Slot = "17")]
	internal override NLAECECLOFD PFJKHMILOFO(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x556F7F0", Offset = "0x556DFF0", VA = "0x18556F7F0")]
	private void NJEJDGJGKID(LLBPHHLDHFL LAFALEHGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x556F220", Offset = "0x556DA20", VA = "0x18556F220", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x5581650", Offset = "0x557FE50", VA = "0x185581650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool ELDHHCEEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NNIHDAPLEEB.GCDGFJIIHGI LDLGMNAPEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NNIHDAPLEEB.GCDGFJIIHGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C90", Offset = "0x6F3490", VA = "0x1806F4C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MFAOHGDBKLP CGDCGKHEHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5580AA0", Offset = "0x557F2A0", VA = "0x185580AA0")]
	public static PKIGMKLPPJG CEJAPPIKKIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5581880", Offset = "0x5580080", VA = "0x185581880")]
	[Preserve]
	protected MKGOJFLMADG([NBLPGINBDGI(null)] ANAPHBJACBA PANKOECPCED, [NBLPGINBDGI(null)] MFAOHGDBKLP MJNCFJMFBMA, [NBLPGINBDGI(null)] PCIJIHBMIBP EKAENLMBGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5580D70", Offset = "0x557F570", VA = "0x185580D70", Slot = "6")]
	public PKIGMKLPPJG CHCDHEIAFLI(IEnumerator<KDCGDINMKGL> BKBMBOCOKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5580B40", Offset = "0x557F340", VA = "0x185580B40", Slot = "7")]
	public PKIGMKLPPJG CHCDHEIAFLI(Behaviour IGBOEABBEHO, IEnumerator<KDCGDINMKGL> BKBMBOCOKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract PKIGMKLPPJG EFACGIHFBCE(JOLKFPIPKMP IGBOEABBEHO, IEnumerator<KDCGDINMKGL> BKBMBOCOKKP);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x55816A0", Offset = "0x557FEA0", VA = "0x1855816A0", Slot = "13")]
	public virtual void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5581100", Offset = "0x557F900", VA = "0x185581100", Slot = "9")]
	public void EEBGDOAMHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5581160", Offset = "0x557F960", VA = "0x185581160", Slot = "14")]
	protected virtual void FMPDGFOLIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x55813E0", Offset = "0x557FBE0", VA = "0x1855813E0")]
	private void HDGOPGEIKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5581180", Offset = "0x557F980", VA = "0x185581180")]
	private void GJLNFNEALIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5581400", Offset = "0x557FC00", VA = "0x185581400")]
	private void JDHHMNHLCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5580A80", Offset = "0x557F280", VA = "0x185580A80")]
	private void BEBFDDBPGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5581420", Offset = "0x557FC20", VA = "0x185581420")]
	private void JMNDLCKMAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5581630", Offset = "0x557FE30", VA = "0x185581630")]
	private void NKIKPIPNDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5581610", Offset = "0x557FE10", VA = "0x185581610")]
	private void NAEPDMHOGHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x55811A0", Offset = "0x557F9A0", VA = "0x1855811A0", Slot = "15")]
	public virtual void GMDJIFFDCIE(NNIHDAPLEEB.GCDGFJIIHGI DLOKOHBEDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5581440", Offset = "0x557FC40", VA = "0x185581440")]
	private void MEPCJFCDOGE(NLAECECLOFD LAFALEHGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x18122A0", Offset = "0x1810AA0", VA = "0x1818122A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5580D80", Offset = "0x557F580", VA = "0x185580D80", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public KDCGDINMKGL POLEOJGIENF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OLGBKGHHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x55701C0", Offset = "0x556E9C0", VA = "0x1855701C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool BMALHDHFCLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x71C520", Offset = "0x71AD20", VA = "0x18071C520")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x71C540", Offset = "0x71AD40", VA = "0x18071C540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float PKANHNFIBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CE830", Offset = "0x8CD030", VA = "0x1808CE830")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x19E2AF0", Offset = "0x19E12F0", VA = "0x1819E2AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x55706B0", Offset = "0x556EEB0", VA = "0x1855706B0")]
	public BGLGLBJGDHB(IEnumerator<KDCGDINMKGL> OFCPKPFIMAH, MNAIEHBAGCI IGBOEABBEHO, AJFAIIFPLLE FBOICHJLBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x55702B0", Offset = "0x556EAB0", VA = "0x1855702B0")]
	public KDCGDINMKGL LJIHJCBHCBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5570240", Offset = "0x556EA40", VA = "0x185570240")]
	public bool LHFIDINMGFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5570570", Offset = "0x556ED70", VA = "0x185570570")]
	public void MHCPGDEAOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x55705F0", Offset = "0x556EDF0", VA = "0x1855705F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A13A70", Offset = "0x2A12270", VA = "0x182A13A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FAA40", Offset = "0x6F9240", VA = "0x1806FAA40", Slot = "23")]
		get
		{
			return default(NNIHDAPLEEB.GCDGFJIIHGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NNIHDAPLEEB.GCDGFJIIHGI NPDBPJKOACA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x902C20", Offset = "0x901420", VA = "0x180902C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float EFLACMGGLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAD0500", Offset = "0xACED00", VA = "0x180AD0500", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x556FEC0", Offset = "0x556E6C0", VA = "0x18556FEC0", Slot = "24")]
	private bool JMEKHKPBKPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x556FEB0", Offset = "0x556E6B0", VA = "0x18556FEB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x556FEE0", Offset = "0x556E6E0", VA = "0x18556FEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D250", Offset = "0x72BA50", VA = "0x18072D250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5583490", Offset = "0x5581C90", VA = "0x185583490")]
	public NLAECECLOFD(NNIHDAPLEEB.GCDGFJIIHGI AOBKLHHNECH, OAGAAMCHMGI AOHDHEKJADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5582EA0", Offset = "0x55816A0", VA = "0x185582EA0")]
	public void IHDFDIHLDMI(BGLGLBJGDHB OFCPKPFIMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5582250", Offset = "0x5580A50", VA = "0x185582250")]
	public void DPLHFBDGHDE(IList<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5582BD0", Offset = "0x55813D0", VA = "0x185582BD0")]
	public void IHCEBFKJOEF(IList<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5583280", Offset = "0x5581A80", VA = "0x185583280")]
	private void PDJABOMAFAD(BGLGLBJGDHB OFCPKPFIMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x55820D0", Offset = "0x55808D0", VA = "0x1855820D0")]
	private void BDINNEBFJPO(IList<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x55830E0", Offset = "0x55818E0", VA = "0x1855830E0")]
	private PCLHMNMAAFJ NGMILNJLAPD(BGLGLBJGDHB OFCPKPFIMAH)
	{
		return default(PCLHMNMAAFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5582A90", Offset = "0x5581290", VA = "0x185582A90")]
	public void FMPDGFOLIAO(float LAPDMGFFHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5582660", Offset = "0x5580E60", VA = "0x185582660")]
	public void EEBGDOAMHBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5582870", Offset = "0x5581070", VA = "0x185582870")]
	private void FFLICBDCOEC(List<BGLGLBJGDHB> HJCJJJLPFHG, Stack<int> EDKOBFEIEBL, bool ILGAHJHKKLP, float CKOLPFIDJGF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5582520", Offset = "0x5580D20", VA = "0x185582520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5582FC0", Offset = "0x55817C0", VA = "0x185582FC0")]
	private void JCFCMJFBPHD(List<BGLGLBJGDHB> HJCJJJLPFHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class CNDKLLLAIBI : OAGAAMCHMGI
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "4")]
	public void MNOCOEBBDFD(string FOGNBJMCDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
	public void CLLMEIOBABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
		[Cpp2IlInjected.Address(RVA = "0x5574950", Offset = "0x5573150", VA = "0x185574950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MCIDMJPMKKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x55748F0", Offset = "0x55730F0", VA = "0x1855748F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OFOMNFICCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x55749E0", Offset = "0x55731E0", VA = "0x1855749E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
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

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
		private delegate List<PlayerLoopSystem> MIPPBIKMALB(List<PlayerLoopSystem> MCBFLNKNNCK, int EHFIDDDCJCE);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct BKNBINCKNLA
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct GPMCAIIJCPF
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static MHBAOJKAIFE ICCABHKIJBA;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x48574F0", Offset = "0x48562F0", VA = "0x1848574F0")]
				public static PlayerLoopSystem BGHFCDGAKMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct BMHPHDKMCBN
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static MHBAOJKAIFE NOJIMPDBEEF;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4851390", Offset = "0x4850190", VA = "0x184851390")]
				public static PlayerLoopSystem BGHFCDGAKMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct PIEEGPFEGIF
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static MHBAOJKAIFE IKILFDJLAEM;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4860D60", Offset = "0x485FB60", VA = "0x184860D60")]
				public static PlayerLoopSystem BGHFCDGAKMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct KPEGCCLEBPD
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static MHBAOJKAIFE GCOCBGGGPNF;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x485DE10", Offset = "0x485CC10", VA = "0x18485DE10")]
				public static PlayerLoopSystem BGHFCDGAKMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct FFOGLEHDGIH
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class LJCIFKHKKPH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public FNJDDDCIEFM.JJNMPIPJHMJ key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
					public LJCIFKHKKPH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x485DFE0", Offset = "0x485CDE0", VA = "0x18485DFE0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable FOMHCOPGAMP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4856660", Offset = "0x4855460", VA = "0x184856660")]
				public static PlayerLoopSystem OGEMPEBKJBH(FNJDDDCIEFM.JJNMPIPJHMJ IIIMPJEHMOP)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct CFIGPGPHDAN
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class MFJDFPNFIKE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public FNJDDDCIEFM.JJNMPIPJHMJ key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
					public MFJDFPNFIKE()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x485F2D0", Offset = "0x485E0D0", VA = "0x18485F2D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x48524D0", Offset = "0x48512D0", VA = "0x1848524D0")]
				public static PlayerLoopSystem OGEMPEBKJBH(FNJDDDCIEFM.JJNMPIPJHMJ IIIMPJEHMOP)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GPKAIGJFCPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public GPKAIGJFCPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x48573F0", Offset = "0x48561F0", VA = "0x1848573F0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool CENIBAJPCGH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool AEKPACMMJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4853CE0", Offset = "0x4852AE0", VA = "0x184853CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4854010", Offset = "0x4852E10", VA = "0x184854010")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4852A60", Offset = "0x4851860", VA = "0x184852A60")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4853E40", Offset = "0x4852C40", VA = "0x184853E40")]
		private static void IIENDOBFNIH(FNJDDDCIEFM.JJNMPIPJHMJ IIIMPJEHMOP, ref PlayerLoopSystem IFDCNALGMKE, Type BBNMDPBBLHE, Type GMBOPAIAKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4854050", Offset = "0x4852E50", VA = "0x184854050")]
		private static void LNDIDKMDHKG(ref PlayerLoopSystem IFDCNALGMKE, Type BBNMDPBBLHE, Type GMBOPAIAKNO, MIPPBIKMALB OEGGEPIPLFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4853D20", Offset = "0x4852B20", VA = "0x184853D20")]
		private static void EFMKGANIEGK(ref PlayerLoopSystem IFDCNALGMKE, Type BBNMDPBBLHE, Type GMBOPAIAKNO, PlayerLoopSystem? PLIBIPOGAGJ, PlayerLoopSystem? LNDHPMMMLCL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FNJDDDCIEFM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum JJNMPIPJHMJ
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
	public class DGFBEJAADKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly JJNMPIPJHMJ OIFEJKJMDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly GDEHBMDMOPJ EDMGICGOFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long JICHIBBFKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long BBIBBEFLKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long MCBIBNICLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int GGFJPNCBNNM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4855270", Offset = "0x4854070", VA = "0x184855270")]
		public DGFBEJAADKK(JJNMPIPJHMJ AKAEECBLMNI, int LNFDKJOAAEK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4855250", Offset = "0x4854050", VA = "0x184855250")]
		public void PMIFJNLPJIP(int MEJLFLDPGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4854F70", Offset = "0x4853D70", VA = "0x184854F70")]
		public void GGCCFHAFIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4854F10", Offset = "0x4853D10", VA = "0x184854F10")]
		public void BPNAGNHAAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4854FE0", Offset = "0x4853DE0", VA = "0x184854FE0")]
		public void MCNMAJGKHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x48551B0", Offset = "0x4853FB0", VA = "0x1848551B0")]
		public double NAIMGOHNJMK(int IHNBELMMCLC)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int LIDNHGIGNNH = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static JJNMPIPJHMJ[] LMKKOHACAHN;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static DGFBEJAADKK[] OCIOCMJALNL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x48568C0", Offset = "0x48556C0", VA = "0x1848568C0")]
	public static DGFBEJAADKK EOBPNKEOIGD(JJNMPIPJHMJ IIIMPJEHMOP, int LNFDKJOAAEK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4856830", Offset = "0x4855630", VA = "0x184856830")]
	public static DGFBEJAADKK ENGIFIDIHMH(JJNMPIPJHMJ IIIMPJEHMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4856780", Offset = "0x4855580", VA = "0x184856780")]
	public static void COPFJFLIHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GDEHBMDMOPJ : DBLLICIHDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int AOFKJDMNPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> DIEEMLJBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double BBHFOEPLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double NINBHHFOEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double DCAHNBECCHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HENEBACLLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4856FE0", Offset = "0x4855DE0", VA = "0x184856FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double EHMEKFEDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4857190", Offset = "0x4855F90", VA = "0x184857190", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AHBALAFOIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x142E3E0", Offset = "0x142D1E0", VA = "0x18142E3E0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MECBDNKEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x11B8890", Offset = "0x11B7690", VA = "0x1811B8890", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x48571F0", Offset = "0x4855FF0", VA = "0x1848571F0")]
	public GDEHBMDMOPJ(int MJLAGKBEMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4857090", Offset = "0x4855E90", VA = "0x184857090", Slot = "4")]
	public void OJLGECALCBA(double JLBKJKPDOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4857020", Offset = "0x4855E20", VA = "0x184857020", Slot = "5")]
	public void LPAKPFAJHDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IPDMOMHAELM : DBLLICIHDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long BFNOFMOBMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double EDFOGGOHBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double EKMFGLIOMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double IALHMKMFGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double IEAKDFENMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double BBHFOEPLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double NINBHHFOEAK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long KBFJPEDAEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double AHBALAFOIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x142E3D0", Offset = "0x142D1D0", VA = "0x18142E3D0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MECBDNKEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1015880", Offset = "0x1014680", VA = "0x181015880", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double JJEJGKGAPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x11B8890", Offset = "0x11B7690", VA = "0x1811B8890")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DNNNOAEGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x11B8880", Offset = "0x11B7680", VA = "0x1811B8880")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double EHMEKFEDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x142E2F0", Offset = "0x142D0F0", VA = "0x18142E2F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4859110", Offset = "0x4857F10", VA = "0x184859110", Slot = "4")]
	public void OJLGECALCBA(double JLBKJKPDOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x48590D0", Offset = "0x4857ED0", VA = "0x1848590D0", Slot = "5")]
	public void LPAKPFAJHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4859230", Offset = "0x4858030", VA = "0x184859230")]
	public IPDMOMHAELM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DBLLICIHDLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double EHMEKFEDNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double AHBALAFOIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double MECBDNKEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJLGECALCBA(double JLBKJKPDOGK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPAKPFAJHDM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IHKACGAOIHH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface FDDMCJEIGDE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool PAEHKLMBNCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ELGHEPGNNBP();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HKBMBOOOBJG();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class AJJCCDPHNHH<TPromise, TMainThreadPromise> : FDDMCJEIGDE where TPromise : GGJFLBABPCA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise FLHBJJMGAAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise DMIDNMMBIAL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise EALGBFJIPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3887990", Offset = "0x3886790", VA = "0x183887990")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PAEHKLMBNCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3887940", Offset = "0x3886740", VA = "0x183887940", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2FF7A60", Offset = "0x2FF6860", VA = "0x182FF7A60")]
		protected AJJCCDPHNHH(TPromise FLHBJJMGAAI, TMainThreadPromise LMDNKCIGMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x38879F0", Offset = "0x38867F0", VA = "0x1838879F0", Slot = "5")]
		public void ELGHEPGNNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xB27560", Offset = "0xB26360", VA = "0x180B27560", Slot = "6")]
		public void HKBMBOOOBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void OCCHIAGFOCN(TPromise FLHBJJMGAAI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void GLPCGGGFNKA();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class CFPJPMGNGON<T> : AJJCCDPHNHH<global::JDJCJHOOLJN<T>, global::NHLAFCECFCD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3887F70", Offset = "0x3886D70", VA = "0x183887F70")]
		public CFPJPMGNGON(global::JDJCJHOOLJN<T> FLHBJJMGAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3887DD0", Offset = "0x3886BD0", VA = "0x183887DD0", Slot = "7")]
		protected override void OCCHIAGFOCN(global::JDJCJHOOLJN<T> FLHBJJMGAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3887D10", Offset = "0x3886B10", VA = "0x183887D10", Slot = "8")]
		protected override void GLPCGGGFNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3887D70", Offset = "0x3886B70", VA = "0x183887D70")]
		[CompilerGenerated]
		private void IKECAHCBOFJ(T CKHKIPCNPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3887DA0", Offset = "0x3886BA0", VA = "0x183887DA0")]
		[CompilerGenerated]
		private void KPBGINEANKF(string NLMHPLPAFMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class HKJHEBHBBIL : AJJCCDPHNHH<GGJFLBABPCA, LBEDEENLGHL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4857DD0", Offset = "0x4856BD0", VA = "0x184857DD0")]
		public HKJHEBHBBIL(GGJFLBABPCA FLHBJJMGAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4857D00", Offset = "0x4856B00", VA = "0x184857D00", Slot = "7")]
		protected override void OCCHIAGFOCN(GGJFLBABPCA FLHBJJMGAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4857CB0", Offset = "0x4856AB0", VA = "0x184857CB0", Slot = "8")]
		protected override void GLPCGGGFNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1A86970", Offset = "0x1A85770", VA = "0x181A86970")]
		[CompilerGenerated]
		private void IKECAHCBOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1A86950", Offset = "0x1A85750", VA = "0x181A86950")]
		[CompilerGenerated]
		private void KPBGINEANKF(string NLMHPLPAFMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KOPEIGMIKKD : FDDMCJEIGDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action CHNALKMKMGL;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PAEHKLMBNCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x56D180", Offset = "0x56BF80", VA = "0x18056D180", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7166E0", Offset = "0x7154E0", VA = "0x1807166E0")]
		public KOPEIGMIKKD(Action CHNALKMKMGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x143E350", Offset = "0x143D150", VA = "0x18143E350", Slot = "5")]
		public void ELGHEPGNNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "6")]
		public void HKBMBOOOBJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<FDDMCJEIGDE> HAKMFNKKGHI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29B88B0", Offset = "0x29B76B0", VA = "0x1829B88B0")]
	public static global::JDJCJHOOLJN<T> CPNPALKLFAF<T>(this global::JDJCJHOOLJN<T> FLHBJJMGAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x48580C0", Offset = "0x4856EC0", VA = "0x1848580C0")]
	public static GGJFLBABPCA CPNPALKLFAF(this GGJFLBABPCA FLHBJJMGAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x48581D0", Offset = "0x4856FD0", VA = "0x1848581D0")]
	public static void CPNPALKLFAF(Action CHNALKMKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29B87F0", Offset = "0x29B75F0", VA = "0x1829B87F0")]
	private static global::JDJCJHOOLJN<T> AIBANDGPGAG<T>(global::JDJCJHOOLJN<T> FLHBJJMGAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4857FE0", Offset = "0x4856DE0", VA = "0x184857FE0")]
	private static GGJFLBABPCA AIBANDGPGAG(GGJFLBABPCA FLHBJJMGAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4858630", Offset = "0x4857430", VA = "0x184858630")]
	private static void NOEFLGGEECF(FDDMCJEIGDE BEFFCPHNDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4858260", Offset = "0x4857060", VA = "0x184858260")]
	private static void DJMPNPENEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4858820", Offset = "0x4857620", VA = "0x184858820")]
	private static void OABJGLEPCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4858580", Offset = "0x4857380", VA = "0x184858580")]
	private static void EPGJDNFFHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MHBKOKHEPHK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CFEKCLHGGLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LBEDEENLGHL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public CFEKCLHGGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x48522D0", Offset = "0x48510D0", VA = "0x1848522D0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x48522C0", Offset = "0x48510C0", VA = "0x1848522C0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OCLCHILMEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public OCLCHILMEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4860BE0", Offset = "0x485F9E0", VA = "0x184860BE0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GBMCCMBHGFM : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LBEDEENLGHL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public GBMCCMBHGFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4856EE0", Offset = "0x4855CE0", VA = "0x184856EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4856BC0", Offset = "0x48559C0", VA = "0x184856BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4856F90", Offset = "0x4855D90", VA = "0x184856F90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4856E90", Offset = "0x4855C90", VA = "0x184856E90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JFEPKPIHGEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LBEDEENLGHL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public JFEPKPIHGEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class LNPIMFPOPNF : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public LBEDEENLGHL onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private JFEPKPIHGEL <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public LNPIMFPOPNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x485EEF0", Offset = "0x485DCF0", VA = "0x18485EEF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x485F280", Offset = "0x485E080", VA = "0x18485F280", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string LIBFNKBFOGI = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string ACIIIGICMCF = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string HMKIHKCEKBL = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string ABBFHCFPLOG = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string COGDIFCNKFC = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float MDGHILGIBLB = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static GGJFLBABPCA NCEEABGPBNC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation NBECDGGFNPM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static GGJFLBABPCA HCPHAGHFHBP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string BDKMFFAPKPE;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority FAEIIBDAHNK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool DHELLAKHLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x485F7A0", Offset = "0x485E5A0", VA = "0x18485F7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool HJLBNJAOONE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x485F650", Offset = "0x485E450", VA = "0x18485F650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool BBKAOHOKOAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x485F740", Offset = "0x485E540", VA = "0x18485F740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> EEFJEFKPLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x485FA50", Offset = "0x485E850", VA = "0x18485FA50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x485FB00", Offset = "0x485E900", VA = "0x18485FB00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x485F9A0", Offset = "0x485E7A0", VA = "0x18485F9A0")]
	[NONPLMHAFKG(NKOBICDJAEL.EnteredEditModeNextFrame, 0)]
	private static void KEEAKFDLDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x485F840", Offset = "0x485E640", VA = "0x18485F840")]
	public static GGJFLBABPCA IMGBANFLOCM(string PIOJLDKPCLM, LoadSceneMode GEIKILOMFII = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x485F420", Offset = "0x485E220", VA = "0x18485F420")]
	public static GGJFLBABPCA CENPJAEKJBD(string PIOJLDKPCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x485F6B0", Offset = "0x485E4B0", VA = "0x18485F6B0")]
	[IteratorStateMachine(typeof(GBMCCMBHGFM))]
	private static IEnumerator<MKGJCNMEMBO> FGOGPDKIOOI(string PIOJLDKPCLM, LBEDEENLGHL DFBIPJEDCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x485F390", Offset = "0x485E190", VA = "0x18485F390")]
	[IteratorStateMachine(typeof(LNPIMFPOPNF))]
	private static IEnumerator<MKGJCNMEMBO> AIFLDLFNMDC(string PIOJLDKPCLM, LoadSceneMode GEIKILOMFII, LBEDEENLGHL DFBIPJEDCCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ANNPPKADHHG
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4850E20", Offset = "0x484FC20", VA = "0x184850E20")]
	public static IDisposable GMICCEHONPM(this EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4850DA0", Offset = "0x484FBA0", VA = "0x184850DA0")]
	public static IDisposable GMICCEHONPM(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4851230", Offset = "0x4850030", VA = "0x184851230")]
	public static IDisposable MHKDJENJBAP(this EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4850FC0", Offset = "0x484FDC0", VA = "0x184850FC0")]
	public static IDisposable IECHKLJLMGC(this EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48512A0", Offset = "0x48500A0", VA = "0x1848512A0")]
	public static IDisposable NGOKGBHOCFC(this EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4850D30", Offset = "0x484FB30", VA = "0x184850D30")]
	public static IDisposable FBNACPINEKH(this EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4850AB0", Offset = "0x484F8B0", VA = "0x184850AB0")]
	public static IDisposable BPFAJAOLDEF(this EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4850EA0", Offset = "0x484FCA0", VA = "0x184850EA0")]
	public static IDisposable HFEKEFFLDDI(this EIFMBKIIJEH FLMJHFDBGLA, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4850A30", Offset = "0x484F830", VA = "0x184850A30")]
	public static IDisposable BMJAKPDALDB(this EIFMBKIIJEH FLMJHFDBGLA, float FOGPGIGGHGD, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4850B20", Offset = "0x484F920", VA = "0x184850B20")]
	public static IDisposable CAIEIEPPIJM(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4850BA0", Offset = "0x484F9A0", VA = "0x184850BA0")]
	public static IDisposable CBCIEJDGIKO(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4851030", Offset = "0x484FE30", VA = "0x184851030")]
	public static IDisposable JINMMFFDEAI(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4850C20", Offset = "0x484FA20", VA = "0x184850C20")]
	public static IDisposable DILHDNHFMCH(this EIFMBKIIJEH FLMJHFDBGLA, float FOGPGIGGHGD, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4850CB0", Offset = "0x484FAB0", VA = "0x184850CB0")]
	public static IDisposable EIADHDHOEPJ(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4851130", Offset = "0x484FF30", VA = "0x184851130")]
	public static IDisposable KCMJFGOACEH(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x48510B0", Offset = "0x484FEB0", VA = "0x1848510B0")]
	public static IDisposable JPIEEPPLKDL(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4850F30", Offset = "0x484FD30", VA = "0x184850F30")]
	public static IDisposable ICIDCNNLGJD(this EIFMBKIIJEH FLMJHFDBGLA, float FOGPGIGGHGD, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x48511B0", Offset = "0x484FFB0", VA = "0x1848511B0")]
	public static IDisposable LLHJBKFIMCB(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x48509B0", Offset = "0x484F7B0", VA = "0x1848509B0")]
	public static IDisposable AHDFIGHNIHE(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4851310", Offset = "0x4850110", VA = "0x184851310")]
	public static IDisposable PKKIHLEPJAE(this EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FADDNMGEIGD
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4855C20", Offset = "0x4854A20", VA = "0x184855C20")]
	public static IDisposable FKOJHANILMC(this MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4855BA0", Offset = "0x48549A0", VA = "0x184855BA0")]
	public static IDisposable FKOJHANILMC(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x48560F0", Offset = "0x4854EF0", VA = "0x1848560F0")]
	public static IDisposable LAILODAHAHN(this MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4855A10", Offset = "0x4854810", VA = "0x184855A10")]
	public static IDisposable BGNEBPGDIKO(this MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4855DA0", Offset = "0x4854BA0", VA = "0x184855DA0")]
	public static IDisposable HHMPINANGPI(this MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4855910", Offset = "0x4854710", VA = "0x184855910")]
	public static IDisposable AILPNIPJJJA(this MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4855CA0", Offset = "0x4854AA0", VA = "0x184855CA0")]
	public static IDisposable GAINPPODLPB(this MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4855FC0", Offset = "0x4854DC0", VA = "0x184855FC0")]
	public static IDisposable IHGGFGKBLPB(this MonoBehaviour DPADBLBJHCK, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4856160", Offset = "0x4854F60", VA = "0x184856160")]
	public static IDisposable LAMCPCDBIFP(this MonoBehaviour DPADBLBJHCK, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4855980", Offset = "0x4854780", VA = "0x184855980")]
	public static IDisposable AMIAFMAIJHI(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4855B10", Offset = "0x4854910", VA = "0x184855B10")]
	public static IDisposable EKCLMFDEKFF(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4856320", Offset = "0x4855120", VA = "0x184856320")]
	public static IDisposable OHEFLCDBFJF(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4855D10", Offset = "0x4854B10", VA = "0x184855D10")]
	public static IDisposable GIPAGMHOMJB(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4855A80", Offset = "0x4854880", VA = "0x184855A80")]
	public static IDisposable EGMJHKMCGAO(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4856060", Offset = "0x4854E60", VA = "0x184856060")]
	public static IDisposable INEFLKGPDIL(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4856280", Offset = "0x4855080", VA = "0x184856280")]
	public static IDisposable NMPMPDOODGI(this MonoBehaviour DPADBLBJHCK, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4855E10", Offset = "0x4854C10", VA = "0x184855E10")]
	public static IDisposable HOCHOLLIJHO(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4855F30", Offset = "0x4854D30", VA = "0x184855F30")]
	public static IDisposable IFKKHCHEAGH(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4855EA0", Offset = "0x4854CA0", VA = "0x184855EA0")]
	public static IDisposable ICLBMNACPCJ(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4856440", Offset = "0x4855240", VA = "0x184856440")]
	public static IDisposable PJBHKPGMEMI(this MonoBehaviour DPADBLBJHCK, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x48564E0", Offset = "0x48552E0", VA = "0x1848564E0")]
	public static IDisposable PJLPHNKCLHF(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x48561F0", Offset = "0x4854FF0", VA = "0x1848561F0")]
	public static IDisposable LLANCLHLACK(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x48563B0", Offset = "0x48551B0", VA = "0x1848563B0")]
	public static IDisposable PDBHHCAMJPB(this MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JHOJCBDPNBB
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JNOLGACFFGA : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public FJHMKDNGCFF.EOBLANAGKJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private OIFGPAAFLLH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public JNOLGACFFGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4859D20", Offset = "0x4858B20", VA = "0x184859D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4859DE0", Offset = "0x4858BE0", VA = "0x184859DE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EGJONPKNAEC : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FJHMKDNGCFF.EOBLANAGKJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private OIFGPAAFLLH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public EGJONPKNAEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4855400", Offset = "0x4854200", VA = "0x184855400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x48554E0", Offset = "0x48542E0", VA = "0x1848554E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4859600", Offset = "0x4858400", VA = "0x184859600")]
	public static ONFMLALHBOC FKOJHANILMC(Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x48596F0", Offset = "0x48584F0", VA = "0x1848596F0")]
	public static ONFMLALHBOC FKOJHANILMC(Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x48598F0", Offset = "0x48586F0", VA = "0x1848598F0")]
	public static ONFMLALHBOC FKOJHANILMC(Behaviour FLMJHFDBGLA, Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x48597E0", Offset = "0x48585E0", VA = "0x1848597E0")]
	public static ONFMLALHBOC FKOJHANILMC(Behaviour FLMJHFDBGLA, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4859A00", Offset = "0x4858800", VA = "0x184859A00")]
	public static ONFMLALHBOC GMICCEHONPM(EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4859B10", Offset = "0x4858910", VA = "0x184859B10")]
	public static ONFMLALHBOC GMICCEHONPM(EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4859C20", Offset = "0x4858A20", VA = "0x184859C20")]
	[IteratorStateMachine(typeof(JNOLGACFFGA))]
	private static IEnumerator<MKGJCNMEMBO> MDMHHKCLLLD(FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO, Action INMNIDDIEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4859CA0", Offset = "0x4858AA0", VA = "0x184859CA0")]
	[IteratorStateMachine(typeof(EGJONPKNAEC))]
	private static IEnumerator<MKGJCNMEMBO> MDMHHKCLLLD(FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO, Action<float> INMNIDDIEMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CPPMCJHEKMH
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class GOMMIGNBIMD : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public FJHMKDNGCFF.EOBLANAGKJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private JELNHIOCMBB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public GOMMIGNBIMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4857290", Offset = "0x4856090", VA = "0x184857290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x48573A0", Offset = "0x48561A0", VA = "0x1848573A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4852840", Offset = "0x4851640", VA = "0x184852840")]
	public static ONFMLALHBOC FKOJHANILMC(float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4852900", Offset = "0x4851700", VA = "0x184852900")]
	public static ONFMLALHBOC FKOJHANILMC(MonoBehaviour DPADBLBJHCK, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4852780", Offset = "0x4851580", VA = "0x184852780")]
	public static ONFMLALHBOC ELGGDMDLAEK(EIFMBKIIJEH FLMJHFDBGLA, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, bool FGICOALINJO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x48529C0", Offset = "0x48517C0", VA = "0x1848529C0")]
	[IteratorStateMachine(typeof(GOMMIGNBIMD))]
	private static IEnumerator<MKGJCNMEMBO> MDMHHKCLLLD(float FOGPGIGGHGD, FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO, Action<float> INMNIDDIEMM, bool FGICOALINJO = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CCJDFINLFJK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class CGDPEJDNMHP : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FJHMKDNGCFF.EOBLANAGKJH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public CGDPEJDNMHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x48525F0", Offset = "0x48513F0", VA = "0x1848525F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x48526A0", Offset = "0x48514A0", VA = "0x1848526A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x48520E0", Offset = "0x4850EE0", VA = "0x1848520E0")]
	[IteratorStateMachine(typeof(CGDPEJDNMHP))]
	private static IEnumerator<MKGJCNMEMBO> CALFFEBHKNO(FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, Func<bool> OMHHJLHPANH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4852160", Offset = "0x4850F60", VA = "0x184852160")]
	public static ONFMLALHBOC JKLEABDNHOJ(this MonoBehaviour DPADBLBJHCK, Func<bool> OMHHJLHPANH, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD = FJHMKDNGCFF.EOBLANAGKJH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class CBEFPIDBAHN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PFJIGAGDGMD : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public FJHMKDNGCFF.EOBLANAGKJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public PFJIGAGDGMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4860C50", Offset = "0x485FA50", VA = "0x184860C50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4860D10", Offset = "0x485FB10", VA = "0x184860D10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NKECHIEKFAO : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public FJHMKDNGCFF.EOBLANAGKJH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private MKGJCNMEMBO <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public NKECHIEKFAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x485FD90", Offset = "0x485EB90", VA = "0x18485FD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x485FE60", Offset = "0x485EC60", VA = "0x18485FE60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4851810", Offset = "0x4850610", VA = "0x184851810")]
	[IteratorStateMachine(typeof(PFJIGAGDGMD))]
	private static IEnumerator<MKGJCNMEMBO> DGCJNHPPNID(float GPFDONCHLCL, FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4851570", Offset = "0x4850370", VA = "0x184851570")]
	[IteratorStateMachine(typeof(NKECHIEKFAO))]
	private static IEnumerator<MKGJCNMEMBO> AOHEGMKMCHO(float GPFDONCHLCL, FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x48518A0", Offset = "0x48506A0", VA = "0x1848518A0")]
	public static IDisposable FCOGPGBNMDN(this MonoBehaviour DPADBLBJHCK, float GPFDONCHLCL, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4851710", Offset = "0x4850510", VA = "0x184851710")]
	public static ONFMLALHBOC CABMFINKNEK(this MonoBehaviour DPADBLBJHCK, float GPFDONCHLCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x48519F0", Offset = "0x48507F0", VA = "0x1848519F0")]
	public static ONFMLALHBOC FCOGPGBNMDN(this MonoBehaviour DPADBLBJHCK, float GPFDONCHLCL, FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4851560", Offset = "0x4850360", VA = "0x184851560")]
	public static ONFMLALHBOC AJHKFPLEKJB(this MonoBehaviour DPADBLBJHCK, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x48520D0", Offset = "0x4850ED0", VA = "0x1848520D0")]
	public static ONFMLALHBOC OKANOEKGOJD(this MonoBehaviour DPADBLBJHCK, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x48520C0", Offset = "0x4850EC0", VA = "0x1848520C0")]
	public static ONFMLALHBOC NIGGKHJEDAJ(this MonoBehaviour DPADBLBJHCK, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4851B50", Offset = "0x4850950", VA = "0x184851B50")]
	public static ONFMLALHBOC FJKLDLHOLEE(this MonoBehaviour DPADBLBJHCK, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4851E90", Offset = "0x4850C90", VA = "0x184851E90")]
	public static ONFMLALHBOC JCEFEIFHJLA(this MonoBehaviour DPADBLBJHCK, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4851EA0", Offset = "0x4850CA0", VA = "0x184851EA0")]
	private static ONFMLALHBOC MHAPBOCJJML(MonoBehaviour DPADBLBJHCK, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4851D80", Offset = "0x4850B80", VA = "0x184851D80")]
	public static ONFMLALHBOC JBCOGIJPHNL(this MonoBehaviour DPADBLBJHCK, float MIJOIIFEGFM, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4851B60", Offset = "0x4850960", VA = "0x184851B60")]
	public static ONFMLALHBOC HPKDCNDJKDP(this MonoBehaviour DPADBLBJHCK, float MIJOIIFEGFM, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4851C70", Offset = "0x4850A70", VA = "0x184851C70")]
	public static ONFMLALHBOC IAMCPHNEKAN(this MonoBehaviour DPADBLBJHCK, float MIJOIIFEGFM, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4851FB0", Offset = "0x4850DB0", VA = "0x184851FB0")]
	public static ONFMLALHBOC NIAOJEOLBBE(this MonoBehaviour DPADBLBJHCK, float MIJOIIFEGFM, Action CONOMNEGLBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4851600", Offset = "0x4850400", VA = "0x184851600")]
	public static ONFMLALHBOC AOIHCIDAEFO(this MonoBehaviour DPADBLBJHCK, float MIJOIIFEGFM, Action CONOMNEGLBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class JBFBLPCECKK : DFNADMDMHJO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PDKADMODFII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public JBFBLPCECKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public PDKADMODFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4856B90", Offset = "0x4855990", VA = "0x184856B90")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FPIJPAPMJBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public JBFBLPCECKK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public FPIJPAPMJBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4856B90", Offset = "0x4855990", VA = "0x184856B90")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float NKBJLBCIJMH;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x48553A0", Offset = "0x48541A0", VA = "0x1848553A0")]
	public JBFBLPCECKK(Behaviour FLMJHFDBGLA, float NKBJLBCIJMH, [Optional] Action DAICIKCBMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4859340", Offset = "0x4858140", VA = "0x184859340", Slot = "9")]
	protected override bool NOAPINMBALI(Action CHNALKMKMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4859260", Offset = "0x4858060", VA = "0x184859260", Slot = "10")]
	protected override bool MMKPEKNMGDE(Action CHNALKMKMGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PECBFFAIIGC
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool AKHCHBBHMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JFOILBBIHIN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHNCAIFANKP(bool DKKCAKBAFCA = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EHNCAIFANKP(Action CHNALKMKMGL, bool DKKCAKBAFCA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class DFNADMDMHJO : PECBFFAIIGC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class FFNHGLNBKBI : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public FFNHGLNBKBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4856570", Offset = "0x4855370", VA = "0x184856570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4856610", Offset = "0x4855410", VA = "0x184856610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour FLMJHFDBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action DAICIKCBMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private HJLPNCBIIPA JNBJNKBPAKH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AKHCHBBHMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xB34C70", Offset = "0xB33A70", VA = "0x180B34C70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JFOILBBIHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x48543D0", Offset = "0x48531D0", VA = "0x1848543D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x48545F0", Offset = "0x48533F0", VA = "0x1848545F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x48548D0", Offset = "0x48536D0", VA = "0x1848548D0")]
	protected DFNADMDMHJO(Behaviour FLMJHFDBGLA, [Optional] Action DAICIKCBMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x48544C0", Offset = "0x48532C0", VA = "0x1848544C0", Slot = "7")]
	public bool EHNCAIFANKP(bool DKKCAKBAFCA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x4854470", Offset = "0x4853270", VA = "0x184854470", Slot = "8")]
	public bool EHNCAIFANKP(Action CHNALKMKMGL, bool DKKCAKBAFCA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool NOAPINMBALI(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MMKPEKNMGDE(Action CHNALKMKMGL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4854520", Offset = "0x4853320", VA = "0x184854520")]
	protected void FMJDCNECCBD(Action CHNALKMKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x48546F0", Offset = "0x48534F0", VA = "0x1848546F0")]
	protected GGJFLBABPCA PPFMDINGHIK(float PCHGGIMDIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4854580", Offset = "0x4853380", VA = "0x184854580")]
	private void MNPPPGICEFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4854690", Offset = "0x4853490", VA = "0x184854690")]
	[IteratorStateMachine(typeof(FFNHGLNBKBI))]
	private static IEnumerator<MKGJCNMEMBO> PGNMKEOEDCB(float PCHGGIMDIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4854540", Offset = "0x4853340", VA = "0x184854540")]
	[CompilerGenerated]
	private void HKHEGABIHIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ELEPPDFJLDO : DFNADMDMHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float KHIGEMIDCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int NPEOKLOIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float JIOHNONKPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] IABIECKBDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int DJKBAODPMFI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LGDKBEOPAIK LGBEODCEOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x526A10", Offset = "0x525810", VA = "0x180526A10")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB0", Offset = "0x54CAB0", VA = "0x18054DCB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x48557E0", Offset = "0x48545E0", VA = "0x1848557E0")]
	public ELEPPDFJLDO(Behaviour FLMJHFDBGLA, float ADPJGIIABBH, int NPEOKLOIHIK, [Optional] Action DAICIKCBMOK, float JIOHNONKPBF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x56D080", Offset = "0x56BE80", VA = "0x18056D080", Slot = "9")]
	protected override bool NOAPINMBALI(Action CHNALKMKMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x48555C0", Offset = "0x48543C0", VA = "0x1848555C0", Slot = "10")]
	protected override bool MMKPEKNMGDE(Action CHNALKMKMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4855530", Offset = "0x4854330", VA = "0x184855530")]
	private void BLFKDMKPKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EENLKPKMMGG : DFNADMDMHJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float NKBJLBCIJMH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x48553A0", Offset = "0x48541A0", VA = "0x1848553A0")]
	public EENLKPKMMGG(Behaviour FLMJHFDBGLA, float NKBJLBCIJMH, [Optional] Action DAICIKCBMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x56D080", Offset = "0x56BE80", VA = "0x18056D080", Slot = "9")]
	protected override bool NOAPINMBALI(Action CHNALKMKMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4855360", Offset = "0x4854160", VA = "0x184855360", Slot = "10")]
	protected override bool MMKPEKNMGDE(Action CHNALKMKMGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OCGHHJAHGNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MPEDOJLDJNB : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public MPEDOJLDJNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x485FC40", Offset = "0x485EA40", VA = "0x18485FC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x485FD40", Offset = "0x485EB40", VA = "0x18485FD40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ONFMLALHBOC EECCGDOEDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private EIFMBKIIJEH FLMJHFDBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action INMNIDDIEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> DOKOAPNGBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float NABIBGKMDDI;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x48608A0", Offset = "0x485F6A0", VA = "0x1848608A0")]
	public OCGHHJAHGNF(EIFMBKIIJEH FLMJHFDBGLA, Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x48606E0", Offset = "0x485F4E0", VA = "0x1848606E0")]
	public OCGHHJAHGNF(EIFMBKIIJEH FLMJHFDBGLA, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4860A60", Offset = "0x485F860", VA = "0x184860A60")]
	public OCGHHJAHGNF(EIFMBKIIJEH FLMJHFDBGLA, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4860120", Offset = "0x485EF20", VA = "0x184860120")]
	private void FKOJHANILMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4860330", Offset = "0x485F130", VA = "0x184860330")]
	private void JNINIPLACMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x485FF70", Offset = "0x485ED70", VA = "0x18485FF70")]
	private void BAKJJMGBEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4860540", Offset = "0x485F340", VA = "0x184860540")]
	private void NHLLMGGJJGO(string NLMHPLPAFMC, Action APHLMJMPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4860670", Offset = "0x485F470", VA = "0x184860670")]
	[IteratorStateMachine(typeof(MPEDOJLDJNB))]
	private IEnumerator<MKGJCNMEMBO> OBNNGLLLILC(Action APHLMJMPFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x48600C0", Offset = "0x485EEC0", VA = "0x1848600C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x48604C0", Offset = "0x485F2C0", VA = "0x1848604C0")]
	[CompilerGenerated]
	private void KKCPGDFDKNO(string BNOCGDMHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x48602B0", Offset = "0x485F0B0", VA = "0x1848602B0")]
	[CompilerGenerated]
	private void FLKDBPPHMEK(string BNOCGDMHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x485FEF0", Offset = "0x485ECF0", VA = "0x18485FEF0")]
	[CompilerGenerated]
	private void ALKJKAPAMPK(string BNOCGDMHEJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class LKBAKEIJJAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class LJKOLDICIBC : IEnumerator<MKGJCNMEMBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private MKGJCNMEMBO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private MKGJCNMEMBO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
		[DebuggerHidden]
		public LJKOLDICIBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x485E090", Offset = "0x485CE90", VA = "0x18485E090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x485E190", Offset = "0x485CF90", VA = "0x18485E190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private ONFMLALHBOC EECCGDOEDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour DPADBLBJHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action INMNIDDIEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> DOKOAPNGBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float NABIBGKMDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool FGICOALINJO;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x485ED30", Offset = "0x485DB30", VA = "0x18485ED30")]
	public LKBAKEIJJAD(MonoBehaviour DPADBLBJHCK, Action INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x485E9D0", Offset = "0x485D7D0", VA = "0x18485E9D0")]
	public LKBAKEIJJAD(MonoBehaviour DPADBLBJHCK, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x485EB90", Offset = "0x485D990", VA = "0x18485EB90")]
	public LKBAKEIJJAD(MonoBehaviour DPADBLBJHCK, float FOGPGIGGHGD, Action<float> INMNIDDIEMM, FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD, bool FGICOALINJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x485E490", Offset = "0x485D290", VA = "0x18485E490")]
	private void FKOJHANILMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x485E620", Offset = "0x485D420", VA = "0x18485E620")]
	private void JNINIPLACMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x485E1E0", Offset = "0x485CFE0", VA = "0x18485E1E0")]
	private void BAKJJMGBEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x485E830", Offset = "0x485D630", VA = "0x18485E830")]
	private void NHLLMGGJJGO(string NLMHPLPAFMC, Action APHLMJMPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x485E960", Offset = "0x485D760", VA = "0x18485E960")]
	[IteratorStateMachine(typeof(LJKOLDICIBC))]
	private IEnumerator<MKGJCNMEMBO> OBNNGLLLILC(Action APHLMJMPFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x485E430", Offset = "0x485D230", VA = "0x18485E430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x485E7B0", Offset = "0x485D5B0", VA = "0x18485E7B0")]
	[CompilerGenerated]
	private void LMFDANGDPKK(string BNOCGDMHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x485E330", Offset = "0x485D130", VA = "0x18485E330")]
	[CompilerGenerated]
	private void CJAHBLCACGE(string BNOCGDMHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x485E3B0", Offset = "0x485D1B0", VA = "0x18485E3B0")]
	[CompilerGenerated]
	private void CPOAJBANOMK(string BNOCGDMHEJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface OPDALAPLNHE
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int LFGMGBIAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IDOOKIKBKBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IDOOKIKBKBC GPHKLGMAKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action BKANDJCGAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool IMDFPFHAILG;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7166E0", Offset = "0x7154E0", VA = "0x1807166E0")]
	public IDOOKIKBKBC(Action BKANDJCGAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4857EE0", Offset = "0x4856CE0", VA = "0x184857EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HDDEPBJPPHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MDOAIEJIMGO(Action<T> HKIPCOOBFBD);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable MDOAIEJIMGO(UnityEngine.Object FLMJHFDBGLA, Action<T> HKIPCOOBFBD);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KGNOBOIJGBI<T> : global::HDDEPBJPPHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IIBEKFGMBIJ<T> : global::KGNOBOIJGBI<T>, global::HDDEPBJPPHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class INBNHFOLNCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::IIBEKFGMBIJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::GJDOCFJEMJA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x28DB5C0", Offset = "0x28DA3C0", VA = "0x1828DB5C0")]
		public INBNHFOLNCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3897230", Offset = "0x3896030", VA = "0x183897230")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject BGLJJJBJCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::GJDOCFJEMJA<UnityEngine.Object, Action<T>>> NBAALLMILMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T ABAAEJAAPAF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object FMAABAIJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3890F40", Offset = "0x388FD40", VA = "0x183890F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T PGEGKAIHDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5518F0", Offset = "0x5506F0", VA = "0x1805518F0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3891440", Offset = "0x3890240", VA = "0x183891440", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x38914D0", Offset = "0x38902D0", VA = "0x1838914D0")]
	private static bool IFIIGFLKNBC(T DCJNBPLJICC, T JLGJJNEIJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3892010", Offset = "0x3890E10", VA = "0x183892010")]
	public IIBEKFGMBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3891ED0", Offset = "0x3890CD0", VA = "0x183891ED0")]
	public IIBEKFGMBIJ(T MLFGJPKNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x38913A0", Offset = "0x38901A0", VA = "0x1838913A0")]
	public void HHACGHHCOLP(T DMFFGABONKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3891800", Offset = "0x3890600", VA = "0x183891800", Slot = "7")]
	public IDisposable MDOAIEJIMGO(Action<T> HKIPCOOBFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x38916A0", Offset = "0x38904A0", VA = "0x1838916A0", Slot = "8")]
	public IDisposable MDOAIEJIMGO(UnityEngine.Object FLMJHFDBGLA, Action<T> HKIPCOOBFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3891BA0", Offset = "0x38909A0", VA = "0x183891BA0")]
	private void OIEIFEGIGHA()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<IKOCECLGGHM, Scheduler>, IKOCECLGGHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class KBOADLKDFCA : OPDALAPLNHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public KBACPEDIENI NNNNOJPKPAI;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int LFGMGBIAJGO
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x523010", Offset = "0x521E10", VA = "0x180523010", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x54CBC0", Offset = "0x54B9C0", VA = "0x18054CBC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x485DAE0", Offset = "0x485C8E0", VA = "0x18485DAE0")]
			public static MKGJCNMEMBO BBEAKFLFFEM(IEnumerator<MKGJCNMEMBO> CJPCGLOCIJD, JHLJOEPGJCP EKLJEEAJMIC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x485DA00", Offset = "0x485C800", VA = "0x18485DA00")]
			public MKGJCNMEMBO BBEAKFLFFEM(JHLJOEPGJCP[] MMDOHPCEHEA, IEnumerator<MKGJCNMEMBO>[] AAHEFIJGBOP, MKGJCNMEMBO[] ELMMDAEPPGK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x485DC40", Offset = "0x485CA40", VA = "0x18485DC40")]
			public void PNOAIEJMMMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x485DD40", Offset = "0x485CB40", VA = "0x18485DD40")]
			public void OECNOJFFLHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x485DC70", Offset = "0x485CA70", VA = "0x18485DC70")]
			public void NBPPGLAINLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x485DC40", Offset = "0x485CA40", VA = "0x18485DC40")]
			public void HKBMBOOOBJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public KBOADLKDFCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class KBACPEDIENI
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct MFNENHCLNNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public KBOADLKDFCA LFGBGHBEJHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public EIFMBKIIJEH EPNAKNBBCGK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public JHLJOEPGJCP INJCGPOLAOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<MKGJCNMEMBO> EBAAMPDJCNN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public MKGJCNMEMBO IEOMFMJGCOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public AFMLMLJACON LLLBPFOGHLO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct ANEJBBPHFAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public FJHMKDNGCFF.EOBLANAGKJH IAKJKAEPAAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<MFNENHCLNNA> KAKGHGOPHIH;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class IMMNGCMJOJO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KBACPEDIENI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public EIFMBKIIJEH context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public KBOADLKDFCA routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public AFMLMLJACON coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public JHLJOEPGJCP promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public MKGJCNMEMBO currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<MKGJCNMEMBO> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
				public IMMNGCMJOJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x4858A20", Offset = "0x4857820", VA = "0x184858A20")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class NMPBCEJEOGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public KBOADLKDFCA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public KBACPEDIENI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
				public NMPBCEJEOGO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x485FEB0", Offset = "0x485ECB0", VA = "0x18485FEB0")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class ICBKOCCKFJK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public KBOADLKDFCA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public KBACPEDIENI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
				public ICBKOCCKFJK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x4857EA0", Offset = "0x4856CA0", VA = "0x184857EA0")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class PDCEPBOLFBA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public KBOADLKDFCA schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public KBACPEDIENI <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
				public PDCEPBOLFBA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x4860C10", Offset = "0x485FA10", VA = "0x184860C10")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] FKNHCDHEKGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<AFMLMLJACON> IOODAKONDJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> JMEGGBMMOGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> BDDLJGKOIKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> AJBLMDLIDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> OBMHNELDCAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> OICANNFKGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> JDJGNAKHJFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KBOADLKDFCA[] AEPDAOBGCMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private JHLJOEPGJCP[] MMDOHPCEHEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private EIFMBKIIJEH[] DBGDMOMHLHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<MKGJCNMEMBO>[] FAGOAEHBMEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private MKGJCNMEMBO[] EJCKLKGNHHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int FMJPNMMGNEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int EHCNCIHFDGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int OFJPMAOGOHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float HFHIIDFGACC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private PMBGJKGEFGB GLCOADDNNEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle FMPCFEEBIHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<KBOADLKDFCA> DGHFHGFJHHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool FPKFFFBKEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> FLGBKDMFFDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> OHONCNCOCBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool GDHBGAFHBCK;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public ANEJBBPHFAA[] JDNOCCGOGCJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x563B60", Offset = "0x562960", VA = "0x180563B60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int GNEICEIDDNB
			{
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x7D5A30", Offset = "0x7D4830", VA = "0x1807D5A30")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x485C790", Offset = "0x485B590", VA = "0x18485C790")]
			private static int MIHPBNOHMDG(FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x485D4B0", Offset = "0x485C2B0", VA = "0x18485D4B0")]
			public KBACPEDIENI(FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x485BC20", Offset = "0x485AA20", VA = "0x18485BC20")]
			private void DHFODMLAEBL(ref int KKPLKCAGFLE, int HOGOIFHIFEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x485CD30", Offset = "0x485BB30", VA = "0x18485CD30")]
			public void OEDBDGKGDGC(EIFMBKIIJEH FLMJHFDBGLA, MKGJCNMEMBO CEBKPEOBJEO, IEnumerator<MKGJCNMEMBO> CJPCGLOCIJD, JHLJOEPGJCP EKLJEEAJMIC, [Optional] KBOADLKDFCA NHNGELCDPCC, AFMLMLJACON ODLEOJICDBA = AFMLMLJACON.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x485D200", Offset = "0x485C000", VA = "0x18485D200")]
			public void PHGGPEEPMPO(IEnumerable<MFNENHCLNNA> JJPIMDAGOBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x485B7A0", Offset = "0x485A5A0", VA = "0x18485B7A0")]
			private MFNENHCLNNA CHKIJPECJJC(int HJAGPPDKJCA)
			{
				return default(MFNENHCLNNA);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x485CE90", Offset = "0x485BC90", VA = "0x18485CE90")]
			private void PEPHCCFHMKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x2CEC730", Offset = "0x2CEB530", VA = "0x182CEC730")]
			private static void HFKBCFNAHLC<T>(int HJAGPPDKJCA, T[] IJOIDJDECEN, int NEPCFDJCABD, [Optional] T DCIDBFCGBBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2CEC710", Offset = "0x2CEB510", VA = "0x182CEC710")]
			private static void HFKBCFNAHLC<T>(int HJAGPPDKJCA, NativeArray<T> IJOIDJDECEN, int NEPCFDJCABD, [Optional] T DCIDBFCGBBG) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x485BE30", Offset = "0x485AC30", VA = "0x18485BE30")]
			private void FAIDNKNKEII(IEnumerable<MFNENHCLNNA> JJPIMDAGOBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x485D3F0", Offset = "0x485C1F0", VA = "0x18485D3F0")]
			private void PJGFABPCCEL(MFNENHCLNNA GIIMLFJDEJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x485C7C0", Offset = "0x485B5C0", VA = "0x18485C7C0")]
			private CCOCIGJHLFK MMINBIDADCH(int AOOKHAOAGCG)
			{
				return default(CCOCIGJHLFK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x485CB40", Offset = "0x485B940", VA = "0x18485CB40")]
			public void OEADMGMEGPJ(float GGAHHCEKMOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x485BDB0", Offset = "0x485ABB0", VA = "0x18485BDB0")]
			private void EFIPGLDMMNP(Action DCJNBPLJICC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x485C0D0", Offset = "0x485AED0", VA = "0x18485C0D0")]
			private void GMOENJHFBHN(Action DCJNBPLJICC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x485C2F0", Offset = "0x485B0F0", VA = "0x18485C2F0")]
			public void JLBNLFICDGB(float GGAHHCEKMOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x485C210", Offset = "0x485B010", VA = "0x18485C210")]
			public void JHKCEBHDNNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x485C150", Offset = "0x485AF50", VA = "0x18485C150")]
			public void HKBMBOOOBJG(KBOADLKDFCA FMBOKPJBIDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x485CA80", Offset = "0x485B880", VA = "0x18485CA80")]
			public void NLMFHHCEAFJ(KBOADLKDFCA FMBOKPJBIDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x485B6E0", Offset = "0x485A4E0", VA = "0x18485B6E0")]
			public void ACLDALBCLPH(KBOADLKDFCA FMBOKPJBIDE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct PMBGJKGEFGB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float PEDECEEKKMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int LHCHDJBGDFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> HBJNHFEBMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> LHKOGJCAFPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> OINAHKBJMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<AFMLMLJACON> GEAGLMKDCOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> MOKPFJOMDJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> OBMHNELDCAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> BDDLJGKOIKB;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4860F70", Offset = "0x485FD70", VA = "0x184860F70")]
			public static PMBGJKGEFGB EPOPAOGMFCF(int KCECJMNPEPD, float GGAHHCEKMOK, NativeArray<AFMLMLJACON> JOGKCAAFBFJ, NativeArray<float> HOGMKHGGABC, NativeArray<int> APGDPKAAJDG, NativeArray<int> FOFGMDOJPKL, NativeArray<int> NLADIDFNKIJ, NativeArray<int> LHKOGJCAFPO, NativeArray<int> OINAHKBJMOH)
			{
				return default(PMBGJKGEFGB);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4861040", Offset = "0x485FE40", VA = "0x184861040", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4860F30", Offset = "0x485FD30", VA = "0x184860F30")]
			private bool ALBOEHJJKNK(int HLONBDLBPCF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4861120", Offset = "0x485FF20", VA = "0x184861120")]
			private void FDCKEPNACHA(NativeArray<int> EMIAEKMNBGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4861150", Offset = "0x485FF50", VA = "0x184861150")]
			private int GGFJIFGAIOP(int FFOKIMICFNJ, int OBFAMDOIKDG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x48613F0", Offset = "0x48601F0", VA = "0x1848613F0")]
			private void NOJEHLAJPNH(NativeArray<int> EMIAEKMNBGH, int OKNNDDIGHFE, int ABBHIEGMJNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x48611C0", Offset = "0x485FFC0", VA = "0x1848611C0")]
			private void GJDPKNLMMGL(NativeArray<int> EMIAEKMNBGH, int HPHOPFJANAF, int LFDCBJLKCBI, int MEMOCBMOGJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class HECOEJJBAJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly JHLJOEPGJCP EKLJEEAJMIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour FLMJHFDBGLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool DODPJKANFEN;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<MKGJCNMEMBO> EBAAMPDJCNN
			{
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x527480", Offset = "0x526280", VA = "0x180527480")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x54AEA0", Offset = "0x549CA0", VA = "0x18054AEA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public MKGJCNMEMBO IEOMFMJGCOO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x52A460", Offset = "0x529260", VA = "0x18052A460")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool DDJANMAGMOD
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x48578D0", Offset = "0x48566D0", VA = "0x1848578D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool JKFPAINCCCA
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x853820", Offset = "0x852620", VA = "0x180853820")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x853E60", Offset = "0x852C60", VA = "0x180853E60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string EHPHADKLFCE
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x5274A0", Offset = "0x5262A0", VA = "0x1805274A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x54EB50", Offset = "0x54D950", VA = "0x18054EB50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float IDEDHMIJDDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0xA0EE70", Offset = "0xA0DC70", VA = "0x180A0EE70")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x1881470", Offset = "0x1880270", VA = "0x181881470")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4857B10", Offset = "0x4856910", VA = "0x184857B10")]
			public HECOEJJBAJP(IEnumerator<MKGJCNMEMBO> CJPCGLOCIJD, Behaviour FLMJHFDBGLA, JHLJOEPGJCP EKLJEEAJMIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x48576C0", Offset = "0x48564C0", VA = "0x1848576C0")]
			public MKGJCNMEMBO BBEAKFLFFEM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x48579F0", Offset = "0x48567F0", VA = "0x1848579F0")]
			public bool MGGJPIBEMCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x4857960", Offset = "0x4856760", VA = "0x184857960")]
			public void HKBMBOOOBJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x4857A80", Offset = "0x4856880", VA = "0x184857A80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x23EEDD0", Offset = "0x23EDBD0", VA = "0x1823EEDD0")]
			[CompilerGenerated]
			private void HAEPEMOAAAH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class JHLJOEPGJCP : OFLPBFHADPI, ONFMLALHBOC, HJLPNCBIIPA, GGJFLBABPCA, IEnumerator, MKGJCNMEMBO, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private FJHMKDNGCFF.EOBLANAGKJH ONPNFCEBACE;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private FJHMKDNGCFF.EOBLANAGKJH NNICPOMMOGJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x591190", Offset = "0x58FF90", VA = "0x180591190", Slot = "23")]
				get
				{
					return default(FJHMKDNGCFF.EOBLANAGKJH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public FJHMKDNGCFF.EOBLANAGKJH NNNNOJPKPAI
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x591190", Offset = "0x58FF90", VA = "0x180591190")]
				get
				{
					return default(FJHMKDNGCFF.EOBLANAGKJH);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x760B90", Offset = "0x75F990", VA = "0x180760B90")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float BNBCEHIBEOJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0x742990", Offset = "0x741790", VA = "0x180742990", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x4859580", Offset = "0x4858380", VA = "0x184859580", Slot = "24")]
			private bool HPBNHMJPHHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x4859570", Offset = "0x4858370", VA = "0x184859570", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x48595A0", Offset = "0x48583A0", VA = "0x1848595A0")]
			public JHLJOEPGJCP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum CCOCIGJHLFK : byte
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
		private sealed class JPGLEDKAIBD : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum PNPLJCLGDEI
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct KIHLBEGJKLM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public FJHMKDNGCFF.EOBLANAGKJH IAKJKAEPAAL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public PNPLJCLGDEI DCKDNKKKEBL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<HECOEJJBAJP> BNBJLOOOHKI;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly PNPLJCLGDEI[] AEPOJKMCMHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly FJHMKDNGCFF.EOBLANAGKJH LHKBNNHHMOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool NOOCDOFJKIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly HECOEJJBAJP[] EOABKACEMFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<HECOEJJBAJP> GLNMFLFLCJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> AJCIJIJLFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<HECOEJJBAJP> OKJHFNCAEAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> GKNANOMMPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool GDHBGAFHBCK;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public KIHLBEGJKLM[,] FAKGGEDBEJD
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x526800", Offset = "0x525600", VA = "0x180526800")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int GNEICEIDDNB
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x485A510", Offset = "0x4859310", VA = "0x18485A510")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x485B290", Offset = "0x485A090", VA = "0x18485B290")]
			public JPGLEDKAIBD(FJHMKDNGCFF.EOBLANAGKJH IIHEDPNBEFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x485A300", Offset = "0x4859100", VA = "0x18485A300")]
			public void EELLPGPJGNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x485A680", Offset = "0x4859480", VA = "0x18485A680")]
			public void GDMFFCPNLNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x485AE00", Offset = "0x4859C00", VA = "0x18485AE00")]
			private void OPABDFKPDKG(IReadOnlyList<HECOEJJBAJP> FBOOCHDEGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4859F50", Offset = "0x4858D50", VA = "0x184859F50")]
			public void BKFNHAGJCOL(HECOEJJBAJP CJPCGLOCIJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x485AF30", Offset = "0x4859D30", VA = "0x18485AF30")]
			public void PBIPIJMIKDH(IList<HECOEJJBAJP> AAHEFIJGBOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x485AB80", Offset = "0x4859980", VA = "0x18485AB80")]
			public void NALKGGELJFK(IList<HECOEJJBAJP> AAHEFIJGBOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x485A870", Offset = "0x4859670", VA = "0x18485A870")]
			private void IPCBAKJIONM(HECOEJJBAJP CJPCGLOCIJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x485A960", Offset = "0x4859760", VA = "0x18485A960")]
			private void KKGCNCLNGOH(IList<HECOEJJBAJP> AAHEFIJGBOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x485A070", Offset = "0x4858E70", VA = "0x18485A070")]
			private CCOCIGJHLFK BNDIOBNKCNI(HECOEJJBAJP CJPCGLOCIJD)
			{
				return default(CCOCIGJHLFK);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x485AAD0", Offset = "0x48598D0", VA = "0x18485AAD0")]
			public void LAILODAHAHN(float GGAHHCEKMOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x485A310", Offset = "0x4859110", VA = "0x18485A310")]
			public void FBHHAECBHOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x485A690", Offset = "0x4859490", VA = "0x18485A690")]
			private void IIJOENHPENC(List<HECOEJJBAJP> AAHEFIJGBOP, Stack<int> PADCKHNIOAG, bool BIBLBPCJMGF, float MHGPDNEMIIM = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x485A1C0", Offset = "0x4858FC0", VA = "0x18485A1C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x4859E30", Offset = "0x4858C30", VA = "0x184859E30")]
			private void AOGJEGCMFMH(List<HECOEJJBAJP> AAHEFIJGBOP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum AFMLMLJACON : byte
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
		private sealed class ILKJBAPDCAN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x180527080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x54AC50", Offset = "0x549A50", VA = "0x18054AC50")]
			[DebuggerHidden]
			public ILKJBAPDCAN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x4858950", Offset = "0x4857750", VA = "0x184858950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x48589D0", Offset = "0x48577D0", VA = "0x1848589D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const AFMLMLJACON BMGDKCNGJMP = AFMLMLJACON.Cancelled | AFMLMLJACON.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly FJHMKDNGCFF.EOBLANAGKJH[] BIACMKLGCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private JPGLEDKAIBD[] OIAFGOBBHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KBACPEDIENI[] OOLCIHIPIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine GIODLFMKAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame ALBMDPGENNE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FJHMKDNGCFF.EOBLANAGKJH NCINMNFDNDP
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x527470", Offset = "0x526270", VA = "0x180527470")]
			[CompilerGenerated]
			get
			{
				return default(FJHMKDNGCFF.EOBLANAGKJH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x54BBD0", Offset = "0x54A9D0", VA = "0x18054BBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BLBLDKDCJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x54BBE0", Offset = "0x54A9E0", VA = "0x18054BBE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x54B7F0", Offset = "0x54A5F0", VA = "0x18054B7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int GNEICEIDDNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4862DF0", Offset = "0x4861BF0", VA = "0x184862DF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x48619D0", Offset = "0x48607D0", VA = "0x1848619D0")]
		public static ONFMLALHBOC GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x48614C0", Offset = "0x48602C0", VA = "0x1848614C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4861E40", Offset = "0x4860C40", VA = "0x184861E40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4861E00", Offset = "0x4860C00", VA = "0x184861E00")]
		private JPGLEDKAIBD OJHOGDJOEKF(FJHMKDNGCFF.EOBLANAGKJH FHJGHNDLPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xF14370", Offset = "0xF13170", VA = "0x180F14370")]
		private KBACPEDIENI LLHIOMBMGFC(FJHMKDNGCFF.EOBLANAGKJH FHJGHNDLPMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4862300", Offset = "0x4861100", VA = "0x184862300")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x48622C0", Offset = "0x48610C0", VA = "0x1848622C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4862BC0", Offset = "0x48619C0", VA = "0x184862BC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4861A70", Offset = "0x4860870", VA = "0x184861A70")]
		private void ICCABHKIJBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4861DF0", Offset = "0x4860BF0", VA = "0x184861DF0")]
		private void NOJIMPDBEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x48619C0", Offset = "0x48607C0", VA = "0x1848619C0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4861DE0", Offset = "0x4860BE0", VA = "0x184861DE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4861A80", Offset = "0x4860880", VA = "0x184861A80")]
		private void IKILFDJLAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4861D70", Offset = "0x4860B70", VA = "0x184861D70")]
		[IteratorStateMachine(typeof(ILKJBAPDCAN))]
		private IEnumerator LLHHBMKFFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x48626E0", Offset = "0x48614E0", VA = "0x1848626E0", Slot = "7")]
		public ONFMLALHBOC Run(IEnumerator<MKGJCNMEMBO> DDLHNJGLMNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x48624B0", Offset = "0x48612B0", VA = "0x1848624B0", Slot = "8")]
		public ONFMLALHBOC Run(Behaviour FLMJHFDBGLA, IEnumerator<MKGJCNMEMBO> DDLHNJGLMNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4862380", Offset = "0x4861180", VA = "0x184862380", Slot = "9")]
		public ONFMLALHBOC RunJobbed(EIFMBKIIJEH FLMJHFDBGLA, IEnumerator<MKGJCNMEMBO> DDLHNJGLMNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4861960", Offset = "0x4860760", VA = "0x184861960", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x48626F0", Offset = "0x48614F0", VA = "0x1848626F0")]
		public void UpdateQueue(FJHMKDNGCFF.EOBLANAGKJH CCFKPKNDLHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4861A90", Offset = "0x4860890", VA = "0x184861A90")]
		private void JBKEMOJNEAO(JPGLEDKAIBD CCMCGAMINJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4861C50", Offset = "0x4860A50", VA = "0x184861C50")]
		private void JOCECIAODAH(KBACPEDIENI CCMCGAMINJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4862D80", Offset = "0x4861B80", VA = "0x184862D80")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class CIGLBCCMPLM
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x48526F0", Offset = "0x48514F0", VA = "0x1848526F0")]
	[BMPLDOFAONG]
	private static void OGICEOHIGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class HLHIBJDHCEK : LGDKBEOPAIK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float OOMFJBBPMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4857E90", Offset = "0x4856C90", VA = "0x184857E90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float BMJLGAOEAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4857E70", Offset = "0x4856C70", VA = "0x184857E70", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float GNMMDGMDAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4857E80", Offset = "0x4856C80", VA = "0x184857E80", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int KCOBMEFKAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4857E40", Offset = "0x4856C40", VA = "0x184857E40", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double GBNGNFOJKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4857E50", Offset = "0x4856C50", VA = "0x184857E50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public HLHIBJDHCEK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DFPNJGLKJCK
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] BHKGCCOPMJC;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int GBDAOKLIGMK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int OHPBAKOKAFL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger DGIAGADGPEN;

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DFPNJGLKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4854C50", Offset = "0x4853A50", VA = "0x184854C50")]
	private static string JPCMDGFJHKL(byte[] JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4854920", Offset = "0x4853720", VA = "0x184854920")]
	public static string FNPNBMDGJBN(byte[] LPHHCMJDKLK, bool DODMIEKCDBF)
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

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
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

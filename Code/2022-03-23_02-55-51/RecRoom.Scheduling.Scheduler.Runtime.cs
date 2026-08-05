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
		private delegate List<PlayerLoopSystem> HLAIFFMHFMP(List<PlayerLoopSystem> APDHBPIBKFM, int FAMKONMGEOC);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct DLFBONMPEGM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct JCIGHCPJOGM
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static AIPMLCOLGIN GGMJGKGPLEB;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x46F0680", Offset = "0x46EEE80", VA = "0x1846F0680")]
				public static PlayerLoopSystem DLBFOOLHACB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct OHIOBBAAIJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static AIPMLCOLGIN KGPFBNEJCBN;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x46F5BF0", Offset = "0x46F43F0", VA = "0x1846F5BF0")]
				public static PlayerLoopSystem DLBFOOLHACB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct OAPFDCEBHBN
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static AIPMLCOLGIN NAJNDLJMKPM;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x46F56C0", Offset = "0x46F3EC0", VA = "0x1846F56C0")]
				public static PlayerLoopSystem DLBFOOLHACB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct KNDFPHJKMML
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static AIPMLCOLGIN HBPNHHCFPLI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x46F3290", Offset = "0x46F1A90", VA = "0x1846F3290")]
				public static PlayerLoopSystem DLBFOOLHACB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct EINLFEALCCD
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class LHJMOEGPGLD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public DDPLHCNHPAM.KEEHIHNJJKC key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
					public LHJMOEGPGLD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x46F3DC0", Offset = "0x46F25C0", VA = "0x1846F3DC0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable AJNLDGABAJI;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x46ECB50", Offset = "0x46EB350", VA = "0x1846ECB50")]
				public static PlayerLoopSystem IOHENCCEDAO(DDPLHCNHPAM.KEEHIHNJJKC MHAAPGJKGCK)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct JJCKGDFDGKO
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class KGJOLMALFOL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public DDPLHCNHPAM.KEEHIHNJJKC key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
					public KGJOLMALFOL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x46F31D0", Offset = "0x46F19D0", VA = "0x1846F31D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x46F1670", Offset = "0x46EFE70", VA = "0x1846F1670")]
				public static PlayerLoopSystem IOHENCCEDAO(DDPLHCNHPAM.KEEHIHNJJKC MHAAPGJKGCK)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EKPGIPKAANN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public EKPGIPKAANN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x46ECC70", Offset = "0x46EB470", VA = "0x1846ECC70")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool GMNDKEFIJAD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool BIMIDHKIOPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x46E97A0", Offset = "0x46E7FA0", VA = "0x1846E97A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x46E9AD0", Offset = "0x46E82D0", VA = "0x1846E9AD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46E8520", Offset = "0x46E6D20", VA = "0x1846E8520")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46E9900", Offset = "0x46E8100", VA = "0x1846E9900")]
		private static void HEFFEKPAMAC(DDPLHCNHPAM.KEEHIHNJJKC MHAAPGJKGCK, ref PlayerLoopSystem NOKCFDAGHFA, Type POODHFOCCCM, Type BFKMOGJNGHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x46E9B10", Offset = "0x46E8310", VA = "0x1846E9B10")]
		private static void PAHLINLPJGO(ref PlayerLoopSystem NOKCFDAGHFA, Type POODHFOCCCM, Type BFKMOGJNGHN, HLAIFFMHFMP KCLJBEFEPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46E97E0", Offset = "0x46E7FE0", VA = "0x1846E97E0")]
		private static void EGCDDCFACOD(ref PlayerLoopSystem NOKCFDAGHFA, Type POODHFOCCCM, Type BFKMOGJNGHN, PlayerLoopSystem? FIKJHNGNCJN, PlayerLoopSystem? KNADJBEAENO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DDPLHCNHPAM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum KEEHIHNJJKC
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
	public class COGGMGAJKNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KEEHIHNJJKC PAEKJMIKBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly LHIBAMBIPHC HLBFCOOKEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long CFKDEDOJHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long CDBCNHNIDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long PNFKEIFEFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int DDLKLFFAIJG;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46E7A50", Offset = "0x46E6250", VA = "0x1846E7A50")]
		public COGGMGAJKNN(KEEHIHNJJKC PLKCOCCDGBK, int BOLMEGDBMPH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x46E79C0", Offset = "0x46E61C0", VA = "0x1846E79C0")]
		public void OPJPLKDBDJC(int IBJOOOCKPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46E79E0", Offset = "0x46E61E0", VA = "0x1846E79E0")]
		public void PIEDNDMLPPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46E7790", Offset = "0x46E5F90", VA = "0x1846E7790")]
		public void FGCHPPDHAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46E77F0", Offset = "0x46E5FF0", VA = "0x1846E77F0")]
		public void MOOPPGLDFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46E76F0", Offset = "0x46E5EF0", VA = "0x1846E76F0")]
		public double BIPJKBGDHDN(int KCILLOHFMJB)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int PPMGGKKCBMO = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static KEEHIHNJJKC[] CIKAPLJFNAD;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static COGGMGAJKNN[] BPBLPADLICA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46E9F90", Offset = "0x46E8790", VA = "0x1846E9F90")]
	public static COGGMGAJKNN GOFCNPMKMJO(KEEHIHNJJKC MHAAPGJKGCK, int BOLMEGDBMPH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46EA1F0", Offset = "0x46E89F0", VA = "0x1846EA1F0")]
	public static COGGMGAJKNN LDADNOHCNKE(KEEHIHNJJKC MHAAPGJKGCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46EA140", Offset = "0x46E8940", VA = "0x1846EA140")]
	public static void JLGCHEGEMMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LHIBAMBIPHC : JONJIKKMPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int PANOCKDIBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> IKONJNPDGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double OFBJHBMBFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double BCHCMKEJPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double OMEKPGHCGMC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GCANPPNBDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46F3B10", Offset = "0x46F2310", VA = "0x1846F3B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double FIOJOCAEEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x46F3B50", Offset = "0x46F2350", VA = "0x1846F3B50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PLEDNHGPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDC43F0", Offset = "0xDC2BF0", VA = "0x180DC43F0", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MALJIJAGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x314C0E0", Offset = "0x314A8E0", VA = "0x18314C0E0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46F3D20", Offset = "0x46F2520", VA = "0x1846F3D20")]
	public LHIBAMBIPHC(int OFACOJCICPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46F3C20", Offset = "0x46F2420", VA = "0x1846F3C20", Slot = "4")]
	public void MKCKPPJGMBD(double OCHDAFFGFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46F3BB0", Offset = "0x46F23B0", VA = "0x1846F3BB0", Slot = "5")]
	public void HJODMEDLLNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BPBJKLEMHJC : JONJIKKMPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long KALABHLPPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double POPOEOIKEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double KLFIJNAJEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double MKICENEAOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double ILMFAOIJHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double OFBJHBMBFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double BCHCMKEJPMN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long MKFJBHDFMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double PLEDNHGPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x34E4C80", Offset = "0x34E3480", VA = "0x1834E4C80", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MALJIJAGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x94EBA0", Offset = "0x94D3A0", VA = "0x18094EBA0", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double LCHEBCCFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x314C0E0", Offset = "0x314A8E0", VA = "0x18314C0E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LLBNAFOELOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x314C0D0", Offset = "0x314A8D0", VA = "0x18314C0D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double FIOJOCAEEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x34E4BB0", Offset = "0x34E33B0", VA = "0x1834E4BB0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46E66A0", Offset = "0x46E4EA0", VA = "0x1846E66A0", Slot = "4")]
	public void MKCKPPJGMBD(double OCHDAFFGFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46E6660", Offset = "0x46E4E60", VA = "0x1846E6660", Slot = "5")]
	public void HJODMEDLLNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x46E67C0", Offset = "0x46E4FC0", VA = "0x1846E67C0")]
	public BPBJKLEMHJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JONJIKKMPIA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double FIOJOCAEEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double PLEDNHGPEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double MALJIJAGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKCKPPJGMBD(double OCHDAFFGFED);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJODMEDLLNE();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class MACGAGINOLM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface AAIOOECGAJB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool NKLMAMDAKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HOCHBDLCMIE();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PGMGHKEOCFG();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class LHBAABMAPNK<TPromise, TMainThreadPromise> : AAIOOECGAJB where TPromise : CDJPJKPGHKC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise MIBBPNJEGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise DJBPIAKLJMN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise NLLCNAIOCLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2698060", Offset = "0x2696860", VA = "0x182698060")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NKLMAMDAKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x26980F0", Offset = "0x26968F0", VA = "0x1826980F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1C0CBD0", Offset = "0x1C0B3D0", VA = "0x181C0CBD0")]
		protected LHBAABMAPNK(TPromise MIBBPNJEGJF, TMainThreadPromise IGDCEDLNKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x26980C0", Offset = "0x26968C0", VA = "0x1826980C0", Slot = "5")]
		public void HOCHBDLCMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x24C1730", Offset = "0x24BFF30", VA = "0x1824C1730", Slot = "6")]
		public void PGMGHKEOCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void JJNJCEBGHHC(TPromise MIBBPNJEGJF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void NBDKLJAMMDN();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class EGNCFGPJPIK<T> : LHBAABMAPNK<global::HBEENCCJBCB<T>, global::IFPNNBFIADD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2697630", Offset = "0x2695E30", VA = "0x182697630")]
		public EGNCFGPJPIK(global::HBEENCCJBCB<T> MIBBPNJEGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x26973D0", Offset = "0x2695BD0", VA = "0x1826973D0", Slot = "7")]
		protected override void JJNJCEBGHHC(global::HBEENCCJBCB<T> MIBBPNJEGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x26975D0", Offset = "0x2695DD0", VA = "0x1826975D0", Slot = "8")]
		protected override void NBDKLJAMMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x26973A0", Offset = "0x2695BA0", VA = "0x1826973A0")]
		[CompilerGenerated]
		private void JEFNIKOMMHC(T IAGHMNJKEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2697370", Offset = "0x2695B70", VA = "0x182697370")]
		[CompilerGenerated]
		private void AJKGOMDINBB(string CFMOADFJIJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class CMBNAMOCCFF : LHBAABMAPNK<CDJPJKPGHKC, EMAJIFEKEMH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x46E6A20", Offset = "0x46E5220", VA = "0x1846E6A20")]
		public CMBNAMOCCFF(CDJPJKPGHKC MIBBPNJEGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x46E6900", Offset = "0x46E5100", VA = "0x1846E6900", Slot = "7")]
		protected override void JJNJCEBGHHC(CDJPJKPGHKC MIBBPNJEGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x46E69D0", Offset = "0x46E51D0", VA = "0x1846E69D0", Slot = "8")]
		protected override void NBDKLJAMMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x11210E0", Offset = "0x111F8E0", VA = "0x1811210E0")]
		[CompilerGenerated]
		private void JEFNIKOMMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19589B0", Offset = "0x19571B0", VA = "0x1819589B0")]
		[CompilerGenerated]
		private void AJKGOMDINBB(string CFMOADFJIJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KMIOCJIKHMK : AAIOOECGAJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action BOJLOMGNIOM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NKLMAMDAKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x521FE0", Offset = "0x5207E0", VA = "0x180521FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x656320", Offset = "0x654B20", VA = "0x180656320")]
		public KMIOCJIKHMK(Action BOJLOMGNIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x102FCA0", Offset = "0x102E4A0", VA = "0x18102FCA0", Slot = "5")]
		public void HOCHBDLCMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "6")]
		public void PGMGHKEOCFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<AAIOOECGAJB> ALIBDFFFOAJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1CDDFF0", Offset = "0x1CDC7F0", VA = "0x181CDDFF0")]
	public static global::HBEENCCJBCB<T> ALFFHJLAEAE<T>(this global::HBEENCCJBCB<T> MIBBPNJEGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46F4460", Offset = "0x46F2C60", VA = "0x1846F4460")]
	public static CDJPJKPGHKC ALFFHJLAEAE(this CDJPJKPGHKC MIBBPNJEGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46F4570", Offset = "0x46F2D70", VA = "0x1846F4570")]
	public static void ALFFHJLAEAE(Action BOJLOMGNIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1CDE060", Offset = "0x1CDC860", VA = "0x181CDE060")]
	private static global::HBEENCCJBCB<T> CFJEKCLGLMC<T>(global::HBEENCCJBCB<T> MIBBPNJEGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46F46D0", Offset = "0x46F2ED0", VA = "0x1846F46D0")]
	private static CDJPJKPGHKC CFJEKCLGLMC(CDJPJKPGHKC MIBBPNJEGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46F4B80", Offset = "0x46F3380", VA = "0x1846F4B80")]
	private static void NCAOMOBBFMF(AAIOOECGAJB OBKKOAPPBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46F47B0", Offset = "0x46F2FB0", VA = "0x1846F47B0")]
	private static void IFEKJGHFAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46F4600", Offset = "0x46F2E00", VA = "0x1846F4600")]
	private static void ANNDCOAGJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46F4AD0", Offset = "0x46F32D0", VA = "0x1846F4AD0")]
	private static void JIAONFCDAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FOFLOPGILMF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AOOBLIIEKHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public EMAJIFEKEMH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public AOOBLIIEKHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46E5620", Offset = "0x46E3E20", VA = "0x1846E5620")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x46E5610", Offset = "0x46E3E10", VA = "0x1846E5610")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AENPMJFDPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public AENPMJFDPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x46E55A0", Offset = "0x46E3DA0", VA = "0x1846E55A0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class JKDEENHAELB : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public EMAJIFEKEMH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public JKDEENHAELB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x46F1AB0", Offset = "0x46F02B0", VA = "0x1846F1AB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46F1790", Offset = "0x46EFF90", VA = "0x1846F1790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x46F1B60", Offset = "0x46F0360", VA = "0x1846F1B60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A60", Offset = "0x46F0260", VA = "0x1846F1A60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FPIJLBKABCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EMAJIFEKEMH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public FPIJLBKABCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ICFFLDFPIHJ : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public EMAJIFEKEMH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private FPIJLBKABCC <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public ICFFLDFPIHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x46EE450", Offset = "0x46ECC50", VA = "0x1846EE450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x46EE7E0", Offset = "0x46ECFE0", VA = "0x1846EE7E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string HLJCEJPEBKM = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string BPIGOIHBADJ = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string HOMEILELOGJ = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string MBNGCMPMEFM = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string PJPANOHNEFP = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float OGENDPCPOFG = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static CDJPJKPGHKC BAJPAJFFCKA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation EOJBEHLPOME;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static CDJPJKPGHKC OGHHBFAEDBM;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string CDJPLPFDCID;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority IFFFCJADMMN;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool DHJJJLINGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x46EDA10", Offset = "0x46EC210", VA = "0x1846EDA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool EIDLCOHAJHH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x46EDD00", Offset = "0x46EC500", VA = "0x1846EDD00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool APDJBMDHPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x46EDB40", Offset = "0x46EC340", VA = "0x1846EDB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> NBEFOEBLFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x46EDBA0", Offset = "0x46EC3A0", VA = "0x1846EDBA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x46EDC50", Offset = "0x46EC450", VA = "0x1846EDC50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x46EDD60", Offset = "0x46EC560", VA = "0x1846EDD60")]
	[DIOLCMJEKCJ(DMCKANKCBMH.EnteredEditModeNextFrame, 0)]
	private static void KCLGJJOHBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x46EE0D0", Offset = "0x46EC8D0", VA = "0x1846EE0D0")]
	public static CDJPJKPGHKC PEEHKHOJBEP(string HCBOFDCJLOG, LoadSceneMode ACJFNIBEHJF = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x46EDEA0", Offset = "0x46EC6A0", VA = "0x1846EDEA0")]
	public static CDJPJKPGHKC OFHOPPLOFJA(string HCBOFDCJLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x46EDAB0", Offset = "0x46EC2B0", VA = "0x1846EDAB0")]
	[IteratorStateMachine(typeof(JKDEENHAELB))]
	private static IEnumerator<NJCBPLHFLJK> EJBEHPGDPNK(string HCBOFDCJLOG, EMAJIFEKEMH PDIMKPDGLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x46EDE10", Offset = "0x46EC610", VA = "0x1846EDE10")]
	[IteratorStateMachine(typeof(ICFFLDFPIHJ))]
	private static IEnumerator<NJCBPLHFLJK> MENHGLHGLFF(string HCBOFDCJLOG, LoadSceneMode ACJFNIBEHJF, EMAJIFEKEMH PDIMKPDGLHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class COGNKHAMFKF
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46E7C30", Offset = "0x46E6430", VA = "0x1846E7C30")]
	public static IDisposable BFLEDJNGBHK(this LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46E7CB0", Offset = "0x46E64B0", VA = "0x1846E7CB0")]
	public static IDisposable BFLEDJNGBHK(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46E8440", Offset = "0x46E6C40", VA = "0x1846E8440")]
	public static IDisposable PKLHLACLEGO(this LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x46E84B0", Offset = "0x46E6CB0", VA = "0x1846E84B0")]
	public static IDisposable PPBIANAAMIB(this LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x46E7B40", Offset = "0x46E6340", VA = "0x1846E7B40")]
	public static IDisposable AAGAPILJEKN(this LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x46E7F40", Offset = "0x46E6740", VA = "0x1846E7F40")]
	public static IDisposable GEDCIACOOAN(this LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x46E7E40", Offset = "0x46E6640", VA = "0x1846E7E40")]
	public static IDisposable DPKLHKPIKIG(this LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x46E7EB0", Offset = "0x46E66B0", VA = "0x1846E7EB0")]
	public static IDisposable EEMDEFDFLGJ(this LCOBOOAPANG DAABJFEBLJF, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x46E82C0", Offset = "0x46E6AC0", VA = "0x1846E82C0")]
	public static IDisposable PIEMAMINHKD(this LCOBOOAPANG DAABJFEBLJF, float ECJLPMGCNFN, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x46E8030", Offset = "0x46E6830", VA = "0x1846E8030")]
	public static IDisposable IAEFEHFAIML(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x46E80B0", Offset = "0x46E68B0", VA = "0x1846E80B0")]
	public static IDisposable IJMGHENPLHP(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46E7D30", Offset = "0x46E6530", VA = "0x1846E7D30")]
	public static IDisposable CFOEJBFKFIA(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46E7DB0", Offset = "0x46E65B0", VA = "0x1846E7DB0")]
	public static IDisposable CMLJLGBNLMK(this LCOBOOAPANG DAABJFEBLJF, float ECJLPMGCNFN, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x46E7FB0", Offset = "0x46E67B0", VA = "0x1846E7FB0")]
	public static IDisposable HLNMMPAHODB(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46E83C0", Offset = "0x46E6BC0", VA = "0x1846E83C0")]
	public static IDisposable PJBCLLKGLLI(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x46E8340", Offset = "0x46E6B40", VA = "0x1846E8340")]
	public static IDisposable PJBBCDJIGIG(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46E8130", Offset = "0x46E6930", VA = "0x1846E8130")]
	public static IDisposable KEKHELIINGD(this LCOBOOAPANG DAABJFEBLJF, float ECJLPMGCNFN, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x46E8240", Offset = "0x46E6A40", VA = "0x1846E8240")]
	public static IDisposable MNEJMKNBIJF(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46E81C0", Offset = "0x46E69C0", VA = "0x1846E81C0")]
	public static IDisposable LBNCBACFCAN(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x46E7BB0", Offset = "0x46E63B0", VA = "0x1846E7BB0")]
	public static IDisposable AMHPNHHAGOM(this LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CMOJMJOCHCE
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x46E7110", Offset = "0x46E5910", VA = "0x1846E7110")]
	public static IDisposable IHCJBJOLLFH(this MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x46E7190", Offset = "0x46E5990", VA = "0x1846E7190")]
	public static IDisposable IHCJBJOLLFH(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x46E6E50", Offset = "0x46E5650", VA = "0x1846E6E50")]
	public static IDisposable GNNANHCHACC(this MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46E6D50", Offset = "0x46E5550", VA = "0x1846E6D50")]
	public static IDisposable DBAHCIOJEAM(this MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x46E7680", Offset = "0x46E5E80", VA = "0x1846E7680")]
	public static IDisposable PHLKHGKPJAP(this MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x46E6B20", Offset = "0x46E5320", VA = "0x1846E6B20")]
	public static IDisposable AMCMFBCMJEF(this MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46E7210", Offset = "0x46E5A10", VA = "0x1846E7210")]
	public static IDisposable IKJPFCFEHAB(this MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46E74C0", Offset = "0x46E5CC0", VA = "0x1846E74C0")]
	public static IDisposable LHFMCDCGDGD(this MonoBehaviour MCEAFHOLIGH, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46E7430", Offset = "0x46E5C30", VA = "0x1846E7430")]
	public static IDisposable LFPLHAIBLOI(this MonoBehaviour MCEAFHOLIGH, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x46E6F60", Offset = "0x46E5760", VA = "0x1846E6F60")]
	public static IDisposable HKOAMAPJJAP(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x46E6B90", Offset = "0x46E5390", VA = "0x1846E6B90")]
	public static IDisposable BKKGIGDKICN(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x46E7080", Offset = "0x46E5880", VA = "0x1846E7080")]
	public static IDisposable IBDIOBEHDLL(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x46E6A90", Offset = "0x46E5290", VA = "0x1846E6A90")]
	public static IDisposable AHPMCEIIIFH(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46E7280", Offset = "0x46E5A80", VA = "0x1846E7280")]
	public static IDisposable JJFCCFINIDC(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46E7560", Offset = "0x46E5D60", VA = "0x1846E7560")]
	public static IDisposable PEJHABKDAIH(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46E6EC0", Offset = "0x46E56C0", VA = "0x1846E6EC0")]
	public static IDisposable HKKDGECBJBK(this MonoBehaviour MCEAFHOLIGH, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x46E6FF0", Offset = "0x46E57F0", VA = "0x1846E6FF0")]
	public static IDisposable HLEAFGJIAHD(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46E6DC0", Offset = "0x46E55C0", VA = "0x1846E6DC0")]
	public static IDisposable EIOJEINHLEC(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46E7310", Offset = "0x46E5B10", VA = "0x1846E7310")]
	public static IDisposable JOCDHOFCEMD(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46E6C20", Offset = "0x46E5420", VA = "0x1846E6C20")]
	public static IDisposable CBBAANLLDKJ(this MonoBehaviour MCEAFHOLIGH, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46E75F0", Offset = "0x46E5DF0", VA = "0x1846E75F0")]
	public static IDisposable PHGKBJCPFIE(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46E6CC0", Offset = "0x46E54C0", VA = "0x1846E6CC0")]
	public static IDisposable CNAPCCBGNLJ(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46E73A0", Offset = "0x46E5BA0", VA = "0x1846E73A0")]
	public static IDisposable KNPEPGHJAHE(this MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BGEHPOBNPAK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CFKFJLNOGHO : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public HNDAOKNLPII.AGGJBCFLNPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ILAIGOGHEFD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public CFKFJLNOGHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x46E67F0", Offset = "0x46E4FF0", VA = "0x1846E67F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x46E68B0", Offset = "0x46E50B0", VA = "0x1846E68B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class PCBDEAPDBHB : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public HNDAOKNLPII.AGGJBCFLNPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private ILAIGOGHEFD <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public PCBDEAPDBHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x46F5E90", Offset = "0x46F4690", VA = "0x1846F5E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x46F5F70", Offset = "0x46F4770", VA = "0x1846F5F70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46E6310", Offset = "0x46E4B10", VA = "0x1846E6310")]
	public static NJIHFLFDJJB IHCJBJOLLFH(Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46E6000", Offset = "0x46E4800", VA = "0x1846E6000")]
	public static NJIHFLFDJJB IHCJBJOLLFH(Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x46E6200", Offset = "0x46E4A00", VA = "0x1846E6200")]
	public static NJIHFLFDJJB IHCJBJOLLFH(Behaviour DAABJFEBLJF, Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46E60F0", Offset = "0x46E48F0", VA = "0x1846E60F0")]
	public static NJIHFLFDJJB IHCJBJOLLFH(Behaviour DAABJFEBLJF, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46E5EF0", Offset = "0x46E46F0", VA = "0x1846E5EF0")]
	public static NJIHFLFDJJB BFLEDJNGBHK(LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46E5DE0", Offset = "0x46E45E0", VA = "0x1846E5DE0")]
	public static NJIHFLFDJJB BFLEDJNGBHK(LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x46E6480", Offset = "0x46E4C80", VA = "0x1846E6480")]
	[IteratorStateMachine(typeof(CFKFJLNOGHO))]
	private static IEnumerator<NJCBPLHFLJK> PAJJKDKECGM(HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN, Action HEDLFFONPMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x46E6400", Offset = "0x46E4C00", VA = "0x1846E6400")]
	[IteratorStateMachine(typeof(PCBDEAPDBHB))]
	private static IEnumerator<NJCBPLHFLJK> PAJJKDKECGM(HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN, Action<float> HEDLFFONPMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class OENGNOHCCDO
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class BKCGHPBAHIA : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public HNDAOKNLPII.AGGJBCFLNPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KJONGNDOBAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public BKCGHPBAHIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x46E6500", Offset = "0x46E4D00", VA = "0x1846E6500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x46E6610", Offset = "0x46E4E10", VA = "0x1846E6610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46F5A50", Offset = "0x46F4250", VA = "0x1846F5A50")]
	public static NJIHFLFDJJB IHCJBJOLLFH(float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46F5990", Offset = "0x46F4190", VA = "0x1846F5990")]
	public static NJIHFLFDJJB IHCJBJOLLFH(MonoBehaviour MCEAFHOLIGH, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46F58D0", Offset = "0x46F40D0", VA = "0x1846F58D0")]
	public static NJIHFLFDJJB CEBEJKLGOLC(LCOBOOAPANG DAABJFEBLJF, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, bool GBMPIHNLMHA = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x46F5B10", Offset = "0x46F4310", VA = "0x1846F5B10")]
	[IteratorStateMachine(typeof(BKCGHPBAHIA))]
	private static IEnumerator<NJCBPLHFLJK> PAJJKDKECGM(float ECJLPMGCNFN, HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN, Action<float> HEDLFFONPMK, bool GBMPIHNLMHA = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EHPKEKHGIFO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DCFGKLFICGE : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HNDAOKNLPII.AGGJBCFLNPD queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public DCFGKLFICGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x46E9E90", Offset = "0x46E8690", VA = "0x1846E9E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x46E9F40", Offset = "0x46E8740", VA = "0x1846E9F40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x46ECAD0", Offset = "0x46EB2D0", VA = "0x1846ECAD0")]
	[IteratorStateMachine(typeof(DCFGKLFICGE))]
	private static IEnumerator<NJCBPLHFLJK> PEDCIDMGDOK(HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, Func<bool> GEPNAANOJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x46EC970", Offset = "0x46EB170", VA = "0x1846EC970")]
	public static NJIHFLFDJJB BDADJELDLGM(this MonoBehaviour MCEAFHOLIGH, Func<bool> GEPNAANOJMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG = HNDAOKNLPII.AGGJBCFLNPD.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ENNNIFDAGIE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JIINMNODPPJ : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HNDAOKNLPII.AGGJBCFLNPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public JIINMNODPPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x46F1560", Offset = "0x46EFD60", VA = "0x1846F1560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x46F1620", Offset = "0x46EFE20", VA = "0x1846F1620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class EPFNOMJBEFH : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public HNDAOKNLPII.AGGJBCFLNPD queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private NJCBPLHFLJK <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public EPFNOMJBEFH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x46ED8F0", Offset = "0x46EC0F0", VA = "0x1846ED8F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x46ED9C0", Offset = "0x46EC1C0", VA = "0x1846ED9C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x46ED2E0", Offset = "0x46EBAE0", VA = "0x1846ED2E0")]
	[IteratorStateMachine(typeof(JIINMNODPPJ))]
	private static IEnumerator<NJCBPLHFLJK> JHLFMMOLGCG(float CNEHNHENJMF, HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x46ED860", Offset = "0x46EC060", VA = "0x1846ED860")]
	[IteratorStateMachine(typeof(EPFNOMJBEFH))]
	private static IEnumerator<NJCBPLHFLJK> PLDBBOLPEKM(float CNEHNHENJMF, HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x46ED590", Offset = "0x46EBD90", VA = "0x1846ED590")]
	public static IDisposable LLOGNNBMDEB(this MonoBehaviour MCEAFHOLIGH, float CNEHNHENJMF, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x46ECE80", Offset = "0x46EB680", VA = "0x1846ECE80")]
	public static NJIHFLFDJJB CDMMPMENEMK(this MonoBehaviour MCEAFHOLIGH, float CNEHNHENJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x46ED6E0", Offset = "0x46EBEE0", VA = "0x1846ED6E0")]
	public static NJIHFLFDJJB LLOGNNBMDEB(this MonoBehaviour MCEAFHOLIGH, float CNEHNHENJMF, HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x46ECF90", Offset = "0x46EB790", VA = "0x1846ECF90")]
	public static NJIHFLFDJJB FBDBDGBAHGH(this MonoBehaviour MCEAFHOLIGH, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x46ED850", Offset = "0x46EC050", VA = "0x1846ED850")]
	public static NJIHFLFDJJB PDCBOGDAHBJ(this MonoBehaviour MCEAFHOLIGH, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x46ECF80", Offset = "0x46EB780", VA = "0x1846ECF80")]
	public static NJIHFLFDJJB DNNKEDBFCOC(this MonoBehaviour MCEAFHOLIGH, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x46ED840", Offset = "0x46EC040", VA = "0x1846ED840")]
	public static NJIHFLFDJJB OOINFNHBBFB(this MonoBehaviour MCEAFHOLIGH, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x46ED2D0", Offset = "0x46EBAD0", VA = "0x1846ED2D0")]
	public static NJIHFLFDJJB GICHOEAIHIK(this MonoBehaviour MCEAFHOLIGH, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x46ECFA0", Offset = "0x46EB7A0", VA = "0x1846ECFA0")]
	private static NJIHFLFDJJB FOAEAABDGLL(MonoBehaviour MCEAFHOLIGH, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x46ED370", Offset = "0x46EBB70", VA = "0x1846ED370")]
	public static NJIHFLFDJJB JNEMHLLOFMA(this MonoBehaviour MCEAFHOLIGH, float PAOIFHFEADI, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x46ECD70", Offset = "0x46EB570", VA = "0x1846ECD70")]
	public static NJIHFLFDJJB CBPFFIENGCH(this MonoBehaviour MCEAFHOLIGH, float PAOIFHFEADI, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x46ED1C0", Offset = "0x46EB9C0", VA = "0x1846ED1C0")]
	public static NJIHFLFDJJB GGDGAPHMACF(this MonoBehaviour MCEAFHOLIGH, float PAOIFHFEADI, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x46ED480", Offset = "0x46EBC80", VA = "0x1846ED480")]
	public static NJIHFLFDJJB KFHJIOCFMKE(this MonoBehaviour MCEAFHOLIGH, float PAOIFHFEADI, Action AKIDGDNKFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x46ED0B0", Offset = "0x46EB8B0", VA = "0x1846ED0B0")]
	public static NJIHFLFDJJB GCFNIFHLDFF(this MonoBehaviour MCEAFHOLIGH, float PAOIFHFEADI, Action AKIDGDNKFCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class DPKJJEDPKDM : JKINPBDAKOO
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class APMKLMBNELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DPKJJEDPKDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public APMKLMBNELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x46E5820", Offset = "0x46E4020", VA = "0x1846E5820")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FOHPABNOAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DPKJJEDPKDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
		public FOHPABNOAFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x46E5820", Offset = "0x46E4020", VA = "0x1846E5820")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float IKCCLHKCOFG;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x46EC910", Offset = "0x46EB110", VA = "0x1846EC910")]
	public DPKJJEDPKDM(Behaviour DAABJFEBLJF, float IKCCLHKCOFG, [Optional] Action DLCNPCOGEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x46EC750", Offset = "0x46EAF50", VA = "0x1846EC750", Slot = "9")]
	protected override bool CGOFPHPIICL(Action BOJLOMGNIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x46EC830", Offset = "0x46EB030", VA = "0x1846EC830", Slot = "10")]
	protected override bool ILMJJMJPJJM(Action BOJLOMGNIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KGCDEHIBDJH
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GKFODLBEHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DCIICFOEFNE;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PAIGHMDBBLA(bool NMOGGLCILMM = false);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PAIGHMDBBLA(Action BOJLOMGNIOM, bool NMOGGLCILMM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class JKINPBDAKOO : KGCDEHIBDJH
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ADADPGOBPJP : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public ADADPGOBPJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x46E54B0", Offset = "0x46E3CB0", VA = "0x1846E54B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x46E5550", Offset = "0x46E3D50", VA = "0x1846E5550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour DAABJFEBLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action DLCNPCOGEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private GFFCKECKPCB KEEPLKLBNEJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GKFODLBEHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x74CD00", Offset = "0x74B500", VA = "0x18074CD00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action DCIICFOEFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x46F1BD0", Offset = "0x46F03D0", VA = "0x1846F1BD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x46F1C70", Offset = "0x46F0470", VA = "0x1846F1C70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x46F20B0", Offset = "0x46F08B0", VA = "0x1846F20B0")]
	protected JKINPBDAKOO(Behaviour DAABJFEBLJF, [Optional] Action DLCNPCOGEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x46F2010", Offset = "0x46F0810", VA = "0x1846F2010", Slot = "7")]
	public bool PAIGHMDBBLA(bool NMOGGLCILMM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x46F1FC0", Offset = "0x46F07C0", VA = "0x1846F1FC0", Slot = "8")]
	public bool PAIGHMDBBLA(Action BOJLOMGNIOM, bool NMOGGLCILMM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CGOFPHPIICL(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool ILMJJMJPJJM(Action BOJLOMGNIOM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x46F1BB0", Offset = "0x46F03B0", VA = "0x1846F1BB0")]
	protected void CKCOGHCIOBE(Action BOJLOMGNIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x46F1D10", Offset = "0x46F0510", VA = "0x1846F1D10")]
	protected CDJPJKPGHKC FIABLCFEKNB(float BMLNLBGLLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x46F1EF0", Offset = "0x46F06F0", VA = "0x1846F1EF0")]
	private void GALAPCKCBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x46F1F60", Offset = "0x46F0760", VA = "0x1846F1F60")]
	[IteratorStateMachine(typeof(ADADPGOBPJP))]
	private static IEnumerator<NJCBPLHFLJK> JEJNONJMCEC(float BMLNLBGLLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x46F2070", Offset = "0x46F0870", VA = "0x1846F2070")]
	[CompilerGenerated]
	private void PPDHPPMFPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JOAAICOEPCF : JKINPBDAKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float JIKHFKCANJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int HEIIJDBMCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float IBCJBDANBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] FHFHJLLPBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int FNOCJPOEBAJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AAMKJAPMPEC HCIGJIEHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x549A30", Offset = "0x548230", VA = "0x180549A30")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x659540", Offset = "0x657D40", VA = "0x180659540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x46F23B0", Offset = "0x46F0BB0", VA = "0x1846F23B0")]
	public JOAAICOEPCF(Behaviour DAABJFEBLJF, float FDFBHNNINCB, int HEIIJDBMCGN, [Optional] Action DLCNPCOGEEH, float IBCJBDANBPK = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x521EC0", Offset = "0x5206C0", VA = "0x180521EC0", Slot = "9")]
	protected override bool CGOFPHPIICL(Action BOJLOMGNIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x46F2190", Offset = "0x46F0990", VA = "0x1846F2190", Slot = "10")]
	protected override bool ILMJJMJPJJM(Action BOJLOMGNIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x46F2100", Offset = "0x46F0900", VA = "0x1846F2100")]
	private void CDOOEKJEKHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OFBBLOKNGBN : JKINPBDAKOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float IKCCLHKCOFG;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x46EC910", Offset = "0x46EB110", VA = "0x1846EC910")]
	public OFBBLOKNGBN(Behaviour DAABJFEBLJF, float IKCCLHKCOFG, [Optional] Action DLCNPCOGEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x521EC0", Offset = "0x5206C0", VA = "0x180521EC0", Slot = "9")]
	protected override bool CGOFPHPIICL(Action BOJLOMGNIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x46F5BB0", Offset = "0x46F43B0", VA = "0x1846F5BB0", Slot = "10")]
	protected override bool ILMJJMJPJJM(Action BOJLOMGNIOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class KDHCAKICBEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class NGAMEEFAEIA : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public NGAMEEFAEIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x46F5570", Offset = "0x46F3D70", VA = "0x1846F5570", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x46F5670", Offset = "0x46F3E70", VA = "0x1846F5670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NJIHFLFDJJB LGCCKIIFOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private LCOBOOAPANG DAABJFEBLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action HEDLFFONPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> LKLEGLIEDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float HKLFCBKJGDD;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x46F3010", Offset = "0x46F1810", VA = "0x1846F3010")]
	public KDHCAKICBEC(LCOBOOAPANG DAABJFEBLJF, Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x46F2E50", Offset = "0x46F1650", VA = "0x1846F2E50")]
	public KDHCAKICBEC(LCOBOOAPANG DAABJFEBLJF, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x46F2CD0", Offset = "0x46F14D0", VA = "0x1846F2CD0")]
	public KDHCAKICBEC(LCOBOOAPANG DAABJFEBLJF, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x46F25C0", Offset = "0x46F0DC0", VA = "0x1846F25C0")]
	private void IHCJBJOLLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x46F27D0", Offset = "0x46F0FD0", VA = "0x1846F27D0")]
	private void JCLJPDKLDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x46F2B80", Offset = "0x46F1380", VA = "0x1846F2B80")]
	private void POMBBDEODHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x46F2960", Offset = "0x46F1160", VA = "0x1846F2960")]
	private void MLGKJJIHFDO(string CFMOADFJIJP, Action DHDEDLKMJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x46F2B10", Offset = "0x46F1310", VA = "0x1846F2B10")]
	[IteratorStateMachine(typeof(NGAMEEFAEIA))]
	private IEnumerator<NJCBPLHFLJK> ONPJKCOECAB(Action DHDEDLKMJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x46F2560", Offset = "0x46F0D60", VA = "0x1846F2560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x46F2750", Offset = "0x46F0F50", VA = "0x1846F2750")]
	[CompilerGenerated]
	private void JBIPDMABALA(string NAAPPGENNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x46F2A90", Offset = "0x46F1290", VA = "0x1846F2A90")]
	[CompilerGenerated]
	private void OCDPDDKBMAP(string NAAPPGENNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x46F24E0", Offset = "0x46F0CE0", VA = "0x1846F24E0")]
	[CompilerGenerated]
	private void CNPBFLHEKIL(string NAAPPGENNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class JGPCLKMCEKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MOCELICENFE : IEnumerator<NJCBPLHFLJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NJCBPLHFLJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private NJCBPLHFLJK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
		[DebuggerHidden]
		public MOCELICENFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x46F5420", Offset = "0x46F3C20", VA = "0x1846F5420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x46F5520", Offset = "0x46F3D20", VA = "0x1846F5520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NJIHFLFDJJB LGCCKIIFOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour MCEAFHOLIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action HEDLFFONPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> LKLEGLIEDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float HKLFCBKJGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool GBMPIHNLMHA;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x46F13A0", Offset = "0x46EFBA0", VA = "0x1846F13A0")]
	public JGPCLKMCEKJ(MonoBehaviour MCEAFHOLIGH, Action HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x46F1040", Offset = "0x46EF840", VA = "0x1846F1040")]
	public JGPCLKMCEKJ(MonoBehaviour MCEAFHOLIGH, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x46F1200", Offset = "0x46EFA00", VA = "0x1846F1200")]
	public JGPCLKMCEKJ(MonoBehaviour MCEAFHOLIGH, float ECJLPMGCNFN, Action<float> HEDLFFONPMK, HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG, bool GBMPIHNLMHA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x46F09B0", Offset = "0x46EF1B0", VA = "0x1846F09B0")]
	private void IHCJBJOLLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x46F0B40", Offset = "0x46EF340", VA = "0x1846F0B40")]
	private void JCLJPDKLDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x46F0EF0", Offset = "0x46EF6F0", VA = "0x1846F0EF0")]
	private void POMBBDEODHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x46F0D50", Offset = "0x46EF550", VA = "0x1846F0D50")]
	private void MLGKJJIHFDO(string CFMOADFJIJP, Action DHDEDLKMJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x46F0E80", Offset = "0x46EF680", VA = "0x1846F0E80")]
	[IteratorStateMachine(typeof(MOCELICENFE))]
	private IEnumerator<NJCBPLHFLJK> ONPJKCOECAB(Action DHDEDLKMJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x46F08D0", Offset = "0x46EF0D0", VA = "0x1846F08D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x46F0CD0", Offset = "0x46EF4D0", VA = "0x1846F0CD0")]
	[CompilerGenerated]
	private void KBLBKHOBNCD(string NAAPPGENNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x46F0850", Offset = "0x46EF050", VA = "0x1846F0850")]
	[CompilerGenerated]
	private void DLIJPOEAHKO(string NAAPPGENNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x46F0930", Offset = "0x46EF130", VA = "0x1846F0930")]
	[CompilerGenerated]
	private void IECMFNILMAL(string NAAPPGENNFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface HIHCLJPMLIC
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int ICFFKCCKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IJAOMIGCLLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly IJAOMIGCLLI PCPIMEGKCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action HPOOOCNCJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool NCNAFNHDFJF;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x656320", Offset = "0x654B20", VA = "0x180656320")]
	public IJAOMIGCLLI(Action HPOOOCNCJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x46EE830", Offset = "0x46ED030", VA = "0x1846EE830", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FCABFIMLJLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T MPJDHKAGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable ANEDGNKNMNE(Action<T> CDLFKAFADEG);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable ANEDGNKNMNE(UnityEngine.Object DAABJFEBLJF, Action<T> CDLFKAFADEG);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MNPIIOOOHOD<T> : global::FCABFIMLJLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T MPJDHKAGMAD
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
public class PMMIJDLBKMK<T> : global::MNPIIOOOHOD<T>, global::FCABFIMLJLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FKNLKJLOCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::PMMIJDLBKMK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::NEFPBMJPAEA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C10", Offset = "0x1AF6410", VA = "0x181AF7C10")]
		public FKNLKJLOCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C6C860", Offset = "0x3C6B060", VA = "0x183C6C860")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject ODICLGHHCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::NEFPBMJPAEA<UnityEngine.Object, Action<T>>> GNEAADODIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T NFAGAFODEKE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object KFJKLCAFGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7B730", Offset = "0x3C79F30", VA = "0x183C7B730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T MPJDHKAGMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x64FBA0", Offset = "0x64E3A0", VA = "0x18064FBA0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BAC0", Offset = "0x3C7A2C0", VA = "0x183C7BAC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3C7B940", Offset = "0x3C7A140", VA = "0x183C7B940")]
	private static bool DGPOHNBHNPM(T DIDMABCLHLL, T DOMNMKJGGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x341ACB0", Offset = "0x34194B0", VA = "0x18341ACB0")]
	public PMMIJDLBKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3C7C220", Offset = "0x3C7AA20", VA = "0x183C7C220")]
	public PMMIJDLBKMK(T LMCGPBCHDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3C7BA20", Offset = "0x3C7A220", VA = "0x183C7BA20")]
	public void IGDFMGKMPCB(T ANNHMLONOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3C7B4B0", Offset = "0x3C79CB0", VA = "0x183C7B4B0", Slot = "7")]
	public IDisposable ANEDGNKNMNE(Action<T> CDLFKAFADEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3C7B1F0", Offset = "0x3C799F0", VA = "0x183C7B1F0", Slot = "8")]
	public IDisposable ANEDGNKNMNE(UnityEngine.Object DAABJFEBLJF, Action<T> CDLFKAFADEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3C7BE50", Offset = "0x3C7A650", VA = "0x183C7BE50")]
	private void NMHKGPCNGKH()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<EBNLIKPOLIJ, Scheduler>, EBNLIKPOLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class IPAFDNILIOL : HIHCLJPMLIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public DKECCCHPEIF AGMNNLDHKFF;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int ICFFKCCKJCC
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x521ED0", Offset = "0x5206D0", VA = "0x180521ED0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x521EE0", Offset = "0x5206E0", VA = "0x180521EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x46F02A0", Offset = "0x46EEAA0", VA = "0x1846F02A0")]
			public static NJCBPLHFLJK GFJFIGCJGDG(IEnumerator<NJCBPLHFLJK> NBLBEJBMEPM, IMKENBLOCDP LAPKAMHCPGL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x46F0400", Offset = "0x46EEC00", VA = "0x1846F0400")]
			public NJCBPLHFLJK GFJFIGCJGDG(IMKENBLOCDP[] OGBFDPIAOPB, IEnumerator<NJCBPLHFLJK>[] EFLLHHAENDM, NJCBPLHFLJK[] DBLIAOPJDIN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x46F0270", Offset = "0x46EEA70", VA = "0x1846F0270")]
			public void BLOEFCBLMAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x46F05B0", Offset = "0x46EEDB0", VA = "0x1846F05B0")]
			public void LLLLDJKMOFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x46F04E0", Offset = "0x46EECE0", VA = "0x1846F04E0")]
			public void IBABAHCCENM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x46F0270", Offset = "0x46EEA70", VA = "0x1846F0270")]
			public void PGMGHKEOCFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public IPAFDNILIOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class DKECCCHPEIF
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct IPNLKMDODKE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public IPAFDNILIOL PJKMGBNDIFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public LCOBOOAPANG KFOMHAJNEBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public IMKENBLOCDP KCELLIAEHKB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<NJCBPLHFLJK> ENLKJDOEMAC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public NJCBPLHFLJK NMBINCOBBDJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public KBDEPFFBLKH KNNIOHFNMKM;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct BKPOLBDKPJJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public HNDAOKNLPII.AGGJBCFLNPD BIJNNCKMGMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<IPNLKMDODKE> KKGPBIOMBLH;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class LHCCLBCBHPO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public DKECCCHPEIF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public LCOBOOAPANG context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public IPAFDNILIOL routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public KBDEPFFBLKH coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public IMKENBLOCDP promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public NJCBPLHFLJK currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<NJCBPLHFLJK> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
				public LHCCLBCBHPO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x46F3460", Offset = "0x46F1C60", VA = "0x1846F3460")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class ODHPKMGHPFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public IPAFDNILIOL schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public DKECCCHPEIF <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
				public ODHPKMGHPFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x46F5890", Offset = "0x46F4090", VA = "0x1846F5890")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class GIMGDJMLDHJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public IPAFDNILIOL schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public DKECCCHPEIF <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
				public GIMGDJMLDHJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x46EE380", Offset = "0x46ECB80", VA = "0x1846EE380")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class AGDDMOHIDBN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public IPAFDNILIOL schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public DKECCCHPEIF <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
				public AGDDMOHIDBN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x46E55D0", Offset = "0x46E3DD0", VA = "0x1846E55D0")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] GBEDDCEHMFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<KBDEPFFBLKH> BGFLFAAPHBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> DFPFKBLNIEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> HNKAOEHADNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> IBKFNMGOLCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> GLCHOINOMOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> NNEHMPKPAOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> MDCHMGNNCJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private IPAFDNILIOL[] OFCOJHNPBPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private IMKENBLOCDP[] OGBFDPIAOPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private LCOBOOAPANG[] KBJLKIGKDMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<NJCBPLHFLJK>[] BGDKCNMGJJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private NJCBPLHFLJK[] GJPMAIPHBED;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int NCIJDEAOJIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int PODLECMNECF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int LFKHNEAANLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float GPCPNKPLCNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private BCKAFBANFLE MNFDLEFMLLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle HJAKEKNKPAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<IPAFDNILIOL> BLBJHPNCFLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool ECHCKEFGJGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> PKAPPBLBKGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> OFGHMFHMOLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool JECHHPANCIB;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public BKPOLBDKPJJ[] ACJDMMJKPPL
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x8AD1F0", Offset = "0x8AB9F0", VA = "0x1808AD1F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int CNCFPELJAKC
			{
				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0xAEC9E0", Offset = "0xAEB1E0", VA = "0x180AEC9E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x46EBC40", Offset = "0x46EA440", VA = "0x1846EBC40")]
			private static int MJNGIKEMEOJ(HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x46EC200", Offset = "0x46EAA00", VA = "0x1846EC200")]
			public DKECCCHPEIF(HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x46EB9F0", Offset = "0x46EA1F0", VA = "0x1846EB9F0")]
			private void JHJCJNPIGPK(ref int JGLFHDMFCDP, int MLJBIPHACFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x46EBFE0", Offset = "0x46EA7E0", VA = "0x1846EBFE0")]
			public void OJMHECIGNMA(LCOBOOAPANG DAABJFEBLJF, NJCBPLHFLJK PMGGKCBCHCJ, IEnumerator<NJCBPLHFLJK> NBLBEJBMEPM, IMKENBLOCDP LAPKAMHCPGL, [Optional] IPAFDNILIOL CMIHLAMCPAK, KBDEPFFBLKH BEMFPNDAKNC = KBDEPFFBLKH.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x46EAA10", Offset = "0x46E9210", VA = "0x1846EAA10")]
			public void ANMOEFFKGCJ(IEnumerable<IPNLKMDODKE> FHKLPNPFLMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x46EAED0", Offset = "0x46E96D0", VA = "0x1846EAED0")]
			private IPNLKMDODKE EAMMCFMJFFE(int GBMPMHDEFGO)
			{
				return default(IPNLKMDODKE);
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x46EBC70", Offset = "0x46EA470", VA = "0x1846EBC70")]
			private void OCDDGDFAPNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x1B875C0", Offset = "0x1B85DC0", VA = "0x181B875C0")]
			private static void OPPBNHNIMOL<T>(int GBMPMHDEFGO, T[] PIIPBLCJBMD, int LGIEDJBGIJJ, [Optional] T JKCIGOMFGGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1B875A0", Offset = "0x1B85DA0", VA = "0x181B875A0")]
			private static void OPPBNHNIMOL<T>(int GBMPMHDEFGO, NativeArray<T> PIIPBLCJBMD, int LGIEDJBGIJJ, [Optional] T JKCIGOMFGGP) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x46EB490", Offset = "0x46E9C90", VA = "0x1846EB490")]
			private void FPHBBILCLPH(IEnumerable<IPNLKMDODKE> FHKLPNPFLMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x46EB3D0", Offset = "0x46E9BD0", VA = "0x1846EB3D0")]
			private void EILMNLBKOFM(IPNLKMDODKE BBEKMCFDPHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x46EB730", Offset = "0x46E9F30", VA = "0x1846EB730")]
			private JCDKGNJNEEJ IGGDLNGFJIE(int JAPJFKODBBM)
			{
				return default(JCDKGNJNEEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x46EACE0", Offset = "0x46E94E0", VA = "0x1846EACE0")]
			public void BOLEJIJMCKM(float KDFHECPHEII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x46EB350", Offset = "0x46E9B50", VA = "0x1846EB350")]
			private void EDFDLHAGFMO(Action DIDMABCLHLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x46EA430", Offset = "0x46E8C30", VA = "0x1846EA430")]
			private void AANNPNOPBGA(Action DIDMABCLHLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x46EA570", Offset = "0x46E8D70", VA = "0x1846EA570")]
			public void AJMEONOJHCD(float KDFHECPHEII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x46EAC00", Offset = "0x46E9400", VA = "0x1846EAC00")]
			public void BMLOFNJHHAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x46EC140", Offset = "0x46EA940", VA = "0x1846EC140")]
			public void PGMGHKEOCFG(IPAFDNILIOL IDCFOKBBNOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x46EBB80", Offset = "0x46EA380", VA = "0x1846EBB80")]
			public void LEIIBFLOOGJ(IPAFDNILIOL IDCFOKBBNOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x46EA4B0", Offset = "0x46E8CB0", VA = "0x1846EA4B0")]
			public void ADBMBGAKEFO(IPAFDNILIOL IDCFOKBBNOC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct BCKAFBANFLE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float HGDCACEDKDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int KAKCFEEFJNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> HEOIHIIDANE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> EHPBDHKLHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> MLBNABJDEPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<KBDEPFFBLKH> LAOICEELEAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> GCCFFNDMKBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> GLCHOINOMOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> HNKAOEHADNB;

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x46E5CA0", Offset = "0x46E44A0", VA = "0x1846E5CA0")]
			public static BCKAFBANFLE OGMFEGPOBPM(int GCFCDMHEJNG, float KDFHECPHEII, NativeArray<KBDEPFFBLKH> MIFDDPEOGMF, NativeArray<float> HJFBABOCICN, NativeArray<int> HNFAABNOFLF, NativeArray<int> HPCKBMMEJGD, NativeArray<int> CCHDCMPAGLD, NativeArray<int> EHPBDHKLHCE, NativeArray<int> MLBNABJDEPC)
			{
				return default(BCKAFBANFLE);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x46E5920", Offset = "0x46E4120", VA = "0x1846E5920", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x46E5C30", Offset = "0x46E4430", VA = "0x1846E5C30")]
			private bool IFNPCHMOOBH(int MPFAEFMOAIE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x46E5C70", Offset = "0x46E4470", VA = "0x1846E5C70")]
			private void KBCAJONEBHC(NativeArray<int> PPBBLBKGLGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x46E5D70", Offset = "0x46E4570", VA = "0x1846E5D70")]
			private int OOKIICDGLFJ(int JJCPNJCPNCF, int EPPNCHDELDG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x46E5850", Offset = "0x46E4050", VA = "0x1846E5850")]
			private void BKGGNMLNPMN(NativeArray<int> PPBBLBKGLGI, int POIDOFMGPKF, int IPJJEOOGIAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x46E5A00", Offset = "0x46E4200", VA = "0x1846E5A00")]
			private void FLJGDJPHDNJ(NativeArray<int> PPBBLBKGLGI, int JENDHNLMEJM, int PNIBCPPNOPG, int PLFNNLOFJJB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class MAIHKBBOLFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly IMKENBLOCDP LAPKAMHCPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour DAABJFEBLJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool ILMOEANBPGK;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<NJCBPLHFLJK> ENLKJDOEMAC
			{
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x5211D0", Offset = "0x51F9D0", VA = "0x1805211D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x521490", Offset = "0x51FC90", VA = "0x180521490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public NJCBPLHFLJK NMBINCOBBDJ
			{
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x5214A0", Offset = "0x51FCA0", VA = "0x1805214A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool EKACJNDEHNB
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x46F5070", Offset = "0x46F3870", VA = "0x1846F5070")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool IDDJDELIMAC
			{
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x7BDC00", Offset = "0x7BC400", VA = "0x1807BDC00")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x1459F30", Offset = "0x1458730", VA = "0x181459F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string KMPNNCBDBPK
			{
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x522010", Offset = "0x520810", VA = "0x180522010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x522020", Offset = "0x520820", VA = "0x180522020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float MCGLIJGAGPC
			{
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x1056D40", Offset = "0x1055540", VA = "0x181056D40")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x105E5E0", Offset = "0x105CDE0", VA = "0x18105E5E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x46F5220", Offset = "0x46F3A20", VA = "0x1846F5220")]
			public MAIHKBBOLFM(IEnumerator<NJCBPLHFLJK> NBLBEJBMEPM, Behaviour DAABJFEBLJF, IMKENBLOCDP LAPKAMHCPGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x46F4E60", Offset = "0x46F3660", VA = "0x1846F4E60")]
			public NJCBPLHFLJK GFJFIGCJGDG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x46F4DD0", Offset = "0x46F35D0", VA = "0x1846F4DD0")]
			public bool CHLGJKIDKNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x46F5100", Offset = "0x46F3900", VA = "0x1846F5100")]
			public void PGMGHKEOCFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x46F5190", Offset = "0x46F3990", VA = "0x1846F5190", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x1317A60", Offset = "0x1316260", VA = "0x181317A60")]
			[CompilerGenerated]
			private void IHLBCGHNFKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class IMKENBLOCDP : CCNEAMFBBPN, NJIHFLFDJJB, GFFCKECKPCB, CDJPJKPGHKC, IEnumerator, NJCBPLHFLJK, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private HNDAOKNLPII.AGGJBCFLNPD ODABEAKCDNE;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private HNDAOKNLPII.AGGJBCFLNPD IOBIADELEGM
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x546180", Offset = "0x544980", VA = "0x180546180", Slot = "23")]
				get
				{
					return default(HNDAOKNLPII.AGGJBCFLNPD);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public HNDAOKNLPII.AGGJBCFLNPD AGMNNLDHKFF
			{
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x546180", Offset = "0x544980", VA = "0x180546180")]
				get
				{
					return default(HNDAOKNLPII.AGGJBCFLNPD);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x6BC1C0", Offset = "0x6BA9C0", VA = "0x1806BC1C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float OAABJGFKBPF
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0xDC69B0", Offset = "0xDC51B0", VA = "0x180DC69B0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x46EE940", Offset = "0x46ED140", VA = "0x1846EE940", Slot = "24")]
			private bool KIEGJFGABBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x46EE930", Offset = "0x46ED130", VA = "0x1846EE930", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x46EE960", Offset = "0x46ED160", VA = "0x1846EE960")]
			public IMKENBLOCDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum JCDKGNJNEEJ : byte
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
		private sealed class IOFFAIFKPPC : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum EGLCOJCCKIL
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct PKOLALHPAPP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public HNDAOKNLPII.AGGJBCFLNPD BIJNNCKMGMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public EGLCOJCCKIL FAOJGILLEIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<MAIHKBBOLFM> OHHNFBOINKP;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly EGLCOJCCKIL[] GLFCNKNFBDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly HNDAOKNLPII.AGGJBCFLNPD JILGGLHEKFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool MMGJPIKLFKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly MAIHKBBOLFM[] LFKFNJPOAEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<MAIHKBBOLFM> DPDLKKIDFJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> BJHGPOCMFLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<MAIHKBBOLFM> CKODKFCCLND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> OPFOPIBCOJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool JECHHPANCIB;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public PKOLALHPAPP[,] CIJFNABOGHI
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x534D70", Offset = "0x533570", VA = "0x180534D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int CNCFPELJAKC
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x46EF0A0", Offset = "0x46ED8A0", VA = "0x1846EF0A0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x46EFE20", Offset = "0x46EE620", VA = "0x1846EFE20")]
			public IOFFAIFKPPC(HNDAOKNLPII.AGGJBCFLNPD FEPFGCKEPEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x46EFAE0", Offset = "0x46EE2E0", VA = "0x1846EFAE0")]
			public void LNDHEJIDDCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x46EF980", Offset = "0x46EE180", VA = "0x1846EF980")]
			public void LDABPLAHDBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x46EFC10", Offset = "0x46EE410", VA = "0x1846EFC10")]
			private void OJODNLADHDL(IReadOnlyList<MAIHKBBOLFM> FNGOOKJDBII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x46EFAF0", Offset = "0x46EE2F0", VA = "0x1846EFAF0")]
			public void NAHAJBLOFKE(MAIHKBBOLFM NBLBEJBMEPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x46EEBC0", Offset = "0x46ED3C0", VA = "0x1846EEBC0")]
			public void DLKOKJNNANP(IList<MAIHKBBOLFM> EFLLHHAENDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x46EF210", Offset = "0x46EDA10", VA = "0x1846EF210")]
			public void GLHMLDPOFHC(IList<MAIHKBBOLFM> EFLLHHAENDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x46EF890", Offset = "0x46EE090", VA = "0x1846EF890")]
			private void IMFNACALJLG(MAIHKBBOLFM NBLBEJBMEPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x46EF720", Offset = "0x46EDF20", VA = "0x1846EF720")]
			private void IEMGKDNDMPP(IList<MAIHKBBOLFM> EFLLHHAENDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x46EF990", Offset = "0x46EE190", VA = "0x1846EF990")]
			private JCDKGNJNEEJ LGKPNHHMNIM(MAIHKBBOLFM NBLBEJBMEPM)
			{
				return default(JCDKGNJNEEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x46EF490", Offset = "0x46EDC90", VA = "0x1846EF490")]
			public void GNNANHCHACC(float KDFHECPHEII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x46EE9C0", Offset = "0x46ED1C0", VA = "0x1846EE9C0")]
			public void AFKJPKMIHIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x46EF540", Offset = "0x46EDD40", VA = "0x1846EF540")]
			private void HDKOODPNPDC(List<MAIHKBBOLFM> EFLLHHAENDM, Stack<int> EDLOMGFMJOL, bool BHJKBMPEHHH, float GNNMBGMNGED = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x46EEE40", Offset = "0x46ED640", VA = "0x1846EEE40", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x46EEF80", Offset = "0x46ED780", VA = "0x1846EEF80")]
			private void ECGCEKAAGDN(List<MAIHKBBOLFM> EFLLHHAENDM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum KBDEPFFBLKH : byte
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
		private sealed class OLDOEALEHAO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5211C0", Offset = "0x51F9C0", VA = "0x1805211C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x6327D0", Offset = "0x630FD0", VA = "0x1806327D0")]
			[DebuggerHidden]
			public OLDOEALEHAO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x46F5DC0", Offset = "0x46F45C0", VA = "0x1846F5DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x46F5E40", Offset = "0x46F4640", VA = "0x1846F5E40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const KBDEPFFBLKH JBNGLHDKFHM = KBDEPFFBLKH.Cancelled | KBDEPFFBLKH.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly HNDAOKNLPII.AGGJBCFLNPD[] CELNIDHEFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private IOFFAIFKPPC[] IJJDEPCFOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DKECCCHPEIF[] CDCCJNGIDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine JJJCCFKCJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame EBAFHEEFJKG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public HNDAOKNLPII.AGGJBCFLNPD ABPFHINBOIO
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5AD670", Offset = "0x5ABE70", VA = "0x1805AD670")]
			[CompilerGenerated]
			get
			{
				return default(HNDAOKNLPII.AGGJBCFLNPD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x6735D0", Offset = "0x671DD0", VA = "0x1806735D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool HIKJNCAOHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7BD900", Offset = "0x7BC100", VA = "0x1807BD900", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x1E9C9D0", Offset = "0x1E9B1D0", VA = "0x181E9C9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int CNCFPELJAKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x46F78F0", Offset = "0x46F60F0", VA = "0x1846F78F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x46F67C0", Offset = "0x46F4FC0", VA = "0x1846F67C0")]
		public static NJIHFLFDJJB GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x46F5FC0", Offset = "0x46F47C0", VA = "0x1846F5FC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x46F68D0", Offset = "0x46F50D0", VA = "0x1846F68D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x46F6860", Offset = "0x46F5060", VA = "0x1846F6860")]
		private IOFFAIFKPPC HPHFDMMLAJI(HNDAOKNLPII.AGGJBCFLNPD MIDEMNGPEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8F3030", Offset = "0x8F1830", VA = "0x1808F3030")]
		private DKECCCHPEIF OMMDDJAMFHF(HNDAOKNLPII.AGGJBCFLNPD MIDEMNGPEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x46F6D90", Offset = "0x46F5590", VA = "0x1846F6D90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x46F6D50", Offset = "0x46F5550", VA = "0x1846F6D50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x46F76C0", Offset = "0x46F5EC0", VA = "0x1846F76C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x46F67B0", Offset = "0x46F4FB0", VA = "0x1846F67B0")]
		private void GGMJGKGPLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x46F68A0", Offset = "0x46F50A0", VA = "0x1846F68A0")]
		private void KGPFBNEJCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x46F67A0", Offset = "0x46F4FA0", VA = "0x1846F67A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x46F68B0", Offset = "0x46F50B0", VA = "0x1846F68B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x46F68C0", Offset = "0x46F50C0", VA = "0x1846F68C0")]
		private void NAJNDLJMKPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x46F6E10", Offset = "0x46F5610", VA = "0x1846F6E10")]
		[IteratorStateMachine(typeof(OLDOEALEHAO))]
		private IEnumerator PKEIKJDINHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x46F6FB0", Offset = "0x46F57B0", VA = "0x1846F6FB0", Slot = "7")]
		public NJIHFLFDJJB Run(IEnumerator<NJCBPLHFLJK> LOAPGNKLBLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x46F6FC0", Offset = "0x46F57C0", VA = "0x1846F6FC0", Slot = "8")]
		public NJIHFLFDJJB Run(Behaviour DAABJFEBLJF, IEnumerator<NJCBPLHFLJK> LOAPGNKLBLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x46F6E80", Offset = "0x46F5680", VA = "0x1846F6E80", Slot = "9")]
		public NJIHFLFDJJB RunJobbed(LCOBOOAPANG DAABJFEBLJF, IEnumerator<NJCBPLHFLJK> LOAPGNKLBLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x46F6620", Offset = "0x46F4E20", VA = "0x1846F6620", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x46F71F0", Offset = "0x46F59F0", VA = "0x1846F71F0")]
		public void UpdateQueue(HNDAOKNLPII.AGGJBCFLNPD GFCCNEAJKIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x46F6460", Offset = "0x46F4C60", VA = "0x1846F6460")]
		private void BGNGIEJKOCF(IOFFAIFKPPC CHCJHJBKJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x46F6680", Offset = "0x46F4E80", VA = "0x1846F6680")]
		private void FFNNLJIAGHG(DKECCCHPEIF CHCJHJBKJKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x46F7880", Offset = "0x46F6080", VA = "0x1846F7880")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class DIAJIPBBCCB
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x46EA3A0", Offset = "0x46E8BA0", VA = "0x1846EA3A0")]
	[GHGHOICNHGA]
	private static void LHPLLNMCLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class MEKCOIDNMII : AAMKJAPMPEC
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float FPKBMEIJEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x46F53E0", Offset = "0x46F3BE0", VA = "0x1846F53E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float MMGCKBBJJND
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x46F5410", Offset = "0x46F3C10", VA = "0x1846F5410", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float MMAFPKKGDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x46F53C0", Offset = "0x46F3BC0", VA = "0x1846F53C0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BCKKAIFBCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x46F53D0", Offset = "0x46F3BD0", VA = "0x1846F53D0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double BHCHPDOKCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x46F53F0", Offset = "0x46F3BF0", VA = "0x1846F53F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public MEKCOIDNMII()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LPHGEELGLMB
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] GPJANLJHPME;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int PPCKGPBBLCP;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int JEFPLDJMJDE;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger ABCMBKBOAFJ;

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LPHGEELGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x46F3E70", Offset = "0x46F2670", VA = "0x1846F3E70")]
	private static string EOENAFMMDNF(byte[] DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x46F3F70", Offset = "0x46F2770", VA = "0x1846F3F70")]
	public static string OPCCKPNHHLB(byte[] MIIBCOAJABM, bool NJCHAECDCAB)
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
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
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
